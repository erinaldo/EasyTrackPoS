Imports System.Data.SqlClient
Public Class frmSalesMenu
    Dim con As New SqlConnection(My.Settings.PoSConnectionString)
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
        cmd = New SqlCommand(que, con)
        da = New SqlDataAdapter(cmd)
        Dim table As New DataTable
        da.Fill(table)
        If table.Rows.Count() = 0 Then
            MsgBox("NO Active Session. Please open a new session to continue", vbCritical)
        Else
            Dim f2 As New frmSales
            f2.Show()

        End If

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Dim que = "select * from ActiveSession"
        cmd = New SqlCommand(que, con)
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
        cmd = New SqlCommand(que, con)
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
        frmOders.Show()
        Me.Hide()
    End Sub
End Class