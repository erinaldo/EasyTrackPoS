Imports System.Data.SqlClient

Public Class frmProductline
    'Dim As New SqlConnection(My.Settings.PoSConnectionString)
    Dim dr As SqlDataReader
    Dim cmd As SqlCommand
    Dim builder As SqlCommandBuilder
    Dim adapter As SqlDataAdapter
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim f2 As New frmProdSetup
        f2.Show()
        Me.Hide()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Poscon.State = ConnectionState.Closed Then
            Poscon.Open()
        End If

        Dim sql = "select * from Productline where Productline= '" + txtProdline.Text + "' "
        cmd = New SqlCommand(sql, Poscon)
        dr = cmd.ExecuteReader
        If txtProdline.Text = "" Then
            MsgBox("Enter New Productline")
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
                Dim query = "Insert into Productline values('" + txtProdline.Text + "')"
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
    End Sub

    Private Sub Display()
        If Poscon.State = ConnectionState.Closed Then
            Poscon.Open()
        End If
        Dim query = "select * from Productline"
        cmd = New SqlCommand(query, Poscon)
        adapter = New SqlDataAdapter(cmd)
        builder = New SqlCommandBuilder(adapter)
        Dim ds
        ds = New DataSet
        adapter.Fill(ds)
        gvStock.DataSource = ds.Tables(0)
        Poscon.Close()
    End Sub

    Private Sub clear()
        txtProdline.Text = ""
    End Sub

    Private Sub frmProductline_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Display()

    End Sub
    Dim key = ""
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If key = "" Then
            MsgBox("Select a Productline")
        Else
            Try
                Poscon.Open()
                Dim query = "delete from Productline where Id= " + key + " "
                cmd = New SqlCommand(query, Poscon)
                cmd.ExecuteNonQuery()
                'MsgBox("Productline Deleted Successfully")
                Poscon.Close()
                clear()
                Display()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        clear()

    End Sub

    Private Sub gvStock_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles gvStock.CellClick
        Dim row As DataGridViewRow = gvStock.Rows(e.RowIndex)
        txtProdline.Text = row.Cells(1).Value.ToString()
        If txtProdline.Text = "" Then
            key = ""
        Else
            key = row.Cells(0).Value.ToString
        End If
    End Sub

    Private Sub txtProdline_KeyDown(sender As Object, e As KeyEventArgs) Handles txtProdline.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button3_Click(Nothing, Nothing)
        End If
    End Sub
End Class