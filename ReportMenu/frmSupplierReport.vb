Imports System.Data.SqlClient
Public Class frmSupplierReport
    'Dim As New SqlConnection(My.Settings.PoSConnectionString)
    Dim cmd As New SqlCommand
    Dim adp As New SqlDataAdapter
    Dim dt As New dsSupplier
    Private Sub frmSupplierReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class