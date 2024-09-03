<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmActivitiesPivot
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
        Me.PivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl
        Me.ActivitiesViewDataSet = New KSoft_Apparel.ActivitiesViewDataSet
        Me.ActivitiesViewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ActivitiesViewTableAdapter = New KSoft_Apparel.ActivitiesViewDataSetTableAdapters.ActivitiesViewTableAdapter
        Me.fieldExDuration = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldExEDate = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldAEDate = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldProgramNo = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldStyleName = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldBuyerName = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldDescription = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldStatus = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldSndASDate = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldTrdASDate = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldSndStatus = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldTrdStatus = New DevExpress.XtraPivotGrid.PivotGridField
        CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActivitiesViewDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActivitiesViewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PivotGridControl1
        '
        Me.PivotGridControl1.Cursor = System.Windows.Forms.Cursors.Default
        Me.PivotGridControl1.DataSource = Me.ActivitiesViewBindingSource
        Me.PivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldExDuration, Me.fieldExEDate, Me.fieldAEDate, Me.fieldProgramNo, Me.fieldStyleName, Me.fieldBuyerName, Me.fieldDescription, Me.fieldStatus, Me.fieldSndASDate, Me.fieldTrdASDate, Me.fieldSndStatus, Me.fieldTrdStatus})
        Me.PivotGridControl1.Location = New System.Drawing.Point(0, 0)
        Me.PivotGridControl1.Name = "PivotGridControl1"
        Me.PivotGridControl1.Size = New System.Drawing.Size(754, 390)
        Me.PivotGridControl1.TabIndex = 0
        '
        'ActivitiesViewDataSet
        '
        Me.ActivitiesViewDataSet.DataSetName = "ActivitiesViewDataSet"
        Me.ActivitiesViewDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ActivitiesViewBindingSource
        '
        Me.ActivitiesViewBindingSource.DataMember = "ActivitiesView"
        Me.ActivitiesViewBindingSource.DataSource = Me.ActivitiesViewDataSet
        '
        'ActivitiesViewTableAdapter
        '
        Me.ActivitiesViewTableAdapter.ClearBeforeFill = True
        '
        'fieldExDuration
        '
        Me.fieldExDuration.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.fieldExDuration.AreaIndex = 0
        Me.fieldExDuration.Caption = "Ex Duration"
        Me.fieldExDuration.FieldName = "ExDuration"
        Me.fieldExDuration.Name = "fieldExDuration"
        '
        'fieldExEDate
        '
        Me.fieldExEDate.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldExEDate.AreaIndex = 0
        Me.fieldExEDate.Caption = "Ex EDate"
        Me.fieldExEDate.FieldName = "ExEDate"
        Me.fieldExEDate.Name = "fieldExEDate"
        Me.fieldExEDate.Width = 70
        '
        'fieldAEDate
        '
        Me.fieldAEDate.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldAEDate.AreaIndex = 1
        Me.fieldAEDate.Caption = "AE Date"
        Me.fieldAEDate.FieldName = "AEDate"
        Me.fieldAEDate.Name = "fieldAEDate"
        Me.fieldAEDate.Width = 62
        '
        'fieldProgramNo
        '
        Me.fieldProgramNo.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldProgramNo.AreaIndex = 0
        Me.fieldProgramNo.Caption = "Program No"
        Me.fieldProgramNo.FieldName = "ProgramNo"
        Me.fieldProgramNo.Name = "fieldProgramNo"
        '
        'fieldStyleName
        '
        Me.fieldStyleName.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.fieldStyleName.AreaIndex = 1
        Me.fieldStyleName.Caption = "Style Name"
        Me.fieldStyleName.FieldName = "StyleName"
        Me.fieldStyleName.Name = "fieldStyleName"
        '
        'fieldBuyerName
        '
        Me.fieldBuyerName.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.fieldBuyerName.AreaIndex = 2
        Me.fieldBuyerName.Caption = "Buyer Name"
        Me.fieldBuyerName.FieldName = "BuyerName"
        Me.fieldBuyerName.Name = "fieldBuyerName"
        '
        'fieldDescription
        '
        Me.fieldDescription.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldDescription.AreaIndex = 0
        Me.fieldDescription.Caption = "Description"
        Me.fieldDescription.FieldName = "Description"
        Me.fieldDescription.Name = "fieldDescription"
        '
        'fieldStatus
        '
        Me.fieldStatus.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.fieldStatus.AreaIndex = 3
        Me.fieldStatus.Caption = "Status"
        Me.fieldStatus.FieldName = "Status"
        Me.fieldStatus.Name = "fieldStatus"
        '
        'fieldSndASDate
        '
        Me.fieldSndASDate.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.fieldSndASDate.AreaIndex = 4
        Me.fieldSndASDate.Caption = "Snd AS Date"
        Me.fieldSndASDate.FieldName = "SndASDate"
        Me.fieldSndASDate.Name = "fieldSndASDate"
        '
        'fieldTrdASDate
        '
        Me.fieldTrdASDate.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.fieldTrdASDate.AreaIndex = 5
        Me.fieldTrdASDate.Caption = "Trd AS Date"
        Me.fieldTrdASDate.FieldName = "TrdASDate"
        Me.fieldTrdASDate.Name = "fieldTrdASDate"
        '
        'fieldSndStatus
        '
        Me.fieldSndStatus.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldSndStatus.AreaIndex = 2
        Me.fieldSndStatus.Caption = "Snd Status"
        Me.fieldSndStatus.FieldName = "SndStatus"
        Me.fieldSndStatus.Name = "fieldSndStatus"
        Me.fieldSndStatus.Width = 75
        '
        'fieldTrdStatus
        '
        Me.fieldTrdStatus.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.fieldTrdStatus.AreaIndex = 6
        Me.fieldTrdStatus.Caption = "Trd Status"
        Me.fieldTrdStatus.FieldName = "TrdStatus"
        Me.fieldTrdStatus.Name = "fieldTrdStatus"
        '
        'frmActivitiesPivot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(754, 390)
        Me.Controls.Add(Me.PivotGridControl1)
        Me.Name = "frmActivitiesPivot"
        Me.Text = "Activities Pivot"
        CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActivitiesViewDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActivitiesViewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents ActivitiesViewDataSet As KSoft_Apparel.ActivitiesViewDataSet
    Friend WithEvents ActivitiesViewBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ActivitiesViewTableAdapter As KSoft_Apparel.ActivitiesViewDataSetTableAdapters.ActivitiesViewTableAdapter
    Friend WithEvents fieldExDuration As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldExEDate As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldAEDate As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldProgramNo As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldStyleName As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldBuyerName As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldDescription As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldStatus As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldSndASDate As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldTrdASDate As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldSndStatus As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldTrdStatus As DevExpress.XtraPivotGrid.PivotGridField
End Class
