Public Class frmSuppliersMenu
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)
        Dim f2 As New frmMain
        f2.Show()
        Me.Hide()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)
        Dim f2 As New frmCreateSupplierAccount
        f2.Show()
        Me.Hide()

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)
        Dim f2 As New frmPaySupplierBill
        f2.Show()
        Me.Hide()

    End Sub

    Private Sub BunifuButton3_Click(sender As Object, e As EventArgs) Handles BunifuButton3.Click
        Dim f2 As New frmCreateSupplierAccount
        With f2
            .TopLevel = False
            PCreateProd.Controls.Add(f2)
            .BringToFront()
            .Show()

        End With
    End Sub

    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles BunifuButton1.Click
        Dim f2 As New frmModifySupplier
        With f2
            .TopLevel = False
            PCreateProd.Controls.Add(f2)
            .BringToFront()
            .Show()

        End With
    End Sub

    Private Sub BunifuButton4_Click(sender As Object, e As EventArgs) Handles BunifuButton4.Click
        Dim f2 As New frmPaySupplierBill
        With f2
            .TopLevel = False
            PCreateProd.Controls.Add(f2)
            .BringToFront()
            .Show()

        End With
    End Sub

    Private Sub frmSuppliersMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MaximumSize = Screen.FromRectangle(Me.Bounds).WorkingArea.Size
        WindowState = FormWindowState.Maximized
        settings()
    End Sub
    Private Sub settings()
        BunifuButton3.Enabled = My.Settings.CreateCS
        BunifuButton4.Enabled = My.Settings.RecieveCS
        BunifuButton1.Enabled = My.Settings.DeleteCS
    End Sub

    Private Sub BunifuButton2_Click(sender As Object, e As EventArgs) Handles BunifuButton2.Click
        frmMain.Show()
        Me.Hide()
    End Sub
End Class