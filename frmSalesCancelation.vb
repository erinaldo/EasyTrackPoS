Imports System.Data.SqlClient
Imports System.Globalization
Public Class frmSalesCancelation
    'Dim  As New SqlConnection(My.Settings.PoSConnectionString)
    Dim dr As SqlDataReader
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter
    Dim action As String = "Startup"
    Dim query As String
    Private WithEvents lblPrice As New Label
    Dim dt As New dsSalesTranx

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtRecieptNo.TextChanged

    End Sub

    Private Sub Display()

        If Poscon.State = ConnectionState.Closed Then
            Poscon.Open()
        End If
        Dim query = "select SalesPerson,RecieptId from RecieptConfig"
        cmd = New SqlCommand(query, Poscon)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable()
        adapter.Fill(tbl)
        gvReciepts.DataSource = tbl
        Poscon.Close()

    End Sub

    Private Sub LoadReciepts(RecieptNo As String)
        gvSalesReciepts.Rows.Clear()
        If Poscon.State = ConnectionState.Closed Then
            Poscon.Open()
        End If
        lblRecieptNo.Text = txtRecieptNo.Text
        Dim query = "Select * from SalesTranx where RecieptNo='" + RecieptNo + "'"
        cmd = New SqlCommand(query, Poscon)
        dr = cmd.ExecuteReader

        While dr.Read
            If dr.Item("BuyerName").ToString = "" Then
            Else
                lblBuyerName.Text = dr.Item("BuyerName")
            End If
            If dr.Item("BuyerTel").ToString = "" Then
            Else
                lblBuyerTel.Text = dr.Item("BuyerTel")
            End If
            If dr.Item("DateSold").ToString = "" Then
            Else
                lblDateSold.Text = dr.Item("DateSold")
            End If
            If dr.Item("BuyerLocation").ToString = "" Then
            Else
                lblCustLoc.Text = dr.Item("BuyerLocation")
            End If
            If dr.Item("TimeSold").ToString = "" Then
            Else
                lblTimeSold.Text = dr.Item("TimeSold").ToString
            End If


            gvSalesReciepts.Rows.Add(dr.Item("ItemCode").ToString, dr.Item("ItemName").ToString, dr.Item("QtySold").ToString, dr.Item("RetailPrice").ToString, dr.Item("Amount").ToString, dr.Item("RecieptNo"))


        End While

        dr.Close()
        Poscon.Close()

    End Sub

    Private Sub frmSalesCancelation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Me.MaximumSize = Screen.FromRectangle(Me.Bounds).WorkingArea.Size
        WindowState = FormWindowState.Maximized
        Display()
        User()
        'Dim milliseconds = CLng(DateTime.UtcNow.Subtract(New DateTime(1970, 1, 1)).TotalMilliseconds)
        'MsgBox(milliseconds)
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        LoadReciepts(txtRecieptNo.Text)
    End Sub

    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click
        If lblRecieptNo.Text = "" Then
            MsgBox("Select Reciept to Cancel")
            Exit Sub
        End If
        If gvSalesReciepts.Rows.Count = 0 Then
            MsgBox("Select Reciept to Cancel")
            Exit Sub
        End If
        If txtToBeCancelled.Text = "" Or txtQtySold.Text = "" Then
            MsgBox("Select Item and Enter Quantity to be canceled")
            Exit Sub
        End If
        For Each row As DataGridViewRow In gvSalesReciepts.Rows
            If lblProdCode.Text = row.Cells(0).Value And lblRecieptNo.Text = row.Cells(5).Value Then
                row.Cells(6).Value = txtNewQtySold.Text
                row.Cells(7).Value = row.Cells(6).Value * row.Cells(3).Value
                row.Cells(8).Value = txtToBeCancelled.Text
                row.Cells(9).Value = Val(txtToBeCancelled.Text) + Val(lblActualStock.Text)
            End If

        Next
        Clear()
    End Sub

    Private Sub gvSalesReciepts_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles gvSalesReciepts.CellClick
        Try
            Dim row As DataGridViewRow = gvSalesReciepts.Rows(e.RowIndex)
            lblItemName.Text = row.Cells(1).Value.ToString()
            txtQtySold.Text = row.Cells(2).Value.ToString()
            lblProdCode.Text = row.Cells(0).Value.ToString()
            lblRecieptNo.Text = row.Cells(5).Value.ToString()

            If Poscon.State = ConnectionState.Closed Then
                Poscon.Open()
            End If

            Dim quer = "Select * from StockMast where Prodcode='" + lblProdCode.Text + "'"
            cmd = New SqlCommand(quer, Poscon)
            dr = cmd.ExecuteReader
            While dr.Read
                lblActualStock.Text = dr.Item("ProdQty")

            End While
            Poscon.Close()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtToBeCancelled_TextChanged(sender As Object, e As EventArgs) Handles txtToBeCancelled.TextChanged
        Dim a As New Decimal
        Dim b As New Decimal
        Dim c As New Decimal
        a = Val(txtQtySold.Text)
        b = Val(txtToBeCancelled.Text)
        c = a - b
        txtNewQtySold.Text = c


    End Sub
    Sub Clear()
        txtQtySold.Text = ""
        txtToBeCancelled.Text = ""
        lblProdCode.Text = ""
        lblItemName.Text = ""


    End Sub

    Private Sub BunifuThinButton23_Click(sender As Object, e As EventArgs) Handles BunifuThinButton23.Click

        If gvSalesReciepts.Rows.Count = 0 Then
            MsgBox("Select Reciept to cancel")
            Exit Sub
        End If
        For Each row As DataGridViewRow In gvSalesReciepts.Rows
            For i = 6 To 7
                If row.Cells(i).Value Is Nothing Then
                    row.Cells(6).Value = row.Cells(2).Value
                    row.Cells(7).Value = row.Cells(4).Value
                End If
            Next
            For k = 8 To 9
                If row.Cells(k).Value Is Nothing Then
                    row.Cells(k).Value = 0
                End If
            Next
            If Poscon.State = ConnectionState.Closed Then
                Poscon.Open()
            End If
            Dim query = "insert into cancellationlog (ItemCode,ItemName,QtySold,DateSold,TimeSold,BuyerName,BuyerTel,BuyerLocation,QtyCancelled,Price,Cancelledby,RecieptNo,DateCancelled,TimeCancelled) values(@ItemCode,@ItemName,@QtySold,@DateSold,@TimeSold,@BuyerName,@BuyerTel,@BuyerLocation,@NewStock,@RetailPrice,'" + ActiveUser.Text + "', '" + lblRecieptNo.Text + "','" + lblDate.Text + "','" + lblTime.Text + "')"
            Dim cmd As New SqlCommand
            cmd = New SqlCommand(query, Poscon)
            With cmd

                .Parameters.AddWithValue("@ItemCode", row.Cells(0).Value)
                .Parameters.AddWithValue("@Itemname", row.Cells(1).Value)
                .Parameters.AddWithValue("@QtySold", row.Cells(2).Value)
                .Parameters.AddWithValue("@DateSold", CDate(lblDateSold.Text))
                .Parameters.AddWithValue("@TimeSold", lblTimeSold.Text)
                .Parameters.AddWithValue("@BuyerName", lblBuyerName.Text)
                .Parameters.AddWithValue("@BuyerTel", lblBuyerTel.Text)
                .Parameters.AddWithValue("@BuyerLocation", lblCustLoc.Text)
                .Parameters.AddWithValue("@NewStock", row.Cells(8).Value)
                .Parameters.AddWithValue("@RetailPrice", row.Cells(3).Value)
                .ExecuteNonQuery()

            End With
        Next

        For Each row As DataGridViewRow In gvSalesReciepts.Rows

            If Poscon.State = ConnectionState.Closed Then
                Poscon.Open()
            End If

            Dim sqll = "update Salestranx set QtySold = @newstock, Amount=@newamt where ItemCode =@itemcode and RecieptNo='" + lblRecieptNo.Text + "'"
            cmd = New SqlCommand(sqll, Poscon)
            With cmd
                .Parameters.AddWithValue("@ItemCode", SqlDbType.NVarChar).Value = row.Cells(0).Value
                .Parameters.AddWithValue("@newstock", row.Cells(6).Value)
                .Parameters.AddWithValue("@newamt", row.Cells(7).Value)
                .ExecuteNonQuery()

            End With



            Dim query = "update StockMast set ProdQty = @newstock where Prodcode =" + row.Cells(0).Value + ""
            cmd = New SqlCommand(query, Poscon)
            With cmd
                Dim sql = "Select * from StockMast where ProdCode='" + row.Cells(0).Value + "'"
                cmd = New SqlCommand(sql, Poscon)
                dr = cmd.ExecuteReader
                While dr.Read

                    lblActualStock.Text = dr.Item("ProdQty")

                    .Parameters.AddWithValue("@newstock", dr.Item("ProdQty") + row.Cells(8).Value)
                    .ExecuteNonQuery()
                End While
            End With

        Next
        If ckA5Paper.Checked = True Then
            PrintRecieptA5(txtRecieptNo.Text)
        ElseIf ckrollPaper.Checked = True Then
            RollReciept(txtRecieptNo.Text)
        ElseIf ckA4.Checked = True Then
            PrintRecieptA4(txtRecieptNo.Text)
        End If
        gvSalesReciepts.Rows.Clear()
        Poscon.Close()
    End Sub
    Private Sub ckA4_Click(sender As Object, e As EventArgs) Handles ckA4.Click
        If ckA4.Checked = True Then
            ckA5Paper.Checked = False
            ckrollPaper.Checked = False
        Else
            ckA4.Checked = True
        End If
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
    Public Sub SearchRecieptNo(valuetosearch As String)
        Try
            If Poscon.State = ConnectionState.Closed Then
                Poscon.Open()
            End If
            Dim query = "select SalesPerson,RecieptId from RecieptConfig where concat(SalesPerson,RecieptId,date) like '%" + valuetosearch + "%'"
            cmd = New SqlCommand(query, Poscon)
            Dim adapter As New SqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)
            gvReciepts.DataSource = table
            Poscon.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTime.Text = Date.Now.ToString("hh:mm:ss")
        lblDate.Text = Date.Now.ToString("dd-MMM-yy")
    End Sub

    Private Sub gvReciepts_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles gvReciepts.CellClick
        Dim row As DataGridViewRow = gvReciepts.Rows(e.RowIndex)
        txtRecieptNo.Text = row.Cells(1).Value.ToString()
        LoadReciepts(txtRecieptNo.Text)
    End Sub

    Private Sub BunifuThinButton24_Click(sender As Object, e As EventArgs) Handles BunifuThinButton24.Click
        Dim que = "select * from ActiveSession"
        cmd = New SqlCommand(que, Poscon)
        da = New SqlDataAdapter(cmd)
        Dim table As New DataTable
        da.Fill(table)
        If table.Rows.Count() = 0 Then
            MsgBox("No Active Session")
            frmSessionOpening.Show()
            'Me.Hide()

        Else
            frmSales.Show()
            'Me.Hide()
        End If


    End Sub

    Private Sub txtRecieptNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRecieptNo.KeyPress
        SearchRecieptNo(txtRecieptNo.Text)
    End Sub

    Private Sub BunifuThinButton25_Click(sender As Object, e As EventArgs)
        For Each row As DataGridViewRow In gvSalesReciepts.Rows
            For i = 6 To 7
                If row.Cells(i).Value Is Nothing Then
                    row.Cells(6).Value = row.Cells(2).Value
                    row.Cells(7).Value = row.Cells(4).Value
                End If
            Next
            For k = 8 To 9
                If row.Cells(k).Value Is Nothing Then
                    row.Cells(k).Value = 0
                End If
            Next
        Next
    End Sub

    Private Sub BunifuThinButton25_Click_1(sender As Object, e As EventArgs) Handles BunifuThinButton25.Click
        Try
            Dim outto As Date
            Dim outfrom As Date
            DateTime.TryParseExact(dpDate.Value, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, outfrom)
            DateTime.TryParseExact(dpdateto.Value, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, outto)
            If Poscon.State = ConnectionState.Closed Then
                Poscon.Open()
            End If
            Dim query = "select SalesPerson,RecieptId from RecieptConfig where date between @date1 and @date2"
            cmd = New SqlCommand(query, Poscon)
            cmd.Parameters.Add("date1", SqlDbType.DateTime).Value = outfrom
            cmd.Parameters.Add("date2", SqlDbType.DateTime).Value = outto
            da = New SqlDataAdapter(cmd)
            Dim tbl As New DataTable()
            da.Fill(tbl)
            gvReciepts.DataSource = tbl
            Poscon.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
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
            ActiveUser.Text = table.Rows(index)(1).ToString
        End If

        Poscon.Close()
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
            MsgBox(ex.ToString)
        End Try
    End Sub

    Sub PrintRecieptA4(valuetosearch As String)
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
            MsgBox(ex.ToString)
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
            MsgBox(ex.ToString)
        End Try
    End Sub


End Class