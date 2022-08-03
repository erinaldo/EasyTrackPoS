Imports System.Data.SqlClient
Public Class frmCloseSalesMenu
    'Dim As New SqlConnection(My.Settings.PoSConnectionString)
    Dim cmd As SqlCommand
    Private Sub CloseSalesMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbSalesType.SelectedIndex = 0
        Timer1.Enabled = True

        Display()

        Me.MaximumSize = Screen.FromRectangle(Me.Bounds).WorkingArea.Size
        WindowState = FormWindowState.Maximized
        lblnextdate.Text = DateAdd(DateInterval.Day, 1, Date.Parse(lblDate.Text))
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTime.Text = Date.Now.ToString("hh:mm:ss")

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
                If Poscon.State = ConnectionState.Closed Then
                    Poscon.Open()
                End If
                Dim query = "update SessionLedger set closedby='" + My.Settings.ActiveUser + "',dateclosed=convert(datetime,'" + lblDate.Text + "',105),Timeclosed='" + lblTime.Text + "',salesType='" + cbSalesType.Text + "',CashCounted='" + txtCashCounted.Text + "',Expenses='" + txtExpense.Text + "',NextSessiondate=convert(datetime,'" + lblnextdate.Text + "',105) where sessionid='" + lblsessionID.Text + "'"
                cmd = New SqlCommand(query, Poscon)
                cmd.ExecuteNonQuery()
                Dim quer = "delete from ActiveSession where SessionID= " + lblsessionID.Text + " "
                cmd = New SqlCommand(quer, Poscon)
                cmd.ExecuteNonQuery()
                Poscon.Close()
                MsgBox("Session Closed Succesfully")
                PfrmSalesMgmt.Hide()
                Me.Close()
                Application.Restart()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        ElseIf cbSalesType.SelectedIndex = 0 Or cbSalesType.SelectedItem = "Non-Sales Session" Then

            If txtCashCounted.Text = "" Then
                MsgBox("Kindly Enter Cash counted")
            Else
                Try
                    If Poscon.State = ConnectionState.Closed Then
                        Poscon.Open()
                    End If
                    Dim query = "update SessionLedger set closedby='" + stUser.Text + "',dateclosed=convert(datetime,'" + lblDate.Text + "',105),Timeclosed='" + lblTime.Text + "',salesType='" + cbSalesType.Text + "',CashCounted='" + txtCashCounted.Text + "',Expenses='" + txtExpense.Text + "',NextSessiondate=convert(datetime,'" + lblnextdate.Text + "',105) where sessionid='" + lblsessionID.Text + "'"
                    cmd = New SqlCommand(query, Poscon)
                    cmd.ExecuteNonQuery()
                    Dim quer = "delete from ActiveSession where SessionID= " + lblsessionID.Text + " "
                    cmd = New SqlCommand(quer, Poscon)
                    cmd.ExecuteNonQuery()
                    Poscon.Close()
                    MsgBox("Session Closed Succesfully")
                    PfrmSalesMgmt.Hide()
                    Application.Restart()
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

    Private Sub frmCloseSalesMenu_Enter(sender As Object, e As EventArgs) Handles MyBase.Enter
        ' Dim morodate As Date
        'morodate = Convert.ToDateTime(lblDate.Text)
        ' MsgBox(lblDate.Text)
        'morodate = Date.Parse(lblDate.Text)
        lblnextdate.Text = DateAdd(DateInterval.Day, 1, Date.Parse(lblDate.Text))
    End Sub
    Private Sub Display()
        If Poscon.State = ConnectionState.Closed Then
            Poscon.Open()
        End If
        cmd = New SqlCommand("select * from ActiveSession", Poscon)
        da = New SqlDataAdapter(cmd)
        tbl = New DataTable
        da.Fill(tbl)
        If tbl.Rows.Count = 0 Then
        Else
            lblsessionID.Text = tbl.Rows(0)(0).ToString
        End If
        cmd = New SqlCommand("select convert(datetime,dateopened,103) from Sessionledger", Poscon)
        da = New SqlDataAdapter(cmd)
        tbl = New DataTable
        da.Fill(tbl)
        ' DataGridView1.DataSource = tbl
        If tbl.Rows.Count = 0 Then
        Else
            Dim index = tbl.Rows.Count - 1
            'MsgBox(Date.Parse(tbl.Rows(index)(0).ToString))
            lblDate.Text = Date.Parse(tbl.Rows(index)(0).ToString)
        End If
        Poscon.Close()
    End Sub
End Class