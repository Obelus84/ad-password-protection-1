Imports Lithnet.ActiveDirectory.PasswordProtection

Public Class test_filter
    Public myHandle As IntPtr
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles bCloseForm.Click
        Dim ctrl2Remove As Control = Control.FromHandle(myHandle)
        If ctrl2Remove IsNot Nothing Then
            ctrl2Remove.Dispose()
        End If
    End Sub
    Private Sub bCheck_Click(sender As Object, e As EventArgs) Handles bSubmit.Click
        If txtUsername.Text <> "" And txtPassword.Text <> "" Then
            Dim result As PasswordTestResult = FilterInterface.TestPassword(txtUsername.Text, txtFullName.Text, txtPassword.Text, radSet.Checked)
            If result > 0 Then
                MsgBox(result.ToString, MsgBoxStyle.Critical, "Error")
            Else
                MsgBox(result.ToString, MsgBoxStyle.Information, "Success")
            End If
        Else
            MsgBox("Username and Password are required to test password filtering", MsgBoxStyle.Critical, "Error")
        End If
    End Sub
End Class
