Imports System.Data.SqlClient
Public Class SupplierReport
    Dim dt As New dsSupplier
    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        Dim selectedindex = cbReport.SelectedIndex
        Select Case selectedindex
            Case 0
                Try
                    Dim query = "select * from Supplier"
                    If Poscon.State = ConnectionState.Closed Then
                        Poscon.Open()
                    End If
                    cmd = New SqlCommand(query, Poscon)
                    da.SelectCommand = cmd
                    dt.Tables("supplier").Rows.Clear()
                    da.Fill(dt, "Supplier")

                    Dim sql = "select * from ClientReg"
                    cmd = New SqlCommand(sql, Poscon)
                    da.SelectCommand = cmd
                    dt.Tables("clientreg").Rows.Clear()
                    da.Fill(dt, "ClientReg")

                    Dim report As New rptSupplierInfo
                    report.SetDataSource(dt)

                    NewReport.CrystalReportViewer1.ReportSource = report
                    NewReport.CrystalReportViewer1.Refresh()
                    cmd.Dispose()
                    da.Dispose()
                    Poscon.Close()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            Case 1
                Try

                    If Poscon.State = ConnectionState.Closed Then
                        Poscon.Open()
                    End If
                    Dim query = "select * from RecieveStock where daterecieved between @datefrom and @dateto "
                    cmd = New SqlCommand(query, Poscon)
                    cmd.Parameters.Add("datefrom", sqlDbType:=SqlDbType.Date).Value = outfrom
                    cmd.Parameters.Add("dateto", sqlDbType:=SqlDbType.Date).Value = outto
                    da.SelectCommand = cmd
                    dt.Tables("recieveStock").Rows.Clear()
                    da.Fill(dt, "recieveStock")

                    dt.Tables("range").Rows.Clear()
                    dt.Tables("range").Rows.Add(NewReport.dpdatefrom.Value, NewReport.dpdateto.Value)

                    Dim sql = "select * from ClientReg"
                    cmd = New SqlCommand(sql, Poscon)
                    da.SelectCommand = cmd
                    dt.Tables("clientreg").Rows.Clear()
                    da.Fill(dt, "ClientReg")

                    Dim report As New rptGoodsRecievedPerDate
                    report.SetDataSource(dt)

                    NewReport.CrystalReportViewer1.ReportSource = report
                    NewReport.CrystalReportViewer1.Refresh()
                    cmd.Dispose()
                    da.Dispose()
                    Poscon.Close()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            Case 2
                Try
                    Dim query = "select * from supplierpayments"
                    Poscon.Open()
                    cmd = New SqlCommand(query, Poscon)
                    dt.Tables("supplierpayments").Rows.Clear()
                    da.SelectCommand = cmd
                    da.Fill(dt, "supplierpayments")

                    Dim sql = "select * from ClientReg"
                    dt.Tables("ClientReg").Rows.Clear()
                    cmd = New SqlCommand(sql, Poscon)
                    da.SelectCommand = cmd
                    da.Fill(dt, "ClientReg")

                    Dim report As New rptSupplierPayment
                    report.SetDataSource(dt)

                    NewReport.CrystalReportViewer1.ReportSource = report
                    NewReport.CrystalReportViewer1.Refresh()
                    cmd.Dispose()
                    da.Dispose()
                    Poscon.Close()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            Case 3
                Try
                    Dim query = "select * from Supplier"
                    If Poscon.State = ConnectionState.Closed Then
                        Poscon.Open()
                    End If
                    cmd = New SqlCommand(query, Poscon)
                    da.SelectCommand = cmd
                    dt.Tables("supplier").Rows.Clear()
                    da.Fill(dt, "Supplier")

                    Dim sql = "select * from ClientReg"
                    cmd = New SqlCommand(sql, Poscon)
                    da.SelectCommand = cmd
                    dt.Tables("clientreg").Rows.Clear()
                    da.Fill(dt, "ClientReg")

                    Dim report As New rptSupplierBalance
                    report.SetDataSource(dt)
                    NewReport.CrystalReportViewer1.ReportSource = report
                    NewReport.CrystalReportViewer1.Refresh()
                    cmd.Dispose()
                    da.Dispose()
                    Poscon.Close()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            Case 4
                Try

                    If Poscon.State = ConnectionState.Closed Then
                        Poscon.Open()
                    End If
                    Dim query = "select * from RecieveStock"
                    cmd = New SqlCommand(query, Poscon)
                    da.SelectCommand = cmd
                    dt.Tables("recieveStock").Rows.Clear()
                    da.Fill(dt, "recieveStock")

                    Dim sql = "select * from ClientReg"
                    cmd = New SqlCommand(sql, Poscon)
                    da.SelectCommand = cmd
                    dt.Tables("clientreg").Rows.Clear()
                    da.Fill(dt, "ClientReg")

                    Dim report As New rptSupplierGoodsPerInvoice
                    report.SetDataSource(dt)

                    NewReport.CrystalReportViewer1.ReportSource = report
                    NewReport.CrystalReportViewer1.Refresh()
                    cmd.Dispose()
                    da.Dispose()
                    Poscon.Close()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            Case Else
                MsgBox("Kindly Choose a Report to View")
        End Select
    End Sub
End Class
