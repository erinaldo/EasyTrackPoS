Public Class PfrmUserSetup
    Private Sub Label3_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)
        frmMain.Show()
        Me.Hide()

    End Sub

    Private Sub PfrmUserSetup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MaximumSize = Screen.FromRectangle(Me.Bounds).WorkingArea.Size
        WindowState = FormWindowState.Maximized
    End Sub

    Private Sub BunifuButton3_Click(sender As Object, e As EventArgs) Handles BunifuButton3.Click, BunifuButton3.Click
        With frmUserProfilemgmt
            .TopLevel = False
            PUserProfile.Controls.Add(frmUserProfilemgmt)
            .BringToFront()
            .Show()

        End With
    End Sub

    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles BunifuButton1.Click
        With frmClientReg
            .TopLevel = False
            PUserProfile.Controls.Add(frmClientReg)
            .BringToFront()
            .Show()

        End With
    End Sub

    Private Sub BunifuButton2_Click(sender As Object, e As EventArgs) Handles BunifuButton2.Click
        frmMain.Show()
        Me.Hide()

    End Sub

    Private Sub BunifuButton4_Click(sender As Object, e As EventArgs) Handles BunifuButton4.Click
        Dim f2 As New frmMessagingSetup
        With f2
            .TopLevel = False
            PUserProfile.Controls.Add(f2)
            .BringToFront()
            .Show()

        End With
    End Sub
End Class