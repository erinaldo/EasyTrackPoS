Imports System.Data.SqlClient
Imports System.Globalization
Public Class frmSupplierReportMenu
    'Dim As New SqlConnection(My.Settings.PoSConnectionString)
    Dim cmd As New SqlCommand
    'Dim adp As New SqlDataAdapter
    Dim dt As New dsSupplier
    Public outto As Date
    Public outfrom As Date
    Private Sub btnOpenSession_Click(sender As Object, e As EventArgs) Handles btnOpenSession.Click

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
            frmSupplierReport.Show()
            frmSupplierReport.CrystalReportViewer1.ReportSource = report
            frmSupplierReport.CrystalReportViewer1.Refresh()
            cmd.Dispose()
            da.Dispose()
            Poscon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles BunifuButton1.Click


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
            frmSupplierReport.Show()
            frmSupplierReport.CrystalReportViewer1.ReportSource = report
            frmSupplierReport.CrystalReportViewer1.Refresh()
            cmd.Dispose()
            da.Dispose()
            Poscon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BunifuButton2_Click(sender As Object, e As EventArgs) Handles BunifuButton2.Click
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
            frmSupplierReport.Show()
            frmSupplierReport.CrystalReportViewer1.ReportSource = report
            frmSupplierReport.CrystalReportViewer1.Refresh()
            cmd.Dispose()
            da.Dispose()
            Poscon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BunifuButton3_Click(sender As Object, e As EventArgs) Handles BunifuButton3.Click
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
            frmSupplierReport.Show()
            frmSupplierReport.CrystalReportViewer1.ReportSource = report
            frmSupplierReport.CrystalReportViewer1.Refresh()
            cmd.Dispose()
            da.Dispose()
            Poscon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        frmReportMenu.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuButton4_Click(sender As Object, e As EventArgs) Handles BunifuButton4.Click

        DateTime.TryParseExact(dpdatefrom.Value, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, outfrom)
        DateTime.TryParseExact(dpdateto.Value, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, outto)


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
            dt.Tables("range").Rows.Add(dpdatefrom.Value, dpdateto.Value)

            Dim sql = "select * from ClientReg"
            cmd = New SqlCommand(sql, Poscon)
            da.SelectCommand = cmd
            dt.Tables("clientreg").Rows.Clear()
            da.Fill(dt, "ClientReg")

            Dim report As New rptGoodsRecievedPerDate
            report.SetDataSource(dt)
            frmSupplierReport.Show()
            frmSupplierReport.CrystalReportViewer1.ReportSource = report
            frmSupplierReport.CrystalReportViewer1.Refresh()
            cmd.Dispose()
            da.Dispose()
            Poscon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class