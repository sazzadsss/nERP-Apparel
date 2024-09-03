<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStyleName
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStyleName))
        Me.StyleNameMstBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.StyleNameMstBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StyleDataSet = New KSoft_Apparel.StyleDataSet()
        Me.StyleNameMstBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.SearchTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.StyleNameMstDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StyleNameGroup = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StyleNameMstTableAdapter = New KSoft_Apparel.StyleDataSetTableAdapters.StyleNameMstTableAdapter()
        Me.TableAdapterManager = New KSoft_Apparel.StyleDataSetTableAdapters.TableAdapterManager()
        Me.OKButton = New System.Windows.Forms.Button()
        Me.SNCancelButton = New System.Windows.Forms.Button()
        CType(Me.StyleNameMstBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StyleNameMstBindingNavigator.SuspendLayout()
        CType(Me.StyleNameMstBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleNameMstDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StyleNameMstBindingNavigator
        '
        Me.StyleNameMstBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.StyleNameMstBindingNavigator.BindingSource = Me.StyleNameMstBindingSource
        Me.StyleNameMstBindingNavigator.CountItem = Nothing
        Me.StyleNameMstBindingNavigator.DeleteItem = Nothing
        Me.StyleNameMstBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorAddNewItem, Me.StyleNameMstBindingNavigatorSaveItem, Me.SearchTextBox, Me.ToolStripButton1})
        Me.StyleNameMstBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.StyleNameMstBindingNavigator.MoveFirstItem = Nothing
        Me.StyleNameMstBindingNavigator.MoveLastItem = Nothing
        Me.StyleNameMstBindingNavigator.MoveNextItem = Nothing
        Me.StyleNameMstBindingNavigator.MovePreviousItem = Nothing
        Me.StyleNameMstBindingNavigator.Name = "StyleNameMstBindingNavigator"
        Me.StyleNameMstBindingNavigator.PositionItem = Nothing
        Me.StyleNameMstBindingNavigator.Size = New System.Drawing.Size(505, 25)
        Me.StyleNameMstBindingNavigator.TabIndex = 0
        Me.StyleNameMstBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(74, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'StyleNameMstBindingSource
        '
        Me.StyleNameMstBindingSource.DataMember = "StyleNameMst"
        Me.StyleNameMstBindingSource.DataSource = Me.StyleDataSet
        '
        'StyleDataSet
        '
        Me.StyleDataSet.DataSetName = "StyleDataSet"
        Me.StyleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StyleNameMstBindingNavigatorSaveItem
        '
        Me.StyleNameMstBindingNavigatorSaveItem.Image = CType(resources.GetObject("StyleNameMstBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.StyleNameMstBindingNavigatorSaveItem.Name = "StyleNameMstBindingNavigatorSaveItem"
        Me.StyleNameMstBindingNavigatorSaveItem.Size = New System.Drawing.Size(78, 22)
        Me.StyleNameMstBindingNavigatorSaveItem.Text = "Save Data"
        '
        'SearchTextBox
        '
        Me.SearchTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.SearchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SearchTextBox.Name = "SearchTextBox"
        Me.SearchTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(41, 22)
        Me.ToolStripButton1.Text = "All"
        '
        'StyleNameMstDataGridView
        '
        Me.StyleNameMstDataGridView.AllowUserToAddRows = False
        Me.StyleNameMstDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StyleNameMstDataGridView.AutoGenerateColumns = False
        Me.StyleNameMstDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.StyleNameMstDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StyleNameMstDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.StyleNameGroup})
        Me.StyleNameMstDataGridView.DataSource = Me.StyleNameMstBindingSource
        Me.StyleNameMstDataGridView.Location = New System.Drawing.Point(0, 28)
        Me.StyleNameMstDataGridView.Name = "StyleNameMstDataGridView"
        Me.StyleNameMstDataGridView.Size = New System.Drawing.Size(503, 248)
        Me.StyleNameMstDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "StyleName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Style Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'StyleNameGroup
        '
        Me.StyleNameGroup.DataPropertyName = "StyleNameGroup"
        Me.StyleNameGroup.HeaderText = "Style Name Group"
        Me.StyleNameGroup.Name = "StyleNameGroup"
        Me.StyleNameGroup.Width = 150
        '
        'StyleNameMstTableAdapter
        '
        Me.StyleNameMstTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.FRStyleProcessTableAdapter = Nothing
        Me.TableAdapterManager.StyleNameMstTableAdapter = Me.StyleNameMstTableAdapter
        Me.TableAdapterManager.StyleTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.StyleDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'OKButton
        '
        Me.OKButton.Location = New System.Drawing.Point(413, 282)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(90, 26)
        Me.OKButton.TabIndex = 2
        Me.OKButton.Text = "&OK"
        Me.OKButton.UseVisualStyleBackColor = True
        '
        'SNCancelButton
        '
        Me.SNCancelButton.Location = New System.Drawing.Point(299, 282)
        Me.SNCancelButton.Name = "SNCancelButton"
        Me.SNCancelButton.Size = New System.Drawing.Size(108, 26)
        Me.SNCancelButton.TabIndex = 3
        Me.SNCancelButton.Text = "&Cancel"
        Me.SNCancelButton.UseVisualStyleBackColor = True
        '
        'frmStyleName
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(505, 316)
        Me.Controls.Add(Me.SNCancelButton)
        Me.Controls.Add(Me.OKButton)
        Me.Controls.Add(Me.StyleNameMstDataGridView)
        Me.Controls.Add(Me.StyleNameMstBindingNavigator)
        Me.Name = "frmStyleName"
        Me.Text = "Style Name"
        CType(Me.StyleNameMstBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StyleNameMstBindingNavigator.ResumeLayout(False)
        Me.StyleNameMstBindingNavigator.PerformLayout()
        CType(Me.StyleNameMstBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleNameMstDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StyleDataSet As KSoft_Apparel.StyleDataSet
    Friend WithEvents StyleNameMstBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StyleNameMstTableAdapter As KSoft_Apparel.StyleDataSetTableAdapters.StyleNameMstTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.StyleDataSetTableAdapters.TableAdapterManager
    Friend WithEvents StyleNameMstBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents StyleNameMstBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents StyleNameMstDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents SearchTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StyleNameGroup As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OKButton As System.Windows.Forms.Button
    Friend WithEvents SNCancelButton As System.Windows.Forms.Button
End Class
