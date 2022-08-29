Imports System.Data.SqlClient
Public Class frmCreateSupplierAccount
    ' Dim  As New SqlConnection(My.Settings.PoSConnectionString)
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader
    Dim da As SqlDataAdapter
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)
        Dim f2 As New frmSuppliersMenu
        f2.Show()
        Me.Hide()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)
        Dim f2 As New frmModifySupplier
        f2.Show()
        Me.Hide()

    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        If My.Settings.CreateCS = False Then
            MsgBox("Sorry you dont have access to this feature")
            Exit Sub
        End If
        If Poscon.State = ConnectionState.Closed Then
            Poscon.Open()
        End If

        Dim sql = "select * from Supplier where IDnumber= '" + txtIdCardNo.Text + "' "
        cmd = New SqlCommand(sql, Poscon)
        dr = cmd.ExecuteReader
        If txtIdCardNo.Text = "" Then
            MsgBox("Enter New Supplier ID")
            Poscon.Close()
        ElseIf (dr.Read = True) Then
            MsgBox("Supplier Already Exists, Enter a new Supplier")
            Poscon.Close()

        Else
            Try
                If Poscon.State = ConnectionState.Closed Then
                    Poscon.Open()
                End If
                Dim query = "insert into supplier values('" + txtName.Text + "','" + txtEmailAddress.Text + "','" + txtBusDigAddress.Text + "','" + txtBusLocation.Text + "','" + cbIDCardType.Text + "','" + txtIdCardNo.Text + "','" + txtCustBal.Text + "')"
                cmd = New SqlCommand(query, Poscon)
                cmd.ExecuteNonQuery()
                MsgBox("Supplier Saved Succesfully")
                Clear()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
        Display()
    End Sub
    Private Sub Display()
        If Poscon.State = ConnectionState.Closed Then
            Poscon.Open()
        End If

        Dim query = "select * from Supplier"
        cmd = New SqlCommand(query, Poscon)
        Dim tbl As New DataTable()
        da = New SqlDataAdapter(cmd)
        da.Fill(tbl)
        gvStockMast.DataSource = tbl

        'lblProdCount.Text = gvStockMast.Rows.Count()
        Poscon.Close()
    End Sub
    Sub Clear()
        txtBusDigAddress.Text = ""
        txtBusLocation.Text = ""
        txtCustBal.Text = ""
        txtEmailAddress.Text = ""
        txtIdCardNo.Text = ""
        txtName.Text = ""

    End Sub

    Private Sub frmCreateSupplierAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Display()
    End Sub

    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click
        frmCreateSupplierAccount_Load(e, e)
    End Sub
End Class