Imports System.Data.SQLite
Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.Controls
Imports DevComponents.DotNetBar.SuperGrid
Imports DevComponents.DotNetBar.SuperGrid.Style

Public Class usercon_add_equipment

    ' สร้าง Property เพื่อรับค่าจากฟอร์มหลัก
    Public Property ConnectionString As String

    Private Sub usercon_add_equipment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Load_Combobox()
    End Sub

    ' เพิ่มรายการใน ComboBox
    Private Sub Load_Combobox()
        LoadComboBoxData(ComboBox_Categories, ConnectionString, "SELECT CategoryID, CategoryName FROM Categories", "CategoryName", "CategoryID")
        LoadComboBoxData(ComboBox_SubCategories, ConnectionString, "SELECT SubCategoryID, SubCategoryName FROM SubCategories", "SubCategoryName", "SubCategoryID")
        LoadComboBoxData(ComboBox_StandardCode, ConnectionString, "SELECT StandardID, StandardCode FROM Standards", "StandardCode", "StandardID")
        LoadComboBoxData(ComboBox_MeasurementUnit, ConnectionString, "SELECT MeasurementUnitID, Description FROM MeasurementUnits", "Description", "MeasurementUnitID")
        LoadComboBoxData(ComboBox_MaterialType, ConnectionString, "SELECT MaterialTypeID, MaterialTypeNameTH FROM MaterialTypes", "MaterialTypeNameTH", "MaterialTypeID")
        LoadComboBoxData(ComboBox_QuantityUnit, ConnectionString, "SELECT QuantityUnitID, Description FROM QuantityUnits", "Description", "QuantityUnitID")
        LoadComboBoxData(ComboBox_Brand, ConnectionString, "SELECT BrandID, BrandName FROM Brands", "BrandName", "BrandID")
        LoadComboBoxData(ComboBox_Model, ConnectionString, "SELECT ModelID, ModelName FROM Models", "ModelName", "ModelID")
    End Sub
End Class
