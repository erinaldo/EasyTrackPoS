Imports System.Data.SqlClient
Public Class frmToCollected
    'Dim As New SqlConnection(My.Settings.PoSConnectionString)
    Dim dr As SqlDataReader
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter
    Dim dt As New dsTobeCollected
    Dim tbl As New DataTable()
    Private Sub frmToCollected_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Me.MaximumSize = Screen.FromRectangle(Me.Bounds).WorkingArea.Size
        WindowState = FormWindowState.Maximized
        Display()
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
                txtBuyerName.Text = dr.Item("BuyerName")
            End If
            If dr.Item("BuyerTel").ToString = "" Then
            Else
                txtBuyerTel.Text = dr.Item("BuyerTel")
            End If
            If dr.Item("DateSold").ToString = "" Then
            Else
                lblDateSold.Text = dr.Item("DateSold")
            End If
            If dr.Item("BuyerLocation").ToString = "" Then
            Else
                txtCustLoc.Text = dr.Item("BuyerLocation")
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

    Private Sub Display()

        'If Poscon.State = ConnectionState.Closed Then
        '    Poscon.Open()
        'End If

        'Dim query = "select SalesPerson,RecieptId from SalesTranx"
        'cmd = New SqlCommand(query, Poscon)
        'Dim adapter As New SqlDataAdapter(cmd)
        'Dim tbl As New DataTable()
        'adapter.Fill(tbl)
        ''gvReciepts.DataSource = tbl
        'Poscon.Close()


        reload("select distinct recieptno,buyername,buyerlocation,buyertel from salestranx", gvdel)
    End Sub


    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        If Poscon.State = ConnectionState.Closed Then
            Poscon.Open()
        End If
        Dim query = "select * from TobeCollected where RecieptNo='" + txtRecieptNo.Text + "'"
        cmd = New SqlCommand(query, Poscon)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable()
        adapter.Fill(table)
        If table.Rows.Count() = 0 Then
        Else
            MsgBox("Sale Already Saved in To Be Collected")
            Exit Sub
        End If

        If txtRecieptNo.Text = "" Then
            MsgBox("Enter Receiept Number", vbCritical)
            Exit Sub
        End If
        LoadReciepts(txtRecieptNo.Text)
    End Sub


    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click
        If lblRecieptNo.Text = "" Then
            MsgBox("Select Reciept to be Collected")
            Exit Sub
        End If
        If gvSalesReciepts.Rows.Count = 0 Then
            MsgBox("Select Reciept to be collected")
            Exit Sub
        End If
        If txtToBecollected.Text = "" Or txtQtySold.Text = "" Then
            MsgBox("Select Item and Enter Quantity to be Collected")
            Exit Sub
        End If
        For Each row As DataGridViewRow In gvSalesReciepts.Rows
            If lblProdCode.Text = row.Cells(0).Value And lblRecieptNo.Text = row.Cells(5).Value Then
                row.Cells(6).Value = txtToBecollected.Text
                row.Cells(7).Value = txtQtyCollected.Text
            End If

        Next
        txtQtyCollected.Text = ""
        txtQtySold.Text = ""
        txtToBecollected.Text = ""
    End Sub

    Private Sub gvSalesReciepts_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles gvSalesReciepts.CellClick
        Try
            Dim row As DataGridViewRow = gvSalesReciepts.Rows(e.RowIndex)
            lblItemName.Text = row.Cells(1).Value.ToString()
            txtQtySold.Text = row.Cells(2).Value.ToString()
            lblProdCode.Text = row.Cells(0).Value.ToString()
            lblRecieptNo.Text = row.Cells(5).Value.ToString()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub txtToBecollected_TextChanged(sender As Object, e As EventArgs) Handles txtToBecollected.TextChanged
        Dim a As New Decimal
        Dim b As New Decimal
        Dim c As New Decimal
        a = Val(txtQtySold.Text)
        b = Val(txtToBecollected.Text)
        c = a - b
        txtQtyCollected.Text = c
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTime.Text = Date.Now.ToString("hh:mm:ss")
        lblDate.Text = Date.Now.ToString("dd-MMM-yy")
    End Sub

    Private Sub BunifuThinButton23_Click(sender As Object, e As EventArgs) Handles BunifuThinButton23.Click
        If gvSalesReciepts.Rows.Count = 0 Then
            MsgBox("Select Reciept to be Collected")
            Exit Sub
        End If
        ' If lblUpdateTBC.Text = "AjustTobeCollected" Then
        ' Else
        'EditCollected()
        'gvSalesReciepts.Rows.Clear()
        ' MsgBox("Successfully Updated")
        ' Exit Sub
        ' End If
        For Each row As DataGridViewRow In gvSalesReciepts.Rows
            For i = 6 To 7
                If row.Cells(i).Value Is Nothing Then
                    row.Cells(6).Value = row.Cells(2).Value
                    row.Cells(7).Value = 0
                End If
            Next
            'For k = 8 To 9
            ' If row.Cells(k).Value Is Nothing Then
            'row.Cells(k).Value = 0
            'End If
            'Next
            If Poscon.State = ConnectionState.Closed Then
                Poscon.Open()
            End If
            Dim query = "insert into ToBeCollected (ItemCode,ItemName,QtySold,DateSold,BuyerName,BuyerTel,BuyerLoc,QtyCollected,QtyTobeCollected,Price,salesperson,RecieptNo,DateToBeCollected) values(@ItemCode,@ItemName,@QtySold,@DateSold,@BuyerName,@BuyerTel,@BuyerLocation,@QtyCollected,@QtyTobeCollected,@Price,'" + ActiveUser.Text + "', '" + lblRecieptNo.Text + "','" + dpDate.Text + "')"
            Dim cmd As New SqlCommand
            cmd = New SqlCommand(query, Poscon)
            With cmd

                .Parameters.AddWithValue("@ItemCode", row.Cells(0).Value)
                .Parameters.AddWithValue("@Itemname", row.Cells(1).Value)
                .Parameters.AddWithValue("@QtySold", row.Cells(2).Value)
                .Parameters.AddWithValue("@DateSold", CDate(lblDateSold.Text))
                .Parameters.AddWithValue("@TimeSold", lblTimeSold.Text)
                .Parameters.AddWithValue("@BuyerName", txtBuyerName.Text)
                .Parameters.AddWithValue("@BuyerTel", txtBuyerTel.Text)
                .Parameters.AddWithValue("@BuyerLocation", txtCustLoc.Text)
                .Parameters.AddWithValue("@NewStock", row.Cells(5).Value)
                .Parameters.AddWithValue("@Price", row.Cells(3).Value)
                .Parameters.AddWithValue("@QtyCollected", row.Cells(7).Value)
                .Parameters.AddWithValue("@QtyTobeCollected", row.Cells(6).Value)
                .ExecuteNonQuery()

            End With
        Next

        MsgBox("Item Collected Successfully")
        TobeColReciept(lblRecieptNo.Text)
        gvSalesReciepts.Rows.Clear()
        Poscon.Close()
        clear()
    End Sub
    Sub clear()
        txtQtyCollected.Text = ""
        txtQtySold.Text = ""
        txtToBecollected.Text = ""
        txtBuyerName.Text = ""
        txtRecieptNo.Text = ""
        txtBuyerTel.Text = ""
        txtCustLoc.Text = ""
    End Sub

    Private Sub BunifuThinButton24_Click(sender As Object, e As EventArgs) Handles BunifuThinButton24.Click
        frmSales.Show()
    End Sub
    Private Sub TobeColReciept(RecieptNo As String)
        'dt.EnforceConstraints = False
        If Poscon.State = ConnectionState.Closed Then
            Poscon.Open()
        End If

        Dim query = "select * from TobeCollected where recieptno='" + RecieptNo + "'"
        dt.Tables("TobeCollected").Rows.Clear()
        cmd = New SqlCommand(query, Poscon)
        da = New SqlDataAdapter
        da.SelectCommand = cmd
        da.Fill(dt, "TobeCollected")

        Dim sql = "select * from ClientReg"
        dt.Tables("ClientReg").Rows.Clear()
        cmd = New SqlCommand(sql, Poscon)
        da = New SqlDataAdapter
        da.SelectCommand = cmd
        da.Fill(dt, "ClientReg")

        Dim report As New rptTobeCollected
        report.SetDataSource(dt)
        If ckprint.Checked = True Then
            report.PrintToPrinter(1, True, 0, 0)
        End If
        frmSalesReciept.Show()
        frmSalesReciept.CrystalReportViewer1.Refresh()
        frmSalesReciept.CrystalReportViewer1.ReportSource = report


        ' report.PrintToPrinter(1, True, 0, 0)
        cmd.Dispose()
        da.Dispose()
        Poscon.Close()
    End Sub
    Private Sub EditCollected()
        For Each row As DataGridViewRow In gvSalesReciepts.Rows
            For i = 6 To 7
                If row.Cells(i).Value Is Nothing Then
                    row.Cells(6).Value = row.Cells(2).Value
                    row.Cells(7).Value = 0
                End If
            Next
            If Poscon.State = ConnectionState.Closed Then
                Poscon.Open()
            End If
            Dim sql = "update TobeCollected set QtyTobeCollected = @newstock, QtyCollected=@QtyCollected where ItemCode =" + row.Cells(0).Value + " and RecieptNo=" + lblRecieptNo.Text + ""
            cmd = New SqlCommand(sql, Poscon)
            With cmd
                .Parameters.AddWithValue("@newstock", row.Cells(6).Value)
                .Parameters.AddWithValue("@QtyCollected", row.Cells(7).Value)
                .ExecuteNonQuery()
            End With
        Next
    End Sub

    Private Sub gvdel_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles gvdel.CellClick
        Try
            Dim row As DataGridViewRow = gvdel.Rows(e.RowIndex)

            If Poscon.State = ConnectionState.Closed Then
                Poscon.Open()
            End If
            cmd = New SqlCommand("select * from TobeCollected where RecieptNo=@rno", Poscon)
            cmd.Parameters.AddWithValue("@rno", SqlDbType.NVarChar).Value = row.Cells(0).Value.ToString
            da = New SqlDataAdapter(cmd)
            tbl = New DataTable()
            da.Fill(tbl)
            If tbl.Rows.Count() = 0 Then
                LoadReciepts(row.Cells(0).Value.ToString)
            Else
                MsgBox("Sale Already Saved in To Be Collected")
                Exit Sub
            End If


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub


End Class