Imports System.Data.SqlClient

Public Class frmProdCatCreation
    Dim con As New SqlConnection(My.Settings.PoSConnectionString)
    Dim dr As SqlDataReader
    Dim cmd As SqlCommand
    Dim adapter As SqlDataAdapter
    Dim builder As SqlCommandBuilder
    Private Sub Product_Category_Creation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MaximumSize = Screen.FromRectangle(Me.Bounds).WorkingArea.Size
        Display()
    End Sub
    Private Sub Display()
        con.Close()
        con.Open()
        Dim query = "select * from Category"
        cmd = New SqlCommand(query, con)
        adapter = New SqlDataAdapter(cmd)
        builder = New SqlCommandBuilder(adapter)
        ds = New DataSet
        adapter.Fill(ds)
        gvStock.DataSource = ds.Tables(0)
        con.Close()
    End Sub
    Private Sub clear()
        txtCat.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Dim sql = "select * from category where category= '" + txtCat.Text + "' "
        cmd = New SqlCommand(sql, con)
        dr = cmd.ExecuteReader
        If txtCat.Text = "" Then
            MsgBox("Enter New Category")
            con.Close()
        ElseIf (dr.Read = True) Then
            MsgBox("Category Already Exists, Enter a new Category")
            con.Close()
            clear()
        Else
            Try
                If con.State = ConnectionState.Closed Then
                    con.Open()
                End If
                Dim query = "Insert into category values('" + txtCat.Text + "')"
                cmd = New SqlCommand(query, con)
                cmd.ExecuteNonQuery()
                'MsgBox("Succesfully Created")
                con.Close()
                Display()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If
        clear()
        dr.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        clear()
    End Sub
    Dim key = ""
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If key = "" Then
            MsgBox("Select a Category")
        Else
            Try
                If con.State = ConnectionState.Closed Then
                    con.Open()
                End If
                Dim query = "delete from Category where Id= " + key + " "
                cmd = New SqlCommand(query, con)
                cmd.ExecuteNonQuery()
                MsgBox("Product Deleted Successfully")
                con.Close()
                clear()
                Display()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

    End Sub

    Private Sub gvStock_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gvStock.CellContentClick
        Try
            Dim row As DataGridViewRow = gvStock.Rows(e.RowIndex)
            txtCat.Text = row.Cells(1).Value.ToString()
            If txtCat.Text = "" Then
                key = ""
            Else
                key = row.Cells(0).Value.ToString
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub txtCat_TextChanged(sender As Object, e As EventArgs) Handles txtCat.TextChanged

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        Dim f2 As New frmProdSetup
        f2.Show()
        Me.Hide()

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim f2 As New frmProdSetup
        f2.Show()
        Me.Hide()

    End Sub

    Private Sub gvStock_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles gvStock.CellClick
        Try
            Dim row As DataGridViewRow = gvStock.Rows(e.RowIndex)
            txtCat.Text = row.Cells(1).Value.ToString()
            If txtCat.Text = "" Then
                key = ""
            Else
                key = row.Cells(0).Value.ToString
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub txtCat_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCat.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button3_Click(Nothing, Nothing)
        End If
    End Sub
End Class