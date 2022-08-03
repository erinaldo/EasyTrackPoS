<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmUserProfilemgmt
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUserProfilemgmt))
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtUserpassword = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtUserId = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.cbCustName = New System.Windows.Forms.ComboBox()
        Me.cbUsergroup = New System.Windows.Forms.ComboBox()
        Me.cbUsertype = New System.Windows.Forms.ComboBox()
        Me.gvUserProfiles = New System.Windows.Forms.DataGridView()
        Me.BunifuThinButton21 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.BunifuThinButton22 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.lbluserid = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ckproforma = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.ckclosesess = New System.Windows.Forms.CheckBox()
        Me.CheckBox21 = New System.Windows.Forms.CheckBox()
        Me.CheckBox22 = New System.Windows.Forms.CheckBox()
        Me.CheckBox23 = New System.Windows.Forms.CheckBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.CheckBox24 = New System.Windows.Forms.CheckBox()
        Me.ckrecievecs = New System.Windows.Forms.CheckBox()
        Me.ckmodcs = New System.Windows.Forms.CheckBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ckcreatecs = New System.Windows.Forms.CheckBox()
        Me.ckdisc = New System.Windows.Forms.CheckBox()
        Me.ckcancsale = New System.Windows.Forms.CheckBox()
        Me.cksell = New System.Windows.Forms.CheckBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ckopensession = New System.Windows.Forms.CheckBox()
        Me.ckmultisale = New System.Windows.Forms.CheckBox()
        Me.ckmultiissue = New System.Windows.Forms.CheckBox()
        Me.ckadjstock = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ckrecgoods = New System.Windows.Forms.CheckBox()
        Me.ckchangeprice = New System.Windows.Forms.CheckBox()
        Me.ckdelprod = New System.Windows.Forms.CheckBox()
        Me.ckmodprod = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ckcreateprod = New System.Windows.Forms.CheckBox()
        CType(Me.gvUserProfiles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(72, 203)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 21)
        Me.Label6.TabIndex = 127
        Me.Label6.Text = "Module"
        Me.Label6.Visible = False
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(507, 136)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 21)
        Me.Label5.TabIndex = 125
        Me.Label5.Text = "User Type"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(496, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 21)
        Me.Label4.TabIndex = 123
        Me.Label4.Text = "User Group"
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(29, 157)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 21)
        Me.Label3.TabIndex = 121
        Me.Label3.Text = "User Password"
        '
        'txtUserpassword
        '
        Me.txtUserpassword.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtUserpassword.BackColor = System.Drawing.Color.White
        Me.txtUserpassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUserpassword.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtUserpassword.Location = New System.Drawing.Point(181, 155)
        Me.txtUserpassword.Name = "txtUserpassword"
        Me.txtUserpassword.Size = New System.Drawing.Size(191, 29)
        Me.txtUserpassword.TabIndex = 2
        Me.txtUserpassword.UseSystemPasswordChar = True
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(69, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 21)
        Me.Label2.TabIndex = 119
        Me.Label2.Text = "User ID"
        '
        'txtUserId
        '
        Me.txtUserId.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtUserId.BackColor = System.Drawing.Color.White
        Me.txtUserId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUserId.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtUserId.Location = New System.Drawing.Point(181, 112)
        Me.txtUserId.Name = "txtUserId"
        Me.txtUserId.Size = New System.Drawing.Size(191, 29)
        Me.txtUserId.TabIndex = 1
        '
        'Label13
        '
        Me.Label13.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label13.Location = New System.Drawing.Point(52, 77)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(94, 21)
        Me.Label13.TabIndex = 117
        Me.Label13.Text = "User Name"
        '
        'txtName
        '
        Me.txtName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtName.BackColor = System.Drawing.Color.White
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtName.Location = New System.Drawing.Point(181, 77)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(191, 29)
        Me.txtName.TabIndex = 0
        '
        'cbCustName
        '
        Me.cbCustName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbCustName.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.cbCustName.FormattingEnabled = True
        Me.cbCustName.Location = New System.Drawing.Point(184, 197)
        Me.cbCustName.Name = "cbCustName"
        Me.cbCustName.Size = New System.Drawing.Size(191, 33)
        Me.cbCustName.TabIndex = 3
        Me.cbCustName.Visible = False
        '
        'cbUsergroup
        '
        Me.cbUsergroup.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbUsergroup.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbUsergroup.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.cbUsergroup.FormattingEnabled = True
        Me.cbUsergroup.Items.AddRange(New Object() {"Management", "Operational"})
        Me.cbUsergroup.Location = New System.Drawing.Point(610, 75)
        Me.cbUsergroup.Name = "cbUsergroup"
        Me.cbUsergroup.Size = New System.Drawing.Size(183, 33)
        Me.cbUsergroup.TabIndex = 129
        '
        'cbUsertype
        '
        Me.cbUsertype.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbUsertype.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbUsertype.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.cbUsertype.FormattingEnabled = True
        Me.cbUsertype.Items.AddRange(New Object() {"Admin", "PosCashier", "BranchCashier"})
        Me.cbUsertype.Location = New System.Drawing.Point(610, 130)
        Me.cbUsertype.Name = "cbUsertype"
        Me.cbUsertype.Size = New System.Drawing.Size(183, 33)
        Me.cbUsertype.TabIndex = 130
        '
        'gvUserProfiles
        '
        Me.gvUserProfiles.AllowUserToAddRows = False
        Me.gvUserProfiles.AllowUserToDeleteRows = False
        Me.gvUserProfiles.AllowUserToOrderColumns = True
        Me.gvUserProfiles.AllowUserToResizeRows = False
        Me.gvUserProfiles.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gvUserProfiles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gvUserProfiles.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.gvUserProfiles.BackgroundColor = System.Drawing.Color.Silver
        Me.gvUserProfiles.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.gvUserProfiles.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.gvUserProfiles.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gvUserProfiles.DefaultCellStyle = DataGridViewCellStyle1
        Me.gvUserProfiles.GridColor = System.Drawing.Color.DarkRed
        Me.gvUserProfiles.Location = New System.Drawing.Point(21, 270)
        Me.gvUserProfiles.Name = "gvUserProfiles"
        Me.gvUserProfiles.ReadOnly = True
        Me.gvUserProfiles.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.gvUserProfiles.RowHeadersVisible = False
        Me.gvUserProfiles.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.gvUserProfiles.RowTemplate.Height = 25
        Me.gvUserProfiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gvUserProfiles.Size = New System.Drawing.Size(781, 294)
        Me.gvUserProfiles.TabIndex = 132
        '
        'BunifuThinButton21
        '
        Me.BunifuThinButton21.ActiveBorderThickness = 1
        Me.BunifuThinButton21.ActiveCornerRadius = 20
        Me.BunifuThinButton21.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton21.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton21.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton21.BackColor = System.Drawing.SystemColors.Control
        Me.BunifuThinButton21.BackgroundImage = CType(resources.GetObject("BunifuThinButton21.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton21.ButtonText = "Add User"
        Me.BunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton21.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton21.IdleBorderThickness = 1
        Me.BunifuThinButton21.IdleCornerRadius = 20
        Me.BunifuThinButton21.IdleFillColor = System.Drawing.Color.White
        Me.BunifuThinButton21.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton21.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton21.Location = New System.Drawing.Point(631, 221)
        Me.BunifuThinButton21.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton21.Name = "BunifuThinButton21"
        Me.BunifuThinButton21.Size = New System.Drawing.Size(143, 41)
        Me.BunifuThinButton21.TabIndex = 133
        Me.BunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel1.Controls.Add(Me.Guna2PictureBox2)
        Me.Panel1.Controls.Add(Me.Guna2PictureBox1)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(-1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(831, 55)
        Me.Panel1.TabIndex = 143
        '
        'Guna2PictureBox2
        '
        Me.Guna2PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2PictureBox2.Image = CType(resources.GetObject("Guna2PictureBox2.Image"), System.Drawing.Image)
        Me.Guna2PictureBox2.ImageRotate = 0!
        Me.Guna2PictureBox2.Location = New System.Drawing.Point(753, 2)
        Me.Guna2PictureBox2.Name = "Guna2PictureBox2"
        Me.Guna2PictureBox2.Size = New System.Drawing.Size(40, 27)
        Me.Guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox2.TabIndex = 143
        Me.Guna2PictureBox2.TabStop = False
        Me.Guna2PictureBox2.Visible = False
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2PictureBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(785, 0)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(43, 32)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox1.TabIndex = 142
        Me.Guna2PictureBox1.TabStop = False
        Me.Guna2PictureBox1.Visible = False
        '
        'Label9
        '
        Me.Label9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(60, 3)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(327, 45)
        Me.Label9.TabIndex = 141
        Me.Label9.Text = "Profile Management"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(13, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(41, 42)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 105
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'lblUsername
        '
        Me.lblUsername.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.Location = New System.Drawing.Point(69, 580)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(146, 37)
        Me.lblUsername.TabIndex = 144
        Me.lblUsername.Text = "Username"
        '
        'BunifuThinButton22
        '
        Me.BunifuThinButton22.ActiveBorderThickness = 1
        Me.BunifuThinButton22.ActiveCornerRadius = 20
        Me.BunifuThinButton22.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton22.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton22.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton22.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuThinButton22.BackColor = System.Drawing.SystemColors.Control
        Me.BunifuThinButton22.BackgroundImage = CType(resources.GetObject("BunifuThinButton22.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton22.ButtonText = "Delete User"
        Me.BunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton22.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton22.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton22.IdleBorderThickness = 1
        Me.BunifuThinButton22.IdleCornerRadius = 20
        Me.BunifuThinButton22.IdleFillColor = System.Drawing.Color.White
        Me.BunifuThinButton22.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton22.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton22.Location = New System.Drawing.Point(571, 580)
        Me.BunifuThinButton22.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton22.Name = "BunifuThinButton22"
        Me.BunifuThinButton22.Size = New System.Drawing.Size(181, 41)
        Me.BunifuThinButton22.TabIndex = 145
        Me.BunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbluserid
        '
        Me.lbluserid.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbluserid.AutoSize = True
        Me.lbluserid.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lbluserid.Location = New System.Drawing.Point(427, 209)
        Me.lbluserid.Name = "lbluserid"
        Me.lbluserid.Size = New System.Drawing.Size(19, 21)
        Me.lbluserid.TabIndex = 146
        Me.lbluserid.Text = "#"
        Me.lbluserid.Visible = False
        '
        'ComboBox1
        '
        Me.ComboBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComboBox1.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(610, 180)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(183, 33)
        Me.ComboBox1.TabIndex = 148
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(487, 186)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 21)
        Me.Label1.TabIndex = 147
        Me.Label1.Text = "Branch Name"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.GroupBox1.Controls.Add(Me.ckproforma)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.ckclosesess)
        Me.GroupBox1.Controls.Add(Me.CheckBox21)
        Me.GroupBox1.Controls.Add(Me.CheckBox22)
        Me.GroupBox1.Controls.Add(Me.CheckBox23)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.CheckBox24)
        Me.GroupBox1.Controls.Add(Me.ckrecievecs)
        Me.GroupBox1.Controls.Add(Me.ckmodcs)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.ckcreatecs)
        Me.GroupBox1.Controls.Add(Me.ckdisc)
        Me.GroupBox1.Controls.Add(Me.ckcancsale)
        Me.GroupBox1.Controls.Add(Me.cksell)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.ckopensession)
        Me.GroupBox1.Controls.Add(Me.ckmultisale)
        Me.GroupBox1.Controls.Add(Me.ckmultiissue)
        Me.GroupBox1.Controls.Add(Me.ckadjstock)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.ckrecgoods)
        Me.GroupBox1.Controls.Add(Me.ckchangeprice)
        Me.GroupBox1.Controls.Add(Me.ckdelprod)
        Me.GroupBox1.Controls.Add(Me.ckmodprod)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.ckcreateprod)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 290)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(781, 157)
        Me.GroupBox1.TabIndex = 149
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "User Controls"
        Me.GroupBox1.Visible = False
        '
        'ckproforma
        '
        Me.ckproforma.AutoSize = True
        Me.ckproforma.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckproforma.Location = New System.Drawing.Point(140, 148)
        Me.ckproforma.Name = "ckproforma"
        Me.ckproforma.Size = New System.Drawing.Size(82, 21)
        Me.ckproforma.TabIndex = 181
        Me.ckproforma.Text = "Proforma"
        Me.ckproforma.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(270, 126)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(105, 21)
        Me.CheckBox1.TabIndex = 180
        Me.CheckBox1.Text = "Deposit sales"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'ckclosesess
        '
        Me.ckclosesess.AutoSize = True
        Me.ckclosesess.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckclosesess.Location = New System.Drawing.Point(270, 147)
        Me.ckclosesess.Name = "ckclosesess"
        Me.ckclosesess.Size = New System.Drawing.Size(107, 21)
        Me.ckclosesess.TabIndex = 179
        Me.ckclosesess.Text = "Close Session"
        Me.ckclosesess.UseVisualStyleBackColor = True
        '
        'CheckBox21
        '
        Me.CheckBox21.AutoSize = True
        Me.CheckBox21.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox21.Location = New System.Drawing.Point(609, 121)
        Me.CheckBox21.Name = "CheckBox21"
        Me.CheckBox21.Size = New System.Drawing.Size(113, 21)
        Me.CheckBox21.TabIndex = 178
        Me.CheckBox21.Text = "Multishop Sale"
        Me.CheckBox21.UseVisualStyleBackColor = True
        '
        'CheckBox22
        '
        Me.CheckBox22.AutoSize = True
        Me.CheckBox22.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox22.Location = New System.Drawing.Point(609, 94)
        Me.CheckBox22.Name = "CheckBox22"
        Me.CheckBox22.Size = New System.Drawing.Size(90, 21)
        Me.CheckBox22.TabIndex = 177
        Me.CheckBox22.Text = "Multi-Issue"
        Me.CheckBox22.UseVisualStyleBackColor = True
        '
        'CheckBox23
        '
        Me.CheckBox23.AutoSize = True
        Me.CheckBox23.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox23.Location = New System.Drawing.Point(609, 67)
        Me.CheckBox23.Name = "CheckBox23"
        Me.CheckBox23.Size = New System.Drawing.Size(60, 21)
        Me.CheckBox23.TabIndex = 176
        Me.CheckBox23.Text = "Users"
        Me.CheckBox23.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label14.Location = New System.Drawing.Point(605, 16)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(54, 21)
        Me.Label14.TabIndex = 175
        Me.Label14.Text = "Setup"
        '
        'CheckBox24
        '
        Me.CheckBox24.AutoSize = True
        Me.CheckBox24.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox24.Location = New System.Drawing.Point(609, 40)
        Me.CheckBox24.Name = "CheckBox24"
        Me.CheckBox24.Size = New System.Drawing.Size(86, 21)
        Me.CheckBox24.TabIndex = 174
        Me.CheckBox24.Text = "Add users"
        Me.CheckBox24.UseVisualStyleBackColor = True
        '
        'ckrecievecs
        '
        Me.ckrecievecs.AutoSize = True
        Me.ckrecievecs.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckrecievecs.Location = New System.Drawing.Point(423, 94)
        Me.ckrecievecs.Name = "ckrecievecs"
        Me.ckrecievecs.Size = New System.Drawing.Size(124, 21)
        Me.ckrecievecs.TabIndex = 168
        Me.ckrecievecs.Text = "Recieve Payment"
        Me.ckrecievecs.UseVisualStyleBackColor = True
        '
        'ckmodcs
        '
        Me.ckmodcs.AutoSize = True
        Me.ckmodcs.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckmodcs.Location = New System.Drawing.Point(423, 67)
        Me.ckmodcs.Name = "ckmodcs"
        Me.ckmodcs.Size = New System.Drawing.Size(110, 21)
        Me.ckmodcs.TabIndex = 167
        Me.ckmodcs.Text = "Delete/Modify"
        Me.ckmodcs.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label11.Location = New System.Drawing.Point(404, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(154, 21)
        Me.Label11.TabIndex = 165
        Me.Label11.Text = "Customer/Supplier"
        '
        'ckcreatecs
        '
        Me.ckcreatecs.AutoSize = True
        Me.ckcreatecs.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckcreatecs.Location = New System.Drawing.Point(423, 40)
        Me.ckcreatecs.Name = "ckcreatecs"
        Me.ckcreatecs.Size = New System.Drawing.Size(65, 21)
        Me.ckcreatecs.TabIndex = 164
        Me.ckcreatecs.Text = "Create"
        Me.ckcreatecs.UseVisualStyleBackColor = True
        '
        'ckdisc
        '
        Me.ckdisc.AutoSize = True
        Me.ckdisc.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckdisc.Location = New System.Drawing.Point(270, 105)
        Me.ckdisc.Name = "ckdisc"
        Me.ckdisc.Size = New System.Drawing.Size(77, 21)
        Me.ckdisc.TabIndex = 163
        Me.ckdisc.Text = "Discount"
        Me.ckdisc.UseVisualStyleBackColor = True
        '
        'ckcancsale
        '
        Me.ckcancsale.AutoSize = True
        Me.ckcancsale.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckcancsale.Location = New System.Drawing.Point(270, 84)
        Me.ckcancsale.Name = "ckcancsale"
        Me.ckcancsale.Size = New System.Drawing.Size(99, 21)
        Me.ckcancsale.TabIndex = 162
        Me.ckcancsale.Text = "Cancel Sales"
        Me.ckcancsale.UseVisualStyleBackColor = True
        '
        'cksell
        '
        Me.cksell.AutoSize = True
        Me.cksell.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cksell.Location = New System.Drawing.Point(270, 63)
        Me.cksell.Name = "cksell"
        Me.cksell.Size = New System.Drawing.Size(47, 21)
        Me.cksell.TabIndex = 161
        Me.cksell.Text = "Sell"
        Me.cksell.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.Location = New System.Drawing.Point(283, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 21)
        Me.Label10.TabIndex = 160
        Me.Label10.Text = "Sales"
        '
        'ckopensession
        '
        Me.ckopensession.AutoSize = True
        Me.ckopensession.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckopensession.Location = New System.Drawing.Point(270, 42)
        Me.ckopensession.Name = "ckopensession"
        Me.ckopensession.Size = New System.Drawing.Size(107, 21)
        Me.ckopensession.TabIndex = 159
        Me.ckopensession.Text = "Open Session"
        Me.ckopensession.UseVisualStyleBackColor = True
        '
        'ckmultisale
        '
        Me.ckmultisale.AutoSize = True
        Me.ckmultisale.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckmultisale.Location = New System.Drawing.Point(140, 121)
        Me.ckmultisale.Name = "ckmultisale"
        Me.ckmultisale.Size = New System.Drawing.Size(113, 21)
        Me.ckmultisale.TabIndex = 158
        Me.ckmultisale.Text = "Multishop Sale"
        Me.ckmultisale.UseVisualStyleBackColor = True
        '
        'ckmultiissue
        '
        Me.ckmultiissue.AutoSize = True
        Me.ckmultiissue.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckmultiissue.Location = New System.Drawing.Point(140, 94)
        Me.ckmultiissue.Name = "ckmultiissue"
        Me.ckmultiissue.Size = New System.Drawing.Size(90, 21)
        Me.ckmultiissue.TabIndex = 157
        Me.ckmultiissue.Text = "Multi-Issue"
        Me.ckmultiissue.UseVisualStyleBackColor = True
        '
        'ckadjstock
        '
        Me.ckadjstock.AutoSize = True
        Me.ckadjstock.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckadjstock.Location = New System.Drawing.Point(140, 67)
        Me.ckadjstock.Name = "ckadjstock"
        Me.ckadjstock.Size = New System.Drawing.Size(98, 21)
        Me.ckadjstock.TabIndex = 156
        Me.ckadjstock.Text = "Adjust Stock"
        Me.ckadjstock.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(136, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 21)
        Me.Label8.TabIndex = 155
        Me.Label8.Text = "Inventory"
        '
        'ckrecgoods
        '
        Me.ckrecgoods.AutoSize = True
        Me.ckrecgoods.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckrecgoods.Location = New System.Drawing.Point(140, 40)
        Me.ckrecgoods.Name = "ckrecgoods"
        Me.ckrecgoods.Size = New System.Drawing.Size(114, 21)
        Me.ckrecgoods.TabIndex = 154
        Me.ckrecgoods.Text = "Recieve Goods"
        Me.ckrecgoods.UseVisualStyleBackColor = True
        '
        'ckchangeprice
        '
        Me.ckchangeprice.AutoSize = True
        Me.ckchangeprice.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckchangeprice.Location = New System.Drawing.Point(6, 121)
        Me.ckchangeprice.Name = "ckchangeprice"
        Me.ckchangeprice.Size = New System.Drawing.Size(103, 21)
        Me.ckchangeprice.TabIndex = 153
        Me.ckchangeprice.Text = "Change Price"
        Me.ckchangeprice.UseVisualStyleBackColor = True
        '
        'ckdelprod
        '
        Me.ckdelprod.AutoSize = True
        Me.ckdelprod.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckdelprod.Location = New System.Drawing.Point(6, 94)
        Me.ckdelprod.Name = "ckdelprod"
        Me.ckdelprod.Size = New System.Drawing.Size(113, 21)
        Me.ckdelprod.TabIndex = 152
        Me.ckdelprod.Text = "Delete Product"
        Me.ckdelprod.UseVisualStyleBackColor = True
        '
        'ckmodprod
        '
        Me.ckmodprod.AutoSize = True
        Me.ckmodprod.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckmodprod.Location = New System.Drawing.Point(6, 67)
        Me.ckmodprod.Name = "ckmodprod"
        Me.ckmodprod.Size = New System.Drawing.Size(118, 21)
        Me.ckmodprod.TabIndex = 151
        Me.ckmodprod.Text = "Modify product"
        Me.ckmodprod.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(12, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 21)
        Me.Label7.TabIndex = 150
        Me.Label7.Text = "Product "
        '
        'ckcreateprod
        '
        Me.ckcreateprod.AutoSize = True
        Me.ckcreateprod.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckcreateprod.Location = New System.Drawing.Point(6, 40)
        Me.ckcreateprod.Name = "ckcreateprod"
        Me.ckcreateprod.Size = New System.Drawing.Size(114, 21)
        Me.ckcreateprod.TabIndex = 0
        Me.ckcreateprod.Text = "Create Product"
        Me.ckcreateprod.UseVisualStyleBackColor = True
        '
        'frmUserProfilemgmt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(829, 635)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbluserid)
        Me.Controls.Add(Me.BunifuThinButton22)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BunifuThinButton21)
        Me.Controls.Add(Me.gvUserProfiles)
        Me.Controls.Add(Me.cbUsertype)
        Me.Controls.Add(Me.cbUsergroup)
        Me.Controls.Add(Me.cbCustName)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtUserpassword)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtUserId)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmUserProfilemgmt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmUserProfilemgmt"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.gvUserProfiles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtUserpassword As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUserId As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents cbCustName As ComboBox
    Friend WithEvents cbUsergroup As ComboBox
    Friend WithEvents cbUsertype As ComboBox
    Friend WithEvents gvUserProfiles As DataGridView
    Friend WithEvents BunifuThinButton21 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblUsername As Label
    Friend WithEvents BunifuThinButton22 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents lbluserid As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ckchangeprice As CheckBox
    Friend WithEvents ckdelprod As CheckBox
    Friend WithEvents ckmodprod As CheckBox
    Friend WithEvents Label7 As Label
    Friend WithEvents ckcreateprod As CheckBox
    Friend WithEvents ckmultisale As CheckBox
    Friend WithEvents ckmultiissue As CheckBox
    Friend WithEvents ckadjstock As CheckBox
    Friend WithEvents Label8 As Label
    Friend WithEvents ckrecgoods As CheckBox
    Friend WithEvents ckclosesess As CheckBox
    Friend WithEvents CheckBox21 As CheckBox
    Friend WithEvents CheckBox22 As CheckBox
    Friend WithEvents CheckBox23 As CheckBox
    Friend WithEvents Label14 As Label
    Friend WithEvents CheckBox24 As CheckBox
    Friend WithEvents ckrecievecs As CheckBox
    Friend WithEvents ckmodcs As CheckBox
    Friend WithEvents Label11 As Label
    Friend WithEvents ckcreatecs As CheckBox
    Friend WithEvents ckdisc As CheckBox
    Friend WithEvents ckcancsale As CheckBox
    Friend WithEvents cksell As CheckBox
    Friend WithEvents Label10 As Label
    Friend WithEvents ckopensession As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents ckproforma As CheckBox
End Class
