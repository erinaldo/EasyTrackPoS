Imports System.Data.SqlClient
Imports System.Globalization
Public Class SalesReportMenu
    'Dim As New SqlConnection(My.Settings.PoSConnectionString)
    Dim cmd As New SqlCommand
    Dim da As New SqlDataAdapter
    Dim dt As New dsSalesTranx
    'Dim outto As Date
    'Dim outfrom As Date

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim f2 As New frmReportMenu
        f2.Show()
        Me.Hide()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        DateTime.TryParseExact(dpDatefrom.Value, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, outfrom)
        DateTime.TryParseExact(dpdateto.Value, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, outto)
        Try
            Dim query = "select * from cancellationlog where datecancelled between @datefrom and @dateto"
            cmd = New SqlCommand(query, Poscon)
            cmd.Parameters.Add("datefrom", sqlDbType:=SqlDbType.Date).Value = outfrom
            cmd.Parameters.Add("dateto", sqlDbType:=SqlDbType.Date).Value = outto
            dt.Tables("cancellationlog").Rows.Clear()
            da.SelectCommand = cmd
            da.Fill(dt, "cancellationlog")

            'Dim sql = "select * from ClientReg"
            'dt.Tables("ClientReg").Rows.Clear()
            'cmd = New SqlCommand(sql, Poscon)
            'da.SelectCommand = cmd
            'da.Fill(dt, "ClientReg")


            'dt.Tables("cancellationlog").Rows.Clear()
            'cmd = New SqlCommand("select * from cancellationlog", Poscon)
            'da.SelectCommand = cmd
            'da.Fill(dt, "cancellationlog")

            'Dim sqll = "select expenses,cashcounted from Sessionledger where dateclosed between @datefrom and @dateto"
            'cmd = New SqlCommand(query, poscon)
            'cmd.Parameters.Add("datefrom", sqlDbType:=SqlDbType.Date).Value = outfrom
            'cmd.Parameters.Add("dateto", sqlDbType:=SqlDbType.Date).Value = outto
            'dt.Tables("Sessionledger").Rows.Clear()
            'da.SelectCommand = cmd
            'da.Fill(dt, "Sessionledger")

            Dim report As New rptCancellationpdate
            report.SetDataSource(dt)
            frmSupplierReport.Show()
            frmSupplierReport.CrystalReportViewer1.ReportSource = report
            frmSupplierReport.CrystalReportViewer1.Refresh()
            cmd.Dispose()
            da.Dispose()
            Poscon.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click, Label2.Click
        DateTime.TryParseExact(dpDatefrom.Value, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, outfrom)
        DateTime.TryParseExact(dpdateto.Value, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, outto)
        Try
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
            frmSupplierReport.Show()
            frmSupplierReport.CrystalReportViewer1.ReportSource = report
            frmSupplierReport.CrystalReportViewer1.Refresh()
            cmd.Dispose()
            da.Dispose()
            Poscon.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        DateTime.TryParseExact(dpDatefrom.Value, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, outfrom)
        DateTime.TryParseExact(dpdateto.Value, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, outto)
        Try
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

            Dim report As New rptSalesperItem
            report.SetDataSource(dt)
            frmSupplierReport.Show()
            frmSupplierReport.CrystalReportViewer1.ReportSource = report
            frmSupplierReport.CrystalReportViewer1.Refresh()
            cmd.Dispose()
            da.Dispose()
            Poscon.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        DateTime.TryParseExact(dpDatefrom.Value, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, outfrom)
        DateTime.TryParseExact(dpdateto.Value, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, outto)
        Try
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

            Dim report As New rptSalespercashierRoll
            report.SetDataSource(dt)
            frmSupplierReport.Show()
            frmSupplierReport.CrystalReportViewer1.ReportSource = report
            frmSupplierReport.CrystalReportViewer1.Refresh()
            cmd.Dispose()
            da.Dispose()
            Poscon.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        DateTime.TryParseExact(dpDatefrom.Value, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, outfrom)
        DateTime.TryParseExact(dpdateto.Value, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, outto)
        Try
            Dim query = "select * from Pricechangelog where date between @datefrom and @dateto"
            cmd = New SqlCommand(query, Poscon)
            cmd.Parameters.Add("datefrom", sqlDbType:=SqlDbType.Date).Value = outfrom
            cmd.Parameters.Add("dateto", sqlDbType:=SqlDbType.Date).Value = outto
            dt.Tables("Pricechangelog").Rows.Clear()
            da.SelectCommand = cmd
            da.Fill(dt, "Pricechangelog")

            Dim sql = "select * from ClientReg"
            dt.Tables("ClientReg").Rows.Clear()
            cmd = New SqlCommand(sql, Poscon)
            da.SelectCommand = cmd
            da.Fill(dt, "ClientReg")

            Dim report As New rptPriceChangelog
            report.SetDataSource(dt)
            frmSupplierReport.Show()
            frmSupplierReport.CrystalReportViewer1.ReportSource = report
            frmSupplierReport.CrystalReportViewer1.Refresh()
            cmd.Dispose()
            da.Dispose()
            Poscon.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub SalesReportMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class