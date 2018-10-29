Namespace Classes
    Public Class BetweenGenerator
        ''' <summary>
        ''' Generate multiple between clauses for dates
        ''' </summary>
        ''' <param name="pSelectStatement">Full select statement without where clause</param>
        ''' <param name="pList">Range list</param>
        ''' <returns>SELECT with WHERE conditions</returns>
        ''' <remarks>
        ''' Farther expansion could provide ORDER BY
        ''' </remarks>
        Public Function CreateDatesBetween(pSelectStatement As String, pList As List(Of DateTimeItem)) As String

            Dim sb As New Text.StringBuilder

            sb.Append(" WHERE ")

            For Each item In pList
                If item.Process Then
                    sb.Append($"O.{item.ColumnName} BETWEEN '{item.StartRange.ToString("yyyy-MM-dd")}' AND '{item.EndRange.ToString("yyyy-MM-dd")}' OR ")
                End If
            Next

            Return String.Concat(pSelectStatement, sb.ToString.Substring(0, sb.ToString.LastIndexOf(" OR", StringComparison.Ordinal)))

        End Function
    End Class
End Namespace