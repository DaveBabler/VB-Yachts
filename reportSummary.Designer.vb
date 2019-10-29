<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class reportSummary
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
        Me.lblSummaryReportHeader = New System.Windows.Forms.Label()
        Me.tlayoutSummary = New System.Windows.Forms.TableLayoutPanel()
        Me.lblProgrammerSummaryForm = New System.Windows.Forms.Label()
        Me.lblNumChartersLabel = New System.Windows.Forms.Label()
        Me.lblAvgHoursCharteredLabel = New System.Windows.Forms.Label()
        Me.lblTotalRevenueLabel = New System.Windows.Forms.Label()
        Me.lblNumChartersOutput = New System.Windows.Forms.Label()
        Me.lblAvgHoursCharteredOut = New System.Windows.Forms.Label()
        Me.lblTotalRevenueOut = New System.Windows.Forms.Label()
        Me.tlayoutSummary.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblSummaryReportHeader
        '
        Me.lblSummaryReportHeader.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblSummaryReportHeader.AutoSize = True
        Me.tlayoutSummary.SetColumnSpan(Me.lblSummaryReportHeader, 2)
        Me.lblSummaryReportHeader.Font = New System.Drawing.Font("Roboto", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSummaryReportHeader.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lblSummaryReportHeader.Location = New System.Drawing.Point(29, 0)
        Me.lblSummaryReportHeader.Name = "lblSummaryReportHeader"
        Me.lblSummaryReportHeader.Size = New System.Drawing.Size(262, 35)
        Me.lblSummaryReportHeader.TabIndex = 0
        Me.lblSummaryReportHeader.Text = "Revenue Summary"
        Me.lblSummaryReportHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'tlayoutSummary
        '
        Me.tlayoutSummary.ColumnCount = 2
        Me.tlayoutSummary.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.0!))
        Me.tlayoutSummary.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.0!))
        Me.tlayoutSummary.Controls.Add(Me.lblAvgHoursCharteredOut, 1, 2)
        Me.tlayoutSummary.Controls.Add(Me.lblNumChartersOutput, 1, 1)
        Me.tlayoutSummary.Controls.Add(Me.lblAvgHoursCharteredLabel, 0, 2)
        Me.tlayoutSummary.Controls.Add(Me.lblSummaryReportHeader, 0, 0)
        Me.tlayoutSummary.Controls.Add(Me.lblNumChartersLabel, 0, 1)
        Me.tlayoutSummary.Controls.Add(Me.lblProgrammerSummaryForm, 1, 3)
        Me.tlayoutSummary.Controls.Add(Me.lblTotalRevenueLabel, 0, 3)
        Me.tlayoutSummary.Controls.Add(Me.lblTotalRevenueOut, 1, 3)
        Me.tlayoutSummary.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold)
        Me.tlayoutSummary.Location = New System.Drawing.Point(1, 6)
        Me.tlayoutSummary.Name = "tlayoutSummary"
        Me.tlayoutSummary.RowCount = 5
        Me.tlayoutSummary.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.tlayoutSummary.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlayoutSummary.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlayoutSummary.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlayoutSummary.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlayoutSummary.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlayoutSummary.Size = New System.Drawing.Size(320, 246)
        Me.tlayoutSummary.TabIndex = 2
        '
        'lblProgrammerSummaryForm
        '
        Me.lblProgrammerSummaryForm.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblProgrammerSummaryForm.AutoSize = True
        Me.tlayoutSummary.SetColumnSpan(Me.lblProgrammerSummaryForm, 2)
        Me.lblProgrammerSummaryForm.Font = New System.Drawing.Font("Roboto", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblProgrammerSummaryForm.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblProgrammerSummaryForm.Location = New System.Drawing.Point(57, 229)
        Me.lblProgrammerSummaryForm.Name = "lblProgrammerSummaryForm"
        Me.lblProgrammerSummaryForm.Size = New System.Drawing.Size(206, 17)
        Me.lblProgrammerSummaryForm.TabIndex = 4
        Me.lblProgrammerSummaryForm.Text = "Programmers Name Goes Here"
        Me.lblProgrammerSummaryForm.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.lblProgrammerSummaryForm.Visible = False
        '
        'lblNumChartersLabel
        '
        Me.lblNumChartersLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblNumChartersLabel.AutoSize = True
        Me.lblNumChartersLabel.Location = New System.Drawing.Point(3, 88)
        Me.lblNumChartersLabel.Name = "lblNumChartersLabel"
        Me.lblNumChartersLabel.Size = New System.Drawing.Size(157, 19)
        Me.lblNumChartersLabel.TabIndex = 1
        Me.lblNumChartersLabel.Text = "Number of Charters:"
        Me.lblNumChartersLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAvgHoursCharteredLabel
        '
        Me.lblAvgHoursCharteredLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblAvgHoursCharteredLabel.AutoSize = True
        Me.lblAvgHoursCharteredLabel.Location = New System.Drawing.Point(3, 137)
        Me.lblAvgHoursCharteredLabel.Name = "lblAvgHoursCharteredLabel"
        Me.lblAvgHoursCharteredLabel.Size = New System.Drawing.Size(198, 19)
        Me.lblAvgHoursCharteredLabel.TabIndex = 5
        Me.lblAvgHoursCharteredLabel.Text = "Average Hours Chartered:"
        Me.lblAvgHoursCharteredLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTotalRevenueLabel
        '
        Me.lblTotalRevenueLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblTotalRevenueLabel.AutoSize = True
        Me.lblTotalRevenueLabel.Location = New System.Drawing.Point(3, 186)
        Me.lblTotalRevenueLabel.Name = "lblTotalRevenueLabel"
        Me.lblTotalRevenueLabel.Size = New System.Drawing.Size(120, 19)
        Me.lblTotalRevenueLabel.TabIndex = 6
        Me.lblTotalRevenueLabel.Text = "Total Revenue: "
        Me.lblTotalRevenueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblNumChartersOutput
        '
        Me.lblNumChartersOutput.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblNumChartersOutput.AutoSize = True
        Me.lblNumChartersOutput.Location = New System.Drawing.Point(263, 88)
        Me.lblNumChartersOutput.Name = "lblNumChartersOutput"
        Me.lblNumChartersOutput.Size = New System.Drawing.Size(54, 19)
        Me.lblNumChartersOutput.TabIndex = 7
        Me.lblNumChartersOutput.Text = "88888"
        Me.lblNumChartersOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAvgHoursCharteredOut
        '
        Me.lblAvgHoursCharteredOut.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblAvgHoursCharteredOut.AutoSize = True
        Me.lblAvgHoursCharteredOut.Location = New System.Drawing.Point(263, 137)
        Me.lblAvgHoursCharteredOut.Name = "lblAvgHoursCharteredOut"
        Me.lblAvgHoursCharteredOut.Size = New System.Drawing.Size(54, 19)
        Me.lblAvgHoursCharteredOut.TabIndex = 8
        Me.lblAvgHoursCharteredOut.Text = "88888"
        Me.lblAvgHoursCharteredOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotalRevenueOut
        '
        Me.lblTotalRevenueOut.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblTotalRevenueOut.AutoSize = True
        Me.lblTotalRevenueOut.Location = New System.Drawing.Point(213, 186)
        Me.lblTotalRevenueOut.Name = "lblTotalRevenueOut"
        Me.lblTotalRevenueOut.Size = New System.Drawing.Size(104, 19)
        Me.lblTotalRevenueOut.TabIndex = 9
        Me.lblTotalRevenueOut.Text = "$8888888.88"
        Me.lblTotalRevenueOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'reportSummary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(323, 264)
        Me.Controls.Add(Me.tlayoutSummary)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Name = "reportSummary"
        Me.Text = "reportSummary"
        Me.tlayoutSummary.ResumeLayout(False)
        Me.tlayoutSummary.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblSummaryReportHeader As Label
    Friend WithEvents tlayoutSummary As TableLayoutPanel
    Friend WithEvents lblProgrammerSummaryForm As Label
    Friend WithEvents lblNumChartersLabel As Label
    Friend WithEvents lblAvgHoursCharteredLabel As Label
    Friend WithEvents lblTotalRevenueLabel As Label
    Friend WithEvents lblNumChartersOutput As Label
    Friend WithEvents lblAvgHoursCharteredOut As Label
    Friend WithEvents lblTotalRevenueOut As Label
End Class
