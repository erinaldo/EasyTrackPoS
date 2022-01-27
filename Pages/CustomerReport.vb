Imports System.Data.SqlClient
Public Class CustomerReport
    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        Dim selectedindex = cbReport.SelectedIndex
        Select Case selectedindex
            Case 0

            Case 1

            Case 2

            Case 3

            Case 4

            Case Else
                MsgBox("Kindly Choose a Report to View")
        End Select
    End Sub
End Class
