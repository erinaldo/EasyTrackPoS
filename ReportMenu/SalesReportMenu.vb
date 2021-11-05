Imports System.Data.SqlClient
Public Class SalesReportMenu
    Dim con As New SqlConnection(My.Settings.PoSConnectionString)
    Dim cmd As New SqlCommand
    Dim da As New SqlDataAdapter
    Dim dt As New dsSalesTranx
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim f2 As New frmReportMenu
        f2.Show()
        Me.Hide()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Try
            Dim query = "select * from salestranx"
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            cmd = New SqlCommand(query, con)
            dt.Tables("salestranx").Rows.Clear()
            da.SelectCommand = cmd
            da.Fill(dt, "salestranx")

            'Dim sql = "select * from ClientReg"
            'dt.Tables("ClientReg").Rows.Clear()
            'cmd = New SqlCommand(sql, con)
            'da.SelectCommand = cmd
            'da.Fill(dt, "ClientReg")

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
        Try
            Dim query = "select * from salestranx"
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            cmd = New SqlCommand(query, con)
            dt.Tables("ClientReg").Rows.Clear()
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