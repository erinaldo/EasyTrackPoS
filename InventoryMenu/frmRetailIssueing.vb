Imports System.Data.SqlClient
Public Class frmRetailIssueing
    'Dim As New SqlConnection(My.Settings.PoSConnectionString)
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter
    Dim dr As SqlDataReader
    Dim dt As New dsGoodsRecieved
    Private Sub frmRetailIssueing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MaximumSize = Screen.FromRectangle(Me.Bounds).WorkingArea.Size
        WindowState = FormWindowState.Maximized
        Timer1.Enabled = True
        Display()
        Try
            If Poscon.State = ConnectionState.Closed Then
                Poscon.Open()
            End If
            cbSearchItem.Items.Clear()
            Dim sql = "select * from Stockmast"
            cmd = New SqlCommand(sql, Poscon)
            dr = cmd.ExecuteReader
            While dr.Read
                cbSearchItem.Items.Add(dr(1))

            End While
            Poscon.Close()

            If Poscon.State = ConnectionState.Closed Then
                Poscon.Open()
            End If
            cbSuppName.Items.Clear()
            Dim query = ("select * from customer")
            cmd = New SqlCommand(query, Poscon)
            dr = cmd.ExecuteReader
            While dr.Read
                cbSuppName.Items.Add(dr(1))
            End While
            Poscon.Close()

            If Poscon.State = ConnectionState.Closed Then
                Poscon.Open()
            End If
            cbCatSort.Items.Clear()
            Dim sqll = "select category from Category"
            cmd = New SqlCommand(sqll, Poscon)
            dr = cmd.ExecuteReader
            While dr.Read
                cbCatSort.Items.Add(dr(0))
            End While
            Poscon.Close()

            If Poscon.State = ConnectionState.Closed Then
                Poscon.Open()
            End If
            cbCatSort.Items.Clear()
            Dim pli = "select productline from productline"
            cmd = New SqlCommand(pli, Poscon)
            dr = cmd.ExecuteReader
            While dr.Read
                cbCatSort.Items.Add(dr(0))
            End While
            Poscon.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        cbSearchItem.Focus()
        cbPaymentMode.SelectedIndex = 0
        cbSuppName.SelectedIndex = -1
        clear()
        ShowConfig()
        txtdate.Text = Date.Now.ToString("dd-MMM-yy")

    End Sub
    Private Sub Display()

        If Poscon.State = ConnectionState.Closed Then
            Poscon.Open()
        End If
        Dim que = "select * from userlogs"
        cmd = New SqlCommand(que, Poscon)
        da = New SqlDataAdapter(cmd)
        Dim table As New DataTable
        da.Fill(table)
        Dim index = table.Rows.Count() - 1
        If table.Rows.Count = 0 Then

        Else
            tsuser.Text = table.Rows(index)(1).ToString
        End If

        Poscon.Close()

        If Poscon.State = ConnectionState.Closed Then
            Poscon.Open()
        End If
        Dim query = "select ProdName,prodqty,ProdCat,retailprice,packprice,packsize,baseqty,Prodcode from StockMast"
        cmd = New SqlCommand(query, Poscon)
        da = New SqlDataAdapter(cmd)
        Dim tbl As New DataTable
        da.Fill(tbl)
        gvStockBf.DataSource = tbl
        Poscon.Close()

    End Sub

    Private Sub txtQtyRecieved_TextChanged(sender As Object, e As EventArgs) Handles txtQtyRecieved.TextChanged
        Try
            Dim amt As Decimal
            amt = Val(txtQtyRecieved.Text) * Val(txtItemPrice.Text) * Val(txtbaseQty.Text) * Val(txtPackSize.Text)
            txtItemAmount.Text = amt
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub clear()
        txtItemName.Text = ""
        txtItemPrice.Text = ""
        txtActualStock.Text = ""
        txtItemAmount.Text = ""
        txtQtyRecieved.Text = ""
        lblTotal.Text = ""
        txtCat.Text = ""
        txtPackSize.Text = ""
        txtPackVolume.Text = ""
        cbSuppName.SelectedIndex = -1
        txtAmtPaid.Text = ""
        txtbaseQty.Text = ""
        txtNarration.Text = ""
        cbPaymentMode.SelectedIndex = 0
        txtREfNo.Text = ""
        lblCustNo.Text = ""
        lblNewBal.Text = ""
        lblOldBal.Text = ""
        lbltotalbal.Text = ""

    End Sub
    Private Sub gvStockBf_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles gvStockBf.CellClick
        Try
            Dim row As DataGridViewRow = gvStockBf.Rows(e.RowIndex)
            txtItemName.Text = row.Cells(0).Value.ToString()
            txtItemPrice.Text = row.Cells(3).Value.ToString()
            txtActualStock.Text = row.Cells(1).Value.ToString()
            lblProdcode.Text = row.Cells(7).Value.ToString()
            txtCat.Text = row.Cells(2).Value.ToString()
            txtPackSize.Text = row.Cells(5).Value.ToString()
            txtbaseQty.Text = row.Cells(6).Value.ToString()
            lblpackprice.Text = row.Cells(4).Value.ToString()
            txtPackVolume.Text = Val(txtPackSize.Text * txtbaseQty.Text)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        If txtItemPrice.Text = "" Or txtQtyRecieved.Text = "" Then
            MsgBox("Select item or Enter Quantity recieved")
            txtQtyRecieved.Focus()
        Else

            Dim NewStock As Decimal
            Dim a = Val(txtActualStock.Text)
            Dim b = Val(txtQtyRecieved.Text)
            NewStock = a - b
            'For Each row As DataGridViewRow In gvStockBatch.Rows
            '    If lblProdcode.Text = row.Cells(6).Value Then
            '        row.Cells(3).Value += Val(txtQtyRecieved.Text)
            '        row.Cells(4).Value = row.Cells(1).Value - row.Cells(3).Value
            '        row.Cells(5).Value = row.Cells(8).Value * row.Cells(2).Value * row.Cells(3).Value

            '        gvStockBatch.Rows.Add(txtItemName.Text, txtActualStock.Text, txtItemPrice.Text, txtQtyRecieved.Text, "", txtItemAmount.Text, lblProdcode.Text, txtCat.Text, txtPackVolume.Text)


            '        Try
            '            Dim sum As Decimal = 0
            '            For k = 0 To gvStockBatch.RowCount - 1
            '                sum += gvStockBatch.Rows(k).Cells(5).Value

            '            Next
            '            lblTotal.Text = sum
            '            Dim newbal = Val(lblOldBal.Text) + Val(lblTotal.Text) - Val(txtAmtPaid.Text)
            '            lblNewBal.Text = newbal
            '            Dim totbal = Val(lblOldBal.Text) + Val(lblTotal.Text)
            '            lbltotalbal.Text = totbal
            '            clear()
            '        Catch ex As Exception
            '            MsgBox(ex.ToString)
            '        End Try
            '        Exit Sub
            '    End If
            'Next
            gvStockBatch.Rows.Add(txtItemName.Text, txtActualStock.Text, txtItemPrice.Text, txtQtyRecieved.Text, NewStock, txtItemAmount.Text, lblProdcode.Text, txtCat.Text, txtPackVolume.Text)
            clear()
        End If
        Try
            Dim sum As Decimal = 0
            For k = 0 To gvStockBatch.RowCount - 1
                sum += gvStockBatch.Rows(k).Cells(5).Value

            Next
            lblTotal.Text = sum
            Dim newbal = Val(lblOldBal.Text) + Val(lblTotal.Text) - Val(txtAmtPaid.Text)
            lblNewBal.Text = newbal
            Dim totbal = Val(lblOldBal.Text) + Val(lblTotal.Text)
            lbltotalbal.Text = totbal
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub customers(valuetosearch As String)
        Try
            If Poscon.State = ConnectionState.Closed Then
                Poscon.Open()
            End If
            Dim query = "select * from customer where concat(CustomerName,IDcardNumber) like '%" + valuetosearch + "%'"
            cmd = New SqlCommand(query, Poscon)
            da = New SqlDataAdapter(cmd)
            Dim tbl As New DataTable()
            da.Fill(tbl)
            If tbl.Rows.Count = 0 Then
            Else
                lblOldBal.Text = tbl.Rows(0)(10).ToString
                lblCustNo.Text = tbl.Rows(0)(0).ToString
                Dim newbal = Val(lblOldBal.Text) + Val(lblTotal.Text) - Val(txtAmtPaid.Text)
                lblNewBal.Text = newbal
                Dim totbal = Val(lblOldBal.Text) + Val(lblTotal.Text)
                lbltotalbal.Text = totbal
            End If
            Poscon.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


    End Sub

    Private Sub cbSuppName_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbSuppName.SelectionChangeCommitted
        customers(cbSuppName.Text)
    End Sub

    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If cbSuppName.Text = "" Or lblCustNo.Text = "CustNo" Then
            MsgBox("Choose Customer")
            Exit Sub
        End If
        If gvStockBatch.Rows.Count = 0 Then
            MsgBox("Fill Item Cart")
            Exit Sub
        End If
        If txtinvoiceno.Text = "" Or gvStockBatch.Rows.Count = 0 Then
            MsgBox("Fill in invoice number")
        Else
            Try
                Dim i As Integer
                For i = 0 To gvStockBatch.RowCount - 1
                    If Poscon.State = ConnectionState.Closed Then
                        Poscon.Open()
                    End If
                    Dim query = "insert into Issuestock (invoiceno,ItemName,Price,Amount,OldStock,NewStock,QtyIssued,Issuedby,itemcat,CustomerName,CustomerID,PackVolume,Customeroldbal,totalbalance,customerpayment,newbalance,narration,dateissued,time,paymode,TranxRef,totalissued) values('" + txtinvoiceno.Text + "',@Itemname,@Price,@amount,@oldStock,@newstock,@qtyrecieved,'" + tsuser.Text + "',@itemCat,'" + cbSuppName.Text + "','" + lblCustNo.Text + "',@packVolume,'" + lblOldBal.Text + "','" + lbltotalbal.Text + "','" + txtAmtPaid.Text + "','" + lblNewBal.Text + "','" + txtNarration.Text + "','" + txtdate.Text + "','" + tstime.Text + "','" + cbPaymentMode.Text + "','" + txtREfNo.Text + "','" + lblTotal.Text + "')"
                    cmd = New SqlCommand(query, Poscon)
                    With cmd
                        .Parameters.AddWithValue("@Itemname", gvStockBatch.Rows(i).Cells(0).Value)
                        .Parameters.AddWithValue("@Price", gvStockBatch.Rows(i).Cells(2).Value)
                        .Parameters.AddWithValue("@amount", gvStockBatch.Rows(i).Cells(5).Value)
                        .Parameters.AddWithValue("@oldStock", gvStockBatch.Rows(i).Cells(1).Value)
                        .Parameters.AddWithValue("@newstock", gvStockBatch.Rows(i).Cells(4).Value)
                        .Parameters.AddWithValue("@qtyrecieved", gvStockBatch.Rows(i).Cells(3).Value)
                        .Parameters.AddWithValue("@packvolume", gvStockBatch.Rows(i).Cells(8).Value)
                        .Parameters.AddWithValue("@itemcat", gvStockBatch.Rows(i).Cells(7).Value)
                        .ExecuteNonQuery()
                    End With
                Next
                If Poscon.State = ConnectionState.Closed Then
                    Poscon.Open()
                End If
                Dim sql = "insert into CustomerLedger (issueno,Recievedby,CustomerName,CustomerNo,creditrecieved,oldbal,narration,newbal,daterecieved,timerecieved,amtpaid) values('" + txtinvoiceno.Text + "','" + tsuser.Text + "','" + cbSuppName.Text + "','" + lblCustNo.Text + "','" + lblTotal.Text + "','" + lblOldBal.Text + "','" + txtNarration.Text + "','" + lblNewBal.Text + "','" + txtdate.Text + "','" + tstime.Text + "','" + txtAmtPaid.Text + "')"
                cmd = New SqlCommand(sql, Poscon)
                cmd.ExecuteNonQuery()
                For Each row As DataGridViewRow In gvStockBatch.Rows
                    Dim quer = "insert into InventoryLedger (ItemCode,itemname,tranxtype,TranxSource,TranxGroup,oldqty,QtyIssued,StockBalance,Userid,RetailPrice,CostPrice,RetailAmt,CostAmt,Narration,time,date,qtyrecieved,Customername) values(@ItemCode,@Itemname,@Tranxtype,@tranxsource,@TranxGroup,@oldqty,@qtyissued,@balance,@userid,@Rprice,@cprice,@ramt,@camt,@nar,@time,@date,@qtyrecieved,'" + cbSuppName.Text + "')"
                    cmd = New SqlCommand(quer, Poscon)
                    With cmd
                        .Parameters.AddWithValue("@ItemCode", row.Cells(6).Value)
                        .Parameters.AddWithValue("@Itemname", row.Cells(0).Value)
                        .Parameters.AddWithValue("@tranxtype", "Issued")
                        .Parameters.AddWithValue("@tranxsource", "Issued Stock")
                        .Parameters.AddWithValue("@tranxgroup", row.Cells(4).Value)
                        .Parameters.AddWithValue("@oldqty", row.Cells(1).Value)
                        .Parameters.AddWithValue("@qtyIssued", row.Cells(3).Value)
                        .Parameters.AddWithValue("@qtyrecieved", "0")
                        .Parameters.AddWithValue("@Balance", row.Cells(4).Value)
                        .Parameters.AddWithValue("@Rprice", row.Cells(2).Value)
                        .Parameters.AddWithValue("@Cprice", row.Cells(2).Value)
                        .Parameters.AddWithValue("@Ramt", row.Cells(5).Value)
                        .Parameters.AddWithValue("@Camt", row.Cells(5).Value)
                        .Parameters.AddWithValue("@Nar", txtNarration.Text)
                        .Parameters.AddWithValue("@userid", tsuser.Text)
                        .Parameters.AddWithValue("@Date", txtdate.Text)
                        .Parameters.AddWithValue("@Time", tstime.Text)
                        .ExecuteNonQuery()
                    End With
                    'MsgBox("Succesfully Wrintten into ledger")
                Next
                If Val(txtAmtPaid.Text) > 0 Then
                    Dim query = "insert into customerpayment(Customername,oldbal,datepaid,amtpaid,newbal,Paymentmode,Recievedby) values('" + cbSuppName.Text + "','" + lblOldBal.Text + "','" + txtdate.Text + "','" + txtAmtPaid.Text + "','" + lblNewBal.Text + "','" + cbPaymentMode.Text + "','" + tsuser.Text + "') "
                    cmd = New SqlCommand(query, Poscon)
                    cmd.ExecuteNonQuery()
                End If
                Poscon.Close()
                'MsgBox("Record Saved")
            Finally
                For k = 0 To gvStockBatch.RowCount - 1
                    If Poscon.State = ConnectionState.Closed Then
                        Poscon.Open()
                    End If
                    Dim sqll = "Select * from StockMast where Prodcode='" + gvStockBatch.Rows(k).Cells(6).Value + "'"
                    cmd = New SqlCommand(sqll, Poscon)
                    dr = cmd.ExecuteReader
                    While dr.Read

                        Dim query = "update StockMast set prodqty = '" & dr.Item("ProdQty") - gvStockBatch.Rows(k).Cells(3).Value & "' where Prodcode= " & gvStockBatch.Rows(k).Cells(6).Value & ""
                        cmd = New SqlCommand(query, Poscon)
                        cmd.ExecuteNonQuery()
                    End While
                Next

                If Poscon.State = ConnectionState.Closed Then
                    Poscon.Open()
                End If
                Dim sql = "update Customer set CurrentBalance = '" & lblNewBal.Text & "' where customerNo= " & lblCustNo.Text & ""
                cmd = New SqlCommand(sql, Poscon)
                cmd.ExecuteNonQuery()
                'MsgBox("Goods Recieved Successful")
                Poscon.Close()
                Display()
                reciept()
                gvStockBatch.Rows.Clear()
                If ckPreview.Checked = True Or ckprint.Checked = True Then
                    printreciept(txtinvoiceno.Text)
                End If
                clear()
                cbSuppName.SelectedItem = ""
            End Try
        End If
        ShowConfig()
        cbSearchItem.Focus()
    End Sub
    Private Sub printreciept(valuetosearch As String)
        Try
            Dim query = "select * from IssueStock where InvoiceNo ='" + valuetosearch + "'"
            If Poscon.State = ConnectionState.Closed Then
                Poscon.Open()
            End If
            dt.Tables("IssueStock").Rows.Clear()
            cmd = New SqlCommand(query, Poscon)
            da.SelectCommand = cmd
            da.Fill(dt, "IssueStock")

            Dim sql = "select * from ClientReg"
            dt.Tables("ClientReg").Rows.Clear()
            cmd = New SqlCommand(sql, Poscon)
            da.SelectCommand = cmd
            da.Fill(dt, "ClientReg")

            Dim report As New rptGoodsIssued
            report.SetDataSource(dt)
            If ckprint.Checked = True Then
                report.PrintToPrinter(1, True, 0, 0)
            End If
            If ckPreview.Checked = True Then
                frmSupplierReport.Show()
                frmSupplierReport.CrystalReportViewer1.ReportSource = report
                frmSupplierReport.CrystalReportViewer1.Refresh()
            End If


            cmd.Dispose()
            da.Dispose()
            Poscon.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        tstime.Text = Date.Now.ToString("hh:mm:ss")
    End Sub

    Private Sub BunifuThinButton23_Click(sender As Object, e As EventArgs) Handles BunifuThinButton23.Click
        Dim ask As MsgBoxResult
        ask = MsgBox("Would you like to clear Cart?", MsgBoxStyle.YesNo, "")
        If ask = MsgBoxResult.Yes Then
            gvStockBatch.Rows.Clear()
        End If
    End Sub

    Private Sub txtAmtPaid_TextChanged(sender As Object, e As EventArgs) Handles txtAmtPaid.TextChanged
        Dim newbal = Val(lblOldBal.Text) + Val(lblTotal.Text) - Val(txtAmtPaid.Text)
        lblNewBal.Text = newbal

        Dim totbal = Val(lblOldBal.Text) + Val(lblTotal.Text)
        lbltotalbal.Text = totbal
    End Sub

    Public Sub BunifuThinButton24_Click(sender As Object, e As EventArgs) Handles BunifuThinButton24.Click
        frmRetailIssueing_Load(e, e)
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

    Private Sub BunifuThinButton25_Click(sender As Object, e As EventArgs) Handles BunifuThinButton25.Click
        printreciept(txtReprintInvoice.Text)
    End Sub

    Private Sub cbSearchItem_TextChanged(sender As Object, e As EventArgs) Handles cbSearchItem.TextChanged
        Search(cbSearchItem.Text)
    End Sub
    Public Sub Search(valueTosearch As String)
        Try
            If Poscon.State = ConnectionState.Closed Then
                Poscon.Open()
            End If
            If cbCatSort.SelectedIndex = -1 Then
                Dim query = "select ProdName,prodqty,ProdCat,retailprice,packprice,packsize,baseqty,Prodcode from StockMast where concat(ProdName,ProdCode) like '%" + valueTosearch + "%'"
                cmd = New SqlCommand(query, Poscon)
                Dim adapter As New SqlDataAdapter(cmd)
                Dim table As New DataTable()
                adapter.Fill(table)
                gvStockBf.DataSource = table
            Else
                Dim query = "select ProdName,prodqty,ProdCat,retailprice,packprice,packsize,baseqty,Prodcode from StockMast where concat(ProdName,ProdCode) like '%" + valueTosearch + "%' and ProdCat = '" + cbCatSort.Text + "'"
                cmd = New SqlCommand(query, Poscon)
                Dim adapter As New SqlDataAdapter(cmd)
                Dim table As New DataTable()
                adapter.Fill(table)
                gvStockBf.DataSource = table
            End If

            Poscon.Close()
        Catch ex As Exception
            ' MsgBox(ex.ToString)
        End Try

    End Sub
    Sub Sort(valuetosearch As String)
        Dim query = "select ProdName,prodqty,ProdCat,retailprice,packprice,packsize,baseqty,Prodcode from StockMast where ProdCat like '%" + valuetosearch + "%'"
        cmd = New SqlCommand(query, Poscon)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable()
        adapter.Fill(table)
        gvStockBf.DataSource = table
    End Sub
    Private Sub ShowConfigs()
        If Poscon.State = ConnectionState.Closed Then
            Poscon.Open()
        End If
        Dim que = "select IssueId from Issueconfig"
        cmd = New SqlCommand(que, Poscon)
        Dim da As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        da.Fill(table)
        If table.Rows.Count() = 0 Then
            txtinvoiceno.Text = "2100001"
        Else

            Dim index = table.Rows.Count() - 1
            Dim reciept = table.Rows(index)(0).ToString
            txtinvoiceno.Text = reciept + 1
        End If
        Poscon.Close()
    End Sub
    Private Sub ShowConfig()
        If Poscon.State = ConnectionState.Closed Then
            Poscon.Open()
        End If
        Dim recieptcount As String
        Dim nextreciept As String
        Dim que = "select issuecount from Issueconfig"
        cmd = New SqlCommand(que, Poscon)
        Dim da As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        da.Fill(table)
        If table.Rows.Count() = 0 Then
            txtinvoiceno.Text = "210001"
        Else

            Dim index = table.Rows.Count() - 1
            Dim reciept = table.Rows(index)(0).ToString
            nextreciept = reciept + 1
            recieptcount = nextreciept.Count.ToString
            Select Case recieptcount
                Case "1"
                    txtinvoiceno.Text = "21000" + nextreciept
                Case "2"
                    txtinvoiceno.Text = "2100" + nextreciept
                Case "3"
                    txtinvoiceno.Text = "210" + nextreciept
                Case "4"
                    txtinvoiceno.Text = "21" + nextreciept
                Case "5"
                    txtinvoiceno.Text = nextreciept
                Case Else
                    txtinvoiceno.Text = nextreciept

            End Select
        End If


        Poscon.Close()


    End Sub
    Private Sub reciept()
        If Poscon.State = ConnectionState.Closed Then
            Poscon.Open()
        End If
        Dim sql = "insert into issueconfig(customer,issueid,date) values('" + cbSuppName.Text + "','" + txtinvoiceno.Text + "','" + txtdate.Text + "') "
        cmd = New SqlCommand(sql, Poscon)
        cmd.ExecuteNonQuery()
        Poscon.Close()

    End Sub
    Public Sub FillIssue(valueTosearch As String)
        Try
            If Poscon.State = ConnectionState.Closed Then
                Poscon.Open()
            End If

            Dim query = "select ProdName,prodqty,ProdCat,retailprice,packprice,packsize,baseqty,Prodcode from StockMast where concat(ProdName,ProdCode) like '%" + valueTosearch + "%'"
            cmd = New SqlCommand(query, Poscon)
            da = New SqlDataAdapter(cmd)
            Dim table As New DataTable()
            da.Fill(table)
            gvStockBf.DataSource = table

            txtItemName.Text = table.Rows(0)(0).ToString
            txtItemPrice.Text = table.Rows(0)(3).ToString
            txtActualStock.Text = table.Rows(0)(1).ToString
            lblProdcode.Text = table.Rows(0)(7).ToString
            txtCat.Text = table.Rows(0)(2).ToString
            txtPackSize.Text = table.Rows(0)(5).ToString
            txtbaseQty.Text = table.Rows(0)(6).ToString
            lblpackprice.Text = table.Rows(0)(4).ToString
            txtPackVolume.Text = Val(txtPackSize.Text * txtbaseQty.Text)

            Poscon.Close()
        Catch ex As Exception
            clear()
        End Try
    End Sub

    Private Sub cbSearchItem_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbSearchItem.KeyPress

    End Sub

    Private Sub cbSearchItem_KeyDown(sender As Object, e As KeyEventArgs) Handles cbSearchItem.KeyDown
        If e.KeyCode = Keys.Enter Then
            FillIssue(cbSearchItem.Text)
            txtQtyRecieved.Focus()
        End If
        'e.SuppressKeyPress = True
    End Sub

    Private Sub txtQtyRecieved_KeyDown(sender As Object, e As KeyEventArgs) Handles txtQtyRecieved.KeyDown
        If txtQtyRecieved.Text Is Nothing Then
            MsgBox("Enter Qty")
            Exit Sub
        End If
        If e.KeyCode = Keys.Enter Then
            BunifuThinButton21_Click(Nothing, Nothing)
            cbSearchItem.Focus()
        End If
    End Sub

    Private Sub cbSuppName_KeyDown(sender As Object, e As KeyEventArgs) Handles cbSuppName.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtAmtPaid.Focus()
        End If
    End Sub

    Private Sub txtAmtPaid_KeyDown(sender As Object, e As KeyEventArgs) Handles txtAmtPaid.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnSave.Focus()
        End If
    End Sub

    Private Sub btnSave_KeyDown(sender As Object, e As KeyEventArgs) Handles btnSave.KeyDown
        If e.KeyCode = Keys.Enter Then
            BunifuThinButton22_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub cbCatSort_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbCatSort.SelectionChangeCommitted
        Sort(cbCatSort.Text)
    End Sub

    Private Sub BunifuThinButton21_Click_1(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        cbCatSort.SelectedIndex = -1
        cbProdlineSort.SelectedIndex = -1
        Display()
    End Sub

    Private Sub txtdate_ValueChanged(sender As Object, e As EventArgs) Handles txtdate.ValueChanged
        lbldate.Text = txtdate.Text
    End Sub
End Class