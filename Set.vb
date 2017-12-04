Partial Class _Set
    Partial Class OptionsDataTable

        Private Sub OptionsDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.StartupColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

End Class
