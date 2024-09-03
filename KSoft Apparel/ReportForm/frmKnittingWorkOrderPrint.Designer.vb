<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKnittingWorkOrderPrint
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
        Me.KWOrderLookupDataSet = New KSoft_Apparel.KWOrderLookupDataSet()
        Me.KWOrderLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KWOrderLookupTableAdapter = New KSoft_Apparel.KWOrderLookupDataSetTableAdapters.KWOrderLookupTableAdapter()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ShowButton = New System.Windows.Forms.Button()
        Me.KWOrderLookupGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colKnittingOrderId1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProgramNo2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDetails2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSupplierName1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.FinishFabricOrderLookupDataSet = New KSoft_Apparel.FinishFabricOrderLookupDataSet()
        Me.FinishFabricOrderLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FinishFabricOrderLookupTableAdapter = New KSoft_Apparel.FinishFabricOrderLookupDataSetTableAdapters.FinishFabricOrderLookupTableAdapter()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ProgramShowButton = New System.Windows.Forms.Button()
        Me.ProgramNoGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDetails = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.KWOrderLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KWOrderLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KWOrderLookupGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FinishFabricOrderLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FinishFabricOrderLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProgramNoGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 31)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1045, 443)
        Me.CrystalReportViewer1.TabIndex = 0
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'KWOrderLookupDataSet
        '
        Me.KWOrderLookupDataSet.DataSetName = "KWOrderLookupDataSet"
        Me.KWOrderLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'KWOrderLookupBindingSource
        '
        Me.KWOrderLookupBindingSource.DataMember = "KWOrderLookup"
        Me.KWOrderLookupBindingSource.DataSource = Me.KWOrderLookupDataSet
        '
        'KWOrderLookupTableAdapter
        '
        Me.KWOrderLookupTableAdapter.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 13)
        Me.Label2.TabIndex = 60
        Me.Label2.Text = "Knitting Work Order"
        '
        'ShowButton
        '
        Me.ShowButton.Location = New System.Drawing.Point(323, 4)
        Me.ShowButton.Margin = New System.Windows.Forms.Padding(3, 6, 3, 3)
        Me.ShowButton.Name = "ShowButton"
        Me.ShowButton.Size = New System.Drawing.Size(69, 23)
        Me.ShowButton.TabIndex = 59
        Me.ShowButton.Text = "&Show"
        Me.ShowButton.UseVisualStyleBackColor = True
        '
        'KWOrderLookupGridLookUpEdit
        '
        Me.KWOrderLookupGridLookUpEdit.Location = New System.Drawing.Point(115, 5)
        Me.KWOrderLookupGridLookUpEdit.Name = "KWOrderLookupGridLookUpEdit"
        Me.KWOrderLookupGridLookUpEdit.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.KWOrderLookupGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.KWOrderLookupGridLookUpEdit.Properties.DataSource = Me.KWOrderLookupBindingSource
        Me.KWOrderLookupGridLookUpEdit.Properties.DisplayMember = "Details"
        Me.KWOrderLookupGridLookUpEdit.Properties.ImmediatePopup = True
        Me.KWOrderLookupGridLookUpEdit.Properties.NullText = ""
        Me.KWOrderLookupGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.KWOrderLookupGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.KWOrderLookupGridLookUpEdit.Properties.ValueMember = "KnittingOrderId"
        Me.KWOrderLookupGridLookUpEdit.Properties.View = Me.GridView5
        Me.KWOrderLookupGridLookUpEdit.Size = New System.Drawing.Size(202, 20)
        Me.KWOrderLookupGridLookUpEdit.TabIndex = 58
        '
        'GridView5
        '
        Me.GridView5.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colKnittingOrderId1, Me.colProgramNo2, Me.colDetails2, Me.colSupplierName1})
        Me.GridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView5.Name = "GridView5"
        Me.GridView5.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView5.OptionsView.ShowGroupPanel = False
        '
        'colKnittingOrderId1
        '
        Me.colKnittingOrderId1.FieldName = "KnittingOrderId"
        Me.colKnittingOrderId1.Name = "colKnittingOrderId1"
        '
        'colProgramNo2
        '
        Me.colProgramNo2.FieldName = "ProgramNo"
        Me.colProgramNo2.Name = "colProgramNo2"
        Me.colProgramNo2.OptionsColumn.ReadOnly = True
        '
        'colDetails2
        '
        Me.colDetails2.FieldName = "Details"
        Me.colDetails2.Name = "colDetails2"
        Me.colDetails2.OptionsColumn.ReadOnly = True
        Me.colDetails2.Visible = True
        Me.colDetails2.VisibleIndex = 0
        '
        'colSupplierName1
        '
        Me.colSupplierName1.FieldName = "SupplierName"
        Me.colSupplierName1.Name = "colSupplierName1"
        Me.colSupplierName1.Visible = True
        Me.colSupplierName1.VisibleIndex = 1
        '
        'FinishFabricOrderLookupDataSet
        '
        Me.FinishFabricOrderLookupDataSet.DataSetName = "FinishFabricOrderLookupDataSet"
        Me.FinishFabricOrderLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FinishFabricOrderLookupBindingSource
        '
        Me.FinishFabricOrderLookupBindingSource.DataMember = "FinishFabricOrderLookup"
        Me.FinishFabricOrderLookupBindingSource.DataSource = Me.FinishFabricOrderLookupDataSet
        '
        'FinishFabricOrderLookupTableAdapter
        '
        Me.FinishFabricOrderLookupTableAdapter.ClearBeforeFill = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(451, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 15)
        Me.Label3.TabIndex = 63
        Me.Label3.Text = "Program_Style_Buyer:"
        '
        'ProgramShowButton
        '
        Me.ProgramShowButton.Location = New System.Drawing.Point(734, 4)
        Me.ProgramShowButton.Name = "ProgramShowButton"
        Me.ProgramShowButton.Size = New System.Drawing.Size(64, 20)
        Me.ProgramShowButton.TabIndex = 62
        Me.ProgramShowButton.Text = "&Show"
        Me.ProgramShowButton.UseVisualStyleBackColor = True
        '
        'ProgramNoGridLookUpEdit
        '
        Me.ProgramNoGridLookUpEdit.Location = New System.Drawing.Point(565, 4)
        Me.ProgramNoGridLookUpEdit.Name = "ProgramNoGridLookUpEdit"
        Me.ProgramNoGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ProgramNoGridLookUpEdit.Properties.DataSource = Me.FinishFabricOrderLookupBindingSource
        Me.ProgramNoGridLookUpEdit.Properties.DisplayMember = "Details"
        Me.ProgramNoGridLookUpEdit.Properties.ImmediatePopup = True
        Me.ProgramNoGridLookUpEdit.Properties.NullText = "[Type Program No]"
        Me.ProgramNoGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.ProgramNoGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.ProgramNoGridLookUpEdit.Properties.ValueMember = "ProgramNo"
        Me.ProgramNoGridLookUpEdit.Properties.View = Me.GridLookUpEdit1View
        Me.ProgramNoGridLookUpEdit.Size = New System.Drawing.Size(160, 20)
        Me.ProgramNoGridLookUpEdit.TabIndex = 61
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDetails})
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
        '
        'frmKnittingWorkOrderPrint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1045, 474)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ProgramShowButton)
        Me.Controls.Add(Me.ProgramNoGridLookUpEdit)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ShowButton)
        Me.Controls.Add(Me.KWOrderLookupGridLookUpEdit)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "frmKnittingWorkOrderPrint"
        Me.Text = "Knitting Work Order Print"
        CType(Me.KWOrderLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KWOrderLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KWOrderLookupGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FinishFabricOrderLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FinishFabricOrderLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProgramNoGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents KWOrderLookupDataSet As KSoft_Apparel.KWOrderLookupDataSet
    Friend WithEvents KWOrderLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents KWOrderLookupTableAdapter As KSoft_Apparel.KWOrderLookupDataSetTableAdapters.KWOrderLookupTableAdapter
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ShowButton As System.Windows.Forms.Button
    Friend WithEvents KWOrderLookupGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colKnittingOrderId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProgramNo2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDetails2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplierName1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FinishFabricOrderLookupBindingSource As BindingSource
    Friend WithEvents FinishFabricOrderLookupDataSet As FinishFabricOrderLookupDataSet
    Friend WithEvents FinishFabricOrderLookupTableAdapter As FinishFabricOrderLookupDataSetTableAdapters.FinishFabricOrderLookupTableAdapter
    Friend WithEvents Label3 As Label
    Friend WithEvents ProgramShowButton As Button
    Friend WithEvents ProgramNoGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colDetails As DevExpress.XtraGrid.Columns.GridColumn
End Class
