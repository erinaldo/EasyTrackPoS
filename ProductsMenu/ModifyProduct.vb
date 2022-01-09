Imports System.Data.SqlClient
Public Class frmModifyProduct
    'Dim poscon As New SqlConnection(My.Settings.PoSConnectionString)
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader
    Dim da As SqlDataAdapter

    Private Sub frmModifyProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.MaximumSize = Screen.FromRectangle(Me.Bounds).WorkingArea.Size
        WindowState = FormWindowState.Maximized
        Display()
        LoadCatPline()
    End Sub
    Private Sub Display()
        If poscon.State = ConnectionState.Closed Then
            poscon.Open()
        End If
        Dim query = "select * from StockMast"
        cmd = New SqlCommand(query, poscon)
        da = New SqlDataAdapter(cmd)
        Dim tbl As New DataTable
        da.Fill(tbl)
        gvStock.DataSource = tbl
        poscon.Close()


    End Sub

    Private Sub gvStock_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        Try
            Dim row As DataGridViewRow = gvStock.Rows(e.RowIndex)
            txtStockCode.Text = row.Cells(0).Value.ToString()
            cbProdLine.Text = row.Cells(2).Value.ToString()
            cbProdname.Text = row.Cells(1).Value.ToString()
            cbCat.Text = row.Cells(5).Value.ToString()
            cbSize.Text = row.Cells(3).Value.ToString()
            cbColour.Text = row.Cells(4).Value.ToString()
            cbUnique.Text = row.Cells(8).Value.ToString()
            txtbaseqty.Text = row.Cells(16).Value.ToString()
            txtpacksize.Text = row.Cells(15).Value.ToString()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)
        Dim f2 As New frmModifyProduct
        f2.Show()
        Me.Hide()
    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs)
        Dim f2 As New frmMain
        f2.Show()
        Me.Hide()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)
        Dim f2 As New frmChangePrice
        f2.Show()
        Me.Hide()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)
        Dim f2 As New frmProdCreate
        f2.Show()
        Me.Hide()
    End Sub
    Private Sub clear()
        txtStockCode.Text = ""
        cbProdname.Text = ""
        cbProdLine.Text = ""
        cbSize.Text = ""
        cbColour.Text = ""
        cbCat.Text = ""
        cbBrandName.Text = ""
        cbCat.Text = ""
        cbUnique.Text = ""
        txtbaseqty.Text = ""
        txtpacksize.Text = ""
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Try
            If poscon.State = ConnectionState.Closed Then
                poscon.Open()
            End If
            Dim query = "update Stockmast Set ProdCode='" + txtStockCode.Text + "',ProdName= '" + cbProdname.Text + "',ProdLine='" + cbProdLine.Text + "',ProdSize='" + cbSize.Text + "',ProdColour='" + cbColour.Text + "',ProdCat='" + cbCat.Text + "' where Prodcode =" + txtStockCode.Text + ""
            Dim cmd As New SqlCommand(query, poscon)
            cmd.ExecuteNonQuery()
            MsgBox("Product Updated Successfully")
            poscon.Close()
            Display()
            clear()

        Catch ex As Exception

        End Try

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

        frmDeleteProduct.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs)

        frmProdSetup.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim f2 As New frmProductManagementMenu
        f2.Show()
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

    Private Sub gvStock_CellClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles gvStock.CellClick
        Try
            Dim row As DataGridViewRow = gvStock.Rows(e.RowIndex)
            txtStockCode.Text = row.Cells(0).Value.ToString()
            cbProdLine.Text = row.Cells(2).Value.ToString()
            cbProdname.Text = row.Cells(1).Value.ToString()
            cbCat.Text = row.Cells(5).Value.ToString()
            cbSize.Text = row.Cells(3).Value.ToString()
            cbColour.Text = row.Cells(4).Value.ToString()
            cbUnique.Text = row.Cells(12).Value.ToString()
            cbBrandName.Text = row.Cells(11).Value.ToString()
            txtbaseqty.Text = row.Cells(16).Value.ToString()
            txtpacksize.Text = row.Cells(15).Value.ToString()
        Catch ex As Exception
            'MsgBox(ex.ToString)
        End Try

    End Sub
    Sub LoadCatPline()
        If poscon.State = ConnectionState.Closed Then
            poscon.Open()
        End If
        cbProdLine.Items.Clear()
        Dim query = "select * from Productline"
        cmd = New SqlCommand(query, poscon)
        dr = cmd.ExecuteReader
        While dr.Read
            cbProdLine.Items.Add(dr(1))
        End While
        poscon.Close()

        If poscon.State = ConnectionState.Closed Then
            poscon.Open()
        End If
        cbCat.Items.Clear()
        Dim sqll = "select * from Category"
        cmd = New SqlCommand(sqll, poscon)
        dr = cmd.ExecuteReader
        While dr.Read
            cbCat.Items.Add(dr(1))
        End While
        poscon.Close()
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click

        Try
            If poscon.State = ConnectionState.Closed Then
                poscon.Open()
            End If
            Dim query = "update Stockmast Set ProdCode='" + txtStockCode.Text + "',ProdName= '" + cbProdname.Text + "',ProdLine='" + cbProdLine.Text + "',ProdSize='" + cbSize.Text + "',ProdColour='" + cbColour.Text + "',ProdCat='" + cbCat.Text + "',BrandName='" + cbBrandName.Text + "',uniqueid='" + cbUnique.Text + "',PackSize='" + txtpacksize.Text + "',Baseqty='" + txtbaseqty.Text + "' where Prodcode =" + txtStockCode.Text + ""
            Dim cmd As New SqlCommand(query, poscon)
            cmd.ExecuteNonQuery()
            'MsgBox("Product Updated Successfully")
            poscon.Close()
            Display()
            clear()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub cbSearchItem_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbSearchItem.KeyPress
        Search(cbSearchItem.Text)
    End Sub
    Public Sub Search(valueTosearch As String)
        Try
            If poscon.State = ConnectionState.Closed Then
                poscon.Open()
            End If
            Dim query = "select * from StockMast where concat(ProdName,ProdCode) like '%" + valueTosearch + "%'"
            cmd = New SqlCommand(query, poscon)
            da = New SqlDataAdapter(cmd)
            Dim table As New DataTable()
            da.Fill(table)
            gvStock.DataSource = table
            poscon.Close()

        Catch ex As Exception

        End Try

    End Sub

    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click
        frmModifyProduct_Load(e, e)
    End Sub

    Private Sub cbSearchItem_TextChanged(sender As Object, e As EventArgs) Handles cbSearchItem.TextChanged
        Search(cbSearchItem.Text)
    End Sub
End Class