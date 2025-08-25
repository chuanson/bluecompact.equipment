Imports System.Data.SQLite
Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.Controls
Imports DevComponents.DotNetBar.SuperGrid
Imports DevComponents.DotNetBar.SuperGrid.Style

Public Class usercon_find_equipment

    ' สร้าง Property เพื่อรับค่าจากฟอร์มหลัก
    Public Property ConnectionString As String
    Public Property UserID As String
    Public Property WarehouseID As String

    ' *********************************************************************'
    ' ฟังชั่นการดึงข้อมูลฐานข้อมูล
    ' *********************************************************************'

    Private Sub usercon_find_equipment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        load_Items()
    End Sub

    Private Sub load_Items()
        ' ดึงข้อมูลจาก SQL Server
        Dim query As String = "SELECT * FROM vw_ItemStockBalance_ByLocation WHERE WarehouseID = @WarehouseID ORDER BY LocationName ASC, ItemCode ASC"
        Dim resultTable As New DataTable()

        Try
            Using connection As New SQLiteConnection(ConnectionString)
                connection.Open()
                Using command As New SQLiteCommand(query, connection)
                    command.Parameters.AddWithValue("@WarehouseID", WarehouseID)

                    Using adapter As New SQLiteDataAdapter(command)
                        adapter.Fill(resultTable)

                        ' แทนค่า NULL/ว่าง ด้วย " - "
                        For Each row As DataRow In resultTable.Rows
                            For Each col As DataColumn In resultTable.Columns
                                If row.IsNull(col) OrElse String.IsNullOrWhiteSpace(row(col).ToString()) Then
                                    row(col) = " - "
                                End If
                            Next
                        Next

                        ' ตั้งค่า SuperGridControl
                        SuperGridView_Items.PrimaryGrid.DataSource = resultTable
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("เกิดข้อผิดพลาด: " & ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        AddHandler SuperGridView_Items.DataBindingComplete, AddressOf gridview_ItemsDataBindingComplete
    End Sub

    Private Sub gridview_ItemsDataBindingComplete(ByVal sender As Object, ByVal e As GridDataBindingCompleteEventArgs)
        For Each col As DevComponents.DotNetBar.SuperGrid.GridColumn In SuperGridView_Items.PrimaryGrid.Columns
            col.Visible = True
        Next

        ' แทนที่หัวคอลัมน์
        With SuperGridView_Items.PrimaryGrid
            .Columns("LocationName").HeaderText = "ตำแหน่ง"
            .Columns("ItemCode").HeaderText = "รหัส"
            .Columns("ItemName").HeaderText = "ชื่อ"
            .Columns("BrandName").HeaderText = "ยี่ห้อ"
            .Columns("ModelName").HeaderText = "รุ่น"
            .Columns("MaterialTypeNameTH").HeaderText = "ประเภทวัสดุ"
            .Columns("CategoryName").HeaderText = "หมวดหมู่"
            .Columns("SubCategoryName").HeaderText = "หมวดหมู่ย่อย"
            .Columns("StandardCode").HeaderText = "มาตรฐาน"
            .Columns("SupplierName").HeaderText = "ผู้จำหน่าย"

            ' ค่ารวมการเคลื่อนไหว
            .Columns("TotalStockIn").HeaderText = "รวมรับเข้า"
            .Columns("TotalStockOut").HeaderText = "รวมเบิกออก"
            .Columns("TotalTransferIn").HeaderText = "รวมโอนเข้า"
            .Columns("TotalTransferOut").HeaderText = "รวมโอนออก"
            .Columns("TotalAdjustment").HeaderText = "รวมปรับปรุงสต๊อก"

            ' คงเหลือ
            .Columns("CurrentStock").HeaderText = "สต๊อกคงเหลือ"
            .Columns("QuantityUnit").HeaderText = "หน่วยนับ"

            ' ซ่อน
            .Columns("WarehouseID").Visible = False
            .Columns("WarehouseName").Visible = False
            .Columns("LocationID").Visible = False
            .Columns("ItemID").Visible = False
            .Columns("TotalStockIn").Visible = False
            .Columns("TotalStockOut").Visible = False
            .Columns("TotalTransferIn").Visible = False
            .Columns("TotalTransferOut").Visible = False
            .Columns("TotalAdjustment").Visible = False
        End With

        ' นับจำนวนแถวใน SuperGridView
        supergrid_Module.GridView_RowCount(SuperGridView_Items)
    End Sub

    Private Sub CheckBoxItem_ShowStockInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxItem_ShowStockInfo.Click
        Dim grid As GridPanel = SuperGridView_Items.PrimaryGrid

        ' รายชื่อคอลัมน์ที่จะควบคุม
        Dim detailColumns As String() = {"TotalStockIn", "TotalStockOut", "TotalTransferIn", "TotalTransferOut", "TotalAdjustment"}

        For Each colName In detailColumns
            If grid.Columns.Contains(colName) Then
                grid.Columns(colName).Visible = CheckBoxItem_ShowStockInfo.Checked
            End If
        Next
    End Sub

    ' จัดเรียงโดยคอลัมน์
    Private Sub SortColumnAscending(ByVal columnName As String)
        Dim gridPanel As GridPanel = SuperGridView_Items.PrimaryGrid

        ' ค้นหาคอลัมน์ที่ต้องการจัดเรียง
        Dim column As GridColumn = gridPanel.Columns(columnName)

        ' ตรวจสอบว่าคอลัมน์มีอยู่หรือไม่
        If column IsNot Nothing Then
            ' ตั้งค่าการเรียงลำดับจากน้อยไปมาก (Ascending)
            gridPanel.SetSort(column, SortDirection.Ascending)
        End If
    End Sub

    Private Sub SuperGridView_Items_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Delete Then
            'delete_Items()
        ElseIf e.KeyCode = Keys.F5 Then
            load_Items()
        End If
    End Sub

    ' *********************************************************************'
    ' ฟังก์ชั่นการทำงาน
    ' *********************************************************************'

    ' ฟังก์ชั่นการค้นหาพนักงาน
    Private Sub SearchInRows(ByVal rows As IEnumerable(Of DevComponents.DotNetBar.SuperGrid.GridElement), ByVal searchText As String)
        For Each row As DevComponents.DotNetBar.SuperGrid.GridElement In rows
            If TypeOf row Is DevComponents.DotNetBar.SuperGrid.GridRow Then
                ' ถ้าเป็นแถวปกติ ให้ตรวจสอบค่าภายในเซลล์
                Dim gridRow As DevComponents.DotNetBar.SuperGrid.GridRow = CType(row, DevComponents.DotNetBar.SuperGrid.GridRow)
                gridRow.Visible = gridRow.Cells("EmpCode").Value.ToString().ToLower().Contains(searchText) OrElse
                                  gridRow.Cells("EmpName").Value.ToString().ToLower().Contains(searchText)
            ElseIf TypeOf row Is DevComponents.DotNetBar.SuperGrid.GridGroup Then
                ' ถ้าเป็นกลุ่ม ให้ตรวจสอบใน Child Rows
                Dim gridGroup As DevComponents.DotNetBar.SuperGrid.GridGroup = CType(row, DevComponents.DotNetBar.SuperGrid.GridGroup)
                SearchInRows(gridGroup.Rows, searchText)

                ' ตรวจสอบว่ากลุ่มนี้มีแถวที่มองเห็นได้หรือไม่
                gridGroup.Visible = gridGroup.Rows.Cast(Of DevComponents.DotNetBar.SuperGrid.GridElement)().Any(Function(r) r.Visible)
            End If
        Next
    End Sub

End Class
