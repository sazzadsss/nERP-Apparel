<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCuttingReportPOWise
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
        Me.OrderLookupDataSet = New KSoft_Apparel.OrderLookupDataSet()
        Me.OrderLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderLookupTableAdapter = New KSoft_Apparel.OrderLookupDataSetTableAdapters.OrderLookupTableAdapter()
        Me.StyleLookupDataSet = New KSoft_Apparel.StyleLookupDataSet()
        Me.StyleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StyleTableAdapter = New KSoft_Apparel.StyleLookupDataSetTableAdapters.StyleTableAdapter()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SizeCheckBox = New System.Windows.Forms.CheckBox()
        Me.ProgramAllocationButton = New System.Windows.Forms.Button()
        Me.ProgramNoGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDetails = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsPrint = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BuyerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BuyerDataSet = New KSoft_Apparel.BuyerDataSet()
        Me.BuyerTableAdapter = New KSoft_Apparel.BuyerDataSetTableAdapters.BuyerTableAdapter()
        Me.BuyerCheckBox = New System.Windows.Forms.CheckBox()
        Me.BuyerComboBox = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.OrderLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProgramNoGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 62)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(785, 294)
        Me.CrystalReportViewer1.TabIndex = 1
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'OrderLookupDataSet
        '
        Me.OrderLookupDataSet.DataSetName = "OrderLookupDataSet"
        Me.OrderLookupDataSet.EnforceConstraints = False
        Me.OrderLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OrderLookupBindingSource
        '
        Me.OrderLookupBindingSource.DataMember = "OrderLookup"
        Me.OrderLookupBindingSource.DataSource = Me.OrderLookupDataSet
        '
        'OrderLookupTableAdapter
        '
        Me.OrderLookupTableAdapter.ClearBeforeFill = True
        '
        'StyleLookupDataSet
        '
        Me.StyleLookupDataSet.DataSetName = "StyleLookupDataSet"
        Me.StyleLookupDataSet.EnforceConstraints = False
        Me.StyleLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StyleBindingSource
        '
        Me.StyleBindingSource.DataMember = "Style"
        Me.StyleBindingSource.DataSource = Me.StyleLookupDataSet
        '
        'StyleTableAdapter
        '
        Me.StyleTableAdapter.ClearBeforeFill = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(395, 22)
        Me.Label4.Margin = New System.Windows.Forms.Padding(10, 10, 3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 103
        Me.Label4.Text = "Program No:"
        '
        'SizeCheckBox
        '
        Me.SizeCheckBox.AutoSize = True
        Me.SizeCheckBox.Location = New System.Drawing.Point(629, 22)
        Me.SizeCheckBox.Name = "SizeCheckBox"
        Me.SizeCheckBox.Size = New System.Drawing.Size(67, 17)
        Me.SizeCheckBox.TabIndex = 97
        Me.SizeCheckBox.Text = "Sizewise"
        Me.SizeCheckBox.UseVisualStyleBackColor = True
        '
        'ProgramAllocationButton
        '
        Me.ProgramAllocationButton.Location = New System.Drawing.Point(701, 7)
        Me.ProgramAllocationButton.Name = "ProgramAllocationButton"
        Me.ProgramAllocationButton.Size = New System.Drawing.Size(75, 46)
        Me.ProgramAllocationButton.TabIndex = 96
        Me.ProgramAllocationButton.Text = "Show"
        Me.ProgramAllocationButton.UseVisualStyleBackColor = True
        '
        'ProgramNoGridLookUpEdit
        '
        Me.ProgramNoGridLookUpEdit.Location = New System.Drawing.Point(461, 20)
        Me.ProgramNoGridLookUpEdit.Name = "ProgramNoGridLookUpEdit"
        Me.ProgramNoGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ProgramNoGridLookUpEdit.Properties.DataSource = Me.OrderLookupBindingSource
        Me.ProgramNoGridLookUpEdit.Properties.DisplayMember = "Details"
        Me.ProgramNoGridLookUpEdit.Properties.ImmediatePopup = True
        Me.ProgramNoGridLookUpEdit.Properties.NullText = "[Select/Write  Program]"
        Me.ProgramNoGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.ProgramNoGridLookUpEdit.Properties.PopupView = Me.GridLookUpEdit1View
        Me.ProgramNoGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.ProgramNoGridLookUpEdit.Properties.ValueMember = "OrderId"
        Me.ProgramNoGridLookUpEdit.Size = New System.Drawing.Size(166, 20)
        Me.ProgramNoGridLookUpEdit.TabIndex = 95
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDetails, Me.colIsPrint})
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
        'colIsPrint
        '
        Me.colIsPrint.FieldName = "IsPrint"
        Me.colIsPrint.Name = "colIsPrint"
        Me.colIsPrint.Visible = True
        Me.colIsPrint.VisibleIndex = 1
        '
        'BuyerBindingSource
        '
        Me.BuyerBindingSource.DataMember = "Buyer"
        Me.BuyerBindingSource.DataSource = Me.BuyerDataSet
        '
        'BuyerDataSet
        '
        Me.BuyerDataSet.DataSetName = "BuyerDataSet"
        Me.BuyerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BuyerTableAdapter
        '
        Me.BuyerTableAdapter.ClearBeforeFill = True
        '
        'BuyerCheckBox
        '
        Me.BuyerCheckBox.AutoSize = True
        Me.BuyerCheckBox.Location = New System.Drawing.Point(14, 3)
        Me.BuyerCheckBox.Name = "BuyerCheckBox"
        Me.BuyerCheckBox.Size = New System.Drawing.Size(59, 17)
        Me.BuyerCheckBox.TabIndex = 106
        Me.BuyerCheckBox.Text = "Buyer :"
        Me.BuyerCheckBox.UseVisualStyleBackColor = True
        '
        'BuyerComboBox
        '
        Me.BuyerComboBox.DataSource = Me.BuyerBindingSource
        Me.BuyerComboBox.DisplayMember = "BuyerCode"
        Me.BuyerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BuyerComboBox.Enabled = False
        Me.BuyerComboBox.FormattingEnabled = True
        Me.BuyerComboBox.Location = New System.Drawing.Point(12, 22)
        Me.BuyerComboBox.Name = "BuyerComboBox"
        Me.BuyerComboBox.Size = New System.Drawing.Size(129, 21)
        Me.BuyerComboBox.TabIndex = 105
        Me.BuyerComboBox.ValueMember = "BuyerId"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(150, 7)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(113, 46)
        Me.Button1.TabIndex = 104
        Me.Button1.Text = "&Show All Running"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(269, 7)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(113, 46)
        Me.Button2.TabIndex = 107
        Me.Button2.Text = "&Show All Running [PO Wise Data]"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'frmCuttingReportPOWise
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(785, 355)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.BuyerCheckBox)
        Me.Controls.Add(Me.BuyerComboBox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.SizeCheckBox)
        Me.Controls.Add(Me.ProgramAllocationButton)
        Me.Controls.Add(Me.ProgramNoGridLookUpEdit)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "frmCuttingReportPOWise"
        Me.Text = "Cutting Production PO Wise Report"
        CType(Me.OrderLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProgramNoGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents OrderLookupDataSet As OrderLookupDataSet
    Friend WithEvents OrderLookupBindingSource As BindingSource
    Friend WithEvents OrderLookupTableAdapter As OrderLookupDataSetTableAdapters.OrderLookupTableAdapter
    Friend WithEvents StyleLookupDataSet As StyleLookupDataSet
    Friend WithEvents StyleBindingSource As BindingSource
    Friend WithEvents StyleTableAdapter As StyleLookupDataSetTableAdapters.StyleTableAdapter
    Friend WithEvents Label4 As Label
    Friend WithEvents SizeCheckBox As CheckBox
    Friend WithEvents ProgramAllocationButton As Button
    Friend WithEvents ProgramNoGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colDetails As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsPrint As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BuyerBindingSource As BindingSource
    Friend WithEvents BuyerDataSet As BuyerDataSet
    Friend WithEvents BuyerTableAdapter As BuyerDataSetTableAdapters.BuyerTableAdapter
    Friend WithEvents BuyerCheckBox As CheckBox
    Friend WithEvents BuyerComboBox As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
