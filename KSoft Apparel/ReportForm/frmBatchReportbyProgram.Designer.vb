Imports CrystalDecisions.Windows.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBatchReportbyProgram
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
        Me.GridLookUpEdit1 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colProgramNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ShowButton = New System.Windows.Forms.Button()
        Me.FreshRadioButton = New System.Windows.Forms.RadioButton()
        Me.ReprocessRadioButton = New System.Windows.Forms.RadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BatchNoShowButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BatchNoLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.BatchProgramNoLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BatchProgramLookupDataSet = New KSoft_Dyeing.BatchProgramLookupDataSet()
        Me.colBatchNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BatchProgramNoTableAdapter = New KSoft_Dyeing.BatchProgramLookupDataSetTableAdapters.BatchProgramNoTableAdapter()
        Me.FinishFabricOrderLookupDataSet = New KSoft_Dyeing.FinishFabricOrderLookupDataSet()
        Me.FinishFabricOrderLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FinishFabricOrderLookupTableAdapter = New KSoft_Dyeing.FinishFabricOrderLookupDataSetTableAdapters.FinishFabricOrderLookupTableAdapter()
        Me.colStyleName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBuyerName = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.GridLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.BatchNoLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BatchProgramNoLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BatchProgramLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FinishFabricOrderLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FinishFabricOrderLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 34)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(846, 427)
        Me.CrystalReportViewer1.TabIndex = 0
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'GridLookUpEdit1
        '
        Me.GridLookUpEdit1.Location = New System.Drawing.Point(229, 7)
        Me.GridLookUpEdit1.Name = "GridLookUpEdit1"
        Me.GridLookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GridLookUpEdit1.Properties.DataSource = Me.FinishFabricOrderLookupBindingSource
        Me.GridLookUpEdit1.Properties.DisplayMember = "ProgramNo"
        Me.GridLookUpEdit1.Properties.ImmediatePopup = True
        Me.GridLookUpEdit1.Properties.NullText = "[Type Program No]"
        Me.GridLookUpEdit1.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.GridLookUpEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.GridLookUpEdit1.Properties.ValueMember = "ProgramNo"
        Me.GridLookUpEdit1.Properties.View = Me.GridLookUpEdit1View
        Me.GridLookUpEdit1.Size = New System.Drawing.Size(138, 20)
        Me.GridLookUpEdit1.TabIndex = 2
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colProgramNo, Me.colStyleName, Me.colBuyerName})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colProgramNo
        '
        Me.colProgramNo.FieldName = "ProgramNo"
        Me.colProgramNo.Name = "colProgramNo"
        Me.colProgramNo.Visible = True
        Me.colProgramNo.VisibleIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(160, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Program No"
        '
        'ShowButton
        '
        Me.ShowButton.Location = New System.Drawing.Point(373, 4)
        Me.ShowButton.Name = "ShowButton"
        Me.ShowButton.Size = New System.Drawing.Size(73, 23)
        Me.ShowButton.TabIndex = 4
        Me.ShowButton.Text = "&Show"
        Me.ShowButton.UseVisualStyleBackColor = True
        '
        'FreshRadioButton
        '
        Me.FreshRadioButton.AutoSize = True
        Me.FreshRadioButton.Checked = True
        Me.FreshRadioButton.Location = New System.Drawing.Point(3, 3)
        Me.FreshRadioButton.Name = "FreshRadioButton"
        Me.FreshRadioButton.Size = New System.Drawing.Size(51, 17)
        Me.FreshRadioButton.TabIndex = 5
        Me.FreshRadioButton.TabStop = True
        Me.FreshRadioButton.Text = "Fresh"
        Me.FreshRadioButton.UseVisualStyleBackColor = True
        '
        'ReprocessRadioButton
        '
        Me.ReprocessRadioButton.AutoSize = True
        Me.ReprocessRadioButton.Location = New System.Drawing.Point(60, 3)
        Me.ReprocessRadioButton.Name = "ReprocessRadioButton"
        Me.ReprocessRadioButton.Size = New System.Drawing.Size(76, 17)
        Me.ReprocessRadioButton.TabIndex = 6
        Me.ReprocessRadioButton.Text = "Reprocess"
        Me.ReprocessRadioButton.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.FreshRadioButton)
        Me.Panel1.Controls.Add(Me.ReprocessRadioButton)
        Me.Panel1.Location = New System.Drawing.Point(9, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(145, 24)
        Me.Panel1.TabIndex = 7
        '
        'BatchNoShowButton
        '
        Me.BatchNoShowButton.Location = New System.Drawing.Point(667, 4)
        Me.BatchNoShowButton.Name = "BatchNoShowButton"
        Me.BatchNoShowButton.Size = New System.Drawing.Size(73, 23)
        Me.BatchNoShowButton.TabIndex = 10
        Me.BatchNoShowButton.Text = "&Show"
        Me.BatchNoShowButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(465, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Batch No"
        '
        'BatchNoLookUpEdit
        '
        Me.BatchNoLookUpEdit.Location = New System.Drawing.Point(523, 6)
        Me.BatchNoLookUpEdit.Name = "BatchNoLookUpEdit"
        Me.BatchNoLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.BatchNoLookUpEdit.Properties.DataSource = Me.BatchProgramNoLookupBindingSource
        Me.BatchNoLookUpEdit.Properties.DisplayMember = "BatchNo"
        Me.BatchNoLookUpEdit.Properties.ImmediatePopup = True
        Me.BatchNoLookUpEdit.Properties.NullText = "[Type Batch No]"
        Me.BatchNoLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.BatchNoLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.BatchNoLookUpEdit.Properties.ValueMember = "BatchNo"
        Me.BatchNoLookUpEdit.Properties.View = Me.GridView1
        Me.BatchNoLookUpEdit.Size = New System.Drawing.Size(138, 20)
        Me.BatchNoLookUpEdit.TabIndex = 8
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colBatchNo})
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'BatchProgramNoLookupBindingSource
        '
        Me.BatchProgramNoLookupBindingSource.DataMember = "BatchProgramNoLookup"
        Me.BatchProgramNoLookupBindingSource.DataSource = Me.BatchProgramLookupDataSet
        '
        'BatchProgramLookupDataSet
        '
        Me.BatchProgramLookupDataSet.DataSetName = "BatchProgramLookupDataSet"
        Me.BatchProgramLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'colBatchNo
        '
        Me.colBatchNo.FieldName = "BatchNo"
        Me.colBatchNo.Name = "colBatchNo"
        Me.colBatchNo.Visible = True
        Me.colBatchNo.VisibleIndex = 0
        '
        'BatchProgramNoTableAdapter
        '
        Me.BatchProgramNoTableAdapter.ClearBeforeFill = True
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
        'colStyleName
        '
        Me.colStyleName.FieldName = "StyleName"
        Me.colStyleName.Name = "colStyleName"
        Me.colStyleName.Visible = True
        Me.colStyleName.VisibleIndex = 1
        '
        'colBuyerName
        '
        Me.colBuyerName.FieldName = "BuyerName"
        Me.colBuyerName.Name = "colBuyerName"
        Me.colBuyerName.Visible = True
        Me.colBuyerName.VisibleIndex = 2
        '
        'frmBatchReportbyProgram
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(846, 460)
        Me.Controls.Add(Me.BatchNoShowButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BatchNoLookUpEdit)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ShowButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GridLookUpEdit1)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "frmBatchReportbyProgram"
        Me.Text = "Batch Report by Program"
        CType(Me.GridLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.BatchNoLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BatchProgramNoLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BatchProgramLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FinishFabricOrderLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FinishFabricOrderLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents GridLookUpEdit1 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BatchProgramLookupDataSet As KSoft_Dyeing.BatchProgramLookupDataSet
    Friend WithEvents BatchProgramNoLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BatchProgramNoTableAdapter As KSoft_Dyeing.BatchProgramLookupDataSetTableAdapters.BatchProgramNoTableAdapter
    Friend WithEvents colProgramNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ShowButton As System.Windows.Forms.Button
    Friend WithEvents FreshRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents ReprocessRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BatchNoShowButton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents BatchNoLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colBatchNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FinishFabricOrderLookupDataSet As FinishFabricOrderLookupDataSet
    Friend WithEvents FinishFabricOrderLookupBindingSource As BindingSource
    Friend WithEvents FinishFabricOrderLookupTableAdapter As FinishFabricOrderLookupDataSetTableAdapters.FinishFabricOrderLookupTableAdapter
    Friend WithEvents colStyleName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBuyerName As DevExpress.XtraGrid.Columns.GridColumn
End Class
