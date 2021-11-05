Imports System.Data.SqlClient
Public Class frmSalesReciept
    Dim con As New SqlConnection(My.Settings.PoSConnectionString)
    Dim cmd As SqlCommand
    Dim adp As New SqlDataAdapter
    Dim dt As New dsSalesTranx
    Dim da As SqlDataAdapter
    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load
        Try
            'reciept()
            dt.EnforceConstraints = False
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If

            Dim que = "select * from recieptconfig"
            cmd = New SqlCommand(que, con)
            da = New SqlDataAdapter(cmd)
            Dim table As New DataTable
            da.Fill(table)
            Dim query = "select * from SalesTranx where recieptno='" + table.Rows(table.Rows.Count() - 1)(2).ToString + "'"
            cmd = New SqlCommand(query, con)
            adp.SelectCommand = cmd
            adp.Fill(dt, "salesTranx")

            Dim sql = "select * from ClientReg"
            cmd = New SqlCommand(sql, con)
            adp.SelectCommand = cmd
            adp.Fill(dt, "ClientReg")

            Dim report As New rptSalesReciept
            report.SetDataSource(dt)
            report.PrintToPrinter(1, True, 0, 0)
            CrystalReportViewer1.ReportSource = report
            CrystalReportViewer1.Refresh()
            cmd.Dispose()
            adp.Dispose()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub reciept()

        con.Open()
        Dim sql = "insert into Recieptconfig(Salesperson,recieptid) values('" + frmSales.Activeuser.Text + "','" + frmSales.lblRecieptNo.Text + "') "
        cmd = New SqlCommand(sql, con)
        cmd.ExecuteNonQuery()
        con.Close()

    End Sub

    Private Sub ShowConfig()
        con.Open()
        Dim que = "select * from recieptconfig"
        cmd = New SqlCommand(que, con)
        Dim da As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        da.Fill(table)
        If table.Rows.Count() = 0 Then
            'Dim reciept = "1"
        Else
            Dim index = table.Rows.Count() - 1
            Dim reciept = table.Rows(index)(0).ToString
        End If
        con.Close()
    End Sub

End Class