Imports System.Data.SqlClient
Public Class frmCreateWHSE
    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        If txtName.Text = "" Then
            MsgBox("Kindly enter a Warehouse name")
            txtName.Focus()
            Exit Sub
        End If
        If txtloc.Text = "" Then
            MsgBox("Kindly enter a Warehouse location")
            txtloc.Focus()
            Exit Sub
        End If
        insertd("insert into warehouse(whsename,whseloc,whsetype) values('" + txtName.Text + "','" + txtloc.Text + "','" + cbWHSEType.Text + "')")
        reload("select * from warehouse", gvStockMast)
    End Sub

    Private Sub frmCreateWHSE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reload("select * from warehouse", gvStockMast)
    End Sub
End Class