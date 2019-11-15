' Program:                Yachts 
' Author:                 Dave Babler
' Date:                   2019-10227
' Purpose:                Produces a summary report showing total revuneu, number of charters, and average hours per charter based on user input
' Colors used:            #ff00cc|rgb(255, 0, 204)  ~  #5a0048|rgb(90, 0, 72) (Darker shade ff0cc)
'                         #00ccff|rgb(0, 204, 255)
'                         #ccff00|rgb(204, 255, 0)
'                         End split complementary color scheme
'                         Standard Windows colors: Black, Gainsboro
' Assignment Paramaters:  Create a project to input boat chartering and produce a summary report showing total revenue, number of charters, 
'                         and average hours per charter. User will input party name & hours wanted, select yacht type & length (dropdown combo boxes),
'                         then cost will be calculated and displayed with OK button.
'                         ______________________________________________________________________________________________
'                         Ability to: add/remove a yacht type, list count of types, print a list/report of all types. 
'                         Summary Report includes: # charters, total revenue, average hours chartered, and programmer name.
'                         Yacht Type Report will list the yacht types in the combo box with programmer name and title at top.
'                         ______________________________________________________________________________________________

' Parameters for 2019-11-14
'                         ______________________________________________________________________________________________

'                       Modify Yachts A to replace with files: yacht types (load on start during splash, save when done); create reservation file adding date 
'                       (use system date, not user entered) & comment field (50-chars) form and also to reservation records; append new reservations; add new form to view/display reservation file. 
'                       Optional: produce report of reservations, log file.
'                       Testing: add 2 New yacht types And remove one of the original 8
'                       File I/O testing – missing file, empty file, standards; saving the data
'                       Testing: spin through reservations –browse one at a time
'<todo>
'Read from file to populate yacht list
'add comment field
'add date field
'then move on to saving to reservation records. 


