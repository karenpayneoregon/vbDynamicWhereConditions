Imports System.Data.SqlClient

Namespace Classes
    Public Class DataOperations
        Inherits BaseSqlServerConnection
        ''' <summary>
        ''' Get all DateTime columns
        ''' </summary>
        ''' <returns></returns>
        Public Function DateColumnNames() As List(Of String)
            Dim dateColumns As New List(Of String)
            Dim selectStatement = "SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS " &
                                  "WHERE TABLE_NAME = 'Orders' AND DATA_TYPE = 'datetime'"

            Using cn As New SqlConnection With {.ConnectionString = ConnectionString}
                Using cmd As New SqlCommand With {.Connection = cn, .CommandText = selectStatement}
                    cn.Open()
                    Dim reader = cmd.ExecuteReader()
                    While reader.Read()
                        dateColumns.Add(reader.GetString(0))
                    End While
                End Using
            End Using

            Return dateColumns

        End Function
        Public Function Countries() As List(Of DataItem)
            Dim results As New List(Of DataItem)
            Dim selectStatement = "SELECT id,CountryName  FROM dbo.Countries"

            Using cn As New SqlConnection With {.ConnectionString = ConnectionString}
                Using cmd As New SqlCommand With {.Connection = cn, .CommandText = selectStatement}
                    cn.Open()
                    Dim reader = cmd.ExecuteReader()
                    While reader.Read()
                        results.Add(New DataItem() With {.Id = reader.GetInt32(0), .Display = reader.GetString(1)})
                    End While
                End Using
            End Using

            Return results

        End Function
        Public Function Contacts() As List(Of DataItem)
            Dim results As New List(Of DataItem)
            Dim selectStatement = "SELECT  ContactTypeIdentifier,ContactTitle FROM NorthWindAzure2.dbo.ContactType"

            Using cn As New SqlConnection With {.ConnectionString = ConnectionString}
                Using cmd As New SqlCommand With {.Connection = cn, .CommandText = selectStatement}
                    cn.Open()
                    Dim reader = cmd.ExecuteReader()
                    While reader.Read()
                        results.Add(New DataItem() With {.Id = reader.GetInt32(0), .Display = reader.GetString(1)})
                    End While
                End Using
            End Using

            Return results

        End Function
        Public Function ReadDateRange(pSelectStatement As String) As DataTable
            Dim dtResults As New DataTable
            mHasException = False
            Using cn As New SqlConnection With {.ConnectionString = ConnectionString}
                Using cmd As New SqlCommand With {.Connection = cn, .CommandText = pSelectStatement}
                    Try
                        cn.Open()
                        dtResults.Load(cmd.ExecuteReader())
                    Catch ex As Exception
                        mHasException = True
                        mLastException = ex
                    End Try
                End Using
            End Using

            Return dtResults
        End Function
        Public Function ReadInContactsAndCountries(pContacts As String, pCountries As String) As DataTable
            Dim contactsClause = ""
            If pContacts <> "()" Then
                contactsClause = $"CT.ContactTypeIdentifier IN {pContacts}"
            End If

            Dim countriesClause = ""
            If pCountries <> "()" Then
                countriesClause = $"dbo.Countries.id IN {pCountries}"
            End If

            Dim whereCondition = ""

            If Not String.IsNullOrWhiteSpace(contactsClause) AndAlso Not String.IsNullOrWhiteSpace(countriesClause) Then
                whereCondition = String.Join(" AND ", {contactsClause, countriesClause})
            ElseIf Not String.IsNullOrWhiteSpace(contactsClause) Then
                whereCondition = contactsClause
            ElseIf Not String.IsNullOrWhiteSpace(countriesClause) Then
                whereCondition = countriesClause
            End If

            Dim dtResults As New DataTable

            mHasException = False

            If Not String.IsNullOrWhiteSpace(whereCondition) Then
                Using cn As New SqlConnection With {.ConnectionString = ConnectionString}
                    Using cmd As New SqlCommand With {.Connection = cn}
                        Try
                            cmd.CommandText = String.Concat(InClauseStatement(), " WHERE ", whereCondition)
                            cn.Open()

                            dtResults.Load(cmd.ExecuteReader())

                            ' hide some columns as in this code sample DataGridView columns are auto generated
                            ' as aposed to the code sample for dates where columns are generated in the designer.
                            dtResults.Columns("CustomerIdentifier").ColumnMapping = MappingType.Hidden
                            dtResults.Columns("ContactIdentifier").ColumnMapping = MappingType.Hidden
                            dtResults.Columns("ContactTypeIdentifier").ColumnMapping = MappingType.Hidden
                            dtResults.Columns("CountryIdentfier").ColumnMapping = MappingType.Hidden
                            dtResults.Columns("InUse").ColumnMapping = MappingType.Hidden

                        Catch ex As Exception
                            mHasException = True
                            mLastException = ex
                        End Try
                    End Using
                End Using
            End If

            Return dtResults
        End Function
        Public Function InClauseStatement() As String
            Return _
                <SQL>
SELECT  C.CustomerIdentifier ,
        C.CompanyName ,
        C.ContactName ,
        C.ContactIdentifier ,
        C.ContactTypeIdentifier ,
        CT.ContactTitle ,
        C.Street ,
        C.City ,
        C.PostalCode ,
        C.CountryIdentfier ,
        Countries.CountryName ,
        C.Phone ,
        C.ModifiedDate ,
        C.InUse
FROM    Customers AS C
        INNER JOIN ContactType AS CT ON C.ContactTypeIdentifier = CT.ContactTypeIdentifier
        INNER JOIN Countries ON C.CountryIdentfier = Countries.id
        </SQL>.Value
        End Function
        Public Function OrdersBetweenStatement() As String
            Return _
                <SQL>
SELECT  C.CompanyName ,
        O.OrderID ,
        E.FirstName + ' ' + E.LastName AS Employee ,
		FORMAT(O.OrderDate,'MM-dd-yyyy') AS Ordered,
        FORMAT(O.RequiredDate,'MM-dd-yyyy') AS [Required],
        FORMAT(O.ShippedDate,'MM-dd-yyyy') AS Shipped,
        Shippers.CompanyName AS ShipperName ,
        O.Freight ,
        O.ShipAddress ,
        O.ShipCity ,
        O.ShipPostalCode ,
        O.ShipCountry
FROM    Orders AS O
        INNER JOIN Customers AS C ON O.CustomerIdentifier = C.CustomerIdentifier
        INNER JOIN Employees AS E ON O.EmployeeID = E.EmployeeID
        INNER JOIN Shippers ON O.ShipVia = Shippers.ShipperID
        </SQL>.Value
        End Function
    End Class
End Namespace