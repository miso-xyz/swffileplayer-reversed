Imports System
Imports System.IO
Imports System.Text
Imports ICSharpCode.SharpZipLib.Zip.Compression.Streams
' Token: 0x02000005 RID: 5
Public Class SWFFile
    ' Token: 0x17000005 RID: 5
    ' (get) Token: 0x06000017 RID: 23 RVA: 0x00003BBF File Offset: 0x00001DBF
    Dim fileLength_ As UInteger, fileName_ As String, frameCount_ As UShort, frameHeight_ As Integer, frameRate_ As Single, frameWidth_ As Integer, swf_ As SWFReader, version_ As Byte, signature_ As String, stream_ As Stream
    Public ReadOnly Property FileName As String
        Get
            Return Me.fileName_
        End Get
    End Property

    ' Token: 0x17000006 RID: 6
    ' (get) Token: 0x06000018 RID: 24 RVA: 0x00003BC7 File Offset: 0x00001DC7
    Public ReadOnly Property Signature As String
        Get
            Return Me.Signature_
        End Get
    End Property

    ' Token: 0x17000007 RID: 7
    ' (get) Token: 0x06000019 RID: 25 RVA: 0x00003BCF File Offset: 0x00001DCF
    Public ReadOnly Property Version As Byte
        Get
            Return Me.Version_
        End Get
    End Property

    ' Token: 0x17000008 RID: 8
    ' (get) Token: 0x0600001A RID: 26 RVA: 0x00003BD7 File Offset: 0x00001DD7
    Public ReadOnly Property FileLength As UInteger
        Get
            Return Me.FileLength_
        End Get
    End Property

    ' Token: 0x17000009 RID: 9
    ' (get) Token: 0x0600001B RID: 27 RVA: 0x00003BDF File Offset: 0x00001DDF
    Public ReadOnly Property FrameWidth As Integer
        Get
            Return Me.frameWidth_
        End Get
    End Property

    ' Token: 0x1700000A RID: 10
    ' (get) Token: 0x0600001C RID: 28 RVA: 0x00003BE7 File Offset: 0x00001DE7
    Public ReadOnly Property FrameHeight As Integer
        Get
            Return Me.FrameHeight_
        End Get
    End Property

    ' Token: 0x1700000B RID: 11
    ' (get) Token: 0x0600001D RID: 29 RVA: 0x00003BEF File Offset: 0x00001DEF
    Public ReadOnly Property FrameRate As Single
        Get
            Return Me.FrameRate_
        End Get
    End Property

    ' Token: 0x1700000C RID: 12
    ' (get) Token: 0x0600001E RID: 30 RVA: 0x00003BF7 File Offset: 0x00001DF7
    Public ReadOnly Property FrameCount As UShort
        Get
            Return Me.FrameCount_
        End Get
    End Property

    ' Token: 0x0600001F RID: 31 RVA: 0x00003C00 File Offset: 0x00001E00
    Public Sub New(ByVal fileName As String)
        Me.fileName_ = fileName
        Me.stream_ = New FileStream(Me.FileName, FileMode.Open, FileAccess.Read)
        Me.swf_ = New SWFReader(Me.stream_)
        If Me.ReadHeader() Then
            Me.IdentifyTags()
        End If
    End Sub

    ' Token: 0x06000020 RID: 32 RVA: 0x00003C64 File Offset: 0x00001E64
    Private Function ReadHeader() As Boolean
        Me.signature_ = Encoding.ASCII.GetString(Me.swf_.ReadUI8(3))
        If Me.Signature <> "FWS" AndAlso Me.Signature <> "CWS" Then
            Return False
        End If
        Me.version_ = Me.swf_.ReadUI8()
        Me.fileLength_ = Me.swf_.ReadUI32()
        If Me.Signature = "CWS" Then
            Dim inflaterInputStream As InflaterInputStream = New InflaterInputStream(Me.stream_)
            Me.swf_.Stream = inflaterInputStream
        End If
        Dim rect As Rect = New Rect(Me.swf_)
        Me.frameWidth_ = rect.XMax
        Me.frameHeight_ = rect.YMax
        Dim num As UShort = CUShort(Me.swf_.ReadUI8())
        Dim num2 As UShort = CUShort(Me.swf_.ReadUI8())
        Me.frameRate_ = Convert.ToSingle(String.Format("{0}.{1}", num2, num))
        Me.frameCount_ = Me.swf_.ReadUI16()
        Return True
    End Function

    ' Token: 0x06000021 RID: 33 RVA: 0x00003D70 File Offset: 0x00001F70
    Private Sub IdentifyTags()
        Dim tag As Tag
        Do
            tag = New Tag(Me.swf_)
        Loop While tag.ID <> 0US
    End Sub

    ' Token: 0x06000022 RID: 34 RVA: 0x00003D93 File Offset: 0x00001F93
    Public Sub Close()
        Me.stream_.Close()
    End Sub
End Class