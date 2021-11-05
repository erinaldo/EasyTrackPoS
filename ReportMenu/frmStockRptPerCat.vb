Imports System.Data.SqlClient
Public Class frmStockRptPerCat
    Dim con As New SqlConnection(My.Settings.PoSConnectionString)
    Dim cmd As New SqlCommand
    Dim adp As New SqlDataAdapter
    Dim dt As New dsStockMast

    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles rvStockPerCat.Load
        Try
            Dim query = "select * from StockMast"
            con.Open()
            cmd = New SqlCommand(query, con)
            adp.SelectCommand = cmd
            adp.Fill(dt, "StockMast")
            Dim report As New rptStockPerCat
            report.SetDataSource(dt)
            rvStockPerCat.ReportSource = report
            rvStockPerCat.Refresh()
            cmd.Dispose()
            adp.Dispose()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


    End Sub



End Class