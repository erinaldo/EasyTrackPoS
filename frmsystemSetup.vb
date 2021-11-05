Public Class frmsystemSetup
    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        frmUserProfilemgmt.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        frmMain.Show()
        Me.Hide()
    End Sub
End Class