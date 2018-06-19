Public Class Form1
    Private OutputFileName As String = String.Empty
    Private divans_version As String = "001"
    Private Running As Boolean = False

    Private AboutString As String = My.Resources.About
    Private ActionGroupBoxString As String = My.Resources.Action
    Private BrowseFileButtonString As String = My.Resources.BrowseFileButton
    Private BrowseFolderButtonString As String = My.Resources.BrowseFolderButton
    Private BrowseOutputButton As String = My.Resources.BrowseOutputButton
    Private CompressFolderSelectedMessage As String = My.Resources.CompressFolderSelectedMessage
    Private CompressInputMessage As String = My.Resources.CompressInputMessage
    Private CompressOutputMessage As String = My.Resources.CompressOutputMessage
    Private CompressRButtonString As String = My.Resources.CompressRButton
    Private CompressingString As String = My.Resources.Compressing
    Private ExtractFolderSelectedMessage As String = My.Resources.ExtractFolderSelectedMessage
    Private ExtractInputMessage As String = My.Resources.ExtractInputMessage
    Private ExtractOutputMessage As String = My.Resources.ExtractOutputMessage
    Private ExtractRButtonString As String = My.Resources.ExtractRButton
    Private ExtractingString As String = My.Resources.Extracting
    Private StartButtonString As String = My.Resources.StartButton
    Private Finished As String = My.Resources.Finished
    Private FormName As String = My.Resources.FormName

    Private Sub SetOutputFilename()
        If CompressRButton.Checked Then OutputFileTxt.Text = OutputFileName + divans_version
    End Sub
    Private Sub SetOutputFileNamePathWithoutExtension(Path As String)
        OutputFileTxt.Text = My.Computer.FileSystem.GetParentPath(Path) + "\" + IO.Path.GetFileNameWithoutExtension(Path)
    End Sub
    Private Function GetInputNameAndUpdateForm(Path As String) As String
        Dim CheckIfFile = CheckIfFileOrFolder(Path)
        If CheckIfFile = "File" Then
            Dim FileExtension As String = IO.Path.GetExtension(Path)
            If FileExtension.Contains("divans") Then
                SetOutputFileNamePathWithoutExtension(Path)
                ExtractRButton.Checked = True
            End If
            If CompressRButton.Checked Then
                OutputFileName = Path + ".divans"
                SetOutputFilename()
            End If
        End If
        Return Path
    End Function
    Private Sub UpdateElementsInForm()
        If CompressRButton.Checked Then
            InputFileMessage.Text = CompressInputMessage
        ElseIf ExtractRButton.Checked Then
            InputFileMessage.Text = ExtractInputMessage
        End If
        AboutLabel.Text = AboutString
        ActionGroupBox.Text = ActionGroupBoxString
        BrowseFileButton.Text = BrowseFileButtonString
        BrowseFolderButton.Text = BrowseFolderButtonString
        BrowseFile2Button.Text = BrowseOutputButton
        CompressRButton.Text = CompressRButtonString
        ExtractRButton.Text = ExtractRButtonString
        StartButton.Text = StartButtonString
        If Running Then UpdateStartButton()
        Me.Text = FormName
    End Sub
    Private Sub UpdateMessageStrings(Language As String)
        If Language = "English" Then
            AboutString = My.Resources.About
            ActionGroupBoxString = My.Resources.Action
            BrowseFileButtonString = My.Resources.BrowseFileButton
            BrowseFolderButtonString = My.Resources.BrowseFolderButton
            BrowseOutputButton = My.Resources.BrowseOutputButton
            CompressFolderSelectedMessage = My.Resources.CompressFolderSelectedMessage
            CompressInputMessage = My.Resources.CompressInputMessage
            CompressOutputMessage = My.Resources.CompressOutputMessage
            CompressRButtonString = My.Resources.CompressRButton
            CompressingString = My.Resources.Compressing
            ExtractFolderSelectedMessage = My.Resources.ExtractFolderSelectedMessage
            ExtractInputMessage = My.Resources.ExtractInputMessage
            ExtractOutputMessage = My.Resources.ExtractOutputMessage
            ExtractRButtonString = My.Resources.ExtractRButton
            ExtractingString = My.Resources.Extracting
            StartButtonString = My.Resources.StartButton
            Finished = My.Resources.Finished
            FormName = My.Resources.FormName
        Else
            AboutString = My.Resources.AboutSpanish
            ActionGroupBoxString = My.Resources.ActionSpanish
            BrowseFileButtonString = My.Resources.BrowseFileButtonSpanish
            BrowseFolderButtonString = My.Resources.BrowseFolderButtonSpanish
            BrowseOutputButton = My.Resources.BrowseOutputButtonSpanish
            CompressFolderSelectedMessage = My.Resources.CompressFolderSelectedMessageSpanish
            CompressInputMessage = My.Resources.CompressInputMessageSpanish
            CompressOutputMessage = My.Resources.CompressOutputMessageSpanish
            CompressRButtonString = My.Resources.CompressRButtonSpanish
            CompressingString = My.Resources.CompressingSpanish
            ExtractFolderSelectedMessage = My.Resources.ExtractFolderSelectedMessageSpanish
            ExtractInputMessage = My.Resources.ExtractInputMessageSpanish
            ExtractOutputMessage = My.Resources.ExtractOutputMessageSpanish
            ExtractRButtonString = My.Resources.ExtractRButtonSpanish
            ExtractingString = My.Resources.ExtractingSpanish
            StartButtonString = My.Resources.StartButtonSpanish
            Finished = My.Resources.FinishedSpanish
            FormName = My.Resources.FormNameSpanish
        End If
        UpdateElementsInForm()
    End Sub
    Private Function CheckIfFileOrFolder(Optional PathToCheck As String = "") As String
        If My.Computer.FileSystem.FileExists(PathToCheck) Or PathToCheck = "" Then
            If CompressRButton.Checked Then
                OutputFileMessage.Text = CompressOutputMessage
            ElseIf ExtractRButton.Checked Then
                OutputFileMessage.Text = ExtractOutputMessage
            End If
            OutputFileTxt.Enabled = True
            BrowseFile2Button.Enabled = True
            If PathToCheck IsNot "" Then Return "File"
        ElseIf My.Computer.FileSystem.DirectoryExists(PathToCheck) Then
            If CompressRButton.Checked Then
                OutputFileMessage.Text = CompressFolderSelectedMessage
            ElseIf ExtractRButton.Checked Then
                OutputFileMessage.Text = ExtractFolderSelectedMessage
            End If
            OutputFileTxt.Enabled = False
            BrowseFile2Button.Enabled = False
            Return "Folder"
        End If
        Return "N/A"
    End Function
    Private Sub InputFileTxt_TextChanged(sender As Object, e As EventArgs) Handles InputFileTxt.TextChanged
        GetInputNameAndUpdateForm(InputFileTxt.Text)
    End Sub

    Private Sub EnglishRButton_CheckedChanged(sender As Object, e As EventArgs) Handles EnglishRButton.CheckedChanged
        My.Settings.EnglishLanguage = EnglishRButton.Checked
        My.Settings.Save()
        UpdateMessageStrings("English")
    End Sub

    Private Sub SpanishRButton_CheckedChanged(sender As Object, e As EventArgs) Handles SpanishRButton.CheckedChanged
        My.Settings.SpanishLanguage = SpanishRButton.Checked
        My.Settings.Save()
        UpdateMessageStrings("Spanish")
    End Sub

    Private Sub CompressRButton_CheckedChanged(sender As Object, e As EventArgs) Handles CompressRButton.CheckedChanged
        InputFileMessage.Text = CompressInputMessage
        OutputFileMessage.Text = CompressOutputMessage
        My.Settings.Compress = CompressRButton.Checked
        My.Settings.Save()
        If InputFileTxt.Text IsNot String.Empty Then GetInputNameAndUpdateForm(InputFileTxt.Text)
    End Sub

    Private Sub ExtractRButton_CheckedChanged(sender As Object, e As EventArgs) Handles ExtractRButton.CheckedChanged
        InputFileMessage.Text = ExtractInputMessage
        OutputFileMessage.Text = ExtractOutputMessage
        My.Settings.Extract = ExtractRButton.Checked
        My.Settings.Save()
        If InputFileTxt.Text IsNot String.Empty Then GetInputNameAndUpdateForm(InputFileTxt.Text)
    End Sub

    Private Sub BrowseFileButton_Click(sender As Object, e As EventArgs) Handles BrowseFileButton.Click
        OpenFileDialog1.Title = InputFileMessage.Text
        OpenFileDialog1.Filter = "All files (*.*)|*.*"
        If InputFileTxt.Text IsNot String.Empty Then
            If My.Computer.FileSystem.FileExists(InputFileTxt.Text) Then OpenFileDialog1.FileName = My.Computer.FileSystem.GetName(InputFileTxt.Text) Else OpenFileDialog1.FileName = String.Empty
        Else
            OpenFileDialog1.FileName = String.Empty
        End If
        Dim response As DialogResult = OpenFileDialog1.ShowDialog
        If response = DialogResult.OK Then
            InputFileTxt.Text = GetInputNameAndUpdateForm(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub BrowseFolderButton_Click(sender As Object, e As EventArgs) Handles BrowseFolderButton.Click
        Dim response As DialogResult = FolderBrowserDialog1.ShowDialog()
        If response = DialogResult.OK Then
            InputFileTxt.Text = GetInputNameAndUpdateForm(FolderBrowserDialog1.SelectedPath)
        End If
    End Sub

    Private Sub BrowseFile2Button_Click(sender As Object, e As EventArgs) Handles BrowseFile2Button.Click
        SaveFileDialog1.Title = OutputFileMessage.Text
        If CompressRButton.Checked Then SaveFileDialog1.Filter = "divans file|*.divans" Else SaveFileDialog1.Filter = "All files (*.*)|*.*"
        If OutputFileTxt.Text IsNot String.Empty Then
            If My.Computer.FileSystem.FileExists(OutputFileTxt.Text) Then SaveFileDialog1.FileName = My.Computer.FileSystem.GetName(OutputFileTxt.Text) Else SaveFileDialog1.FileName = String.Empty
        Else
            SaveFileDialog1.FileName = String.Empty
        End If
        Dim response As DialogResult = SaveFileDialog1.ShowDialog
        If response = DialogResult.OK Then
            If CompressRButton.Checked Then
                OutputFileName = SaveFileDialog1.FileName
                If CompressRButton.Checked Then SetOutputFilename()
            Else
                OutputFileTxt.Text = SaveFileDialog1.FileName
            End If
        End If
    End Sub

    Private Sub Form1_DragDrop(sender As Object, e As DragEventArgs) Handles MyBase.DragDrop
        InputFileTxt.Text = e.Data.GetData(DataFormats.FileDrop)(0)
        GetInputNameAndUpdateForm(InputFileTxt.Text)
    End Sub

    Private Sub Form1_DragEnter(sender As Object, e As DragEventArgs) Handles MyBase.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub
    Public Sub ProcessFiles(Folder As String, Action As String)
        For Each File In IO.Directory.GetFiles(Folder)
            If ExtractRButton.Checked Then
                If IO.Path.GetExtension(File).Contains("cmix") Then
                    GetInputNameAndUpdateForm(File)
                    Run_divans(File, OutputFileTxt.Text, Action)
                End If
            Else
                Run_divans(File, File + ".divans" + divans_version, Action)
            End If
        Next
    End Sub

    Public Sub ProcessSubfolders(Folder As String, Action As String)
        For Each Subfolder In IO.Directory.GetDirectories(Folder)
            ProcessFolder(Subfolder, Action)
        Next
    End Sub

    Public Sub ProcessFolder(Folder As String, Action As String)
        ProcessFiles(Folder, Action)
        ProcessSubfolders(Folder, Action)
    End Sub
    Private Delegate Sub UpdateStartButtonInvoker(Finished As Boolean)
    Private Sub UpdateStartButton(Optional Finished As Boolean = False)
        If StartButton.InvokeRequired Then
            StartButton.Invoke(New UpdateStartButtonInvoker(AddressOf UpdateStartButton), Finished)
        Else
            If Finished Then
                StartButton.Enabled = True
                StartButton.Text = StartButtonString
            Else
                StartButton.Enabled = False
                If CompressRButton.Checked Then
                    StartButton.Text = CompressingString
                Else
                    StartButton.Text = ExtractingString
                End If
            End If
        End If
    End Sub
    Private Sub ProcessThread()
        Running = True
        Dim ProcessAction As String = ""
        If CompressRButton.Checked Then
            ProcessAction = "-c"
        End If
        UpdateStartButton()
        Dim CheckInput As String = CheckIfFileOrFolder(InputFileTxt.Text)
        If CheckInput = "File" Then
            If OutputFileTxt.Text IsNot String.Empty Then
                Run_divans(InputFileTxt.Text, OutputFileTxt.Text, ProcessAction)
            End If
        ElseIf CheckInput = "Folder" Then
            ProcessFolder(InputFileTxt.Text, ProcessAction)
        End If
        UpdateStartButton(True)
        Running = False
        MessageBox.Show(Finished)
    End Sub
    Private Sub StartButton_Click(sender As Object, e As EventArgs) Handles StartButton.Click
        If InputFileTxt.Text IsNot String.Empty Then
            Dim Thread As New Threading.Thread(Sub() ProcessThread())
            Thread.Start()
        End If
    End Sub
    Private Sub Run_divans(Input As String, Output As String, action As String)
        Dim cmixProcessInfo As New ProcessStartInfo
        Dim cmixProcess As Process
        cmixProcessInfo.FileName = My.Settings.Version + ".exe"
        cmixProcessInfo.Arguments = action + " """ + Input + """ """ + Output + """"
        cmixProcessInfo.CreateNoWindow = True
        cmixProcessInfo.RedirectStandardOutput = True
        cmixProcessInfo.UseShellExecute = False
        cmixProcess = Process.Start(cmixProcessInfo)
        Dim currentOutput As String = String.Empty
        cmixProcess.WaitForExit()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CompressRButton.Checked = My.Settings.Compress
        ExtractRButton.Checked = My.Settings.Extract
        EnglishRButton.Checked = My.Settings.EnglishLanguage
        SpanishRButton.Checked = My.Settings.SpanishLanguage
    End Sub
End Class
