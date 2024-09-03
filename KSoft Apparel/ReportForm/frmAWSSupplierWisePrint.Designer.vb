<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAWSSupplierWisePrint
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
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.AWSNoLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit
        Me.AWSLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AWSLookupDataSet = New KSoft_Apparel.AWSLookupDataSet
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.AWSLookupTableAdapter = New KSoft_Apparel.AWSLookupDataSetTableAdapters.AWSLookupTableAdapter
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.AWSNoLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AWSLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AWSLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'Me.CrystalReportViewer1.DisplayGroupTree = False
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 33)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1267, 512)
        Me.CrystalReportViewer1.TabIndex = 1
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'AWSNoLookUpEdit
        '
        Me.AWSNoLookUpEdit.Location = New System.Drawing.Point(149, 7)
        Me.AWSNoLookUpEdit.Name = "AWSNoLookUpEdit"
        Me.AWSNoLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.AWSNoLookUpEdit.Properties.DataSource = Me.AWSLookupBindingSource
        Me.AWSNoLookUpEdit.Properties.DisplayMember = "AWSNo::ProgramNo"
        Me.AWSNoLookUpEdit.Properties.NullText = ""
        Me.AWSNoLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.AWSNoLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.AWSNoLookUpEdit.Properties.ValueMember = "AWSId"
        Me.AWSNoLookUpEdit.Properties.View = Me.GridLookUpEdit1View
        Me.AWSNoLookUpEdit.Size = New System.Drawing.Size(176, 20)
        Me.AWSNoLookUpEdit.TabIndex = 56
        '
        'AWSLookupBindingSource
        '
        Me.AWSLookupBindingSource.DataMember = "AWSLookup"
        Me.AWSLookupBindingSource.DataSource = Me.AWSLookupDataSet
        '
        'AWSLookupDataSet
        '
        Me.AWSLookupDataSet.DataSetName = "AWSLookupDataSet"
        Me.AWSLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 13)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "AWS No :: Program No"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(331, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 57
        Me.Button1.Text = "Show"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'AWSLookupTableAdapter
        '
        Me.AWSLookupTableAdapter.ClearBeforeFill = True
        '
        'GridColumn1
        '
        Me.GridColumn1.FieldName = "AWSNo::ProgramNo"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        '
        'frmAWSSupplierWisePrint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1267, 545)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.AWSNoLookUpEdit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "frmAWSSupplierWisePrint"
        Me.Text = "AWS Supplier Wise Print"
        CType(Me.AWSNoLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AWSLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AWSLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents AWSNoLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents AWSLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AWSLookupDataSet As KSoft_Apparel.AWSLookupDataSet
    Friend WithEvents AWSLookupTableAdapter As KSoft_Apparel.AWSLookupDataSetTableAdapters.AWSLookupTableAdapter
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
End Class
