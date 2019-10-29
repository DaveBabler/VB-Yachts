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
    ' Going to need this key value pair object for testing things in console later and populating lists and such 
    Dim pair As KeyValuePair(Of String, String)
    ' initially tried an array for this, changing array size on the fly is not fun using list instead
    Dim lstYachtTypes As New List(Of String)

    ' Need a multidimensional array that can be resized on the fly, do not have access to C#'s jagged array, constantly having 
    ' to reDim the array would be...tedious.  We will use a dictionary
    Dim dctYachtSizePrice As New Dictionary(Of String, String)
    'initialized here, populated on form loading event

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

    Function GetRentalPrice(strYachtLength As String, intHoursChartered As Integer) As Decimal
        Dim strPriceValue As String
        Dim decPriceValue As Decimal
        Dim decHoursChartered As Decimal = CType(intHoursChartered, Decimal)
        Dim decReturnedCost As Decimal = 0.00  'VB was giving me errors about assigning null to a decimial o.O since when!? 

        ' First look up the hourly cost for the yacht from the dictionary object

        If dctYachtSizePrice.TryGetValue(strYachtLength, strPriceValue) Then
            decPriceValue = CType(strPriceValue, Decimal)
        Else
            MsgBox("Value selected not found, try again", 0 Or 48, "Referenced Value Not Found")
        End If

        ' Next multiply it by the hours to get the total cost and assign it to the return variable
        decReturnedCost = (decPriceValue * decHoursChartered)

        Return decReturnedCost
    End Function

    Private Sub frmYachtEntryMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        YachtTypeListPopulate()
        YachtSizePriceDictionaryPopulate()

        'populates the dropdown lists and the listbox
        For Each yacht In lstYachtTypes
            cboYachtType.Items.Add(yacht)
        Next

        For Each pair In dctYachtSizePrice
            'in this case Key is the length
            lstAvailibleYachtLength.Items.Add(pair.Key)
        Next



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
            Console.WriteLine("Key = ""tif"" is not found.")
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
End Class
