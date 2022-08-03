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
            MsgBox(ex.Message)
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
                For Each row As DataGridViewRow In gvUserProfiles.Rows
                    If txtUserId.Text = row.Cells(2).Value Then
                        MsgBox("User ID aready exist. Kindly enter a unique one")
                        txtUserId.Focus()
                        Exit Sub
                    End If
                    If txtName.Text = row.Cells(1).Value Then
                        MsgBox("User name aready exist. Kindly enter a unique one")
                        txtName.Focus()
                        Exit Sub
                    End If
                Next
                create("insert into UserProfiles(username,userid,password,usertype,usergroup,usergroupid,branch) values('" & txtName.Text & "','" + txtUserId.Text + "','" + txtUserpassword.Text + "','" & cbUsertype.Text & "','" & cbUsergroup.Text & "','" & cbUsertype.SelectedIndex.ToString & "','" + ComboBox1.Text + "')")
                create("insert into settings (username,createprod,modprod,delprod,changeprice,opensession,sell,cancellation,proforma,DeliverySale,closesession,createCS,DeleteCS,RecieveCS)
                values('" & txtUserId.Text & "','" & ckcreateprod.Checked & "','" & ckmodprod.Checked & "','" & ckdelprod.Checked & "','" & ckchangeprice.Checked & "','" & ckopensession.Checked & "','" & cksell.Checked & "','" & ckcancsale.Checked & "','" & ckproforma.Checked & "','" & CheckBox1.Checked & "','" & ckclosesess.Checked & "','" & ckcreatecs.Checked & "','" & ckmodcs.Checked & "','" & ckrecievecs.Checked & "')")
                Display()
            Catch ex As Exception
                MsgBox(ex.Message)
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
            accesslevels(row.Cells(2).Value.ToString())
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub accesslevels(uname As String)

        Try
            If Poscon.State = ConnectionState.Closed Then
                Poscon.Open()
            End If
            Dim query = "select * from settings where username='" & uname & "'"
            cmd = New SqlCommand(query, Poscon)
            dr = cmd.ExecuteReader
            While dr.Read


                ''main menu
                'My.Settings.Productmenu = dr.Item("productmenu").ToString
                'My.Settings.invmenu = dr.Item("inventorymenu").ToString
                'My.Settings.customermenu = dr.Item("customermenu").ToString
                'My.Settings.suppliermenu = dr.Item("suppliermenu").ToString
                'My.Settings.salesmenu = dr.Item("salesmenu").ToString
                'My.Settings.setupmenu = dr.Item("setupmenu").ToString
                'My.Settings.reportmenu = dr.Item("reportmenu").ToString
                'My.Settings.accountsmenu = dr.Item("accountmenu").ToString

                'product management
                ckcreateprod.Checked = dr.Item("createprod").ToString
                ckmodprod.Checked = dr.Item("modprod").ToString
                    ckdelprod.Checked = dr.Item("delprod").ToString
                    ckchangeprice.Checked = dr.Item("delprod").ToString

                    'Sales management
                    ckopensession.Checked = dr.Item("opensession").ToString
                    cksell.Checked = dr.Item("sell").ToString
                    ckcancsale.Checked = dr.Item("cancellation").ToString
                'My.Settings.packtrans = dr.Item("packtrans").ToString
                'My.Settings.proforma = dr.Item("proforma").ToString
                'My.Settings.tobecoldel = dr.Item("tobecoldel").ToString
                ckclosesess.Checked = dr.Item("closesession").ToString

                'customer/supplier management
                My.Settings.CreateCS = dr.Item("CreateCS").ToString
                My.Settings.RecieveCS = dr.Item("DeleteCS").ToString
                My.Settings.DeleteCS = dr.Item("RecieveCS").ToString






            End While


            Poscon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
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
                'If Poscon.State = ConnectionState.Closed Then
                '    Poscon.Open()
                'End If
                'Dim query = "delete from Userprofiles where id= " + lbluserid.Text + " "
                'Dim cmd As New SqlCommand(query, Poscon)
                'cmd.ExecuteNonQuery()
                'MsgBox("User Deleted Successfully")
                'Poscon.Close()
                create("delete from Userprofiles where id= " & lbluserid.Text & " ")
                Display()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub lblUsername_DoubleClick(sender As Object, e As EventArgs) Handles lblUsername.DoubleClick
        BunifuThinButton21_Click(Nothing, Nothing)
    End Sub

    Private Sub cbUsertype_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbUsertype.SelectedIndexChanged
        If cbUsertype.SelectedIndex = 1 Then
            GroupBox1.Enabled = False
        Else
            GroupBox1.Enabled = Enabled

        End If
    End Sub
End Class