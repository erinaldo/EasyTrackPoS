<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StockRecievedReportMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StockRecievedReportMenu))
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dpFrom = New Bunifu.UI.WinForms.BunifuDatePicker()
        Me.dpto = New Bunifu.UI.WinForms.BunifuDatePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.BunifuPanel1 = New Bunifu.UI.WinForms.BunifuPanel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Peru
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(162, 23)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(269, 32)
        Me.Label10.TabIndex = 126
        Me.Label10.Text = "Stock Recieved Report"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(78, 305)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(127, 32)
        Me.Label8.TabIndex = 121
        Me.Label8.Text = "Per Brand"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(78, 137)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(163, 32)
        Me.Label2.TabIndex = 118
        Me.Label2.Text = "Per Category"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(248, 400)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 32)
        Me.Label1.TabIndex = 117
        Me.Label1.Text = "Overall"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Peru
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(13, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(41, 42)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 116
        Me.PictureBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(370, 137)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(142, 32)
        Me.Label5.TabIndex = 130
        Me.Label5.Text = "Per Invoice"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(361, 305)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(154, 32)
        Me.Label6.TabIndex = 129
        Me.Label6.Text = "Per Supplier"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(85, 219)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 32)
        Me.Label7.TabIndex = 128
        Me.Label7.Text = "Per Date"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(390, 219)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(111, 32)
        Me.Label9.TabIndex = 127
        Me.Label9.Text = "Per Item"
        '
        'dpFrom
        '
        Me.dpFrom.BackColor = System.Drawing.Color.Transparent
        Me.dpFrom.BorderColor = System.Drawing.Color.Silver
        Me.dpFrom.BorderRadius = 1
        Me.dpFrom.Color = System.Drawing.Color.Silver
        Me.dpFrom.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin
        Me.dpFrom.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left
        Me.dpFrom.DisabledColor = System.Drawing.Color.Gray
        Me.dpFrom.DisplayWeekNumbers = False
        Me.dpFrom.DPHeight = 0
        Me.dpFrom.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dpFrom.FillDatePicker = False
        Me.dpFrom.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dpFrom.ForeColor = System.Drawing.Color.Black
        Me.dpFrom.Icon = CType(resources.GetObject("dpFrom.Icon"), System.Drawing.Image)
        Me.dpFrom.IconColor = System.Drawing.Color.Gray
        Me.dpFrom.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right
        Me.dpFrom.LeftTextMargin = 5
        Me.dpFrom.Location = New System.Drawing.Point(122, 92)
        Me.dpFrom.MinimumSize = New System.Drawing.Size(4, 32)
        Me.dpFrom.Name = "dpFrom"
        Me.dpFrom.Size = New System.Drawing.Size(169, 32)
        Me.dpFrom.TabIndex = 131
        Me.dpFrom.Value = New Date(2022, 1, 23, 0, 0, 0, 0)
        '
        'dpto
        '
        Me.dpto.BackColor = System.Drawing.Color.Transparent
        Me.dpto.BorderColor = System.Drawing.Color.Silver
        Me.dpto.BorderRadius = 1
        Me.dpto.Color = System.Drawing.Color.Silver
        Me.dpto.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin
        Me.dpto.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left
        Me.dpto.DisabledColor = System.Drawing.Color.Gray
        Me.dpto.DisplayWeekNumbers = False
        Me.dpto.DPHeight = 0
        Me.dpto.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dpto.FillDatePicker = False
        Me.dpto.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dpto.ForeColor = System.Drawing.Color.Black
        Me.dpto.Icon = CType(resources.GetObject("dpto.Icon"), System.Drawing.Image)
        Me.dpto.IconColor = System.Drawing.Color.Gray
        Me.dpto.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right
        Me.dpto.LeftTextMargin = 5
        Me.dpto.Location = New System.Drawing.Point(358, 92)
        Me.dpto.MinimumSize = New System.Drawing.Size(4, 32)
        Me.dpto.Name = "dpto"
        Me.dpto.Size = New System.Drawing.Size(169, 32)
        Me.dpto.TabIndex = 132
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(68, 100)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(52, 21)
        Me.Label12.TabIndex = 134
        Me.Label12.Text = "From:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(311, 98)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(31, 21)
        Me.Label13.TabIndex = 135
        Me.Label13.Text = "To:"
        '
        'BunifuPanel1
        '
        Me.BunifuPanel1.BackgroundColor = System.Drawing.Color.Peru
        Me.BunifuPanel1.BackgroundImage = CType(resources.GetObject("BunifuPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuPanel1.BorderColor = System.Drawing.Color.Transparent
        Me.BunifuPanel1.BorderRadius = 3
        Me.BunifuPanel1.BorderThickness = 1
        Me.BunifuPanel1.Controls.Add(Me.PictureBox1)
        Me.BunifuPanel1.Controls.Add(Me.Label10)
        Me.BunifuPanel1.Location = New System.Drawing.Point(-1, -4)
        Me.BunifuPanel1.Name = "BunifuPanel1"
        Me.BunifuPanel1.ShowBorders = True
        Me.BunifuPanel1.Size = New System.Drawing.Size(637, 71)
        Me.BunifuPanel1.TabIndex = 136
        '
        'StockRecievedReportMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(635, 471)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.dpto)
        Me.Controls.Add(Me.dpFrom)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BunifuPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "StockRecievedReportMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "StockRecievedReportMenu"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuPanel1.ResumeLayout(False)
        Me.BunifuPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents dpFrom As Bunifu.UI.WinForms.BunifuDatePicker
    Friend WithEvents dpto As Bunifu.UI.WinForms.BunifuDatePicker
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents BunifuPanel1 As Bunifu.UI.WinForms.BunifuPanel
End Class
