<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomerbalanceRevaluation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCustomerbalanceRevaluation))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblcustid = New System.Windows.Forms.Label()
        Me.BunifuThinButton22 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.txtdatepaid = New Bunifu.UI.WinForms.BunifuDatePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtAmtPaid = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblCustBal = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbCustName = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblnewbalance = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BunifuThinButton21 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNarration = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Teal
        Me.Panel1.Controls.Add(Me.lblcustid)
        Me.Panel1.Controls.Add(Me.BunifuThinButton22)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(652, 61)
        Me.Panel1.TabIndex = 149
        '
        'lblcustid
        '
        Me.lblcustid.AutoSize = True
        Me.lblcustid.Location = New System.Drawing.Point(470, 27)
        Me.lblcustid.Name = "lblcustid"
        Me.lblcustid.Size = New System.Drawing.Size(45, 13)
        Me.lblcustid.TabIndex = 152
        Me.lblcustid.Text = "Label12"
        Me.lblcustid.Visible = False
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
        Me.BunifuThinButton22.Location = New System.Drawing.Point(554, 5)
        Me.BunifuThinButton22.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton22.Name = "BunifuThinButton22"
        Me.BunifuThinButton22.Size = New System.Drawing.Size(84, 46)
        Me.BunifuThinButton22.TabIndex = 151
        Me.BunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(0, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(464, 40)
        Me.Label9.TabIndex = 137
        Me.Label9.Text = "Customer Balance Re-evaluation"
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
        Me.txtdatepaid.Location = New System.Drawing.Point(198, 182)
        Me.txtdatepaid.MinimumSize = New System.Drawing.Size(4, 32)
        Me.txtdatepaid.Name = "txtdatepaid"
        Me.txtdatepaid.Size = New System.Drawing.Size(317, 32)
        Me.txtdatepaid.TabIndex = 159
        '
        'Label3
        '
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(95, 225)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 42)
        Me.Label3.TabIndex = 158
        Me.Label3.Text = "   Value " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Difference"
        '
        'txtAmtPaid
        '
        Me.txtAmtPaid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAmtPaid.BackColor = System.Drawing.Color.White
        Me.txtAmtPaid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAmtPaid.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtAmtPaid.Location = New System.Drawing.Point(198, 225)
        Me.txtAmtPaid.Name = "txtAmtPaid"
        Me.txtAmtPaid.Size = New System.Drawing.Size(320, 29)
        Me.txtAmtPaid.TabIndex = 157
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(95, 177)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 42)
        Me.Label2.TabIndex = 156
        Me.Label2.Text = " Date of " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Valuation"
        '
        'lblCustBal
        '
        Me.lblCustBal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCustBal.AutoSize = True
        Me.lblCustBal.Font = New System.Drawing.Font("Segoe UI Black", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblCustBal.Location = New System.Drawing.Point(237, 133)
        Me.lblCustBal.Name = "lblCustBal"
        Me.lblCustBal.Size = New System.Drawing.Size(29, 32)
        Me.lblCustBal.TabIndex = 155
        Me.lblCustBal.Text = "0"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(129, 143)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 21)
        Me.Label1.TabIndex = 154
        Me.Label1.Text = "Balance"
        '
        'cbCustName
        '
        Me.cbCustName.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbCustName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCustName.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.cbCustName.FormattingEnabled = True
        Me.cbCustName.Location = New System.Drawing.Point(195, 97)
        Me.cbCustName.Name = "cbCustName"
        Me.cbCustName.Size = New System.Drawing.Size(320, 33)
        Me.cbCustName.TabIndex = 153
        '
        'Label13
        '
        Me.Label13.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label13.Location = New System.Drawing.Point(108, 103)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(83, 21)
        Me.Label13.TabIndex = 152
        Me.Label13.Text = "Customer"
        '
        'lblnewbalance
        '
        Me.lblnewbalance.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblnewbalance.AutoSize = True
        Me.lblnewbalance.Font = New System.Drawing.Font("Segoe UI Black", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblnewbalance.Location = New System.Drawing.Point(223, 292)
        Me.lblnewbalance.Name = "lblnewbalance"
        Me.lblnewbalance.Size = New System.Drawing.Size(29, 32)
        Me.lblnewbalance.TabIndex = 161
        Me.lblnewbalance.Text = "0"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(86, 303)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 21)
        Me.Label5.TabIndex = 160
        Me.Label5.Text = "New Balance:"
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
        Me.BunifuThinButton21.Location = New System.Drawing.Point(209, 393)
        Me.BunifuThinButton21.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton21.Name = "BunifuThinButton21"
        Me.BunifuThinButton21.Size = New System.Drawing.Size(177, 88)
        Me.BunifuThinButton21.TabIndex = 162
        Me.BunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(98, 342)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 21)
        Me.Label6.TabIndex = 164
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
        Me.txtNarration.Location = New System.Drawing.Point(185, 340)
        Me.txtNarration.Multiline = True
        Me.txtNarration.Name = "txtNarration"
        Me.txtNarration.Size = New System.Drawing.Size(330, 45)
        Me.txtNarration.TabIndex = 163
        '
        'frmCustomerbalanceRevaluation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(652, 485)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtNarration)
        Me.Controls.Add(Me.BunifuThinButton21)
        Me.Controls.Add(Me.lblnewbalance)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtdatepaid)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtAmtPaid)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblCustBal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbCustName)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCustomerbalanceRevaluation"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmCustomerbalanceRevaluation"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblcustid As Label
    Friend WithEvents BunifuThinButton22 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Label9 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents txtdatepaid As Bunifu.UI.WinForms.BunifuDatePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents txtAmtPaid As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblCustBal As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cbCustName As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents lblnewbalance As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents BunifuThinButton21 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Label6 As Label
    Friend WithEvents txtNarration As TextBox
End Class
