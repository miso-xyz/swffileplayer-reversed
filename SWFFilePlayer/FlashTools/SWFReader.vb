Imports System
Imports System.IO
Imports System.Text
' Token: 0x02000006 RID: 6
Public Class SWFReader
    ' Token: 0x1700000D RID: 13
    ' (get) Token: 0x06000023 RID: 35 RVA: 0x00003DA0 File Offset: 0x00001FA0
    ' (set) Token: 0x06000024 RID: 36 RVA: 0x00003DA8 File Offset: 0x00001FA8
    Dim bitPosition As Byte, currentByte As Byte, stream_ As Stream
    Public Property Stream As Stream
        Get
            Return Me.stream_
        End Get
        Set(ByVal value As Stream)
            Me.stream_ = value
        End Set
    End Property

    ' Token: 0x06000025 RID: 37 RVA: 0x00003DB4 File Offset: 0x00001FB4
    Shared Sub New()
        For b As Byte = 0 To 32 - 1
            SWFReader.bitValues(CInt(b)) = 1UI << CInt(b)
        Next
        SWFReader.powers = New Single(31) {}
        For b2 As Byte = 0 To 32 - 1
            SWFReader.powers(CInt(b2)) = CSng(Math.Pow(2.0, CDbl((b2 - 16))))
        Next
    End Sub

    ' Token: 0x06000026 RID: 38 RVA: 0x00003E1D File Offset: 0x0000201D
    Public Sub New(ByVal stream As Stream)
        Me.Stream = stream
    End Sub

    ' Token: 0x06000027 RID: 39 RVA: 0x00003E2C File Offset: 0x0000202C
    Public Function ReadByte() As Byte
        Dim num As Integer = Me.Stream.ReadByte()
        Me.bitPosition = 8
        If num = -1 Then
            Throw New ApplicationException("Attempted to read past end of stream")
        End If
        Return CByte(num)
    End Function

    ' Token: 0x06000028 RID: 40 RVA: 0x00003E60 File Offset: 0x00002060
    Public Function ReadBit() As Boolean
        If Me.bitPosition > 7 Then
            Me.currentByte = Me.ReadByte()
            Me.bitPosition = 0
        End If
        Dim result As Boolean = (CUInt(Me.currentByte) And SWFReader.bitValues(CInt((7 - Me.bitPosition)))) <> 0UI
        Me.bitPosition += 1
        Return result
    End Function

    ' Token: 0x06000029 RID: 41 RVA: 0x00003EB5 File Offset: 0x000020B5
    Public Function ReadUI8() As Byte
        Return Me.ReadByte()
    End Function

    ' Token: 0x0600002A RID: 42 RVA: 0x00003EC0 File Offset: 0x000020C0
    Public Function ReadUI8(ByVal n As Integer) As Byte()
        Dim array As Byte() = New Byte(n - 1) {}
        For i As Integer = 0 To n - 1
            array(i) = Me.ReadUI8()
        Next
        Return array
    End Function

    ' Token: 0x0600002B RID: 43 RVA: 0x00003EEA File Offset: 0x000020EA
    Public Function ReadSI8() As SByte
        Return CSByte(Me.ReadByte())
    End Function

    ' Token: 0x0600002C RID: 44 RVA: 0x00003EF4 File Offset: 0x000020F4
    Public Function ReadUI16() As UShort
        Dim num As UShort = 0US
        num = num Or CUShort(Me.ReadByte())
        Return num Or CUShort((Me.ReadByte() << 8))
    End Function

    ' Token: 0x0600002D RID: 45 RVA: 0x00003F1B File Offset: 0x0000211B
    Public Function ReadSI16() As Short
        Return CShort(Me.ReadUI16())
    End Function

    ' Token: 0x0600002E RID: 46 RVA: 0x00003F24 File Offset: 0x00002124
    Public Function ReadUI32() As UInteger
        Dim num As UInteger = 0UI
        num = num Or CUInt(Me.ReadByte())
        num = num Or CUInt((CUInt(Me.ReadByte()) << 8))
        num = num Or CUInt((CUInt(Me.ReadByte()) << 16))
        Return num Or CUInt((CUInt(Me.ReadByte()) << 24))
    End Function

    ' Token: 0x0600002F RID: 47 RVA: 0x00003F60 File Offset: 0x00002160
    Public Function ReadSI32() As Integer
        Return CInt(Me.ReadUI32())
    End Function

    ' Token: 0x06000030 RID: 48 RVA: 0x00003F68 File Offset: 0x00002168
    Public Function ReadFIXED() As Single
        Dim num As Single = 0.0F
        num += CSng(Me.ReadByte()) * SWFReader.powers(0)
        num += CSng(Me.ReadByte()) * SWFReader.powers(7)
        num += CSng(Me.ReadByte()) * SWFReader.powers(15)
        Return num + CSng(Me.ReadByte()) * SWFReader.powers(31)
    End Function

    ' Token: 0x06000031 RID: 49 RVA: 0x00003FCC File Offset: 0x000021CC
    Public Function ReadSTRING() As String
        Dim text As String = String.Empty
        Dim array As Byte() = New Byte(0) {}
        Dim array2 As Byte() = array
        Do
            array2(0) = Me.ReadByte()
            If array2(0) <> 0 Then
                text += Encoding.ASCII.GetString(array2)
            End If
        Loop While array2(0) <> 0
        Return text
    End Function

    ' Token: 0x06000032 RID: 50 RVA: 0x00004010 File Offset: 0x00002210
    Public Function ReadUB(ByVal nBits As Integer) As UInteger
        Dim num As UInteger = 0UI
        If nBits > 0 Then
            For i As Integer = nBits - 1 To -1 + 1 Step -1
                If Me.ReadBit() Then
                    num = num Or SWFReader.bitValues(i)
                End If
            Next
        End If
        Return num
    End Function

    ' Token: 0x06000033 RID: 51 RVA: 0x00004044 File Offset: 0x00002244
    Public Function ReadSB(ByVal nBits As Integer) As Integer
        Dim num As Integer = 0
        If nBits > 0 Then
            If Me.ReadBit() Then
                num -= CInt(SWFReader.bitValues(nBits - 1))
            End If
            For i As Integer = nBits - 2 To -1 + 1 Step -1
                If Me.ReadBit() Then
                    num = num Or CInt(SWFReader.bitValues(i))
                End If
            Next
        End If
        Return num
    End Function

    ' Token: 0x06000034 RID: 52 RVA: 0x0000408C File Offset: 0x0000228C
    Public Function ReadFB(ByVal nBits As Integer) As Single
        Dim num As Single = 0.0F
        If nBits > 0 Then
            If Me.ReadBit() Then
                num -= SWFReader.powers(nBits - 1)
            End If
            For i As Integer = nBits - 1 To 0 + 1 Step -1
                If Me.ReadBit() Then
                    num += SWFReader.powers(i - 1)
                End If
            Next
        End If
        Return num
    End Function

    ' Token: 0x0400003F RID: 63
    Private Shared bitValues As UInteger() = New UInteger(31) {}

    ' Token: 0x04000040 RID: 64
    Private Shared powers As Single()
End Class

