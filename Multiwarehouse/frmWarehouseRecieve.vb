Imports System.Data.SqlClient
Imports System.Globalization
Public Class frmWarehouseRecieve


    'Dim As New SqlConnection(My.Settings.PoSConnectionString)
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter
    Dim dr As SqlDataReader
    Dim dt As New dsGoodsRecieved
    Dim whseno As String = ""

    Private Sub frmRecieveGoods_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Me.MaximumSize = Screen.FromRectangle(Me.Bounds).WorkingArea.Size
            WindowState = FormWindowState.Maximized
            Timer1.Enabled = True
            cbSuppName.SelectedItem = -1
            cbSearchItem.Focus()
            'stxtdate.Text = Date.Now.ToString("dd-MMM-yy")
            'Newshowconfig()
        End Sub
    Private Sub Display()

        reload("select itemname,ProdQty,ProdCat,packprice as CtnPrice,Prodcode,packsize,baseqty,retailprice from whsestockmast", gvStockBf)

        ComboFeed("select itemname from stockmast", cbSearchItem, 0)


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
                    lblOldBal.Text = tbl.Rows(0)(7).ToString
                    lblCustNo.Text = tbl.Rows(0)(0).ToString
                    Dim newbal = Val(lblOldBal.Text) + Val(lblTotal.Text)
                    lblNewBal.Text = newbal
                End If
                Poscon.Close()
            Catch ex As Exception
                'msgbox(ex.message)
            End Try


        End Sub


        Private Sub gvStock_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)


        End Sub

        Private Sub txtQtyRecieved_TextChanged(sender As Object, e As EventArgs) Handles txtQtyRecieved.TextChanged

        Try
                Dim amt As Decimal
                amt = Val(txtQtyRecieved.Text) * Val(txtItemPrice.Text)
                txtItemAmount.Text = amt
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End Sub

        Private Sub Button2_Click(sender As Object, e As EventArgs)
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
                        Dim query = "insert into recievestock (invoiceno,ItemName,Price,Amount,OldStock,NewStock,QtyRecieved,dateRecieved,time,Recievedby,itemcat,Suppliername) values('" + txtinvoiceno.Text + "',@Itemname,@Price,@amount,@oldStock,@newstock,@qtyrecieved,'" + txtdate.Text + "','" + tstime.Text + "','" + tsuser.Text + "',@itemCat,'" + cbSuppName.Text + "')"
                        cmd = New SqlCommand(query, Poscon)
                        With cmd
                            .Parameters.AddWithValue("@Itemname", gvStockBatch.Rows(i).Cells(0).Value)
                            .Parameters.AddWithValue("@Price", CDbl(gvStockBatch.Rows(i).Cells(2).Value))
                            .Parameters.AddWithValue("@amount", CDbl(gvStockBatch.Rows(i).Cells(5).Value))
                            .Parameters.AddWithValue("@oldStock", CDbl(gvStockBatch.Rows(i).Cells(1).Value))
                            .Parameters.AddWithValue("@newstock", CDbl(gvStockBatch.Rows(i).Cells(4).Value))
                            .Parameters.AddWithValue("@qtyrecieved", CDbl(gvStockBatch.Rows(i).Cells(3).Value))
                            .Parameters.AddWithValue("@itemcat", gvStockBatch.Rows(i).Cells(7).Value)
                            .ExecuteNonQuery()

                        End With

                    Next
                    Poscon.Close()
                    MsgBox("Record Saved")

                Finally
                    For k = 0 To gvStockBatch.RowCount - 1
                        If Poscon.State = ConnectionState.Closed Then
                            Poscon.Open()
                        End If
                        Dim query = "update StockMast set Prodqty = '" & gvStockBatch.Rows(k).Cells(4).Value & "' where Prodcode= '" & gvStockBatch.Rows(k).Cells(6).Value & "'"
                        cmd = New SqlCommand(query, Poscon)
                        cmd.ExecuteNonQuery()


                    Next

                    MsgBox("StockMast Updated")
                    Poscon.Close()
                    Display()
                    gvStockBatch.Rows.Clear()
                    clear()

                End Try
            End If
        End Sub
        Private Sub clear()
            txtItemName.Text = ""
            txtItemPrice.Text = ""
            txtActualStock.Text = ""
            txtItemAmount.Text = ""
            txtQtyRecieved.Text = ""
            lblTotal.Text = ""
            txtinvoiceno.Text = ""
            txtCat.Text = ""
            lbloderid.Text = "oder"
            txtCat.Text = ""
            txtWayBill.Text = ""
        End Sub

        Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
            Dim f2 As New frmInventoryManagement
            f2.Show()
            Me.Hide()


        End Sub

    Private Sub gvStockBatch_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs)
        Try
            Dim sum As Decimal = 0
            For k = 0 To gvStockBatch.RowCount - 1
                sum += gvStockBatch.Rows(k).Cells(5).Value

            Next
            lblTotal.Text = sum
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Guna2PictureBox1_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    Private Sub Guna2PictureBox2_Click(sender As Object, e As EventArgs)
        If WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Maximized
        ElseIf WindowState = FormWindowState.Maximized Then
            WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub gvStockBf_CellClick(sender As Object, e As DataGridViewCellEventArgs)

        Try
            Dim row As DataGridViewRow = gvStockBf.Rows(e.RowIndex)
            txtItemName.Text = row.Cells(0).Value.ToString()
            txtItemPrice.Text = row.Cells(3).Value.ToString()
            txtActualStock.Text = row.Cells(1).Value.ToString()
            lblProdcode.Text = row.Cells(4).Value.ToString()
            txtCat.Text = row.Cells(2).Value.ToString()
            txtbaseQty.Text = row.Cells(5).Value.ToString()
            txtPackSize.Text = row.Cells(6).Value.ToString()
            Dim pckvol As New Decimal
            Dim a = Val(txtPackSize.Text)
            Dim b = Val(txtbaseQty.Text)
            pckvol = a * b
            txtPackVolume.Text = pckvol
            txtQtyRecieved.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



    End Sub
    Public Sub Search(valueTosearch As String)
        Try
            If Poscon.State = ConnectionState.Closed Then
                Poscon.Open()
            End If
            If cbCatSort.SelectedIndex = -1 Then
                reload("select itemname,ProdQty,ProdCat,costprice,Prodcode,packsize,baseqty from StockMast where concat(itemname,ProdCode) like '%" + valueTosearch + "%'", gvStockBf)
            Else
                reload("select itemname,ProdQty,ProdCat,costprice,Prodcode,packsize,baseqty from StockMast where concat(itemname,ProdCode) like '%" + valueTosearch + "%' and ProdCat = '" + cbCatSort.Text + "'", gvStockBf)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub cbSearchItem_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbSearchItem.KeyPress
        'Search(cbSearchItem.Text)
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click


        If txtItemPrice.Text = "" Or txtQtyRecieved.Text = "" Then
            MsgBox("Select item or Enter Quantity recieved")
            txtQtyRecieved.Focus()
        Else
            Dim NewStock As Decimal
            Dim a = Val(txtActualStock.Text)
            Dim b = Val(txtQtyRecieved.Text)
            NewStock = a + b
            For Each row As DataGridViewRow In gvStockBatch.Rows
                If lblProdcode.Text = row.Cells(6).Value Then
                    If ComboBox1.SelectedIndex = 1 Then
                        addOder()
                        Exit Sub
                    End If
                    MsgBox("Item already added,Delete existing item to add again")
                    Exit Sub
                End If

            Next

            gvStockBatch.Rows.Add(txtItemName.Text, txtActualStock.Text, txtItemPrice.Text, txtQtyRecieved.Text, NewStock, txtItemAmount.Text, lblProdcode.Text, txtCat.Text, txtPackVolume.Text)
            clear()
        End If
        Try
            Dim sum As Decimal = 0
            For k = 0 To gvStockBatch.RowCount - 1
                sum += gvStockBatch.Rows(k).Cells(5).Value

            Next
            lblTotal.Text = sum
            Dim newbal = Val(lblOldBal.Text) + Val(lblTotal.Text)
            lblNewBal.Text = newbal
            Dim dblValue As Double = Val(lblTotal.Text)
            ' lblTotal.Text = dblValue.ToString("N", CultureInfo.InvariantCulture)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub addOder()

        For Each row As DataGridViewRow In gvStockBatch.Rows
            If lblProdcode.Text = row.Cells(6).Value Then
                row.Cells(3).Value = txtQtyRecieved.Text
                row.Cells(5).Value = Val(txtQtyRecieved.Text) * Val(txtItemPrice.Text)
                row.Cells(1).Value = txtActualStock.Text
                row.Cells(4).Value = Val(txtActualStock.Text) + Val(txtActualStock.Text)
            End If

        Next
        Try
            Dim sum As Decimal = 0
            For k = 0 To gvStockBatch.RowCount - 1
                sum += gvStockBatch.Rows(k).Cells(5).Value
            Next
            lblTotal.Text = sum
            Dim newbal = Val(lblOldBal.Text) + Val(lblTotal.Text)
            lblNewBal.Text = newbal
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        cbSearchItem.Focus()


    End Sub
    Public Sub searchSupp(valuetosearch As String)
        Try
            If Poscon.State = ConnectionState.Closed Then
                Poscon.Open()
            End If
            cmd = New SqlCommand("select supplierno from Supplier where suppliername like '%" + valuetosearch + "%'", Poscon)
            da = New SqlDataAdapter(cmd)
            tbl = New DataTable()
            da.Fill(tbl)
            If tbl.Rows.Count() = 0 Then
            Else
                lblCustNo.Text = tbl.Rows(0)(0).ToString

            End If

            Poscon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click
        If ComboBox1.Text = "" Then
            MsgBox("Kindly select a warehouse")
            Exit Sub
        End If
        If cbSuppName.Text = "" Or lblCustNo.Text = "CustNo" Then
            MsgBox("Choose supplier")
            Exit Sub
        End If
        If gvStockBatch.Rows.Count = 0 Then
            MsgBox("Fill Item Cart")
            Exit Sub
        End If
        If txtinvoiceno.Text = "" Then
            MsgBox("Fill in invoice number")
            Dim ask As MsgBoxResult
            ask = MsgBox("Would you like to Save without invoice number?", MsgBoxStyle.YesNo, "")
            If ask = MsgBoxResult.Yes Then
                Newshowconfig()
            Else
                Exit Sub
            End If
        End If

        Try
            Dim i As Integer
            For i = 0 To gvStockBatch.RowCount - 1
                If Poscon.State = ConnectionState.Closed Then
                    Poscon.Open()
                End If
                Dim query = "insert into whserecievestock (invoiceno,ItemName,Price,Amount,OldStock,NewStock,QtyRecieved,dateRecieved,time,Recievedby,itemcat,SupplierName,SupplierID,PackVolume,narration,waybillno,warehouse) values('" + txtinvoiceno.Text + "',@Itemname,@Price,@amount,@oldStock,@newstock,@qtyrecieved,'" + txtdate.Text + "','" + tstime.Text + "','" + My.Settings.ActiveUser + "',@itemCat,'" + cbSuppName.Text + "','" + lblCustNo.Text + "',@packvolume,'" + txtNarration.Text + "','" + txtWayBill.Text + "','" + ComboBox1.Text + "')"
                cmd = New SqlCommand(query, Poscon)
                With cmd
                    .Parameters.AddWithValue("@Itemname", gvStockBatch.Rows(i).Cells(0).Value)
                    .Parameters.AddWithValue("@Price", (gvStockBatch.Rows(i).Cells(2).Value))
                    .Parameters.AddWithValue("@amount", (gvStockBatch.Rows(i).Cells(5).Value))
                    .Parameters.AddWithValue("@oldStock", (gvStockBatch.Rows(i).Cells(1).Value))
                    .Parameters.AddWithValue("@newstock", (gvStockBatch.Rows(i).Cells(4).Value))
                    .Parameters.AddWithValue("@qtyrecieved", (gvStockBatch.Rows(i).Cells(3).Value))
                    .Parameters.AddWithValue("@itemcat", gvStockBatch.Rows(i).Cells(7).Value)
                    .Parameters.AddWithValue("@packvolume", gvStockBatch.Rows(i).Cells(8).Value)
                    .ExecuteNonQuery()

                End With
            Next

            insertd("insert into SupplierLedger (invoiceno,dateRecieved,timerecieved,Recievedby,SupplierName,SupplierNo,GoodsAmt) values('" + txtinvoiceno.Text + "','" + txtdate.Text + "','" + tstime.Text + "','" + tsuser.Text + "','" + cbSuppName.Text + "','" + lblCustNo.Text + "','" + lblTotal.Text + "')")
            Poscon.Open()

            For Each row As DataGridViewRow In gvStockBatch.Rows
                Dim quer = "insert into whseInventoryLedger (ItemCode,itemname,tranxtype,TranxSource,TranxGroup,oldqty,QtyRecieved,StockBalance,Userid,RetailPrice,CostPrice,RetailAmt,CostAmt,Narration,time,date,suppliername,qtyissued,warehouse) values(@ItemCode,@Itemname,@Tranxtype,@tranxsource,@TranxGroup,@oldqty,@qtyrecieved,@balance,@userid,@Rprice,@cprice,@ramt,@camt,@nar,@time,@date,'" + cbSuppName.Text + "',@qtyissued,'" + ComboBox1.Text + "')"
                cmd = New SqlCommand(quer, Poscon)
                With cmd
                    .Parameters.AddWithValue("@ItemCode", row.Cells(6).Value)
                    .Parameters.AddWithValue("@Itemname", row.Cells(0).Value)
                    .Parameters.AddWithValue("@tranxtype", "Recieved")
                    .Parameters.AddWithValue("@tranxsource", "Recieve Goods")
                    .Parameters.AddWithValue("@tranxgroup", row.Cells(4).Value)
                    .Parameters.AddWithValue("@oldqty", row.Cells(1).Value)
                    .Parameters.AddWithValue("@qtyrecieved", row.Cells(3).Value)
                    .Parameters.AddWithValue("@qtyIssued", "0")
                    .Parameters.AddWithValue("@Balance", row.Cells(4).Value)
                    .Parameters.AddWithValue("@Rprice", row.Cells(2).Value)
                    .Parameters.AddWithValue("@Cprice", row.Cells(2).Value)
                    .Parameters.AddWithValue("@Ramt", row.Cells(5).Value)
                    .Parameters.AddWithValue("@Camt", row.Cells(5).Value)
                    .Parameters.AddWithValue("@Nar", txtNarration.Text)
                    .Parameters.AddWithValue("@userid", My.Settings.ActiveUser)
                    .Parameters.AddWithValue("@Date", txtdate.Text)
                    .Parameters.AddWithValue("@Time", tstime.Text)
                    .ExecuteNonQuery()
                End With
                'MsgBox("Succesfully Wrintten into ledger")
            Next
            'If lbloderid.Text <> "oder" Then
            'create("update supplieroderconfig set supplierinvoice='" + txtWayBill.Text + "' where oderno='" + txtinvoiceno.Text + "'")
            'create("update supplieroder set supplierinvoice='" + txtWayBill.Text + "' where oderno='" + txtinvoiceno.Text + "'")
            'End If

            'Poscon.Close()
            'MsgBox("Record Saved")

        Finally

            'For k = 0 To gvStockBatch.RowCount - 1

            '    insertd("update whseStockMast set prodqty =prodqty + '" & gvStockBatch.Rows(k).Cells(3).Value & "' where Prodcode= '" & gvStockBatch.Rows(k).Cells(6).Value.ToString & "'")


            'Next
            ' Poscon.Open()

            For Each row As DataGridViewRow In gvStockBatch.Rows
                cmd = New SqlCommand("Select * from whseStockMast where Prodcode='" & row.Cells(6).Value.ToString & "' and whsename='" + ComboBox1.Text + "' and whseno='" + whseno + "'", Poscon)
                da = New SqlDataAdapter(cmd)
                    tbl = New DataTable()
                    da.Fill(tbl)
                If tbl.Rows.Count = 0 Then
                    MsgBox("Write")
                    cmd = New SqlCommand("Select * from StockMast where Prodcode='" & row.Cells(6).Value.ToString & "'", Poscon)
                    dr = cmd.ExecuteReader()
                    While dr.Read

                        cmd = New SqlCommand("insert into Whsestockmast (prodcode,prodname,prodline,prodsize,prodcolour,prodcat,prodqty,retailprice,wholesaleprice,itemname,brandname,uniqueid,leastqtyReminder,distributorprice,packsize,baseqty,Packprice,whsename,whseno) values (@prodcode,@prodname,@prodline,@prodsize,@prodcolour,@prodcat,@prodqty,@retailprice,@wholesaleprice,@itemname,@brandname,@uniqueid,@leastqtyReminder,@distributorprice,@packsize,@baseqty,@Packprice,'" + ComboBox1.Text + "','" + whseno + "')", Poscon)
                        With cmd
                            .Parameters.AddWithValue("@prodcode", dr.Item("Prodcode"))
                            .Parameters.AddWithValue("@prodname", dr.Item("itemname"))
                            .Parameters.AddWithValue("@prodline", dr.Item("Prodline"))
                            .Parameters.AddWithValue("@prodsize", dr.Item("Prodsize"))
                            .Parameters.AddWithValue("@prodcolour", dr.Item("Prodcolour"))
                            .Parameters.AddWithValue("@prodcat", dr.Item("Prodcat"))
                            .Parameters.AddWithValue("@prodqty", row.Cells(3).Value)
                            .Parameters.AddWithValue("@itemname", dr.Item("itemname"))
                            .Parameters.AddWithValue("@retailprice", dr.Item("Retailprice"))
                            .Parameters.AddWithValue("@wholesaleprice", dr.Item("Wholesaleprice"))
                            .Parameters.AddWithValue("@brandname", dr.Item("Brandname"))
                            .Parameters.AddWithValue("@uniqueid", dr.Item("uniqueid"))
                            .Parameters.AddWithValue("@leastqtyReminder", dr.Item("leastqtyreminder"))
                            .Parameters.AddWithValue("@distributorprice", dr.Item("distributorprice"))
                            .Parameters.AddWithValue("@packsize", dr.Item("packsize"))
                            .Parameters.AddWithValue("@baseqty", dr.Item("baseqty"))
                            .Parameters.AddWithValue("@Packprice", dr.Item("packprice"))
                            .ExecuteNonQuery()
                        End With
                    End While
                Else
                    MsgBox("Update")
                    'cmd = New SqlCommand("Select * from whseStockMast where Prodcode='" + row.Cells(6).Value + "' and whsename='" + ComboBox1.Text + "' and whseno='" + whseno + "'", Poscon)
                    'dr = cmd.ExecuteReader()
                    '    While dr.Read
                    '    cmd = New SqlCommand("update whsestockmast set prodqty=@Prodqty where Prodcode= '" & row.Cells(6).Value.ToString & "' and whsename='" + cbSuppName.Text + "' and whseno='" + whseno + "'", Poscon)
                    '    With cmd
                    '            .Parameters.AddWithValue("@prodcode", dr.Item("Prodcode"))
                    '            .Parameters.AddWithValue("@prodqty", dr.Item("ProdQty") + row.Cells(3).Value)
                    '            .ExecuteNonQuery()
                    '        End With
                    '    End While
                    'End If
                    insertd("update whsestockmast set prodqty=prodqty + '" & row.Cells(3).Value & "' where Prodcode= '" & row.Cells(6).Value.ToString & "' and whsename='" + ComboBox1.Text + "' and whseno='" + whseno + "'")

                    Display()
                End If
            Next
            reload("select * from whseStockmast", DataGridView1)

            Poscon.Close()
            insertd("update Supplier set Balance = '" & lblNewBal.Text & "' where SupplierNo= " & whseno & "")
            MsgBox("Goods Recieved Successful")
            Poscon.Close()
            Display()
            If ckprint.Checked = True Or tkPreview.Checked = True Then
                printreciept(txtinvoiceno.Text)
            End If

            gvStockBatch.Rows.Clear()
            clear()

        End Try
        'Newshowconfig()
        cbSuppName.SelectedIndex = -1
    End Sub
    Public Sub Newshowconfig()
        Dim digit As Integer
        Dim result As String
        If Poscon.State = ConnectionState.Closed Then
            Poscon.Open()
        End If
        cmd = New SqlCommand("select max(Goodsid) from whseRecieveStock", Poscon)
        result = cmd.ExecuteScalar.ToString

        If String.IsNullOrEmpty(result) Then
            result = "WSIR0001"
            txtinvoiceno.Text = result
        Else
            result = result.Substring(0)
            Int32.TryParse(result, digit)
            digit = digit + 1
            result = "WSIR" + digit.ToString("D4")
            txtinvoiceno.Text = result
        End If
        'txtinvoiceno.Text = "SRV" + Date.Now.ToString("dd") + Date.Now.ToString("MM") + Date.Now.ToString("yy") + Date.Now.ToString("HH") + Date.Now.ToString("mm") + Date.Now.ToString("ss")

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        tstime.Text = Date.Now.ToString("hh:mm:ss tt")
        lbltime.Text = Date.Now.ToString("hh:mm:ss tt")
    End Sub

    Private Sub BunifuThinButton23_Click(sender As Object, e As EventArgs) Handles BunifuThinButton23.Click
        Dim ask As MsgBoxResult
        ask = MsgBox("Would you like to clear Cart?", MsgBoxStyle.YesNo, "")
        If ask = MsgBoxResult.Yes Then
            gvStockBatch.Rows.Clear()
        End If
    End Sub
    Public Sub FillGoods(valueTosearch As String, e As KeyEventArgs)
        Try
            If Poscon.State = ConnectionState.Closed Then
                Poscon.Open()
            End If

            Dim query = "select itemname,ProdQty,ProdCat,packprice as ctnprice,Prodcode,packsize,baseqty,retailprice from StockMast where concat(itemname,prodcode) like '%" + valueTosearch + "%'"
            cmd = New SqlCommand(query, Poscon)
            Dim adapter As New SqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)
            If e.KeyCode = Keys.Enter Then
                If gvStockBf.Rows.Count > 1 Then
                    gvStockBf.DataSource = table
                End If

            End If
            MsgBox(table.Rows.Count)

            cmd = New SqlCommand("select itemname,ProdQty,ProdCat,packprice as ctnprice,Prodcode,packsize,baseqty,retailprice from whseStockMast where concat(itemname,prodcode) like '%" + valueTosearch + "%' and whsename='" + ComboBox1.Text + "'", Poscon)
            da = New SqlDataAdapter(cmd)
            tbl = New DataTable()
            da.Fill(tbl)
            If tbl.Rows.Count = 1 Then
                If table.Rows.Count = 1 Then
                    txtItemName.Text = table.Rows(0)(0).ToString
                    txtItemPrice.Text = table.Rows(0)(3).ToString
                    txtActualStock.Text = tbl.Rows(0)(1).ToString
                    lblProdcode.Text = table.Rows(0)(4).ToString
                    txtCat.Text = table.Rows(0)(2).ToString
                    txtbaseQty.Text = table.Rows(0)(5).ToString
                    txtPackSize.Text = table.Rows(0)(6).ToString
                    txtunitprice.Text = table.Rows(0)(7).ToString

                End If
            Else
                If table.Rows.Count = 1 Then
                    txtItemName.Text = table.Rows(0)(0).ToString
                    txtItemPrice.Text = table.Rows(0)(3).ToString
                    txtActualStock.Text = 0
                    lblProdcode.Text = table.Rows(0)(4).ToString
                    txtCat.Text = table.Rows(0)(2).ToString
                    txtbaseQty.Text = table.Rows(0)(5).ToString
                    txtPackSize.Text = table.Rows(0)(6).ToString
                    txtunitprice.Text = table.Rows(0)(7).ToString

                End If

            End If
            Dim pckvol As New Decimal
            Dim a = Val(txtPackSize.Text)
            Dim b = Val(txtbaseQty.Text)
            pckvol = a * b
            txtPackVolume.Text = pckvol
            Poscon.Close()
        Catch ex As Exception
            clear()
        End Try
    End Sub

    Private Sub cbSuppName_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbSuppName.SelectionChangeCommitted
        Suppliers(cbSuppName.Text)
    End Sub
    Sub catSort(valuetosearch As String)

        reload("select itemname,ProdQty,ProdCat,costprice,Prodcode,packsize,baseqty from StockMast where ProdCat like '%" + valuetosearch + "%'", gvStockBf)

    End Sub

    Private Sub BunifuThinButton24_Click(sender As Object, e As EventArgs) Handles BunifuThinButton24.Click
        frmRecieveGoods_Load(e, e)
        WindowState = FormWindowState.Maximized
    End Sub

    Private Sub BunifuThinButton25_Click(sender As Object, e As EventArgs) Handles BunifuThinButton25.Click
        cbCatSort.SelectedIndex = -1
        cbProdlineSort.SelectedIndex = -1
        Display()
    End Sub

    Private Sub cbCatSort_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbCatSort.SelectionChangeCommitted
        catSort(cbCatSort.Text)
    End Sub

    Private Sub cbSearchItem_TextChanged(sender As Object, e As EventArgs) Handles cbSearchItem.TextChanged
        If cbSearchItem.Text = "" Then
            Display()
        End If
        'Search(cbSearchItem.Text)
    End Sub

    Private Sub cbSearchItem_KeyDown(sender As Object, e As KeyEventArgs) Handles cbSearchItem.KeyDown
        If e.KeyCode = Keys.Enter Then
            FillGoods(cbSearchItem.Text, e)
            txtQtyRecieved.Focus()
        End If
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

    Private Sub txtinvoiceno_KeyDown(sender As Object, e As KeyEventArgs) Handles txtinvoiceno.KeyDown
        If e.KeyCode = Keys.Enter Then
            BunifuThinButton22.Focus()
        End If
    End Sub

    Private Sub BunifuThinButton22_KeyDown(sender As Object, e As KeyEventArgs) Handles BunifuThinButton22.KeyDown
        If e.KeyCode = Keys.Enter Then
            BunifuThinButton22_Click(Nothing, Nothing)
        End If
    End Sub
    Private Sub printreciept(valuetosearch As String)
        Try
            Dim query = "select * from Recievestock where InvoiceNo ='" + valuetosearch + "'"
            If Poscon.State = ConnectionState.Closed Then
                Poscon.Open()
            End If
            dt.Tables("Recievestock").Rows.Clear()
            cmd = New SqlCommand(query, Poscon)
            da.SelectCommand = cmd
            da.Fill(dt, "Recievestock")

            Dim sql = "select * from ClientReg"
            dt.Tables("ClientReg").Rows.Clear()
            cmd = New SqlCommand(sql, Poscon)
            da.SelectCommand = cmd
            da.Fill(dt, "ClientReg")

            Dim report As New rptRecieveStockInvoice
            report.SetDataSource(dt)
            If ckprint.Checked = True Then
                report.PrintToPrinter(1, True, 0, 0)
            End If
            If tkPreview.Checked = True Then
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
    Private Sub BunifuThinButton26_Click(sender As Object, e As EventArgs) Handles BunifuThinButton26.Click
        printreciept(txtReprint.Text)
    End Sub

    Private Sub txtdate_ValueChanged(sender As Object, e As EventArgs)
        lbldate.Text = txtdate.Text
    End Sub

    Private Sub txtdate_ValueChanged_1(sender As Object, e As EventArgs) Handles txtdate.ValueChanged
        lbldate.Text = txtdate.Text
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged


        reload("select itemname,ProdQty,ProdCat,packprice as CtnPrice,Prodcode,packsize,baseqty,retailprice from whsestockmast where whsename='" + ComboBox1.Text + "' ", gvStockBf)


        If Poscon.State = ConnectionState.Closed Then
                Poscon.Open()
            End If
        Dim query = "select whseno from warehouse where whsename = '" + ComboBox1.Text + "'"
        cmd = New SqlCommand(query, Poscon)
        da = New SqlDataAdapter(cmd)
        tbl = New DataTable()
        da.Fill(tbl)
        If tbl.Rows.Count() = 0 Then
        Else

            whseno = tbl.Rows(0)(0).ToString
            MsgBox(whseno)

            ' lblCustBal.Text = dblValue.ToString("N", CultureInfo.InvariantCulture)
        End If

        Poscon.Close()

    End Sub

    Private Sub gvStockBatch_CellClick(sender As Object, e As DataGridViewCellEventArgs)
        Try
            Dim row As DataGridViewRow = gvStockBatch.Rows(e.RowIndex)
            txtCat.Text = row.Cells(7).Value.ToString()
            If ComboBox1.SelectedIndex = 1 Then
                ' txtOrderQty.Text = row.Cells(9).Value.ToString()
            End If
            txtItemPrice.Text = row.Cells(2).Value.ToString()
            lblProdcode.Text = row.Cells(6).Value.ToString()
            txtItemName.Text = row.Cells(0).Value.ToString()
            If Poscon.State = ConnectionState.Closed Then
                Poscon.Open()
            End If
            cmd = New SqlCommand("select prodqty from whseStockmast where prodcode='" + row.Cells(6).Value.ToString() + "' and whsename='" + ComboBox1.Text + "'", Poscon)
            da = New SqlDataAdapter(cmd)
            tbl = New DataTable
            da.Fill(tbl)
            If tbl.Rows.Count = 0 Then

            Else
                txtActualStock.Text = tbl.Rows(0)(0).ToString
            End If
            Poscon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub cbSuppName_TextChanged(sender As Object, e As EventArgs) Handles cbSuppName.TextChanged
            searchSupp(cbSuppName.Text)
        End Sub

        Private Sub txtItemPrice_TextChanged(sender As Object, e As EventArgs) Handles txtItemPrice.TextChanged
            Try
                Dim amt As Decimal
                amt = Val(txtQtyRecieved.Text) * Val(txtItemPrice.Text)
                txtItemAmount.Text = amt
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub

        Private Sub cbProdlineSort_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbProdlineSort.SelectedIndexChanged
            reload("select itemname,ProdQty,ProdCat,costprice,Prodcode,packsize,baseqty from StockMast where prodline = '" + cbProdlineSort.Text + "'", gvStockBf)
        End Sub

        Private Sub frmRecieveGoods_Enter(sender As Object, e As EventArgs) Handles MyBase.Enter

    End Sub

        Private Sub cbSearchItem_Click(sender As Object, e As EventArgs) Handles cbSearchItem.Click

        End Sub

        Private Sub cbSuppName_Click(sender As Object, e As EventArgs) Handles cbSuppName.Click
            ComboFeed("select suppliername from Supplier", cbSuppName, 0)
        End Sub

        Private Sub cbCatSort_Click(sender As Object, e As EventArgs) Handles cbCatSort.Click
            ComboFeed("select distinct(prodcat) from stockmast", cbCatSort, 0)
        End Sub

        Private Sub cbProdlineSort_Click(sender As Object, e As EventArgs) Handles cbProdlineSort.Click
            ComboFeed("select distinct(prodline) from stockmast", cbProdlineSort, 0)
        End Sub

        Private Sub gvStockBf_CellClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles gvStockBf.CellClick




        Try
                        Dim row As DataGridViewRow = gvStockBf.Rows(e.RowIndex)
                        txtItemName.Text = row.Cells(0).Value.ToString()
                        txtItemPrice.Text = row.Cells(3).Value.ToString()
                        txtActualStock.Text = row.Cells(1).Value.ToString()
                        lblProdcode.Text = row.Cells(4).Value.ToString()
                        txtCat.Text = row.Cells(2).Value.ToString()
                        txtbaseQty.Text = row.Cells(5).Value.ToString()
                        txtPackSize.Text = row.Cells(6).Value.ToString()
                        txtunitprice.Text = row.Cells(6).Value.ToString()
                        Dim pckvol As New Decimal
                        Dim a = Val(txtPackSize.Text)
                        Dim b = Val(txtbaseQty.Text)
                        pckvol = a * b
                        txtPackVolume.Text = pckvol
                        txtQtyRecieved.Focus()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try





    End Sub

        Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click
            For Each row As DataGridViewRow In gvStockBatch.Rows
                dt.Tables("Recievestock").Rows.Clear()
                dt.Tables("Recievestock").Rows.Add("Preview", row.Cells(0).Value, row.Cells(2).Value, row.Cells(5).Value, 0, 0, row.Cells(3).Value)
            Next
            Dim report As New rptRecieveStockInvoice
            report.SetDataSource(dt)
            frmSupplierReport.Show()
            frmSupplierReport.CrystalReportViewer1.ReportSource = report
            frmSupplierReport.CrystalReportViewer1.Refresh()
        End Sub

    Private Sub cbSearchItem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSearchItem.SelectedIndexChanged

    End Sub

    Private Sub ComboBox1_Click(sender As Object, e As EventArgs) Handles ComboBox1.Click
        ComboFeed("select whsename from warehouse", ComboBox1, 0)
    End Sub
End Class

