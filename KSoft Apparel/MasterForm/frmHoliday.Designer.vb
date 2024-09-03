<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHoliday
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHoliday))
        Me.HolidayDataSet = New KSoft_Apparel.HolidayDataSet
        Me.HolidayBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HolidayTableAdapter = New KSoft_Apparel.HolidayDataSetTableAdapters.HolidayTableAdapter
        Me.TableAdapterManager = New KSoft_Apparel.HolidayDataSetTableAdapters.TableAdapterManager
        Me.HolidayBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.HolidayBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.HolidayGridControl = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colHolidayDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIsWeekend = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colYear = New DevExpress.XtraGrid.Columns.GridColumn
        Me.YearTextBox = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.WeekdayCheckBox = New System.Windows.Forms.CheckBox
        Me.GenerateButton = New System.Windows.Forms.Button
        Me.ShowButton = New System.Windows.Forms.Button
        CType(Me.HolidayDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HolidayBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HolidayBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HolidayBindingNavigator.SuspendLayout()
        CType(Me.HolidayGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'HolidayDataSet
        '
        Me.HolidayDataSet.DataSetName = "HolidayDataSet"
        Me.HolidayDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'HolidayBindingSource
        '
        Me.HolidayBindingSource.DataMember = "Holiday"
        Me.HolidayBindingSource.DataSource = Me.HolidayDataSet
        '
        'HolidayTableAdapter
        '
        Me.HolidayTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.HolidayTableAdapter = Me.HolidayTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.HolidayDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'HolidayBindingNavigator
        '
        Me.HolidayBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.HolidayBindingNavigator.BindingSource = Me.HolidayBindingSource
        Me.HolidayBindingNavigator.CountItem = Nothing
        Me.HolidayBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.HolidayBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.HolidayBindingNavigatorSaveItem})
        Me.HolidayBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.HolidayBindingNavigator.MoveFirstItem = Nothing
        Me.HolidayBindingNavigator.MoveLastItem = Nothing
        Me.HolidayBindingNavigator.MoveNextItem = Nothing
        Me.HolidayBindingNavigator.MovePreviousItem = Nothing
        Me.HolidayBindingNavigator.Name = "HolidayBindingNavigator"
        Me.HolidayBindingNavigator.PositionItem = Nothing
        Me.HolidayBindingNavigator.Size = New System.Drawing.Size(708, 25)
        Me.HolidayBindingNavigator.TabIndex = 0
        Me.HolidayBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(74, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(60, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'HolidayBindingNavigatorSaveItem
        '
        Me.HolidayBindingNavigatorSaveItem.Image = CType(resources.GetObject("HolidayBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.HolidayBindingNavigatorSaveItem.Name = "HolidayBindingNavigatorSaveItem"
        Me.HolidayBindingNavigatorSaveItem.Size = New System.Drawing.Size(78, 22)
        Me.HolidayBindingNavigatorSaveItem.Text = "Save Data"
        '
        'HolidayGridControl
        '
        Me.HolidayGridControl.DataSource = Me.HolidayBindingSource
        Me.HolidayGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HolidayGridControl.Location = New System.Drawing.Point(0, 25)
        Me.HolidayGridControl.MainView = Me.GridView1
        Me.HolidayGridControl.Name = "HolidayGridControl"
        Me.HolidayGridControl.Size = New System.Drawing.Size(708, 414)
        Me.HolidayGridControl.TabIndex = 1
        Me.HolidayGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colHolidayDate, Me.colDescription, Me.colIsWeekend, Me.colYear})
        Me.GridView1.GridControl = Me.HolidayGridControl
        Me.GridView1.Name = "GridView1"
        '
        'colHolidayDate
        '
        Me.colHolidayDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colHolidayDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colHolidayDate.FieldName = "HolidayDate"
        Me.colHolidayDate.Name = "colHolidayDate"
        Me.colHolidayDate.Visible = True
        Me.colHolidayDate.VisibleIndex = 1
        Me.colHolidayDate.Width = 98
        '
        'colDescription
        '
        Me.colDescription.FieldName = "Description"
        Me.colDescription.Name = "colDescription"
        Me.colDescription.Visible = True
        Me.colDescription.VisibleIndex = 2
        Me.colDescription.Width = 314
        '
        'colIsWeekend
        '
        Me.colIsWeekend.AppearanceHeader.Options.UseTextOptions = True
        Me.colIsWeekend.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colIsWeekend.FieldName = "IsWeekend"
        Me.colIsWeekend.Name = "colIsWeekend"
        Me.colIsWeekend.Visible = True
        Me.colIsWeekend.VisibleIndex = 3
        Me.colIsWeekend.Width = 122
        '
        'colYear
        '
        Me.colYear.AppearanceHeader.Options.UseTextOptions = True
        Me.colYear.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colYear.FieldName = "Year"
        Me.colYear.Name = "colYear"
        Me.colYear.Visible = True
        Me.colYear.VisibleIndex = 0
        Me.colYear.Width = 88
        '
        'YearTextBox
        '
        Me.YearTextBox.Location = New System.Drawing.Point(311, 3)
        Me.YearTextBox.Name = "YearTextBox"
        Me.YearTextBox.Size = New System.Drawing.Size(100, 20)
        Me.YearTextBox.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(278, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Year"
        '
        'WeekdayCheckBox
        '
        Me.WeekdayCheckBox.AutoSize = True
        Me.WeekdayCheckBox.Location = New System.Drawing.Point(418, 5)
        Me.WeekdayCheckBox.Name = "WeekdayCheckBox"
        Me.WeekdayCheckBox.Size = New System.Drawing.Size(73, 17)
        Me.WeekdayCheckBox.TabIndex = 5
        Me.WeekdayCheckBox.Text = "Weekend"
        Me.WeekdayCheckBox.UseVisualStyleBackColor = True
        '
        'GenerateButton
        '
        Me.GenerateButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GenerateButton.Location = New System.Drawing.Point(616, 1)
        Me.GenerateButton.Name = "GenerateButton"
        Me.GenerateButton.Size = New System.Drawing.Size(89, 23)
        Me.GenerateButton.TabIndex = 6
        Me.GenerateButton.Text = "Generate"
        Me.GenerateButton.UseVisualStyleBackColor = True
        '
        'ShowButton
        '
        Me.ShowButton.Location = New System.Drawing.Point(496, 1)
        Me.ShowButton.Name = "ShowButton"
        Me.ShowButton.Size = New System.Drawing.Size(73, 23)
        Me.ShowButton.TabIndex = 7
        Me.ShowButton.Text = "Show"
        Me.ShowButton.UseVisualStyleBackColor = True
        '
        'frmHoliday
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(708, 439)
        Me.Controls.Add(Me.ShowButton)
        Me.Controls.Add(Me.GenerateButton)
        Me.Controls.Add(Me.WeekdayCheckBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.YearTextBox)
        Me.Controls.Add(Me.HolidayGridControl)
        Me.Controls.Add(Me.HolidayBindingNavigator)
        Me.Name = "frmHoliday"
        Me.Text = "Holiday Master"
        CType(Me.HolidayDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HolidayBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HolidayBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HolidayBindingNavigator.ResumeLayout(False)
        Me.HolidayBindingNavigator.PerformLayout()
        CType(Me.HolidayGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents HolidayDataSet As KSoft_Apparel.HolidayDataSet
    Friend WithEvents HolidayBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HolidayTableAdapter As KSoft_Apparel.HolidayDataSetTableAdapters.HolidayTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.HolidayDataSetTableAdapters.TableAdapterManager
    Friend WithEvents HolidayBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents HolidayBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents HolidayGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colHolidayDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsWeekend As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colYear As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents YearTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents WeekdayCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents GenerateButton As System.Windows.Forms.Button
    Friend WithEvents ShowButton As System.Windows.Forms.Button
End Class
