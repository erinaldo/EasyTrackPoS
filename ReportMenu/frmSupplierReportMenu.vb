Imports System.Data.SqlClient
Public Class frmSupplierReportMenu
    Dim con As New SqlConnection(My.Settings.PoSConnectionString)
    Dim cmd As New SqlCommand
    Dim adp As New SqlDataAdapter
    Dim dt As New dsSalesTranx
    Private Sub btnOpenSession_Click(sender As Object, e As EventArgs) Handles btnOpenSession.Click

        Try
            Dim query = "select * from salestranx"
            con.Open()
            cmd = New SqlCommand(query, con)
            dt.Tables("salestranx").Rows.Clear()
            adp.SelectCommand = cmd
            adp.Fill(dt, "salestranx")

            Dim sql = "select * from ClientReg"
            dt.Tables("ClientReg").Rows.Clear()
            cmd = New SqlCommand(sql, con)
            adp.SelectCommand = cmd
            adp.Fill(dt, "ClientReg")

            Dim report As New rptSalesPerDate
            report.SetDataSource(dt)
            frmSupplierReport.Show()
            frmSupplierReport.CrystalReportViewer1.ReportSource = report
            frmSupplierReport.CrystalReportViewer1.Refresh()
            cmd.Dispose()
            adp.Dispose()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles BunifuButton1.Click


        Try

            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            Dim query = "select * from RecieveStock"
            cmd = New SqlCommand(query, con)
            adp.SelectCommand = cmd
            adp.Fill(dt, "recieveStock")

            Dim sql = "select * from ClientReg"
            cmd = New SqlCommand(sql, con)
            adp.SelectCommand = cmd
            adp.Fill(dt, "ClientReg")
            Dim report As New rptSupplierGoodsPerInvoice
            report.SetDataSource(dt)
            frmSupplierReport.Show()
            frmSupplierReport.CrystalReportViewer1.ReportSource = report
            frmSupplierReport.CrystalReportViewer1.Refresh()
            cmd.Dispose()
            adp.Dispose()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub BunifuButton2_Click(sender As Object, e As EventArgs) Handles BunifuButton2.Click
        Try
            Dim query = "select * from Supplier"
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            cmd = New SqlCommand(query, con)
            adp.SelectCommand = cmd
            adp.Fill(dt, "Supplier")

            Dim sql = "select * from ClientReg"
            cmd = New SqlCommand(sql, con)
            adp.SelectCommand = cmd
            adp.Fill(dt, "ClientReg")
            Dim report As New rptSupplierBalance
            report.SetDataSource(dt)
            frmSupplierReport.Show()
            frmSupplierReport.CrystalReportViewer1.ReportSource = report
            frmSupplierReport.CrystalReportViewer1.Refresh()
            cmd.Dispose()
            adp.Dispose()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub BunifuButton3_Click(sender As Object, e As EventArgs) Handles BunifuButton3.Click
        Try
            Dim query = "select * from Supplier"
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            cmd = New SqlCommand(query, con)
            adp.SelectCommand = cmd
            adp.Fill(dt, "Supplier")

            Dim sql = "select * from ClientReg"
            cmd = New SqlCommand(sql, con)
            adp.SelectCommand = cmd
            adp.Fill(dt, "ClientReg")
            Dim report As New rptSupplierInfo
            report.SetDataSource(dt)
            frmSupplierReport.Show()
            frmSupplierReport.CrystalReportViewer1.ReportSource = report
            frmSupplierReport.CrystalReportViewer1.Refresh()
            cmd.Dispose()
            adp.Dispose()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        frmReportMenu.Show()
        Me.Hide()
    End Sub
End Class