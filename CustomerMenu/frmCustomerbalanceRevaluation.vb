﻿Imports System.Data.SqlClient
Public Class frmCustomerbalanceRevaluation

    Public Sub search(valuetosearch As String)
        Try
            If Poscon.State = ConnectionState.Closed Then
                Poscon.Open()
            End If
            Dim query = "select * from customer where concat(customername,emailaddress) = '" + valuetosearch + "'"
            cmd = New SqlCommand(query, Poscon)
            da = New SqlDataAdapter(cmd)
            tbl = New DataTable()
            da.Fill(tbl)
            If tbl.Rows.Count() = 0 Then
            Else
                lblCustBal.Text = tbl.Rows(0)(10).ToString
                lblcustid.Text = tbl.Rows(0)(0).ToString()
                Dim dblValue As Double = Val(lblCustBal.Text)

                ' lblCustBal.Text = dblValue.ToString("N", CultureInfo.InvariantCulture)

            End If

            Poscon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub frmCustomerbalanceRevaluation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboFeed("select customername from customer", cbCustName, 0)
    End Sub

    Private Sub cbCustName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCustName.SelectedIndexChanged
        search(cbCustName.Text)
    End Sub

    Private Sub txtAmtPaid_TextChanged(sender As Object, e As EventArgs) Handles txtAmtPaid.TextChanged
        lblnewbalance.Text = Val(lblCustBal.Text) + Val(txtAmtPaid.Text)

    End Sub
    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        If My.Settings.CustBalReEva = False Then
            MsgBox("Sorry you are do not have access this feature")
            Exit Sub
        End If
        If txtAmtPaid.Text = "" Then
            MsgBox("Kindly Enter Difference")
            Exit Sub
        End If
        If cbCustName.SelectedIndex = -1 Then
            MsgBox("Kindly select a customer")
            Exit Sub
        End If
        updates("update Customer set CurrentBalance = '" + lblnewbalance.Text + "' where customerno ='" & lblcustid.Text & "'")
        insertd("insert into customerledger (customername,Oldbal,narration,newbal,Creditrecieved,daterecieved,customerno) 
        values ( '" + cbCustName.Text + "','" & lblCustBal.Text & "','" + txtNarration.Text + "','" & lblnewbalance.Text & "','" + txtAmtPaid.Text + "','" + txtdatepaid.Text + "','" + lblcustid.Text + "')")
        clear()
    End Sub
    Public Sub clear()
        txtAmtPaid.Text = ""
        txtNarration.Text = ""
        cbCustName.SelectedIndex = -1
        lblCustBal.Text = 0
    End Sub
End Class