Imports System.Data.SqlClient

Public Class frmProdCatCreation
    'Dim poscon As New SqlConnection(My.Settings.PoSConnectionString)
    Dim dr As SqlDataReader
    Dim cmd As SqlCommand
    Dim adapter As SqlDataAdapter
    Dim builder As SqlCommandBuilder
    Private Sub Product_Category_Creation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MaximumSize = Screen.FromRectangle(Me.Bounds).WorkingArea.Size
        Display()
    End Sub
    Private Sub Display()

        reload("select * from Category", gvStock)
        reload("select * from Prodline", DataGridView1)
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If poscon.State = ConnectionState.Closed Then
            poscon.Open()
        End If

        Dim sql = "select * from category where category= '" + txtCat.Text + "' "
        cmd = New SqlCommand(sql, poscon)
        dr = cmd.ExecuteReader
        If txtCat.Text = "" Then
            MsgBox("Enter New Category")
            poscon.Close()
        ElseIf (dr.Read = True) Then
            MsgBox("Category Already Exists, Enter a new Category")
            poscon.Close()
            clear()
        Else
            Try
                If poscon.State = ConnectionState.Closed Then
                    poscon.Open()
                End If
                Dim query = "Insert into category values('" + txtCat.Text + "')"
                cmd = New SqlCommand(query, poscon)
                cmd.ExecuteNonQuery()
                'MsgBox("Succesfully Created")
                poscon.Close()
                Display()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If
        clear()
        dr.Close()
    End Sub


    'Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
    '    If key = "" Then
    '        MsgBox("Select a Category")
    '    Else
    '        Try
    '            If poscon.State = ConnectionState.Closed Then
    '                poscon.Open()
    '            End If
    '            Dim query = "delete from Category where Id= " + key + " "
    '            cmd = New SqlCommand(query, poscon)
    '            cmd.ExecuteNonQuery()
    '            MsgBox("Product Deleted Successfully")
    '            poscon.Close()
    '            clear()
    '            Display()
    '        Catch ex As Exception
    '            MsgBox(ex.Message)
    '        End Try
    '    End If

    'End Sub

    'Private Sub gvStock_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gvStock.CellContentClick
    '    Try
    '        Dim row As DataGridViewRow = gvStock.Rows(e.RowIndex)
    '        txtCat.Text = row.Cells(1).Value.ToString()
    '        If txtCat.Text = "" Then
    '            key = ""
    '        Else
    '            key = row.Cells(0).Value.ToString
    '        End If
    '    Catch ex As Exception

    '    End Try

    'End Sub

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





    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    '    If Poscon.State = ConnectionState.Closed Then
    '        Poscon.Open()
    '    End If

    '    Dim sql = "select * from Productline where Productline= '" + txtProdline.Text + "' "
    '    cmd = New SqlCommand(sql, Poscon)
    '    dr = cmd.ExecuteReader
    '    If txtProdline.Text = "" Then
    '        MsgBox("Enter New Productline")
    '        Poscon.Close()
    '    ElseIf (dr.Read = True) Then
    '        MsgBox("Productline Already Exists, Enter a new Productline")
    '        Poscon.Close()
    '        clear()
    '    Else
    '        Try
    '            If Poscon.State = ConnectionState.Closed Then
    '                Poscon.Open()
    '            End If
    '            Dim query = "Insert into Productline values('" + txtProdline.Text + "')"
    '            cmd = New SqlCommand(query, Poscon)
    '            cmd.ExecuteNonQuery()
    '            'MsgBox("Succesfully Created")
    '            Poscon.Close()
    '            Display()

    '        Catch ex As Exception
    '            MsgBox(ex.Message)
    '        End Try

    '    End If
    '    clear()
    'End Sub



    Private Sub clear()
        txtProdline.Text = ""
    End Sub

    Private Sub frmProductline_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Display()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'If key = "" Then
        '    MsgBox("Select a Productline")
        'Else
        '    Try
        '        Poscon.Open()
        '        Dim query = "delete from Productline where Id= " + key + " "
        '        cmd = New SqlCommand(query, Poscon)
        '        cmd.ExecuteNonQuery()
        '        'MsgBox("Productline Deleted Successfully")
        '        Poscon.Close()
        '        clear()
        '        Display()
        '    Catch ex As Exception
        '        MsgBox(ex.Message)
        '    End Try
        'End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        clear()

    End Sub

    Private Sub gvStock_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles gvStock.CellClick
        'Dim row As DataGridViewRow = gvStock.Rows(e.RowIndex)
        'txtProdline.Text = row.Cells(1).Value.ToString()
        'If txtProdline.Text = "" Then
        '    key = ""
        'Else
        '    key = row.Cells(0).Value.ToString
        'End If
    End Sub

    Private Sub txtProdline_KeyDown(sender As Object, e As KeyEventArgs) Handles txtProdline.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button3_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If Poscon.State = ConnectionState.Closed Then
            Poscon.Open()
        End If

        Dim sql = "select * from Prodline where Productline= '" + txtProdline.Text + "' "
        cmd = New SqlCommand(sql, Poscon)
        dr = cmd.ExecuteReader
        If txtProdline.Text = "" Then
            MsgBox("Enter New Productlline")
            Poscon.Close()
        ElseIf (dr.Read = True) Then
            MsgBox("Productline Already Exists, Enter a new Productline")
            Poscon.Close()
            clear()
        Else
            Try
                If Poscon.State = ConnectionState.Closed Then
                    Poscon.Open()
                End If
                Dim query = "Insert into Prodline values('" + txtProdline.Text + "')"
                cmd = New SqlCommand(query, Poscon)
                cmd.ExecuteNonQuery()
                'MsgBox("Succesfully Created")
                Poscon.Close()
                Display()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If
        clear()
        dr.Close()
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        clear()
    End Sub
End Class