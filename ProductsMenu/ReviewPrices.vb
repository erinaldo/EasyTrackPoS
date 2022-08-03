Imports System.Data.SqlClient

Public Class frmReviewPrices
    'Dim  New SqlConnection(My.Settings.PoSConnectionString)
    Private Sub ReviewPrices_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Display()
    End Sub

    Private Sub Display()
        Poscon.Open()
        Dim query = "select * from StockMast"
        Dim adapter As SqlDataAdapter
        Dim cmd As SqlCommand
        cmd = New SqlCommand(query, Poscon)
        adapter = New SqlDataAdapter(cmd)
        Dim builder As New SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds
        ds = New DataSet
        adapter.Fill(ds)
        gvStock.DataSource = ds.Tables(0)
        Poscon.Close()
    End Sub
    Dim key = 0
    Private Sub gvStock_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles gvStock.CellClick
        Dim row As DataGridViewRow = gvStock.Rows(e.RowIndex)
        txtStockCode.Text = row.Cells(0).Value.ToString()
        txtOldRPrice.Text = row.Cells(7).Value.ToString()
        txtNewRPrice.Text = row.Cells(7).Value.ToString()
        txtOldWPrice.Text = row.Cells(8).Value.ToString()
        txtNewWPrice.Text = row.Cells(8).Value.ToString()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtNewRPrice.Text = "" Or txtNewWPrice.Text = "" Then
            MsgBox("Enter New Prices")
        Else
            Try
                Poscon.Open()
                Dim query = ("update Stockmast set RetailPrice='" + txtNewRPrice.Text + "', WholesalePrice= '" + txtNewWPrice.Text + "' where Prodcode= '" + txtStockCode.Text + "'")
                Dim cmd As New SqlCommand(query, Poscon)
                cmd.ExecuteNonQuery()
                MsgBox("Product Updated Successfully")
                Poscon.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
        Display()
        Clear()
    End Sub
    Private Sub Clear()
        txtStockCode.Text = ""
        txtOldWPrice.Text = ""
        txtOldRPrice.Text = ""
        txtNewRPrice.Text = ""
        txtNewWPrice.Text = ""
    End Sub
End Class