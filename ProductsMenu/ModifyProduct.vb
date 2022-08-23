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

        reload("select * from StockMast", gvStock)
        ComboFeed("select distinct prodline from stockmast where prodline IS NOT NULL ORDER BY Prodline asc", cbProdLine, 0)
        ComboFeed("select distinct prodsize from stockmast where prodsize IS NOT NULL ORDER BY Prodsize asc", cbSize, 0)
        ComboFeed("select distinct prodcolour from stockmast where prodcolour IS NOT NULL ORDER BY Prodcolour asc", cbColour, 0)
        ComboFeed("select distinct Prodcat from Stockmast where Prodcat IS NOT NULL ORDER BY Prodcat asc", cbCat, 0)
        ComboFeed("select distinct brandname from stockmast where brandname IS NOT NULL ORDER BY brandname asc", cbBrandName, 0)
        ComboFeed("select distinct units from stockmast where units IS NOT NULL ORDER BY units asc", ComboBox1, 0)
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
            txtReoder.Text = row.Cells(13).Value.ToString()
        Catch ex As Exception
            MsgBox(ex.Message)
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
        txtReoder.Text = ""
        ComboBox1.Text = ""
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
            cbProdname.Text = row.Cells(10).Value.ToString()
            cbCat.Text = row.Cells(5).Value.ToString()
            cbSize.Text = row.Cells(3).Value.ToString()
            cbColour.Text = row.Cells(4).Value.ToString()
            cbUnique.Text = row.Cells(12).Value.ToString()
            cbBrandName.Text = row.Cells(11).Value.ToString()
            txtbaseqty.Text = row.Cells(16).Value.ToString()
            txtpacksize.Text = row.Cells(15).Value.ToString()
            txtReoder.Text = row.Cells(13).Value.ToString()
            ComboBox1.Text = row.Cells(20).Value.ToString()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Sub LoadCatPline()
        'If poscon.State = ConnectionState.Closed Then
        '    poscon.Open()
        'End If
        'cbProdLine.Items.Clear()
        'Dim query = "select * from Productline"
        'cmd = New SqlCommand(query, poscon)
        'dr = cmd.ExecuteReader
        'While dr.Read
        '    cbProdLine.Items.Add(dr(1))
        'End While
        'poscon.Close()

        'If poscon.State = ConnectionState.Closed Then
        '    poscon.Open()
        'End If
        'cbCat.Items.Clear()
        'Dim sqll = "select * from Category"
        'cmd = New SqlCommand(sqll, poscon)
        'dr = cmd.ExecuteReader
        'While dr.Read
        '    cbCat.Items.Add(dr(1))
        'End While
        'Poscon.Close()
        ComboFeed("select distinct prodline from stockmast where prodline IS NOT NULL ORDER BY Prodline asc", cbProdLine, 0)
        ComboFeed("select distinct prodsize from stockmast where prodsize IS NOT NULL ORDER BY Prodsize asc", cbSize, 0)
        ComboFeed("select distinct prodcolour from stockmast where prodcolour IS NOT NULL ORDER BY Prodcolour asc", cbColour, 0)
        ComboFeed("select distinct Prodcat from Stockmast where Prodcat IS NOT NULL ORDER BY Prodcat asc", cbCat, 0)
        ComboFeed("select distinct brandname from stockmast where brandname IS NOT NULL ORDER BY brandname asc", cbBrandName, 0)
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click

        Try

            create("update Stockmast Set ProdCode='" + txtStockCode.Text + "',Itemname= '" + cbProdname.Text + "',Prodname= '" + cbProdname.Text + "',ProdLine='" + cbProdLine.Text + "',ProdSize='" + cbSize.Text + "',ProdColour='" + cbColour.Text + "',ProdCat='" + cbCat.Text + "',BrandName='" + cbBrandName.Text + "',uniqueid='" + cbUnique.Text + "',PackSize='" + txtpacksize.Text + "',Baseqty='" + txtbaseqty.Text + "',leastqtyreminder='" & txtReoder.Text & "',units='" & ComboBox1.Text & "' where Prodcode ='" & txtStockCode.Text & "'")
            If Poscon.State = ConnectionState.Closed Then
                Poscon.Open()
            End If
            cmd = New SqlCommand("select prodcode from multishopstockmast where prodcode='" & txtStockCode.Text & "'", Poscon)
            da = New SqlDataAdapter(cmd)
            tbl = New DataTable
            da.Fill(tbl)
            If tbl.Rows.Count <> 0 Then
                create("update multishopStockmast Set ProdCode='" + txtStockCode.Text + "',ProdName= '" + cbProdname.Text + "',ProdLine='" + cbProdLine.Text + "',ProdSize='" + cbSize.Text + "',ProdColour='" + cbColour.Text + "',ProdCat='" + cbCat.Text + "',BrandName='" + cbBrandName.Text + "',uniqueid='" + cbUnique.Text + "',PackSize='" + txtpacksize.Text + "',Baseqty='" + txtbaseqty.Text + "' where Prodcode =" + txtStockCode.Text + "")
            End If
            Display()
            clear()

        Catch ex As Exception
            MsgBox(ex.Message)
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