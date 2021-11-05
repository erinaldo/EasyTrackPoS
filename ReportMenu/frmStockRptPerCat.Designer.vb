<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStockRptPerCat
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
        Me.rvStockPerCat = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.rptStockPerCat1 = New HardSoft_PoS.rptStockPerCat()
        Me.SuspendLayout()
        '
        'rvStockPerCat
        '
        Me.rvStockPerCat.ActiveViewIndex = 0
        Me.rvStockPerCat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rvStockPerCat.Cursor = System.Windows.Forms.Cursors.Default
        Me.rvStockPerCat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rvStockPerCat.Location = New System.Drawing.Point(0, 0)
        Me.rvStockPerCat.Name = "rvStockPerCat"
        Me.rvStockPerCat.ReportSource = Me.rptStockPerCat1
        Me.rvStockPerCat.Size = New System.Drawing.Size(800, 450)
        Me.rvStockPerCat.TabIndex = 0
        '
        'frmStockRptPerCat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.rvStockPerCat)
        Me.Name = "frmStockRptPerCat"
        Me.Text = "frmStockRptPerCat"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents rvStockPerCat As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents rptStockPerCat1 As rptStockPerCat
End Class
