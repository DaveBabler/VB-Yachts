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
        Me.mnuStripYachtEntry.SuspendLayout()
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
        'frmYachtsEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.mnuStripYachtEntry)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MainMenuStrip = Me.mnuStripYachtEntry
        Me.Name = "frmYachtsEntry"
        Me.Text = "Yacht Entry"
        Me.mnuStripYachtEntry.ResumeLayout(False)
        Me.mnuStripYachtEntry.PerformLayout()
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
End Class
