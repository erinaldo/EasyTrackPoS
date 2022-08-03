Imports System.Data.SqlClient
Public Class frmGoodsRecievedPerItem
    ' Dim poscon As New SqlConnection(My.Settings.PoSConnectionString)
    Dim cmd As New SqlCommand
    Dim adp As New SqlDataAdapter
    Dim dt As New dsGoodsRecieved
    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load
        Try
            Dim query = "select * from recieveStock"
            poscon.Open()
            cmd = New SqlCommand(query, poscon)
            adp.SelectCommand = cmd
            adp.Fill(dt, "recievestock")
            Dim report As New rptGoodsPerItemRecieved
            report.SetDataSource(dt)
            CrystalReportViewer1.ReportSource = report
            CrystalReportViewer1.Refresh()
            cmd.Dispose()
            adp.Dispose()
            poscon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class