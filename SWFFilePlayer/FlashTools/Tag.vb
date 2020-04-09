Imports System
' Token: 0x02000007 RID: 7
Public Class Tag
    ' Token: 0x1700000E RID: 14
    ' (get) Token: 0x06000035 RID: 53 RVA: 0x000040DA File Offset: 0x000022DA
    Dim id_ As UShort, length_ As ULong
    Public ReadOnly Property ID As UShort
        Get
            Return Me.id_
        End Get
    End Property

    ' Token: 0x1700000F RID: 15
    ' (get) Token: 0x06000036 RID: 54 RVA: 0x000040E2 File Offset: 0x000022E2
    Public ReadOnly Property Length As ULong
        Get
            Return Me.length_
        End Get
    End Property

    ' Token: 0x06000037 RID: 55 RVA: 0x000040EC File Offset: 0x000022EC
    Public Sub New(ByVal swf As SWFReader)
        Dim num As UShort = swf.ReadUI16()
        Me.id_ = CUShort((num >> 6))
        Me.length_ = CULng(CLng((num And 63US)))
        If Me.Length = 63UL Then
            Me.length_ = CULng(swf.ReadUI32())
        End If
        For num2 As ULong = 0UL To Me.length_ - 1
            swf.Stream.ReadByte()
        Next
    End Sub

    ' Token: 0x06000038 RID: 56 RVA: 0x00004154 File Offset: 0x00002354
    Public Overloads Shared Function [GetType](ByVal id As UShort) As String
        Dim result As String = "(unknown)"
        Select Case id
            Case 0US
                result = "End (V1.0)"
            Case 1US
                result = "ShowFrame (V1.0)"
            Case 2US
                result = "DefineShape (V1.0)"
            Case 3US
                result = "FreeCharacter (V1.0)"
            Case 4US
                result = "PlaceObject (V1.0)"
            Case 5US
                result = "RemoveObject (V1.0)"
            Case 6US
                result = "DefineBits (V1.0)"
            Case 7US
                result = "DefineButton (V1.0)"
            Case 8US
                result = "JPEGTables (V1.0)"
            Case 9US
                result = "SetBackgroundColor (V1.0)"
            Case 10US
                result = "DefineFont (V1.0)"
            Case 11US
                result = "DefineText (V1.0)"
            Case 12US
                result = "DoAction (V1.0)"
            Case 13US
                result = "DefineFontInfo (V1.0)"
            Case 14US
                result = "DefineSound (V2.0)"
            Case 15US
                result = "StartSound (V2.0)"
            Case 16US
                result = "StopSound (V2.0)"
            Case 17US
                result = "DefineButtonSound (V2.0)"
            Case 18US
                result = "SoundStreamHead (V2.0)"
            Case 19US
                result = "SoundStreamBlock (V2.0)"
            Case 20US
                result = "DefineBitsLossless (V2.0)"
            Case 21US
                result = "DefineBitsJPEG2 (V2.0)"
            Case 22US
                result = "DefineShape2 (V2.0)"
            Case 23US
                result = "DefineButtonCxform (V2.0)"
            Case 24US
                result = "Protect (V2.0)"
            Case 25US
                result = "PathsArePostscript (V3.0)"
            Case 26US
                result = "PlaceObject2 (V3.0)"
            Case 28US
                result = "RemoveObject2 (V3.0)"
            Case 29US
                result = "SyncFrame (V3.0)"
            Case 31US
                result = "FreeAll (V3.0)"
            Case 32US
                result = "DefineShape3 (V3.0)"
            Case 33US
                result = "DefineText2 (V3.0)"
            Case 34US
                result = "DefineButton2 (V3.0)"
            Case 35US
                result = "DefineBitsJPEG3 (V3.0)"
            Case 36US
                result = "DefineBitsLossless2 (V3.0)"
            Case 37US
                result = "DefineEditText (V4.0)"
            Case 38US
                result = "DefineVideo (V4.0)"
            Case 39US
                result = "DefineSprite (V3.0)"
            Case 40US
                result = "NameCharacter (V3.0)"
            Case 41US
                result = "SerialNumber (V3.0)"
            Case 42US
                result = "DefineTextFormat (V3.0)"
            Case 43US
                result = "FrameLabel (V3.0)"
            Case 45US
                result = "SoundStreamHead2 (V3.0)"
            Case 46US
                result = "DefineMorphShape (V3.0)"
            Case 47US
                result = "GenerateFrame (V3.0)"
            Case 48US
                result = "DefineFont2 (V3.0)"
            Case 49US
                result = "GeneratorCommand (V3.0)"
            Case 50US
                result = "DefineCommandObject (V5.0)"
            Case 51US
                result = "CharacterSet (V5.0)"
            Case 52US
                result = "ExternalFont (V5.0)"
            Case 56US
                result = "Export (V5.0)"
            Case 57US
                result = "Import (V5.0)"
            Case 58US
                result = "ProtectDebug (V5.0)"
            Case 59US
                result = "DoInitAction (V6.0)"
            Case 60US
                result = "DefineVideoStream (V6.0)"
            Case 61US
                result = "VideoFrame (V6.0)"
            Case 62US
                result = "DefineFontInfo2 (V6.0)"
            Case 64US
                result = "ProtectDebug2 (V6.0)"
            Case 65US
                result = "ScriptLimits (V7.0)"
            Case 66US
                result = "SetTabIndex (V7.0)"
            Case 69US
                result = "FileAttributes (V8.0)"
            Case 70US
                result = "PlaceObject3 (V8.0)"
            Case 71US
                result = "Import2 (V8.0)"
            Case 73US
                result = "DefineFontAlignZones (V8.0)"
            Case 74US
                result = "CSMTextSettings (V8.0)"
            Case 75US
                result = "DefineFont3 (V8.0)"
            Case 77US
                result = "Metadata (V8.0)"
            Case 78US
                result = "DefineScalingGrid (V8.0)"
            Case 83US
                result = "DefineShape4 (V8.0)"
            Case 84US
                result = "DefineMorphShape2 (V8.0)"
        End Select
        Return result
    End Function
End Class

