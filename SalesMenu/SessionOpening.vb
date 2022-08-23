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
        lblDate.Text = Date.Now.ToString("dd/MM/yyyy")
    End Sub

    Private Sub frmSessionOpening_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' txtOpeningSalesDate.Text = Date.Now.ToString("dd-MMM-yy")
        Display()
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

        If Poscon.State = ConnectionState.Closed Then
            Poscon.Open()
        End If
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
        If Date.Parse(txtOpeningSalesDate.Text) <> Date.Parse(lblDate.Text) Then
            MsgBox("Date Conflict. Kindly adjust Computer Date")
            Exit Sub
        End If
        If cbSessiontype.Text = "" Then
            MsgBox("Select Session Type")
            Exit Sub
        End If
        If Poscon.State = ConnectionState.Closed Then
            Poscon.Open()
        End If
        If lblSessionID.Text = "#" Then
            Dim sql = "insert into Activesession values('" + tsUser.Text + "',convert(datetime,'" + txtOpeningSalesDate.Text + "',105),'" + lblTime.Text + "','" + cbSessiontype.Text + "','" + txtShiftMembers.Text + "')"
            cmd = New SqlCommand(sql, Poscon)
            cmd.ExecuteNonQuery()
            Poscon.Close()
            MsgBox("Session Created Succesfully")
            Dim f2 As New frmSales
            'f2.Show()
            f2.Show()
            Me.Hide()

            If Poscon.State = ConnectionState.Closed Then
                Poscon.Open()
            End If
            Dim que = "select * from ActiveSession"
            cmd = New SqlCommand(que, Poscon)
            Dim da As New SqlDataAdapter(cmd)
            Dim table As New DataTable
            da.Fill(table)
            lblSessionID.Text = table.Rows(0)(0).ToString
            'Dim query = "insert into SessionLedger(sessionId,Openedby,dateopened,Timeopened,sessionType,Sessionmembers) values('" + lblSessionID.Text + "','" + My.Settings.ActiveUser + "',convert(datetime,'" + txtOpeningSalesDate.Text + "',105),'" + lblTime.Text + "','" + cbSessiontype.Text + "','" + txtShiftMembers.Text + "')"
            'cmd = New SqlCommand(query, Poscon)
            'cmd.ExecuteNonQuery()
            'Poscon.Close()
            create("insert into SessionLedger(sessionId,Openedby,dateopened,Timeopened,sessionType,Sessionmembers) values('" + lblSessionID.Text + "','" + My.Settings.ActiveUser + "',convert(datetime,'" + txtOpeningSalesDate.Text + "',105),'" + lblTime.Text + "','" + cbSessiontype.Text + "','" + txtShiftMembers.Text + "')")
            Me.Hide()
        Else
            MsgBox("Active Session Already in progress", vbCritical)

        End If

    End Sub
    Private Sub Display()
        cmd = New SqlCommand("select nextsessiondate from Sessionledger", Poscon)
        da = New SqlDataAdapter(cmd)
        tbl = New DataTable
        da.Fill(tbl)
        DataGridView1.DataSource = tbl
        If tbl.Rows.Count = 0 Then

            txtOpeningSalesDate.Text = Date.Now.ToString("dd/MM/yyyy")
            'MsgBox(tbl.Rows(0)(0).ToString)

        Else
                Dim Index = tbl.Rows.Count - 1
            'MsgBox(tbl.Rows(Index)(0).ToString)
            txtOpeningSalesDate.Text = Date.Parse(tbl.Rows(Index)(0).ToString)
            Label5.Text = Date.Parse(tbl.Rows(Index)(0).ToString)
        End If
        Poscon.Close()
    End Sub

    Private Sub frmSessionOpening_Enter(sender As Object, e As EventArgs) Handles MyBase.Enter
        Dim ask As MsgBoxResult
        ask = MsgBox("Kindly make sure your Computers date is correct before opening this session. Do you wish to proceed?", MsgBoxStyle.YesNo, "")
        If ask = MsgBoxResult.Yes Then
            Display()
        End If
    End Sub
End Class