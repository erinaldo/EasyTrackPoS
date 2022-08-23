Imports System.Data.SqlClient
Public Class frmChangePrice
    'Dim  New SqlConnection(My.Settings.PoSConnectionString)
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader
    Dim da As SqlDataAdapter
    Private Sub frmChangePrice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MaximumSize = Screen.FromRectangle(Me.Bounds).WorkingArea.Size
        WindowState = FormWindowState.Maximized
        If Poscon.State = ConnectionState.Closed Then
            Poscon.Open()
        End If
        cbItemName.Items.Clear()
        Dim sql = "select * from Stockmast"
        cmd = New SqlCommand(sql, Poscon)
        dr = cmd.ExecuteReader
        While dr.Read
            cbItemName.Items.Add(dr(1))
        End While
        Poscon.Close()
        Timer1.Enabled = True
        Display()
    End Sub
    Private Sub Display()
        If Poscon.State = ConnectionState.Closed Then
            Poscon.Open()
        End If
        Dim query = "select prodname,Retailprice,Prodqty,Wholesaleprice,prodcode,packprice,packsize,baseqty from StockMast"
        cmd = New SqlCommand(query, Poscon)
        da = New SqlDataAdapter(cmd)
        Dim tbl As New DataTable
        da.Fill(tbl)
        gvStockguna.DataSource = tbl
        Poscon.Close()
        ComboFeed("select prodname from StockMast where ProdName like '%" + cbChangepriceSrch.Text + "%'", cbChangepriceSrch, 0)
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs)
        Dim f2 As New frmMain
        f2.Show()
        Me.Hide()
    End Sub
    Dim key = ""

    Private Sub txtNewRPrice_TextChanged(sender As Object, e As EventArgs) Handles txtNewRPrice.TextChanged
        ' lblnewramt.Text = Val(txtNewRPrice.Text) * Val(lblqty.Text)
        txtnewpckprice.Text = Val(txtNewRPrice.Text) * Val(lblpackvol.Text)
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)
        Dim f2 As New frmModifyProduct
        f2.Show()
        Me.Hide()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)
        Dim f2 As New frmProdCreate
        f2.Show()
        Me.Hide()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim f2 As New frmProductManagementMenu
        f2.Show()
        Me.Hide()

    End Sub
    Private Sub Clear()
        txtProdname.Text = ""
        txtOldWPrice.Text = ""
        txtOldRPrice.Text = ""
        txtNewRPrice.Text = ""
        txtNewWPrice.Text = ""
        lblStockCode.Text = ""
        txtoldpckprice.Text = ""
        txtnewpckprice.Text = ""

    End Sub

    Private Sub Guna2PictureBox1_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    Public Sub Search(valueTosearch As String)
        Poscon.Open()
        Dim query = "select prodname,Retailprice,Prodqty,Wholesaleprice,prodcode,packprice,packsize,baseqty from StockMast where Itemname like '%" + valueTosearch + "%'"
        cmd = New SqlCommand(query, Poscon)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable()
        adapter.Fill(table)
        gvStockguna.DataSource = table


        If table.Rows.Count() > 0 Then
            ''txtProdName.Text = table.Rows(0)(1).ToString()
            ''ProdName.Text = table.Rows(0)(1).ToString()
            ''txtPrice.Text = table.Rows(0)(7).ToString()
            ''txtProdcode.Text = table.Rows(0)(0).ToString()
            ''lblActualStock.Text = table.Rows(0)(6).ToString()
            ''xtProdline.Text = table.Rows(0)(2).ToString()
            ''txtCat.Text = table.Rows(0)(5).ToString()
            ''tSize.Text = table.Rows(0)(3).ToString()
            ''txtColour.Text = table.Rows(0)(4).ToString()
        Else
            'MsgBox("No Record")
            ''txtProdName.Text = ""

        End If

        Poscon.Close()
    End Sub

    Private Sub cbProdLine_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbChangepriceSrch.KeyPress
        Search(cbChangepriceSrch.Text)
    End Sub

    Private Sub gvStockguna_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles gvStockguna.CellClick
        Try
            Dim row As DataGridViewRow = gvStockguna.Rows(e.RowIndex)
            lblStockCode.Text = row.Cells(4).Value.ToString()
            txtProdname.Text = row.Cells(0).Value.ToString()
            txtOldRPrice.Text = row.Cells(1).Value.ToString()
            txtNewRPrice.Text = row.Cells(1).Value.ToString()
            txtOldWPrice.Text = row.Cells(3).Value.ToString()
            txtNewWPrice.Text = row.Cells(3).Value.ToString()
            lblqty.Text = row.Cells(2).Value.ToString()
            txtoldpckprice.Text = row.Cells(5).Value.ToString()
            lblpackvol.Text = Val(row.Cells(6).Value.ToString()) * Val(row.Cells(7).Value.ToString())

            lblodlRamt.Text = Val(txtOldRPrice.Text) * Val(lblqty.Text)
            lbloldcamt.Text = Val(txtOldWPrice.Text) * Val(lblqty.Text)
            lblnewcamt.Text = Val(txtNewWPrice.Text) * Val(lblqty.Text)
            lblnewramt.Text = Val(txtNewRPrice.Text) * Val(lblqty.Text)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        If txtNewRPrice.Text = "" Then
            MsgBox("Enter New Prices")
            Exit Sub
        Else
            Try
                If Poscon.State = ConnectionState.Closed Then
                    Poscon.Open()
                End If
                'For Each row As DataGridViewRow In gvPriceBatch.Rows
                '    Dim query = ("update Stockmast set RetailPrice=@Rprice, WholesalePrice= @Wprice,Packprice= @pckprice where Prodcode= '" + row.Cells(10).Value + "'")
                '    cmd = New SqlCommand(query, Poscon)
                '    With cmd
                '        .Parameters.AddWithValue("@rprice", row.Cells(3).Value)
                '        .Parameters.AddWithValue("@wprice", row.Cells(5).Value)
                '        .Parameters.AddWithValue("@pckprice", row.Cells(11).Value)
                '        .ExecuteNonQuery()
                '    End With
                'Next
                For Each row As DataGridViewRow In gvPriceBatch.Rows

                    create("update Stockmast set RetailPrice='" & row.Cells(3).Value & "', WholesalePrice= '" & row.Cells(3).Value & "',Packprice= '" & row.Cells(3).Value & "' where Prodcode= '" & row.Cells(10).Value & "'")
                    Poscon.Open()
                    cmd = New SqlCommand("select prodcode from multishopstockmast where prodcode='" & row.Cells(10).Value & "'", Poscon)
                    da = New SqlDataAdapter(cmd)
                    tbl = New DataTable
                    da.Fill(tbl)
                    If tbl.Rows.Count <> 0 Then
                        create("update multishopStockmast set RetailPrice='" & row.Cells(3).Value & "', WholesalePrice= '" & row.Cells(3).Value & "',Packprice= '" & row.Cells(3).Value & "' where Prodcode= '" & row.Cells(10).Value & "'")
                    End If

                Next

                If Poscon.State = ConnectionState.Closed Then
                    Poscon.Open()
                End If
                For Each row As DataGridViewRow In gvPriceBatch.Rows
                    Dim sql = "insert into Pricechangelog(ItemCode,ItemName,Qty,oldrprice,newrprice,newramt,date,time,activeuser,oldpackprice,newpackprice) values(@itemcode,@itemname,@qty,@oldrprice,@newrprice,@newramt,'" + lblDate.Text + "','" + lbltime.Text + "','" + My.Settings.ActiveUser + "',@oldpackprice,@newpackprice)"
                    cmd = New SqlCommand(sql, Poscon)
                    With cmd
                        .Parameters.AddWithValue("@ItemCode", row.Cells(10).Value)
                        .Parameters.AddWithValue("@Itemname", row.Cells(0).Value)
                        .Parameters.AddWithValue("@qty", row.Cells(1).Value)
                        .Parameters.AddWithValue("@oldrprice", row.Cells(2).Value)
                        .Parameters.AddWithValue("@newrprice", row.Cells(3).Value)
                        .Parameters.AddWithValue("@newramt", row.Cells(7).Value)
                        .Parameters.AddWithValue("@newpackprice", row.Cells(11).Value)
                        .Parameters.AddWithValue("@oldpackprice", row.Cells(12).Value)
                        cmd.ExecuteNonQuery()
                    End With
                Next
                MsgBox("Product Updated Successfully")
                gvPriceBatch.Rows.Clear()
                Poscon.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
        Display()
        Clear()
    End Sub

    Private Sub Guna2PictureBox2_Click(sender As Object, e As EventArgs)
        If WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Maximized
        ElseIf WindowState = FormWindowState.Maximized Then
            WindowState = FormWindowState.Normal
        End If
    End Sub
    Private Sub ShowBand()
        If Poscon.State = ConnectionState.Closed Then
            Poscon.Open()
        End If

        Dim query = "select * from PriceBand"
        cmd = New SqlCommand(query, Poscon)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable()
        adapter.Fill(tbl)
        gvPriceBand.DataSource = tbl
        Poscon.Close()
    End Sub

    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click

        If Poscon.State = ConnectionState.Closed Then
            Poscon.Open()
        End If

        Dim sql = "select * from PriceBand where PriceBand= '" + txtBandName.Text + "' "
        cmd = New SqlCommand(sql, Poscon)
        dr = cmd.ExecuteReader
        If txtBandName.Text = "" Then
            MsgBox("Enter New PriceBand")
            Poscon.Close()
        ElseIf (dr.Read = True) Then
            MsgBox("PriceBand Already Exists, Enter a new Band")
            Poscon.Close()
            Clear()
        Else
            Try
                If Poscon.State = ConnectionState.Closed Then
                    Poscon.Open()
                End If
                Dim query = "Insert into PriceBand values('" + lblBandCode.Text + "','" + cbItemName.Text + "','" + txtBandName.Text + "','" + txtFromQty.Text + "','" + txtToQty.Text + "','" + txtBandPrice.Text + "')"
                cmd = New SqlCommand(query, Poscon)
                cmd.ExecuteNonQuery()
                MsgBox("Succesfully Created")
                Poscon.Close()
                Display()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If
        ShowBand()
        dr.Close()
    End Sub

    Private Sub txtFromQty_Validated(sender As Object, e As EventArgs) Handles txtFromQty.Validated
        txtBandName.Text = cbItemName.SelectedItem + txtFromQty.Text + txtToQty.Text
    End Sub

    Private Sub txtToQty_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtToQty.Validating
        txtBandName.Text = cbItemName.SelectedItem + txtFromQty.Text + txtToQty.Text
    End Sub

    Private Sub BunifuThinButton23_Click(sender As Object, e As EventArgs) Handles BunifuThinButton23.Click
        frmChangePrice_Load(e, e)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblDate.Text = Date.Now.ToString("dd-MMM-yy")
        lbltime.Text = Date.Now.ToString("hh:mm:ss")
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        lblodlRamt.Text = Val(txtOldRPrice.Text) * Val(lblqty.Text)
        lbloldcamt.Text = Val(lbloldcamt.Text) * Val(lblqty.Text)
        lblnewcamt.Text = Val(txtNewWPrice.Text) * Val(lblqty.Text)
        lblnewramt.Text = Val(txtNewRPrice.Text) * Val(lblqty.Text)
        gvPriceBatch.Rows.Add(txtProdname.Text, lblqty.Text, txtOldRPrice.Text, txtNewRPrice.Text, txtOldWPrice.Text, txtNewWPrice.Text, lblodlRamt.Text, lblnewramt.Text, lbloldcamt.Text, lblnewcamt.Text, lblStockCode.Text, txtnewpckprice.Text, txtoldpckprice.Text)
        Clear()
    End Sub

    Private Sub txtNewWPrice_TextChanged(sender As Object, e As EventArgs) Handles txtNewWPrice.TextChanged
        'lblnewcamt.Text = Val(txtNewWPrice.Text * lblqty.Text)
    End Sub

    Private Sub txtOldRPrice_TextChanged(sender As Object, e As EventArgs) Handles txtOldRPrice.TextChanged
        'lblodlRamt.Text = Val(lblodlRamt.Text * lblqty.Text)
    End Sub

    Private Sub txtOldWPrice_TextChanged(sender As Object, e As EventArgs) Handles txtOldWPrice.TextChanged
        ' lbloldcamt.Text = Val(lbloldcamt.Text * lblqty.Text)
    End Sub


    Private Sub txtNewRPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNewRPrice.KeyPress
        txtnewpckprice.Text = Val(txtNewRPrice.Text) * Val(lblpackvol.Text)
    End Sub

    Private Sub txtnewpckprice_TextChanged(sender As Object, e As EventArgs) Handles txtnewpckprice.TextChanged
        txtNewRPrice.Text = Val(txtnewpckprice.Text) / Val(lblpackvol.Text)
    End Sub

    Private Sub cbChangepriceSrch_TextChanged(sender As Object, e As EventArgs) Handles cbChangepriceSrch.TextChanged

    End Sub
End Class