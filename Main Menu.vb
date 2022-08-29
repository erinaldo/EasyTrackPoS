Public Class frmMain

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.MaximumSize = Screen.FromRectangle(Me.Bounds).WorkingArea.Size
        WindowState = FormWindowState.Maximized
        stuser.Text = My.Settings.ActiveUser

        'settings()
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

    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles btnproductmenu.Click

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

    Private Sub BunifuButton2_Click(sender As Object, e As EventArgs) Handles btninvmenu.Click
        Dim f4 As New PfrmInventoryMgmt
        f4.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuButton3_Click(sender As Object, e As EventArgs) Handles btnsalesmenu.Click
        Dim f5 As New PfrmSalesMgmt
        f5.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuButton4_Click(sender As Object, e As EventArgs) Handles btnrptmenu.Click
        'Dim f2 As New NewReport
        'f2.Show()
        ' NewReport.Show()
        frmReportMenu.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuButton5_Click(sender As Object, e As EventArgs) Handles rptcustmenu.Click
        Dim f2 As New PfrmCustomer
        f2.Show()
        Me.Hide()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2PictureBox9_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BunifuButton7_Click(sender As Object, e As EventArgs) Handles btnsuppmenu.Click
        frmSuppliersMenu.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuButton8_Click(sender As Object, e As EventArgs) Handles btnsysmenu.Click
        PfrmUserSetup.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuButton9_Click(sender As Object, e As EventArgs) Handles BunifuButton9.Click
        Dim f1 As New Login
        f1.Show()
        Me.Hide()

    End Sub

    Private Sub Label7_Click_1(sender As Object, e As EventArgs) Handles Label7.Click
        Dim f1 As New frmSales
        f1.Show()
        'Me.Hide()
    End Sub

    Private Sub BunifuButton6_Click(sender As Object, e As EventArgs) Handles btnaccmenu.Click
        PfrmWHSEManagement.Show()
        Me.Hide()
    End Sub


    Private Sub BunifuButton10_Click_1(sender As Object, e As EventArgs)
        Dim f1 As New SuppliersOders
        f1.Show()
        ' Me.Hide()
    End Sub
    Private Sub settings()
        'btnproductmenu.Enabled = My.Settings.Productmenu
        'btninvmenu.Enabled = My.Settings.invmenu
        'btnsalesmenu.Enabled = My.Settings.salesmenu
        'btnrptmenu.Enabled = My.Settings.reportmenu
        'rptcustmenu.Enabled = My.Settings.customermenu
        'btnaccmenu.Enabled = My.Settings.accountsmenu
        'btnsuppmenu.Enabled = My.Settings.suppliermenu
        'btnsysmenu.Enabled = My.Settings.setupmenu



    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles Label1.Click

        frmsimplesale.Show()
    End Sub
End Class
