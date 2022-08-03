Imports System.Data.SqlClient
Public Class frmMessagingSetup
    'Dim As New SqlConnection(My.Settings.PoSConnectionString)
    Dim tbl As DataTable
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter

    Private Sub frmMessagingSetup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        search()
    End Sub
    Public Sub search()
        txtsmsapikey.Enabled = False
        Try
            'Dim arrimage As Byte
            If Poscon.State = ConnectionState.Closed Then
                Poscon.Open()
            End If
            Dim query = "select * from Emailconfig"
            cmd = New SqlCommand(query, Poscon)
            da = New SqlDataAdapter(cmd)
            tbl = New DataTable()
            da.Fill(tbl)
            If tbl.Rows.Count() = 0 Then
            Else
                txtemailaddress.Text = tbl.Rows(0)(1).ToString()
                txtemailheader.Text = tbl.Rows(0)(2).ToString()
                txtmessage.Text = tbl.Rows(0)(3).ToString()

                txtsmsapikey.Text = tbl.Rows(0)(6).ToString()
                txtsmsid.Text = tbl.Rows(0)(4).ToString()
                txtsmsmessage.Text = tbl.Rows(0)(5).ToString()
            End If

            Poscon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        If Poscon.State = ConnectionState.Closed Then
            Poscon.Open()
        End If
        Dim sql = "update emailconfig set fromemail='" + txtemailaddress.Text + "',Mailsubject='" + txtemailheader.Text + "',Body='" + txtmessage.Text + "',fromsms='" + txtsmsid.Text + "',smsbody='" + txtsmsmessage.Text + "',smsapikey='" + txtsmsapikey.Text + "'"
        With cmd
            .Connection = Poscon
            .CommandText = sql
            'EXECUTE THE DATA
            result = cmd.ExecuteNonQuery
            'CHECKING IF THE DATA HAS EXECUTED OR NOT AND THEN THE POP UP MESSAGE WILL APPEAR
            If result = 0 Then
                MessageBox.Show("Data is failed to insert.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show("Data has been inserted in the database.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End With
        Poscon.Close()
        search()
    End Sub
End Class