Imports System.Data.SqlClient
Public Class frmsimplesale
    Dim ds As New dsSalesTranx
    Dim dt As New dsStockMast
    Private Sub frmsimplesale_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsStockMast.StockMast' table. You can move, or remove it, as needed.
        Me.StockMastTableAdapter.Fill(Me.DsStockMast.StockMast)
        'ComboFeed("select prodcode from stockmast", txtProdname, 0)
        'txtProdname.DataSource = dt.Tables()
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        'If Date.Parse(lblDate.Text) <> Date.Now.ToString("dd/MM/yyyy") Then
        '    MsgBox("Date Conflict. Kindly adjust Computer Date to " & lblDate.Text & "")
        '    Exit Sub
        'End If

        If Val(txtCashPaid.Text) < Val(lblTotal.Text) Then
            MsgBox("Cash paid not enough", vbCritical)
            Exit Sub
        End If


        If gvSales.RowCount = 0 Then
            MsgBox("Fill sale Cart", vbCritical)
            Exit Sub
        End If


        If Poscon.State = ConnectionState.Closed Then
            Poscon.Open()
        End If

        For Each row As DataGridViewRow In gvSales.Rows
            create("insert into salestranx (ItemCode,ItemName,ProdLine,ProdCat,QtySold,DateSold,NewStock,RetailPrice,SaleType,CredCustName,Amount,Soldby,RecieptNo,AmtPaid,Balance,waiter,amountpayable) 
            values('" & row.Cells(0).Value & "','" & row.Cells(1).Value & "','" & row.Cells(8).Value & "','" & row.Cells(7).Value & "','" & row.Cells(3).Value & "',convert(datetime,'" & Date.Now & "',105),'" & row.Cells(10).Value & "','" & row.Cells(2).Value & "','" & "Walkin" & "','" & "Walkin" & "','" & row.Cells(4).Value & "','" & Activeuser.Text & "', '" & lblRecieptNo.Text & "','" & txtCashPaid.Text & "','" & lblChange.Text & "','" & "Walkin" & "','" & lblTotal.Text & "')")

            create("update StockMast set prodqty = prodqty - '" & row.Cells(3).Value & "' where Prodcode= '" & row.Cells(5).Value & "'")

            create("insert into InventoryLedger (ItemCode,itemname,tranxtype,TranxSource,TranxGroup,oldqty,qtyIssued,StockBalance,Userid,RetailPrice,CostPrice,RetailAmt,CostAmt,date) 
            values('" & row.Cells(5).Value & "','" & row.Cells(0).Value & "','" & "issued" & "','" & "Sales" & "','" & row.Cells(4).Value & "',
            '" & row.Cells(15).Value & "','" & row.Cells(1).Value & "','" & row.Cells(8).Value & "','" & Activeuser.Text & "','" & row.Cells(5).Value & "',
            '" & row.Cells(5).Value & "','" & row.Cells(5).Value & "','" & row.Cells(5).Value & "',convert(datetime,'" & Date.Now & "',105))")

        Next
        print()
        ' MsgBox("success")


        lblTotal.Text = ""

        gvSales.Rows.Clear()


    End Sub


    Public Sub FillSale(valueTosearch As String)

        Try
            If Poscon.State = ConnectionState.Closed Then
                Poscon.Open()
            End If

            Dim query = "select ProdName,ProdQty,retailprice,Prodsize,ProdCat,ProdColour,Prodline,ProdCode from StockMast where ProdCode = '" & valueTosearch & "'"
            cmd = New SqlCommand(query, Poscon)
            da = New SqlDataAdapter(cmd)
            tbl = New DataTable()
            da.Fill(tbl)
            'ListBox1.DataSource = tbl
            'reload("select ProdName,ProdQty,retailprice,Prodsize,ProdCat,ProdColour,Prodline,ProdCode from StockMast where concat(ProdName,ProdCode) like '%" + valueTosearch + "%'", gvStock)
            If tbl.Rows.Count = 1 Then
                cbProdName.Text = tbl.Rows(0)(0).ToString
                lblProdName.Text = tbl.Rows(0)(0).ToString
                'lblProdName.Text = table.Rows(0)(0).ToString + " " + "(" + txtProdline.Text + ")"
                txtPrice.Text = tbl.Rows(0)(2).ToString
                'lblActualStock.Text = tbl.Rows(0)(1).ToString
                txtProdcode.Text = tbl.Rows(0)(7).ToString
                txtProdline.Text = tbl.Rows(0)(6).ToString
                txtCat.Text = tbl.Rows(0)(4).ToString
                txtSize.Text = tbl.Rows(0)(3).ToString
                txtColour.Text = tbl.Rows(0)(5).ToString

                gvSales.Rows.Add(tbl.Rows(0)(0).ToString, 1, tbl.Rows(0)(2).ToString, tbl.Rows(0)(2).ToString, tbl.Rows(0)(4).ToString, tbl.Rows(0)(7).ToString, tbl.Rows(0)(3).ToString, tbl.Rows(0)(6).ToString, tbl.Rows(0)(1).ToString, lblRecieptNo.Text, "0", "0", tbl.Rows(0)(2).ToString, "", tbl.Rows(0)(5).ToString, tbl.Rows(0)(2).ToString)
            Else

            End If

            Poscon.Close()
        Catch ex As Exception

        End Try

    End Sub
    Sub display()
        'gvStock.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.EnableResizing
        ' Or even better, use .DisableResizing. Most time consuming enum Is DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders

        'set it to false if Not needed
        'gvStock.RowHeadersVisible = False
        reload("select ProdName,ProdQty,retailprice,Prodsize,ProdCat,ProdColour,Prodline,ProdCode from StockMast ORDER BY Prodname asc", gvStock)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim sum As Decimal = 0
        Dim payable As Decimal = 0
        Dim DiscAmt As Decimal = 0
        For Each row As DataGridViewRow In gvSales.Rows
            If txtProdcode.Text = row.Cells(5).Value Then
                row.Cells(1).Value += Val(txtQty.Text)
                row.Cells(3).Value = row.Cells(1).Value * row.Cells(2).Value
                'Row.Cells(8).Value = (Val(lblActualStock.Text) - Val(Row.Cells(1).Value))
                row.Cells(12).Value = row.Cells(3).Value

                Try
                    For k = 0 To gvSales.RowCount - 1
                        If gvSales.Rows(k).Cells(10).ToString = "" Then
                            gvSales.Rows(k).Cells(12).Value = gvSales.Rows(k).Cells(3).Value
                            gvSales.Rows(k).Cells(11).Value = "0"
                        End If
                        sum += gvSales.Rows(k).Cells(3).Value
                        payable += gvSales.Rows(k).Cells(12).Value
                        DiscAmt += gvSales.Rows(k).Cells(11).Value
                    Next
                    lblTotal.Text = sum

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                Exit Sub

            End If
        Next
        Dim a = Val(txtQty.Text)
        Dim c = Val(txtQty.Text)
        Dim newstock = c - a
        gvSales.Rows.Add(lblProdName.Text, txtQty.Text, txtPrice.Text, txtAmt.Text, txtCat.Text, txtProdcode.Text, txtSize.Text, txtProdline.Text, newstock, lblRecieptNo.Text, "0", "0", txtAmt.Text, "", txtColour.Text, txtAmt.Text)

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Application.Exit()
    End Sub

    Private Sub txtProdname_TextChanged(sender As Object, e As EventArgs) Handles txtProdname.TextChanged

    End Sub

    Private Sub txtQty_TextChanged(sender As Object, e As EventArgs) Handles txtQty.TextChanged
        If txtQty.Text = "" Then
            Exit Sub
        End If
        Dim amt As Decimal
        amt = Val(txtQty.Text) * Val(txtPrice.Text)
        txtAmt.Text = amt
    End Sub



    Private Sub gvSales_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs)
        Try
            Dim sum As Decimal = 0
            Dim payable As Decimal = 0
            Dim discamt As Decimal = 0
            For k = 0 To gvSales.RowCount - 1
                If gvSales.Rows(k).Cells(10).ToString = "" Then
                    gvSales.Rows(k).Cells(12).Value = gvSales.Rows(k).Cells(3).Value
                    gvSales.Rows(k).Cells(11).Value = "0"
                End If
                sum += gvSales.Rows(k).Cells(3).Value
                payable += gvSales.Rows(k).Cells(12).Value
                discamt += gvSales.Rows(k).Cells(11).Value
            Next
            lblTotal.Text = sum

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtCashPaid_TextChanged(sender As Object, e As EventArgs) Handles txtCashPaid.TextChanged
        Dim CashPaid As Decimal = 0
        Dim change As Decimal = 0
        change = Val(txtCashPaid.Text) - Val(lblTotal.Text)
        lblChange.Text = change
    End Sub
    Public Sub print()
        ds.Tables("salestranx").Rows.Clear()

        For Each row As DataGridViewRow In gvSales.Rows
            ds.Tables("Salestranx").Rows.Add(1, row.Cells(2).Value, row.Cells(3).Value, row.Cells(4).Value)
        Next
        Dim report As New rptSalesReciept
        report.SetDataSource(ds)
        report.PrintToPrinter(1, True, 0, 0)
        'frmSupplierReport.Show()
        'frmSupplierReport.CrystalReportViewer1.ReportSource = report
        'frmSupplierReport.CrystalReportViewer1.Refresh()
    End Sub

    Private Sub txtProdname_TextUpdate(sender As Object, e As EventArgs) Handles txtProdname.TextUpdate

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        display()
    End Sub

    Private Sub lblProdName_Click(sender As Object, e As EventArgs) Handles lblProdName.Click
        frmMain.Show()
        Me.Dispose()
    End Sub

    Private Sub txtProdname_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtProdname.SelectedIndexChanged
        FillSale(txtProdname.Text)
    End Sub
End Class