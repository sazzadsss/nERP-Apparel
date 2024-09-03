<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPlanningBoard
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
        Me.XtraScrollableControl2 = New DevExpress.XtraEditors.XtraScrollableControl
        Me.FromDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.ToDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.LoadButton = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.DateRangeLabelControl = New DevExpress.XtraEditors.LabelControl
        Me.XtraScrollableControl1 = New DevExpress.XtraEditors.XtraScrollableControl
        Me.XtraScrollableControl3 = New DevExpress.XtraEditors.XtraScrollableControl
        Me.SimpleButton8 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel
        Me.AddButton = New System.Windows.Forms.Button
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton5 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton6 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton7 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton9 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton10 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton11 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton12 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton13 = New DevExpress.XtraEditors.SimpleButton
        Me.SelectedFromDateButton = New DevExpress.XtraEditors.SimpleButton
        Me.SelectedLineButton = New DevExpress.XtraEditors.SimpleButton
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PlanningNewDataSet = New KSoft_Apparel.PlanningNewDataSet
        Me.PlanningBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PlanningTableAdapter = New KSoft_Apparel.PlanningNewDataSetTableAdapters.PlanningTableAdapter
        Me.TableAdapterManager = New KSoft_Apparel.PlanningNewDataSetTableAdapters.TableAdapterManager
        Me.LineDataSet = New KSoft_Apparel.LineDataSet
        Me.LineBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LineTableAdapter = New KSoft_Apparel.LineDataSetTableAdapters.LineTableAdapter
        Me.TableAdapterManager1 = New KSoft_Apparel.LineDataSetTableAdapters.TableAdapterManager
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlanningNewDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlanningBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LineDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LineBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'XtraScrollableControl2
        '
        Me.XtraScrollableControl2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XtraScrollableControl2.Location = New System.Drawing.Point(172, 72)
        Me.XtraScrollableControl2.LookAndFeel.SkinName = "Blue"
        Me.XtraScrollableControl2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.XtraScrollableControl2.Name = "XtraScrollableControl2"
        Me.XtraScrollableControl2.Size = New System.Drawing.Size(840, 334)
        Me.XtraScrollableControl2.TabIndex = 1
        '
        'FromDateTimePicker
        '
        Me.FromDateTimePicker.CustomFormat = "dd-MMM-yy"
        Me.FromDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.FromDateTimePicker.Location = New System.Drawing.Point(72, 5)
        Me.FromDateTimePicker.Margin = New System.Windows.Forms.Padding(3, 5, 3, 3)
        Me.FromDateTimePicker.Name = "FromDateTimePicker"
        Me.FromDateTimePicker.Size = New System.Drawing.Size(91, 20)
        Me.FromDateTimePicker.TabIndex = 3
        '
        'ToDateTimePicker
        '
        Me.ToDateTimePicker.CustomFormat = "dd-MMM-yy"
        Me.ToDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.ToDateTimePicker.Location = New System.Drawing.Point(221, 5)
        Me.ToDateTimePicker.Margin = New System.Windows.Forms.Padding(3, 5, 3, 3)
        Me.ToDateTimePicker.Name = "ToDateTimePicker"
        Me.ToDateTimePicker.Size = New System.Drawing.Size(95, 20)
        Me.ToDateTimePicker.TabIndex = 4
        '
        'LoadButton
        '
        Me.LoadButton.Location = New System.Drawing.Point(322, 3)
        Me.LoadButton.Name = "LoadButton"
        Me.LoadButton.Size = New System.Drawing.Size(75, 23)
        Me.LoadButton.TabIndex = 5
        Me.LoadButton.Text = "Load"
        Me.LoadButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 8)
        Me.Label1.Margin = New System.Windows.Forms.Padding(10, 8, 3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Tag = ""
        Me.Label1.Text = "From Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(169, 8)
        Me.Label2.Margin = New System.Windows.Forms.Padding(3, 8, 3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Tag = ""
        Me.Label2.Text = "To Date"
        '
        'DateRangeLabelControl
        '
        Me.DateRangeLabelControl.Location = New System.Drawing.Point(403, 8)
        Me.DateRangeLabelControl.Margin = New System.Windows.Forms.Padding(3, 8, 3, 3)
        Me.DateRangeLabelControl.Name = "DateRangeLabelControl"
        Me.DateRangeLabelControl.Size = New System.Drawing.Size(54, 13)
        Me.DateRangeLabelControl.TabIndex = 8
        Me.DateRangeLabelControl.Text = "DateRange"
        '
        'XtraScrollableControl1
        '
        Me.XtraScrollableControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.XtraScrollableControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.XtraScrollableControl1.Appearance.Options.UseBackColor = True
        Me.XtraScrollableControl1.Location = New System.Drawing.Point(12, 72)
        Me.XtraScrollableControl1.LookAndFeel.SkinName = "Blue"
        Me.XtraScrollableControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.XtraScrollableControl1.Name = "XtraScrollableControl1"
        Me.XtraScrollableControl1.Size = New System.Drawing.Size(160, 310)
        Me.XtraScrollableControl1.TabIndex = 26
        '
        'XtraScrollableControl3
        '
        Me.XtraScrollableControl3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XtraScrollableControl3.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.XtraScrollableControl3.Appearance.Options.UseBackColor = True
        Me.XtraScrollableControl3.Location = New System.Drawing.Point(172, 38)
        Me.XtraScrollableControl3.Name = "XtraScrollableControl3"
        Me.XtraScrollableControl3.Size = New System.Drawing.Size(817, 55)
        Me.XtraScrollableControl3.TabIndex = 27
        '
        'SimpleButton8
        '
        Me.SimpleButton8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton8.Location = New System.Drawing.Point(12, 437)
        Me.SimpleButton8.LookAndFeel.SkinName = "Blue"
        Me.SimpleButton8.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SimpleButton8.Name = "SimpleButton8"
        Me.SimpleButton8.Size = New System.Drawing.Size(112, 23)
        Me.SimpleButton8.TabIndex = 14
        '
        'SimpleButton
        '
        Me.SimpleButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton.Location = New System.Drawing.Point(12, 412)
        Me.SimpleButton.LookAndFeel.SkinName = "Blue"
        Me.SimpleButton.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SimpleButton.Name = "SimpleButton"
        Me.SimpleButton.Size = New System.Drawing.Size(112, 23)
        Me.SimpleButton.TabIndex = 10
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LabelControl1.Appearance.Options.UseBackColor = True
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.LabelControl1.Location = New System.Drawing.Point(12, 38)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(160, 34)
        Me.LabelControl1.TabIndex = 29
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.FlowLayoutPanel1.Controls.Add(Me.Label1)
        Me.FlowLayoutPanel1.Controls.Add(Me.FromDateTimePicker)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label2)
        Me.FlowLayoutPanel1.Controls.Add(Me.ToDateTimePicker)
        Me.FlowLayoutPanel1.Controls.Add(Me.LoadButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.DateRangeLabelControl)
        Me.FlowLayoutPanel1.Controls.Add(Me.AddButton)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1029, 32)
        Me.FlowLayoutPanel1.TabIndex = 30
        '
        'AddButton
        '
        Me.AddButton.Location = New System.Drawing.Point(463, 3)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(75, 23)
        Me.AddButton.TabIndex = 9
        Me.AddButton.Text = "Add"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'LabelControl2
        '
        Me.LabelControl2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelControl2.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LabelControl2.Appearance.Options.UseBackColor = True
        Me.LabelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.LabelControl2.Location = New System.Drawing.Point(12, 382)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(160, 24)
        Me.LabelControl2.TabIndex = 31
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Location = New System.Drawing.Point(125, 437)
        Me.SimpleButton1.LookAndFeel.SkinName = "Blue"
        Me.SimpleButton1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(112, 23)
        Me.SimpleButton1.TabIndex = 34
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.Location = New System.Drawing.Point(125, 412)
        Me.SimpleButton2.LookAndFeel.SkinName = "Blue"
        Me.SimpleButton2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(112, 23)
        Me.SimpleButton2.TabIndex = 33
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton3.Location = New System.Drawing.Point(238, 437)
        Me.SimpleButton3.LookAndFeel.SkinName = "Blue"
        Me.SimpleButton3.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(112, 23)
        Me.SimpleButton3.TabIndex = 36
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton4.Location = New System.Drawing.Point(238, 412)
        Me.SimpleButton4.LookAndFeel.SkinName = "Blue"
        Me.SimpleButton4.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(112, 23)
        Me.SimpleButton4.TabIndex = 35
        '
        'SimpleButton5
        '
        Me.SimpleButton5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton5.Location = New System.Drawing.Point(352, 437)
        Me.SimpleButton5.LookAndFeel.SkinName = "Blue"
        Me.SimpleButton5.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SimpleButton5.Name = "SimpleButton5"
        Me.SimpleButton5.Size = New System.Drawing.Size(112, 23)
        Me.SimpleButton5.TabIndex = 38
        '
        'SimpleButton6
        '
        Me.SimpleButton6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton6.Location = New System.Drawing.Point(352, 412)
        Me.SimpleButton6.LookAndFeel.SkinName = "Blue"
        Me.SimpleButton6.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SimpleButton6.Name = "SimpleButton6"
        Me.SimpleButton6.Size = New System.Drawing.Size(112, 23)
        Me.SimpleButton6.TabIndex = 37
        '
        'SimpleButton7
        '
        Me.SimpleButton7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton7.Location = New System.Drawing.Point(466, 437)
        Me.SimpleButton7.LookAndFeel.SkinName = "Blue"
        Me.SimpleButton7.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SimpleButton7.Name = "SimpleButton7"
        Me.SimpleButton7.Size = New System.Drawing.Size(112, 23)
        Me.SimpleButton7.TabIndex = 40
        '
        'SimpleButton9
        '
        Me.SimpleButton9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton9.Location = New System.Drawing.Point(466, 412)
        Me.SimpleButton9.LookAndFeel.SkinName = "Blue"
        Me.SimpleButton9.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SimpleButton9.Name = "SimpleButton9"
        Me.SimpleButton9.Size = New System.Drawing.Size(112, 23)
        Me.SimpleButton9.TabIndex = 39
        '
        'SimpleButton10
        '
        Me.SimpleButton10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton10.Location = New System.Drawing.Point(580, 437)
        Me.SimpleButton10.LookAndFeel.SkinName = "Blue"
        Me.SimpleButton10.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SimpleButton10.Name = "SimpleButton10"
        Me.SimpleButton10.Size = New System.Drawing.Size(112, 23)
        Me.SimpleButton10.TabIndex = 42
        '
        'SimpleButton11
        '
        Me.SimpleButton11.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton11.Location = New System.Drawing.Point(580, 412)
        Me.SimpleButton11.LookAndFeel.SkinName = "Blue"
        Me.SimpleButton11.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SimpleButton11.Name = "SimpleButton11"
        Me.SimpleButton11.Size = New System.Drawing.Size(112, 23)
        Me.SimpleButton11.TabIndex = 41
        '
        'SimpleButton12
        '
        Me.SimpleButton12.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton12.Location = New System.Drawing.Point(694, 437)
        Me.SimpleButton12.LookAndFeel.SkinName = "Blue"
        Me.SimpleButton12.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SimpleButton12.Name = "SimpleButton12"
        Me.SimpleButton12.Size = New System.Drawing.Size(111, 23)
        Me.SimpleButton12.TabIndex = 44
        '
        'SimpleButton13
        '
        Me.SimpleButton13.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton13.Location = New System.Drawing.Point(694, 412)
        Me.SimpleButton13.LookAndFeel.SkinName = "Blue"
        Me.SimpleButton13.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SimpleButton13.Name = "SimpleButton13"
        Me.SimpleButton13.Size = New System.Drawing.Size(111, 23)
        Me.SimpleButton13.TabIndex = 43
        '
        'SelectedFromDateButton
        '
        Me.SelectedFromDateButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SelectedFromDateButton.Location = New System.Drawing.Point(807, 437)
        Me.SelectedFromDateButton.LookAndFeel.SkinName = "Black"
        Me.SelectedFromDateButton.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SelectedFromDateButton.Name = "SelectedFromDateButton"
        Me.SelectedFromDateButton.Size = New System.Drawing.Size(193, 23)
        Me.SelectedFromDateButton.TabIndex = 46
        '
        'SelectedLineButton
        '
        Me.SelectedLineButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SelectedLineButton.Location = New System.Drawing.Point(807, 412)
        Me.SelectedLineButton.LookAndFeel.SkinName = "Black"
        Me.SelectedLineButton.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SelectedLineButton.Name = "SelectedLineButton"
        Me.SelectedLineButton.Size = New System.Drawing.Size(193, 23)
        Me.SelectedLineButton.TabIndex = 45
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Location = New System.Drawing.Point(990, 38)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(33, 351)
        Me.PictureBox1.TabIndex = 32
        Me.PictureBox1.TabStop = False
        '
        'PlanningNewDataSet
        '
        Me.PlanningNewDataSet.DataSetName = "PlanningNewDataSet"
        Me.PlanningNewDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PlanningBindingSource
        '
        Me.PlanningBindingSource.DataMember = "Planning"
        Me.PlanningBindingSource.DataSource = Me.PlanningNewDataSet
        '
        'PlanningTableAdapter
        '
        Me.PlanningTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.PlanningTableAdapter = Me.PlanningTableAdapter
        Me.TableAdapterManager.SewingTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.PlanningNewDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
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
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.LineTableAdapter = Me.LineTableAdapter
        Me.TableAdapterManager1.UpdateOrder = KSoft_Apparel.LineDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'frmPlanningBoard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1029, 467)
        Me.Controls.Add(Me.SelectedFromDateButton)
        Me.Controls.Add(Me.SelectedLineButton)
        Me.Controls.Add(Me.SimpleButton12)
        Me.Controls.Add(Me.SimpleButton13)
        Me.Controls.Add(Me.SimpleButton10)
        Me.Controls.Add(Me.SimpleButton11)
        Me.Controls.Add(Me.SimpleButton7)
        Me.Controls.Add(Me.SimpleButton9)
        Me.Controls.Add(Me.SimpleButton5)
        Me.Controls.Add(Me.SimpleButton6)
        Me.Controls.Add(Me.SimpleButton3)
        Me.Controls.Add(Me.SimpleButton4)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.XtraScrollableControl2)
        Me.Controls.Add(Me.XtraScrollableControl1)
        Me.Controls.Add(Me.SimpleButton8)
        Me.Controls.Add(Me.SimpleButton)
        Me.Controls.Add(Me.XtraScrollableControl3)
        Me.Name = "frmPlanningBoard"
        Me.Text = "Planning Board"
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlanningNewDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlanningBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LineDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LineBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents XtraScrollableControl2 As DevExpress.XtraEditors.XtraScrollableControl
    Friend WithEvents FromDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ToDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents LoadButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DateRangeLabelControl As DevExpress.XtraEditors.LabelControl
    Friend WithEvents XtraScrollableControl1 As DevExpress.XtraEditors.XtraScrollableControl
    Friend WithEvents XtraScrollableControl3 As DevExpress.XtraEditors.XtraScrollableControl
    Friend WithEvents SimpleButton8 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton5 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton6 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton7 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton9 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton10 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton11 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton12 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton13 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SelectedFromDateButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SelectedLineButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents AddButton As System.Windows.Forms.Button
    Friend WithEvents PlanningNewDataSet As KSoft_Apparel.PlanningNewDataSet
    Friend WithEvents PlanningBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PlanningTableAdapter As KSoft_Apparel.PlanningNewDataSetTableAdapters.PlanningTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.PlanningNewDataSetTableAdapters.TableAdapterManager
    Friend WithEvents LineDataSet As KSoft_Apparel.LineDataSet
    Friend WithEvents LineBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LineTableAdapter As KSoft_Apparel.LineDataSetTableAdapters.LineTableAdapter
    Friend WithEvents TableAdapterManager1 As KSoft_Apparel.LineDataSetTableAdapters.TableAdapterManager
End Class
