Imports System.Data.SqlClient
Public Class Login
    'Dim As New SqlConnection(My.Settings.PoSConnectionString)
    Dim dr As SqlDataReader
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter
    Dim tbl As DataTable

    Public Sub search(valuetosearch As String)
        Try
            If Poscon.State = ConnectionState.Closed Then
                Poscon.Open()
            End If
            Dim query = "select * from UserProfiles where UserID like '%" + valuetosearch + "%'"
            cmd = New SqlCommand(query, Poscon)
            da = New SqlDataAdapter(cmd)
            tbl = New DataTable()
            da.Fill(tbl)
            If tbl.Rows.Count = 0 Then
                txtPassword.Text = ""
                txtUserID.Text = ""
                txtUserID.Focus()
            Else
                lblID.Text = tbl.Rows(0)(0).ToString
                lblusername.Text = tbl.Rows(0)(1).ToString
                lblBranch.Text = tbl.Rows(0)(5).ToString
            End If
            Poscon.Close()
        Catch ex As Exception
            'MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbltime.Text = Date.Now.ToString("hh:mm:ss")
        lbldate.Text = Date.Now.ToString("dd-MMM-yy")
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Try
            If Poscon.State = ConnectionState.Closed Then
                Poscon.Open()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub txtUsername_Validated(sender As Object, e As EventArgs) Handles txtUserID.Validated
        search(txtUserID.Text)
    End Sub
    Private Sub Guna2PictureBox2_Click(sender As Object, e As EventArgs)
        If WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Maximized
        ElseIf WindowState = FormWindowState.Maximized Then
            WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub Guna2PictureBox1_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        Try
            If (txtUserID.Text = "" Or txtPassword.Text = "") Then
                MsgBox("Enter username and password")
            Else
                If Poscon.State = ConnectionState.Closed Then
                    Poscon.Open()
                End If

                Dim sql = "select * from UserProfiles where UserId= '" + txtUserID.Text + "' and Password='" + txtPassword.Text + "' "
                cmd = New SqlCommand(sql, Poscon)
                dr = cmd.ExecuteReader
                If (dr.Read = True) Then
                    Dim userlevel As Integer
                    userlevel = dr(6)
                    Select Case userlevel
                        Case "0"
                            Dim f3 As New frmMain
                            f3.Show()
                            Me.Hide()
                        Case "1"
                            Dim f2 As New frmSalesMenu
                            f2.Show()
                            Me.Hide()
                        Case Else
                            MsgBox("Contact Admin")
                    End Select
                    dr.Close()

                    If Poscon.State = ConnectionState.Closed Then
                        Poscon.Open()
                    End If
                    Dim query = "insert into Userlogs(username,UserId,LoginTime,LoginDate,Branch) values('" + lblusername.Text + "','" + txtUserID.Text + "','" + lbltime.Text + "','" + lbldate.Text + "','" + lblbranch.Text + "')"
                    cmd = New SqlCommand(query, Poscon)
                    cmd.ExecuteNonQuery()
                    Poscon.Close()
                Else
                    MsgBox("Wrong Username or Password")
                    txtPassword.Text = ""
                    Poscon.Close()
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        frmMain.stuser.Text = lblusername.Text
        frmCashierAccess.stUser.Text = lblusername.Text



    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Application.Exit()
    End Sub

    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            BunifuThinButton21_Click(Nothing, Nothing)
        End If
    End Sub
End Class