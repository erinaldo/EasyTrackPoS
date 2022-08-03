<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModifyProduct
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmModifyProduct))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtStockCode = New System.Windows.Forms.TextBox()
        Me.cbUnique = New System.Windows.Forms.ComboBox()
        Me.cbColour = New System.Windows.Forms.ComboBox()
        Me.cbSize = New System.Windows.Forms.ComboBox()
        Me.cbCat = New System.Windows.Forms.ComboBox()
        Me.cbProdname = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbProdLine = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BunifuThinButton22 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.gvStock = New Bunifu.UI.WinForms.BunifuDataGridView()
        Me.BunifuThinButton21 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.cbBrandName = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbSearchItem = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtbaseqty = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtpacksize = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtReoder = New System.Windows.Forms.TextBox()
        Me.Panel2.SuspendLayout()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvStock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label17
        '
        Me.Label17.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.SystemColors.Control
        Me.Label17.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(1, 515)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(87, 21)
        Me.Label17.TabIndex = 51
        Me.Label17.Text = "Item Code"
        Me.Label17.Visible = False
        '
        'txtStockCode
        '
        Me.txtStockCode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtStockCode.Font = New System.Drawing.Font("Tahoma", 24.0!)
        Me.txtStockCode.Location = New System.Drawing.Point(12, 539)
        Me.txtStockCode.Name = "txtStockCode"
        Me.txtStockCode.ReadOnly = True
        Me.txtStockCode.Size = New System.Drawing.Size(31, 46)
        Me.txtStockCode.TabIndex = 49
        Me.txtStockCode.Visible = False
        '
        'cbUnique
        '
        Me.cbUnique.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cbUnique.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.cbUnique.FormattingEnabled = True
        Me.cbUnique.Location = New System.Drawing.Point(140, 421)
        Me.cbUnique.Name = "cbUnique"
        Me.cbUnique.Size = New System.Drawing.Size(220, 28)
        Me.cbUnique.TabIndex = 48
        '
        'cbColour
        '
        Me.cbColour.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cbColour.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.cbColour.FormattingEnabled = True
        Me.cbColour.Location = New System.Drawing.Point(140, 378)
        Me.cbColour.Name = "cbColour"
        Me.cbColour.Size = New System.Drawing.Size(220, 28)
        Me.cbColour.TabIndex = 47
        '
        'cbSize
        '
        Me.cbSize.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cbSize.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.cbSize.FormattingEnabled = True
        Me.cbSize.Location = New System.Drawing.Point(140, 344)
        Me.cbSize.Name = "cbSize"
        Me.cbSize.Size = New System.Drawing.Size(220, 28)
        Me.cbSize.TabIndex = 46
        '
        'cbCat
        '
        Me.cbCat.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cbCat.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbCat.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbCat.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.cbCat.FormattingEnabled = True
        Me.cbCat.Location = New System.Drawing.Point(140, 243)
        Me.cbCat.Name = "cbCat"
        Me.cbCat.Size = New System.Drawing.Size(220, 28)
        Me.cbCat.TabIndex = 45
        '
        'cbProdname
        '
        Me.cbProdname.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cbProdname.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.cbProdname.FormattingEnabled = True
        Me.cbProdname.Location = New System.Drawing.Point(140, 196)
        Me.cbProdname.Name = "cbProdname"
        Me.cbProdname.Size = New System.Drawing.Size(220, 28)
        Me.cbProdname.TabIndex = 44
        '
        'Label16
        '
        Me.Label16.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.SystemColors.Control
        Me.Label16.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(42, 380)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(59, 21)
        Me.Label16.TabIndex = 42
        Me.Label16.Text = "Colour"
        '
        'Label10
        '
        Me.Label10.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.Control
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(45, 346)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(37, 21)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "size"
        '
        'Label9
        '
        Me.Label9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.Control
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(14, 196)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(91, 21)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "Item Name"
        '
        'Label8
        '
        Me.Label8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(23, 246)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 21)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "Category"
        '
        'Label7
        '
        Me.Label7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(14, 100)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(102, 21)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Product Line"
        '
        'cbProdLine
        '
        Me.cbProdLine.AllowDrop = True
        Me.cbProdLine.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cbProdLine.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbProdLine.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbProdLine.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.cbProdLine.FormattingEnabled = True
        Me.cbProdLine.Location = New System.Drawing.Point(140, 97)
        Me.cbProdLine.Name = "cbProdLine"
        Me.cbProdLine.Size = New System.Drawing.Size(220, 28)
        Me.cbProdLine.TabIndex = 29
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.MediumPurple
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(78, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(341, 45)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Product Modification"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.MediumPurple
        Me.Panel2.Controls.Add(Me.BunifuThinButton22)
        Me.Panel2.Controls.Add(Me.Guna2PictureBox2)
        Me.Panel2.Controls.Add(Me.Guna2PictureBox1)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Location = New System.Drawing.Point(-1, -3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(941, 59)
        Me.Panel2.TabIndex = 28
        '
        'BunifuThinButton22
        '
        Me.BunifuThinButton22.ActiveBorderThickness = 1
        Me.BunifuThinButton22.ActiveCornerRadius = 20
        Me.BunifuThinButton22.ActiveFillColor = System.Drawing.Color.Teal
        Me.BunifuThinButton22.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton22.ActiveLineColor = System.Drawing.Color.Teal
        Me.BunifuThinButton22.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BunifuThinButton22.BackColor = System.Drawing.Color.MediumPurple
        Me.BunifuThinButton22.BackgroundImage = CType(resources.GetObject("BunifuThinButton22.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton22.ButtonText = "Refresh"
        Me.BunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton22.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton22.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton22.IdleBorderThickness = 1
        Me.BunifuThinButton22.IdleCornerRadius = 20
        Me.BunifuThinButton22.IdleFillColor = System.Drawing.Color.White
        Me.BunifuThinButton22.IdleForecolor = System.Drawing.Color.SkyBlue
        Me.BunifuThinButton22.IdleLineColor = System.Drawing.Color.SkyBlue
        Me.BunifuThinButton22.Location = New System.Drawing.Point(637, 8)
        Me.BunifuThinButton22.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton22.Name = "BunifuThinButton22"
        Me.BunifuThinButton22.Size = New System.Drawing.Size(112, 51)
        Me.BunifuThinButton22.TabIndex = 151
        Me.BunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2PictureBox2
        '
        Me.Guna2PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2PictureBox2.Image = CType(resources.GetObject("Guna2PictureBox2.Image"), System.Drawing.Image)
        Me.Guna2PictureBox2.ImageRotate = 0!
        Me.Guna2PictureBox2.Location = New System.Drawing.Point(863, 5)
        Me.Guna2PictureBox2.Name = "Guna2PictureBox2"
        Me.Guna2PictureBox2.Size = New System.Drawing.Size(40, 27)
        Me.Guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox2.TabIndex = 145
        Me.Guna2PictureBox2.TabStop = False
        Me.Guna2PictureBox2.Visible = False
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2PictureBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(895, 3)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(43, 32)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox1.TabIndex = 144
        Me.Guna2PictureBox1.TabStop = False
        Me.Guna2PictureBox1.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.MediumPurple
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(13, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(41, 42)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 97
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'Label11
        '
        Me.Label11.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.SystemColors.Control
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(23, 421)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(82, 21)
        Me.Label11.TabIndex = 34
        Me.Label11.Text = "Unique ID"
        '
        'gvStock
        '
        Me.gvStock.AllowCustomTheming = True
        Me.gvStock.AllowUserToAddRows = False
        Me.gvStock.AllowUserToDeleteRows = False
        Me.gvStock.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        Me.gvStock.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.gvStock.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gvStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.gvStock.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.gvStock.BackgroundColor = System.Drawing.Color.White
        Me.gvStock.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.gvStock.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.gvStock.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(204, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gvStock.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.gvStock.ColumnHeadersHeight = 25
        Me.gvStock.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvStock.CurrentTheme.AlternatingRowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.gvStock.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black
        Me.gvStock.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvStock.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.gvStock.CurrentTheme.BackColor = System.Drawing.Color.White
        Me.gvStock.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvStock.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue
        Me.gvStock.CurrentTheme.HeaderStyle.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvStock.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.gvStock.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.gvStock.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White
        Me.gvStock.CurrentTheme.Name = Nothing
        Me.gvStock.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White
        Me.gvStock.CurrentTheme.RowsStyle.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvStock.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.gvStock.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvStock.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.gvStock.DefaultCellStyle = DataGridViewCellStyle6
        Me.gvStock.EnableHeadersVisualStyles = False
        Me.gvStock.GridColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvStock.HeaderBackColor = System.Drawing.Color.DodgerBlue
        Me.gvStock.HeaderBgColor = System.Drawing.Color.Empty
        Me.gvStock.HeaderForeColor = System.Drawing.Color.White
        Me.gvStock.Location = New System.Drawing.Point(382, 131)
        Me.gvStock.MultiSelect = False
        Me.gvStock.Name = "gvStock"
        Me.gvStock.ReadOnly = True
        Me.gvStock.RowHeadersVisible = False
        Me.gvStock.RowTemplate.Height = 40
        Me.gvStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gvStock.ShowEditingIcon = False
        Me.gvStock.Size = New System.Drawing.Size(534, 437)
        Me.gvStock.TabIndex = 145
        Me.gvStock.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light
        '
        'BunifuThinButton21
        '
        Me.BunifuThinButton21.ActiveBorderThickness = 1
        Me.BunifuThinButton21.ActiveCornerRadius = 20
        Me.BunifuThinButton21.ActiveFillColor = System.Drawing.Color.Teal
        Me.BunifuThinButton21.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton21.ActiveLineColor = System.Drawing.Color.Teal
        Me.BunifuThinButton21.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BunifuThinButton21.BackColor = System.Drawing.SystemColors.Control
        Me.BunifuThinButton21.BackgroundImage = CType(resources.GetObject("BunifuThinButton21.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton21.ButtonText = "Update"
        Me.BunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton21.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton21.IdleBorderThickness = 1
        Me.BunifuThinButton21.IdleCornerRadius = 20
        Me.BunifuThinButton21.IdleFillColor = System.Drawing.Color.White
        Me.BunifuThinButton21.IdleForecolor = System.Drawing.Color.SkyBlue
        Me.BunifuThinButton21.IdleLineColor = System.Drawing.Color.SkyBlue
        Me.BunifuThinButton21.Location = New System.Drawing.Point(126, 522)
        Me.BunifuThinButton21.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton21.Name = "BunifuThinButton21"
        Me.BunifuThinButton21.Size = New System.Drawing.Size(185, 61)
        Me.BunifuThinButton21.TabIndex = 146
        Me.BunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cbBrandName
        '
        Me.cbBrandName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cbBrandName.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.cbBrandName.FormattingEnabled = True
        Me.cbBrandName.Location = New System.Drawing.Point(140, 151)
        Me.cbBrandName.Name = "cbBrandName"
        Me.cbBrandName.Size = New System.Drawing.Size(220, 28)
        Me.cbBrandName.TabIndex = 148
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(14, 151)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 21)
        Me.Label1.TabIndex = 147
        Me.Label1.Text = "Brand Name"
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(389, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 17)
        Me.Label4.TabIndex = 150
        Me.Label4.Text = "Search Item"
        '
        'cbSearchItem
        '
        Me.cbSearchItem.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbSearchItem.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSearchItem.FormattingEnabled = True
        Me.cbSearchItem.Location = New System.Drawing.Point(382, 95)
        Me.cbSearchItem.Name = "cbSearchItem"
        Me.cbSearchItem.Size = New System.Drawing.Size(527, 30)
        Me.cbSearchItem.TabIndex = 149
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.SystemColors.Control
        Me.Label15.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(209, 298)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(74, 21)
        Me.Label15.TabIndex = 159
        Me.Label15.Text = "Base Qty"
        '
        'txtbaseqty
        '
        Me.txtbaseqty.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbaseqty.Location = New System.Drawing.Point(305, 294)
        Me.txtbaseqty.Name = "txtbaseqty"
        Me.txtbaseqty.Size = New System.Drawing.Size(71, 31)
        Me.txtbaseqty.TabIndex = 158
        Me.txtbaseqty.Text = "1"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(10, 298)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 21)
        Me.Label5.TabIndex = 157
        Me.Label5.Text = "Pack Size"
        '
        'txtpacksize
        '
        Me.txtpacksize.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpacksize.Location = New System.Drawing.Point(110, 294)
        Me.txtpacksize.Name = "txtpacksize"
        Me.txtpacksize.Size = New System.Drawing.Size(74, 31)
        Me.txtpacksize.TabIndex = 156
        Me.txtpacksize.Text = "1"
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(23, 473)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 21)
        Me.Label2.TabIndex = 160
        Me.Label2.Text = "Re-Oder Qty"
        '
        'txtReoder
        '
        Me.txtReoder.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtReoder.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReoder.Location = New System.Drawing.Point(140, 467)
        Me.txtReoder.Name = "txtReoder"
        Me.txtReoder.Size = New System.Drawing.Size(220, 27)
        Me.txtReoder.TabIndex = 161
        '
        'frmModifyProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(938, 597)
        Me.Controls.Add(Me.txtReoder)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtbaseqty)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtpacksize)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbSearchItem)
        Me.Controls.Add(Me.cbBrandName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BunifuThinButton21)
        Me.Controls.Add(Me.gvStock)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txtStockCode)
        Me.Controls.Add(Me.cbUnique)
        Me.Controls.Add(Me.cbColour)
        Me.Controls.Add(Me.cbSize)
        Me.Controls.Add(Me.cbCat)
        Me.Controls.Add(Me.cbProdname)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cbProdLine)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label11)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmModifyProduct"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modify Product"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvStock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label17 As Label
    Friend WithEvents txtStockCode As TextBox
    Friend WithEvents cbUnique As ComboBox
    Friend WithEvents cbColour As ComboBox
    Friend WithEvents cbSize As ComboBox
    Friend WithEvents cbCat As ComboBox
    Friend WithEvents cbProdname As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cbProdLine As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents gvStock As Bunifu.UI.WinForms.BunifuDataGridView
    Friend WithEvents BunifuThinButton21 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents cbBrandName As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cbSearchItem As ComboBox
    Friend WithEvents BunifuThinButton22 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Label15 As Label
    Friend WithEvents txtbaseqty As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtpacksize As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtReoder As TextBox
End Class
