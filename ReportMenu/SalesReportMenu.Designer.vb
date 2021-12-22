<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SalesReportMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SalesReportMenu))
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dpDatefrom = New Bunifu.UI.WinForms.BunifuDatePicker()
        Me.dpdateto = New Bunifu.UI.WinForms.BunifuDatePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(131, 18)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(157, 32)
        Me.Label10.TabIndex = 126
        Me.Label10.Text = "Sales Report"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(175, 364)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(127, 32)
        Me.Label8.TabIndex = 121
        Me.Label8.Text = "Per Brand"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(177, 317)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 32)
        Me.Label3.TabIndex = 119
        Me.Label3.Text = "Per Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(167, 165)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 32)
        Me.Label2.TabIndex = 118
        Me.Label2.Text = "Per Cashier"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(154, 417)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(171, 32)
        Me.Label1.TabIndex = 117
        Me.Label1.Text = "Price Change "
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(17, 17)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(41, 42)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 116
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Peru
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(529, 82)
        Me.Panel1.TabIndex = 127
        '
        'dpDatefrom
        '
        Me.dpDatefrom.BackColor = System.Drawing.Color.Transparent
        Me.dpDatefrom.BorderColor = System.Drawing.Color.Silver
        Me.dpDatefrom.BorderRadius = 1
        Me.dpDatefrom.Color = System.Drawing.Color.Silver
        Me.dpDatefrom.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin
        Me.dpDatefrom.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left
        Me.dpDatefrom.DisabledColor = System.Drawing.Color.Gray
        Me.dpDatefrom.DisplayWeekNumbers = False
        Me.dpDatefrom.DPHeight = 0
        Me.dpDatefrom.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dpDatefrom.FillDatePicker = False
        Me.dpDatefrom.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dpDatefrom.ForeColor = System.Drawing.Color.Black
        Me.dpDatefrom.Icon = CType(resources.GetObject("dpDatefrom.Icon"), System.Drawing.Image)
        Me.dpDatefrom.IconColor = System.Drawing.Color.Gray
        Me.dpDatefrom.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right
        Me.dpDatefrom.LeftTextMargin = 5
        Me.dpDatefrom.Location = New System.Drawing.Point(61, 106)
        Me.dpDatefrom.MinimumSize = New System.Drawing.Size(4, 32)
        Me.dpDatefrom.Name = "dpDatefrom"
        Me.dpDatefrom.Size = New System.Drawing.Size(161, 32)
        Me.dpDatefrom.TabIndex = 128
        Me.dpDatefrom.Value = New Date(2021, 12, 13, 0, 0, 0, 0)
        '
        'dpdateto
        '
        Me.dpdateto.BackColor = System.Drawing.Color.Transparent
        Me.dpdateto.BorderColor = System.Drawing.Color.Silver
        Me.dpdateto.BorderRadius = 1
        Me.dpdateto.Color = System.Drawing.Color.Silver
        Me.dpdateto.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin
        Me.dpdateto.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left
        Me.dpdateto.DisabledColor = System.Drawing.Color.Gray
        Me.dpdateto.DisplayWeekNumbers = False
        Me.dpdateto.DPHeight = 0
        Me.dpdateto.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dpdateto.FillDatePicker = False
        Me.dpdateto.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dpdateto.ForeColor = System.Drawing.Color.Black
        Me.dpdateto.Icon = CType(resources.GetObject("dpdateto.Icon"), System.Drawing.Image)
        Me.dpdateto.IconColor = System.Drawing.Color.Gray
        Me.dpdateto.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right
        Me.dpdateto.LeftTextMargin = 5
        Me.dpdateto.Location = New System.Drawing.Point(294, 106)
        Me.dpdateto.MinimumSize = New System.Drawing.Size(4, 32)
        Me.dpdateto.Name = "dpdateto"
        Me.dpdateto.Size = New System.Drawing.Size(157, 32)
        Me.dpdateto.TabIndex = 129
        Me.dpdateto.Value = New Date(2021, 12, 13, 0, 0, 0, 0)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(177, 265)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 32)
        Me.Label4.TabIndex = 130
        Me.Label4.Text = "Per Item"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(142, 215)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(204, 32)
        Me.Label5.TabIndex = 118
        Me.Label5.Text = "Per Cashier(Roll)"
        '
        'SalesReportMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(522, 480)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dpdateto)
        Me.Controls.Add(Me.dpDatefrom)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SalesReportMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SalesReportMenu"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents dpDatefrom As Bunifu.UI.WinForms.BunifuDatePicker
    Friend WithEvents dpdateto As Bunifu.UI.WinForms.BunifuDatePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
