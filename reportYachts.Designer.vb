<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class reportYachts
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
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblYachtReportHeader = New System.Windows.Forms.Label()
        Me.lblYachtTypeReportOutput = New System.Windows.Forms.Label()
        Me.lblProgrammerYachtForm = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.lblProgrammerYachtForm, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.lblYachtReportHeader, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lblYachtTypeReportOutput, 0, 1)
        Me.TableLayoutPanel2.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(5, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(312, 141)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'lblYachtReportHeader
        '
        Me.lblYachtReportHeader.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblYachtReportHeader.AutoSize = True
        Me.lblYachtReportHeader.Font = New System.Drawing.Font("Roboto", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYachtReportHeader.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lblYachtReportHeader.Location = New System.Drawing.Point(8, 0)
        Me.lblYachtReportHeader.Name = "lblYachtReportHeader"
        Me.lblYachtReportHeader.Size = New System.Drawing.Size(295, 35)
        Me.lblYachtReportHeader.TabIndex = 0
        Me.lblYachtReportHeader.Text = "Availible Yacht Types"
        Me.lblYachtReportHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblYachtTypeReportOutput
        '
        Me.lblYachtTypeReportOutput.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblYachtTypeReportOutput.AutoSize = True
        Me.lblYachtTypeReportOutput.Location = New System.Drawing.Point(61, 60)
        Me.lblYachtTypeReportOutput.Name = "lblYachtTypeReportOutput"
        Me.lblYachtTypeReportOutput.Size = New System.Drawing.Size(190, 19)
        Me.lblYachtTypeReportOutput.TabIndex = 1
        Me.lblYachtTypeReportOutput.Text = "Yacht Types Will Go Here"
        Me.lblYachtTypeReportOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblProgrammerYachtForm
        '
        Me.lblProgrammerYachtForm.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblProgrammerYachtForm.AutoSize = True
        Me.lblProgrammerYachtForm.Font = New System.Drawing.Font("Roboto", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblProgrammerYachtForm.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblProgrammerYachtForm.Location = New System.Drawing.Point(118, 124)
        Me.lblProgrammerYachtForm.Name = "lblProgrammerYachtForm"
        Me.lblProgrammerYachtForm.Size = New System.Drawing.Size(76, 17)
        Me.lblProgrammerYachtForm.TabIndex = 4
        Me.lblProgrammerYachtForm.Text = "$88888.88"
        Me.lblProgrammerYachtForm.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.lblProgrammerYachtForm.Visible = False
        '
        'reportYachts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(323, 450)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Name = "reportYachts"
        Me.Text = "reportYachts"
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents lblYachtReportHeader As Label
    Friend WithEvents lblYachtTypeReportOutput As Label
    Friend WithEvents lblProgrammerYachtForm As Label
End Class
