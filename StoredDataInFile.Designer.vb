<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StoredDataInFile
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblYachtRemovalHeader = New System.Windows.Forms.Label()
        Me.lblStoredReportsInstructions = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblCommentsOut = New System.Windows.Forms.Label()
        Me.lblYachtLengthOut = New System.Windows.Forms.Label()
        Me.lblYachtTypeOut = New System.Windows.Forms.Label()
        Me.lblPartyOut = New System.Windows.Forms.Label()
        Me.lblDateOut = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblPartyName = New System.Windows.Forms.Label()
        Me.lblYachtType = New System.Windows.Forms.Label()
        Me.lblYachtLength = New System.Windows.Forms.Label()
        Me.lblComments = New System.Windows.Forms.Label()
        Me.dmnReportNumber = New System.Windows.Forms.NumericUpDown()
        Me.lblRentalPrice = New System.Windows.Forms.Label()
        Me.lblRentalPriceOut = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.dmnReportNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblYachtRemovalHeader
        '
        Me.lblYachtRemovalHeader.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblYachtRemovalHeader.AutoSize = True
        Me.lblYachtRemovalHeader.Font = New System.Drawing.Font("Roboto", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYachtRemovalHeader.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lblYachtRemovalHeader.Location = New System.Drawing.Point(65, 19)
        Me.lblYachtRemovalHeader.Name = "lblYachtRemovalHeader"
        Me.lblYachtRemovalHeader.Size = New System.Drawing.Size(375, 36)
        Me.lblYachtRemovalHeader.TabIndex = 1
        Me.lblYachtRemovalHeader.Text = "View Stored Rental Reports"
        Me.lblYachtRemovalHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblStoredReportsInstructions
        '
        Me.lblStoredReportsInstructions.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblStoredReportsInstructions.AutoSize = True
        Me.lblStoredReportsInstructions.Font = New System.Drawing.Font("Roboto", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblStoredReportsInstructions.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblStoredReportsInstructions.Location = New System.Drawing.Point(143, 59)
        Me.lblStoredReportsInstructions.Name = "lblStoredReportsInstructions"
        Me.lblStoredReportsInstructions.Size = New System.Drawing.Size(219, 54)
        Me.lblStoredReportsInstructions.TabIndex = 2
        Me.lblStoredReportsInstructions.Text = "Scroll to pick a report to review. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "That Report #'s information will" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "automatica" &
    "lly fill in for you below" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblStoredReportsInstructions.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lblYachtLengthOut, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.lblYachtTypeOut, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lblPartyOut, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblDateOut, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblDate, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblPartyName, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblYachtType, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lblYachtLength, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.lblComments, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.lblRentalPrice, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.lblCommentsOut, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.lblRentalPriceOut, 1, 4)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(71, 186)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(360, 308)
        Me.TableLayoutPanel1.TabIndex = 4
        '
        'lblCommentsOut
        '
        Me.lblCommentsOut.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblCommentsOut.AutoSize = True
        Me.lblCommentsOut.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCommentsOut.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblCommentsOut.Location = New System.Drawing.Point(344, 234)
        Me.lblCommentsOut.Name = "lblCommentsOut"
        Me.lblCommentsOut.Size = New System.Drawing.Size(13, 20)
        Me.lblCommentsOut.TabIndex = 9
        Me.lblCommentsOut.Text = " "
        Me.lblCommentsOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblYachtLengthOut
        '
        Me.lblYachtLengthOut.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblYachtLengthOut.AutoSize = True
        Me.lblYachtLengthOut.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYachtLengthOut.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblYachtLengthOut.Location = New System.Drawing.Point(344, 116)
        Me.lblYachtLengthOut.Name = "lblYachtLengthOut"
        Me.lblYachtLengthOut.Size = New System.Drawing.Size(13, 20)
        Me.lblYachtLengthOut.TabIndex = 8
        Me.lblYachtLengthOut.Text = " "
        Me.lblYachtLengthOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblYachtTypeOut
        '
        Me.lblYachtTypeOut.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblYachtTypeOut.AutoSize = True
        Me.lblYachtTypeOut.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYachtTypeOut.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblYachtTypeOut.Location = New System.Drawing.Point(344, 80)
        Me.lblYachtTypeOut.Name = "lblYachtTypeOut"
        Me.lblYachtTypeOut.Size = New System.Drawing.Size(13, 20)
        Me.lblYachtTypeOut.TabIndex = 7
        Me.lblYachtTypeOut.Text = " "
        Me.lblYachtTypeOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPartyOut
        '
        Me.lblPartyOut.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblPartyOut.AutoSize = True
        Me.lblPartyOut.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPartyOut.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblPartyOut.Location = New System.Drawing.Point(344, 44)
        Me.lblPartyOut.Name = "lblPartyOut"
        Me.lblPartyOut.Size = New System.Drawing.Size(13, 20)
        Me.lblPartyOut.TabIndex = 6
        Me.lblPartyOut.Text = " "
        Me.lblPartyOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDateOut
        '
        Me.lblDateOut.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblDateOut.AutoSize = True
        Me.lblDateOut.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateOut.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblDateOut.Location = New System.Drawing.Point(344, 8)
        Me.lblDateOut.Name = "lblDateOut"
        Me.lblDateOut.Size = New System.Drawing.Size(13, 20)
        Me.lblDateOut.TabIndex = 5
        Me.lblDateOut.Text = " "
        Me.lblDateOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDate
        '
        Me.lblDate.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(3, 8)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(47, 20)
        Me.lblDate.TabIndex = 0
        Me.lblDate.Text = "Date:"
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPartyName
        '
        Me.lblPartyName.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblPartyName.AutoSize = True
        Me.lblPartyName.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPartyName.Location = New System.Drawing.Point(3, 44)
        Me.lblPartyName.Name = "lblPartyName"
        Me.lblPartyName.Size = New System.Drawing.Size(144, 20)
        Me.lblPartyName.TabIndex = 2
        Me.lblPartyName.Text = "Responsible Party:"
        Me.lblPartyName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblYachtType
        '
        Me.lblYachtType.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblYachtType.AutoSize = True
        Me.lblYachtType.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYachtType.Location = New System.Drawing.Point(3, 80)
        Me.lblYachtType.Name = "lblYachtType"
        Me.lblYachtType.Size = New System.Drawing.Size(91, 20)
        Me.lblYachtType.TabIndex = 3
        Me.lblYachtType.Text = "YachtType:"
        Me.lblYachtType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblYachtLength
        '
        Me.lblYachtLength.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblYachtLength.AutoSize = True
        Me.lblYachtLength.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYachtLength.Location = New System.Drawing.Point(3, 116)
        Me.lblYachtLength.Name = "lblYachtLength"
        Me.lblYachtLength.Size = New System.Drawing.Size(109, 20)
        Me.lblYachtLength.TabIndex = 4
        Me.lblYachtLength.Text = "Yacht Length:"
        Me.lblYachtLength.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblComments
        '
        Me.lblComments.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblComments.AutoSize = True
        Me.lblComments.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComments.Location = New System.Drawing.Point(3, 234)
        Me.lblComments.Name = "lblComments"
        Me.lblComments.Size = New System.Drawing.Size(92, 20)
        Me.lblComments.TabIndex = 1
        Me.lblComments.Text = "Comments:"
        Me.lblComments.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dmnReportNumber
        '
        Me.dmnReportNumber.BackColor = System.Drawing.Color.Gainsboro
        Me.dmnReportNumber.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.dmnReportNumber.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Bold)
        Me.dmnReportNumber.ForeColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.dmnReportNumber.Location = New System.Drawing.Point(192, 127)
        Me.dmnReportNumber.Name = "dmnReportNumber"
        Me.dmnReportNumber.Size = New System.Drawing.Size(120, 26)
        Me.dmnReportNumber.TabIndex = 5
        Me.dmnReportNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.dmnReportNumber.UseWaitCursor = True
        '
        'lblRentalPrice
        '
        Me.lblRentalPrice.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblRentalPrice.AutoSize = True
        Me.lblRentalPrice.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRentalPrice.Location = New System.Drawing.Point(3, 152)
        Me.lblRentalPrice.Name = "lblRentalPrice"
        Me.lblRentalPrice.Size = New System.Drawing.Size(101, 20)
        Me.lblRentalPrice.TabIndex = 10
        Me.lblRentalPrice.Text = "RentalPrice: "
        Me.lblRentalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblRentalPriceOut
        '
        Me.lblRentalPriceOut.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblRentalPriceOut.AutoSize = True
        Me.lblRentalPriceOut.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRentalPriceOut.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblRentalPriceOut.Location = New System.Drawing.Point(344, 152)
        Me.lblRentalPriceOut.Name = "lblRentalPriceOut"
        Me.lblRentalPriceOut.Size = New System.Drawing.Size(13, 20)
        Me.lblRentalPriceOut.TabIndex = 11
        Me.lblRentalPriceOut.Text = " "
        Me.lblRentalPriceOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'StoredDataInFile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(504, 543)
        Me.Controls.Add(Me.dmnReportNumber)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.lblStoredReportsInstructions)
        Me.Controls.Add(Me.lblYachtRemovalHeader)
        Me.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "StoredDataInFile"
        Me.Text = "StoredDataInFile"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.dmnReportNumber, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblYachtRemovalHeader As Label
    Friend WithEvents lblStoredReportsInstructions As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lblComments As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblPartyName As Label
    Friend WithEvents lblYachtType As Label
    Friend WithEvents dmnReportNumber As NumericUpDown
    Friend WithEvents lblYachtLength As Label
    Friend WithEvents lblDateOut As Label
    Friend WithEvents lblCommentsOut As Label
    Friend WithEvents lblYachtLengthOut As Label
    Friend WithEvents lblYachtTypeOut As Label
    Friend WithEvents lblPartyOut As Label
    Friend WithEvents lblRentalPrice As Label
    Friend WithEvents lblRentalPriceOut As Label
End Class
