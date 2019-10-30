<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditYachtTypes
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
        Me.tblloYachtRemoval = New System.Windows.Forms.TableLayoutPanel()
        Me.lblYachtRemovalHeader = New System.Windows.Forms.Label()
        Me.lblYachtRemovalInstructions = New System.Windows.Forms.Label()
        Me.dmnYachts = New System.Windows.Forms.DomainUpDown()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.tblloYachtRemoval.SuspendLayout()
        Me.SuspendLayout()
        '
        'tblloYachtRemoval
        '
        Me.tblloYachtRemoval.ColumnCount = 1
        Me.tblloYachtRemoval.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblloYachtRemoval.Controls.Add(Me.lblYachtRemovalHeader, 0, 0)
        Me.tblloYachtRemoval.Controls.Add(Me.lblYachtRemovalInstructions, 0, 1)
        Me.tblloYachtRemoval.Controls.Add(Me.dmnYachts, 0, 2)
        Me.tblloYachtRemoval.Controls.Add(Me.btnOK, 0, 3)
        Me.tblloYachtRemoval.Controls.Add(Me.btnCancel, 0, 4)
        Me.tblloYachtRemoval.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold)
        Me.tblloYachtRemoval.Location = New System.Drawing.Point(5, 12)
        Me.tblloYachtRemoval.Name = "tblloYachtRemoval"
        Me.tblloYachtRemoval.RowCount = 5
        Me.tblloYachtRemoval.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.tblloYachtRemoval.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72.0!))
        Me.tblloYachtRemoval.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tblloYachtRemoval.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tblloYachtRemoval.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tblloYachtRemoval.Size = New System.Drawing.Size(312, 236)
        Me.tblloYachtRemoval.TabIndex = 2
        '
        'lblYachtRemovalHeader
        '
        Me.lblYachtRemovalHeader.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblYachtRemovalHeader.AutoSize = True
        Me.lblYachtRemovalHeader.Font = New System.Drawing.Font("Roboto", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYachtRemovalHeader.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lblYachtRemovalHeader.Location = New System.Drawing.Point(15, 0)
        Me.lblYachtRemovalHeader.Name = "lblYachtRemovalHeader"
        Me.lblYachtRemovalHeader.Size = New System.Drawing.Size(281, 35)
        Me.lblYachtRemovalHeader.TabIndex = 0
        Me.lblYachtRemovalHeader.Text = "Yacht Type Removal"
        Me.lblYachtRemovalHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblYachtRemovalInstructions
        '
        Me.lblYachtRemovalInstructions.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblYachtRemovalInstructions.AutoSize = True
        Me.lblYachtRemovalInstructions.Font = New System.Drawing.Font("Roboto", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblYachtRemovalInstructions.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblYachtRemovalInstructions.Location = New System.Drawing.Point(9, 50)
        Me.lblYachtRemovalInstructions.Name = "lblYachtRemovalInstructions"
        Me.lblYachtRemovalInstructions.Size = New System.Drawing.Size(294, 68)
        Me.lblYachtRemovalInstructions.TabIndex = 0
        Me.lblYachtRemovalInstructions.Text = "Pick a yacht type to remove." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Then choose OK to close this dialogue " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "and remove " &
    "the yacht type from the program." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Press 'Cancel' to go back." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblYachtRemovalInstructions.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'dmnYachts
        '
        Me.dmnYachts.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.dmnYachts.Location = New System.Drawing.Point(3, 125)
        Me.dmnYachts.Name = "dmnYachts"
        Me.dmnYachts.Size = New System.Drawing.Size(306, 27)
        Me.dmnYachts.TabIndex = 1
        Me.dmnYachts.Text = "DomainUpDown1"
        '
        'btnOK
        '
        Me.btnOK.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnOK.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnOK.Location = New System.Drawing.Point(95, 155)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(121, 34)
        Me.btnOK.TabIndex = 2
        Me.btnOK.Text = "&OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCancel.Location = New System.Drawing.Point(95, 195)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(121, 34)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'frmEditYachtTypes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(323, 267)
        Me.Controls.Add(Me.tblloYachtRemoval)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Name = "frmEditYachtTypes"
        Me.Text = "frmEditYachtTypes"
        Me.tblloYachtRemoval.ResumeLayout(False)
        Me.tblloYachtRemoval.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tblloYachtRemoval As TableLayoutPanel
    Friend WithEvents lblYachtRemovalHeader As Label
    Friend WithEvents lblYachtRemovalInstructions As Label
    Friend WithEvents dmnYachts As DomainUpDown
    Friend WithEvents btnOK As Button
    Friend WithEvents btnCancel As Button
End Class
