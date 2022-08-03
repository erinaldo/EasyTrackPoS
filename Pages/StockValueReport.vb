Imports System.Data.SqlClient
Public Class StockValueReport
    Dim dt As New dsStockMast
    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        Dim selectedindex = cbReport.SelectedIndex
        Select Case selectedindex
            Case 0
                Try
                    If Poscon.State = ConnectionState.Closed Then
                        Poscon.Open()
                    End If
                    Dim query = "select * from Stockmast where baseqty*packsize=1"
                    cmd = New SqlCommand(query, Poscon)
                    dt.Tables("Stockmast").Rows.Clear()
                    da.SelectCommand = cmd
                    da.Fill(dt, "Stockmast")

                    'Dim sql = "select * from ClientReg"
                    'dt.Tables("ClientReg").Rows.Clear()
                    'cmd = New SqlCommand(sql, poscon)
                    'adp.SelectCommand = cmd
                    'adp.Fill(dt, "ClientReg")

                    Dim report As New rptStockValpCat
                    report.SetDataSource(dt)
                    NewReport.CrystalReportViewer1.ReportSource = report
                    NewReport.CrystalReportViewer1.Refresh()
                    cmd.Dispose()
                    da.Dispose()
                    Poscon.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Case 1
                Try
                    If Poscon.State = ConnectionState.Closed Then
                        Poscon.Open()
                    End If
                    Dim query = "select * from Stockmast where baseqty*packsize=1 "
                    cmd = New SqlCommand(query, Poscon)
                    dt.Tables("Stockmast").Rows.Clear()
                    da.SelectCommand = cmd
                    da.Fill(dt, "Stockmast")

                    'Dim sql = "select * from ClientReg"
                    'dt.Tables("ClientReg").Rows.Clear()
                    'cmd = New SqlCommand(sql, poscon)
                    'adp.SelectCommand = cmd
                    'adp.Fill(dt, "ClientReg")

                    Dim report As New rptStockValpPline
                    report.SetDataSource(dt)
                    NewReport.CrystalReportViewer1.ReportSource = report
                    NewReport.CrystalReportViewer1.Refresh()
                    cmd.Dispose()
                    da.Dispose()
                    Poscon.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Case 2
                Try
                    If Poscon.State = ConnectionState.Closed Then
                        Poscon.Open()
                    End If
                    Dim query = "select * from Stockmast where baseqty*packsize>1 "
                    cmd = New SqlCommand(query, Poscon)
                    dt.Tables("Stockmast").Rows.Clear()
                    da.SelectCommand = cmd
                    da.Fill(dt, "Stockmast")

                    'Dim sql = "select * from ClientReg"
                    'dt.Tables("ClientReg").Rows.Clear()
                    'cmd = New SqlCommand(sql, poscon)
                    'adp.SelectCommand = cmd
                    'adp.Fill(dt, "ClientReg")

                    Dim report As New rptStockValPCatPck
                    report.SetDataSource(dt)
                    NewReport.CrystalReportViewer1.ReportSource = report
                    NewReport.CrystalReportViewer1.Refresh()
                    cmd.Dispose()
                    da.Dispose()
                    Poscon.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Case 3
                Try
                    If Poscon.State = ConnectionState.Closed Then
                        Poscon.Open()
                    End If
                    Dim query = "select * from Stockmast where baseqty*packsize>1"
                    cmd = New SqlCommand(query, Poscon)
                    dt.Tables("Stockmast").Rows.Clear()
                    da.SelectCommand = cmd
                    da.Fill(dt, "Stockmast")

                    'Dim sql = "select * from ClientReg"
                    'dt.Tables("ClientReg").Rows.Clear()
                    'cmd = New SqlCommand(sql, poscon)
                    'adp.SelectCommand = cmd
                    'adp.Fill(dt, "ClientReg")

                    Dim report As New rptStockValPBrandPck
                    report.SetDataSource(dt)
                    NewReport.CrystalReportViewer1.ReportSource = report
                    NewReport.CrystalReportViewer1.Refresh()
                    cmd.Dispose()
                    da.Dispose()
                    Poscon.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Case 4
                Try
                    If Poscon.State = ConnectionState.Closed Then
                        Poscon.Open()
                    End If
                    Dim query = "select * from Stockmast "
                    cmd = New SqlCommand(query, Poscon)
                    dt.Tables("Stockmast").Rows.Clear()
                    da.SelectCommand = cmd
                    da.Fill(dt, "Stockmast")

                    'Dim sql = "select * from ClientReg"
                    'dt.Tables("ClientReg").Rows.Clear()
                    'cmd = New SqlCommand(sql, poscon)
                    'adp.SelectCommand = cmd
                    'adp.Fill(dt, "ClientReg")

                    Dim report As New rptStockValOverall
                    report.SetDataSource(dt)
                    NewReport.CrystalReportViewer1.ReportSource = report
                    NewReport.CrystalReportViewer1.Refresh()
                    cmd.Dispose()
                    da.Dispose()
                    Poscon.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try


            Case Else
        End Select
    End Sub
End Class
