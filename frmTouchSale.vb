Imports System.Data.SqlClient
Public Class frmTouchSale
    ' Dim poscon As New SqlConnection(My.Settings.Poscon)
    'Dim dr As SqlDataReader
    'Dim cmd As SqlCommand
    'Dim da As SqlDataAdapter
    Dim action As String = "Startup"
    Dim query As String
    Private WithEvents lblPrice As New Label
    Dim dt As New dsSalesTranx
    Dim ds As New dsTouchReciepts
    Dim tbl As New DataTable

    Sub LoadCatbtn()
        flbtnCat.AutoScroll = True
        flbtnCat.Controls.Clear()
        If Poscon.State = ConnectionState.Closed Then
            Poscon.Open()
        End If
        Dim query = "Select distinct prodcat from stockmast"
        cmd = New SqlCommand(query, Poscon)
        dr = cmd.ExecuteReader
        While dr.Read
            Dim Button = New Button
            Button.Width = 90
            Button.Height = 25


            Button.Text = dr.Item("prodcat").ToString
            Button.FlatStyle = FlatStyle.Flat
            Button.BackColor = Color.FromArgb(128, 128, 255)
            Button.ForeColor = Color.White
            'Button.Font = New Font(Button.Font.FontFamily, 14)
            Button.Font = New Font("Segoe UI", 13, FontStyle.Bold)
            ' Button.Font = System.Drawing.Font("Marlett", 12.0F, FontStyle.Regular, GraphicsUnit.Point)


            flbtnCat.Controls.Add(Button)
            Button.Cursor = Cursors.Hand

            AddHandler Button.Click, AddressOf Button_click

        End While
        dr.Close()
        Poscon.Close()

    End Sub


    Sub LoadItems()
        flItems.AutoScroll = True
        flItems.Controls.Clear()
        If Poscon.State = ConnectionState.Closed Then
            Poscon.Open()
        End If
        If action = "Startup" Then

            cmd = New SqlCommand("Select * from StockMast", Poscon)
        End If
        If action = "btnCategory" Then
            cmd = New SqlCommand("Select * from StockMast where ProdCat='" + txtCat.Text + "'", Poscon)
        End If
        If action = "btnsearch" Then
            cmd = New SqlCommand("Select * from StockMast where Prodname like '%" + txtSearch.Text + "%'", Poscon)
        End If

        dr = cmd.ExecuteReader
        While dr.Read
            Dim Btn = New Button
            Btn.Width = 125
            Btn.Height = 65
            Btn.Text = dr.Item("Prodname").ToString
            Btn.TextAlign = ContentAlignment.TopCenter
            Btn.FlatStyle = FlatStyle.Flat
            Btn.BackColor = Color.FromArgb(255, 107, 107)
            Btn.ForeColor = Color.White
            Btn.Font = New Font("Segoe UI", 10, FontStyle.Bold)
            Btn.Tag = dr.Item("ProdCode").ToString
            flItems.Controls.Add(Btn)
            Btn.Cursor = Cursors.Hand


            lblPrice = New Label
            lblPrice.BackColor = Color.SteelBlue
            lblPrice.TextAlign = ContentAlignment.MiddleCenter
            lblPrice.Dock = DockStyle.Bottom
            lblPrice.Text = "¢" & dr.Item("RetailPrice")
            lblPrice.Tag = dr.Item("ProdCode").ToString

            Btn.Controls.Add(lblPrice)

            AddHandler Btn.MouseDown, AddressOf Item_dgv

        End While
        dr.Close()
        Poscon.Close()
    End Sub
    Private Sub frmTouchSale_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tsUser.Text = My.Settings.ActiveUser
        LoadCatbtn()
        LoadItems()
        action = "Startup"
        LoadOder()
        DisplayOders()
        LoadWaiterNames()
        ShowConfig()
        OnloadActivity()
        ShowOderNo()
        btnSell.Visible = False
        btnOder.Visible = True
        display()
        Me.MaximumSize = Screen.FromRectangle(Me.Bounds).WorkingArea.Size
        WindowState = FormWindowState.Maximized
    End Sub
    Public Sub Button_click(sender As Object, e As EventArgs)

        txtCat.Text = sender.text.ToString
        action = "btnCategory"
        LoadItems()
    End Sub

    Private Sub Item_dgv(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Try
            If e.Clicks = 2 Then
                'MessageBox.Show("The button was double-clicked.")
                Dim qty As Double = 1
                'Dim amt As Double
                lblProdCode.Text = sender.tag.ToString

                If Poscon.State = ConnectionState.Closed Then
                    Poscon.Open()
                End If

                Dim query = "Select * from StockMast where Prodcode='" + sender.tag.ToString + "'"
                cmd = New SqlCommand(query, Poscon)
                dr = cmd.ExecuteReader
                While dr.Read
                    lblCat.Text = dr.Item("ProdCat")
                    lblActualStock.Text = dr.Item("ProdQty")
                    For Each row As DataGridViewRow In gvtouchsale.Rows
                        If lblProdCode.Text = row.Cells(0).Value Then
                            row.Cells(3).Value += 1
                            row.Cells(4).Value = row.Cells(3).Value * row.Cells(2).Value
                            row.Cells(10).Value -= 1
                            Try
                                Dim sum As Decimal
                                For k = 0 To gvtouchsale.RowCount - 1
                                    sum += gvtouchsale.Rows(k).Cells(4).Value
                                Next
                                lblTotal.Text = sum
                            Catch ex As Exception
                                MsgBox(ex.ToString)
                            End Try
                            dr.Close()
                            Poscon.Close()
                            Exit Sub
                        End If

                    Next
                    gvtouchsale.Rows.Add(dr.Item("ProdCode").ToString, dr.Item("Itemname").ToString, dr.Item("RetailPrice").ToString, qty, dr.Item("RetailPrice").ToString, lblDayOder.Text, "Pending", dr.Item("ProdCat").ToString, dr.Item("Prodline").ToString, lblRecieptNo.Text, dr.Item("ProdQty") - one.Text, dr.Item("ProdQty"), lblOderNo.Text)
                End While

                dr.Close()
                Poscon.Close()
            End If
            If e.Clicks = 1 Then
                'MessageBox.Show("The button was double-clicked.")
                Dim qty As Double = 1
                'Dim amt As Double
                lblProdCode.Text = sender.tag.ToString

                If Poscon.State = ConnectionState.Closed Then
                    Poscon.Open()
                End If

                Dim query = "Select * from StockMast where Prodcode='" + sender.tag.ToString + "'"
                cmd = New SqlCommand(query, Poscon)
                dr = cmd.ExecuteReader
                While dr.Read
                    lblItemName.Text = dr.Item("Prodname")
                    lblCat.Text = dr.Item("ProdCat")
                    lblprodline.Text = dr.Item("Prodline")
                    lblActualStock.Text = dr.Item("ProdQty")
                    txtPrice.Text = dr.Item("RetailPrice").ToString
                End While
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub
    'Public Sub Item_dgv(sender As Object, e As EventArgs)

    '    Dim qty As Double = 1
    '    'Dim amt As Double
    '    lblProdCode.Text = sender.tag.ToString

    '    If poscon.State = ConnectionState.Closed Then
    '        poscon.Open()
    '    End If

    '    Dim query = "Select * from StockMast where Prodcode='" + sender.tag.ToString + "'"
    '    cmd = New SqlCommand(query, poscon)
    '    dr = cmd.ExecuteReader
    '    While dr.Read
    '        lblCat.Text = dr.Item("ProdCat")
    '        lblActualStock.Text = dr.Item("ProdQty")
    '        For Each row As DataGridViewRow In gvtouchsale.Rows
    '            If lblProdCode.Text = row.Cells(0).Value Then
    '                row.Cells(3).Value += 1
    '                row.Cells(4).Value = row.Cells(3).Value * row.Cells(2).Value
    '                row.Cells(10).Value -= 1
    '                Try
    '                    Dim sum As Decimal
    '                    For k = 0 To gvtouchsale.RowCount - 1
    '                        sum += gvtouchsale.Rows(k).Cells(4).Value
    '                    Next
    '                    lblTotal.Text = sum
    '                Catch ex As Exception
    '                    MsgBox(ex.ToString)
    '                End Try
    '                dr.Close()
    '                poscon.Close()
    '                Exit Sub
    '            End If

    '        Next
    '        gvtouchsale.Rows.Add(dr.Item("ProdCode").ToString, dr.Item("ProdName").ToString, dr.Item("RetailPrice").ToString, qty, dr.Item("RetailPrice").ToString, lblDayOder.Text, "Pending", dr.Item("ProdCat").ToString, dr.Item("Prodline").ToString, lblRecieptNo.Text, dr.Item("ProdQty") - one.Text, dr.Item("ProdQty"), lblOderNo.Text)
    '    End While

    '    dr.Close()
    '    poscon.Close()


    'End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles btnOder.Click
        If lblOderSale.Text <> "odersale" Then
            Update_Oder()
            Exit Sub
        Else
            If cbwaiter.Text = "" Then
                MsgBox("Choose Waiter Odering")
            Else
                ShowOderNo()
                Oder()
                Oderdetails()
                gvtouchsale.Rows.Clear()

                LoadOder()
                DisplayOders()
                ShowOderNo()
                Clear()
            End If
        End If


    End Sub

    Private Sub Guna2PictureBox1_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox1.Click
        Me.Hide()
        Application.Exit()

    End Sub
    Public Sub Update_Oder()
        create("delete from odertranx where oderno='" + lblOderSale.Text + "'")
        If Poscon.State = ConnectionState.Closed Then
            Poscon.Open()
        End If

        For Each row As DataGridViewRow In gvtouchsale.Rows
            'create("insert into odertranx (OderNo,ItemCode,ItemName,Price,Oderqty,OderAmt,DayOderNo,OderStatus,Category,Prodline,WaiterName) values('" + lblOderNo.Text + "',@ItemCode,@ItemName,@Price,@Oderqty,@OderAmt,'" + lblDayOder.Text + "',@Oderstatus,@Category,@Prodline,'" + cbWaiter.Text + "') ON DUPLICATE KEY update ItemCode=@itemcodeu,ItemName=@itemnameu,Price=@priceu,Oderqty=@oderqtyu,OderAmt=@oderamtu,OderStatus=@oderstatusu,Category=@categoryu,Prodline=@prodlineu,WaiterName='" + cbWaiter.Text + "' where Oderno=@dayoderno")
            Dim qu = "insert into odertranx (OderNo,ItemCode,ItemName,Price,Oderqty,OderAmt,DayOderNo,OderStatus,Category,Prodline,WaiterName) values('" + lblOderSale.Text + "',@ItemCode,@ItemName,@Price,@Oderqty,@OderAmt,'" + lbldayodersale.Text + "',@Oderstatus,@Category,@Prodline,'" + cbwaiter.Text + "')"
            'ON DUPLICATE KEY update ItemCode=@itemcodeu,ItemName=@itemnameu,Price=@priceu,Oderqty=@oderqtyu,OderAmt=@oderamtu,OderStatus=@oderstatusu,Category=@categoryu,Prodline=@prodlineu,WaiterName='" + cbWaiter.Text + "' where Oderno=@dayoderno"
            cmd = New SqlCommand(qu, Poscon)
            With cmd

                .Parameters.AddWithValue("@ItemCode", row.Cells(0).Value)
                .Parameters.AddWithValue("@ItemName", row.Cells(1).Value)
                .Parameters.AddWithValue("@Price", row.Cells(2).Value)
                .Parameters.AddWithValue("@Oderqty", row.Cells(3).Value)
                .Parameters.AddWithValue("@OderAmt", row.Cells(4).Value)
                .Parameters.AddWithValue("@OderStatus", "Pending")
                .Parameters.AddWithValue("@Category", row.Cells(7).Value)
                .Parameters.AddWithValue("@Prodline", row.Cells(8).Value)

                .ExecuteNonQuery()
            End With
        Next

        MsgBox("Oder Details Succefull")

        'For Each row As DataGridViewRow In gvtouchsale.Rows

        '    Dim qu = "update odertranx set ItemCode=@itemcode,ItemName=@itemname,Price=@price,Oderqty=@oderqty,OderAmt=@oderamt,DayOderNo='" + lblDayOder.Text + "',OderStatus=@oderstatus,Category=@category,Prodline=@prodline,WaiterName='" + cbWaiter.Text + "' where Oderno=@dayoderno"
        '    cmd = New SqlCommand(qu, poscon)
        '    With cmd
        '        .Parameters.AddWithValue("@ItemCode", row.Cells(0).Value)
        '        .Parameters.AddWithValue("@ItemName", row.Cells(1).Value)
        '        .Parameters.AddWithValue("@Price", row.Cells(2).Value)
        '        .Parameters.AddWithValue("@Oderqty", row.Cells(3).Value)
        '        .Parameters.AddWithValue("@OderAmt", row.Cells(4).Value)
        '        .Parameters.AddWithValue("@OderStatus", "Pending")
        '        .Parameters.AddWithValue("@Category", row.Cells(7).Value)
        '        .Parameters.AddWithValue("@Prodline", row.Cells(8).Value)
        '        .Parameters.AddWithValue("@dayoderno", lblDayOder.Text)
        '        .ExecuteNonQuery()
        '    End With
        'Next

        lblOderSale.Text = "odersale"
        MsgBox("Oder Updated Succefull")
        LoadOder()
    End Sub
    Sub LoadOder()
        'Dim nextoder As String
        'Dim odercount As String
        'If Poscon.State = ConnectionState.Closed Then
        '    Poscon.Open()
        'End If
        'Dim sql = "select * from odersConfig"
        'cmd = New SqlCommand(sql, Poscon)
        'da = New SqlDataAdapter(cmd)
        'Dim table As New DataTable
        'da.Fill(table)
        'If table.Rows.Count() = 0 Then
        '    lblDayOder.Text = "10001"
        'Else
        '    Dim index = table.Rows.Count() - 1
        '    Dim reciept = table.Rows(index)(0).ToString
        '    nextoder = reciept + 1
        '    odercount = nextoder.Count.ToString
        '    Select Case odercount
        '        Case "1"
        '            lblDayOder.Text = "1000" + nextoder
        '        Case "2"
        '            lblDayOder.Text = "100" + nextoder
        '        Case "3"
        '            lblDayOder.Text = "10" + nextoder
        '        Case "4"
        '            lblDayOder.Text = "1" + nextoder
        '        Case "5"
        '            lblDayOder.Text = nextoder
        '        Case Else
        '            lblDayOder.Text = nextoder

        '    End Select
        'End If
        Dim digit As Integer
        Dim result As String
        If Poscon.State = ConnectionState.Closed Then
            Poscon.Open()
        End If
        cmd = New SqlCommand("Select max(dayoderno) from odersConfig where oderdate=convert(date,'" + Date.Now + "',105)", Poscon)
        result = cmd.ExecuteScalar.ToString

        If String.IsNullOrEmpty(result) Then
            result = "0001"
            lblDayOder.Text = result
        Else
            result = result.Substring(0)
            Int32.TryParse(result, digit)
            digit = digit + 1
            result = digit.ToString("D4")
            lblDayOder.Text = result
        End If
        'txtinvoiceno.Text = "SRV" + Date.Now.ToString("dd") + Date.Now.ToString("MM") + Date.Now.ToString("yy") + Date.Now.ToString("HH") + Date.Now.ToString("mm") + Date.Now.ToString("ss")

    End Sub
    Sub Oder()
        If Poscon.State = ConnectionState.Closed Then
            Poscon.Open()
        End If
        Dim oderstat As String = "Pending"
        Dim sql = "insert into OdersConfig(dayoderno,salesperson,waiter,oderno,status,oderdate) values('" + lblDayOder.Text + "','" + tsUser.Text + "','" + cbwaiter.Text + "','" + lblOderNo.Text + "','" + oderstat + "',convert(date,'" + Date.Now + "',105)) "
        cmd = New SqlCommand(sql, Poscon)
        cmd.ExecuteNonQuery()
        Poscon.Close()
        MsgBox("Oder Successful")
        'gvtouchsale.Rows.Clear()
        'Clear()
        LoadOder()
    End Sub
    Sub Oderdetails()
        If Poscon.State = ConnectionState.Closed Then
            Poscon.Open()
        End If
        For Each row As DataGridViewRow In gvtouchsale.Rows
            'create("insert into odertranx (OderNo,ItemCode,ItemName,Price,Oderqty,OderAmt,DayOderNo,OderStatus,Category,Prodline,WaiterName) values('" + lblOderNo.Text + "',@ItemCode,@ItemName,@Price,@Oderqty,@OderAmt,'" + lblDayOder.Text + "',@Oderstatus,@Category,@Prodline,'" + cbWaiter.Text + "') ON DUPLICATE KEY update ItemCode=@itemcodeu,ItemName=@itemnameu,Price=@priceu,Oderqty=@oderqtyu,OderAmt=@oderamtu,OderStatus=@oderstatusu,Category=@categoryu,Prodline=@prodlineu,WaiterName='" + cbWaiter.Text + "' where Oderno=@dayoderno")
            Dim qu = "insert into odertranx (OderNo,ItemCode,ItemName,Price,Oderqty,OderAmt,DayOderNo,OderStatus,Category,Prodline,WaiterName,oderdate) values('" + lblOderNo.Text + "',@ItemCode,@ItemName,@Price,@Oderqty,@OderAmt,'" + lblDayOder.Text + "',@Oderstatus,@Category,@Prodline,'" + cbwaiter.Text + "',convert(date,'" + Date.Now + "',105))"
            'ON DUPLICATE KEY update ItemCode=@itemcodeu,ItemName=@itemnameu,Price=@priceu,Oderqty=@oderqtyu,OderAmt=@oderamtu,OderStatus=@oderstatusu,Category=@categoryu,Prodline=@prodlineu,WaiterName='" + cbWaiter.Text + "' where Oderno=@dayoderno"
            cmd = New SqlCommand(qu, Poscon)
            With cmd

                .Parameters.AddWithValue("@ItemCode", row.Cells(0).Value)
                .Parameters.AddWithValue("@ItemName", row.Cells(1).Value)
                .Parameters.AddWithValue("@Price", row.Cells(2).Value)
                .Parameters.AddWithValue("@Oderqty", row.Cells(3).Value)
                .Parameters.AddWithValue("@OderAmt", row.Cells(4).Value)
                .Parameters.AddWithValue("@OderStatus", "Pending")
                .Parameters.AddWithValue("@Category", row.Cells(7).Value)
                .Parameters.AddWithValue("@Prodline", row.Cells(8).Value)

                'Update
                '.Parameters.AddWithValue("@ItemCodeu", row.Cells(0).Value)
                '.Parameters.AddWithValue("@ItemNameu", row.Cells(1).Value)
                '.Parameters.AddWithValue("@Priceu", row.Cells(2).Value)
                '.Parameters.AddWithValue("@Oderqtyu", row.Cells(3).Value)
                '.Parameters.AddWithValue("@OderAmtu", row.Cells(4).Value)
                '.Parameters.AddWithValue("@OderStatusu", "Pending")
                '.Parameters.AddWithValue("@Categoryu", row.Cells(7).Value)
                '.Parameters.AddWithValue("@Prodlineu", row.Cells(8).Value)
                '.Parameters.AddWithValue("@dayodernou", lblDayOder.Text)

                .ExecuteNonQuery()
            End With
        Next

        MsgBox("Oder Details Succefull")
        LoadOder()
    End Sub
    Sub SearchWaiters(valuetosearch As String)
        Try

            If cbcreditcustname.Text = "" Then
                reload("select * from OdersConfig where status='" + "Pending" + "'", gvOders)
                Exit Sub
            End If
            reload("select * from OdersConfig where concat(OderNo,Waiter) like '%" + valuetosearch + "%' and status='" + "Pending" + "'", gvOders)



        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub DisplayOders()

        reload("select * from OdersConfig where status='" + "Pending" + "'", gvOders)
    End Sub
    Sub Clear()
        'lblDayOder.Text = ""
        cbwaiter.SelectedIndex = -1
        'lblCreditCust.Text = ""
        lblProdCode.Text = ""
        txtBuyerName.Text = ""
        txtCashPaid.Text = ""
        lblPrice.Text = ""
        lblOldBal.Text = ""
        lblCustNo.Text = ""
        cbWaiterSearch.SelectedIndex = -1
        cbwaiter.SelectedIndex = -1
        txtCashPaid.Text = ""
        txtCat.Text = ""
        lblCustNo.Text = ""
        lblChange.Text = ""
        'lblActualStock.Text = ""
        lblNewBal.Text = ""
        lblOldBal.Text = ""
        cbcreditcustname.SelectedIndex = -1
        txtCat.Text = ""
        'txtProdline.Text = ""


    End Sub

    Private Sub TextBox1_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtSearchWaiterOder.Validating
        SearchWaiters(txtSearchWaiterOder.Text)

    End Sub

    Private Sub TextBox1_Validated(sender As Object, e As EventArgs) Handles txtSearchWaiterOder.Validated
        SearchWaiters(txtSearchWaiterOder.Text)
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearchWaiterOder.KeyPress
        SearchWaiters(txtSearchWaiterOder.Text)
    End Sub
    Sub LoadWaiterNames()
        ComboFeed("Select waitername from Waiters", cbwaiter, 0)
        ComboFeed("Select waitername from Waiters", cbWaiterSearch, 0)
    End Sub



    Private Sub txtSearchWaiterOder_TextChanged(sender As Object, e As EventArgs) Handles txtSearchWaiterOder.TextChanged
        SearchWaiters(txtSearchWaiterOder.Text)
    End Sub
    Sub LoadOderSale()
        If gvtouchsale.Rows.Count = 0 Then
            If Poscon.State = ConnectionState.Closed Then
                Poscon.Open()
            End If
            Dim queryy = ("Select * from OderTranx where OderNo like '%" + lblOderSale.Text + "%'")
            cmd = New SqlCommand(queryy, Poscon)
            da = New SqlDataAdapter(cmd)
            Dim table As New DataTable()
            da.Fill(table)
            gvOderDetails.DataSource = table
            For Each row As DataGridViewRow In gvOderDetails.Rows
                'dr.Close()
                Dim query = "Select * from StockMast where Prodcode=@itemcode"
                cmd = New SqlCommand(query, Poscon)
                cmd.Parameters.AddWithValue("@itemcode", SqlDbType.NVarChar).Value = row.Cells(1).Value
                dr = cmd.ExecuteReader
                While dr.Read
                    lblWaiter.Text = row.Cells(10).Value
                    gvtouchsale.Rows.Add(row.Cells(1).Value, row.Cells(2).Value, row.Cells(3).Value, row.Cells(4).Value, row.Cells(5).Value, row.Cells(6).Value, row.Cells(7).Value, row.Cells(8).Value, row.Cells(9).Value, lblRecieptNo.Text, dr.Item("ProdQty") - row.Cells(4).Value, dr.Item("ProdQty"), row.Cells(10).Value, row.Cells(0).Value)
                End While
            Next
            Poscon.Close()
        Else
            Dim ask As MsgBoxResult
            ask = MsgBox("Would you like to clear Cart?", MsgBoxStyle.YesNo, "")
            If ask = MsgBoxResult.Yes Then
                gvtouchsale.Rows.Clear()
                If Poscon.State = ConnectionState.Closed Then
                    Poscon.Open()
                End If
                Dim queryy = ("Select * from OderTranx where OderNo like '%" + lblOderSale.Text + "%'")
                cmd = New SqlCommand(queryy, Poscon)
                da = New SqlDataAdapter(cmd)
                Dim table As New DataTable()
                da.Fill(table)
                gvOderDetails.DataSource = table
                For Each row As DataGridViewRow In gvOderDetails.Rows
                    dr.Close()
                    Dim query = "Select * from StockMast where Prodcode=@itemcode"
                    cmd = New SqlCommand(query, Poscon)
                    cmd.Parameters.AddWithValue("@itemcode", SqlDbType.NVarChar).Value = row.Cells(1).Value
                    dr = cmd.ExecuteReader
                    While dr.Read
                        lblWaiter.Text = row.Cells(10).Value
                        gvtouchsale.Rows.Add(row.Cells(1).Value, row.Cells(2).Value, row.Cells(3).Value, row.Cells(4).Value, row.Cells(5).Value, row.Cells(6).Value, row.Cells(7).Value, row.Cells(8).Value, row.Cells(9).Value, lblRecieptNo.Text, dr.Item("ProdQty") - row.Cells(4).Value, dr.Item("ProdQty"), row.Cells(10).Value, row.Cells(0).Value)
                    End While
                Next
                Poscon.Close()
            Else

            End If
        End If

    End Sub

    Private Sub gvOders_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles gvOders.CellClick
        Try
            Dim row As DataGridViewRow = gvOders.Rows(e.RowIndex)

            lblOderSale.Text = row.Cells(3).Value.ToString()
            lbldayodersale.Text = row.Cells(0).Value.ToString()
            cbwaiter.Text = row.Cells(2).Value.ToString()
            If Poscon.State = ConnectionState.Closed Then
                Poscon.Open()
            End If
            Dim queryy = ("Select * from OderTranx where OderNo like '%" + lblOderSale.Text + "%'")
            cmd = New SqlCommand(queryy, Poscon)
            da = New SqlDataAdapter(cmd)
            tbl = New DataTable
            da.Fill(tbl)
            gvOderDetails.DataSource = tbl
            If tbl.Rows.Count = 0 Then

                MsgBox("Empty Oder. Reoder!")
                create("delete from odersconfig where oderno='" + lblOderSale.Text + "'")

                'Clear()
            End If
            'LoadOderSale()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub
    Sub Reciept()

        create("insert into Recieptconfig(salesperson,Recieptid,waitername,oderno,date) values('" + tsUser.Text + "','" + lblRecieptNo.Text + "','" + lblWaiter.Text + "','" + lblDayOder.Text + "','" + lbldate.Text + "') ")
    End Sub
    Private Sub ShowConfig()
        Dim digit As Integer
        Dim result As String
        If Poscon.State = ConnectionState.Closed Then
            Poscon.Open()
        End If
        cmd = New SqlCommand("select max(recieptno) from salestranx", Poscon)
        result = cmd.ExecuteScalar.ToString

        If String.IsNullOrEmpty(result) Then
            result = "ET000000"
            lblRecieptNo.Text = result
        Else
            result = result.Substring(3)
            Int32.TryParse(result, digit)
            digit = digit + 1
            result = "ET" + digit.ToString("D6")
            lblRecieptNo.Text = result
        End If
    End Sub

    Private Sub ShowOderNo()

        Dim digit As Integer
        Dim result As String
        If Poscon.State = ConnectionState.Closed Then
            Poscon.Open()
        End If
        cmd = New SqlCommand("select max(Oderno) from odersconfig", Poscon)
        result = cmd.ExecuteScalar.ToString

        If String.IsNullOrEmpty(result) Then
            result = "000001"
            lblOderNo.Text = result
        Else
            result = result.Substring(0)
            Int32.TryParse(result, digit)
            digit = digit + 1
            result = digit.ToString("D6")
            lblOderNo.Text = result
        End If

    End Sub
    Sub PrintReciept()

        Try
            Reciept()
            dt.EnforceConstraints = False
            Poscon.Open()
            Dim que = "select * from recieptconfig"
            cmd = New SqlCommand(que, Poscon)
            Dim da As New SqlDataAdapter(cmd)
            Dim table As New DataTable
            da.Fill(table)
            ' If table.Rows.Count() = 0 Then
            'Dim reciept = "1"
            'Else
            'Dim index = table.Rows.Count() - 1
            ' Dim reciept = table.Rows(index)(0).ToString
            ' End If


            Dim query = "select * from SalesTranx where recieptno='" + table.Rows(table.Rows.Count() - 1)(2).ToString + "'"
            'itemname,qtySold,amount,Retailprice

            cmd = New SqlCommand(query, Poscon)
            da.SelectCommand = cmd

            da.Fill(dt, "salesTranx")

            Dim report As New rptSalesReciept
            report.SetDataSource(dt)
            report.PrintToPrinter(1, True, 0, 0)
            'CrystalReportViewer1.ReportSource = report
            ' CrystalReportViewer1.Refresh()
            cmd.Dispose()
            da.Dispose()
            Poscon.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click
        ShowConfig()
        Reciept()
        ShowConfig()

        If cbSaleType.Text = "" Or gvtouchsale.RowCount = 0 Then
            MsgBox("Select Sale Type or Fill sale Cart", vbCritical)
        Else
            'Try
            If (cbSaleType.SelectedIndex = 0 Or cbSaleType.SelectedItem = "Walk-In Sale") Then
                'reciept()

                ' cbCreditCustName.Visible = False
                ' lblCreditCust.Visible = False
                Try
                    Dim i As Integer
                    If True Then
                        For i = 0 To gvtouchsale.RowCount - 1

                            If Poscon.State = ConnectionState.Closed Then
                                Poscon.Open()
                            End If
                            Dim query = "insert into salestranx (ItemCode,ItemName,ProdLine,ProdCat,QtySold,DateSold,TimeSold,BuyerName,BuyerTel,BuyerLocation,NewStock,RetailPrice,SaleType,CredCustName,Amount,Soldby,RecieptNo,AmtPaid,Balance) values(@ItemCode,@ItemName,@ProdLine,@ProdCat,@QtySold,@DateSold,@TimeSold,@BuyerName,@BuyerTel,@BuyerLocation,@NewStock,@RetailPrice,@SaleType,@CreditCustomerName,@Amount,'" + tsUser.Text + "', '" + lblRecieptNo.Text + "','" + txtCashPaid.Text + "','" + lblChange.Text + "')"
                            Dim cmd As New SqlCommand
                            cmd = New SqlCommand(query, Poscon)
                            With cmd

                                .Parameters.AddWithValue("@ItemCode", gvtouchsale.Rows(i).Cells(0).Value)
                                .Parameters.AddWithValue("@Itemname", gvtouchsale.Rows(i).Cells(1).Value)
                                .Parameters.AddWithValue("@ProdLine", (gvtouchsale.Rows(i).Cells(8).Value))
                                .Parameters.AddWithValue("@ProdCat", (gvtouchsale.Rows(i).Cells(7).Value))
                                '.Parameters.AddWithValue("@ItemSize", (gvtouchsale.Rows(i).Cells(6).Value))
                                '.Parameters.AddWithValue("@ItemColour", (gvtouchsale.Rows(i).Cells(4).Value))
                                .Parameters.AddWithValue("@QtySold", (gvtouchsale.Rows(i).Cells(3).Value))
                                .Parameters.AddWithValue("@DateSold", lbldate.Text)
                                .Parameters.AddWithValue("@TimeSold", lbltime.Text)
                                .Parameters.AddWithValue("@BuyerName", txtBuyerName.Text)
                                .Parameters.AddWithValue("@BuyerTel", txtBuyerTel.Text)
                                .Parameters.AddWithValue("@BuyerLocation", cbLocation.Text)
                                .Parameters.AddWithValue("@NewStock", (gvtouchsale.Rows(i).Cells(10).Value))
                                .Parameters.AddWithValue("@RetailPrice", gvtouchsale.Rows(i).Cells(2).Value)
                                .Parameters.AddWithValue("@Saletype", cbSaleType.Text)
                                .Parameters.AddWithValue("@CreditCustomerName", cbcreditcustname.Text)
                                .Parameters.AddWithValue("@Amount", gvtouchsale.Rows(i).Cells(4).Value)
                                .ExecuteNonQuery()
                            End With
                            Poscon.Close()


                        Next

                        'frmSalesReciept.Show()
                        'MsgBox("Record Saved")
                    End If
                Finally

                    For k = 0 To gvtouchsale.RowCount - 1
                        If Poscon.State = ConnectionState.Closed Then
                            Poscon.Open()
                        End If
                        Dim query = "update StockMast set ProdQty = @newstock where Prodcode =" + gvtouchsale.Rows(k).Cells(0).Value + ""
                        Dim cmd As New SqlCommand
                        cmd = New SqlCommand(query, Poscon)
                        With cmd
                            .Parameters.AddWithValue("@newstock", gvtouchsale.Rows(k).Cells(10).Value)
                            .ExecuteNonQuery()
                        End With

                        Poscon.Close()


                        If Poscon.State = ConnectionState.Closed Then
                            Poscon.Open()
                        End If
                        Dim sql = "delete from OdersConfig where OderNo= '" + gvtouchsale.Rows(k).Cells(5).Value + "' "
                        cmd = New SqlCommand(sql, Poscon)
                        cmd.ExecuteNonQuery()
                        MsgBox("Oder Deleted Successfully")
                        Poscon.Close()
                        DisplayOders()



                    Next


                    MsgBox("StockMast Updated")
                    lblTotal.Text = ""
                    Clear()
                    gvtouchsale.Rows.Clear()
                    DisplayOders()


                End Try
            ElseIf (cbSaleType.SelectedIndex = 1) Then
                'cbCreditCustName.Visible = True
                'lblCreditCust.Visible = True
                Dim a = Val(lblTotal.Text)
                Dim b = Val(lblOldBal.Text)
                Dim sum = b - a
                lblNewBal.Text = sum
                If cbcreditcustname.Text = "" Then
                    MsgBox("Choose customer")
                Else
                    Try
                        'reciept()
                        Dim i As Integer
                        If True Then
                            For i = 0 To gvtouchsale.RowCount - 1
                                If Poscon.State = ConnectionState.Closed Then
                                    Poscon.Open()
                                End If
                                Dim query = "insert into salestranx (ItemCode,ItemName,ProdLine,ProdCat,ItemSize,ItemColour,QtySold,DateSold,TimeSold,BuyerName,BuyerTel,BuyerLocation,NewStock,RetailPrice,SaleType,CredCustName,Amount,Soldby,RecieptNo,AmtPaid,Balance) values(@ItemCode,@ItemName,@ProdLine,@ProdCat,@ItemSize,@ItemColour,@QtySold,@DateSold,@TimeSold,@BuyerName,@BuyerTel,@BuyerLocation,@NewStock,@RetailPrice,@SaleType,@CreditCustomerName,@Amount,'" + tsUser.Text + "', '" + lblRecieptNo.Text + "','" + txtCashPaid.Text + "','" + lblChange.Text + "')"
                                Dim cmd As New SqlCommand
                                cmd = New SqlCommand(query, Poscon)
                                With cmd

                                    .Parameters.AddWithValue("@ItemCode", gvtouchsale.Rows(i).Cells(0).Value)
                                    .Parameters.AddWithValue("@Itemname", gvtouchsale.Rows(i).Cells(1).Value)
                                    .Parameters.AddWithValue("@ProdLine", (gvtouchsale.Rows(i).Cells(8).Value))
                                    .Parameters.AddWithValue("@ProdCat", (gvtouchsale.Rows(i).Cells(7).Value))
                                    '.Parameters.AddWithValue("@ItemSize", (gvtouchsale.Rows(i).Cells(6).Value))
                                    '.Parameters.AddWithValue("@ItemColour", (gvtouchsale.Rows(i).Cells(4).Value))
                                    .Parameters.AddWithValue("@QtySold", (gvtouchsale.Rows(i).Cells(3).Value))
                                    .Parameters.AddWithValue("@DateSold", lbldate.Text)
                                    .Parameters.AddWithValue("@TimeSold", lbltime.Text)
                                    .Parameters.AddWithValue("@BuyerName", txtBuyerName.Text)
                                    .Parameters.AddWithValue("@BuyerTel", txtBuyerTel.Text)
                                    .Parameters.AddWithValue("@BuyerLocation", cbLocation.Text)
                                    .Parameters.AddWithValue("@NewStock", (gvtouchsale.Rows(i).Cells(9).Value))
                                    .Parameters.AddWithValue("@RetailPrice", gvtouchsale.Rows(i).Cells(2).Value)
                                    .Parameters.AddWithValue("@Saletype", cbSaleType.Text)
                                    .Parameters.AddWithValue("@CreditCustomerName", cbcreditcustname.Text)
                                    .Parameters.AddWithValue("@Amount", gvtouchsale.Rows(i).Cells(4).Value)
                                    .ExecuteNonQuery()
                                End With
                                Poscon.Close()
                                MsgBox("You Reach")


                            Next

                        End If

                    Finally
                        If Poscon.State = ConnectionState.Closed Then
                            Poscon.Open()
                        End If
                        Dim quer = "Insert into CustomerLedger(CustomerName,oldbal,Newbal,CreditRecieved,DateRecieved,TimeRecieved,CustomerNo)Values('" + cbcreditcustname.Text + "','" + lblOldBal.Text + "','" + lblNewBal.Text + "','" + lblTotal.Text + "','" + lbldate.Text + "','" + lbltime.Text + "','" + lblCustNo.Text + "')"
                        Dim cmd As New SqlCommand
                        cmd = New SqlCommand(quer, Poscon)
                        cmd.ExecuteNonQuery()

                        Dim que = "update Customer set CurrentBalance=@CurBal where CustomerNo = " + lblCustNo.Text + ""
                        Dim cm As New SqlCommand(que, Poscon)
                        With cm

                            .Parameters.AddWithValue("@CurBal", CDbl(lblNewBal.Text))
                            .ExecuteNonQuery()

                        End With


                        MsgBox("Customer Updated")
                        Poscon.Close()

                        For k = 0 To gvtouchsale.RowCount - 1
                            If Poscon.State = ConnectionState.Closed Then
                                Poscon.Open()
                            End If
                            Dim query = "update StockMast set ProdQty = @newstock where ProdCode =" + gvtouchsale.Rows(k).Cells(5).Value + ""
                            Dim cmdd As New SqlCommand
                            cmdd = New SqlCommand(query, Poscon)
                            With cmdd
                                .Parameters.AddWithValue("@newstock", CInt(gvtouchsale.Rows(k).Cells(8).Value))
                                .ExecuteNonQuery()
                            End With



                        Next
                        Poscon.Close()

                        ShowConfig()
                        MsgBox("StockMast Updated")
                        frmSalesReciept.Show()

                        gvtouchsale.Rows.Clear()
                        lblTotal.Text = ""
                        Clear()
                        DisplayOders()



                        lblTotal.Text = ""
                    End Try
                End If
                'If cbSaleType.Text = "" Or cbSaleType.Text = "Credit Sale" Then
                'cbCreditCustName.Visible = False
                'Else
                '  cbCreditCustName.Visible = True

                '     End If                   
            End If
            'Catch ex As Exception
            '  MsgBox(ex.ToString)
            'End Try
        End If
        ShowConfig()
        'frmSalesReciept.Hide()
    End Sub

    Private Sub gvtouchsale_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles gvtouchsale.RowsAdded
        Try
            Dim sum As Double
            For k = 0 To gvtouchsale.RowCount - 1
                sum += gvtouchsale.Rows(k).Cells(4).Value

            Next
            lblTotal.Text = sum
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Sub CashPaid()
        Dim CashPaid As Decimal = 0
        Dim change As Decimal = 0
        change = Val(txtCashPaid.Text) - Val(lblTotal.Text)
        lblChange.Text = change
    End Sub

    Private Sub txtCashPaid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCashPaid.KeyPress
        CashPaid()
    End Sub

    Private Sub txtCashPaid_KeyUp(sender As Object, e As KeyEventArgs) Handles txtCashPaid.KeyUp
        CashPaid()
    End Sub
    Sub OnloadActivity()
        cbSaleType.SelectedIndex = 0
        lbltime.Text = Date.Now.ToString("hh:mm:ss")
        lbldate.Text = Date.Now.ToString("dd-MMM-yy")
        cbPaymode.SelectedIndex = 0
        cbwaiter.SelectedIndex = -1
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbltime.Text = Date.Now.ToString("hh:mm:ss")
        lbldate.Text = Date.Now.ToString("dd-MMM-yy")
    End Sub

    Private Sub BunifuThinButton23_Click(sender As Object, e As EventArgs) Handles BunifuThinButton23.Click, BunifuThinButton23.Click
        gvtouchsale.Rows.Clear()
        lblOderSale.Text = "odersale"
    End Sub

    Private Sub Guna2PictureBox2_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox2.Click
        If WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Maximized
        ElseIf WindowState = FormWindowState.Maximized Then
            WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub BunifuThinButton24_Click(sender As Object, e As EventArgs) Handles btnSell.Click
        'ShowConfig()
        Reciept()
        ShowConfig()


        If cbSaleType.Text = "" Or gvtouchsale.RowCount = 0 Then
            MsgBox("Select Sale Type or Fill sale Cart", vbCritical)
        End If


        'Try
        If (cbSaleType.SelectedIndex = 0 Or cbSaleType.Text = "Walk-In Sale") Then
            'reciept()
            If Val(txtCashPaid.Text) < Val(lblTotal.Text) Then
                MsgBox("Cash Paid not enough")
                Exit Sub
            End If
            ' cbCreditCustName.Visible = False
            ' lblCreditCust.Visible = False
            Try


                For Each row As DataGridViewRow In gvtouchsale.Rows
                    create("insert into salestranx (ItemCode,ItemName,ProdLine,ProdCat,QtySold,DateSold,TimeSold,BuyerName,BuyerTel,BuyerLocation,NewStock,RetailPrice,SaleType,CredCustName,Amount,Soldby,RecieptNo,AmtPaid,Balance,waiter,amountpayable) values('" & row.Cells(0).Value & "','" & row.Cells(1).Value & "','" & row.Cells(8).Value & "','" & row.Cells(7).Value & "','" & row.Cells(3).Value & "','" & lbldate.Text & "','" & lbltime.Text & "','" & txtBuyerName.Text & "','" & txtBuyerTel.Text & "','" & cbLocation.Text & "','" & row.Cells(10).Value & "','" & row.Cells(2).Value & "','" & cbSaleType.Text & "','" & cbcreditcustname.Text & "','" & row.Cells(4).Value & "','" + tsUser.Text + "', '" + lblRecieptNo.Text + "','" + txtCashPaid.Text + "','" + lblChange.Text + "','" + cbwaiter.Text + "','" & lblTotal.Text & "')")
                    create("update StockMast set prodqty = prodqty - '" & row.Cells(3).Value & "' where Prodcode= '" & row.Cells(0).Value & "'")
                Next
                MsgBox("Record Saved")

            Finally
                RollReciept(lblRecieptNo.Text)
                MsgBox("Sale Complete")

                'Odersaleno.Text = gvtouchsale.Rows(k).Cells(5).Value
                If lblOderSale.Text <> "odersale" Then
                    Dim oderstatus As String = "sold"
                    create("update OdersConfig set status='" + oderstatus + "' where OderNo= '" & lblOderSale.Text & "' ")
                    create("update Odertranx set OderStatus = '" + oderstatus + "' where DayoderNo =" + lblOderSale.Text + "")

                    MsgBox("Oder Status Updated")


                End If

                DisplayOders()
                MsgBox("StockMast Updated")
                lblTotal.Text = ""
                Clear()
                gvtouchsale.Rows.Clear()
                DisplayOders()
                frmTouchSale_Load(Nothing, Nothing)

            End Try
        End If
        If (cbSaleType.SelectedIndex = 1 Or cbSaleType.Text = "Credit-Sale") Then
            'cbCreditCustName.Visible = True
            'lblCreditCust.Visible = True
            Dim a = Val(lblTotal.Text)
            Dim b = Val(lblOldBal.Text)
            Dim sum = b - a
            lblNewBal.Text = sum
            If cbcreditcustname.Text = "" Then
                MsgBox("Choose customer")
                Exit Sub
            End If

            Try
                'reciept()

                For Each row As DataGridViewRow In gvtouchsale.Rows
                    create("insert into salestranx (ItemCode,ItemName,ProdLine,ProdCat,QtySold,DateSold,TimeSold,BuyerName,BuyerTel,BuyerLocation,NewStock,RetailPrice,SaleType,CredCustName,Amount,Soldby,RecieptNo,AmtPaid,Balance) values('" & row.Cells(0).Value & "','" & row.Cells(1).Value & "','" & row.Cells(8).Value & "','" & row.Cells(7).Value & "','" & row.Cells(3).Value & "','" & lbldate.Text & "','" & lbltime.Text & "','" & txtBuyerName.Text & "','" & txtBuyerTel.Text & "','" & cbLocation.Text & "','" & row.Cells(10).Value & "','" & row.Cells(2).Value & "','" & cbSaleType.Text & "','" & cbcreditcustname.Text & "','" & row.Cells(4).Value & "','" + tsUser.Text + "', '" + lblRecieptNo.Text + "','" + txtCashPaid.Text + "','" + lblChange.Text + "')")
                    create("update StockMast set prodqty = prodqty - '" & row.Cells(3).Value & "' where Prodcode= '" & row.Cells(0).Value & "'")
                    MsgBox("You Reach") ''''''''''''''''''''''''''
                Next
            Finally
                create("Insert into CustomerLedger(CustomerName,oldbal,Newbal,CreditRecieved,DateRecieved,TimeRecieved,CustomerNo)Values('" + cbcreditcustname.Text + "','" + lblOldBal.Text + "','" + lblNewBal.Text + "','" + lblTotal.Text + "','" + lbldate.Text + "','" + lbltime.Text + "','" + lblCustNo.Text + "')")
                create("update Customer set CurrentBalance = currentbalance + '" & lblTotal.Text & "' where CustomerNo = " + lblCustNo.Text + "")

                MsgBox("Customer Updated") '''''''''''''''''''''''''''''''
                RollReciept(lblRecieptNo.Text)
                ShowConfig()
                MsgBox("StockMast Updated") '''''''''''''''''''''''''

                gvtouchsale.Rows.Clear()
                lblTotal.Text = ""
                Clear()
                DisplayOders()
                frmTouchSale_Load(Nothing, Nothing)
            End Try
        End If
        'If cbSaleType.Text = "" Or cbSaleType.Text = "Credit Sale" Then
        'cbCreditCustName.Visible = False
        'Else
        '  cbCreditCustName.Visible = True

        '     End If                   

        'Catch ex As Exception
        '  MsgBox(ex.ToString)
        'End Try

        ShowConfig()
    End Sub

    Sub RollReciept(valuetosearch As String)
        Try
            If Poscon.State = ConnectionState.Closed Then
                Poscon.Open()
            End If

            Dim que = "select * from recieptconfig"
            cmd = New SqlCommand(que, Poscon)
            da = New SqlDataAdapter(cmd)
            Dim table As New DataTable
            da.Fill(table)
            Dim query = "select * from SalesTranx where recieptno='" + valuetosearch + "'"
            cmd = New SqlCommand(query, Poscon)
            dt.Tables("salesTranx").Rows.Clear()
            da.SelectCommand = cmd
            da.Fill(dt, "salesTranx")

            Dim sql = "select * from ClientReg"
            dt.Tables("ClientReg").Rows.Clear()
            cmd = New SqlCommand(sql, Poscon)
            da.SelectCommand = cmd
            da.Fill(dt, "ClientReg")

            Dim report As New rptSalesReciept
            report.SetDataSource(dt)
            If ckprint.Checked = True Then
                report.PrintToPrinter(1, True, 0, 0)
            End If
            If ckprintpreview.Checked = True Then
                frmSupplierReport.Show()
                frmSupplierReport.CrystalReportViewer1.ReportSource = report
                frmSupplierReport.CrystalReportViewer1.Refresh()
            End If
            cmd.Dispose()
            da.Dispose()
            Poscon.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub gvOders_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles gvOders.CellDoubleClick
        Try
            Dim row As DataGridViewRow = gvOders.Rows(e.RowIndex)
            'lblOderNo.Text = row.Cells(0).Value.ToString()
            lblOderSale.Text = row.Cells(3).Value.ToString()
            lbldayodersale.Text = row.Cells(0).Value.ToString()
            LoadOderSale()
            btnSell.Visible = True
            btnOder.Visible = False
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub BunifuThinButton25_Click(sender As Object, e As EventArgs) Handles BunifuThinButton25.Click
        ds.Tables("OderReciept").Rows.Clear()

        For Each row As DataGridViewRow In gvOderDetails.Rows
            ds.Tables("OderReciept").Rows.Add(row.Cells(2).Value, row.Cells(3).Value, row.Cells(4).Value)
        Next
        Dim report As New rptOderReciept
        report.SetDataSource(ds)
        report.PrintToPrinter(1, True, 0, 0)
        'frmSupplierReport.Show()
        'frmSupplierReport.CrystalReportViewer1.ReportSource = report
        'frmSupplierReport.CrystalReportViewer1.Refresh()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If txtPrice.Text = "" Then
            MsgBox("Select an item to sell")
            Exit Sub
        End If
        For Each row As DataGridViewRow In gvtouchsale.Rows
            If lblProdCode.Text = row.Cells(0).Value Then
                row.Cells(3).Value += Val(txtQty.Text)
                row.Cells(4).Value = row.Cells(3).Value * row.Cells(2).Value
                row.Cells(10).Value -= Val(txtQty.Text)
                Try
                    Dim sum As Double
                    For k = 0 To gvtouchsale.RowCount - 1
                        sum += gvtouchsale.Rows(k).Cells(4).Value
                    Next
                    lblTotal.Text = sum
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
                dr.Close()
                Poscon.Close()
                txtQty.Text = ""
                txtPrice.Text = ""
                txtAmt.Text = ""
                Exit Sub
            End If

        Next
        gvtouchsale.Rows.Add(lblProdCode.Text, lblItemName.Text, txtPrice.Text, txtQty.Text, txtAmt.Text, lblDayOder.Text, "Pending", lblCat.Text, lblprodline.Text, lblRecieptNo.Text, one.Text, one.Text, lblOderNo.Text)
        txtQty.Text = ""
        txtPrice.Text = ""
        txtAmt.Text = ""
    End Sub

    Private Sub txtQty_KeyUp(sender As Object, e As KeyEventArgs) Handles txtQty.KeyUp
        txtAmt.Text = Val(txtPrice.Text) * Val(txtQty.Text)
    End Sub

    Private Sub cbWaiterSearch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbWaiterSearch.SelectedIndexChanged
        SearchWaiters(cbWaiterSearch.Text)
    End Sub

    Private Sub ckDirectsale_CheckedChanged(sender As Object, e As Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs)
        If ckDirectsale.Checked = True Then
            btnSell.Visible = False
            btnOder.Visible = True
        Else
            btnSell.Visible = True
            btnOder.Visible = False
        End If
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs)
        btnSell.Visible = True
        btnOder.Visible = False
    End Sub

    Private Sub ckdirectsale_CheckedChanged(sender As Object, e As EventArgs) Handles ckdirectsale.CheckedChanged
        If ckdirectsale.Checked = True Then
            btnSell.Visible = True
            btnOder.Visible = False
        Else
            btnSell.Visible = False
            btnOder.Visible = True
        End If
    End Sub

    Private Sub txtQty_Enter(sender As Object, e As EventArgs) Handles txtQty.Enter
        System.Diagnostics.Process.Start("osk.exe")
    End Sub

    Private Sub txtQty_Leave(sender As Object, e As EventArgs) Handles txtQty.Leave

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        action = "btnsearch"
        LoadItems()
    End Sub

    Private Sub cbcreditcustname_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbcreditcustname.SelectedIndexChanged
        Searchc(cbcreditcustname.Text)
    End Sub
    Public Sub Searchc(valuetosearch As String)
        Try
            If Poscon.State = ConnectionState.Closed Then
                Poscon.Open()
            End If
            Dim query = "select * from customer where concat(customername,Customerno) like '%" + valuetosearch + "%'"
            cmd = New SqlCommand(query, Poscon)
            da = New SqlDataAdapter(cmd)
            tbl = New DataTable()
            da.Fill(tbl)
            lblOldBal.Text = tbl.Rows(0)(10).ToString
            lblCustNo.Text = tbl.Rows(0)(0).ToString
            'lblcusttype.Text = tbl.Rows(0)(12).ToString
            Dim newbal = Val(lblOldBal.Text) + Val(lblTotal.Text)
            lblNewBal.Text = newbal
            Poscon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub display()
        ComboFeed("select customername from customer", cbcreditcustname, 0)
    End Sub

    Private Sub cbcreditcustname_Click(sender As Object, e As EventArgs) Handles cbcreditcustname.Click
        ComboFeed("select customername from customer", cbcreditcustname, 0)
    End Sub

    Private Sub cbSaleType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSaleType.SelectedIndexChanged
        If (cbSaleType.SelectedIndex = 1) Then
            txtBuyerName.Enabled = False
            txtCashPaid.Enabled = False
            txtBuyerTel.Enabled = False
            cbLocation.Enabled = False
            cbPaymode.Enabled = False
            cbcreditcustname.Visible = True
            lblCreditCust.Visible = True
            txtCashPaid.Text = 0
        ElseIf (cbSaleType.SelectedIndex = 0) Then
            cbPaymode.Enabled = True
            txtBuyerName.Enabled = True
            txtCashPaid.Enabled = True
            txtBuyerTel.Enabled = True
            cbLocation.Enabled = True
            cbcreditcustname.Visible = False
            lblCreditCust.Visible = False
        End If
    End Sub

    Private Sub cbWaiterSearch_TextChanged(sender As Object, e As EventArgs) Handles cbWaiterSearch.TextChanged
        SearchWaiters(cbWaiterSearch.Text)
    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click
        frmMain.Show()
    End Sub
End Class