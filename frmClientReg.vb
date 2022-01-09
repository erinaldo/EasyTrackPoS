Imports System.Data.SqlClient
Imports System.IO
Public Class frmClientReg
    'Dim As New SqlConnection(My.Settings.PoSConnectionString)
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader
    Dim da As SqlDataAdapter

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim opf As New OpenFileDialog
        opf.Filter = "Choose Image(*.JPG;*.PNG;*GIF,*ICO)|*.jpg;*.png;*.gif*.ICO"
        If opf.ShowDialog = Windows.Forms.DialogResult.OK Then
            pbClientLogo.Image = Image.FromFile(opf.FileName)
            txtClientLogo.Text = opf.FileName.ToString()
        End If

    End Sub

    Private Sub frmClientReg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MaximumSize = Screen.FromRectangle(Me.Bounds).WorkingArea.Size
        WindowState = FormWindowState.Maximized
        search()
    End Sub

    Public Sub search()
        Try
            'Dim arrimage As Byte
            If Poscon.State = ConnectionState.Closed Then
                Poscon.Open()
            End If
            Dim query = "select * from ClientReg"
            cmd = New SqlCommand(query, Poscon)
            Dim adapter As New SqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)
            If table.Rows.Count() = 0 Then
            Else
                txtClientName.Text = table.Rows(0)(1).ToString()
                TxtLocation.Text = table.Rows(0)(2).ToString()
                txtBranchTel.Text = table.Rows(0)(7).ToString()
                txtTradingName.Text = table.Rows(0)(10).ToString()
                txtBranchName.Text = table.Rows(0)(4).ToString()
                txtBusinessDesc.Text = table.Rows(0)(8).ToString()
                txttermsoftrade.Text = table.Rows(0)(3).ToString()
                txtCompanyContact.Text = table.Rows(0)(6).ToString()
                'arrimage = table.Rows(0)(9).ToString
                'Dim mstream As New System.IO.MemoryStream(arrimage)
                'pbClientLogo.Image = Image.FromStream(mstream)

            End If
            showimage()
            Poscon.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click

        Try
            If Poscon.State = ConnectionState.Closed Then
                Poscon.Open()
            End If

            Dim ms As New MemoryStream
            pbClientLogo.Image.Save(ms, pbClientLogo.Image.RawFormat)

            Dim query = "update ClientReg Set Companyname='" + txtClientName.Text + "',location= '" + TxtLocation.Text + "',termsoftrade='" + txttermsoftrade.Text + "',branchname='" + txtBranchName.Text + "',branchcontact='" + txtBranchTel.Text + "',companydealings='" + txtBusinessDesc.Text + "',tradingname='" + txtTradingName.Text + "',companycontact='" + txtCompanyContact.Text + "',companylogo=@img"
            cmd = New SqlCommand(query, Poscon)
            With cmd
                .Parameters.Add("@img", SqlDbType.Image).Value = ms.ToArray()
                .ExecuteNonQuery()
            End With
            MsgBox("Company details Successfully updated")
            Poscon.Close()
            search()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub
    Sub showimage()
        Dim quer = "select companylogo from clientreg"
        cmd = New SqlCommand(quer, Poscon)
        'dr = cmd.ExecuteReader
        'dr.Read()
        'Try


        '    If dr.HasRows Then
        '        Dim logo As Byte
        '        logo = dr("Companylogo")
        '        Dim ms As New MemoryStream(logo)
        '        pbClientLogo.Image = Image.FromStream(ms)
        '        pbClientLogo.SizeMode = PictureBoxSizeMode.StretchImage
        '    End If

        'Catch ex As Exception
        '    MsgBox(ex.ToString)
        'End Try
        da = New SqlDataAdapter(cmd)
        Dim ds As New DataSet()
        da.Fill(ds, "clientreg")
        If ds.Tables.Count = 0 Then
            Exit Sub
        End If
        Dim c As Integer = ds.Tables(0).Rows.Count
        If c > 0 Then
            Dim bytBLOBData() As Byte =
                ds.Tables(0).Rows(c - 1)("companylogo")
            Dim stmBLOBData As New MemoryStream(bytBLOBData)
            pbClientLogo.Image = Image.FromStream(stmBLOBData)

        End If
    End Sub
End Class