Public Class frmYachtEntryMain
    'Standard variable declarations
    Dim intTotalCharteredBoats As Integer = 0
    Dim intTotalHoursChartered As Integer = 0
    Dim intMeanHoursChartered 'use Math.Floor(a/b) to round up  we are using Mean instead of Average for precision (full hours only)
    Dim decTotalRevenue As Decimal = 0D


    'End standard class variable declarations

    'Begin advanced varaible section


    'Going to need this key value pair object for testing things in console later and populating lists and such 
    Dim pair As KeyValuePair(Of String, String)

    Dim arrlblProgrammerName As System.Windows.Forms.Label() = {reportYachts.lblProgrammerYachtForm, reportSummary.lblProgrammerSummaryForm}

    'Need a multidimensional array that can be resized on the fly, do not have access to C#'s jagged array, constantly having 
    ' to reDim the array would be...tedious.  We will use a dictionary
    Dim dctYachtSizePrice As New Dictionary(Of String, String)
    'initialized here, populated on form loading event

    'End advanced class variable declarations
    'Begin custom Functions

    Function GetRentalPrice(strYachtLength As String, intHoursChartered As Integer) As Decimal
        Dim strPriceValue As String
        Dim decPriceValue As Decimal
        Dim decHoursChartered As Decimal = CType(intHoursChartered, Decimal)
        Dim decReturnedCost As Decimal = 0.00D  'VB was giving me errors about assigning null to a decimial o.O since when!? 

        ' First look up the hourly cost for the yacht from the dictionary object

        If dctYachtSizePrice.TryGetValue(strYachtLength, strPriceValue) Then
            decPriceValue = CType(strPriceValue, Decimal)
        Else
            UserErrorMessage("Value selected not found, try again.", "Refereced value error")
        End If

        ' Next multiply it by the hours to get the total cost and assign it to the return variable
        decReturnedCost = (decPriceValue * decHoursChartered)

        Return decReturnedCost
    End Function

    Function ValidateInts(ByVal strValue As String, ByRef txtBox As System.Windows.Forms.TextBox) As Integer
        'Passing a val as string because of user entry, we will try and validate here. 
        'Then will return a proper integer for correct maths
        'If Error it will clear the entry box and return focus to it.
        Dim intValue As Integer = 0I
        If (Not Integer.TryParse(strValue, intValue)) Then
            UserErrorMessage("Whole numbers only please", "Invalid Entry")
            txtBox.Clear()
            txtBox.Focus()
        Else
            intValue = CInt(strValue)
        End If
        Return intValue
    End Function


    'End custom Functions

    'Begin custom (non Event created/form created Subs & Functions
    Sub CloseForms()
        'Closing the summary forms incase Print Preview opens them and keeps them open in memory
        'Also closing them in the event a future programmer wants to keep them open, it will save them time.
        reportSummary.Close()
        reportYachts.Close()

        'close this form
        Me.Close()

    End Sub
    Sub ClearTextBoxes()
        'clears textboxes in bulk and focuses on first point of user entered data
        txtHoursChartered.Clear()
        txtResponsibleParty.Clear()
        txtResponsibleParty.Focus()
    End Sub

    Sub ClearFormData()
        ' This clears the temporary form data after entry and is user event driven thus will be called by appropriate events
        lblCalculatedPriceOutput.Text = ""
        lblCalculatedPriceOutput.Visible = False
        lstAvailibleYachtLength.ClearSelected() 'unselects the selection in the box
        cboYachtType.SelectedIndex = -1 'sets the combo box back to default
        ClearTextBoxes()

    End Sub


    Sub PopulateSummaryData(ByVal intTotalChartered As Integer, ByVal intAvgHoursChartered As Integer, ByVal decTotalRevenue As Decimal)
        'populates the summary data on the summary report for printing
        reportSummary.lblAvgHoursCharteredOut.Text = intAvgHoursChartered.ToString("N0")
        reportSummary.lblNumChartersOutput.Text = intTotalChartered.ToString("N0")
        reportSummary.lblTotalRevenueOut.Text = decTotalRevenue.ToString("C")

    End Sub






    Sub UserErrorMessage(ByVal strMessage As String, ByVal strTitle As String)
        ' a quick way of sending a popup error box instead of recoding the thing the whole time I am tired of it.
        MsgBox(strMessage, MsgBoxStyle.Exclamation Or MsgBoxStyle.OkOnly, strTitle)

    End Sub



    Sub YachtSizePriceDictionaryPopulate()
        'populate the dictionary dctYachtSize Price
        '(length, cost) will cast to appropriate numerics later, I just want this data stored and solid for display here
        dctYachtSizePrice.Add("22", "95.00")
        dctYachtSizePrice.Add("24", "137.00")
        dctYachtSizePrice.Add("30", "160.00")
        dctYachtSizePrice.Add("32", "192.00")
        dctYachtSizePrice.Add("36", "250.00")
        dctYachtSizePrice.Add("38", "400.00")
        dctYachtSizePrice.Add("45", "550.00")
        ' End population of dctYachtSizePrice
        ' note, had there been time, I probably would have made a Sub that could be reused to populate a Dictionary same for the List
    End Sub


    'End custom (non Event created/form created Subs

    Private Sub frmYachtEntryMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'This is the primary form that will be front facing and visual to users.
        'The rest of the forms will only show up upon print.
        'Some logic for those forms may appear here, the rest will be user event driven instead of
        'program load event.
        frmEditYachtTypes.Visible = False
        frmEditYachtTypes.Dispose()
        frmEditYachtTypes.Close()
        ClearTextBoxes()
        GlobalClass.YachtTypeListPopulate()
        YachtSizePriceDictionaryPopulate()
        GlobalClass.PopulateYachtReport(GlobalClass.lstYachtTypes, GlobalClass.intCountYachtTypes)
        GlobalClass.PopulateDomainWithList(GlobalClass.lstYachtTypes, frmEditYachtTypes.dmnYachts)

        GlobalClass.PopulateComboBox(GlobalClass.lstYachtTypes, cboYachtType)
        'populates the dropdown lists and the listbox


        For Each pair In dctYachtSizePrice
            'in this case Key is the length
            lstAvailibleYachtLength.Items.Add(pair.Key)
        Next

        For Each programmerNameLabel In arrlblProgrammerName
            programmerNameLabel.Text = "Program Code && Design by: Dave Babler"
            programmerNameLabel.Visible = True
        Next


    End Sub

    Private Sub mnuPrintSummary_Click(sender As Object, e As EventArgs) Handles mnuPrintSummary.Click
        ' PrintPreviewControl.
        ' Show to load the form, hide to conceal from user, print the form, then close the form
        reportSummary.Show()
        'Adding this second option to populate summmary data should in theory allow for accumulated data to show even after "clear" is pressed
        PopulateSummaryData(intTotalCharteredBoats, intMeanHoursChartered, decTotalRevenue)
        reportSummary.Hide()
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print(reportSummary, PowerPacks.Printing.PrintForm.PrintOption.FullWindow)
        reportSummary.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearFormData()
    End Sub

    Private Sub mnuClearForNext_Click(sender As Object, e As EventArgs) Handles mnuClearForNext.Click
        ClearFormData()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        CloseForms()

    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        CloseForms()

    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Dim strUserHoursEntered As String
        Dim intUserHours As Integer
        Dim strYachtLength As String = lstAvailibleYachtLength.SelectedItem

        Dim decIndividualRentalCost As Decimal
        If String.IsNullOrEmpty(txtResponsibleParty.Text) Then
            UserErrorMessage("You must enter the responsible parties name to proceed", "Who is paying for this?")
            txtResponsibleParty.Focus()
        Else
            'If we have a name proceed with the rest of the logic, otherwise just throw it away
            Try


                If cboYachtType.SelectedIndex < 0 Then
                    UserErrorMessage("You forgot to select a model", "Pick a Yacht")
                End If

                strUserHoursEntered = txtHoursChartered.Text
                intUserHours = ValidateInts(strUserHoursEntered, txtHoursChartered)
                If intUserHours = 0 Then
                    UserErrorMessage("Zero is not a valid entry", "Zero times X is Zero")

                End If
                ' use a try catch to divide by zero when you do the print forms and such 

                decIndividualRentalCost = GetRentalPrice(strYachtLength, intUserHours)
                'Console.WriteLine("DecIndCost = " & decIndividualRentalCost.ToString())

                ' Begin accumulation collection
                If decIndividualRentalCost <> 0 Then
                    lblCalculatedPriceOutput.Text = decIndividualRentalCost.ToString("C")
                    lblCalculatedPriceOutput.Visible = True
                    'only if we know the value isn't zero add to the accumulator, otherwise, why bother?
                    decTotalRevenue += decIndividualRentalCost
                    decIndividualRentalCost = 0 ' we need to immediately reset this to 0 on the back end to prevent errors on adding to accumulator
                    'only add to total chartered boats if the cost is greater than 0, 
                    'if the customer needs  a way to "comp" a boat rental for customer service this can be worked out in 
                    'other modules or future releases (same for total hours)
                    intTotalCharteredBoats += 1
                    intTotalHoursChartered += intUserHours

                    Try

                        intMeanHoursChartered = Math.Ceiling(intTotalHoursChartered / intTotalCharteredBoats)

                        PopulateSummaryData(intTotalCharteredBoats, intMeanHoursChartered, decTotalRevenue)


                    Catch divZero As DivideByZeroException

                        MsgBox("Critical Divide By Zero Error, that shouldn't be possible." & Environment.NewLine _
                               & "Please contact development team!", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly,
                                "Significant Exception Has Ocurred")

                    End Try


                End If






            Catch nullRef As NullReferenceException
                UserErrorMessage("You need to select a length by clicking the length of the Yacht you wish to rent!", "Choose yacht length!")
                ''Console.WriteLine("We have a null reference " & nullRef.ToString())
            Catch nullArgEx As ArgumentNullException
                UserErrorMessage("You need to select a length by clicking the length of the Yacht you wish to rent!", "Choose yacht length!")
                ''Console.WriteLine("We have a null argument exception which is not a null reference? " & nullArgEx.ToString())
            Catch argEx As ArgumentException
                UserErrorMessage("You need to select a length by clicking the length of the Yacht you wish to rent!", "Choose yacht length!")


            End Try

        End If

        'If all that succeeds then it is time to add to the accumulators






        If decTotalRevenue > 0 And mnuPrintSummary.Enabled = False Then
            'If the print summary has not yet been enabled, and deserves to be enabled, enable it. 


            mnuPrintSummary.Enabled = True
        End If


    End Sub

    Private Sub mnuAddYachtType_Click(sender As Object, e As EventArgs) Handles mnuAddYachtType.Click
        'pop up text entry
        Dim strNewYacht As String = InputBox("Please enter the new Yacht Type Here: ", "Add Yacht")
        GlobalClass.lstYachtTypes.Add(strNewYacht)
        'Sort the list
        GlobalClass.lstYachtTypes.Sort()
        GlobalClass.ReloadControlsWithList(GlobalClass.lstYachtTypes)
    End Sub

    Private Sub mnuRemoveYachtType_Click(sender As Object, e As EventArgs) Handles mnuRemoveYachtType.Click
        'load a modal with a list box of all yachts availible 
        'have the user select and then click ok
        'if cancel just close the modal (oh and do it as a modal)
        frmEditYachtTypes.ShowDialog()

    End Sub

    Private Sub mnuDisplayYachtCount_Click(sender As Object, e As EventArgs) Handles mnuDisplayYachtCount.Click
        MsgBox("Total Count of Yachts is: " & GlobalClass.intCountYachtTypes, vbApplicationModal Or vbOKOnly Or vbInformation, "Counted Yacht Types")
    End Sub

    Private Sub mnuPrintYachtTypes_Click(sender As Object, e As EventArgs) Handles mnuPrintYachtTypes.Click
        ' PrintPreviewControl.
        ' Show to load the form, hide to conceal from user, print the form, then close the form
        reportYachts.Show()
        reportYachts.Hide()
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print(reportYachts, PowerPacks.Printing.PrintForm.PrintOption.FullWindow)
        reportYachts.Close()

    End Sub

    Private Sub mnuAbout_Click(sender As Object, e As EventArgs) Handles mnuAbout.Click
        frmAbout.ShowDialog()

    End Sub


End Class
Public Class GlobalClass
    ' This class stores Global Variables as is suggested by the name. (Self referencing code!)
    ' initially tried an array for this, changing array size on the fly is not fun using list instead
    ' also needed this to be in a couple different classes
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
    Public Shared Sub YachtTypeListPopulate()
        ' This sub will be used on form load to populate the original data set for the Yacht Types List because I simply do not want to reDim arrays
        Dim strYachtTypes As String() = {"C & C", "Catalina", "Coronado", "Excalibur", "Hans Christian", "Hobie", "Ranger", "Wavelength"}
        For i = 0 To (strYachtTypes.Length - 1)
            lstYachtTypes.Add(strYachtTypes(i))
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