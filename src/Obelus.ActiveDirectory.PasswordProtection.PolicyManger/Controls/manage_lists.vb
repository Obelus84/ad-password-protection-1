Imports System.Runtime.Remoting.Channels
Imports System.Threading
Imports System.Windows.Forms.VisualStyles
Imports System.Xml.Serialization
Imports Lithnet.ActiveDirectory.PasswordProtection
Imports Obelus.ActiveDirectory.PasswordProtection.PolicyManger.Policy

Public Class manage_lists
    Public myHandle As IntPtr
    Public needSave As Boolean = False
    Public processing As Boolean = False
    Private WithEvents prgTimer As New System.Windows.Forms.Timer
    Private prg As New OperationProgress
    Private ct As New CancellationTokenSource()
    Private th As Thread
    Private reg As New RegistryClass()
    Private thRet As String


    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles bCloseForm.Click
        Dim ctrl2Remove As Control = Control.FromHandle(myHandle)
        If ctrl2Remove IsNot Nothing Then
            ctrl2Remove.Dispose()
        End If
    End Sub
    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    '    'Dim test As New Lithnet.ActiveDirectory.PasswordProtection.UserPolicy
    '    'FilterInterface.GetUserPolicy("LocalAdmins", test)
    '    Dim res As PasswordTestResult = FilterInterface.TestPassword(TextBox1.Text, "Tim Turner", TextBox2.Text, True)
    '    Dim res2 As PasswordTestResult
    '    MsgBox(res.ToString)
    'End Sub
    Private Sub manage_lists_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TextBox1.Text = "test1"
        'TextBox2.Text = "TestTimPassword$#@@%"
        parseControls(Me)
        prgTimer.Interval = 100

        cmbListDest.Enabled = False
        txtSource.Enabled = False
        bBrowseDest.Enabled = False
        bBrowseSource.Enabled = False
        bStart.Enabled = False
        bStop.Enabled = False
        reg.getPasswordLists(cmbListDest, False)
        reg.getPasswordLists(cmbLists, False)
        cmbListDest.SelectedIndex = 0
        gbHashListType.Enabled = False
        txtSource.Text = "C:\Users\Travis\Downloads\keep\Hacking\rockyou.txt"
        'Tabcontrol1.Text = "C:\temp\store"

    End Sub

    Private Sub bBrowseSource_Click(sender As Object, e As EventArgs) Handles bBrowseSource.Click
        If radStore.Checked Then
            Dim folderBrowserDialog1 As New FolderBrowserDialog()

            folderBrowserDialog1.RootFolder = Environment.SpecialFolder.MyComputer
            folderBrowserDialog1.SelectedPath = "C:\"
            folderBrowserDialog1.ShowNewFolderButton = True

            If folderBrowserDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                txtSource.Text = folderBrowserDialog1.SelectedPath
            End If
        Else
            Dim openFileDialog1 As New OpenFileDialog()

            openFileDialog1.InitialDirectory = "C:\"
            openFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"
            openFileDialog1.FilterIndex = 2
            openFileDialog1.RestoreDirectory = True
            openFileDialog1.Multiselect = False

            If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                txtSource.Text = openFileDialog1.FileName
            End If
        End If
        If cmbListDest.Text <> "" Then bStart.Enabled = True
    End Sub
    Private Sub parseControls(ByVal container As Control)
        For Each c As Control In container.Controls
            If TypeOf c Is Button Then
                AddHandler DirectCast(c, Button).EnabledChanged, AddressOf Handle_EnabledChanged
            End If
            If c.Controls.Count > 0 Then
                parseControls(c)
            End If
        Next
    End Sub
    Private Sub bBrowseDest_Click(sender As Object, e As EventArgs) Handles bBrowseDest.Click
        Dim folderBrowserDialog1 As New FolderBrowserDialog()

        folderBrowserDialog1.RootFolder = Environment.SpecialFolder.MyComputer
        folderBrowserDialog1.SelectedPath = "C:\"
        folderBrowserDialog1.ShowNewFolderButton = True

        If folderBrowserDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            cmbListDest.Text = folderBrowserDialog1.SelectedPath
        End If
        If txtSource.Text <> "" Then bStart.Enabled = True
    End Sub

    Private Sub destChanged(sender As Object, e As EventArgs) Handles cmbListDest.SelectedIndexChanged
        If txtSource.Text <> "" Then bStart.Enabled = True
    End Sub

    Private Sub bStart_Click(sender As Object, e As EventArgs) Handles bStart.Click
        bStart.Enabled = False
        Try
            If Not FileIO.FileSystem.DirectoryExists(cmbListDest.Text) Then
                bStart.Enabled = True
                MsgBox("Destination directory must exist", MsgBoxStyle.Critical, "Error")
                Exit Sub
            End If
            If Not FileIO.FileSystem.FileExists(txtSource.Text) Then
                bStart.Enabled = True
                MsgBox("Source File must exist", MsgBoxStyle.Critical, "Error")
                Exit Sub
            End If
            If cmbListDest.Items.IndexOf(cmbListDest.Text) = -1 Then
                Dim msg As MsgBoxResult = MsgBox("Destination store currently doesn't exit, Confirm you are creating a new list", MsgBoxStyle.Question + MsgBoxStyle.YesNoCancel, "New Password Store")
                If msg = MsgBoxResult.Yes Then
                    Dim ret As Boolean = reg.newPasswordList(cmbListDest.Text)
                    If ret Then
                        reg.getPasswordLists(cmbListDest, False)
                    Else
                        MsgBox("There was an issue creating the new list, please try again", MsgBoxStyle.Critical, "Error")
                        bStart.Enabled = True
                        Exit Sub
                    End If
                Else
                    Exit Sub
                End If
            End If
            Dim vstore As New V3Store(cmbListDest.Text)
            Dim sType As StoreType = StoreType.Password
            If radTypeWord.Checked Then sType = StoreType.Word
            If radHash.Checked Then
                If radSorted.Checked Then
                    th = New Thread(Sub()
                                        Try
                                            Store.ImportHexHashesFromSortedFile(vstore, sType, txtSource.Text, ct.Token, prg)
                                        Catch ex As Exception
                                            thRet = ex.Message
                                            Console.WriteLine(ex.Message)
                                        End Try
                                    End Sub)
                Else
                    th = New Thread(Sub()
                                        Try
                                            Store.ImportHexHashesFromFile(vstore, sType, txtSource.Text, ct.Token,, prg)
                                        Catch ex As Exception
                                            thRet = ex.Message
                                            Console.WriteLine(ex.Message)
                                        End Try
                                    End Sub)
                End If
            ElseIf radWordList.Checked Then
                th = New Thread(Sub()
                                    Try
                                        Store.ImportPasswordsFromFile(vstore, sType, txtSource.Text, ct.Token,, prg)
                                    Catch ex As Exception
                                        thRet = ex.Message
                                        Console.WriteLine(ex.Message)
                                    End Try
                                End Sub)
            ElseIf radStore.Checked Then
                Dim sStore As New V3Store(txtSource.Text)
                th = New Thread(Sub()
                                    Try
                                        Store.ImportFromStore(vstore, sStore, txtSource.Text, sType, ct.Token, prg)
                                    Catch ex As Exception
                                        thRet = ex.Message
                                        Console.WriteLine(ex.Message)
                                    End Try
                                End Sub)
            End If
            th.Start()
            Thread.Sleep(100)
            bStop.Enabled = True
            processing = True
            prgTimer.Start()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub
    Private Sub tick(sender As Object, e As EventArgs) Handles prgTimer.Tick
        Try
            If th.IsAlive() Then
                lbl1.Text = prg.Status
                lbl2.Text = prg.FileProgressPercent
                ProgressBar1.Value = prg.FileProgressPercent
                If prg.Status = "Done" Then
                    prgTimer.Stop()
                    GC.Collect()
                    bStop.Enabled = False
                    bStart.Enabled = True
                    processing = False
                    MsgBox("Finished Importing file to store", MsgBoxStyle.Information, "Finished")
                End If
            ElseIf thRet <> "" Then
                prgTimer.Stop()
                GC.Collect()
                bStop.Enabled = False
                bStart.Enabled = True
                processing = False
                MsgBox("The import process terminated unexpectidly with the error:" & vbCrLf & vbCrLf & thRet, MsgBoxStyle.Critical, "Error")
                thRet = ""
            Else
                If prg.Status = "Done" And thRet = "" Then
                    prgTimer.Stop()
                    GC.Collect()
                    bStop.Enabled = False
                    bStart.Enabled = True
                    processing = False
                    MsgBox("Finished Importing file to store", MsgBoxStyle.Information, "Finished")
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub bStop_Click(sender As Object, e As EventArgs) Handles bStop.Click
        Dim msg As MsgBoxResult = MsgBox("WARNING: You are canceling mid import, this will cause the new entries not to be reflected in the store. You will have to restart the Import processes from the begning", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Are you sure?")
        If msg = MsgBoxResult.Yes Then
            prgTimer.Stop()
            If th.IsAlive() Then
                ct.Cancel()
                While th.IsAlive()
                    Thread.Sleep(50)
                End While
                If th.IsAlive Then
                    MsgBox("cancel fail")
                Else
                    ct = New CancellationTokenSource()
                    processing = False
                    GC.Collect()
                    thRet = ""
                    MsgBox("Import process has been terminated", MsgBoxStyle.Information, "Import terminated")
                    bStop.Enabled = False
                    bStart.Enabled = True
                End If
            Else
                ct = New CancellationTokenSource()
                processing = False
                GC.Collect()
                thRet = ""
                MsgBox("Import process has been terminated", MsgBoxStyle.Information, "Import terminated")
                bStop.Enabled = False
                bStart.Enabled = True
            End If
        End If
    End Sub

    Private Sub radWordList_CheckedChanged(sender As Object, e As EventArgs) Handles radWordList.CheckedChanged, radHash.CheckedChanged, radStore.CheckedChanged

        cmbListDest.Enabled = True
        txtSource.Enabled = True
        bBrowseDest.Enabled = True
        bBrowseSource.Enabled = True

        If radWordList.Checked Then
            gbHashListType.Enabled = False
        ElseIf radHash.Checked Then
            gbHashListType.Enabled = Enabled
        ElseIf radStore.Checked Then
            gbHashListType.Enabled = False

        End If
    End Sub

    Private Sub bSearch_Click(sender As Object, e As EventArgs) Handles bSearch.Click
        lblResult.Text = ""
        Dim sStore As Store = CType(New V3Store(cmbLists.Text), Store)
        Try
            Dim test As Boolean = sStore.IsInStore(txtSearch.Text, StoreType.Password)
            If test Then
                lblResult.Text = "Password was found in the selected password store"
            Else
                lblResult.Text = "Password was NOT found in the selected password store"
            End If
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub

    Private Sub cmbLists_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbLists.SelectedIndexChanged
        lblResult.Text = ""
    End Sub
    Private Sub Handle_EnabledChanged(sender As Object, e As EventArgs)
        Dim b As Button = DirectCast(sender, Button)
        If b.Enabled Then
            b.BackColor = ColorTranslator.FromHtml("#273c75")
        Else
            b.BackColor = ColorTranslator.FromHtml("#7f8fa6")
        End If
    End Sub

    Private Sub bListManager_Click(sender As Object, e As EventArgs) Handles bListManager.Click
        If pListManager.Visible Then
            pListManager.Visible = False
        Else
            pListManager.Visible = True
        End If
    End Sub

    Private Sub bTestPassword_Click(sender As Object, e As EventArgs) Handles bTestPassword.Click
        If pTestPassword.Visible Then
            pTestPassword.Visible = False
        Else
            pTestPassword.Visible = True
        End If
    End Sub
End Class
