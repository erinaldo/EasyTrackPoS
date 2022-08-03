Imports System.Data.SqlClient
Imports BarcodeLib
Public Class frmBarcodeGen
    'Dim poscon As New SqlConnection(My.Settings.PoSConnectionString)
    Dim dr As SqlDataReader
    Dim cmd As SqlCommand
    Private ds As New dsGenerateBarcode
    Private Sub frmBarcodeGen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Display()
        Me.MaximumSize = Screen.FromRectangle(Me.Bounds).WorkingArea.Size
        WindowState = FormWindowState.Maximized
    End Sub
    Private Sub Display()

        If poscon.State = ConnectionState.Closed Then
            poscon.Open()
        End If

        Dim query = "select prodname,prodcode,Retailprice from StockMast"
        cmd = New SqlCommand(query, poscon)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable()
        adapter.Fill(tbl)
        gvStockguna.DataSource = tbl
        poscon.Close()

    End Sub
    Private Sub Feel(valueTosearch As String)
        If poscon.State = ConnectionState.Closed Then
            poscon.Open()
        End If
        Dim query = "select prodname,prodcode,Retailprice from StockMast where concat(ProdName,ProdCode) like '%" + valueTosearch + "%'"
        Dim cmd = New SqlCommand(query, poscon)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable()
        adapter.Fill(table)
        gvStockguna.DataSource = table
        If table.Rows.Count() > 0 Then

        Else
            MsgBox("No Record")
        End If

        poscon.Close()


    End Sub
    Private Sub GenerateCode()
        Try
            Dim Barcode As New Barcode
            Dim forecolor = Color.Black
            Dim backcolor = Color.White
            Barcode.IncludeLabel = True
            Barcode.BarWidth = 1.5
            Dim barcodeimage As Image = Barcode.Encode(TYPE.CODE39, lblBarCode.Text, forecolor, backcolor, pbBarcode.Width, 75)
            pbBarcode.Image = barcodeimage
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub gvStockguna_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles gvStockguna.CellClick
        Try
            Dim row As DataGridViewRow = gvStockguna.Rows(e.RowIndex)
            lblBarCode.Text = row.Cells(1).Value.ToString()
            lblitemname.Text = row.Cells(0).Value.ToString()
            lblPrice.Text = row.Cells(2).Value.ToString()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub lblBarCode_TextChanged(sender As Object, e As EventArgs) Handles lblBarCode.TextChanged
        GenerateCode()
    End Sub
    Sub printBarcode(image As Image, lable As String)
        ds.Tables("dtbarcode").Rows.Clear()
        Dim barcodeimage As Byte()
        Dim barcodelabel As String
        Dim ms As New System.IO.MemoryStream
        image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
        Dim arrimage() As Byte = ms.ToArray

        barcodeimage = arrimage
        barcodelabel = lable
        For i As Integer = 0 To Int32.Parse(txtBarcodeQty.Text) - 1
            ds.Tables("dtbarcode").Rows.Add(arrimage, lable, lblPrice.Text, lblitemname.Text)
        Next


        Dim report As New rptGenBarCode
        report.SetDataSource(ds.Tables("dtbarcode"))
        frmSupplierReport.Show()
        frmSupplierReport.CrystalReportViewer1.ReportSource = report
        frmSupplierReport.CrystalReportViewer1.Refresh()

    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        If lblBarCode.Text = "" Then
            MsgBox("Select Barcode to preview")
            Exit Sub
        End If
        If txtBarcodeQty.Text = "" Then
            MsgBox("Enter Amount to Preview")
            Exit Sub
        End If
        printBarcode(pbBarcode.Image, lblBarCode.Text)
    End Sub
    Private Sub SearchBarcode(valueTosearch As String)
        If poscon.State = ConnectionState.Closed Then
            poscon.Open()
        End If
        Dim query = "select prodname,prodcode,Retailprice from StockMast where concat(ProdName,ProdCode) like '%" + valueTosearch + "%'"
        Dim cmd = New SqlCommand(query, poscon)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable()
        adapter.Fill(table)
        gvStockguna.DataSource = table


        If table.Rows.Count() > 0 Then

        Else
            'MsgBox("No Record")
        End If

        poscon.Close()


    End Sub
    Private Sub txtDelSearch_TextChanged(sender As Object, e As EventArgs) Handles txtBarcodeSearch.TextChanged
        SearchBarcode(txtBarcodeSearch.Text)
    End Sub
End Class