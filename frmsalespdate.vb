Imports System.Data.SqlClient
Public Class frmsalespdate
    Dim con As New SqlConnection(My.Settings.PoSConnectionString)
    Dim cmd As New SqlCommand
    Dim adp As New SqlDataAdapter
    Dim dt As New dsSalesTranx
    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If

            Dim query = "select * from salestranx"
            cmd = New SqlCommand(query, con)
            dt.Tables("salestranx").Rows.Clear()
            adp.SelectCommand = cmd
            adp.Fill(dt, "salestranx")

            Dim report As New rptSalesPerDate
            report.SetDataSource(dt)
            CrystalReportViewer1.ReportSource = report
            CrystalReportViewer1.Refresh()
            cmd.Dispose()
            adp.Dispose()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub frmsalespdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class