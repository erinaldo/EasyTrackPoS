Imports System.Data.SqlClient
Public Class StockValueReportMenu
    'Dim  As New SqlConnection(My.Settings.PoSConnectionString)
    Dim cmd As New SqlCommand
    Dim adp As New SqlDataAdapter
    Dim dt As New dsStockMast
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim f2 As New InventoryReportMenu
        f2.Show()
        Me.Hide()

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        frmStockValpCat.Show()
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        frmStockValpPline.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        frmstockValOverall.Show()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Try
            Dim query = "select * from Stockmast"
            If Poscon.State = ConnectionState.Closed Then
                Poscon.Open()
            End If
            cmd = New SqlCommand(query, Poscon)
            dt.Tables("Stockmast").Rows.Clear()
            adp.SelectCommand = cmd
            adp.Fill(dt, "Stockmast")

            Dim sql = "select * from ClientReg"
            dt.Tables("ClientReg").Rows.Clear()
            cmd = New SqlCommand(sql, Poscon)
            adp.SelectCommand = cmd
            adp.Fill(dt, "ClientReg")

            Dim report As New rptStockValPCatPck
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

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Try
            Dim query = "select * from Stockmast"
            If Poscon.State = ConnectionState.Closed Then
                Poscon.Open()
            End If
            cmd = New SqlCommand(query, Poscon)
            dt.Tables("Stockmast").Rows.Clear()
            adp.SelectCommand = cmd
            adp.Fill(dt, "Stockmast")

            Dim sql = "select * from ClientReg"
            dt.Tables("ClientReg").Rows.Clear()
            cmd = New SqlCommand(sql, Poscon)
            adp.SelectCommand = cmd
            adp.Fill(dt, "ClientReg")

            Dim report As New rptStockValPBrandPck
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

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Try
            Dim query = "select * from Stockmast"
            If Poscon.State = ConnectionState.Closed Then
                Poscon.Open()
            End If
            cmd = New SqlCommand(query, Poscon)
            dt.Tables("Stockmast").Rows.Clear()
            adp.SelectCommand = cmd
            adp.Fill(dt, "Stockmast")

            Dim sql = "select * from ClientReg"
            dt.Tables("ClientReg").Rows.Clear()
            cmd = New SqlCommand(sql, Poscon)
            adp.SelectCommand = cmd
            adp.Fill(dt, "ClientReg")

            Dim report As New rptStockValOvllPck
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