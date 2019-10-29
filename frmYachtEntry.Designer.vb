<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmYachtEntryMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmYachtEntryMain))
        Me.mnuStripYachtEntry = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrintYachtTypes = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrintSummary = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDisplayYachtCount = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClearForNext = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuAddYachtType = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRemoveYachtType = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.grpParty = New System.Windows.Forms.GroupBox()
        Me.txtResponsibleParty = New System.Windows.Forms.TextBox()
        Me.txtHoursChartered = New System.Windows.Forms.TextBox()
        Me.lblCalculatedPriceOutput = New System.Windows.Forms.Label()
        Me.lblCalculatedPrice = New System.Windows.Forms.Label()
        Me.lblHoursChartered = New System.Windows.Forms.Label()
        Me.lblPartyName = New System.Windows.Forms.Label()
        Me.grpYachts = New System.Windows.Forms.GroupBox()
        Me.lstAvailibleYachtLength = New System.Windows.Forms.ListBox()
        Me.cboYachtType = New System.Windows.Forms.ComboBox()
        Me.lblAvailibleLength = New System.Windows.Forms.Label()
        Me.lblYachType = New System.Windows.Forms.Label()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.picYachtParty = New System.Windows.Forms.PictureBox()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.DebuggingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowReportYachtsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowReportSummaryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuStripYachtEntry.SuspendLayout()
        Me.grpParty.SuspendLayout()
        Me.grpYachts.SuspendLayout()
        CType(Me.picYachtParty, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mnuStripYachtEntry
        '
        Me.mnuStripYachtEntry.Font = New System.Drawing.Font("Tw Cen MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuStripYachtEntry.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuEdit, Me.mnuHelp, Me.DebuggingToolStripMenuItem})
        Me.mnuStripYachtEntry.Location = New System.Drawing.Point(0, 0)
        Me.mnuStripYachtEntry.Name = "mnuStripYachtEntry"
        Me.mnuStripYachtEntry.Size = New System.Drawing.Size(662, 27)
        Me.mnuStripYachtEntry.TabIndex = 0
        Me.mnuStripYachtEntry.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPrintYachtTypes, Me.mnuPrintSummary, Me.mnuDisplayYachtCount, Me.mnuExit})
        Me.mnuFile.ForeColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(42, 23)
        Me.mnuFile.Text = "&File"
        '
        'mnuPrintYachtTypes
        '
        Me.mnuPrintYachtTypes.Font = New System.Drawing.Font("Tw Cen MT", 11.0!)
        Me.mnuPrintYachtTypes.Name = "mnuPrintYachtTypes"
        Me.mnuPrintYachtTypes.Size = New System.Drawing.Size(204, 24)
        Me.mnuPrintYachtTypes.Text = "Print &Yacht Types"
        '
        'mnuPrintSummary
        '
        Me.mnuPrintSummary.Name = "mnuPrintSummary"
        Me.mnuPrintSummary.Size = New System.Drawing.Size(204, 24)
        Me.mnuPrintSummary.Text = "Print &Summary"
        '
        'mnuDisplayYachtCount
        '
        Me.mnuDisplayYachtCount.Name = "mnuDisplayYachtCount"
        Me.mnuDisplayYachtCount.Size = New System.Drawing.Size(204, 24)
        Me.mnuDisplayYachtCount.Text = "&Display Yacht Count"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(204, 24)
        Me.mnuExit.Text = "&Exit"
        '
        'mnuEdit
        '
        Me.mnuEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClearForNext, Me.ToolStripSeparator1, Me.mnuAddYachtType, Me.mnuRemoveYachtType})
        Me.mnuEdit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.mnuEdit.Name = "mnuEdit"
        Me.mnuEdit.Size = New System.Drawing.Size(44, 23)
        Me.mnuEdit.Text = "&Edit"
        '
        'mnuClearForNext
        '
        Me.mnuClearForNext.Font = New System.Drawing.Font("Tw Cen MT", 11.0!)
        Me.mnuClearForNext.Name = "mnuClearForNext"
        Me.mnuClearForNext.Size = New System.Drawing.Size(191, 22)
        Me.mnuClearForNext.Text = "&Clear for Next"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(188, 6)
        '
        'mnuAddYachtType
        '
        Me.mnuAddYachtType.Font = New System.Drawing.Font("Tw Cen MT", 11.0!)
        Me.mnuAddYachtType.Name = "mnuAddYachtType"
        Me.mnuAddYachtType.Size = New System.Drawing.Size(191, 22)
        Me.mnuAddYachtType.Text = "&Add YactType"
        '
        'mnuRemoveYachtType
        '
        Me.mnuRemoveYachtType.Font = New System.Drawing.Font("Tw Cen MT", 11.0!)
        Me.mnuRemoveYachtType.Name = "mnuRemoveYachtType"
        Me.mnuRemoveYachtType.Size = New System.Drawing.Size(191, 22)
        Me.mnuRemoveYachtType.Text = "&Remove Yact Type"
        '
        'mnuHelp
        '
        Me.mnuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAbout})
        Me.mnuHelp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.Size = New System.Drawing.Size(51, 23)
        Me.mnuHelp.Text = "&Help"
        '
        'mnuAbout
        '
        Me.mnuAbout.Font = New System.Drawing.Font("Tw Cen MT", 11.0!)
        Me.mnuAbout.Name = "mnuAbout"
        Me.mnuAbout.Size = New System.Drawing.Size(113, 22)
        Me.mnuAbout.Text = "&About"
        '
        'grpParty
        '
        Me.grpParty.BackColor = System.Drawing.Color.Transparent
        Me.grpParty.Controls.Add(Me.txtResponsibleParty)
        Me.grpParty.Controls.Add(Me.txtHoursChartered)
        Me.grpParty.Controls.Add(Me.lblCalculatedPriceOutput)
        Me.grpParty.Controls.Add(Me.lblCalculatedPrice)
        Me.grpParty.Controls.Add(Me.lblHoursChartered)
        Me.grpParty.Controls.Add(Me.lblPartyName)
        Me.grpParty.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpParty.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.grpParty.Location = New System.Drawing.Point(15, 38)
        Me.grpParty.Name = "grpParty"
        Me.grpParty.Size = New System.Drawing.Size(387, 143)
        Me.grpParty.TabIndex = 1
        Me.grpParty.TabStop = False
        Me.grpParty.Text = "Party"
        '
        'txtResponsibleParty
        '
        Me.txtResponsibleParty.BackColor = System.Drawing.Color.Gainsboro
        Me.txtResponsibleParty.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResponsibleParty.Location = New System.Drawing.Point(187, 35)
        Me.txtResponsibleParty.Name = "txtResponsibleParty"
        Me.txtResponsibleParty.Size = New System.Drawing.Size(178, 23)
        Me.txtResponsibleParty.TabIndex = 0
        Me.txtResponsibleParty.Text = "XXXXResponsible PartyXXXX"
        Me.txtResponsibleParty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtHoursChartered
        '
        Me.txtHoursChartered.BackColor = System.Drawing.Color.Gainsboro
        Me.txtHoursChartered.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHoursChartered.Location = New System.Drawing.Point(306, 67)
        Me.txtHoursChartered.Name = "txtHoursChartered"
        Me.txtHoursChartered.Size = New System.Drawing.Size(59, 23)
        Me.txtHoursChartered.TabIndex = 1
        Me.txtHoursChartered.Text = "000"
        Me.txtHoursChartered.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblCalculatedPriceOutput
        '
        Me.lblCalculatedPriceOutput.AutoSize = True
        Me.lblCalculatedPriceOutput.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCalculatedPriceOutput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblCalculatedPriceOutput.Location = New System.Drawing.Point(279, 102)
        Me.lblCalculatedPriceOutput.Name = "lblCalculatedPriceOutput"
        Me.lblCalculatedPriceOutput.Size = New System.Drawing.Size(86, 19)
        Me.lblCalculatedPriceOutput.TabIndex = 3
        Me.lblCalculatedPriceOutput.Text = "$88888.88"
        Me.lblCalculatedPriceOutput.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.lblCalculatedPriceOutput.Visible = False
        '
        'lblCalculatedPrice
        '
        Me.lblCalculatedPrice.AutoSize = True
        Me.lblCalculatedPrice.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCalculatedPrice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblCalculatedPrice.Location = New System.Drawing.Point(16, 102)
        Me.lblCalculatedPrice.Name = "lblCalculatedPrice"
        Me.lblCalculatedPrice.Size = New System.Drawing.Size(131, 19)
        Me.lblCalculatedPrice.TabIndex = 2
        Me.lblCalculatedPrice.Text = "Calculated Price:"
        Me.lblCalculatedPrice.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'lblHoursChartered
        '
        Me.lblHoursChartered.AutoSize = True
        Me.lblHoursChartered.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHoursChartered.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblHoursChartered.Location = New System.Drawing.Point(16, 70)
        Me.lblHoursChartered.Name = "lblHoursChartered"
        Me.lblHoursChartered.Size = New System.Drawing.Size(133, 19)
        Me.lblHoursChartered.TabIndex = 1
        Me.lblHoursChartered.Text = "Hours Chartered:"
        Me.lblHoursChartered.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'lblPartyName
        '
        Me.lblPartyName.AutoSize = True
        Me.lblPartyName.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPartyName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblPartyName.Location = New System.Drawing.Point(16, 38)
        Me.lblPartyName.Name = "lblPartyName"
        Me.lblPartyName.Size = New System.Drawing.Size(144, 19)
        Me.lblPartyName.TabIndex = 0
        Me.lblPartyName.Text = "Responsible Party:"
        Me.lblPartyName.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'grpYachts
        '
        Me.grpYachts.BackColor = System.Drawing.Color.Transparent
        Me.grpYachts.Controls.Add(Me.lstAvailibleYachtLength)
        Me.grpYachts.Controls.Add(Me.cboYachtType)
        Me.grpYachts.Controls.Add(Me.lblAvailibleLength)
        Me.grpYachts.Controls.Add(Me.lblYachType)
        Me.grpYachts.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpYachts.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.grpYachts.Location = New System.Drawing.Point(15, 187)
        Me.grpYachts.Name = "grpYachts"
        Me.grpYachts.Size = New System.Drawing.Size(387, 251)
        Me.grpYachts.TabIndex = 2
        Me.grpYachts.TabStop = False
        Me.grpYachts.Text = "Yachts"
        '
        'lstAvailibleYachtLength
        '
        Me.lstAvailibleYachtLength.BackColor = System.Drawing.Color.Gainsboro
        Me.lstAvailibleYachtLength.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lstAvailibleYachtLength.FormattingEnabled = True
        Me.lstAvailibleYachtLength.ItemHeight = 15
        Me.lstAvailibleYachtLength.Location = New System.Drawing.Point(187, 95)
        Me.lstAvailibleYachtLength.Name = "lstAvailibleYachtLength"
        Me.lstAvailibleYachtLength.Size = New System.Drawing.Size(178, 109)
        Me.lstAvailibleYachtLength.TabIndex = 4
        '
        'cboYachtType
        '
        Me.cboYachtType.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.cboYachtType.BackColor = System.Drawing.Color.Gainsboro
        Me.cboYachtType.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Bold)
        Me.cboYachtType.FormattingEnabled = True
        Me.cboYachtType.Location = New System.Drawing.Point(187, 44)
        Me.cboYachtType.Name = "cboYachtType"
        Me.cboYachtType.Size = New System.Drawing.Size(177, 23)
        Me.cboYachtType.TabIndex = 3
        '
        'lblAvailibleLength
        '
        Me.lblAvailibleLength.AutoSize = True
        Me.lblAvailibleLength.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvailibleLength.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblAvailibleLength.Location = New System.Drawing.Point(16, 95)
        Me.lblAvailibleLength.Name = "lblAvailibleLength"
        Me.lblAvailibleLength.Size = New System.Drawing.Size(130, 19)
        Me.lblAvailibleLength.TabIndex = 2
        Me.lblAvailibleLength.Text = "Availible Length:"
        Me.lblAvailibleLength.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'lblYachType
        '
        Me.lblYachType.AutoSize = True
        Me.lblYachType.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYachType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblYachType.Location = New System.Drawing.Point(16, 44)
        Me.lblYachType.Name = "lblYachType"
        Me.lblYachType.Size = New System.Drawing.Size(94, 19)
        Me.lblYachType.TabIndex = 1
        Me.lblYachType.Text = "Yacht Type:"
        Me.lblYachType.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'btnOK
        '
        Me.btnOK.BackColor = System.Drawing.Color.Gainsboro
        Me.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnOK.Font = New System.Drawing.Font("Tw Cen MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOK.ForeColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.btnOK.Location = New System.Drawing.Point(470, 64)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(110, 32)
        Me.btnOK.TabIndex = 5
        Me.btnOK.Text = "&OK"
        Me.btnOK.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Gainsboro
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClear.Font = New System.Drawing.Font("Tw Cen MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.btnClear.Location = New System.Drawing.Point(470, 122)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(110, 32)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Gainsboro
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Tw Cen MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(470, 180)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(110, 32)
        Me.Button2.TabIndex = 7
        Me.Button2.TabStop = False
        Me.Button2.Text = "E&xit"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'picYachtParty
        '
        Me.picYachtParty.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picYachtParty.Image = Global.Yachts.My.Resources.Resources.Yacht_Party
        Me.picYachtParty.Location = New System.Drawing.Point(470, 238)
        Me.picYachtParty.Name = "picYachtParty"
        Me.picYachtParty.Size = New System.Drawing.Size(175, 175)
        Me.picYachtParty.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picYachtParty.TabIndex = 8
        Me.picYachtParty.TabStop = False
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.MainMenuStrip = Me.mnuStripYachtEntry
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'DebuggingToolStripMenuItem
        '
        Me.DebuggingToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShowReportYachtsToolStripMenuItem, Me.ShowReportSummaryToolStripMenuItem})
        Me.DebuggingToolStripMenuItem.Name = "DebuggingToolStripMenuItem"
        Me.DebuggingToolStripMenuItem.Size = New System.Drawing.Size(92, 23)
        Me.DebuggingToolStripMenuItem.Text = "Debugging"
        '
        'ShowReportYachtsToolStripMenuItem
        '
        Me.ShowReportYachtsToolStripMenuItem.Name = "ShowReportYachtsToolStripMenuItem"
        Me.ShowReportYachtsToolStripMenuItem.Size = New System.Drawing.Size(221, 24)
        Me.ShowReportYachtsToolStripMenuItem.Text = "Show Report Yachts"
        '
        'ShowReportSummaryToolStripMenuItem
        '
        Me.ShowReportSummaryToolStripMenuItem.Name = "ShowReportSummaryToolStripMenuItem"
        Me.ShowReportSummaryToolStripMenuItem.Size = New System.Drawing.Size(221, 24)
        Me.ShowReportSummaryToolStripMenuItem.Text = "Show Report Summary"
        '
        'frmYachtEntryMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(662, 450)
        Me.Controls.Add(Me.picYachtParty)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.grpYachts)
        Me.Controls.Add(Me.grpParty)
        Me.Controls.Add(Me.mnuStripYachtEntry)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MainMenuStrip = Me.mnuStripYachtEntry
        Me.Name = "frmYachtEntryMain"
        Me.Text = "Yacht Entry"
        Me.mnuStripYachtEntry.ResumeLayout(False)
        Me.mnuStripYachtEntry.PerformLayout()
        Me.grpParty.ResumeLayout(False)
        Me.grpParty.PerformLayout()
        Me.grpYachts.ResumeLayout(False)
        Me.grpYachts.PerformLayout()
        CType(Me.picYachtParty, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuStripYachtEntry As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuPrintYachtTypes As ToolStripMenuItem
    Friend WithEvents mnuPrintSummary As ToolStripMenuItem
    Friend WithEvents mnuDisplayYachtCount As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents mnuEdit As ToolStripMenuItem
    Friend WithEvents mnuClearForNext As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents mnuAddYachtType As ToolStripMenuItem
    Friend WithEvents mnuRemoveYachtType As ToolStripMenuItem
    Friend WithEvents mnuHelp As ToolStripMenuItem
    Friend WithEvents mnuAbout As ToolStripMenuItem
    Friend WithEvents grpParty As GroupBox
    Friend WithEvents lblPartyName As Label
    Friend WithEvents lblCalculatedPriceOutput As Label
    Friend WithEvents lblCalculatedPrice As Label
    Friend WithEvents lblHoursChartered As Label
    Friend WithEvents txtHoursChartered As TextBox
    Friend WithEvents txtResponsibleParty As TextBox
    Friend WithEvents grpYachts As GroupBox
    Friend WithEvents lblAvailibleLength As Label
    Friend WithEvents lblYachType As Label
    Friend WithEvents lstAvailibleYachtLength As ListBox
    Friend WithEvents cboYachtType As ComboBox
    Friend WithEvents btnOK As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents picYachtParty As PictureBox
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents DebuggingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ShowReportYachtsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ShowReportSummaryToolStripMenuItem As ToolStripMenuItem
End Class
