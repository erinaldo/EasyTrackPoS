Imports System.Data.SqlClient
Public Class frmSalesMenu
    'Dim poscon As New SqlConnection(My.Settings.PoSConnectionString)
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim f2 As New frmSalesManagement
        f2.Show()
        Me.Hide()

    End Sub

    Private Sub SalesMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tsuser.Text = frmSalesManagement.tsUser.Text

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

        Dim que = "select * from ActiveSession"
        cmd = New SqlCommand(que, poscon)
        da = New SqlDataAdapter(cmd)
        tbl = New DataTable
        da.Fill(tbl)
        If tbl.Rows.Count() = 0 Then
            MsgBox("NO Active Session. Please open a new session to continue", vbCritical)
        Else
            If Poscon.State = ConnectionState.Closed Then
                Poscon.Open()
            End If
            cmd = New SqlCommand("select * from userlogs", Poscon)
            da = New SqlDataAdapter(cmd)
            tbl = New DataTable
            da.Fill(tbl)
            If tbl.Rows.Count = 0 Then
            Else
                Dim index = tbl.Rows.Count() - 1
                If tbl.Rows(index)(5).ToString = "" Then
                    Dim f2 As New frmSales
                    f2.Show()
                Else
                    Dim f3 As New frmMultishop
                    f3.Show()
                End If
            End If
            'cmd = New SqlCommand("Select * from userlogs where ", Poscon)
            'dr = cmd.ExecuteReader()
            'While dr.Read


            'End While


        End If

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Dim que = "select * from ActiveSession"
        cmd = New SqlCommand(que, poscon)
        da = New SqlDataAdapter(cmd)
        Dim table As New DataTable
        da.Fill(table)
        If table.Rows.Count() = 0 Then
            MsgBox("No Active Session in progress", vbCritical)
        Else
            frmCloseSalesMenu.Show()
            'Me.Hide
        End If



    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Dim que = "select * from ActiveSession"
        cmd = New SqlCommand(que, poscon)
        da = New SqlDataAdapter(cmd)
        Dim table As New DataTable
        da.Fill(table)
        If table.Rows.Count() = 0 Then
            frmSessionOpening.Show()
            'Me.Hide()
        Else
            MsgBox("Active Session in progress, Please close current session to open a new one", vbCritical)
        End If

    End Sub

    Private Sub Guna2PictureBox1_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox1.Click
        Dim f2 As New Login
        f2.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2PictureBox2_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox2.Click
        If WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Maximized
        ElseIf WindowState = FormWindowState.Maximized Then
            WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        frmSupplierOders.Show()
        Me.Hide()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Me.Hide()
        Dim f1 As New Login
        f1.Show()
    End Sub
End Class