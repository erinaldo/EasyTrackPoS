Imports System.Data.SqlClient
Public Class frmPackSingles
    Private Sub frmPackSingles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        display()
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
            activeuser.Text = table.Rows(index)(1).ToString
        End If

        Poscon.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        frmMain.Show()
    End Sub
    Public Sub display()
        ComboFeed("select prodname from stockmast where packsize >1 or baseqty>1", ComboBox1, 0)
        ComboFeed("select prodname from stockmast where packsize =1 and baseqty=1", ComboBox2, 0)
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Try
            cmd = New SqlCommand("Select prodcode,packsize,baseqty,prodqty from stockmast where prodname='" + ComboBox1.Text + "'", Poscon)
            da = New SqlDataAdapter(cmd)
            tbl = New DataTable()
            da.Fill(tbl)
            Label8.Text = tbl.Rows(0)(0).ToString()
            TextBox5.Text = tbl.Rows(0)(1).ToString()
            TextBox4.Text = tbl.Rows(0)(2).ToString()
            lbloldpckqty.Text = tbl.Rows(0)(3).ToString()
            TextBox2.Text = Val(tbl.Rows(0)(1).ToString()) * Val(tbl.Rows(0)(2).ToString())
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        TextBox3.Text = Val(TextBox1.Text) * Val(TextBox2.Text)
        lblnewpckqty.Text = Val(lbloldpckqty.Text) - Val(TextBox1.Text)
        lblnewsigqty.Text = Val(lbloldsigqty.Text) + Val(TextBox3.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Then
            MsgBox("Please enter amount transferring")
            Exit Sub
        End If
        Try
            If Poscon.State = ConnectionState.Closed Then
                Poscon.Open()
            End If
            cmd = New SqlCommand("Select * from StockMast where prodname='" + ComboBox1.Text + "'", Poscon)
            dr = cmd.ExecuteReader
            While dr.Read
                cmd = New SqlCommand("update StockMast set prodqty = '" & dr.Item("ProdQty") - Val(TextBox1.Text) & "' where prodname= @itemname", Poscon)
                With cmd
                    .Parameters.AddWithValue("@Itemname", SqlDbType.NVarChar).Value = ComboBox1.Text
                    .ExecuteNonQuery()
                    result = cmd.ExecuteNonQuery()
                End With
            End While

            If Poscon.State = ConnectionState.Closed Then
                Poscon.Open()
            End If

            cmd = New SqlCommand("Select * from StockMast where prodname='" + ComboBox2.Text + "'", Poscon)
            dr = cmd.ExecuteReader
            While dr.Read
                cmd = New SqlCommand("update StockMast set prodqty = '" & dr.Item("ProdQty") + Val(TextBox3.Text) & "' where prodname= @itemname", Poscon)
                With cmd
                    .Parameters.AddWithValue("@Itemname", SqlDbType.NVarChar).Value = ComboBox2.Text
                    .ExecuteNonQuery()
                    result = cmd.ExecuteNonQuery()
                End With
            End While
            If result = 1 Then
                MsgBox("Success")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        inventorypck()
        inventorysig()
    End Sub
    Sub clear()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        Label1.Text = ""
        Label2.Text = ""
        Label3.Text = ""
        Label4.Text = ""
        Label5.Text = ""
        Label6.Text = ""
        Label7.Text = ""
        lblnewpckqty.Text = ""
        lblnewsigqty.Text = ""
        lbloldpckqty.Text = ""
        lbloldsigqty.Text = ""
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Try
            cmd = New SqlCommand("Select prodcode,prodqty from stockmast where Prodname='" + ComboBox2.Text + "'", Poscon)
            da = New SqlDataAdapter(cmd)
            tbl = New DataTable()
            da.Fill(tbl)
            Label9.Text = tbl.Rows(0)(0).ToString()
            lbloldsigqty.Text = tbl.Rows(0)(1).ToString()

            TextBox3.Text = Val(TextBox1.Text) * Val(TextBox2.Text)
            lblnewpckqty.Text = Val(lbloldpckqty.Text) - Val(TextBox1.Text)
            lblnewsigqty.Text = Val(lbloldsigqty.Text) + Val(TextBox3.Text)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Sub inventorypck()
        Try
            If Poscon.State = ConnectionState.Closed Then
                Poscon.Open()
            End If
            Dim sql = "insert into InventoryLedger (ItemCode,itemname,tranxtype,TranxSource,TranxGroup,oldqty,qtyIssued,StockBalance,Userid,time,date) values(@ItemCode,@Itemname,@Tranxtype,@tranxsource,@TranxGroup,@oldqty,@qtyIssued,@balance,@userid,@time,@date)"
            cmd = New SqlCommand(sql, Poscon)
            With cmd
                .Parameters.AddWithValue("@ItemCode", Label8.Text)
                .Parameters.AddWithValue("@Itemname", ComboBox1.Text)
                .Parameters.AddWithValue("@tranxtype", "Transfer")
                .Parameters.AddWithValue("@tranxsource", "Pack to Singles")
                .Parameters.AddWithValue("@tranxgroup", "Pack to singles")
                .Parameters.AddWithValue("@oldqty", lbloldpckqty.Text)
                .Parameters.AddWithValue("@qtyIssued", TextBox1.Text)
                .Parameters.AddWithValue("@Balance", lblnewpckqty.Text)
                .Parameters.AddWithValue("@userid", activeuser.Text)
                .Parameters.AddWithValue("@Date", Date.Now)
                .Parameters.AddWithValue("@Time", lbltime.Text)
                .ExecuteNonQuery()
            End With
            Poscon.Close()
        Catch ex As Exception

        End Try

    End Sub
    Sub inventorysig()
        Try
            If Poscon.State = ConnectionState.Closed Then
                Poscon.Open()
            End If
            Dim sql = "insert into InventoryLedger (ItemCode,itemname,tranxtype,TranxSource,TranxGroup,oldqty,qtyrecieved,StockBalance,Userid,time,date) values(@ItemCode,@Itemname,@Tranxtype,@tranxsource,@TranxGroup,@oldqty,@qtyIssued,@balance,@userid,@time,@date)"
            cmd = New SqlCommand(sql, Poscon)
            With cmd
                .Parameters.AddWithValue("@ItemCode", Label1.Text)
                .Parameters.AddWithValue("@Itemname", ComboBox2.Text)
                .Parameters.AddWithValue("@tranxtype", "Transfer Recvd")
                .Parameters.AddWithValue("@tranxsource", "Pack to Singles")
                .Parameters.AddWithValue("@tranxgroup", "Pack to singles")
                .Parameters.AddWithValue("@oldqty", lbloldsigqty.Text)
                .Parameters.AddWithValue("@qtyIssued", TextBox3.Text)
                .Parameters.AddWithValue("@Balance", lblnewsigqty.Text)
                .Parameters.AddWithValue("@userid", activeuser.Text)
                .Parameters.AddWithValue("@Date", Date.Now)
                .Parameters.AddWithValue("@Time", lbltime.Text)
                .ExecuteNonQuery()
            End With
            Poscon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTime.Text = Date.Now.ToString("hh:mm:ss")
    End Sub

    Private Sub ComboBox1_KeyUp(sender As Object, e As KeyEventArgs) Handles ComboBox1.KeyUp

    End Sub
End Class