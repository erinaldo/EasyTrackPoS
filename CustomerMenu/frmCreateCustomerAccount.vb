Imports System.Data.SqlClient
Public Class frmCreateCustomerAccount
    'Dim As New SqlConnection(My.Settings.PoSConnectionString)
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader
    Dim da As SqlDataAdapter
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim f2 As New frmCustomersMenu
        f2.Show()
        Me.Hide()

    End Sub


    Private Sub frmCreateCustomerAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MaximumSize = Screen.FromRectangle(Me.Bounds).WorkingArea.Size
        WindowState = FormWindowState.Maximized
        txtCustBal.Text = 0
        Display()

    End Sub
    Private Sub clear()
        txtName.Text = ""
        txtEmailAddress.Text = ""
        txtContact.Text = ""
        txtResDigAddress.Text = ""
        txtResLocation.Text = ""
        txtBusLocation.Text = ""
        txtCreditLimit.Text = ""
        cbIDCardType.Text = ""
        txtIdCardNo.Text = ""
        txtCustBal.Text = ""
    End Sub
    Private Sub Display()
        If Poscon.State = ConnectionState.Closed Then
            Poscon.Open()
        End If

        Dim query = "select Customername,currentbalance,EmailAddress,businesslocation from Customer"
        cmd = New SqlCommand(query, Poscon)
        Dim tbl As New DataTable()
        da = New SqlDataAdapter(cmd)
        da.Fill(tbl)
        gvStockMast.DataSource = tbl

        'lblProdCount.Text = gvStockMast.Rows.Count()
        Poscon.Close()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        If Poscon.State = ConnectionState.Closed Then
            Poscon.Open()
        End If
        Dim sql = "select * from Customer where IDcardnumber= '" + txtIdCardNo.Text + "' "
        cmd = New SqlCommand(sql, Poscon)
        dr = cmd.ExecuteReader
        If txtIdCardNo.Text = "" Then
            MsgBox("Enter New Customer ID")
            Poscon.Close()
        ElseIf (dr.Read = True) Then
            MsgBox("Customer Already Exists, Enter a new Customer")
            Poscon.Close()
            clear()
        Else
            Try
                If Poscon.State = ConnectionState.Closed Then
                    Poscon.Open()
                End If
                Dim query = "insert into customer values('" + txtName.Text + "','" + txtEmailAddress.Text + "','" + txtContact.Text + "','" + txtResDigAddress.Text + "','" + txtResLocation.Text + "','" + txtBusLocation.Text + "','" + txtCreditLimit.Text + "','" + cbIDCardType.Text + "','" + txtIdCardNo.Text + "','" + txtCustBal.Text + "')"
                cmd = New SqlCommand(query, Poscon)
                cmd.ExecuteNonQuery()
                'MsgBox("Customer Saved Succesfully")
                clear()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If


    End Sub

    Private Sub Guna2PictureBox1_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox1.Click
        Application.Exit()
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs)
        If Poscon.State = ConnectionState.Closed Then
            Poscon.Open()
        End If
        Dim sql = "select * from Customer where IDcardnumber= '" + txtIdCardNo.Text + "' "
        cmd = New SqlCommand(sql, Poscon)
        dr = cmd.ExecuteReader
        If txtIdCardNo.Text = "" Then
            MsgBox("Enter New Customer ID")
            Poscon.Close()
        ElseIf (dr.Read = True) Then
            MsgBox("Customer Already Exists, Enter a new Customer")
            Poscon.Close()
            clear()
        Else
            Try
                If Poscon.State = ConnectionState.Closed Then
                    Poscon.Open()
                End If
                Dim query = "insert into customer values('" + txtName.Text + "','" + txtEmailAddress.Text + "','" + txtContact.Text + "','" + txtResDigAddress.Text + "','" + txtResLocation.Text + "','" + txtBusLocation.Text + "','" + txtCreditLimit.Text + "','" + cbIDCardType.Text + "','" + txtIdCardNo.Text + "','" + txtCustBal.Text + "')"

                cmd = New SqlCommand(query, Poscon)
                cmd.ExecuteNonQuery()
                'MsgBox("Customer Saved Succesfully")
                clear()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub BunifuThinButton21_Click_1(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        If My.Settings.CreateCS = False Then
            MsgBox("Sorry you dont have access to this feature")
            Exit Sub
        End If
        If Poscon.State = ConnectionState.Closed Then
            Poscon.Open()
        End If

        Dim sql = "select * from Customer where IDcardnumber= '" + txtIdCardNo.Text + "' "
        cmd = New SqlCommand(sql, Poscon)
        dr = cmd.ExecuteReader
        If txtIdCardNo.Text = "" Then
            MsgBox("Enter New Customer ID")
            Poscon.Close()
        ElseIf (dr.Read = True) Then
            MsgBox("Customer Already Exists, Enter a new Customer")
            Poscon.Close()
            clear()
        Else
            Try
                If Poscon.State = ConnectionState.Closed Then
                    Poscon.Open()
                End If
                Dim query = "insert into customer(Customername,Emailaddress,Businessdigitaladdress,residentialdigitaladdress,residentaillocation,businesslocation,creditlimit,idcardtype,idcardnumber,currentbalance,customertype) values('" + txtName.Text + "','" + txtEmailAddress.Text + "','" + txtContact.Text + "','" + txtResDigAddress.Text + "','" + txtResLocation.Text + "','" + txtBusLocation.Text + "','" + txtCreditLimit.Text + "','" + cbIDCardType.Text + "','" + txtIdCardNo.Text + "','" + txtCustBal.Text + "','" + cbCustType.Text + "')"
                cmd = New SqlCommand(query, Poscon)
                cmd.ExecuteNonQuery()
                'MsgBox("Customer Saved Succesfully")
                clear()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
        Display()
        'CustTotal()
    End Sub

    Private Sub Guna2PictureBox2_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox2.Click
        If WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Maximized
        ElseIf WindowState = FormWindowState.Maximized Then
            WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click
        frmCreateCustomerAccount_Load(e, e)
    End Sub

    Private Sub txtIdCardNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIdCardNo.KeyPress
        'If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
        '    e.Handled = True
        '    MsgBox("This field will accept numbers only")
        'End If
    End Sub
    Sub CustTotal()
        If gvStockMast.Rows.Count = 0 Then
            Exit Sub
        End If
        For Each row As DataGridViewRow In gvStockMast.Rows
            Dim sum As Decimal
            sum += row.Cells(1).Value
            lbltotal.Text = sum
        Next

    End Sub
End Class