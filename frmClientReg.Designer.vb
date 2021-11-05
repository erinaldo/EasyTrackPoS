<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClientReg
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClientReg))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtBranchTel = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBranchName = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtClientName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTradingName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtLocation = New System.Windows.Forms.TextBox()
        Me.pbClientLogo = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.txtClientLogo = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BunifuThinButton22 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.txtBusinessDesc = New System.Windows.Forms.RichTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txttermsoftrade = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCompanyContact = New System.Windows.Forms.TextBox()
        CType(Me.pbClientLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(36, 282)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(151, 21)
        Me.Label3.TabIndex = 115
        Me.Label3.Text = "Branch Telephone "
        '
        'txtBranchTel
        '
        Me.txtBranchTel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtBranchTel.BackColor = System.Drawing.Color.White
        Me.txtBranchTel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBranchTel.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtBranchTel.Location = New System.Drawing.Point(208, 274)
        Me.txtBranchTel.Name = "txtBranchTel"
        Me.txtBranchTel.Size = New System.Drawing.Size(282, 29)
        Me.txtBranchTel.TabIndex = 114
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(71, 188)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 21)
        Me.Label2.TabIndex = 113
        Me.Label2.Text = "Branch Name"
        '
        'txtBranchName
        '
        Me.txtBranchName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtBranchName.BackColor = System.Drawing.Color.White
        Me.txtBranchName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBranchName.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtBranchName.Location = New System.Drawing.Point(208, 180)
        Me.txtBranchName.Name = "txtBranchName"
        Me.txtBranchName.Size = New System.Drawing.Size(282, 29)
        Me.txtBranchName.TabIndex = 112
        '
        'Label13
        '
        Me.Label13.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label13.Location = New System.Drawing.Point(54, 93)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(133, 21)
        Me.Label13.TabIndex = 111
        Me.Label13.Text = "Company Name"
        '
        'txtClientName
        '
        Me.txtClientName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtClientName.BackColor = System.Drawing.Color.White
        Me.txtClientName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtClientName.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtClientName.Location = New System.Drawing.Point(208, 91)
        Me.txtClientName.Name = "txtClientName"
        Me.txtClientName.Size = New System.Drawing.Size(282, 29)
        Me.txtClientName.TabIndex = 110
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(534, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 21)
        Me.Label1.TabIndex = 117
        Me.Label1.Text = "Trading Name"
        '
        'txtTradingName
        '
        Me.txtTradingName.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTradingName.BackColor = System.Drawing.Color.White
        Me.txtTradingName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTradingName.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtTradingName.Location = New System.Drawing.Point(668, 91)
        Me.txtTradingName.Name = "txtTradingName"
        Me.txtTradingName.Size = New System.Drawing.Size(282, 29)
        Me.txtTradingName.TabIndex = 116
        '
        'Label4
        '
        Me.Label4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(572, 143)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 21)
        Me.Label4.TabIndex = 119
        Me.Label4.Text = " Location"
        '
        'TxtLocation
        '
        Me.TxtLocation.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtLocation.BackColor = System.Drawing.Color.White
        Me.TxtLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtLocation.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TxtLocation.Location = New System.Drawing.Point(668, 135)
        Me.TxtLocation.Name = "TxtLocation"
        Me.TxtLocation.Size = New System.Drawing.Size(282, 29)
        Me.TxtLocation.TabIndex = 118
        '
        'pbClientLogo
        '
        Me.pbClientLogo.Location = New System.Drawing.Point(230, 407)
        Me.pbClientLogo.Name = "pbClientLogo"
        Me.pbClientLogo.Size = New System.Drawing.Size(202, 125)
        Me.pbClientLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbClientLogo.TabIndex = 122
        Me.pbClientLogo.TabStop = False
        '
        'Label6
        '
        Me.Label6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(54, 373)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(129, 21)
        Me.Label6.TabIndex = 123
        Me.Label6.Text = "Company Logo:"
        '
        'txtClientLogo
        '
        Me.txtClientLogo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtClientLogo.BackColor = System.Drawing.Color.White
        Me.txtClientLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtClientLogo.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtClientLogo.Location = New System.Drawing.Point(208, 365)
        Me.txtClientLogo.Name = "txtClientLogo"
        Me.txtClientLogo.Size = New System.Drawing.Size(253, 29)
        Me.txtClientLogo.TabIndex = 124
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(467, 365)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(23, 29)
        Me.Button1.TabIndex = 125
        Me.Button1.Text = "....."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BunifuThinButton22
        '
        Me.BunifuThinButton22.ActiveBorderThickness = 1
        Me.BunifuThinButton22.ActiveCornerRadius = 20
        Me.BunifuThinButton22.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton22.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton22.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton22.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuThinButton22.BackColor = System.Drawing.SystemColors.Control
        Me.BunifuThinButton22.BackgroundImage = CType(resources.GetObject("BunifuThinButton22.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton22.ButtonText = "SAVE"
        Me.BunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton22.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton22.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton22.IdleBorderThickness = 1
        Me.BunifuThinButton22.IdleCornerRadius = 20
        Me.BunifuThinButton22.IdleFillColor = System.Drawing.Color.White
        Me.BunifuThinButton22.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton22.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton22.Location = New System.Drawing.Point(687, 448)
        Me.BunifuThinButton22.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.BunifuThinButton22.Name = "BunifuThinButton22"
        Me.BunifuThinButton22.Size = New System.Drawing.Size(224, 84)
        Me.BunifuThinButton22.TabIndex = 147
        Me.BunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtBusinessDesc
        '
        Me.txtBusinessDesc.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBusinessDesc.Location = New System.Drawing.Point(563, 343)
        Me.txtBusinessDesc.Name = "txtBusinessDesc"
        Me.txtBusinessDesc.Size = New System.Drawing.Size(387, 64)
        Me.txtBusinessDesc.TabIndex = 148
        Me.txtBusinessDesc.Text = ""
        '
        'Label7
        '
        Me.Label7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(559, 319)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(167, 21)
        Me.Label7.TabIndex = 149
        Me.Label7.Text = "Business Description"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Location = New System.Drawing.Point(1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(973, 68)
        Me.Panel1.TabIndex = 150
        '
        'Label8
        '
        Me.Label8.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(67, 19)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(309, 40)
        Me.Label8.TabIndex = 151
        Me.Label8.Text = "Business Information"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(539, 246)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(123, 21)
        Me.Label5.TabIndex = 152
        Me.Label5.Text = "Terms Of Trade"
        '
        'txttermsoftrade
        '
        Me.txttermsoftrade.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txttermsoftrade.BackColor = System.Drawing.Color.White
        Me.txttermsoftrade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txttermsoftrade.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txttermsoftrade.Location = New System.Drawing.Point(668, 238)
        Me.txttermsoftrade.Name = "txttermsoftrade"
        Me.txttermsoftrade.Size = New System.Drawing.Size(282, 29)
        Me.txttermsoftrade.TabIndex = 151
        '
        'Label9
        '
        Me.Label9.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(516, 190)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(146, 21)
        Me.Label9.TabIndex = 154
        Me.Label9.Text = "Company Contact"
        '
        'txtCompanyContact
        '
        Me.txtCompanyContact.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCompanyContact.BackColor = System.Drawing.Color.White
        Me.txtCompanyContact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCompanyContact.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtCompanyContact.Location = New System.Drawing.Point(668, 188)
        Me.txtCompanyContact.Name = "txtCompanyContact"
        Me.txtCompanyContact.Size = New System.Drawing.Size(282, 29)
        Me.txtCompanyContact.TabIndex = 153
        '
        'frmClientReg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(974, 544)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtCompanyContact)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txttermsoftrade)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtBusinessDesc)
        Me.Controls.Add(Me.BunifuThinButton22)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtClientLogo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.pbClientLogo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtLocation)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTradingName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtBranchTel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtBranchName)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtClientName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmClientReg"
        Me.Text = "frmClientReg"
        CType(Me.pbClientLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents txtBranchTel As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtBranchName As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtClientName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTradingName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtLocation As TextBox
    Friend WithEvents pbClientLogo As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents txtClientLogo As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents BunifuThinButton22 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents txtBusinessDesc As RichTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txttermsoftrade As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtCompanyContact As TextBox
End Class
