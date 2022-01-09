Imports System.Data.SqlClient
Public Class frmPriceBand
    'Dim  New SqlConnection(My.Settings.PoSConnectionString)
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader
    Dim da As SqlDataAdapter
    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click
        If Val(txtFromQty.Text) > Val(txtToQty.Text) Then
            MsgBox("From Band Qty Greater than To band Qty", vbCritical)
            Exit Sub
        End If
        If txtBandPrice.Text = "" Then
            MsgBox("Enter Band price", vbCritical)
            Exit Sub
        End If
        If txtBandPrice.Text = "" Or txtFromQty.Text = "" Or txtToQty.Text = "" Or txtBandName.Text = "" Then
            MsgBox("Fill All Fields", vbCritical)
            Exit Sub
        End If
        If Poscon.State = ConnectionState.Closed Then
            Poscon.Open()
        End If

        Dim sql = "select * from PriceBand where PriceBand= '" + txtBandName.Text + "' "
        cmd = New SqlCommand(sql, Poscon)
        dr = cmd.ExecuteReader
        If txtBandName.Text = "" Then
            MsgBox("Enter New PriceBand")
            Poscon.Close()
        ElseIf (dr.Read = True) Then
            MsgBox("PriceBand Already Exists, Enter a new Band")
            Poscon.Close()
            Clear()
        Else
            Try
                If Poscon.State = ConnectionState.Closed Then
                    Poscon.Open()
                End If
                Dim query = "Insert into PriceBand values('" + lblBandCode.Text + "','" + cbItemName.Text + "','" + txtBandName.Text + "','" + txtFromQty.Text + "','" + txtToQty.Text + "','" + txtBandPrice.Text + "')"
                cmd = New SqlCommand(query, Poscon)
                cmd.ExecuteNonQuery()
                MsgBox("Succesfully Created")
                Poscon.Close()


            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If
        ShowBand()
        dr.Close()
        Clear()
    End Sub
    Private Sub ShowBand()
        If Poscon.State = ConnectionState.Closed Then
            Poscon.Open()
        End If

        Dim query = "select * from PriceBand"
        cmd = New SqlCommand(query, Poscon)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable()
        adapter.Fill(tbl)
        gvPriceBand.DataSource = tbl
        Poscon.Close()
    End Sub
    Private Sub ShowBandItem()
        If Poscon.State = ConnectionState.Closed Then
            Poscon.Open()
        End If

        Dim query = "select * from PriceBand where ItemName='" + cbItemName.Text + "' "
        cmd = New SqlCommand(query, Poscon)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable()
        adapter.Fill(tbl)
        gvPriceBand.DataSource = tbl
        Poscon.Close()
    End Sub

    Private Sub frmPriceBand_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowBand()
        If Poscon.State = ConnectionState.Closed Then
            Poscon.Open()
        End If
        cbItemName.Items.Clear()
        Dim sql = "select * from Stockmast"
        cmd = New SqlCommand(sql, Poscon)
        da = New SqlDataAdapter(cmd)
        Dim tbl As New DataTable()
        da.Fill(tbl)

        dr = cmd.ExecuteReader
        While dr.Read
            cbItemName.Items.Add(dr(1))

        End While
        Poscon.Close()
        Me.MaximumSize = Screen.FromRectangle(Me.Bounds).WorkingArea.Size
        WindowState = FormWindowState.Maximized
    End Sub

    Private Sub txtFromQty_Validated(sender As Object, e As EventArgs) Handles txtFromQty.Validated
        txtBandName.Text = cbItemName.SelectedItem + txtFromQty.Text + txtToQty.Text
    End Sub

    Private Sub txtToQty_Validated(sender As Object, e As EventArgs) Handles txtToQty.Validated
        txtBandName.Text = cbItemName.SelectedItem + txtFromQty.Text + txtToQty.Text
    End Sub

    Private Sub cbItemName_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbItemName.SelectionChangeCommitted
        BandDet()
        If cbItemName.Text = "" Then
            ShowBand()
        Else
            ShowBandItem()
        End If

    End Sub
    Private Sub BandDet()
        If Poscon.State = ConnectionState.Closed Then
            Poscon.Open()
        End If
        Dim sql = "select * from Stockmast Where Prodname='" + cbItemName.Text + "'"
        cmd = New SqlCommand(sql, Poscon)
        da = New SqlDataAdapter(cmd)
        Dim tbl As New DataTable()
        da.Fill(tbl)

        If tbl.Rows.Count = 0 Then
        Else
            lblBandCode.Text = tbl.Rows(0)(0).ToString
        End If
    End Sub

    Private Sub cbItemName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbItemName.SelectedIndexChanged
        BandDet()
        If cbItemName.Text = "" Then
            ShowBand()
        Else
            ShowBandItem()
            Exit Sub
        End If
        BandDet()
    End Sub

    Private Sub gvPriceBand_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles gvPriceBand.CellClick
        Try
            Dim row As DataGridViewRow = gvPriceBand.Rows(e.RowIndex)
            txtBandName.Text = row.Cells(2).Value.ToString()
            txtBandPrice.Text = row.Cells(5).Value.ToString()
            txtFromQty.Text = row.Cells(3).Value.ToString()
            txtToQty.Text = row.Cells(4).Value.ToString()
            lblBandCode.Text = row.Cells(0).Value.ToString()
            cbItemName.Text = row.Cells(1).Value.ToString()
        Catch ex As Exception
            'MsgBox(ex.ToString)
        End Try
    End Sub
    Sub Clear()
        lblBandCode.Text = ""
        txtBandName.Text = ""
        txtBandPrice.Text = ""
        txtFromQty.Text = ""
        txtToQty.Text = ""

    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        If Poscon.State = ConnectionState.Closed Then
            Poscon.Open()
        End If

        Dim sql = "delete from PriceBand where PriceBand= '" + txtBandName.Text + "' "
        cmd = New SqlCommand(sql, Poscon)
        cmd.ExecuteNonQuery()
        ShowBand()
        Poscon.Close()
        Clear()

    End Sub

    Private Sub BunifuThinButton23_Click(sender As Object, e As EventArgs) Handles BunifuThinButton23.Click
        frmPriceBand_Load(e, e)
    End Sub

    Private Sub cbItemName_TextUpdate(sender As Object, e As EventArgs) Handles cbItemName.TextUpdate
        If cbItemName.Text = "" Then
            BandDet()
            ShowBand()
        Else
            ShowBandItem()

        End If
    End Sub

    Private Sub txtBandPrice_Enter(sender As Object, e As EventArgs) Handles txtBandPrice.Enter
        txtBandName.Text = cbItemName.SelectedItem + txtFromQty.Text + txtToQty.Text
        BandDet()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class