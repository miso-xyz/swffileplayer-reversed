Imports System

' Token: 0x02000004 RID: 4
Public Class Rect
    Dim xMin_, xMax_, yMin_, yMax_
    ' Token: 0x17000001 RID: 1
    ' (get) Token: 0x06000012 RID: 18 RVA: 0x00003B4F File Offset: 0x00001D4F
    Public ReadOnly Property XMin As Integer
        Get
            Return Me.xMin_
        End Get
    End Property

    ' Token: 0x17000002 RID: 2
    ' (get) Token: 0x06000013 RID: 19 RVA: 0x00003B57 File Offset: 0x00001D57
    Public ReadOnly Property XMax As Integer
        Get
            Return Me.xMax_
        End Get
    End Property

    ' Token: 0x17000003 RID: 3
    ' (get) Token: 0x06000014 RID: 20 RVA: 0x00003B5F File Offset: 0x00001D5F
    Public ReadOnly Property YMin As Integer
        Get
            Return Me.yMin_
        End Get
    End Property

    ' Token: 0x17000004 RID: 4
    ' (get) Token: 0x06000015 RID: 21 RVA: 0x00003B67 File Offset: 0x00001D67
    Public ReadOnly Property YMax As Integer
        Get
            Return Me.yMax_
        End Get
    End Property

    ' Token: 0x06000016 RID: 22 RVA: 0x00003B70 File Offset: 0x00001D70
    Public Sub New(ByVal swf As SWFReader)
        Dim nBits As Integer = CInt(swf.ReadUB(5))
        Me.xMin_ = swf.ReadSB(nBits)
        Me.xMax_ = swf.ReadSB(nBits)
        Me.yMin_ = swf.ReadSB(nBits)
        Me.yMax_ = swf.ReadSB(nBits)
    End Sub
End Class

