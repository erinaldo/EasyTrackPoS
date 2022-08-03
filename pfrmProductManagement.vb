Public Class pfrmProductManagement
    Private Sub pfrmProductManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MaximumSize = Screen.FromRectangle(Me.Bounds).WorkingArea.Size
        WindowState = FormWindowState.Maximized
        'setttings()
    End Sub

    Private Sub btnCat_Click(sender As Object, e As EventArgs)
        Dim f2 As New frmProdCatCreation
        With f2
            .TopLevel = False
            PCreateProd.Controls.Add(f2)
            .BringToFront()
            .Show()

        End With
    End Sub

    Private Sub btnPline_Click(sender As Object, e As EventArgs)
        Dim f2 As New frmPackages
        With f2
            .TopLevel = False
            PCreateProd.Controls.Add(f2)
            .BringToFront()
            .Show()

        End With
    End Sub

    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles BunifuButton1.Click
        With Dashboard
            .TopLevel = False
            PCreateProd.Controls.Add(Dashboard)
            .BringToFront()
            .Show()

        End With
    End Sub

    Private Sub BunifuButton2_Click(sender As Object, e As EventArgs) Handles btncreateprod.Click
        Dim f2 As New frmProdCreate
        With f2
            .TopLevel = False
            PCreateProd.Controls.Add(f2)
            .BringToFront()
            .Show()

        End With
    End Sub

    Private Sub BunifuButton3_Click(sender As Object, e As EventArgs) Handles btnmodprod.Click
        Dim f2 As New frmModifyProduct
        With f2
            .TopLevel = False
            PCreateProd.Controls.Add(f2)
            .BringToFront()
            .Show()

        End With
    End Sub

    Private Sub BunifuButton4_Click(sender As Object, e As EventArgs) Handles btnchprice.Click
        Dim f2 As New frmChangePrice
        With f2
            .TopLevel = False
            PCreateProd.Controls.Add(f2)
            .BringToFront()
            .Show()

        End With
    End Sub

    Private Sub BunifuButton5_Click(sender As Object, e As EventArgs) Handles btndelprod.Click
        Dim f2 As New frmDeleteProduct
        With f2
            .TopLevel = False
            PCreateProd.Controls.Add(f2)
            .BringToFront()
            .Show()

        End With
    End Sub

    Private Sub BunifuButton8_Click(sender As Object, e As EventArgs) Handles BunifuButton8.Click
        Dim f2 As New frmPackages
        With f2
            .TopLevel = False
            PCreateProd.Controls.Add(f2)
            .BringToFront()
            .Show()

        End With
    End Sub

    Private Sub BunifuButton9_Click(sender As Object, e As EventArgs) Handles BunifuButton9.Click
        frmMain.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuButton7_Click(sender As Object, e As EventArgs) 
        Dim f2 As New frmProdCatCreation
        With f2
            .TopLevel = False
            PCreateProd.Controls.Add(f2)
            .BringToFront()
            .Show()

        End With
    End Sub

    Private Sub BunifuButton10_Click(sender As Object, e As EventArgs) Handles BunifuButton10.Click
        Dim f2 As New frmPriceBand
        With f2
            .TopLevel = False
            PCreateProd.Controls.Add(f2)
            .BringToFront()
            .Show()

        End With
    End Sub

    Private Sub BunifuButton11_Click(sender As Object, e As EventArgs) Handles BunifuButton11.Click
        Dim f2 As New frmBarcodeGen
        With f2
            .TopLevel = False
            PCreateProd.Controls.Add(f2)
            .BringToFront()
            .Show()

        End With
    End Sub
    Private Sub setttings()
        btncreateprod.Enabled = My.Settings.createprod
        btnmodprod.Enabled = My.Settings.modprod
        btndelprod.Enabled = My.Settings.delprod
        'btnchprice.Enabled = My.Settings.changeprice
    End Sub

End Class