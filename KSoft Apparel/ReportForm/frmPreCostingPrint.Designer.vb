<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPreCostingPrint
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.PrecostingGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.PreCostingNoLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PreCostingNoLookupDataSet = New KSoft_Apparel.PreCostingNoLookupDataSet()
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDetails = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAmendmentNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPreCostingDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ShowButton = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PreCostingNoLookupTableAdapter = New KSoft_Apparel.PreCostingNoLookupDataSetTableAdapters.PreCostingNoLookupTableAdapter()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.PrecostingGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PreCostingNoLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PreCostingNoLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(7, 19)
        Me.Label21.Margin = New System.Windows.Forms.Padding(7, 15, 3, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(127, 14)
        Me.Label21.TabIndex = 33
        Me.Label21.Text = "Pre Costing / Budget No :"
        '
        'PrecostingGridLookUpEdit
        '
        Me.PrecostingGridLookUpEdit.Location = New System.Drawing.Point(134, 16)
        Me.PrecostingGridLookUpEdit.Name = "PrecostingGridLookUpEdit"
        Me.PrecostingGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PrecostingGridLookUpEdit.Properties.DataSource = Me.PreCostingNoLookupBindingSource
        Me.PrecostingGridLookUpEdit.Properties.DisplayMember = "Details"
        Me.PrecostingGridLookUpEdit.Properties.ImmediatePopup = True
        Me.PrecostingGridLookUpEdit.Properties.NullText = ""
        Me.PrecostingGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.PrecostingGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.PrecostingGridLookUpEdit.Properties.ValueMember = "PreCostingId"
        Me.PrecostingGridLookUpEdit.Properties.View = Me.GridLookUpEdit1View
        Me.PrecostingGridLookUpEdit.Size = New System.Drawing.Size(308, 20)
        Me.PrecostingGridLookUpEdit.TabIndex = 34
        '
        'PreCostingNoLookupBindingSource
        '
        Me.PreCostingNoLookupBindingSource.DataMember = "PreCostingNoLookup"
        Me.PreCostingNoLookupBindingSource.DataSource = Me.PreCostingNoLookupDataSet
        '
        'PreCostingNoLookupDataSet
        '
        Me.PreCostingNoLookupDataSet.DataSetName = "PreCostingNoLookupDataSet"
        Me.PreCostingNoLookupDataSet.EnforceConstraints = False
        Me.PreCostingNoLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDetails, Me.colAmendmentNo, Me.colPreCostingDate})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colDetails
        '
        Me.colDetails.FieldName = "Details"
        Me.colDetails.Name = "colDetails"
        Me.colDetails.Visible = True
        Me.colDetails.VisibleIndex = 0
        Me.colDetails.Width = 799
        '
        'colAmendmentNo
        '
        Me.colAmendmentNo.Caption = "Version"
        Me.colAmendmentNo.FieldName = "AmendmentNo"
        Me.colAmendmentNo.Name = "colAmendmentNo"
        Me.colAmendmentNo.Visible = True
        Me.colAmendmentNo.VisibleIndex = 1
        Me.colAmendmentNo.Width = 280
        '
        'colPreCostingDate
        '
        Me.colPreCostingDate.Caption = "Costing/Budget Date"
        Me.colPreCostingDate.FieldName = "PreCostingDate"
        Me.colPreCostingDate.Name = "colPreCostingDate"
        Me.colPreCostingDate.Visible = True
        Me.colPreCostingDate.VisibleIndex = 2
        Me.colPreCostingDate.Width = 553
        '
        'ShowButton
        '
        Me.ShowButton.Location = New System.Drawing.Point(536, 5)
        Me.ShowButton.Name = "ShowButton"
        Me.ShowButton.Size = New System.Drawing.Size(82, 41)
        Me.ShowButton.TabIndex = 36
        Me.ShowButton.Text = "&Show  [Legal]"
        Me.ShowButton.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Location = New System.Drawing.Point(624, 5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(208, 41)
        Me.Button2.TabIndex = 36
        Me.Button2.Text = "&Show [Budget Cost$ VS Actual Cost$]"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PreCostingNoLookupTableAdapter
        '
        Me.PreCostingNoLookupTableAdapter.ClearBeforeFill = True
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 52)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.ShowGroupTreeButton = False
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1118, 592)
        Me.CrystalReportViewer1.TabIndex = 42
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(838, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(127, 41)
        Me.Button1.TabIndex = 36
        Me.Button1.Text = "&Fabric Details"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(448, 5)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(82, 41)
        Me.Button3.TabIndex = 36
        Me.Button3.Text = "&Show [A4]"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'frmPreCostingPrint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1118, 645)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.ShowButton)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.PrecostingGridLookUpEdit)
        Me.Name = "frmPreCostingPrint"
        Me.Text = "Pre Costing/Budget Sheet Print"
        CType(Me.PrecostingGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PreCostingNoLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PreCostingNoLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents PrecostingGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PreCostingNoLookupDataSet As KSoft_Apparel.PreCostingNoLookupDataSet
    Friend WithEvents PreCostingNoLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PreCostingNoLookupTableAdapter As KSoft_Apparel.PreCostingNoLookupDataSetTableAdapters.PreCostingNoLookupTableAdapter
    Friend WithEvents ShowButton As System.Windows.Forms.Button
    Friend WithEvents Button2 As Button
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents colDetails As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAmendmentNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPreCostingDate As DevExpress.XtraGrid.Columns.GridColumn
End Class
