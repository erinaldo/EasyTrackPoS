

Imports System.Data.SqlClient

Public Class RecieveOder
    'Dim As New SqlConnection(My.Settings.PoSConnectionString)
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter
    Dim dr As SqlDataReader
    Dim dt As New dsGoodsRecieved
    Private Sub frmCreateOder_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Display()

        If Poscon.State = ConnectionState.Closed Then
            Poscon.Open()
        End If
        Dim que = "select * from userlogs"
        cmd = New SqlCommand(que, Poscon)
        da = New SqlDataAdapter(cmd)
        tbl = New DataTable
        da.Fill(tbl)
        Dim index = tbl.Rows.Count() - 1
        If tbl.Rows.Count = 0 Then

        Else
            tsuser.Text = tbl.Rows(index)(1).ToString
        End If

        Poscon.Close()

        'If Poscon.State = ConnectionState.Closed Then
        '    Poscon.Open()
        'End If
        'Dim query = "select ProdName,ProdQty,ProdCat,packprice,Prodcode,packsize,baseqty from StockMast"
        'cmd = New SqlCommand(query, Poscon)
        'da = New SqlDataAdapter(cmd)
        'Dim tbl As New DataTable
        'da.Fill(tbl)
        'gvStockBf.DataSource = tbl
        'Poscon.Close()
        reload("select * from Supplieroderconfig", gvStockBf)

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
            'MsgBox(ex.ToString)
        End Try


    End Sub


    Private Sub gvStock_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)


    End Sub

    Private Sub txtQtyRecieved_TextChanged(sender As Object, e As EventArgs) Handles txtqtyremaining.TextChanged
        Try
            Dim amt As Decimal
            amt = Val(txtqtyremaining.Text) * Val(txtPrice.Text)
            txtAmount.Text = amt
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub


    Private Sub clear()
        txtItemName.Text = ""
        txtPrice.Text = ""
        txtqtyrecieve.Text = ""
        txtAmount.Text = ""
        txtqtyremaining.Text = ""
        lblTotal.Text = ""
        txtinvoiceno.Text = ""
        txtoderqty.Text = ""

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim f2 As New frmInventoryManagement
        f2.Show()
        Me.Hide()


    End Sub

    Private Sub gvStockBatch_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles gvStockBatch.RowsAdded
        Try
            Dim sum As Decimal = 0
            For k = 0 To gvStockBatch.RowCount - 1
                sum += gvStockBatch.Rows(k).Cells(5).Value

            Next
            lblTotal.Text = sum
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub Guna2PictureBox1_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    Private Sub Guna2PictureBox2_Click(sender As Object, e As EventArgs)
        'If WindowState = FormWindowState.Normal Then
        '    WindowState = FormWindowState.Maximized
        'ElseIf WindowState = FormWindowState.Maximized Then
        '    WindowState = FormWindowState.Normal
        'End If
    End Sub

    Private Sub gvStockBf_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles gvStockBf.CellClick
        If gvStockBatch.Rows.Count = 0 Then
            Dim ask As MsgBoxResult
            ask = MsgBox("Would you like to clear Cart?", MsgBoxStyle.YesNo, "")
            If ask = MsgBoxResult.Yes Then
                gvStockBatch.Rows.Clear()
                Dim row As DataGridViewRow = gvStockBf.Rows(e.RowIndex)
                lbloderid.Text = row.Cells(0).Value.ToString()
                If Poscon.State = ConnectionState.Closed Then
                    Poscon.Open()
                End If
                Dim queryy = ("Select Itemname,price,Qtyodered,Qtyrecieved,QtyRemaining from supplieroder where invoiceno='" + lbloderid.Text + "'")
                cmd = New SqlCommand(queryy, Poscon)
                da = New SqlDataAdapter(cmd)
                tbl = New DataTable()
                da.Fill(tbl)
                If tbl.Rows.Count = 0 Then
                    MsgBox("Package Empty")
                    Exit Sub
                End If



                ' lblPayable.Text = tbl.Rows(0)(15).ToString

                For k = 0 To tbl.Rows.Count - 1
                    gvStockBatch.Rows.Add(tbl.Rows(k)(0).ToString, tbl.Rows(k)(1).ToString, tbl.Rows(k)(2).ToString, tbl.Rows(k)(3).ToString, tbl.Rows(k)(4).ToString)
                Next
                Poscon.Close()
            End If

        End If
    End Sub
    Public Sub Search(valueTosearch As String)
        Try
            If Poscon.State = ConnectionState.Closed Then
                Poscon.Open()
            End If
            If cbCatSort.SelectedIndex = -1 Then
                reload("select ProdName,ProdQty,ProdCat,packprice,Prodcode,packsize,baseqty from StockMast where concat(ProdName,ProdCode) like '%" + valueTosearch + "%'", gvStockBf)
            Else
                reload("select ProdName,ProdQty,ProdCat,packprice,Prodcode,packsize,baseqty from StockMast where concat(ProdName,ProdCode) like '%" + valueTosearch + "%' and ProdCat = '" + cbCatSort.Text + "'", gvStockBf)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub cbSearchItem_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbSearchItem.KeyPress
        Search(cbSearchItem.Text)
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        If txtPrice.Text = "" Or txtqtyremaining.Text = "" Then
            MsgBox("Select item or Enter Quantity recieved")
            txtqtyremaining.Focus()
        Else

            For Each row As DataGridViewRow In gvStockBatch.Rows
                If txtItemName.Text = row.Cells(0).Value Then

                    row.Cells(3).Value = txtqtyrecieve.Text
                    row.Cells(5).Value = Val(txtPrice.Text) * Val(txtqtyrecieve.Text)
                End If
            Next

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
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click

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

        Dim i As Integer
        For i = 0 To gvStockBatch.RowCount - 1
            If Poscon.State = ConnectionState.Closed Then
                Poscon.Open()
            End If
            Dim query = "update Supplieroder (invoiceno,ItemName,Price,Amount,QtyOdered,dateodered,Oderedby,itemcat,SupplierName,SupplierID,PackVolume,qtyrecieved,qtyremaining,narration) values('" + txtinvoiceno.Text + "',@Itemname,@Price,@amount,@qtyodered,convert(datetime,'" + DateTime.Now + "',105),'" + tsuser.Text + "',@itemCat,'" + cbSuppName.Text + "','" + lblCustNo.Text + "',@packvolume,'" + "0" + "','" + gvStockBatch.Rows(i).Cells(3).Value + "','" + txtNarration.Text + "')"
            cmd = New SqlCommand(query, Poscon)
            With cmd
                .Parameters.AddWithValue("@Itemname", gvStockBatch.Rows(i).Cells(0).Value)
                .Parameters.AddWithValue("@Price", (gvStockBatch.Rows(i).Cells(2).Value))
                .Parameters.AddWithValue("@amount", (gvStockBatch.Rows(i).Cells(5).Value))
                '.Parameters.AddWithValue("@oldStock", (gvStockBatch.Rows(i).Cells(1).Value))
                '.Parameters.AddWithValue("@newstock", (gvStockBatch.Rows(i).Cells(4).Value))
                .Parameters.AddWithValue("@qtyodered", gvStockBatch.Rows(i).Cells(3).Value)
                .Parameters.AddWithValue("@itemcat", gvStockBatch.Rows(i).Cells(7).Value)
                .Parameters.AddWithValue("@packvolume", gvStockBatch.Rows(i).Cells(8).Value)
                .ExecuteNonQuery()

            End With
        Next

        'If Poscon.State = ConnectionState.Closed Then
        '    Poscon.Open()
        'End If
        'Dim sql = "update Supplier set Balance = '" & lblNewBal.Text & "' where SupplierNo= " & lblCustNo.Text & ""
        'cmd = New SqlCommand(sql, Poscon)
        'cmd.ExecuteNonQuery()
        'MsgBox("Goods Recieved Successful")
        'Poscon.Close()
        Display()
        If ckprint.Checked = True Or tkPreview.Checked = True Then
            printreciept(txtinvoiceno.Text)
        End If
        gvStockBatch.Rows.Clear()
        clear()

        'Newshowconfig()
        cbSuppName.SelectedIndex = -1
    End Sub
    Public Sub Newshowconfig()
        Dim digit As Integer
        Dim result As String
        If Poscon.State = ConnectionState.Closed Then
            Poscon.Open()
        End If
        cmd = New SqlCommand("select max(Goodsid) from RecieveStock", Poscon)
        result = cmd.ExecuteScalar.ToString

        If String.IsNullOrEmpty(result) Then
            result = "SIR0001"
            txtinvoiceno.Text = result
        Else
            result = result.Substring(0)
            Int32.TryParse(result, digit)
            digit = digit + 1
            result = "SIR" + digit.ToString("D4")
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
    Public Sub FillGoods(valueTosearch As String)
        Try
            If Poscon.State = ConnectionState.Closed Then
                Poscon.Open()
            End If

            Dim query = "select ProdName,ProdQty,ProdCat,packprice,Prodcode,packsize,baseqty from StockMast where concat(ProdName,ProdCode) like '%" + valueTosearch + "%'"
            cmd = New SqlCommand(query, Poscon)
            Dim adapter As New SqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)
            gvStockBf.DataSource = table
            txtItemName.Text = table.Rows(0)(0).ToString
            txtPrice.Text = table.Rows(0)(3).ToString
            txtqtyrecieve.Text = table.Rows(0)(1).ToString
            lblProdcode.Text = table.Rows(0)(4).ToString
            txtoderqty.Text = table.Rows(0)(2).ToString
            txtbaseQty.Text = table.Rows(0)(5).ToString
            txtPackSize.Text = table.Rows(0)(6).ToString


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
    Sub Sort(valuetosearch As String)
        If Poscon.State = ConnectionState.Closed Then
            Poscon.Open()
        End If
        Dim query = "select ProdName,ProdQty,ProdCat,packprice,Prodcode,packsize,baseqty from StockMast where ProdCat like '%" + valuetosearch + "%'"
        cmd = New SqlCommand(query, Poscon)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable()
        adapter.Fill(table)
        gvStockBf.DataSource = table
        Poscon.Close()

    End Sub

    Private Sub BunifuThinButton24_Click(sender As Object, e As EventArgs) Handles BunifuThinButton24.Click
        frmCreateOder_Load(e, e)
        'WindowState = FormWindowState.Maximized
    End Sub

    Private Sub BunifuThinButton25_Click(sender As Object, e As EventArgs) Handles BunifuThinButton25.Click
        cbCatSort.SelectedIndex = -1
        cbProdlineSort.SelectedIndex = -1
        Display()
    End Sub

    Private Sub cbCatSort_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbCatSort.SelectionChangeCommitted
        Sort(cbCatSort.Text)
    End Sub

    Private Sub cbSearchItem_TextChanged(sender As Object, e As EventArgs) Handles cbSearchItem.TextChanged
        Search(cbSearchItem.Text)
    End Sub

    Private Sub cbSearchItem_KeyDown(sender As Object, e As KeyEventArgs) Handles cbSearchItem.KeyDown
        If e.KeyCode = Keys.Enter Then
            FillGoods(cbSearchItem.Text)
            txtqtyremaining.Focus()
        End If
    End Sub

    Private Sub txtQtyRecieved_KeyDown(sender As Object, e As KeyEventArgs) Handles txtqtyremaining.KeyDown
        If txtqtyremaining.Text Is Nothing Then
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
            Dim query = "select * from Supplieroder where InvoiceNo ='" + valuetosearch + "'"
            If Poscon.State = ConnectionState.Closed Then
                Poscon.Open()
            End If
            dt.Tables("Supplieroder").Rows.Clear()
            cmd = New SqlCommand(query, Poscon)
            da.SelectCommand = cmd
            da.Fill(dt, "Supplieroder")

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
            MsgBox(ex.ToString)
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

    Private Sub frmCreateOder_Enter(sender As Object, e As EventArgs) Handles MyBase.Enter
        Me.MaximumSize = Screen.FromRectangle(Me.Bounds).WorkingArea.Size
        ' WindowState = FormWindowState.Maximized
        Timer1.Enabled = True
        Display()

        txtdate.Text = Date.Now.ToString("dd-MMM-yy")
        'Newshowconfig()
    End Sub

    Private Sub gvStockBatch_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles gvStockBatch.CellClick
        Dim row As DataGridViewRow = gvStockBatch.Rows(e.RowIndex)
        txtoderqty.Text = row.Cells(2).Value.ToString()
        ' txtqtyrecieve.Text = row.Cells(0).Value.ToString()
        txtqtyremaining.Text = row.Cells(4).Value.ToString()
        txtPrice.Text = row.Cells(1).Value.ToString()
        txtItemName.Text = row.Cells(0).Value.ToString()
    End Sub

    Private Sub txtqtyrecieve_TextChanged(sender As Object, e As EventArgs) Handles txtqtyrecieve.TextChanged
        txtAmount.Text = Val(txtPrice.Text) * Val(txtqtyrecieve.Text)
    End Sub
End Class


