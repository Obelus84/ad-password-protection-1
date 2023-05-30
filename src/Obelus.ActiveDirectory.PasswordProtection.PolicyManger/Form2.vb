Imports System.Net
Imports System.Runtime.InteropServices
Imports System.Windows.Forms.AxHost
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Window
Public Structure MINMAXINFO
    Public ptReserved As Point
    Public ptMaxSize As Point
    Public ptMaxPosition As Point
    Public ptMinTrackSize As Point
    Public ptMaxTrackSize As Point
End Structure
Public Structure WINDOWPOS
    Public hwnd As IntPtr
    Public hwndInsertAfter As IntPtr
    Public x As Integer
    Public y As Integer
    Public cx As Integer
    Public cy As Integer
    Public flags As UInteger
End Structure
<StructLayout(LayoutKind.Sequential)>
Public Structure RECT
    Public Left As Integer
    Public Top As Integer
    Public Right As Integer
    Public Bottom As Integer
End Structure
<StructLayout(LayoutKind.Sequential)>
Public Structure NCCALCSIZE_PARAMS
    <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)>
    Public rgRect As RECT()

    Public lppos As IntPtr
End Structure
'<StructLayout(LayoutKind.Sequential)>
'Public Structure MONITORINFO
'    Public cbSize As Integer
'    Public rcMonitor As RECT
'    Public rcWork As RECT
'    Public dwFlags As Integer
'End Structure
Public Class Form2
    Private Const GWL_STYLE As Integer = -16
    Private Const WS_CAPTION As Integer = &HC00000
    Private Const WS_SYSMENU As Integer = &H80000
    Private Const WM_NCLBUTTONDOWN As Integer = &HA1
    Private Const HTCAPTION As Integer = &H2
    Private Const WM_SYSCOMMAND As Integer = &H112
    Private Const SC_MINIMIZE As Integer = &HF020
    Private Const SC_RESTORE As Integer = &HF120
    Private Const SWP_NOZORDER As Integer = &H4
    Private Const SWP_NOACTIVATE As Integer = &H10
    Private Const SC_MOVE As Integer = &HF01
    Private Const SC_DRAGMOVE As Integer = &HF012
    Private Const WM_GETMINMAXINFO As Integer = &H24
    Public Const WS_THICKFRAME = &H40000
    Private Const WM_NCHITTEST = &H84
    Private Const WM_NCCALCSIZE = &H83
    Private Const MONITOR_DEFAULTTONEAREST As Integer = &H2

    Private counter As Integer = 0
    'Private WindowSize As Size
    'Private WindowLoc As Point
    'Private minWindowSize As Size
    'Private minWindowLoc As Point

    'Private WithEvents _minTimer As New Timer
    'Private _isMinimizing As Boolean = False
    'Private _isRestoring As Boolean = False

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
    '<DllImport("user32.dll")>
    'Private Shared Function GetWindowDC(ByVal hWnd As IntPtr) As IntPtr
    'End Function

    '<DllImport("user32.dll")>
    'Private Shared Function ReleaseDC(ByVal hWnd As IntPtr, ByVal hdc As IntPtr) As Integer
    'End Function
    '<DllImport("user32.dll")>
    'Private Shared Function GetClientRect(ByVal hWnd As IntPtr, ByRef lpRect As RECT) As Boolean
    'End Function
    '' Declare the GetWindowRect function from the Windows API.
    '<DllImport("user32.dll")>
    'Private Shared Function GetWindowRect(ByVal hWnd As IntPtr, ByRef lpRect As RECT) As Boolean
    'End Function
    '' Declare the DrawFrameControl function from the Windows API.
    '<DllImport("user32.dll")>
    'Private Shared Function DrawFrameControl(ByVal hdc As IntPtr, ByRef rect As RECT, ByVal uType As Integer, ByVal uState As Integer) As Boolean
    'End Function
    '<DllImport("user32.dll", CharSet:=CharSet.Auto)>
    'Private Shared Function SetWindowPos(ByVal hWnd As IntPtr, ByVal hWndInsertAfter As IntPtr, ByVal X As Integer, ByVal Y As Integer, ByVal cx As Integer, ByVal cy As Integer, ByVal uFlags As Integer) As Boolean
    'End Function
    '<DllImport("user32.dll")>
    'Private Shared Function GetMonitorInfo(ByVal hMonitor As IntPtr, ByRef lpmi As MONITORINFO) As Boolean
    'End Function

    '<DllImport("user32.dll")>
    'Private Shared Function MonitorFromWindow(ByVal hwnd As IntPtr, ByVal dwFlags As UInteger) As IntPtr
    'End Function
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '_minTimer.Interval = 10
        If Me.WindowState = FormWindowState.Normal Then
            btnMaximize.Visible = True
        Else
            btnRestore.Visible = True
        End If
    End Sub
    'Private Sub _minTimer_Tick(sender As Object, e As EventArgs) Handles _minTimer.Tick
    '    If _isMinimizing Then
    '        Me.Opacity -= 0.05
    '        Me.Width = Me.Width - (Me.Width * 0.1)
    '        Me.Height = Me.Height - (Me.Height * 0.1)
    '        Me.Location = New Point(Me.Location.X + (Me.Width * 0.1 \ 2), Me.Location.Y + (Me.Location.Y * 0.1))
    '        If Me.Opacity <= 0 Then
    '            minWindowLoc = Me.Location
    '            minWindowSize = Me.Size
    '            SendMessage(Me.Handle, WM_SYSCOMMAND, SC_MINIMIZE, 0)
    '            _isMinimizing = False
    '            _minTimer.Stop()
    '        End If
    '    ElseIf _isRestoring Then
    '        Me.Opacity += 0.05
    '        Me.Width = WindowSize.Width * Me.Opacity
    '        Me.Height = WindowSize.Height * Me.Opacity
    '        Dim x = minWindowLoc.X + (WindowLoc.X - minWindowLoc.X) * Me.Opacity
    '        Dim y = minWindowLoc.Y + (WindowLoc.Y - minWindowLoc.Y) * Me.Opacity
    '        Me.Location = New Point(x, y)
    '        If Me.Opacity >= 1 Then
    '            Me.Opacity = 0 '<< Hack to prevent part of the gui from being clipped set opacity to <1 (0.9 works too) and back to 1
    '            Me.Opacity = 1
    '            Me.Location = WindowLoc
    '            _isRestoring = False
    '            _minTimer.Stop()
    '        End If
    '    End If
    'End Sub
    Private Sub TitleBar_MouseMove(sender As Object, e As MouseEventArgs) Handles TitleBar.MouseDown, MiniTitleBar.MouseDown, lblTitle.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, WM_SYSCOMMAND, SC_DRAGMOVE, 0)
    End Sub
    Private Sub btnManagePolicies_Click(sender As Object, e As EventArgs) Handles btnManagePolicies.Click
        Dim c As New policy_control
        AddControl(c)
    End Sub
    Private Sub btnManageGroups_Click(sender As Object, e As EventArgs) Handles btnManageGroups.Click
        Dim c As New manage_groups
        AddControl(c)
    End Sub
    Private Sub btnManageLists_Click(sender As Object, e As EventArgs) Handles btnManageLists.Click
        Dim c As New manage_lists
        AddControl(c)
    End Sub
    Private Sub btnManageFilter_Click(sender As Object, e As EventArgs) Handles btnManageFilter.Click
        Dim c As New manage_filter
        AddControl(c)
    End Sub
    Private Sub btnTestPasswords_Click(sender As Object, e As EventArgs) Handles btnTestPasswords.Click
        Dim c As New test_filter
        AddControl(c)
    End Sub
    Private Sub AddControl(ByVal c As Object)
        If pContent.Controls.Count > 1 Then
            Console.WriteLine("this error is for debug purposes there are more than 1 control occupying the pCotent container")
            Exit Sub
        ElseIf pContent.Controls.Count = 1 Then
            If pContent.Controls.Item(0).GetType = c.GetType Then
                Console.WriteLine("Control already added")
                c.Dispose()
                Exit Sub
            Else
                Console.WriteLine("New control being added")
                pContent.Controls.Item(0).Dispose()
                If pContent.Controls.Count = 1 Then
                    Console.WriteLine("control not disposal canceled")
                    Exit Sub
                End If
            End If
        End If
        c.Dock = DockStyle.Fill
        c.myHandle = c.Handle
        pContent.Controls.Add(c)
    End Sub
    Private Sub formClosing_event(sender As Object, e As FormClosingEventArgs) Handles Me.Closing
        Try
            If pContent.Controls.Count > 0 Then
                If pContent.Controls.Count = 1 Then
                    If CType(pContent.Controls.Item(0), Object).needSave Then
                        Dim answ As MsgBoxResult = MsgBox("You may have settings that need to be changed, are you sure you want to close this form?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Are you sure?")
                        If answ = MsgBoxResult.Yes Then
                        ElseIf answ = MsgBoxResult.No Then
                            e.Cancel = True
                            Me.DialogResult = DialogResult.None
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            If ex.HResult = -2146233070 Then
                Console.WriteLine(ex.Message)
            End If
        Finally

        End Try
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        'store current size and location for restoring window
        'WindowSize = Me.Size
        'WindowLoc = Me.Location
        '_isMinimizing = True
        '_minTimer.Start()
        Me.WindowState = FormWindowState.Minimized

    End Sub
    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            If True Then
                cp.Style = cp.Style Or WS_THICKFRAME Or WS_CAPTION
            End If
            Return cp
        End Get
    End Property

    'handles restore event from taskbar, yeilds all other messages back to windows default
    'purposely left case statements incase i wan't to handle other msg in the future
    'Private Const WM_NCPAINT As Integer = &H85
    'Private Const DFCS_CAPTION As Integer = &H1
    'Private Const DFCS_CAPTIONCLOSE As Integer = &H0
    Protected Overrides Sub WndProc(ByRef m As Message)
        ' Console.WriteLine(m)
        Select Case m.Msg
            Case WM_SYSCOMMAND
                Select Case m.WParam
                    'Case SC_RESTORE
                    '    _isRestoring = True
                    '    _minTimer.Start()
                    Case Else

                        MyBase.WndProc(m)
                End Select
            Case WM_GETMINMAXINFO
                'Handles a weird bug where pixles are outside of the screen. it's more than 1 but for some reason subtracting
                '1 fixes the display issue

                Dim minMaxInfoPtr As IntPtr = m.LParam
                Dim minMaxInfo As MINMAXINFO = CType(Marshal.PtrToStructure(minMaxInfoPtr, GetType(MINMAXINFO)), MINMAXINFO)

                minMaxInfo.ptMaxSize.X = Screen.FromControl(Me).WorkingArea.Size.Width - 1
                minMaxInfo.ptMaxSize.Y = Screen.FromControl(Me).WorkingArea.Size.Height - 1
                minMaxInfo.ptMaxPosition = New Point(0, 0)
                Marshal.StructureToPtr(minMaxInfo, minMaxInfoPtr, True)
                m.Result = IntPtr.Zero ' Set the result to zero to indicate that the message was processed
            Case WM_NCHITTEST
                'not entirly sure what this does
                m.Result = New IntPtr(HTCAPTION)
            Case WM_NCCALCSIZE
                'this sets the title bar to nothing while still retaining all of the window aero functionality
                If m.WParam.ToInt32() = 1 Then
                    m.Result = IntPtr.Zero
                Else
                    MyBase.WndProc(m)
                End If
            Case Else
                MyBase.WndProc(m)
        End Select
    End Sub

    Protected Overrides Sub SetBoundsCore(x As Integer, y As Integer, width As Integer, height As Integer, specified As BoundsSpecified)
        MyBase.SetBoundsCore(RestoreBounds.Left, RestoreBounds.Top, RestoreBounds.Width, RestoreBounds.Height, BoundsSpecified.All)
    End Sub

    Private Sub btnMaximize_Click(sender As Object, e As EventArgs) Handles btnMaximize.Click, btnRestore.Click, TitleBar.DoubleClick, MiniTitleBar.DoubleClick, lblTitle.DoubleClick
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
            btnRestore.Visible = False
            btnMaximize.Visible = True
        ElseIf Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
            btnMaximize.Visible = False
            btnRestore.Visible = True
        End If
    End Sub
    Private Sub windowResized_Event(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        If Me.WindowState = FormWindowState.Normal Then
            btnRestore.Visible = False
            btnMaximize.Visible = True
        End If
    End Sub

End Class