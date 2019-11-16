Public Class ReportBuilding
    ' Class is going to hold methods for building and saving a texual based log file.
    Public Shared strOfReportKeys() As String = {"dtCurrentDate", "strComments", "strName", "strYachtType", "strLengthOfYacht", "strCostOfRental"}
    Public Shared dicOutputReport As New Dictionary(Of String, String)
    Public Shared Sub StrOfStrDicPopulateKeys(ByRef dicStrStr As Dictionary(Of String, String), strArrayToUse As String())
        'Populates a dictionary of keys for use
        For i = 0 To strArrayToUse.Count - 1
            If (strArrayToUse(i) = "dtCurrentDate") Then
                dicStrStr.Add(strArrayToUse(i), DateAndTime.DateString())
            Else
                dicStrStr.Add(strArrayToUse(i), "")
            End If
        Next i
    End Sub




End Class
