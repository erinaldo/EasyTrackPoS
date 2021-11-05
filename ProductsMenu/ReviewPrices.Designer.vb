<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReviewPrices
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
        Me.txtNewWPrice = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtOldRPrice = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtStockCode = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtOldWPrice = New System.Windows.Forms.TextBox()
        Me.txtNewRPrice = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.gvStock = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.gvStock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNewWPrice
        '
        Me.txtNewWPrice.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtNewWPrice.Location = New System.Drawing.Point(188, 259)
        Me.txtNewWPrice.Name = "txtNewWPrice"
        Me.txtNewWPrice.Size = New System.Drawing.Size(140, 20)
        Me.txtNewWPrice.TabIndex = 67
        '
        'Label8
        '
        Me.Label8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(31, 258)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(143, 19)
        Me.Label8.TabIndex = 66
        Me.Label8.Text = "New Whosale price"
        '
        'txtOldRPrice
        '
        Me.txtOldRPrice.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtOldRPrice.Enabled = False
        Me.txtOldRPrice.Location = New System.Drawing.Point(188, 146)
        Me.txtOldRPrice.Name = "txtOldRPrice"
        Me.txtOldRPrice.Size = New System.Drawing.Size(140, 20)
        Me.txtOldRPrice.TabIndex = 65
        '
        'Label7
        '
        Me.Label7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(48, 150)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(117, 19)
        Me.Label7.TabIndex = 64
        Me.Label7.Text = "Old Retail Price"
        '
        'Label17
        '
        Me.Label17.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.SystemColors.Control
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(57, 68)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(83, 19)
        Me.Label17.TabIndex = 63
        Me.Label17.Text = "Item Code"
        '
        'txtStockCode
        '
        Me.txtStockCode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtStockCode.Font = New System.Drawing.Font("Tahoma", 24.0!)
        Me.txtStockCode.Location = New System.Drawing.Point(37, 88)
        Me.txtStockCode.Name = "txtStockCode"
        Me.txtStockCode.Size = New System.Drawing.Size(308, 46)
        Me.txtStockCode.TabIndex = 62
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Button1.Location = New System.Drawing.Point(123, 314)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 67)
        Me.Button1.TabIndex = 61
        Me.Button1.Text = "Update"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtOldWPrice
        '
        Me.txtOldWPrice.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtOldWPrice.Enabled = False
        Me.txtOldWPrice.Location = New System.Drawing.Point(188, 224)
        Me.txtOldWPrice.Name = "txtOldWPrice"
        Me.txtOldWPrice.Size = New System.Drawing.Size(140, 20)
        Me.txtOldWPrice.TabIndex = 60
        '
        'txtNewRPrice
        '
        Me.txtNewRPrice.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtNewRPrice.Location = New System.Drawing.Point(188, 175)
        Me.txtNewRPrice.Name = "txtNewRPrice"
        Me.txtNewRPrice.Size = New System.Drawing.Size(140, 20)
        Me.txtNewRPrice.TabIndex = 59
        '
        'Label13
        '
        Me.Label13.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.SystemColors.Control
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(31, 224)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(137, 19)
        Me.Label13.TabIndex = 58
        Me.Label13.Text = "Old Whosale price"
        '
        'Label12
        '
        Me.Label12.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.SystemColors.Control
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(48, 179)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(123, 19)
        Me.Label12.TabIndex = 57
        Me.Label12.Text = "New Retail Price"
        '
        'gvStock
        '
        Me.gvStock.AllowUserToOrderColumns = True
        Me.gvStock.AllowUserToResizeColumns = False
        Me.gvStock.AllowUserToResizeRows = False
        Me.gvStock.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gvStock.BackgroundColor = System.Drawing.Color.Silver
        Me.gvStock.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.gvStock.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.gvStock.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.gvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gvStock.GridColor = System.Drawing.Color.DarkRed
        Me.gvStock.Location = New System.Drawing.Point(413, 43)
        Me.gvStock.Name = "gvStock"
        Me.gvStock.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.gvStock.RowHeadersVisible = False
        Me.gvStock.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.gvStock.RowTemplate.Height = 25
        Me.gvStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gvStock.Size = New System.Drawing.Size(302, 360)
        Me.gvStock.TabIndex = 56
        '
        'Label6
        '
        Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 24.0!)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(48, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(203, 39)
        Me.Label6.TabIndex = 68
        Me.Label6.Text = "Change Price"
        '
        'frmReviewPrices
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(736, 419)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtNewWPrice)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtOldRPrice)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txtStockCode)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtOldWPrice)
        Me.Controls.Add(Me.txtNewRPrice)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.gvStock)
        Me.Name = "frmReviewPrices"
        Me.Text = "ReviewPrices"
        CType(Me.gvStock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNewWPrice As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtOldRPrice As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents txtStockCode As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents txtOldWPrice As TextBox
    Friend WithEvents txtNewRPrice As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents gvStock As DataGridView
    Friend WithEvents Label6 As Label
End Class
