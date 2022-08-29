<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmModifyCustomerAccounts
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmModifyCustomerAccounts))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.txtCardNo = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbCardType = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCardLimit = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtResDigAdd = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtBussLocation = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtResLocation = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtBusDigAdd = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtEmailAdd = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblCustID = New System.Windows.Forms.Label()
        Me.BunifuThinButton21 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BunifuThinButton22 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.gvcust = New Bunifu.UI.WinForms.BunifuDataGridView()
        Me.txtCurrentBalance = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvcust, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(10, 5)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(41, 42)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 102
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
        '
        'txtCardNo
        '
        Me.txtCardNo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtCardNo.BackColor = System.Drawing.Color.White
        Me.txtCardNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCardNo.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtCardNo.Location = New System.Drawing.Point(218, 469)
        Me.txtCardNo.Name = "txtCardNo"
        Me.txtCardNo.ReadOnly = True
        Me.txtCardNo.Size = New System.Drawing.Size(198, 29)
        Me.txtCardNo.TabIndex = 141
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(37, 471)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(133, 21)
        Me.Label9.TabIndex = 140
        Me.Label9.Text = "ID Card Number"
        '
        'cbCardType
        '
        Me.cbCardType.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cbCardType.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.cbCardType.FormattingEnabled = True
        Me.cbCardType.Location = New System.Drawing.Point(218, 417)
        Me.cbCardType.Name = "cbCardType"
        Me.cbCardType.Size = New System.Drawing.Size(198, 33)
        Me.cbCardType.TabIndex = 139
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(41, 429)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(104, 21)
        Me.Label8.TabIndex = 138
        Me.Label8.Text = "ID Card type"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(41, 374)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 21)
        Me.Label7.TabIndex = 137
        Me.Label7.Text = "Credit Limit"
        '
        'txtCardLimit
        '
        Me.txtCardLimit.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtCardLimit.BackColor = System.Drawing.Color.White
        Me.txtCardLimit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCardLimit.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtCardLimit.Location = New System.Drawing.Point(218, 372)
        Me.txtCardLimit.Name = "txtCardLimit"
        Me.txtCardLimit.Size = New System.Drawing.Size(198, 29)
        Me.txtCardLimit.TabIndex = 136
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(-3, 243)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(215, 21)
        Me.Label6.TabIndex = 135
        Me.Label6.Text = "Residential Digital Address"
        '
        'txtResDigAdd
        '
        Me.txtResDigAdd.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtResDigAdd.BackColor = System.Drawing.Color.White
        Me.txtResDigAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtResDigAdd.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtResDigAdd.Location = New System.Drawing.Point(218, 235)
        Me.txtResDigAdd.Name = "txtResDigAdd"
        Me.txtResDigAdd.Size = New System.Drawing.Size(198, 29)
        Me.txtResDigAdd.TabIndex = 134
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(29, 332)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(145, 21)
        Me.Label5.TabIndex = 133
        Me.Label5.Text = "Business Location"
        '
        'txtBussLocation
        '
        Me.txtBussLocation.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtBussLocation.BackColor = System.Drawing.Color.White
        Me.txtBussLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBussLocation.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtBussLocation.Location = New System.Drawing.Point(218, 324)
        Me.txtBussLocation.Name = "txtBussLocation"
        Me.txtBussLocation.Size = New System.Drawing.Size(198, 29)
        Me.txtBussLocation.TabIndex = 132
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(29, 283)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(165, 21)
        Me.Label4.TabIndex = 131
        Me.Label4.Text = "Residentail Location"
        '
        'txtResLocation
        '
        Me.txtResLocation.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtResLocation.BackColor = System.Drawing.Color.White
        Me.txtResLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtResLocation.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtResLocation.Location = New System.Drawing.Point(218, 275)
        Me.txtResLocation.Name = "txtResLocation"
        Me.txtResLocation.Size = New System.Drawing.Size(198, 29)
        Me.txtResLocation.TabIndex = 130
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(7, 194)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(195, 21)
        Me.Label3.TabIndex = 129
        Me.Label3.Text = "Business Digital Address"
        '
        'txtBusDigAdd
        '
        Me.txtBusDigAdd.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtBusDigAdd.BackColor = System.Drawing.Color.White
        Me.txtBusDigAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBusDigAdd.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtBusDigAdd.Location = New System.Drawing.Point(218, 192)
        Me.txtBusDigAdd.Name = "txtBusDigAdd"
        Me.txtBusDigAdd.Size = New System.Drawing.Size(198, 29)
        Me.txtBusDigAdd.TabIndex = 128
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(41, 150)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 21)
        Me.Label2.TabIndex = 127
        Me.Label2.Text = "Email Address"
        '
        'txtEmailAdd
        '
        Me.txtEmailAdd.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtEmailAdd.BackColor = System.Drawing.Color.White
        Me.txtEmailAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmailAdd.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtEmailAdd.Location = New System.Drawing.Point(218, 150)
        Me.txtEmailAdd.Name = "txtEmailAdd"
        Me.txtEmailAdd.Size = New System.Drawing.Size(198, 29)
        Me.txtEmailAdd.TabIndex = 126
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label13.Location = New System.Drawing.Point(72, 101)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 21)
        Me.Label13.TabIndex = 125
        Me.Label13.Text = "Name"
        '
        'txtName
        '
        Me.txtName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtName.BackColor = System.Drawing.Color.White
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtName.Location = New System.Drawing.Point(218, 99)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(198, 29)
        Me.txtName.TabIndex = 124
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.Location = New System.Drawing.Point(506, 57)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(104, 21)
        Me.Label10.TabIndex = 144
        Me.Label10.Text = "Customer ID"
        '
        'lblCustID
        '
        Me.lblCustID.AutoSize = True
        Me.lblCustID.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblCustID.Location = New System.Drawing.Point(616, 57)
        Me.lblCustID.Name = "lblCustID"
        Me.lblCustID.Size = New System.Drawing.Size(104, 21)
        Me.lblCustID.TabIndex = 145
        Me.lblCustID.Text = "Customer ID"
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
        Me.BunifuThinButton21.ButtonText = "Update"
        Me.BunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton21.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton21.IdleBorderThickness = 1
        Me.BunifuThinButton21.IdleCornerRadius = 20
        Me.BunifuThinButton21.IdleFillColor = System.Drawing.Color.White
        Me.BunifuThinButton21.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton21.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton21.Location = New System.Drawing.Point(132, 560)
        Me.BunifuThinButton21.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.BunifuThinButton21.Name = "BunifuThinButton21"
        Me.BunifuThinButton21.Size = New System.Drawing.Size(214, 45)
        Me.BunifuThinButton21.TabIndex = 146
        Me.BunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Teal
        Me.Panel1.Controls.Add(Me.BunifuThinButton22)
        Me.Panel1.Controls.Add(Me.Guna2PictureBox2)
        Me.Panel1.Controls.Add(Me.Guna2PictureBox1)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Location = New System.Drawing.Point(0, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(960, 82)
        Me.Panel1.TabIndex = 147
        '
        'BunifuThinButton22
        '
        Me.BunifuThinButton22.ActiveBorderThickness = 1
        Me.BunifuThinButton22.ActiveCornerRadius = 20
        Me.BunifuThinButton22.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton22.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton22.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton22.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuThinButton22.BackColor = System.Drawing.Color.Teal
        Me.BunifuThinButton22.BackgroundImage = CType(resources.GetObject("BunifuThinButton22.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton22.ButtonText = "Refresh"
        Me.BunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton22.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton22.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton22.IdleBorderThickness = 1
        Me.BunifuThinButton22.IdleCornerRadius = 20
        Me.BunifuThinButton22.IdleFillColor = System.Drawing.Color.White
        Me.BunifuThinButton22.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton22.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton22.Location = New System.Drawing.Point(760, 15)
        Me.BunifuThinButton22.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton22.Name = "BunifuThinButton22"
        Me.BunifuThinButton22.Size = New System.Drawing.Size(155, 46)
        Me.BunifuThinButton22.TabIndex = 152
        Me.BunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2PictureBox2
        '
        Me.Guna2PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2PictureBox2.Image = CType(resources.GetObject("Guna2PictureBox2.Image"), System.Drawing.Image)
        Me.Guna2PictureBox2.ImageRotate = 0!
        Me.Guna2PictureBox2.Location = New System.Drawing.Point(875, 5)
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
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(907, 3)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(43, 32)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox1.TabIndex = 142
        Me.Guna2PictureBox1.TabStop = False
        Me.Guna2PictureBox1.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Bold)
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(0, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(258, 40)
        Me.Label11.TabIndex = 103
        Me.Label11.Text = "Modify Customer"
        '
        'gvcust
        '
        Me.gvcust.AllowCustomTheming = True
        Me.gvcust.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.gvcust.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.gvcust.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gvcust.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.gvcust.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.gvcust.BackgroundColor = System.Drawing.Color.White
        Me.gvcust.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.gvcust.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.gvcust.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gvcust.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.gvcust.ColumnHeadersHeight = 25
        Me.gvcust.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.gvcust.CurrentTheme.AlternatingRowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.gvcust.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black
        Me.gvcust.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.gvcust.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White
        Me.gvcust.CurrentTheme.BackColor = System.Drawing.Color.White
        Me.gvcust.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.gvcust.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.SteelBlue
        Me.gvcust.CurrentTheme.HeaderStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        Me.gvcust.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.gvcust.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.gvcust.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White
        Me.gvcust.CurrentTheme.Name = Nothing
        Me.gvcust.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.gvcust.CurrentTheme.RowsStyle.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvcust.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.gvcust.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.gvcust.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(178, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.gvcust.DefaultCellStyle = DataGridViewCellStyle3
        Me.gvcust.EnableHeadersVisualStyles = False
        Me.gvcust.GridColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.gvcust.HeaderBackColor = System.Drawing.Color.SteelBlue
        Me.gvcust.HeaderBgColor = System.Drawing.Color.Empty
        Me.gvcust.HeaderForeColor = System.Drawing.Color.White
        Me.gvcust.Location = New System.Drawing.Point(440, 101)
        Me.gvcust.MultiSelect = False
        Me.gvcust.Name = "gvcust"
        Me.gvcust.ReadOnly = True
        Me.gvcust.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI Semilight", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gvcust.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.gvcust.RowHeadersVisible = False
        Me.gvcust.RowTemplate.Height = 40
        Me.gvcust.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gvcust.Size = New System.Drawing.Size(507, 507)
        Me.gvcust.TabIndex = 148
        Me.gvcust.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Teal
        '
        'txtCurrentBalance
        '
        Me.txtCurrentBalance.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtCurrentBalance.BackColor = System.Drawing.Color.White
        Me.txtCurrentBalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCurrentBalance.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtCurrentBalance.Location = New System.Drawing.Point(218, 516)
        Me.txtCurrentBalance.Name = "txtCurrentBalance"
        Me.txtCurrentBalance.ReadOnly = True
        Me.txtCurrentBalance.Size = New System.Drawing.Size(198, 29)
        Me.txtCurrentBalance.TabIndex = 150
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(37, 524)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 21)
        Me.Label1.TabIndex = 149
        Me.Label1.Text = "Cutomer Balance"
        '
        'frmModifyCustomerAccounts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(959, 620)
        Me.Controls.Add(Me.txtCurrentBalance)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.gvcust)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BunifuThinButton21)
        Me.Controls.Add(Me.lblCustID)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtCardNo)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cbCardType)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtCardLimit)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtResDigAdd)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtBussLocation)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtResLocation)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtBusDigAdd)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtEmailAdd)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmModifyCustomerAccounts"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modify Customer Accounts"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvcust, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents txtCardNo As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cbCardType As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtCardLimit As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtResDigAdd As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtBussLocation As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtResLocation As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtBusDigAdd As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtEmailAdd As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents lblCustID As Label
    Friend WithEvents BunifuThinButton21 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Label11 As Label
    Friend WithEvents gvcust As Bunifu.UI.WinForms.BunifuDataGridView
    Friend WithEvents BunifuThinButton22 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents txtCurrentBalance As TextBox
    Friend WithEvents Label1 As Label
End Class
