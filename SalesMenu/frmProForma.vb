Imports System.Data.SqlClient
Public Class frmProForma
    'Dim poscon As New SqlConnection(My.Settings.PoSConnectionString)
    Dim dr As SqlDataReader
    Dim cmd As SqlCommand
    Dim builder As SqlCommandBuilder
    Dim da As SqlDataAdapter
    Dim dt As New dsproforma
    Dim tbl As DataTable
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        'Dim f2 As New frmSalesMenu
        'f2.Show()
        Me.Hide()
    End Sub

    Private Sub frmSales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'StockCheck()
        Display()

        If poscon.State = ConnectionState.Closed Then
            poscon.Open()
        End If
        Dim que = "select * from userlogs"
        cmd = New SqlCommand(que, poscon)
        Dim da As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        da.Fill(table)
        If table.Rows.Count = 0 Then
        Else
            Dim index = table.Rows.Count() - 1
            Activeuser.Text = table.Rows(index)(1).ToString
        End If

        poscon.Close()


        ckrollPaper.Checked = True
        ckA5Paper.Checked = False
        ckA4.Checked = False

        Me.MaximumSize = Screen.FromRectangle(Me.Bounds).WorkingArea.Size
        WindowState = FormWindowState.Maximized
        Timer1.Enabled = True


        ShowBand()
        clear()

        txtProdname.Focus()


    End Sub
    Private Sub clear()

        txtProdcode.Text = ""
        txtPrice.Text = ""
        cbProdName.Text = ""
        txtAmt.Text = ""
        txtQty.Text = ""
        txtCat.Text = ""


        lblActualStock.Text = ""

        txtCat.Text = ""
        txtColour.Text = ""
        txtProdline.Text = ""
        txtSize.Text = ""
        txtBuyerName.Text = ""
        txtBuyerTel.Text = ""
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim sum As Decimal = 0
        Dim payable As Decimal = 0
        Dim DiscAmt As Decimal = 0
        If lblProdName.Text = "" Or txtQty.Text = "" Or txtPrice.Text = "" Then
            MsgBox("Select Item or Input Quantity", vbCritical)
        Else
            If poscon.State = ConnectionState.Closed Then
                poscon.Open()
            End If

            Dim query = "Select * from StockMast where Prodcode='" + txtProdcode.Text + "'"
            cmd = New SqlCommand(query, poscon)
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
                        'If row.Cells(13).Value = "%" Then
                        '    Dim Discprice As Decimal
                        '    Discprice = (Val(txtPerDisc.Text) / 100) * row.Cells(3).Value
                        '    row.Cells(10).Value = txtPerDisc.Text
                        '    row.Cells(11).Value = Discprice
                        '    row.Cells(12).Value = row.Cells(3).Value - Discprice

                        'End If
                        'for Money Discount
                        'If row.Cells(13).Value = "$" Then
                        'Dim Discprice As Decimal
                        'Discprice = row.Cells(3).Value - Val(txtCashDisc.Text)
                        'row.Cells(10).Value = txtCashDisc.Text
                        ' row.Cells(12).Value = Discprice
                        'row.Cells(11).Value = row.Cells(3).Value - Discprice

                        'End If

                        'If ckPerDisc.Checked = True Then
                        '    For k = 0 To gvSales.RowCount - 1
                        '        If row.Cells(10).Value = "" Then
                        '            row.Cells(12).Value = row.Cells(3).Value
                        '            row.Cells(11).Value = 0
                        '        End If
                        '        sum += gvSales.Rows(k).Cells(3).Value
                        '        payable += gvSales.Rows(k).Cells(12).Value
                        '        DiscAmt += gvSales.Rows(k).Cells(11).Value
                        '    Next
                        '    lblTotal.Text = sum
                        '    lblPayable.Text = payable
                        '    lblDiscAmt.Text = DiscAmt
                        'End If

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
                            'lblDiscAmt.Text = DiscAmt
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


        txtProdcode.Text = ""
        txtPrice.Text = ""
        cbProdName.Text = ""
        txtAmt.Text = ""
        txtQty.Text = ""
        txtCat.Text = ""


        lblActualStock.Text = ""

        txtCat.Text = ""
        txtColour.Text = ""
        txtProdline.Text = ""
        txtSize.Text = ""


    End Sub

    Public Sub Feel(valueTosearch As String)
        Try
            If poscon.State = ConnectionState.Closed Then
                poscon.Open()
            End If
            If cbCatSort.SelectedIndex = -1 And cbProdlineSort.SelectedIndex = -1 Then
                Dim query = "select ProdName,ProdQty,retailprice,Prodsize,ProdCat,ProdColour,Prodline,ProdCode from StockMast where concat(ProdName,ProdCode) like '%" + valueTosearch + "%'"
                cmd = New SqlCommand(query, poscon)
                Dim adapter As New SqlDataAdapter(cmd)
                Dim table As New DataTable()
                adapter.Fill(table)
                gvStock.DataSource = table
                'Dim itemavailable As Boolean
                'itemavailable = table.Rows(0)(0).ToString = ""
                'If itemavailable Then
                'Else
                'If table.Rows(0)(0).ToString = txtProdname.Text And table.Rows.Count = 1 Then
                'cbProdName.Text = table.Rows(0)(7).ToString()
                'Else
                'MsgBox("No Record")
                ''txtProdName.Text = ""
                'End If
                'End If

            End If
            If cbCatSort.SelectedIndex <> -1 And cbProdlineSort.SelectedIndex = -1 Then
                Dim query = "select ProdName,ProdQty,retailprice,Prodsize,ProdCat,ProdColour,Prodline,ProdCode from StockMast where concat(ProdName,ProdCode) like '%" + valueTosearch + "%' and prodcat like '%" + cbCatSort.Text + "%'"
                cmd = New SqlCommand(query, poscon)
                Dim adapter As New SqlDataAdapter(cmd)
                Dim table As New DataTable()
                adapter.Fill(table)
                gvStock.DataSource = table
                'Dim itemavailable As Boolean
                'itemavailable = table.Rows(0)(0).ToString = ""
                'If itemavailable Then
                'Else
                'If table.Rows(0)(0).ToString = txtProdname.Text And table.Rows.Count = 1 Then
                'cbProdName.Text = table.Rows(0)(7).ToString()
                'Else
                'MsgBox("No Record")
                ''txtProdName.Text = ""
                'End If
                'End If
            End If
            If cbCatSort.SelectedIndex = -1 And cbProdlineSort.SelectedIndex <> -1 Then
                Dim query = "select ProdName,ProdQty,retailprice,Prodsize,ProdCat,ProdColour,Prodline,ProdCode from StockMast where concat(ProdName,ProdCode) like '%" + valueTosearch + "%' and Prodline like '%" + cbProdlineSort.Text + "%'"
                cmd = New SqlCommand(query, poscon)
                Dim adapter As New SqlDataAdapter(cmd)
                Dim table As New DataTable()
                adapter.Fill(table)
                gvStock.DataSource = table
                'Dim itemavailable As Boolean
                'itemavailable = table.Rows(0)(0).ToString = ""
                'If itemavailable Then
                'Else
                'If table.Rows(0)(0).ToString = txtProdname.Text And table.Rows.Count = 1 Then
                'cbProdName.Text = table.Rows(0)(7).ToString()
                'Else
                'MsgBox("No Record")
                ''txtProdName.Text = ""
                'End If
                'End If

            End If

            If cbCatSort.SelectedIndex <> -1 And cbProdlineSort.SelectedIndex <> -1 Then
                Dim query = "select ProdName,ProdQty,retailprice,Prodsize,ProdCat,ProdColour,Prodline,ProdCode from StockMast where concat(ProdName,ProdCode) like '%" + valueTosearch + "%' and prodcat like '%" + cbCatSort.Text + "%' and Prodline like '%" + cbProdlineSort.Text + "%'"
                cmd = New SqlCommand(query, poscon)
                Dim adapter As New SqlDataAdapter(cmd)
                Dim table As New DataTable()
                adapter.Fill(table)
                gvStock.DataSource = table
                'Dim itemavailable As Boolean
                'itemavailable = table.Rows(0)(0).ToString = ""
                'If itemavailable Then
                'Else
                'If table.Rows(0)(0).ToString = txtProdname.Text And table.Rows.Count = 1 Then
                'cbProdName.Text = table.Rows(0)(7).ToString()
                'Else
                'MsgBox("No Record")
                ''txtProdName.Text = ""
                'End If
                'End If

            End If
            poscon.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Display()
        reload("select * from Proformaconfig where Status='" + "Pending" + "'", gvProformaInvoice)
        reload("select ProdName,ProdQty,retailprice,Prodsize,ProdCat,ProdColour,Prodline,ProdCode from StockMast", gvStock)
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
        'reload("select * from PriceBand", gvPriceBand)
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




    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTime.Text = Date.Now.ToString("hh:mm:ss")
        lblDate.Text = Date.Now.ToString("dd-MMM-yy")
    End Sub

    Private Sub cbSaleType_TextChanged(sender As Object, e As EventArgs)
        'Search(cbCreditCustName.Text)
    End Sub

    Private Sub cbSaleType_DropDownClosed(sender As Object, e As EventArgs)

    End Sub

    Private Sub cbProdName_TextChanged(sender As Object, e As EventArgs) Handles cbProdName.TextChanged

    End Sub

    Private Sub cbProdName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbProdName.SelectedIndexChanged


    End Sub

    Private Sub txtProdName_KeyUp(sender As Object, e As KeyEventArgs)
        Feel(txtProdname.Text)

    End Sub

    Private Sub lblTotal_TextChanged(sender As Object, e As EventArgs) Handles lblTotal.TextChanged

    End Sub

    Private Sub cbCreditCustName_DropDownClosed(sender As Object, e As EventArgs)
        'Search(cbCreditCustName.Text)
    End Sub

    Private Sub cbCreditCustName_SelectedIndexChanged(sender As Object, e As EventArgs)
        'Search(cbCreditCustName.Text)
    End Sub

    Private Sub txtPrice_TextChanged(sender As Object, e As EventArgs) Handles txtPrice.TextChanged
        Dim amt As Decimal
        amt = Val(txtQty.Text) * Val(txtPrice.Text)
        txtAmt.Text = amt
    End Sub

    Private Sub cbCreditCustName_TextUpdate(sender As Object, e As EventArgs)
        'Search(cbCreditCustName.Text)
    End Sub

    Private Sub txtQty_KeyUp(sender As Object, e As KeyEventArgs) Handles txtQty.KeyUp

    End Sub

    Private Sub txtQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQty.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            'MsgBox("This field will accept numbers only")
        End If
    End Sub

    Private Sub txtCashPaid_KeyPress(sender As Object, e As KeyPressEventArgs)
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
            '+ "-" + txtProdline.Text + ""
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        ''txtProdName.Text = ""
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
            'lblDiscAmt.Text = discamt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
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
            gvSales.Rows.Clear()
        End If

    End Sub

    Private Sub gvSales_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles gvSales.RowsRemoved
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
            'lblDiscAmt.Text = discamt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub gvSales_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles gvSales.CellClick
        Dim row As DataGridViewRow = gvSales.Rows(e.RowIndex)
        lbldiscCode.Text = row.Cells(5).Value.ToString()
    End Sub

    Public Sub FillSale(valueTosearch As String)
        Try
            If Poscon.State = ConnectionState.Closed Then
                Poscon.Open()
            End If

            Dim query = "select ProdName,ProdQty,retailprice,Prodsize,ProdCat,ProdColour,Prodline,ProdCode from StockMast where concat(ProdName,ProdCode) like '%" + valueTosearch + "%'"
            cmd = New SqlCommand(query, Poscon)
            Dim adapter As New SqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)
            gvStock.DataSource = table


            cbProdName.Text = table.Rows(0)(0).ToString
            lblProdName.Text = table.Rows(0)(0).ToString
            'lblProdName.Text = table.Rows(0)(0).ToString + " " + "(" + txtProdline.Text + ")"
            txtPrice.Text = table.Rows(0)(2).ToString
            lblActualStock.Text = table.Rows(0)(1).ToString
            txtProdcode.Text = table.Rows(0)(7).ToString
            txtProdline.Text = table.Rows(0)(6).ToString
            txtCat.Text = table.Rows(0)(4).ToString
            txtSize.Text = table.Rows(0)(3).ToString
            txtColour.Text = table.Rows(0)(5).ToString


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

    Private Sub BunifuThinButton26_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub txtQty_MouseLeave(sender As Object, e As EventArgs) Handles txtQty.MouseLeave
        If txtQty.Text = "" Then
            Exit Sub
        End If
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

    Private Sub txtCashPaid_KeyDown(sender As Object, e As KeyEventArgs)
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
            'BunifuThinButton21_Click(Nothing, Nothing)
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

    Private Sub PrintA4(valuetosearch As String)
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
        If Poscon.State = ConnectionState.Closed Then
            Poscon.Open()
        End If
        Dim query = "select ProdName,ProdQty,retailprice,Prodsize,ProdCat,ProdColour,Prodline,ProdCode from StockMast where ProdCat like '%" + valuetosearch + "%'"
        cmd = New SqlCommand(query, Poscon)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable()
        adapter.Fill(table)
        gvStock.DataSource = table
        Poscon.Close()

    End Sub

    Sub Sortpline(valuetosearch As String)
        reload("select ProdName,ProdQty,retailprice,Prodsize,ProdCat,ProdColour,Prodline,ProdCode from StockMast where prodline like '%" + valuetosearch + "%'", gvStock)
    End Sub

    'Private Sub BunifuThinButton28_Click(sender As Object, e As EventArgs) Handles BunifuThinButton28.Click
    '    If ckA5Paper.Checked = True Then
    '        PrintRecieptA5(txtReprintNo.Text)
    '    ElseIf ckrollPaper.Checked = True Then
    '        RollReciept(txtReprintNo.Text)
    '    ElseIf ckA4.Checked = True Then
    '        PrintRecieptA4(txtReprintNo.Text)
    '    End If
    'End Sub

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
        'If Poscon.State = ConnectionState.Closed Then
        '    Poscon.Open()
        'End If
        'cbProdlineSort.Items.Clear()
        'Dim pli = "select productline from productline"
        'cmd = New SqlCommand(pli, Poscon)
        'dr = cmd.ExecuteReader
        'While dr.Read
        '    cbProdlineSort.Items.Add(dr(0))
        'End While
        'Poscon.Close()
        ComboFeed("select productline from productline", cbProdlineSort, 0)
    End Sub

    Private Sub cbCatSort_Click(sender As Object, e As EventArgs) Handles cbCatSort.Click
        'If Poscon.State = ConnectionState.Closed Then
        '    Poscon.Open()
        'End If
        'cbCatSort.Items.Clear()
        'Dim sqll = "select category from Category"
        'cmd = New SqlCommand(sqll, Poscon)
        'dr = cmd.ExecuteReader
        'While dr.Read
        '    cbCatSort.Items.Add(dr(0))
        'End While
        'Poscon.Close()
        ComboFeed("select category from Category", cbCatSort, 0)
    End Sub



    Private Sub txtProdname_Enter(sender As Object, e As EventArgs) Handles txtProdname.Enter
        'If Poscon.State = ConnectionState.Closed Then
        '    Poscon.Open()
        'End If
        'txtProdname.Items.Clear()
        'Dim query = "select * from Stockmast"
        'cmd = New SqlCommand(query, Poscon)
        'dr = cmd.ExecuteReader
        'While dr.Read
        '    txtProdname.Items.Add(dr(1))
        'End While
        'Poscon.Close()
        ComboFeed("select * from Stockmast", txtProdname, 0)
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

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        If gvSales.Rows.Count = 0 Then
            MsgBox("Please select items to make a proforma")
            Exit Sub
        End If
        If txtBuyerName.Text = "" And txtBuyerTel.Text = "" Then
            MsgBox("Please enter client information")
            txtBuyerName.Focus()
            Exit Sub
        End If
        ShowConfig()
        If Poscon.State = ConnectionState.Closed Then
            Poscon.Open()
        End If
        For Each row As DataGridViewRow In gvSales.Rows
            Dim query = "insert into ProformaInvoices (ItemCode,ItemName,ProdLine,ProdCat,ItemSize,ItemColour,QtySold,DateSold,TimeSold,BuyerName,BuyerTel,BuyerLocation,RetailPrice,Amount,Soldby,AmountPayable,Invoiceno,narration) values(@ItemCode,@ItemName,@ProdLine,@ProdCat,@ItemSize,@ItemColour,@QtySold,@DateSold,@TimeSold,@BuyerName,@BuyerTel,@BuyerLocation,@RetailPrice,@Amount,'" + Activeuser.Text + "',@Amtpayable,'" + lblRecieptNo.Text + "','" + txtNarration.Text + "')"
            cmd = New SqlCommand(query, Poscon)
            With cmd

                .Parameters.AddWithValue("@ItemCode", SqlDbType.NVarChar).Value = row.Cells(5).Value
                .Parameters.AddWithValue("@Itemname", row.Cells(0).Value)
                .Parameters.AddWithValue("@ProdLine", row.Cells(7).Value)
                .Parameters.AddWithValue("@ProdCat", row.Cells(4).Value)
                .Parameters.AddWithValue("@ItemSize", row.Cells(6).Value)
                .Parameters.AddWithValue("@ItemColour", row.Cells(4).Value)
                .Parameters.AddWithValue("@QtySold", row.Cells(1).Value)
                .Parameters.AddWithValue("@DateSold", lblDate.Text)
                .Parameters.AddWithValue("@TimeSold", lblTime.Text)
                .Parameters.AddWithValue("@BuyerName", txtBuyerName.Text)
                .Parameters.AddWithValue("@BuyerTel", txtBuyerTel.Text)
                .Parameters.AddWithValue("@BuyerLocation", cbLocation.Text)
                .Parameters.AddWithValue("@RetailPrice", row.Cells(2).Value)
                .Parameters.AddWithValue("@Amount", row.Cells(3).Value)
                .Parameters.AddWithValue("@AmtPayable", value:=(lblPayable.Text))
                .ExecuteNonQuery()
            End With

        Next
        create("insert into proformaconfig(Invoiceno,Customername,Amount,date,Attendee,Status)values('" + lblRecieptNo.Text + "','" + txtBuyerName.Text + "','" + lblPayable.Text + "','" + lblDate.Text + "','" + Activeuser.Text + "','" + "Pending" + "')")
        'reports("select * from Proformainvoices", "rptproformaa4", frmSupplierReport.CrystalReportViewer1)
        'MsgBox("Sucess")
        PrintA4()
        ShowConfig()
        clear()
        gvSales.Rows.Clear()
        Display()
    End Sub
    Private Sub PrintA4()
        Try
            If Poscon.State = ConnectionState.Closed Then
                Poscon.Open()
            End If
            For Each row As DataGridViewRow In gvSales.Rows
                dt.Tables("Proforma").Rows.Add(row.Cells(0).Value, row.Cells(1).Value, row.Cells(2).Value, row.Cells(3).Value, txtBuyerName.Text, txtBuyerTel.Text, cbLocation.Text, lblDate.Text, Activeuser.Text, txtNarration.Text)
            Next
            dt.Tables("ClientReg").Rows.Clear()
            cmd = New SqlCommand("select * from ClientReg", Poscon)
            da.SelectCommand = cmd
            da.Fill(dt, "ClientReg")
            Dim report As New rptProformaA4
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

    Public Sub ShowConfig()
        If Poscon.State = ConnectionState.Closed Then
            Poscon.Open()
        End If
        Dim recieptcount As String
        Dim nextreciept As String
        Dim que = "select Invoiceno from Proformainvoices"
        cmd = New SqlCommand(que, Poscon)
        da = New SqlDataAdapter(cmd)
        tbl = New DataTable
        da.Fill(tbl)
        If tbl.Rows.Count() = 0 Then
            lblRecieptNo.Text = "10001"
        Else
            Dim index = tbl.Rows.Count() - 1
            Dim reciept = tbl.Rows(index)(0).ToString
            nextreciept = reciept + 1
            recieptcount = nextreciept.Count.ToString
            Select Case recieptcount
                Case "1"
                    lblRecieptNo.Text = "1000" + nextreciept
                Case "2"
                    lblRecieptNo.Text = "100" + nextreciept
                Case "3"
                    lblRecieptNo.Text = "10" + nextreciept
                Case "4"
                    lblRecieptNo.Text = "1" + nextreciept
                Case "5"
                    lblRecieptNo.Text = nextreciept
                Case Else
                    lblRecieptNo.Text = nextreciept
            End Select
        End If


        Poscon.Close()


    End Sub

    Private Sub gvProformaInvoice_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles gvProformaInvoice.CellClick
        If gvSales.Rows.Count <> 0 Then
            Dim ask As MsgBoxResult
            ask = MsgBox("Would you like to clear Cart?", MsgBoxStyle.YesNo, "")
            If ask = MsgBoxResult.Yes Then
                gvSales.Rows.Clear()
                Dim row As DataGridViewRow = gvProformaInvoice.Rows(e.RowIndex)
                lblProformainvoice.Text = row.Cells(0).Value.ToString()
                If Poscon.State = ConnectionState.Closed Then
                    Poscon.Open()
                End If
                Dim queryy = ("Select Itemname,qtysold,retailprice,amount,prodcat,itemcode,itemsize,prodline,Itemcolour,buyername,buyertel,buyerlocation,amountpayable from proformainvoices where invoiceno like '%" + lblProformainvoice.Text + "%'")
                cmd = New SqlCommand(queryy, Poscon)
                da = New SqlDataAdapter(cmd)
                tbl = New DataTable()
                da.Fill(tbl)
                If tbl.Rows.Count = 0 Then
                    MsgBox("ProForma Empty")
                    Exit Sub
                End If
                txtBuyerName.Text = tbl.Rows(0)(9).ToString
                txtBuyerTel.Text = tbl.Rows(0)(10).ToString
                cbLocation.Text = tbl.Rows(0)(11).ToString
                ' lblPayable.Text = tbl.Rows(0)(15).ToString
                For k = 0 To tbl.Rows.Count - 1
                    gvSales.Rows.Add(tbl.Rows(k)(0).ToString, tbl.Rows(k)(1).ToString, tbl.Rows(k)(2).ToString, tbl.Rows(k)(3).ToString, tbl.Rows(k)(4).ToString, tbl.Rows(k)(5).ToString, tbl.Rows(k)(6).ToString, tbl.Rows(k)(7).ToString, 0, lblRecieptNo.Text, 0, 0, tbl.Rows(k)(3).ToString, 0, tbl.Rows(k)(8).ToString, 0)
                Next
                Poscon.Close()
            End If
        Else
            gvSales.Rows.Clear()
            Dim row As DataGridViewRow = gvProformaInvoice.Rows(e.RowIndex)
            lblProformainvoice.Text = row.Cells(0).Value.ToString()
            If Poscon.State = ConnectionState.Closed Then
                Poscon.Open()
            End If
            Dim queryy = ("Select Itemname,qtysold,retailprice,amount,prodcat,itemcode,itemsize,prodline,Itemcolour,buyername,buyertel,buyerlocation,amountpayable from proformainvoices where invoiceno like '%" + lblProformainvoice.Text + "%'")
            cmd = New SqlCommand(queryy, Poscon)
            da = New SqlDataAdapter(cmd)
            tbl = New DataTable()
            da.Fill(tbl)
            If tbl.Rows.Count = 0 Then
                MsgBox("ProForma Empty")
                Exit Sub
            End If
            txtBuyerName.Text = tbl.Rows(0)(9).ToString
            txtBuyerTel.Text = tbl.Rows(0)(10).ToString
            cbLocation.Text = tbl.Rows(0)(11).ToString
            ' lblPayable.Text = tbl.Rows(0)(15).ToString
            For k = 0 To tbl.Rows.Count - 1
                gvSales.Rows.Add(tbl.Rows(k)(0).ToString, tbl.Rows(k)(1).ToString, tbl.Rows(k)(2).ToString, tbl.Rows(k)(3).ToString, tbl.Rows(k)(4).ToString, tbl.Rows(k)(5).ToString, tbl.Rows(k)(6).ToString, tbl.Rows(k)(7).ToString, 0, lblRecieptNo.Text, 0, 0, tbl.Rows(k)(3).ToString, 0, tbl.Rows(k)(8).ToString, 0)
            Next
            Poscon.Close()
        End If



    End Sub

    Private Sub BunifuThinButton28_Click(sender As Object, e As EventArgs) Handles BunifuThinButton28.Click
        Try
            If Poscon.State = ConnectionState.Closed Then
                Poscon.Open()
            End If
            cmd = New SqlCommand("select * from proformainvoices where invoiceno='" + lblRecieptNo.Text + "'", Poscon)
            dt.Tables("proformainvoices").Rows.Clear()
            da.SelectCommand = cmd
            da.Fill(dt, "proformainvoices")

            dt.Tables("ClientReg").Rows.Clear()
            cmd = New SqlCommand("select * from ClientReg", Poscon)
            da.SelectCommand = cmd
            da.Fill(dt, "ClientReg")
            Dim report As New rptProformaA4
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
End Class