Imports System.Data.SqlClient
Public Class frmModifySupplier
    'Dim poscon As New SqlConnection(My.Settings.PoSConnectionString)
    Dim da As SqlDataAdapter
    Dim cmd As SqlCommand
    Private Sub Label2_Click(sender As Object, e As EventArgs)
        Dim f2 As New frmCreateSupplierAccount
        f2.Show()
        Me.Hide()


    End Sub
    Private Sub Display()
        If poscon.State = ConnectionState.Closed Then
            poscon.Open()
        End If
        Dim query = "select * from Supplier"
        cmd = New SqlCommand(query, poscon)
        da = New SqlDataAdapter(cmd)
        Dim tbl As New DataTable
        da.Fill(tbl)
        gvcust.DataSource = tbl
        poscon.Close()
    End Sub
    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click
        If My.Settings.DeleteCS = False Then
            MsgBox("Sorry you dont have access to this feature")
            Exit Sub
        End If
        If lblCustID.Text = "" Then
            MsgBox("Select Supplier To Edit")
            Exit Sub
        End If
        If poscon.State = ConnectionState.Closed Then
            poscon.Open()
        End If

        Dim query = ("update Supplier set SupplierName='" + txtName.Text + "', SupplierContact= '" + txtEmailAdd.Text + "',BusinessDigitalAddress= '" + txtBusDigAdd.Text + "',Location= '" + txtBussLocation.Text + "',Idtype= '" + cbCardType.Text + "' where Supplierno='" + lblCustID.Text + "'")
        Dim cmd As New SqlCommand(query, poscon)
        cmd.ExecuteNonQuery()
        MsgBox("Supplier Updated Successfully")
        poscon.Close()
        Display()

        Clear()
    End Sub

    Private Sub gvcust_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles gvcust.CellClick
        Dim row As DataGridViewRow = gvcust.Rows(e.RowIndex)
        lblCustID.Text = row.Cells(0).Value.ToString()
        txtName.Text = row.Cells(1).Value.ToString()
        txtEmailAdd.Text = row.Cells(2).Value.ToString()
        txtBusDigAdd.Text = row.Cells(3).Value.ToString()
        txtBussLocation.Text = row.Cells(4).Value.ToString()
        cbCardType.Text = row.Cells(5).Value.ToString()
        txtCardNo.Text = row.Cells(6).Value.ToString()

    End Sub

    Private Sub frmModifySupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Display()
    End Sub
    Private Sub Clear()
        lblCustID.Text = ""
        txtName.Text = ""
        txtEmailAdd.Text = ""
        txtBusDigAdd.Text = ""
        txtBussLocation.Text = ""
        cbCardType.Text = ""
        txtCardNo.Text = ""
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        If My.Settings.DeleteCS = False Then
            MsgBox("Sorry you dont have access to this feature")
            Exit Sub
        End If
        If Poscon.State = ConnectionState.Closed Then
            Poscon.Open()
        End If
        Dim query = "delete from Supplier where Supplierno='" + lblCustID.Text + "' "
        cmd = New SqlCommand(query, poscon)
        cmd.ExecuteNonQuery()
        poscon.Close()
        Clear()
        Display()

    End Sub

    Private Sub BunifuThinButton23_Click(sender As Object, e As EventArgs) Handles BunifuThinButton23.Click
        frmModifySupplier_Load(e, e)
    End Sub
End Class