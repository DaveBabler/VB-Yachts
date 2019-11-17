Public Class GlobalClass
    ' This class stores Global Variables as is suggested by the name. (Self referencing code!)
    ' initially tried an array for this, changing array size on the fly is not fun using list instead
    ' also needed this to be in a couple different classes
    ' Private strYachtTypes As String() = {"C & C", "Catalina", "Coronado", "Excalibur", "Hans Christian", "Hobie", "Ranger", "Wavelength"}  depreciated
    Public Shared lstYachtTypes As New List(Of String)
    Public Shared intCountYachtTypes As Integer = 0


    Public Shared Sub PopulateDomainWithList(ByVal lstItems As List(Of String), ByRef dmnToManipulate As DomainUpDown)
        'This populates an updown domain so that a selected item can be wholly removed from a list
        'This is why we are passing ByRef
        'Be advised forms where the list shows will require reloading upon successful execution of this Sub
        'Babler has made this function Generic because he feels he will need it again...someday.

        dmnToManipulate.Items.Clear()
        dmnToManipulate.Text = ""

        For Each strValue As String In lstYachtTypes
            dmnToManipulate.Items.Add(strValue)
        Next

        dmnToManipulate.SelectedIndex = 0
    End Sub

    Public Shared Sub PopulateComboBox(ByVal lstItems As List(Of String), ByRef cboBoxToPopulate As ComboBox)
        'Clears then populates a combo box!
        cboBoxToPopulate.Text = ""
        cboBoxToPopulate.Items.Clear()

        For Each strValue As String In lstItems
            Console.WriteLine("String list  value " & strValue)
            cboBoxToPopulate.Items.Add(strValue)
        Next
    End Sub

    'Public Shared Sub RemoveListItem(ByRef lstItems As List(Of String), ByVal strToStrip As String)
    '    'The code below is one way of doing it if you really need to worry about Indecies (or is it Indexes)
    '    'Dim idxOfThing = GlobalClass.lstYachtTypes.IndexOf(strToStrip)
    '    'GlobalClass.lstYachtTypes.RemoveAt(idxOfThing)

    '    lstItems.Remove(strToStrip)

    'End Sub
    Public Shared Sub PopulateYachtReport(ByVal strYachts As List(Of String), ByRef intYachtCount As Integer)
        ' Populates the array report and updates the count of the number of items in the Array
        ' WARNING any time a yacht type is added or removed this Subprocedure must be called.
        reportYachts.lblYachtTypeReportOutput.Text = ""
        'Reset the counter before manipulating it and passing it back
        intYachtCount = 0

        For Each yacht As String In strYachts
            reportYachts.lblYachtTypeReportOutput.Text += yacht.ToString() & Environment.NewLine
        Next
        intYachtCount = strYachts.Count
        reportYachts.lblCountYachtOutput.Text = "Total Types of Yachts: " & intYachtCount.ToString("N0")
    End Sub

    Public Shared Sub YachtTypeListPopulate(strArrtoUse As String(), ByRef lstToPopulate As List(Of String))
        ' This sub will be used on form load to populate the original data set for the Yacht Types List because I simply do not want to reDim arrays

        For i = 0 To (strArrtoUse.Length - 1)
            lstYachtTypes.Add(strArrtoUse(i))
            'Console.WriteLine(strYachtTypes(i))
            'Console.WriteLine(lstYachtTypes.Item(i))
        Next

    End Sub

    Public Shared Sub ReloadControlsWithList(ByVal lstToUse As List(Of String))
        PopulateYachtReport(lstToUse, intCountYachtTypes)
        PopulateComboBox(lstToUse, frmYachtEntryMain.cboYachtType)
        PopulateDomainWithList(lstToUse, frmEditYachtTypes.dmnYachts)


    End Sub


End Class