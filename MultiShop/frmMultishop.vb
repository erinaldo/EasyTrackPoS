Imports System.Data.SqlClient
Public Class frmMultishop

    'Dim poscon As New SqlConnection(My.Settings.PoSConnectionString)
    Dim dr As SqlDataReader
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter
    Dim dt As New dsSalesTranx
    Dim tbl As DataTable
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        'Dim f2 As New frmSalesMenu
        'f2.Show()
        Me.Hide()
    End Sub

    Private Sub frmSales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StockCheck()

        SessionCheck()
        ckCashDisc.Checked = True
        txtCashDisc.Enabled = True
        ckPerDisc.Checked = False
        txtPerDisc.Enabled = False

        If Poscon.State = ConnectionState.Closed Then
            Poscon.Open()
        End If
        cmd = New SqlCommand("select * from userlogs", Poscon)
        da = New SqlDataAdapter(cmd)
        tbl = New DataTable
        da.Fill(tbl)
        If tbl.Rows.Count = 0 Then
        Else
            Dim index = tbl.Rows.Count() - 1
            Activeuser.Text = tbl.Rows(index)(1).ToString
            lblBranch.Text = tbl.Rows(index)(5).ToString
        End If

        Poscon.Close()


        'ckrollPaper.Checked = True
        'ckA5Paper.Checked = False
        'ckA4.Checked = False
        ShowConfig()
        Me.MaximumSize = Screen.FromRectangle(Me.Bounds).WorkingArea.Size
        WindowState = FormWindowState.Maximized
        Timer1.Enabled = True

        ShowBand()
        clear()

        txtProdname.Focus()
        cbPaymode.SelectedIndex = 0
        lblCustType.Text = ""
    End Sub
    Private Sub clear()
        txtCashPaid.Text = ""
        txtProdcode.Text = ""
        txtPrice.Text = ""
        cbProdName.Text = ""
        txtAmt.Text = ""
        txtQty.Text = ""
        txtCat.Text = ""
        lblCustNo.Text = ""
        lblChange.Text = ""
        lblActualStock.Text = ""
        lblNewBal.Text = ""
        lblOldBal.Text = ""
        cbCreditCustName.Text = ""
        txtCat.Text = ""
        txtColour.Text = ""
        txtProdline.Text = ""
        txtSize.Text = ""
        txtBuyerName.Text = ""
        txtBuyerTel.Text = ""
        lblProformaInvoice.Text = "100#"
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If lblProformaInvoice.Text <> "100#" Then
            MsgBox("You cannot add items to a proforma.")
            Exit Sub
        End If
        Dim sum As Decimal = 0
        Dim payable As Decimal = 0
        Dim DiscAmt As Decimal = 0
        If lblProdName.Text = "" Or txtQty.Text = "" Or txtPrice.Text = "" Then
            MsgBox("Select Item or Input Quantity", vbCritical)
        Else
            If Poscon.State = ConnectionState.Closed Then
                Poscon.Open()
            End If

            Dim query = "Select * from StockMast where Prodcode='" + txtProdcode.Text + "'"
            cmd = New SqlCommand(query, Poscon)
            dr = cmd.ExecuteReader
            While dr.Read
                If dr.Item("ProdQty") Is Nothing Then
                    lblActualStock.Text = 0
                Else
                    lblActualStock.Text = dr.Item("ProdQty")
                End If
                For Each row As DataGridViewRow In gvSales.Rows
                    If txtProdcode.Text = row.Cells(5).Value Then
                        row.Cells(1).Value += Val(txtQty.Text)
                        row.Cells(3).Value = row.Cells(1).Value * row.Cells(2).Value
                        row.Cells(8).Value = (Val(lblActualStock.Text) - Val(row.Cells(1).Value))
                        row.Cells(12).Value = row.Cells(3).Value
                        'For discount percentage
                        If row.Cells(13).Value = "%" Then
                            Dim Discprice As Decimal
                            Discprice = (Val(txtPerDisc.Text) / 100) * row.Cells(3).Value
                            row.Cells(10).Value = txtPerDisc.Text
                            row.Cells(11).Value = Discprice
                            row.Cells(12).Value = row.Cells(3).Value - Discprice

                        End If
                        'for Money Discount
                        'If row.Cells(13).Value = "$" Then
                        'Dim Discprice As Decimal
                        'Discprice = row.Cells(3).Value - Val(txtCashDisc.Text)
                        'row.Cells(10).Value = txtCashDisc.Text
                        ' row.Cells(12).Value = Discprice
                        'row.Cells(11).Value = row.Cells(3).Value - Discprice

                        'End If

                        If ckPerDisc.Checked = True Then
                            For k = 0 To gvSales.RowCount - 1
                                If row.Cells(10).Value = "" Then
                                    row.Cells(12).Value = row.Cells(3).Value
                                    row.Cells(11).Value = 0
                                End If
                                sum += gvSales.Rows(k).Cells(3).Value
                                payable += gvSales.Rows(k).Cells(12).Value
                                DiscAmt += gvSales.Rows(k).Cells(11).Value
                            Next
                            lblTotal.Text = sum
                            lblPayable.Text = payable
                            lblDiscAmt.Text = DiscAmt
                        End If

                        Poscon.Close()
                        clear()
                        dr.Close()

                        Try
                            For k = 0 To gvSales.RowCount - 1
                                If gvSales.Rows(k).Cells(10).ToString = "" Then
                                    gvSales.Rows(k).Cells(12).Value = gvSales.Rows(k).Cells(3).Value
                                    gvSales.Rows(k).Cells(11).Value = "0"
                                End If
                                sum += gvSales.Rows(k).Cells(3).Value
                                payable += gvSales.Rows(k).Cells(12).Value
                                DiscAmt += gvSales.Rows(k).Cells(11).Value
                            Next
                            lblTotal.Text = sum
                            lblPayable.Text = payable
                            lblDiscAmt.Text = DiscAmt
                        Catch ex As Exception
                            MsgBox(ex.Message)
                        End Try
                        Exit Sub

                    End If

                Next

                Dim a = Val(txtQty.Text)
                Dim c = Val(lblActualStock.Text)
                Dim newstock = c - a
                gvSales.Rows.Add(lblProdName.Text, txtQty.Text, txtPrice.Text, txtAmt.Text, txtCat.Text, txtProdcode.Text, txtSize.Text, txtProdline.Text, newstock, lblRecieptNo.Text, "0", "0", txtAmt.Text, "", txtColour.Text, lblActualStock.Text)

            End While
            dr.Close()

        End If

        txtCashPaid.Text = ""
        txtProdcode.Text = ""
        txtPrice.Text = ""
        cbProdName.Text = ""
        txtAmt.Text = ""
        txtQty.Text = ""
        txtCat.Text = ""
        'lblCustNo.Text = ""
        lblChange.Text = ""
        lblActualStock.Text = ""
        lblNewBal.Text = ""
        lblOldBal.Text = ""
        cbCreditCustName.Text = ""
        txtCat.Text = ""
        txtColour.Text = ""
        txtProdline.Text = ""
        txtSize.Text = ""

    End Sub
    Public Sub Feel(valueTosearch As String)
        Try
            If Poscon.State = ConnectionState.Closed Then
                Poscon.Open()
            End If
            If cbCatSort.SelectedIndex = -1 And cbProdlineSort.SelectedIndex = -1 Then
                reload("select ProdName,ProdQty,retailprice,Prodsize,ProdCat,ProdColour,Prodline,ProdCode from multishopStockMast where concat(ProdName,ProdCode) like '%" + valueTosearch + "%' and shopname='" + cbCreditCustName.Text + "'", gvStock)
            End If
            If cbCatSort.SelectedIndex <> -1 And cbProdlineSort.SelectedIndex = -1 Then

                reload("select ProdName,ProdQty,retailprice,Prodsize,ProdCat,ProdColour,Prodline,ProdCode from multishopStockMast where concat(ProdName,ProdCode) like '%" + valueTosearch + "%' and prodcat like '%" + cbCatSort.Text + "%' and shopname='" + cbCreditCustName.Text + "'", gvStock)

            End If
            If cbCatSort.SelectedIndex = -1 And cbProdlineSort.SelectedIndex <> -1 Then

                reload("select ProdName,ProdQty,retailprice,Prodsize,ProdCat,ProdColour,Prodline,ProdCode from multishopStockMast where concat(ProdName,ProdCode) like '%" + valueTosearch + "%' and Prodline like '%" + cbProdlineSort.Text + "%' and shopname='" + cbCreditCustName.Text + "'", gvStock)

            End If

            If cbCatSort.SelectedIndex <> -1 And cbProdlineSort.SelectedIndex <> -1 Then

                reload("select ProdName,ProdQty,retailprice,Prodsize,ProdCat,ProdColour,Prodline,ProdCode from multishopStockMast where concat(ProdName,ProdCode) like '%" + valueTosearch + "%' and prodcat like '%" + cbCatSort.Text + "%' and Prodline like '%" + cbProdlineSort.Text + "%' and shopname='" + cbCreditCustName.Text + "'", gvStock)

            End If
            Poscon.Close()
        Catch ex As Exception

        End Try
    End Sub
    Public Sub Search(valuetosearch As String)
        Try
            If Poscon.State = ConnectionState.Closed Then
                Poscon.Open()
            End If
            Dim query = "select * from customer where concat(customername,Customerno) like '%" + valuetosearch + "%'"
            cmd = New SqlCommand(query, Poscon)
            da = New SqlDataAdapter(cmd)
            tbl = New DataTable()
            da.Fill(tbl)
            lblOldBal.Text = tbl.Rows(0)(10).ToString
            lblCustNo.Text = tbl.Rows(0)(0).ToString
            lblCustType.Text = tbl.Rows(0)(12).ToString
            Dim newbal = Val(lblOldBal.Text) + Val(lblTotal.Text)
            lblNewBal.Text = newbal
            Poscon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Display()
        reload("select ProdName,ProdQty,retailprice,Prodsize,ProdCat,ProdColour,Prodline,ProdCode from multishopstockmast where shopname='" + cbCreditCustName.Text + "'", gvStock)
        'cbSaleslist.Items.Clear()
        'cbSaleslist.Items.Add(lblBranch.Text)
        ''If cbSaleslist.SelectedIndex = 0 Or cbSaleslist.SelectedIndex = -1 Then
        ''    reload("select ProdName,ProdQty,retailprice,Prodsize,ProdCat,ProdColour,Prodline,ProdCode from StockMast", gvStock)
        ''End If
        ''If cbSaleslist.SelectedIndex = 1 Then
        ''    reload("select * from Packages", gvStock)
        ''End If
        ''If cbSaleslist.SelectedIndex = 2 Then
        ''    reload("select * from Proformaconfig where Status='" + "Pending" + "'", gvStock)
        ''End If
        'Select Case cbSaleslist.SelectedIndex
        '    Case 0
        '        reload("select ProdName,ProdQty,retailprice,Prodsize,ProdCat,ProdColour,Prodline,ProdCode from StockMast", gvStock)
        '    Case 1
        '        reload("select * from Packagesconfig", gvStock)
        '    Case 2
        '        reload("select * from Proformaconfig where Status='" + "Pending" + "'", gvStock)
        '    Case 3
        '        reload("select ProdName,ProdQty,retailprice,Prodsize,ProdCat,ProdColour,Prodline,ProdCode from StockMast where baseqty*packsize<>1", gvStock)
        '    Case 4
        '        reload("select ProdName,ProdQty,retailprice,Prodsize,ProdCat,ProdColour,Prodline,ProdCode from StockMast where baseqty*packsize=1", gvStock)

        'End Select
        ' cbSaleslist.Items.Add(lblBranch.Text)
        'ComboFeed("select Customername from Customer where customername='" + lblBranch.Text + "'", cbSaleslist, 0)
    End Sub

    Private Sub cbProdName_TextUpdate(sender As Object, e As EventArgs) Handles cbProdName.TextUpdate
        'Feel(txtProdname.Text)
    End Sub
    Private Sub gvStock_CellClick(sender As Object, e As DataGridViewCellEventArgs)
        Try
            Dim row As DataGridViewRow = gvStock.Rows(e.RowIndex)
            cbProdName.Text = row.Cells(1).Value.ToString()
            lblProdName.Text = row.Cells(1).Value.ToString()
            txtPrice.Text = row.Cells(7).Value.ToString()
            txtProdcode.Text = row.Cells(0).Value.ToString()
            lblActualStock.Text = row.Cells(6).Value.ToString()
            txtProdline.Text = row.Cells(2).Value.ToString()
            txtCat.Text = row.Cells(5).Value.ToString()
            txtSize.Text = row.Cells(3).Value.ToString()
            txtColour.Text = row.Cells(4).Value.ToString()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        ''txtProdName.Text = ""
    End Sub
    Private Sub ShowBand()

        reload("select * from PriceBand", gvPriceBand)
    End Sub
    Private Sub txtQty_TextChanged(sender As Object, e As EventArgs) Handles txtQty.TextChanged
        If txtQty.Text = "" Then
            Exit Sub
        End If
        'Price Bands
        'For Each row As DataGridViewRow In gvPriceBand.Rows
        '    If row.Cells(1).Value = lblProdName.Text And row.Cells(3).Value <= CDbl(txtQty.Text) And row.Cells(4).Value >= CDbl(txtQty.Text) Then
        '        txtPrice.Text = row.Cells(5).Value
        '    Else
        '        'txtPrice.Text = lblOPrice.Text
        '    End If
        '    'MsgBox(row.Cells(5).Value)
        'Next

        Dim amt As Decimal
        amt = Val(txtQty.Text) * Val(txtPrice.Text)
        txtAmt.Text = amt
    End Sub

    Private Sub gvSales_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs)

        Try
            Dim sum As Decimal = 0
            For k = 0 To gvSales.RowCount - 1
                sum += gvSales.Rows(k).Cells(3).Value

            Next
            lblTotal.Text = sum
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub txtCashPaid_TextChanged(sender As Object, e As EventArgs) Handles txtCashPaid.TextChanged
        Dim CashPaid As Decimal = 0
        Dim change As Decimal = 0
        change = Val(txtCashPaid.Text) - Val(lblPayable.Text)
        lblChange.Text = change
    End Sub

    Private Sub reciept()
        Try
            create("insert into Recieptconfig(Salesperson,recieptid,date) values('" + Activeuser.Text + "','" + lblRecieptNo.Text + "','" + lblDate.Text + "') ")

        Catch ex As Exception
            MsgBox(ex.Message, ex.ToString)
        End Try

    End Sub
    Private Sub ShowConfig()
        'Try
        '    If Poscon.State = ConnectionState.Closed Then
        '        Poscon.Open()
        '    End If
        '    Dim recieptcount As String
        '    Dim nextreciept As String
        '    cmd = New SqlCommand("select * from recieptconfig", Poscon)
        '    Dim da As New SqlDataAdapter(cmd)
        '    Dim table As New DataTable
        '    da.Fill(table)
        '    If table.Rows.Count() = 0 Then
        '        lblRecieptNo.Text = "10001"
        '    Else
        '        Dim index = table.Rows.Count() - 1
        '        Dim reciept = table.Rows(index)(0).ToString
        '        nextreciept = reciept + 1
        '        recieptcount = nextreciept.Count.ToString
        '        Select Case recieptcount
        '            Case "1"
        '                lblRecieptNo.Text = "1000" + nextreciept
        '            Case "2"
        '                lblRecieptNo.Text = "100" + nextreciept
        '            Case "3"
        '                lblRecieptNo.Text = "10" + nextreciept
        '            Case "4"
        '                lblRecieptNo.Text = "1" + nextreciept
        '            Case "5"
        '                lblRecieptNo.Text = "A" + nextreciept
        '            Case Else
        '                lblRecieptNo.Text = "A" + nextreciept
        '        End Select
        '    End If
        '    Poscon.Close()
        'Catch ex As Exception
        '    MsgBox(ex.Message, ex.ToString)
        'End Try

        Newshowconfig()

    End Sub
    Public Sub Newshowconfig()
        Dim digit As Integer
        Dim result As String
        If Poscon.State = ConnectionState.Closed Then
            Poscon.Open()
        End If
        cmd = New SqlCommand("select max(Recieptid) from recieptconfig", Poscon)
        result = cmd.ExecuteScalar.ToString

        If String.IsNullOrEmpty(result) Then
            result = "ET000000"
            lblRecieptNo.Text = result
        Else
            result = result.Substring(3)
            Int32.TryParse(result, digit)
            digit = digit + 1
            result = "ET" + digit.ToString("D6")
            lblRecieptNo.Text = result
        End If

    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTime.Text = Date.Now.ToString("hh:mm:ss")
        'lblDate.Text = Date.Now.ToString("dd-MMM-yy")
    End Sub

    Private Sub txtProdName_KeyUp(sender As Object, e As KeyEventArgs)
        Feel(txtProdname.Text)

    End Sub

    Private Sub lblTotal_TextChanged(sender As Object, e As EventArgs) Handles lblTotal.TextChanged
        Dim newbal As New Decimal
        newbal = Val(lblOldBal.Text) + Val(lblTotal.Text)
        lblNewBal.Text = newbal
    End Sub

    Private Sub cbCreditCustName_DropDownClosed(sender As Object, e As EventArgs) Handles cbCreditCustName.DropDownClosed
        'Search(cbCreditCustName.Text)
    End Sub

    Private Sub cbCreditCustName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCreditCustName.SelectedIndexChanged
        Search(lblBranch.Text)
        If lblCustType.Text = "Branch Customer" Then
            If lblBranch.Text = "" Then
                reload("select ProdName,ProdQty,retailprice,Prodsize,ProdCat,ProdColour,Prodline,ProdCode from multishopstockmast where shopname='" + cbCreditCustName.Text + "'", gvStock)
                Exit Sub
            End If
            reload("select ProdName,ProdQty,retailprice,Prodsize,ProdCat,ProdColour,Prodline,ProdCode from multishopstockmast where shopname='" + lblBranch.Text + "'", gvStock)
        End If
    End Sub

    Private Sub txtPrice_TextChanged(sender As Object, e As EventArgs) Handles txtPrice.TextChanged
        Dim amt As Decimal
        amt = Val(txtQty.Text) * Val(txtPrice.Text)
        txtAmt.Text = amt
    End Sub

    Private Sub cbCreditCustName_TextUpdate(sender As Object, e As EventArgs) Handles cbCreditCustName.TextUpdate
        'Search(cbCreditCustName.Text)
    End Sub



    Private Sub txtQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQty.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            'MsgBox("This field will accept numbers only")
        End If
    End Sub

    Private Sub txtCashPaid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCashPaid.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            'MsgBox("This field will accept numbers only")
        End If
    End Sub

    Private Sub txtProdname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtProdname.KeyPress
        Feel(txtProdname.Text)
    End Sub

    Private Sub txtProdname_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtProdname.Validating
        Itemfill()
    End Sub
    Sub Itemfill()
        If txtProdname.Text = "" Then
            txtPrice.Text = ""
            txtProdcode.Text = ""
            lblActualStock.Text = ""
            txtProdline.Text = ""
            txtCat.Text = ""
            txtSize.Text = ""
            txtColour.Text = ""
            lblProdName.Text = ""
        End If
    End Sub

    Private Sub txtProdname_Validated(sender As Object, e As EventArgs) Handles txtProdname.Validated
        Itemfill()
    End Sub

    Private Sub txtProdname_TextChanged(sender As Object, e As EventArgs) Handles txtProdname.TextChanged
        Itemfill()
    End Sub

    Private Sub gvStock_CellClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles gvStock.CellClick

        Try

            Dim row As DataGridViewRow = gvStock.Rows(e.RowIndex)
            cbProdName.Text = row.Cells(0).Value.ToString()
            'lblProdName.Text = row.Cells(0).Value.ToString()
            txtPrice.Text = row.Cells(2).Value.ToString()
            lblActualStock.Text = row.Cells(1).Value.ToString()
            txtProdcode.Text = row.Cells(7).Value.ToString()
            txtProdline.Text = row.Cells(6).Value.ToString()
            txtCat.Text = row.Cells(4).Value.ToString()
            txtSize.Text = row.Cells(3).Value.ToString()
            txtColour.Text = row.Cells(5).Value.ToString()
            lblOPrice.Text = row.Cells(2).Value.ToString()
            lblProdName.Text = row.Cells(0).Value.ToString()
            txtQty.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        '    Case 1
        '        If gvSales.Rows.Count <> 0 Then
        '            Dim ask As MsgBoxResult
        '            ask = MsgBox("Would you like to clear Cart?", MsgBoxStyle.YesNo, "")
        '            If ask = MsgBoxResult.Yes Then
        '                gvSales.Rows.Clear()
        '                Dim row As DataGridViewRow = gvStock.Rows(e.RowIndex)
        '                lblPackageid.Text = row.Cells(0).Value.ToString()
        '                If Poscon.State = ConnectionState.Closed Then
        '                    Poscon.Open()
        '                End If
        '                Dim queryy = ("Select Itemname,qtysold,retailprice,amount,prodcat,itemcode,itemsize,prodline,Itemcolour,Packagename,amountpayable from Packages where packageid like '%" + lblPackageid.Text + "%'")
        '                cmd = New SqlCommand(queryy, Poscon)
        '                da = New SqlDataAdapter(cmd)
        '                tbl = New DataTable()
        '                da.Fill(tbl)
        '                If tbl.Rows.Count = 0 Then
        '                    MsgBox("Package Empty")
        '                    Exit Sub
        '                End If

        '                lblProdName.Text = tbl.Rows(0)(9).ToString

        '                ' lblPayable.Text = tbl.Rows(0)(15).ToString

        '                For k = 0 To tbl.Rows.Count - 1
        '                    gvSales.Rows.Add(tbl.Rows(k)(0).ToString, tbl.Rows(k)(1).ToString, tbl.Rows(k)(2).ToString, tbl.Rows(k)(3).ToString, tbl.Rows(k)(4).ToString, tbl.Rows(k)(5).ToString, tbl.Rows(k)(6).ToString, tbl.Rows(k)(7).ToString, 0, lblRecieptNo.Text, "", 0, tbl.Rows(k)(3).ToString, "", tbl.Rows(k)(8).ToString, 0)
        '                Next
        '                Poscon.Close()
        '            End If
        '            txtCashPaid.Focus()
        '        Else
        '            Dim row As DataGridViewRow = gvStock.Rows(e.RowIndex)
        '            lblPackageid.Text = row.Cells(0).Value.ToString()
        '            If Poscon.State = ConnectionState.Closed Then
        '                Poscon.Open()
        '            End If
        '            Dim queryy = ("Select Itemname,qtysold,retailprice,amount,prodcat,itemcode,itemsize,prodline,Itemcolour,Packagename,amountpayable from Packages where packageid like '%" + lblPackageid.Text + "%'")
        '            cmd = New SqlCommand(queryy, Poscon)
        '            da = New SqlDataAdapter(cmd)
        '            tbl = New DataTable()
        '            da.Fill(tbl)
        '            If tbl.Rows.Count = 0 Then
        '                MsgBox("Package Empty")
        '                Exit Sub
        '            End If

        '            lblProdName.Text = tbl.Rows(0)(9).ToString

        '            ' lblPayable.Text = tbl.Rows(0)(15).ToString

        '            For k = 0 To tbl.Rows.Count - 1
        '                gvSales.Rows.Add(tbl.Rows(k)(0).ToString, tbl.Rows(k)(1).ToString, tbl.Rows(k)(2).ToString, tbl.Rows(k)(3).ToString, tbl.Rows(k)(4).ToString, tbl.Rows(k)(5).ToString, tbl.Rows(k)(6).ToString, tbl.Rows(k)(7).ToString, 0, lblRecieptNo.Text, "", 0, tbl.Rows(k)(3).ToString, "", tbl.Rows(k)(8).ToString, 0)
        '            Next
        '            Poscon.Close()

        '        End If
        '    Case 2
        '        If gvSales.Rows.Count <> 0 Then
        '            Dim ask As MsgBoxResult
        '            ask = MsgBox("Would you like to clear Cart?", MsgBoxStyle.YesNo, "")
        '            If ask = MsgBoxResult.Yes Then
        '                gvSales.Rows.Clear()
        '                Dim row As DataGridViewRow = gvStock.Rows(e.RowIndex)
        '                lblProformaInvoice.Text = row.Cells(0).Value.ToString()
        '                If Poscon.State = ConnectionState.Closed Then
        '                    Poscon.Open()
        '                End If
        '                Dim queryy = ("Select Itemname,qtysold,retailprice,amount,prodcat,itemcode,itemsize,prodline,Itemcolour,buyername,buyertel,buyerlocation,amountpayable from proformainvoices where invoiceno like '%" + lblProformaInvoice.Text + "%'")
        '                cmd = New SqlCommand(queryy, Poscon)
        '                da = New SqlDataAdapter(cmd)
        '                tbl = New DataTable()
        '                da.Fill(tbl)
        '                If tbl.Rows.Count = 0 Then
        '                    MsgBox("ProForma Empty")
        '                    Exit Sub
        '                End If

        '                txtBuyerName.Text = tbl.Rows(0)(9).ToString
        '                txtBuyerTel.Text = tbl.Rows(0)(10).ToString
        '                cbLocation.Text = tbl.Rows(0)(11).ToString
        '                ' lblPayable.Text = tbl.Rows(0)(15).ToString

        '                For k = 0 To tbl.Rows.Count - 1
        '                    gvSales.Rows.Add(tbl.Rows(k)(0).ToString, tbl.Rows(k)(1).ToString, tbl.Rows(k)(2).ToString, tbl.Rows(k)(3).ToString, tbl.Rows(k)(4).ToString, tbl.Rows(k)(5).ToString, tbl.Rows(k)(6).ToString, tbl.Rows(k)(7).ToString, 0, lblRecieptNo.Text, 0, 0, tbl.Rows(k)(3).ToString, 0, tbl.Rows(k)(8).ToString, 0)
        '                Next
        '                Poscon.Close()
        '            End If
        '            txtCashPaid.Focus()
        '        Else
        '            If Poscon.State = ConnectionState.Closed Then
        '                Poscon.Open()
        '            End If
        '            Dim row As DataGridViewRow = gvStock.Rows(e.RowIndex)
        '            lblProformaInvoice.Text = row.Cells(0).Value.ToString()
        '            If Poscon.State = ConnectionState.Closed Then
        '                Poscon.Open()
        '            End If
        '            Dim queryy = ("Select Itemname,qtysold,retailprice,amount,prodcat,itemcode,itemsize,prodline,Itemcolour,buyername,buyertel,buyerlocation,amountpayable from proformainvoices where invoiceno like '%" + lblProformaInvoice.Text + "%'")
        '            cmd = New SqlCommand(queryy, Poscon)
        '            da = New SqlDataAdapter(cmd)
        '            tbl = New DataTable()
        '            da.Fill(tbl)
        '            If tbl.Rows.Count = 0 Then
        '                MsgBox("ProForma Empty")
        '                Exit Sub
        '            End If

        '            txtBuyerName.Text = tbl.Rows(0)(9).ToString
        '            txtBuyerTel.Text = tbl.Rows(0)(10).ToString
        '            cbLocation.Text = tbl.Rows(0)(11).ToString
        '            ' lblPayable.Text = tbl.Rows(0)(15).ToString

        '            For k = 0 To tbl.Rows.Count - 1
        '                gvSales.Rows.Add(tbl.Rows(k)(0).ToString, tbl.Rows(k)(1).ToString, tbl.Rows(k)(2).ToString, tbl.Rows(k)(3).ToString, tbl.Rows(k)(4).ToString, tbl.Rows(k)(5).ToString, tbl.Rows(k)(6).ToString, tbl.Rows(k)(7).ToString, 0, lblRecieptNo.Text, 0, 0, tbl.Rows(k)(3).ToString, 0, tbl.Rows(k)(8).ToString, 0)
        '            Next
        '            Poscon.Close()
        '        End If
        '        txtCashPaid.Focus()
        '    Case 3
        '        Try

        '            Dim row As DataGridViewRow = gvStock.Rows(e.RowIndex)
        '            cbProdName.Text = row.Cells(0).Value.ToString()
        '            'lblProdName.Text = row.Cells(0).Value.ToString()
        '            txtPrice.Text = row.Cells(2).Value.ToString()
        '            lblActualStock.Text = row.Cells(1).Value.ToString()
        '            txtProdcode.Text = row.Cells(7).Value.ToString()
        '            txtProdline.Text = row.Cells(6).Value.ToString()
        '            txtCat.Text = row.Cells(4).Value.ToString()
        '            txtSize.Text = row.Cells(3).Value.ToString()
        '            txtColour.Text = row.Cells(5).Value.ToString()
        '            lblOPrice.Text = row.Cells(2).Value.ToString()
        '            lblProdName.Text = row.Cells(0).Value.ToString()
        '            '+ "-" + txtProdline.Text + ""
        '            txtQty.Focus()
        '        Catch ex As Exception
        '            msgbox(ex.message)
        '        End Try
        '    Case 4
        '        Try

        '            Dim row As DataGridViewRow = gvStock.Rows(e.RowIndex)
        '            cbProdName.Text = row.Cells(0).Value.ToString()
        '            'lblProdName.Text = row.Cells(0).Value.ToString()
        '            txtPrice.Text = row.Cells(2).Value.ToString()
        '            lblActualStock.Text = row.Cells(1).Value.ToString()
        '            txtProdcode.Text = row.Cells(7).Value.ToString()
        '            txtProdline.Text = row.Cells(6).Value.ToString()
        '            txtCat.Text = row.Cells(4).Value.ToString()
        '            txtSize.Text = row.Cells(3).Value.ToString()
        '            txtColour.Text = row.Cells(5).Value.ToString()
        '            lblOPrice.Text = row.Cells(2).Value.ToString()
        '            lblProdName.Text = row.Cells(0).Value.ToString()
        '            '+ "-" + txtProdline.Text + ""
        '            txtQty.Focus()
        '        Catch ex As Exception
        '            msgbox(ex.message)
        '        End Try

        '    Case Else

        'End Select


    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Hide()
        PfrmSalesMgmt.btnOpenSession.Visible = False
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        If WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Maximized
        ElseIf WindowState = FormWindowState.Maximized Then
            WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub gvSales_RowsAdded_1(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles gvSales.RowsAdded
        Try
            Dim sum As Decimal = 0
            Dim payable As Decimal = 0
            Dim discamt As Decimal = 0
            For k = 0 To gvSales.RowCount - 1
                If gvSales.Rows(k).Cells(10).ToString = "" Then
                    gvSales.Rows(k).Cells(12).Value = gvSales.Rows(k).Cells(3).Value
                    gvSales.Rows(k).Cells(11).Value = "0"
                End If
                sum += gvSales.Rows(k).Cells(3).Value
                payable += gvSales.Rows(k).Cells(12).Value
                discamt += gvSales.Rows(k).Cells(11).Value
            Next
            lblTotal.Text = sum
            lblPayable.Text = payable
            lblDiscAmt.Text = discamt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub SessionCheck()
        If Poscon.State = ConnectionState.Closed Then
            Poscon.Open()
        End If
        cmd = New SqlCommand("select convert(datetime,dateopened,103) from Sessionledger", Poscon)
        da = New SqlDataAdapter(cmd)
        tbl = New DataTable
        da.Fill(tbl)
        DataGridView1.DataSource = tbl
        If tbl.Rows.Count = 0 Then
            lblDate.Text = Date.Now.ToString("dd/MM/yyyy")
        Else
            Dim index = tbl.Rows.Count - 1
            'MsgBox(Date.Parse(tbl.Rows(index)(0).ToString))
            lblDate.Text = Date.Parse(tbl.Rows(index)(0).ToString)
        End If
        Poscon.Close()
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        If Date.Parse(lblDate.Text) <> Date.Now.ToString("dd/MM/yyyy") Then
            MsgBox("Date Conflict. Kindly adjust Computer Date to " + lblDate.Text + "")
            Exit Sub
        End If


        ShowConfig()
        ''Send sms Message
        'If tksendsms.Checked = True Then
        '    Try
        '        If Poscon.State = ConnectionState.Closed Then
        '            Poscon.Open()
        '        End If
        '        Dim que = " SELECT fromemail, mailsubject,body,fromsms,smsbody,smsapikey  FROM Emailconfig"
        '        cmd = New SqlCommand(que, Poscon)
        '        da = New SqlDataAdapter(cmd)
        '        tbl = New DataTable
        '        da.Fill(tbl)
        '        If tbl.Rows.Count = 0 Then
        '            MsgBox("Reconfigure Sms and try again")
        '        Else
        '            Sendsms(tbl.Rows(0)(5).ToString, tbl.Rows(0)(3).ToString, txtBuyerTel.Text, tbl.Rows(0)(4).ToString + "")
        '        End If
        '    Catch ex As Exception
        '        MsgBox(ex.Message)
        '    End Try


        'End If

        'If Val(txtCashPaid.Text) < Val(lblPayable.Text) Then
        '    MsgBox("Cash paid not enough", vbCritical)
        '    Exit Sub
        'End If
        If ckrollPaper.Checked = False And ckA5Paper.Checked = False And ckA4.Checked = False Then
            MsgBox("Select Print format")
            Exit Sub
        End If

        If gvSales.RowCount = 0 Then
            MsgBox("Select Sale Type or Fill sale Cart", vbCritical)
            Exit Sub
        Else

            'cbCreditCustName.Visible = True
            'lblCreditCust.Visible = Truejn
            Dim a = Val(lblTotal.Text)
            Dim b = Val(lblOldBal.Text)
            Dim sum = b + a
            lblNewBal.Text = sum
            If cbCreditCustName.Text = "" Then
                MsgBox("Choose customer")
            Else

                'reciept()
                'Dim i As Integer

                For Each row As DataGridViewRow In gvSales.Rows

                    If Poscon.State = ConnectionState.Closed Then
                        Poscon.Open()
                    End If
                    Dim query = "insert into salestranx (ItemCode,ItemName,ProdLine,ProdCat,ItemSize,ItemColour,QtySold,DateSold,TimeSold,BuyerName,BuyerTel,BuyerLocation,NewStock,RetailPrice,SaleType,CredCustName,Amount,Soldby,RecieptNo,AmtPaid,Balance,DiscountRate,DiscountAmount,AmountPayable,TotalDiscount,customertype) values(@ItemCode,@ItemName,@ProdLine,@ProdCat,@ItemSize,@ItemColour,@QtySold,convert(datetime,@DateSold,105),@TimeSold,@BuyerName,@BuyerTel,@BuyerLocation,@NewStock,@RetailPrice,@SaleType,@CreditCustomerName,@Amount,'" + Activeuser.Text + "', '" + lblRecieptNo.Text + "','" + txtCashPaid.Text + "','" + lblChange.Text + "',@Discount,@DiscAmt,@Amtpayable,'" + lblDiscAmt.Text + "','" + lblCustType.Text + "')"
                    cmd = New SqlCommand(query, Poscon)
                    With cmd

                        .Parameters.AddWithValue("@ItemCode", SqlDbType.NVarChar).Value = row.Cells(5).Value
                        .Parameters.AddWithValue("@Itemname", row.Cells(0).Value)
                        .Parameters.AddWithValue("@ProdLine", row.Cells(7).Value)
                        .Parameters.AddWithValue("@ProdCat", row.Cells(4).Value)
                        .Parameters.AddWithValue("@ItemSize", row.Cells(6).Value)
                        .Parameters.AddWithValue("@ItemColour", row.Cells(5).Value)
                        .Parameters.AddWithValue("@QtySold", row.Cells(1).Value)
                        .Parameters.AddWithValue("@DateSold", SqlDbType.Date).Value = lblDate.Text
                        .Parameters.AddWithValue("@TimeSold", lblTime.Text)
                        .Parameters.AddWithValue("@BuyerName", txtBuyerName.Text)
                        .Parameters.AddWithValue("@BuyerTel", txtBuyerTel.Text)
                        .Parameters.AddWithValue("@BuyerLocation", cbLocation.Text)
                        .Parameters.AddWithValue("@NewStock", row.Cells(8).Value)
                        .Parameters.AddWithValue("@RetailPrice", row.Cells(2).Value)
                        .Parameters.AddWithValue("@Saletype", "Credit Sale")
                        .Parameters.AddWithValue("@CreditCustomerName", cbCreditCustName.Text)
                        .Parameters.AddWithValue("@Amount", row.Cells(3).Value)
                        .Parameters.AddWithValue("@Discount", row.Cells(10).Value)
                        .Parameters.AddWithValue("@DiscAmt", row.Cells(11).Value)
                        .Parameters.AddWithValue("@AmtPayable", value:=(lblPayable.Text))
                        .ExecuteNonQuery()
                    End With
                Next
                'If Poscon.State = ConnectionState.Closed Then
                '    Poscon.Open()
                'End If
                'Dim quer = "Insert into CustomerLedger(CustomerName,oldbal,Newbal,CreditRecieved,DateRecieved,TimeRecieved,CustomerNo)Values('" + cbCreditCustName.Text + "','" + lblOldBal.Text + "','" + lblNewBal.Text + "','" + lblTotal.Text + "',convert(datetime,'" + lblDate.Text + "',105),'" + lblTime.Text + "','" + lblCustNo.Text + "')"
                'cmd = New SqlCommand(quer, Poscon)
                'cmd.ExecuteNonQuery()

                'Dim que = "update Customer set CurrentBalance=@CurBal where CustomerNo = @custno"
                'cmd = New SqlCommand(que, Poscon)
                'With cmd
                '    .Parameters.AddWithValue("@custno", lblCustNo.Text)
                '    .Parameters.AddWithValue("@CurBal", CDbl(lblNewBal.Text))
                '    .ExecuteNonQuery()

                'End With



                For Each row As DataGridViewRow In gvSales.Rows
                    cmd = New SqlCommand("Select * from multishopStockMast where Prodcode='" + row.Cells(5).Value + "' and shopname='" + cbCreditCustName.Text + "' and shopno='" + lblCustNo.Text + "'", Poscon)
                    dr = cmd.ExecuteReader()
                    While dr.Read
                        cmd = New SqlCommand("update multishopstockmast set prodqty=@Prodqty where Prodcode= '" & row.Cells(5).Value.ToString & "' and shopname='" + cbCreditCustName.Text + "' and shopno='" + lblCustNo.Text + "'", Poscon)
                        With cmd
                            .Parameters.AddWithValue("@prodcode", dr.Item("Prodcode"))
                            .Parameters.AddWithValue("@prodqty", dr.Item("ProdQty") - row.Cells(1).Value)
                            .ExecuteNonQuery()
                        End With
                    End While

                Next


                For Each row As DataGridViewRow In gvSales.Rows
                    Dim sql = "insert into InventoryLedger (ItemCode,itemname,tranxtype,TranxSource,TranxGroup,oldqty,qtyIssued,StockBalance,Userid,RetailPrice,CostPrice,RetailAmt,CostAmt,time,date,customertype) values(@ItemCode,@Itemname,@Tranxtype,@tranxsource,@TranxGroup,@oldqty,@qtyIssued,@balance,@userid,@Rprice,@cprice,@ramt,@camt,@time,convert(datetime,@Date,105),'" + lblCustType.Text + "')"
                    cmd = New SqlCommand(sql, Poscon)
                    With cmd
                        .Parameters.AddWithValue("@ItemCode", row.Cells(5).Value)
                        .Parameters.AddWithValue("@Itemname", row.Cells(0).Value)
                        .Parameters.AddWithValue("@tranxtype", "Issued")
                        .Parameters.AddWithValue("@tranxsource", "Sales")
                        .Parameters.AddWithValue("@tranxgroup", row.Cells(4).Value)
                        .Parameters.AddWithValue("@oldqty", row.Cells(15).Value)
                        .Parameters.AddWithValue("@qtyIssued", row.Cells(1).Value)
                        .Parameters.AddWithValue("@Balance", row.Cells(8).Value)
                        .Parameters.AddWithValue("@Rprice", row.Cells(2).Value)
                        .Parameters.AddWithValue("@Cprice", row.Cells(2).Value)
                        .Parameters.AddWithValue("@Ramt", row.Cells(5).Value)
                        .Parameters.AddWithValue("@Camt", row.Cells(5).Value)
                        .Parameters.AddWithValue("@userid", Activeuser.Text)
                        .Parameters.AddWithValue("@Date", lblDate.Text)
                        .Parameters.AddWithValue("@Time", lblTime.Text)
                        .ExecuteNonQuery()
                    End With

                Next
                Poscon.Close()

                ShowConfig()
                'MsgBox("StockMast Updated")
                reciept()
                If ckprintpreview.Checked = True Or ckprint.Checked = True Then
                    If ckA5Paper.Checked = True Then
                        PrintRecieptA5(lblRecieptNo.Text)
                    ElseIf ckrollPaper.Checked = True Then
                        RollReciept(lblRecieptNo.Text)
                    ElseIf ckA4.Checked = True Then
                        PrintRecieptA4(lblRecieptNo.Text)
                    End If
                End If

                gvSales.Rows.Clear()
                lblTotal.Text = ""
                clear()
                Display()

                lblTotal.Text = ""

            End If
        End If

        'If tksendsms.Checked = True Then
        '    Dim que = " SELECT fromemail, mailsubject,body,fromsms,smsbody,smsapikey  FROM Emailconfig"
        '    cmd = New SqlCommand(que, Poscon)
        '    da = New SqlDataAdapter(cmd)
        '    tbl = New DataTable
        '    da.Fill(tbl)
        '    If tbl.Rows.Count = 0 Then
        '        MsgBox("Reconfigure Sms and try again")
        '    Else
        '        Sendsms(tbl.Rows(0)(5).ToString, tbl.Rows(0)(3).ToString, txtBuyerTel.Text, tbl.Rows(0)(4).ToString + "")
        '    End If

        'End If
        ShowConfig()
        txtProdname.Focus()
    End Sub

    Private Sub ckrollPaper_Click(sender As Object, e As EventArgs) Handles ckrollPaper.Click
        If ckrollPaper.Checked = False Then
            ckA5Paper.Checked = True
            ckA4.Checked = False
        Else
            ckA5Paper.Checked = False
            ckA4.Checked = False
        End If
        If ckA5Paper.Checked = False And ckrollPaper.Checked = False Then
            ckA4.Checked = True
        End If
    End Sub

    Private Sub ckA5Paper_Click(sender As Object, e As EventArgs) Handles ckA5Paper.Click
        If ckA5Paper.Checked = False Then
            ckrollPaper.Checked = True
            ckA4.Checked = False
        Else
            ckrollPaper.Checked = False
            ckA4.Checked = False
        End If
        If ckA5Paper.Checked = False And ckrollPaper.Checked = False Then
            ckA4.Checked = True
        End If
    End Sub

    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click
        Dim ask As MsgBoxResult
        ask = MsgBox("Would you like to clear Cart?", MsgBoxStyle.YesNo, "")
        If ask = MsgBoxResult.Yes Then
            lblProformaInvoice.Text = "100#"
            gvSales.Rows.Clear()
        End If

    End Sub

    Private Sub gvSales_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles gvSales.RowsRemoved
        If gvSales.Rows.Count = 0 Then
            lblProformaInvoice.Text = "100#"
        End If
        Try
            Dim sum As Decimal = 0
            Dim payable As Decimal = 0
            Dim discamt As Decimal = 0
            For k = 0 To gvSales.RowCount - 1
                If gvSales.Rows(k).Cells(10).ToString = "" Then
                    gvSales.Rows(k).Cells(12).Value = gvSales.Rows(k).Cells(3).Value
                    gvSales.Rows(k).Cells(11).Value = "0"
                End If
                sum += gvSales.Rows(k).Cells(3).Value
                payable += gvSales.Rows(k).Cells(12).Value
                discamt += gvSales.Rows(k).Cells(11).Value
            Next
            lblTotal.Text = sum
            lblPayable.Text = payable
            lblDiscAmt.Text = discamt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub gvSales_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles gvSales.CellClick
        Try
            Dim row As DataGridViewRow = gvSales.Rows(e.RowIndex)
            txtDiscName.Text = row.Cells(0).Value.ToString()
            lbldiscCode.Text = row.Cells(5).Value.ToString()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub BunifuCheckBox2_Click(sender As Object, e As EventArgs) Handles ckPerDisc.Click
        If ckPerDisc.Checked = False Then
            ckCashDisc.Checked = True
            txtCashDisc.Enabled = True
        Else
            ckCashDisc.Checked = False
            txtCashDisc.Enabled = False
        End If

        If ckCashDisc.Checked = False Then
            txtCashDisc.Enabled = False
            txtPerDisc.Enabled = True
        Else
            txtCashDisc.Enabled = True
            txtPerDisc.Enabled = False
        End If

    End Sub

    Private Sub BunifuCheckBox1_Click(sender As Object, e As EventArgs) Handles ckCashDisc.Click
        If ckCashDisc.Checked = False Then
            ckPerDisc.Checked = True

        Else
            ckPerDisc.Checked = False

        End If

        If ckPerDisc.Checked = False Then
            txtPerDisc.Enabled = False
            txtCashDisc.Enabled = True
        Else
            txtPerDisc.Enabled = True
            txtCashDisc.Enabled = False
        End If

    End Sub

    Private Sub BunifuThinButton23_Click(sender As Object, e As EventArgs) Handles BunifuThinButton23.Click

        If lbldiscCode.Text = "" Then
            MsgBox("Select Item to Discount")
            Exit Sub
        End If


        Dim sum As Decimal = 0
        Dim payable As Decimal = 0
        Dim DiscAmt As Decimal = 0
        If ckPerDisc.Checked = True Then
            For Each row As DataGridViewRow In gvSales.Rows

                If lbldiscCode.Text = row.Cells(5).Value Then
                    If row.Cells(10).Value = 0 Then
                        Dim Discprice As Decimal
                        Discprice = (Val(txtPerDisc.Text) / 100) * row.Cells(3).Value
                        row.Cells(10).Value = txtPerDisc.Text
                        row.Cells(11).Value = Discprice
                        row.Cells(12).Value = row.Cells(3).Value - Discprice
                        row.Cells(13).Value = "%"
                    Else
                        MsgBox("Discount Already Added", vbCritical)
                        lbldiscCode.Text = ""
                        txtDiscName.Text = ""
                        Exit Sub
                    End If
                End If
            Next
            For k = 0 To gvSales.RowCount - 1
                If gvSales.Rows(k).Cells(10).ToString = "" Then
                    gvSales.Rows(k).Cells(12).Value = gvSales.Rows(k).Cells(3).Value
                    gvSales.Rows(k).Cells(11).Value = "0"
                End If
                sum += gvSales.Rows(k).Cells(3).Value
                payable += gvSales.Rows(k).Cells(12).Value
                DiscAmt += gvSales.Rows(k).Cells(11).Value
            Next
            lblTotal.Text = sum
            lblPayable.Text = payable
            lblDiscAmt.Text = DiscAmt
            MsgBox("Discount Added")

        End If
        If ckCashDisc.Checked = True Then
            For Each row As DataGridViewRow In gvSales.Rows
                If lbldiscCode.Text = row.Cells(5).Value Then
                    If row.Cells(10).Value = 0 Then
                        Dim Discprice As Decimal
                        Discprice = row.Cells(3).Value - Val(txtCashDisc.Text)
                        row.Cells(10).Value = txtCashDisc.Text
                        row.Cells(12).Value = Discprice
                        row.Cells(11).Value = row.Cells(3).Value - Discprice
                        row.Cells(13).Value = "$"
                    Else

                        MsgBox("Discount Already Added", vbCritical)
                        lbldiscCode.Text = ""
                        txtDiscName.Text = ""
                        Exit Sub
                    End If
                End If

            Next
            For k = 0 To gvSales.RowCount - 1
                If gvSales.Rows(k).Cells(10).Value = "" Then
                    gvSales.Rows(k).Cells(12).Value = gvSales.Rows(k).Cells(3).Value
                    gvSales.Rows(k).Cells(11).Value = "0"
                End If
                sum += gvSales.Rows(k).Cells(3).Value
                payable += gvSales.Rows(k).Cells(12).Value
                DiscAmt += gvSales.Rows(k).Cells(11).Value
            Next
            lblTotal.Text = sum
            lblPayable.Text = payable
            lblDiscAmt.Text = DiscAmt
            MsgBox("Discount Added")
        End If

        lbldiscCode.Text = ""
        txtDiscName.Text = ""
    End Sub

    Private Sub BunifuThinButton25_Click(sender As Object, e As EventArgs) Handles BunifuThinButton25.Click
        If gvSales.Rows.Count = 0 Then
            MsgBox("Make a sale to Discount")
            Exit Sub
        End If

        Dim sum As Decimal = 0
        Dim payable As Decimal = 0
        Dim DiscAmt As Decimal = 0

        If ckPerDisc.Checked = True Then
            Dim ask As MsgBoxResult
            ask = MsgBox("Would you like to discount Cart by " + txtPerDisc.Text + "%?", MsgBoxStyle.YesNo, "")
            If ask = MsgBoxResult.Yes Then
                For Each row As DataGridViewRow In gvSales.Rows

                    If True Then
                        If row.Cells(10).Value = 0 Then
                            Dim Discprice As Decimal
                            Discprice = (Val(txtPerDisc.Text) / 100) * row.Cells(3).Value
                            row.Cells(10).Value = txtPerDisc.Text
                            row.Cells(11).Value = Discprice
                            row.Cells(12).Value = row.Cells(3).Value - Discprice
                            row.Cells(13).Value = "%"
                        Else
                            MsgBox("Discount Already Added", vbCritical)
                            lbldiscCode.Text = ""
                            txtDiscName.Text = ""
                            Exit Sub
                        End If
                    End If
                Next
                For k = 0 To gvSales.RowCount - 1
                    If gvSales.Rows(k).Cells(10).ToString = "" Then
                        gvSales.Rows(k).Cells(12).Value = gvSales.Rows(k).Cells(3).Value
                        gvSales.Rows(k).Cells(11).Value = "0"
                    End If
                    sum += gvSales.Rows(k).Cells(3).Value
                    payable += gvSales.Rows(k).Cells(12).Value
                    DiscAmt += gvSales.Rows(k).Cells(11).Value
                Next
                If txtPerDisc.Text = "" Then
                Else
                    lblPayable.Text = Val(lblTotal.Text) - (Val(lblTotal.Text) * (Val(txtPerDisc.Text) / 100))
                End If
                lblTotal.Text = sum
                'lblPayable.Text = payable
                lblDiscAmt.Text = DiscAmt
                MsgBox("Discount Added")

            End If
        End If
        If ckCashDisc.Checked = True Then
            Dim ask As MsgBoxResult
            ask = MsgBox("Would you like to discount Cart by ¢" + txtCashDisc.Text + "?", MsgBoxStyle.YesNo, "")
            If ask = MsgBoxResult.Yes Then
                For Each row As DataGridViewRow In gvSales.Rows
                    If True Then

                        If row.Cells(10).Value = 0 Then
                            Dim Discprice As Decimal
                            Discprice = row.Cells(3).Value - Val(txtCashDisc.Text)
                            row.Cells(10).Value = txtCashDisc.Text
                            row.Cells(11).Value = Val(row.Cells(3).Value - Discprice) / Val(gvSales.Rows.Count)
                            row.Cells(12).Value = row.Cells(3).Value - row.Cells(11).Value
                            row.Cells(13).Value = "$"
                        Else

                            MsgBox("Discount Already Added", vbCritical)
                            lbldiscCode.Text = ""
                            txtDiscName.Text = ""
                            Exit Sub
                        End If
                    End If

                Next
                For k = 0 To gvSales.RowCount - 1
                    If gvSales.Rows(k).Cells(10).Value = "" Then
                        gvSales.Rows(k).Cells(12).Value = gvSales.Rows(k).Cells(3).Value
                        gvSales.Rows(k).Cells(11).Value = "0"
                    End If
                    sum += gvSales.Rows(k).Cells(3).Value
                    payable += gvSales.Rows(k).Cells(12).Value
                    DiscAmt += gvSales.Rows(k).Cells(11).Value
                Next
                If txtCashDisc.Text = "" Then
                Else
                    lblPayable.Text = Val(lblTotal.Text) - Val(txtCashDisc.Text)
                End If
                lblTotal.Text = sum
                'lblPayable.Text = payable
                lblDiscAmt.Text = Math.Round(DiscAmt)
                MsgBox("Discount Added")
            End If
        End If

        lbldiscCode.Text = ""
        txtDiscName.Text = ""

    End Sub
    Public Sub FillSale(valueTosearch As String)
        Try
            If Poscon.State = ConnectionState.Closed Then
                Poscon.Open()
            End If

            Dim query = "select ProdName,ProdQty,retailprice,Prodsize,ProdCat,ProdColour,Prodline,ProdCode from StockMast where concat(ProdName,ProdCode) like '%" + valueTosearch + "%'"
            cmd = New SqlCommand(query, Poscon)
            da = New SqlDataAdapter(cmd)
            tbl = New DataTable()
            da.Fill(tbl)
            gvStock.DataSource = tbl
            'reload("select ProdName,ProdQty,retailprice,Prodsize,ProdCat,ProdColour,Prodline,ProdCode from StockMast where concat(ProdName,ProdCode) like '%" + valueTosearch + "%'", gvStock)

            cbProdName.Text = tbl.Rows(0)(0).ToString
            lblProdName.Text = tbl.Rows(0)(0).ToString
            'lblProdName.Text = table.Rows(0)(0).ToString + " " + "(" + txtProdline.Text + ")"
            txtPrice.Text = tbl.Rows(0)(2).ToString
            lblActualStock.Text = tbl.Rows(0)(1).ToString
            txtProdcode.Text = tbl.Rows(0)(7).ToString
            txtProdline.Text = tbl.Rows(0)(6).ToString
            txtCat.Text = tbl.Rows(0)(4).ToString
            txtSize.Text = tbl.Rows(0)(3).ToString
            txtColour.Text = tbl.Rows(0)(5).ToString
            Poscon.Close()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub txtProdname_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles txtProdname.SelectionChangeCommitted
        FillSale(txtProdname.SelectedItem)
    End Sub

    Private Sub txtProdname_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtProdname.SelectedIndexChanged
        FillSale(txtProdname.SelectedItem)
    End Sub

    Private Sub txtQty_MouseLeave(sender As Object, e As EventArgs) Handles txtQty.MouseLeave
        If txtQty.Text = "" Then
            Exit Sub
        End If
        For Each row As DataGridViewRow In gvPriceBand.Rows
            If row.Cells(1).Value = lblProdName.Text And row.Cells(3).Value <= CDbl(txtQty.Text) And row.Cells(4).Value >= CDbl(txtQty.Text) Then
                txtPrice.Text = row.Cells(5).Value
            Else
                'txtPrice.Text = lblOPrice.Text
            End If
            'MsgBox(row.Cells(5).Value)
        Next

        Dim amt As Decimal
        amt = Val(txtQty.Text) * Val(txtPrice.Text)
        txtAmt.Text = amt
    End Sub

    Private Sub BunifuThinButton27_Click(sender As Object, e As EventArgs) Handles BunifuThinButton27.Click
        frmSales_Load(e, e)
    End Sub

    Private Sub ckA4_Click(sender As Object, e As EventArgs) Handles ckA4.Click
        If ckA4.Checked = True Then
            ckA5Paper.Checked = False
            ckrollPaper.Checked = False
        Else
            ckA4.Checked = True
        End If
    End Sub

    Private Sub txtProdname_KeyDown(sender As Object, e As KeyEventArgs) Handles txtProdname.KeyDown
        If e.KeyCode = Keys.Enter Then
            FillSale(txtProdname.Text)
            txtQty.Focus()
        End If
    End Sub

    Private Sub txtQty_KeyDown(sender As Object, e As KeyEventArgs) Handles txtQty.KeyDown
        If txtQty.Text Is Nothing Then
            MsgBox("Enter Qty")
            Exit Sub
        End If
        If e.KeyCode = Keys.Enter Then
            PictureBox1_Click(Nothing, Nothing)
            txtProdname.Focus()
        End If
    End Sub

    Private Sub txtCashPaid_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCashPaid.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtBuyerName.Focus()
        End If
    End Sub

    Private Sub txtBuyerName_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBuyerName.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtBuyerTel.Focus()
        End If
    End Sub

    Private Sub txtBuyerTel_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBuyerTel.KeyDown
        If e.KeyCode = Keys.Enter Then
            SessionCheck()
            BunifuThinButton21_Click(Nothing, Nothing)
        End If
    End Sub

    Sub RollReciept(valuetosearch As String)
        Try
            If Poscon.State = ConnectionState.Closed Then
                Poscon.Open()
            End If

            Dim que = "select * from recieptconfig"
            cmd = New SqlCommand(que, Poscon)
            da = New SqlDataAdapter(cmd)
            Dim table As New DataTable
            da.Fill(table)
            Dim query = "select * from SalesTranx where recieptno='" + valuetosearch + "'"
            cmd = New SqlCommand(query, Poscon)
            dt.Tables("salesTranx").Rows.Clear()
            da.SelectCommand = cmd
            da.Fill(dt, "salesTranx")

            Dim sql = "select * from ClientReg"
            dt.Tables("ClientReg").Rows.Clear()
            cmd = New SqlCommand(sql, Poscon)
            da.SelectCommand = cmd
            da.Fill(dt, "ClientReg")

            Dim report As New rptSalesReciept
            report.SetDataSource(dt)
            If ckprint.Checked = True Then
                report.PrintToPrinter(1, True, 0, 0)
            End If
            If ckprintpreview.Checked = True Then
                frmSupplierReport.Show()
                frmSupplierReport.CrystalReportViewer1.ReportSource = report
                frmSupplierReport.CrystalReportViewer1.Refresh()
            End If
            cmd.Dispose()
            da.Dispose()
            Poscon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub PrintRecieptA4(valuetosearch As String)
        Try
            If Poscon.State = ConnectionState.Closed Then
                Poscon.Open()
            End If

            Dim que = "select * from recieptconfig"
            cmd = New SqlCommand(que, Poscon)
            da = New SqlDataAdapter(cmd)
            Dim table As New DataTable
            da.Fill(table)
            Dim query = "select * from SalesTranx where recieptno='" + valuetosearch + "'"
            cmd = New SqlCommand(query, Poscon)
            dt.Tables("salesTranx").Rows.Clear()
            da.SelectCommand = cmd
            da.Fill(dt, "salesTranx")

            Dim sql = "select * from ClientReg"
            dt.Tables("ClientReg").Rows.Clear()
            cmd = New SqlCommand(sql, Poscon)
            da.SelectCommand = cmd
            da.Fill(dt, "ClientReg")

            Dim report As New rptSalesRecieptA4
            report.SetDataSource(dt)
            If ckprint.Checked = True Then
                report.PrintToPrinter(1, True, 0, 0)
            End If
            If ckprintpreview.Checked = True Then
                frmSupplierReport.Show()
                frmSupplierReport.CrystalReportViewer1.ReportSource = report
                frmSupplierReport.CrystalReportViewer1.Refresh()
            End If

            cmd.Dispose()
            da.Dispose()
            Poscon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub PrintRecieptA5(valuetosearch As String)
        Try
            If Poscon.State = ConnectionState.Closed Then
                Poscon.Open()
            End If

            Dim que = "select * from recieptconfig"
            cmd = New SqlCommand(que, Poscon)
            da = New SqlDataAdapter(cmd)
            Dim table As New DataTable
            da.Fill(table)
            Dim query = "select * from SalesTranx where recieptno='" + valuetosearch + "'"
            cmd = New SqlCommand(query, Poscon)
            dt.Tables("salesTranx").Rows.Clear()
            da.SelectCommand = cmd
            da.Fill(dt, "salesTranx")

            Dim sql = "select * from ClientReg"
            dt.Tables("ClientReg").Rows.Clear()
            cmd = New SqlCommand(sql, Poscon)
            da.SelectCommand = cmd
            da.Fill(dt, "ClientReg")

            Dim report As New rptSalesRecieptA5
            report.SetDataSource(dt)
            If ckprint.Checked = True Then
                report.PrintToPrinter(1, True, 0, 0)
            End If
            If ckprintpreview.Checked = True Then
                frmSupplierReport.Show()
                frmSupplierReport.CrystalReportViewer1.ReportSource = report
                frmSupplierReport.CrystalReportViewer1.Refresh()
            End If
            cmd.Dispose()
            da.Dispose()
            Poscon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub Sortcat(valuetosearch As String)

        reload("select ProdName,ProdQty,retailprice,Prodsize,ProdCat,ProdColour,Prodline,ProdCode from StockMast where ProdCat like '%" + valuetosearch + "%'", gvStock)
    End Sub

    Sub Sortpline(valuetosearch As String)

        reload("select ProdName,ProdQty,retailprice,Prodsize,ProdCat,ProdColour,Prodline,ProdCode from StockMast where prodline like '%" + valuetosearch + "%'", gvStock)

    End Sub

    Private Sub BunifuThinButton28_Click(sender As Object, e As EventArgs) Handles BunifuThinButton28.Click
        If ckA5Paper.Checked = True Then
            PrintRecieptA5(txtReprintNo.Text)
        ElseIf ckrollPaper.Checked = True Then
            RollReciept(txtReprintNo.Text)
        ElseIf ckA4.Checked = True Then
            PrintRecieptA4(txtReprintNo.Text)
        End If
    End Sub

    Private Sub cbCatSort_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbCatSort.SelectionChangeCommitted
        Sortcat(cbCatSort.Text)
        'cbProdlineSort.SelectedIndex = -1
    End Sub

    Private Sub cbProdlineSort_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbProdlineSort.SelectionChangeCommitted
        Sortpline(cbProdlineSort.Text)
        'cbCatSort.SelectedIndex = -1
    End Sub

    Private Sub BunifuThinButton29_Click(sender As Object, e As EventArgs) Handles BunifuThinButton29.Click
        cbCatSort.SelectedIndex = -1
        cbProdlineSort.SelectedIndex = -1
        Display()
    End Sub

    Private Sub cbProdlineSort_Click(sender As Object, e As EventArgs) Handles cbProdlineSort.Click

        ComboFeed("select productline from productline", cbProdlineSort, 0)
    End Sub

    Private Sub cbCatSort_Click(sender As Object, e As EventArgs) Handles cbCatSort.Click

        ComboFeed("select category from Category", cbCatSort, 0)
    End Sub

    Private Sub cbCreditCustName_Click(sender As Object, e As EventArgs) Handles cbCreditCustName.Click
        If lblBranch.Text = "" Then
            ComboFeed("select customername from Customer where Customertype='" + "Branch Customer" + "' ", cbCreditCustName, 0)
            Exit Sub
        End If

        ComboFeed("select * from Customer where customername='" + lblBranch.Text + "'", cbCreditCustName, 1)
    End Sub

    Private Sub txtProdname_Enter(sender As Object, e As EventArgs) Handles txtProdname.Enter
        ComboFeed("select * from multishopStockmast where shopname='" + cbCreditCustName.Text + "'", txtProdname, 1)
    End Sub

    Public Sub StockCheck()

        If Poscon.State = ConnectionState.Closed Then
            Poscon.Open()
        End If
        Dim query = "select * from Stockmast where prodqty<=leastqtyreminder"
        cmd = New SqlCommand(query, Poscon)
        da = New SqlDataAdapter(cmd)
        tbl = New DataTable()
        da.Fill(tbl)
        If tbl.Rows.Count = 0 Then
        Else
            For k = 0 To tbl.Rows.Count - 1
                NotifyIcon1.Visible = True
                NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
                NotifyIcon1.BalloonTipText = tbl.Rows(k)(1).ToString + " " + "is below its normal stock level. Kindly restock"
                NotifyIcon1.BalloonTipTitle = "Stock Check"
                NotifyIcon1.ShowBalloonTip(20)
            Next
        End If
    End Sub

    Private Sub frmSales_Enter(sender As Object, e As EventArgs) Handles MyBase.Enter
        Display()
        SessionCheck()
    End Sub

    Private Sub BunifuThinButton21_MouseEnter(sender As Object, e As EventArgs) Handles BunifuThinButton21.MouseEnter
        SessionCheck()
    End Sub

    Private Sub cbSaleslist_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSaleslist.SelectedIndexChanged
        reload("select ProdName,ProdQty,retailprice,Prodsize,ProdCat,ProdColour,Prodline,ProdCode from multishopstockmast where shopname='" + cbCreditCustName.Text + "'", gvStock)
    End Sub
End Class
