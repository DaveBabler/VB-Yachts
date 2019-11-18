Public Class PlainPrinting
    Public Shared Sub PrintYachtTypes(e As Printing.PrintPageEventArgs)
        'Print the yacht types
        Dim prtFont As New Font("Roboto", 14)
        Dim LineHgt As Single = prtFont.GetHeight + 2
        Dim horPrintLoc As Single = e.MarginBounds.Left
        Dim verPrintLoc As Single = e.MarginBounds.Top + 150
        Dim prtLineStr As String

        e.Graphics.DrawString("Yachts Chartering Form", New Font("Roboto", 30), Brushes.Black, 100, 100)
        'Display all yacht types in the typeComboBox
        For Each item In GlobalClass.lstYachtTypes

            prtLineStr = item.ToString()
            e.Graphics.DrawString(prtLineStr, prtFont, Brushes.Black, horPrintLoc, verPrintLoc)
            verPrintLoc += LineHgt
        Next item

    End Sub
    Public Shared Sub PrintSummary(e As Printing.PrintPageEventArgs, ByRef intTotalChartered As Integer, ByRef intAvgHoursChartered As Integer, ByRef decTotalRevenue As Decimal)
        Dim prtFont As New Font("Roboto", 14)
        Dim LineHgt As Single = prtFont.GetHeight + 2
        Dim horPrintLoc As Single = e.MarginBounds.Left
        Dim verPrintLoc As Single = e.MarginBounds.Top + 150
        Dim prtLineStr As String
        Dim dicSummary As New Dictionary(Of String, String)
        dicSummary.Add("Total Chartered Yachts", intTotalChartered.ToString("N0"))
        dicSummary.Add("Average Hours Chartered", intAvgHoursChartered.ToString("N0"))
        dicSummary.Add("Total Revenue For This Program Run", decTotalRevenue.ToString("C"))
        e.Graphics.DrawString("Yachts Summary Report", New Font("Roboto", 30), Brushes.Red, 100, 100)
        For Each pair In dicSummary
            prtLineStr = pair.Key & " = " & pair.Value
            e.Graphics.DrawString(prtLineStr, prtFont, Brushes.Navy, horPrintLoc, verPrintLoc)
            verPrintLoc += LineHgt

        Next
    End Sub
End Class
