<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSales
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSales))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCashPaid = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblChange = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.txtAmt = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cbProdName = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtBuyerName = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtBuyerTel = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cbLocation = New System.Windows.Forms.ComboBox()
        Me.cbPaymode = New System.Windows.Forms.ComboBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lblProdName = New System.Windows.Forms.Label()
        Me.txtProdcode = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lblActualStock = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtCat = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtSize = New System.Windows.Forms.TextBox()
        Me.txtProdline = New System.Windows.Forms.TextBox()
        Me.txtColour = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.cbSaleType = New System.Windows.Forms.ComboBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.lblCreditCust = New System.Windows.Forms.Label()
        Me.cbCreditCustName = New System.Windows.Forms.ComboBox()
        Me.lblOldBal = New System.Windows.Forms.Label()
        Me.lblNewBal = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.lblCustNo = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblDate = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblTime = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Activeuser = New System.Windows.Forms.ToolStripStatusLabel()
        Me.txtProdname = New System.Windows.Forms.ComboBox()
        Me.lblRecieptNo = New System.Windows.Forms.Label()
        Me.gvStock = New Bunifu.UI.WinForms.BunifuDataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.ckprintpreview = New Bunifu.UI.WinForms.BunifuCheckBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.BunifuThinButton28 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.txtReprintNo = New System.Windows.Forms.TextBox()
        Me.BunifuThinButton25 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuThinButton22 = New Bunifu.Framework.UI.BunifuThinButton2()
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cbSaleslist = New System.Windows.Forms.ComboBox()
        Me.cbProdlineSort = New System.Windows.Forms.ComboBox()
        Me.BunifuThinButton29 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.cbCatSort = New System.Windows.Forms.ComboBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.lblOPrice = New System.Windows.Forms.Label()
        Me.gvPriceBand = New Bunifu.UI.WinForms.BunifuDataGridView()
        Me.gbsell = New System.Windows.Forms.GroupBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.tksendsms = New Bunifu.UI.WinForms.BunifuCheckBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.ckprint = New Bunifu.UI.WinForms.BunifuCheckBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.ckA4 = New Bunifu.UI.WinForms.BunifuCheckBox()
        Me.lblDiscAmt = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.lblPayable = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.lbldiscCode = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtDiscName = New System.Windows.Forms.RichTextBox()
        Me.BunifuThinButton23 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.txtCashDisc = New System.Windows.Forms.TextBox()
        Me.txtPerDisc = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.ckCashDisc = New Bunifu.UI.WinForms.BunifuCheckBox()
        Me.ckPerDisc = New Bunifu.UI.WinForms.BunifuCheckBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.ckA5Paper = New Bunifu.UI.WinForms.BunifuCheckBox()
        Me.ckrollPaper = New Bunifu.UI.WinForms.BunifuCheckBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.BunifuThinButton21 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BunifuThinButton27 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.lblProformaInvoice = New System.Windows.Forms.Label()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.gvStock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.gvSales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.gvPriceBand, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbsell.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(112, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(167, 40)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sales Entry"
        '
        'lblTotal
        '
        Me.lblTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(71, 236)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(25, 30)
        Me.lblTotal.TabIndex = 1
        Me.lblTotal.Text = "0"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(29, 277)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 21)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Cash Paid"
        '
        'txtCashPaid
        '
        Me.txtCashPaid.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCashPaid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCashPaid.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCashPaid.Location = New System.Drawing.Point(30, 301)
        Me.txtCashPaid.Name = "txtCashPaid"
        Me.txtCashPaid.Size = New System.Drawing.Size(150, 31)
        Me.txtCashPaid.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(191, 275)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 21)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Pay Mode"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(59, 354)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 21)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Change>>"
        '
        'lblChange
        '
        Me.lblChange.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblChange.AutoSize = True
        Me.lblChange.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChange.Location = New System.Drawing.Point(179, 347)
        Me.lblChange.Name = "lblChange"
        Me.lblChange.Size = New System.Drawing.Size(34, 40)
        Me.lblChange.TabIndex = 7
        Me.lblChange.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(21, 56)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 20)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Qty"
        '
        'txtQty
        '
        Me.txtQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtQty.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold)
        Me.txtQty.Location = New System.Drawing.Point(18, 80)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(97, 43)
        Me.txtQty.TabIndex = 2
        '
        'txtAmt
        '
        Me.txtAmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAmt.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold)
        Me.txtAmt.Location = New System.Drawing.Point(278, 80)
        Me.txtAmt.Name = "txtAmt"
        Me.txtAmt.ReadOnly = True
        Me.txtAmt.Size = New System.Drawing.Size(103, 43)
        Me.txtAmt.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(281, 57)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 20)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Amount"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(159, 57)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 20)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Price"
        '
        'txtPrice
        '
        Me.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPrice.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold)
        Me.txtPrice.Location = New System.Drawing.Point(156, 80)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.ReadOnly = True
        Me.txtPrice.Size = New System.Drawing.Size(104, 43)
        Me.txtPrice.TabIndex = 12
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(395, 82)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(60, 37)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'cbProdName
        '
        Me.cbProdName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbProdName.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold)
        Me.cbProdName.FormattingEnabled = True
        Me.cbProdName.Location = New System.Drawing.Point(743, 14)
        Me.cbProdName.Name = "cbProdName"
        Me.cbProdName.Size = New System.Drawing.Size(106, 40)
        Me.cbProdName.TabIndex = 14
        Me.cbProdName.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label10.Location = New System.Drawing.Point(13, 73)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(71, 25)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Search"
        '
        'txtBuyerName
        '
        Me.txtBuyerName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBuyerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBuyerName.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuyerName.Location = New System.Drawing.Point(165, 399)
        Me.txtBuyerName.Name = "txtBuyerName"
        Me.txtBuyerName.Size = New System.Drawing.Size(157, 27)
        Me.txtBuyerName.TabIndex = 16
        '
        'Label11
        '
        Me.Label11.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(30, 397)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(104, 21)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "Buyer Name"
        '
        'Label12
        '
        Me.Label12.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(41, 430)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(80, 21)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "Buyer Tel"
        '
        'txtBuyerTel
        '
        Me.txtBuyerTel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBuyerTel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBuyerTel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuyerTel.Location = New System.Drawing.Point(166, 432)
        Me.txtBuyerTel.Name = "txtBuyerTel"
        Me.txtBuyerTel.Size = New System.Drawing.Size(157, 27)
        Me.txtBuyerTel.TabIndex = 18
        '
        'Label13
        '
        Me.Label13.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(41, 464)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(76, 21)
        Me.Label13.TabIndex = 21
        Me.Label13.Text = "Location"
        '
        'cbLocation
        '
        Me.cbLocation.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbLocation.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbLocation.FormattingEnabled = True
        Me.cbLocation.Location = New System.Drawing.Point(166, 465)
        Me.cbLocation.Name = "cbLocation"
        Me.cbLocation.Size = New System.Drawing.Size(158, 29)
        Me.cbLocation.TabIndex = 22
        '
        'cbPaymode
        '
        Me.cbPaymode.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbPaymode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPaymode.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.cbPaymode.FormattingEnabled = True
        Me.cbPaymode.Items.AddRange(New Object() {"Cash", "Mobile Money", "Bank Transfer"})
        Me.cbPaymode.Location = New System.Drawing.Point(200, 299)
        Me.cbPaymode.Name = "cbPaymode"
        Me.cbPaymode.Size = New System.Drawing.Size(113, 33)
        Me.cbPaymode.TabIndex = 24
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(18, 9)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(41, 42)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 100
        Me.PictureBox2.TabStop = False
        '
        'lblProdName
        '
        Me.lblProdName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblProdName.AutoSize = True
        Me.lblProdName.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Bold)
        Me.lblProdName.Location = New System.Drawing.Point(6, 153)
        Me.lblProdName.Name = "lblProdName"
        Me.lblProdName.Size = New System.Drawing.Size(194, 47)
        Me.lblProdName.TabIndex = 101
        Me.lblProdName.Text = "ItemName"
        '
        'txtProdcode
        '
        Me.txtProdcode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtProdcode.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold)
        Me.txtProdcode.Location = New System.Drawing.Point(585, 14)
        Me.txtProdcode.Name = "txtProdcode"
        Me.txtProdcode.ReadOnly = True
        Me.txtProdcode.Size = New System.Drawing.Size(148, 43)
        Me.txtProdcode.TabIndex = 102
        Me.txtProdcode.Visible = False
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 242)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 21)
        Me.Label2.TabIndex = 104
        Me.Label2.Text = "Total:"
        '
        'Label6
        '
        Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(6, 127)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 20)
        Me.Label6.TabIndex = 105
        Me.Label6.Text = "Item Name:"
        '
        'Timer1
        '
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label17.Location = New System.Drawing.Point(1172, -65)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(68, 32)
        Me.Label17.TabIndex = 108
        Me.Label17.Text = "Date"
        '
        'lblActualStock
        '
        Me.lblActualStock.AutoSize = True
        Me.lblActualStock.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Bold)
        Me.lblActualStock.Location = New System.Drawing.Point(101, 55)
        Me.lblActualStock.Name = "lblActualStock"
        Me.lblActualStock.Size = New System.Drawing.Size(34, 40)
        Me.lblActualStock.TabIndex = 111
        Me.lblActualStock.Text = "0"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label18.Location = New System.Drawing.Point(7, 62)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(97, 20)
        Me.Label18.TabIndex = 112
        Me.Label18.Text = "ActualStock:"
        '
        'txtCat
        '
        Me.txtCat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCat.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtCat.Location = New System.Drawing.Point(95, 158)
        Me.txtCat.Name = "txtCat"
        Me.txtCat.ReadOnly = True
        Me.txtCat.Size = New System.Drawing.Size(80, 23)
        Me.txtCat.TabIndex = 114
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label16.Location = New System.Drawing.Point(16, 19)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(54, 13)
        Me.Label16.TabIndex = 113
        Me.Label16.Text = "ProdLine"
        '
        'txtSize
        '
        Me.txtSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSize.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtSize.Location = New System.Drawing.Point(180, 158)
        Me.txtSize.Name = "txtSize"
        Me.txtSize.ReadOnly = True
        Me.txtSize.Size = New System.Drawing.Size(47, 23)
        Me.txtSize.TabIndex = 115
        '
        'txtProdline
        '
        Me.txtProdline.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProdline.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtProdline.Location = New System.Drawing.Point(20, 158)
        Me.txtProdline.Name = "txtProdline"
        Me.txtProdline.ReadOnly = True
        Me.txtProdline.Size = New System.Drawing.Size(69, 23)
        Me.txtProdline.TabIndex = 116
        '
        'txtColour
        '
        Me.txtColour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtColour.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtColour.Location = New System.Drawing.Point(232, 158)
        Me.txtColour.Name = "txtColour"
        Me.txtColour.ReadOnly = True
        Me.txtColour.Size = New System.Drawing.Size(67, 23)
        Me.txtColour.TabIndex = 119
        '
        'Label20
        '
        Me.Label20.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label20.Location = New System.Drawing.Point(133, 81)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(19, 20)
        Me.Label20.TabIndex = 120
        Me.Label20.Text = "R"
        '
        'Label21
        '
        Me.Label21.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label21.Location = New System.Drawing.Point(132, 101)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(24, 20)
        Me.Label21.TabIndex = 121
        Me.Label21.Text = "W"
        '
        'cbSaleType
        '
        Me.cbSaleType.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbSaleType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSaleType.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.cbSaleType.FormattingEnabled = True
        Me.cbSaleType.Items.AddRange(New Object() {"Walk-In Sale", "Credit Sale"})
        Me.cbSaleType.Location = New System.Drawing.Point(156, 22)
        Me.cbSaleType.Name = "cbSaleType"
        Me.cbSaleType.Size = New System.Drawing.Size(148, 33)
        Me.cbSaleType.TabIndex = 123
        '
        'Label22
        '
        Me.Label22.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(47, 29)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(82, 21)
        Me.Label22.TabIndex = 122
        Me.Label22.Text = "Sale Type"
        '
        'lblCreditCust
        '
        Me.lblCreditCust.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCreditCust.AutoSize = True
        Me.lblCreditCust.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCreditCust.Location = New System.Drawing.Point(27, 67)
        Me.lblCreditCust.Name = "lblCreditCust"
        Me.lblCreditCust.Size = New System.Drawing.Size(133, 21)
        Me.lblCreditCust.TabIndex = 122
        Me.lblCreditCust.Text = "Credit Customer"
        '
        'cbCreditCustName
        '
        Me.cbCreditCustName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbCreditCustName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCreditCustName.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.cbCreditCustName.FormattingEnabled = True
        Me.cbCreditCustName.Location = New System.Drawing.Point(156, 61)
        Me.cbCreditCustName.Name = "cbCreditCustName"
        Me.cbCreditCustName.Size = New System.Drawing.Size(148, 33)
        Me.cbCreditCustName.TabIndex = 123
        '
        'lblOldBal
        '
        Me.lblOldBal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblOldBal.AutoSize = True
        Me.lblOldBal.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOldBal.Location = New System.Drawing.Point(84, 4)
        Me.lblOldBal.Name = "lblOldBal"
        Me.lblOldBal.Size = New System.Drawing.Size(50, 15)
        Me.lblOldBal.TabIndex = 104
        Me.lblOldBal.Text = "Balance"
        Me.lblOldBal.Visible = False
        '
        'lblNewBal
        '
        Me.lblNewBal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNewBal.AutoSize = True
        Me.lblNewBal.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewBal.Location = New System.Drawing.Point(243, 4)
        Me.lblNewBal.Name = "lblNewBal"
        Me.lblNewBal.Size = New System.Drawing.Size(50, 15)
        Me.lblNewBal.TabIndex = 104
        Me.lblNewBal.Text = "NewBal"
        Me.lblNewBal.Visible = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label19.Location = New System.Drawing.Point(93, 21)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(54, 13)
        Me.Label19.TabIndex = 113
        Me.Label19.Text = "Category"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label23.Location = New System.Drawing.Point(178, 21)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(27, 13)
        Me.Label23.TabIndex = 113
        Me.Label23.Text = "Size"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label24.Location = New System.Drawing.Point(230, 21)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(42, 13)
        Me.Label24.TabIndex = 113
        Me.Label24.Text = "Colour"
        '
        'lblCustNo
        '
        Me.lblCustNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCustNo.AutoSize = True
        Me.lblCustNo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustNo.Location = New System.Drawing.Point(162, 5)
        Me.lblCustNo.Name = "lblCustNo"
        Me.lblCustNo.Size = New System.Drawing.Size(47, 15)
        Me.lblCustNo.TabIndex = 104
        Me.lblCustNo.Text = "CustNo"
        Me.lblCustNo.Visible = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel2, Me.lblDate, Me.ToolStripStatusLabel4, Me.lblTime, Me.ToolStripStatusLabel1, Me.Activeuser})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 738)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1259, 22)
        Me.StatusStrip1.TabIndex = 124
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(34, 17)
        Me.ToolStripStatusLabel2.Text = "Date:"
        '
        'lblDate
        '
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(30, 17)
        Me.lblDate.Text = "date"
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(36, 17)
        Me.ToolStripStatusLabel4.Text = "Time:"
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
        Me.txtProdname.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold)
        Me.txtProdname.FormattingEnabled = True
        Me.txtProdname.Location = New System.Drawing.Point(90, 73)
        Me.txtProdname.Name = "txtProdname"
        Me.txtProdname.Size = New System.Drawing.Size(749, 40)
        Me.txtProdname.TabIndex = 0
        '
        'lblRecieptNo
        '
        Me.lblRecieptNo.AutoSize = True
        Me.lblRecieptNo.Location = New System.Drawing.Point(909, 38)
        Me.lblRecieptNo.Name = "lblRecieptNo"
        Me.lblRecieptNo.Size = New System.Drawing.Size(32, 13)
        Me.lblRecieptNo.TabIndex = 126
        Me.lblRecieptNo.Text = "100#"
        Me.lblRecieptNo.Visible = False
        '
        'gvStock
        '
        Me.gvStock.AllowCustomTheming = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.gvStock.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.gvStock.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gvStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.gvStock.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.gvStock.BackgroundColor = System.Drawing.Color.White
        Me.gvStock.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.gvStock.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.gvStock.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(204, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gvStock.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
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
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.gvStock.DefaultCellStyle = DataGridViewCellStyle3
        Me.gvStock.EnableHeadersVisualStyles = False
        Me.gvStock.GridColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvStock.HeaderBackColor = System.Drawing.Color.DodgerBlue
        Me.gvStock.HeaderBgColor = System.Drawing.Color.Empty
        Me.gvStock.HeaderForeColor = System.Drawing.Color.White
        Me.gvStock.Location = New System.Drawing.Point(6, 169)
        Me.gvStock.MultiSelect = False
        Me.gvStock.Name = "gvStock"
        Me.gvStock.ReadOnly = True
        Me.gvStock.RowHeadersVisible = False
        Me.gvStock.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.gvStock.RowTemplate.Height = 40
        Me.gvStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gvStock.Size = New System.Drawing.Size(322, 429)
        Me.gvStock.TabIndex = 127
        Me.gvStock.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.Khaki
        Me.GroupBox1.Controls.Add(Me.Label35)
        Me.GroupBox1.Controls.Add(Me.ckprintpreview)
        Me.GroupBox1.Controls.Add(Me.Label31)
        Me.GroupBox1.Controls.Add(Me.BunifuThinButton28)
        Me.GroupBox1.Controls.Add(Me.txtReprintNo)
        Me.GroupBox1.Controls.Add(Me.BunifuThinButton25)
        Me.GroupBox1.Controls.Add(Me.BunifuThinButton22)
        Me.GroupBox1.Controls.Add(Me.gvSales)
        Me.GroupBox1.Controls.Add(Me.lblProdName)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.txtPrice)
        Me.GroupBox1.Controls.Add(Me.txtAmt)
        Me.GroupBox1.Controls.Add(Me.txtQty)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(343, 122)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(581, 606)
        Me.GroupBox1.TabIndex = 128
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cart"
        '
        'Label35
        '
        Me.Label35.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(446, 565)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(112, 21)
        Me.Label35.TabIndex = 147
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
        Me.ckprintpreview.Location = New System.Drawing.Point(426, 568)
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
        Me.ckprintpreview.TabIndex = 146
        Me.ckprintpreview.ThreeState = False
        Me.ckprintpreview.ToolTipText = Nothing
        '
        'Label31
        '
        Me.Label31.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(21, 565)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(94, 21)
        Me.Label31.TabIndex = 144
        Me.Label31.Text = "Reciept No"
        '
        'BunifuThinButton28
        '
        Me.BunifuThinButton28.ActiveBorderThickness = 1
        Me.BunifuThinButton28.ActiveCornerRadius = 20
        Me.BunifuThinButton28.ActiveFillColor = System.Drawing.Color.SteelBlue
        Me.BunifuThinButton28.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton28.ActiveLineColor = System.Drawing.Color.SteelBlue
        Me.BunifuThinButton28.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuThinButton28.BackColor = System.Drawing.Color.Khaki
        Me.BunifuThinButton28.BackgroundImage = CType(resources.GetObject("BunifuThinButton28.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton28.ButtonText = "Reprint"
        Me.BunifuThinButton28.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton28.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton28.ForeColor = System.Drawing.SystemColors.WindowText
        Me.BunifuThinButton28.IdleBorderThickness = 1
        Me.BunifuThinButton28.IdleCornerRadius = 20
        Me.BunifuThinButton28.IdleFillColor = System.Drawing.Color.White
        Me.BunifuThinButton28.IdleForecolor = System.Drawing.Color.SteelBlue
        Me.BunifuThinButton28.IdleLineColor = System.Drawing.Color.SteelBlue
        Me.BunifuThinButton28.Location = New System.Drawing.Point(327, 555)
        Me.BunifuThinButton28.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton28.Name = "BunifuThinButton28"
        Me.BunifuThinButton28.Size = New System.Drawing.Size(80, 40)
        Me.BunifuThinButton28.TabIndex = 135
        Me.BunifuThinButton28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtReprintNo
        '
        Me.txtReprintNo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtReprintNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtReprintNo.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReprintNo.Location = New System.Drawing.Point(121, 558)
        Me.txtReprintNo.Name = "txtReprintNo"
        Me.txtReprintNo.Size = New System.Drawing.Size(198, 31)
        Me.txtReprintNo.TabIndex = 144
        '
        'BunifuThinButton25
        '
        Me.BunifuThinButton25.ActiveBorderThickness = 1
        Me.BunifuThinButton25.ActiveCornerRadius = 20
        Me.BunifuThinButton25.ActiveFillColor = System.Drawing.Color.Firebrick
        Me.BunifuThinButton25.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton25.ActiveLineColor = System.Drawing.Color.Firebrick
        Me.BunifuThinButton25.BackColor = System.Drawing.Color.Khaki
        Me.BunifuThinButton25.BackgroundImage = CType(resources.GetObject("BunifuThinButton25.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton25.ButtonText = "Discount Cart"
        Me.BunifuThinButton25.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton25.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton25.ForeColor = System.Drawing.SystemColors.WindowText
        Me.BunifuThinButton25.IdleBorderThickness = 1
        Me.BunifuThinButton25.IdleCornerRadius = 20
        Me.BunifuThinButton25.IdleFillColor = System.Drawing.Color.White
        Me.BunifuThinButton25.IdleForecolor = System.Drawing.Color.DarkRed
        Me.BunifuThinButton25.IdleLineColor = System.Drawing.Color.Maroon
        Me.BunifuThinButton25.Location = New System.Drawing.Point(395, 19)
        Me.BunifuThinButton25.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton25.Name = "BunifuThinButton25"
        Me.BunifuThinButton25.Size = New System.Drawing.Size(119, 39)
        Me.BunifuThinButton25.TabIndex = 139
        Me.BunifuThinButton25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuThinButton22
        '
        Me.BunifuThinButton22.ActiveBorderThickness = 1
        Me.BunifuThinButton22.ActiveCornerRadius = 20
        Me.BunifuThinButton22.ActiveFillColor = System.Drawing.Color.Firebrick
        Me.BunifuThinButton22.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton22.ActiveLineColor = System.Drawing.Color.Firebrick
        Me.BunifuThinButton22.BackColor = System.Drawing.Color.Khaki
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
        Me.BunifuThinButton22.Location = New System.Drawing.Point(274, 16)
        Me.BunifuThinButton22.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton22.Name = "BunifuThinButton22"
        Me.BunifuThinButton22.Size = New System.Drawing.Size(98, 43)
        Me.BunifuThinButton22.TabIndex = 130
        Me.BunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gvSales
        '
        Me.gvSales.AllowCustomTheming = True
        Me.gvSales.AllowUserToAddRows = False
        Me.gvSales.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        Me.gvSales.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.gvSales.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gvSales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.gvSales.BackgroundColor = System.Drawing.Color.White
        Me.gvSales.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.gvSales.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.gvSales.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(204, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gvSales.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
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
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.gvSales.DefaultCellStyle = DataGridViewCellStyle6
        Me.gvSales.EnableHeadersVisualStyles = False
        Me.gvSales.GridColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvSales.HeaderBackColor = System.Drawing.Color.DodgerBlue
        Me.gvSales.HeaderBgColor = System.Drawing.Color.Empty
        Me.gvSales.HeaderForeColor = System.Drawing.Color.White
        Me.gvSales.Location = New System.Drawing.Point(6, 202)
        Me.gvSales.Name = "gvSales"
        Me.gvSales.ReadOnly = True
        Me.gvSales.RowHeadersVisible = False
        Me.gvSales.RowTemplate.Height = 40
        Me.gvSales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gvSales.Size = New System.Drawing.Size(569, 349)
        Me.gvSales.TabIndex = 132
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
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.BackColor = System.Drawing.Color.NavajoWhite
        Me.GroupBox2.Controls.Add(Me.cbSaleslist)
        Me.GroupBox2.Controls.Add(Me.cbProdlineSort)
        Me.GroupBox2.Controls.Add(Me.BunifuThinButton29)
        Me.GroupBox2.Controls.Add(Me.cbCatSort)
        Me.GroupBox2.Controls.Add(Me.Label32)
        Me.GroupBox2.Controls.Add(Me.Label33)
        Me.GroupBox2.Controls.Add(Me.lblOPrice)
        Me.GroupBox2.Controls.Add(Me.gvStock)
        Me.GroupBox2.Controls.Add(Me.lblActualStock)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.Label23)
        Me.GroupBox2.Controls.Add(Me.Label24)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(3, 123)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(334, 605)
        Me.GroupBox2.TabIndex = 129
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Items"
        '
        'cbSaleslist
        '
        Me.cbSaleslist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSaleslist.FormattingEnabled = True
        Me.cbSaleslist.Items.AddRange(New Object() {"Products", "Packages ", "Pro-Forma Invoices"})
        Me.cbSaleslist.Location = New System.Drawing.Point(15, 136)
        Me.cbSaleslist.Name = "cbSaleslist"
        Me.cbSaleslist.Size = New System.Drawing.Size(296, 28)
        Me.cbSaleslist.TabIndex = 211
        '
        'cbProdlineSort
        '
        Me.cbProdlineSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbProdlineSort.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbProdlineSort.FormattingEnabled = True
        Me.cbProdlineSort.Location = New System.Drawing.Point(133, 107)
        Me.cbProdlineSort.Name = "cbProdlineSort"
        Me.cbProdlineSort.Size = New System.Drawing.Size(126, 25)
        Me.cbProdlineSort.TabIndex = 210
        '
        'BunifuThinButton29
        '
        Me.BunifuThinButton29.ActiveBorderThickness = 1
        Me.BunifuThinButton29.ActiveCornerRadius = 20
        Me.BunifuThinButton29.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton29.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton29.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton29.BackColor = System.Drawing.Color.NavajoWhite
        Me.BunifuThinButton29.BackgroundImage = CType(resources.GetObject("BunifuThinButton29.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton29.ButtonText = "Reset"
        Me.BunifuThinButton29.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton29.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton29.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton29.IdleBorderThickness = 1
        Me.BunifuThinButton29.IdleCornerRadius = 20
        Me.BunifuThinButton29.IdleFillColor = System.Drawing.Color.White
        Me.BunifuThinButton29.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton29.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton29.Location = New System.Drawing.Point(272, 89)
        Me.BunifuThinButton29.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton29.Name = "BunifuThinButton29"
        Me.BunifuThinButton29.Size = New System.Drawing.Size(54, 42)
        Me.BunifuThinButton29.TabIndex = 209
        Me.BunifuThinButton29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cbCatSort
        '
        Me.cbCatSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCatSort.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCatSort.FormattingEnabled = True
        Me.cbCatSort.Location = New System.Drawing.Point(13, 107)
        Me.cbCatSort.Name = "cbCatSort"
        Me.cbCatSort.Size = New System.Drawing.Size(109, 25)
        Me.cbCatSort.TabIndex = 208
        '
        'Label32
        '
        Me.Label32.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label32.Location = New System.Drawing.Point(134, 87)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(129, 17)
        Me.Label32.TabIndex = 207
        Me.Label32.Text = "Sort By Product line"
        '
        'Label33
        '
        Me.Label33.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label33.Location = New System.Drawing.Point(10, 89)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(112, 17)
        Me.Label33.TabIndex = 206
        Me.Label33.Text = "Sort By Category"
        '
        'lblOPrice
        '
        Me.lblOPrice.AutoSize = True
        Me.lblOPrice.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblOPrice.Location = New System.Drawing.Point(234, 67)
        Me.lblOPrice.Name = "lblOPrice"
        Me.lblOPrice.Size = New System.Drawing.Size(42, 13)
        Me.lblOPrice.TabIndex = 128
        Me.lblOPrice.Text = "Colour"
        Me.lblOPrice.Visible = False
        '
        'gvPriceBand
        '
        Me.gvPriceBand.AllowCustomTheming = True
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        Me.gvPriceBand.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.gvPriceBand.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.gvPriceBand.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.gvPriceBand.BackgroundColor = System.Drawing.Color.Gray
        Me.gvPriceBand.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.gvPriceBand.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.gvPriceBand.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(204, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gvPriceBand.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.gvPriceBand.ColumnHeadersHeight = 20
        Me.gvPriceBand.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvPriceBand.CurrentTheme.AlternatingRowsStyle.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvPriceBand.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black
        Me.gvPriceBand.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvPriceBand.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.gvPriceBand.CurrentTheme.BackColor = System.Drawing.Color.White
        Me.gvPriceBand.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvPriceBand.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue
        Me.gvPriceBand.CurrentTheme.HeaderStyle.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvPriceBand.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.gvPriceBand.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.gvPriceBand.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White
        Me.gvPriceBand.CurrentTheme.Name = Nothing
        Me.gvPriceBand.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White
        Me.gvPriceBand.CurrentTheme.RowsStyle.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvPriceBand.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.gvPriceBand.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvPriceBand.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.gvPriceBand.DefaultCellStyle = DataGridViewCellStyle9
        Me.gvPriceBand.EnableHeadersVisualStyles = False
        Me.gvPriceBand.GridColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvPriceBand.HeaderBackColor = System.Drawing.Color.DodgerBlue
        Me.gvPriceBand.HeaderBgColor = System.Drawing.Color.Empty
        Me.gvPriceBand.HeaderForeColor = System.Drawing.Color.White
        Me.gvPriceBand.Location = New System.Drawing.Point(303, 9)
        Me.gvPriceBand.MultiSelect = False
        Me.gvPriceBand.Name = "gvPriceBand"
        Me.gvPriceBand.ReadOnly = True
        Me.gvPriceBand.RowHeadersVisible = False
        Me.gvPriceBand.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.gvPriceBand.RowTemplate.Height = 40
        Me.gvPriceBand.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gvPriceBand.Size = New System.Drawing.Size(235, 46)
        Me.gvPriceBand.TabIndex = 128
        Me.gvPriceBand.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light
        Me.gvPriceBand.Visible = False
        '
        'gbsell
        '
        Me.gbsell.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbsell.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.gbsell.Controls.Add(Me.Label36)
        Me.gbsell.Controls.Add(Me.tksendsms)
        Me.gbsell.Controls.Add(Me.Label34)
        Me.gbsell.Controls.Add(Me.ckprint)
        Me.gbsell.Controls.Add(Me.Label28)
        Me.gbsell.Controls.Add(Me.ckA4)
        Me.gbsell.Controls.Add(Me.lblDiscAmt)
        Me.gbsell.Controls.Add(Me.Label30)
        Me.gbsell.Controls.Add(Me.lblPayable)
        Me.gbsell.Controls.Add(Me.Label29)
        Me.gbsell.Controls.Add(Me.lbldiscCode)
        Me.gbsell.Controls.Add(Me.GroupBox3)
        Me.gbsell.Controls.Add(Me.Label25)
        Me.gbsell.Controls.Add(Me.Label15)
        Me.gbsell.Controls.Add(Me.ckA5Paper)
        Me.gbsell.Controls.Add(Me.txtBuyerName)
        Me.gbsell.Controls.Add(Me.txtBuyerTel)
        Me.gbsell.Controls.Add(Me.cbLocation)
        Me.gbsell.Controls.Add(Me.cbPaymode)
        Me.gbsell.Controls.Add(Me.ckrollPaper)
        Me.gbsell.Controls.Add(Me.Label14)
        Me.gbsell.Controls.Add(Me.BunifuThinButton21)
        Me.gbsell.Controls.Add(Me.Label22)
        Me.gbsell.Controls.Add(Me.lblTotal)
        Me.gbsell.Controls.Add(Me.cbCreditCustName)
        Me.gbsell.Controls.Add(Me.Label3)
        Me.gbsell.Controls.Add(Me.cbSaleType)
        Me.gbsell.Controls.Add(Me.Label4)
        Me.gbsell.Controls.Add(Me.Label5)
        Me.gbsell.Controls.Add(Me.txtCashPaid)
        Me.gbsell.Controls.Add(Me.lblCreditCust)
        Me.gbsell.Controls.Add(Me.lblChange)
        Me.gbsell.Controls.Add(Me.Label11)
        Me.gbsell.Controls.Add(Me.Label12)
        Me.gbsell.Controls.Add(Me.Label13)
        Me.gbsell.Controls.Add(Me.Label2)
        Me.gbsell.Controls.Add(Me.lblOldBal)
        Me.gbsell.Controls.Add(Me.lblCustNo)
        Me.gbsell.Controls.Add(Me.lblNewBal)
        Me.gbsell.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbsell.Location = New System.Drawing.Point(930, 123)
        Me.gbsell.Name = "gbsell"
        Me.gbsell.Size = New System.Drawing.Size(324, 612)
        Me.gbsell.TabIndex = 130
        Me.gbsell.TabStop = False
        Me.gbsell.Text = "Sell"
        '
        'Label36
        '
        Me.Label36.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(242, 505)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(85, 21)
        Me.Label36.TabIndex = 145
        Me.Label36.Text = "Send SMS"
        '
        'tksendsms
        '
        Me.tksendsms.AllowBindingControlAnimation = True
        Me.tksendsms.AllowBindingControlColorChanges = False
        Me.tksendsms.AllowBindingControlLocation = True
        Me.tksendsms.AllowCheckBoxAnimation = False
        Me.tksendsms.AllowCheckmarkAnimation = True
        Me.tksendsms.AllowOnHoverStates = True
        Me.tksendsms.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tksendsms.AutoCheck = True
        Me.tksendsms.BackColor = System.Drawing.Color.Transparent
        Me.tksendsms.BackgroundImage = CType(resources.GetObject("tksendsms.BackgroundImage"), System.Drawing.Image)
        Me.tksendsms.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tksendsms.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right
        Me.tksendsms.BorderRadius = 12
        Me.tksendsms.Checked = False
        Me.tksendsms.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Unchecked
        Me.tksendsms.Cursor = System.Windows.Forms.Cursors.Default
        Me.tksendsms.CustomCheckmarkImage = Nothing
        Me.tksendsms.Location = New System.Drawing.Point(222, 508)
        Me.tksendsms.MinimumSize = New System.Drawing.Size(17, 17)
        Me.tksendsms.Name = "tksendsms"
        Me.tksendsms.OnCheck.BorderColor = System.Drawing.Color.DodgerBlue
        Me.tksendsms.OnCheck.BorderRadius = 12
        Me.tksendsms.OnCheck.BorderThickness = 2
        Me.tksendsms.OnCheck.CheckBoxColor = System.Drawing.Color.DodgerBlue
        Me.tksendsms.OnCheck.CheckmarkColor = System.Drawing.Color.White
        Me.tksendsms.OnCheck.CheckmarkThickness = 2
        Me.tksendsms.OnDisable.BorderColor = System.Drawing.Color.LightGray
        Me.tksendsms.OnDisable.BorderRadius = 12
        Me.tksendsms.OnDisable.BorderThickness = 2
        Me.tksendsms.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent
        Me.tksendsms.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray
        Me.tksendsms.OnDisable.CheckmarkThickness = 2
        Me.tksendsms.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tksendsms.OnHoverChecked.BorderRadius = 12
        Me.tksendsms.OnHoverChecked.BorderThickness = 2
        Me.tksendsms.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tksendsms.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White
        Me.tksendsms.OnHoverChecked.CheckmarkThickness = 2
        Me.tksendsms.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tksendsms.OnHoverUnchecked.BorderRadius = 12
        Me.tksendsms.OnHoverUnchecked.BorderThickness = 1
        Me.tksendsms.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent
        Me.tksendsms.OnUncheck.BorderColor = System.Drawing.Color.DarkGray
        Me.tksendsms.OnUncheck.BorderRadius = 12
        Me.tksendsms.OnUncheck.BorderThickness = 1
        Me.tksendsms.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent
        Me.tksendsms.Size = New System.Drawing.Size(17, 17)
        Me.tksendsms.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu
        Me.tksendsms.TabIndex = 144
        Me.tksendsms.ThreeState = False
        Me.tksendsms.ToolTipText = Nothing
        '
        'Label34
        '
        Me.Label34.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(166, 506)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(47, 21)
        Me.Label34.TabIndex = 145
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
        Me.ckprint.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.ckprint.Location = New System.Drawing.Point(146, 509)
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
        Me.ckprint.TabIndex = 144
        Me.ckprint.ThreeState = False
        Me.ckprint.ToolTipText = Nothing
        '
        'Label28
        '
        Me.Label28.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(33, 583)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(78, 21)
        Me.Label28.TabIndex = 143
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
        Me.ckA4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ckA4.AutoCheck = True
        Me.ckA4.BackColor = System.Drawing.Color.Transparent
        Me.ckA4.BackgroundImage = CType(resources.GetObject("ckA4.BackgroundImage"), System.Drawing.Image)
        Me.ckA4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ckA4.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right
        Me.ckA4.BorderRadius = 12
        Me.ckA4.Checked = True
        Me.ckA4.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Checked
        Me.ckA4.Cursor = System.Windows.Forms.Cursors.Default
        Me.ckA4.CustomCheckmarkImage = Nothing
        Me.ckA4.Location = New System.Drawing.Point(13, 586)
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
        Me.ckA4.TabIndex = 142
        Me.ckA4.ThreeState = False
        Me.ckA4.ToolTipText = Nothing
        '
        'lblDiscAmt
        '
        Me.lblDiscAmt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDiscAmt.AutoSize = True
        Me.lblDiscAmt.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscAmt.Location = New System.Drawing.Point(155, 201)
        Me.lblDiscAmt.Name = "lblDiscAmt"
        Me.lblDiscAmt.Size = New System.Drawing.Size(25, 30)
        Me.lblDiscAmt.TabIndex = 140
        Me.lblDiscAmt.Text = "0"
        '
        'Label30
        '
        Me.Label30.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(73, 205)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(82, 21)
        Me.Label30.TabIndex = 141
        Me.Label30.Text = "Discount:"
        '
        'lblPayable
        '
        Me.lblPayable.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPayable.AutoSize = True
        Me.lblPayable.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPayable.Location = New System.Drawing.Point(233, 235)
        Me.lblPayable.Name = "lblPayable"
        Me.lblPayable.Size = New System.Drawing.Size(34, 40)
        Me.lblPayable.TabIndex = 138
        Me.lblPayable.Text = "0"
        '
        'Label29
        '
        Me.Label29.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(152, 243)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(75, 21)
        Me.Label29.TabIndex = 139
        Me.Label29.Text = "Payable:"
        '
        'lbldiscCode
        '
        Me.lbldiscCode.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbldiscCode.AutoSize = True
        Me.lbldiscCode.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldiscCode.Location = New System.Drawing.Point(311, 160)
        Me.lbldiscCode.Name = "lbldiscCode"
        Me.lbldiscCode.Size = New System.Drawing.Size(0, 15)
        Me.lbldiscCode.TabIndex = 137
        Me.lbldiscCode.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.txtDiscName)
        Me.GroupBox3.Controls.Add(Me.BunifuThinButton23)
        Me.GroupBox3.Controls.Add(Me.txtCashDisc)
        Me.GroupBox3.Controls.Add(Me.txtPerDisc)
        Me.GroupBox3.Controls.Add(Me.Label26)
        Me.GroupBox3.Controls.Add(Me.Label27)
        Me.GroupBox3.Controls.Add(Me.ckCashDisc)
        Me.GroupBox3.Controls.Add(Me.ckPerDisc)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Black
        Me.GroupBox3.Location = New System.Drawing.Point(39, 98)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(282, 104)
        Me.GroupBox3.TabIndex = 136
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Discount"
        '
        'txtDiscName
        '
        Me.txtDiscName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDiscName.Location = New System.Drawing.Point(153, 15)
        Me.txtDiscName.Name = "txtDiscName"
        Me.txtDiscName.Size = New System.Drawing.Size(96, 41)
        Me.txtDiscName.TabIndex = 138
        Me.txtDiscName.Text = ""
        '
        'BunifuThinButton23
        '
        Me.BunifuThinButton23.ActiveBorderThickness = 1
        Me.BunifuThinButton23.ActiveCornerRadius = 20
        Me.BunifuThinButton23.ActiveFillColor = System.Drawing.Color.Firebrick
        Me.BunifuThinButton23.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton23.ActiveLineColor = System.Drawing.Color.Firebrick
        Me.BunifuThinButton23.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuThinButton23.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.BunifuThinButton23.BackgroundImage = CType(resources.GetObject("BunifuThinButton23.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton23.ButtonText = "Discount"
        Me.BunifuThinButton23.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton23.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton23.ForeColor = System.Drawing.SystemColors.WindowText
        Me.BunifuThinButton23.IdleBorderThickness = 1
        Me.BunifuThinButton23.IdleCornerRadius = 20
        Me.BunifuThinButton23.IdleFillColor = System.Drawing.Color.White
        Me.BunifuThinButton23.IdleForecolor = System.Drawing.Color.DarkRed
        Me.BunifuThinButton23.IdleLineColor = System.Drawing.Color.Maroon
        Me.BunifuThinButton23.Location = New System.Drawing.Point(178, 63)
        Me.BunifuThinButton23.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton23.Name = "BunifuThinButton23"
        Me.BunifuThinButton23.Size = New System.Drawing.Size(96, 33)
        Me.BunifuThinButton23.TabIndex = 137
        Me.BunifuThinButton23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCashDisc
        '
        Me.txtCashDisc.Location = New System.Drawing.Point(68, 29)
        Me.txtCashDisc.Name = "txtCashDisc"
        Me.txtCashDisc.Size = New System.Drawing.Size(62, 27)
        Me.txtCashDisc.TabIndex = 135
        Me.txtCashDisc.Text = "0"
        '
        'txtPerDisc
        '
        Me.txtPerDisc.Location = New System.Drawing.Point(67, 62)
        Me.txtPerDisc.Name = "txtPerDisc"
        Me.txtPerDisc.Size = New System.Drawing.Size(65, 27)
        Me.txtPerDisc.TabIndex = 134
        Me.txtPerDisc.Text = "0"
        '
        'Label26
        '
        Me.Label26.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(37, 33)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(19, 21)
        Me.Label26.TabIndex = 133
        Me.Label26.Text = "$"
        '
        'Label27
        '
        Me.Label27.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(37, 68)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(24, 21)
        Me.Label27.TabIndex = 132
        Me.Label27.Text = "%"
        '
        'ckCashDisc
        '
        Me.ckCashDisc.AllowBindingControlAnimation = True
        Me.ckCashDisc.AllowBindingControlColorChanges = False
        Me.ckCashDisc.AllowBindingControlLocation = True
        Me.ckCashDisc.AllowCheckBoxAnimation = False
        Me.ckCashDisc.AllowCheckmarkAnimation = True
        Me.ckCashDisc.AllowOnHoverStates = True
        Me.ckCashDisc.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ckCashDisc.AutoCheck = True
        Me.ckCashDisc.BackColor = System.Drawing.Color.Transparent
        Me.ckCashDisc.BackgroundImage = CType(resources.GetObject("ckCashDisc.BackgroundImage"), System.Drawing.Image)
        Me.ckCashDisc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ckCashDisc.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right
        Me.ckCashDisc.BorderRadius = 12
        Me.ckCashDisc.Checked = True
        Me.ckCashDisc.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Checked
        Me.ckCashDisc.Cursor = System.Windows.Forms.Cursors.Default
        Me.ckCashDisc.CustomCheckmarkImage = Nothing
        Me.ckCashDisc.Location = New System.Drawing.Point(10, 34)
        Me.ckCashDisc.MinimumSize = New System.Drawing.Size(17, 17)
        Me.ckCashDisc.Name = "ckCashDisc"
        Me.ckCashDisc.OnCheck.BorderColor = System.Drawing.Color.DodgerBlue
        Me.ckCashDisc.OnCheck.BorderRadius = 12
        Me.ckCashDisc.OnCheck.BorderThickness = 2
        Me.ckCashDisc.OnCheck.CheckBoxColor = System.Drawing.Color.DodgerBlue
        Me.ckCashDisc.OnCheck.CheckmarkColor = System.Drawing.Color.White
        Me.ckCashDisc.OnCheck.CheckmarkThickness = 2
        Me.ckCashDisc.OnDisable.BorderColor = System.Drawing.Color.LightGray
        Me.ckCashDisc.OnDisable.BorderRadius = 12
        Me.ckCashDisc.OnDisable.BorderThickness = 2
        Me.ckCashDisc.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent
        Me.ckCashDisc.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray
        Me.ckCashDisc.OnDisable.CheckmarkThickness = 2
        Me.ckCashDisc.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ckCashDisc.OnHoverChecked.BorderRadius = 12
        Me.ckCashDisc.OnHoverChecked.BorderThickness = 2
        Me.ckCashDisc.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ckCashDisc.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White
        Me.ckCashDisc.OnHoverChecked.CheckmarkThickness = 2
        Me.ckCashDisc.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ckCashDisc.OnHoverUnchecked.BorderRadius = 12
        Me.ckCashDisc.OnHoverUnchecked.BorderThickness = 1
        Me.ckCashDisc.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent
        Me.ckCashDisc.OnUncheck.BorderColor = System.Drawing.Color.DarkGray
        Me.ckCashDisc.OnUncheck.BorderRadius = 12
        Me.ckCashDisc.OnUncheck.BorderThickness = 1
        Me.ckCashDisc.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent
        Me.ckCashDisc.Size = New System.Drawing.Size(21, 21)
        Me.ckCashDisc.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu
        Me.ckCashDisc.TabIndex = 131
        Me.ckCashDisc.ThreeState = False
        Me.ckCashDisc.ToolTipText = Nothing
        '
        'ckPerDisc
        '
        Me.ckPerDisc.AllowBindingControlAnimation = True
        Me.ckPerDisc.AllowBindingControlColorChanges = False
        Me.ckPerDisc.AllowBindingControlLocation = True
        Me.ckPerDisc.AllowCheckBoxAnimation = False
        Me.ckPerDisc.AllowCheckmarkAnimation = True
        Me.ckPerDisc.AllowOnHoverStates = True
        Me.ckPerDisc.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ckPerDisc.AutoCheck = True
        Me.ckPerDisc.BackColor = System.Drawing.Color.Transparent
        Me.ckPerDisc.BackgroundImage = CType(resources.GetObject("ckPerDisc.BackgroundImage"), System.Drawing.Image)
        Me.ckPerDisc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ckPerDisc.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right
        Me.ckPerDisc.BorderRadius = 12
        Me.ckPerDisc.Checked = True
        Me.ckPerDisc.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Checked
        Me.ckPerDisc.Cursor = System.Windows.Forms.Cursors.Default
        Me.ckPerDisc.CustomCheckmarkImage = Nothing
        Me.ckPerDisc.Location = New System.Drawing.Point(11, 68)
        Me.ckPerDisc.MinimumSize = New System.Drawing.Size(17, 17)
        Me.ckPerDisc.Name = "ckPerDisc"
        Me.ckPerDisc.OnCheck.BorderColor = System.Drawing.Color.DodgerBlue
        Me.ckPerDisc.OnCheck.BorderRadius = 12
        Me.ckPerDisc.OnCheck.BorderThickness = 2
        Me.ckPerDisc.OnCheck.CheckBoxColor = System.Drawing.Color.DodgerBlue
        Me.ckPerDisc.OnCheck.CheckmarkColor = System.Drawing.Color.White
        Me.ckPerDisc.OnCheck.CheckmarkThickness = 2
        Me.ckPerDisc.OnDisable.BorderColor = System.Drawing.Color.LightGray
        Me.ckPerDisc.OnDisable.BorderRadius = 12
        Me.ckPerDisc.OnDisable.BorderThickness = 2
        Me.ckPerDisc.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent
        Me.ckPerDisc.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray
        Me.ckPerDisc.OnDisable.CheckmarkThickness = 2
        Me.ckPerDisc.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ckPerDisc.OnHoverChecked.BorderRadius = 12
        Me.ckPerDisc.OnHoverChecked.BorderThickness = 2
        Me.ckPerDisc.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ckPerDisc.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White
        Me.ckPerDisc.OnHoverChecked.CheckmarkThickness = 2
        Me.ckPerDisc.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ckPerDisc.OnHoverUnchecked.BorderRadius = 12
        Me.ckPerDisc.OnHoverUnchecked.BorderThickness = 1
        Me.ckPerDisc.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent
        Me.ckPerDisc.OnUncheck.BorderColor = System.Drawing.Color.DarkGray
        Me.ckPerDisc.OnUncheck.BorderRadius = 12
        Me.ckPerDisc.OnUncheck.BorderThickness = 1
        Me.ckPerDisc.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent
        Me.ckPerDisc.Size = New System.Drawing.Size(21, 21)
        Me.ckPerDisc.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu
        Me.ckPerDisc.TabIndex = 130
        Me.ckPerDisc.ThreeState = False
        Me.ckPerDisc.ToolTipText = Nothing
        '
        'Label25
        '
        Me.Label25.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(33, 559)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(78, 21)
        Me.Label25.TabIndex = 129
        Me.Label25.Text = "A5 Paper"
        '
        'Label15
        '
        Me.Label15.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(33, 534)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(84, 21)
        Me.Label15.TabIndex = 128
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
        Me.ckA5Paper.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.ckA5Paper.Location = New System.Drawing.Point(13, 562)
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
        Me.ckA5Paper.TabIndex = 127
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
        Me.ckrollPaper.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ckrollPaper.AutoCheck = True
        Me.ckrollPaper.BackColor = System.Drawing.Color.Transparent
        Me.ckrollPaper.BackgroundImage = CType(resources.GetObject("ckrollPaper.BackgroundImage"), System.Drawing.Image)
        Me.ckrollPaper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ckrollPaper.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right
        Me.ckrollPaper.BorderRadius = 12
        Me.ckrollPaper.Checked = False
        Me.ckrollPaper.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Unchecked
        Me.ckrollPaper.Cursor = System.Windows.Forms.Cursors.Default
        Me.ckrollPaper.CustomCheckmarkImage = Nothing
        Me.ckrollPaper.Location = New System.Drawing.Point(13, 537)
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
        Me.ckrollPaper.TabIndex = 126
        Me.ckrollPaper.ThreeState = False
        Me.ckrollPaper.ToolTipText = Nothing
        '
        'Label14
        '
        Me.Label14.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(11, 511)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(106, 15)
        Me.Label14.TabIndex = 125
        Me.Label14.Text = "Choose Print Type"
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
        Me.BunifuThinButton21.Location = New System.Drawing.Point(144, 537)
        Me.BunifuThinButton21.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton21.Name = "BunifuThinButton21"
        Me.BunifuThinButton21.Size = New System.Drawing.Size(160, 68)
        Me.BunifuThinButton21.TabIndex = 124
        Me.BunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Peru
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
        Me.Panel1.Location = New System.Drawing.Point(0, -2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1269, 69)
        Me.Panel1.TabIndex = 131
        '
        'BunifuThinButton27
        '
        Me.BunifuThinButton27.ActiveBorderThickness = 1
        Me.BunifuThinButton27.ActiveCornerRadius = 20
        Me.BunifuThinButton27.ActiveFillColor = System.Drawing.Color.SteelBlue
        Me.BunifuThinButton27.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton27.ActiveLineColor = System.Drawing.Color.SteelBlue
        Me.BunifuThinButton27.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuThinButton27.BackColor = System.Drawing.Color.Peru
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
        Me.BunifuThinButton27.Location = New System.Drawing.Point(1061, 3)
        Me.BunifuThinButton27.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton27.Name = "BunifuThinButton27"
        Me.BunifuThinButton27.Size = New System.Drawing.Size(153, 48)
        Me.BunifuThinButton27.TabIndex = 135
        Me.BunifuThinButton27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox5
        '
        Me.PictureBox5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(1147, 3)
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
        Me.PictureBox4.Location = New System.Drawing.Point(1222, 0)
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
        Me.PictureBox3.Location = New System.Drawing.Point(1222, -2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(37, 44)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 127
        Me.PictureBox3.TabStop = False
        Me.PictureBox3.Visible = False
        '
        'lblProformaInvoice
        '
        Me.lblProformaInvoice.AutoSize = True
        Me.lblProformaInvoice.Location = New System.Drawing.Point(909, 11)
        Me.lblProformaInvoice.Name = "lblProformaInvoice"
        Me.lblProformaInvoice.Size = New System.Drawing.Size(32, 13)
        Me.lblProformaInvoice.TabIndex = 126
        Me.lblProformaInvoice.Text = "100#"
        Me.lblProformaInvoice.Visible = False
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "Stock Check"
        Me.NotifyIcon1.Visible = True
        '
        'frmSales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1259, 760)
        Me.Controls.Add(Me.gvPriceBand)
        Me.Controls.Add(Me.txtProdname)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.txtColour)
        Me.Controls.Add(Me.txtProdline)
        Me.Controls.Add(Me.txtSize)
        Me.Controls.Add(Me.txtCat)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.gbsell)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ItemName"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.gvStock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.gvSales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.gvPriceBand, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbsell.ResumeLayout(False)
        Me.gbsell.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCashPaid As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblChange As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtQty As TextBox
    Friend WithEvents txtAmt As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents cbProdName As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtBuyerName As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtBuyerTel As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents cbLocation As ComboBox
    Friend WithEvents cbPaymode As ComboBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lblProdName As Label
    Friend WithEvents txtProdcode As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label17 As Label
    Friend WithEvents lblActualStock As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents txtCat As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtSize As TextBox
    Friend WithEvents txtProdline As TextBox
    Friend WithEvents txtColour As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents cbSaleType As ComboBox
    Friend WithEvents Label22 As Label
    Friend WithEvents lblCreditCust As Label
    Friend WithEvents cbCreditCustName As ComboBox
    Friend WithEvents lblOldBal As Label
    Friend WithEvents lblNewBal As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents lblCustNo As Label
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents txtProdname As ComboBox
    Friend WithEvents lblRecieptNo As Label
    Friend WithEvents gvStock As Bunifu.UI.WinForms.BunifuDataGridView
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents lblDate As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As ToolStripStatusLabel
    Friend WithEvents lblTime As ToolStripStatusLabel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents gbsell As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents gvSales As Bunifu.UI.WinForms.BunifuDataGridView
    Friend WithEvents BunifuThinButton21 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Label14 As Label
    Friend WithEvents ckA5Paper As Bunifu.UI.WinForms.BunifuCheckBox
    Friend WithEvents ckrollPaper As Bunifu.UI.WinForms.BunifuCheckBox
    Friend WithEvents Label25 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents BunifuThinButton22 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Activeuser As ToolStripStatusLabel
    Friend WithEvents txtCashDisc As TextBox
    Friend WithEvents txtPerDisc As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents ckCashDisc As Bunifu.UI.WinForms.BunifuCheckBox
    Friend WithEvents ckPerDisc As Bunifu.UI.WinForms.BunifuCheckBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents BunifuThinButton23 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents txtDiscName As RichTextBox
    Friend WithEvents lbldiscCode As Label
    Friend WithEvents lblPayable As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents lblDiscAmt As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents BunifuThinButton25 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents gvPriceBand As Bunifu.UI.WinForms.BunifuDataGridView
    Friend WithEvents BunifuThinButton27 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Label28 As Label
    Friend WithEvents ckA4 As Bunifu.UI.WinForms.BunifuCheckBox
    Friend WithEvents lblOPrice As Label
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
    Friend WithEvents Label31 As Label
    Friend WithEvents BunifuThinButton28 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents txtReprintNo As TextBox
    Friend WithEvents cbProdlineSort As ComboBox
    Friend WithEvents BunifuThinButton29 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents cbCatSort As ComboBox
    Friend WithEvents Label32 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents ckprint As Bunifu.UI.WinForms.BunifuCheckBox
    Friend WithEvents Label35 As Label
    Friend WithEvents ckprintpreview As Bunifu.UI.WinForms.BunifuCheckBox
    Friend WithEvents Label36 As Label
    Friend WithEvents tksendsms As Bunifu.UI.WinForms.BunifuCheckBox
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents cbSaleslist As ComboBox
    Friend WithEvents lblProformaInvoice As Label
End Class
