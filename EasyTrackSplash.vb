
Public Class EasyTrackSplash

    Private Sub EasyTrackSplash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Timer1.Enabled = True
        startProgress.Increment(1)
        Dim per As String
        per = Convert.ToString(startProgress.Value)
        lblStartPercentage.Text = per + "%"
        If startProgress.Value = 100 Then
            Dim f2 As New Login
            f2.Show()
            Me.Hide()
            Timer1.Enabled = False
        End If
    End Sub

End Class