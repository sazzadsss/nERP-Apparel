<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmActivitiesPrint
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
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.Button1 = New System.Windows.Forms.Button
        Me.MultipleProgramTextBox2 = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.ProgramNoGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit
        Me.ActivitiesProgramNoLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ActivitiesDataSet = New KSoft_Apparel.ActivitiesDataSet
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colProgramNo1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ActivitiesProgramNoLookupTableAdapter = New KSoft_Apparel.ActivitiesDataSetTableAdapters.ActivitiesProgramNoLookupTableAdapter
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.ToDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.FromDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.ShowByExButton = New System.Windows.Forms.Button
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.BuyerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BuyerDataSet = New KSoft_Apparel.BuyerDataSet
        Me.BuyerCheckBox = New System.Windows.Forms.CheckBox
        Me.BuyerTableAdapter = New KSoft_Apparel.BuyerDataSetTableAdapters.BuyerTableAdapter
        Me.SeasonGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit
        Me.SeasonBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SeasonDataSet = New KSoft_Apparel.SeasonDataSet
        Me.GridView6 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colSeasonId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSeasonName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GMDepGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GMDepartmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GMDepartmentDataSet = New KSoft_Apparel.GMDepartmentDataSet
        Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colGMDepartmentId1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colGMDepartmentName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colBuyerId3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.UserTableAdapter = New KSoft_Apparel.UserDataSetTableAdapters.UserTableAdapter
        Me.GMDepartmentTableAdapter = New KSoft_Apparel.GMDepartmentDataSetTableAdapters.GMDepartmentTableAdapter
        Me.SeasonTableAdapter = New KSoft_Apparel.SeasonDataSetTableAdapters.SeasonTableAdapter
        Me.DepartButton = New System.Windows.Forms.Button
        Me.SeasonButton = New System.Windows.Forms.Button
        Label4 = New System.Windows.Forms.Label
        Label5 = New System.Windows.Forms.Label
        CType(Me.ProgramNoGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActivitiesProgramNoLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActivitiesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeasonGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeasonBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeasonDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GMDepGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GMDepartmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GMDepartmentDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(819, 34)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(49, 13)
        Label4.TabIndex = 60
        Label4.Text = "Season :"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(819, 10)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(68, 13)
        Label5.TabIndex = 61
        Label5.Text = "Department :"
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        'Me.CrystalReportViewer1.DisplayGroupTree = False
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 58)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1132, 351)
        Me.CrystalReportViewer1.TabIndex = 0
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(383, 30)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Show"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MultipleProgramTextBox2
        '
        Me.MultipleProgramTextBox2.Location = New System.Drawing.Point(164, 9)
        Me.MultipleProgramTextBox2.Multiline = True
        Me.MultipleProgramTextBox2.Name = "MultipleProgramTextBox2"
        Me.MultipleProgramTextBox2.Size = New System.Drawing.Size(213, 43)
        Me.MultipleProgramTextBox2.TabIndex = 50
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "Program No"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(127, 31)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(31, 23)
        Me.Button2.TabIndex = 51
        Me.Button2.Text = ">>"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ProgramNoGridLookUpEdit
        '
        Me.ProgramNoGridLookUpEdit.EditValue = "[Select your Program]"
        Me.ProgramNoGridLookUpEdit.Location = New System.Drawing.Point(12, 33)
        Me.ProgramNoGridLookUpEdit.Margin = New System.Windows.Forms.Padding(3, 7, 3, 3)
        Me.ProgramNoGridLookUpEdit.Name = "ProgramNoGridLookUpEdit"
        Me.ProgramNoGridLookUpEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ProgramNoGridLookUpEdit.Properties.Appearance.Options.UseBackColor = True
        Me.ProgramNoGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ProgramNoGridLookUpEdit.Properties.DataSource = Me.ActivitiesProgramNoLookupBindingSource
        Me.ProgramNoGridLookUpEdit.Properties.DisplayMember = "ProgramNo"
        Me.ProgramNoGridLookUpEdit.Properties.ImmediatePopup = True
        Me.ProgramNoGridLookUpEdit.Properties.NullText = "Select your Program"
        Me.ProgramNoGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.ProgramNoGridLookUpEdit.Properties.Tag = "NR"
        Me.ProgramNoGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.ProgramNoGridLookUpEdit.Properties.ValueMember = "ProgramNo"
        Me.ProgramNoGridLookUpEdit.Properties.View = Me.GridLookUpEdit1View
        Me.ProgramNoGridLookUpEdit.Size = New System.Drawing.Size(109, 20)
        Me.ProgramNoGridLookUpEdit.TabIndex = 52
        Me.ProgramNoGridLookUpEdit.Tag = "NR"
        '
        'ActivitiesProgramNoLookupBindingSource
        '
        Me.ActivitiesProgramNoLookupBindingSource.DataMember = "ActivitiesProgramNoLookup"
        Me.ActivitiesProgramNoLookupBindingSource.DataSource = Me.ActivitiesDataSet
        '
        'ActivitiesDataSet
        '
        Me.ActivitiesDataSet.DataSetName = "ActivitiesDataSet"
        Me.ActivitiesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colProgramNo1})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colProgramNo1
        '
        Me.colProgramNo1.FieldName = "ProgramNo"
        Me.colProgramNo1.Name = "colProgramNo1"
        Me.colProgramNo1.Visible = True
        Me.colProgramNo1.VisibleIndex = 0
        '
        'ActivitiesProgramNoLookupTableAdapter
        '
        Me.ActivitiesProgramNoLookupTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(471, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 56
        Me.Label1.Text = "To :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(471, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 55
        Me.Label3.Text = "From : "
        '
        'ToDateTimePicker
        '
        Me.ToDateTimePicker.CustomFormat = "dd-MMM-yy"
        Me.ToDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.ToDateTimePicker.Location = New System.Drawing.Point(516, 30)
        Me.ToDateTimePicker.Name = "ToDateTimePicker"
        Me.ToDateTimePicker.Size = New System.Drawing.Size(95, 20)
        Me.ToDateTimePicker.TabIndex = 54
        '
        'FromDateTimePicker
        '
        Me.FromDateTimePicker.CustomFormat = "dd-MMM-yy"
        Me.FromDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.FromDateTimePicker.Location = New System.Drawing.Point(516, 6)
        Me.FromDateTimePicker.Name = "FromDateTimePicker"
        Me.FromDateTimePicker.Size = New System.Drawing.Size(96, 20)
        Me.FromDateTimePicker.TabIndex = 53
        '
        'ShowByExButton
        '
        Me.ShowByExButton.Location = New System.Drawing.Point(689, 30)
        Me.ShowByExButton.Name = "ShowByExButton"
        Me.ShowByExButton.Size = New System.Drawing.Size(121, 23)
        Me.ShowByExButton.TabIndex = 57
        Me.ShowByExButton.Text = "Show By Ex"
        Me.ShowByExButton.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.BuyerBindingSource
        Me.ComboBox1.DisplayMember = "BuyerCode"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(689, 5)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 58
        Me.ComboBox1.ValueMember = "BuyerId"
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
        'BuyerCheckBox
        '
        Me.BuyerCheckBox.AutoSize = True
        Me.BuyerCheckBox.Location = New System.Drawing.Point(630, 9)
        Me.BuyerCheckBox.Name = "BuyerCheckBox"
        Me.BuyerCheckBox.Size = New System.Drawing.Size(53, 17)
        Me.BuyerCheckBox.TabIndex = 59
        Me.BuyerCheckBox.Text = "Buyer"
        Me.BuyerCheckBox.UseVisualStyleBackColor = True
        '
        'BuyerTableAdapter
        '
        Me.BuyerTableAdapter.ClearBeforeFill = True
        '
        'SeasonGridLookUpEdit
        '
        Me.SeasonGridLookUpEdit.Location = New System.Drawing.Point(893, 31)
        Me.SeasonGridLookUpEdit.Name = "SeasonGridLookUpEdit"
        Me.SeasonGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SeasonGridLookUpEdit.Properties.DataSource = Me.SeasonBindingSource
        Me.SeasonGridLookUpEdit.Properties.DisplayMember = "SeasonName"
        Me.SeasonGridLookUpEdit.Properties.NullText = ""
        Me.SeasonGridLookUpEdit.Properties.ValueMember = "SeasonId"
        Me.SeasonGridLookUpEdit.Properties.View = Me.GridView6
        Me.SeasonGridLookUpEdit.Size = New System.Drawing.Size(115, 20)
        Me.SeasonGridLookUpEdit.TabIndex = 62
        '
        'SeasonBindingSource
        '
        Me.SeasonBindingSource.DataMember = "Season"
        Me.SeasonBindingSource.DataSource = Me.SeasonDataSet
        '
        'SeasonDataSet
        '
        Me.SeasonDataSet.DataSetName = "SeasonDataSet"
        Me.SeasonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView6
        '
        Me.GridView6.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSeasonId, Me.colSeasonName})
        Me.GridView6.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView6.Name = "GridView6"
        Me.GridView6.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView6.OptionsView.ShowGroupPanel = False
        '
        'colSeasonId
        '
        Me.colSeasonId.FieldName = "SeasonId"
        Me.colSeasonId.Name = "colSeasonId"
        Me.colSeasonId.OptionsColumn.ReadOnly = True
        '
        'colSeasonName
        '
        Me.colSeasonName.FieldName = "SeasonName"
        Me.colSeasonName.Name = "colSeasonName"
        Me.colSeasonName.Visible = True
        Me.colSeasonName.VisibleIndex = 0
        '
        'GMDepGridLookUpEdit
        '
        Me.GMDepGridLookUpEdit.Location = New System.Drawing.Point(893, 6)
        Me.GMDepGridLookUpEdit.Name = "GMDepGridLookUpEdit"
        Me.GMDepGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GMDepGridLookUpEdit.Properties.DataSource = Me.GMDepartmentBindingSource
        Me.GMDepGridLookUpEdit.Properties.DisplayMember = "GMDepartmentName"
        Me.GMDepGridLookUpEdit.Properties.NullText = ""
        Me.GMDepGridLookUpEdit.Properties.ValueMember = "GMDepartmentId"
        Me.GMDepGridLookUpEdit.Properties.View = Me.GridView5
        Me.GMDepGridLookUpEdit.Size = New System.Drawing.Size(115, 20)
        Me.GMDepGridLookUpEdit.TabIndex = 63
        '
        'GMDepartmentBindingSource
        '
        Me.GMDepartmentBindingSource.DataMember = "GMDepartment"
        Me.GMDepartmentBindingSource.DataSource = Me.GMDepartmentDataSet
        '
        'GMDepartmentDataSet
        '
        Me.GMDepartmentDataSet.DataSetName = "GMDepartmentDataSet"
        Me.GMDepartmentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView5
        '
        Me.GridView5.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colGMDepartmentId1, Me.colGMDepartmentName, Me.colBuyerId3})
        Me.GridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView5.Name = "GridView5"
        Me.GridView5.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView5.OptionsView.ShowGroupPanel = False
        '
        'colGMDepartmentId1
        '
        Me.colGMDepartmentId1.FieldName = "GMDepartmentId"
        Me.colGMDepartmentId1.Name = "colGMDepartmentId1"
        Me.colGMDepartmentId1.OptionsColumn.ReadOnly = True
        '
        'colGMDepartmentName
        '
        Me.colGMDepartmentName.FieldName = "GMDepartmentName"
        Me.colGMDepartmentName.Name = "colGMDepartmentName"
        Me.colGMDepartmentName.Visible = True
        Me.colGMDepartmentName.VisibleIndex = 0
        '
        'colBuyerId3
        '
        Me.colBuyerId3.FieldName = "BuyerId"
        Me.colBuyerId3.Name = "colBuyerId3"
        '
        'UserTableAdapter
        '
        Me.UserTableAdapter.ClearBeforeFill = True
        '
        'GMDepartmentTableAdapter
        '
        Me.GMDepartmentTableAdapter.ClearBeforeFill = True
        '
        'SeasonTableAdapter
        '
        Me.SeasonTableAdapter.ClearBeforeFill = True
        '
        'DepartButton
        '
        Me.DepartButton.Location = New System.Drawing.Point(1014, 5)
        Me.DepartButton.Name = "DepartButton"
        Me.DepartButton.Size = New System.Drawing.Size(89, 23)
        Me.DepartButton.TabIndex = 57
        Me.DepartButton.Text = "Show"
        Me.DepartButton.UseVisualStyleBackColor = True
        '
        'SeasonButton
        '
        Me.SeasonButton.Location = New System.Drawing.Point(1014, 29)
        Me.SeasonButton.Name = "SeasonButton"
        Me.SeasonButton.Size = New System.Drawing.Size(89, 23)
        Me.SeasonButton.TabIndex = 57
        Me.SeasonButton.Text = "Show"
        Me.SeasonButton.UseVisualStyleBackColor = True
        '
        'frmActivitiesPrint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1132, 410)
        Me.Controls.Add(Me.SeasonGridLookUpEdit)
        Me.Controls.Add(Me.GMDepGridLookUpEdit)
        Me.Controls.Add(Label4)
        Me.Controls.Add(Label5)
        Me.Controls.Add(Me.BuyerCheckBox)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.SeasonButton)
        Me.Controls.Add(Me.DepartButton)
        Me.Controls.Add(Me.ShowByExButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ToDateTimePicker)
        Me.Controls.Add(Me.FromDateTimePicker)
        Me.Controls.Add(Me.ProgramNoGridLookUpEdit)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.MultipleProgramTextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "frmActivitiesPrint"
        Me.Text = "Critical Path Print"
        CType(Me.ProgramNoGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActivitiesProgramNoLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActivitiesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeasonGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeasonBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeasonDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GMDepGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GMDepartmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GMDepartmentDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents MultipleProgramTextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ProgramNoGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colProgramNo1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ActivitiesDataSet As KSoft_Apparel.ActivitiesDataSet
    Friend WithEvents ActivitiesProgramNoLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ActivitiesProgramNoLookupTableAdapter As KSoft_Apparel.ActivitiesDataSetTableAdapters.ActivitiesProgramNoLookupTableAdapter
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ToDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents FromDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ShowByExButton As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents BuyerCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents BuyerDataSet As KSoft_Apparel.BuyerDataSet
    Friend WithEvents BuyerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BuyerTableAdapter As KSoft_Apparel.BuyerDataSetTableAdapters.BuyerTableAdapter
    Friend WithEvents SeasonGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView6 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSeasonId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSeasonName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GMDepGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colGMDepartmentId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGMDepartmentName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBuyerId3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SeasonBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SeasonDataSet As KSoft_Apparel.SeasonDataSet
    Friend WithEvents GMDepartmentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GMDepartmentDataSet As KSoft_Apparel.GMDepartmentDataSet
    Friend WithEvents UserTableAdapter As KSoft_Apparel.UserDataSetTableAdapters.UserTableAdapter
    Friend WithEvents GMDepartmentTableAdapter As KSoft_Apparel.GMDepartmentDataSetTableAdapters.GMDepartmentTableAdapter
    Friend WithEvents SeasonTableAdapter As KSoft_Apparel.SeasonDataSetTableAdapters.SeasonTableAdapter
    Friend WithEvents DepartButton As System.Windows.Forms.Button
    Friend WithEvents SeasonButton As System.Windows.Forms.Button
End Class
