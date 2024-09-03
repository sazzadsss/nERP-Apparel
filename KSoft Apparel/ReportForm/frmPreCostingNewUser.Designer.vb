<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPreCostingNewUser
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
        Me.components = New System.ComponentModel.Container()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.ShowAmnd = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.PreCostingAmndLookupTableAdapter = New KSoft_Apparel.PreCostingNoLookupDataSetTableAdapters.PreCostingAmndLookupTableAdapter()
        Me.PreCostingAmndLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PreCostingNoLookupDataSet1 = New KSoft_Apparel.PreCostingNoLookupDataSet()
        Me.PreCostingNoLookupTableAdapter = New KSoft_Apparel.PreCostingNoLookupDataSetTableAdapters.PreCostingNoLookupTableAdapter()
        Me.PreCostingNoLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PreCostingNoLookupDataSet = New KSoft_Apparel.PreCostingNoLookupDataSet()
        Me.PrecostingGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDetails = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPreCostingDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.AmndLookupGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colAmendmentNo = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.PreCostingAmndLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PreCostingNoLookupDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PreCostingNoLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PreCostingNoLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrecostingGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AmndLookupGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(2, 56)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.ShowGroupTreeButton = False
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1071, 519)
        Me.CrystalReportViewer1.TabIndex = 43
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'ShowAmnd
        '
        Me.ShowAmnd.Location = New System.Drawing.Point(671, 4)
        Me.ShowAmnd.Name = "ShowAmnd"
        Me.ShowAmnd.Size = New System.Drawing.Size(82, 37)
        Me.ShowAmnd.TabIndex = 47
        Me.ShowAmnd.Text = "&Show "
        Me.ShowAmnd.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(440, 4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(82, 37)
        Me.Button3.TabIndex = 48
        Me.Button3.Text = "&Show"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(534, 12)
        Me.Label1.Margin = New System.Windows.Forms.Padding(7, 15, 3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 14)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Version:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(-1, 15)
        Me.Label21.Margin = New System.Windows.Forms.Padding(7, 15, 3, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(127, 14)
        Me.Label21.TabIndex = 45
        Me.Label21.Text = "Pre Costing / Budget No :"
        '
        'PreCostingAmndLookupTableAdapter
        '
        Me.PreCostingAmndLookupTableAdapter.ClearBeforeFill = True
        '
        'PreCostingAmndLookupBindingSource
        '
        Me.PreCostingAmndLookupBindingSource.DataMember = "PreCostingAmndLookup"
        Me.PreCostingAmndLookupBindingSource.DataSource = Me.PreCostingNoLookupDataSet1
        '
        'PreCostingNoLookupDataSet1
        '
        Me.PreCostingNoLookupDataSet1.DataSetName = "PreCostingNoLookupDataSet"
        Me.PreCostingNoLookupDataSet1.EnforceConstraints = False
        Me.PreCostingNoLookupDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PreCostingNoLookupTableAdapter
        '
        Me.PreCostingNoLookupTableAdapter.ClearBeforeFill = True
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
        'PrecostingGridLookUpEdit
        '
        Me.PrecostingGridLookUpEdit.Location = New System.Drawing.Point(126, 13)
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
        Me.PrecostingGridLookUpEdit.TabIndex = 49
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDetails, Me.colPreCostingDate})
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
        'colPreCostingDate
        '
        Me.colPreCostingDate.Caption = "Costing/Budget Date"
        Me.colPreCostingDate.FieldName = "PreCostingDate"
        Me.colPreCostingDate.Name = "colPreCostingDate"
        Me.colPreCostingDate.Visible = True
        Me.colPreCostingDate.VisibleIndex = 1
        Me.colPreCostingDate.Width = 553
        '
        'AmndLookupGridLookUpEdit
        '
        Me.AmndLookupGridLookUpEdit.Location = New System.Drawing.Point(591, 12)
        Me.AmndLookupGridLookUpEdit.Name = "AmndLookupGridLookUpEdit"
        Me.AmndLookupGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.AmndLookupGridLookUpEdit.Properties.DataSource = Me.PreCostingAmndLookupBindingSource
        Me.AmndLookupGridLookUpEdit.Properties.DisplayMember = "AmendmentNo"
        Me.AmndLookupGridLookUpEdit.Properties.ImmediatePopup = True
        Me.AmndLookupGridLookUpEdit.Properties.NullText = ""
        Me.AmndLookupGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.AmndLookupGridLookUpEdit.Properties.PopupView = Me.GridView1
        Me.AmndLookupGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.AmndLookupGridLookUpEdit.Properties.ValueMember = "PreCostingId"
        Me.AmndLookupGridLookUpEdit.Size = New System.Drawing.Size(74, 20)
        Me.AmndLookupGridLookUpEdit.TabIndex = 50
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colAmendmentNo})
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colAmendmentNo
        '
        Me.colAmendmentNo.FieldName = "AmendmentNo"
        Me.colAmendmentNo.Name = "colAmendmentNo"
        Me.colAmendmentNo.Visible = True
        Me.colAmendmentNo.VisibleIndex = 0
        '
        'frmPreCostingNewUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1075, 577)
        Me.Controls.Add(Me.AmndLookupGridLookUpEdit)
        Me.Controls.Add(Me.PrecostingGridLookUpEdit)
        Me.Controls.Add(Me.ShowAmnd)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "frmPreCostingNewUser"
        Me.Text = "Pre Costing/Budget Sheet Print for General"
        CType(Me.PreCostingAmndLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PreCostingNoLookupDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PreCostingNoLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PreCostingNoLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrecostingGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AmndLookupGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents ShowAmnd As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents PreCostingAmndLookupTableAdapter As PreCostingNoLookupDataSetTableAdapters.PreCostingAmndLookupTableAdapter
    Friend WithEvents PreCostingAmndLookupBindingSource As BindingSource
    Friend WithEvents PreCostingNoLookupDataSet1 As PreCostingNoLookupDataSet
    Friend WithEvents PreCostingNoLookupTableAdapter As PreCostingNoLookupDataSetTableAdapters.PreCostingNoLookupTableAdapter
    Friend WithEvents PreCostingNoLookupBindingSource As BindingSource
    Friend WithEvents PreCostingNoLookupDataSet As PreCostingNoLookupDataSet
    Friend WithEvents PrecostingGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colDetails As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPreCostingDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AmndLookupGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colAmendmentNo As DevExpress.XtraGrid.Columns.GridColumn
End Class
