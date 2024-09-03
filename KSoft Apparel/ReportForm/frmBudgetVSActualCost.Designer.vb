<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBudgetVSActualCost
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
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.PreCostingNoLookupDataSet = New KSoft_Apparel.PreCostingNoLookupDataSet()
        Me.PreCostingNoLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PreCostingNoLookupTableAdapter = New KSoft_Apparel.PreCostingNoLookupDataSetTableAdapters.PreCostingNoLookupTableAdapter()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.PrecostingGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDetails = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAmendmentNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPreCostingDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        CType(Me.PreCostingNoLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PreCostingNoLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrecostingGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 53)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.ShowGroupTreeButton = False
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1123, 347)
        Me.CrystalReportViewer1.TabIndex = 43
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'PreCostingNoLookupDataSet
        '
        Me.PreCostingNoLookupDataSet.DataSetName = "PreCostingNoLookupDataSet"
        Me.PreCostingNoLookupDataSet.EnforceConstraints = False
        Me.PreCostingNoLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PreCostingNoLookupBindingSource
        '
        Me.PreCostingNoLookupBindingSource.DataMember = "PreCostingNoLookup"
        Me.PreCostingNoLookupBindingSource.DataSource = Me.PreCostingNoLookupDataSet
        '
        'PreCostingNoLookupTableAdapter
        '
        Me.PreCostingNoLookupTableAdapter.ClearBeforeFill = True
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(603, 20)
        Me.Label21.Margin = New System.Windows.Forms.Padding(7, 15, 3, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(127, 14)
        Me.Label21.TabIndex = 44
        Me.Label21.Text = "Pre Costing / Budget No :"
        '
        'PrecostingGridLookUpEdit
        '
        Me.PrecostingGridLookUpEdit.Location = New System.Drawing.Point(730, 17)
        Me.PrecostingGridLookUpEdit.Name = "PrecostingGridLookUpEdit"
        Me.PrecostingGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PrecostingGridLookUpEdit.Properties.DataSource = Me.PreCostingNoLookupBindingSource
        Me.PrecostingGridLookUpEdit.Properties.DisplayMember = "Details"
        Me.PrecostingGridLookUpEdit.Properties.ImmediatePopup = True
        Me.PrecostingGridLookUpEdit.Properties.NullText = ""
        Me.PrecostingGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.PrecostingGridLookUpEdit.Properties.PopupView = Me.GridLookUpEdit1View
        Me.PrecostingGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.PrecostingGridLookUpEdit.Properties.ValueMember = "PreCostingId"
        Me.PrecostingGridLookUpEdit.Size = New System.Drawing.Size(308, 20)
        Me.PrecostingGridLookUpEdit.TabIndex = 45
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
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(361, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(113, 41)
        Me.Button1.TabIndex = 47
        Me.Button1.Text = "&Show All Running"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(480, 6)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(113, 41)
        Me.Button3.TabIndex = 48
        Me.Button3.Text = "&Show All "
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(1044, 6)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(72, 41)
        Me.Button4.TabIndex = 49
        Me.Button4.Text = "&Show"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(123, 6)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(113, 41)
        Me.Button2.TabIndex = 50
        Me.Button2.Text = "&Show Complete"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(4, 6)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(113, 41)
        Me.Button5.TabIndex = 51
        Me.Button5.Text = "&Show Approved"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(242, 6)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(113, 41)
        Me.Button6.TabIndex = 52
        Me.Button6.Text = "&Show Cancel"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'frmBudgetVSActualCost
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1123, 400)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.PrecostingGridLookUpEdit)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "frmBudgetVSActualCost"
        Me.Text = "Post Costing/Budget [Budget VS Actual Cost$ Sheet]"
        CType(Me.PreCostingNoLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PreCostingNoLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrecostingGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents PreCostingNoLookupDataSet As PreCostingNoLookupDataSet
    Friend WithEvents PreCostingNoLookupBindingSource As BindingSource
    Friend WithEvents PreCostingNoLookupTableAdapter As PreCostingNoLookupDataSetTableAdapters.PreCostingNoLookupTableAdapter
    Friend WithEvents Label21 As Label
    Friend WithEvents PrecostingGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colDetails As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAmendmentNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPreCostingDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
End Class
