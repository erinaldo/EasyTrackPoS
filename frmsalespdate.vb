Imports System.Data.SqlClient
Public Class frmsalespdate
    'Dim As New SqlConnection(My.Settings.PoSConnectionString)
    Dim cmd As New SqlCommand
    Dim adp As New SqlDataAdapter
    Dim dt As New dsSalesTranx
    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load
        Try
            If Poscon.State = ConnectionState.Closed Then
                Poscon.Open()
            End If

            Dim query = "select * from salestranx"
            cmd = New SqlCommand(query, Poscon)
            dt.Tables("salestranx").Rows.Clear()
            adp.SelectCommand = cmd
            adp.Fill(dt, "salestranx")

            Dim report As New rptSalesPerDate
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

    Private Sub frmsalespdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class