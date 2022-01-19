Imports System.Data.SqlClient
Imports System.Globalization
Public Class frmCustomerReportMenu
    'Dim As New SqlConnection(My.Settings.PoSConnectionString)
    Dim cmd As New SqlCommand
    Dim adp As New SqlDataAdapter
    Dim dt As New dscustomer
    Dim outto As Date
    Dim outfrom As Date
    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles BunifuButton1.Click
        Try
            Dim query = "select * from CustomerLedger"
            If Poscon.State = ConnectionState.Closed Then
                Poscon.Open()
            End If
            dt.Tables("CustomerLedger").Rows.Clear()
            cmd = New SqlCommand(query, Poscon)
            adp.SelectCommand = cmd
            adp.Fill(dt, "CustomerLedger")

            Dim sql = "select * from ClientReg"
            dt.Tables("clientreg").Rows.Clear()
            cmd = New SqlCommand(sql, Poscon)
            adp.SelectCommand = cmd
            adp.Fill(dt, "ClientReg")
            Dim report As New rptCustomerSales
            report.SetDataSource(dt)
            frmSupplierReport.Show()
            frmSupplierReport.CrystalReportViewer1.ReportSource = report
            frmSupplierReport.CrystalReportViewer1.Refresh()
            cmd.Dispose()
            adp.Dispose()
            Poscon.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        frmReportMenu.Show()
        Me.Hide()
    End Sub

    Private Sub btnOpenSession_Click(sender As Object, e As EventArgs) Handles btnOpenSession.Click
        Try
            Dim query = "select * from Customerpayment"
            If Poscon.State = ConnectionState.Closed Then
                Poscon.Open()
            End If
            dt.Tables("customerpayment").Rows.Clear()
            cmd = New SqlCommand(query, Poscon)
            adp.SelectCommand = cmd
            adp.Fill(dt, "Customerpayment")

            Dim sql = "select * from ClientReg"
            cmd = New SqlCommand(sql, Poscon)
            dt.Tables("clientreg").Rows.Clear()
            adp.SelectCommand = cmd
            adp.Fill(dt, "ClientReg")
            Dim report As New rptCustomerPayments
            report.SetDataSource(dt)
            frmSupplierReport.Show()
            frmSupplierReport.CrystalReportViewer1.ReportSource = report
            frmSupplierReport.CrystalReportViewer1.Refresh()
            cmd.Dispose()
            adp.Dispose()
            Poscon.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub BunifuButton3_Click(sender As Object, e As EventArgs) Handles BunifuButton3.Click
        Try
            Dim query = "select * from Customer"
            If Poscon.State = ConnectionState.Closed Then
                Poscon.Open()
            End If
            dt.Tables("customer").Rows.Clear()
            cmd = New SqlCommand(query, Poscon)
            adp.SelectCommand = cmd
            adp.Fill(dt, "Customer")

            Dim sql = "select * from ClientReg"
            dt.Tables("clientreg").Rows.Clear()
            cmd = New SqlCommand(sql, Poscon)
            adp.SelectCommand = cmd
            adp.Fill(dt, "ClientReg")
            Dim report As New rptCustomerInfo
            report.SetDataSource(dt)
            frmSupplierReport.Show()
            frmSupplierReport.CrystalReportViewer1.ReportSource = report
            frmSupplierReport.CrystalReportViewer1.Refresh()
            cmd.Dispose()
            adp.Dispose()
            Poscon.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub BunifuButton2_Click(sender As Object, e As EventArgs) Handles BunifuButton2.Click
        Try
            Dim query = "select * from Customer"
            If Poscon.State = ConnectionState.Closed Then
                Poscon.Open()
            End If
            dt.Tables("Customer").Rows.Clear()
            cmd = New SqlCommand(query, Poscon)
            adp.SelectCommand = cmd
            adp.Fill(dt, "Customer")

            Dim sql = "select * from ClientReg"
            dt.Tables("clientreg").Rows.Clear()
            cmd = New SqlCommand(sql, Poscon)
            adp.SelectCommand = cmd
            adp.Fill(dt, "ClientReg")
            Dim report As New rptCustomerBalance
            report.SetDataSource(dt)
            frmSupplierReport.Show()
            frmSupplierReport.CrystalReportViewer1.ReportSource = report
            frmSupplierReport.CrystalReportViewer1.Refresh()
            cmd.Dispose()
            adp.Dispose()
            Poscon.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub BunifuButton4_Click(sender As Object, e As EventArgs) Handles BunifuButton4.Click
        Try
            Dim query = "select * from issuestock"
            If Poscon.State = ConnectionState.Closed Then
                Poscon.Open()
            End If
            dt.Tables("Customer").Rows.Clear()
            cmd = New SqlCommand(query, Poscon)
            adp.SelectCommand = cmd
            adp.Fill(dt, "issuestock")

            Dim sql = "select * from ClientReg"
            dt.Tables("clientreg").Rows.Clear()
            cmd = New SqlCommand(sql, Poscon)
            adp.SelectCommand = cmd
            adp.Fill(dt, "ClientReg")
            Dim report As New rptCustomerSummPDate
            report.SetDataSource(dt)
            frmSupplierReport.Show()
            frmSupplierReport.CrystalReportViewer1.ReportSource = report
            frmSupplierReport.CrystalReportViewer1.Refresh()
            cmd.Dispose()
            adp.Dispose()
            Poscon.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub BunifuButton5_Click(sender As Object, e As EventArgs) Handles BunifuButton5.Click
        DateTime.TryParseExact(dpdatefrom.Value, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, outfrom)
        DateTime.TryParseExact(dpdateto.Value, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, outto)

        Try
            If Poscon.State = ConnectionState.Closed Then
                Poscon.Open()
            End If
            Dim query = "select * from Customerpayment where datepaid between @datefrom and @dateto"
            cmd = New SqlCommand(query, Poscon)
            cmd.Parameters.Add("datefrom", sqlDbType:=SqlDbType.Date).Value = outfrom
            cmd.Parameters.Add("dateto", sqlDbType:=SqlDbType.Date).Value = outto
            dt.Tables("Customerpayment").Rows.Clear()
            adp.SelectCommand = cmd
            adp.Fill(dt, "Customerpayment")

            dt.Tables("range").Rows.Add(dpdatefrom.Value, dpdateto.Value)

            Dim sql = "select * from ClientReg"
            dt.Tables("clientreg").Rows.Clear()
            cmd = New SqlCommand(sql, Poscon)
            adp.SelectCommand = cmd
            adp.Fill(dt, "ClientReg")
            Dim report As New rptCustomerPaymentsperDate
            report.SetDataSource(dt)
            frmSupplierReport.Show()
            frmSupplierReport.CrystalReportViewer1.ReportSource = report
            frmSupplierReport.CrystalReportViewer1.Refresh()
            cmd.Dispose()
            adp.Dispose()
            Poscon.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class