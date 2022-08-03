Imports System.Data.SqlClient
Public Class frmReportMenu
    Dim dt As New dsTotalStock
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim f As New frmMain
        f.Show()
        Me.Hide()

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Dim f2 As New InventoryReportMenu
        f2.Show()
        Me.Hide()

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Dim f2 As New SalesReportMenu
        f2.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2PictureBox1_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    Private Sub Guna2PictureBox2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        frmMain.Show()
        Me.Hide()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Dim f2 As New frmProdReports
        f2.Show()

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Dim f2 As New frmSessionLedger
        f2.Show()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

        frmAdjustStockReportMenu.Show()
        Me.Hide()

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        Dim f2 As New frmSupplierReportMenu
        f2.Show()
        Me.Hide()

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        frmCustomerReportMenu.Show()
        Me.Hide()

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        Try

            If Poscon.State = ConnectionState.Closed Then
                Poscon.Open()
            End If
            Dim query = "select q1.itemname as itemname,sum(q1.prodqty) as shopqty,sum(q2.qtytobecollected) as tobelcollectedqty
                        from stockmast as q1
                        inner join tobecollected as q2
                        on q1.prodcode=q2.itemcode
                        group by q1.itemname
                        "
            cmd = New SqlCommand(query, Poscon)
            dt.Tables("TotalStock").Rows.Clear()
            da.SelectCommand = cmd
            da.Fill(dt, "TotalStock")

            'Dim sql = "select * from ClientReg"
            'dt.Tables("ClientReg").Rows.Clear()
            'cmd = New SqlCommand(sql, Poscon)
            'da.SelectCommand = cmd
            'da.Fill(dt, "ClientReg")

            Dim report As New rptTotalStock
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