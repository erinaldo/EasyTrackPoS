Imports System.Data.SqlClient
Public Class PfrmSalesMgmt

    'Dim poscon As New SqlConnection(My.Settings.PoSConnectionString)
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter

    Private Sub PfrmSalesMgmt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MaximumSize = Screen.FromRectangle(Me.Bounds).WorkingArea.Size
        WindowState = FormWindowState.Maximized
        'settings()
    End Sub

    Private Sub btnOders_Click(sender As Object, e As EventArgs)
        Dim f2 As New frmSupplierOders
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
        Try
            If Poscon.State = ConnectionState.Closed Then
                Poscon.Open()
            End If
            Dim que = "select * from ActiveSession"
            cmd = New SqlCommand(que, Poscon)
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
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub BunifuButton2_Click(sender As Object, e As EventArgs) Handles btnsell.Click
        Try
            If Poscon.State = ConnectionState.Closed Then
                Poscon.Open()
            End If
            Dim que = "select * from ActiveSession"
            cmd = New SqlCommand(que, Poscon)
            da = New SqlDataAdapter(cmd)
            Dim table As New DataTable
            da.Fill(table)
            If table.Rows.Count() = 0 Then
                MsgBox("NO Active Session. Please open a new session to continue", vbCritical)
            Else
                'Dim f2 As New frmTouchSale
                frmSales.Show()

            End If
        Catch ex As Exception
            MsgBox(ex.Message, ex.ToString)
        End Try

    End Sub

    Private Sub BunifuButton4_Click(sender As Object, e As EventArgs) Handles btnchangepricesel.Click
        Dim f2 As New frmChangePrice
        With f2
            .TopLevel = False
            PCreateProd.Controls.Add(f2)
            .BringToFront()
            .Show()

        End With
    End Sub

    Private Sub BunifuButton5_Click(sender As Object, e As EventArgs) Handles btncanc.Click
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

    Private Sub BunifuButton7_Click(sender As Object, e As EventArgs) Handles btnclosesession.Click
        Try
            If Poscon.State = ConnectionState.Closed Then
                Poscon.Open()
            End If
            Dim que = "select * from ActiveSession"
            cmd = New SqlCommand(que, Poscon)
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
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub BunifuButton3_Click(sender As Object, e As EventArgs) Handles btntobecol.Click
        Dim f2 As New frmToCollected
        With f2
            .TopLevel = False
            PCreateProd.Controls.Add(f2)
            .BringToFront()
            .Show()

        End With
    End Sub

    Private Sub BunifuButton1_Click_1(sender As Object, e As EventArgs) Handles btntobecoldel.Click
        Dim f2 As New frmTobeCollectedDelivery
        With f2
            .TopLevel = False
            PCreateProd.Controls.Add(f2)
            .BringToFront()
            .Show()

        End With
    End Sub

    Private Sub BunifuButton8_Click(sender As Object, e As EventArgs) Handles btnpacktrans.Click
        Dim f2 As New frmPackSingles
        With f2
            .TopLevel = False
            PCreateProd.Controls.Add(f2)
            .BringToFront()
            .Show()

        End With
    End Sub

    Private Sub BunifuButton9_Click(sender As Object, e As EventArgs) Handles btnproforma.Click
        Dim f2 As New frmProForma
        f2.Show()
    End Sub
    Private Sub settings()
        btnOpenSession.Enabled = My.Settings.opensession
        btnsell.Enabled = My.Settings.sell
        'btnchangepricesel.Enabled = My.Settings.changeprice
        btncanc.Enabled = My.Settings.cancellation
        btntobecol.Enabled = My.Settings.DelierySale
        btntobecoldel.Enabled = My.Settings.DelierySale
        btnclosesession.Enabled = My.Settings.closesession
        btnproforma.Enabled = My.Settings.proforma
        btnpacktrans.Enabled = My.Settings.packtrans
    End Sub
End Class