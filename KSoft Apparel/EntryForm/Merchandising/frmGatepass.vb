Public Class frmGatepass
    Dim AddFlag As Boolean = False
    Private Sub GatePassBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GatePassBindingNavigatorSaveItem.Click


        If PrintCount(Me.GatePassNoTextEdit.Text, True) > 0 Then
            Dim UL As Integer = ReadIntData("Select User_Level From [User] Where User_Id = " & UserId, cnn)
            If UL <> 1 Then
                MessageBox.Show("Not allowed to edit a already printed challan", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            Else
                GoTo Line1
            End If
        End If

Line1:


        Try

        
            Me.Validate()
            Me.GatePassBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.GatePassDataSet)

            If Me.GatePassBindingSource.Position > -1 Then

                Dim row As GatePassDataSet.GatePassRow
                row = CType(CType(Me.GatePassBindingSource.Current, DataRowView).Row, GatePassDataSet.GatePassRow)

                For Each drv As DataRowView In Me.GatePassDetailsBindingSource.List
                    ExecuteQuery("Update SampleRequestFinalDetails Set SampleSendDate='" & row.GatepassDate & "' Where SampleRequestDetailsId=" & drv!ItemId, cnn)
                    'MessageBox.Show(drv!ItemId.ToString & " / " & row.GatepassDate.ToString)
                Next

                Me.GatePassLookupTableAdapter.Fill(Me.GatePassDataSet.GatePassLookup)

                Me.GridLookUpEdit1.EditValue = row.GatePassId
            End If



        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub frmGatepass_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.GatePassLookupTableAdapter.Fill(Me.GatePassDataSet.GatePassLookup)

        Me.SampleRequestColorLookupTableAdapter.Fill(Me.SampleRequestColorLookupDataSet.SampleRequestColorLookup)
        Me.UnitTableAdapter.Fill(Me.UnitDataSet.Unit)



        If CheckUserRights("Sample Delivery").CanEdit = False Then

            BindingNavigatorAddNewItem.Enabled = False
            GatePassBindingNavigatorSaveItem.Enabled = False
            BindingNavigatorDeleteItem.Enabled = False

        ElseIf CheckUserRights("Sample Delivery").CanDelete = False Then

            BindingNavigatorAddNewItem.Enabled = True
            GatePassBindingNavigatorSaveItem.Enabled = True
            BindingNavigatorDeleteItem.Enabled = False

        End If

       

    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click

        Me.GatePassDataSet.GatePassDetails.UnitIdColumn.DefaultValue = ReadIntegerData("Select UnitId From Unit Where UnitName='PC'", cnn)

        Dim DT As Date = ReadDateData("Select GetDate()", cnn)
        Dim ABC As String = DT.Year.ToString.Substring(2) & "SG"
        Dim XYZ As Integer = ReadIntData("Select Max(Cast(REVERSE(SUBSTRING(REVERSE(GatePassNo),0,CHARINDEX('G',REVERSE(GatePassNo))))AS Integer)) From GatePass Where GatePassNo Like '" & ABC & "%'", cnn)

        'KPNo = DT.Year.ToString.Substring(2) & "C" & (Val(XYZ) + 1).ToString()

        Me.GatePassDataSet.GatePass.GatePassNoColumn.DefaultValue = DT.Year.ToString.Substring(2) & "SG" & (Val(XYZ) + 1).ToString()
        Me.GatePassDataSet.GatePass.GatepassDateColumn.DefaultValue = DT

        Try
            Me.GatePassBindingSource.AddNew()
            Me.Validate()
            Me.GatePassBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.GatePassDataSet)
            Me.GatePassLookupTableAdapter.Fill(Me.GatePassDataSet.GatePassLookup)

            Dim row As GatePassDataSet.GatePassRow
            row = CType(CType(Me.GatePassBindingSource.Current, DataRowView).Row, GatePassDataSet.GatePassRow)

            GridLookUpEdit1.EditValue = row.GatePassId

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try



    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        Me.GatePassTableAdapter.FillByGatePassId(Me.GatePassDataSet.GatePass, GridLookUpEdit1.EditValue)
        Me.GatePassDetailsTableAdapter.Fill(Me.GatePassDataSet.GatePassDetails, GridLookUpEdit1.EditValue)
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click


        If GridLookUpEdit1.Text = String.Empty Then

            MessageBox.Show("Type GatePass No ", "Missing Gate Pass No", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            Me.GatePassTableAdapter.FillByGatePassId(Me.GatePassDataSet.GatePass, GridLookUpEdit1.EditValue)


            With frmGatePassPrint

                .MdiParent = frmMain
                .GatePassId = GridLookUpEdit1.EditValue
                .WindowState = FormWindowState.Maximized
                .Show()

            End With

        End If




    End Sub

   
End Class