Imports System.Data.SqlClient
Public Class frmSessionOpening
    'Dim As New SqlConnection(My.Settings.PoSConnectionString)
    Dim cmd As SqlCommand
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim f2 As New frmSalesMenu
        f2.Show()
        Me.Hide()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTime.Text = Date.Now.ToString("hh:mm:ss")
        lblDate.Text = Date.Now.ToString("dd-MMM-yy")
    End Sub

    Private Sub frmSessionOpening_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtOpeningSalesDate.Text = Date.Now.ToString("dd-MMM-yy")
        Timer1.Enabled = True
        Me.MaximumSize = Screen.FromRectangle(Me.Bounds).WorkingArea.Size
        WindowState = FormWindowState.Maximized
        cbSessiontype.SelectedIndex = 0
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        If Poscon.State = ConnectionState.Closed Then
            Poscon.Open()
        End If
        Dim sql = "insert into Activesession values('" + tsUser.Text + "','" + txtOpeningSalesDate.Text + "','" + lblTime.Text + "','" + cbSessiontype.Text + "','" + txtShiftMembers.Text + "')"
        cmd = New SqlCommand(sql, Poscon)
        cmd.ExecuteNonQuery()
        Poscon.Close()
        MsgBox("Session Created Succesfully")
        frmSales.Show()
        Me.Hide()

        Poscon.Open()
        Dim que = "select * from ActiveSession"
        cmd = New SqlCommand(que, Poscon)
        Dim da As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        da.Fill(table)
        lblSessionID.Text = table.Rows(0)(0).ToString
        Dim query = "insert into SessionLedger(sessionId,Openedby,dateopened,Timeopened,sessionType,Sessionmembers) values('" + lblSessionID.Text + "','" + tsUser.Text + "','" + txtOpeningSalesDate.Text + "','" + lblTime.Text + "','" + cbSessiontype.Text + "','" + txtShiftMembers.Text + "')"
        cmd = New SqlCommand(query, Poscon)
        cmd.ExecuteNonQuery()
        Poscon.Close()
        Me.Hide()



    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click

        If cbSessiontype.Text = "" Then
            MsgBox("Select Session Type")
            Exit Sub
        End If
        If Poscon.State = ConnectionState.Closed Then
            Poscon.Open()
        End If
        If lblSessionID.Text = "#" Then
            Dim sql = "insert into Activesession values('" + tsUser.Text + "','" + txtOpeningSalesDate.Text + "','" + lblTime.Text + "','" + cbSessiontype.Text + "','" + txtShiftMembers.Text + "')"
            cmd = New SqlCommand(sql, Poscon)
            cmd.ExecuteNonQuery()
            Poscon.Close()
            MsgBox("Session Created Succesfully")
            'Dim f2 As New PfrmSalesMgmt
            'f2.Show()
            frmSales.Show()
            Me.Hide()

            Poscon.Open()
            Dim que = "select * from ActiveSession"
            cmd = New SqlCommand(que, Poscon)
            Dim da As New SqlDataAdapter(cmd)
            Dim table As New DataTable
            da.Fill(table)
            lblSessionID.Text = table.Rows(0)(0).ToString
            Dim query = "insert into SessionLedger(sessionId,Openedby,dateopened,Timeopened,sessionType,Sessionmembers) values('" + lblSessionID.Text + "','" + tsUser.Text + "','" + txtOpeningSalesDate.Text + "','" + lblTime.Text + "','" + cbSessiontype.Text + "','" + txtShiftMembers.Text + "')"
            cmd = New SqlCommand(query, Poscon)
            cmd.ExecuteNonQuery()
            Poscon.Close()
            Me.Hide()
        Else
            MsgBox("Active Session Already in progress", vbCritical)

        End If




    End Sub
End Class