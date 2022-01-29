Imports System.Data.SqlClient
Public Class CustomerReport
    Dim dt As New dscustomer
    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        Dim selectedindex = cbReport.SelectedIndex
        Select Case selectedindex
            Case 0
                Try
                    Dim query = "select * from Customer"
                    If Poscon.State = ConnectionState.Closed Then
                        Poscon.Open()
                    End If
                    dt.Tables("customer").Rows.Clear()
                    cmd = New SqlCommand(query, Poscon)
                    da.SelectCommand = cmd
                    da.Fill(dt, "Customer")

                    Dim sql = "select * from ClientReg"
                    dt.Tables("clientreg").Rows.Clear()
                    cmd = New SqlCommand(sql, Poscon)
                    da.SelectCommand = cmd
                    da.Fill(dt, "ClientReg")
                    Dim report As New rptCustomerInfo
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
                    Dim query = "select * from Customerpayment"
                    If Poscon.State = ConnectionState.Closed Then
                        Poscon.Open()
                    End If
                    dt.Tables("customerpayment").Rows.Clear()
                    cmd = New SqlCommand(query, Poscon)
                    da.SelectCommand = cmd
                    da.Fill(dt, "Customerpayment")

                    Dim sql = "select * from ClientReg"
                    cmd = New SqlCommand(sql, Poscon)
                    dt.Tables("clientreg").Rows.Clear()
                    da.SelectCommand = cmd
                    da.Fill(dt, "ClientReg")
                    Dim report As New rptCustomerPayments
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
                    Dim query = "select * from Customerpayment where datepaid between @datefrom and @dateto"
                    cmd = New SqlCommand(query, Poscon)
                    cmd.Parameters.Add("datefrom", sqlDbType:=SqlDbType.Date).Value = outfrom
                    cmd.Parameters.Add("dateto", sqlDbType:=SqlDbType.Date).Value = outto
                    dt.Tables("Customerpayment").Rows.Clear()
                    da.SelectCommand = cmd
                    da.Fill(dt, "Customerpayment")


                    dt.Tables("range").Rows.Clear()
                    dt.Tables("range").Rows.Add(NewReport.dpdatefrom.Value, NewReport.dpdateto.Value)

                    Dim sql = "select * from ClientReg"
                    dt.Tables("clientreg").Rows.Clear()
                    cmd = New SqlCommand(sql, Poscon)
                    da.SelectCommand = cmd
                    da.Fill(dt, "ClientReg")
                    Dim report As New rptCustomerPaymentsperDate
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
                    Dim query = "select * from issuestock where dateissued between @datefrom and @dateto "
                    cmd = New SqlCommand(query, Poscon)
                    cmd.Parameters.Add("datefrom", sqlDbType:=SqlDbType.Date).Value = outfrom
                    cmd.Parameters.Add("dateto", sqlDbType:=SqlDbType.Date).Value = outto

                    dt.Tables("Issuestock").Rows.Clear()

                    da.SelectCommand = cmd
                    da.Fill(dt, "issuestock")

                    dt.Tables("range").Rows.Clear()
                    dt.Tables("range").Rows.Add(NewReport.dpdatefrom.Value, NewReport.dpdateto.Value)

                    Dim sql = "select * from ClientReg"
                    dt.Tables("clientreg").Rows.Clear()
                    cmd = New SqlCommand(sql, Poscon)
                    da.SelectCommand = cmd
                    da.Fill(dt, "ClientReg")
                    Dim report As New rptCustomerSummPDate
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
                    Dim query = "select * from CustomerLedger"
                    If Poscon.State = ConnectionState.Closed Then
                        Poscon.Open()
                    End If
                    dt.Tables("CustomerLedger").Rows.Clear()
                    cmd = New SqlCommand(query, Poscon)
                    da.SelectCommand = cmd
                    da.Fill(dt, "CustomerLedger")

                    Dim sql = "select * from ClientReg"
                    dt.Tables("clientreg").Rows.Clear()
                    cmd = New SqlCommand(sql, Poscon)
                    da.SelectCommand = cmd
                    da.Fill(dt, "ClientReg")
                    Dim report As New rptCustomerSales
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
                    Dim query = "select * from Customer"
                    If Poscon.State = ConnectionState.Closed Then
                        Poscon.Open()
                    End If
                    dt.Tables("Customer").Rows.Clear()
                    cmd = New SqlCommand(query, Poscon)
                    da.SelectCommand = cmd
                    da.Fill(dt, "Customer")

                    Dim sql = "select * from ClientReg"
                    dt.Tables("clientreg").Rows.Clear()
                    cmd = New SqlCommand(sql, Poscon)
                    da.SelectCommand = cmd
                    da.Fill(dt, "ClientReg")
                    Dim report As New rptCustomerBalance
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
