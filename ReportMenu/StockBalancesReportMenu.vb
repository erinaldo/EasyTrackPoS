Imports System.Data.SqlClient
Public Class StockBalancesReportMenu
    'Dim As New SqlConnection(My.Settings.PoSConnectionString)
    Dim cmd As New SqlCommand
    Dim adp As New SqlDataAdapter
    Dim dt As New dsInventory
    Dim ds As New dscustomer
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim f2 As New InventoryReportMenu
        f2.Show()
        Me.Hide()

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        ' Dim f2 As New frmStockRptPerCat

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
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

        frmStockBalpSize.Show()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Try
            frmTakingStock.Show()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        frmStockBalbyColour.Show()
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        'frmStockBalpPline.Show()
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

            Dim report As New rptStockBalpBrandpck
            report.SetDataSource(dt)
            frmSupplierReport.Show()
            frmSupplierReport.CrystalReportViewer1.ReportSource = report
            frmSupplierReport.CrystalReportViewer1.Refresh()
            cmd.Dispose()
            adp.Dispose()
            Poscon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        'frmStockBalZero.Show()
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
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        'frmStockBalPositive.Show()
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
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        frmStockBalNegative.Show()
    End Sub

    Private Sub Guna2PictureBox1_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        'frmStockMovement.Show()
        Try

            If Poscon.State = ConnectionState.Closed Then
                Poscon.Open()
            End If
            Dim query = "select * from inventoryledger"
            cmd = New SqlCommand(query, Poscon)
            dt.Tables("inventoryledger").Rows.Clear()
            adp.SelectCommand = cmd
            adp.Fill(dt, "inventoryledger")

            Dim sql = "select * from ClientReg"
            dt.Tables("ClientReg").Rows.Clear()
            cmd = New SqlCommand(sql, Poscon)
            adp.SelectCommand = cmd
            adp.Fill(dt, "ClientReg")

            Dim report As New rptInventPerItem
            report.SetDataSource(dt)
            frmSupplierReport.Show()
            frmSupplierReport.CrystalReportViewer1.ReportSource = report
            frmSupplierReport.CrystalReportViewer1.Refresh()
            cmd.Dispose()
            adp.Dispose()
            Poscon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click
        Try

            If Poscon.State = ConnectionState.Closed Then
                Poscon.Open()
            End If
            Dim query = "select * from inventoryledger"
            cmd = New SqlCommand(query, Poscon)
            dt.Tables("inventoryledger").Rows.Clear()
            adp.SelectCommand = cmd
            adp.Fill(dt, "inventoryledger")

            'Dim sql = "select * from ClientReg"
            'dt.Tables("ClientReg").Rows.Clear()
            'cmd = New SqlCommand(sql, poscon)
            'adp.SelectCommand = cmd
            'adp.Fill(dt, "ClientReg")

            Dim report As New rptInventLedgerPerItem
            report.SetDataSource(dt)
            frmSupplierReport.Show()
            frmSupplierReport.CrystalReportViewer1.ReportSource = report
            frmSupplierReport.CrystalReportViewer1.Refresh()
            cmd.Dispose()
            adp.Dispose()
            Poscon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click
        Try

            If Poscon.State = ConnectionState.Closed Then
                Poscon.Open()
            End If
            Dim query = "select * from Stockmast where prodqty<=leastqtyreminder"
            cmd = New SqlCommand(query, Poscon)
            dt.Tables("Stockmast").Rows.Clear()
            adp.SelectCommand = cmd
            adp.Fill(dt, "Stockmast")

            'Dim sql = "select * from ClientReg"
            'dt.Tables("ClientReg").Rows.Clear()
            'cmd = New SqlCommand(sql, poscon)
            'adp.SelectCommand = cmd
            'adp.Fill(dt, "ClientReg")

            Dim report As New rptStockChecks
            report.SetDataSource(dt)
            frmSupplierReport.Show()
            frmSupplierReport.CrystalReportViewer1.ReportSource = report
            frmSupplierReport.CrystalReportViewer1.Refresh()
            cmd.Dispose()
            adp.Dispose()
            Poscon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class