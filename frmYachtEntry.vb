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
    Dim strYachtTypes As String() = {"C & C", "Catalina", "Coronado", "Excalibur", "Hans Christian", "Hobie", "Ranger", "Wavelength"}
    Dim strYachtSizeAndPrice As String(,) = {{"22", "95.00"}, {"24", "137.00"}, {"30", "160.00"}, {"32", "192.00"}, {"36", "250.00"}, {"38", "400.00"}, {"45", "550.00"}}
    Private Sub frmYachtEntryMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'populates the dropdown lists and the listbox
        For Each yacht In strYachtTypes
            cboYachtType.Items.Add(yacht)
        Next


    End Sub
End Class
