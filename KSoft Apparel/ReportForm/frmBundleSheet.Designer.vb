<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBundleSheet
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
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.BundleSheetButton = New System.Windows.Forms.Button
        Me.BundleStickerButton = New System.Windows.Forms.Button
        Me.CuttingNoTextBox = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        'Me.CrystalReportViewer1.DisplayGroupTree = False
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 28)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1040, 504)
        Me.CrystalReportViewer1.TabIndex = 1
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'BundleSheetButton
        '
        Me.BundleSheetButton.Location = New System.Drawing.Point(273, 3)
        Me.BundleSheetButton.Name = "BundleSheetButton"
        Me.BundleSheetButton.Size = New System.Drawing.Size(111, 23)
        Me.BundleSheetButton.TabIndex = 2
        Me.BundleSheetButton.Text = "Bundle Sheet"
        Me.BundleSheetButton.UseVisualStyleBackColor = True
        '
        'BundleStickerButton
        '
        Me.BundleStickerButton.Location = New System.Drawing.Point(390, 3)
        Me.BundleStickerButton.Name = "BundleStickerButton"
        Me.BundleStickerButton.Size = New System.Drawing.Size(112, 23)
        Me.BundleStickerButton.TabIndex = 3
        Me.BundleStickerButton.Text = "Bundle Sticker"
        Me.BundleStickerButton.UseVisualStyleBackColor = True
        '
        'CuttingNoTextBox
        '
        Me.CuttingNoTextBox.Location = New System.Drawing.Point(132, 4)
        Me.CuttingNoTextBox.Name = "CuttingNoTextBox"
        Me.CuttingNoTextBox.Size = New System.Drawing.Size(124, 20)
        Me.CuttingNoTextBox.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Cutting No :"
        '
        'frmBundleSheet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1040, 532)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CuttingNoTextBox)
        Me.Controls.Add(Me.BundleStickerButton)
        Me.Controls.Add(Me.BundleSheetButton)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "frmBundleSheet"
        Me.Text = "Bundle Sheet"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents BundleSheetButton As System.Windows.Forms.Button
    Friend WithEvents BundleStickerButton As System.Windows.Forms.Button
    Friend WithEvents CuttingNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
