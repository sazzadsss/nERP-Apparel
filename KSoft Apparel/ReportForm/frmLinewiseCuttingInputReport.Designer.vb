<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLinewiseCuttingInputReport
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
        Me.OrderLookupTableAdapter = New KSoft_Apparel.OrderLookupDataSetTableAdapters.OrderLookupTableAdapter()
        Me.OrderLookupDataSet = New KSoft_Apparel.OrderLookupDataSet()
        Me.OrderLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProgramAllocationButton = New System.Windows.Forms.Button()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.FabricColorComboBox = New System.Windows.Forms.ComboBox()
        Me.OrderFabricColorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderFabricColorDataSet = New KSoft_Apparel.OrderFabricColorDataSet()
        Me.OrderFabricColorTableAdapter = New KSoft_Apparel.OrderFabricColorDataSetTableAdapters.OrderFabricColorTableAdapter()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.OrderNoGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDetails = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LineDataSet = New KSoft_Apparel.LineDataSet()
        Me.LineBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LineTableAdapter = New KSoft_Apparel.LineDataSetTableAdapters.LineTableAdapter()
        Me.ShowSummeryButton = New System.Windows.Forms.Button()
        Me.ShowByProgramButton = New System.Windows.Forms.Button()
        Me.MultipleProgramTextBox = New System.Windows.Forms.TextBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.AllBranch = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.OrderLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderFabricColorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderFabricColorDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderNoGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LineDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LineBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OrderLookupTableAdapter
        '
        Me.OrderLookupTableAdapter.ClearBeforeFill = True
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
        'ProgramAllocationButton
        '
        Me.ProgramAllocationButton.Location = New System.Drawing.Point(696, 14)
        Me.ProgramAllocationButton.Name = "ProgramAllocationButton"
        Me.ProgramAllocationButton.Size = New System.Drawing.Size(75, 23)
        Me.ProgramAllocationButton.TabIndex = 9
        Me.ProgramAllocationButton.Text = "Show"
        Me.ProgramAllocationButton.UseVisualStyleBackColor = True
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 46)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1282, 461)
        Me.CrystalReportViewer1.TabIndex = 10
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(514, 19)
        Me.Label5.Margin = New System.Windows.Forms.Padding(10, 9, 3, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Color"
        '
        'FabricColorComboBox
        '
        Me.FabricColorComboBox.DataSource = Me.OrderFabricColorBindingSource
        Me.FabricColorComboBox.DisplayMember = "FabricColorName"
        Me.FabricColorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.FabricColorComboBox.FormattingEnabled = True
        Me.FabricColorComboBox.Location = New System.Drawing.Point(548, 15)
        Me.FabricColorComboBox.Margin = New System.Windows.Forms.Padding(5, 5, 3, 3)
        Me.FabricColorComboBox.Name = "FabricColorComboBox"
        Me.FabricColorComboBox.Size = New System.Drawing.Size(142, 21)
        Me.FabricColorComboBox.TabIndex = 11
        Me.FabricColorComboBox.ValueMember = "FabricColorId"
        '
        'OrderFabricColorBindingSource
        '
        Me.OrderFabricColorBindingSource.DataMember = "OrderFabricColor"
        Me.OrderFabricColorBindingSource.DataSource = Me.OrderFabricColorDataSet
        '
        'OrderFabricColorDataSet
        '
        Me.OrderFabricColorDataSet.DataSetName = "OrderFabricColorDataSet"
        Me.OrderFabricColorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OrderFabricColorTableAdapter
        '
        Me.OrderFabricColorTableAdapter.ClearBeforeFill = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 16)
        Me.Label4.Margin = New System.Windows.Forms.Padding(3, 8, 3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Program No"
        '
        'OrderNoGridLookUpEdit
        '
        Me.OrderNoGridLookUpEdit.Location = New System.Drawing.Point(87, 13)
        Me.OrderNoGridLookUpEdit.Margin = New System.Windows.Forms.Padding(3, 5, 3, 3)
        Me.OrderNoGridLookUpEdit.Name = "OrderNoGridLookUpEdit"
        Me.OrderNoGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.OrderNoGridLookUpEdit.Properties.DataSource = Me.OrderLookupBindingSource
        Me.OrderNoGridLookUpEdit.Properties.DisplayMember = "Details"
        Me.OrderNoGridLookUpEdit.Properties.ImmediatePopup = True
        Me.OrderNoGridLookUpEdit.Properties.NullText = ""
        Me.OrderNoGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.OrderNoGridLookUpEdit.Properties.PopupView = Me.GridLookUpEdit1View
        Me.OrderNoGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.OrderNoGridLookUpEdit.Properties.ValueMember = "OrderId"
        Me.OrderNoGridLookUpEdit.Size = New System.Drawing.Size(245, 20)
        Me.OrderNoGridLookUpEdit.TabIndex = 15
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
        'LineDataSet
        '
        Me.LineDataSet.DataSetName = "LineDataSet"
        Me.LineDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LineBindingSource
        '
        Me.LineBindingSource.DataMember = "Line"
        Me.LineBindingSource.DataSource = Me.LineDataSet
        '
        'LineTableAdapter
        '
        Me.LineTableAdapter.ClearBeforeFill = True
        '
        'ShowSummeryButton
        '
        Me.ShowSummeryButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ShowSummeryButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ShowSummeryButton.Location = New System.Drawing.Point(777, 15)
        Me.ShowSummeryButton.Margin = New System.Windows.Forms.Padding(8, 3, 3, 3)
        Me.ShowSummeryButton.Name = "ShowSummeryButton"
        Me.ShowSummeryButton.Size = New System.Drawing.Size(98, 22)
        Me.ShowSummeryButton.TabIndex = 23
        Me.ShowSummeryButton.Text = "Show &Summery"
        Me.ShowSummeryButton.UseVisualStyleBackColor = True
        '
        'ShowByProgramButton
        '
        Me.ShowByProgramButton.Location = New System.Drawing.Point(335, 12)
        Me.ShowByProgramButton.Name = "ShowByProgramButton"
        Me.ShowByProgramButton.Size = New System.Drawing.Size(75, 23)
        Me.ShowByProgramButton.TabIndex = 24
        Me.ShowByProgramButton.Text = "Show"
        Me.ShowByProgramButton.UseVisualStyleBackColor = True
        '
        'MultipleProgramTextBox
        '
        Me.MultipleProgramTextBox.Location = New System.Drawing.Point(905, 17)
        Me.MultipleProgramTextBox.Name = "MultipleProgramTextBox"
        Me.MultipleProgramTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.MultipleProgramTextBox.Size = New System.Drawing.Size(229, 20)
        Me.MultipleProgramTextBox.TabIndex = 27
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(880, 18)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(19, 13)
        Me.LinkLabel1.TabIndex = 26
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = ">>"
        '
        'AllBranch
        '
        Me.AllBranch.Location = New System.Drawing.Point(1140, 15)
        Me.AllBranch.Name = "AllBranch"
        Me.AllBranch.Size = New System.Drawing.Size(126, 22)
        Me.AllBranch.TabIndex = 25
        Me.AllBranch.Text = "Show by Multiple Color"
        Me.AllBranch.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(415, 13)
        Me.Button1.Margin = New System.Windows.Forms.Padding(8, 3, 3, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 22)
        Me.Button1.TabIndex = 28
        Me.Button1.Text = "Show &Summery"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmLinewiseCuttingInputReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1283, 501)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MultipleProgramTextBox)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.AllBranch)
        Me.Controls.Add(Me.ShowByProgramButton)
        Me.Controls.Add(Me.ShowSummeryButton)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.OrderNoGridLookUpEdit)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.FabricColorComboBox)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.ProgramAllocationButton)
        Me.Name = "frmLinewiseCuttingInputReport"
        Me.Text = "Linewise Cutting Input Report"
        CType(Me.OrderLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderFabricColorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderFabricColorDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderNoGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LineDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LineBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OrderLookupTableAdapter As KSoft_Apparel.OrderLookupDataSetTableAdapters.OrderLookupTableAdapter
    Friend WithEvents OrderLookupDataSet As KSoft_Apparel.OrderLookupDataSet
    Friend WithEvents OrderLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProgramAllocationButton As System.Windows.Forms.Button
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents FabricColorComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents OrderFabricColorDataSet As KSoft_Apparel.OrderFabricColorDataSet
    Friend WithEvents OrderFabricColorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrderFabricColorTableAdapter As KSoft_Apparel.OrderFabricColorDataSetTableAdapters.OrderFabricColorTableAdapter
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents OrderNoGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colDetails As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LineDataSet As KSoft_Apparel.LineDataSet
    Friend WithEvents LineBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LineTableAdapter As KSoft_Apparel.LineDataSetTableAdapters.LineTableAdapter
    Friend WithEvents ShowSummeryButton As System.Windows.Forms.Button
    Friend WithEvents ShowByProgramButton As System.Windows.Forms.Button
    Friend WithEvents MultipleProgramTextBox As TextBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents AllBranch As Button
    Friend WithEvents Button1 As Button
End Class
