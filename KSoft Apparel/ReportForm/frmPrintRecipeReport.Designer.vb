<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrintRecipeReport
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
        Me.PrintColorTableAdapter = New KSoft_Apparel.PrintColorDataSetTableAdapters.PrintColorTableAdapter()
        Me.PrintColorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PrintColorDataSet = New KSoft_Apparel.PrintColorDataSet()
        Me.PrintColorLookupGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colPrintColorId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrintColor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GridLookUpEdit1 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.PrintRecipeLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PrintRecipeLookupDataSet = New KSoft_Apparel.PrintRecipeLookupDataSet()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ShowByRecipeButton = New System.Windows.Forms.Button()
        Me.PrintRecipeLookupTableAdapter = New KSoft_Apparel.PrintRecipeLookupDataSetTableAdapters.PrintRecipeLookupTableAdapter()
        CType(Me.PrintColorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintColorDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintColorLookupGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintRecipeLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintRecipeLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.CrystalReportViewer1.ShowGroupTreeButton = False
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(876, 497)
        Me.CrystalReportViewer1.TabIndex = 0
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'PrintColorTableAdapter
        '
        Me.PrintColorTableAdapter.ClearBeforeFill = True
        '
        'PrintColorBindingSource
        '
        Me.PrintColorBindingSource.DataMember = "PrintColor"
        Me.PrintColorBindingSource.DataSource = Me.PrintColorDataSet
        '
        'PrintColorDataSet
        '
        Me.PrintColorDataSet.DataSetName = "PrintColorDataSet"
        Me.PrintColorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PrintColorLookupGridLookUpEdit
        '
        Me.PrintColorLookupGridLookUpEdit.Location = New System.Drawing.Point(546, 6)
        Me.PrintColorLookupGridLookUpEdit.Name = "PrintColorLookupGridLookUpEdit"
        Me.PrintColorLookupGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PrintColorLookupGridLookUpEdit.Properties.DataSource = Me.PrintColorBindingSource
        Me.PrintColorLookupGridLookUpEdit.Properties.DisplayMember = "PrintColor"
        Me.PrintColorLookupGridLookUpEdit.Properties.ImmediatePopup = True
        Me.PrintColorLookupGridLookUpEdit.Properties.NullText = "[Type Print Color]"
        Me.PrintColorLookupGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.PrintColorLookupGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.PrintColorLookupGridLookUpEdit.Properties.ValueMember = "PrintColorId"
        Me.PrintColorLookupGridLookUpEdit.Properties.View = Me.GridView1
        Me.PrintColorLookupGridLookUpEdit.Size = New System.Drawing.Size(197, 20)
        Me.PrintColorLookupGridLookUpEdit.TabIndex = 37
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPrintColorId, Me.colPrintColor})
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colPrintColorId
        '
        Me.colPrintColorId.FieldName = "PrintColorId"
        Me.colPrintColorId.Name = "colPrintColorId"
        Me.colPrintColorId.OptionsColumn.ReadOnly = True
        '
        'colPrintColor
        '
        Me.colPrintColor.FieldName = "PrintColor"
        Me.colPrintColor.Name = "colPrintColor"
        Me.colPrintColor.Visible = True
        Me.colPrintColor.VisibleIndex = 0
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(474, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 21)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Print Color     "
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(749, 5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(104, 23)
        Me.Button2.TabIndex = 35
        Me.Button2.Text = "Search Recipe"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GridLookUpEdit1
        '
        Me.GridLookUpEdit1.EditValue = ""
        Me.GridLookUpEdit1.Location = New System.Drawing.Point(86, 6)
        Me.GridLookUpEdit1.Name = "GridLookUpEdit1"
        Me.GridLookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GridLookUpEdit1.Properties.DataSource = Me.PrintRecipeLookupBindingSource
        Me.GridLookUpEdit1.Properties.DisplayMember = "Receipe::ProgramNo::Style::Buyer"
        Me.GridLookUpEdit1.Properties.ImmediatePopup = True
        Me.GridLookUpEdit1.Properties.NullText = "[Type Print Color]"
        Me.GridLookUpEdit1.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.GridLookUpEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.GridLookUpEdit1.Properties.ValueMember = "RecipeId"
        Me.GridLookUpEdit1.Properties.View = Me.GridView2
        Me.GridLookUpEdit1.Size = New System.Drawing.Size(272, 20)
        Me.GridLookUpEdit1.TabIndex = 38
        '
        'PrintRecipeLookupBindingSource
        '
        Me.PrintRecipeLookupBindingSource.DataMember = "PrintRecipeLookup"
        Me.PrintRecipeLookupBindingSource.DataSource = Me.PrintRecipeLookupDataSet
        '
        'PrintRecipeLookupDataSet
        '
        Me.PrintRecipeLookupDataSet.DataSetName = "PrintRecipeLookupDataSet"
        Me.PrintRecipeLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1})
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.FieldName = "Receipe::ProgramNo::Style::Buyer"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 21)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Recipe No  "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ShowByRecipeButton
        '
        Me.ShowByRecipeButton.Location = New System.Drawing.Point(364, 4)
        Me.ShowByRecipeButton.Name = "ShowByRecipeButton"
        Me.ShowByRecipeButton.Size = New System.Drawing.Size(104, 23)
        Me.ShowByRecipeButton.TabIndex = 39
        Me.ShowByRecipeButton.Text = "Show"
        Me.ShowByRecipeButton.UseVisualStyleBackColor = True
        '
        'PrintRecipeLookupTableAdapter
        '
        Me.PrintRecipeLookupTableAdapter.ClearBeforeFill = True
        '
        'frmPrintRecipeReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(876, 531)
        Me.Controls.Add(Me.ShowByRecipeButton)
        Me.Controls.Add(Me.GridLookUpEdit1)
        Me.Controls.Add(Me.PrintColorLookupGridLookUpEdit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "frmPrintRecipeReport"
        Me.Text = "Sample Costing Sheet"
        CType(Me.PrintColorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintColorDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintColorLookupGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintRecipeLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintRecipeLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents PrintColorTableAdapter As PrintColorDataSetTableAdapters.PrintColorTableAdapter
    Friend WithEvents PrintColorBindingSource As BindingSource
    Friend WithEvents PrintColorDataSet As PrintColorDataSet
    Friend WithEvents PrintColorLookupGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colPrintColorId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrintColor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label5 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents GridLookUpEdit1 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label1 As Label
    Friend WithEvents ShowByRecipeButton As Button
    Friend WithEvents PrintRecipeLookupDataSet As PrintRecipeLookupDataSet
    Friend WithEvents PrintRecipeLookupBindingSource As BindingSource
    Friend WithEvents PrintRecipeLookupTableAdapter As PrintRecipeLookupDataSetTableAdapters.PrintRecipeLookupTableAdapter
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
End Class
