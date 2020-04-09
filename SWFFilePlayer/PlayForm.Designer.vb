Imports System.Windows.Forms
<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class PlayForm
    Inherits Form
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso Me.components IsNot Nothing Then
            Me.components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub
    ' Token: 0x06000010 RID: 16 RVA: 0x00002954 File Offset: 0x00000B54
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PlayForm))
        Me.menuStrip = New System.Windows.Forms.MenuStrip()
        Me.fileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.openToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.closeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.fullScreenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.exitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.helpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.homepageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.aboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.openFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.infoPanel = New System.Windows.Forms.Panel()
        Me.closeButton = New System.Windows.Forms.Button()
        Me.playButton = New System.Windows.Forms.Button()
        Me.countTextBox = New System.Windows.Forms.TextBox()
        Me.countLabel = New System.Windows.Forms.Label()
        Me.rateTextBox = New System.Windows.Forms.TextBox()
        Me.rateLabel = New System.Windows.Forms.Label()
        Me.heightTextBox = New System.Windows.Forms.TextBox()
        Me.heightLabel = New System.Windows.Forms.Label()
        Me.widthTextBox = New System.Windows.Forms.TextBox()
        Me.widthLabel = New System.Windows.Forms.Label()
        Me.lengthTextBox = New System.Windows.Forms.TextBox()
        Me.lengthLabel = New System.Windows.Forms.Label()
        Me.versionTextBox = New System.Windows.Forms.TextBox()
        Me.versionLabel = New System.Windows.Forms.Label()
        Me.signatureTextBox = New System.Windows.Forms.TextBox()
        Me.signatureLabel = New System.Windows.Forms.Label()
        Me.fileTextBox = New System.Windows.Forms.TextBox()
        Me.fileLabel = New System.Windows.Forms.Label()
        Me.openToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.closeToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator()
        Me.fullScreenToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.HgjToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuStrip.SuspendLayout()
        Me.infoPanel.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'menuStrip
        '
        Me.menuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.fileToolStripMenuItem, Me.helpToolStripMenuItem})
        Me.menuStrip.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip.Name = "menuStrip"
        Me.menuStrip.Size = New System.Drawing.Size(664, 24)
        Me.menuStrip.TabIndex = 0
        Me.menuStrip.Text = "menuStrip1"
        '
        'fileToolStripMenuItem
        '
        Me.fileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.openToolStripMenuItem, Me.closeToolStripMenuItem, Me.toolStripMenuItem1, Me.fullScreenToolStripMenuItem, Me.toolStripMenuItem3, Me.exitToolStripMenuItem})
        Me.fileToolStripMenuItem.Name = "fileToolStripMenuItem"
        Me.fileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.fileToolStripMenuItem.Text = "File"
        '
        'openToolStripMenuItem
        '
        Me.openToolStripMenuItem.Name = "openToolStripMenuItem"
        Me.openToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.openToolStripMenuItem.Text = "Open..."
        '
        'closeToolStripMenuItem
        '
        Me.closeToolStripMenuItem.Name = "closeToolStripMenuItem"
        Me.closeToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.closeToolStripMenuItem.Text = "Close"
        '
        'toolStripMenuItem1
        '
        Me.toolStripMenuItem1.Name = "toolStripMenuItem1"
        Me.toolStripMenuItem1.Size = New System.Drawing.Size(149, 6)
        '
        'fullScreenToolStripMenuItem
        '
        Me.fullScreenToolStripMenuItem.Name = "fullScreenToolStripMenuItem"
        Me.fullScreenToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.fullScreenToolStripMenuItem.Text = "Full Screen"
        '
        'toolStripMenuItem3
        '
        Me.toolStripMenuItem3.Name = "toolStripMenuItem3"
        Me.toolStripMenuItem3.Size = New System.Drawing.Size(149, 6)
        '
        'exitToolStripMenuItem
        '
        Me.exitToolStripMenuItem.Name = "exitToolStripMenuItem"
        Me.exitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.exitToolStripMenuItem.Text = "Exit"
        '
        'helpToolStripMenuItem
        '
        Me.helpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.homepageToolStripMenuItem, Me.toolStripMenuItem2, Me.aboutToolStripMenuItem})
        Me.helpToolStripMenuItem.Name = "helpToolStripMenuItem"
        Me.helpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.helpToolStripMenuItem.Text = "Help"
        '
        'homepageToolStripMenuItem
        '
        Me.homepageToolStripMenuItem.Name = "homepageToolStripMenuItem"
        Me.homepageToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.homepageToolStripMenuItem.Text = "Homepage"
        '
        'toolStripMenuItem2
        '
        Me.toolStripMenuItem2.Name = "toolStripMenuItem2"
        Me.toolStripMenuItem2.Size = New System.Drawing.Size(130, 6)
        '
        'aboutToolStripMenuItem
        '
        Me.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem"
        Me.aboutToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.aboutToolStripMenuItem.Text = "About"
        '
        'openFileDialog
        '
        Me.openFileDialog.DefaultExt = "swf"
        Me.openFileDialog.Filter = "SWF files (*.swf)|*.swf"
        '
        'infoPanel
        '
        Me.infoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.infoPanel.Controls.Add(Me.closeButton)
        Me.infoPanel.Controls.Add(Me.playButton)
        Me.infoPanel.Controls.Add(Me.countTextBox)
        Me.infoPanel.Controls.Add(Me.countLabel)
        Me.infoPanel.Controls.Add(Me.rateTextBox)
        Me.infoPanel.Controls.Add(Me.rateLabel)
        Me.infoPanel.Controls.Add(Me.heightTextBox)
        Me.infoPanel.Controls.Add(Me.heightLabel)
        Me.infoPanel.Controls.Add(Me.widthTextBox)
        Me.infoPanel.Controls.Add(Me.widthLabel)
        Me.infoPanel.Controls.Add(Me.lengthTextBox)
        Me.infoPanel.Controls.Add(Me.lengthLabel)
        Me.infoPanel.Controls.Add(Me.versionTextBox)
        Me.infoPanel.Controls.Add(Me.versionLabel)
        Me.infoPanel.Controls.Add(Me.signatureTextBox)
        Me.infoPanel.Controls.Add(Me.signatureLabel)
        Me.infoPanel.Controls.Add(Me.fileTextBox)
        Me.infoPanel.Controls.Add(Me.fileLabel)
        Me.infoPanel.Location = New System.Drawing.Point(117, 68)
        Me.infoPanel.Name = "infoPanel"
        Me.infoPanel.Size = New System.Drawing.Size(460, 292)
        Me.infoPanel.TabIndex = 1
        Me.infoPanel.Visible = False
        '
        'closeButton
        '
        Me.closeButton.Location = New System.Drawing.Point(363, 256)
        Me.closeButton.Name = "closeButton"
        Me.closeButton.Size = New System.Drawing.Size(75, 25)
        Me.closeButton.TabIndex = 17
        Me.closeButton.Text = "Close"
        Me.closeButton.UseVisualStyleBackColor = True
        '
        'playButton
        '
        Me.playButton.Location = New System.Drawing.Point(266, 256)
        Me.playButton.Name = "playButton"
        Me.playButton.Size = New System.Drawing.Size(75, 25)
        Me.playButton.TabIndex = 16
        Me.playButton.Text = "Play"
        Me.playButton.UseVisualStyleBackColor = True
        '
        'countTextBox
        '
        Me.countTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.countTextBox.Location = New System.Drawing.Point(102, 218)
        Me.countTextBox.Name = "countTextBox"
        Me.countTextBox.ReadOnly = True
        Me.countTextBox.Size = New System.Drawing.Size(105, 20)
        Me.countTextBox.TabIndex = 15
        Me.countTextBox.TabStop = False
        '
        'countLabel
        '
        Me.countLabel.AutoSize = True
        Me.countLabel.Location = New System.Drawing.Point(13, 221)
        Me.countLabel.Name = "countLabel"
        Me.countLabel.Size = New System.Drawing.Size(70, 13)
        Me.countLabel.TabIndex = 14
        Me.countLabel.Text = "Frame Count:"
        '
        'rateTextBox
        '
        Me.rateTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.rateTextBox.Location = New System.Drawing.Point(102, 189)
        Me.rateTextBox.Name = "rateTextBox"
        Me.rateTextBox.ReadOnly = True
        Me.rateTextBox.Size = New System.Drawing.Size(105, 20)
        Me.rateTextBox.TabIndex = 13
        Me.rateTextBox.TabStop = False
        '
        'rateLabel
        '
        Me.rateLabel.AutoSize = True
        Me.rateLabel.Location = New System.Drawing.Point(13, 192)
        Me.rateLabel.Name = "rateLabel"
        Me.rateLabel.Size = New System.Drawing.Size(65, 13)
        Me.rateLabel.TabIndex = 12
        Me.rateLabel.Text = "Frame Rate:"
        '
        'heightTextBox
        '
        Me.heightTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.heightTextBox.Location = New System.Drawing.Point(102, 159)
        Me.heightTextBox.Name = "heightTextBox"
        Me.heightTextBox.ReadOnly = True
        Me.heightTextBox.Size = New System.Drawing.Size(181, 20)
        Me.heightTextBox.TabIndex = 11
        Me.heightTextBox.TabStop = False
        '
        'heightLabel
        '
        Me.heightLabel.AutoSize = True
        Me.heightLabel.Location = New System.Drawing.Point(13, 163)
        Me.heightLabel.Name = "heightLabel"
        Me.heightLabel.Size = New System.Drawing.Size(73, 13)
        Me.heightLabel.TabIndex = 10
        Me.heightLabel.Text = "Frame Height:"
        '
        'widthTextBox
        '
        Me.widthTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.widthTextBox.Location = New System.Drawing.Point(102, 130)
        Me.widthTextBox.Name = "widthTextBox"
        Me.widthTextBox.ReadOnly = True
        Me.widthTextBox.Size = New System.Drawing.Size(181, 20)
        Me.widthTextBox.TabIndex = 9
        Me.widthTextBox.TabStop = False
        '
        'widthLabel
        '
        Me.widthLabel.AutoSize = True
        Me.widthLabel.Location = New System.Drawing.Point(13, 133)
        Me.widthLabel.Name = "widthLabel"
        Me.widthLabel.Size = New System.Drawing.Size(70, 13)
        Me.widthLabel.TabIndex = 8
        Me.widthLabel.Text = "Frame Width:"
        '
        'lengthTextBox
        '
        Me.lengthTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.lengthTextBox.Location = New System.Drawing.Point(102, 101)
        Me.lengthTextBox.Name = "lengthTextBox"
        Me.lengthTextBox.ReadOnly = True
        Me.lengthTextBox.Size = New System.Drawing.Size(105, 20)
        Me.lengthTextBox.TabIndex = 7
        Me.lengthTextBox.TabStop = False
        '
        'lengthLabel
        '
        Me.lengthLabel.AutoSize = True
        Me.lengthLabel.Location = New System.Drawing.Point(13, 104)
        Me.lengthLabel.Name = "lengthLabel"
        Me.lengthLabel.Size = New System.Drawing.Size(62, 13)
        Me.lengthLabel.TabIndex = 6
        Me.lengthLabel.Text = "File Length:"
        '
        'versionTextBox
        '
        Me.versionTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.versionTextBox.Location = New System.Drawing.Point(102, 72)
        Me.versionTextBox.Name = "versionTextBox"
        Me.versionTextBox.ReadOnly = True
        Me.versionTextBox.Size = New System.Drawing.Size(105, 20)
        Me.versionTextBox.TabIndex = 5
        Me.versionTextBox.TabStop = False
        '
        'versionLabel
        '
        Me.versionLabel.AutoSize = True
        Me.versionLabel.Location = New System.Drawing.Point(13, 75)
        Me.versionLabel.Name = "versionLabel"
        Me.versionLabel.Size = New System.Drawing.Size(45, 13)
        Me.versionLabel.TabIndex = 4
        Me.versionLabel.Text = "Version:"
        '
        'signatureTextBox
        '
        Me.signatureTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.signatureTextBox.Location = New System.Drawing.Point(102, 42)
        Me.signatureTextBox.Name = "signatureTextBox"
        Me.signatureTextBox.ReadOnly = True
        Me.signatureTextBox.Size = New System.Drawing.Size(181, 20)
        Me.signatureTextBox.TabIndex = 3
        Me.signatureTextBox.TabStop = False
        '
        'signatureLabel
        '
        Me.signatureLabel.AutoSize = True
        Me.signatureLabel.Location = New System.Drawing.Point(13, 46)
        Me.signatureLabel.Name = "signatureLabel"
        Me.signatureLabel.Size = New System.Drawing.Size(55, 13)
        Me.signatureLabel.TabIndex = 2
        Me.signatureLabel.Text = "Signature:"
        '
        'fileTextBox
        '
        Me.fileTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.fileTextBox.Location = New System.Drawing.Point(102, 13)
        Me.fileTextBox.Name = "fileTextBox"
        Me.fileTextBox.ReadOnly = True
        Me.fileTextBox.Size = New System.Drawing.Size(336, 20)
        Me.fileTextBox.TabIndex = 1
        Me.fileTextBox.TabStop = False
        '
        'fileLabel
        '
        Me.fileLabel.AutoSize = True
        Me.fileLabel.Location = New System.Drawing.Point(13, 16)
        Me.fileLabel.Name = "fileLabel"
        Me.fileLabel.Size = New System.Drawing.Size(26, 13)
        Me.fileLabel.TabIndex = 0
        Me.fileLabel.Text = "File:"
        '
        'openToolStripMenuItem1
        '
        Me.openToolStripMenuItem1.Name = "openToolStripMenuItem1"
        Me.openToolStripMenuItem1.Size = New System.Drawing.Size(131, 22)
        Me.openToolStripMenuItem1.Text = "Open..."
        '
        'closeToolStripMenuItem1
        '
        Me.closeToolStripMenuItem1.Name = "closeToolStripMenuItem1"
        Me.closeToolStripMenuItem1.Size = New System.Drawing.Size(131, 22)
        Me.closeToolStripMenuItem1.Text = "Close"
        '
        'toolStripMenuItem4
        '
        Me.toolStripMenuItem4.Name = "toolStripMenuItem4"
        Me.toolStripMenuItem4.Size = New System.Drawing.Size(128, 6)
        '
        'fullScreenToolStripMenuItem1
        '
        Me.fullScreenToolStripMenuItem1.Name = "fullScreenToolStripMenuItem1"
        Me.fullScreenToolStripMenuItem1.Size = New System.Drawing.Size(131, 22)
        Me.fullScreenToolStripMenuItem1.Text = "Full Screen"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.openToolStripMenuItem1, Me.closeToolStripMenuItem1, Me.toolStripMenuItem4, Me.fullScreenToolStripMenuItem1})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(132, 76)
        '
        'HgjToolStripMenuItem
        '
        Me.HgjToolStripMenuItem.Name = "HgjToolStripMenuItem"
        Me.HgjToolStripMenuItem.Size = New System.Drawing.Size(91, 22)
        Me.HgjToolStripMenuItem.Text = "hgj"
        '
        'PlayForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(664, 499)
        Me.Controls.Add(Me.infoPanel)
        Me.Controls.Add(Me.menuStrip)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.menuStrip
        Me.Name = "PlayForm"
        Me.Text = "SWF File Player (www.swffileplayer.com)"
        Me.menuStrip.ResumeLayout(False)
        Me.menuStrip.PerformLayout()
        Me.infoPanel.ResumeLayout(False)
        Me.infoPanel.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents fileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents openToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents closeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents fullScreenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents exitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents helpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents homepageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents aboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents toolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents toolStripMenuItem3 As ToolStripSeparator
    Friend WithEvents closeButton As Button
    Friend WithEvents playButton As Button
    Friend WithEvents fileLabel As Label
    Friend WithEvents signatureLabel As Label
    Friend WithEvents versionLabel As Label
    Friend WithEvents lengthLabel As Label
    Friend WithEvents widthLabel As Label
    Friend WithEvents heightLabel As Label
    Friend WithEvents rateLabel As Label
    Friend WithEvents countLabel As Label
    Friend WithEvents countTextBox As TextBox
    Friend WithEvents rateTextBox As TextBox
    Friend WithEvents heightTextBox As TextBox
    Friend WithEvents widthTextBox As TextBox
    Friend WithEvents lengthTextBox As TextBox
    Friend WithEvents versionTextBox As TextBox
    Friend WithEvents signatureTextBox As TextBox
    Friend WithEvents fileTextBox As TextBox
    Friend WithEvents openToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents closeToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents fullScreenToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents toolStripMenuItem4 As ToolStripSeparator
    Friend WithEvents infoPanel As Panel
    Friend WithEvents openFileDialog As OpenFileDialog
    Friend WithEvents menuStrip As MenuStrip
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Private components As System.ComponentModel.IContainer
    Friend WithEvents HgjToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
