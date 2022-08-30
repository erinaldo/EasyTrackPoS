Imports System.Data.SqlClient

Public Class frmWarehouseReportMenu
    Dim dt As New dsInventory
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        frmReportMenu.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles BunifuButton1.Click
        Try

            If Poscon.State = ConnectionState.Closed Then
                Poscon.Open()
            End If
            Dim query = "select * from whsestockmast"
            cmd = New SqlCommand(query, Poscon)
            da.SelectCommand = cmd
            dt.Tables("whsestockmast").Rows.Clear()
            da.Fill(dt, "whsestockmast")

            Dim sql = "select * from ClientReg"
            cmd = New SqlCommand(sql, Poscon)
            da.SelectCommand = cmd
            dt.Tables("clientreg").Rows.Clear()
            da.Fill(dt, "ClientReg")

            Dim report As New rptStockBalpBrandWHSE
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

    Private Sub frmWarehouseReportMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnOpenSession_Click(sender As Object, e As EventArgs) Handles btnOpenSession.Click
        Try

            If Poscon.State = ConnectionState.Closed Then
                Poscon.Open()
            End If
            Dim query = "select * from whseinventoryledger"
            cmd = New SqlCommand(query, Poscon)
            da.SelectCommand = cmd
            dt.Tables("whseinventoryledger").Rows.Clear()
            da.Fill(dt, "whseinventoryledger")

            Dim sql = "select * from ClientReg"
            cmd = New SqlCommand(sql, Poscon)
            da.SelectCommand = cmd
            dt.Tables("clientreg").Rows.Clear()
            da.Fill(dt, "ClientReg")

            Dim report As New rptStockMovementpItemWHSE
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

            If Poscon.State = ConnectionState.Closed Then
                Poscon.Open()
            End If
            Dim query = "select * from whserecievestock"
            cmd = New SqlCommand(query, Poscon)
            da.SelectCommand = cmd
            dt.Tables("whserecievestock").Rows.Clear()
            da.Fill(dt, "whserecievestock")

            Dim sql = "select * from ClientReg"
            cmd = New SqlCommand(sql, Poscon)
            da.SelectCommand = cmd
            dt.Tables("clientreg").Rows.Clear()
            da.Fill(dt, "ClientReg")

            Dim report As New rptRecieveStockWHSE
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

            If Poscon.State = ConnectionState.Closed Then
                Poscon.Open()
            End If
            Dim query = "select * from whseissuestock"
            cmd = New SqlCommand(query, Poscon)
            da.SelectCommand = cmd
            dt.Tables("whseissuestock").Rows.Clear()
            da.Fill(dt, "whseissuestock")

            Dim sql = "select * from ClientReg"
            cmd = New SqlCommand(sql, Poscon)
            da.SelectCommand = cmd
            dt.Tables("clientreg").Rows.Clear()
            da.Fill(dt, "ClientReg")

            Dim report As New rptStockIssuedWHSE
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