Public Class ReportBuilding
    ' Class is going to hold methods for building and saving a texual based log file.
    Public Shared strLineDelimiter As String = "----------" 'for determining when a record ends or begins
    Public Shared strOfReportKeys() As String = {"dtCurrentDate", "strComments", "strName", "strYachtType", "strLengthOfYacht", "strCostOfRental"}
    Public Shared dicOutputReport As New Dictionary(Of String, String)
    Public Shared lstRecordsFromFile As List(Of Dictionary(Of String, String)) 'records read from the file will go here
    Public Shared Sub StrOfStrDicPopulateKeys(ByRef dicStrStr As Dictionary(Of String, String), strArrayToUse As String(), boolTodaysDate As Boolean)
        'First Clears a dictionary, then
        'Populates a dictionary of keys for use 
        'If the boolean is True it will automatically add today's date to any str that matches dtCurrentDate
        'Otherwise it can be used to blank out values or to simply populate keys.
        dicStrStr.Clear()
        For i = 0 To strArrayToUse.Count - 1
            If (strArrayToUse(i) = "dtCurrentDate") And boolTodaysDate = True Then
                dicStrStr.Add(strArrayToUse(i), DateAndTime.DateString())
            Else
                dicStrStr.Add(strArrayToUse(i), "")
            End If
        Next i
    End Sub
    ' https://social.msdn.microsoft.com/Forums/vstudio/en-US/772cfe62-3b36-4a9c-b5d0-b3faccaf8bdb/creating-variable-namesidentifier-dynamically
    Public Shared Sub PopulateYachtDictionary(ByRef dicYachtReport As Dictionary(Of String, String), ByVal decCalculatedCost As Decimal)
        'Ideally this would take an array and do comparisons but since I'm so late on this assignment
        'due to nearly breaking my wrist I'm making this Sub
        'This SUB WILL ONLY WORK WITH KNOWN KEYS
        dicYachtReport("strComments") = frmYachtEntryMain.txtComments.Text.ToString()
        dicYachtReport("strName") = frmYachtEntryMain.txtResponsibleParty.Text.ToString()
        dicYachtReport("strYachtType") = frmYachtEntryMain.cboYachtType.SelectedItem.ToString()
        dicYachtReport("strLengthOfYacht") = frmYachtEntryMain.lstAvailibleYachtLength.SelectedItem.ToString()
        dicYachtReport("strCostOfRental") = decCalculatedCost.ToString("C")


    End Sub

    Public Shared Sub AddDictionaryToList(ByRef lstToAddTo As List(Of Dictionary(Of String, String)), ByVal dicToUse As Dictionary(Of String, String), ByRef intDicNumber As Integer, ByVal strDicName As String)
        'populates a list based on passed Dictionary, it renames the dictionary on the fly to make sure nothing in the list has the same value twice
        'Each time this is run some global loop counter is incremented
        Dim dic As New Dictionary(Of String, String)

        '''I don't know if this is needed  TRY adding the dictionary to a list then continue to populate the list after clearing the dictionary 
        ''''if that works come back here and wipe this out.

    End Sub




End Class
