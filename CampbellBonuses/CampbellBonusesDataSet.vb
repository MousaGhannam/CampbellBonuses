Partial Class CampbellBonusesDataSet
    Partial Public Class Employee_BonusDataTable
        Private Sub Employee_BonusDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.EIDColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class
End Class

Namespace CampbellBonusesDataSetTableAdapters
    Partial Public Class Employee_BonusTableAdapter
    End Class

    Partial Public Class IncentivesInformationTableAdapter
    End Class
End Namespace
