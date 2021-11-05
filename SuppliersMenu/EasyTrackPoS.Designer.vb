<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EasyTrackPoS
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
        Me.pnlEasytrack = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'pnlEasytrack
        '
        Me.pnlEasytrack.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlEasytrack.Location = New System.Drawing.Point(0, 0)
        Me.pnlEasytrack.Name = "pnlEasytrack"
        Me.pnlEasytrack.Size = New System.Drawing.Size(869, 520)
        Me.pnlEasytrack.TabIndex = 0
        '
        'EasyTrackPoS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(869, 520)
        Me.Controls.Add(Me.pnlEasytrack)
        Me.Name = "EasyTrackPoS"
        Me.Text = "EasyTrackPoS"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlEasytrack As Panel
End Class
