Imports System.Data.SqlClient
Public Class frmStockTaking
    Private Sub cbSuppName_Click(sender As Object, e As EventArgs) Handles cbSuppName.Click
        ComboFeed("select distinct prodline from stockmast", cbSuppName, 0)
    End Sub

    Private Sub cbSuppName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSuppName.SelectedIndexChanged
        If Poscon.State = ConnectionState.Closed Then
            Poscon.Open()
        End If
        Dim queryy = ("Select prodcode,itemname,retailprice,prodqty,baseqty*packsize from stockmast where Prodline = '" + cbSuppName.Text + "'")
        cmd = New SqlCommand(queryy, Poscon)
        da = New SqlDataAdapter(cmd)
        tbl = New DataTable()
        da.Fill(tbl)
        If tbl.Rows.Count = 0 Then
            MsgBox("Productline Empty")
            Exit Sub
        End If

        'lblProdName.Text = tbl.Rows(0)(9).ToString

        ' lblPayable.Text = tbl.Rows(0)(15).ToString
        gvStockBf.Rows.Clear()

        For k = 0 To tbl.Rows.Count - 1
            gvStockBf.Rows.Add(tbl.Rows(k)(0).ToString, tbl.Rows(k)(1).ToString, tbl.Rows(k)(2).ToString, tbl.Rows(k)(3).ToString, tbl.Rows(k)(4).ToString)
        Next
        Poscon.Close()
    End Sub

    Private Sub BunifuButton22_Click(sender As Object, e As EventArgs) Handles BunifuButton22.Click
        For Each row As DataGridViewRow In gvStockBf.Rows

            insertd("update stockmast set prodqty='" & row.Cells(3).Value & "' where prodcode='" & row.Cells(0).Value & "'")


            insertd("insert into InventoryLedger (ItemCode,itemname,retailprice,tranxtype,TranxSource,TranxGroup,QtyRecieved,StockBalance,Userid,date) values('" & row.Cells(0).Value & "','" & row.Cells(1).Value & "','" & row.Cells(2).Value & "','" + " Stocktaking " + "','" + " Stocktaking " + "','" + " Stocktaking " + "','" & row.Cells(3).Value & "','" & row.Cells(3).Value & "','" & My.Settings.ActiveUser & "',convert(datetime,'" + Date.Now + "',105))")
        Next
        MsgBox("Complete")
    End Sub
End Class