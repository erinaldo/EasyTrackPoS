

Partial Class dsproforma
    Partial Public Class ProformaDataTable
        Private Sub ProformaDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.AmountColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class
End Class
