<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChangePrice
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChangePrice))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblStockCode = New System.Windows.Forms.Label()
        Me.txtProdname = New System.Windows.Forms.TextBox()
        Me.txtOldWPrice = New System.Windows.Forms.TextBox()
        Me.txtNewRPrice = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lbltime = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.BunifuThinButton23 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblBandCode = New System.Windows.Forms.Label()
        Me.txtBandName = New System.Windows.Forms.TextBox()
        Me.BunifuThinButton22 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbItemName = New System.Windows.Forms.ComboBox()
        Me.gvPriceBand = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtBandPrice = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtToQty = New System.Windows.Forms.TextBox()
        Me.txtFromQty = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtOldRPrice = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNewWPrice = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbChangepriceSrch = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gvStockguna = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.BunifuThinButton21 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lblpackvol = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtnewpckprice = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtoldpckprice = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lblnewcamt = New System.Windows.Forms.Label()
        Me.lbloldcamt = New System.Windows.Forms.Label()
        Me.lblnewramt = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lbluser = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblodlRamt = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.gvPriceBatch = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Itemname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OldRPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NewRPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OldCPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NewCprice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OldRAmt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NewRAmt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OldCostAmt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NewCostAmt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prodcode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NewPackPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OldpackPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblqty = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.gvPriceBand, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvStockguna, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.gvPriceBatch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblStockCode
        '
        Me.lblStockCode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblStockCode.AutoSize = True
        Me.lblStockCode.BackColor = System.Drawing.SystemColors.Control
        Me.lblStockCode.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStockCode.ForeColor = System.Drawing.Color.Black
        Me.lblStockCode.Location = New System.Drawing.Point(814, 21)
        Me.lblStockCode.Name = "lblStockCode"
        Me.lblStockCode.Size = New System.Drawing.Size(87, 21)
        Me.lblStockCode.TabIndex = 51
        Me.lblStockCode.Text = "Item Code"
        Me.lblStockCode.Visible = False
        '
        'txtProdname
        '
        Me.txtProdname.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtProdname.Font = New System.Drawing.Font("Tahoma", 24.0!)
        Me.txtProdname.Location = New System.Drawing.Point(11, 55)
        Me.txtProdname.Name = "txtProdname"
        Me.txtProdname.ReadOnly = True
        Me.txtProdname.Size = New System.Drawing.Size(308, 46)
        Me.txtProdname.TabIndex = 49
        '
        'txtOldWPrice
        '
        Me.txtOldWPrice.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtOldWPrice.Enabled = False
        Me.txtOldWPrice.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOldWPrice.Location = New System.Drawing.Point(156, 149)
        Me.txtOldWPrice.Name = "txtOldWPrice"
        Me.txtOldWPrice.Size = New System.Drawing.Size(57, 35)
        Me.txtOldWPrice.TabIndex = 40
        '
        'txtNewRPrice
        '
        Me.txtNewRPrice.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtNewRPrice.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewRPrice.Location = New System.Drawing.Point(86, 149)
        Me.txtNewRPrice.Name = "txtNewRPrice"
        Me.txtNewRPrice.Size = New System.Drawing.Size(63, 35)
        Me.txtNewRPrice.TabIndex = 39
        '
        'Label13
        '
        Me.Label13.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.SystemColors.Control
        Me.Label13.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(157, 104)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(84, 21)
        Me.Label13.TabIndex = 37
        Me.Label13.Text = "Cost price"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.MediumPurple
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(122, 3)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(229, 45)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Change Prices"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.MediumPurple
        Me.Panel2.Controls.Add(Me.lbltime)
        Me.Panel2.Controls.Add(Me.lblDate)
        Me.Panel2.Controls.Add(Me.BunifuThinButton23)
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Location = New System.Drawing.Point(-1, -1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(989, 56)
        Me.Panel2.TabIndex = 28
        '
        'lbltime
        '
        Me.lbltime.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbltime.AutoSize = True
        Me.lbltime.BackColor = System.Drawing.SystemColors.Control
        Me.lbltime.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltime.ForeColor = System.Drawing.Color.Black
        Me.lbltime.Location = New System.Drawing.Point(477, 18)
        Me.lbltime.Name = "lbltime"
        Me.lbltime.Size = New System.Drawing.Size(43, 21)
        Me.lbltime.TabIndex = 148
        Me.lbltime.Text = "time"
        Me.lbltime.Visible = False
        '
        'lblDate
        '
        Me.lblDate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblDate.AutoSize = True
        Me.lblDate.BackColor = System.Drawing.SystemColors.Control
        Me.lblDate.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.Black
        Me.lblDate.Location = New System.Drawing.Point(398, 10)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(44, 21)
        Me.lblDate.TabIndex = 73
        Me.lblDate.Text = "Date"
        Me.lblDate.Visible = False
        '
        'BunifuThinButton23
        '
        Me.BunifuThinButton23.ActiveBorderThickness = 1
        Me.BunifuThinButton23.ActiveCornerRadius = 20
        Me.BunifuThinButton23.ActiveFillColor = System.Drawing.Color.SteelBlue
        Me.BunifuThinButton23.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton23.ActiveLineColor = System.Drawing.Color.MediumPurple
        Me.BunifuThinButton23.BackColor = System.Drawing.Color.MediumPurple
        Me.BunifuThinButton23.BackgroundImage = CType(resources.GetObject("BunifuThinButton23.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton23.ButtonText = "Refresh"
        Me.BunifuThinButton23.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton23.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton23.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton23.IdleBorderThickness = 1
        Me.BunifuThinButton23.IdleCornerRadius = 20
        Me.BunifuThinButton23.IdleFillColor = System.Drawing.Color.White
        Me.BunifuThinButton23.IdleForecolor = System.Drawing.Color.MediumPurple
        Me.BunifuThinButton23.IdleLineColor = System.Drawing.Color.MediumPurple
        Me.BunifuThinButton23.Location = New System.Drawing.Point(806, 3)
        Me.BunifuThinButton23.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton23.Name = "BunifuThinButton23"
        Me.BunifuThinButton23.Size = New System.Drawing.Size(102, 51)
        Me.BunifuThinButton23.TabIndex = 61
        Me.BunifuThinButton23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.Turquoise
        Me.GroupBox1.Controls.Add(Me.lblBandCode)
        Me.GroupBox1.Controls.Add(Me.txtBandName)
        Me.GroupBox1.Controls.Add(Me.BunifuThinButton22)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.cbItemName)
        Me.GroupBox1.Controls.Add(Me.gvPriceBand)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtBandPrice)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtToQty)
        Me.GroupBox1.Controls.Add(Me.txtFromQty)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(649, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(149, 22)
        Me.GroupBox1.TabIndex = 60
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Price Band"
        Me.GroupBox1.Visible = False
        '
        'lblBandCode
        '
        Me.lblBandCode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblBandCode.AutoSize = True
        Me.lblBandCode.BackColor = System.Drawing.Color.Turquoise
        Me.lblBandCode.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBandCode.ForeColor = System.Drawing.Color.Black
        Me.lblBandCode.Location = New System.Drawing.Point(394, 24)
        Me.lblBandCode.Name = "lblBandCode"
        Me.lblBandCode.Size = New System.Drawing.Size(87, 21)
        Me.lblBandCode.TabIndex = 61
        Me.lblBandCode.Text = "Item Code"
        Me.lblBandCode.Visible = False
        '
        'txtBandName
        '
        Me.txtBandName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtBandName.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBandName.Location = New System.Drawing.Point(331, 116)
        Me.txtBandName.Name = "txtBandName"
        Me.txtBandName.Size = New System.Drawing.Size(150, 35)
        Me.txtBandName.TabIndex = 72
        '
        'BunifuThinButton22
        '
        Me.BunifuThinButton22.ActiveBorderThickness = 1
        Me.BunifuThinButton22.ActiveCornerRadius = 20
        Me.BunifuThinButton22.ActiveFillColor = System.Drawing.Color.SteelBlue
        Me.BunifuThinButton22.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton22.ActiveLineColor = System.Drawing.Color.MediumPurple
        Me.BunifuThinButton22.BackColor = System.Drawing.Color.Turquoise
        Me.BunifuThinButton22.BackgroundImage = CType(resources.GetObject("BunifuThinButton22.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton22.ButtonText = "Create Band"
        Me.BunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton22.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton22.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton22.IdleBorderThickness = 1
        Me.BunifuThinButton22.IdleCornerRadius = 20
        Me.BunifuThinButton22.IdleFillColor = System.Drawing.Color.White
        Me.BunifuThinButton22.IdleForecolor = System.Drawing.Color.MediumPurple
        Me.BunifuThinButton22.IdleLineColor = System.Drawing.Color.MediumPurple
        Me.BunifuThinButton22.Location = New System.Drawing.Point(307, 165)
        Me.BunifuThinButton22.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton22.Name = "BunifuThinButton22"
        Me.BunifuThinButton22.Size = New System.Drawing.Size(141, 47)
        Me.BunifuThinButton22.TabIndex = 61
        Me.BunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Turquoise
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(174, 130)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(27, 21)
        Me.Label10.TabIndex = 71
        Me.Label10.Text = "To"
        '
        'Label9
        '
        Me.Label9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Turquoise
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(9, 130)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 21)
        Me.Label9.TabIndex = 70
        Me.Label9.Text = "From"
        '
        'cbItemName
        '
        Me.cbItemName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbItemName.FormattingEnabled = True
        Me.cbItemName.Items.AddRange(New Object() {"<", ">", "<=", ">=", "="})
        Me.cbItemName.Location = New System.Drawing.Point(12, 52)
        Me.cbItemName.Name = "cbItemName"
        Me.cbItemName.Size = New System.Drawing.Size(384, 29)
        Me.cbItemName.TabIndex = 69
        '
        'gvPriceBand
        '
        Me.gvPriceBand.AllowUserToAddRows = False
        Me.gvPriceBand.AllowUserToDeleteRows = False
        Me.gvPriceBand.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.gvPriceBand.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.gvPriceBand.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gvPriceBand.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.gvPriceBand.BackgroundColor = System.Drawing.Color.White
        Me.gvPriceBand.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.gvPriceBand.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.gvPriceBand.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gvPriceBand.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.gvPriceBand.ColumnHeadersHeight = 30
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.gvPriceBand.DefaultCellStyle = DataGridViewCellStyle3
        Me.gvPriceBand.EnableHeadersVisualStyles = False
        Me.gvPriceBand.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvPriceBand.Location = New System.Drawing.Point(512, 24)
        Me.gvPriceBand.MultiSelect = False
        Me.gvPriceBand.Name = "gvPriceBand"
        Me.gvPriceBand.ReadOnly = True
        Me.gvPriceBand.RowHeadersVisible = False
        Me.gvPriceBand.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader
        Me.gvPriceBand.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gvPriceBand.ShowCellErrors = False
        Me.gvPriceBand.ShowEditingIcon = False
        Me.gvPriceBand.ShowRowErrors = False
        Me.gvPriceBand.Size = New System.Drawing.Size(0, 0)
        Me.gvPriceBand.TabIndex = 59
        Me.gvPriceBand.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.gvPriceBand.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.gvPriceBand.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.gvPriceBand.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.gvPriceBand.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.gvPriceBand.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.gvPriceBand.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvPriceBand.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvPriceBand.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.gvPriceBand.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.gvPriceBand.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.gvPriceBand.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.gvPriceBand.ThemeStyle.HeaderStyle.Height = 30
        Me.gvPriceBand.ThemeStyle.ReadOnly = True
        Me.gvPriceBand.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.gvPriceBand.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.gvPriceBand.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.gvPriceBand.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.gvPriceBand.ThemeStyle.RowsStyle.Height = 22
        Me.gvPriceBand.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvPriceBand.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Turquoise
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(19, 187)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 21)
        Me.Label4.TabIndex = 67
        Me.Label4.Text = "Price"
        '
        'txtBandPrice
        '
        Me.txtBandPrice.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtBandPrice.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBandPrice.Location = New System.Drawing.Point(74, 177)
        Me.txtBandPrice.Name = "txtBandPrice"
        Me.txtBandPrice.Size = New System.Drawing.Size(140, 35)
        Me.txtBandPrice.TabIndex = 68
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Turquoise
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(8, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 21)
        Me.Label3.TabIndex = 59
        Me.Label3.Text = "Item Name"
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Turquoise
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(6, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 21)
        Me.Label2.TabIndex = 59
        Me.Label2.Text = "Buy Quantity"
        '
        'txtToQty
        '
        Me.txtToQty.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtToQty.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtToQty.Location = New System.Drawing.Point(216, 120)
        Me.txtToQty.Name = "txtToQty"
        Me.txtToQty.Size = New System.Drawing.Size(76, 35)
        Me.txtToQty.TabIndex = 63
        '
        'txtFromQty
        '
        Me.txtFromQty.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtFromQty.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFromQty.Location = New System.Drawing.Point(73, 120)
        Me.txtFromQty.Name = "txtFromQty"
        Me.txtFromQty.Size = New System.Drawing.Size(85, 35)
        Me.txtFromQty.TabIndex = 62
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.MediumPurple
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(13, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(41, 42)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 98
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'txtOldRPrice
        '
        Me.txtOldRPrice.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtOldRPrice.Enabled = False
        Me.txtOldRPrice.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOldRPrice.Location = New System.Drawing.Point(17, 149)
        Me.txtOldRPrice.Name = "txtOldRPrice"
        Me.txtOldRPrice.Size = New System.Drawing.Size(63, 35)
        Me.txtOldRPrice.TabIndex = 53
        '
        'Label7
        '
        Me.Label7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(25, 104)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 21)
        Me.Label7.TabIndex = 52
        Me.Label7.Text = " Retail Price"
        '
        'txtNewWPrice
        '
        Me.txtNewWPrice.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtNewWPrice.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewWPrice.Location = New System.Drawing.Point(219, 149)
        Me.txtNewWPrice.Name = "txtNewWPrice"
        Me.txtNewWPrice.Size = New System.Drawing.Size(57, 35)
        Me.txtNewWPrice.TabIndex = 55
        '
        'Label8
        '
        Me.Label8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(218, 125)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 21)
        Me.Label8.TabIndex = 54
        Me.Label8.Text = "New "
        '
        'cbChangepriceSrch
        '
        Me.cbChangepriceSrch.AllowDrop = True
        Me.cbChangepriceSrch.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbChangepriceSrch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbChangepriceSrch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbChangepriceSrch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbChangepriceSrch.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbChangepriceSrch.FormattingEnabled = True
        Me.cbChangepriceSrch.Location = New System.Drawing.Point(513, 45)
        Me.cbChangepriceSrch.Name = "cbChangepriceSrch"
        Me.cbChangepriceSrch.Size = New System.Drawing.Size(413, 38)
        Me.cbChangepriceSrch.TabIndex = 56
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(518, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 21)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "Search"
        '
        'gvStockguna
        '
        Me.gvStockguna.AllowUserToAddRows = False
        Me.gvStockguna.AllowUserToDeleteRows = False
        Me.gvStockguna.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.gvStockguna.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.gvStockguna.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gvStockguna.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gvStockguna.BackgroundColor = System.Drawing.Color.White
        Me.gvStockguna.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.gvStockguna.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.gvStockguna.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gvStockguna.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.gvStockguna.ColumnHeadersHeight = 30
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.gvStockguna.DefaultCellStyle = DataGridViewCellStyle6
        Me.gvStockguna.EnableHeadersVisualStyles = False
        Me.gvStockguna.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvStockguna.Location = New System.Drawing.Point(512, 104)
        Me.gvStockguna.MultiSelect = False
        Me.gvStockguna.Name = "gvStockguna"
        Me.gvStockguna.ReadOnly = True
        Me.gvStockguna.RowHeadersVisible = False
        Me.gvStockguna.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader
        Me.gvStockguna.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gvStockguna.ShowCellErrors = False
        Me.gvStockguna.ShowEditingIcon = False
        Me.gvStockguna.ShowRowErrors = False
        Me.gvStockguna.Size = New System.Drawing.Size(414, 449)
        Me.gvStockguna.TabIndex = 58
        Me.gvStockguna.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.gvStockguna.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.gvStockguna.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.gvStockguna.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.gvStockguna.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.gvStockguna.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.gvStockguna.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvStockguna.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvStockguna.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.gvStockguna.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.gvStockguna.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.gvStockguna.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.gvStockguna.ThemeStyle.HeaderStyle.Height = 30
        Me.gvStockguna.ThemeStyle.ReadOnly = True
        Me.gvStockguna.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.gvStockguna.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.gvStockguna.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.gvStockguna.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.gvStockguna.ThemeStyle.RowsStyle.Height = 22
        Me.gvStockguna.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvStockguna.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'BunifuThinButton21
        '
        Me.BunifuThinButton21.ActiveBorderThickness = 1
        Me.BunifuThinButton21.ActiveCornerRadius = 20
        Me.BunifuThinButton21.ActiveFillColor = System.Drawing.Color.SteelBlue
        Me.BunifuThinButton21.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton21.ActiveLineColor = System.Drawing.Color.MediumPurple
        Me.BunifuThinButton21.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BunifuThinButton21.BackColor = System.Drawing.SystemColors.Control
        Me.BunifuThinButton21.BackgroundImage = CType(resources.GetObject("BunifuThinButton21.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton21.ButtonText = "UPDATE"
        Me.BunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton21.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton21.IdleBorderThickness = 1
        Me.BunifuThinButton21.IdleCornerRadius = 20
        Me.BunifuThinButton21.IdleFillColor = System.Drawing.Color.White
        Me.BunifuThinButton21.IdleForecolor = System.Drawing.Color.MediumPurple
        Me.BunifuThinButton21.IdleLineColor = System.Drawing.Color.MediumPurple
        Me.BunifuThinButton21.Location = New System.Drawing.Point(341, 474)
        Me.BunifuThinButton21.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton21.Name = "BunifuThinButton21"
        Me.BunifuThinButton21.Size = New System.Drawing.Size(154, 57)
        Me.BunifuThinButton21.TabIndex = 59
        Me.BunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.lblpackvol)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.txtnewpckprice)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.txtoldpckprice)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.lblnewcamt)
        Me.GroupBox2.Controls.Add(Me.lbloldcamt)
        Me.GroupBox2.Controls.Add(Me.lblnewramt)
        Me.GroupBox2.Controls.Add(Me.PictureBox2)
        Me.GroupBox2.Controls.Add(Me.StatusStrip1)
        Me.GroupBox2.Controls.Add(Me.lblodlRamt)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.gvPriceBatch)
        Me.GroupBox2.Controls.Add(Me.lblqty)
        Me.GroupBox2.Controls.Add(Me.txtNewWPrice)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtOldRPrice)
        Me.GroupBox2.Controls.Add(Me.gvStockguna)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.BunifuThinButton21)
        Me.GroupBox2.Controls.Add(Me.txtOldWPrice)
        Me.GroupBox2.Controls.Add(Me.cbChangepriceSrch)
        Me.GroupBox2.Controls.Add(Me.txtNewRPrice)
        Me.GroupBox2.Controls.Add(Me.txtProdname)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.lblStockCode)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 77)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(949, 561)
        Me.GroupBox2.TabIndex = 61
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Change Price"
        '
        'Label18
        '
        Me.Label18.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.SystemColors.Control
        Me.Label18.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(107, 21)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(106, 21)
        Me.Label18.TabIndex = 159
        Me.Label18.Text = "Pack Volume:"
        '
        'lblpackvol
        '
        Me.lblpackvol.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblpackvol.AutoSize = True
        Me.lblpackvol.BackColor = System.Drawing.SystemColors.Control
        Me.lblpackvol.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpackvol.ForeColor = System.Drawing.Color.Black
        Me.lblpackvol.Location = New System.Drawing.Point(215, 21)
        Me.lblpackvol.Name = "lblpackvol"
        Me.lblpackvol.Size = New System.Drawing.Size(98, 21)
        Me.lblpackvol.TabIndex = 158
        Me.lblpackvol.Text = "packvolume"
        '
        'Label15
        '
        Me.Label15.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.SystemColors.Control
        Me.Label15.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(300, 126)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(36, 21)
        Me.Label15.TabIndex = 157
        Me.Label15.Text = "Old"
        '
        'txtnewpckprice
        '
        Me.txtnewpckprice.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtnewpckprice.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnewpckprice.Location = New System.Drawing.Point(358, 149)
        Me.txtnewpckprice.Name = "txtnewpckprice"
        Me.txtnewpckprice.Size = New System.Drawing.Size(57, 35)
        Me.txtnewpckprice.TabIndex = 156
        '
        'Label16
        '
        Me.Label16.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.SystemColors.Control
        Me.Label16.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(357, 125)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(47, 21)
        Me.Label16.TabIndex = 155
        Me.Label16.Text = "New "
        '
        'txtoldpckprice
        '
        Me.txtoldpckprice.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtoldpckprice.Enabled = False
        Me.txtoldpckprice.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtoldpckprice.Location = New System.Drawing.Point(295, 149)
        Me.txtoldpckprice.Name = "txtoldpckprice"
        Me.txtoldpckprice.Size = New System.Drawing.Size(57, 35)
        Me.txtoldpckprice.TabIndex = 154
        '
        'Label17
        '
        Me.Label17.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.SystemColors.Control
        Me.Label17.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(296, 104)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(84, 21)
        Me.Label17.TabIndex = 153
        Me.Label17.Text = "Pack price"
        '
        'lblnewcamt
        '
        Me.lblnewcamt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblnewcamt.AutoSize = True
        Me.lblnewcamt.BackColor = System.Drawing.SystemColors.Control
        Me.lblnewcamt.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnewcamt.ForeColor = System.Drawing.Color.Black
        Me.lblnewcamt.Location = New System.Drawing.Point(348, 79)
        Me.lblnewcamt.Name = "lblnewcamt"
        Me.lblnewcamt.Size = New System.Drawing.Size(81, 21)
        Me.lblnewcamt.TabIndex = 152
        Me.lblnewcamt.Text = "newCAmt"
        Me.lblnewcamt.Visible = False
        '
        'lbloldcamt
        '
        Me.lbloldcamt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbloldcamt.AutoSize = True
        Me.lbloldcamt.BackColor = System.Drawing.SystemColors.Control
        Me.lbloldcamt.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbloldcamt.ForeColor = System.Drawing.Color.Black
        Me.lbloldcamt.Location = New System.Drawing.Point(348, 58)
        Me.lbloldcamt.Name = "lbloldcamt"
        Me.lbloldcamt.Size = New System.Drawing.Size(75, 21)
        Me.lbloldcamt.TabIndex = 151
        Me.lbloldcamt.Text = "oldCAmt"
        Me.lbloldcamt.Visible = False
        '
        'lblnewramt
        '
        Me.lblnewramt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblnewramt.AutoSize = True
        Me.lblnewramt.BackColor = System.Drawing.SystemColors.Control
        Me.lblnewramt.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnewramt.ForeColor = System.Drawing.Color.Black
        Me.lblnewramt.Location = New System.Drawing.Point(348, 32)
        Me.lblnewramt.Name = "lblnewramt"
        Me.lblnewramt.Size = New System.Drawing.Size(81, 21)
        Me.lblnewramt.TabIndex = 150
        Me.lblnewramt.Text = "newRAmt"
        Me.lblnewramt.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.Menu
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(424, 126)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(57, 58)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 149
        Me.PictureBox2.TabStop = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.lbluser})
        Me.StatusStrip1.Location = New System.Drawing.Point(3, 536)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(943, 22)
        Me.StatusStrip1.TabIndex = 73
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(30, 17)
        Me.ToolStripStatusLabel1.Text = "User"
        '
        'lbluser
        '
        Me.lbluser.Name = "lbluser"
        Me.lbluser.Size = New System.Drawing.Size(30, 17)
        Me.lbluser.Text = "User"
        '
        'lblodlRamt
        '
        Me.lblodlRamt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblodlRamt.AutoSize = True
        Me.lblodlRamt.BackColor = System.Drawing.SystemColors.Control
        Me.lblodlRamt.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblodlRamt.ForeColor = System.Drawing.Color.Black
        Me.lblodlRamt.Location = New System.Drawing.Point(348, 11)
        Me.lblodlRamt.Name = "lblodlRamt"
        Me.lblodlRamt.Size = New System.Drawing.Size(75, 21)
        Me.lblodlRamt.TabIndex = 67
        Me.lblodlRamt.Text = "oldRAmt"
        Me.lblodlRamt.Visible = False
        '
        'Label14
        '
        Me.Label14.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.SystemColors.Control
        Me.Label14.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(161, 126)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(36, 21)
        Me.Label14.TabIndex = 66
        Me.Label14.Text = "Old"
        '
        'Label12
        '
        Me.Label12.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.SystemColors.Control
        Me.Label12.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(82, 126)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(43, 21)
        Me.Label12.TabIndex = 65
        Me.Label12.Text = "New"
        '
        'Label11
        '
        Me.Label11.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.SystemColors.Control
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(25, 125)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(36, 21)
        Me.Label11.TabIndex = 64
        Me.Label11.Text = "Old"
        '
        'gvPriceBatch
        '
        Me.gvPriceBatch.AllowUserToAddRows = False
        Me.gvPriceBatch.AllowUserToDeleteRows = False
        Me.gvPriceBatch.AllowUserToResizeRows = False
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        Me.gvPriceBatch.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.gvPriceBatch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gvPriceBatch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.gvPriceBatch.BackgroundColor = System.Drawing.Color.White
        Me.gvPriceBatch.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.gvPriceBatch.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.gvPriceBatch.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gvPriceBatch.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.gvPriceBatch.ColumnHeadersHeight = 30
        Me.gvPriceBatch.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Itemname, Me.Qty, Me.OldRPrice, Me.NewRPrice, Me.OldCPrice, Me.NewCprice, Me.OldRAmt, Me.NewRAmt, Me.OldCostAmt, Me.NewCostAmt, Me.prodcode, Me.NewPackPrice, Me.OldpackPrice})
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.gvPriceBatch.DefaultCellStyle = DataGridViewCellStyle9
        Me.gvPriceBatch.EnableHeadersVisualStyles = False
        Me.gvPriceBatch.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvPriceBatch.Location = New System.Drawing.Point(11, 200)
        Me.gvPriceBatch.MultiSelect = False
        Me.gvPriceBatch.Name = "gvPriceBatch"
        Me.gvPriceBatch.ReadOnly = True
        Me.gvPriceBatch.RowHeadersVisible = False
        Me.gvPriceBatch.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader
        Me.gvPriceBatch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gvPriceBatch.ShowCellErrors = False
        Me.gvPriceBatch.ShowEditingIcon = False
        Me.gvPriceBatch.ShowRowErrors = False
        Me.gvPriceBatch.Size = New System.Drawing.Size(484, 275)
        Me.gvPriceBatch.TabIndex = 63
        Me.gvPriceBatch.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.gvPriceBatch.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.gvPriceBatch.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.gvPriceBatch.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.gvPriceBatch.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.gvPriceBatch.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.gvPriceBatch.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvPriceBatch.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvPriceBatch.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.gvPriceBatch.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.gvPriceBatch.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.gvPriceBatch.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.gvPriceBatch.ThemeStyle.HeaderStyle.Height = 30
        Me.gvPriceBatch.ThemeStyle.ReadOnly = True
        Me.gvPriceBatch.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.gvPriceBatch.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.gvPriceBatch.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.gvPriceBatch.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.gvPriceBatch.ThemeStyle.RowsStyle.Height = 22
        Me.gvPriceBatch.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvPriceBatch.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Itemname
        '
        Me.Itemname.HeaderText = "ItemName"
        Me.Itemname.Name = "Itemname"
        Me.Itemname.ReadOnly = True
        Me.Itemname.Width = 96
        '
        'Qty
        '
        Me.Qty.HeaderText = "Qty"
        Me.Qty.Name = "Qty"
        Me.Qty.ReadOnly = True
        Me.Qty.Width = 54
        '
        'OldRPrice
        '
        Me.OldRPrice.HeaderText = "OldRPrice"
        Me.OldRPrice.Name = "OldRPrice"
        Me.OldRPrice.ReadOnly = True
        Me.OldRPrice.Width = 92
        '
        'NewRPrice
        '
        Me.NewRPrice.HeaderText = "NewRPrice"
        Me.NewRPrice.Name = "NewRPrice"
        Me.NewRPrice.ReadOnly = True
        Me.NewRPrice.Width = 97
        '
        'OldCPrice
        '
        Me.OldCPrice.HeaderText = "OldCPrice"
        Me.OldCPrice.Name = "OldCPrice"
        Me.OldCPrice.ReadOnly = True
        Me.OldCPrice.Width = 92
        '
        'NewCprice
        '
        Me.NewCprice.HeaderText = "NewCPrice"
        Me.NewCprice.Name = "NewCprice"
        Me.NewCprice.ReadOnly = True
        Me.NewCprice.Width = 97
        '
        'OldRAmt
        '
        Me.OldRAmt.HeaderText = "OldRAmt"
        Me.OldRAmt.Name = "OldRAmt"
        Me.OldRAmt.ReadOnly = True
        Me.OldRAmt.Width = 88
        '
        'NewRAmt
        '
        Me.NewRAmt.HeaderText = "NewRAmt"
        Me.NewRAmt.Name = "NewRAmt"
        Me.NewRAmt.ReadOnly = True
        Me.NewRAmt.Width = 93
        '
        'OldCostAmt
        '
        Me.OldCostAmt.HeaderText = "OldCostAmt"
        Me.OldCostAmt.Name = "OldCostAmt"
        Me.OldCostAmt.ReadOnly = True
        Me.OldCostAmt.Width = 107
        '
        'NewCostAmt
        '
        Me.NewCostAmt.HeaderText = "NewCostAmt"
        Me.NewCostAmt.Name = "NewCostAmt"
        Me.NewCostAmt.ReadOnly = True
        Me.NewCostAmt.Width = 112
        '
        'prodcode
        '
        Me.prodcode.HeaderText = "prodcode"
        Me.prodcode.Name = "prodcode"
        Me.prodcode.ReadOnly = True
        Me.prodcode.Width = 90
        '
        'NewPackPrice
        '
        Me.NewPackPrice.HeaderText = "NewPackPrice"
        Me.NewPackPrice.Name = "NewPackPrice"
        Me.NewPackPrice.ReadOnly = True
        Me.NewPackPrice.Width = 117
        '
        'OldpackPrice
        '
        Me.OldpackPrice.HeaderText = "OldpackPrice"
        Me.OldpackPrice.Name = "OldpackPrice"
        Me.OldpackPrice.ReadOnly = True
        Me.OldpackPrice.Width = 112
        '
        'lblqty
        '
        Me.lblqty.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblqty.AutoSize = True
        Me.lblqty.BackColor = System.Drawing.SystemColors.Control
        Me.lblqty.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblqty.ForeColor = System.Drawing.Color.Black
        Me.lblqty.Location = New System.Drawing.Point(447, 45)
        Me.lblqty.Name = "lblqty"
        Me.lblqty.Size = New System.Drawing.Size(34, 21)
        Me.lblqty.TabIndex = 61
        Me.lblqty.Text = "qty"
        Me.lblqty.Visible = False
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(13, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 21)
        Me.Label5.TabIndex = 60
        Me.Label5.Text = "Item Code"
        '
        'Timer1
        '
        '
        'frmChangePrice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(973, 652)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmChangePrice"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Change Price"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.gvPriceBand, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvStockguna, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.gvPriceBatch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblStockCode As Label
    Friend WithEvents txtProdname As TextBox
    Friend WithEvents txtOldWPrice As TextBox
    Friend WithEvents txtNewRPrice As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtOldRPrice As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtNewWPrice As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents cbChangepriceSrch As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents gvStockguna As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents BunifuThinButton21 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtToQty As TextBox
    Friend WithEvents txtFromQty As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents gvPriceBand As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents txtBandPrice As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cbItemName As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents BunifuThinButton22 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents txtBandName As TextBox
    Friend WithEvents lblBandCode As Label
    Friend WithEvents BunifuThinButton23 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents lblqty As Label
    Friend WithEvents gvPriceBatch As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Label14 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lblodlRamt As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lbltime As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents lbluser As ToolStripStatusLabel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lblnewcamt As Label
    Friend WithEvents lbloldcamt As Label
    Friend WithEvents lblnewramt As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents txtnewpckprice As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtoldpckprice As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents lblpackvol As Label
    Friend WithEvents Itemname As DataGridViewTextBoxColumn
    Friend WithEvents Qty As DataGridViewTextBoxColumn
    Friend WithEvents OldRPrice As DataGridViewTextBoxColumn
    Friend WithEvents NewRPrice As DataGridViewTextBoxColumn
    Friend WithEvents OldCPrice As DataGridViewTextBoxColumn
    Friend WithEvents NewCprice As DataGridViewTextBoxColumn
    Friend WithEvents OldRAmt As DataGridViewTextBoxColumn
    Friend WithEvents NewRAmt As DataGridViewTextBoxColumn
    Friend WithEvents OldCostAmt As DataGridViewTextBoxColumn
    Friend WithEvents NewCostAmt As DataGridViewTextBoxColumn
    Friend WithEvents prodcode As DataGridViewTextBoxColumn
    Friend WithEvents NewPackPrice As DataGridViewTextBoxColumn
    Friend WithEvents OldpackPrice As DataGridViewTextBoxColumn
    Friend WithEvents Label18 As Label
End Class
