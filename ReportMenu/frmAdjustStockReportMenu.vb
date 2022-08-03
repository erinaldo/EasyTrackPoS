Imports System.Data.SqlClient
Public Class frmAdjustStockReportMenu
    Dim dt As New dsMultishop
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Try

            If Poscon.State = ConnectionState.Closed Then
                Poscon.Open()
            End If
            Dim query = "select * from multishopstockmast"
            cmd = New SqlCommand(query, Poscon)
            dt.Tables("multishopstockmast").Rows.Clear()
            da.SelectCommand = cmd
            da.Fill(dt, "multishopstockmast")

            'Dim sql = "select * from ClientReg"
            'dt.Tables("ClientReg").Rows.Clear()
            'cmd = New SqlCommand(sql, Poscon)
            'da.SelectCommand = cmd
            'da.Fill(dt, "ClientReg")

            Dim report As New rptMultishopStockBals
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
End Class