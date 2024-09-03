Public Class frmStyleCapture_Fabric

    Private _StyleId As Long
    Public Property StyleId() As Long
        Get
            Return _StyleId
        End Get
        Set(ByVal value As Long)
            _StyleId = value
        End Set
    End Property

    

    Private Sub frmStyleCapture_Fabric_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.DyeingTypeTableAdapter.Fill(Me.DyeingTypeDataSet.DyeingType)

        Me.StyleCapture_FinishingTableAdapter.Fill(Me.StyleCaptureFabricDataSet.StyleCapture_Finishing)

        Me.FabricFinishingTypeTableAdapter.Fill(Me.FabricFinishingTypeDataSet.FabricFinishingType)


        LoadData()

        'If StyleLookupGridLookUpEdit.EditValue > -1 Then
        '    StyleLookupGridLookUpEdit.EditValue =
        'End If

        If DBNull.Value.Equals(Me.StyleId) = False Then

            Me.StyleLookupGridLookUpEdit.EditValue = Me.StyleId
            Me.StyleCaptureFabricDataSet.StyleCapture_Fabric.StyleIdColumn.DefaultValue = Me.StyleId
            Me.StyleCapture_FabricTableAdapter.Fill(Me.StyleCaptureFabricDataSet.StyleCapture_Fabric, Me.StyleId)

        End If


    End Sub

   
    Private Sub StyleLookupGridLookUpEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StyleLookupGridLookUpEdit.EditValueChanged

        If StyleLookupGridLookUpEdit.EditValue > -1 Then

            Me.StyleCaptureFabricDataSet.StyleCapture_Fabric.StyleIdColumn.DefaultValue = StyleLookupGridLookUpEdit.EditValue
            Me.StyleCapture_FabricTableAdapter.Fill(Me.StyleCaptureFabricDataSet.StyleCapture_Fabric, StyleLookupGridLookUpEdit.EditValue)

        End If

    End Sub

    Private Sub LoadData()
        Me.UnitTableAdapter.Fill(Me.UnitDataSet.Unit)
        Me.ItemListTableAdapter.Fill(Me.ItemListLookupDataSet.ItemList, 8)
        Me.StyleTableAdapter.Fill(Me.StyleLookupDataSet.Style)
        Me.GSMTableAdapter.Fill(Me.GSMDataSet.GSM)
        Me.GarmentsPartTableAdapter.Fill(Me.GarmentsPartDataSet.GarmentsPart)
        Me.CompositionTableAdapter.FillByContinueItem(Me.CompositionDataSet.Composition)
        Me.KnittingTypeTableAdapter.FillByContinueItem(Me.KnittingTypeDataSet.KnittingType)
        Me.StyleCapture_YarnTableAdapter.Fill(Me.StyleCaptureFabricDataSet.StyleCapture_Yarn)
    End Sub

    
    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub NewButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewButton.Click

        If StyleLookupGridLookUpEdit.EditValue > -1 Then
            Me.StyleCapture_FabricBindingSource.AddNew()
        Else
            MessageBox.Show("Select Style.")

        End If


    End Sub

    Private Sub DeleteButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteButton.Click
        StyleCapture_FabricBindingSource.RemoveCurrent()
    End Sub

    Private Sub SaveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveButton.Click
        Save()

        For Each drv As DataRowView In StyleCapture_FabricBindingSource.List
            Dim Ycount As Integer = ReadIntData("Select Count(*) From StyleCapture_Yarn Where StyleCapture_FabricId=" & drv!StyleCapture_FabricId, cnn)
            If Ycount > 0 Then
                drv!IsYarnAllocated = True
            Else
                drv!IsYarnAllocated = False
            End If
        Next

        Save()
        

    End Sub

    Private Sub Save()
        Try
            Me.Validate()
            Me.StyleCapture_FabricBindingSource.EndEdit()
            Me.StyleCapture_YarnBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.StyleCaptureFabricDataSet)
            CalcCon()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub RefreshButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshButton.Click
        LoadData()
    End Sub

    Private Sub GridView1_RowCellStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)


        If e.Column.Caption = "Yarn Allocated" Then

            If DBNull.Value.Equals(e.CellValue) = False Then

                If e.CellValue = False Then
                    e.Appearance.BackColor = Color.Red
                    e.Appearance.ForeColor = Color.Yellow
                Else
                    e.Appearance.BackColor = Color.White
                    e.Appearance.ForeColor = Color.Black

                End If


            End If

        End If
    End Sub

    Private Sub GridView4_CellValueChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs)
        On Error Resume Next

        Dim row As StyleCaptureFabricDataSet.StyleCapture_FinishingRow
        row = CType(CType(Me.StyleCapture_FinishingBindingSource.Current, DataRowView).Row, StyleCaptureFabricDataSet.StyleCapture_FinishingRow)

        row.PricePerKg = ReadData("Select PricePerKg From FabricFinishingType Where FinishingTypeId=" & row.FinishingTypeId, cnn)

    End Sub

    Private Sub CalcCon()

        For Each drv As DataRowView In Me.StyleCapture_FabricBindingSource.List

            On Error Resume Next


            Dim Consumption As Decimal

            'Dim row As StyleCaptureFabricDataSet.StyleCapture_FabricRow
            'row = CType(CType(Me.StyleCapture_FabricBindingSource.Current, DataRowView).Row, StyleCaptureFabricDataSet.StyleCapture_FabricRow)


            Dim DType As String = ""
            DType = Trim(drv!DiaType.ToString())

            'MessageBox.Show(DType.ToString() & drv!Dia.ToString())

            If Trim(DType) = "Open" Then
                drv!Dia = drv!MarkerWidth + drv!WidthAllowance
            ElseIf Trim(DType) = "Tube" Then
                drv!Dia = (drv!MarkerWidth + drv!WidthAllowance) / 2
            End If


            Dim Length As Decimal = CDec(drv!MarkerLengthYrds) * 36 + CDec(drv!MarkerLengthInch) + drv!LengthAllowance
            Dim Width As Decimal = CDec(drv!MarkerWidth) + CDec(drv!WidthAllowance)
            Dim GSM As Decimal = ReadData("Select GSM From GSM Where GSMId=" & drv!GSMId, cnn)
            Dim MarkerQuantity As Decimal = drv!GarmentsQuantity
            Dim WP As Decimal = (1 + drv!WastagePercentage / 100)




            Consumption = Length * Width * GSM / MarkerQuantity * 12 / 1550 / 1000 * WP

            If Consumption > 0 Then
                drv!Consumption = Consumption
            End If

        Next

    End Sub
End Class