Imports System.Data.SqlClient
Public Class frmSupplierOders
    'Dim As New SqlConnection(My.Settings.PoSConnectionString)
    Dim dr As SqlDataReader
    Dim cmd As SqlCommand
    Private Sub Display()
        Poscon.Open()
        Dim query = "select * from StockMast"
        Dim adapter As SqlDataAdapter
        Dim cmd As SqlCommand
        cmd = New SqlCommand(query, Poscon)
        adapter = New SqlDataAdapter(cmd)
        Dim builder As New SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds
        ds = New DataSet
        adapter.Fill(ds)
        gvStock.DataSource = ds.Tables(0)
        Poscon.Close()
    End Sub

    Private Sub frmOders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Display()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        MsgBox("iWont close")
        frmSalesMenu.Show()
        Me.Hide()

    End Sub

    Private Sub Guna2PictureBox1_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox1.Click
        Application.Exit()
    End Sub

    Private Sub Guna2PictureBox2_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox2.Click
        If WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Maximized
        ElseIf WindowState = FormWindowState.Maximized Then
            WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub gvStock_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles gvStock.CellClick
        Try
            Dim row As DataGridViewRow = gvStock.Rows(e.RowIndex)
            txtProdname.Text = row.Cells(1).Value.ToString()
            lblProdName.Text = row.Cells(1).Value.ToString()
            txtPrice.Text = row.Cells(7).Value.ToString()
            lblProdcode.Text = row.Cells(0).Value.ToString()
            'lblActualStock.Text = row.Cells(6).Value.ToString()
            'txtProdline.Text = row.Cells(2).Value.ToString()
            'txtCat.Text = row.Cells(5).Value.ToString()
            'txtSize.Text = row.Cells(3).Value.ToString()
            'txtColour.Text = row.Cells(4).Value.ToString()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub Search(valueTosearch As String)
        Poscon.Open()
        Dim query = "select * from StockMast where concat(ProdName,ProdCode) like '%" + valueTosearch + "%'"
        cmd = New SqlCommand(query, Poscon)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable()
        adapter.Fill(table)
        gvStock.DataSource = table


        If table.Rows.Count() > 0 Then

        Else

        End If

        Poscon.Close()
    End Sub

    Private Sub txtProdname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtProdname.KeyPress
        Search(txtProdname.Text)
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If lblProdName.Text = "" Or txtQty.Text = "" Or txtPrice.Text = "" Then
            MsgBox("Select Item or Input Quantity", vbCritical)
        Else

            For R = 0 To gvOders.RowCount - 1
                Dim itemAvailable As New Boolean
                itemAvailable = (gvOders.Rows(R).Cells(5).Value = lblProdcode.Text)
                MsgBox(itemAvailable)
                'Select Case itemAvailable
                'Case "true"
                'MsgBox(itemAvailable)
                'Case "false"
                'Dim a = Val(txtQty.Text)
                'Dim newstock As New Integer
                'Dim c = Val(lblActualStock.Text)
                'newstock = CInt(c - a)
                'gvSales.Rows.Add(lblProdName.Text, txtQty.Text, txtPrice.Text, txtAmt.Text, txtCat.Text, txtProdcode.Text, txtSize.Text, txtProdline.Text, newstock, lblRecieptNo.Text)
                'End Select

            Next


        End If

        txtProdname.Text = ""
        lblProdcode.Text = ""
        txtPrice.Text = ""
        lblProdName.Text = ""
        txtAmt.Text = ""
        txtQty.Text = ""
    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click
        frmSalesMenu.Show()
        Me.Hide()
    End Sub
End Class