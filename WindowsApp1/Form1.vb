Public Class Form1
    Private _CityList As List(Of City)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ops As New Operations

        CheckedListBox1.DataSource = ops.Countries
        _CityList = ops.Cities


        Dim dt As New DataTable
        dt.Columns.Add(New DataColumn() With {.AutoIncrement = True, .AutoIncrementSeed = 1, .AutoIncrementStep = 1, .ColumnName = "C1", .DataType = GetType(Integer)})
        dt.Columns.Add(New DataColumn() With {.ColumnName = "C2", .DataType = GetType(String)})

        DataGridView1.DataSource = dt

    End Sub

    Private Sub CheckedListBox1_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles CheckedListBox1.ItemCheck
        If e.NewValue = CheckState.Checked Then
            For x As Integer = 0 To CheckedListBox1.Items.Count - 1
                If x <> e.Index Then
                    CheckedListBox1.SetItemChecked(x, False)
                End If
            Next
            ListBox1.Items.Clear()
            Dim item As Country = CType(CType(sender, CheckedListBox).Items(e.Index), Country)

            Dim results = _CityList.Where(Function(c) c.CountryId = item.Id).ToList()

            For Each city In results
                ListBox1.Items.Add(city.Name)
            Next
        End If
    End Sub
End Class
Public Class Country
    Public Property Id() As Integer
    Public Property Name() As String

    Public Overrides Function ToString() As String
        Return Name
    End Function
End Class
Public Class City
    Public Property CountryId() As Integer
    Public Property Name() As String

End Class
Public Class Operations
    Public ReadOnly Property Countries() As List(Of Country)
        Get
            Return New List(Of Country) From
                {
                    New Country() With {.Id = 1, .Name = "Germany"},
                    New Country() With {.Id = 2, .Name = "Mexico"},
                    New Country() With {.Id = 3, .Name = "Spain"}
                }
        End Get
    End Property
    Public ReadOnly Property Cities() As List(Of City)
        Get
            Return New List(Of City) From
                {
                    New City() With {.CountryId = 2, .Name = "Cancuin"},
                    New City() With {.CountryId = 2, .Name = "Merida"},
                    New City() With {.CountryId = 2, .Name = "Pueida"},
                    New City() With {.CountryId = 1, .Name = "Berlin"},
                    New City() With {.CountryId = 1, .Name = "Hamberg"},
                    New City() With {.CountryId = 1, .Name = "Bonn"},
                    New City() With {.CountryId = 3, .Name = "Bibao"},
                    New City() With {.CountryId = 3, .Name = "Cadiz"},
                    New City() With {.CountryId = 3, .Name = "Seville"}
                }
        End Get
    End Property
End Class