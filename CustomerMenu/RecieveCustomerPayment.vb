Imports System.Data.SqlClient

Public Class RecieveCustomerPayment
    'Dim As New SqlConnection(My.Settings.PoSConnectionString)
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim f2 As New frmCustomersMenu
        f2.Show()
        Me.Hide()

    End Sub
    Private Sub RecieveCustomerPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        User()


        Timer1.Enabled = True
        Try
            Poscon.Open()
            Dim query = ("select * from Customer")
            cmd = New SqlCommand(query, Poscon)
            Dim adp As New SqlDataAdapter(cmd)
            Dim tbl As New DataTable
            adp.Fill(tbl)
            cbCustName.DataSource = tbl
            cbCustName.DisplayMember = "CustomerName"
            cbCustName.ValueMember = "IDCardNumber"
            Poscon.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        cbCustName.Text = ""
        lblCustBal.Text = 0
        'search("")
        clear()
        txtdatepaid.Text = Date.Now.ToString("dd-MMM-yy")
        Me.MaximumSize = Screen.FromRectangle(Me.Bounds).WorkingArea.Size
        WindowState = FormWindowState.Maximized
    End Sub
    Public Sub search(valuetosearch As String)
        Try
            If Poscon.State = ConnectionState.Closed Then
                Poscon.Open()
            End If
            Dim query = "select * from customer where concat(customername,emailaddress) like '%" + valuetosearch + "%'"
            cmd = New SqlCommand(query, Poscon)
            Dim adapter As New SqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)
            If table.Rows.Count() = 0 Then
            Else
                lblCustBal.Text = table.Rows(0)(10).ToString
                lblCustID.Text = table.Rows(0)(9).ToString()
            End If

            Poscon.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub cbCustName_TextChanged(sender As Object, e As EventArgs) Handles cbCustName.TextChanged
        'search(cbCustName.Text)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTime.Text = Date.Now.ToString("hh:mm:ss")
    End Sub

    Private Sub txtAmtPaid_TextChanged(sender As Object, e As EventArgs) Handles txtAmtPaid.TextChanged
        Dim a = Val(lblCustBal.Text)
        Dim b = Val(txtAmtPaid.Text)
        Dim c = Val(txtdiscount.Text)
        lblNewBal.Text = a - b - c
    End Sub
    Private Sub clear()
        cbCustName.Text = ""
        lblCustBal.Text = ""
        txtAmtPaid.Text = ""
        txtNarration.Text = ""
        txtRecieptNo.Text = ""
        cbPaymentMode.Text = ""
        lblCustID.Text = ""
        txtdiscount.Text = ""

    End Sub

    Private Sub cbCustName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCustName.SelectedIndexChanged
        search(cbCustName.Text)
    End Sub

    Private Sub cbCustName_DropDownClosed(sender As Object, e As EventArgs) Handles cbCustName.DropDownClosed
        search(cbCustName.Text)
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs)
        Try

            If cbCustName.Text = "" Then
                MsgBox("Select a Credit Customer")
            Else
                If Poscon.State = ConnectionState.Closed Then
                    Poscon.Open()
                End If

                Dim query = "insert into customerpayment values('" + cbCustName.Text + "','" + lblCustBal.Text + "','" + txtDatePaid.Text + "','" + txtAmtPaid.Text + "','" + lblNewBal.Text + "','" + cbType.Text + "','" + cbPaymentMode.Text + "','" + txtRecievedBy.Text + "','" + txtNarration.Text + "','" + lblTime.Text + "') "
                cmd = New SqlCommand(query, Poscon)
                cmd.ExecuteNonQuery()

                Dim quer = "update Customer set CurrentBalance = " + lblNewBal.Text + " where IDCardNumber =" + lblCustID.Text + ""
                cmd = New SqlCommand(quer, Poscon)
                cmd.ExecuteNonQuery()

                Dim sql = "insert into customerledger(CustomerName,Oldbal,datepaid,amtpaid,newbal,paymenttype,paymentmode,REcievedby,narration,timepaid) values('" + cbCustName.Text + "','" + lblCustBal.Text + "','" + txtDatePaid.Text + "','" + txtAmtPaid.Text + "','" + lblNewBal.Text + "','" + cbType.Text + "','" + cbPaymentMode.Text + "','" + txtRecievedBy.Text + "','" + txtNarration.Text + "','" + lblTime.Text + "') "
                cmd = New SqlCommand(sql, Poscon)
                cmd.ExecuteNonQuery()


                Poscon.Close()
                MsgBox("Payment Saved")
            End If


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


        clear()
    End Sub

    Private Sub Guna2PictureBox2_Click(sender As Object, e As EventArgs)
        If WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Maximized
        ElseIf WindowState = FormWindowState.Maximized Then
            WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub BunifuThinButton21_Click_1(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        If lblCustID.Text = "" Then
            MsgBox("Choose Customer")
            Exit Sub
        End If
        If txtAmtPaid.Text = "" Then
            MsgBox("Enter Amount Paid")
            Exit Sub
        End If

        Try

            If cbCustName.Text = "" Then
                MsgBox("Select a Credit Customer")
                Exit Sub
            Else
                If Poscon.State = ConnectionState.Closed Then
                    Poscon.Open()
                End If

                Dim query = "insert into customerpayment values('" + cbCustName.Text + "','" + lblCustBal.Text + "','" + txtdatepaid.Text + "','" + txtAmtPaid.Text + "','" + lblNewBal.Text + "','" + cbType.Text + "','" + cbPaymentMode.Text + "','" + txtRecievedBy.Text + "','" + txtNarration.Text + "','" + lblTime.Text + "','" + txtdiscount.Text + "') "
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Poscon)
                cmd.ExecuteNonQuery()

                If Poscon.State = ConnectionState.Closed Then
                    Poscon.Open()
                End If
                Dim sql = "Insert into CustomerLedger(CustomerName,oldbal,Newbal,AmtPaid,DatePaid,TimePaid,CustomerNo,RecievedBy,discount)Values('" + cbCustName.Text + "','" + lblCustBal.Text + "','" + lblNewBal.Text + "','" + txtAmtPaid.Text + "','" + txtdatepaid.Text + "','" + lblTime.Text + "','" + lblCustID.Text + "','" + txtRecievedBy.Text + "','" + txtdiscount.Text + "')"
                cmd = New SqlCommand(sql, Poscon)
                cmd.ExecuteNonQuery()

                Dim quer = "update Customer set CurrentBalance = " + lblNewBal.Text + " where IDCardNumber =" + lblCustID.Text + ""
                cmd = New SqlCommand(quer, Poscon)
                cmd.ExecuteNonQuery()
                Poscon.Close()
                MsgBox("Payment Saved")
            End If


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


        clear()
    End Sub

    Private Sub Guna2PictureBox1_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub
    Public Sub User()
        If Poscon.State = ConnectionState.Closed Then
            Poscon.Open()
        End If
        Dim que = "select * from userlogs"
        cmd = New SqlCommand(que, Poscon)
        Dim da As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        da.Fill(table)
        If table.Rows.Count = 0 Then

        Else

            Dim index = table.Rows.Count() - 1
            txtRecievedBy.Text = table.Rows(index)(1).ToString
        End If

        Poscon.Close()
    End Sub

    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click
        RecieveCustomerPayment_Load(e, e)
        WindowState = FormWindowState.Maximized

    End Sub

    Private Sub txtdiscount_TextChanged(sender As Object, e As EventArgs) Handles txtdiscount.TextChanged
        Dim a = Val(lblCustBal.Text)
        Dim b = Val(txtAmtPaid.Text)
        Dim c = Val(txtdiscount.Text)
        lblNewBal.Text = a - b - c
    End Sub
End Class