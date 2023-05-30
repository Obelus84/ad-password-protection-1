<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class manage_lists
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    '<System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If needsave Then
            Dim answ As MsgBoxResult = MsgBox("You may have settings that need to be changed, are you sure you want to close this form?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Are you sure?")
            If answ = MsgBoxResult.Yes Then

            ElseIf answ = MsgBoxResult.No Then
                Exit Sub
            End If
        ElseIf processing Then
            Dim answ As MsgBoxResult = MsgBox("You are currently importing or updateing a store. You can continue to modify other settings but once this form is gone you will no longer be able to see the progress or cancel. It's recommended that you cancel the import or wait for it to finish first" + vbCrLf + vbCrLf + "Do you still want to close?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Import in progress?")
            If answ = MsgBoxResult.Yes Then

            ElseIf answ = MsgBoxResult.No Then
                Exit Sub
            End If
        End If
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.bCloseForm = New System.Windows.Forms.Button()
        Me.pTestPassword = New System.Windows.Forms.Panel()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.bSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbLists = New System.Windows.Forms.ComboBox()
        Me.bTestPassword = New System.Windows.Forms.Button()
        Me.pListManager = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.radTypeWord = New System.Windows.Forms.RadioButton()
        Me.radTypePassword = New System.Windows.Forms.RadioButton()
        Me.gbHashListType = New System.Windows.Forms.GroupBox()
        Me.radUnsorted = New System.Windows.Forms.RadioButton()
        Me.radSorted = New System.Windows.Forms.RadioButton()
        Me.cmbListDest = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.bStart = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.bStop = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radStore = New System.Windows.Forms.RadioButton()
        Me.radHash = New System.Windows.Forms.RadioButton()
        Me.radWordList = New System.Windows.Forms.RadioButton()
        Me.bBrowseDest = New System.Windows.Forms.Button()
        Me.bBrowseSource = New System.Windows.Forms.Button()
        Me.txtSource = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.bListManager = New System.Windows.Forms.Button()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.pTestPassword.SuspendLayout()
        Me.pListManager.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.gbHashListType.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label9)
        Me.SplitContainer1.Panel1.Controls.Add(Me.bCloseForm)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.pTestPassword)
        Me.SplitContainer1.Panel2.Controls.Add(Me.bTestPassword)
        Me.SplitContainer1.Panel2.Controls.Add(Me.pListManager)
        Me.SplitContainer1.Panel2.Controls.Add(Me.bListManager)
        Me.SplitContainer1.Size = New System.Drawing.Size(826, 338)
        Me.SplitContainer1.SplitterDistance = 82
        Me.SplitContainer1.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.Label9.Location = New System.Drawing.Point(196, 32)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(367, 16)
        Me.Label9.TabIndex = 47
        Me.Label9.Text = "Use the sections below to manage and test Password Stores"
        '
        'bCloseForm
        '
        Me.bCloseForm.FlatAppearance.BorderSize = 0
        Me.bCloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bCloseForm.Location = New System.Drawing.Point(3, 3)
        Me.bCloseForm.Name = "bCloseForm"
        Me.bCloseForm.Size = New System.Drawing.Size(33, 27)
        Me.bCloseForm.TabIndex = 46
        Me.bCloseForm.Text = "X"
        Me.bCloseForm.UseVisualStyleBackColor = True
        '
        'pTestPassword
        '
        Me.pTestPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.pTestPassword.Controls.Add(Me.lblResult)
        Me.pTestPassword.Controls.Add(Me.Label6)
        Me.pTestPassword.Controls.Add(Me.bSearch)
        Me.pTestPassword.Controls.Add(Me.txtSearch)
        Me.pTestPassword.Controls.Add(Me.Label5)
        Me.pTestPassword.Controls.Add(Me.Label1)
        Me.pTestPassword.Controls.Add(Me.cmbLists)
        Me.pTestPassword.Dock = System.Windows.Forms.DockStyle.Top
        Me.pTestPassword.Location = New System.Drawing.Point(0, 375)
        Me.pTestPassword.Name = "pTestPassword"
        Me.pTestPassword.Size = New System.Drawing.Size(809, 190)
        Me.pTestPassword.TabIndex = 11
        Me.pTestPassword.Visible = False
        '
        'lblResult
        '
        Me.lblResult.Location = New System.Drawing.Point(72, 142)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(394, 27)
        Me.lblResult.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 142)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Result:"
        '
        'bSearch
        '
        Me.bSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.bSearch.FlatAppearance.BorderSize = 0
        Me.bSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bSearch.Location = New System.Drawing.Point(292, 99)
        Me.bSearch.Name = "bSearch"
        Me.bSearch.Size = New System.Drawing.Size(119, 31)
        Me.bSearch.TabIndex = 11
        Me.bSearch.Text = "Search"
        Me.bSearch.UseVisualStyleBackColor = False
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(199, 57)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(308, 20)
        Me.txtSearch.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 57)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(144, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Text/Password to search for:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Pick a list:"
        '
        'cmbLists
        '
        Me.cmbLists.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLists.FormattingEnabled = True
        Me.cmbLists.Location = New System.Drawing.Point(75, 12)
        Me.cmbLists.Name = "cmbLists"
        Me.cmbLists.Size = New System.Drawing.Size(733, 21)
        Me.cmbLists.TabIndex = 7
        '
        'bTestPassword
        '
        Me.bTestPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.bTestPassword.Dock = System.Windows.Forms.DockStyle.Top
        Me.bTestPassword.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.bTestPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bTestPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bTestPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.bTestPassword.Location = New System.Drawing.Point(0, 340)
        Me.bTestPassword.Name = "bTestPassword"
        Me.bTestPassword.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Me.bTestPassword.Size = New System.Drawing.Size(809, 35)
        Me.bTestPassword.TabIndex = 10
        Me.bTestPassword.Text = "Test Password Against List"
        Me.bTestPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bTestPassword.UseVisualStyleBackColor = False
        '
        'pListManager
        '
        Me.pListManager.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.pListManager.Controls.Add(Me.Label8)
        Me.pListManager.Controls.Add(Me.Label7)
        Me.pListManager.Controls.Add(Me.GroupBox2)
        Me.pListManager.Controls.Add(Me.gbHashListType)
        Me.pListManager.Controls.Add(Me.cmbListDest)
        Me.pListManager.Controls.Add(Me.Label4)
        Me.pListManager.Controls.Add(Me.bStart)
        Me.pListManager.Controls.Add(Me.ProgressBar1)
        Me.pListManager.Controls.Add(Me.lbl2)
        Me.pListManager.Controls.Add(Me.lbl1)
        Me.pListManager.Controls.Add(Me.bStop)
        Me.pListManager.Controls.Add(Me.GroupBox1)
        Me.pListManager.Controls.Add(Me.bBrowseDest)
        Me.pListManager.Controls.Add(Me.bBrowseSource)
        Me.pListManager.Controls.Add(Me.txtSource)
        Me.pListManager.Controls.Add(Me.Label3)
        Me.pListManager.Controls.Add(Me.Label2)
        Me.pListManager.Dock = System.Windows.Forms.DockStyle.Top
        Me.pListManager.Location = New System.Drawing.Point(0, 35)
        Me.pListManager.Name = "pListManager"
        Me.pListManager.Size = New System.Drawing.Size(809, 305)
        Me.pListManager.TabIndex = 9
        Me.pListManager.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.Label8.Location = New System.Drawing.Point(88, 239)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 16)
        Me.Label8.TabIndex = 106
        Me.Label8.Text = "%Completed:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.Label7.Location = New System.Drawing.Point(87, 205)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 16)
        Me.Label7.TabIndex = 105
        Me.Label7.Text = "Current Status:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.radTypeWord)
        Me.GroupBox2.Controls.Add(Me.radTypePassword)
        Me.GroupBox2.Location = New System.Drawing.Point(202, 31)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(390, 24)
        Me.GroupBox2.TabIndex = 91
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Destination List Type"
        '
        'radTypeWord
        '
        Me.radTypeWord.AutoSize = True
        Me.radTypeWord.Location = New System.Drawing.Point(257, 0)
        Me.radTypeWord.Name = "radTypeWord"
        Me.radTypeWord.Size = New System.Drawing.Size(79, 17)
        Me.radTypeWord.TabIndex = 2
        Me.radTypeWord.Text = "Word Store"
        Me.radTypeWord.UseVisualStyleBackColor = True
        '
        'radTypePassword
        '
        Me.radTypePassword.AutoSize = True
        Me.radTypePassword.Checked = True
        Me.radTypePassword.Location = New System.Drawing.Point(140, 0)
        Me.radTypePassword.Name = "radTypePassword"
        Me.radTypePassword.Size = New System.Drawing.Size(99, 17)
        Me.radTypePassword.TabIndex = 0
        Me.radTypePassword.TabStop = True
        Me.radTypePassword.Text = "Password Store"
        Me.radTypePassword.UseVisualStyleBackColor = True
        '
        'gbHashListType
        '
        Me.gbHashListType.Controls.Add(Me.radUnsorted)
        Me.gbHashListType.Controls.Add(Me.radSorted)
        Me.gbHashListType.Location = New System.Drawing.Point(202, 56)
        Me.gbHashListType.Name = "gbHashListType"
        Me.gbHashListType.Size = New System.Drawing.Size(390, 26)
        Me.gbHashListType.TabIndex = 92
        Me.gbHashListType.TabStop = False
        Me.gbHashListType.Text = "Hash List Type"
        '
        'radUnsorted
        '
        Me.radUnsorted.AutoSize = True
        Me.radUnsorted.Location = New System.Drawing.Point(167, -1)
        Me.radUnsorted.Name = "radUnsorted"
        Me.radUnsorted.Size = New System.Drawing.Size(68, 17)
        Me.radUnsorted.TabIndex = 1
        Me.radUnsorted.Text = "Unsorted"
        Me.radUnsorted.UseVisualStyleBackColor = True
        '
        'radSorted
        '
        Me.radSorted.AutoSize = True
        Me.radSorted.Checked = True
        Me.radSorted.Location = New System.Drawing.Point(100, -1)
        Me.radSorted.Name = "radSorted"
        Me.radSorted.Size = New System.Drawing.Size(56, 17)
        Me.radSorted.TabIndex = 0
        Me.radSorted.TabStop = True
        Me.radSorted.Text = "Sorted"
        Me.radSorted.UseVisualStyleBackColor = True
        '
        'cmbListDest
        '
        Me.cmbListDest.FormattingEnabled = True
        Me.cmbListDest.Location = New System.Drawing.Point(205, 115)
        Me.cmbListDest.Name = "cmbListDest"
        Me.cmbListDest.Size = New System.Drawing.Size(397, 21)
        Me.cmbListDest.TabIndex = 95
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Label4.Location = New System.Drawing.Point(205, 145)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(484, 13)
        Me.Label4.TabIndex = 104
        Me.Label4.Text = "Use the drop down to select a current list or choose a location to create a new o" &
    "ne (Folder must exist)"
        '
        'bStart
        '
        Me.bStart.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.bStart.FlatAppearance.BorderSize = 0
        Me.bStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bStart.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bStart.Location = New System.Drawing.Point(302, 171)
        Me.bStart.Name = "bStart"
        Me.bStart.Size = New System.Drawing.Size(89, 31)
        Me.bStart.TabIndex = 97
        Me.bStart.Text = "Build list"
        Me.bStart.UseVisualStyleBackColor = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(114, 267)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(582, 23)
        Me.ProgressBar1.TabIndex = 103
        '
        'lbl2
        '
        Me.lbl2.Location = New System.Drawing.Point(185, 241)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(511, 23)
        Me.lbl2.TabIndex = 102
        '
        'lbl1
        '
        Me.lbl1.Location = New System.Drawing.Point(182, 205)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(528, 36)
        Me.lbl1.TabIndex = 101
        '
        'bStop
        '
        Me.bStop.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.bStop.FlatAppearance.BorderSize = 0
        Me.bStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bStop.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bStop.Location = New System.Drawing.Point(398, 171)
        Me.bStop.Name = "bStop"
        Me.bStop.Size = New System.Drawing.Size(89, 31)
        Me.bStop.TabIndex = 98
        Me.bStop.Text = "Stop Import"
        Me.bStop.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radStore)
        Me.GroupBox1.Controls.Add(Me.radHash)
        Me.GroupBox1.Controls.Add(Me.radWordList)
        Me.GroupBox1.Location = New System.Drawing.Point(202, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(390, 24)
        Me.GroupBox1.TabIndex = 90
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "File Type"
        '
        'radStore
        '
        Me.radStore.AutoSize = True
        Me.radStore.Location = New System.Drawing.Point(196, 0)
        Me.radStore.Name = "radStore"
        Me.radStore.Size = New System.Drawing.Size(79, 17)
        Me.radStore.TabIndex = 69
        Me.radStore.TabStop = True
        Me.radStore.Text = "Other Store"
        Me.radStore.UseVisualStyleBackColor = True
        '
        'radHash
        '
        Me.radHash.AutoSize = True
        Me.radHash.Location = New System.Drawing.Point(140, 0)
        Me.radHash.Name = "radHash"
        Me.radHash.Size = New System.Drawing.Size(50, 17)
        Me.radHash.TabIndex = 1
        Me.radHash.TabStop = True
        Me.radHash.Text = "Hash"
        Me.radHash.UseVisualStyleBackColor = True
        '
        'radWordList
        '
        Me.radWordList.AutoSize = True
        Me.radWordList.Location = New System.Drawing.Point(71, 0)
        Me.radWordList.Name = "radWordList"
        Me.radWordList.Size = New System.Drawing.Size(63, 17)
        Me.radWordList.TabIndex = 0
        Me.radWordList.Text = "Wordlist"
        Me.radWordList.UseVisualStyleBackColor = True
        '
        'bBrowseDest
        '
        Me.bBrowseDest.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.bBrowseDest.FlatAppearance.BorderSize = 0
        Me.bBrowseDest.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bBrowseDest.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bBrowseDest.Location = New System.Drawing.Point(609, 118)
        Me.bBrowseDest.Name = "bBrowseDest"
        Me.bBrowseDest.Size = New System.Drawing.Size(80, 23)
        Me.bBrowseDest.TabIndex = 96
        Me.bBrowseDest.Text = "Browse"
        Me.bBrowseDest.UseVisualStyleBackColor = False
        '
        'bBrowseSource
        '
        Me.bBrowseSource.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.bBrowseSource.FlatAppearance.BorderSize = 0
        Me.bBrowseSource.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bBrowseSource.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bBrowseSource.Location = New System.Drawing.Point(609, 89)
        Me.bBrowseSource.Name = "bBrowseSource"
        Me.bBrowseSource.Size = New System.Drawing.Size(80, 23)
        Me.bBrowseSource.TabIndex = 94
        Me.bBrowseSource.Text = "Browse"
        Me.bBrowseSource.UseVisualStyleBackColor = False
        '
        'txtSource
        '
        Me.txtSource.Location = New System.Drawing.Point(205, 89)
        Me.txtSource.Name = "txtSource"
        Me.txtSource.Size = New System.Drawing.Size(397, 20)
        Me.txtSource.TabIndex = 93
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.Label3.Location = New System.Drawing.Point(82, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 16)
        Me.Label3.TabIndex = 100
        Me.Label3.Text = "Output Location"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.Label2.Location = New System.Drawing.Point(99, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 16)
        Me.Label2.TabIndex = 99
        Me.Label2.Text = "Source Data"
        '
        'bListManager
        '
        Me.bListManager.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.bListManager.Dock = System.Windows.Forms.DockStyle.Top
        Me.bListManager.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.bListManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bListManager.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bListManager.ForeColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.bListManager.Location = New System.Drawing.Point(0, 0)
        Me.bListManager.Name = "bListManager"
        Me.bListManager.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Me.bListManager.Size = New System.Drawing.Size(809, 35)
        Me.bListManager.TabIndex = 8
        Me.bListManager.Text = "List Manager (Add/Create)"
        Me.bListManager.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bListManager.UseVisualStyleBackColor = False
        '
        'manage_lists
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "manage_lists"
        Me.Size = New System.Drawing.Size(826, 338)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.pTestPassword.ResumeLayout(False)
        Me.pTestPassword.PerformLayout()
        Me.pListManager.ResumeLayout(False)
        Me.pListManager.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.gbHashListType.ResumeLayout(False)
        Me.gbHashListType.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents bCloseForm As Button
    Friend WithEvents bListManager As Button
    Friend WithEvents pListManager As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents radTypeWord As RadioButton
    Friend WithEvents radTypePassword As RadioButton
    Friend WithEvents gbHashListType As GroupBox
    Friend WithEvents radUnsorted As RadioButton
    Friend WithEvents radSorted As RadioButton
    Friend WithEvents cmbListDest As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents bStart As Button
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents lbl2 As Label
    Friend WithEvents lbl1 As Label
    Friend WithEvents bStop As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radStore As RadioButton
    Friend WithEvents radHash As RadioButton
    Friend WithEvents radWordList As RadioButton
    Friend WithEvents bBrowseDest As Button
    Friend WithEvents bBrowseSource As Button
    Friend WithEvents txtSource As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents bTestPassword As Button
    Friend WithEvents pTestPassword As Panel
    Friend WithEvents lblResult As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents bSearch As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbLists As ComboBox
    Friend WithEvents Label9 As Label
End Class
