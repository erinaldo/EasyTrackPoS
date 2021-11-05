Imports System.Data.SqlClient
Public Class frmStockMovement
    Dim con As New SqlConnection(My.Settings.PoSConnectionString)
    Dim cmd As New SqlCommand
    Dim adp As New SqlDataAdapter
    Dim dt As New dsInventory
    Private Sub BunifuButton3_Click(sender As Object, e As EventArgs) Handles BunifuButton3.Click
        Try
            Dim query = "select * from inventoryledger"
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            cmd = New SqlCommand(query, con)
            dt.Tables("inventoryledger").Rows.Clear()
            adp.SelectCommand = cmd
            adp.Fill(dt, "inventoryledger")

            Dim sql = "select * from ClientReg"
            dt.Tables("ClientReg").Rows.Clear()
            cmd = New SqlCommand(sql, con)
            adp.SelectCommand = cmd
            adp.Fill(dt, "ClientReg")

            Dim report As New rptInventPerItem
            report.SetDataSource(dt)
            'frmSupplierReport.Show()
            With frmSupplierReport
                .TopLevel = False
                PCreateProd.Controls.Add(frmSupplierReport)
                .BringToFront()
                .Show()
            End With
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
            Dim query = "select * from inventoryledger"
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            cmd = New SqlCommand(query, con)
            dt.Tables("inventoryledger").Rows.Clear()
            adp.SelectCommand = cmd
            adp.Fill(dt, "inventoryledger")

            Dim sql = "select * from ClientReg"
            dt.Tables("ClientReg").Rows.Clear()
            cmd = New SqlCommand(sql, con)
            adp.SelectCommand = cmd
            adp.Fill(dt, "ClientReg")

            Dim report As New rptInventPerItem
            report.SetDataSource(dt)
            'frmSupplierReport.Show()
            With frmSupplierReport
                .TopLevel = False
                PCreateProd.Controls.Add(frmSupplierReport)
                .BringToFront()
                .Show()
            End With
            frmSupplierReport.CrystalReportViewer1.ReportSource = report
            frmSupplierReport.CrystalReportViewer1.Refresh()
            cmd.Dispose()
            adp.Dispose()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

End Class