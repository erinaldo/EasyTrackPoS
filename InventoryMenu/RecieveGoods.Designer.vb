<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRecieveGoods
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRecieveGoods))
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.cbSearchItem = New System.Windows.Forms.ComboBox()
        Me.txtQtyRecieved = New System.Windows.Forms.TextBox()
        Me.txtItemPrice = New System.Windows.Forms.TextBox()
        Me.txtItemAmount = New System.Windows.Forms.TextBox()
        Me.gvStockBatch = New System.Windows.Forms.DataGridView()
        Me.clItemName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clOldStock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clQtyRecieved = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clNewStock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemCat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PackVolume = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OderQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtinvoiceno = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblProdcode = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtNarration = New System.Windows.Forms.RichTextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtActualStock = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtCat = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbloderid = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.lbldate = New System.Windows.Forms.Label()
        Me.lbltime = New System.Windows.Forms.Label()
        Me.BunifuThinButton24 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.tsuser = New System.Windows.Forms.Label()
        Me.tstime = New System.Windows.Forms.Label()
        Me.gvStockBf = New Bunifu.UI.WinForms.BunifuDataGridView()
        Me.BunifuThinButton21 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuThinButton22 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BunifuThinButton23 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.txtItemName = New System.Windows.Forms.Label()
        Me.cbSuppName = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblOldBal = New System.Windows.Forms.Label()
        Me.lblCustNo = New System.Windows.Forms.Label()
        Me.lblNewBal = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.cbProdlineSort = New System.Windows.Forms.ComboBox()
        Me.BunifuThinButton25 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.cbCatSort = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtdate = New Bunifu.UI.WinForms.BunifuDatePicker()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.tkPreview = New Bunifu.UI.WinForms.BunifuCheckBox()
        Me.ckprint = New Bunifu.UI.WinForms.BunifuCheckBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.BunifuThinButton26 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.txtReprint = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtPackVolume = New System.Windows.Forms.TextBox()
        Me.txtbaseQty = New System.Windows.Forms.TextBox()
        Me.txtPackSize = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        CType(Me.gvStockBatch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.gvStockBf, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbSearchItem
        '
        Me.cbSearchItem.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbSearchItem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbSearchItem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbSearchItem.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSearchItem.FormattingEnabled = True
        Me.cbSearchItem.Location = New System.Drawing.Point(21, 50)
        Me.cbSearchItem.Name = "cbSearchItem"
        Me.cbSearchItem.Size = New System.Drawing.Size(439, 33)
        Me.cbSearchItem.TabIndex = 0
        '
        'txtQtyRecieved
        '
        Me.txtQtyRecieved.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtQtyRecieved.Location = New System.Drawing.Point(239, 102)
        Me.txtQtyRecieved.Name = "txtQtyRecieved"
        Me.txtQtyRecieved.Size = New System.Drawing.Size(76, 29)
        Me.txtQtyRecieved.TabIndex = 1
        '
        'txtItemPrice
        '
        Me.txtItemPrice.Enabled = False
        Me.txtItemPrice.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtItemPrice.Location = New System.Drawing.Point(334, 100)
        Me.txtItemPrice.Name = "txtItemPrice"
        Me.txtItemPrice.Size = New System.Drawing.Size(66, 29)
        Me.txtItemPrice.TabIndex = 3
        '
        'txtItemAmount
        '
        Me.txtItemAmount.Enabled = False
        Me.txtItemAmount.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtItemAmount.Location = New System.Drawing.Point(406, 100)
        Me.txtItemAmount.Name = "txtItemAmount"
        Me.txtItemAmount.Size = New System.Drawing.Size(67, 29)
        Me.txtItemAmount.TabIndex = 4
        '
        'gvStockBatch
        '
        Me.gvStockBatch.AllowDrop = True
        Me.gvStockBatch.AllowUserToAddRows = False
        Me.gvStockBatch.AllowUserToOrderColumns = True
        Me.gvStockBatch.AllowUserToResizeRows = False
        Me.gvStockBatch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gvStockBatch.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.gvStockBatch.BackgroundColor = System.Drawing.Color.White
        Me.gvStockBatch.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.gvStockBatch.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.gvStockBatch.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gvStockBatch.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.gvStockBatch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gvStockBatch.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clItemName, Me.clOldStock, Me.clPrice, Me.clQtyRecieved, Me.clNewStock, Me.clAmount, Me.ProdCode, Me.ItemCat, Me.PackVolume, Me.OderQty})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.gvStockBatch.DefaultCellStyle = DataGridViewCellStyle7
        Me.gvStockBatch.GridColor = System.Drawing.Color.DarkRed
        Me.gvStockBatch.Location = New System.Drawing.Point(479, 222)
        Me.gvStockBatch.Name = "gvStockBatch"
        Me.gvStockBatch.ReadOnly = True
        Me.gvStockBatch.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.gvStockBatch.RowHeadersVisible = False
        Me.gvStockBatch.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.gvStockBatch.RowTemplate.Height = 25
        Me.gvStockBatch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gvStockBatch.Size = New System.Drawing.Size(591, 262)
        Me.gvStockBatch.TabIndex = 36
        '
        'clItemName
        '
        Me.clItemName.Frozen = True
        Me.clItemName.HeaderText = "Item Name"
        Me.clItemName.Name = "clItemName"
        Me.clItemName.ReadOnly = True
        '
        'clOldStock
        '
        Me.clOldStock.HeaderText = "Old Stock"
        Me.clOldStock.Name = "clOldStock"
        Me.clOldStock.ReadOnly = True
        '
        'clPrice
        '
        Me.clPrice.HeaderText = "Price"
        Me.clPrice.Name = "clPrice"
        Me.clPrice.ReadOnly = True
        '
        'clQtyRecieved
        '
        Me.clQtyRecieved.HeaderText = "Qty Recieved"
        Me.clQtyRecieved.Name = "clQtyRecieved"
        Me.clQtyRecieved.ReadOnly = True
        '
        'clNewStock
        '
        Me.clNewStock.HeaderText = "New Stock"
        Me.clNewStock.Name = "clNewStock"
        Me.clNewStock.ReadOnly = True
        '
        'clAmount
        '
        Me.clAmount.HeaderText = "Amount"
        Me.clAmount.Name = "clAmount"
        Me.clAmount.ReadOnly = True
        '
        'ProdCode
        '
        Me.ProdCode.HeaderText = "ProductCode"
        Me.ProdCode.Name = "ProdCode"
        Me.ProdCode.ReadOnly = True
        '
        'ItemCat
        '
        Me.ItemCat.HeaderText = "Category"
        Me.ItemCat.Name = "ItemCat"
        Me.ItemCat.ReadOnly = True
        '
        'PackVolume
        '
        Me.PackVolume.HeaderText = "PackVolume"
        Me.PackVolume.Name = "PackVolume"
        Me.PackVolume.ReadOnly = True
        '
        'OderQty
        '
        Me.OderQty.HeaderText = "OderQty"
        Me.OderQty.Name = "OderQty"
        Me.OderQty.ReadOnly = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(236, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 17)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Qty Recieved"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(334, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 17)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Price"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(406, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 17)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Amount"
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(34, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 17)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "Search Item"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(241, 39)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "Recieve Stock"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 23)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 20)
        Me.Label7.TabIndex = 48
        Me.Label7.Text = "Date"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(4, 60)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 20)
        Me.Label8.TabIndex = 50
        Me.Label8.Text = "Invoice No"
        '
        'txtinvoiceno
        '
        Me.txtinvoiceno.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtinvoiceno.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.txtinvoiceno.Location = New System.Drawing.Point(89, 61)
        Me.txtinvoiceno.Name = "txtinvoiceno"
        Me.txtinvoiceno.Size = New System.Drawing.Size(131, 27)
        Me.txtinvoiceno.TabIndex = 49
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 129)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 20)
        Me.Label9.TabIndex = 52
        Me.Label9.Text = "Narration"
        '
        'lblProdcode
        '
        Me.lblProdcode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblProdcode.AutoSize = True
        Me.lblProdcode.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProdcode.Location = New System.Drawing.Point(297, 39)
        Me.lblProdcode.Name = "lblProdcode"
        Me.lblProdcode.Size = New System.Drawing.Size(61, 16)
        Me.lblProdcode.TabIndex = 54
        Me.lblProdcode.Text = "prodcode"
        Me.lblProdcode.Visible = False
        '
        'Label11
        '
        Me.Label11.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label11.Location = New System.Drawing.Point(33, 86)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(112, 17)
        Me.Label11.TabIndex = 56
        Me.Label11.Text = "Sort By Category"
        '
        'Label12
        '
        Me.Label12.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label12.Location = New System.Drawing.Point(222, 84)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(129, 17)
        Me.Label12.TabIndex = 58
        Me.Label12.Text = "Sort By Product line"
        '
        'txtNarration
        '
        Me.txtNarration.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtNarration.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNarration.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNarration.Location = New System.Drawing.Point(89, 129)
        Me.txtNarration.Name = "txtNarration"
        Me.txtNarration.Size = New System.Drawing.Size(254, 49)
        Me.txtNarration.TabIndex = 59
        Me.txtNarration.Text = "Goods Recieved"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label13.Location = New System.Drawing.Point(150, 83)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(83, 17)
        Me.Label13.TabIndex = 61
        Me.Label13.Text = "Actual Stock"
        '
        'txtActualStock
        '
        Me.txtActualStock.Enabled = False
        Me.txtActualStock.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtActualStock.Location = New System.Drawing.Point(155, 104)
        Me.txtActualStock.Name = "txtActualStock"
        Me.txtActualStock.Size = New System.Drawing.Size(78, 29)
        Me.txtActualStock.TabIndex = 60
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label14.Location = New System.Drawing.Point(7, 83)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(64, 17)
        Me.Label14.TabIndex = 63
        Me.Label14.Text = "Category"
        '
        'txtCat
        '
        Me.txtCat.Enabled = False
        Me.txtCat.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtCat.Location = New System.Drawing.Point(8, 103)
        Me.txtCat.Name = "txtCat"
        Me.txtCat.Size = New System.Drawing.Size(63, 29)
        Me.txtCat.TabIndex = 62
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(10, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(41, 42)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 98
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'Timer1
        '
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.Controls.Add(Me.lbloderid)
        Me.Panel1.Controls.Add(Me.Label22)
        Me.Panel1.Controls.Add(Me.Label21)
        Me.Panel1.Controls.Add(Me.lbldate)
        Me.Panel1.Controls.Add(Me.lbltime)
        Me.Panel1.Controls.Add(Me.BunifuThinButton24)
        Me.Panel1.Controls.Add(Me.tsuser)
        Me.Panel1.Controls.Add(Me.tstime)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.lblProdcode)
        Me.Panel1.Location = New System.Drawing.Point(0, -3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1088, 68)
        Me.Panel1.TabIndex = 142
        '
        'lbloderid
        '
        Me.lbloderid.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbloderid.AutoSize = True
        Me.lbloderid.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbloderid.Location = New System.Drawing.Point(527, 26)
        Me.lbloderid.Name = "lbloderid"
        Me.lbloderid.Size = New System.Drawing.Size(36, 16)
        Me.lbloderid.TabIndex = 164
        Me.lbloderid.Text = "Oder"
        Me.lbloderid.Visible = False
        '
        'Label22
        '
        Me.Label22.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.White
        Me.Label22.Location = New System.Drawing.Point(615, 4)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(85, 32)
        Me.Label22.TabIndex = 163
        Me.Label22.Text = "Date:"
        '
        'Label21
        '
        Me.Label21.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.White
        Me.Label21.Location = New System.Drawing.Point(617, 36)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(82, 32)
        Me.Label21.TabIndex = 162
        Me.Label21.Text = "Time:"
        '
        'lbldate
        '
        Me.lbldate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbldate.AutoSize = True
        Me.lbldate.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldate.ForeColor = System.Drawing.Color.White
        Me.lbldate.Location = New System.Drawing.Point(724, 2)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(77, 32)
        Me.lbldate.TabIndex = 161
        Me.lbldate.Text = "Date"
        '
        'lbltime
        '
        Me.lbltime.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbltime.AutoSize = True
        Me.lbltime.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltime.ForeColor = System.Drawing.Color.White
        Me.lbltime.Location = New System.Drawing.Point(724, 34)
        Me.lbltime.Name = "lbltime"
        Me.lbltime.Size = New System.Drawing.Size(74, 32)
        Me.lbltime.TabIndex = 160
        Me.lbltime.Text = "Time"
        '
        'BunifuThinButton24
        '
        Me.BunifuThinButton24.ActiveBorderThickness = 1
        Me.BunifuThinButton24.ActiveCornerRadius = 20
        Me.BunifuThinButton24.ActiveFillColor = System.Drawing.Color.MediumPurple
        Me.BunifuThinButton24.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton24.ActiveLineColor = System.Drawing.Color.MediumPurple
        Me.BunifuThinButton24.BackColor = System.Drawing.Color.SteelBlue
        Me.BunifuThinButton24.BackgroundImage = CType(resources.GetObject("BunifuThinButton24.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton24.ButtonText = "Refresh"
        Me.BunifuThinButton24.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton24.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton24.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton24.IdleBorderThickness = 1
        Me.BunifuThinButton24.IdleCornerRadius = 20
        Me.BunifuThinButton24.IdleFillColor = System.Drawing.Color.White
        Me.BunifuThinButton24.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton24.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton24.Location = New System.Drawing.Point(974, 5)
        Me.BunifuThinButton24.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton24.Name = "BunifuThinButton24"
        Me.BunifuThinButton24.Size = New System.Drawing.Size(109, 46)
        Me.BunifuThinButton24.TabIndex = 155
        Me.BunifuThinButton24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tsuser
        '
        Me.tsuser.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tsuser.AutoSize = True
        Me.tsuser.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsuser.Location = New System.Drawing.Point(324, 19)
        Me.tsuser.Name = "tsuser"
        Me.tsuser.Size = New System.Drawing.Size(34, 16)
        Me.tsuser.TabIndex = 145
        Me.tsuser.Text = "User"
        Me.tsuser.Visible = False
        '
        'tstime
        '
        Me.tstime.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tstime.AutoSize = True
        Me.tstime.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tstime.Location = New System.Drawing.Point(376, 17)
        Me.tstime.Name = "tstime"
        Me.tstime.Size = New System.Drawing.Size(37, 16)
        Me.tstime.TabIndex = 144
        Me.tstime.Text = "Time"
        '
        'gvStockBf
        '
        Me.gvStockBf.AllowCustomTheming = True
        Me.gvStockBf.AllowUserToAddRows = False
        Me.gvStockBf.AllowUserToDeleteRows = False
        Me.gvStockBf.AllowUserToResizeRows = False
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black
        Me.gvStockBf.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle8
        Me.gvStockBf.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gvStockBf.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.gvStockBf.BackgroundColor = System.Drawing.Color.White
        Me.gvStockBf.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.gvStockBf.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.gvStockBf.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.MediumPurple
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(204, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gvStockBf.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.gvStockBf.ColumnHeadersHeight = 20
        Me.gvStockBf.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvStockBf.CurrentTheme.AlternatingRowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.gvStockBf.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black
        Me.gvStockBf.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvStockBf.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.gvStockBf.CurrentTheme.BackColor = System.Drawing.Color.White
        Me.gvStockBf.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvStockBf.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.MediumPurple
        Me.gvStockBf.CurrentTheme.HeaderStyle.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvStockBf.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.gvStockBf.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.gvStockBf.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White
        Me.gvStockBf.CurrentTheme.Name = Nothing
        Me.gvStockBf.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White
        Me.gvStockBf.CurrentTheme.RowsStyle.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvStockBf.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.gvStockBf.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvStockBf.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.gvStockBf.DefaultCellStyle = DataGridViewCellStyle10
        Me.gvStockBf.EnableHeadersVisualStyles = False
        Me.gvStockBf.GridColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvStockBf.HeaderBackColor = System.Drawing.Color.MediumPurple
        Me.gvStockBf.HeaderBgColor = System.Drawing.Color.Empty
        Me.gvStockBf.HeaderForeColor = System.Drawing.Color.White
        Me.gvStockBf.Location = New System.Drawing.Point(8, 245)
        Me.gvStockBf.MultiSelect = False
        Me.gvStockBf.Name = "gvStockBf"
        Me.gvStockBf.ReadOnly = True
        Me.gvStockBf.RowHeadersVisible = False
        Me.gvStockBf.RowTemplate.Height = 40
        Me.gvStockBf.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gvStockBf.ShowEditingIcon = False
        Me.gvStockBf.Size = New System.Drawing.Size(452, 332)
        Me.gvStockBf.TabIndex = 143
        Me.gvStockBf.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light
        '
        'BunifuThinButton21
        '
        Me.BunifuThinButton21.ActiveBorderThickness = 1
        Me.BunifuThinButton21.ActiveCornerRadius = 20
        Me.BunifuThinButton21.ActiveFillColor = System.Drawing.Color.MediumPurple
        Me.BunifuThinButton21.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton21.ActiveLineColor = System.Drawing.Color.MediumPurple
        Me.BunifuThinButton21.BackColor = System.Drawing.Color.LightBlue
        Me.BunifuThinButton21.BackgroundImage = CType(resources.GetObject("BunifuThinButton21.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton21.ButtonText = "ADD"
        Me.BunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton21.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton21.IdleBorderThickness = 1
        Me.BunifuThinButton21.IdleCornerRadius = 20
        Me.BunifuThinButton21.IdleFillColor = System.Drawing.Color.White
        Me.BunifuThinButton21.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton21.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton21.Location = New System.Drawing.Point(481, 81)
        Me.BunifuThinButton21.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton21.Name = "BunifuThinButton21"
        Me.BunifuThinButton21.Size = New System.Drawing.Size(110, 52)
        Me.BunifuThinButton21.TabIndex = 144
        Me.BunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuThinButton22
        '
        Me.BunifuThinButton22.ActiveBorderThickness = 1
        Me.BunifuThinButton22.ActiveCornerRadius = 20
        Me.BunifuThinButton22.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton22.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton22.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton22.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BunifuThinButton22.BackColor = System.Drawing.Color.LightBlue
        Me.BunifuThinButton22.BackgroundImage = CType(resources.GetObject("BunifuThinButton22.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton22.ButtonText = "SAVE"
        Me.BunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton22.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton22.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton22.IdleBorderThickness = 1
        Me.BunifuThinButton22.IdleCornerRadius = 20
        Me.BunifuThinButton22.IdleFillColor = System.Drawing.Color.White
        Me.BunifuThinButton22.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton22.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton22.Location = New System.Drawing.Point(449, 106)
        Me.BunifuThinButton22.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton22.Name = "BunifuThinButton22"
        Me.BunifuThinButton22.Size = New System.Drawing.Size(140, 72)
        Me.BunifuThinButton22.TabIndex = 145
        Me.BunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotal
        '
        Me.lblTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(261, 71)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(38, 45)
        Me.lblTotal.TabIndex = 146
        Me.lblTotal.Text = "0"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(228, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 25)
        Me.Label6.TabIndex = 147
        Me.Label6.Text = "Total"
        '
        'BunifuThinButton23
        '
        Me.BunifuThinButton23.ActiveBorderThickness = 1
        Me.BunifuThinButton23.ActiveCornerRadius = 20
        Me.BunifuThinButton23.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton23.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton23.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton23.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BunifuThinButton23.BackColor = System.Drawing.Color.LightBlue
        Me.BunifuThinButton23.BackgroundImage = CType(resources.GetObject("BunifuThinButton23.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton23.ButtonText = "Clear"
        Me.BunifuThinButton23.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton23.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton23.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton23.IdleBorderThickness = 1
        Me.BunifuThinButton23.IdleCornerRadius = 20
        Me.BunifuThinButton23.IdleFillColor = System.Drawing.Color.White
        Me.BunifuThinButton23.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton23.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton23.Location = New System.Drawing.Point(530, 10)
        Me.BunifuThinButton23.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton23.Name = "BunifuThinButton23"
        Me.BunifuThinButton23.Size = New System.Drawing.Size(52, 63)
        Me.BunifuThinButton23.TabIndex = 148
        Me.BunifuThinButton23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtItemName
        '
        Me.txtItemName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtItemName.AutoSize = True
        Me.txtItemName.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Bold)
        Me.txtItemName.Location = New System.Drawing.Point(12, 16)
        Me.txtItemName.Name = "txtItemName"
        Me.txtItemName.Size = New System.Drawing.Size(194, 47)
        Me.txtItemName.TabIndex = 149
        Me.txtItemName.Text = "ItemName"
        '
        'cbSuppName
        '
        Me.cbSuppName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSuppName.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSuppName.FormattingEnabled = True
        Me.cbSuppName.Items.AddRange(New Object() {"CASH"})
        Me.cbSuppName.Location = New System.Drawing.Point(335, 29)
        Me.cbSuppName.Name = "cbSuppName"
        Me.cbSuppName.Size = New System.Drawing.Size(191, 29)
        Me.cbSuppName.TabIndex = 150
        '
        'Label10
        '
        Me.Label10.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label10.Location = New System.Drawing.Point(340, 10)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(106, 17)
        Me.Label10.TabIndex = 151
        Me.Label10.Text = "Choose Supplier"
        '
        'lblOldBal
        '
        Me.lblOldBal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblOldBal.AutoSize = True
        Me.lblOldBal.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOldBal.Location = New System.Drawing.Point(341, 61)
        Me.lblOldBal.Name = "lblOldBal"
        Me.lblOldBal.Size = New System.Drawing.Size(50, 15)
        Me.lblOldBal.TabIndex = 152
        Me.lblOldBal.Text = "Balance"
        Me.lblOldBal.Visible = False
        '
        'lblCustNo
        '
        Me.lblCustNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCustNo.AutoSize = True
        Me.lblCustNo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustNo.Location = New System.Drawing.Point(397, 62)
        Me.lblCustNo.Name = "lblCustNo"
        Me.lblCustNo.Size = New System.Drawing.Size(47, 15)
        Me.lblCustNo.TabIndex = 153
        Me.lblCustNo.Text = "CustNo"
        Me.lblCustNo.Visible = False
        '
        'lblNewBal
        '
        Me.lblNewBal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNewBal.AutoSize = True
        Me.lblNewBal.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewBal.Location = New System.Drawing.Point(450, 64)
        Me.lblNewBal.Name = "lblNewBal"
        Me.lblNewBal.Size = New System.Drawing.Size(50, 15)
        Me.lblNewBal.TabIndex = 154
        Me.lblNewBal.Text = "NewBal"
        Me.lblNewBal.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.PeachPuff
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.cbProdlineSort)
        Me.GroupBox1.Controls.Add(Me.BunifuThinButton25)
        Me.GroupBox1.Controls.Add(Me.cbCatSort)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.cbSearchItem)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 71)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(466, 168)
        Me.GroupBox1.TabIndex = 155
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'ComboBox1
        '
        Me.ComboBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Items", "Oders"})
        Me.ComboBox1.Location = New System.Drawing.Point(14, 135)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(439, 25)
        Me.ComboBox1.TabIndex = 206
        '
        'cbProdlineSort
        '
        Me.cbProdlineSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbProdlineSort.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbProdlineSort.FormattingEnabled = True
        Me.cbProdlineSort.Location = New System.Drawing.Point(225, 105)
        Me.cbProdlineSort.Name = "cbProdlineSort"
        Me.cbProdlineSort.Size = New System.Drawing.Size(126, 25)
        Me.cbProdlineSort.TabIndex = 205
        '
        'BunifuThinButton25
        '
        Me.BunifuThinButton25.ActiveBorderThickness = 1
        Me.BunifuThinButton25.ActiveCornerRadius = 20
        Me.BunifuThinButton25.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton25.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton25.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton25.BackColor = System.Drawing.Color.PeachPuff
        Me.BunifuThinButton25.BackgroundImage = CType(resources.GetObject("BunifuThinButton25.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton25.ButtonText = "Reset"
        Me.BunifuThinButton25.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton25.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton25.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton25.IdleBorderThickness = 1
        Me.BunifuThinButton25.IdleCornerRadius = 20
        Me.BunifuThinButton25.IdleFillColor = System.Drawing.Color.White
        Me.BunifuThinButton25.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton25.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton25.Location = New System.Drawing.Point(372, 87)
        Me.BunifuThinButton25.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton25.Name = "BunifuThinButton25"
        Me.BunifuThinButton25.Size = New System.Drawing.Size(66, 42)
        Me.BunifuThinButton25.TabIndex = 204
        Me.BunifuThinButton25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cbCatSort
        '
        Me.cbCatSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCatSort.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCatSort.FormattingEnabled = True
        Me.cbCatSort.Location = New System.Drawing.Point(36, 104)
        Me.cbCatSort.Name = "cbCatSort"
        Me.cbCatSort.Size = New System.Drawing.Size(131, 25)
        Me.cbCatSort.TabIndex = 170
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.BackColor = System.Drawing.Color.LightBlue
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.txtItemName)
        Me.GroupBox2.Controls.Add(Me.BunifuThinButton21)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.txtCat)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.txtActualStock)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtItemAmount)
        Me.GroupBox2.Controls.Add(Me.txtItemPrice)
        Me.GroupBox2.Controls.Add(Me.txtQtyRecieved)
        Me.GroupBox2.Location = New System.Drawing.Point(479, 71)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(609, 137)
        Me.GroupBox2.TabIndex = 156
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label17.Location = New System.Drawing.Point(78, 82)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(64, 17)
        Me.Label17.TabIndex = 151
        Me.Label17.Text = "Oder Qty"
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TextBox1.Location = New System.Drawing.Point(77, 103)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(72, 29)
        Me.TextBox1.TabIndex = 150
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.BackColor = System.Drawing.Color.LightBlue
        Me.GroupBox3.Controls.Add(Me.TextBox2)
        Me.GroupBox3.Controls.Add(Me.Label23)
        Me.GroupBox3.Controls.Add(Me.lblOldBal)
        Me.GroupBox3.Controls.Add(Me.txtdate)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.tkPreview)
        Me.GroupBox3.Controls.Add(Me.lblCustNo)
        Me.GroupBox3.Controls.Add(Me.ckprint)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.lblNewBal)
        Me.GroupBox3.Controls.Add(Me.BunifuThinButton23)
        Me.GroupBox3.Controls.Add(Me.lblTotal)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.BunifuThinButton22)
        Me.GroupBox3.Controls.Add(Me.txtinvoiceno)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.cbSuppName)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.txtNarration)
        Me.GroupBox3.Location = New System.Drawing.Point(480, 490)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(590, 186)
        Me.GroupBox3.TabIndex = 157
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "GroupBox3"
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox2.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.TextBox2.Location = New System.Drawing.Point(89, 93)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(131, 27)
        Me.TextBox2.TabIndex = 155
        '
        'Label23
        '
        Me.Label23.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(13, 93)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(65, 20)
        Me.Label23.TabIndex = 156
        Me.Label23.Text = "Way Bill"
        '
        'txtdate
        '
        Me.txtdate.BackColor = System.Drawing.Color.Transparent
        Me.txtdate.BorderColor = System.Drawing.Color.Silver
        Me.txtdate.BorderRadius = 1
        Me.txtdate.CalendarTitleBackColor = System.Drawing.Color.White
        Me.txtdate.Color = System.Drawing.Color.Silver
        Me.txtdate.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin
        Me.txtdate.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left
        Me.txtdate.DisabledColor = System.Drawing.Color.Gray
        Me.txtdate.DisplayWeekNumbers = False
        Me.txtdate.DPHeight = 0
        Me.txtdate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.txtdate.FillDatePicker = False
        Me.txtdate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtdate.ForeColor = System.Drawing.Color.Black
        Me.txtdate.Icon = CType(resources.GetObject("txtdate.Icon"), System.Drawing.Image)
        Me.txtdate.IconColor = System.Drawing.Color.Gray
        Me.txtdate.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right
        Me.txtdate.LeftTextMargin = 5
        Me.txtdate.Location = New System.Drawing.Point(54, 20)
        Me.txtdate.MinimumSize = New System.Drawing.Size(4, 32)
        Me.txtdate.Name = "txtdate"
        Me.txtdate.Size = New System.Drawing.Size(133, 32)
        Me.txtdate.TabIndex = 152
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(372, 146)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(71, 21)
        Me.Label16.TabIndex = 151
        Me.Label16.Text = "Preview"
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(375, 121)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(47, 21)
        Me.Label15.TabIndex = 151
        Me.Label15.Text = "Print"
        '
        'tkPreview
        '
        Me.tkPreview.AllowBindingControlAnimation = True
        Me.tkPreview.AllowBindingControlColorChanges = False
        Me.tkPreview.AllowBindingControlLocation = True
        Me.tkPreview.AllowCheckBoxAnimation = False
        Me.tkPreview.AllowCheckmarkAnimation = True
        Me.tkPreview.AllowOnHoverStates = True
        Me.tkPreview.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tkPreview.AutoCheck = True
        Me.tkPreview.BackColor = System.Drawing.Color.Transparent
        Me.tkPreview.BackgroundImage = CType(resources.GetObject("tkPreview.BackgroundImage"), System.Drawing.Image)
        Me.tkPreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tkPreview.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right
        Me.tkPreview.BorderRadius = 12
        Me.tkPreview.Checked = False
        Me.tkPreview.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Unchecked
        Me.tkPreview.Cursor = System.Windows.Forms.Cursors.Default
        Me.tkPreview.CustomCheckmarkImage = Nothing
        Me.tkPreview.Location = New System.Drawing.Point(352, 149)
        Me.tkPreview.MinimumSize = New System.Drawing.Size(17, 17)
        Me.tkPreview.Name = "tkPreview"
        Me.tkPreview.OnCheck.BorderColor = System.Drawing.Color.DodgerBlue
        Me.tkPreview.OnCheck.BorderRadius = 12
        Me.tkPreview.OnCheck.BorderThickness = 2
        Me.tkPreview.OnCheck.CheckBoxColor = System.Drawing.Color.DodgerBlue
        Me.tkPreview.OnCheck.CheckmarkColor = System.Drawing.Color.White
        Me.tkPreview.OnCheck.CheckmarkThickness = 2
        Me.tkPreview.OnDisable.BorderColor = System.Drawing.Color.LightGray
        Me.tkPreview.OnDisable.BorderRadius = 12
        Me.tkPreview.OnDisable.BorderThickness = 2
        Me.tkPreview.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent
        Me.tkPreview.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray
        Me.tkPreview.OnDisable.CheckmarkThickness = 2
        Me.tkPreview.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tkPreview.OnHoverChecked.BorderRadius = 12
        Me.tkPreview.OnHoverChecked.BorderThickness = 2
        Me.tkPreview.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tkPreview.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White
        Me.tkPreview.OnHoverChecked.CheckmarkThickness = 2
        Me.tkPreview.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tkPreview.OnHoverUnchecked.BorderRadius = 12
        Me.tkPreview.OnHoverUnchecked.BorderThickness = 1
        Me.tkPreview.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent
        Me.tkPreview.OnUncheck.BorderColor = System.Drawing.Color.DarkGray
        Me.tkPreview.OnUncheck.BorderRadius = 12
        Me.tkPreview.OnUncheck.BorderThickness = 1
        Me.tkPreview.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent
        Me.tkPreview.Size = New System.Drawing.Size(17, 17)
        Me.tkPreview.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu
        Me.tkPreview.TabIndex = 150
        Me.tkPreview.ThreeState = False
        Me.tkPreview.ToolTipText = Nothing
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
        Me.ckprint.Location = New System.Drawing.Point(355, 124)
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
        Me.ckprint.TabIndex = 150
        Me.ckprint.ThreeState = False
        Me.ckprint.ToolTipText = Nothing
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.BackColor = System.Drawing.Color.Plum
        Me.GroupBox4.Controls.Add(Me.BunifuThinButton26)
        Me.GroupBox4.Controls.Add(Me.txtReprint)
        Me.GroupBox4.Location = New System.Drawing.Point(8, 636)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(463, 49)
        Me.GroupBox4.TabIndex = 158
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Reprint"
        '
        'BunifuThinButton26
        '
        Me.BunifuThinButton26.ActiveBorderThickness = 1
        Me.BunifuThinButton26.ActiveCornerRadius = 20
        Me.BunifuThinButton26.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton26.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton26.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton26.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BunifuThinButton26.BackColor = System.Drawing.Color.Plum
        Me.BunifuThinButton26.BackgroundImage = CType(resources.GetObject("BunifuThinButton26.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton26.ButtonText = "Reprint"
        Me.BunifuThinButton26.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton26.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton26.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton26.IdleBorderThickness = 1
        Me.BunifuThinButton26.IdleCornerRadius = 20
        Me.BunifuThinButton26.IdleFillColor = System.Drawing.Color.White
        Me.BunifuThinButton26.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton26.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton26.Location = New System.Drawing.Point(244, 11)
        Me.BunifuThinButton26.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton26.Name = "BunifuThinButton26"
        Me.BunifuThinButton26.Size = New System.Drawing.Size(89, 33)
        Me.BunifuThinButton26.TabIndex = 149
        Me.BunifuThinButton26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtReprint
        '
        Me.txtReprint.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtReprint.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.txtReprint.Location = New System.Drawing.Point(49, 16)
        Me.txtReprint.Name = "txtReprint"
        Me.txtReprint.Size = New System.Drawing.Size(190, 27)
        Me.txtReprint.TabIndex = 149
        '
        'Label20
        '
        Me.Label20.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label20.Location = New System.Drawing.Point(186, 587)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(81, 17)
        Me.Label20.TabIndex = 213
        Me.Label20.Text = "PackVolume"
        '
        'Label19
        '
        Me.Label19.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label19.Location = New System.Drawing.Point(100, 587)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(58, 17)
        Me.Label19.TabIndex = 212
        Me.Label19.Text = "BaseQty"
        '
        'Label18
        '
        Me.Label18.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label18.Location = New System.Drawing.Point(18, 588)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(58, 17)
        Me.Label18.TabIndex = 211
        Me.Label18.Text = "Packsize"
        '
        'txtPackVolume
        '
        Me.txtPackVolume.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtPackVolume.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPackVolume.Location = New System.Drawing.Point(189, 609)
        Me.txtPackVolume.Name = "txtPackVolume"
        Me.txtPackVolume.ReadOnly = True
        Me.txtPackVolume.Size = New System.Drawing.Size(76, 23)
        Me.txtPackVolume.TabIndex = 210
        '
        'txtbaseQty
        '
        Me.txtbaseQty.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtbaseQty.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbaseQty.Location = New System.Drawing.Point(103, 607)
        Me.txtbaseQty.Name = "txtbaseQty"
        Me.txtbaseQty.ReadOnly = True
        Me.txtbaseQty.Size = New System.Drawing.Size(76, 23)
        Me.txtbaseQty.TabIndex = 209
        '
        'txtPackSize
        '
        Me.txtPackSize.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtPackSize.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPackSize.Location = New System.Drawing.Point(21, 607)
        Me.txtPackSize.Name = "txtPackSize"
        Me.txtPackSize.ReadOnly = True
        Me.txtPackSize.Size = New System.Drawing.Size(76, 23)
        Me.txtPackSize.TabIndex = 208
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(28, 374)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(213, 203)
        Me.DataGridView1.TabIndex = 214
        Me.DataGridView1.Visible = False
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(252, 351)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(326, 191)
        Me.DataGridView2.TabIndex = 215
        Me.DataGridView2.Visible = False
        '
        'frmRecieveGoods
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1088, 689)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.txtPackVolume)
        Me.Controls.Add(Me.txtbaseQty)
        Me.Controls.Add(Me.txtPackSize)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.gvStockBf)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.gvStockBatch)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmRecieveGoods"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.gvStockBatch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.gvStockBf, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbSearchItem As ComboBox
    Friend WithEvents txtQtyRecieved As TextBox
    Friend WithEvents txtItemPrice As TextBox
    Friend WithEvents txtItemAmount As TextBox
    Friend WithEvents gvStockBatch As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtinvoiceno As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents lblProdcode As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtNarration As RichTextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtActualStock As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtCat As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents gvStockBf As Bunifu.UI.WinForms.BunifuDataGridView
    Friend WithEvents BunifuThinButton21 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents tsuser As Label
    Friend WithEvents tstime As Label
    Friend WithEvents BunifuThinButton22 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents lblTotal As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents BunifuThinButton23 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents txtItemName As Label
    Friend WithEvents cbSuppName As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents lblOldBal As Label
    Friend WithEvents lblCustNo As Label
    Friend WithEvents lblNewBal As Label
    Friend WithEvents BunifuThinButton24 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents cbCatSort As ComboBox
    Friend WithEvents BunifuThinButton25 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents cbProdlineSort As ComboBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents lbldate As Label
    Friend WithEvents lbltime As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents BunifuThinButton26 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents txtReprint As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents ckprint As Bunifu.UI.WinForms.BunifuCheckBox
    Friend WithEvents txtdate As Bunifu.UI.WinForms.BunifuDatePicker
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents txtPackVolume As TextBox
    Friend WithEvents txtbaseQty As TextBox
    Friend WithEvents txtPackSize As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents tkPreview As Bunifu.UI.WinForms.BunifuCheckBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents lbloderid As Label
    Friend WithEvents clItemName As DataGridViewTextBoxColumn
    Friend WithEvents clOldStock As DataGridViewTextBoxColumn
    Friend WithEvents clPrice As DataGridViewTextBoxColumn
    Friend WithEvents clQtyRecieved As DataGridViewTextBoxColumn
    Friend WithEvents clNewStock As DataGridViewTextBoxColumn
    Friend WithEvents clAmount As DataGridViewTextBoxColumn
    Friend WithEvents ProdCode As DataGridViewTextBoxColumn
    Friend WithEvents ItemCat As DataGridViewTextBoxColumn
    Friend WithEvents PackVolume As DataGridViewTextBoxColumn
    Friend WithEvents OderQty As DataGridViewTextBoxColumn
    Friend WithEvents Label17 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridView2 As DataGridView
End Class
