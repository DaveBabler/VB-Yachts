<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmYachtsEntry
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
        Me.mnuStripYachtEntry = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrintYachtTypes = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrintSummary = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDisplayYachtCount = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClearForNext = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuAddYachtType = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRemoveYachtType = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.grpParty = New System.Windows.Forms.GroupBox()
        Me.lblPartyName = New System.Windows.Forms.Label()
        Me.lblHoursChartered = New System.Windows.Forms.Label()
        Me.lblCalculatedPrice = New System.Windows.Forms.Label()
        Me.lblCalculatedPriceOutput = New System.Windows.Forms.Label()
        Me.txtHoursChartered = New System.Windows.Forms.TextBox()
        Me.txtResponsibleParty = New System.Windows.Forms.TextBox()
        Me.grpYachts = New System.Windows.Forms.GroupBox()
        Me.mnuStripYachtEntry.SuspendLayout()
        Me.grpParty.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuStripYachtEntry
        '
        Me.mnuStripYachtEntry.Font = New System.Drawing.Font("Tw Cen MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuStripYachtEntry.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuEdit, Me.mnuHelp})
        Me.mnuStripYachtEntry.Location = New System.Drawing.Point(0, 0)
        Me.mnuStripYachtEntry.Name = "mnuStripYachtEntry"
        Me.mnuStripYachtEntry.Size = New System.Drawing.Size(800, 27)
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
        'mnuHelp
        '
        Me.mnuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAbout})
        Me.mnuHelp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.Size = New System.Drawing.Size(51, 23)
        Me.mnuHelp.Text = "&Help"
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
        'mnuAbout
        '
        Me.mnuAbout.Font = New System.Drawing.Font("Tw Cen MT", 11.0!)
        Me.mnuAbout.Name = "mnuAbout"
        Me.mnuAbout.Size = New System.Drawing.Size(180, 22)
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
        Me.grpParty.Size = New System.Drawing.Size(370, 143)
        Me.grpParty.TabIndex = 1
        Me.grpParty.TabStop = False
        Me.grpParty.Text = "Party"
        '
        'lblPartyName
        '
        Me.lblPartyName.AutoSize = True
        Me.lblPartyName.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPartyName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblPartyName.Location = New System.Drawing.Point(16, 38)
        Me.lblPartyName.Name = "lblPartyName"
        Me.lblPartyName.Size = New System.Drawing.Size(139, 20)
        Me.lblPartyName.TabIndex = 0
        Me.lblPartyName.Text = "Responsible Party"
        '
        'lblHoursChartered
        '
        Me.lblHoursChartered.AutoSize = True
        Me.lblHoursChartered.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHoursChartered.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblHoursChartered.Location = New System.Drawing.Point(16, 70)
        Me.lblHoursChartered.Name = "lblHoursChartered"
        Me.lblHoursChartered.Size = New System.Drawing.Size(128, 20)
        Me.lblHoursChartered.TabIndex = 1
        Me.lblHoursChartered.Text = "Hours Chartered"
        '
        'lblCalculatedPrice
        '
        Me.lblCalculatedPrice.AutoSize = True
        Me.lblCalculatedPrice.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCalculatedPrice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblCalculatedPrice.Location = New System.Drawing.Point(16, 102)
        Me.lblCalculatedPrice.Name = "lblCalculatedPrice"
        Me.lblCalculatedPrice.Size = New System.Drawing.Size(126, 20)
        Me.lblCalculatedPrice.TabIndex = 2
        Me.lblCalculatedPrice.Text = "Calculated Price"
        '
        'lblCalculatedPriceOutput
        '
        Me.lblCalculatedPriceOutput.AutoSize = True
        Me.lblCalculatedPriceOutput.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCalculatedPriceOutput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblCalculatedPriceOutput.Location = New System.Drawing.Point(279, 102)
        Me.lblCalculatedPriceOutput.Name = "lblCalculatedPriceOutput"
        Me.lblCalculatedPriceOutput.Size = New System.Drawing.Size(86, 20)
        Me.lblCalculatedPriceOutput.TabIndex = 3
        Me.lblCalculatedPriceOutput.Text = "$88888.88"
        Me.lblCalculatedPriceOutput.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.lblCalculatedPriceOutput.Visible = False
        '
        'txtHoursChartered
        '
        Me.txtHoursChartered.BackColor = System.Drawing.Color.Gainsboro
        Me.txtHoursChartered.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHoursChartered.Location = New System.Drawing.Point(306, 67)
        Me.txtHoursChartered.Name = "txtHoursChartered"
        Me.txtHoursChartered.Size = New System.Drawing.Size(59, 23)
        Me.txtHoursChartered.TabIndex = 4
        Me.txtHoursChartered.Text = "000"
        Me.txtHoursChartered.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtResponsibleParty
        '
        Me.txtResponsibleParty.BackColor = System.Drawing.Color.Gainsboro
        Me.txtResponsibleParty.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResponsibleParty.Location = New System.Drawing.Point(187, 35)
        Me.txtResponsibleParty.Name = "txtResponsibleParty"
        Me.txtResponsibleParty.Size = New System.Drawing.Size(178, 23)
        Me.txtResponsibleParty.TabIndex = 5
        Me.txtResponsibleParty.Text = "XXXXResponsible PartyXXXX"
        Me.txtResponsibleParty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'grpYachts
        '
        Me.grpYachts.BackColor = System.Drawing.Color.Transparent
        Me.grpYachts.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpYachts.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.grpYachts.Location = New System.Drawing.Point(15, 187)
        Me.grpYachts.Name = "grpYachts"
        Me.grpYachts.Size = New System.Drawing.Size(370, 251)
        Me.grpYachts.TabIndex = 6
        Me.grpYachts.TabStop = False
        Me.grpYachts.Text = "Yachts"
        '
        'frmYachtsEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.grpYachts)
        Me.Controls.Add(Me.grpParty)
        Me.Controls.Add(Me.mnuStripYachtEntry)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MainMenuStrip = Me.mnuStripYachtEntry
        Me.Name = "frmYachtsEntry"
        Me.Text = "Yacht Entry"
        Me.mnuStripYachtEntry.ResumeLayout(False)
        Me.mnuStripYachtEntry.PerformLayout()
        Me.grpParty.ResumeLayout(False)
        Me.grpParty.PerformLayout()
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
End Class
