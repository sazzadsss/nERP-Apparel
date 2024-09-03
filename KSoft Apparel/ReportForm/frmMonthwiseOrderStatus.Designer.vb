<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMonthwiseOrderStatus
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
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.ShipmentRadioButton = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ShowYearlyButton = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ToDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.FromDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.BuyerDataSet = New KSoft_Apparel.BuyerDataSet()
        Me.BuyerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BuyerTableAdapter = New KSoft_Apparel.BuyerDataSetTableAdapters.BuyerTableAdapter()
        Me.BuyerCheckBox = New System.Windows.Forms.CheckBox()
        Me.BuyerComboBox = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        CType(Me.BuyerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 108)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1257, 396)
        Me.CrystalReportViewer1.TabIndex = 2
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'ShipmentRadioButton
        '
        Me.ShipmentRadioButton.AutoSize = True
        Me.ShipmentRadioButton.Checked = True
        Me.ShipmentRadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShipmentRadioButton.Location = New System.Drawing.Point(5, 3)
        Me.ShipmentRadioButton.Name = "ShipmentRadioButton"
        Me.ShipmentRadioButton.Size = New System.Drawing.Size(164, 17)
        Me.ShipmentRadioButton.TabIndex = 42
        Me.ShipmentRadioButton.TabStop = True
        Me.ShipmentRadioButton.Text = "Ex Date Wise Order Booking:"
        Me.ShipmentRadioButton.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(131, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(23, 13)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "To:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "From:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(508, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 53)
        Me.Button1.TabIndex = 43
        Me.Button1.Text = "&Show Confirm Order [Portrait]"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(799, 8)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(165, 13)
        Me.Label7.TabIndex = 49
        Me.Label7.Text = "Year/Month Wise Order Booking:"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030"})
        Me.ComboBox2.Location = New System.Drawing.Point(1001, 25)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(80, 21)
        Me.ComboBox2.TabIndex = 47
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030"})
        Me.ComboBox1.Location = New System.Drawing.Point(860, 25)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(80, 21)
        Me.ComboBox1.TabIndex = 48
        '
        'ShowYearlyButton
        '
        Me.ShowYearlyButton.Location = New System.Drawing.Point(1091, 8)
        Me.ShowYearlyButton.Name = "ShowYearlyButton"
        Me.ShowYearlyButton.Size = New System.Drawing.Size(79, 53)
        Me.ShowYearlyButton.TabIndex = 46
        Me.ShowYearlyButton.Text = "&Show Confirm Order"
        Me.ShowYearlyButton.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(944, 29)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 13)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "To Year : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(799, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "From Year : "
        '
        'ToDateTimePicker
        '
        Me.ToDateTimePicker.CustomFormat = "dd-MMM-yy"
        Me.ToDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.ToDateTimePicker.Location = New System.Drawing.Point(162, 26)
        Me.ToDateTimePicker.Name = "ToDateTimePicker"
        Me.ToDateTimePicker.Size = New System.Drawing.Size(80, 20)
        Me.ToDateTimePicker.TabIndex = 51
        '
        'FromDateTimePicker
        '
        Me.FromDateTimePicker.CustomFormat = "dd-MMM-yy"
        Me.FromDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.FromDateTimePicker.Location = New System.Drawing.Point(45, 26)
        Me.FromDateTimePicker.Name = "FromDateTimePicker"
        Me.FromDateTimePicker.Size = New System.Drawing.Size(80, 20)
        Me.FromDateTimePicker.TabIndex = 50
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(602, 8)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(88, 53)
        Me.Button3.TabIndex = 53
        Me.Button3.Text = "&Show Confirm Order [Landscape]"
        Me.Button3.UseVisualStyleBackColor = True
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
        'BuyerCheckBox
        '
        Me.BuyerCheckBox.AutoSize = True
        Me.BuyerCheckBox.Location = New System.Drawing.Point(254, 27)
        Me.BuyerCheckBox.Name = "BuyerCheckBox"
        Me.BuyerCheckBox.Size = New System.Drawing.Size(59, 17)
        Me.BuyerCheckBox.TabIndex = 55
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
        Me.BuyerComboBox.Location = New System.Drawing.Point(315, 25)
        Me.BuyerComboBox.Name = "BuyerComboBox"
        Me.BuyerComboBox.Size = New System.Drawing.Size(187, 21)
        Me.BuyerComboBox.TabIndex = 54
        Me.BuyerComboBox.ValueMember = "BuyerId"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(1176, 8)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(79, 53)
        Me.Button2.TabIndex = 56
        Me.Button2.Text = "&Show Block Order"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(696, 8)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(98, 53)
        Me.Button4.TabIndex = 57
        Me.Button4.Text = "&Show Block Order"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(508, 65)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(88, 20)
        Me.Button5.TabIndex = 58
        Me.Button5.Text = "&Show Details"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(602, 65)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(88, 20)
        Me.Button6.TabIndex = 59
        Me.Button6.Text = "&Show Cancel"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(696, 65)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(98, 20)
        Me.Button7.TabIndex = 60
        Me.Button7.Text = "&Show Shipment"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(860, 52)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(221, 22)
        Me.Button8.TabIndex = 61
        Me.Button8.Text = "&Show Running All Confirm Order"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(860, 80)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(221, 22)
        Me.Button9.TabIndex = 62
        Me.Button9.Text = "&Show Only Balance All Confirm Order"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'frmMonthwiseOrderStatus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1260, 505)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.BuyerCheckBox)
        Me.Controls.Add(Me.BuyerComboBox)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.ToDateTimePicker)
        Me.Controls.Add(Me.FromDateTimePicker)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.ShowYearlyButton)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ShipmentRadioButton)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "frmMonthwiseOrderStatus"
        Me.Text = "Order Booking Month Wise Report"
        CType(Me.BuyerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents ShipmentRadioButton As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ShowYearlyButton As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ToDateTimePicker As DateTimePicker
    Friend WithEvents FromDateTimePicker As DateTimePicker
    Friend WithEvents Button3 As Button
    Friend WithEvents BuyerDataSet As BuyerDataSet
    Friend WithEvents BuyerBindingSource As BindingSource
    Friend WithEvents BuyerTableAdapter As BuyerDataSetTableAdapters.BuyerTableAdapter
    Friend WithEvents BuyerCheckBox As CheckBox
    Friend WithEvents BuyerComboBox As ComboBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
End Class
