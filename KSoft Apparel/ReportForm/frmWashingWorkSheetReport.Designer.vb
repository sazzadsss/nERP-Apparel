<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWashingWorkSheetReport
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
        Me.components = New System.ComponentModel.Container
        Dim WashingRequestNoLabel As System.Windows.Forms.Label
        Me.ShowButton = New System.Windows.Forms.Button
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.WashingRequestNoLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colWashingRequestNo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WashingRequestDataSet = New KSoft_Apparel.WashingRequestDataSet
        Me.WashingRequestLookUpBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WashingRequestLookUpTableAdapter = New KSoft_Apparel.WashingRequestDataSetTableAdapters.WashingRequestLookUpTableAdapter
        WashingRequestNoLabel = New System.Windows.Forms.Label
        CType(Me.WashingRequestNoLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WashingRequestDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WashingRequestLookUpBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ShowButton
        '
        Me.ShowButton.Location = New System.Drawing.Point(415, 4)
        Me.ShowButton.Name = "ShowButton"
        Me.ShowButton.Size = New System.Drawing.Size(83, 23)
        Me.ShowButton.TabIndex = 9
        Me.ShowButton.Text = "&Show"
        Me.ShowButton.UseVisualStyleBackColor = True
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        'Me.CrystalReportViewer1.DisplayGroupTree = False
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(1, 33)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(966, 433)
        Me.CrystalReportViewer1.TabIndex = 8
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'WashingRequestNoLookUpEdit
        '
        Me.WashingRequestNoLookUpEdit.Location = New System.Drawing.Point(130, 6)
        Me.WashingRequestNoLookUpEdit.Name = "WashingRequestNoLookUpEdit"
        Me.WashingRequestNoLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.WashingRequestNoLookUpEdit.Properties.DataSource = Me.WashingRequestLookUpBindingSource
        Me.WashingRequestNoLookUpEdit.Properties.DisplayMember = "WashingRequestNo"
        Me.WashingRequestNoLookUpEdit.Properties.ImmediatePopup = True
        Me.WashingRequestNoLookUpEdit.Properties.NullText = ""
        Me.WashingRequestNoLookUpEdit.Properties.ValueMember = "WashingRequestId"
        Me.WashingRequestNoLookUpEdit.Properties.View = Me.GridView4
        Me.WashingRequestNoLookUpEdit.Size = New System.Drawing.Size(279, 20)
        Me.WashingRequestNoLookUpEdit.TabIndex = 18
        '
        'GridView4
        '
        Me.GridView4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colWashingRequestNo})
        Me.GridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView4.OptionsView.ShowGroupPanel = False
        '
        'colWashingRequestNo
        '
        Me.colWashingRequestNo.FieldName = "WashingRequestNo"
        Me.colWashingRequestNo.Name = "colWashingRequestNo"
        Me.colWashingRequestNo.Visible = True
        Me.colWashingRequestNo.VisibleIndex = 0
        '
        'WashingRequestNoLabel
        '
        WashingRequestNoLabel.AutoSize = True
        WashingRequestNoLabel.Location = New System.Drawing.Point(12, 9)
        WashingRequestNoLabel.Name = "WashingRequestNoLabel"
        WashingRequestNoLabel.Size = New System.Drawing.Size(112, 13)
        WashingRequestNoLabel.TabIndex = 19
        WashingRequestNoLabel.Text = "Washing Request No:"
        '
        'WashingRequestDataSet
        '
        Me.WashingRequestDataSet.DataSetName = "WashingRequestDataSet"
        Me.WashingRequestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'WashingRequestLookUpBindingSource
        '
        Me.WashingRequestLookUpBindingSource.DataMember = "WashingRequestLookUp"
        Me.WashingRequestLookUpBindingSource.DataSource = Me.WashingRequestDataSet
        '
        'WashingRequestLookUpTableAdapter
        '
        Me.WashingRequestLookUpTableAdapter.ClearBeforeFill = True
        '
        'frmWashingWorkSheetReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(965, 465)
        Me.Controls.Add(WashingRequestNoLabel)
        Me.Controls.Add(Me.WashingRequestNoLookUpEdit)
        Me.Controls.Add(Me.ShowButton)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "frmWashingWorkSheetReport"
        Me.Text = "Washing Work Sheet Report"
        CType(Me.WashingRequestNoLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WashingRequestDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WashingRequestLookUpBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ShowButton As System.Windows.Forms.Button
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents WashingRequestNoLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colWashingRequestNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WashingRequestDataSet As KSoft_Apparel.WashingRequestDataSet
    Friend WithEvents WashingRequestLookUpBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents WashingRequestLookUpTableAdapter As KSoft_Apparel.WashingRequestDataSetTableAdapters.WashingRequestLookUpTableAdapter
End Class
