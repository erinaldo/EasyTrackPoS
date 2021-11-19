<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSalesCancelation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSalesCancelation))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.gvSalesReciepts = New System.Windows.Forms.DataGridView()
        Me.ItemCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QtySold = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RecieptNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NewQtySold = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NewAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CancellationQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NewQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtRecieptNo = New System.Windows.Forms.TextBox()
        Me.BunifuThinButton21 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.gvReciepts = New System.Windows.Forms.DataGridView()
        Me.txtQtySold = New System.Windows.Forms.TextBox()
        Me.txtToBeCancelled = New System.Windows.Forms.TextBox()
        Me.txtNewQtySold = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BunifuThinButton22 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.lblItemName = New System.Windows.Forms.Label()
        Me.lblRecieptNo = New System.Windows.Forms.Label()
        Me.lblProdCode = New System.Windows.Forms.Label()
        Me.BunifuThinButton23 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.lblActualStock = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblBuyerName = New System.Windows.Forms.Label()
        Me.lblBuyerTel = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ActiveUser = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblCustLoc = New System.Windows.Forms.Label()
        Me.lblTimeSold = New System.Windows.Forms.Label()
        Me.lblDateSold = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BunifuThinButton24 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BunifuThinButton25 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.dpDate = New Bunifu.UI.WinForms.BunifuDatePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.ckA4 = New Bunifu.UI.WinForms.BunifuCheckBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.ckA5Paper = New Bunifu.UI.WinForms.BunifuCheckBox()
        Me.ckrollPaper = New Bunifu.UI.WinForms.BunifuCheckBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.ckprintpreview = New Bunifu.UI.WinForms.BunifuCheckBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.ckprint = New Bunifu.UI.WinForms.BunifuCheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dpdateto = New Bunifu.UI.WinForms.BunifuDatePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.gvSalesReciepts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvReciepts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'gvSalesReciepts
        '
        Me.gvSalesReciepts.AllowUserToAddRows = False
        Me.gvSalesReciepts.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gvSalesReciepts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.gvSalesReciepts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.gvSalesReciepts.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gvSalesReciepts.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.gvSalesReciepts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gvSalesReciepts.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ItemCode, Me.ItemName, Me.QtySold, Me.RPrice, Me.Amount, Me.RecieptNo, Me.NewQtySold, Me.NewAmount, Me.CancellationQty, Me.NewQty})
        Me.gvSalesReciepts.Location = New System.Drawing.Point(343, 275)
        Me.gvSalesReciepts.MultiSelect = False
        Me.gvSalesReciepts.Name = "gvSalesReciepts"
        Me.gvSalesReciepts.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Khaki
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gvSalesReciepts.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.gvSalesReciepts.RowHeadersVisible = False
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvSalesReciepts.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.gvSalesReciepts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gvSalesReciepts.Size = New System.Drawing.Size(619, 271)
        Me.gvSalesReciepts.TabIndex = 0
        '
        'ItemCode
        '
        Me.ItemCode.HeaderText = "ItemCode"
        Me.ItemCode.Name = "ItemCode"
        Me.ItemCode.ReadOnly = True
        Me.ItemCode.Width = 99
        '
        'ItemName
        '
        Me.ItemName.HeaderText = "ItemName"
        Me.ItemName.Name = "ItemName"
        Me.ItemName.ReadOnly = True
        Me.ItemName.Width = 102
        '
        'QtySold
        '
        Me.QtySold.HeaderText = "QtySold"
        Me.QtySold.Name = "QtySold"
        Me.QtySold.ReadOnly = True
        Me.QtySold.Width = 82
        '
        'RPrice
        '
        Me.RPrice.HeaderText = "Price"
        Me.RPrice.Name = "RPrice"
        Me.RPrice.ReadOnly = True
        Me.RPrice.Width = 64
        '
        'Amount
        '
        Me.Amount.HeaderText = "Amount"
        Me.Amount.Name = "Amount"
        Me.Amount.ReadOnly = True
        Me.Amount.Width = 85
        '
        'RecieptNo
        '
        Me.RecieptNo.HeaderText = "RecieptNo"
        Me.RecieptNo.Name = "RecieptNo"
        Me.RecieptNo.ReadOnly = True
        Me.RecieptNo.Width = 101
        '
        'NewQtySold
        '
        Me.NewQtySold.HeaderText = "NewQtySold"
        Me.NewQtySold.Name = "NewQtySold"
        Me.NewQtySold.ReadOnly = True
        Me.NewQtySold.Width = 112
        '
        'NewAmount
        '
        Me.NewAmount.HeaderText = "NewAmount"
        Me.NewAmount.Name = "NewAmount"
        Me.NewAmount.ReadOnly = True
        Me.NewAmount.Width = 115
        '
        'CancellationQty
        '
        Me.CancellationQty.HeaderText = "CancellationQty"
        Me.CancellationQty.Name = "CancellationQty"
        Me.CancellationQty.ReadOnly = True
        Me.CancellationQty.Width = 139
        '
        'NewQty
        '
        Me.NewQty.HeaderText = "NewStockQty"
        Me.NewQty.Name = "NewQty"
        Me.NewQty.ReadOnly = True
        Me.NewQty.Width = 120
        '
        'txtRecieptNo
        '
        Me.txtRecieptNo.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRecieptNo.Location = New System.Drawing.Point(88, 92)
        Me.txtRecieptNo.Name = "txtRecieptNo"
        Me.txtRecieptNo.Size = New System.Drawing.Size(181, 33)
        Me.txtRecieptNo.TabIndex = 1
        '
        'BunifuThinButton21
        '
        Me.BunifuThinButton21.ActiveBorderThickness = 1
        Me.BunifuThinButton21.ActiveCornerRadius = 20
        Me.BunifuThinButton21.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton21.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton21.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton21.BackColor = System.Drawing.SystemColors.ButtonFace
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
        Me.BunifuThinButton21.Location = New System.Drawing.Point(6, 91)
        Me.BunifuThinButton21.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton21.Name = "BunifuThinButton21"
        Me.BunifuThinButton21.Size = New System.Drawing.Size(69, 37)
        Me.BunifuThinButton21.TabIndex = 2
        Me.BunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gvReciepts
        '
        Me.gvReciepts.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gvReciepts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gvReciepts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.gvReciepts.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gvReciepts.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.gvReciepts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gvReciepts.Location = New System.Drawing.Point(12, 178)
        Me.gvReciepts.MultiSelect = False
        Me.gvReciepts.Name = "gvReciepts"
        Me.gvReciepts.ReadOnly = True
        Me.gvReciepts.RowHeadersVisible = False
        Me.gvReciepts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvReciepts.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.gvReciepts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gvReciepts.Size = New System.Drawing.Size(325, 368)
        Me.gvReciepts.TabIndex = 3
        '
        'txtQtySold
        '
        Me.txtQtySold.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQtySold.Location = New System.Drawing.Point(16, 52)
        Me.txtQtySold.Name = "txtQtySold"
        Me.txtQtySold.ReadOnly = True
        Me.txtQtySold.Size = New System.Drawing.Size(95, 33)
        Me.txtQtySold.TabIndex = 4
        '
        'txtToBeCancelled
        '
        Me.txtToBeCancelled.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtToBeCancelled.Location = New System.Drawing.Point(148, 52)
        Me.txtToBeCancelled.Name = "txtToBeCancelled"
        Me.txtToBeCancelled.Size = New System.Drawing.Size(118, 33)
        Me.txtToBeCancelled.TabIndex = 5
        '
        'txtNewQtySold
        '
        Me.txtNewQtySold.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewQtySold.Location = New System.Drawing.Point(302, 52)
        Me.txtNewQtySold.Name = "txtNewQtySold"
        Me.txtNewQtySold.ReadOnly = True
        Me.txtNewQtySold.Size = New System.Drawing.Size(97, 33)
        Me.txtNewQtySold.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 21)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "QtySold"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(135, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(157, 21)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "QtyToBeCancelled"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(298, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 21)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "NewQtySold"
        '
        'BunifuThinButton22
        '
        Me.BunifuThinButton22.ActiveBorderThickness = 1
        Me.BunifuThinButton22.ActiveCornerRadius = 20
        Me.BunifuThinButton22.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton22.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton22.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton22.BackColor = System.Drawing.Color.Khaki
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
        Me.BunifuThinButton22.Location = New System.Drawing.Point(466, 38)
        Me.BunifuThinButton22.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton22.Name = "BunifuThinButton22"
        Me.BunifuThinButton22.Size = New System.Drawing.Size(99, 65)
        Me.BunifuThinButton22.TabIndex = 10
        Me.BunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblItemName
        '
        Me.lblItemName.AutoSize = True
        Me.lblItemName.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemName.Location = New System.Drawing.Point(8, 87)
        Me.lblItemName.Name = "lblItemName"
        Me.lblItemName.Size = New System.Drawing.Size(185, 45)
        Me.lblItemName.TabIndex = 11
        Me.lblItemName.Text = "Item Name"
        '
        'lblRecieptNo
        '
        Me.lblRecieptNo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblRecieptNo.AutoSize = True
        Me.lblRecieptNo.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecieptNo.Location = New System.Drawing.Point(491, 82)
        Me.lblRecieptNo.Name = "lblRecieptNo"
        Me.lblRecieptNo.Size = New System.Drawing.Size(39, 45)
        Me.lblRecieptNo.TabIndex = 12
        Me.lblRecieptNo.Text = "#"
        '
        'lblProdCode
        '
        Me.lblProdCode.AutoSize = True
        Me.lblProdCode.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProdCode.Location = New System.Drawing.Point(791, 85)
        Me.lblProdCode.Name = "lblProdCode"
        Me.lblProdCode.Size = New System.Drawing.Size(89, 21)
        Me.lblProdCode.TabIndex = 13
        Me.lblProdCode.Text = "ProdCode"
        Me.lblProdCode.Visible = False
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
        Me.BunifuThinButton23.ButtonText = "CANCEL SALE"
        Me.BunifuThinButton23.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton23.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton23.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton23.IdleBorderThickness = 1
        Me.BunifuThinButton23.IdleCornerRadius = 20
        Me.BunifuThinButton23.IdleFillColor = System.Drawing.Color.White
        Me.BunifuThinButton23.IdleForecolor = System.Drawing.Color.Red
        Me.BunifuThinButton23.IdleLineColor = System.Drawing.Color.Red
        Me.BunifuThinButton23.Location = New System.Drawing.Point(761, 13)
        Me.BunifuThinButton23.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton23.Name = "BunifuThinButton23"
        Me.BunifuThinButton23.Size = New System.Drawing.Size(190, 52)
        Me.BunifuThinButton23.TabIndex = 14
        Me.BunifuThinButton23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblActualStock
        '
        Me.lblActualStock.AutoSize = True
        Me.lblActualStock.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActualStock.Location = New System.Drawing.Point(782, 106)
        Me.lblActualStock.Name = "lblActualStock"
        Me.lblActualStock.Size = New System.Drawing.Size(107, 21)
        Me.lblActualStock.TabIndex = 15
        Me.lblActualStock.Text = "ActualStock"
        Me.lblActualStock.Visible = False
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(301, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(184, 45)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Reciept No"
        '
        'lblDate
        '
        Me.lblDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(16, 21)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(50, 21)
        Me.lblDate.TabIndex = 17
        Me.lblDate.Text = "Date"
        '
        'lblTime
        '
        Me.lblTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(19, 49)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(46, 21)
        Me.lblTime.TabIndex = 18
        Me.lblTime.Text = "Time"
        '
        'lblBuyerName
        '
        Me.lblBuyerName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblBuyerName.AutoSize = True
        Me.lblBuyerName.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuyerName.Location = New System.Drawing.Point(374, 10)
        Me.lblBuyerName.Name = "lblBuyerName"
        Me.lblBuyerName.Size = New System.Drawing.Size(58, 21)
        Me.lblBuyerName.TabIndex = 19
        Me.lblBuyerName.Text = "Name"
        '
        'lblBuyerTel
        '
        Me.lblBuyerTel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblBuyerTel.AutoSize = True
        Me.lblBuyerTel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuyerTel.Location = New System.Drawing.Point(378, 34)
        Me.lblBuyerTel.Name = "lblBuyerTel"
        Me.lblBuyerTel.Size = New System.Drawing.Size(31, 21)
        Me.lblBuyerTel.TabIndex = 20
        Me.lblBuyerTel.Text = "Tel"
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(268, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 21)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "BuyerName:"
        '
        'Label6
        '
        Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(281, 34)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 21)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Buyer Tel:"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ActiveUser})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 629)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(974, 22)
        Me.StatusStrip1.TabIndex = 23
        Me.StatusStrip1.Text = "StatusStrip1"
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
        'Label7
        '
        Me.Label7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(244, 53)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(128, 21)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Buyer Location:"
        '
        'lblCustLoc
        '
        Me.lblCustLoc.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCustLoc.AutoSize = True
        Me.lblCustLoc.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustLoc.Location = New System.Drawing.Point(380, 52)
        Me.lblCustLoc.Name = "lblCustLoc"
        Me.lblCustLoc.Size = New System.Drawing.Size(37, 21)
        Me.lblCustLoc.TabIndex = 24
        Me.lblCustLoc.Text = "Loc"
        '
        'lblTimeSold
        '
        Me.lblTimeSold.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTimeSold.AutoSize = True
        Me.lblTimeSold.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeSold.Location = New System.Drawing.Point(119, 49)
        Me.lblTimeSold.Name = "lblTimeSold"
        Me.lblTimeSold.Size = New System.Drawing.Size(78, 21)
        Me.lblTimeSold.TabIndex = 27
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
        Me.lblDateSold.TabIndex = 26
        Me.lblDateSold.Text = "DateSold"
        '
        'Timer1
        '
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
        Me.BunifuThinButton24.Location = New System.Drawing.Point(824, 0)
        Me.BunifuThinButton24.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton24.Name = "BunifuThinButton24"
        Me.BunifuThinButton24.Size = New System.Drawing.Size(145, 61)
        Me.BunifuThinButton24.TabIndex = 28
        Me.BunifuThinButton24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.BunifuThinButton24)
        Me.Panel1.Location = New System.Drawing.Point(0, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(974, 65)
        Me.Panel1.TabIndex = 29
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
        Me.Label8.Size = New System.Drawing.Size(287, 45)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "Sales Cancellation"
        '
        'BunifuThinButton25
        '
        Me.BunifuThinButton25.ActiveBorderThickness = 1
        Me.BunifuThinButton25.ActiveCornerRadius = 20
        Me.BunifuThinButton25.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton25.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton25.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton25.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BunifuThinButton25.BackgroundImage = CType(resources.GetObject("BunifuThinButton25.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton25.ButtonText = "Load "
        Me.BunifuThinButton25.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton25.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton25.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton25.IdleBorderThickness = 1
        Me.BunifuThinButton25.IdleCornerRadius = 20
        Me.BunifuThinButton25.IdleFillColor = System.Drawing.Color.White
        Me.BunifuThinButton25.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton25.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton25.Location = New System.Drawing.Point(12, 139)
        Me.BunifuThinButton25.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton25.Name = "BunifuThinButton25"
        Me.BunifuThinButton25.Size = New System.Drawing.Size(57, 33)
        Me.BunifuThinButton25.TabIndex = 32
        Me.BunifuThinButton25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dpDate
        '
        Me.dpDate.BackColor = System.Drawing.Color.Transparent
        Me.dpDate.BorderColor = System.Drawing.Color.Silver
        Me.dpDate.BorderRadius = 1
        Me.dpDate.Color = System.Drawing.Color.Silver
        Me.dpDate.CustomFormat = "dd/MM/yyyy"
        Me.dpDate.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin
        Me.dpDate.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left
        Me.dpDate.DisabledColor = System.Drawing.Color.Gray
        Me.dpDate.DisplayWeekNumbers = False
        Me.dpDate.DPHeight = 0
        Me.dpDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dpDate.FillDatePicker = False
        Me.dpDate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dpDate.ForeColor = System.Drawing.Color.Black
        Me.dpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dpDate.Icon = CType(resources.GetObject("dpDate.Icon"), System.Drawing.Image)
        Me.dpDate.IconColor = System.Drawing.Color.Gray
        Me.dpDate.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right
        Me.dpDate.LeftTextMargin = 5
        Me.dpDate.Location = New System.Drawing.Point(77, 140)
        Me.dpDate.MinimumSize = New System.Drawing.Size(4, 32)
        Me.dpDate.Name = "dpDate"
        Me.dpDate.Size = New System.Drawing.Size(104, 32)
        Me.dpDate.TabIndex = 33
        Me.dpDate.Value = New Date(2021, 11, 18, 0, 0, 0, 0)
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.Thistle
        Me.GroupBox1.Controls.Add(Me.Label28)
        Me.GroupBox1.Controls.Add(Me.ckA4)
        Me.GroupBox1.Controls.Add(Me.Label25)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.ckA5Paper)
        Me.GroupBox1.Controls.Add(Me.ckrollPaper)
        Me.GroupBox1.Controls.Add(Me.Label35)
        Me.GroupBox1.Controls.Add(Me.ckprintpreview)
        Me.GroupBox1.Controls.Add(Me.Label34)
        Me.GroupBox1.Controls.Add(Me.ckprint)
        Me.GroupBox1.Controls.Add(Me.lblDateSold)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.lblTimeSold)
        Me.GroupBox1.Controls.Add(Me.lblTime)
        Me.GroupBox1.Controls.Add(Me.lblBuyerTel)
        Me.GroupBox1.Controls.Add(Me.BunifuThinButton23)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.lblBuyerName)
        Me.GroupBox1.Controls.Add(Me.lblCustLoc)
        Me.GroupBox1.Controls.Add(Me.lblDate)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 552)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(959, 73)
        Me.GroupBox1.TabIndex = 34
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'Label28
        '
        Me.Label28.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(675, 52)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(78, 21)
        Me.Label28.TabIndex = 157
        Me.Label28.Text = "A4 Paper"
        '
        'ckA4
        '
        Me.ckA4.AllowBindingControlAnimation = True
        Me.ckA4.AllowBindingControlColorChanges = False
        Me.ckA4.AllowBindingControlLocation = True
        Me.ckA4.AllowCheckBoxAnimation = False
        Me.ckA4.AllowCheckmarkAnimation = True
        Me.ckA4.AllowOnHoverStates = True
        Me.ckA4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ckA4.AutoCheck = True
        Me.ckA4.BackColor = System.Drawing.Color.Transparent
        Me.ckA4.BackgroundImage = CType(resources.GetObject("ckA4.BackgroundImage"), System.Drawing.Image)
        Me.ckA4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ckA4.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right
        Me.ckA4.BorderRadius = 12
        Me.ckA4.Checked = False
        Me.ckA4.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Unchecked
        Me.ckA4.Cursor = System.Windows.Forms.Cursors.Default
        Me.ckA4.CustomCheckmarkImage = Nothing
        Me.ckA4.Location = New System.Drawing.Point(655, 55)
        Me.ckA4.MinimumSize = New System.Drawing.Size(17, 17)
        Me.ckA4.Name = "ckA4"
        Me.ckA4.OnCheck.BorderColor = System.Drawing.Color.DodgerBlue
        Me.ckA4.OnCheck.BorderRadius = 12
        Me.ckA4.OnCheck.BorderThickness = 2
        Me.ckA4.OnCheck.CheckBoxColor = System.Drawing.Color.DodgerBlue
        Me.ckA4.OnCheck.CheckmarkColor = System.Drawing.Color.White
        Me.ckA4.OnCheck.CheckmarkThickness = 2
        Me.ckA4.OnDisable.BorderColor = System.Drawing.Color.LightGray
        Me.ckA4.OnDisable.BorderRadius = 12
        Me.ckA4.OnDisable.BorderThickness = 2
        Me.ckA4.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent
        Me.ckA4.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray
        Me.ckA4.OnDisable.CheckmarkThickness = 2
        Me.ckA4.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ckA4.OnHoverChecked.BorderRadius = 12
        Me.ckA4.OnHoverChecked.BorderThickness = 2
        Me.ckA4.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ckA4.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White
        Me.ckA4.OnHoverChecked.CheckmarkThickness = 2
        Me.ckA4.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ckA4.OnHoverUnchecked.BorderRadius = 12
        Me.ckA4.OnHoverUnchecked.BorderThickness = 1
        Me.ckA4.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent
        Me.ckA4.OnUncheck.BorderColor = System.Drawing.Color.DarkGray
        Me.ckA4.OnUncheck.BorderRadius = 12
        Me.ckA4.OnUncheck.BorderThickness = 1
        Me.ckA4.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent
        Me.ckA4.Size = New System.Drawing.Size(17, 17)
        Me.ckA4.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu
        Me.ckA4.TabIndex = 156
        Me.ckA4.ThreeState = False
        Me.ckA4.ToolTipText = Nothing
        '
        'Label25
        '
        Me.Label25.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(675, 28)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(78, 21)
        Me.Label25.TabIndex = 155
        Me.Label25.Text = "A5 Paper"
        '
        'Label15
        '
        Me.Label15.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(675, 3)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(84, 21)
        Me.Label15.TabIndex = 154
        Me.Label15.Text = "RollPaper"
        '
        'ckA5Paper
        '
        Me.ckA5Paper.AllowBindingControlAnimation = True
        Me.ckA5Paper.AllowBindingControlColorChanges = False
        Me.ckA5Paper.AllowBindingControlLocation = True
        Me.ckA5Paper.AllowCheckBoxAnimation = False
        Me.ckA5Paper.AllowCheckmarkAnimation = True
        Me.ckA5Paper.AllowOnHoverStates = True
        Me.ckA5Paper.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ckA5Paper.AutoCheck = True
        Me.ckA5Paper.BackColor = System.Drawing.Color.Transparent
        Me.ckA5Paper.BackgroundImage = CType(resources.GetObject("ckA5Paper.BackgroundImage"), System.Drawing.Image)
        Me.ckA5Paper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ckA5Paper.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right
        Me.ckA5Paper.BorderRadius = 12
        Me.ckA5Paper.Checked = False
        Me.ckA5Paper.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Unchecked
        Me.ckA5Paper.Cursor = System.Windows.Forms.Cursors.Default
        Me.ckA5Paper.CustomCheckmarkImage = Nothing
        Me.ckA5Paper.Location = New System.Drawing.Point(655, 31)
        Me.ckA5Paper.MinimumSize = New System.Drawing.Size(17, 17)
        Me.ckA5Paper.Name = "ckA5Paper"
        Me.ckA5Paper.OnCheck.BorderColor = System.Drawing.Color.DodgerBlue
        Me.ckA5Paper.OnCheck.BorderRadius = 12
        Me.ckA5Paper.OnCheck.BorderThickness = 2
        Me.ckA5Paper.OnCheck.CheckBoxColor = System.Drawing.Color.DodgerBlue
        Me.ckA5Paper.OnCheck.CheckmarkColor = System.Drawing.Color.White
        Me.ckA5Paper.OnCheck.CheckmarkThickness = 2
        Me.ckA5Paper.OnDisable.BorderColor = System.Drawing.Color.LightGray
        Me.ckA5Paper.OnDisable.BorderRadius = 12
        Me.ckA5Paper.OnDisable.BorderThickness = 2
        Me.ckA5Paper.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent
        Me.ckA5Paper.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray
        Me.ckA5Paper.OnDisable.CheckmarkThickness = 2
        Me.ckA5Paper.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ckA5Paper.OnHoverChecked.BorderRadius = 12
        Me.ckA5Paper.OnHoverChecked.BorderThickness = 2
        Me.ckA5Paper.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ckA5Paper.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White
        Me.ckA5Paper.OnHoverChecked.CheckmarkThickness = 2
        Me.ckA5Paper.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ckA5Paper.OnHoverUnchecked.BorderRadius = 12
        Me.ckA5Paper.OnHoverUnchecked.BorderThickness = 1
        Me.ckA5Paper.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent
        Me.ckA5Paper.OnUncheck.BorderColor = System.Drawing.Color.DarkGray
        Me.ckA5Paper.OnUncheck.BorderRadius = 12
        Me.ckA5Paper.OnUncheck.BorderThickness = 1
        Me.ckA5Paper.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent
        Me.ckA5Paper.Size = New System.Drawing.Size(17, 17)
        Me.ckA5Paper.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu
        Me.ckA5Paper.TabIndex = 153
        Me.ckA5Paper.ThreeState = False
        Me.ckA5Paper.ToolTipText = Nothing
        '
        'ckrollPaper
        '
        Me.ckrollPaper.AllowBindingControlAnimation = True
        Me.ckrollPaper.AllowBindingControlColorChanges = False
        Me.ckrollPaper.AllowBindingControlLocation = True
        Me.ckrollPaper.AllowCheckBoxAnimation = False
        Me.ckrollPaper.AllowCheckmarkAnimation = True
        Me.ckrollPaper.AllowOnHoverStates = True
        Me.ckrollPaper.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ckrollPaper.AutoCheck = True
        Me.ckrollPaper.BackColor = System.Drawing.Color.Transparent
        Me.ckrollPaper.BackgroundImage = CType(resources.GetObject("ckrollPaper.BackgroundImage"), System.Drawing.Image)
        Me.ckrollPaper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ckrollPaper.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right
        Me.ckrollPaper.BorderRadius = 12
        Me.ckrollPaper.Checked = True
        Me.ckrollPaper.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Checked
        Me.ckrollPaper.Cursor = System.Windows.Forms.Cursors.Default
        Me.ckrollPaper.CustomCheckmarkImage = Nothing
        Me.ckrollPaper.Location = New System.Drawing.Point(655, 6)
        Me.ckrollPaper.MinimumSize = New System.Drawing.Size(17, 17)
        Me.ckrollPaper.Name = "ckrollPaper"
        Me.ckrollPaper.OnCheck.BorderColor = System.Drawing.Color.DodgerBlue
        Me.ckrollPaper.OnCheck.BorderRadius = 12
        Me.ckrollPaper.OnCheck.BorderThickness = 2
        Me.ckrollPaper.OnCheck.CheckBoxColor = System.Drawing.Color.DodgerBlue
        Me.ckrollPaper.OnCheck.CheckmarkColor = System.Drawing.Color.White
        Me.ckrollPaper.OnCheck.CheckmarkThickness = 2
        Me.ckrollPaper.OnDisable.BorderColor = System.Drawing.Color.LightGray
        Me.ckrollPaper.OnDisable.BorderRadius = 12
        Me.ckrollPaper.OnDisable.BorderThickness = 2
        Me.ckrollPaper.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent
        Me.ckrollPaper.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray
        Me.ckrollPaper.OnDisable.CheckmarkThickness = 2
        Me.ckrollPaper.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ckrollPaper.OnHoverChecked.BorderRadius = 12
        Me.ckrollPaper.OnHoverChecked.BorderThickness = 2
        Me.ckrollPaper.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ckrollPaper.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White
        Me.ckrollPaper.OnHoverChecked.CheckmarkThickness = 2
        Me.ckrollPaper.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ckrollPaper.OnHoverUnchecked.BorderRadius = 12
        Me.ckrollPaper.OnHoverUnchecked.BorderThickness = 1
        Me.ckrollPaper.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent
        Me.ckrollPaper.OnUncheck.BorderColor = System.Drawing.Color.DarkGray
        Me.ckrollPaper.OnUncheck.BorderRadius = 12
        Me.ckrollPaper.OnUncheck.BorderThickness = 1
        Me.ckrollPaper.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent
        Me.ckrollPaper.Size = New System.Drawing.Size(17, 17)
        Me.ckrollPaper.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu
        Me.ckrollPaper.TabIndex = 152
        Me.ckrollPaper.ThreeState = False
        Me.ckrollPaper.ToolTipText = Nothing
        '
        'Label35
        '
        Me.Label35.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(537, 46)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(112, 21)
        Me.Label35.TabIndex = 151
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
        Me.ckprintpreview.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
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
        Me.ckprintpreview.Location = New System.Drawing.Point(517, 49)
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
        Me.ckprintpreview.TabIndex = 150
        Me.ckprintpreview.ThreeState = False
        Me.ckprintpreview.ToolTipText = Nothing
        '
        'Label34
        '
        Me.Label34.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(561, 12)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(47, 21)
        Me.Label34.TabIndex = 149
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
        Me.ckprint.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
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
        Me.ckprint.Location = New System.Drawing.Point(541, 15)
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
        Me.ckprint.TabIndex = 148
        Me.ckprint.ThreeState = False
        Me.ckprint.ToolTipText = Nothing
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.BackColor = System.Drawing.Color.Khaki
        Me.GroupBox2.Controls.Add(Me.lblItemName)
        Me.GroupBox2.Controls.Add(Me.BunifuThinButton22)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtNewQtySold)
        Me.GroupBox2.Controls.Add(Me.txtToBeCancelled)
        Me.GroupBox2.Controls.Add(Me.txtQtySold)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(343, 134)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(619, 135)
        Me.GroupBox2.TabIndex = 35
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'dpdateto
        '
        Me.dpdateto.BackColor = System.Drawing.Color.Transparent
        Me.dpdateto.BorderColor = System.Drawing.Color.Silver
        Me.dpdateto.BorderRadius = 1
        Me.dpdateto.Color = System.Drawing.Color.Silver
        Me.dpdateto.CustomFormat = "MM/dd/yyyy"
        Me.dpdateto.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin
        Me.dpdateto.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left
        Me.dpdateto.DisabledColor = System.Drawing.Color.Gray
        Me.dpdateto.DisplayWeekNumbers = False
        Me.dpdateto.DPHeight = 0
        Me.dpdateto.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dpdateto.FillDatePicker = False
        Me.dpdateto.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dpdateto.ForeColor = System.Drawing.Color.Black
        Me.dpdateto.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dpdateto.Icon = CType(resources.GetObject("dpdateto.Icon"), System.Drawing.Image)
        Me.dpdateto.IconColor = System.Drawing.Color.Gray
        Me.dpdateto.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right
        Me.dpdateto.LeftTextMargin = 5
        Me.dpdateto.Location = New System.Drawing.Point(216, 139)
        Me.dpdateto.MinimumSize = New System.Drawing.Size(4, 32)
        Me.dpdateto.Name = "dpdateto"
        Me.dpdateto.Size = New System.Drawing.Size(122, 32)
        Me.dpdateto.TabIndex = 36
        Me.dpdateto.Value = New Date(2021, 11, 18, 0, 0, 0, 0)
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(185, 146)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(28, 21)
        Me.Label9.TabIndex = 37
        Me.Label9.Text = "To"
        Me.Label9.Visible = False
        '
        'frmSalesCancelation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(974, 651)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.dpdateto)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.dpDate)
        Me.Controls.Add(Me.BunifuThinButton25)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblActualStock)
        Me.Controls.Add(Me.lblProdCode)
        Me.Controls.Add(Me.lblRecieptNo)
        Me.Controls.Add(Me.gvReciepts)
        Me.Controls.Add(Me.BunifuThinButton21)
        Me.Controls.Add(Me.txtRecieptNo)
        Me.Controls.Add(Me.gvSalesReciepts)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmSalesCancelation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmSalesCancelation"
        CType(Me.gvSalesReciepts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvReciepts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gvSalesReciepts As DataGridView
    Friend WithEvents txtRecieptNo As TextBox
    Friend WithEvents BunifuThinButton21 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents gvReciepts As DataGridView
    Friend WithEvents txtQtySold As TextBox
    Friend WithEvents txtToBeCancelled As TextBox
    Friend WithEvents txtNewQtySold As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BunifuThinButton22 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents ItemCode As DataGridViewTextBoxColumn
    Friend WithEvents ItemName As DataGridViewTextBoxColumn
    Friend WithEvents QtySold As DataGridViewTextBoxColumn
    Friend WithEvents RPrice As DataGridViewTextBoxColumn
    Friend WithEvents Amount As DataGridViewTextBoxColumn
    Friend WithEvents RecieptNo As DataGridViewTextBoxColumn
    Friend WithEvents NewQtySold As DataGridViewTextBoxColumn
    Friend WithEvents NewAmount As DataGridViewTextBoxColumn
    Friend WithEvents lblItemName As Label
    Friend WithEvents lblRecieptNo As Label
    Friend WithEvents lblProdCode As Label
    Friend WithEvents CancellationQty As DataGridViewTextBoxColumn
    Friend WithEvents BunifuThinButton23 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents NewQty As DataGridViewTextBoxColumn
    Friend WithEvents lblActualStock As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents lblBuyerName As Label
    Friend WithEvents lblBuyerTel As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ActiveUser As ToolStripStatusLabel
    Friend WithEvents Label7 As Label
    Friend WithEvents lblCustLoc As Label
    Friend WithEvents lblTimeSold As Label
    Friend WithEvents lblDateSold As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents BunifuThinButton24 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents BunifuThinButton25 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents dpDate As Bunifu.UI.WinForms.BunifuDatePicker
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label35 As Label
    Friend WithEvents ckprintpreview As Bunifu.UI.WinForms.BunifuCheckBox
    Friend WithEvents Label34 As Label
    Friend WithEvents ckprint As Bunifu.UI.WinForms.BunifuCheckBox
    Friend WithEvents Label28 As Label
    Friend WithEvents ckA4 As Bunifu.UI.WinForms.BunifuCheckBox
    Friend WithEvents Label25 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents ckA5Paper As Bunifu.UI.WinForms.BunifuCheckBox
    Friend WithEvents ckrollPaper As Bunifu.UI.WinForms.BunifuCheckBox
    Friend WithEvents dpdateto As Bunifu.UI.WinForms.BunifuDatePicker
    Friend WithEvents Label9 As Label
End Class
