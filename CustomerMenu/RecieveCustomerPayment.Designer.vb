<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RecieveCustomerPayment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RecieveCustomerPayment))
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblCustBal = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtAmtPaid = New System.Windows.Forms.TextBox()
        Me.lblNewBal = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNarration = New System.Windows.Forms.TextBox()
        Me.cbType = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbPaymentMode = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtRecieptNo = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtRecievedBy = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.cbCustName = New System.Windows.Forms.ComboBox()
        Me.lblCustID = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblpaymentid = New System.Windows.Forms.Label()
        Me.BunifuThinButton22 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuThinButton21 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblTime = New System.Windows.Forms.ToolStripStatusLabel()
        Me.txtdatepaid = New Bunifu.UI.WinForms.BunifuDatePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtdiscount = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.ckprint = New Bunifu.UI.WinForms.BunifuCheckBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.ckprintpreview = New Bunifu.UI.WinForms.BunifuCheckBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tkroll = New Bunifu.UI.WinForms.BunifuCheckBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.tkA5 = New Bunifu.UI.WinForms.BunifuCheckBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(12, 13)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(41, 42)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 102
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
        '
        'Label13
        '
        Me.Label13.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label13.Location = New System.Drawing.Point(58, 109)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(83, 21)
        Me.Label13.TabIndex = 121
        Me.Label13.Text = "Customer"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(79, 149)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 21)
        Me.Label1.TabIndex = 123
        Me.Label1.Text = "Balance"
        '
        'lblCustBal
        '
        Me.lblCustBal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCustBal.AutoSize = True
        Me.lblCustBal.Font = New System.Drawing.Font("Segoe UI Black", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblCustBal.Location = New System.Drawing.Point(187, 139)
        Me.lblCustBal.Name = "lblCustBal"
        Me.lblCustBal.Size = New System.Drawing.Size(29, 32)
        Me.lblCustBal.TabIndex = 124
        Me.lblCustBal.Text = "0"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(45, 194)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 21)
        Me.Label2.TabIndex = 126
        Me.Label2.Text = "Date Paid"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(19, 237)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 21)
        Me.Label3.TabIndex = 128
        Me.Label3.Text = "Amount Paid"
        '
        'txtAmtPaid
        '
        Me.txtAmtPaid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAmtPaid.BackColor = System.Drawing.Color.White
        Me.txtAmtPaid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAmtPaid.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtAmtPaid.Location = New System.Drawing.Point(145, 229)
        Me.txtAmtPaid.Name = "txtAmtPaid"
        Me.txtAmtPaid.Size = New System.Drawing.Size(320, 29)
        Me.txtAmtPaid.TabIndex = 127
        '
        'lblNewBal
        '
        Me.lblNewBal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNewBal.AutoSize = True
        Me.lblNewBal.Font = New System.Drawing.Font("Segoe UI Black", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblNewBal.Location = New System.Drawing.Point(176, 310)
        Me.lblNewBal.Name = "lblNewBal"
        Me.lblNewBal.Size = New System.Drawing.Size(29, 32)
        Me.lblNewBal.TabIndex = 130
        Me.lblNewBal.Text = "0"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(45, 318)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 21)
        Me.Label5.TabIndex = 129
        Me.Label5.Text = "New Balance"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(58, 357)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 21)
        Me.Label6.TabIndex = 132
        Me.Label6.Text = "Narration"
        '
        'txtNarration
        '
        Me.txtNarration.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNarration.BackColor = System.Drawing.Color.White
        Me.txtNarration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNarration.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtNarration.Location = New System.Drawing.Point(145, 355)
        Me.txtNarration.Multiline = True
        Me.txtNarration.Name = "txtNarration"
        Me.txtNarration.Size = New System.Drawing.Size(330, 102)
        Me.txtNarration.TabIndex = 131
        '
        'cbType
        '
        Me.cbType.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbType.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.cbType.FormattingEnabled = True
        Me.cbType.Items.AddRange(New Object() {"Debt Payment", "Deposit Payment"})
        Me.cbType.Location = New System.Drawing.Point(681, 102)
        Me.cbType.Name = "cbType"
        Me.cbType.Size = New System.Drawing.Size(149, 33)
        Me.cbType.TabIndex = 134
        Me.cbType.Visible = False
        '
        'Label7
        '
        Me.Label7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(552, 102)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(118, 21)
        Me.Label7.TabIndex = 133
        Me.Label7.Text = "Payment Type"
        Me.Label7.Visible = False
        '
        'cbPaymentMode
        '
        Me.cbPaymentMode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbPaymentMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPaymentMode.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.cbPaymentMode.FormattingEnabled = True
        Me.cbPaymentMode.Items.AddRange(New Object() {"Cash", "Cheque", "Momo"})
        Me.cbPaymentMode.Location = New System.Drawing.Point(681, 158)
        Me.cbPaymentMode.Name = "cbPaymentMode"
        Me.cbPaymentMode.Size = New System.Drawing.Size(149, 33)
        Me.cbPaymentMode.TabIndex = 136
        '
        'Label8
        '
        Me.Label8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(549, 168)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(126, 21)
        Me.Label8.TabIndex = 135
        Me.Label8.Text = "Payment Mode"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(0, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(279, 40)
        Me.Label9.TabIndex = 137
        Me.Label9.Text = "Customer Payment"
        '
        'Label10
        '
        Me.Label10.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.Location = New System.Drawing.Point(519, 230)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(156, 21)
        Me.Label10.TabIndex = 139
        Me.Label10.Text = "Manual Reciept No"
        Me.Label10.Visible = False
        '
        'txtRecieptNo
        '
        Me.txtRecieptNo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRecieptNo.BackColor = System.Drawing.Color.White
        Me.txtRecieptNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRecieptNo.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtRecieptNo.Location = New System.Drawing.Point(681, 228)
        Me.txtRecieptNo.Name = "txtRecieptNo"
        Me.txtRecieptNo.Size = New System.Drawing.Size(149, 29)
        Me.txtRecieptNo.TabIndex = 138
        Me.txtRecieptNo.Visible = False
        '
        'Label11
        '
        Me.Label11.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label11.Location = New System.Drawing.Point(568, 275)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(102, 21)
        Me.Label11.TabIndex = 141
        Me.Label11.Text = "Recieved By"
        '
        'txtRecievedBy
        '
        Me.txtRecievedBy.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRecievedBy.BackColor = System.Drawing.Color.White
        Me.txtRecievedBy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRecievedBy.Enabled = False
        Me.txtRecievedBy.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtRecievedBy.Location = New System.Drawing.Point(681, 273)
        Me.txtRecievedBy.Name = "txtRecievedBy"
        Me.txtRecievedBy.Size = New System.Drawing.Size(149, 29)
        Me.txtRecievedBy.TabIndex = 140
        '
        'Timer1
        '
        '
        'cbCustName
        '
        Me.cbCustName.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbCustName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCustName.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.cbCustName.FormattingEnabled = True
        Me.cbCustName.Location = New System.Drawing.Point(145, 103)
        Me.cbCustName.Name = "cbCustName"
        Me.cbCustName.Size = New System.Drawing.Size(320, 33)
        Me.cbCustName.TabIndex = 122
        '
        'lblCustID
        '
        Me.lblCustID.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCustID.AutoSize = True
        Me.lblCustID.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustID.Location = New System.Drawing.Point(142, 43)
        Me.lblCustID.Name = "lblCustID"
        Me.lblCustID.Size = New System.Drawing.Size(0, 17)
        Me.lblCustID.TabIndex = 145
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Teal
        Me.Panel1.Controls.Add(Me.lblpaymentid)
        Me.Panel1.Controls.Add(Me.BunifuThinButton22)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Location = New System.Drawing.Point(0, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(860, 61)
        Me.Panel1.TabIndex = 148
        '
        'lblpaymentid
        '
        Me.lblpaymentid.AutoSize = True
        Me.lblpaymentid.Location = New System.Drawing.Point(342, 24)
        Me.lblpaymentid.Name = "lblpaymentid"
        Me.lblpaymentid.Size = New System.Drawing.Size(45, 13)
        Me.lblpaymentid.TabIndex = 152
        Me.lblpaymentid.Text = "Label12"
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
        Me.BunifuThinButton22.Location = New System.Drawing.Point(609, 3)
        Me.BunifuThinButton22.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton22.Name = "BunifuThinButton22"
        Me.BunifuThinButton22.Size = New System.Drawing.Size(155, 46)
        Me.BunifuThinButton22.TabIndex = 151
        Me.BunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuThinButton21
        '
        Me.BunifuThinButton21.ActiveBorderThickness = 1
        Me.BunifuThinButton21.ActiveCornerRadius = 20
        Me.BunifuThinButton21.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton21.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton21.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton21.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuThinButton21.BackColor = System.Drawing.SystemColors.Control
        Me.BunifuThinButton21.BackgroundImage = CType(resources.GetObject("BunifuThinButton21.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton21.ButtonText = "SAVE"
        Me.BunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton21.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton21.IdleBorderThickness = 1
        Me.BunifuThinButton21.IdleCornerRadius = 20
        Me.BunifuThinButton21.IdleFillColor = System.Drawing.Color.White
        Me.BunifuThinButton21.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton21.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton21.Location = New System.Drawing.Point(593, 355)
        Me.BunifuThinButton21.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton21.Name = "BunifuThinButton21"
        Me.BunifuThinButton21.Size = New System.Drawing.Size(177, 88)
        Me.BunifuThinButton21.TabIndex = 149
        Me.BunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.lblTime})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 473)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(857, 22)
        Me.StatusStrip1.TabIndex = 150
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(36, 17)
        Me.ToolStripStatusLabel1.Text = "Time:"
        '
        'lblTime
        '
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(31, 17)
        Me.lblTime.Text = "time"
        '
        'txtdatepaid
        '
        Me.txtdatepaid.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtdatepaid.BackColor = System.Drawing.Color.Transparent
        Me.txtdatepaid.BorderColor = System.Drawing.Color.Silver
        Me.txtdatepaid.BorderRadius = 1
        Me.txtdatepaid.Color = System.Drawing.Color.Silver
        Me.txtdatepaid.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin
        Me.txtdatepaid.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left
        Me.txtdatepaid.DisabledColor = System.Drawing.Color.Gray
        Me.txtdatepaid.DisplayWeekNumbers = False
        Me.txtdatepaid.DPHeight = 0
        Me.txtdatepaid.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.txtdatepaid.FillDatePicker = False
        Me.txtdatepaid.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtdatepaid.ForeColor = System.Drawing.Color.Black
        Me.txtdatepaid.Icon = CType(resources.GetObject("txtdatepaid.Icon"), System.Drawing.Image)
        Me.txtdatepaid.IconColor = System.Drawing.Color.Gray
        Me.txtdatepaid.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right
        Me.txtdatepaid.LeftTextMargin = 5
        Me.txtdatepaid.Location = New System.Drawing.Point(148, 188)
        Me.txtdatepaid.MinimumSize = New System.Drawing.Size(4, 32)
        Me.txtdatepaid.Name = "txtdatepaid"
        Me.txtdatepaid.Size = New System.Drawing.Size(317, 32)
        Me.txtdatepaid.TabIndex = 151
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(51, 275)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 21)
        Me.Label4.TabIndex = 153
        Me.Label4.Text = "Discount"
        Me.Label4.Visible = False
        '
        'txtdiscount
        '
        Me.txtdiscount.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtdiscount.BackColor = System.Drawing.Color.White
        Me.txtdiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdiscount.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtdiscount.Location = New System.Drawing.Point(148, 275)
        Me.txtdiscount.Name = "txtdiscount"
        Me.txtdiscount.ReadOnly = True
        Me.txtdiscount.Size = New System.Drawing.Size(149, 29)
        Me.txtdiscount.TabIndex = 152
        Me.txtdiscount.Text = "0"
        Me.txtdiscount.Visible = False
        '
        'Label34
        '
        Me.Label34.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(549, 329)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(47, 21)
        Me.Label34.TabIndex = 155
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
        Me.ckprint.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.ckprint.Location = New System.Drawing.Point(529, 332)
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
        Me.ckprint.TabIndex = 154
        Me.ckprint.ThreeState = False
        Me.ckprint.ToolTipText = Nothing
        '
        'Label35
        '
        Me.Label35.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(630, 328)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(112, 21)
        Me.Label35.TabIndex = 157
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
        Me.ckprintpreview.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.ckprintpreview.Location = New System.Drawing.Point(610, 331)
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
        Me.ckprintpreview.TabIndex = 156
        Me.ckprintpreview.ThreeState = False
        Me.ckprintpreview.ToolTipText = Nothing
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(519, 369)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(40, 21)
        Me.Label12.TabIndex = 159
        Me.Label12.Text = "Roll"
        '
        'tkroll
        '
        Me.tkroll.AllowBindingControlAnimation = True
        Me.tkroll.AllowBindingControlColorChanges = False
        Me.tkroll.AllowBindingControlLocation = True
        Me.tkroll.AllowCheckBoxAnimation = False
        Me.tkroll.AllowCheckmarkAnimation = True
        Me.tkroll.AllowOnHoverStates = True
        Me.tkroll.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tkroll.AutoCheck = True
        Me.tkroll.BackColor = System.Drawing.Color.Transparent
        Me.tkroll.BackgroundImage = CType(resources.GetObject("tkroll.BackgroundImage"), System.Drawing.Image)
        Me.tkroll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tkroll.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right
        Me.tkroll.BorderRadius = 12
        Me.tkroll.Checked = False
        Me.tkroll.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Unchecked
        Me.tkroll.Cursor = System.Windows.Forms.Cursors.Default
        Me.tkroll.CustomCheckmarkImage = Nothing
        Me.tkroll.Location = New System.Drawing.Point(499, 372)
        Me.tkroll.MinimumSize = New System.Drawing.Size(17, 17)
        Me.tkroll.Name = "tkroll"
        Me.tkroll.OnCheck.BorderColor = System.Drawing.Color.DodgerBlue
        Me.tkroll.OnCheck.BorderRadius = 12
        Me.tkroll.OnCheck.BorderThickness = 2
        Me.tkroll.OnCheck.CheckBoxColor = System.Drawing.Color.DodgerBlue
        Me.tkroll.OnCheck.CheckmarkColor = System.Drawing.Color.White
        Me.tkroll.OnCheck.CheckmarkThickness = 2
        Me.tkroll.OnDisable.BorderColor = System.Drawing.Color.LightGray
        Me.tkroll.OnDisable.BorderRadius = 12
        Me.tkroll.OnDisable.BorderThickness = 2
        Me.tkroll.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent
        Me.tkroll.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray
        Me.tkroll.OnDisable.CheckmarkThickness = 2
        Me.tkroll.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tkroll.OnHoverChecked.BorderRadius = 12
        Me.tkroll.OnHoverChecked.BorderThickness = 2
        Me.tkroll.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tkroll.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White
        Me.tkroll.OnHoverChecked.CheckmarkThickness = 2
        Me.tkroll.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tkroll.OnHoverUnchecked.BorderRadius = 12
        Me.tkroll.OnHoverUnchecked.BorderThickness = 1
        Me.tkroll.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent
        Me.tkroll.OnUncheck.BorderColor = System.Drawing.Color.DarkGray
        Me.tkroll.OnUncheck.BorderRadius = 12
        Me.tkroll.OnUncheck.BorderThickness = 1
        Me.tkroll.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent
        Me.tkroll.Size = New System.Drawing.Size(17, 17)
        Me.tkroll.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu
        Me.tkroll.TabIndex = 158
        Me.tkroll.ThreeState = False
        Me.tkroll.ToolTipText = Nothing
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(524, 399)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(30, 21)
        Me.Label14.TabIndex = 161
        Me.Label14.Text = "A5"
        '
        'tkA5
        '
        Me.tkA5.AllowBindingControlAnimation = True
        Me.tkA5.AllowBindingControlColorChanges = False
        Me.tkA5.AllowBindingControlLocation = True
        Me.tkA5.AllowCheckBoxAnimation = False
        Me.tkA5.AllowCheckmarkAnimation = True
        Me.tkA5.AllowOnHoverStates = True
        Me.tkA5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tkA5.AutoCheck = True
        Me.tkA5.BackColor = System.Drawing.Color.Transparent
        Me.tkA5.BackgroundImage = CType(resources.GetObject("tkA5.BackgroundImage"), System.Drawing.Image)
        Me.tkA5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tkA5.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right
        Me.tkA5.BorderRadius = 12
        Me.tkA5.Checked = True
        Me.tkA5.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Checked
        Me.tkA5.Cursor = System.Windows.Forms.Cursors.Default
        Me.tkA5.CustomCheckmarkImage = Nothing
        Me.tkA5.Location = New System.Drawing.Point(500, 402)
        Me.tkA5.MinimumSize = New System.Drawing.Size(17, 17)
        Me.tkA5.Name = "tkA5"
        Me.tkA5.OnCheck.BorderColor = System.Drawing.Color.DodgerBlue
        Me.tkA5.OnCheck.BorderRadius = 12
        Me.tkA5.OnCheck.BorderThickness = 2
        Me.tkA5.OnCheck.CheckBoxColor = System.Drawing.Color.DodgerBlue
        Me.tkA5.OnCheck.CheckmarkColor = System.Drawing.Color.White
        Me.tkA5.OnCheck.CheckmarkThickness = 2
        Me.tkA5.OnDisable.BorderColor = System.Drawing.Color.LightGray
        Me.tkA5.OnDisable.BorderRadius = 12
        Me.tkA5.OnDisable.BorderThickness = 2
        Me.tkA5.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent
        Me.tkA5.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray
        Me.tkA5.OnDisable.CheckmarkThickness = 2
        Me.tkA5.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tkA5.OnHoverChecked.BorderRadius = 12
        Me.tkA5.OnHoverChecked.BorderThickness = 2
        Me.tkA5.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tkA5.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White
        Me.tkA5.OnHoverChecked.CheckmarkThickness = 2
        Me.tkA5.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tkA5.OnHoverUnchecked.BorderRadius = 12
        Me.tkA5.OnHoverUnchecked.BorderThickness = 1
        Me.tkA5.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent
        Me.tkA5.OnUncheck.BorderColor = System.Drawing.Color.DarkGray
        Me.tkA5.OnUncheck.BorderRadius = 12
        Me.tkA5.OnUncheck.BorderThickness = 1
        Me.tkA5.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent
        Me.tkA5.Size = New System.Drawing.Size(17, 17)
        Me.tkA5.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu
        Me.tkA5.TabIndex = 160
        Me.tkA5.ThreeState = False
        Me.tkA5.ToolTipText = Nothing
        '
        'RecieveCustomerPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(857, 495)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.tkA5)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.tkroll)
        Me.Controls.Add(Me.Label35)
        Me.Controls.Add(Me.ckprintpreview)
        Me.Controls.Add(Me.Label34)
        Me.Controls.Add(Me.ckprint)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtdiscount)
        Me.Controls.Add(Me.txtdatepaid)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.BunifuThinButton21)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblCustID)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtRecievedBy)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtRecieptNo)
        Me.Controls.Add(Me.cbPaymentMode)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cbType)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtNarration)
        Me.Controls.Add(Me.lblNewBal)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtAmtPaid)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblCustBal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbCustName)
        Me.Controls.Add(Me.Label13)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "RecieveCustomerPayment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RecieveCustomerPayment"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblCustBal As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtAmtPaid As TextBox
    Friend WithEvents lblNewBal As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtNarration As TextBox
    Friend WithEvents cbType As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cbPaymentMode As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtRecieptNo As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtRecievedBy As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents cbCustName As ComboBox
    Friend WithEvents lblCustID As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BunifuThinButton21 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents lblTime As ToolStripStatusLabel
    Friend WithEvents BunifuThinButton22 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents txtdatepaid As Bunifu.UI.WinForms.BunifuDatePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents txtdiscount As TextBox
    Friend WithEvents Label34 As Label
    Friend WithEvents ckprint As Bunifu.UI.WinForms.BunifuCheckBox
    Friend WithEvents Label35 As Label
    Friend WithEvents ckprintpreview As Bunifu.UI.WinForms.BunifuCheckBox
    Friend WithEvents lblpaymentid As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents tkroll As Bunifu.UI.WinForms.BunifuCheckBox
    Friend WithEvents Label14 As Label
    Friend WithEvents tkA5 As Bunifu.UI.WinForms.BunifuCheckBox
End Class
