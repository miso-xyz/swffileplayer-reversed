Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Windows.Forms
Imports AxShockwaveFlashObjects
Imports Microsoft.VisualBasic
Public Class PlayForm
    Dim brdStyle As FormBorderStyle, winState As FormWindowState, objectTop As Integer, objectHeight As Integer, axShockwaveFlash As AxShockwaveFlash, SWF_FileName As String, SWF_FrameHeight As Integer, SWF_FrameWidth As Integer

    Private Sub aboutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles aboutToolStripMenuItem.Click
        MessageBox.Show("SWF File Player" & vbCrLf & "Freeware" & vbCrLf & "www.swffileplayer.com", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
    End Sub

    Private Sub closeButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles closeButton.Click
        Me.infoPanel.Visible = False
        Me.menuStrip.Enabled = True
    End Sub

    Private Sub closeSWF()
        Me.Text = "SWF File Player (www.swffileplayer.com)"
        Me.SWF_FileName = ""
        Me.SWF_FrameWidth = 0
        Me.SWF_FrameHeight = 0
        If Me.axShockwaveFlash IsNot Nothing Then
            MyBase.Controls.Remove(Me.axShockwaveFlash)
            Me.axShockwaveFlash.Dispose()
            Me.axShockwaveFlash = Nothing
        End If
        If Me.infoPanel.Visible Then
            Me.infoPanel.Visible = False
        End If
        Me.fileTextBox.Text = ""
        Me.signatureTextBox.Text = ""
        Me.versionTextBox.Text = ""
        Me.lengthTextBox.Text = ""
        Me.widthTextBox.Text = ""
        Me.heightTextBox.Text = ""
        Me.rateTextBox.Text = ""
        Me.countTextBox.Text = ""
        Me.playButton.Enabled = False
        Me.closeButton.Enabled = False
        If Not Me.menuStrip.Enabled Then
            Me.menuStrip.Enabled = True
        End If
    End Sub

    Private Sub closeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles closeToolStripMenuItem.Click
        closeSWF()
    End Sub

    Private Sub exitToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles exitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub fullScreenToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles fullScreenToolStripMenuItem.Click
        If Me.menuStrip.Visible Then
            Me.winState = MyBase.WindowState
            Me.brdStyle = MyBase.FormBorderStyle
            Me.TopMost = MyBase.TopMost
            Me.Bounds = MyBase.Bounds
            If Me.axShockwaveFlash IsNot Nothing Then
                Me.objectTop = Me.axShockwaveFlash.Top
                Me.objectHeight = Me.axShockwaveFlash.Height
            End If
            Me.menuStrip.Visible = False
            Dim maxValue As Integer = Integer.MaxValue
            Dim val As Integer = maxValue
            Dim val2 As Integer = maxValue
            Dim minValue As Integer = Integer.MinValue
            Dim num As Integer = minValue
            Dim num2 As Integer = minValue
            For Each screen As Screen In screen.AllScreens
                val2 = Math.Min(val2, screen.Bounds.X)
                val = Math.Min(val, screen.Bounds.Y)
                num2 = Math.Max(num2, screen.Bounds.Right)
                num = Math.Max(num, screen.Bounds.Bottom)
            Next
            Dim rectangle As Rectangle = New Rectangle(0, 0, num2, num)
            MyBase.FormBorderStyle = FormBorderStyle.None
            MyBase.Bounds = rectangle
            MyBase.TopMost = True
            If Me.axShockwaveFlash IsNot Nothing Then
                Me.axShockwaveFlash.Height = Me.axShockwaveFlash.Height + Me.axShockwaveFlash.Top
                Me.axShockwaveFlash.Top = 0
            End If
            Me.fullScreenToolStripMenuItem.Checked = True
            Me.fullScreenToolStripMenuItem1.Checked = True
            Return
        End If
        MyBase.WindowState = Me.winState
        MyBase.FormBorderStyle = Me.brdStyle
        MyBase.TopMost = Me.TopMost
        MyBase.Bounds = Me.Bounds
        Me.menuStrip.Visible = True
        If Me.axShockwaveFlash IsNot Nothing Then
            Me.axShockwaveFlash.Top = Me.objectTop
            Me.axShockwaveFlash.Height = Me.objectHeight
        End If
        Me.fullScreenToolStripMenuItem.Checked = False
        Me.fullScreenToolStripMenuItem1.Checked = False
    End Sub

    Private Sub homepageToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles homepageToolStripMenuItem.Click
        Process.Start("www.swffileplayer.com")
    End Sub

    Private Sub openSWF(ByVal filename As String)
        If Not File.Exists(filename) Then
            Return
        End If
        Me.fileTextBox.Text = "Reading..."
        Me.menuStrip.Enabled = False
        Me.infoPanel.Visible = True
        MyBase.Update()
        Me.PlayForm_Resize(Nothing, Nothing)
        MyBase.Update()
        Dim swffile As SWFFile = Nothing
        Try
            Me.fileTextBox.Text = filename
            swffile = New SWFFile(filename)
            Me.signatureTextBox.Text = swffile.Signature
            If Me.signatureTextBox.Text = "FWS" Then
                Me.signatureTextBox.Text = "FWS (uncompressed SWF)"
            End If
            If Me.signatureTextBox.Text = "CWS" Then
                Me.signatureTextBox.Text = "CWS (compressed SWF)"
            End If
            Me.versionTextBox.Text = String.Format("{0}", swffile.Version)
            Me.lengthTextBox.Text = String.Format("{0} bytes", swffile.FileLength)
            Me.widthTextBox.Text = String.Format("{0} twips ({1} pixels)", swffile.FrameWidth, swffile.FrameWidth / 20)
            Me.heightTextBox.Text = String.Format("{0} twips ({1} pixels)", swffile.FrameHeight, swffile.FrameHeight / 20)
            Me.rateTextBox.Text = String.Format("{0} fps", swffile.FrameRate)
            Me.countTextBox.Text = String.Format("{0}", swffile.FrameCount)
            Me.playButton.Enabled = True
            Me.closeButton.Enabled = True
            MyBase.Update()
            Me.SWF_FileName = swffile.FileName
            Me.SWF_FrameWidth = swffile.FrameWidth
            Me.SWF_FrameHeight = swffile.FrameHeight
        Catch ex As Exception
            Me.signatureTextBox.Text = "Error: " + ex.Message.ToLower()
            Me.playButton.Enabled = True
            Me.closeButton.Enabled = True
            Me.SWF_FileName = filename
        Finally
            If swffile IsNot Nothing Then
                swffile.Close()
            End If
        End Try
    End Sub

    Private Sub openToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles openToolStripMenuItem.Click, openToolStripMenuItem1.Click
        If Me.openFileDialog.ShowDialog() <> DialogResult.OK Then
            Return
        End If
        Me.closeSWF()
        Me.openSWF(Me.openFileDialog.FileName)
    End Sub

    Private Sub playButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles playButton.Click
        Dim typeFromProgID As Type = Type.GetTypeFromProgID("ShockwaveFlash.ShockwaveFlash")
        If typeFromProgID Is Nothing Then
            MessageBox.Show("No ShockwaveFlash Object installed." & vbLf & vbLf & "Please go to ""http://get.adobe.com/flashplayer/"" to install Adobe Flash Player.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            Return
        End If
        Me.infoPanel.Visible = False
        Me.menuStrip.Enabled = True
        If Me.SWF_FileName = "" Then
            Return
        End If
        Me.Text = Me.SWF_FileName
        Try
            Me.axShockwaveFlash = New AxShockwaveFlash()
            MyBase.Controls.Add(Me.axShockwaveFlash)
            Me.axShockwaveFlash.Enabled = True
            Me.axShockwaveFlash.Location = New Point(0, Me.menuStrip.Height)
            If Me.SWF_FrameWidth > 0 Then
                MyBase.Width = Me.SWF_FrameWidth / 20 + (MyBase.Width - MyBase.ClientSize.Width)
            End If
            If Me.SWF_FrameHeight > 0 Then
                MyBase.Height = Me.SWF_FrameHeight / 20 + Me.axShockwaveFlash.Top + (MyBase.Height - MyBase.ClientSize.Height)
            End If
            Me.PlayForm_Resize(Nothing, Nothing)
            Me.axShockwaveFlash.Movie = Me.SWF_FileName
            Me.axShockwaveFlash.Play()
        Catch
            MessageBox.Show("ShockwaveFlash Object Failed." & vbLf & vbLf & "Please go to ""http://get.adobe.com/flashplayer/"" to re-install Adobe Flash Player.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            Try
                If Me.axShockwaveFlash IsNot Nothing Then
                    MyBase.Controls.Remove(Me.axShockwaveFlash)
                    Me.axShockwaveFlash.Dispose()
                    Me.axShockwaveFlash = Nothing
                End If
            Catch
            End Try
        End Try
    End Sub

    Private Sub PlayForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        closeSWF()
    End Sub

    Private Sub PlayForm_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        If Me.axShockwaveFlash IsNot Nothing Then
            Me.axShockwaveFlash.Top = Me.menuStrip.Height
            Me.axShockwaveFlash.Left = 0
            Me.axShockwaveFlash.Width = MyBase.ClientSize.Width
            Me.axShockwaveFlash.Height = MyBase.ClientSize.Height - Me.axShockwaveFlash.Top
        End If
        If Me.infoPanel.Visible Then
            Me.infoPanel.Left = (MyBase.ClientSize.Width - Me.infoPanel.Width) / 2
            Me.infoPanel.Top = (MyBase.ClientSize.Height - Me.infoPanel.Height) / 2
        End If
    End Sub

    Private Sub PlayForm_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        If Me.openFileDialog.FileName <> "" Then
            Me.openSWF(Me.openFileDialog.FileName)
        End If
    End Sub
End Class