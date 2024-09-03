Imports System.Data.SqlClient

Public Class frmFabricCostingMaster

    Private Sub FabricCostingMasterBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FabricCostingMasterBindingNavigatorSaveItem.Click

        Try
            Me.Validate()
            Me.FabricCostingMasterBindingSource.EndEdit()
            Me.FabricCostingMasterDetailsBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.FabricCostingMasterDataSet)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
       

    End Sub

    Private Sub frmFabricCostingMaster_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Me.ItemListLookupTableAdapter.Fill(Me.ItemListDataSet.ItemListLookup, 8)
        Me.CompositionTableAdapter.FillByContinueItem(Me.CompositionDataSet.Composition)
        Me.KnittingTypeTableAdapter.FillByContinueItem(Me.KnittingTypeDataSet.KnittingType)
        Me.FabricCostingMasterDetailsTableAdapter.Fill(Me.FabricCostingMasterDataSet.FabricCostingMasterDetails)
        Me.FabricCostingMasterTableAdapter.Fill(Me.FabricCostingMasterDataSet.FabricCostingMaster)


        With DyeingTypeItemLookUpEdit

            .DataSource = GetDeyingTypeTable()
            .DisplayMember = "DyeingType"
            .ValueMember = "DyeingTypeId"
            .ForceInitialize() ' Force it to initialize
            .PopulateColumns() ' Force the lookupedit to populate
            .Columns("DyeingTypeId").Visible = False

        End With


        With GSMLookUpEdit

            .DataSource = GetGSM()
            .DisplayMember = "GSM"
            .ValueMember = "GSMId"
            .ForceInitialize() ' Force it to initialize
            .PopulateColumns() ' Force the lookupedit to populate
            .Columns("GSMId").Visible = False

        End With


        If CheckUserRights("Fabric Costing Master").CanEdit = False Then

            BindingNavigatorAddNewItem.Enabled = False
            FabricCostingMasterBindingNavigatorSaveItem.Enabled = False
            BindingNavigatorDeleteItem.Enabled = False

        ElseIf CheckUserRights("Fabric Costing Master").CanDelete = False Then
            BindingNavigatorAddNewItem.Enabled = True
            FabricCostingMasterBindingNavigatorSaveItem.Enabled = True
            BindingNavigatorDeleteItem.Enabled = False

        End If



    End Sub

End Class