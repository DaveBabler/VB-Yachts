Public Class StoredDataInFile
    Shared intCI As Integer ' CI  = current index and will be the current index of the numeric domain

    Private Sub dmnReportNumber_ValueChanged(sender As Object, e As EventArgs) Handles dmnReportNumber.ValueChanged
        intCI = CInt(dmnReportNumber.Value)
        GenerateVisualReport(intCI)

    End Sub

    Private Sub StoredDataInFile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dmnReportNumber.Maximum = ReportBuilding.lstRecordsFromFile.Count - 1
        intCI = 0 'starting value
        GenerateVisualReport(intCI)
    End Sub

    Sub GenerateVisualReport(ByVal intReportNum)
        lblDateOut.Text = ReportBuilding.lstRecordsFromFile(intReportNum)(0).ToString()
        lblCommentsOut.Text = ReportBuilding.lstRecordsFromFile(intReportNum)(1).ToString()
        lblPartyOut.Text = ReportBuilding.lstRecordsFromFile(intReportNum)(2).ToString()
        lblYachtTypeOut.Text = ReportBuilding.lstRecordsFromFile(intReportNum)(3).ToString()
        lblYachtLengthOut.Text = ReportBuilding.lstRecordsFromFile(intReportNum)(4).ToString()
        lblRentalPriceOut.Text = ReportBuilding.lstRecordsFromFile(intReportNum)(5).ToString()
    End Sub
End Class