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

Public Class frmYachtEntryMain
    'Standard variable declarations
    Dim intTotalCharteredBoats As Integer = 0
    Dim intTotalHoursChartered As Integer = 0
    Dim intMeanHoursChartered 'use Math.Floor(a/b) to round up  we are using Mean instead of Average for precision (full hours only)
    Dim decTotalRevenue As Decimal = 0D
    Dim intCountYachtTypes As Integer = 0

    'End standard class variable declarations

    'Begin advanced varaible section

    'Going to need this key value pair object for testing things in console later and populating lists and such 
    Dim pair As KeyValuePair(Of String, String)

    ' initially tried an array for this, changing array size on the fly is not fun using list instead
    Dim lstYachtTypes As New List(Of String)
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


    Sub PopulateYachtReport(ByVal strYachts As List(Of String), ByRef intYachtCount As Integer)
        ' Populates the array report and updates the count of the number of items in the Array
        reportYachts.lblYachtTypeReportOutput.Text = ""

        For Each yacht As String In strYachts
            reportYachts.lblYachtTypeReportOutput.Text += yacht.ToString() & Environment.NewLine
        Next
    End Sub

    Sub UserErrorMessage(ByVal strMessage As String, ByVal strTitle As String)
        ' a quick way of sending a popup error box instead of recoding the thing the whole time I am tired of it.
        MsgBox(strMessage, MsgBoxStyle.Exclamation Or MsgBoxStyle.OkOnly, strTitle)

    End Sub


    Sub YachtTypeListPopulate()
        ' This sub will be used on form load to populate the original data set for the Yacht Types List because I simply do not want to reDim arrays
        Dim strYachtTypes As String() = {"C & C", "Catalina", "Coronado", "Excalibur", "Hans Christian", "Hobie", "Ranger", "Wavelength"}
        For i = 0 To (strYachtTypes.Length - 1)
            lstYachtTypes.Add(strYachtTypes(i))
            Console.WriteLine(strYachtTypes(i))
            Console.WriteLine(lstYachtTypes.Item(i))
        Next

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

        ClearTextBoxes()
        YachtTypeListPopulate()
        YachtSizePriceDictionaryPopulate()
        PopulateYachtReport(lstYachtTypes, intCountYachtTypes)

        'populates the dropdown lists and the listbox
        For Each yacht As String In lstYachtTypes
            cboYachtType.Items.Add(yacht)
        Next

        For Each pair In dctYachtSizePrice
            'in this case Key is the length
            lstAvailibleYachtLength.Items.Add(pair.Key)
        Next

        For Each programmerNameLabel In arrlblProgrammerName
            programmerNameLabel.Text = "Program Code && Design by: Dave Babler"
            programmerNameLabel.Visible = True
        Next



        ''''End legitimate program begin testing section



        ''''REMOVE BEFORE PUBLISHING
        '''
        '''Research on printing a hidden form https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.printpreviewcontrol?view=netframework-4.8
        For Each pair In dctYachtSizePrice
            Console.WriteLine("{0}, {1}", pair.Key, pair.Value)
        Next


        Try
            Console.WriteLine("For key = ""tif"", value = {0}.",
                dctYachtSizePrice("tif"))
        Catch
            Console.WriteLine("______________________________")
            Console.WriteLine("Key = ""tif"" is not found.")
            Console.WriteLine("______________________________")
        End Try

        Try
            Console.WriteLine("For key = ""22"", value = {0}.",
                dctYachtSizePrice("22"))
        Catch
            Console.WriteLine("Key = ""22"" is not found.")
        End Try


        Dim value As String = ""
        If dctYachtSizePrice.TryGetValue("45", value) Then
            Console.WriteLine("For key = ""45"", value = {0}.", value)
        Else
            Console.WriteLine("Key = ""45"" is not found.")
        End If

        Dim TestPrice As Decimal = GetRentalPrice("38", 4)
        Console.WriteLine("The fabulous low price of: {0:N2}", TestPrice)

        ''''REMOVE BEFORE PUBLISHING
        '''


    End Sub

    Private Sub mnuPrintSummary_Click(sender As Object, e As EventArgs) Handles mnuPrintSummary.Click

    End Sub
    ''''REMOVE these events BEFORE PUBLISHING
    Private Sub ShowReportYachtsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowReportYachtsToolStripMenuItem.Click
        reportYachts.Show()
    End Sub

    Private Sub ShowReportSummaryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowReportSummaryToolStripMenuItem.Click
        reportSummary.Show()
    End Sub
    ''''End events REMOVE BEFORE PUBLISHING
    '''
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
                Console.WriteLine("DecIndCost = " & decIndividualRentalCost.ToString())

                ' Begin accumulation collection
                If decIndividualRentalCost <> 0 Then
                    lblCalculatedPriceOutput.Text = decIndividualRentalCost.ToString("C")
                    lblCalculatedPriceOutput.Visible = True
                    'only if we know the value isn't zero add to the accumulator, otherwise, why bother?
                    decTotalRevenue += decIndividualRentalCost
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
                'Console.WriteLine("We have a null reference " & nullRef.ToString())
            Catch nullArgEx As ArgumentNullException
                UserErrorMessage("You need to select a length by clicking the length of the Yacht you wish to rent!", "Choose yacht length!")
                'Console.WriteLine("We have a null argument exception which is not a null reference? " & nullArgEx.ToString())
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
        'pop up text entry?
    End Sub

    Private Sub mnuRemoveYachtType_Click(sender As Object, e As EventArgs) Handles mnuRemoveYachtType.Click
        'load a modal with a list box of all yachts availible 
        'have the user select and then click ok
        'if cancel just close the modal (oh and do it as a modal)
    End Sub
End Class
