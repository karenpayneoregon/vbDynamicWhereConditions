Imports System.ComponentModel
Imports Sample1.Classes

Public Class DatesBetweenForm
    WithEvents _bsRangeList As New BindingSource()
    Private _ops As DataOperations = New DataOperations
    Private _mockedData As New MockupData
    Private _validItems As List(Of DateTimeItem)
    Public ReadOnly Property ValidateRanges() As List(Of DateTimeItem)
        Get
            Return _validItems
        End Get
    End Property
    Private _sqlStatement As String
    Public ReadOnly Property Statement() As String
        Get
            Return _sqlStatement
        End Get
    End Property
    ''' <summary>
    ''' Add new row
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmdAddNewItem_Click(sender As Object, e As EventArgs) Handles cmdAddNewItem.Click
        _bsRangeList.AddNew()
    End Sub
    ''' <summary>
    ''' Triggered from above, set default values for new item
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub _bsRangeList_AddingNew(sender As Object, e As AddingNewEventArgs) Handles _bsRangeList.AddingNew
        If My.Application.IsAuthorMachineRunningUnderDebugger Then
            e.NewObject = _mockedData.NewItem(_bsRangeList)
        Else
            e.NewObject = New DateTimeItem With {.Process = True, .StartRange = Now, .EndRange = Now}
        End If
    End Sub
    ''' <summary>
    ''' Remove current item from DataGridView/BindingSource
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmdRemoveCurrentItem_Click(sender As Object, e As EventArgs) Handles cmdRemoveCurrentItem.Click
        If _bsRangeList.Count > 0 Then

            _bsRangeList.RemoveCurrent()
            ActiveControl = DataGridView1

            If DataGridView1.Rows.Count > 0 Then
                DataGridView1.Rows(DataGridView1.Rows.Count - 1).Selected = True
            End If

        End If
    End Sub
    ''' <summary>
    ''' Initialize objects to display/remember date ranges.
    ''' DataGridViewComboBox is setup in the designer.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        DataGridView1.AutoGenerateColumns = False
        _bsRangeList.DataSource = New List(Of DateTimeItem)
        ColumnNameColumn.DataSource = _ops.DateColumnNames()
        DataGridView1.DataSource = _bsRangeList
    End Sub
    ''' <summary>
    ''' Validate range(s) followed by creating SQL statement for valid items or
    ''' abort the process of creating the SQL statement.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmdCreateWhere_Click(sender As Object, e As EventArgs) Handles cmdCreateWhere.Click
        _validItems = New List(Of DateTimeItem)

        If _bsRangeList.Count > 0 Then

            DataGridView1.Rows.Cast(Of DataGridViewRow).ToList().ForEach(Sub(row) row.ErrorText = "")
            Dim processResult = CType(_bsRangeList.DataSource, List(Of DateTimeItem)).
                    Where(Function(data) data.Process AndAlso Not String.IsNullOrWhiteSpace(data.ColumnName))

            Dim incorrectResults = DataGridView1.Rows.Cast(Of DataGridViewRow).
                    Where(Function(row) CType(row.Cells("ProcessColumn").Value, Boolean) = True _
                                        AndAlso row.Cells("ColumnNameColumn").Value Is Nothing).
                    Select(Function(row) row.Index)


            If incorrectResults.Count() > 0 Then
                For index As Integer = 0 To incorrectResults.Count()
                    DataGridView1.Rows(incorrectResults(index)).ErrorText = "Missing column name"
                Next
            End If

            Console.WriteLine(incorrectResults.Count())

            For Each item In processResult
                If item.StartRange.IsValidRange(item.EndRange) Then
                    _validItems.Add(item)
                End If
            Next

            If _validItems.Count > 0 Then

                Dim generator As New BetweenGenerator

                If My.Application.IsAuthorMachineRunningUnderDebugger Then
                    Console.WriteLine(
                        generator.CreateDatesBetween(_ops.OrdersBetweenStatement(), _validItems))
                End If

                _sqlStatement = generator.CreateDatesBetween(_ops.OrdersBetweenStatement(), _validItems)

                Dim dt As DataTable = _ops.ReadDateRange(_sqlStatement)
                If _ops.IsSuccessFul Then
                    MainDataGridView.DataSource = dt
                    lblCount.Text = dt.Rows.Count.ToString()
                Else
                    MessageBox.Show(_ops.LastExceptionMessage)
                End If

            ElseIf _validItems.Count = 0 AndAlso _bsRangeList.Count > 0 Then
                MessageBox.Show($"One or more ranges are invalid.{Environment.NewLine}Please correct.")
            End If
        End If

    End Sub
End Class
