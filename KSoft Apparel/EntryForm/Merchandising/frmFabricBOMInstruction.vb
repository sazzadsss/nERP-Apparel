Public Class frmFabricBOMInstruction
    Private _FabricBOMId As Integer
    Public Property FabricBOMId() As Integer
        Get
            Return _FabricBOMId
        End Get
        Set(ByVal value As Integer)
            _FabricBOMId = value
        End Set
    End Property
    Private Sub FabricBOMInstructionBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FabricBOMInstructionBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.FabricBOMInstructionBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.FabricBOMInstructionDataSet)

    End Sub

    Private Sub frmFabricBOMInstruction_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.FabricBOMInstructionTableAdapter.Fill(Me.FabricBOMInstructionDataSet.FabricBOMInstruction, Me.FabricBOMId)
        Me.FabricBOMInstructionDataSet.FabricBOMInstruction.FabricBOMIdColumn.DefaultValue = Me.FabricBOMId

        If FabricBOMInstructionBindingSource.Position = -1 Then

            Dim FBInstruction As String = ""

            For i As Integer = 1 To 6


                Select Case i
                    Case 1
                        FBInstruction = "Minimum Fabric Lenth to be required more then 100mtr in each roll."
                    Case 2
                        FBInstruction = "Pls Avoid to deliver any Fabric with twisted,low GSM & (+/-) dia."
                    Case 3
                        FBInstruction = "Pls Provide aprvd Fabric swatch before bulk fabric delivery"
                    Case 4
                        FBInstruction = "Pls, Provide batch wise fabric inspection report on fabric delivery time."
                    Case 5
                        FBInstruction = "Pls, follow the fabric required Date to delivery the fabric"
                    Case 6
                        FBInstruction = "Marker Dia :         Marker Lenght :        "
                    Case Else

                End Select

                Me.FabricBOMInstructionDataSet.FabricBOMInstruction.FabricBOMIdColumn.DefaultValue = Me.FabricBOMId
                Me.FabricBOMInstructionDataSet.FabricBOMInstruction.SLNoColumn.DefaultValue = i
                Me.FabricBOMInstructionDataSet.FabricBOMInstruction.RemarksColumn.DefaultValue = FBInstruction

                Me.FabricBOMInstructionBindingSource.AddNew()


            Next

            Me.Validate()
            Me.FabricBOMInstructionBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.FabricBOMInstructionDataSet)


        End If



    End Sub

    Private Sub FabricBOMInstructionBindingNavigator_RefreshItems(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FabricBOMInstructionBindingNavigator.RefreshItems

    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)



    End Sub
End Class