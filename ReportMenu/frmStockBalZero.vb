Imports System.Data.SqlClient
Public Class frmStockBalZero
    'Dim As New SqlConnection(My.Settings.PoSConnectionString)
    Dim cmd As New SqlCommand
    Dim adp As New SqlDataAdapter
    Dim dt As New dsStockMast
    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load
        Try
            Dim query = "select * from StockMast"
            Poscon.Open()
            cmd = New SqlCommand(query, Poscon)
            adp.SelectCommand = cmd
            adp.Fill(dt, "StockMast")
            Dim report As New rptStockBalZero
            report.SetDataSource(dt)
            CrystalReportViewer1.ReportSource = report
            CrystalReportViewer1.Refresh()
            cmd.Dispose()
            adp.Dispose()
            Poscon.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class