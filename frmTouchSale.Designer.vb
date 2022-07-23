<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTouchSale
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTouchSale))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.flItems = New System.Windows.Forms.FlowLayoutPanel()
        Me.flbtnCat = New System.Windows.Forms.FlowLayoutPanel()
        Me.txtCat = New System.Windows.Forms.TextBox()
        Me.gvtouchsale = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.ItemCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DayOderNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OderStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Category = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Prodline = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RecieptNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NewQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ActualStock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Waiter = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OderNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cbSaleType = New System.Windows.Forms.ComboBox()
        Me.lblCreditCust = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.lblNewBal = New System.Windows.Forms.Label()
        Me.lblCustNo = New System.Windows.Forms.Label()
        Me.lblOldBal = New System.Windows.Forms.Label()
        Me.cbPaymode = New System.Windows.Forms.ComboBox()
        Me.cbLocation = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtBuyerTel = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtBuyerName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCashPaid = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblProdCode = New System.Windows.Forms.Label()
        Me.btnOder = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuThinButton22 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.lblDayOder = New System.Windows.Forms.Label()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsUser = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lbldate = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lbltime = New System.Windows.Forms.ToolStripStatusLabel()
        Me.cbWaiterSearch = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.gvOders = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtSearchWaiterOder = New System.Windows.Forms.TextBox()
        Me.lblOderSale = New System.Windows.Forms.Label()
        Me.gvOderDetails = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.lblRecieptNo = New System.Windows.Forms.Label()
        Me.lblCat = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblActualStock = New System.Windows.Forms.Label()
        Me.one = New System.Windows.Forms.Label()
        Me.BunifuThinButton23 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lbldayodersale = New System.Windows.Forms.Label()
        Me.lblprodline = New System.Windows.Forms.Label()
        Me.lblOderNo = New System.Windows.Forms.Label()
        Me.lblWaiter = New System.Windows.Forms.Label()
        Me.btnSell = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuThinButton25 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtAmt = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblItemName = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblChange = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbcreditcustname = New System.Windows.Forms.ComboBox()
        Me.cbwaiter = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ckdirectsale = New System.Windows.Forms.CheckBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.ckprint = New Bunifu.UI.WinForms.BunifuCheckBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.ckprintpreview = New Bunifu.UI.WinForms.BunifuCheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        CType(Me.gvtouchsale, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.gvOders, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvOderDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'flItems
        '
        Me.flItems.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.flItems.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.flItems.Location = New System.Drawing.Point(12, 121)
        Me.flItems.Name = "flItems"
        Me.flItems.Size = New System.Drawing.Size(457, 523)
        Me.flItems.TabIndex = 0
        '
        'flbtnCat
        '
        Me.flbtnCat.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.flbtnCat.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.flbtnCat.Location = New System.Drawing.Point(12, 82)
        Me.flbtnCat.Name = "flbtnCat"
        Me.flbtnCat.Size = New System.Drawing.Size(457, 33)
        Me.flbtnCat.TabIndex = 1
        '
        'txtCat
        '
        Me.txtCat.Location = New System.Drawing.Point(12, 12)
        Me.txtCat.Name = "txtCat"
        Me.txtCat.Size = New System.Drawing.Size(130, 20)
        Me.txtCat.TabIndex = 2
        Me.txtCat.Visible = False
        '
        'gvtouchsale
        '
        Me.gvtouchsale.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.gvtouchsale.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.gvtouchsale.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gvtouchsale.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.gvtouchsale.BackgroundColor = System.Drawing.Color.White
        Me.gvtouchsale.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.gvtouchsale.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.gvtouchsale.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gvtouchsale.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.gvtouchsale.ColumnHeadersHeight = 21
        Me.gvtouchsale.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ItemCode, Me.ItemName, Me.Price, Me.Qty, Me.Amount, Me.DayOderNo, Me.OderStatus, Me.Category, Me.Prodline, Me.RecieptNo, Me.NewQty, Me.ActualStock, Me.Waiter, Me.OderNo})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.gvtouchsale.DefaultCellStyle = DataGridViewCellStyle3
        Me.gvtouchsale.EnableHeadersVisualStyles = False
        Me.gvtouchsale.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvtouchsale.Location = New System.Drawing.Point(482, 117)
        Me.gvtouchsale.Name = "gvtouchsale"
        Me.gvtouchsale.ReadOnly = True
        Me.gvtouchsale.RowHeadersVisible = False
        Me.gvtouchsale.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.gvtouchsale.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gvtouchsale.Size = New System.Drawing.Size(368, 292)
        Me.gvtouchsale.TabIndex = 3
        Me.gvtouchsale.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.gvtouchsale.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.gvtouchsale.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.gvtouchsale.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.gvtouchsale.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.gvtouchsale.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.gvtouchsale.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvtouchsale.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvtouchsale.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.gvtouchsale.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.gvtouchsale.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.gvtouchsale.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.gvtouchsale.ThemeStyle.HeaderStyle.Height = 21
        Me.gvtouchsale.ThemeStyle.ReadOnly = True
        Me.gvtouchsale.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.gvtouchsale.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.gvtouchsale.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.gvtouchsale.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.gvtouchsale.ThemeStyle.RowsStyle.Height = 22
        Me.gvtouchsale.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvtouchsale.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'ItemCode
        '
        Me.ItemCode.HeaderText = "ItemCode"
        Me.ItemCode.Name = "ItemCode"
        Me.ItemCode.ReadOnly = True
        Me.ItemCode.Width = 92
        '
        'ItemName
        '
        Me.ItemName.HeaderText = "ItemName"
        Me.ItemName.Name = "ItemName"
        Me.ItemName.ReadOnly = True
        Me.ItemName.Width = 96
        '
        'Price
        '
        Me.Price.HeaderText = "Price"
        Me.Price.Name = "Price"
        Me.Price.ReadOnly = True
        Me.Price.Width = 61
        '
        'Qty
        '
        Me.Qty.HeaderText = "Qty"
        Me.Qty.Name = "Qty"
        Me.Qty.ReadOnly = True
        Me.Qty.Width = 55
        '
        'Amount
        '
        Me.Amount.HeaderText = "Amt"
        Me.Amount.Name = "Amount"
        Me.Amount.ReadOnly = True
        Me.Amount.Width = 58
        '
        'DayOderNo
        '
        Me.DayOderNo.HeaderText = "DayOderNo"
        Me.DayOderNo.Name = "DayOderNo"
        Me.DayOderNo.ReadOnly = True
        Me.DayOderNo.Width = 105
        '
        'OderStatus
        '
        Me.OderStatus.HeaderText = "OderStatus"
        Me.OderStatus.Name = "OderStatus"
        Me.OderStatus.ReadOnly = True
        Me.OderStatus.Width = 101
        '
        'Category
        '
        Me.Category.HeaderText = "Category"
        Me.Category.Name = "Category"
        Me.Category.ReadOnly = True
        Me.Category.Width = 88
        '
        'Prodline
        '
        Me.Prodline.HeaderText = "Prodline"
        Me.Prodline.Name = "Prodline"
        Me.Prodline.ReadOnly = True
        Me.Prodline.Width = 82
        '
        'RecieptNo
        '
        Me.RecieptNo.HeaderText = "Reciept"
        Me.RecieptNo.Name = "RecieptNo"
        Me.RecieptNo.ReadOnly = True
        Me.RecieptNo.Width = 76
        '
        'NewQty
        '
        Me.NewQty.HeaderText = "NewQty"
        Me.NewQty.Name = "NewQty"
        Me.NewQty.ReadOnly = True
        Me.NewQty.Width = 82
        '
        'ActualStock
        '
        Me.ActualStock.HeaderText = "ActualStock"
        Me.ActualStock.Name = "ActualStock"
        Me.ActualStock.ReadOnly = True
        Me.ActualStock.Width = 103
        '
        'Waiter
        '
        Me.Waiter.HeaderText = "Waiter"
        Me.Waiter.Name = "Waiter"
        Me.Waiter.ReadOnly = True
        Me.Waiter.Width = 71
        '
        'OderNo
        '
        Me.OderNo.HeaderText = "OderNo"
        Me.OderNo.Name = "OderNo"
        Me.OderNo.ReadOnly = True
        Me.OderNo.Width = 81
        '
        'cbSaleType
        '
        Me.cbSaleType.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbSaleType.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSaleType.FormattingEnabled = True
        Me.cbSaleType.Items.AddRange(New Object() {"Walk-In Sale", "Credit Sale"})
        Me.cbSaleType.Location = New System.Drawing.Point(83, 19)
        Me.cbSaleType.Name = "cbSaleType"
        Me.cbSaleType.Size = New System.Drawing.Size(108, 25)
        Me.cbSaleType.TabIndex = 143
        '
        'lblCreditCust
        '
        Me.lblCreditCust.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCreditCust.AutoSize = True
        Me.lblCreditCust.BackColor = System.Drawing.Color.Transparent
        Me.lblCreditCust.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCreditCust.Location = New System.Drawing.Point(-1, 71)
        Me.lblCreditCust.Name = "lblCreditCust"
        Me.lblCreditCust.Size = New System.Drawing.Size(98, 15)
        Me.lblCreditCust.TabIndex = 142
        Me.lblCreditCust.Text = "Credit Customer"
        '
        'Label22
        '
        Me.Label22.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(3, 23)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(66, 17)
        Me.Label22.TabIndex = 141
        Me.Label22.Text = "Sale Type"
        '
        'lblNewBal
        '
        Me.lblNewBal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNewBal.AutoSize = True
        Me.lblNewBal.BackColor = System.Drawing.Color.Transparent
        Me.lblNewBal.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewBal.Location = New System.Drawing.Point(124, 47)
        Me.lblNewBal.Name = "lblNewBal"
        Me.lblNewBal.Size = New System.Drawing.Size(47, 13)
        Me.lblNewBal.TabIndex = 140
        Me.lblNewBal.Text = "NewBal"
        '
        'lblCustNo
        '
        Me.lblCustNo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCustNo.AutoSize = True
        Me.lblCustNo.BackColor = System.Drawing.Color.Transparent
        Me.lblCustNo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustNo.Location = New System.Drawing.Point(72, 48)
        Me.lblCustNo.Name = "lblCustNo"
        Me.lblCustNo.Size = New System.Drawing.Size(46, 13)
        Me.lblCustNo.TabIndex = 139
        Me.lblCustNo.Text = "CustNo"
        '
        'lblOldBal
        '
        Me.lblOldBal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblOldBal.AutoSize = True
        Me.lblOldBal.BackColor = System.Drawing.Color.Transparent
        Me.lblOldBal.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOldBal.Location = New System.Drawing.Point(19, 47)
        Me.lblOldBal.Name = "lblOldBal"
        Me.lblOldBal.Size = New System.Drawing.Size(47, 13)
        Me.lblOldBal.TabIndex = 138
        Me.lblOldBal.Text = "Balance"
        '
        'cbPaymode
        '
        Me.cbPaymode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbPaymode.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPaymode.FormattingEnabled = True
        Me.cbPaymode.Items.AddRange(New Object() {"Cash", "Mobile Money", "Bank Transfer"})
        Me.cbPaymode.Location = New System.Drawing.Point(264, 19)
        Me.cbPaymode.Name = "cbPaymode"
        Me.cbPaymode.Size = New System.Drawing.Size(96, 25)
        Me.cbPaymode.TabIndex = 136
        '
        'cbLocation
        '
        Me.cbLocation.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbLocation.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbLocation.FormattingEnabled = True
        Me.cbLocation.Location = New System.Drawing.Point(85, 159)
        Me.cbLocation.Name = "cbLocation"
        Me.cbLocation.Size = New System.Drawing.Size(106, 25)
        Me.cbLocation.TabIndex = 135
        '
        'Label13
        '
        Me.Label13.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(11, 162)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(61, 17)
        Me.Label13.TabIndex = 134
        Me.Label13.Text = "Location"
        '
        'Label12
        '
        Me.Label12.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(7, 130)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(65, 17)
        Me.Label12.TabIndex = 133
        Me.Label12.Text = "Buyer Tel"
        '
        'txtBuyerTel
        '
        Me.txtBuyerTel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBuyerTel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBuyerTel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuyerTel.Location = New System.Drawing.Point(85, 128)
        Me.txtBuyerTel.Name = "txtBuyerTel"
        Me.txtBuyerTel.Size = New System.Drawing.Size(108, 25)
        Me.txtBuyerTel.TabIndex = 132
        '
        'Label11
        '
        Me.Label11.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(-3, 99)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(83, 17)
        Me.Label11.TabIndex = 131
        Me.Label11.Text = "Buyer Name"
        '
        'txtBuyerName
        '
        Me.txtBuyerName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBuyerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBuyerName.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuyerName.Location = New System.Drawing.Point(85, 97)
        Me.txtBuyerName.Name = "txtBuyerName"
        Me.txtBuyerName.Size = New System.Drawing.Size(107, 25)
        Me.txtBuyerName.TabIndex = 130
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(193, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 17)
        Me.Label4.TabIndex = 127
        Me.Label4.Text = "Pay Mode"
        '
        'txtCashPaid
        '
        Me.txtCashPaid.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCashPaid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCashPaid.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCashPaid.Location = New System.Drawing.Point(264, 50)
        Me.txtCashPaid.Name = "txtCashPaid"
        Me.txtCashPaid.Size = New System.Drawing.Size(96, 25)
        Me.txtCashPaid.TabIndex = 126
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(193, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 17)
        Me.Label3.TabIndex = 125
        Me.Label3.Text = "Cash Paid"
        '
        'lblProdCode
        '
        Me.lblProdCode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblProdCode.AutoSize = True
        Me.lblProdCode.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProdCode.Location = New System.Drawing.Point(446, 18)
        Me.lblProdCode.Name = "lblProdCode"
        Me.lblProdCode.Size = New System.Drawing.Size(57, 13)
        Me.lblProdCode.TabIndex = 146
        Me.lblProdCode.Text = "Prodcode"
        Me.lblProdCode.Visible = False
        '
        'btnOder
        '
        Me.btnOder.ActiveBorderThickness = 1
        Me.btnOder.ActiveCornerRadius = 20
        Me.btnOder.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnOder.ActiveForecolor = System.Drawing.Color.White
        Me.btnOder.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnOder.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOder.BackColor = System.Drawing.SystemColors.Control
        Me.btnOder.BackgroundImage = CType(resources.GetObject("btnOder.BackgroundImage"), System.Drawing.Image)
        Me.btnOder.ButtonText = "ODER"
        Me.btnOder.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOder.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOder.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnOder.IdleBorderThickness = 1
        Me.btnOder.IdleCornerRadius = 20
        Me.btnOder.IdleFillColor = System.Drawing.Color.White
        Me.btnOder.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnOder.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnOder.Location = New System.Drawing.Point(856, 569)
        Me.btnOder.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnOder.Name = "btnOder"
        Me.btnOder.Size = New System.Drawing.Size(99, 73)
        Me.btnOder.TabIndex = 147
        Me.btnOder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuThinButton22
        '
        Me.BunifuThinButton22.ActiveBorderThickness = 1
        Me.BunifuThinButton22.ActiveCornerRadius = 20
        Me.BunifuThinButton22.ActiveFillColor = System.Drawing.Color.Crimson
        Me.BunifuThinButton22.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton22.ActiveLineColor = System.Drawing.Color.Crimson
        Me.BunifuThinButton22.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuThinButton22.BackColor = System.Drawing.SystemColors.Control
        Me.BunifuThinButton22.BackgroundImage = CType(resources.GetObject("BunifuThinButton22.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton22.ButtonText = "SELL"
        Me.BunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton22.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton22.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton22.IdleBorderThickness = 1
        Me.BunifuThinButton22.IdleCornerRadius = 20
        Me.BunifuThinButton22.IdleFillColor = System.Drawing.Color.White
        Me.BunifuThinButton22.IdleForecolor = System.Drawing.Color.Crimson
        Me.BunifuThinButton22.IdleLineColor = System.Drawing.Color.Crimson
        Me.BunifuThinButton22.Location = New System.Drawing.Point(1058, 682)
        Me.BunifuThinButton22.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.BunifuThinButton22.Name = "BunifuThinButton22"
        Me.BunifuThinButton22.Size = New System.Drawing.Size(239, 82)
        Me.BunifuThinButton22.TabIndex = 148
        Me.BunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDayOder
        '
        Me.lblDayOder.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDayOder.AutoSize = True
        Me.lblDayOder.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDayOder.Location = New System.Drawing.Point(520, 21)
        Me.lblDayOder.Name = "lblDayOder"
        Me.lblDayOder.Size = New System.Drawing.Size(32, 13)
        Me.lblDayOder.TabIndex = 151
        Me.lblDayOder.Text = "Oder"
        Me.lblDayOder.Visible = False
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2PictureBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(1145, -1)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(43, 32)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox1.TabIndex = 152
        Me.Guna2PictureBox1.TabStop = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.tsUser, Me.ToolStripStatusLabel2, Me.lbldate, Me.ToolStripStatusLabel3, Me.lbltime})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 647)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1191, 22)
        Me.StatusStrip1.TabIndex = 153
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(33, 17)
        Me.ToolStripStatusLabel1.Text = "User:"
        '
        'tsUser
        '
        Me.tsUser.Name = "tsUser"
        Me.tsUser.Size = New System.Drawing.Size(29, 17)
        Me.tsUser.Text = "user"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(34, 17)
        Me.ToolStripStatusLabel2.Text = "Date:"
        '
        'lbldate
        '
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(30, 17)
        Me.lbldate.Text = "date"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(36, 17)
        Me.ToolStripStatusLabel3.Text = "Time:"
        '
        'lbltime
        '
        Me.lbltime.Name = "lbltime"
        Me.lbltime.Size = New System.Drawing.Size(31, 17)
        Me.lbltime.Text = "time"
        '
        'cbWaiterSearch
        '
        Me.cbWaiterSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbWaiterSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbWaiterSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbWaiterSearch.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbWaiterSearch.FormattingEnabled = True
        Me.cbWaiterSearch.Location = New System.Drawing.Point(915, 86)
        Me.cbWaiterSearch.Name = "cbWaiterSearch"
        Me.cbWaiterSearch.Size = New System.Drawing.Size(233, 25)
        Me.cbWaiterSearch.TabIndex = 155
        '
        'Label6
        '
        Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(853, 89)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 17)
        Me.Label6.TabIndex = 154
        Me.Label6.Text = "Waiter"
        '
        'gvOders
        '
        Me.gvOders.AllowUserToAddRows = False
        Me.gvOders.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.gvOders.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.gvOders.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gvOders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.gvOders.BackgroundColor = System.Drawing.Color.White
        Me.gvOders.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.gvOders.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.gvOders.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gvOders.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.gvOders.ColumnHeadersHeight = 21
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.gvOders.DefaultCellStyle = DataGridViewCellStyle6
        Me.gvOders.EnableHeadersVisualStyles = False
        Me.gvOders.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvOders.Location = New System.Drawing.Point(856, 117)
        Me.gvOders.MultiSelect = False
        Me.gvOders.Name = "gvOders"
        Me.gvOders.ReadOnly = True
        Me.gvOders.RowHeadersVisible = False
        Me.gvOders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gvOders.Size = New System.Drawing.Size(323, 230)
        Me.gvOders.TabIndex = 156
        Me.gvOders.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.gvOders.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.gvOders.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.gvOders.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.gvOders.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.gvOders.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.gvOders.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvOders.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvOders.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.gvOders.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.gvOders.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.gvOders.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.gvOders.ThemeStyle.HeaderStyle.Height = 21
        Me.gvOders.ThemeStyle.ReadOnly = True
        Me.gvOders.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.gvOders.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.gvOders.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.gvOders.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.gvOders.ThemeStyle.RowsStyle.Height = 22
        Me.gvOders.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvOders.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Label7
        '
        Me.Label7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(853, 36)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(102, 17)
        Me.Label7.TabIndex = 157
        Me.Label7.Text = "OderNo/Waiter"
        '
        'txtSearchWaiterOder
        '
        Me.txtSearchWaiterOder.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSearchWaiterOder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearchWaiterOder.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchWaiterOder.Location = New System.Drawing.Point(856, 56)
        Me.txtSearchWaiterOder.Name = "txtSearchWaiterOder"
        Me.txtSearchWaiterOder.Size = New System.Drawing.Size(292, 25)
        Me.txtSearchWaiterOder.TabIndex = 158
        '
        'lblOderSale
        '
        Me.lblOderSale.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblOderSale.AutoSize = True
        Me.lblOderSale.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOderSale.Location = New System.Drawing.Point(579, 18)
        Me.lblOderSale.Name = "lblOderSale"
        Me.lblOderSale.Size = New System.Drawing.Size(51, 13)
        Me.lblOderSale.TabIndex = 159
        Me.lblOderSale.Text = "odersale"
        Me.lblOderSale.Visible = False
        '
        'gvOderDetails
        '
        Me.gvOderDetails.AllowUserToAddRows = False
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        Me.gvOderDetails.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.gvOderDetails.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gvOderDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.gvOderDetails.BackgroundColor = System.Drawing.Color.White
        Me.gvOderDetails.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.gvOderDetails.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.gvOderDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gvOderDetails.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.gvOderDetails.ColumnHeadersHeight = 21
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.gvOderDetails.DefaultCellStyle = DataGridViewCellStyle9
        Me.gvOderDetails.EnableHeadersVisualStyles = False
        Me.gvOderDetails.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvOderDetails.Location = New System.Drawing.Point(856, 353)
        Me.gvOderDetails.MultiSelect = False
        Me.gvOderDetails.Name = "gvOderDetails"
        Me.gvOderDetails.ReadOnly = True
        Me.gvOderDetails.RowHeadersVisible = False
        Me.gvOderDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gvOderDetails.Size = New System.Drawing.Size(323, 119)
        Me.gvOderDetails.TabIndex = 160
        Me.gvOderDetails.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.gvOderDetails.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.gvOderDetails.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.gvOderDetails.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.gvOderDetails.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.gvOderDetails.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.gvOderDetails.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvOderDetails.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvOderDetails.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.gvOderDetails.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.gvOderDetails.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.gvOderDetails.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.gvOderDetails.ThemeStyle.HeaderStyle.Height = 21
        Me.gvOderDetails.ThemeStyle.ReadOnly = True
        Me.gvOderDetails.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.gvOderDetails.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.gvOderDetails.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.gvOderDetails.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.gvOderDetails.ThemeStyle.RowsStyle.Height = 22
        Me.gvOderDetails.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvOderDetails.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'lblRecieptNo
        '
        Me.lblRecieptNo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblRecieptNo.AutoSize = True
        Me.lblRecieptNo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecieptNo.Location = New System.Drawing.Point(666, 18)
        Me.lblRecieptNo.Name = "lblRecieptNo"
        Me.lblRecieptNo.Size = New System.Drawing.Size(59, 13)
        Me.lblRecieptNo.TabIndex = 161
        Me.lblRecieptNo.Text = "Recieptno"
        '
        'lblCat
        '
        Me.lblCat.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCat.AutoSize = True
        Me.lblCat.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCat.Location = New System.Drawing.Point(752, 18)
        Me.lblCat.Name = "lblCat"
        Me.lblCat.Size = New System.Drawing.Size(37, 13)
        Me.lblCat.TabIndex = 162
        Me.lblCat.Text = "lblCat"
        Me.lblCat.Visible = False
        '
        'Timer1
        '
        '
        'lblActualStock
        '
        Me.lblActualStock.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblActualStock.AutoSize = True
        Me.lblActualStock.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActualStock.Location = New System.Drawing.Point(927, 18)
        Me.lblActualStock.Name = "lblActualStock"
        Me.lblActualStock.Size = New System.Drawing.Size(68, 13)
        Me.lblActualStock.TabIndex = 163
        Me.lblActualStock.Text = "ActualStock"
        Me.lblActualStock.Visible = False
        '
        'one
        '
        Me.one.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.one.AutoSize = True
        Me.one.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.one.Location = New System.Drawing.Point(1034, 9)
        Me.one.Name = "one"
        Me.one.Size = New System.Drawing.Size(13, 13)
        Me.one.TabIndex = 164
        Me.one.Text = "1"
        Me.one.Visible = False
        '
        'BunifuThinButton23
        '
        Me.BunifuThinButton23.ActiveBorderThickness = 1
        Me.BunifuThinButton23.ActiveCornerRadius = 20
        Me.BunifuThinButton23.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton23.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton23.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton23.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuThinButton23.BackColor = System.Drawing.SystemColors.Control
        Me.BunifuThinButton23.BackgroundImage = CType(resources.GetObject("BunifuThinButton23.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton23.ButtonText = "Reset Sale"
        Me.BunifuThinButton23.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton23.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton23.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton23.IdleBorderThickness = 1
        Me.BunifuThinButton23.IdleCornerRadius = 20
        Me.BunifuThinButton23.IdleFillColor = System.Drawing.Color.White
        Me.BunifuThinButton23.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton23.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton23.Location = New System.Drawing.Point(964, 569)
        Me.BunifuThinButton23.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton23.Name = "BunifuThinButton23"
        Me.BunifuThinButton23.Size = New System.Drawing.Size(71, 70)
        Me.BunifuThinButton23.TabIndex = 165
        Me.BunifuThinButton23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2PictureBox2
        '
        Me.Guna2PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2PictureBox2.Image = CType(resources.GetObject("Guna2PictureBox2.Image"), System.Drawing.Image)
        Me.Guna2PictureBox2.ImageRotate = 0!
        Me.Guna2PictureBox2.Location = New System.Drawing.Point(1105, 4)
        Me.Guna2PictureBox2.Name = "Guna2PictureBox2"
        Me.Guna2PictureBox2.Size = New System.Drawing.Size(40, 27)
        Me.Guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox2.TabIndex = 166
        Me.Guna2PictureBox2.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel2.Controls.Add(Me.lbldayodersale)
        Me.Panel2.Controls.Add(Me.lblprodline)
        Me.Panel2.Controls.Add(Me.lblOderNo)
        Me.Panel2.Controls.Add(Me.lblWaiter)
        Me.Panel2.Controls.Add(Me.Guna2PictureBox2)
        Me.Panel2.Controls.Add(Me.one)
        Me.Panel2.Controls.Add(Me.lblProdCode)
        Me.Panel2.Controls.Add(Me.lblActualStock)
        Me.Panel2.Controls.Add(Me.lblDayOder)
        Me.Panel2.Controls.Add(Me.lblCat)
        Me.Panel2.Controls.Add(Me.lblOderSale)
        Me.Panel2.Controls.Add(Me.lblRecieptNo)
        Me.Panel2.Controls.Add(Me.txtCat)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1191, 36)
        Me.Panel2.TabIndex = 168
        '
        'lbldayodersale
        '
        Me.lbldayodersale.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbldayodersale.AutoSize = True
        Me.lbldayodersale.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldayodersale.Location = New System.Drawing.Point(581, 2)
        Me.lbldayodersale.Name = "lbldayodersale"
        Me.lbldayodersale.Size = New System.Drawing.Size(71, 13)
        Me.lbldayodersale.TabIndex = 170
        Me.lbldayodersale.Text = "dayOdersale"
        Me.lbldayodersale.Visible = False
        '
        'lblprodline
        '
        Me.lblprodline.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblprodline.AutoSize = True
        Me.lblprodline.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblprodline.Location = New System.Drawing.Point(782, 4)
        Me.lblprodline.Name = "lblprodline"
        Me.lblprodline.Size = New System.Drawing.Size(51, 13)
        Me.lblprodline.TabIndex = 169
        Me.lblprodline.Text = "prodline"
        Me.lblprodline.Visible = False
        '
        'lblOderNo
        '
        Me.lblOderNo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblOderNo.AutoSize = True
        Me.lblOderNo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOderNo.Location = New System.Drawing.Point(510, 1)
        Me.lblOderNo.Name = "lblOderNo"
        Me.lblOderNo.Size = New System.Drawing.Size(48, 13)
        Me.lblOderNo.TabIndex = 169
        Me.lblOderNo.Text = "OderNo"
        Me.lblOderNo.Visible = False
        '
        'lblWaiter
        '
        Me.lblWaiter.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblWaiter.AutoSize = True
        Me.lblWaiter.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWaiter.Location = New System.Drawing.Point(816, 18)
        Me.lblWaiter.Name = "lblWaiter"
        Me.lblWaiter.Size = New System.Drawing.Size(41, 13)
        Me.lblWaiter.TabIndex = 167
        Me.lblWaiter.Text = "Waiter"
        Me.lblWaiter.Visible = False
        '
        'btnSell
        '
        Me.btnSell.ActiveBorderThickness = 1
        Me.btnSell.ActiveCornerRadius = 20
        Me.btnSell.ActiveFillColor = System.Drawing.Color.Crimson
        Me.btnSell.ActiveForecolor = System.Drawing.Color.White
        Me.btnSell.ActiveLineColor = System.Drawing.Color.Crimson
        Me.btnSell.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSell.BackColor = System.Drawing.SystemColors.Control
        Me.btnSell.BackgroundImage = CType(resources.GetObject("btnSell.BackgroundImage"), System.Drawing.Image)
        Me.btnSell.ButtonText = "SELL"
        Me.btnSell.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSell.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSell.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnSell.IdleBorderThickness = 1
        Me.btnSell.IdleCornerRadius = 20
        Me.btnSell.IdleFillColor = System.Drawing.Color.White
        Me.btnSell.IdleForecolor = System.Drawing.Color.Crimson
        Me.btnSell.IdleLineColor = System.Drawing.Color.Crimson
        Me.btnSell.Location = New System.Drawing.Point(1044, 569)
        Me.btnSell.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSell.Name = "btnSell"
        Me.btnSell.Size = New System.Drawing.Size(134, 67)
        Me.btnSell.TabIndex = 169
        Me.btnSell.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuThinButton25
        '
        Me.BunifuThinButton25.ActiveBorderThickness = 1
        Me.BunifuThinButton25.ActiveCornerRadius = 20
        Me.BunifuThinButton25.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton25.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton25.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton25.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuThinButton25.BackColor = System.Drawing.SystemColors.Control
        Me.BunifuThinButton25.BackgroundImage = CType(resources.GetObject("BunifuThinButton25.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton25.ButtonText = "Print Oder"
        Me.BunifuThinButton25.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton25.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton25.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton25.IdleBorderThickness = 1
        Me.BunifuThinButton25.IdleCornerRadius = 20
        Me.BunifuThinButton25.IdleFillColor = System.Drawing.Color.White
        Me.BunifuThinButton25.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton25.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton25.Location = New System.Drawing.Point(1073, 470)
        Me.BunifuThinButton25.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton25.Name = "BunifuThinButton25"
        Me.BunifuThinButton25.Size = New System.Drawing.Size(106, 31)
        Me.BunifuThinButton25.TabIndex = 165
        Me.BunifuThinButton25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtQty
        '
        Me.txtQty.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtQty.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQty.Location = New System.Drawing.Point(472, 87)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(74, 27)
        Me.txtQty.TabIndex = 126
        '
        'txtPrice
        '
        Me.txtPrice.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPrice.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrice.Location = New System.Drawing.Point(562, 87)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(96, 27)
        Me.txtPrice.TabIndex = 126
        '
        'txtAmt
        '
        Me.txtAmt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAmt.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmt.Location = New System.Drawing.Point(669, 87)
        Me.txtAmt.Name = "txtAmt"
        Me.txtAmt.Size = New System.Drawing.Size(96, 27)
        Me.txtAmt.TabIndex = 126
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(771, 78)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(60, 37)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 170
        Me.PictureBox1.TabStop = False
        '
        'lblItemName
        '
        Me.lblItemName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblItemName.AutoSize = True
        Me.lblItemName.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemName.Location = New System.Drawing.Point(474, 39)
        Me.lblItemName.Name = "lblItemName"
        Me.lblItemName.Size = New System.Drawing.Size(134, 32)
        Me.lblItemName.TabIndex = 171
        Me.lblItemName.Text = "ItemName"
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(216, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 20)
        Me.Label2.TabIndex = 137
        Me.Label2.Text = "Total:"
        '
        'lblTotal
        '
        Me.lblTotal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotal.AutoSize = True
        Me.lblTotal.BackColor = System.Drawing.Color.Transparent
        Me.lblTotal.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(270, 79)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(25, 30)
        Me.lblTotal.TabIndex = 124
        Me.lblTotal.Text = "0"
        '
        'lblChange
        '
        Me.lblChange.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblChange.AutoSize = True
        Me.lblChange.BackColor = System.Drawing.Color.Transparent
        Me.lblChange.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChange.Location = New System.Drawing.Point(280, 145)
        Me.lblChange.Name = "lblChange"
        Me.lblChange.Size = New System.Drawing.Size(25, 30)
        Me.lblChange.TabIndex = 129
        Me.lblChange.Text = "0"
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(212, 113)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 20)
        Me.Label5.TabIndex = 128
        Me.Label5.Text = "Change>>"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.Khaki
        Me.GroupBox1.Controls.Add(Me.cbcreditcustname)
        Me.GroupBox1.Controls.Add(Me.cbwaiter)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.lblTotal)
        Me.GroupBox1.Controls.Add(Me.cbPaymode)
        Me.GroupBox1.Controls.Add(Me.lblChange)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.lblCreditCust)
        Me.GroupBox1.Controls.Add(Me.lblOldBal)
        Me.GroupBox1.Controls.Add(Me.lblCustNo)
        Me.GroupBox1.Controls.Add(Me.cbLocation)
        Me.GroupBox1.Controls.Add(Me.cbSaleType)
        Me.GroupBox1.Controls.Add(Me.txtBuyerName)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtBuyerTel)
        Me.GroupBox1.Controls.Add(Me.lblNewBal)
        Me.GroupBox1.Controls.Add(Me.txtCashPaid)
        Me.GroupBox1.Location = New System.Drawing.Point(472, 432)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(378, 212)
        Me.GroupBox1.TabIndex = 172
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'cbcreditcustname
        '
        Me.cbcreditcustname.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbcreditcustname.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbcreditcustname.FormattingEnabled = True
        Me.cbcreditcustname.Location = New System.Drawing.Point(100, 64)
        Me.cbcreditcustname.Name = "cbcreditcustname"
        Me.cbcreditcustname.Size = New System.Drawing.Size(96, 25)
        Me.cbcreditcustname.TabIndex = 175
        '
        'cbwaiter
        '
        Me.cbwaiter.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbwaiter.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbwaiter.FormattingEnabled = True
        Me.cbwaiter.Items.AddRange(New Object() {"Cash", "Mobile Money", "Bank Transfer"})
        Me.cbwaiter.Location = New System.Drawing.Point(270, 178)
        Me.cbwaiter.Name = "cbwaiter"
        Me.cbwaiter.Size = New System.Drawing.Size(96, 25)
        Me.cbwaiter.TabIndex = 174
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(196, 180)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 17)
        Me.Label1.TabIndex = 173
        Me.Label1.Text = "Waiter"
        '
        'ckdirectsale
        '
        Me.ckdirectsale.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ckdirectsale.AutoSize = True
        Me.ckdirectsale.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckdirectsale.Location = New System.Drawing.Point(856, 552)
        Me.ckdirectsale.Name = "ckdirectsale"
        Me.ckdirectsale.Size = New System.Drawing.Size(93, 21)
        Me.ckdirectsale.TabIndex = 175
        Me.ckdirectsale.Text = "Direct Sale"
        Me.ckdirectsale.UseVisualStyleBackColor = True
        '
        'Label34
        '
        Me.Label34.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(881, 520)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(47, 21)
        Me.Label34.TabIndex = 177
        Me.Label34.Text = "Print"
        '
        'ckprint
        '
        Me.ckprint.AllowBindingControlAnimation = True
        Me.ckprint.AllowBindingControlColorChanges = False
        Me.ckprint.AllowBindingControlLocation = True
        Me.ckprint.AllowCheckBoxAnimation = False
        Me.ckprint.AllowCheckmarkAnimation = True
        Me.ckprint.AllowOnHoverStates = True
        Me.ckprint.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ckprint.AutoCheck = True
        Me.ckprint.BackColor = System.Drawing.Color.Transparent
        Me.ckprint.BackgroundImage = CType(resources.GetObject("ckprint.BackgroundImage"), System.Drawing.Image)
        Me.ckprint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ckprint.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right
        Me.ckprint.BorderRadius = 12
        Me.ckprint.Checked = True
        Me.ckprint.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Checked
        Me.ckprint.Cursor = System.Windows.Forms.Cursors.Default
        Me.ckprint.CustomCheckmarkImage = Nothing
        Me.ckprint.Location = New System.Drawing.Point(861, 523)
        Me.ckprint.MinimumSize = New System.Drawing.Size(17, 17)
        Me.ckprint.Name = "ckprint"
        Me.ckprint.OnCheck.BorderColor = System.Drawing.Color.DodgerBlue
        Me.ckprint.OnCheck.BorderRadius = 12
        Me.ckprint.OnCheck.BorderThickness = 2
        Me.ckprint.OnCheck.CheckBoxColor = System.Drawing.Color.DodgerBlue
        Me.ckprint.OnCheck.CheckmarkColor = System.Drawing.Color.White
        Me.ckprint.OnCheck.CheckmarkThickness = 2
        Me.ckprint.OnDisable.BorderColor = System.Drawing.Color.LightGray
        Me.ckprint.OnDisable.BorderRadius = 12
        Me.ckprint.OnDisable.BorderThickness = 2
        Me.ckprint.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent
        Me.ckprint.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray
        Me.ckprint.OnDisable.CheckmarkThickness = 2
        Me.ckprint.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ckprint.OnHoverChecked.BorderRadius = 12
        Me.ckprint.OnHoverChecked.BorderThickness = 2
        Me.ckprint.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ckprint.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White
        Me.ckprint.OnHoverChecked.CheckmarkThickness = 2
        Me.ckprint.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ckprint.OnHoverUnchecked.BorderRadius = 12
        Me.ckprint.OnHoverUnchecked.BorderThickness = 1
        Me.ckprint.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent
        Me.ckprint.OnUncheck.BorderColor = System.Drawing.Color.DarkGray
        Me.ckprint.OnUncheck.BorderRadius = 12
        Me.ckprint.OnUncheck.BorderThickness = 1
        Me.ckprint.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent
        Me.ckprint.Size = New System.Drawing.Size(17, 17)
        Me.ckprint.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu
        Me.ckprint.TabIndex = 176
        Me.ckprint.ThreeState = False
        Me.ckprint.ToolTipText = Nothing
        '
        'Label35
        '
        Me.Label35.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(877, 477)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(112, 21)
        Me.Label35.TabIndex = 179
        Me.Label35.Text = "Print Preview"
        '
        'ckprintpreview
        '
        Me.ckprintpreview.AllowBindingControlAnimation = True
        Me.ckprintpreview.AllowBindingControlColorChanges = False
        Me.ckprintpreview.AllowBindingControlLocation = True
        Me.ckprintpreview.AllowCheckBoxAnimation = False
        Me.ckprintpreview.AllowCheckmarkAnimation = True
        Me.ckprintpreview.AllowOnHoverStates = True
        Me.ckprintpreview.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ckprintpreview.AutoCheck = True
        Me.ckprintpreview.BackColor = System.Drawing.Color.Transparent
        Me.ckprintpreview.BackgroundImage = CType(resources.GetObject("ckprintpreview.BackgroundImage"), System.Drawing.Image)
        Me.ckprintpreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ckprintpreview.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right
        Me.ckprintpreview.BorderRadius = 12
        Me.ckprintpreview.Checked = False
        Me.ckprintpreview.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Unchecked
        Me.ckprintpreview.Cursor = System.Windows.Forms.Cursors.Default
        Me.ckprintpreview.CustomCheckmarkImage = Nothing
        Me.ckprintpreview.Location = New System.Drawing.Point(857, 480)
        Me.ckprintpreview.MinimumSize = New System.Drawing.Size(17, 17)
        Me.ckprintpreview.Name = "ckprintpreview"
        Me.ckprintpreview.OnCheck.BorderColor = System.Drawing.Color.DodgerBlue
        Me.ckprintpreview.OnCheck.BorderRadius = 12
        Me.ckprintpreview.OnCheck.BorderThickness = 2
        Me.ckprintpreview.OnCheck.CheckBoxColor = System.Drawing.Color.DodgerBlue
        Me.ckprintpreview.OnCheck.CheckmarkColor = System.Drawing.Color.White
        Me.ckprintpreview.OnCheck.CheckmarkThickness = 2
        Me.ckprintpreview.OnDisable.BorderColor = System.Drawing.Color.LightGray
        Me.ckprintpreview.OnDisable.BorderRadius = 12
        Me.ckprintpreview.OnDisable.BorderThickness = 2
        Me.ckprintpreview.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent
        Me.ckprintpreview.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray
        Me.ckprintpreview.OnDisable.CheckmarkThickness = 2
        Me.ckprintpreview.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ckprintpreview.OnHoverChecked.BorderRadius = 12
        Me.ckprintpreview.OnHoverChecked.BorderThickness = 2
        Me.ckprintpreview.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ckprintpreview.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White
        Me.ckprintpreview.OnHoverChecked.CheckmarkThickness = 2
        Me.ckprintpreview.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ckprintpreview.OnHoverUnchecked.BorderRadius = 12
        Me.ckprintpreview.OnHoverUnchecked.BorderThickness = 1
        Me.ckprintpreview.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent
        Me.ckprintpreview.OnUncheck.BorderColor = System.Drawing.Color.DarkGray
        Me.ckprintpreview.OnUncheck.BorderRadius = 12
        Me.ckprintpreview.OnUncheck.BorderThickness = 1
        Me.ckprintpreview.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent
        Me.ckprintpreview.Size = New System.Drawing.Size(17, 17)
        Me.ckprintpreview.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu
        Me.ckprintpreview.TabIndex = 178
        Me.ckprintpreview.ThreeState = False
        Me.ckprintpreview.ToolTipText = Nothing
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(559, 71)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(33, 15)
        Me.Label8.TabIndex = 180
        Me.Label8.Text = "Price"
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(475, 69)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(26, 15)
        Me.Label9.TabIndex = 181
        Me.Label9.Text = "Qty"
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(668, 71)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(30, 15)
        Me.Label10.TabIndex = 182
        Me.Label10.Text = "Amt"
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(12, 51)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(456, 27)
        Me.txtSearch.TabIndex = 183
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(19, 35)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(46, 15)
        Me.Label14.TabIndex = 184
        Me.Label14.Text = "Search:"
        '
        'frmTouchSale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1191, 669)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label35)
        Me.Controls.Add(Me.ckprintpreview)
        Me.Controls.Add(Me.Label34)
        Me.Controls.Add(Me.ckprint)
        Me.Controls.Add(Me.ckdirectsale)
        Me.Controls.Add(Me.lblItemName)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnSell)
        Me.Controls.Add(Me.BunifuThinButton25)
        Me.Controls.Add(Me.BunifuThinButton23)
        Me.Controls.Add(Me.gvOderDetails)
        Me.Controls.Add(Me.txtSearchWaiterOder)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.gvOders)
        Me.Controls.Add(Me.cbWaiterSearch)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.Controls.Add(Me.BunifuThinButton22)
        Me.Controls.Add(Me.btnOder)
        Me.Controls.Add(Me.txtAmt)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtQty)
        Me.Controls.Add(Me.gvtouchsale)
        Me.Controls.Add(Me.flbtnCat)
        Me.Controls.Add(Me.flItems)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmTouchSale"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmTouchSale"
        CType(Me.gvtouchsale, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.gvOders, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvOderDetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents flItems As FlowLayoutPanel
    Friend WithEvents flbtnCat As FlowLayoutPanel
    Friend WithEvents txtCat As TextBox
    Friend WithEvents gvtouchsale As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents cbSaleType As ComboBox
    Friend WithEvents lblCreditCust As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents lblNewBal As Label
    Friend WithEvents lblCustNo As Label
    Friend WithEvents lblOldBal As Label
    Friend WithEvents cbPaymode As ComboBox
    Friend WithEvents cbLocation As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtBuyerTel As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtBuyerName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCashPaid As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lblProdCode As Label
    Friend WithEvents btnOder As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuThinButton22 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents lblDayOder As Label
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents tsUser As ToolStripStatusLabel
    Friend WithEvents cbWaiterSearch As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents gvOders As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents txtSearchWaiterOder As TextBox
    Friend WithEvents lblOderSale As Label
    Friend WithEvents gvOderDetails As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents lblRecieptNo As Label
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents lbldate As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As ToolStripStatusLabel
    Friend WithEvents lbltime As ToolStripStatusLabel
    Friend WithEvents lblCat As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblActualStock As Label
    Friend WithEvents one As Label
    Friend WithEvents BunifuThinButton23 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblWaiter As Label
    Friend WithEvents btnSell As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents lblOderNo As Label
    Friend WithEvents ItemCode As DataGridViewTextBoxColumn
    Friend WithEvents ItemName As DataGridViewTextBoxColumn
    Friend WithEvents Price As DataGridViewTextBoxColumn
    Friend WithEvents Qty As DataGridViewTextBoxColumn
    Friend WithEvents Amount As DataGridViewTextBoxColumn
    Friend WithEvents DayOderNo As DataGridViewTextBoxColumn
    Friend WithEvents OderStatus As DataGridViewTextBoxColumn
    Friend WithEvents Category As DataGridViewTextBoxColumn
    Friend WithEvents Prodline As DataGridViewTextBoxColumn
    Friend WithEvents RecieptNo As DataGridViewTextBoxColumn
    Friend WithEvents NewQty As DataGridViewTextBoxColumn
    Friend WithEvents ActualStock As DataGridViewTextBoxColumn
    Friend WithEvents Waiter As DataGridViewTextBoxColumn
    Friend WithEvents OderNo As DataGridViewTextBoxColumn
    Friend WithEvents BunifuThinButton25 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents txtQty As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtAmt As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblItemName As Label
    Friend WithEvents lblprodline As Label
    Friend WithEvents lbldayodersale As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblChange As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cbwaiter As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cbcreditcustname As ComboBox
    Friend WithEvents ckdirectsale As CheckBox
    Friend WithEvents Label34 As Label
    Friend WithEvents ckprint As Bunifu.UI.WinForms.BunifuCheckBox
    Friend WithEvents Label35 As Label
    Friend WithEvents ckprintpreview As Bunifu.UI.WinForms.BunifuCheckBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label14 As Label
End Class
