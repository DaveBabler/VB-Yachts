Public Class ReportBuilding
    ' Class is going to hold methods for building and saving a texual based log file.
    Public Shared strLineDelimiter As String = "----------" 'for determining when a record ends or begins
    Public Shared strOfReportKeys() As String = {"dtCurrentDate", "strComments", "strName", "strYachtType", "strLengthOfYacht", "strCostOfRental"}
    Public Shared dicOutputReport As New Dictionary(Of String, String)
    Public Shared lstRecordsFromFile As New List(Of String()) 'records read from the file will go here
    Public Shared lstRecordUnit As New List(Of String)
    Public Shared lstTEST As New List(Of String)

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

    Public Shared Sub DictionaryClearValsKeepKeys(ByVal dicToClearVals As Dictionary(Of String, String), strArrayToUse As String())

        'This does exactly what it says it clears the dictionary 



        For i = 0 To strArrayToUse.Count - 1

                If dicToClearVals.ContainsKey(strArrayToUse(i)) Then
                    dicToClearVals(strArrayToUse(i)) = False
                End If

            Next i


    End Sub
    Public Shared Sub OutPutDictionaryToLog(ByRef dicOfData As Dictionary(Of String, String), ByVal strLocationOfSaveFile As String, ByRef strDelimiter As String)
        Dim objWriter As New System.IO.StreamWriter(strLocationOfSaveFile, True)
        If IO.File.Exists(strLocationOfSaveFile) = True Then
            ' the compiler may wipe the  pair As KeyValuePair(Of String, String) and change to just pair but it is helpful to know 
            For Each pair In dicOfData
                objWriter.WriteLine(pair.Value.ToString())
            Next pair
            objWriter.WriteLineAsync(strDelimiter)  'make the program wait to add the delimiter I have no clue if this acts like AJAX but I saw Async and decided to use it
            objWriter.Close()
        Else
            MsgBox("I cannot find the file " & Environment.NewLine() & strLocationOfSaveFile & Environment.NewLine() & "Please verify its existance and reload program",
                  vbOKOnly Or vbExclamation, "Where is my file!")
        End If

    End Sub



    Public Shared Sub ReadTextFileIntoObject(ByVal strFileToRead As String, ByRef strArray As String())
        'Note apparently you cannot directly read a text file into a Listof object!  ATTENTION LISA THOMAS  IF THIS IS INACCURATE PLEASE EMAIL ME!!!
        ' I was forced to do it as an array first!
        Dim objReader As IO.StreamReader
        Dim intCount As Integer = 0
        If IO.File.Exists(strFileToRead) = True Then
            Dim strTextFileLength As String = IO.File.ReadAllText(strFileToRead)
            If strTextFileLength.Length = 0 Then
                MsgBox("Sorry but C:\Yachts.txt does currently contain data." & vbNewLine & "Make data exist in the file, then try again.", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "File not found")
            Else
                objReader = IO.File.OpenText(strFileToRead)

                Do While objReader.Peek <> -1
                    strArray(intCount) = objReader.ReadLine()
                    If strArray(intCount) Is Nothing Then
                        'Console.WriteLine("We are in nothing ")
                    Else
                        intCount += 1
                        'intCount -= 1

                        'ReDim Preserve strArray(intCount)
                    End If
                    ReDim Preserve strArray(intCount)
                Loop
                objReader.Close()
                'The array seems to pickup a Nothing Value no matter what logic I use. 
                ReDim Preserve strArray(intCount - 1)
            End If
        Else
            MsgBox("Sorry but C:\Yachts.txt does not currently exist." & vbNewLine & "Make the file exist then reload program", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "File not found")


        End If

    End Sub

    Public Shared Sub ReadTextFileIntoObject(ByVal strFileToRead As String, ByRef lstOfData As List(Of String()), ByVal strDelimiter As String, ByVal intArrayDimension As Integer)
        'Note apparently you cannot directly read a text file into a Listof object!  ATTENTION LISA THOMAS  IF THIS IS INACCURATE PLEASE EMAIL ME!!!
        ' I was forced to do it as an array first!
        Dim objReader As IO.StreamReader
        Dim incArray(intArrayDimension) As String
        Dim strFromFile As String

        If IO.File.Exists(strFileToRead) = True Then
            Dim strTextFileLength As String = IO.File.ReadAllText(strFileToRead)
            If strTextFileLength.Length = 0 Then
                MsgBox("Sorry but " & strFileToRead & " does currently contain data." & vbNewLine & "Make data exist in the file, then try again.", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "File not found")
            Else
                objReader = IO.File.OpenText(strFileToRead)

                Do While objReader.Peek <> -1
                    strFromFile = objReader.ReadLine().Trim(" ").ToString()
                    strFromFile = ReportBuilding.LineBreakRemover(strFromFile)
                    Console.WriteLine("We are currently in ReadTextFileIntoObject with a ReadLine of {0}", strFromFile)

                    If strFromFile Is Nothing Then
                        '  Console.WriteLine("We are in nothing ")
                    ElseIf String.Compare(strFromFile, strDelimiter) = 0 Then
                        ' either do nothing or add to the list? 
                        MsgBox("We are in the delimiter!!!!", MsgBoxStyle.OkOnly)
                        lstOfData.Add(incArray)
                    Else
                        For i = 0 To incArray.Count - 1
                            incArray(i) = strFromFile & Environment.NewLine()
                        Next

                        'ReDim Preserve strArray(intCount)
                    End If
                    incArray.Clear(incArray, 0, incArray.Length)

                Loop
                objReader.Close()
                'The array seems to pickup a Nothing Value no matter what logic I use. 

            End If
        Else
            MsgBox("Sorry but  " & strFileToRead & "  does not currently exist." & vbNewLine & "Make the file exist then reload program", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "File not found")


        End If

    End Sub

    Public Shared Sub TestRead(ByVal strFileToRead As String, ByRef lstOfData As List(Of String), ByVal strDelimiter As String)
        'Note apparently you cannot directly read a text file into a Listof object!  ATTENTION LISA THOMAS  IF THIS IS INACCURATE PLEASE EMAIL ME!!!
        ' I was forced to do it as an array first!
        Dim objReader As IO.StreamReader

        Dim strFromFile As String
        Dim lcv As Integer = 0
        If String.Compare(strDelimiter, "----------") = 0 Then
            MsgBox("FUCKING WHY DO YOU HATE ME!!!!", MsgBoxStyle.OkOnly)
        End If

        If IO.File.Exists(strFileToRead) = True Then
            Dim strTextFileLength As String = IO.File.ReadAllText(strFileToRead)
            If strTextFileLength.Length = 0 Then
                MsgBox("Sorry but " & strFileToRead & " does currently contain data." & vbNewLine & "Make data exist in the file, then try again.", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "File not found")
            Else
                objReader = IO.File.OpenText(strFileToRead)

                Do While objReader.Peek <> -1
                    strFromFile = objReader.ReadLine().Trim(" ").ToString()
                    strFromFile = ReportBuilding.LineBreakRemover(strFromFile)
                    Console.WriteLine("At Line: {0}, we have a value of {1}", lcv, strFromFile)
                    lcv += 1
                    If strFromFile Is Nothing Then
                        '  Console.WriteLine("We are in nothing ")
                        'ElseIf String.Compare(strFromFile, strDelimiter) = 0 Then
                        '    ' either do nothing or add to the list? 
                        '    lcv = 0


                    Else
                        lstOfData.Add(strFromFile)
                    End If




                Loop
                objReader.Close()
                lcv = 0
                'The array seems to pickup a Nothing Value no matter what logic I use. 

            End If
        Else
            MsgBox("Sorry but  " & strFileToRead & "  does not currently exist." & vbNewLine & "Make the file exist then reload program", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "File not found")


        End If

    End Sub

    Public Shared Function LineBreakRemover(strToFix As String) As String

        If Len(strToFix) <> 0 Then
            If Right$(strToFix, 2) = vbCrLf Or Right$(strToFix, 2) = vbNewLine Then
                strToFix = Left$(strToFix, Len(strToFix) - 2)
            End If
        End If
        Return strToFix
    End Function


    Public Shared Sub BreakListIntoSubLists(ByRef lstContainer As List(Of String()), ByRef lstStarter As List(Of String), strDelim As String)
        Dim lstHolder(5) As String
        Dim x As Integer = 0 'a pseudo loop control variable
        Dim intListControl As Integer = 0

        For i = 0 To lstStarter.Count - 1

            Console.WriteLine(lstStarter.Item(i))
            If String.Compare(lstStarter.Item(i).ToString(), strDelim) <> 0 Then
                lstHolder(x) = ""

                lstHolder(x) = (lstStarter.Item(i).ToString())
                x += 1


            Else
                lstContainer.Insert(intListControl, lstHolder)
                intListControl += 1
                x = 0
                ReDim lstHolder(5)


            End If

        Next i

        'For i = 0 To lstContainer.Count - 1

        '    For q = 0 To lstContainer(i).Count - 1
        '        Console.WriteLine("i is {0}, q is {1}, and lstContainer(i)(q) is {2}", i.ToString(), q.ToString(), lstContainer(i)(q).ToString())
        '    Next q
        'Next i



    End Sub


End Class
