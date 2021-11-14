Imports System.Data.SqlClient
Imports System.Globalization
Public Class SalesReportMenu
    Dim con As New SqlConnection(My.Settings.PoSConnectionString)
    Dim cmd As New SqlCommand
    Dim da As New SqlDataAdapter
    Dim dt As New dsSalesTranx
    Dim outto As Date
    Dim outfrom As Date

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim f2 As New frmReportMenu
        f2.Show()
        Me.Hide()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        DateTime.TryParseExact(dpDatefrom.Value, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, outfrom)
        DateTime.TryParseExact(dpdateto.Value, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, outto)
        Try
            Dim query = "select * from salestranx where datesold between @datefrom and @dateto"
            cmd = New SqlCommand(query, con)
            cmd.Parameters.Add("datefrom", sqlDbType:=SqlDbType.Date).Value = outfrom
            cmd.Parameters.Add("dateto", sqlDbType:=SqlDbType.Date).Value = outto
            dt.Tables("salestranx").Rows.Clear()
            da.SelectCommand = cmd
            da.Fill(dt, "salestranx")

            Dim sql = "select * from ClientReg"
            dt.Tables("ClientReg").Rows.Clear()
            cmd = New SqlCommand(sql, con)
            da.SelectCommand = cmd
            da.Fill(dt, "ClientReg")

            Dim report As New rptSalesPerDate
            report.SetDataSource(dt)
            frmSupplierReport.Show()
            frmSupplierReport.CrystalReportViewer1.ReportSource = report
            frmSupplierReport.CrystalReportViewer1.Refresh()
            cmd.Dispose()
            da.Dispose()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        DateTime.TryParseExact(dpDatefrom.Value, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, outfrom)
        DateTime.TryParseExact(dpdateto.Value, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, outto)
        Try
            Dim query = "select * from salestranx where datesold between @datefrom and @dateto"
            cmd = New SqlCommand(query, con)
            cmd.Parameters.Add("datefrom", sqlDbType:=SqlDbType.Date).Value = outfrom
            cmd.Parameters.Add("dateto", sqlDbType:=SqlDbType.Date).Value = outto
            dt.Tables("salestranx").Rows.Clear()
            da.SelectCommand = cmd
            da.Fill(dt, "salestranx")

            Dim sql = "select * from ClientReg"
            dt.Tables("ClientReg").Rows.Clear()
            cmd = New SqlCommand(sql, con)
            da.SelectCommand = cmd
            da.Fill(dt, "ClientReg")

            Dim report As New rptSalesperCashier
            report.SetDataSource(dt)
            frmSupplierReport.Show()
            frmSupplierReport.CrystalReportViewer1.ReportSource = report
            frmSupplierReport.CrystalReportViewer1.Refresh()
            cmd.Dispose()
            da.Dispose()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class