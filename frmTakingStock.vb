Imports System.Data.SqlClient
Imports System.Data
Public Class frmTakingStock
    'Dim As New SqlConnection(My.Settings.PoSConnectionString)
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter
    Dim dt As dsStockMast
    ' Dim ds As dsClientReg
    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load
        Try
            Poscon.Open()
            Dim query = "select * from StockMast"
            cmd = New SqlCommand(query, Poscon)
            da = New SqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(dt, "StockMast")
            Dim report As New rptStockTakingSheet
            report.SetDataSource(dt)
            CrystalReportViewer1.ReportSource = report
            CrystalReportViewer1.Refresh()
            cmd.Dispose()
            da.Dispose()
            Poscon.Close()
        Catch
        End Try
    End Sub
End Class