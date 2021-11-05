Imports System.Data.SqlClient
Public Class frmCloseSalesMenu
    Dim con As New SqlConnection(My.Settings.PoSConnectionString)
    Dim cmd As SqlCommand
    Private Sub CloseSalesMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbSalesType.SelectedIndex = 0
        Timer1.Enabled = True
        con.Open()
        Dim que = "select * from ActiveSession"
        cmd = New SqlCommand(que, con)
        Dim da As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        da.Fill(table)
        If table.Rows.Count = 0 Then
        Else
            lblsessionID.Text = table.Rows(0)(0).ToString
        End If

        con.Close()
        'Dim morodate As DateTime
        'morodate = Convert.ToDateTime(lblDate.Text)
        'morodate = morodate.AddDays(1)
        'lblnextdate.Text = morodate.ToString("dd-MMM-yy")
        Me.MaximumSize = Screen.FromRectangle(Me.Bounds).WorkingArea.Size
        WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTime.Text = Date.Now.ToString("hh:mm:ss")
        lblDate.Text = Date.Now.ToString("dd/MMM/yy")



    End Sub

    Private Sub lblDate_Click(sender As Object, e As EventArgs) Handles lblDate.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

        'frmSalesMenu.Show()
        Me.Hide()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If cbSalesType.SelectedIndex = 1 Or cbSalesType.SelectedItem = "Non-Sales Session" Then
            txtCashCounted.Text = "0"
            Try
                con.Open()
                Dim query = "update SessionLedger set closedby='" + stUser.Text + "',dateclosed='" + lblDate.Text + "',Timeclosed='" + lblTime.Text + "',salesType='" + cbSalesType.Text + "',CashCounted='" + txtCashCounted.Text + "',Expenses='" + txtExpense.Text + "' where sessionid='" + lblsessionID.Text + "'"
                cmd = New SqlCommand(query, con)
                cmd.ExecuteNonQuery()
                Dim quer = "delete from ActiveSession where SessionID= " + lblsessionID.Text + " "
                cmd = New SqlCommand(quer, con)
                cmd.ExecuteNonQuery()
                con.Close()
                MsgBox("Session Closed Succesfully")
                Application.Exit()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        ElseIf cbSalesType.SelectedIndex = 0 Or cbSalesType.SelectedItem = "Non-Sales Session" Then

            If txtCashCounted.Text = "" Then
                MsgBox("Enter Cash counted")
            Else
                Try
                    con.Open()
                    Dim query = "update SessionLedger set closedby='" + stUser.Text + "',dateclosed='" + lblDate.Text + "',Timeclosed='" + lblTime.Text + "',salesType='" + cbSalesType.Text + "',CashCounted='" + txtCashCounted.Text + "',Expenses='" + txtExpense.Text + "' where sessionid='" + lblsessionID.Text + "'"
                    cmd = New SqlCommand(query, con)
                    cmd.ExecuteNonQuery()
                    Dim quer = "delete from ActiveSession where SessionID= " + lblsessionID.Text + " "
                    cmd = New SqlCommand(quer, con)
                    cmd.ExecuteNonQuery()
                    con.Close()
                    MsgBox("Session Closed Succesfully")
                    Application.Exit()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

            End If

        End If


    End Sub

    Private Sub txtCashCounted_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCashCounted.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MsgBox("This field will accept numbers only")
        End If
    End Sub

    Private Sub cbSalesType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSalesType.SelectedIndexChanged

    End Sub

    Private Sub cbSalesType_DropDownClosed(sender As Object, e As EventArgs) Handles cbSalesType.DropDownClosed
        If cbSalesType.SelectedItem = "Non-Sales Session" Or cbSalesType.SelectedIndex = 1 Then
            txtCashCounted.Enabled = False
        ElseIf cbSalesType.SelectedItem = "Sales Session" Or cbSalesType.SelectedIndex = 0 Then
            txtCashCounted.Enabled = True
        End If
    End Sub
End Class