Imports System.Data.SqlClient
Public Class frmTobeCollectedDelivery
    'Dim As New SqlConnection(My.Settings.PoSConnectionString)
    Dim dr As SqlDataReader
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter
    Dim dt As New dsTobeCollected
    Dim tbl As New DataTable()

    Private Sub LoadReciepts(RecieptNo As String)
        gvSalesReciepts.Rows.Clear()
        If Poscon.State = ConnectionState.Closed Then
            Poscon.Open()
        End If
        lblRecieptNo.Text = txtRecieptNo.Text
        Dim query = "Select * from TobeCollected where RecieptNo='" + RecieptNo + "'"
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
            'If dr.Item("DateSold").ToString = "" Then
            ' Else
            ' lblDateSold.Text = dr.Item("DateSold")
            ' End If
            If dr.Item("BuyerLoc").ToString = "" Then
            Else
                txtCustLoc.Text = dr.Item("BuyerLoc")
            End If
            ' If dr.Item("TimeSold").ToString = "" Then
            ' Else
            ' lblTimeSold.Text = dr.Item("TimeSold").ToString
            '  End If


            gvSalesReciepts.Rows.Add(dr.Item("ItemCode").ToString, dr.Item("ItemName").ToString, dr.Item("QtyTobeCollected").ToString, dr.Item("Price").ToString, dr.Item("RecieptNo"))


        End While

        dr.Close()
        Poscon.Close()

    End Sub
    Sub display()
        reload("select distinct recieptno,buyername,buyerloc,buyertel from tobecollected", gvdel)
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        LoadReciepts(txtRecieptNo.Text)
        ShowConfig()
    End Sub

    Private Sub gvSalesReciepts_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles gvSalesReciepts.CellClick
        Try
            Dim row As DataGridViewRow = gvSalesReciepts.Rows(e.RowIndex)
            lblItemName.Text = row.Cells(1).Value.ToString()
            txtQtySold.Text = row.Cells(2).Value.ToString()
            lblProdCode.Text = row.Cells(0).Value.ToString()
            lblRecieptNo.Text = row.Cells(4).Value.ToString()
            txtQtyCollected.Text = ""
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
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
            If lblProdCode.Text = row.Cells(0).Value And lblRecieptNo.Text = row.Cells(4).Value Then
                row.Cells(5).Value = txtToBecollected.Text
                row.Cells(6).Value = txtQtyCollected.Text
            End If

        Next
        Clear()
    End Sub

    Private Sub txtToBecollected_TextChanged(sender As Object, e As EventArgs) Handles txtToBecollected.TextChanged
        If Val(txtQtySold.Text) < Val(txtToBecollected.Text) Then
            MsgBox("Qty collected cannot be more that qty to be collected")
            txtToBecollected.Text = ""
            Exit Sub
        End If
        Dim a As New Decimal
        Dim b As New Decimal
        Dim c As New Decimal
        a = Val(txtQtySold.Text)
        b = Val(txtToBecollected.Text)
        c = a - b
        txtQtyCollected.Text = c
    End Sub

    Private Sub BunifuThinButton23_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BunifuThinButton23_Click_1(sender As Object, e As EventArgs) Handles BunifuThinButton23.Click
        If gvSalesReciepts.Rows.Count = 0 Then
            MsgBox("Select Reciept to be Delivered")
            Exit Sub
        End If
        For Each row As DataGridViewRow In gvSalesReciepts.Rows

            If Poscon.State = ConnectionState.Closed Then
                Poscon.Open()
            End If
            For i = 5 To 6
                If row.Cells(i).Value Is Nothing Then
                    row.Cells(5).Value = row.Cells(2).Value
                    row.Cells(6).Value = 0
                End If
            Next
            'For k = 8 To 9
            ' If row.Cells(k).Value Is Nothing Then
            'row.Cells(k).Value = 0
            'End If
            'Next

            Dim sqll = "update TobeCollected set QtyTobeCollected = @newstock where ItemCode ='" & row.Cells(0).Value.ToString & "' and RecieptNo='" & lblRecieptNo.Text & "'"
            cmd = New SqlCommand(sqll, Poscon)
            With cmd
                .Parameters.AddWithValue("@newstock", row.Cells(6).Value)
                .ExecuteNonQuery()
            End With
            If Poscon.State = ConnectionState.Closed Then
                Poscon.Open()
            End If
            Dim query = "insert into ToBeCollecteddeliverylog (ItemCode,ItemName,oldQtytobeCollected,DateCollected,BuyerName,BuyerTel,BuyerLoc,QtyTobeCollected,Price,salesperson,RecieptNo,DateToBeCollected,QtyCollected,timecollected,DeliveryID) values(@ItemCode,@ItemName,@oldQtytobecollected,@DateSold,@BuyerName,@BuyerTel,@BuyerLocation,@QtyTobeCollected,@Price,'" + My.Settings.ActiveUser + "', '" & lblRecieptNo.Text & "','" + dpDate.Text + "',@QtyCollected,'" + lblTimeSold.Text + "','" & lblDeliveryReciept.Text & "')"
            cmd = New SqlCommand(query, Poscon)
            With cmd

                .Parameters.AddWithValue("@ItemCode", row.Cells(0).Value.ToString)
                .Parameters.AddWithValue("@Itemname", row.Cells(1).Value)
                .Parameters.AddWithValue("@oldQtyToBeCollected", row.Cells(2).Value)
                .Parameters.AddWithValue("@DateSold", CDate(lblDate.Text))
                .Parameters.AddWithValue("@BuyerName", txtBuyerName.Text)
                .Parameters.AddWithValue("@BuyerTel", txtBuyerTel.Text)
                .Parameters.AddWithValue("@BuyerLocation", txtCustLoc.Text)
                .Parameters.AddWithValue("@NewStock", row.Cells(5).Value)
                .Parameters.AddWithValue("@Price", row.Cells(3).Value)
                .Parameters.AddWithValue("@QtyCollected", row.Cells(5).Value)
                .Parameters.AddWithValue("@QtyTobeCollected", row.Cells(6).Value)
                .ExecuteNonQuery()

            End With
        Next

        If ckrollPaper.Checked = True Then
            TobeColDelReciept()
        Else
            TobeColDelRecieptA4()

        End If
        MsgBox("Successfully Delivered")
        gvSalesReciepts.Rows.Clear()
        Poscon.Close()
        Clear()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTime.Text = Date.Now.ToString("hh:mm:ss")
        lblDate.Text = Date.Now.ToString("dd-MMM-yy")
        lblTimeSold.Text = Date.Now.ToString("hh:mm:ss")
    End Sub

    Private Sub frmTobeCollectedDelivery_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Me.MaximumSize = Screen.FromRectangle(Me.Bounds).WorkingArea.Size
        WindowState = FormWindowState.Maximized
        display()
    End Sub
    Private Sub TobeColDelReciept()

        Try
            Dim query = "select * from TobeCollecteddeliverylog where DeliveryId='" + lblDeliveryReciept.Text + "' and RecieptNo='" + lblRecieptNo.Text + "' and qtytobecollected<>0 "
            cmd = New SqlCommand(query, Poscon)
            dt.Tables("TobeCollecteddeliverylog").Rows.Clear()
            da = New SqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(dt, "TobeCollecteddeliverylog")

            Dim sql = "select * from ClientReg"
            dt.Tables("ClientReg").Rows.Clear()
            cmd = New SqlCommand(sql, Poscon)
            da = New SqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(dt, "ClientReg")

            Dim report As New rptToBeCollectedDelivery
            report.SetDataSource(dt)
            If ckprint.Checked = True Then
                report.PrintToPrinter(1, True, 0, 0)
            End If
            frmTobeCollectedPreview.Show()
            frmTobeCollectedPreview.CrystalReportViewer1.ReportSource = report
            frmTobeCollectedPreview.CrystalReportViewer1.Refresh()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub TobeColDelRecieptA4()

        Try
            Dim query = "select * from TobeCollecteddeliverylog where DeliveryId='" + lblDeliveryReciept.Text + "' and RecieptNo='" + lblRecieptNo.Text + "' and qtytobecollected<>0 "
            cmd = New SqlCommand(query, Poscon)
            dt.Tables("TobeCollecteddeliverylog").Rows.Clear()
            da = New SqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(dt, "TobeCollecteddeliverylog")

            Dim sql = "select * from ClientReg"
            dt.Tables("ClientReg").Rows.Clear()
            cmd = New SqlCommand(sql, Poscon)
            da = New SqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(dt, "ClientReg")

            Dim report As New rptToBeCollectedDeliveryA4
            report.SetDataSource(dt)
            If ckprint.Checked = True Then
                report.PrintToPrinter(1, True, 0, 0)
            End If
            frmTobeCollectedPreview.Show()
            frmTobeCollectedPreview.CrystalReportViewer1.ReportSource = report
            frmTobeCollectedPreview.CrystalReportViewer1.Refresh()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub ShowConfig()
        If Poscon.State = ConnectionState.Closed Then
            Poscon.Open()
        End If
        ' Dim recieptcount As String
        'Dim nextreciept As String
        Dim que = "select Deliveryid from tobecollecteddeliverylog"
        cmd = New SqlCommand(que, Poscon)
        Dim da As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        da.Fill(table)
        If table.Rows.Count() = 0 Then
            lblDeliveryReciept.Text = "20001"
        Else

            Dim index = table.Rows.Count() - 1
            Dim reciept = table.Rows(index)(0).ToString
            lblDeliveryReciept.Text = Val(reciept) + 1
        End If
        Poscon.Close()
    End Sub
    Private Sub Clear()
        lblItemName.Text = ""
        txtBuyerName.Text = ""
        txtBuyerTel.Text = ""
        txtCustLoc.Text = ""
        txtQtySold.Text = ""
        txtRecieptNo.Text = ""
        txtToBecollected.Text = ""
        lblDate.Text = ""
        lblDeliveryReciept.Text = ""

    End Sub

    Private Sub gvdel_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles gvdel.CellClick

    End Sub
End Class