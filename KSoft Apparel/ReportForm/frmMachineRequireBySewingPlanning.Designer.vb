<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMachineRequireBySewingPlanning
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
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.ShowButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FinishingDateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.FinishingDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 31)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(799, 419)
        Me.CrystalReportViewer1.TabIndex = 1
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'ShowButton
        '
        Me.ShowButton.Location = New System.Drawing.Point(399, 5)
        Me.ShowButton.Name = "ShowButton"
        Me.ShowButton.Size = New System.Drawing.Size(75, 20)
        Me.ShowButton.TabIndex = 10
        Me.ShowButton.Text = "&Show"
        Me.ShowButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(271, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "To : "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Sewing Planning Date From : "
        '
        'FinishingDateTimePicker2
        '
        Me.FinishingDateTimePicker2.CustomFormat = "dd-MMM-yy"
        Me.FinishingDateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.FinishingDateTimePicker2.Location = New System.Drawing.Point(302, 5)
        Me.FinishingDateTimePicker2.Name = "FinishingDateTimePicker2"
        Me.FinishingDateTimePicker2.Size = New System.Drawing.Size(91, 20)
        Me.FinishingDateTimePicker2.TabIndex = 15
        '
        'FinishingDateTimePicker
        '
        Me.FinishingDateTimePicker.CustomFormat = "dd-MMM-yy"
        Me.FinishingDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.FinishingDateTimePicker.Location = New System.Drawing.Point(173, 6)
        Me.FinishingDateTimePicker.Name = "FinishingDateTimePicker"
        Me.FinishingDateTimePicker.Size = New System.Drawing.Size(91, 20)
        Me.FinishingDateTimePicker.TabIndex = 14
        '
        'frmMachineRequireBySewingPlanning
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.FinishingDateTimePicker2)
        Me.Controls.Add(Me.FinishingDateTimePicker)
        Me.Controls.Add(Me.ShowButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "frmMachineRequireBySewingPlanning"
        Me.Text = "Machine Require Report by Sewing Planning"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents ShowButton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents FinishingDateTimePicker2 As DateTimePicker
    Friend WithEvents FinishingDateTimePicker As DateTimePicker
End Class
