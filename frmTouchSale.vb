Imports System.Data.SqlClient
Public Class frmTouchSale
    Dim con As New SqlConnection(My.Settings.PoSConnectionString)
    Dim dr As SqlDataReader
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter
    Dim action As String = "Startup"
    Dim query As String
    Private WithEvents lblPrice As New Label
    Dim dt As New dsSalesTranx
    Dim ds As New dsTouchReciepts
    Dim tbl As DataTable

    Sub LoadCatbtn()
        flbtnCat.AutoScroll = True
        flbtnCat.Controls.Clear()
        con.Open()
        Dim query = "Select * from category"
        cmd = New SqlCommand(query, con)
        dr = cmd.ExecuteReader
        While dr.Read
            Dim Button = New Button
            Button.Width = 90
            Button.Height = 30


            Button.Text = dr.Item("Category").ToString
            Button.FlatStyle = FlatStyle.Flat
            Button.BackColor = Color.FromArgb(255, 107, 107)
            Button.ForeColor = Color.White
            flbtnCat.Controls.Add(Button)
            Button.Cursor = Cursors.Hand

            AddHandler Button.DoubleClick, AddressOf Button_click

        End While
        dr.Close()
        con.Close()

    End Sub


    Sub LoadItems()
        flItems.AutoScroll = True
        flItems.Controls.Clear()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        If action = "Startup" Then
            Dim quer = "Select * from StockMast"
            cmd = New SqlCommand(quer, con)
        End If
        If action = "btnCategory" Then
            Dim quer = "Select * from StockMast where ProdCat='" + txtCat.Text + "'"
            cmd = New SqlCommand(quer, con)
        End If

        dr = cmd.ExecuteReader
        While dr.Read
            Dim Btn = New Button
            Btn.Width = 125
            Btn.Height = 60
            Btn.Text = dr.Item("itemname").ToString
            Btn.FlatStyle = FlatStyle.Flat
            Btn.BackColor = Color.FromArgb(255, 107, 107)
            Btn.ForeColor = Color.White
            Btn.Tag = dr.Item("ProdCode").ToString
            flItems.Controls.Add(Btn)
            Btn.Cursor = Cursors.Hand


            lblPrice = New Label
            lblPrice.BackColor = Color.DarkGray
            lblPrice.TextAlign = ContentAlignment.MiddleCenter
            lblPrice.Dock = DockStyle.Bottom
            lblPrice.Text = dr.Item("RetailPrice")
            lblPrice.Tag = dr.Item("ProdCode").ToString

            Btn.Controls.Add(lblPrice)

            AddHandler Btn.MouseDown, AddressOf Item_dgv

        End While
        dr.Close()
        con.Close()
    End Sub
    Private Sub frmTouchSale_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCatbtn()
        LoadItems()
        action = "Startup"
        LoadOder()
        DisplayOders()
        LoadWaiterNames()
        ShowConfig()
        OnloadActivity()
        ShowOderNo()

    End Sub
    Public Sub Button_click(sender As Object, e As EventArgs)
        txtCat.Text = sender.text.ToString
        action = "btnCategory"
        LoadItems()
    End Sub

    Private Sub Item_dgv(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Try
            If e.Clicks = 2 Then
                'MessageBox.Show("The button was double-clicked.")
                Dim qty As Double = 1
                'Dim amt As Double
                lblProdCode.Text = sender.tag.ToString

                If con.State = ConnectionState.Closed Then
                    con.Open()
                End If

                Dim query = "Select * from StockMast where Prodcode='" + sender.tag.ToString + "'"
                cmd = New SqlCommand(query, con)
                dr = cmd.ExecuteReader
                While dr.Read
                    lblCat.Text = dr.Item("ProdCat")
                    lblActualStock.Text = dr.Item("ProdQty")
                    For Each row As DataGridViewRow In gvtouchsale.Rows
                        If lblProdCode.Text = row.Cells(0).Value Then
                            row.Cells(3).Value += 1
                            row.Cells(4).Value = row.Cells(3).Value * row.Cells(2).Value
                            row.Cells(10).Value -= 1
                            Try
                                Dim sum As Decimal
                                For k = 0 To gvtouchsale.RowCount - 1
                                    sum += gvtouchsale.Rows(k).Cells(4).Value
                                Next
                                lblTotal.Text = sum
                            Catch ex As Exception
                                MsgBox(ex.ToString)
                            End Try
                            dr.Close()
                            con.Close()
                            Exit Sub
                        End If

                    Next
                    gvtouchsale.Rows.Add(dr.Item("ProdCode").ToString, dr.Item("Itemname").ToString, dr.Item("RetailPrice").ToString, qty, dr.Item("RetailPrice").ToString, lblDayOder.Text, "Pending", dr.Item("ProdCat").ToString, dr.Item("Prodline").ToString, lblRecieptNo.Text, dr.Item("ProdQty") - one.Text, dr.Item("ProdQty"), lblOderNo.Text)
                End While

                dr.Close()
                con.Close()
            End If
            If e.Clicks = 1 Then
                'MessageBox.Show("The button was double-clicked.")
                Dim qty As Double = 1
                'Dim amt As Double
                lblProdCode.Text = sender.tag.ToString

                If con.State = ConnectionState.Closed Then
                    con.Open()
                End If

                Dim query = "Select * from StockMast where Prodcode='" + sender.tag.ToString + "'"
                cmd = New SqlCommand(query, con)
                dr = cmd.ExecuteReader
                While dr.Read
                    lblItemName.Text = dr.Item("itemname")
                    lblCat.Text = dr.Item("ProdCat")
                    lblprodline.Text = dr.Item("Prodline")
                    lblActualStock.Text = dr.Item("ProdQty")
                    txtPrice.Text = dr.Item("RetailPrice").ToString
                End While
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub
    'Public Sub Item_dgv(sender As Object, e As EventArgs)

    '    Dim qty As Double = 1
    '    'Dim amt As Double
    '    lblProdCode.Text = sender.tag.ToString

    '    If con.State = ConnectionState.Closed Then
    '        con.Open()
    '    End If

    '    Dim query = "Select * from StockMast where Prodcode='" + sender.tag.ToString + "'"
    '    cmd = New SqlCommand(query, con)
    '    dr = cmd.ExecuteReader
    '    While dr.Read
    '        lblCat.Text = dr.Item("ProdCat")
    '        lblActualStock.Text = dr.Item("ProdQty")
    '        For Each row As DataGridViewRow In gvtouchsale.Rows
    '            If lblProdCode.Text = row.Cells(0).Value Then
    '                row.Cells(3).Value += 1
    '                row.Cells(4).Value = row.Cells(3).Value * row.Cells(2).Value
    '                row.Cells(10).Value -= 1
    '                Try
    '                    Dim sum As Decimal
    '                    For k = 0 To gvtouchsale.RowCount - 1
    '                        sum += gvtouchsale.Rows(k).Cells(4).Value
    '                    Next
    '                    lblTotal.Text = sum
    '                Catch ex As Exception
    '                    MsgBox(ex.ToString)
    '                End Try
    '                dr.Close()
    '                con.Close()
    '                Exit Sub
    '            End If

    '        Next
    '        gvtouchsale.Rows.Add(dr.Item("ProdCode").ToString, dr.Item("ProdName").ToString, dr.Item("RetailPrice").ToString, qty, dr.Item("RetailPrice").ToString, lblDayOder.Text, "Pending", dr.Item("ProdCat").ToString, dr.Item("Prodline").ToString, lblRecieptNo.Text, dr.Item("ProdQty") - one.Text, dr.Item("ProdQty"), lblOderNo.Text)
    '    End While

    '    dr.Close()
    '    con.Close()


    'End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        If lblOderSale.Text <> "odersale" Then
            Update_Oder()
            Exit Sub
        End If
        If cbWaiter.Text = "" Then
            MsgBox("Choose Waiter Odering")
        Else
            ShowOderNo()
            oder()
            Oderdetails()
            gvtouchsale.Rows.Clear()
            Clear()
            LoadOder()
            DisplayOders()
            ShowOderNo()

        End If

    End Sub

    Private Sub Guna2PictureBox1_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox1.Click
        Me.Hide()
    End Sub
    Public Sub Update_Oder()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        For Each row As DataGridViewRow In gvtouchsale.Rows
            Dim qu = "update odertranx set ItemCode=@itemcode,ItemName=@itemname,Price=@price,Oderqty=@oderqty,OderAmt=@oderamt,DayOderNo='" + lblDayOder.Text + "',OderStatus=@oderstatus,Category=@category,Prodline=@prodline,WaiterName='" + cbWaiter.Text + "' where Oderno=@dayoderno"
            cmd = New SqlCommand(qu, con)
            With cmd
                .Parameters.AddWithValue("@ItemCode", row.Cells(0).Value)
                .Parameters.AddWithValue("@ItemName", row.Cells(1).Value)
                .Parameters.AddWithValue("@Price", row.Cells(2).Value)
                .Parameters.AddWithValue("@Oderqty", row.Cells(3).Value)
                .Parameters.AddWithValue("@OderAmt", row.Cells(4).Value)
                .Parameters.AddWithValue("@OderStatus", "Pending")
                .Parameters.AddWithValue("@Category", row.Cells(7).Value)
                .Parameters.AddWithValue("@Prodline", row.Cells(8).Value)
                .Parameters.AddWithValue("@dayoderno", lblDayOder.Text)
                .ExecuteNonQuery()
            End With
        Next

        MsgBox("Oder Updated Succefull")
        LoadOder()
    End Sub
    Sub LoadOder()
        Dim nextoder As String
        Dim odercount As String
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim sql = "select * from odersConfig"
        cmd = New SqlCommand(sql, con)
        da = New SqlDataAdapter(cmd)
        Dim table As New DataTable
        da.Fill(table)
        If table.Rows.Count() = 0 Then
            lblDayOder.Text = "10001"
        Else
            Dim index = table.Rows.Count() - 1
            Dim reciept = table.Rows(index)(0).ToString
            nextoder = reciept + 1
            odercount = nextoder.Count.ToString
            Select Case odercount
                Case "1"
                    lblDayOder.Text = "1000" + nextoder
                Case "2"
                    lblDayOder.Text = "100" + nextoder
                Case "3"
                    lblDayOder.Text = "10" + nextoder
                Case "4"
                    lblDayOder.Text = "1" + nextoder
                Case "5"
                    lblDayOder.Text = nextoder
                Case Else
                    lblDayOder.Text = nextoder

            End Select
        End If

    End Sub
    Sub oder()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim sql = "insert into OdersConfig(dayoderno,salesperson,waiter,oderno) values('" + lblDayOder.Text + "','" + tsUser.Text + "','" + cbWaiter.Text + "','" + lblOderNo.Text + "') "
        cmd = New SqlCommand(sql, con)
        cmd.ExecuteNonQuery()
        con.Close()
        MsgBox("Oder Succeful")
        'gvtouchsale.Rows.Clear()
        'Clear()
        LoadOder()
    End Sub
    Sub Oderdetails()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        For Each row As DataGridViewRow In gvtouchsale.Rows
            Dim qu = "insert into odertranx (OderNo,ItemCode,ItemName,Price,Oderqty,OderAmt,DayOderNo,OderStatus,Category,Prodline,WaiterName) values('" + lblOderNo.Text + "',@ItemCode,@ItemName,@Price,@Oderqty,@OderAmt,'" + lblDayOder.Text + "',@Oderstatus,@Category,@Prodline,'" + cbWaiter.Text + "')"
            cmd = New SqlCommand(qu, con)
            With cmd

                .Parameters.AddWithValue("@ItemCode", row.Cells(0).Value)
                .Parameters.AddWithValue("@ItemName", row.Cells(1).Value)
                .Parameters.AddWithValue("@Price", row.Cells(2).Value)
                .Parameters.AddWithValue("@Oderqty", row.Cells(3).Value)
                .Parameters.AddWithValue("@OderAmt", row.Cells(4).Value)
                .Parameters.AddWithValue("@OderStatus", "Pending")
                .Parameters.AddWithValue("@Category", row.Cells(7).Value)
                .Parameters.AddWithValue("@Prodline", row.Cells(8).Value)
                .ExecuteNonQuery()
            End With
        Next

        MsgBox("Oder Details Succefull")
        LoadOder()
    End Sub
    Sub SearchWaiters(valuetosearch As String)

        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            Dim query = "select * from OdersConfig where concat(OderNo,Waiter) like '%" + valuetosearch + "%'"
            cmd = New SqlCommand(query, con)
            da = New SqlDataAdapter(cmd)
            tbl = New DataTable()
            da.Fill(tbl)
            gvOders.DataSource = tbl
            con.Close()
        Catch ex As Exception
            'MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub DisplayOders()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim query = "select * from OdersConfig"
        cmd = New SqlCommand(query, con)
        da = New SqlDataAdapter(cmd)
        Dim builder As New SqlCommandBuilder
        builder = New SqlCommandBuilder(da)
        Dim ds As New DataSet
        da.Fill(ds)
        gvOders.DataSource = ds.Tables(0)
        con.Close()


    End Sub
    Sub Clear()
        lblDayOder.Text = ""
        cbWaiter.SelectedIndex = -1
        lblCreditCust.Text = ""
        lblProdCode.Text = ""
        txtBuyerName.Text = ""
        txtCashPaid.Text = ""
        lblPrice.Text = ""
        lblOldBal.Text = ""
        lblCustNo.Text = ""
        cbWaiterSearch.SelectedIndex = -1
        cbWaiter.SelectedIndex = -1
        txtCashPaid.Text = ""
        txtCat.Text = ""
        lblCustNo.Text = ""
        lblChange.Text = ""
        'lblActualStock.Text = ""
        lblNewBal.Text = ""
        lblOldBal.Text = ""
        cbCreditCustName.SelectedIndex = -1
        txtCat.Text = ""
        'txtProdline.Text = ""



    End Sub

    Private Sub TextBox1_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtSearchWaiterOder.Validating
        SearchWaiters(txtSearchWaiterOder.Text)

    End Sub

    Private Sub TextBox1_Validated(sender As Object, e As EventArgs) Handles txtSearchWaiterOder.Validated
        SearchWaiters(txtSearchWaiterOder.Text)
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearchWaiterOder.KeyPress
        SearchWaiters(txtSearchWaiterOder.Text)
    End Sub
    Sub LoadWaiterNames()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim queryy = ("Select * from Waiters")
        cmd = New SqlCommand(queryy, con)
        Dim adp As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable
        adp.Fill(tbl)
        cbWaiter.DataSource = tbl
        cbWaiter.DisplayMember = "WaiterName"
        ' cbWaiter.ValueMember = "WaiterId"
        cbWaiterSearch.DataSource = tbl
        cbWaiterSearch.DisplayMember = "WaiterName"
        ' cbWaiterSearch.ValueMember = "WaiterId"
        con.Close()
    End Sub

    Private Sub cbWaiterSearch_DropDownClosed(sender As Object, e As EventArgs) Handles cbWaiterSearch.DropDownClosed
        txtSearchWaiterOder.Text = cbWaiterSearch.Text
        MsgBox(cbWaiterSearch.Text)
    End Sub

    Private Sub txtSearchWaiterOder_TextChanged(sender As Object, e As EventArgs) Handles txtSearchWaiterOder.TextChanged
        SearchWaiters(txtSearchWaiterOder.Text)
    End Sub
    Sub LoadOderSale()
        If gvtouchsale.Rows.Count = 0 Then
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            Dim queryy = ("Select * from OderTranx where OderNo like '%" + lblOderSale.Text + "%'")
            cmd = New SqlCommand(queryy, con)
            da = New SqlDataAdapter(cmd)
            Dim table As New DataTable()
            da.Fill(table)
            gvOderDetails.DataSource = table
            For Each row As DataGridViewRow In gvOderDetails.Rows
                'dr.Close()
                Dim query = "Select * from StockMast where Prodcode=@itemcode"
                cmd = New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@itemcode", SqlDbType.NVarChar).Value = row.Cells(1).Value
                dr = cmd.ExecuteReader
                While dr.Read
                    lblWaiter.Text = row.Cells(10).Value
                    gvtouchsale.Rows.Add(row.Cells(1).Value, row.Cells(2).Value, row.Cells(3).Value, row.Cells(4).Value, row.Cells(5).Value, row.Cells(6).Value, row.Cells(7).Value, row.Cells(8).Value, row.Cells(9).Value, lblRecieptNo.Text, dr.Item("ProdQty") - row.Cells(4).Value, dr.Item("ProdQty"), row.Cells(10).Value, row.Cells(0).Value)
                End While
            Next
            con.Close()
        Else
            Dim ask As MsgBoxResult
            ask = MsgBox("Would you like to clear Cart?", MsgBoxStyle.YesNo, "")
            If ask = MsgBoxResult.Yes Then
                gvtouchsale.Rows.Clear()
                If con.State = ConnectionState.Closed Then
                    con.Open()
                End If
                Dim queryy = ("Select * from OderTranx where OderNo like '%" + lblOderSale.Text + "%'")
                cmd = New SqlCommand(queryy, con)
                da = New SqlDataAdapter(cmd)
                Dim table As New DataTable()
                da.Fill(table)
                gvOderDetails.DataSource = table
                For Each row As DataGridViewRow In gvOderDetails.Rows
                    dr.Close()
                    Dim query = "Select * from StockMast where Prodcode=@itemcode"
                    cmd = New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@itemcode", SqlDbType.NVarChar).Value = row.Cells(1).Value
                    dr = cmd.ExecuteReader
                    While dr.Read
                        lblWaiter.Text = row.Cells(10).Value
                        gvtouchsale.Rows.Add(row.Cells(1).Value, row.Cells(2).Value, row.Cells(3).Value, row.Cells(4).Value, row.Cells(5).Value, row.Cells(6).Value, row.Cells(7).Value, row.Cells(8).Value, row.Cells(9).Value, lblRecieptNo.Text, dr.Item("ProdQty") - row.Cells(4).Value, dr.Item("ProdQty"), row.Cells(10).Value, row.Cells(0).Value)
                    End While
                Next
                con.Close()
            Else

            End If
        End If

    End Sub

    Private Sub gvOders_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles gvOders.CellClick
        Dim row As DataGridViewRow = gvOders.Rows(e.RowIndex)
        lblOderNo.Text = row.Cells(0).Value.ToString()
        lblOderSale.Text = row.Cells(3).Value.ToString()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim queryy = ("Select * from OderTranx where OderNo like '%" + lblOderSale.Text + "%'")
        cmd = New SqlCommand(queryy, con)
        da = New SqlDataAdapter(cmd)
        Dim table As New DataTable()
        da.Fill(table)
        gvOderDetails.DataSource = table
        'LoadOderSale()
    End Sub
    Sub Reciept()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim sql = "insert into Recieptconfig(salesperson,Recieptid,waitername,oderno,date) values('" + tsUser.Text + "','" + lblRecieptNo.Text + "','" + lblWaiter.Text + "','" + lblDayOder.Text + "','" + lbldate.Text + "') "
        cmd = New SqlCommand(sql, con)
        cmd.ExecuteNonQuery()
        con.Close()

    End Sub
    Private Sub ShowConfig()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim recieptcount As String
        Dim nextreciept As String
        Dim que = "select * from recieptconfig"
        cmd = New SqlCommand(que, con)
        Dim da As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        da.Fill(table)
        If table.Rows.Count() = 0 Then
            lblRecieptNo.Text = "10001"
        Else

            Dim index = table.Rows.Count() - 1
            Dim reciept = table.Rows(index)(0).ToString
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


        con.Close()


    End Sub
    Private Sub ShowOderNo()

        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim recieptcount As String
        Dim nextreciept As String
        Dim que = "select * from OderTranx"
        cmd = New SqlCommand(que, con)
        Dim da As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        da.Fill(table)
        If table.Rows.Count() = 0 Then
            lblOderNo.Text = "10001"
        Else

            Dim index = table.Rows.Count() - 1
            Dim reciept = table.Rows(index)(0).ToString
            nextreciept = reciept + 1
            recieptcount = nextreciept.Count.ToString
            Select Case recieptcount
                Case "1"
                    lblOderNo.Text = "1000" + nextreciept
                Case "2"
                    lblOderNo.Text = "100" + nextreciept
                Case "3"
                    lblOderNo.Text = "10" + nextreciept
                Case "4"
                    lblOderNo.Text = "1" + nextreciept
                Case "5"
                    lblOderNo.Text = nextreciept
                Case Else
                    lblOderNo.Text = nextreciept

            End Select
        End If


        con.Close()


    End Sub
    Sub PrintReciept()

        Try
            Reciept()
            dt.EnforceConstraints = False
            con.Open()
            Dim que = "select * from recieptconfig"
            cmd = New SqlCommand(que, con)
            Dim da As New SqlDataAdapter(cmd)
            Dim table As New DataTable
            da.Fill(table)
            ' If table.Rows.Count() = 0 Then
            'Dim reciept = "1"
            'Else
            'Dim index = table.Rows.Count() - 1
            ' Dim reciept = table.Rows(index)(0).ToString
            ' End If


            Dim query = "select * from SalesTranx where recieptno='" + table.Rows(table.Rows.Count() - 1)(2).ToString + "'"
            'itemname,qtySold,amount,Retailprice

            cmd = New SqlCommand(query, con)
            da.SelectCommand = cmd

            da.Fill(dt, "salesTranx")

            Dim report As New rptSalesReciept
            report.SetDataSource(dt)
            report.PrintToPrinter(1, True, 0, 0)
            'CrystalReportViewer1.ReportSource = report
            ' CrystalReportViewer1.Refresh()
            cmd.Dispose()
            da.Dispose()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click
        ShowConfig()
        Reciept()
        ShowConfig()

        If cbSaleType.Text = "" Or gvtouchsale.RowCount = 0 Then
            MsgBox("Select Sale Type or Fill sale Cart", vbCritical)
        Else
            'Try
            If (cbSaleType.SelectedIndex = 0 Or cbSaleType.SelectedItem = "Walk-In Sale") Then
                'reciept()

                ' cbCreditCustName.Visible = False
                ' lblCreditCust.Visible = False
                Try
                    Dim i As Integer
                    If True Then
                        For i = 0 To gvtouchsale.RowCount - 1

                            If con.State = ConnectionState.Closed Then
                                con.Open()
                            End If
                            Dim query = "insert into salestranx (ItemCode,ItemName,ProdLine,ProdCat,QtySold,DateSold,TimeSold,BuyerName,BuyerTel,BuyerLocation,NewStock,RetailPrice,SaleType,CredCustName,Amount,Soldby,RecieptNo,AmtPaid,Balance) values(@ItemCode,@ItemName,@ProdLine,@ProdCat,@QtySold,@DateSold,@TimeSold,@BuyerName,@BuyerTel,@BuyerLocation,@NewStock,@RetailPrice,@SaleType,@CreditCustomerName,@Amount,'" + tsUser.Text + "', '" + lblRecieptNo.Text + "','" + txtCashPaid.Text + "','" + lblChange.Text + "')"
                            Dim cmd As New SqlCommand
                            cmd = New SqlCommand(query, con)
                            With cmd

                                .Parameters.AddWithValue("@ItemCode", gvtouchsale.Rows(i).Cells(0).Value)
                                .Parameters.AddWithValue("@Itemname", gvtouchsale.Rows(i).Cells(1).Value)
                                .Parameters.AddWithValue("@ProdLine", (gvtouchsale.Rows(i).Cells(8).Value))
                                .Parameters.AddWithValue("@ProdCat", (gvtouchsale.Rows(i).Cells(7).Value))
                                '.Parameters.AddWithValue("@ItemSize", (gvtouchsale.Rows(i).Cells(6).Value))
                                '.Parameters.AddWithValue("@ItemColour", (gvtouchsale.Rows(i).Cells(4).Value))
                                .Parameters.AddWithValue("@QtySold", (gvtouchsale.Rows(i).Cells(3).Value))
                                .Parameters.AddWithValue("@DateSold", lbldate.Text)
                                .Parameters.AddWithValue("@TimeSold", lbltime.Text)
                                .Parameters.AddWithValue("@BuyerName", txtBuyerName.Text)
                                .Parameters.AddWithValue("@BuyerTel", txtBuyerTel.Text)
                                .Parameters.AddWithValue("@BuyerLocation", cbLocation.Text)
                                .Parameters.AddWithValue("@NewStock", (gvtouchsale.Rows(i).Cells(10).Value))
                                .Parameters.AddWithValue("@RetailPrice", gvtouchsale.Rows(i).Cells(2).Value)
                                .Parameters.AddWithValue("@Saletype", cbSaleType.Text)
                                .Parameters.AddWithValue("@CreditCustomerName", cbCreditCustName.Text)
                                .Parameters.AddWithValue("@Amount", gvtouchsale.Rows(i).Cells(4).Value)
                                .ExecuteNonQuery()
                            End With
                            con.Close()


                        Next

                        'frmSalesReciept.Show()
                        'MsgBox("Record Saved")
                    End If
                Finally

                    For k = 0 To gvtouchsale.RowCount - 1
                        If con.State = ConnectionState.Closed Then
                            con.Open()
                        End If
                        Dim query = "update StockMast set ProdQty = @newstock where Prodcode =" + gvtouchsale.Rows(k).Cells(0).Value + ""
                        Dim cmd As New SqlCommand
                        cmd = New SqlCommand(query, con)
                        With cmd
                            .Parameters.AddWithValue("@newstock", gvtouchsale.Rows(k).Cells(10).Value)
                            .ExecuteNonQuery()
                        End With

                        con.Close()


                        If con.State = ConnectionState.Closed Then
                                con.Open()
                            End If
                        Dim sql = "delete from OdersConfig where OderNo= '" + gvtouchsale.Rows(k).Cells(5).Value + "' "
                        cmd = New SqlCommand(sql, con)
                        cmd.ExecuteNonQuery()
                        MsgBox("Oder Deleted Successfully")
                        con.Close()
                        DisplayOders()



                    Next


                    MsgBox("StockMast Updated")
                    lblTotal.Text = ""
                    Clear()
                    gvtouchsale.Rows.Clear()
                    DisplayOders()


                End Try
            ElseIf (cbSaleType.SelectedIndex = 1) Then
                'cbCreditCustName.Visible = True
                'lblCreditCust.Visible = True
                Dim a = Val(lblTotal.Text)
                Dim b = Val(lblOldBal.Text)
                Dim sum = b - a
                lblNewBal.Text = sum
                If cbCreditCustName.Text = "" Then
                    MsgBox("Choose customer")
                Else
                    Try
                        'reciept()
                        Dim i As Integer
                        If True Then
                            For i = 0 To gvtouchsale.RowCount - 1
                                If con.State = ConnectionState.Closed Then
                                    con.Open()
                                End If
                                Dim query = "insert into salestranx (ItemCode,ItemName,ProdLine,ProdCat,ItemSize,ItemColour,QtySold,DateSold,TimeSold,BuyerName,BuyerTel,BuyerLocation,NewStock,RetailPrice,SaleType,CredCustName,Amount,Soldby,RecieptNo,AmtPaid,Balance) values(@ItemCode,@ItemName,@ProdLine,@ProdCat,@ItemSize,@ItemColour,@QtySold,@DateSold,@TimeSold,@BuyerName,@BuyerTel,@BuyerLocation,@NewStock,@RetailPrice,@SaleType,@CreditCustomerName,@Amount,'" + tsUser.Text + "', '" + lblRecieptNo.Text + "','" + txtCashPaid.Text + "','" + lblChange.Text + "')"
                                Dim cmd As New SqlCommand
                                cmd = New SqlCommand(query, con)
                                With cmd

                                    .Parameters.AddWithValue("@ItemCode", gvtouchsale.Rows(i).Cells(0).Value)
                                    .Parameters.AddWithValue("@Itemname", gvtouchsale.Rows(i).Cells(1).Value)
                                    .Parameters.AddWithValue("@ProdLine", (gvtouchsale.Rows(i).Cells(8).Value))
                                    .Parameters.AddWithValue("@ProdCat", (gvtouchsale.Rows(i).Cells(7).Value))
                                    '.Parameters.AddWithValue("@ItemSize", (gvtouchsale.Rows(i).Cells(6).Value))
                                    '.Parameters.AddWithValue("@ItemColour", (gvtouchsale.Rows(i).Cells(4).Value))
                                    .Parameters.AddWithValue("@QtySold", (gvtouchsale.Rows(i).Cells(3).Value))
                                    .Parameters.AddWithValue("@DateSold", lblDate.Text)
                                    .Parameters.AddWithValue("@TimeSold", lblTime.Text)
                                    .Parameters.AddWithValue("@BuyerName", txtBuyerName.Text)
                                    .Parameters.AddWithValue("@BuyerTel", txtBuyerTel.Text)
                                    .Parameters.AddWithValue("@BuyerLocation", cbLocation.Text)
                                    .Parameters.AddWithValue("@NewStock", (gvtouchsale.Rows(i).Cells(9).Value))
                                    .Parameters.AddWithValue("@RetailPrice", gvtouchsale.Rows(i).Cells(2).Value)
                                    .Parameters.AddWithValue("@Saletype", cbSaleType.Text)
                                    .Parameters.AddWithValue("@CreditCustomerName", cbCreditCustName.Text)
                                    .Parameters.AddWithValue("@Amount", gvtouchsale.Rows(i).Cells(4).Value)
                                    .ExecuteNonQuery()
                                End With
                                con.Close()
                                MsgBox("You Reach")


                            Next

                        End If

                    Finally
                        If con.State = ConnectionState.Closed Then
                            con.Open()
                        End If
                        Dim quer = "Insert into CustomerLedger(CustomerName,oldbal,Newbal,CreditRecieved,DateRecieved,TimeRecieved,CustomerNo)Values('" + cbCreditCustName.Text + "','" + lblOldBal.Text + "','" + lblNewBal.Text + "','" + lblTotal.Text + "','" + lblDate.Text + "','" + lblTime.Text + "','" + lblCustNo.Text + "')"
                        Dim cmd As New SqlCommand
                        cmd = New SqlCommand(quer, con)
                        cmd.ExecuteNonQuery()

                        Dim que = "update Customer set CurrentBalance=@CurBal where CustomerNo = " + lblCustNo.Text + ""
                        Dim cm As New SqlCommand(que, con)
                        With cm

                            .Parameters.AddWithValue("@CurBal", CDbl(lblNewBal.Text))
                            .ExecuteNonQuery()

                        End With


                        MsgBox("Customer Updated")
                        con.Close()

                        For k = 0 To gvtouchsale.RowCount - 1
                            If con.State = ConnectionState.Closed Then
                                con.Open()
                            End If
                            Dim query = "update StockMast set ProdQty = @newstock where ProdCode =" + gvtouchsale.Rows(k).Cells(5).Value + ""
                            Dim cmdd As New SqlCommand
                            cmdd = New SqlCommand(query, con)
                            With cmdd
                                .Parameters.AddWithValue("@newstock", CInt(gvtouchsale.Rows(k).Cells(8).Value))
                                .ExecuteNonQuery()
                            End With



                        Next
                        con.Close()

                        ShowConfig()
                        MsgBox("StockMast Updated")
                        frmSalesReciept.Show()

                        gvtouchsale.Rows.Clear()
                        lblTotal.Text = ""
                        Clear()
                        DisplayOders()



                        lblTotal.Text = ""
                    End Try
                End If
                'If cbSaleType.Text = "" Or cbSaleType.Text = "Credit Sale" Then
                'cbCreditCustName.Visible = False
                'Else
                '  cbCreditCustName.Visible = True

                '     End If                   
            End If
            'Catch ex As Exception
            '  MsgBox(ex.ToString)
            'End Try
        End If
        ShowConfig()
        'frmSalesReciept.Hide()
    End Sub

    Private Sub gvtouchsale_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles gvtouchsale.RowsAdded
        Try
            Dim sum As Double
            For k = 0 To gvtouchsale.RowCount - 1
                sum += gvtouchsale.Rows(k).Cells(4).Value

            Next
            lblTotal.Text = sum
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Sub CashPaid()
        Dim CashPaid As Decimal = 0
        Dim change As Decimal = 0
        change = Val(txtCashPaid.Text) - Val(lblTotal.Text)
        lblChange.Text = change
    End Sub

    Private Sub txtCashPaid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCashPaid.KeyPress
        CashPaid()
    End Sub

    Private Sub txtCashPaid_KeyUp(sender As Object, e As KeyEventArgs) Handles txtCashPaid.KeyUp
        CashPaid()
    End Sub
    Sub OnloadActivity()
        cbSaleType.SelectedIndex = 0
        lbltime.Text = Date.Now.ToString("hh:mm:ss")
        lbldate.Text = Date.Now.ToString("dd-MMM-yy")
        cbPaymode.SelectedIndex = 0
        cbWaiter.SelectedIndex = -1
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbltime.Text = Date.Now.ToString("hh:mm:ss")
        lbldate.Text = Date.Now.ToString("dd-MMM-yy")
    End Sub

    Private Sub BunifuThinButton23_Click(sender As Object, e As EventArgs) Handles BunifuThinButton23.Click, BunifuThinButton23.Click
        gvtouchsale.Rows.Clear()
    End Sub

    Private Sub Guna2PictureBox2_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox2.Click
        If WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Maximized
        ElseIf WindowState = FormWindowState.Maximized Then
            WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub BunifuThinButton24_Click(sender As Object, e As EventArgs) Handles BunifuThinButton24.Click
        ShowConfig()
        Reciept()
        ShowConfig()

        If cbSaleType.Text = "" Or gvtouchsale.RowCount = 0 Then
            MsgBox("Select Sale Type or Fill sale Cart", vbCritical)
        Else
            'Try
            If (cbSaleType.SelectedIndex = 0 Or cbSaleType.SelectedItem = "Walk-In Sale") Then
                'reciept()

                ' cbCreditCustName.Visible = False
                ' lblCreditCust.Visible = False
                Try
                    Dim i As Integer
                    If True Then
                        For i = 0 To gvtouchsale.RowCount - 1

                            If con.State = ConnectionState.Closed Then
                                con.Open()
                            End If
                            Dim query = "insert into salestranx (ItemCode,ItemName,ProdLine,ProdCat,QtySold,DateSold,TimeSold,BuyerName,BuyerTel,BuyerLocation,NewStock,RetailPrice,SaleType,CredCustName,Amount,Soldby,RecieptNo,AmtPaid,Balance) values(@ItemCode,@ItemName,@ProdLine,@ProdCat,@QtySold,@DateSold,@TimeSold,@BuyerName,@BuyerTel,@BuyerLocation,@NewStock,@RetailPrice,@SaleType,@CreditCustomerName,@Amount,'" + tsUser.Text + "', '" + lblRecieptNo.Text + "','" + txtCashPaid.Text + "','" + lblChange.Text + "')"
                            Dim cmd As New SqlCommand
                            cmd = New SqlCommand(query, con)
                            With cmd

                                .Parameters.AddWithValue("@ItemCode", gvtouchsale.Rows(i).Cells(0).Value)
                                .Parameters.AddWithValue("@Itemname", gvtouchsale.Rows(i).Cells(1).Value)
                                .Parameters.AddWithValue("@ProdLine", (gvtouchsale.Rows(i).Cells(8).Value))
                                .Parameters.AddWithValue("@ProdCat", (gvtouchsale.Rows(i).Cells(7).Value))
                                '.Parameters.AddWithValue("@ItemSize", (gvtouchsale.Rows(i).Cells(6).Value))
                                '.Parameters.AddWithValue("@ItemColour", (gvtouchsale.Rows(i).Cells(4).Value))
                                .Parameters.AddWithValue("@QtySold", (gvtouchsale.Rows(i).Cells(3).Value))
                                .Parameters.AddWithValue("@DateSold", lbldate.Text)
                                .Parameters.AddWithValue("@TimeSold", lbltime.Text)
                                .Parameters.AddWithValue("@BuyerName", txtBuyerName.Text)
                                .Parameters.AddWithValue("@BuyerTel", txtBuyerTel.Text)
                                .Parameters.AddWithValue("@BuyerLocation", cbLocation.Text)
                                .Parameters.AddWithValue("@NewStock", (gvtouchsale.Rows(i).Cells(10).Value))
                                .Parameters.AddWithValue("@RetailPrice", gvtouchsale.Rows(i).Cells(2).Value)
                                .Parameters.AddWithValue("@Saletype", cbSaleType.Text)
                                .Parameters.AddWithValue("@CreditCustomerName", cbCreditCustName.Text)
                                .Parameters.AddWithValue("@Amount", gvtouchsale.Rows(i).Cells(4).Value)
                                .ExecuteNonQuery()
                            End With
                            con.Close()


                        Next

                        'frmSalesReciept.Show()


                        'MsgBox("Record Saved")
                    End If
                Finally

                    For k = 0 To gvtouchsale.RowCount - 1
                        If con.State = ConnectionState.Closed Then
                            con.Open()
                        End If
                        Dim sqll = "Select * from StockMast where Prodcode=@itemcode"
                        cmd = New SqlCommand(sqll, con)
                        With cmd
                            .Parameters.AddWithValue("@ItemCode", SqlDbType.NVarChar).Value = gvtouchsale.Rows(k).Cells(0).Value
                            .ExecuteNonQuery()
                        End With
                        dr = cmd.ExecuteReader
                        While dr.Read

                            Dim quer = "update StockMast set prodqty = '" & dr.Item("ProdQty") - gvtouchsale.Rows(k).Cells(3).Value & "' where Prodcode= @itemcode"
                            cmd = New SqlCommand(quer, con)
                            With cmd
                                .Parameters.AddWithValue("@ItemCode", SqlDbType.NVarChar).Value = gvtouchsale.Rows(k).Cells(0).Value
                                .ExecuteNonQuery()
                            End With
                            cmd.ExecuteNonQuery()
                        End While
                    Next

                    If con.State = ConnectionState.Closed Then
                        con.Open()
                    End If
                    'Odersaleno.Text = gvtouchsale.Rows(k).Cells(5).Value
                    Dim sql = "delete from OdersConfig where OderNo= '" + lblOderSale.Text + "' "
                    cmd = New SqlCommand(sql, con)
                    cmd.ExecuteNonQuery()
                    MsgBox("Oder Deleted Successfully")
                    Dim oderstatus As String = "sold"
                    Dim query = "update Odertranx set OderStatus = '" + oderstatus + "' where DayoderNo =" + lblOderSale.Text + ""
                    cmd = New SqlCommand(query, con)
                    cmd.ExecuteNonQuery()
                    MsgBox("Oder Status Updated")
                    con.Close()
                    DisplayOders()
                    MsgBox("StockMast Updated")
                    lblTotal.Text = ""
                    Clear()
                    gvtouchsale.Rows.Clear()
                    DisplayOders()


                End Try
            ElseIf (cbSaleType.SelectedIndex = 1) Then
                'cbCreditCustName.Visible = True
                'lblCreditCust.Visible = True
                Dim a = Val(lblTotal.Text)
                Dim b = Val(lblOldBal.Text)
                Dim sum = b - a
                lblNewBal.Text = sum
                If cbCreditCustName.Text = "" Then
                    MsgBox("Choose customer")
                Else
                    Try
                        'reciept()
                        Dim i As Integer
                        If True Then
                            For i = 0 To gvtouchsale.RowCount - 1
                                If con.State = ConnectionState.Closed Then
                                    con.Open()
                                End If
                                Dim query = "insert into salestranx (ItemCode,ItemName,ProdLine,ProdCat,ItemSize,ItemColour,QtySold,DateSold,TimeSold,BuyerName,BuyerTel,BuyerLocation,NewStock,RetailPrice,SaleType,CredCustName,Amount,Soldby,RecieptNo,AmtPaid,Balance) values(@ItemCode,@ItemName,@ProdLine,@ProdCat,@ItemSize,@ItemColour,@QtySold,@DateSold,@TimeSold,@BuyerName,@BuyerTel,@BuyerLocation,@NewStock,@RetailPrice,@SaleType,@CreditCustomerName,@Amount,'" + tsUser.Text + "', '" + lblRecieptNo.Text + "','" + txtCashPaid.Text + "','" + lblChange.Text + "')"
                                Dim cmd As New SqlCommand
                                cmd = New SqlCommand(query, con)
                                With cmd

                                    .Parameters.AddWithValue("@ItemCode", gvtouchsale.Rows(i).Cells(0).Value)
                                    .Parameters.AddWithValue("@Itemname", gvtouchsale.Rows(i).Cells(1).Value)
                                    .Parameters.AddWithValue("@ProdLine", (gvtouchsale.Rows(i).Cells(8).Value))
                                    .Parameters.AddWithValue("@ProdCat", (gvtouchsale.Rows(i).Cells(7).Value))
                                    '.Parameters.AddWithValue("@ItemSize", (gvtouchsale.Rows(i).Cells(6).Value))
                                    '.Parameters.AddWithValue("@ItemColour", (gvtouchsale.Rows(i).Cells(4).Value))
                                    .Parameters.AddWithValue("@QtySold", (gvtouchsale.Rows(i).Cells(3).Value))
                                    .Parameters.AddWithValue("@DateSold", lbldate.Text)
                                    .Parameters.AddWithValue("@TimeSold", lbltime.Text)
                                    .Parameters.AddWithValue("@BuyerName", txtBuyerName.Text)
                                    .Parameters.AddWithValue("@BuyerTel", txtBuyerTel.Text)
                                    .Parameters.AddWithValue("@BuyerLocation", cbLocation.Text)
                                    .Parameters.AddWithValue("@NewStock", (gvtouchsale.Rows(i).Cells(9).Value))
                                    .Parameters.AddWithValue("@RetailPrice", gvtouchsale.Rows(i).Cells(2).Value)
                                    .Parameters.AddWithValue("@Saletype", cbSaleType.Text)
                                    .Parameters.AddWithValue("@CreditCustomerName", cbCreditCustName.Text)
                                    .Parameters.AddWithValue("@Amount", gvtouchsale.Rows(i).Cells(4).Value)
                                    .ExecuteNonQuery()
                                End With
                                con.Close()
                                MsgBox("You Reach")
                            Next
                        End If

                    Finally
                        If con.State = ConnectionState.Closed Then
                            con.Open()
                        End If
                        Dim quer = "Insert into CustomerLedger(CustomerName,oldbal,Newbal,CreditRecieved,DateRecieved,TimeRecieved,CustomerNo)Values('" + cbCreditCustName.Text + "','" + lblOldBal.Text + "','" + lblNewBal.Text + "','" + lblTotal.Text + "','" + lbldate.Text + "','" + lbltime.Text + "','" + lblCustNo.Text + "')"
                        Dim cmd As New SqlCommand
                        cmd = New SqlCommand(quer, con)
                        cmd.ExecuteNonQuery()

                        Dim que = "update Customer set CurrentBalance=@CurBal where CustomerNo = " + lblCustNo.Text + ""
                        Dim cm As New SqlCommand(que, con)
                        With cm

                            .Parameters.AddWithValue("@CurBal", CDbl(lblNewBal.Text))
                            .ExecuteNonQuery()

                        End With


                        MsgBox("Customer Updated")
                        con.Close()

                        For k = 0 To gvtouchsale.RowCount - 1
                            If con.State = ConnectionState.Closed Then
                                con.Open()
                            End If
                            Dim query = "update StockMast set ProdQty = @newstock where ProdCode =" + gvtouchsale.Rows(k).Cells(5).Value + ""
                            Dim cmdd As New SqlCommand
                            cmdd = New SqlCommand(query, con)
                            With cmdd
                                .Parameters.AddWithValue("@newstock", CInt(gvtouchsale.Rows(k).Cells(8).Value))
                                .ExecuteNonQuery()
                            End With
                        Next
                        con.Close()

                        ShowConfig()
                        MsgBox("StockMast Updated")
                        frmSalesReciept.Show()

                        gvtouchsale.Rows.Clear()
                        lblTotal.Text = ""
                        Clear()
                        DisplayOders()
                        lblTotal.Text = ""
                    End Try
                End If
                'If cbSaleType.Text = "" Or cbSaleType.Text = "Credit Sale" Then
                'cbCreditCustName.Visible = False
                'Else
                '  cbCreditCustName.Visible = True

                '     End If                   
            End If
            'Catch ex As Exception
            '  MsgBox(ex.ToString)
            'End Try
        End If
        'PrintReciept()
        ShowConfig()

        'frmSalesReciept.Hide()
    End Sub

    Private Sub gvOders_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles gvOders.CellDoubleClick
        Dim row As DataGridViewRow = gvOders.Rows(e.RowIndex)
        lblOderNo.Text = row.Cells(0).Value.ToString()
        lblOderSale.Text = row.Cells(3).Value.ToString()
        LoadOderSale()
    End Sub

    Private Sub BunifuThinButton25_Click(sender As Object, e As EventArgs) Handles BunifuThinButton25.Click
        ds.Tables("OderReciept").Rows.Clear()

        For Each row As DataGridViewRow In gvOderDetails.Rows
            ds.Tables("OderReciept").Rows.Add(row.Cells(2).Value, row.Cells(3).Value, row.Cells(4).Value)
        Next
        Dim report As New rptOderReciept
        report.SetDataSource(ds)
        frmSupplierReport.Show()
        frmSupplierReport.CrystalReportViewer1.ReportSource = report
        frmSupplierReport.CrystalReportViewer1.Refresh()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        For Each row As DataGridViewRow In gvtouchsale.Rows
            If lblProdCode.Text = row.Cells(0).Value Then
                row.Cells(3).Value += Val(txtQty.Text)
                row.Cells(4).Value = row.Cells(3).Value * row.Cells(2).Value
                row.Cells(10).Value -= Val(txtQty.Text)
                Try
                    Dim sum As Double
                    For k = 0 To gvtouchsale.RowCount - 1
                        sum += gvtouchsale.Rows(k).Cells(4).Value
                    Next
                    lblTotal.Text = sum
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
                dr.Close()
                con.Close()
                Exit Sub
            End If

        Next
        gvtouchsale.Rows.Add(lblProdCode.Text, lblItemName.Text, txtPrice.Text, txtQty.Text, txtAmt.Text, lblDayOder.Text, "Pending", lblCat.Text, lblprodline.Text, lblRecieptNo.Text, one.Text, one.Text, lblOderNo.Text)
        txtQty.Text = ""
        txtPrice.Text = ""
        txtAmt.Text = ""
    End Sub

    Private Sub txtQty_KeyUp(sender As Object, e As KeyEventArgs) Handles txtQty.KeyUp
        txtAmt.Text = Val(txtPrice.Text) * Val(txtQty.Text)
    End Sub


End Class