Imports System.Data.SqlClient
Public Class frmProdCreate
    'Dim As New SqlConnection(My.Settings.PoSConnectionString)
    Dim dr As SqlDataReader
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter
    Dim tbl As DataTable
    Dim builder As SqlCommandBuilder
    Private isformdragged As Boolean = False
    Private mousedownX As Integer
    Private mousedowny As Integer


    Private Sub Label15_Click(sender As Object, e As EventArgs)
        frmMain.Show()
        Me.Hide()

    End Sub
    Private Sub clear()
        ' cbCat.Text = ""
        cbColour.Text = ""
        ' cbProdLine.Text = ""
        txtProdName.Clear()
        cbSize.Text = ""
        cbUnique.Text = ""
        txtQty.Clear()
        txtRPrice.Clear()
        txtStockCode.Clear()
        txtWPrice.Clear()
        txtItemName.Text = ""
        cbbrandName.Text = ""


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        If txtStockCode.Text = "" Or txtRPrice.Text = "" Or cbProdLine.SelectedIndex = -1 Or txtProdName.Text = "" Or cbCat.SelectedIndex = -1 Then
            MsgBox("Fill all important fields")
        Else

            Try
                If Poscon.State = ConnectionState.Closed Then
                    Poscon.Open()
                End If
                Dim query = "insert into stockmast(Prodcode,prodname,prodline,prodsize,prodcolour,prodcat,prodqty,retailprice,wholesaleprice,itemname,brandname,uniqueid,leastqtyremainder,packsize,baseqty,packprice) values('" & txtStockCode.Text & "','" + txtProdName.Text + "','" + cbProdLine.Text + "','" & cbSize.Text & "','" & cbColour.Text & "','" & cbCat.Text & "','" & txtQty.Text & "','" & txtRPrice.Text & "','" & txtWPrice.Text & "','" & txtItemName.Text & "','" & cbbrandName.Text & "')"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Poscon)
                cmd.ExecuteNonQuery()
                MsgBox("Product Saved Successfully")
                Poscon.Close()


            Catch ex As Exception

            End Try

        End If
        Display()
    End Sub
    Sub ItemName()

        If Val(txtbaseqty.Text) * Val(txtpacksize.Text) > 1 Then
            txtProdName.Text = txtItemName.Text + " " + cbColour.Text + " " + cbUnique.Text + " " + cbSize.Text + " " + txtpacksize.Text + "x" + "" + txtbaseqty.Text
            Exit Sub
        End If
        txtProdName.Text = txtItemName.Text + " " + cbColour.Text + " " + cbUnique.Text + " " + cbSize.Text
    End Sub

    Private Sub ComboBox7_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbItemCodeType.SelectedIndexChanged
        If cbItemCodeType.SelectedIndex = 0 Then
            txtStockCode.Text = ""
        Else
            txtStockCode.Text = lblProdline.Text + lblcat.Text + lblProdCount.Text
        End If
    End Sub
    Public Sub Search(valuetosearch As String)
        Try
            If Poscon.State = ConnectionState.Closed Then
                Poscon.Open()
            End If
            Dim query = "select * from category where category like '%" + valuetosearch + "%'"
            cmd = New SqlCommand(query, Poscon)
            Dim adapter As New SqlDataAdapter(cmd)
            Dim tbl As New DataTable()
            adapter.Fill(tbl)
            If cbCat.Text = "" Then
                txtStockCode.Text = ""
                lblcat.Text = ""
            Else
                lblcat.Text = tbl.Rows(0)(0).ToString
            End If

            Poscon.Close()

        Catch ex As Exception
            'MsgBox(ex.ToString)
        End Try


    End Sub
    Public Sub Search1(valuetosearch As String)
        Try
            If Poscon.State = ConnectionState.Closed Then
                Poscon.Open()
            End If

            Dim query = "select * from productline where productline like '%" + valuetosearch + "%'"
            cmd = New SqlCommand(query, Poscon)
            Dim adapter As New SqlDataAdapter(cmd)
            Dim tbl As New DataTable()
            adapter.Fill(tbl)
            If cbProdLine.Text = "" Then
                txtStockCode.Text = ""
                lblProdline.Text = ""
            Else
                lblProdline.Text = tbl.Rows(0)(0).ToString
            End If

            Poscon.Close()

        Catch ex As Exception
            'MsgBox(ex.ToString)
        End Try


    End Sub
    Private Sub Display()

        reload("select * from StockMast", gvStockMastBf)
        ComboFeed("select distinct prodline from stockmast where prodline IS NOT NULL", cbProdLine, 0)
        ComboFeed("select distinct prodsize from stockmast where prodsize IS NOT NULL", cbSize, 0)
        ComboFeed("select distinct prodcolour from stockmast where prodcolour IS NOT NULL", cbColour, 0)
        ComboFeed("select distinct prodcat from stockmast where prodcat IS NOT NULL", cbCat, 0)
        ComboFeed("select distinct brandname from stockmast where brandname IS NOT NULL", cbbrandName, 0)

        lblProdCount.Text = gvStockMastBf.Rows.Count()

    End Sub
    Private Sub ProductManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Display()
        clear()
        cbItemCodeType.SelectedIndex = 1
    End Sub

    Private Sub cbUnique_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbUnique.SelectedIndexChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)
        Dim f2 As New frmDeleteProduct
        f2.Show()
        Me.Hide()


    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)
        Dim f2 As New frmChangePrice
        f2.Show()
        Me.Hide()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)
        Dim Form As New frmModifyProduct
        Form.Show()
        Me.Hide()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label18_Click(sender As Object, e As EventArgs)
        Dim f2 As New frmProdSetup
        f2.Show()
        Me.Hide()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

        frmProductManagementMenu.Show()
        Me.Hide()

    End Sub

    Private Sub cbCat_DropDownClosed(sender As Object, e As EventArgs) Handles cbCat.DropDownClosed
        If cbItemCodeType.SelectedIndex = 0 Then
            txtStockCode.Text = ""
        Else
            txtStockCode.Text = lblProdline.Text + lblcat.Text + lblProdCount.Text
        End If
    End Sub

    Private Sub cbCat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCat.SelectedIndexChanged
        ' Search(cbCat.Text)
    End Sub

    Private Sub cbProdLine_DropDownClosed(sender As Object, e As EventArgs) Handles cbProdLine.DropDownClosed
        If cbItemCodeType.SelectedIndex = 0 Then
            txtStockCode.Text = ""
        Else
            txtStockCode.Text = lblProdline.Text + lblcat.Text + lblProdCount.Text
        End If
    End Sub

    Private Sub cbProdLine_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbProdLine.SelectedIndexChanged
        '  Search1(cbProdLine.Text)
    End Sub

    Private Sub txtRPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRPrice.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MsgBox("This field will accept numbers only")
        End If
    End Sub

    Private Sub txtWPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtWPrice.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MsgBox("This field will accept numbers only")
        End If
    End Sub

    Private Sub txtQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQty.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MsgBox("This field will accept numbers only")
        End If
    End Sub

    Private Sub txtStockCode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtStockCode.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MsgBox("This field will accept numbers only")
        End If
    End Sub

    Private Sub cbProdLine_Validated(sender As Object, e As EventArgs) Handles cbProdLine.Validated
        Search1(cbProdLine.Text)
    End Sub

    Private Sub Guna2PictureBox1_Click(sender As Object, e As EventArgs) 
        Application.Exit()
    End Sub

    Private Sub Guna2PictureBox2_Click(sender As Object, e As EventArgs) 
        If WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Maximized
        ElseIf WindowState = FormWindowState.Maximized Then
            WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click

        If txtStockCode.Text = "" Or cbProdLine.SelectedIndex = -1 Or txtProdName.Text = "" Or cbCat.SelectedIndex = -1 Then
            MsgBox("Fill all important fields")
            Exit Sub
        Else
            If Poscon.State = ConnectionState.Closed Then
                Poscon.Open()
            End If

            Dim qu = "select * from Stockmast where ProdName= '" + txtProdName.Text + "' and ItemName='" + txtItemName.Text + "' and ProdCat='" + cbCat.Text + "' "
            cmd = New SqlCommand(qu, Poscon)
            dr = cmd.ExecuteReader
            If (dr.Read = True) Then
                MsgBox("Item Name already exists")
                dr.Close()
                Poscon.Close()
                cbItemCodeType.SelectedIndex = 0
                Exit Sub
            End If

            Try
                dr.Close()

                If Poscon.State = ConnectionState.Closed Then
                    Poscon.Open()
                End If

                Dim sql = "select * from StockMast where ProdCode like '%" + txtStockCode.Text + "%'"
                cmd = New SqlCommand(sql, Poscon)
                da = New SqlDataAdapter(cmd)
                tbl = New DataTable()
                da.Fill(tbl)
                ' If (txtItemName.Text + " " + cbColour.Text + " " + cbUnique.Text + " " + cbSize.Text) = table.Rows(0)(1).ToString Then
                'MsgBox("Item Name Alredy exists")

                'Display()
                'clear()
                'Exit Sub
                'End If
                If tbl.Rows.Count() = 0 Then

                    create("insert into stockmast(prodcode,prodname,prodline,prodsize,prodcolour,prodcat,prodqty,retailprice,wholesaleprice,itemname,brandname,uniqueid,leastqtyReminder,distributorprice,packsize,baseqty,Packprice,costprice) values('" & txtStockCode.Text & "','" + txtProdName.Text + "','" + cbProdLine.Text + "','" & cbSize.Text & "','" & cbColour.Text & "','" & cbCat.Text & "','" & txtQty.Text & "','" & txtRPrice.Text & "','" & txtWPrice.Text & "','" & txtItemName.Text & "','" & cbbrandName.Text & "','" & cbUnique.Text & "','" & txtLeastQty.Text & "','" & txtWPrice.Text & "','" & txtpacksize.Text & "','" & txtbaseqty.Text & "','" & txtpackprice.Text & "','" & txtCPrice.Text & "')")

                End If
            Catch ex As Exception
                MsgBox(ex.ToString)

            End Try

        End If
        Display()
        txtRPrice.Text = ""
        txtbaseqty.Text = 1
        txtpacksize.Text = 1
        'clear()
        Poscon.Close()
        dr.Close()
        txtItemName.Select()
        'cbItemCodeType.SelectedIndex = 1
    End Sub

    Private Sub txtItemName_Validated(sender As Object, e As EventArgs)
        ItemName()
    End Sub

    Private Sub cbSize_Validated(sender As Object, e As EventArgs) Handles cbSize.Validated
        ItemName()
    End Sub

    Private Sub cbColour_Validated(sender As Object, e As EventArgs) Handles cbColour.Validated
        ItemName()
    End Sub

    Private Sub cbUnique_Validated(sender As Object, e As EventArgs) Handles cbUnique.Validated
        ItemName()
    End Sub

    Private Sub frmProdCreate_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        If e.Button = MouseButtons.Left Then
            isformdragged = False
        End If
    End Sub


    Private Sub gvStockMastBf_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles gvStockMastBf.CellClick
        Try
            Dim row As DataGridViewRow = gvStockMastBf.Rows(e.RowIndex)
            'txtItemName.Text = row.Cells(0).Value.ToString()
            txtProdName.Text = row.Cells(1).Value.ToString()
            txtRPrice.Text = row.Cells(7).Value.ToString()
            txtStockCode.Text = row.Cells(0).Value.ToString()
            txtQty.Text = row.Cells(6).Value.ToString()
            cbProdLine.Text = row.Cells(2).Value.ToString()
            cbCat.Text = row.Cells(5).Value.ToString()
            cbSize.Text = row.Cells(3).Value.ToString()
            cbColour.Text = row.Cells(4).Value.ToString()
            txtItemName.Text = row.Cells(8).Value.ToString()
            txtItemName.Text = row.Cells(10).Value.ToString()
            cbbrandName.Text = row.Cells(11).Value.ToString()
            cbUnique.Text = row.Cells(12).Value.ToString()
            cbProdLine.Text = row.Cells(2).Value.ToString()
            txtbaseqty.Text = row.Cells(16).Value.ToString()
            txtpackprice.Text = row.Cells(17).Value.ToString()
            txtpacksize.Text = row.Cells(15).Value.ToString()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub Feel(valueTosearch As String)
        Try
            If Poscon.State = ConnectionState.Closed Then
                Poscon.Open()
            End If

            Dim query = "select * from StockMast where concat(ProdName,ProdCode) like '%" + valueTosearch + "%'"
            cmd = New SqlCommand(query, Poscon)
            da = New SqlDataAdapter(cmd)
            tbl = New DataTable()
            da.Fill(tbl)
            gvStockMastBf.DataSource = tbl
            Dim itemavailable As Boolean
            itemavailable = tbl.Rows(0)(0).ToString = ""
            If itemavailable Then
            Else
                If tbl.Rows(0)(0).ToString = txtProdName.Text And tbl.Rows.Count = 1 Then

                Else
                    'MsgBox("No Record")
                    ''txtProdName.Text = ""

                End If
            End If
            Poscon.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cbSearchProdCreate_KeyUp(sender As Object, e As KeyEventArgs) Handles cbSearchProdCreate.KeyUp
        Feel(cbSearchProdCreate.Text)
    End Sub
    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click
        ProductManagement_Load(e, e)
    End Sub

    Private Sub txtLeastQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLeastQty.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MsgBox("This field will accept numbers only")
        End If
    End Sub

    Private Sub txtItemName_Enter(sender As Object, e As EventArgs) Handles txtItemName.Enter
        If cbItemCodeType.SelectedIndex = 0 Then
            txtStockCode.Text = ""
        Else
            txtStockCode.Text = lblProdline.Text + lblcat.Text + lblProdCount.Text
        End If
    End Sub

    Private Sub txtRPrice_TextChanged(sender As Object, e As EventArgs) Handles txtRPrice.TextChanged
        Dim packprice As Decimal
        Dim a = Val(txtpacksize.Text)
        Dim b = Val(txtbaseqty.Text)
        Dim c = Val(txtRPrice.Text)
        packprice = a * b * c
        txtpackprice.Text = packprice
    End Sub

    Private Sub txtpackprice_TextChanged(sender As Object, e As EventArgs) Handles txtpackprice.TextChanged
        Dim rprice As Decimal
        Dim a = Val(txtpacksize.Text)
        Dim b = Val(txtbaseqty.Text)
        Dim c = Val(txtpackprice.Text)
        rprice = c / (a * b)
        txtRPrice.Text = rprice
    End Sub

    Private Sub txtbaseqty_TextChanged(sender As Object, e As EventArgs) Handles txtbaseqty.TextChanged
        ItemName()
    End Sub

    Private Sub txtItemName_TextChanged(sender As Object, e As EventArgs) Handles txtItemName.TextChanged
        ItemName()
    End Sub

    Private Sub cbSize_TextChanged(sender As Object, e As EventArgs) Handles cbSize.TextChanged
        ItemName()
    End Sub

    Private Sub cbColour_TextChanged(sender As Object, e As EventArgs) Handles cbColour.TextChanged
        ItemName()
    End Sub

    Private Sub cbUnique_TextChanged(sender As Object, e As EventArgs) Handles cbUnique.TextChanged
        ItemName()
    End Sub

    Private Sub txtpacksize_TextChanged(sender As Object, e As EventArgs) Handles txtpacksize.TextChanged
        ItemName()
    End Sub
End Class