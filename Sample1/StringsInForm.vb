Imports Sample1.Classes

Public Class StringsInForm
    Private _ops As DataOperations = New DataOperations
    ''' <summary>
    ''' Load CheckedListBoxes with references tables
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub StringsInForm_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Dim contacts = _ops.Contacts()
        Dim countries = _ops.Countries()

        contactsCheckedListBox.DataSource = contacts
        contriesCheckedListBox.DataSource = countries

        '
        ' The remainder of code is for demoing
        '
        If My.Application.IsAuthor Then
            Dim germany = countries.
                    Select(Function(item, index) New With {.Data = item, .Index = index}).
                    FirstOrDefault(Function(item) item.Data.Display = "Germany")

            contriesCheckedListBox.SetItemChecked(germany.Index, True)

            Dim contactsToCheck As New List(Of String) From {"Sales Representative", "Order Administrator", "Owner"}

            For Each contactItem In contactsToCheck
                Dim cItem = contacts.
                        Select(Function(item, index) New With {.Data = item, .Index = index}).
                        FirstOrDefault(Function(item) item.Data.Display = contactItem)

                contactsCheckedListBox.SetItemChecked(cItem.Index, True)
            Next

            cmdCreateWhere.PerformClick()
        Else
            '
            ' Nothing selected
            '
        End If


    End Sub
    ''' <summary>
    ''' Get checked items, create a comma separated string enclosed in () for
    ''' both contacts and countries and pass them to the data operation to query
    ''' the backend database tables.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmdCreateWhere_Click(sender As Object, e As EventArgs) Handles cmdCreateWhere.Click
        MainDataGridView.DataSource = Nothing

        Dim contacts = $"({String.Join(",", contactsCheckedListBox.Items.Cast(Of DataItem).
                                            Where(Function(item) item.Checked).Select(Function(item) item.Id))})"

        Dim countries = $"({String.Join(",", contriesCheckedListBox.Items.Cast(Of DataItem).
                                            Where(Function(item) item.Checked).Select(Function(item) item.Id))})"

        If contacts = "()" AndAlso countries = "()" Then
            MessageBox.Show("Please make one or more selections")
            Exit Sub
        End If

        Dim dt As DataTable = _ops.ReadInContactsAndCountries(contacts, countries)

        If _ops.IsSuccessFul AndAlso dt.Rows.Count > 0 Then
            MainDataGridView.DataSource = dt
        ElseIf _ops.HasException Then
            MessageBox.Show(_ops.LastExceptionMessage)
        End If

    End Sub

    Private Sub contactsCheckedListBox_ItemCheck(sender As Object, e As ItemCheckEventArgs) _
        Handles contactsCheckedListBox.ItemCheck, contriesCheckedListBox.ItemCheck

        CType(CType(sender, CheckedListBox).Items(e.Index), DataItem).Checked =
            If(e.NewValue = CheckState.Checked, True, False)

    End Sub
End Class