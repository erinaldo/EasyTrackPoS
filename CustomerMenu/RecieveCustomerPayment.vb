Imports System.Data.SqlClient
Imports System.Globalization
Public Class RecieveCustomerPayment
    'Dim As New SqlConnection(My.Settings.PoSConnectionString)
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader
    Dim dt As New dscustomer
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim f2 As New frmCustomersMenu
        f2.Show()
        Me.Hide()

    End Sub
    Private Sub RecieveCustomerPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        recieptno()

        Timer1.Enabled = True
        'Try
        '    Poscon.Open()
        '    Dim query = ("select * from Customer")
        '    cmd = New SqlCommand(query, Poscon)
        '    Dim adp As New SqlDataAdapter(cmd)
        '    Dim tbl As New DataTable
        '    adp.Fill(tbl)
        '    cbCustName.DataSource = tbl
        '    cbCustName.DisplayMember = "CustomerName"
        '    cbCustName.ValueMember = "IDCardNumber"
        '    Poscon.Close()
        'Catch ex As Exception
        '    msgbox(ex.message)
        'End Try
        ComboFeed("select customername from Customer", cbCustName, 0)

        cbCustName.SelectedIndex = -1
        cbPaymentMode.SelectedIndex = 0
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
            Dim query = "select * from customer where concat(customername,emailaddress) = '" + valuetosearch + "'"
            cmd = New SqlCommand(query, Poscon)
            da = New SqlDataAdapter(cmd)
            tbl = New DataTable()
            da.Fill(tbl)
            If tbl.Rows.Count() = 0 Then
            Else
                lblCustBal.Text = tbl.Rows(0)(10).ToString
                lblCustID.Text = tbl.Rows(0)(9).ToString()
                Dim dblValue As Double = Val(lblCustBal.Text)

                ' lblCustBal.Text = dblValue.ToString("N", CultureInfo.InvariantCulture)

            End If

            Poscon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
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
        Dim dblValue As Double = Val(lblNewBal.Text)
        'lblNewBal.Text = dblValue.ToString("N", CultureInfo.InvariantCulture)

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

                Dim query = "insert into customerpayment values('" + cbCustName.Text + "','" + lblCustBal.Text + "','" + txtdatepaid.Text + "','" + txtAmtPaid.Text + "','" & lblNewBal.Text & "','" + cbType.Text + "','" + cbPaymentMode.Text + "','" + txtRecievedBy.Text + "','" + txtNarration.Text + "','" + lblTime.Text + "') "
                cmd = New SqlCommand(query, Poscon)
                cmd.ExecuteNonQuery()

                Dim quer = "update Customer set CurrentBalance = " & lblNewBal.Text & " where IDCardNumber ='" & lblCustID.Text & "'"
                cmd = New SqlCommand(quer, Poscon)
                cmd.ExecuteNonQuery()

                Dim sql = "insert into customerledger(CustomerName,Oldbal,datepaid,amtpaid,newbal,paymenttype,paymentmode,REcievedby,narration,timepaid) values('" + cbCustName.Text + "','" + lblCustBal.Text + "','" + txtdatepaid.Text + "','" + txtAmtPaid.Text + "','" & lblNewBal.Text & "','" + cbType.Text + "','" + cbPaymentMode.Text + "','" + txtRecievedBy.Text + "','" + txtNarration.Text + "','" + lblTime.Text + "') "
                cmd = New SqlCommand(sql, Poscon)
                cmd.ExecuteNonQuery()


                Poscon.Close()
                MsgBox("Payment Saved")
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
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
        If My.Settings.RecieveCS = False Then
            MsgBox("Sorry you do not have access to this feature")
            Exit Sub
        End If
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

                create("insert into customerpayment(Customername,oldbal,datepaid,amtpaid,newbal,paymenttype,paymentmode,recievedby,narration,timerecieved,discount) values('" + cbCustName.Text + "','" + lblCustBal.Text + "','" + txtdatepaid.Text + "','" + txtAmtPaid.Text + "','" + lblNewBal.Text + "','" + cbType.Text + "','" + cbPaymentMode.Text + "','" + txtRecievedBy.Text + "','" + txtNarration.Text + "','" + lblTime.Text + "','" + txtdiscount.Text + "') ")
                create("Insert into CustomerLedger(CustomerName,oldbal,Newbal,AmtPaid,DatePaid,TimePaid,CustomerNo,RecievedBy,discount)Values('" + cbCustName.Text + "','" + lblCustBal.Text + "','" + lblNewBal.Text + "','" + txtAmtPaid.Text + "','" + txtdatepaid.Text + "','" + lblTime.Text + "','" + lblCustID.Text + "','" + txtRecievedBy.Text + "','" + txtdiscount.Text + "')")
                updates("update Customer set CurrentBalance = '" + lblNewBal.Text + "' where IDCardNumber ='" & lblCustID.Text & "'")
                If tkroll.Checked = True Then
                    PrintRecieptroll()
                End If
                If tkA5.Checked = True Then
                    A4()
                End If
                MsgBox("Payment Saved")
            End If
            recieptno()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        clear()
    End Sub

    'Private Sub Guna2PictureBox1_Click(sender As Object, e As EventArgs)
    '    Application.Exit()
    'End Sub


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
    Private Sub PrintRecieptroll()

        Try
            If Poscon.State = ConnectionState.Closed Then
                Poscon.Open()
            End If

            cmd = New SqlCommand("select Paymentid from customerpayment", Poscon)
            da = New SqlDataAdapter(cmd)
            tbl = New DataTable()
            da.Fill(tbl)
            If tbl.Rows.Count() = 0 Then
            Else
                Dim index = tbl.Rows.Count() - 1
                Dim query = "select * from customerpayment where paymentid='" & tbl.Rows(index)(0).ToString & "'"
                cmd = New SqlCommand(query, Poscon)
                dt.Tables("customerpayment").Rows.Clear()
                da.SelectCommand = cmd
                da.Fill(dt, "customerpayment")

                Dim sql = "select * from ClientReg"
                dt.Tables("ClientReg").Rows.Clear()
                cmd = New SqlCommand(sql, Poscon)
                da.SelectCommand = cmd
                da.Fill(dt, "ClientReg")

                Dim report As New rptCustomerReciept
                report.SetDataSource(dt)
                If ckprint.Checked = True Then
                    report.PrintToPrinter(1, True, 0, 0)
                End If
                If ckprintpreview.Checked = True Then
                    frmSupplierReport.Show()
                    frmSupplierReport.CrystalReportViewer1.ReportSource = report
                    frmSupplierReport.CrystalReportViewer1.Refresh()
                End If
            End If

            cmd.Dispose()
            da.Dispose()
            Poscon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub A4()

        Try
            If Poscon.State = ConnectionState.Closed Then
                Poscon.Open()
            End If

            cmd = New SqlCommand("select Paymentid from customerpayment", Poscon)
            da = New SqlDataAdapter(cmd)
            tbl = New DataTable()
            da.Fill(tbl)
            If tbl.Rows.Count() = 0 Then
            Else
                Dim index = tbl.Rows.Count() - 1
                Dim query = "select * from customerpayment where paymentid='" + tbl.Rows(index)(0).ToString + "'"
                cmd = New SqlCommand(query, Poscon)
                dt.Tables("customerpayment").Rows.Clear()
                da.SelectCommand = cmd
                da.Fill(dt, "customerpayment")

                Dim sql = "select * from ClientReg"
                dt.Tables("ClientReg").Rows.Clear()
                cmd = New SqlCommand(sql, Poscon)
                da.SelectCommand = cmd
                da.Fill(dt, "ClientReg")

                Dim report As New rptCustomerRecieptA5
                report.SetDataSource(dt)
                If ckprint.Checked = True Then
                    report.PrintToPrinter(1, True, 0, 0)
                End If
                If ckprintpreview.Checked = True Then
                    frmSupplierReport.Show()
                    frmSupplierReport.CrystalReportViewer1.ReportSource = report
                    frmSupplierReport.CrystalReportViewer1.Refresh()
                End If
            End If

            cmd.Dispose()
            da.Dispose()
            Poscon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub recieptno()
        If Poscon.State = ConnectionState.Closed Then
            Poscon.Open()
        End If
        Dim que = "select paymentid from customerpayment"
        cmd = New SqlCommand(que, Poscon)
        da = New SqlDataAdapter(cmd)
        Dim table As New DataTable
        da.Fill(table)
        If table.Rows.Count = 0 Then
            lblpaymentid.Text = 1
        Else

            Dim index = table.Rows.Count() - 1
            lblpaymentid.Text = Val(table.Rows(0)(0).ToString) + 1
        End If

        Poscon.Close()
    End Sub
End Class