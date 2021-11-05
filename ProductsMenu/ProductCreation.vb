Imports System.Data.SqlClient
Public Class frmProdCreate
    Dim con As New SqlConnection(My.Settings.PoSConnectionString)
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
        If txtStockCode.Text = "" Or txtRPrice.Text = "" Or cbProdLine.Text = "" Or txtProdname.Text = "" Or cbCat.Text = "" Then
            MsgBox("Fill all important fields")
        Else

            Try
                If con.State = ConnectionState.Closed Then
                    con.Open()
                End If
                Dim query = "insert into stockmast values('" & txtStockCode.Text & "','" + txtProdName.Text + "','" + cbProdLine.Text + "','" & cbSize.Text & "','" & cbColour.Text & "','" & cbCat.Text & "','" & txtQty.Text & "','" & txtRPrice.Text & "','" & txtWPrice.Text & "','" & txtItemName.Text & "','" & cbbrandName.Text & "')"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, con)
                cmd.ExecuteNonQuery()
                MsgBox("Product Saved Successfully")
                con.Close()


            Catch ex As Exception

            End Try

        End If
        Display()
    End Sub
    Sub ItemName()
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
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            Dim query = "select * from category where category like '%" + valuetosearch + "%'"
            cmd = New SqlCommand(query, con)
            Dim adapter As New SqlDataAdapter(cmd)
            Dim tbl As New DataTable()
            adapter.Fill(tbl)
            If cbCat.Text = "" Then
                txtStockCode.Text = ""
                lblcat.Text = ""
            Else
                lblcat.Text = tbl.Rows(0)(0).ToString
            End If

            con.Close()

        Catch ex As Exception
            'MsgBox(ex.ToString)
        End Try


    End Sub
    Public Sub Search1(valuetosearch As String)
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If

            Dim query = "select * from productline where productline like '%" + valuetosearch + "%'"
            cmd = New SqlCommand(query, con)
            Dim adapter As New SqlDataAdapter(cmd)
            Dim tbl As New DataTable()
            adapter.Fill(tbl)
            If cbProdLine.Text = "" Then
                txtStockCode.Text = ""
                lblProdline.Text = ""
            Else
                lblProdline.Text = tbl.Rows(0)(0).ToString
            End If

            con.Close()

        Catch ex As Exception
            'MsgBox(ex.ToString)
        End Try


    End Sub
    Private Sub Display()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Dim query = "select * from StockMast"
        cmd = New SqlCommand(query, con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable()
        adapter.Fill(tbl)
        gvStockMastBf.DataSource = tbl

        lblProdCount.Text = gvStockMastBf.Rows.Count()
        con.Close()
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

        If txtStockCode.Text = "" Or cbProdLine.Text = "" Or txtProdName.Text = "" Or cbCat.Text = "" Then
            MsgBox("Fill all important fields")
            Exit Sub
        Else
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If

            Dim qu = "select * from Stockmast where ProdName= '" + txtProdName.Text + "' and ItemName='" + txtItemName.Text + "' and ProdCat='" + cbCat.Text + "' "
            cmd = New SqlCommand(qu, con)
            dr = cmd.ExecuteReader
            If (dr.Read = True) Then
                MsgBox("Item Name already exists")
                dr.Close()
                con.Close()
                cbItemCodeType.SelectedIndex = 0
                Exit Sub
            End If

            Try
                dr.Close()

                If con.State = ConnectionState.Closed Then
                    con.Open()
                End If

                Dim sql = "select * from StockMast where ProdCode like '%" + txtStockCode.Text + "%'"
                cmd = New SqlCommand(sql, con)
                Dim adapter As New SqlDataAdapter(cmd)
                Dim table As New DataTable()
                adapter.Fill(table)
                ' If (txtItemName.Text + " " + cbColour.Text + " " + cbUnique.Text + " " + cbSize.Text) = table.Rows(0)(1).ToString Then
                'MsgBox("Item Name Alredy exists")

                'Display()
                'clear()
                'Exit Sub
                'End If
                If table.Rows.Count() = 0 Then
                    Dim query = "insert into stockmast(prodcode,prodname,prodline,prodsize,prodcolour,prodcat,prodqty,retailprice,wholesaleprice,itemname,brandname,uniqueid,leastqtyReminder,distributorprice,packsize,baseqty,Packprice) values('" & txtStockCode.Text & "','" + txtProdName.Text + "','" + cbProdLine.Text + "','" & cbSize.Text & "','" & cbColour.Text & "','" & cbCat.Text & "','" & txtQty.Text & "','" & txtRPrice.Text & "','" & txtWPrice.Text & "','" & txtItemName.Text & "','" & cbbrandName.Text & "','" & cbUnique.Text & "','" & txtLeastQty.Text & "','" + txtWPrice.Text + "','" + txtpacksize.Text + "','" + txtbaseqty.Text + "','" + txtpackprice.Text + "')"
                    Dim cmd As SqlCommand
                    cmd = New SqlCommand(query, con)
                    cmd.ExecuteNonQuery()
                    'MsgBox("Product Saved Successfully")
                    con.Close()
                    'ElseIf table.Rows.Count() = 1 Then
                    '    Dim query = "update Stockmast Set ProdCode='" + txtStockCode.Text + "',ProdName= '" + txtProdName.Text + "',ProdLine='" + cbProdLine.Text + "',ProdSize='" + cbSize.Text + "',ProdColour='" + cbColour.Text + "',ProdCat='" + cbCat.Text + "',ProdQty='" + txtQty.Text + "',RetailPrice='" + txtRPrice.Text + "',WholesalePrice='" + txtWPrice.Text + "',Itemname='" + txtItemName.Text + "',BrandName='" + cbbrandName.Text + "',uniqueid='" + cbUnique.Text + "',PackSize='" + txtpacksize.Text + "',Baseqty='" + txtbaseqty.Text + "',Packprice='" + txtpackprice.Text + "' where Prodcode =" + txtStockCode.Text + ""
                    '    Dim cmd As SqlCommand
                    '    cmd = New SqlCommand(query, con)
                    '    cmd.ExecuteNonQuery()
                    '    MsgBox("Product Successfully updated")
                    '    con.Close()
                    'Else
                    '    MsgBox("Contact Admin")
                End If



            Catch ex As Exception
                MsgBox(ex.ToString)

                End Try

            End If
            Display()
        clear()
        con.Close()
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

    Private Sub frmProdCreate_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        If e.Button = MouseButtons.Left Then
            isformdragged = True
            mousedownX = e.X
            mousedowny = e.Y

        End If
    End Sub

    Private Sub frmProdCreate_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If isformdragged Then
            Dim temp As Point = New Point
            temp.X = Me.Location.X + (e.X - mousedownX)
            temp.Y = Me.Location.Y + (e.Y - mousedowny)
            Me.Location = temp
            temp = Nothing

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
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If

            Dim query = "select * from StockMast where concat(ProdName,ProdCode) like '%" + valueTosearch + "%'"
            cmd = New SqlCommand(query, con)
            Dim adapter As New SqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)
            gvStockMastBf.DataSource = table
            Dim itemavailable As Boolean
            itemavailable = table.Rows(0)(0).ToString = ""
            If itemavailable Then
            Else
                If table.Rows(0)(0).ToString = txtProdName.Text And table.Rows.Count = 1 Then

                Else
                    'MsgBox("No Record")
                    ''txtProdName.Text = ""

                End If
            End If



            con.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cbSearchProdCreate_KeyUp(sender As Object, e As KeyEventArgs) Handles cbSearchProdCreate.KeyUp
        Feel(cbSearchProdCreate.Text)
    End Sub

    Private Sub txtItemName_Validated_1(sender As Object, e As EventArgs) Handles txtItemName.Validated
        ItemName()
    End Sub

    Private Sub txtItemName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtItemName.SelectedIndexChanged
        ItemName()
    End Sub

    Private Sub cbSize_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSize.SelectedIndexChanged
        ItemName()
    End Sub

    Private Sub cbColour_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbColour.SelectedIndexChanged
        ItemName()
    End Sub
    Public Sub loadCatPline()

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

    Private Sub txtItemName_TextUpdate(sender As Object, e As EventArgs) Handles txtItemName.TextUpdate
        ItemName()
    End Sub

    Private Sub cbSize_TextUpdate(sender As Object, e As EventArgs) Handles cbSize.TextUpdate
        ItemName()
    End Sub

    Private Sub cbColour_TextUpdate(sender As Object, e As EventArgs) Handles cbColour.TextUpdate
        ItemName()
    End Sub

    Private Sub cbUnique_TextUpdate(sender As Object, e As EventArgs) Handles cbUnique.TextUpdate
        ItemName()
    End Sub

    Private Sub cbCat_Click(sender As Object, e As EventArgs) Handles cbCat.Click
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cbCat.Items.Clear()
        Dim sqll = "select * from Category"
        cmd = New SqlCommand(sqll, con)
        dr = cmd.ExecuteReader
        While dr.Read
            cbCat.Items.Add(dr(1))
        End While
        con.Close()
    End Sub

    Private Sub cbProdLine_Click(sender As Object, e As EventArgs) Handles cbProdLine.Click
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cbProdLine.Items.Clear()
        Dim query = "select * from Productline"
        cmd = New SqlCommand(query, con)
        dr = cmd.ExecuteReader
        While dr.Read
            cbProdLine.Items.Add(dr(1))
        End While
        con.Close()
    End Sub

    Private Sub cbbrandName_Enter(sender As Object, e As EventArgs) Handles cbbrandName.Enter
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cbColour.Items.Clear()
        txtItemName.Items.Clear()
        cbbrandName.Items.Clear()
        cbSearchProdCreate.Items.Clear()
        Dim sql = "select * from Stockmast"
        cmd = New SqlCommand(sql, con)
        dr = cmd.ExecuteReader
        While dr.Read
            cbColour.Items.Add(dr(4))
            txtItemName.Items.Add(dr(1))
            cbbrandName.Items.Add(dr(11))
            cbSearchProdCreate.Items.Add(dr(1))
        End While
        con.Close()
    End Sub

    Private Sub txtRPrice_TextChanged(sender As Object, e As EventArgs) Handles txtRPrice.TextChanged

    End Sub

    Private Sub txtRPrice_Validated(sender As Object, e As EventArgs) Handles txtRPrice.Validated
        Dim packprice As Decimal
        Dim a = Val(txtpacksize.Text)
        Dim b = Val(txtbaseqty.Text)
        Dim c = Val(txtRPrice.Text)
        packprice = a * b * c
        txtpackprice.Text = packprice
    End Sub
End Class