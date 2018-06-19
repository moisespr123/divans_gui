<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ActionGroupBox = New System.Windows.Forms.GroupBox()
        Me.ExtractRButton = New System.Windows.Forms.RadioButton()
        Me.CompressRButton = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.SpanishRButton = New System.Windows.Forms.RadioButton()
        Me.EnglishRButton = New System.Windows.Forms.RadioButton()
        Me.InputFileMessage = New System.Windows.Forms.Label()
        Me.InputFileTxt = New System.Windows.Forms.TextBox()
        Me.BrowseFileButton = New System.Windows.Forms.Button()
        Me.BrowseFolderButton = New System.Windows.Forms.Button()
        Me.BrowseFile2Button = New System.Windows.Forms.Button()
        Me.OutputFileTxt = New System.Windows.Forms.TextBox()
        Me.OutputFileMessage = New System.Windows.Forms.Label()
        Me.StartButton = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.AboutLabel = New System.Windows.Forms.Label()
        Me.VersionLabel = New System.Windows.Forms.Label()
        Me.ActionGroupBox.SuspendLayout
        Me.GroupBox2.SuspendLayout
        Me.SuspendLayout
        '
        'ActionGroupBox
        '
        Me.ActionGroupBox.Controls.Add(Me.ExtractRButton)
        Me.ActionGroupBox.Controls.Add(Me.CompressRButton)
        Me.ActionGroupBox.Location = New System.Drawing.Point(12, 12)
        Me.ActionGroupBox.Name = "ActionGroupBox"
        Me.ActionGroupBox.Size = New System.Drawing.Size(152, 52)
        Me.ActionGroupBox.TabIndex = 0
        Me.ActionGroupBox.TabStop = false
        Me.ActionGroupBox.Text = "Action"
        '
        'ExtractRButton
        '
        Me.ExtractRButton.AutoSize = true
        Me.ExtractRButton.Location = New System.Drawing.Point(83, 19)
        Me.ExtractRButton.Name = "ExtractRButton"
        Me.ExtractRButton.Size = New System.Drawing.Size(58, 17)
        Me.ExtractRButton.TabIndex = 1
        Me.ExtractRButton.TabStop = true
        Me.ExtractRButton.Text = "Extract"
        Me.ExtractRButton.UseVisualStyleBackColor = true
        '
        'CompressRButton
        '
        Me.CompressRButton.AutoSize = true
        Me.CompressRButton.Location = New System.Drawing.Point(6, 19)
        Me.CompressRButton.Name = "CompressRButton"
        Me.CompressRButton.Size = New System.Drawing.Size(71, 17)
        Me.CompressRButton.TabIndex = 0
        Me.CompressRButton.TabStop = true
        Me.CompressRButton.Text = "Compress"
        Me.CompressRButton.UseVisualStyleBackColor = true
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.SpanishRButton)
        Me.GroupBox2.Controls.Add(Me.EnglishRButton)
        Me.GroupBox2.Location = New System.Drawing.Point(170, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(152, 52)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = false
        Me.GroupBox2.Text = "Language / Idioma"
        '
        'SpanishRButton
        '
        Me.SpanishRButton.AutoSize = true
        Me.SpanishRButton.Location = New System.Drawing.Point(71, 19)
        Me.SpanishRButton.Name = "SpanishRButton"
        Me.SpanishRButton.Size = New System.Drawing.Size(63, 17)
        Me.SpanishRButton.TabIndex = 1
        Me.SpanishRButton.TabStop = true
        Me.SpanishRButton.Text = "Español"
        Me.SpanishRButton.UseVisualStyleBackColor = true
        '
        'EnglishRButton
        '
        Me.EnglishRButton.AutoSize = true
        Me.EnglishRButton.Location = New System.Drawing.Point(6, 19)
        Me.EnglishRButton.Name = "EnglishRButton"
        Me.EnglishRButton.Size = New System.Drawing.Size(59, 17)
        Me.EnglishRButton.TabIndex = 0
        Me.EnglishRButton.TabStop = true
        Me.EnglishRButton.Text = "English"
        Me.EnglishRButton.UseVisualStyleBackColor = true
        '
        'InputFileMessage
        '
        Me.InputFileMessage.AutoSize = true
        Me.InputFileMessage.Location = New System.Drawing.Point(9, 77)
        Me.InputFileMessage.Name = "InputFileMessage"
        Me.InputFileMessage.Size = New System.Drawing.Size(223, 13)
        Me.InputFileMessage.TabIndex = 3
        Me.InputFileMessage.Text = "Step 1: Browse for a file or folder to compress:"
        '
        'InputFileTxt
        '
        Me.InputFileTxt.Location = New System.Drawing.Point(12, 93)
        Me.InputFileTxt.Name = "InputFileTxt"
        Me.InputFileTxt.Size = New System.Drawing.Size(198, 20)
        Me.InputFileTxt.TabIndex = 4
        '
        'BrowseFileButton
        '
        Me.BrowseFileButton.Location = New System.Drawing.Point(216, 91)
        Me.BrowseFileButton.Name = "BrowseFileButton"
        Me.BrowseFileButton.Size = New System.Drawing.Size(88, 23)
        Me.BrowseFileButton.TabIndex = 5
        Me.BrowseFileButton.Text = "Browse File"
        Me.BrowseFileButton.UseVisualStyleBackColor = true
        '
        'BrowseFolderButton
        '
        Me.BrowseFolderButton.Location = New System.Drawing.Point(309, 91)
        Me.BrowseFolderButton.Name = "BrowseFolderButton"
        Me.BrowseFolderButton.Size = New System.Drawing.Size(104, 23)
        Me.BrowseFolderButton.TabIndex = 6
        Me.BrowseFolderButton.Text = "Browse Folder"
        Me.BrowseFolderButton.UseVisualStyleBackColor = true
        '
        'BrowseFile2Button
        '
        Me.BrowseFile2Button.Location = New System.Drawing.Point(216, 140)
        Me.BrowseFile2Button.Name = "BrowseFile2Button"
        Me.BrowseFile2Button.Size = New System.Drawing.Size(88, 23)
        Me.BrowseFile2Button.TabIndex = 9
        Me.BrowseFile2Button.Text = "Browse"
        Me.BrowseFile2Button.UseVisualStyleBackColor = true
        '
        'OutputFileTxt
        '
        Me.OutputFileTxt.Location = New System.Drawing.Point(12, 142)
        Me.OutputFileTxt.Name = "OutputFileTxt"
        Me.OutputFileTxt.Size = New System.Drawing.Size(198, 20)
        Me.OutputFileTxt.TabIndex = 8
        '
        'OutputFileMessage
        '
        Me.OutputFileMessage.AutoSize = true
        Me.OutputFileMessage.Location = New System.Drawing.Point(9, 126)
        Me.OutputFileMessage.Name = "OutputFileMessage"
        Me.OutputFileMessage.Size = New System.Drawing.Size(278, 13)
        Me.OutputFileMessage.TabIndex = 7
        Me.OutputFileMessage.Text = "Step 2: Browse for a location to save the compressed file:"
        '
        'StartButton
        '
        Me.StartButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 24!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.StartButton.Location = New System.Drawing.Point(12, 178)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.Size = New System.Drawing.Size(394, 40)
        Me.StartButton.TabIndex = 10
        Me.StartButton.Text = "Start!"
        Me.StartButton.UseVisualStyleBackColor = true
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'AboutLabel
        '
        Me.AboutLabel.AutoSize = true
        Me.AboutLabel.Location = New System.Drawing.Point(12, 225)
        Me.AboutLabel.Name = "AboutLabel"
        Me.AboutLabel.Size = New System.Drawing.Size(165, 13)
        Me.AboutLabel.TabIndex = 11
        Me.AboutLabel.Text = "GUI software by: Moisés Cardona"
        '
        'VersionLabel
        '
        Me.VersionLabel.AutoSize = true
        Me.VersionLabel.Location = New System.Drawing.Point(378, 225)
        Me.VersionLabel.Name = "VersionLabel"
        Me.VersionLabel.Size = New System.Drawing.Size(28, 13)
        Me.VersionLabel.TabIndex = 12
        Me.VersionLabel.Text = "v1.0"
        '
        'Form1
        '
        Me.AllowDrop = true
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(425, 247)
        Me.Controls.Add(Me.VersionLabel)
        Me.Controls.Add(Me.AboutLabel)
        Me.Controls.Add(Me.StartButton)
        Me.Controls.Add(Me.BrowseFile2Button)
        Me.Controls.Add(Me.OutputFileTxt)
        Me.Controls.Add(Me.OutputFileMessage)
        Me.Controls.Add(Me.BrowseFolderButton)
        Me.Controls.Add(Me.BrowseFileButton)
        Me.Controls.Add(Me.InputFileTxt)
        Me.Controls.Add(Me.InputFileMessage)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.ActionGroupBox)
        Me.MaximizeBox = false
        Me.Name = "Form1"
        Me.Text = "divANS Graphical User Interface"
        Me.ActionGroupBox.ResumeLayout(false)
        Me.ActionGroupBox.PerformLayout
        Me.GroupBox2.ResumeLayout(false)
        Me.GroupBox2.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents ActionGroupBox As GroupBox
    Friend WithEvents ExtractRButton As RadioButton
    Friend WithEvents CompressRButton As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents SpanishRButton As RadioButton
    Friend WithEvents EnglishRButton As RadioButton
    Friend WithEvents InputFileMessage As Label
    Friend WithEvents InputFileTxt As TextBox
    Friend WithEvents BrowseFileButton As Button
    Friend WithEvents BrowseFolderButton As Button
    Friend WithEvents BrowseFile2Button As Button
    Friend WithEvents OutputFileTxt As TextBox
    Friend WithEvents OutputFileMessage As Label
    Friend WithEvents StartButton As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents AboutLabel As Label
    Friend WithEvents VersionLabel As Label
End Class
