Imports System.Data.SqlClient
Public Class StockBalancesReport
    Dim dt As New dsStockMast
    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        Dim selectedindex = cbReport.SelectedIndex
        Select Case selectedindex
            Case 0
                Try
                    Dim query = "select * from StockMast"
                    Poscon.Open()
                    cmd = New SqlCommand(query, Poscon)
                    da.SelectCommand = cmd
                    da.Fill(dt, "StockMast")
                    Dim report As New rptStockTakingSheet
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
                    Dim query = "select * from Stockmast where prodqty<=leastqtyreminder"
                    cmd = New SqlCommand(query, Poscon)
                    dt.Tables("Stockmast").Rows.Clear()
                    da.SelectCommand = cmd
                    da.Fill(dt, "Stockmast")

                    'Dim sql = "select * from ClientReg"
                    'dt.Tables("ClientReg").Rows.Clear()
                    'cmd = New SqlCommand(sql, poscon)
                    'adp.SelectCommand = cmd
                    'adp.Fill(dt, "ClientReg")

                    Dim report As New rptStockChecks
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
                    If Poscon.State = ConnectionState.Closed Then
                        Poscon.Open()
                    End If
                    Dim query = "select * from Stockmast"
                    cmd = New SqlCommand(query, Poscon)
                    dt.Tables("Stockmast").Rows.Clear()
                    da.SelectCommand = cmd
                    da.Fill(dt, "Stockmast")

                    'Dim sql = "select * from ClientReg"
                    'dt.Tables("ClientReg").Rows.Clear()
                    'cmd = New SqlCommand(sql, poscon)
                    'adp.SelectCommand = cmd
                    'adp.Fill(dt, "ClientReg")

                    Dim report As New rptStockBalbyPline
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
                    If Poscon.State = ConnectionState.Closed Then
                        Poscon.Open()
                    End If
                    Dim query = "select * from Stockmast"
                    cmd = New SqlCommand(query, Poscon)
                    dt.Tables("Stockmast").Rows.Clear()
                    da.SelectCommand = cmd
                    da.Fill(dt, "Stockmast")

                    'Dim sql = "select * from ClientReg"
                    'dt.Tables("ClientReg").Rows.Clear()
                    'cmd = New SqlCommand(sql, poscon)
                    'adp.SelectCommand = cmd
                    'adp.Fill(dt, "ClientReg")

                    Dim report As New rptBalperSize
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
                    Dim query = "select * from Stockmast"
                    cmd = New SqlCommand(query, Poscon)
                    dt.Tables("Stockmast").Rows.Clear()
                    da.SelectCommand = cmd
                    da.Fill(dt, "Stockmast")

                    'Dim sql = "select * from ClientReg"
                    'dt.Tables("ClientReg").Rows.Clear()
                    'cmd = New SqlCommand(sql, poscon)
                    'adp.SelectCommand = cmd
                    'adp.Fill(dt, "ClientReg")

                    Dim report As New rptBalperSize
                    report.SetDataSource(dt)
                    NewReport.CrystalReportViewer1.ReportSource = report
                    NewReport.CrystalReportViewer1.Refresh()
                    cmd.Dispose()
                    da.Dispose()
                    Poscon.Close()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            Case 5
                Try
                    If Poscon.State = ConnectionState.Closed Then
                        Poscon.Open()
                    End If
                    Dim query = "select * from Stockmast"
                    cmd = New SqlCommand(query, Poscon)
                    dt.Tables("Stockmast").Rows.Clear()
                    da.SelectCommand = cmd
                    da.Fill(dt, "Stockmast")

                    'Dim sql = "select * from ClientReg"
                    'dt.Tables("ClientReg").Rows.Clear()
                    'cmd = New SqlCommand(sql, poscon)
                    'adp.SelectCommand = cmd
                    'adp.Fill(dt, "ClientReg")

                    Dim report As New rptStockBalbyColor
                    report.SetDataSource(dt)
                    NewReport.CrystalReportViewer1.ReportSource = report
                    NewReport.CrystalReportViewer1.Refresh()
                    cmd.Dispose()
                    da.Dispose()
                    Poscon.Close()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            Case 6
                Try
                    If Poscon.State = ConnectionState.Closed Then
                        Poscon.Open()
                    End If
                    Dim query = "select * from Stockmast"
                    cmd = New SqlCommand(query, Poscon)
                    dt.Tables("Stockmast").Rows.Clear()
                    da.SelectCommand = cmd
                    da.Fill(dt, "Stockmast")

                    'Dim sql = "select * from ClientReg"
                    'dt.Tables("ClientReg").Rows.Clear()
                    'cmd = New SqlCommand(sql, poscon)
                    'adp.SelectCommand = cmd
                    'adp.Fill(dt, "ClientReg")

                    Dim report As New rptStockBalPositive
                    report.SetDataSource(dt)
                    NewReport.CrystalReportViewer1.ReportSource = report
                    NewReport.CrystalReportViewer1.Refresh()
                    cmd.Dispose()
                    da.Dispose()
                    Poscon.Close()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            Case 7
                Try
                    If Poscon.State = ConnectionState.Closed Then
                        Poscon.Open()
                    End If
                    Dim query = "select * from Stockmast"
                    cmd = New SqlCommand(query, Poscon)
                    dt.Tables("Stockmast").Rows.Clear()
                    da.SelectCommand = cmd
                    da.Fill(dt, "Stockmast")

                    'Dim sql = "select * from ClientReg"
                    'dt.Tables("ClientReg").Rows.Clear()
                    'cmd = New SqlCommand(sql, poscon)
                    'adp.SelectCommand = cmd
                    'adp.Fill(dt, "ClientReg")

                    Dim report As New rptStockBalNegative
                    report.SetDataSource(dt)
                    NewReport.CrystalReportViewer1.ReportSource = report
                    NewReport.CrystalReportViewer1.Refresh()
                    cmd.Dispose()
                    da.Dispose()
                    Poscon.Close()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            Case 8
                Try
                    If Poscon.State = ConnectionState.Closed Then
                        Poscon.Open()
                    End If
                    Dim query = "select * from Stockmast"
                    cmd = New SqlCommand(query, Poscon)
                    dt.Tables("Stockmast").Rows.Clear()
                    da.SelectCommand = cmd
                    da.Fill(dt, "Stockmast")

                    'Dim sql = "select * from ClientReg"
                    'dt.Tables("ClientReg").Rows.Clear()
                    'cmd = New SqlCommand(sql, poscon)
                    'adp.SelectCommand = cmd
                    'adp.Fill(dt, "ClientReg")

                    Dim report As New rptStockBalZero
                    report.SetDataSource(dt)
                    NewReport.CrystalReportViewer1.ReportSource = report
                    NewReport.CrystalReportViewer1.Refresh()
                    cmd.Dispose()
                    da.Dispose()
                    Poscon.Close()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            Case 9
                Try

                    If Poscon.State = ConnectionState.Closed Then
                        Poscon.Open()
                    End If
                    Dim query = "select * from inventoryledger"
                    cmd = New SqlCommand(query, Poscon)
                    dt.Tables("inventoryledger").Rows.Clear()
                    da.SelectCommand = cmd
                    da.Fill(dt, "inventoryledger")

                    'Dim sql = "select * from ClientReg"
                    'dt.Tables("ClientReg").Rows.Clear()
                    'cmd = New SqlCommand(sql, poscon)
                    'adp.SelectCommand = cmd
                    'adp.Fill(dt, "ClientReg")

                    Dim report As New rptInventLedgerPerItem
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
