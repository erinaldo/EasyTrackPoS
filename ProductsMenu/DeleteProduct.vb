Imports System.Data.SqlClient
Public Class frmDeleteProduct
    ' Dim As New SqlConnection(My.Settings.PoSConnectionString)
    Dim dr As SqlDataReader
    Dim cmd As SqlCommand
    Dim builder As SqlCommandBuilder
    Dim da As SqlDataAdapter
    Private Sub frmDeleteProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsStockMast.StockMast' table. You can move, or remove it, as needed.
        'Me.StockMastTableAdapter.Fill(Me.DsStockMast.StockMast)
        Me.MaximumSize = Screen.FromRectangle(Me.Bounds).WorkingArea.Size
        WindowState = FormWindowState.Maximized
        Display()

    End Sub
    Private Sub Feel(valueTosearch As String)
        If Poscon.State = ConnectionState.Closed Then
            Poscon.Open()
        End If
        Dim query = "select * from StockMast where concat(ProdName,ProdCode) like '%" + valueTosearch + "%'"
        Dim cmd = New SqlCommand(query, Poscon)
        Dim adapter As New SqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)
            gvStock.DataSource = table


            If table.Rows.Count() > 0 Then

            Else
                MsgBox("No Record")
            End If

        Poscon.Close()


    End Sub
    Private Sub Display()

        If Poscon.State = ConnectionState.Closed Then
            Poscon.Open()
        End If

        Dim query = "select * from StockMast where prodqty=0"
        cmd = New SqlCommand(query, Poscon)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable()
        adapter.Fill(tbl)
        gvStockguna.DataSource = tbl
        Poscon.Close()

    End Sub
    Private Sub filtercat()
        If Poscon.State = ConnectionState.Closed Then
            Poscon.Open()
        End If
        'Dim query = "select * from stockmast where prodcat ='" + cbCat.SelectedItem + "'"
        'cmd = New SqlCommand(query, poscon)
        da = New SqlDataAdapter(cmd)
        Dim tbl As New DataTable()
        da.Fill(tbl)
        gvStock.DataSource = ds.Tables(0)
        Poscon.Close()

    End Sub

    Private Sub gvStock_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gvStock.CellContentClick
        Try
            Dim row As DataGridViewRow = gvStock.Rows(e.RowIndex)
            txtDelSearch.Text = row.Cells(1).Value.ToString()
            txtItemNo.Text = row.Cells(0).Value.ToString()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        If lblItemName.Text = "" Or txtItemNo.Text = "" Then
            MsgBox("Select a Product")
        Else
            Try
                If Poscon.State = ConnectionState.Closed Then
                    Poscon.Open()
                End If
                Dim query = "delete from Stockmast where Prodcode= " + txtItemNo.Text + " "
                Dim cmd As New SqlCommand(query, Poscon)
                cmd.ExecuteNonQuery()
                    MsgBox("Product Deleted Successfully")
                Poscon.Close()
                Display()


            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs)
        Dim f2 As New frmProdCreate
        f2.Show()
        Me.Hide()

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs)
        Dim f2 As New frmChangePrice
        f2.Show()
        Me.Hide()

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)
        Dim f2 As New frmModifyProduct
        f2.Show()
        Me.Hide()

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)
        Dim f2 As New frmDeleteProduct
        f2.Show()
        Me.Hide()

    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs)
        Dim f2 As New frmMain
        f2.Show()
        Me.Hide()

    End Sub

    Private Sub cbCat_SelectedIndexChanged(sender As Object, e As EventArgs)
        filtercat()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim f2 As New frmProductManagementMenu
        f2.Show()
        Me.Hide()

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub gvStock_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles gvStock.CellClick
        Try
            Dim row As DataGridViewRow = gvStock.Rows(e.RowIndex)
            txtDelSearch.Text = row.Cells(1).Value.ToString()
            txtItemNo.Text = row.Cells(0).Value.ToString()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs)
        Feel(txtDelSearch.Text)
    End Sub

    Private Sub txtSearch_KeyUp(sender As Object, e As KeyEventArgs)
        Feel(txtDelSearch.Text)
    End Sub

    Private Sub Guna2DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles gvStockguna.CellClick
        Try
            Dim row As DataGridViewRow = gvStockguna.Rows(e.RowIndex)
            'txtDelSearch.Text = row.Cells(0).Value.ToString()
            txtItemNo.Text = row.Cells(0).Value.ToString()
            lblItemName.Text = row.Cells(1).Value.ToString()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub Guna2PictureBox4_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox4.Click
        Application.Exit()
    End Sub

    Private Sub Guna2PictureBox3_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox3.Click
        If WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Maximized
        ElseIf WindowState = FormWindowState.Maximized Then
            WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub txtDelSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDelSearch.KeyPress
        Search(txtDelSearch.Text)
    End Sub

    Public Sub Search(valueTosearch As String)
        Try
            If Poscon.State = ConnectionState.Closed Then
                Poscon.Open()
                Dim query = "select * from StockMast where concat(ProdName,ProdCode) like '%" + valueTosearch + "%'"
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
            Else
                Dim query = "select * from StockMast where concat(ProdName,ProdCode) like '%" + valueTosearch + "%'"
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

            End If

        Catch ex As Exception

        End Try

    End Sub
    Private Sub Clear()
        txtDelSearch.Text = ""
        txtItemNo.Text = ""
        lblItemName.Text = ""
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        If lblItemName.Text = "" Or txtItemNo.Text = "" Then
            MsgBox("Select a Product")
        Else
            Try
                If Poscon.State = ConnectionState.Closed Then
                    Poscon.Open()
                End If
                Dim query = "delete from Stockmast where Prodcode= " + txtItemNo.Text + " "
                Dim cmd As New SqlCommand(query, Poscon)
                cmd.ExecuteNonQuery()
                MsgBox("Product Deleted Successfully")
                Poscon.Close()
                Display()



            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
End Class