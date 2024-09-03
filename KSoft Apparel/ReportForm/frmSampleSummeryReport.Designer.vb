<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSampleSummeryReport
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
        Dim DevTypeIdLabel As System.Windows.Forms.Label
        Me.BuyerDataSet = New KSoft_Apparel.BuyerDataSet()
        Me.BuyerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BuyerTableAdapter = New KSoft_Apparel.BuyerDataSetTableAdapters.BuyerTableAdapter()
        Me.DevTypeMstTableAdapter = New KSoft_Apparel.DevTypeDataSetTableAdapters.DevTypeMstTableAdapter()
        Me.DevTypeMstBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DevTypeDataSet = New KSoft_Apparel.DevTypeDataSet()
        Me.SampleTypeButton = New System.Windows.Forms.Button()
        Me.DevTypeIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.DevTypeIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDevType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.FromDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ToDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BuyerButton = New System.Windows.Forms.Button()
        Me.BuyerGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colBuyerId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBuyerCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBuyerName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.AllPendingButton = New System.Windows.Forms.Button()
        DevTypeIdLabel = New System.Windows.Forms.Label()
        CType(Me.BuyerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DevTypeMstBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DevTypeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DevTypeIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DevTypeIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BuyerDataSet
        '
        Me.BuyerDataSet.DataSetName = "BuyerDataSet"
        Me.BuyerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BuyerBindingSource
        '
        Me.BuyerBindingSource.DataMember = "Buyer"
        Me.BuyerBindingSource.DataSource = Me.BuyerDataSet
        '
        'BuyerTableAdapter
        '
        Me.BuyerTableAdapter.ClearBeforeFill = True
        '
        'DevTypeMstTableAdapter
        '
        Me.DevTypeMstTableAdapter.ClearBeforeFill = True
        '
        'DevTypeMstBindingSource
        '
        Me.DevTypeMstBindingSource.DataMember = "DevTypeMst"
        Me.DevTypeMstBindingSource.DataSource = Me.DevTypeDataSet
        '
        'DevTypeDataSet
        '
        Me.DevTypeDataSet.DataSetName = "DevTypeDataSet"
        Me.DevTypeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SampleTypeButton
        '
        Me.SampleTypeButton.Location = New System.Drawing.Point(1069, 5)
        Me.SampleTypeButton.Name = "SampleTypeButton"
        Me.SampleTypeButton.Size = New System.Drawing.Size(45, 23)
        Me.SampleTypeButton.TabIndex = 104
        Me.SampleTypeButton.Text = "Show"
        Me.SampleTypeButton.UseVisualStyleBackColor = True
        '
        'DevTypeIdLabel
        '
        DevTypeIdLabel.AutoSize = True
        DevTypeIdLabel.Location = New System.Drawing.Point(849, 9)
        DevTypeIdLabel.Name = "DevTypeIdLabel"
        DevTypeIdLabel.Size = New System.Drawing.Size(75, 13)
        DevTypeIdLabel.TabIndex = 103
        DevTypeIdLabel.Text = "Sample Type :"
        '
        'DevTypeIdGridLookUpEdit
        '
        Me.DevTypeIdGridLookUpEdit.Location = New System.Drawing.Point(930, 7)
        Me.DevTypeIdGridLookUpEdit.Name = "DevTypeIdGridLookUpEdit"
        Me.DevTypeIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DevTypeIdGridLookUpEdit.Properties.DataSource = Me.DevTypeMstBindingSource
        Me.DevTypeIdGridLookUpEdit.Properties.DisplayMember = "DevType"
        Me.DevTypeIdGridLookUpEdit.Properties.ImmediatePopup = True
        Me.DevTypeIdGridLookUpEdit.Properties.NullText = ""
        Me.DevTypeIdGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.DevTypeIdGridLookUpEdit.Properties.ValueMember = "DevTypeId"
        Me.DevTypeIdGridLookUpEdit.Properties.View = Me.DevTypeIdGridLookUpEditView
        Me.DevTypeIdGridLookUpEdit.Size = New System.Drawing.Size(133, 20)
        Me.DevTypeIdGridLookUpEdit.TabIndex = 102
        '
        'DevTypeIdGridLookUpEditView
        '
        Me.DevTypeIdGridLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDevType})
        Me.DevTypeIdGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.DevTypeIdGridLookUpEditView.Name = "DevTypeIdGridLookUpEditView"
        Me.DevTypeIdGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.DevTypeIdGridLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'colDevType
        '
        Me.colDevType.FieldName = "DevType"
        Me.colDevType.Name = "colDevType"
        Me.colDevType.Visible = True
        Me.colDevType.VisibleIndex = 0
        '
        'FromDateTimePicker
        '
        Me.FromDateTimePicker.CustomFormat = "dd-MMM-yy"
        Me.FromDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.FromDateTimePicker.Location = New System.Drawing.Point(118, 5)
        Me.FromDateTimePicker.Name = "FromDateTimePicker"
        Me.FromDateTimePicker.Size = New System.Drawing.Size(163, 20)
        Me.FromDateTimePicker.TabIndex = 98
        '
        'ToDateTimePicker
        '
        Me.ToDateTimePicker.CustomFormat = "dd-MMM-yy"
        Me.ToDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.ToDateTimePicker.Location = New System.Drawing.Point(313, 6)
        Me.ToDateTimePicker.Name = "ToDateTimePicker"
        Me.ToDateTimePicker.Size = New System.Drawing.Size(172, 20)
        Me.ToDateTimePicker.TabIndex = 99
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(287, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 13)
        Me.Label3.TabIndex = 100
        Me.Label3.Text = "To"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 13)
        Me.Label5.TabIndex = 101
        Me.Label5.Text = "Request Date From :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(614, 8)
        Me.Label1.Margin = New System.Windows.Forms.Padding(10, 10, 3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 97
        Me.Label1.Text = "Buyer:"
        '
        'BuyerButton
        '
        Me.BuyerButton.Location = New System.Drawing.Point(798, 4)
        Me.BuyerButton.Margin = New System.Windows.Forms.Padding(3, 6, 3, 3)
        Me.BuyerButton.Name = "BuyerButton"
        Me.BuyerButton.Size = New System.Drawing.Size(45, 22)
        Me.BuyerButton.TabIndex = 96
        Me.BuyerButton.Tag = "NR"
        Me.BuyerButton.Text = "Show"
        Me.BuyerButton.UseVisualStyleBackColor = True
        '
        'BuyerGridLookUpEdit
        '
        Me.BuyerGridLookUpEdit.Location = New System.Drawing.Point(659, 5)
        Me.BuyerGridLookUpEdit.Margin = New System.Windows.Forms.Padding(10, 7, 3, 3)
        Me.BuyerGridLookUpEdit.Name = "BuyerGridLookUpEdit"
        Me.BuyerGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.BuyerGridLookUpEdit.Properties.DataSource = Me.BuyerBindingSource
        Me.BuyerGridLookUpEdit.Properties.DisplayMember = "BuyerName"
        Me.BuyerGridLookUpEdit.Properties.ImmediatePopup = True
        Me.BuyerGridLookUpEdit.Properties.NullText = ""
        Me.BuyerGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.BuyerGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.BuyerGridLookUpEdit.Properties.ValueMember = "BuyerId"
        Me.BuyerGridLookUpEdit.Properties.View = Me.GridView1
        Me.BuyerGridLookUpEdit.Size = New System.Drawing.Size(133, 20)
        Me.BuyerGridLookUpEdit.TabIndex = 95
        Me.BuyerGridLookUpEdit.Tag = "NR"
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colBuyerId, Me.colBuyerCode, Me.colBuyerName})
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colBuyerId
        '
        Me.colBuyerId.FieldName = "BuyerId"
        Me.colBuyerId.Name = "colBuyerId"
        Me.colBuyerId.OptionsColumn.ReadOnly = True
        '
        'colBuyerCode
        '
        Me.colBuyerCode.FieldName = "BuyerCode"
        Me.colBuyerCode.Name = "colBuyerCode"
        '
        'colBuyerName
        '
        Me.colBuyerName.FieldName = "BuyerName"
        Me.colBuyerName.Name = "colBuyerName"
        Me.colBuyerName.Visible = True
        Me.colBuyerName.VisibleIndex = 0
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(1, 34)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1140, 550)
        Me.CrystalReportViewer1.TabIndex = 94
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'AllPendingButton
        '
        Me.AllPendingButton.Location = New System.Drawing.Point(491, 4)
        Me.AllPendingButton.Name = "AllPendingButton"
        Me.AllPendingButton.Size = New System.Drawing.Size(95, 21)
        Me.AllPendingButton.TabIndex = 105
        Me.AllPendingButton.Text = "&Show By Date "
        Me.AllPendingButton.UseVisualStyleBackColor = True
        '
        'frmSampleSummeryReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1146, 583)
        Me.Controls.Add(Me.AllPendingButton)
        Me.Controls.Add(Me.SampleTypeButton)
        Me.Controls.Add(DevTypeIdLabel)
        Me.Controls.Add(Me.DevTypeIdGridLookUpEdit)
        Me.Controls.Add(Me.FromDateTimePicker)
        Me.Controls.Add(Me.ToDateTimePicker)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BuyerButton)
        Me.Controls.Add(Me.BuyerGridLookUpEdit)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "frmSampleSummeryReport"
        Me.Text = "Sample Summery Report"
        CType(Me.BuyerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DevTypeMstBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DevTypeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DevTypeIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DevTypeIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BuyerDataSet As BuyerDataSet
    Friend WithEvents BuyerBindingSource As BindingSource
    Friend WithEvents BuyerTableAdapter As BuyerDataSetTableAdapters.BuyerTableAdapter
    Friend WithEvents DevTypeMstTableAdapter As DevTypeDataSetTableAdapters.DevTypeMstTableAdapter
    Friend WithEvents DevTypeMstBindingSource As BindingSource
    Friend WithEvents DevTypeDataSet As DevTypeDataSet
    Friend WithEvents SampleTypeButton As Button
    Friend WithEvents DevTypeIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents DevTypeIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colDevType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FromDateTimePicker As DateTimePicker
    Friend WithEvents ToDateTimePicker As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BuyerButton As Button
    Friend WithEvents BuyerGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colBuyerId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBuyerCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBuyerName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents AllPendingButton As Button
End Class
