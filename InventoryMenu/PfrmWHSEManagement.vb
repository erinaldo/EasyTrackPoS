Public Class PfrmWHSEManagement
    Private Sub BunifuButton3_Click(sender As Object, e As EventArgs) Handles BunifuButton3.Click
        Dim f2 As New frmCreateWHSE
        With f2
            .TopLevel = False
            PCreateProd.Controls.Add(f2)
            .BringToFront()
            .Show()

        End With
    End Sub

    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles BunifuButton1.Click
        Dim f2 As New frmWarehouseRecieve
        With f2
            .TopLevel = False
            PCreateProd.Controls.Add(f2)
            .BringToFront()
            .Show()

        End With
    End Sub

    Private Sub BunifuButton4_Click(sender As Object, e As EventArgs) Handles BunifuButton4.Click
        Dim f2 As New frmWHSEIssue
        With f2
            .TopLevel = False
            PCreateProd.Controls.Add(f2)
            .BringToFront()
            .Show()

        End With
    End Sub

    Private Sub BunifuButton2_Click(sender As Object, e As EventArgs) Handles BunifuButton2.Click
        frmMain.Show()
        Me.Hide()
    End Sub
End Class