Imports System.Runtime.InteropServices
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Tab

Public Class text_combo_control
    Public parentwindow As IntPtr
    Private loading = True
    Public needSave = False
    Private Sub ComboBox1_MouseWheel(sender As Object, e As HandledMouseEventArgs) Handles ComboBox1.MouseWheel
        ' Set the Handled property of the event arguments to True
        e.Handled = True
    End Sub
    Public Sub SetComboBox(ByVal value As String(), ByVal defaultValue As String)
        loading = True
        ComboBox1.Items.AddRange(value)
        If ComboBox1.Items.IndexOf(defaultValue) <> -1 Then
            ComboBox1.SelectedIndex = ComboBox1.Items.IndexOf(defaultValue)
        Else
            ComboBox1.SelectedIndex = 0
            needSave = True
            TextBox1.BackColor = ColorTranslator.FromHtml("#e84118")
            MsgBox(TextBox1.Text & " did not have an associated policy, policy was set to Default. Change it if required but don't forget to save", MsgBoxStyle.Exclamation, "Warning")
        End If
        loading = False
    End Sub
    Private Sub changed(sender As Object, e As EventArgs) Handles ComboBox1.SelectedValueChanged
        If loading = True Then Exit Sub
        Try
            Dim t As manage_groups = Control.FromHandle(parentwindow)
            t.needsave = True
            t.bSave.Enabled = True
        Catch ex As Exception
            'catching errors because this procs before it has a parent
            Console.WriteLine(ex.Message)
        End Try
    End Sub
End Class
