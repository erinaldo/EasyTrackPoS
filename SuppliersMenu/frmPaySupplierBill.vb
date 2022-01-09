Imports System.Data.SqlClient
Public Class frmPaySupplierBill
    'Dim As New SqlConnection(My.Settings.PoSConnectionString)
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader
    Dim da As SqlDataAdapter
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)
        Dim f2 As New frmSuppliersMenu
        f2.Show()
        Me.Hide()


    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        If cbCustName.Text = "" Then
            MsgBox("Choose Supplier")
            Exit Sub
        End If
        If txtAmtPaid.Text = "" Then
            MsgBox("Enter Amount Paid")
            Exit Sub
        End If
        If txtRecievedBy.Text = "" Then
            MsgBox("Enter Reciepient")
            Exit Sub
        End If
        Try

            If cbCustName.Text = "" Then
                MsgBox("Select a Supplier")
                Exit Sub
            Else
                If Poscon.State = ConnectionState.Closed Then
                    Poscon.Open()
                End If

                Dim query = "insert into Supplierpayments(SupplierName,oldBalance,DatePaid,AmtPaid,NewBalance,Paymode,Recievedby,Narration,InvoiceNo) values('" + cbCustName.Text + "','" + lblCustBal.Text + "','" + txtDatePaid.Text + "','" + txtAmtPaid.Text + "','" + lblNewBal.Text + "','" + cbPaymentMode.Text + "','" + txtRecievedBy.Text + "','" + txtNarration.Text + "','" + txtInvoiceNo.Text + "') "
                cmd = New SqlCommand(query, Poscon)
                cmd.ExecuteNonQuery()

                Dim quer = "update Supplier set Balance = " + lblNewBal.Text + " where supplierNo =" + lblSuppNo.Text + ""
                cmd = New SqlCommand(quer, Poscon)
                cmd.ExecuteNonQuery()


                Dim sql = "insert into SupplierLedger(SupplierName,oldBal,DatePaid,AmtPaid,NewBal,Paymentmode,Recievedby,Narration,invoiceno,Timepaid) values('" + cbCustName.Text + "','" + lblCustBal.Text + "','" + txtDatePaid.Text + "','" + txtAmtPaid.Text + "','" + lblNewBal.Text + "','" + cbPaymentMode.Text + "','" + txtRecievedBy.Text + "','" + txtNarration.Text + "','" + txtInvoiceNo.Text + "','" + lblTime.Text + "') "
                cmd = New SqlCommand(sql, Poscon)
                cmd.ExecuteNonQuery()

                Poscon.Close()
                MsgBox("Payment Saved")
            End If


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Clear()

    End Sub

    Private Sub frmPaySupplierBill_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Try
            If Poscon.State = ConnectionState.Closed Then
                Poscon.Open()
            End If
            cbCustName.Items.Clear()
            Dim query = ("select * from Supplier")
            cmd = New SqlCommand(query, Poscon)
            dr = cmd.ExecuteReader
            While dr.Read
                cbCustName.Items.Add(dr(1))
            End While
            Poscon.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        cbCustName.Text = ""
        lblCustBal.Text = 0
        lblTranxRefNo.Visible = False
        txtREfNo.Visible = False
        'search("")
        'clear()
    End Sub
    Private Sub Clear()
        lblCustBal.Text = ""
        lblNewBal.Text = ""
        lblSuppNo.Text = ""
        txtAmtPaid.Text = ""
        txtNarration.Text = ""
        txtREfNo.Text = ""
        cbCustName.Text = ""
        cbPaymentMode.Text = ""
        txtInvoiceNo.Text = ""
        cbCustName.Text = ""


    End Sub
    Public Sub Suppliers(valuetosearch As String)
        Try
            If Poscon.State = ConnectionState.Closed Then
                Poscon.Open()
            End If
            Dim query = "select * from supplier where concat(suppliername,IDNumber) like '%" + valuetosearch + "%'"
            cmd = New SqlCommand(query, Poscon)
            da = New SqlDataAdapter(cmd)
            Dim tbl As New DataTable()
            da.Fill(tbl)
            If tbl.Rows.Count = 0 Then
            Else
                lblCustBal.Text = tbl.Rows(0)(7).ToString
                lblSuppNo.Text = tbl.Rows(0)(0).ToString
                'lblNewBal.Text = Val(lblCustBal.Text) + Val(txtAmtPaid.Text)
            End If


            Poscon.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


    End Sub

    Private Sub cbCustName_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbCustName.SelectionChangeCommitted
        Suppliers(cbCustName.Text)
    End Sub

    Private Sub txtAmtPaid_TextChanged(sender As Object, e As EventArgs) Handles txtAmtPaid.TextChanged
        Dim a = Val(lblCustBal.Text)
        Dim b = Val(txtAmtPaid.Text)
        lblNewBal.Text = (a - b)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        txtDatePaid.Text = Date.Now.ToString("dd-MMM-yy")
        lblTime.Text = Date.Now.ToString("hh:mm:ss")
    End Sub

    Private Sub cbCustName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCustName.SelectedIndexChanged
        Suppliers(cbCustName.Text)
    End Sub

    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click
        frmPaySupplierBill_Load(e, e)
    End Sub

    Private Sub cbPaymentMode_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbPaymentMode.SelectionChangeCommitted
        If cbPaymentMode.SelectedItem = "Cheque" Or cbPaymentMode.SelectedItem = "Momo" Then
            lblTranxRefNo.Visible = True
            txtREfNo.Visible = True
        Else
            lblTranxRefNo.Visible = False
            txtREfNo.Visible = False
        End If
    End Sub
End Class