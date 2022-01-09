Imports System.Data.SqlClient
Public Class frmTobeCollectedPreview
    'Dim As New SqlConnection(My.Settings.PoSConnectionString)
    Dim dr As SqlDataReader
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter
    Dim dt As New dsTobeCollected
    Dim tbl As New DataTable()
    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load

        'TobeColDelReciept()

    End Sub
    Private Sub TobeColDelReciept()
        dt.EnforceConstraints = False
        If Poscon.State = ConnectionState.Closed Then
            Poscon.Open()
        End If

        Dim sql = "select * from ClientReg"
        cmd = New SqlCommand(sql, Poscon)
        da = New SqlDataAdapter
        da.SelectCommand = cmd
        da.Fill(dt, "ClientReg")



        Dim report As New rptToBeCollectedDelivery
        report.SetDataSource(dt)

        CrystalReportViewer1.ReportSource = report
        CrystalReportViewer1.Refresh()
        'report.PrintToPrinter(1, True, 0, 0)
        cmd.Dispose()
        da.Dispose()
        Poscon.Close()
    End Sub
End Class