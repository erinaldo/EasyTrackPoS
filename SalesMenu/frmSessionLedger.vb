Imports System.Data.SqlClient
Public Class frmSessionLedger
    'Dim As New SqlConnection(My.Settings.PoSConnectionString)
    Dim cmd As New SqlCommand
    Dim adp As New SqlDataAdapter
    Dim dt As New dsSessionLedger
    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load
        Try
            Dim query = "select * from Sessionledger"
            Poscon.Open()
            cmd = New SqlCommand(query, Poscon)
            adp.SelectCommand = cmd
            dt.Tables("Sessionledger").Rows.Clear()
            adp.Fill(dt, "Sessionledger")
            Dim report As New rptSessionLedger
            report.SetDataSource(dt)
            CrystalReportViewer1.ReportSource = report
            CrystalReportViewer1.Refresh()
            cmd.Dispose()
            adp.Dispose()
            Poscon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class