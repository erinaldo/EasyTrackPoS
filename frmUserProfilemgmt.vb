Imports System.Data.SqlClient
Public Class frmUserProfilemgmt
    'Dim As New SqlConnection(My.Settings.PoSConnectionString)
    Dim cmd As SqlCommand
    Dim adapter As SqlDataAdapter
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Try
            If Poscon.State = ConnectionState.Closed Then
                Poscon.Open()
            End If
            Poscon.Open()
            Dim query = "insert into UserProfiles values('" & txtName.Text & "','" + txtUserId.Text + "','" + txtUserpassword.Text + "','" & cbUsertype.Text & "','" & cbUsergroup.Text & "','" & cbUsergroup.SelectedIndex.ToString & "')"
            cmd = New SqlCommand(query, Poscon)
            cmd.ExecuteNonQuery()
            MsgBox("User Saved Successfully")
            Poscon.Close()
            Display()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub Display()

        'Poscon.Open()
        'Dim query = "select id,Username,userid,usergroup,usertype,usergroupid from UserProfiles"

        'cmd = New SqlCommand(query, Poscon)
        'adapter = New SqlDataAdapter(cmd)
        'Dim builder As New SqlCommandBuilder
        'builder = New SqlCommandBuilder(adapter)
        'Dim ds
        'ds = New DataSet
        'adapter.Fill(ds)
        'gvUserProfiles.DataSource = ds.Tables(0)
        'Poscon.Close()
        reload("select id,Username,userid,usergroup,usertype,usergroupid from UserProfiles", gvUserProfiles)
        ComboFeed("select Customername from Customer where Customertype='" + "Branch Customer" + "'", ComboBox1, 0)
    End Sub
    Private Sub Clear()
        txtName.Text = ""
        txtUserId.Text = ""
        txtUserpassword.Text = ""

    End Sub
    Private Sub frmUserProfilemgmt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Display()
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        If txtUserId.Text = "" Or txtUserpassword.Text = "" Or txtName.Text = "" Then
            MsgBox("Fill all fields")
        Else
            Try
                If Poscon.State = ConnectionState.Closed Then
                    Poscon.Open()
                End If
                Dim query = "insert into UserProfiles(username,userid,password,usertype,usergroup,usergroupid,branch) values('" & txtName.Text & "','" + txtUserId.Text + "','" + txtUserpassword.Text + "','" & cbUsertype.Text & "','" & cbUsergroup.Text & "','" & cbUsergroup.SelectedIndex.ToString & "','" + ComboBox1.Text + "')"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Poscon)
                cmd.ExecuteNonQuery()
                MsgBox("User Saved Successfully")
                Poscon.Close()
                Display()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
        Clear()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        frmsystemSetup.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2PictureBox1_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox1.Click
        Application.Exit()
    End Sub

    Private Sub gvUserProfiles_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles gvUserProfiles.CellClick
        Try
            Dim row As DataGridViewRow = gvUserProfiles.Rows(e.RowIndex)
            lblUsername.Text = row.Cells(1).Value.ToString()
            lbluserid.Text = row.Cells(0).Value.ToString()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click
        If lbluserid.Text = "#" Then
            MsgBox("Select a User")
            Exit Sub
        End If
        If lblUsername.Text = "" Or lbluserid.Text = "" Then
            MsgBox("Select a User")
        Else
            Try
                If Poscon.State = ConnectionState.Closed Then
                    Poscon.Open()
                End If
                Dim query = "delete from Userprofiles where id= " + lbluserid.Text + " "
                Dim cmd As New SqlCommand(query, Poscon)
                cmd.ExecuteNonQuery()
                MsgBox("User Deleted Successfully")
                Poscon.Close()
                Display()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub lblUsername_DoubleClick(sender As Object, e As EventArgs) Handles lblUsername.DoubleClick
        BunifuThinButton21_Click(Nothing, Nothing)
    End Sub
End Class