Imports System.Security.Principal
Public Class frmMain

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MaximumSize = Screen.FromRectangle(Me.Bounds).WorkingArea.Size
        WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim f2 As New frmProductManagementMenu
        f2.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Dim f4 As New frmInventoryManagement
        f4.Show()
        Me.Hide()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Dim f5 As New frmSalesManagement
        f5.Show()
        Me.Hide()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs)
        Dim f1 As New Login
        f1.Show()
        Me.Hide()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)
        Dim f2 As New pfrmProductManagement
        f2.Show()
        With Dashboard
            .TopLevel = False
            pfrmProductManagement.PCreateProd.Controls.Add(Dashboard)
            .BringToFront()
            .Show()

        End With
        Me.Hide()

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)
        Dim f4 As New PfrmInventoryMgmt
        f4.Show()
        Me.Hide()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)
        Dim f5 As New PfrmSalesMgmt
        f5.Show()
        Me.Hide()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)
        Dim f1 As New Login
        f1.Show()
        Me.Hide()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs)
        Dim f2 As New frmSuppliersMenu
        f2.Show()
        Me.Hide()

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)
        Dim f2 As New PfrmCustomer
        f2.Show()
        Me.Hide()

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs)
        PfrmUserSetup.Show()
        Me.Hide()

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs)

        frmReportMenu.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2PictureBox1_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox1.Click
        Application.Exit()
    End Sub

    Private Sub Guna2PictureBox2_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox2.Click
        If WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Maximized
        ElseIf WindowState = FormWindowState.Maximized Then
            WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles BunifuButton1.Click
        Dim f2 As New pfrmProductManagement
        f2.Show()
        With Dashboard
            .TopLevel = False
            pfrmProductManagement.PCreateProd.Controls.Add(Dashboard)
            .BringToFront()
            .Show()

        End With
        Me.Hide()
    End Sub

    Private Sub BunifuButton2_Click(sender As Object, e As EventArgs) Handles BunifuButton2.Click
        Dim f4 As New PfrmInventoryMgmt
        f4.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuButton3_Click(sender As Object, e As EventArgs) Handles BunifuButton3.Click
        Dim f5 As New PfrmSalesMgmt
        f5.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuButton4_Click(sender As Object, e As EventArgs) Handles BunifuButton4.Click
        'Dim f2 As New NewReport
        'f2.Show()
        ' NewReport.Show()
        frmReportMenu.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuButton5_Click(sender As Object, e As EventArgs) Handles BunifuButton5.Click
        Dim f2 As New PfrmCustomer
        f2.Show()
        Me.Hide()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2PictureBox9_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BunifuButton7_Click(sender As Object, e As EventArgs) Handles BunifuButton7.Click
        frmSuppliersMenu.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuButton8_Click(sender As Object, e As EventArgs) Handles BunifuButton8.Click
        PfrmUserSetup.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuButton9_Click(sender As Object, e As EventArgs) Handles BunifuButton9.Click
        Dim f1 As New Login
        f1.Show()
        Me.Hide()
    End Sub

    Private Sub Label7_Click_1(sender As Object, e As EventArgs) Handles Label7.Click
        Dim f1 As New frmTouchSale
        f1.Show()
        'Me.Hide()
    End Sub

    Private Sub BunifuButton6_Click(sender As Object, e As EventArgs) Handles BunifuButton6.Click
        MsgBox("Contact your Service Providers")
    End Sub


    Private Sub BunifuButton10_Click_1(sender As Object, e As EventArgs)
        Dim f1 As New SuppliersOders
        f1.Show()
        ' Me.Hide()
    End Sub
End Class
