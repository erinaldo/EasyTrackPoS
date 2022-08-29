Imports System.Data.SqlClient
Public Class frmCreateWHSE
    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        insertd("insert into warehouse(whsename,whseloc,whsetype) values('" + txtName.Text + "','" + txtloc.Text + "','" + cbWHSEType.Text + "')")
    End Sub

    Private Sub frmCreateWHSE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reload("select * from warehouse", gvStockMast)
    End Sub
End Class