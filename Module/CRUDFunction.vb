'Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine.ReportDocument
Module CRUDFunction
    Public result As String
    Public cmd As New SqlCommand
    Public da As New SqlDataAdapter
    Public tbl As New DataTable
    Public ds As New DataSet
    Public dr As SqlDataReader
    Public outto As Date
    Public outfrom As Date

#Region "Report"
    Public Sub reports(ByVal sql As String, ByVal rptname As String, ByVal crystalRpt As Object)
        '
        Try
            If Poscon.State = ConnectionState.Closed Then
                Poscon.Open()
            End If

            Dim reportname As String
            With cmd
                .Connection = Poscon
                .CommandText = sql
            End With
            ds = New DataSet
            da = New SqlDataAdapter(sql, Poscon)
            da.Fill(ds)
            reportname = rptname
            Dim reportdoc = "" 'As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            Dim strReportPath As String
            strReportPath = Application.StartupPath & "\SalesMenu\" & reportname & ".rpt"
            '    "K:\Daakye\FoodApplication\SalesMenu\rptProformaA4.rpt"

            With reportdoc
                '.Load(strReportPath)
                '.SetDataSource(ds.Tables(0))

            End With
            With crystalRpt
                .ShowRefreshButton = False
                .ShowCloseButton = False
                .ShowGroupTreeButton = False
                .ReportSource = reportdoc
            End With
            frmSupplierReport.Show()
        Catch ex As Exception
            MsgBox(ex.Message & "No Crystal Reports have been Installed")
        Finally
            If Poscon.State = ConnectionState.Open Then
                Poscon.Close()
                da.Dispose()
            End If
        End Try
        'poscon.Close()
        'da.Dispose()
    End Sub

    'THIS METHOD IS FOR INSERTING DATA IN THE DATABASE
    Public Sub create(ByVal sql As String)
        Try
            If Poscon.State = ConnectionState.Closed Then
                Poscon.Open()
            End If
            'HOLDS THE DATA TO BE EXECUTED
            With cmd
                .Connection = Poscon
                .CommandText = sql
                'EXECUTE THE DATA
                result = cmd.ExecuteNonQuery
                'CHECKING IF THE DATA HAS EXECUTED OR NOT AND THEN THE POP UP MESSAGE WILL APPEAR
                If result = 0 Then
                    MessageBox.Show("Failed ", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    'MessageBox.Show("Data has been inserted in the database.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End With
            Poscon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Poscon.Close()
        End Try

    End Sub
    Public Sub ComboFeed(ByVal sql As String, combo As ComboBox, row As Integer)
        Try
            If Poscon.State = ConnectionState.Closed Then
                Poscon.Open()
            End If
            With cmd
                .Connection = Poscon
                .CommandText = sql
                dr = cmd.ExecuteReader
                combo.Items.Clear()
                While dr.Read
                    combo.Items.Add(dr(row))

                End While

            End With
            Poscon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Public Sub Reader(ByVal sql As String, combo As ComboBox, row As Integer)
        If Poscon.State = ConnectionState.Closed Then
            Poscon.Open()
        End If
        With cmd
            .Connection = Poscon
            .CommandText = sql
            dr = cmd.ExecuteReader
            combo.Items.Clear()
            While dr.Read
                combo.Items.Add(dr(row))

            End While

        End With
        Poscon.Close()
    End Sub

    Public Sub createLogged(ByVal sql As String)
        Try
            If Poscon.State = ConnectionState.Closed Then
                Poscon.Open()
            End If
            'HOLDS THE DATA TO BE EXECUTED
            With cmd
                .Connection = Poscon
                .CommandText = sql
                'EXECUTE THE DATA
                result = cmd.ExecuteNonQuery
                'CHECKING IF THE DATA HAS EXECUTED OR NOT AND THEN THE POP UP MESSAGE WILL APPEAR
                If result = 0 Then
                    'MessageBox.Show("Data is failed to insert.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    'MessageBox.Show("Data has been inserted in the database.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Poscon.Close()
        End Try

    End Sub

    '    'THIS METHOD IS FOR RETRIEVING DATA IN THE DATABASE
    Public Sub reload(ByVal sql As String, ByVal DTG As Object)
        Try
            If Poscon.State = ConnectionState.Closed Then
                Poscon.Open()
            End If
            tbl = New DataTable
            With cmd
                .Connection = Poscon
                .CommandText = sql
            End With
            da.SelectCommand = cmd
            da.Fill(tbl)
            DTG.DataSource = tbl
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Poscon.Close()
            da.Dispose()
        End Try
    End Sub
#End Region
    Public Sub reloadtxt(ByVal sql As String)
        Try
            If Poscon.State = ConnectionState.Closed Then
                Poscon.Open()
            End If
            With cmd
                .Connection = Poscon
                .CommandText = sql
            End With
            tbl = New DataTable
            da = New SqlDataAdapter(sql, Poscon)
            da.Fill(tbl)

        Catch ex As Exception
            MsgBox(ex.Message & "reloadtxt")
        Finally
            If Poscon.State = ConnectionState.Open Then
                Poscon.Close()
                da.Dispose()
            End If
        End Try
    End Sub

    'THIS METHOD IS FOR UPDATING THE DATA IN THE DATABASE.
    Public Sub updates(ByVal sql As String)
        Try
            If Poscon.State = ConnectionState.Closed Then
                Poscon.Open()
            End If
            With cmd
                .Connection = Poscon
                .CommandText = sql
                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    MessageBox.Show("Data is failed to updated", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    'MessageBox.Show("Data has been updated in the database.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Poscon.Close()
        End Try
    End Sub

    'Mother UPDATE phone
    Public Sub StudentUpdatePhone(ByVal sql As String)
        Try
            If Poscon.State = ConnectionState.Closed Then
                Poscon.Open()
            End If
            With cmd
                .Connection = Poscon
                .CommandText = sql
                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    MessageBox.Show("Student information is failed to Saved", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    MessageBox.Show("Student has been added to parent list.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Poscon.Close()
        End Try
    End Sub

    Public Sub UpdatePhone(ByVal sql As String)
        Try
            If Poscon.State = ConnectionState.Closed Then
                Poscon.Open()
            End If
            With cmd
                .Connection = Poscon
                .CommandText = sql
                result = cmd.ExecuteNonQuery
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Poscon.Close()
        End Try
    End Sub
    'INSERT SMS 
    Public Sub insertd(ByVal sql As String)
        Try
            If Poscon.State = ConnectionState.Closed Then
                Poscon.Open()
            End If
            With cmd
                .Connection = Poscon
                .CommandText = sql
                result = cmd.ExecuteNonQuery
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Poscon.Close()
        End Try
    End Sub

    Public Sub Sql(ByVal sql As String)
        Try
            If Poscon.State = ConnectionState.Closed Then
                Poscon.Open()
            End If
            With cmd
                .Connection = Poscon
                .CommandText = sql
                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    MessageBox.Show("Data is failed to updated", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    ' MessageBox.Show("Data has been updated in the database.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Poscon.Close()

        End Try

    End Sub
    'THIS METHOD IS FOR DELETING THE DATA IN THE DATABASE
    Public Sub delete(ByVal sql As String)
        Try
            If Poscon.State = ConnectionState.Closed Then
                Poscon.Open()
            End If
            With cmd
                .Connection = Poscon
                .CommandText = sql
                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    MessageBox.Show("Data is failed to delete", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show("Data has been deleted in the database.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Poscon.Close()
        End Try
    End Sub

    Public Sub findRecords(sql As String, dtg As DataGridView)
        Try
            If Poscon.State = ConnectionState.Closed Then
                Poscon.Open()
            End If
            cmd = New SqlCommand
            With cmd
                .Connection = Poscon
                .CommandText = sql
            End With
            da = New SqlDataAdapter
            da.SelectCommand = cmd
            tbl = New DataTable
            da.Fill(tbl)
            dtg.DataSource = tbl
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Poscon.Close()
            da.Dispose()
        End Try
    End Sub
    Public Sub userc()
        frmSales.lblTotal.Visible = False
    End Sub


End Module
