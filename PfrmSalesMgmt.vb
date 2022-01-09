Imports System.Data.SqlClient
Public Class PfrmSalesMgmt

    'Dim poscon As New SqlConnection(My.Settings.PoSConnectionString)
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter

    Private Sub PfrmSalesMgmt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MaximumSize = Screen.FromRectangle(Me.Bounds).WorkingArea.Size
        WindowState = FormWindowState.Maximized
    End Sub

    Private Sub btnOders_Click(sender As Object, e As EventArgs)
        Dim f2 As New frmOders
        With f2
            .TopLevel = False
            PCreateProd.Controls.Add(f2)
            .BringToFront()
            .Show()

        End With
    End Sub

    Private Sub btnCloseSession_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Label2_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles btnOpenSession.Click
        Dim que = "select * from ActiveSession"
        cmd = New SqlCommand(que, poscon)
        da = New SqlDataAdapter(cmd)
        Dim table As New DataTable
        da.Fill(table)
        If table.Rows.Count() = 0 Then
            Dim f2 As New frmSessionOpening
            With f2
                .TopLevel = False
                PCreateProd.Controls.Add(f2)
                .BringToFront()
                .Show()

            End With
        Else
            MsgBox("Active Session in progress, Please close current session to open a new one", vbCritical)
        End If
    End Sub

    Private Sub BunifuButton2_Click(sender As Object, e As EventArgs) Handles BunifuButton2.Click
        Dim que = "select * from ActiveSession"
        cmd = New SqlCommand(que, poscon)
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

    Private Sub BunifuButton4_Click(sender As Object, e As EventArgs) Handles BunifuButton4.Click
        Dim f2 As New frmChangePrice
        With f2
            .TopLevel = False
            PCreateProd.Controls.Add(f2)
            .BringToFront()
            .Show()

        End With
    End Sub

    Private Sub BunifuButton5_Click(sender As Object, e As EventArgs) Handles BunifuButton5.Click
        Dim f2 As New frmSalesCancelation
        With f2
            .TopLevel = False
            PCreateProd.Controls.Add(f2)
            .BringToFront()
            .Show()

        End With
    End Sub

    Private Sub BunifuButton6_Click(sender As Object, e As EventArgs) Handles BunifuButton6.Click
        frmMain.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuButton7_Click(sender As Object, e As EventArgs) Handles BunifuButton7.Click
        Dim que = "select * from ActiveSession"
        cmd = New SqlCommand(que, poscon)
        da = New SqlDataAdapter(cmd)
        Dim table As New DataTable
        da.Fill(table)
        If table.Rows.Count() = 0 Then
            MsgBox("No Active Session in progress", vbCritical)
        Else
            Dim f2 As New frmCloseSalesMenu
            With f2
                .TopLevel = False
                PCreateProd.Controls.Add(f2)
                .BringToFront()
                .Show()

            End With
        End If

    End Sub

    Private Sub BunifuButton3_Click(sender As Object, e As EventArgs) Handles BunifuButton3.Click
        Dim f2 As New frmToCollected
        With f2
            .TopLevel = False
            PCreateProd.Controls.Add(f2)
            .BringToFront()
            .Show()

        End With
    End Sub

    Private Sub BunifuButton1_Click_1(sender As Object, e As EventArgs) Handles BunifuButton1.Click
        Dim f2 As New frmTobeCollectedDelivery
        With f2
            .TopLevel = False
            PCreateProd.Controls.Add(f2)
            .BringToFront()
            .Show()

        End With
    End Sub
End Class