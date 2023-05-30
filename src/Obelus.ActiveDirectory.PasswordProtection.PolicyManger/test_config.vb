Imports Lithnet.ActiveDirectory.PasswordProtection

Public Class test_config
    Public myHandle As IntPtr
    Public needSave As Boolean = False
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles bCloseForm.Click
        Dim ctrl2Remove As Control = Control.FromHandle(myHandle)
        If ctrl2Remove IsNot Nothing Then
            ctrl2Remove.Dispose()
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Dim test As New Lithnet.ActiveDirectory.PasswordProtection.UserPolicy
        'FilterInterface.GetUserPolicy("LocalAdmins", test)
        Dim res As PasswordTestResult = FilterInterface.TestPassword(TextBox1.Text, "Tim Turner", TextBox2.Text, True)
        'Dim res2 As PasswordTestResult
        MsgBox(res.ToString)
    End Sub
    Private Sub manage_lists_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = "test1"
        TextBox2.Text = "TestTimPassword$#@@%"
    End Sub


End Class
