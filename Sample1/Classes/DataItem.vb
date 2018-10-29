Public Class DataItem
    Public Property Id() As Integer
    Public Property Display() As String
    Public Property Checked() As Boolean
    Public Overrides Function ToString() As String
        Return Display
    End Function
End Class
