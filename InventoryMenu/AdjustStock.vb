Imports System.Data.SqlClient

Public Class frmAdjustStock
    Dim con As New SqlConnection(My.Settings.PoSConnectionString)
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter
    Dim dr As SqlDataReader
    Private Sub AdjustStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MaximumSize = Screen.FromRectangle(Me.Bounds).WorkingArea.Size
        WindowState = FormWindowState.Maximized
        Display()
        Timer1.Enabled = True
        txtDate.Text = Date.Now.ToString("dd-MMM-yy")

        User()
        cbSearchItem.Focus()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cbSearchItem.Items.Clear()
        Dim sql = "select * from Stockmast"
        cmd = New SqlCommand(sql, con)
        dr = cmd.ExecuteReader
        While dr.Read
            cbSearchItem.Items.Add(dr(1))
        End While
        con.Close()

        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cbCatSort.Items.Clear()
        Dim sqll = "select category from Category"
        cmd = New SqlCommand(sqll, con)
        dr = cmd.ExecuteReader
        While dr.Read
            cbCatSort.Items.Add(dr(0))
        End While
        con.Close()
        Clear()
    End Sub

    Private Sub User()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim que = "select * from userlogs"
        cmd = New SqlCommand(que, con)
        da = New SqlDataAdapter(cmd)
        Dim table As New DataTable
        da.Fill(table)
        If table.Rows.Count = 0 Then

        Else

            Dim index = table.Rows.Count() - 1
            activeuser.Text = table.Rows(index)(1).ToString
        End If

        con.Close()
    End Sub

    Private Sub Display()
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            Dim query = "select Prodcode,ProdName,prodsize,ProdQty,retailprice,prodcat,prodline,prodcolour from StockMast"
            cmd = New SqlCommand(query, con)
            da = New SqlDataAdapter(cmd)
            Dim tbl As New DataTable
            da.Fill(tbl)
            gvStockBf.DataSource = tbl
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        If txtActualStock.Text = "" Then
            MsgBox("Select Item to Adjust")
            Exit Sub
        End If
        Try
            gvStockBatch.Rows.Add(txtItemName.Text, txtCat.Text, txtActualStock.Text, txtItemPrice.Text, txtNewStock.Text, txtItemAmount.Text, lblStockcode.Text, txtprodline.Text)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Clear()

    End Sub
    Dim key = ""
    Private Sub gvStock_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gvStock.CellContentClick
        Try
            Dim row As DataGridViewRow = gvStock.Rows(e.RowIndex)

            txtItemName.Text = row.Cells(1).Value.ToString()
            txtItemPrice.Text = row.Cells(4).Value.ToString()
            txtActualStock.Text = row.Cells(2).Value.ToString()
            lblStockcode.Text = row.Cells(0).Value.ToString()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        If gvStockBatch.Rows.Count = 0 Then
            MsgBox("Select Items to Adjust")
            Exit Sub
        End If
        Try

            For k = 0 To gvStockBatch.RowCount - 1
                If con.State = ConnectionState.Closed Then
                    con.Open()
                End If
                Dim i As Integer
                For i = 0 To gvStockBatch.RowCount - 1
                    If con.State = ConnectionState.Closed Then
                        con.Open()
                    End If
                    Dim que = "insert into AdjustStock (ProdLine,ItemName,ItemCat,OldQty,AdjustmentQty,DateAdjusted,AdjustedBy,Price,Narration,time) values(@Prodline,@Itemname,@ItemCat,@oldqty,@AdjustmentQty,'" + txtDate.Text + "','" + activeuser.Text + "',@Price,'" + txtnarration.Text + "','" + lbltime.Text + "')"
                    cmd = New SqlCommand(que, con)
                    With cmd
                        .Parameters.AddWithValue("@Prodline", gvStockBatch.Rows(i).Cells(7).Value)
                        .Parameters.AddWithValue("@itemname", gvStockBatch.Rows(i).Cells(0).Value)
                        .Parameters.AddWithValue("@itemcat", gvStockBatch.Rows(i).Cells(1).Value)
                        .Parameters.AddWithValue("@adjustmentqty", gvStockBatch.Rows(i).Cells(4).Value)
                        .Parameters.AddWithValue("@price", gvStockBatch.Rows(i).Cells(3).Value)
                        .Parameters.AddWithValue("@oldqty", gvStockBatch.Rows(i).Cells(2).Value)
                        .ExecuteNonQuery()

                    End With

                Next
                ' MsgBox("Record Saved")
                If con.State = ConnectionState.Closed Then
                    con.Open()
                End If

                Dim query = "update StockMast set Prodqty = @newstock where prodcode =" + gvStockBatch.Rows(k).Cells(6).Value + ""
                cmd = New SqlCommand(query, con)
                With cmd
                    .Parameters.AddWithValue("@newstock", gvStockBatch.Rows(k).Cells(4).Value)
                    .ExecuteNonQuery()
                End With
                For Each row As DataGridViewRow In gvStockBatch.Rows
                    Dim quer = "insert into InventoryLedger (ItemCode,itemname,tranxtype,TranxSource,TranxGroup,oldqty,QtyRecieved,StockBalance,Userid,RetailPrice,CostPrice,RetailAmt,CostAmt,Narration,time,date,qtyissued) values(@ItemCode,@Itemname,@Tranxtype,@tranxsource,@TranxGroup,@oldqty,@qtyrecieved,@balance,@userid,@Rprice,@cprice,@ramt,@camt,@nar,@time,@date,@qtyissued)"
                    cmd = New SqlCommand(quer, con)
                    With cmd
                        .Parameters.AddWithValue("@ItemCode", row.Cells(6).Value)
                        .Parameters.AddWithValue("@Itemname", row.Cells(0).Value)
                        .Parameters.AddWithValue("@tranxtype", "Adjusted")
                        .Parameters.AddWithValue("@tranxsource", "Adjust Stock")
                        .Parameters.AddWithValue("@tranxgroup", row.Cells(4).Value)
                        .Parameters.AddWithValue("@oldqty", row.Cells(2).Value)
                        If row.Cells(2).Value > row.Cells(4).Value Then
                            .Parameters.AddWithValue("@qtyissued", row.Cells(3).Value)
                        End If
                        If row.Cells(2).Value < row.Cells(4).Value Then
                            .Parameters.AddWithValue("@qtyrecieved", row.Cells(3).Value)
                        End If
                        .Parameters.AddWithValue("@Balance", row.Cells(4).Value)
                        .Parameters.AddWithValue("@Rprice", row.Cells(3).Value)
                        .Parameters.AddWithValue("@Cprice", row.Cells(3).Value)
                        .Parameters.AddWithValue("@Ramt", row.Cells(5).Value)
                        .Parameters.AddWithValue("@Camt", row.Cells(5).Value)
                        .Parameters.AddWithValue("@Nar", txtnarration.Text)
                        .Parameters.AddWithValue("@userid", activeuser.Text)
                        .Parameters.AddWithValue("@Date", txtDate.Text)
                        .Parameters.AddWithValue("@Time", lbltime.Text)
                        .ExecuteNonQuery()
                    End With
                    'MsgBox("Succesfully Wrintten into ledger")
                Next
            Next
            con.Close()
            MsgBox("Successfully Adjusted Stock")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Display()
        Clear()
        gvStockBatch.Rows.Clear()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        frmInventoryManagement.Show()
        Me.Hide()
    End Sub

    Private Sub txtNewStock_TextChanged(sender As Object, e As EventArgs) Handles txtNewStock.TextChanged

        If txtNewStock.Text = "" Then
            txtItemAmount.Text = ""
        Else
            Dim a = Val(txtItemPrice.Text)
            Dim b = Val(txtNewStock.Text)
            txtItemAmount.Text = Val(a * b)
        End If




    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles txtDate.TextChanged

    End Sub

    Private Sub gvStock_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles gvStock.CellClick
        Try
            Dim row As DataGridViewRow = gvStock.Rows(e.RowIndex)

            txtItemName.Text = row.Cells(1).Value.ToString()
            txtItemPrice.Text = row.Cells(4).Value.ToString()
            txtActualStock.Text = row.Cells(2).Value.ToString()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub gvStockBf_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles gvStockBf.CellClick
        Try
            Dim row As DataGridViewRow = gvStockBf.Rows(e.RowIndex)

            txtItemName.Text = row.Cells(1).Value.ToString()
            txtItemPrice.Text = row.Cells(4).Value.ToString()
            txtActualStock.Text = row.Cells(3).Value.ToString()
            lblStockcode.Text = row.Cells(0).Value.ToString()
            txtCat.Text = row.Cells(5).Value.ToString()
            txtprodline.Text = row.Cells(6).Value.ToString()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Guna2PictureBox3_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox3.Click
        If WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Maximized
        ElseIf WindowState = FormWindowState.Maximized Then
            WindowState = FormWindowState.Normal
        End If

    End Sub

    Private Sub Guna2PictureBox4_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox4.Click
        Application.Exit()
    End Sub
    Private Sub Clear()
        txtItemName.Text = ""
        txtItemPrice.Text = ""
        txtActualStock.Text = ""
        txtItemAmount.Text = ""
        txtNewStock.Text = ""
        lblStockcode.Text = ""
        cbSearchItem.Text = ""

    End Sub

    Private Sub txtNewStock_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNewStock.KeyPress
        'If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
        '    e.Handled = True
        '    'MsgBox("This field will accept numbers only")
        'End If
    End Sub

    Private Sub cbSearchItem_KeyUp(sender As Object, e As KeyEventArgs) Handles cbSearchItem.KeyUp
        Search(cbSearchItem.Text)
    End Sub
    Public Sub Search(valueTosearch As String)
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            If cbCatSort.SelectedIndex = -1 Then
                Dim query = "select Prodcode,ProdName,prodsize,ProdQty,retailprice,prodcat,prodline,prodcolour from StockMast where concat(ProdName,ProdCode) like '%" + valueTosearch + "%'"
                cmd = New SqlCommand(query, con)
                Dim adapter As New SqlDataAdapter(cmd)
                Dim table As New DataTable()
                adapter.Fill(table)
                gvStockBf.DataSource = table
            Else
                Dim query = "select Prodcode,ProdName,prodsize,ProdQty,retailprice,prodcat,prodline,prodcolour from StockMast where concat(ProdName,ProdCode) like '%" + valueTosearch + "%' and ProdCat = '" + cbCatSort.Text + "'"
                cmd = New SqlCommand(query, con)
                Dim adapter As New SqlDataAdapter(cmd)
                Dim table As New DataTable()
                adapter.Fill(table)
                gvStockBf.DataSource = table
            End If

            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        txtDate.Text = Date.Now.ToString("dd-MMM-yy")
        lbltime.Text = Date.Now.ToString("hh:mm:ss tt")
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        AdjustStock_Load(e, e)
    End Sub

    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click
        If txtItemName.Text = "" Then
            MsgBox("Select Item to Adjust")
            Exit Sub
        End If
        Try
            gvStockBatch.Rows.Add(txtItemName.Text, txtCat.Text, txtActualStock.Text, txtItemPrice.Text, txtNewStock.Text, txtItemAmount.Text, lblStockcode.Text, txtprodline.Text)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Clear()
    End Sub

    Private Sub BunifuThinButton23_Click(sender As Object, e As EventArgs) Handles BunifuThinButton23.Click
        If gvStockBatch.Rows.Count = 0 Then
            MsgBox("Select Items to Adjust")
            Exit Sub
        End If
        Try


            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            Dim i As Integer
            For i = 0 To gvStockBatch.RowCount - 1
                If con.State = ConnectionState.Closed Then
                    con.Open()
                End If
                Dim que = "insert into AdjustStock (ProdLine,ItemName,ItemCat,OldQty,AdjustmentQty,DateAdjusted,AdjustedBy,Price,Narration,time) values(@Prodline,@Itemname,@ItemCat,@oldqty,@AdjustmentQty,'" + txtDate.Text + "','" + activeuser.Text + "',@Price,'" + txtnarration.Text + "','" + lbltime.Text + "')"
                cmd = New SqlCommand(que, con)
                With cmd
                    .Parameters.AddWithValue("@Prodline", gvStockBatch.Rows(i).Cells(7).Value)
                    .Parameters.AddWithValue("@itemname", gvStockBatch.Rows(i).Cells(0).Value)
                    .Parameters.AddWithValue("@itemcat", gvStockBatch.Rows(i).Cells(1).Value)
                    .Parameters.AddWithValue("@adjustmentqty", gvStockBatch.Rows(i).Cells(4).Value)
                    .Parameters.AddWithValue("@price", gvStockBatch.Rows(i).Cells(3).Value)
                    .Parameters.AddWithValue("@oldqty", gvStockBatch.Rows(i).Cells(2).Value)
                    .ExecuteNonQuery()

                End With

            Next
            ' MsgBox("Record Saved")
            For k = 0 To gvStockBatch.RowCount - 1
                If con.State = ConnectionState.Closed Then
                    con.Open()
                End If
                Dim sqll = "Select * from StockMast where Prodcode='" + gvStockBatch.Rows(k).Cells(6).Value + "'"
                cmd = New SqlCommand(sqll, con)
                dr = cmd.ExecuteReader
                While dr.Read
                    Dim query = "update StockMast set Prodqty = @newstock where prodcode =" + gvStockBatch.Rows(k).Cells(6).Value + ""
                    cmd = New SqlCommand(query, con)
                    With cmd
                        .Parameters.AddWithValue("@newstock", dr.Item("ProdQty") + gvStockBatch.Rows(k).Cells(4).Value)
                        .ExecuteNonQuery()
                    End With

                End While
            Next

            For Each row As DataGridViewRow In gvStockBatch.Rows
                        Dim quer = "insert into InventoryLedger (ItemCode,itemname,tranxtype,TranxSource,TranxGroup,oldqty,QtyRecieved,StockBalance,Userid,RetailPrice,CostPrice,RetailAmt,CostAmt,Narration,time,date) values(@ItemCode,@Itemname,@Tranxtype,@tranxsource,@TranxGroup,@oldqty,@qtyrecieved,@balance,@userid,@Rprice,@cprice,@ramt,@camt,@nar,@time,@date)"
                        cmd = New SqlCommand(quer, con)
                        With cmd
                            .Parameters.AddWithValue("@ItemCode", row.Cells(6).Value)
                            .Parameters.AddWithValue("@Itemname", row.Cells(0).Value)
                            .Parameters.AddWithValue("@tranxtype", "Adjust")
                            .Parameters.AddWithValue("@tranxsource", "Adjust Stock")
                            .Parameters.AddWithValue("@tranxgroup", row.Cells(4).Value)
                            .Parameters.AddWithValue("@oldqty", row.Cells(2).Value)
                            .Parameters.AddWithValue("@qtyrecieved", row.Cells(4).Value)
                            .Parameters.AddWithValue("@Balance", row.Cells(4).Value)
                            .Parameters.AddWithValue("@Rprice", row.Cells(3).Value)
                            .Parameters.AddWithValue("@Cprice", row.Cells(3).Value)
                            .Parameters.AddWithValue("@Ramt", row.Cells(5).Value)
                            .Parameters.AddWithValue("@Camt", row.Cells(5).Value)
                            .Parameters.AddWithValue("@Nar", txtnarration.Text)
                            .Parameters.AddWithValue("@userid", activeuser.Text)
                            .Parameters.AddWithValue("@Date", txtDate.Text)
                            .Parameters.AddWithValue("@Time", lbltime.Text)
                            .ExecuteNonQuery()
                        End With

                    Next
                con.Close()
            'MsgBox("Successfully Adjusted Stock")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Display()
        Clear()
        gvStockBatch.Rows.Clear()
    End Sub
    Sub Sort(valuetosearch As String)
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim query = "select Prodcode,ProdName,prodsize,ProdQty,retailprice,prodcat,prodline,prodcolour from StockMast where ProdCat like '%" + valuetosearch + "%'"
        cmd = New SqlCommand(query, con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable()
        adapter.Fill(table)
        gvStockBf.DataSource = table
        con.Close()

    End Sub
    Public Sub FillItems(valueTosearch As String)
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If

            Dim query = "select Prodcode,ProdName,prodsize,ProdQty,retailprice,prodcat,prodline,prodcolour from StockMast where concat(ProdName,ProdCode) like '%" + valueTosearch + "%'"
            cmd = New SqlCommand(query, con)
            Dim adapter As New SqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)
            gvStockBf.DataSource = table
            txtItemName.Text = table.Rows(0)(1).ToString
            txtItemPrice.Text = table.Rows(0)(4).ToString
            txtActualStock.Text = table.Rows(0)(3).ToString
            lblStockcode.Text = table.Rows(0)(0).ToString
            txtCat.Text = table.Rows(0)(5).ToString
            txtprodline.Text = table.Rows(0)(6).ToString
            con.Close()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub cbSearchItem_KeyDown(sender As Object, e As KeyEventArgs) Handles cbSearchItem.KeyDown
        If e.KeyCode = Keys.Enter Then
            Fillitems(cbSearchItem.Text)
            txtNewStock.Focus()
        End If
    End Sub

    Private Sub cbSearchItem_TextChanged(sender As Object, e As EventArgs) Handles cbSearchItem.TextChanged
        Search(cbSearchItem.Text)
    End Sub

    Private Sub cbCatSort_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbCatSort.SelectionChangeCommitted
        Sort(cbCatSort.Text)
    End Sub

    Private Sub BunifuThinButton25_Click(sender As Object, e As EventArgs) Handles BunifuThinButton25.Click
        cbCatSort.SelectedIndex = -1
        cbProdlineSort.SelectedIndex = -1
        Display()
    End Sub

    Private Sub txtNewStock_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNewStock.KeyDown
        If txtNewStock.Text Is Nothing Then
            MsgBox("Enter Qty")
            Exit Sub
        End If
        If e.KeyCode = Keys.Enter Then
            BunifuThinButton22_Click(Nothing, Nothing)
            cbSearchItem.Focus()
        End If
    End Sub

    Private Sub ToolStripStatusLabel1_DoubleClick(sender As Object, e As EventArgs) Handles ToolStripStatusLabel1.DoubleClick
        BunifuThinButton23_Click(Nothing, Nothing)
    End Sub
End Class