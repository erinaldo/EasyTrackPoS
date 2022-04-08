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
        CType(Me.gvUserProfiles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.gvUserProfiles.BackgroundColor = System.Drawing.Color.White
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
        Me.gvUserProfiles.Location = New System.Drawing.Point(21, 263)
        Me.gvUserProfiles.Name = "gvUserProfiles"
        Me.gvUserProfiles.ReadOnly = True
        Me.gvUserProfiles.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.gvUserProfiles.RowHeadersVisible = False
        Me.gvUserProfiles.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.gvUserProfiles.RowTemplate.Height = 25
        Me.gvUserProfiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gvUserProfiles.Size = New System.Drawing.Size(781, 301)
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
        Me.Guna2PictureBox2.ShadowDecoration.Parent = Me.Guna2PictureBox2
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
        Me.Guna2PictureBox1.ShadowDecoration.Parent = Me.Guna2PictureBox1
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
        'frmUserProfilemgmt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(829, 635)
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
End Class
