Imports System.Runtime.InteropServices
Imports System.Windows.Forms.VisualStyles

Public Class custom_input_box

    Private Const WM_SYSCOMMAND As Integer = &H112
    Private Const SC_DRAGMOVE As Integer = &HF012

    Public Sub New(ByVal text As String, ByVal title As String, Optional ByVal defaultInput As String = "")
        InitializeComponent()
        lblPrompt.Text = text
        lblTitle.Text = title
        TextBox1.Text = defaultInput
    End Sub
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
    Private Sub bOk_Click(sender As Object, e As EventArgs) Handles bOk.Click
        If check_input() Then
            Me.DialogResult = DialogResult.OK
            Me.Close()
        Else
            MsgBox("Policy name contained one or more restricted characters. Only AlphaNumeric A-Z 0-9 are accepted, with the exception of - (dash) or _ (underscore)", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error")
        End If
    End Sub
    Private Function check_input()
        Dim ret As Boolean = True
        Dim symbols As String = "!@#$%^&*()+=~` "
        For Each c As Char In TextBox1.Text
            If symbols.Contains(c) Then
                ret = False
            End If
        Next
        Return ret
    End Function
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
    Public Function GetInput() As String
        Return TextBox1.Text
    End Function
    Private Sub TitleBar_MouseMove(sender As Object, e As MouseEventArgs) Handles lblTitle.MouseDown, pTitleBar.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, WM_SYSCOMMAND, SC_DRAGMOVE, 0)
    End Sub

    Private Sub custom_input_box_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.AutoSize = False
        TextBox1.Height = 22
    End Sub
End Class