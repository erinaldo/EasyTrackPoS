Public Class frmReportMenu
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim f As New frmMain
        f.Show()
        Me.Hide()

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Dim f2 As New InventoryReportMenu
        f2.Show()
        Me.Hide()

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Dim f2 As New SalesReportMenu
        f2.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2PictureBox1_Click(sender As Object, e As EventArgs) 
        Application.Exit()
    End Sub

    Private Sub Guna2PictureBox2_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        frmMain.Show()
        Me.Hide()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Dim f2 As New frmProdReports
        f2.Show()

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Dim f2 As New frmSessionLedger
        f2.Show()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

        frmAdjustStockReportMenu.Show()
        Me.Hide()

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        Dim f2 As New frmSupplierReportMenu
        f2.Show()
        Me.Hide()

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        frmCustomerReportMenu.Show()
        Me.Hide()

    End Sub
End Class