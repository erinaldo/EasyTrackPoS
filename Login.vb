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
            Dim query = "select * from UserProfiles where UserID = '" + valuetosearch + "'"
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
                lblBranch.Text = tbl.Rows(0)(7).ToString
            End If
            Poscon.Close()
        Catch ex As Exception
            '
            '
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
            MsgBox(ex.Message)
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
                            My.Settings.ActiveUser = lblusername.Text
                            'My.Settings.Save()
                        Case "1"
                            Dim f2 As New frmSalesMenu
                            f2.Show()
                            Me.Hide()
                            My.Settings.ActiveUser = lblusername.Text
                           ' My.Settings.Save()
                        Case "2"
                            Dim f2 As New frmMultishop
                            f2.Show()
                            Me.Hide()
                            My.Settings.ActiveUser = lblusername.Text
                            ' My.Settings.Save()
                        Case Else
                            MsgBox("Contact Admin")
                    End Select
                    dr.Close()
                    create("insert into Userlogs(username,UserId,LoginTime,LoginDate,Branch) values('" + lblusername.Text + "','" + txtUserID.Text + "','" + lbltime.Text + "','" + lbldate.Text + "','" + lblBranch.Text + "')")
                    My.Settings.ActiveUser = lblusername.Text
                    Reset()
                    loadsettings()

                    'My.Settings.Save()
                Else
                    MsgBox("Wrong Username or Password")
                    txtPassword.Text = ""
                    Poscon.Close()
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        frmMain.stuser.Text = lblusername.Text
        frmCashierAccess.stUser.Text = lblusername.Text



    End Sub
    Public Sub loadsettings()
        Try
            If Poscon.State = ConnectionState.Closed Then
                Poscon.Open()
            End If
            Dim query = "select * from settings where username='" & txtUserID.Text & "'"
            cmd = New SqlCommand(query, Poscon)
            dr = cmd.ExecuteReader
            While dr.Read
                'main menu
                'My.Settings.Productmenu = dr.Item("productmenu").ToString
                'My.Settings.invmenu = dr.Item("inventorymenu").ToString
                'My.Settings.customermenu = dr.Item("customermenu").ToString
                'My.Settings.suppliermenu = dr.Item("suppliermenu").ToString
                'My.Settings.salesmenu = dr.Item("salesmenu").ToString
                'My.Settings.setupmenu = dr.Item("setupmenu").ToString
                'My.Settings.reportmenu = dr.Item("reportmenu").ToString
                'My.Settings.accountsmenu = dr.Item("accountmenu").ToString

                'product management
                My.Settings.createprod = dr.Item("createprod").ToString
                My.Settings.modprod = dr.Item("modprod").ToString
                My.Settings.delprod = dr.Item("delprod").ToString

                'Sales management
                My.Settings.opensession = dr.Item("opensession").ToString
                My.Settings.sell = dr.Item("sell").ToString
                My.Settings.cancellation = dr.Item("cancellation").ToString
                My.Settings.packtrans = dr.Item("packtrans").ToString
                My.Settings.proforma = dr.Item("proforma").ToString
                My.Settings.DelierySale = dr.Item("deliverysale").ToString

                My.Settings.closesession = dr.Item("closesession").ToString

                'customer/supplier management
                My.Settings.CreateCS = dr.Item("CreateCS").ToString
                My.Settings.DeleteCS = dr.Item("DeleteCS").ToString
                My.Settings.RecieveCS = dr.Item("RecieveCS").ToString

                My.Settings.Save()
            End While

            Poscon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
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