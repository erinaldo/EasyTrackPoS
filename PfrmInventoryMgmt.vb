Imports System.Data.SqlClient
Public Class PfrmInventoryMgmt
    'Dim As New SqlConnection(My.Settings.PoSConnectionString)
    Dim cmd As New SqlCommand
    Dim adp As New SqlDataAdapter
    Dim dt As New dscustomer
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BunifuButton3_Click(sender As Object, e As EventArgs) Handles BunifuButton3.Click
        Dim f2 As New frmRecieveGoods
        With f2
            .TopLevel = False
            PCreateProd.Controls.Add(f2)
            .BringToFront()
            .Show()

        End With
    End Sub

    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles BunifuButton1.Click
        Dim f2 As New frmAdjustStock
        With f2
            .TopLevel = False
            PCreateProd.Controls.Add(f2)
            .BringToFront()
            .Show()

        End With
    End Sub

    Private Sub BunifuButton2_Click(sender As Object, e As EventArgs) Handles BunifuButton2.Click
        frmMain.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuButton4_Click(sender As Object, e As EventArgs) Handles BunifuButton4.Click
        Dim f2 As New frmRetailIssueing
        With f2
            .TopLevel = False
            PCreateProd.Controls.Add(f2)
            .BringToFront()
            .Show()

        End With
    End Sub

    Private Sub PfrmInventoryMgmt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MaximumSize = Screen.FromRectangle(Me.Bounds).WorkingArea.Size
        WindowState = FormWindowState.Maximized
    End Sub

    Private Sub BunifuButton5_Click(sender As Object, e As EventArgs) Handles BunifuButton5.Click
        Try
            Dim query = "select * from issuestock"
            Poscon.Open()
            cmd = New SqlCommand(query, Poscon)
            dt.Tables("issuestock").Rows.Clear()
            adp.SelectCommand = cmd
            adp.Fill(dt, "issuestock")

            Dim sql = "select * from ClientReg"
            dt.Tables("ClientReg").Rows.Clear()
            cmd = New SqlCommand(sql, Poscon)
            adp.SelectCommand = cmd
            adp.Fill(dt, "ClientReg")

            Dim report As New rptCustomerInvoicesPerDate
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

    Private Sub BunifuButton6_Click(sender As Object, e As EventArgs) Handles BunifuButton6.Click
        Try
            Dim query = "select * from issuestock"
            Poscon.Open()
            cmd = New SqlCommand(query, Poscon)
            dt.Tables("issuestock").Rows.Clear()
            adp.SelectCommand = cmd
            adp.Fill(dt, "issuestock")

            Dim sql = "select * from ClientReg"
            dt.Tables("ClientReg").Rows.Clear()
            cmd = New SqlCommand(sql, Poscon)
            adp.SelectCommand = cmd
            adp.Fill(dt, "ClientReg")

            Dim report As New rptInvoicesPerCustomer
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

    Private Sub BunifuButton7_Click(sender As Object, e As EventArgs) Handles BunifuButton7.Click
        Dim f2 As New frmMultishop
        With f2
            .TopLevel = False
            PCreateProd.Controls.Add(f2)
            .BringToFront()
            .Show()

        End With
    End Sub

    Private Sub BunifuButton8_Click(sender As Object, e As EventArgs) Handles BunifuButton8.Click
        Dim f2 As New frmCreateOder
        With f2
            '.TopLevel = False
            PCreateProd.Controls.Add(f2)
            .BringToFront()
            .Show()
        End With
    End Sub
End Class