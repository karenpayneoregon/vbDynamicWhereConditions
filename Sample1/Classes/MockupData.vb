Namespace Classes
    Public Class MockupData
        Public Function NewItem(pBindingSource As BindingSource) As DateTimeItem
            If pBindingSource.Count = 0 Then
                Return New DateTimeItem With {.Process = True, .StartRange = New DateTime(2014, 7, 24), .EndRange = New DateTime(2014, 9, 5), .ColumnName = "ShippedDate"}
            ElseIf pBindingSource.Count = 1 Then
                Return New DateTimeItem With {.Process = True, .StartRange = New DateTime(2014, 9, 5), .EndRange = New DateTime(2014, 10, 9), .ColumnName = "ShippedDate"}
            Else
                Return New DateTimeItem With {.Process = True, .StartRange = Now, .EndRange = Now}
            End If
        End Function
    End Class
End Namespace