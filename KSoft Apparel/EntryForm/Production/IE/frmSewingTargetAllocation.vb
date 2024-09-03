Public Class frmSewingTargetAllocation
    Dim ProdEff As Double

    Private _SMV As Double
    Public Property SewingSMV() As Double
        Get
            Return _SMV
        End Get
        Set(ByVal value As Double)
            _SMV = value
        End Set
    End Property
    Private _AllocatingQuantity As Double
    Public Property AllocatingQuantity() As Double
        Get
            Return _AllocatingQuantity
        End Get
        Set(ByVal value As Double)
            _AllocatingQuantity = value
        End Set
    End Property
    Private _MachineQuantity As Double
    Public Property MachineQuantity() As Double
        Get
            Return _MachineQuantity
        End Get
        Set(ByVal value As Double)
            _MachineQuantity = value
        End Set
    End Property
    Private _SewingLayoutId As Integer
    Public Property SewingLayoutId() As Integer
        Get
            Return _SewingLayoutId
        End Get
        Set(ByVal value As Integer)
            _SewingLayoutId = value
        End Set
    End Property
    Private _StyleId As Integer
    Public Property StyleId() As Integer
        Get
            Return _StyleId
        End Get
        Set(ByVal value As Integer)
            _StyleId = value
        End Set
    End Property

    Dim WHPD As Integer = 0
    Private Sub SewingTargetAllocationBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SewingTargetAllocationBindingNavigatorSaveItem.Click

        Try
            Me.Validate()
            Me.SewingTargetAllocationBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.SewingLayoutDataSet)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub frmSewingTargetAllocation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        WHPD = ReadIntData("Select WHPerDay From SewingLayout Where LayoutId=" & Me.SewingLayoutId, cnn)
        Dim RecordCount As Integer = 0
        Me.SewingTargetAllocationTableAdapter.Fill(Me.SewingLayoutDataSet.SewingTargetAllocation, Me.SewingLayoutId)
        Me.SewingLayoutDataSet.SewingTargetAllocation.SewingLayoutIdColumn.DefaultValue = Me.SewingLayoutId

        AllocatingQuantityLabel.Text = FormatNumber(Me.AllocatingQuantity, 0)
        Me.WHPerDayLabel.Text = WHPD
        SMVMachineLabel.Text = FormatNumber(Me.SewingSMV, 2)
        '({@WorkingTime}*{@TTLManpower}*{SewingLayout.PlanEfficiency}/100)/{@TTLSMV}
        Dim TTLMachineHelper As Integer = ReadIntData("Select CAST((MachineQuantity+Helper) AS INT) AS TTLMachine From SewingLayout where LayoutId=" & Me.SewingLayoutId, cnn)
        ProdEff = FormatNumber((TTLMachineHelper * 60 * WHPD) / Me.SewingSMV, 0)
        Me.ProdEfficiencyLabel.Text = ProdEff
        RecordCount = ReadIntData("Select Count(*) From SewingTargetAllocation where SewingLayoutId=" & Me.SewingLayoutId, cnn)
        Dim AllocationLayoutTime As Integer = ReadIntData("Select Max(LayoutTime) from SewingTargetAllocation Where SewingLayoutId=" & Me.SewingLayoutId, cnn)


        If RecordCount > 0 And IsDBNull(RecordCount) = False Then

            Dim TargetValue As Decimal = ReadData("Select Sum(NormalQuantity) From SewingTargetAllocation where SewingLayoutId=" & Me.SewingLayoutId, cnn) / (RecordCount * WHPD + AllocationLayoutTime)
            TargetLabel.Text = FormatNumber(TargetValue, 0)
            BonusTargetLabel.Text = FormatNumber(TargetValue * 1.2, 0)

        End If

       
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click

        If Me.SewingTargetAllocationBindingSource.Position = -1 Then


            Dim i As Integer = Val(Me.LCComboBox.Text.ToString)
            Dim CumNormalQuantity As Integer = 0
            Dim CumBonusQuantity As Integer = 0
            Dim Target As Integer = 0

            Dim Efficiency As Decimal


            'Efficiency = ReadData("Select Min(LC_Value) From SewingLearningCurve Where MinSMV<=" & Me.SewingSMV & " and DaySerial=" & i, cnn)

            'CumNormalQuantity = ProdEff * Efficiency 'ReadData("Select LC_Value From SewingLearningCurve Where MinSMV>=" & Me.SewingSMV & " and MaxSMV<= (Select Min(MaxSMV) as MaxSMV from SewingLearningCurve Where MinSMV>=" & Me.SewingSMV & ") and DaySerial=" & i, cnn)
            'CumBonusQuantity = ProdEff * Efficiency * 1.2

            'MessageBox.Show(CumNormalQuantity)

            While CumNormalQuantity <= Me.AllocatingQuantity

                If i < 10 Then

                    Efficiency = ReadData("Select Min(LC_Value) From SewingLearningCurve Where MinSMV<=" & Me.SewingSMV & " and DaySerial=" & i, cnn)

                Else

                    Efficiency = ReadData("Select Min(LC_Value) From SewingLearningCurve Where MinSMV<=" & Me.SewingSMV & " and DaySerial=10", cnn)

                End If

                'If i > 1 Then

                CumNormalQuantity = CumNormalQuantity + ProdEff * Efficiency 'ReadData("Select LC_Value From SewingLearningCurve Where MinSMV>=" & Me.SewingSMV & " and MaxSMV<= (Select Min(MaxSMV) as MaxSMV from SewingLearningCurve Where MinSMV>=" & Me.SewingSMV & ") and DaySerial=" & i, cnn)
                CumBonusQuantity = CumBonusQuantity + ProdEff * Efficiency * 1.2

                'Debug.Print(Me.AllocatingQuantity * 1.05 + 1500)
                'Debug.Print(CumNormalQuantity)


                'End If
                'If CumNormalQuantity <= Me.AllocatingQuantity * 1.08 Then

                Dim TTLMachineHelper As Integer = ReadIntData("Select CAST((MachineQuantity+Helper) AS INT) AS TTLMachine From SewingLayout where LayoutId=" & Me.SewingLayoutId, cnn)



                Dim NewRow As SewingLayoutDataSet.SewingTargetAllocationRow = Me.SewingLayoutDataSet.SewingTargetAllocation.NewRow()

                    With NewRow

                        .SewingLayoutId = Me.SewingLayoutId
                        .DaySerial = i - Val(LCComboBox.Text.ToString) + 1
                    .Efficiency = Efficiency

                    If CumNormalQuantity > Me.AllocatingQuantity Then
                        .NormalQuantity = (ProdEff - (CumNormalQuantity - Me.AllocatingQuantity)) * Efficiency 'ReadData("Select LC_Value From SewingLearningCurve Where MinSMV>=" & Me.SewingSMV & " and MaxSMV<= (Select Min(MaxSMV) as MaxSMV from SewingLearningCurve Where MinSMV>=" & Me.SewingSMV & ") and DaySerial=" & i, cnn)
                        .CumNormalQuantity = CumNormalQuantity - (CumNormalQuantity - Me.AllocatingQuantity)
                    Else
                        'ProdEff = FormatNumber((TTLMachineHelper * 60 * WHPD * Efficiency) / Me.SewingSMV, 0)
                        .NormalQuantity = ProdEff * Efficiency
                        .CumNormalQuantity = CumNormalQuantity
                    End If
                    .CumBonusQuantity = .CumNormalQuantity * 1.2
                    .BonusQuanitty = .NormalQuantity * 1.2

                    .SelectedLCDay = Val(LCComboBox.Text.ToString)
                        .LCDayReason = ReasonTextBox.Text.ToString
                        .LayoutTime = Val(LayoutTimeTextBox.Text.ToString)

                    End With

                    Me.SewingLayoutDataSet.SewingTargetAllocation.Rows.Add(NewRow)



                'Target = (CumNormalQuantity / (i - Val(LCComboBox.Text) + 1) / 10)
                Target = CumNormalQuantity / ((i - Val(LCComboBox.Text) + 1) * WHPD + Val(LayoutTimeTextBox.Text.ToString))
                i += 1

                'End If

            End While


            TargetLabel.Text = FormatNumber(Target, 0)
            BonusTargetLabel.Text = FormatNumber(Target * 1.2, 0)

        End If

    End Sub

    
    
    
    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click

        If SewingTargetAllocationBindingSource.Position > -1 Then

            Me.Validate()
            Me.SewingTargetAllocationBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.SewingLayoutDataSet)

            Me.DialogResult = System.Windows.Forms.DialogResult.OK

        End If

        Me.Close()

    End Sub
End Class