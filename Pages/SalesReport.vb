Imports System.Data.SqlClient
Imports System.Globalization
Public Class SalesReport
    Dim dt As New dsSalesTranx

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        DateTime.TryParseExact(NewReport.dpdatefrom.Value, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, outfrom)
        DateTime.TryParseExact(NewReport.dpdateto.Value, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, outto)

        Dim selectedindex = cbReport.SelectedIndex
        Select Case selectedindex
            Case 0

                Dim query = "select * from salestranx where datesold between @datefrom and @dateto"
                cmd = New SqlCommand(query, Poscon)
                cmd.Parameters.Add("datefrom", sqlDbType:=SqlDbType.Date).Value = outfrom
                cmd.Parameters.Add("dateto", sqlDbType:=SqlDbType.Date).Value = outto
                dt.Tables("salestranx").Rows.Clear()
                da.SelectCommand = cmd
                da.Fill(dt, "salestranx")

                Dim sql = "select * from ClientReg"
                dt.Tables("ClientReg").Rows.Clear()
                cmd = New SqlCommand(sql, Poscon)
                da.SelectCommand = cmd
                da.Fill(dt, "ClientReg")


                dt.Tables("cancellationlog").Rows.Clear()
                cmd = New SqlCommand("select * from cancellationlog", Poscon)
                da.SelectCommand = cmd
                da.Fill(dt, "cancellationlog")

                Dim report As New rptSalesPerDate
                report.SetDataSource(dt)
                NewReport.CrystalReportViewer1.ReportSource = report
                NewReport.CrystalReportViewer1.Refresh()
                cmd.Dispose()
                da.Dispose()
                Poscon.Close()
            Case 1
                Dim query = "select * from salestranx where datesold between @datefrom and @dateto"
                cmd = New SqlCommand(query, Poscon)
                cmd.Parameters.Add("datefrom", sqlDbType:=SqlDbType.Date).Value = outfrom
                cmd.Parameters.Add("dateto", sqlDbType:=SqlDbType.Date).Value = outto
                dt.Tables("salestranx").Rows.Clear()
                da.SelectCommand = cmd
                da.Fill(dt, "salestranx")

                Dim sql = "select * from ClientReg"
                dt.Tables("ClientReg").Rows.Clear()
                cmd = New SqlCommand(sql, Poscon)
                da.SelectCommand = cmd
                da.Fill(dt, "ClientReg")

                Dim report As New rptSalesperCashier
                report.SetDataSource(dt)
                NewReport.CrystalReportViewer1.ReportSource = report
                NewReport.CrystalReportViewer1.Refresh()
                cmd.Dispose()
                da.Dispose()
                Poscon.Close()
            Case 2
                Dim query = "select * from salestranx where datesold between @datefrom and @dateto"
                cmd = New SqlCommand(query, Poscon)
                cmd.Parameters.Add("datefrom", sqlDbType:=SqlDbType.Date).Value = outfrom
                cmd.Parameters.Add("dateto", sqlDbType:=SqlDbType.Date).Value = outto
                dt.Tables("salestranx").Rows.Clear()
                da.SelectCommand = cmd
                da.Fill(dt, "salestranx")

                Dim sql = "select * from ClientReg"
                dt.Tables("ClientReg").Rows.Clear()
                cmd = New SqlCommand(sql, Poscon)
                da.SelectCommand = cmd
                da.Fill(dt, "ClientReg")

                Dim report As New rptSalesperCashier
                report.SetDataSource(dt)
                NewReport.CrystalReportViewer1.ReportSource = report
                NewReport.CrystalReportViewer1.Refresh()
                cmd.Dispose()
                da.Dispose()
                Poscon.Close()
            Case 3
                Dim query = "select * from salestranx where datesold between @datefrom and @dateto"
                cmd = New SqlCommand(query, Poscon)
                cmd.Parameters.Add("datefrom", sqlDbType:=SqlDbType.Date).Value = outfrom
                cmd.Parameters.Add("dateto", sqlDbType:=SqlDbType.Date).Value = outto
                dt.Tables("salestranx").Rows.Clear()
                da.SelectCommand = cmd
                da.Fill(dt, "salestranx")

                Dim sql = "select * from ClientReg"
                dt.Tables("ClientReg").Rows.Clear()
                cmd = New SqlCommand(sql, Poscon)
                da.SelectCommand = cmd
                da.Fill(dt, "ClientReg")

                Dim report As New rptSalesperCashier
                report.SetDataSource(dt)
                NewReport.CrystalReportViewer1.ReportSource = report
                NewReport.CrystalReportViewer1.Refresh()
                cmd.Dispose()
                da.Dispose()
                Poscon.Close()
            Case 4
                Dim query = "select * from salestranx where datesold between @datefrom and @dateto"
                cmd = New SqlCommand(query, Poscon)
                cmd.Parameters.Add("datefrom", sqlDbType:=SqlDbType.Date).Value = outfrom
                cmd.Parameters.Add("dateto", sqlDbType:=SqlDbType.Date).Value = outto
                dt.Tables("salestranx").Rows.Clear()
                da.SelectCommand = cmd
                da.Fill(dt, "salestranx")

                Dim sql = "select * from ClientReg"
                dt.Tables("ClientReg").Rows.Clear()
                cmd = New SqlCommand(sql, Poscon)
                da.SelectCommand = cmd
                da.Fill(dt, "ClientReg")

                Dim report As New rptSalesperCashier
                report.SetDataSource(dt)
                NewReport.CrystalReportViewer1.ReportSource = report
                NewReport.CrystalReportViewer1.Refresh()
                cmd.Dispose()
                da.Dispose()
                Poscon.Close()
            Case Else
                MsgBox("Kindly Choose a Report to View")
        End Select
    End Sub
End Class
