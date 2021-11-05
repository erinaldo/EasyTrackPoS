<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmToCollected
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmToCollected))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ActiveUser = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BunifuThinButton24 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.lblTimeSold = New System.Windows.Forms.Label()
        Me.lblDateSold = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblActualStock = New System.Windows.Forms.Label()
        Me.BunifuThinButton23 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.lblProdCode = New System.Windows.Forms.Label()
        Me.lblRecieptNo = New System.Windows.Forms.Label()
        Me.gvSalesReciepts = New System.Windows.Forms.DataGridView()
        Me.ItemCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QtySold = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RecieptNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NewQtySold = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QtyCollected = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblItemName = New System.Windows.Forms.Label()
        Me.BunifuThinButton22 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtToBecollected = New System.Windows.Forms.TextBox()
        Me.txtQtySold = New System.Windows.Forms.TextBox()
        Me.BunifuThinButton21 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.txtRecieptNo = New System.Windows.Forms.TextBox()
        Me.txtBuyerName = New System.Windows.Forms.TextBox()
        Me.txtBuyerTel = New System.Windows.Forms.TextBox()
        Me.txtCustLoc = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dpDate = New Bunifu.UI.WinForms.BunifuDatePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtQtyCollected = New System.Windows.Forms.TextBox()
        Me.lblUpdateTBC = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.ckprint = New Bunifu.UI.WinForms.BunifuCheckBox()
        Me.Panel1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.gvSalesReciepts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(30, 17)
        Me.ToolStripStatusLabel1.Text = "User"
        '
        'ActiveUser
        '
        Me.ActiveUser.Name = "ActiveUser"
        Me.ActiveUser.Size = New System.Drawing.Size(30, 17)
        Me.ActiveUser.Text = "User"
        '
        'Timer1
        '
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.BunifuThinButton24)
        Me.Panel1.Location = New System.Drawing.Point(-3, -8)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(970, 65)
        Me.Panel1.TabIndex = 62
        '
        'Label8
        '
        Me.Label8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(51, 10)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(251, 45)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "To Be Collected"
        '
        'BunifuThinButton24
        '
        Me.BunifuThinButton24.ActiveBorderThickness = 1
        Me.BunifuThinButton24.ActiveCornerRadius = 20
        Me.BunifuThinButton24.ActiveFillColor = System.Drawing.Color.DarkRed
        Me.BunifuThinButton24.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton24.ActiveLineColor = System.Drawing.Color.DarkRed
        Me.BunifuThinButton24.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuThinButton24.BackColor = System.Drawing.Color.SteelBlue
        Me.BunifuThinButton24.BackgroundImage = CType(resources.GetObject("BunifuThinButton24.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton24.ButtonText = "Open Sales"
        Me.BunifuThinButton24.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton24.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton24.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton24.IdleBorderThickness = 1
        Me.BunifuThinButton24.IdleCornerRadius = 20
        Me.BunifuThinButton24.IdleFillColor = System.Drawing.Color.White
        Me.BunifuThinButton24.IdleForecolor = System.Drawing.Color.DarkRed
        Me.BunifuThinButton24.IdleLineColor = System.Drawing.Color.DarkRed
        Me.BunifuThinButton24.Location = New System.Drawing.Point(808, 4)
        Me.BunifuThinButton24.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton24.Name = "BunifuThinButton24"
        Me.BunifuThinButton24.Size = New System.Drawing.Size(145, 61)
        Me.BunifuThinButton24.TabIndex = 28
        Me.BunifuThinButton24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTimeSold
        '
        Me.lblTimeSold.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTimeSold.AutoSize = True
        Me.lblTimeSold.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeSold.Location = New System.Drawing.Point(120, 53)
        Me.lblTimeSold.Name = "lblTimeSold"
        Me.lblTimeSold.Size = New System.Drawing.Size(78, 21)
        Me.lblTimeSold.TabIndex = 61
        Me.lblTimeSold.Text = "TimeSold"
        '
        'lblDateSold
        '
        Me.lblDateSold.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDateSold.AutoSize = True
        Me.lblDateSold.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateSold.Location = New System.Drawing.Point(116, 21)
        Me.lblDateSold.Name = "lblDateSold"
        Me.lblDateSold.Size = New System.Drawing.Size(82, 21)
        Me.lblDateSold.TabIndex = 60
        Me.lblDateSold.Text = "DateSold"
        '
        'Label7
        '
        Me.Label7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(235, 71)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(128, 21)
        Me.Label7.TabIndex = 59
        Me.Label7.Text = "Buyer Location:"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ActiveUser})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 626)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(964, 22)
        Me.StatusStrip1.TabIndex = 57
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'Label6
        '
        Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(279, 38)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 21)
        Me.Label6.TabIndex = 56
        Me.Label6.Text = "Buyer Tel:"
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(259, 11)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 21)
        Me.Label5.TabIndex = 55
        Me.Label5.Text = "BuyerName:"
        '
        'lblTime
        '
        Me.lblTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(19, 636)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(46, 21)
        Me.lblTime.TabIndex = 52
        Me.lblTime.Text = "Time"
        '
        'lblDate
        '
        Me.lblDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(104, 73)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(50, 21)
        Me.lblDate.TabIndex = 51
        Me.lblDate.Text = "Date"
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(300, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(184, 45)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "Reciept No"
        '
        'lblActualStock
        '
        Me.lblActualStock.AutoSize = True
        Me.lblActualStock.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActualStock.Location = New System.Drawing.Point(634, 95)
        Me.lblActualStock.Name = "lblActualStock"
        Me.lblActualStock.Size = New System.Drawing.Size(107, 21)
        Me.lblActualStock.TabIndex = 49
        Me.lblActualStock.Text = "ActualStock"
        Me.lblActualStock.Visible = False
        '
        'BunifuThinButton23
        '
        Me.BunifuThinButton23.ActiveBorderThickness = 1
        Me.BunifuThinButton23.ActiveCornerRadius = 20
        Me.BunifuThinButton23.ActiveFillColor = System.Drawing.Color.Red
        Me.BunifuThinButton23.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton23.ActiveLineColor = System.Drawing.Color.Red
        Me.BunifuThinButton23.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuThinButton23.BackColor = System.Drawing.Color.Thistle
        Me.BunifuThinButton23.BackgroundImage = CType(resources.GetObject("BunifuThinButton23.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton23.ButtonText = "CONFIRM TO BE COLLECTED"
        Me.BunifuThinButton23.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton23.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton23.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton23.IdleBorderThickness = 1
        Me.BunifuThinButton23.IdleCornerRadius = 20
        Me.BunifuThinButton23.IdleFillColor = System.Drawing.Color.White
        Me.BunifuThinButton23.IdleForecolor = System.Drawing.Color.Red
        Me.BunifuThinButton23.IdleLineColor = System.Drawing.Color.Red
        Me.BunifuThinButton23.Location = New System.Drawing.Point(758, 35)
        Me.BunifuThinButton23.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton23.Name = "BunifuThinButton23"
        Me.BunifuThinButton23.Size = New System.Drawing.Size(140, 57)
        Me.BunifuThinButton23.TabIndex = 48
        Me.BunifuThinButton23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblProdCode
        '
        Me.lblProdCode.AutoSize = True
        Me.lblProdCode.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProdCode.Location = New System.Drawing.Point(643, 74)
        Me.lblProdCode.Name = "lblProdCode"
        Me.lblProdCode.Size = New System.Drawing.Size(89, 21)
        Me.lblProdCode.TabIndex = 47
        Me.lblProdCode.Text = "ProdCode"
        Me.lblProdCode.Visible = False
        '
        'lblRecieptNo
        '
        Me.lblRecieptNo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblRecieptNo.AutoSize = True
        Me.lblRecieptNo.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecieptNo.Location = New System.Drawing.Point(490, 70)
        Me.lblRecieptNo.Name = "lblRecieptNo"
        Me.lblRecieptNo.Size = New System.Drawing.Size(39, 45)
        Me.lblRecieptNo.TabIndex = 46
        Me.lblRecieptNo.Text = "#"
        '
        'gvSalesReciepts
        '
        Me.gvSalesReciepts.AllowUserToAddRows = False
        Me.gvSalesReciepts.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gvSalesReciepts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gvSalesReciepts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.gvSalesReciepts.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gvSalesReciepts.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.gvSalesReciepts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gvSalesReciepts.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ItemCode, Me.ItemName, Me.QtySold, Me.RPrice, Me.Amount, Me.RecieptNo, Me.NewQtySold, Me.QtyCollected})
        Me.gvSalesReciepts.Location = New System.Drawing.Point(26, 260)
        Me.gvSalesReciepts.MultiSelect = False
        Me.gvSalesReciepts.Name = "gvSalesReciepts"
        Me.gvSalesReciepts.ReadOnly = True
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Khaki
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gvSalesReciepts.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.gvSalesReciepts.RowHeadersVisible = False
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvSalesReciepts.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.gvSalesReciepts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gvSalesReciepts.Size = New System.Drawing.Size(911, 259)
        Me.gvSalesReciepts.TabIndex = 34
        '
        'ItemCode
        '
        Me.ItemCode.HeaderText = "ItemCode"
        Me.ItemCode.Name = "ItemCode"
        Me.ItemCode.ReadOnly = True
        '
        'ItemName
        '
        Me.ItemName.HeaderText = "ItemName"
        Me.ItemName.Name = "ItemName"
        Me.ItemName.ReadOnly = True
        '
        'QtySold
        '
        Me.QtySold.HeaderText = "QtySold"
        Me.QtySold.Name = "QtySold"
        Me.QtySold.ReadOnly = True
        '
        'RPrice
        '
        Me.RPrice.HeaderText = "Price"
        Me.RPrice.Name = "RPrice"
        Me.RPrice.ReadOnly = True
        '
        'Amount
        '
        Me.Amount.HeaderText = "Amount"
        Me.Amount.Name = "Amount"
        Me.Amount.ReadOnly = True
        '
        'RecieptNo
        '
        Me.RecieptNo.HeaderText = "RecieptNo"
        Me.RecieptNo.Name = "RecieptNo"
        Me.RecieptNo.ReadOnly = True
        '
        'NewQtySold
        '
        Me.NewQtySold.HeaderText = "ToBeCollected"
        Me.NewQtySold.Name = "NewQtySold"
        Me.NewQtySold.ReadOnly = True
        '
        'QtyCollected
        '
        Me.QtyCollected.HeaderText = "QtyCollected"
        Me.QtyCollected.Name = "QtyCollected"
        Me.QtyCollected.ReadOnly = True
        '
        'lblItemName
        '
        Me.lblItemName.AutoSize = True
        Me.lblItemName.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemName.Location = New System.Drawing.Point(9, 83)
        Me.lblItemName.Name = "lblItemName"
        Me.lblItemName.Size = New System.Drawing.Size(185, 45)
        Me.lblItemName.TabIndex = 45
        Me.lblItemName.Text = "Item Name"
        '
        'BunifuThinButton22
        '
        Me.BunifuThinButton22.ActiveBorderThickness = 1
        Me.BunifuThinButton22.ActiveCornerRadius = 20
        Me.BunifuThinButton22.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton22.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton22.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton22.BackColor = System.Drawing.Color.PeachPuff
        Me.BunifuThinButton22.BackgroundImage = CType(resources.GetObject("BunifuThinButton22.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton22.ButtonText = "UPDATE"
        Me.BunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton22.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton22.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton22.IdleBorderThickness = 1
        Me.BunifuThinButton22.IdleCornerRadius = 20
        Me.BunifuThinButton22.IdleFillColor = System.Drawing.Color.White
        Me.BunifuThinButton22.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton22.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton22.Location = New System.Drawing.Point(722, 21)
        Me.BunifuThinButton22.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton22.Name = "BunifuThinButton22"
        Me.BunifuThinButton22.Size = New System.Drawing.Size(89, 85)
        Me.BunifuThinButton22.TabIndex = 44
        Me.BunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(281, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(153, 21)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "QtyToBeCollected"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(93, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 21)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "QtySold"
        '
        'txtToBecollected
        '
        Me.txtToBecollected.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtToBecollected.Location = New System.Drawing.Point(287, 40)
        Me.txtToBecollected.Name = "txtToBecollected"
        Me.txtToBecollected.Size = New System.Drawing.Size(174, 33)
        Me.txtToBecollected.TabIndex = 39
        '
        'txtQtySold
        '
        Me.txtQtySold.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQtySold.Location = New System.Drawing.Point(97, 40)
        Me.txtQtySold.Name = "txtQtySold"
        Me.txtQtySold.ReadOnly = True
        Me.txtQtySold.Size = New System.Drawing.Size(155, 33)
        Me.txtQtySold.TabIndex = 38
        Me.txtQtySold.Text = "0"
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
        Me.BunifuThinButton21.ButtonText = "Search"
        Me.BunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton21.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton21.IdleBorderThickness = 1
        Me.BunifuThinButton21.IdleCornerRadius = 20
        Me.BunifuThinButton21.IdleFillColor = System.Drawing.Color.White
        Me.BunifuThinButton21.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton21.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton21.Location = New System.Drawing.Point(12, 67)
        Me.BunifuThinButton21.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton21.Name = "BunifuThinButton21"
        Me.BunifuThinButton21.Size = New System.Drawing.Size(69, 49)
        Me.BunifuThinButton21.TabIndex = 36
        Me.BunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtRecieptNo
        '
        Me.txtRecieptNo.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRecieptNo.Location = New System.Drawing.Point(94, 73)
        Me.txtRecieptNo.Name = "txtRecieptNo"
        Me.txtRecieptNo.Size = New System.Drawing.Size(181, 33)
        Me.txtRecieptNo.TabIndex = 35
        '
        'txtBuyerName
        '
        Me.txtBuyerName.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtBuyerName.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuyerName.Location = New System.Drawing.Point(369, 5)
        Me.txtBuyerName.Name = "txtBuyerName"
        Me.txtBuyerName.Size = New System.Drawing.Size(172, 27)
        Me.txtBuyerName.TabIndex = 63
        '
        'txtBuyerTel
        '
        Me.txtBuyerTel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtBuyerTel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuyerTel.Location = New System.Drawing.Point(369, 35)
        Me.txtBuyerTel.Name = "txtBuyerTel"
        Me.txtBuyerTel.Size = New System.Drawing.Size(172, 27)
        Me.txtBuyerTel.TabIndex = 64
        '
        'txtCustLoc
        '
        Me.txtCustLoc.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtCustLoc.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustLoc.Location = New System.Drawing.Point(369, 65)
        Me.txtCustLoc.Name = "txtCustLoc"
        Me.txtCustLoc.Size = New System.Drawing.Size(172, 27)
        Me.txtCustLoc.TabIndex = 65
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(547, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(159, 21)
        Me.Label3.TabIndex = 66
        Me.Label3.Text = "DateTobeCollected:"
        '
        'dpDate
        '
        Me.dpDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dpDate.BackColor = System.Drawing.Color.Transparent
        Me.dpDate.BorderRadius = 1
        Me.dpDate.Color = System.Drawing.Color.Silver
        Me.dpDate.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin
        Me.dpDate.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left
        Me.dpDate.DisabledColor = System.Drawing.Color.Gray
        Me.dpDate.DisplayWeekNumbers = False
        Me.dpDate.DPHeight = 0
        Me.dpDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dpDate.FillDatePicker = False
        Me.dpDate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dpDate.ForeColor = System.Drawing.Color.Black
        Me.dpDate.Icon = CType(resources.GetObject("dpDate.Icon"), System.Drawing.Image)
        Me.dpDate.IconColor = System.Drawing.Color.Gray
        Me.dpDate.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right
        Me.dpDate.LeftTextMargin = 5
        Me.dpDate.Location = New System.Drawing.Point(551, 41)
        Me.dpDate.MinimumSize = New System.Drawing.Size(4, 32)
        Me.dpDate.Name = "dpDate"
        Me.dpDate.Size = New System.Drawing.Size(166, 32)
        Me.dpDate.TabIndex = 67
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(471, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(116, 21)
        Me.Label9.TabIndex = 69
        Me.Label9.Text = "QtyCollected"
        '
        'txtQtyCollected
        '
        Me.txtQtyCollected.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQtyCollected.Location = New System.Drawing.Point(475, 40)
        Me.txtQtyCollected.Name = "txtQtyCollected"
        Me.txtQtyCollected.ReadOnly = True
        Me.txtQtyCollected.Size = New System.Drawing.Size(155, 33)
        Me.txtQtyCollected.TabIndex = 68
        Me.txtQtyCollected.Text = "0"
        '
        'lblUpdateTBC
        '
        Me.lblUpdateTBC.AutoSize = True
        Me.lblUpdateTBC.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUpdateTBC.Location = New System.Drawing.Point(787, 92)
        Me.lblUpdateTBC.Name = "lblUpdateTBC"
        Me.lblUpdateTBC.Size = New System.Drawing.Size(165, 21)
        Me.lblUpdateTBC.TabIndex = 70
        Me.lblUpdateTBC.Text = "AjustTobeCollected"
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(20, 21)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 21)
        Me.Label10.TabIndex = 71
        Me.Label10.Text = "Date Sold:"
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(24, 53)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(90, 21)
        Me.Label11.TabIndex = 72
        Me.Label11.Text = "Time Sold:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.Thistle
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.txtBuyerName)
        Me.GroupBox1.Controls.Add(Me.txtCustLoc)
        Me.GroupBox1.Controls.Add(Me.ckprint)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.dpDate)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtBuyerTel)
        Me.GroupBox1.Controls.Add(Me.lblTimeSold)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.lblDateSold)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.BunifuThinButton23)
        Me.GroupBox1.Controls.Add(Me.lblDate)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 525)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(925, 98)
        Me.GroupBox1.TabIndex = 73
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.BackColor = System.Drawing.Color.PeachPuff
        Me.GroupBox2.Controls.Add(Me.txtQtyCollected)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.lblItemName)
        Me.GroupBox2.Controls.Add(Me.txtToBecollected)
        Me.GroupBox2.Controls.Add(Me.txtQtySold)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.BunifuThinButton22)
        Me.GroupBox2.Location = New System.Drawing.Point(23, 119)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(914, 135)
        Me.GroupBox2.TabIndex = 74
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(810, 11)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(47, 21)
        Me.Label15.TabIndex = 130
        Me.Label15.Text = "Print"
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
        Me.ckprint.Location = New System.Drawing.Point(790, 14)
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
        Me.ckprint.TabIndex = 129
        Me.ckprint.ThreeState = False
        Me.ckprint.ToolTipText = Nothing
        '
        'frmToCollected
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(964, 648)
        Me.Controls.Add(Me.lblUpdateTBC)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblActualStock)
        Me.Controls.Add(Me.lblProdCode)
        Me.Controls.Add(Me.lblRecieptNo)
        Me.Controls.Add(Me.gvSalesReciepts)
        Me.Controls.Add(Me.BunifuThinButton21)
        Me.Controls.Add(Me.txtRecieptNo)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmToCollected"
        Me.Text = "frmToCollected"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.gvSalesReciepts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ActiveUser As ToolStripStatusLabel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents BunifuThinButton24 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents lblTimeSold As Label
    Friend WithEvents lblDateSold As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblActualStock As Label
    Friend WithEvents BunifuThinButton23 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents lblProdCode As Label
    Friend WithEvents lblRecieptNo As Label
    Friend WithEvents gvSalesReciepts As DataGridView
    Friend WithEvents lblItemName As Label
    Friend WithEvents BunifuThinButton22 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtToBecollected As TextBox
    Friend WithEvents txtQtySold As TextBox
    Friend WithEvents BunifuThinButton21 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents txtRecieptNo As TextBox
    Friend WithEvents txtBuyerName As TextBox
    Friend WithEvents txtBuyerTel As TextBox
    Friend WithEvents txtCustLoc As TextBox
    Friend WithEvents ItemCode As DataGridViewTextBoxColumn
    Friend WithEvents ItemName As DataGridViewTextBoxColumn
    Friend WithEvents QtySold As DataGridViewTextBoxColumn
    Friend WithEvents RPrice As DataGridViewTextBoxColumn
    Friend WithEvents Amount As DataGridViewTextBoxColumn
    Friend WithEvents RecieptNo As DataGridViewTextBoxColumn
    Friend WithEvents NewQtySold As DataGridViewTextBoxColumn
    Friend WithEvents Label3 As Label
    Friend WithEvents dpDate As Bunifu.UI.WinForms.BunifuDatePicker
    Friend WithEvents QtyCollected As DataGridViewTextBoxColumn
    Friend WithEvents Label9 As Label
    Friend WithEvents txtQtyCollected As TextBox
    Friend WithEvents lblUpdateTBC As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label15 As Label
    Friend WithEvents ckprint As Bunifu.UI.WinForms.BunifuCheckBox
End Class
