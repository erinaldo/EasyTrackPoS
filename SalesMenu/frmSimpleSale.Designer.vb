<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmsimplesale
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmsimplesale))
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.gbsell = New System.Windows.Forms.GroupBox()
        Me.lbldiscCode = New System.Windows.Forms.Label()
        Me.BunifuThinButton21 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCashPaid = New System.Windows.Forms.TextBox()
        Me.lblChange = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblProformaInvoice = New System.Windows.Forms.Label()
        Me.lblPackageid = New System.Windows.Forms.Label()
        Me.BunifuThinButton27 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblRecieptNo = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.txtProdcode = New System.Windows.Forms.TextBox()
        Me.cbProdName = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblProdName = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.gvSales = New Bunifu.UI.WinForms.BunifuDataGridView()
        Me.ProdName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Category = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Size = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdLine = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NewStock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RecieptNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Discount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiscAmt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AmtPayable = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiscSyb = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Colour = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OldQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BunifuThinButton22 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtAmt = New System.Windows.Forms.TextBox()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.lblDate = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblTime = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Activeuser = New System.Windows.Forms.ToolStripStatusLabel()
        Me.txtProdname = New System.Windows.Forms.ComboBox()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.txtCat = New System.Windows.Forms.TextBox()
        Me.txtColour = New System.Windows.Forms.TextBox()
        Me.txtProdline = New System.Windows.Forms.TextBox()
        Me.txtSize = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblOPrice = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.gvStock = New Bunifu.UI.WinForms.BunifuDataGridView()
        Me.DsStockMastBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsStockMast = New HardSoft_PoS.dsStockMast()
        Me.StockMastTableAdapter = New HardSoft_PoS.dsStockMastTableAdapters.StockMastTableAdapter()
        Me.StockMastBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.gbsell.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.gvSales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.gvStock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsStockMastBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsStockMast, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StockMastBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbsell
        '
        Me.gbsell.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbsell.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.gbsell.Controls.Add(Me.lbldiscCode)
        Me.gbsell.Controls.Add(Me.BunifuThinButton21)
        Me.gbsell.Controls.Add(Me.lblTotal)
        Me.gbsell.Controls.Add(Me.Label3)
        Me.gbsell.Controls.Add(Me.Label5)
        Me.gbsell.Controls.Add(Me.txtCashPaid)
        Me.gbsell.Controls.Add(Me.lblChange)
        Me.gbsell.Controls.Add(Me.Label2)
        Me.gbsell.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbsell.Location = New System.Drawing.Point(916, 126)
        Me.gbsell.Name = "gbsell"
        Me.gbsell.Size = New System.Drawing.Size(324, 599)
        Me.gbsell.TabIndex = 143
        Me.gbsell.TabStop = False
        Me.gbsell.Text = "Sell"
        '
        'lbldiscCode
        '
        Me.lbldiscCode.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbldiscCode.AutoSize = True
        Me.lbldiscCode.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldiscCode.Location = New System.Drawing.Point(308, 140)
        Me.lbldiscCode.Name = "lbldiscCode"
        Me.lbldiscCode.Size = New System.Drawing.Size(0, 15)
        Me.lbldiscCode.TabIndex = 137
        Me.lbldiscCode.Visible = False
        '
        'BunifuThinButton21
        '
        Me.BunifuThinButton21.ActiveBorderThickness = 1
        Me.BunifuThinButton21.ActiveCornerRadius = 20
        Me.BunifuThinButton21.ActiveFillColor = System.Drawing.Color.Firebrick
        Me.BunifuThinButton21.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton21.ActiveLineColor = System.Drawing.Color.Firebrick
        Me.BunifuThinButton21.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuThinButton21.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.BunifuThinButton21.BackgroundImage = CType(resources.GetObject("BunifuThinButton21.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton21.ButtonText = "SELL"
        Me.BunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton21.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton21.ForeColor = System.Drawing.SystemColors.WindowText
        Me.BunifuThinButton21.IdleBorderThickness = 1
        Me.BunifuThinButton21.IdleCornerRadius = 20
        Me.BunifuThinButton21.IdleFillColor = System.Drawing.Color.White
        Me.BunifuThinButton21.IdleForecolor = System.Drawing.Color.DarkRed
        Me.BunifuThinButton21.IdleLineColor = System.Drawing.Color.Maroon
        Me.BunifuThinButton21.Location = New System.Drawing.Point(8, 504)
        Me.BunifuThinButton21.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton21.Name = "BunifuThinButton21"
        Me.BunifuThinButton21.Size = New System.Drawing.Size(293, 68)
        Me.BunifuThinButton21.TabIndex = 124
        Me.BunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotal
        '
        Me.lblTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(64, 108)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(56, 65)
        Me.lblTotal.TabIndex = 1
        Me.lblTotal.Text = "0"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 183)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 21)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Cash Paid"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(82, 323)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 21)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Change>>"
        '
        'txtCashPaid
        '
        Me.txtCashPaid.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCashPaid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCashPaid.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCashPaid.Location = New System.Drawing.Point(8, 207)
        Me.txtCashPaid.Name = "txtCashPaid"
        Me.txtCashPaid.Size = New System.Drawing.Size(316, 50)
        Me.txtCashPaid.TabIndex = 1
        '
        'lblChange
        '
        Me.lblChange.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblChange.AutoSize = True
        Me.lblChange.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChange.Location = New System.Drawing.Point(202, 316)
        Me.lblChange.Name = "lblChange"
        Me.lblChange.Size = New System.Drawing.Size(34, 40)
        Me.lblChange.TabIndex = 7
        Me.lblChange.Text = "0"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(4, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 21)
        Me.Label2.TabIndex = 104
        Me.Label2.Text = "Total:"
        '
        'lblProformaInvoice
        '
        Me.lblProformaInvoice.AutoSize = True
        Me.lblProformaInvoice.Location = New System.Drawing.Point(865, 13)
        Me.lblProformaInvoice.Name = "lblProformaInvoice"
        Me.lblProformaInvoice.Size = New System.Drawing.Size(32, 13)
        Me.lblProformaInvoice.TabIndex = 126
        Me.lblProformaInvoice.Text = "100#"
        Me.lblProformaInvoice.Visible = False
        '
        'lblPackageid
        '
        Me.lblPackageid.AutoSize = True
        Me.lblPackageid.Location = New System.Drawing.Point(775, 15)
        Me.lblPackageid.Name = "lblPackageid"
        Me.lblPackageid.Size = New System.Drawing.Size(32, 13)
        Me.lblPackageid.TabIndex = 136
        Me.lblPackageid.Text = "100#"
        Me.lblPackageid.Visible = False
        '
        'BunifuThinButton27
        '
        Me.BunifuThinButton27.ActiveBorderThickness = 1
        Me.BunifuThinButton27.ActiveCornerRadius = 20
        Me.BunifuThinButton27.ActiveFillColor = System.Drawing.Color.SteelBlue
        Me.BunifuThinButton27.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton27.ActiveLineColor = System.Drawing.Color.SteelBlue
        Me.BunifuThinButton27.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuThinButton27.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.BunifuThinButton27.BackgroundImage = CType(resources.GetObject("BunifuThinButton27.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton27.ButtonText = "Refresh"
        Me.BunifuThinButton27.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton27.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton27.ForeColor = System.Drawing.SystemColors.WindowText
        Me.BunifuThinButton27.IdleBorderThickness = 1
        Me.BunifuThinButton27.IdleCornerRadius = 20
        Me.BunifuThinButton27.IdleFillColor = System.Drawing.Color.White
        Me.BunifuThinButton27.IdleForecolor = System.Drawing.Color.SteelBlue
        Me.BunifuThinButton27.IdleLineColor = System.Drawing.Color.SteelBlue
        Me.BunifuThinButton27.Location = New System.Drawing.Point(926, 11)
        Me.BunifuThinButton27.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton27.Name = "BunifuThinButton27"
        Me.BunifuThinButton27.Size = New System.Drawing.Size(172, 48)
        Me.BunifuThinButton27.TabIndex = 135
        Me.BunifuThinButton27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox5
        '
        Me.PictureBox5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(1116, 7)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(30, 39)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 129
        Me.PictureBox5.TabStop = False
        Me.PictureBox5.Visible = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(1191, 4)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(33, 39)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 128
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(1191, 2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(37, 44)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 127
        Me.PictureBox3.TabStop = False
        Me.PictureBox3.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblPackageid)
        Me.Panel1.Controls.Add(Me.BunifuThinButton27)
        Me.Panel1.Controls.Add(Me.PictureBox5)
        Me.Panel1.Controls.Add(Me.PictureBox4)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.lblProformaInvoice)
        Me.Panel1.Controls.Add(Me.lblRecieptNo)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.txtProdcode)
        Me.Panel1.Controls.Add(Me.cbProdName)
        Me.Panel1.Location = New System.Drawing.Point(0, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1269, 69)
        Me.Panel1.TabIndex = 144
        '
        'lblRecieptNo
        '
        Me.lblRecieptNo.AutoSize = True
        Me.lblRecieptNo.Location = New System.Drawing.Point(815, 27)
        Me.lblRecieptNo.Name = "lblRecieptNo"
        Me.lblRecieptNo.Size = New System.Drawing.Size(32, 13)
        Me.lblRecieptNo.TabIndex = 126
        Me.lblRecieptNo.Text = "100#"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(116, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(167, 40)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sales Entry"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(22, 9)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(41, 42)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 100
        Me.PictureBox2.TabStop = False
        '
        'txtProdcode
        '
        Me.txtProdcode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtProdcode.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold)
        Me.txtProdcode.Location = New System.Drawing.Point(491, 3)
        Me.txtProdcode.Name = "txtProdcode"
        Me.txtProdcode.ReadOnly = True
        Me.txtProdcode.Size = New System.Drawing.Size(148, 43)
        Me.txtProdcode.TabIndex = 102
        Me.txtProdcode.Visible = False
        '
        'cbProdName
        '
        Me.cbProdName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbProdName.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold)
        Me.cbProdName.FormattingEnabled = True
        Me.cbProdName.Location = New System.Drawing.Point(649, 3)
        Me.cbProdName.Name = "cbProdName"
        Me.cbProdName.Size = New System.Drawing.Size(106, 40)
        Me.cbProdName.TabIndex = 14
        Me.cbProdName.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label10.Location = New System.Drawing.Point(-3, 78)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(71, 25)
        Me.Label10.TabIndex = 133
        Me.Label10.Text = "Search"
        '
        'Label6
        '
        Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(3, 107)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 20)
        Me.Label6.TabIndex = 105
        Me.Label6.Text = "Item Name:"
        '
        'lblProdName
        '
        Me.lblProdName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblProdName.AutoSize = True
        Me.lblProdName.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Bold)
        Me.lblProdName.ForeColor = System.Drawing.Color.White
        Me.lblProdName.Location = New System.Drawing.Point(3, 133)
        Me.lblProdName.Name = "lblProdName"
        Me.lblProdName.Size = New System.Drawing.Size(194, 47)
        Me.lblProdName.TabIndex = 101
        Me.lblProdName.Text = "ItemName"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label17.Location = New System.Drawing.Point(1156, -60)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(68, 32)
        Me.Label17.TabIndex = 134
        Me.Label17.Text = "Date"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.gvSales)
        Me.GroupBox1.Controls.Add(Me.BunifuThinButton22)
        Me.GroupBox1.Controls.Add(Me.lblProdName)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.txtPrice)
        Me.GroupBox1.Controls.Add(Me.txtAmt)
        Me.GroupBox1.Controls.Add(Me.txtQty)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(327, 127)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(581, 636)
        Me.GroupBox1.TabIndex = 141
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cart"
        '
        'gvSales
        '
        Me.gvSales.AllowCustomTheming = True
        Me.gvSales.AllowUserToAddRows = False
        Me.gvSales.AllowUserToResizeRows = False
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        Me.gvSales.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.gvSales.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gvSales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.gvSales.BackgroundColor = System.Drawing.Color.White
        Me.gvSales.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.gvSales.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.gvSales.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(204, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gvSales.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.gvSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gvSales.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProdName, Me.Quantity, Me.Price, Me.Amount, Me.Category, Me.ProdCode, Me.Size, Me.ProdLine, Me.NewStock, Me.RecieptNumber, Me.Discount, Me.DiscAmt, Me.AmtPayable, Me.DiscSyb, Me.Colour, Me.OldQty})
        Me.gvSales.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvSales.CurrentTheme.AlternatingRowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.gvSales.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black
        Me.gvSales.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvSales.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.gvSales.CurrentTheme.BackColor = System.Drawing.Color.White
        Me.gvSales.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvSales.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue
        Me.gvSales.CurrentTheme.HeaderStyle.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvSales.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.gvSales.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.gvSales.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White
        Me.gvSales.CurrentTheme.Name = Nothing
        Me.gvSales.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White
        Me.gvSales.CurrentTheme.RowsStyle.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvSales.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.gvSales.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvSales.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.gvSales.DefaultCellStyle = DataGridViewCellStyle9
        Me.gvSales.EnableHeadersVisualStyles = False
        Me.gvSales.GridColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvSales.HeaderBackColor = System.Drawing.Color.DodgerBlue
        Me.gvSales.HeaderBgColor = System.Drawing.Color.Empty
        Me.gvSales.HeaderForeColor = System.Drawing.Color.White
        Me.gvSales.Location = New System.Drawing.Point(6, 182)
        Me.gvSales.Name = "gvSales"
        Me.gvSales.ReadOnly = True
        Me.gvSales.RowHeadersVisible = False
        Me.gvSales.RowTemplate.Height = 40
        Me.gvSales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gvSales.Size = New System.Drawing.Size(569, 427)
        Me.gvSales.TabIndex = 133
        Me.gvSales.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light
        '
        'ProdName
        '
        Me.ProdName.HeaderText = "ProdName"
        Me.ProdName.Name = "ProdName"
        Me.ProdName.ReadOnly = True
        Me.ProdName.Width = 99
        '
        'Quantity
        '
        Me.Quantity.HeaderText = "Qty"
        Me.Quantity.Name = "Quantity"
        Me.Quantity.ReadOnly = True
        Me.Quantity.Width = 54
        '
        'Price
        '
        Me.Price.HeaderText = "Price"
        Me.Price.Name = "Price"
        Me.Price.ReadOnly = True
        Me.Price.Width = 63
        '
        'Amount
        '
        Me.Amount.HeaderText = "Amount"
        Me.Amount.Name = "Amount"
        Me.Amount.ReadOnly = True
        Me.Amount.Width = 81
        '
        'Category
        '
        Me.Category.HeaderText = "Category"
        Me.Category.Name = "Category"
        Me.Category.ReadOnly = True
        Me.Category.Width = 92
        '
        'ProdCode
        '
        Me.ProdCode.HeaderText = "ProdCode"
        Me.ProdCode.Name = "ProdCode"
        Me.ProdCode.ReadOnly = True
        Me.ProdCode.Width = 95
        '
        'Size
        '
        Me.Size.HeaderText = "Size"
        Me.Size.Name = "Size"
        Me.Size.ReadOnly = True
        Me.Size.Width = 56
        '
        'ProdLine
        '
        Me.ProdLine.HeaderText = "ProdLine"
        Me.ProdLine.Name = "ProdLine"
        Me.ProdLine.ReadOnly = True
        Me.ProdLine.Width = 86
        '
        'NewStock
        '
        Me.NewStock.HeaderText = "NewStock"
        Me.NewStock.Name = "NewStock"
        Me.NewStock.ReadOnly = True
        Me.NewStock.Width = 94
        '
        'RecieptNumber
        '
        Me.RecieptNumber.HeaderText = "RecieptNo"
        Me.RecieptNumber.Name = "RecieptNumber"
        Me.RecieptNumber.ReadOnly = True
        Me.RecieptNumber.Width = 98
        '
        'Discount
        '
        Me.Discount.HeaderText = "Discount"
        Me.Discount.Name = "Discount"
        Me.Discount.ReadOnly = True
        Me.Discount.Width = 86
        '
        'DiscAmt
        '
        Me.DiscAmt.HeaderText = "DiscountAmt"
        Me.DiscAmt.Name = "DiscAmt"
        Me.DiscAmt.ReadOnly = True
        Me.DiscAmt.Width = 112
        '
        'AmtPayable
        '
        Me.AmtPayable.HeaderText = "AmtPayable"
        Me.AmtPayable.Name = "AmtPayable"
        Me.AmtPayable.ReadOnly = True
        Me.AmtPayable.Width = 111
        '
        'DiscSyb
        '
        Me.DiscSyb.HeaderText = "DiscSyb"
        Me.DiscSyb.Name = "DiscSyb"
        Me.DiscSyb.ReadOnly = True
        Me.DiscSyb.Width = 82
        '
        'Colour
        '
        Me.Colour.HeaderText = "Colour"
        Me.Colour.Name = "Colour"
        Me.Colour.ReadOnly = True
        Me.Colour.Width = 74
        '
        'OldQty
        '
        Me.OldQty.HeaderText = "oldQty"
        Me.OldQty.Name = "OldQty"
        Me.OldQty.ReadOnly = True
        Me.OldQty.Width = 75
        '
        'BunifuThinButton22
        '
        Me.BunifuThinButton22.ActiveBorderThickness = 1
        Me.BunifuThinButton22.ActiveCornerRadius = 20
        Me.BunifuThinButton22.ActiveFillColor = System.Drawing.Color.Firebrick
        Me.BunifuThinButton22.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton22.ActiveLineColor = System.Drawing.Color.Firebrick
        Me.BunifuThinButton22.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.BunifuThinButton22.BackgroundImage = CType(resources.GetObject("BunifuThinButton22.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton22.ButtonText = "Clear Cart"
        Me.BunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton22.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton22.ForeColor = System.Drawing.SystemColors.WindowText
        Me.BunifuThinButton22.IdleBorderThickness = 1
        Me.BunifuThinButton22.IdleCornerRadius = 20
        Me.BunifuThinButton22.IdleFillColor = System.Drawing.Color.White
        Me.BunifuThinButton22.IdleForecolor = System.Drawing.Color.DarkRed
        Me.BunifuThinButton22.IdleLineColor = System.Drawing.Color.Maroon
        Me.BunifuThinButton22.Location = New System.Drawing.Point(451, 13)
        Me.BunifuThinButton22.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton22.Name = "BunifuThinButton22"
        Me.BunifuThinButton22.Size = New System.Drawing.Size(108, 46)
        Me.BunifuThinButton22.TabIndex = 130
        Me.BunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(18, 36)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 20)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Qty"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(156, 37)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 20)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Price"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(278, 37)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 20)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Amount"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(392, 62)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(60, 37)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'txtPrice
        '
        Me.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPrice.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold)
        Me.txtPrice.Location = New System.Drawing.Point(153, 60)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.ReadOnly = True
        Me.txtPrice.Size = New System.Drawing.Size(104, 43)
        Me.txtPrice.TabIndex = 12
        '
        'txtAmt
        '
        Me.txtAmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAmt.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold)
        Me.txtAmt.Location = New System.Drawing.Point(275, 60)
        Me.txtAmt.Name = "txtAmt"
        Me.txtAmt.ReadOnly = True
        Me.txtAmt.Size = New System.Drawing.Size(103, 43)
        Me.txtAmt.TabIndex = 12
        '
        'txtQty
        '
        Me.txtQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtQty.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold)
        Me.txtQty.Location = New System.Drawing.Point(15, 60)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(97, 43)
        Me.txtQty.TabIndex = 2
        '
        'lblDate
        '
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(30, 17)
        Me.lblDate.Text = "date"
        '
        'lblTime
        '
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(33, 17)
        Me.lblTime.Text = "Time"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.BackColor = System.Drawing.Color.LightGray
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Segoe UI", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(81, 17)
        Me.ToolStripStatusLabel1.Text = " Active User"
        '
        'Activeuser
        '
        Me.Activeuser.Name = "Activeuser"
        Me.Activeuser.Size = New System.Drawing.Size(119, 17)
        Me.Activeuser.Text = "ToolStripStatusLabel3"
        '
        'txtProdname
        '
        Me.txtProdname.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtProdname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtProdname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtProdname.DataSource = Me.StockMastBindingSource
        Me.txtProdname.DisplayMember = "ProdCode"
        Me.txtProdname.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold)
        Me.txtProdname.FormattingEnabled = True
        Me.txtProdname.Location = New System.Drawing.Point(74, 78)
        Me.txtProdname.Name = "txtProdname"
        Me.txtProdname.Size = New System.Drawing.Size(749, 40)
        Me.txtProdname.TabIndex = 132
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(36, 17)
        Me.ToolStripStatusLabel4.Text = "Time:"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel2, Me.lblDate, Me.ToolStripStatusLabel4, Me.lblTime, Me.ToolStripStatusLabel1, Me.Activeuser})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 766)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1243, 22)
        Me.StatusStrip1.TabIndex = 139
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(34, 17)
        Me.ToolStripStatusLabel2.Text = "Date:"
        '
        'txtCat
        '
        Me.txtCat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCat.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtCat.Location = New System.Drawing.Point(79, 163)
        Me.txtCat.Name = "txtCat"
        Me.txtCat.ReadOnly = True
        Me.txtCat.Size = New System.Drawing.Size(80, 23)
        Me.txtCat.TabIndex = 135
        '
        'txtColour
        '
        Me.txtColour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtColour.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtColour.Location = New System.Drawing.Point(216, 163)
        Me.txtColour.Name = "txtColour"
        Me.txtColour.ReadOnly = True
        Me.txtColour.Size = New System.Drawing.Size(67, 23)
        Me.txtColour.TabIndex = 138
        '
        'txtProdline
        '
        Me.txtProdline.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProdline.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtProdline.Location = New System.Drawing.Point(4, 163)
        Me.txtProdline.Name = "txtProdline"
        Me.txtProdline.ReadOnly = True
        Me.txtProdline.Size = New System.Drawing.Size(69, 23)
        Me.txtProdline.TabIndex = 137
        '
        'txtSize
        '
        Me.txtSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSize.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtSize.Location = New System.Drawing.Point(164, 163)
        Me.txtSize.Name = "txtSize"
        Me.txtSize.ReadOnly = True
        Me.txtSize.Size = New System.Drawing.Size(47, 23)
        Me.txtSize.TabIndex = 136
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label24.Location = New System.Drawing.Point(227, 1)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(42, 13)
        Me.Label24.TabIndex = 113
        Me.Label24.Text = "Colour"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label23.Location = New System.Drawing.Point(175, 1)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(27, 13)
        Me.Label23.TabIndex = 113
        Me.Label23.Text = "Size"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label19.Location = New System.Drawing.Point(90, 1)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(54, 13)
        Me.Label19.TabIndex = 113
        Me.Label19.Text = "Category"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label16.Location = New System.Drawing.Point(15, 30)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(54, 13)
        Me.Label16.TabIndex = 113
        Me.Label16.Text = "ProdLine"
        '
        'lblOPrice
        '
        Me.lblOPrice.AutoSize = True
        Me.lblOPrice.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblOPrice.Location = New System.Drawing.Point(231, 47)
        Me.lblOPrice.Name = "lblOPrice"
        Me.lblOPrice.Size = New System.Drawing.Size(42, 13)
        Me.lblOPrice.TabIndex = 128
        Me.lblOPrice.Text = "Colour"
        Me.lblOPrice.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.BackColor = System.Drawing.Color.NavajoWhite
        Me.GroupBox2.Controls.Add(Me.gvStock)
        Me.GroupBox2.Controls.Add(Me.lblOPrice)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.Label23)
        Me.GroupBox2.Controls.Add(Me.Label24)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(4, 133)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(317, 592)
        Me.GroupBox2.TabIndex = 142
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Items"
        '
        'gvStock
        '
        Me.gvStock.AllowCustomTheming = True
        Me.gvStock.AllowUserToAddRows = False
        Me.gvStock.AllowUserToDeleteRows = False
        Me.gvStock.AllowUserToResizeRows = False
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black
        Me.gvStock.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle10
        Me.gvStock.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gvStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.gvStock.BackgroundColor = System.Drawing.Color.White
        Me.gvStock.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.gvStock.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.gvStock.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(204, Byte), Integer))
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gvStock.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.gvStock.ColumnHeadersHeight = 20
        Me.gvStock.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvStock.CurrentTheme.AlternatingRowsStyle.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvStock.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black
        Me.gvStock.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvStock.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.gvStock.CurrentTheme.BackColor = System.Drawing.Color.White
        Me.gvStock.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvStock.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue
        Me.gvStock.CurrentTheme.HeaderStyle.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvStock.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.gvStock.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.gvStock.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White
        Me.gvStock.CurrentTheme.Name = Nothing
        Me.gvStock.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White
        Me.gvStock.CurrentTheme.RowsStyle.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvStock.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.gvStock.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvStock.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.gvStock.DefaultCellStyle = DataGridViewCellStyle12
        Me.gvStock.EnableHeadersVisualStyles = False
        Me.gvStock.GridColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvStock.HeaderBackColor = System.Drawing.Color.DodgerBlue
        Me.gvStock.HeaderBgColor = System.Drawing.Color.Empty
        Me.gvStock.HeaderForeColor = System.Drawing.Color.White
        Me.gvStock.Location = New System.Drawing.Point(-3, 82)
        Me.gvStock.MultiSelect = False
        Me.gvStock.Name = "gvStock"
        Me.gvStock.ReadOnly = True
        Me.gvStock.RowHeadersVisible = False
        Me.gvStock.RowTemplate.Height = 40
        Me.gvStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gvStock.Size = New System.Drawing.Size(314, 428)
        Me.gvStock.TabIndex = 129
        Me.gvStock.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light
        Me.gvStock.VirtualMode = True
        '
        'DsStockMastBindingSource
        '
        Me.DsStockMastBindingSource.DataMember = "StockMast"
        Me.DsStockMastBindingSource.DataSource = Me.DsStockMast
        '
        'DsStockMast
        '
        Me.DsStockMast.DataSetName = "dsStockMast"
        Me.DsStockMast.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StockMastTableAdapter
        '
        Me.StockMastTableAdapter.ClearBeforeFill = True
        '
        'StockMastBindingSource
        '
        Me.StockMastBindingSource.DataMember = "StockMast"
        Me.StockMastBindingSource.DataSource = Me.DsStockMast
        '
        'frmsimplesale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1243, 788)
        Me.Controls.Add(Me.gbsell)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtProdname)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.txtCat)
        Me.Controls.Add(Me.txtColour)
        Me.Controls.Add(Me.txtProdline)
        Me.Controls.Add(Me.txtSize)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmsimplesale"
        Me.Text = "frmSimpleSale"
        Me.gbsell.ResumeLayout(False)
        Me.gbsell.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.gvSales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.gvStock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsStockMastBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsStockMast, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StockMastBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gbsell As GroupBox
    Friend WithEvents lbldiscCode As Label
    Friend WithEvents BunifuThinButton21 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents lblTotal As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCashPaid As TextBox
    Friend WithEvents lblChange As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblProformaInvoice As Label
    Friend WithEvents lblPackageid As Label
    Friend WithEvents BunifuThinButton27 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblRecieptNo As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents txtProdcode As TextBox
    Friend WithEvents cbProdName As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label6 As Label
    Friend WithEvents lblProdName As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BunifuThinButton22 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtAmt As TextBox
    Friend WithEvents txtQty As TextBox
    Friend WithEvents lblDate As ToolStripStatusLabel
    Friend WithEvents lblTime As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents Activeuser As ToolStripStatusLabel
    Friend WithEvents txtProdname As ComboBox
    Friend WithEvents ToolStripStatusLabel4 As ToolStripStatusLabel
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents txtCat As TextBox
    Friend WithEvents txtColour As TextBox
    Friend WithEvents txtProdline As TextBox
    Friend WithEvents txtSize As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents lblOPrice As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents gvSales As Bunifu.UI.WinForms.BunifuDataGridView
    Friend WithEvents ProdName As DataGridViewTextBoxColumn
    Friend WithEvents Quantity As DataGridViewTextBoxColumn
    Friend WithEvents Price As DataGridViewTextBoxColumn
    Friend WithEvents Amount As DataGridViewTextBoxColumn
    Friend WithEvents Category As DataGridViewTextBoxColumn
    Friend WithEvents ProdCode As DataGridViewTextBoxColumn
    Friend WithEvents Size As DataGridViewTextBoxColumn
    Friend WithEvents ProdLine As DataGridViewTextBoxColumn
    Friend WithEvents NewStock As DataGridViewTextBoxColumn
    Friend WithEvents RecieptNumber As DataGridViewTextBoxColumn
    Friend WithEvents Discount As DataGridViewTextBoxColumn
    Friend WithEvents DiscAmt As DataGridViewTextBoxColumn
    Friend WithEvents AmtPayable As DataGridViewTextBoxColumn
    Friend WithEvents DiscSyb As DataGridViewTextBoxColumn
    Friend WithEvents Colour As DataGridViewTextBoxColumn
    Friend WithEvents OldQty As DataGridViewTextBoxColumn
    Friend WithEvents gvStock As Bunifu.UI.WinForms.BunifuDataGridView
    Friend WithEvents DsStockMastBindingSource As BindingSource
    Friend WithEvents DsStockMast As dsStockMast
    Friend WithEvents StockMastTableAdapter As dsStockMastTableAdapters.StockMastTableAdapter
    Friend WithEvents StockMastBindingSource As BindingSource
End Class
