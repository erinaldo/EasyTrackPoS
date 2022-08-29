Imports System.Data.SqlClient
Public Class frmModifyCustomerAccounts
    'Dim As New SqlConnection(My.Settings.PoSConnectionString)
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

        frmCustomersMenu.Show()
        Me.Hide()

    End Sub

    Private Sub frmModifyCustomerAccounts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Display()

    End Sub
    Private Sub Display()
        If Poscon.State = ConnectionState.Closed Then
            Poscon.Open()
        End If
        Dim query = "select * from Customer"
        Dim adapter As SqlDataAdapter
        Dim cmd As SqlCommand
        cmd = New SqlCommand(query, Poscon)
        adapter = New SqlDataAdapter(cmd)
        Dim builder As New SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds
        ds = New DataSet
        adapter.Fill(ds)

        gvcust.DataSource = ds.Tables(0)

        Poscon.Close()
    End Sub
    Dim key = ""


    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Poscon.Open()
        Dim query = ("update customer set CustomerName='" + txtName.Text + "', EmailAddress= '" + txtEmailAdd.Text + "',BusinessDigitalAddress= '" + txtBusDigAdd.Text + "',ResidentialDigitalAddress= '" + txtResDigAdd.Text + "',ResidentailLocation= '" + txtResLocation.Text + "',BusinessLocation= '" + txtBussLocation.Text + "',CreditLimit= '" + txtCardLimit.Text + "',Idcardtype= '" + cbCardType.Text + "',IdcardNumber= '" + txtCardNo.Text + "' where CustomerNo= '" & txtCardNo.Text & "'")
        Dim cmd As New SqlCommand(query, Poscon)
        cmd.ExecuteNonQuery()
        MsgBox("Customer Updated Successfully")
        Poscon.Close()
        Display()
        Clear()
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        If My.Settings.DeleteCS = False Then
            MsgBox("Sorry you dont have access to this feature")
            Exit Sub
        End If
        If txtCardNo.Text = "" Then
            MsgBox("Select Customer To Edit")
            Exit Sub
        End If
        If Poscon.State = ConnectionState.Closed Then
            Poscon.Open()
        End If

        Dim query = ("update customer set CustomerName='" + txtName.Text + "', EmailAddress= '" + txtEmailAdd.Text + "',BusinessDigitalAddress= '" + txtBusDigAdd.Text + "',ResidentialDigitalAddress= '" + txtResDigAdd.Text + "',ResidentailLocation= '" + txtResLocation.Text + "',BusinessLocation= '" + txtBussLocation.Text + "',CreditLimit= '" + txtCardLimit.Text + "',Idcardtype= '" + cbCardType.Text + "',currentbalance= '" + txtCurrentBalance.Text + "' where Idcardnumber= '" & txtCardNo.Text & "'")
        Dim cmd As New SqlCommand(query, Poscon)
        cmd.ExecuteNonQuery()
        MsgBox("Customer Updated Successfully")
        Poscon.Close()
        Display()

        Clear()
    End Sub

    Private Sub Guna2PictureBox1_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox1.Click
        Application.Exit()
    End Sub

    Private Sub gvCustomer_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Guna2PictureBox2_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox2.Click
        If WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Maximized
        ElseIf WindowState = FormWindowState.Maximized Then
            WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub gvcust_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles gvcust.CellClick
        Try
            Dim row As DataGridViewRow = gvcust.Rows(e.RowIndex)
            lblCustID.Text = row.Cells(0).Value.ToString()
            txtName.Text = row.Cells(1).Value.ToString()
            txtEmailAdd.Text = row.Cells(2).Value.ToString()
            txtBusDigAdd.Text = row.Cells(3).Value.ToString()
            txtResDigAdd.Text = row.Cells(4).Value.ToString()
            txtBussLocation.Text = row.Cells(6).Value.ToString()
            txtResLocation.Text = row.Cells(5).Value.ToString()
            txtCardLimit.Text = row.Cells(7).Value.ToString()
            cbCardType.Text = row.Cells(8).Value.ToString()
            txtCardNo.Text = row.Cells(9).Value.ToString()
            txtCurrentBalance.Text = row.Cells(10).Value.ToString()
        Catch ex As Exception

        End Try

    End Sub
    Private Sub Clear()
        lblCustID.Text = ""
        txtName.Text = ""
        txtEmailAdd.Text = ""
        txtBusDigAdd.Text = ""
        txtResDigAdd.Text = ""
        txtBussLocation.Text = ""
        cbCardType.Text = ""
        txtCardNo.Text = ""
        txtResLocation.Text = ""
        txtCardLimit.Text = ""
        txtCurrentBalance.Text = ""
    End Sub

    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click
        frmModifyCustomerAccounts_Load(e, e)
        WindowState = FormWindowState.Maximized
    End Sub
End Class