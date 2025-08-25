Imports System.IO
Imports System.Xml.Linq
Imports System.Data.SQLite
Public Class frm_Main

    Dim ConnectionString As String
    Dim WarehouseID As String

    Private Sub frm_Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' load_Database()
        ConnectionString = "Data Source=" & Application.StartupPath & "\Database\dbEquipment.db;Version=3;"
    End Sub

    ' ฟังก์ชันสำหรับเพิ่ม Tab ใหม่ใน TabControl
    Private Sub OpenNewTab(ByVal userControl As UserControl, ByVal tabName As String)
        ' ตรวจสอบว่าแท็บนี้เปิดอยู่หรือไม่
        For Each tab As DevComponents.DotNetBar.TabItem In tabcontrol_Main.Tabs
            If tab.Text = tabName Then
                ' หากมีแท็บนี้อยู่แล้ว ให้เลือกแท็บนั้น
                tabcontrol_Main.SelectedTab = tab
                Return
            End If
        Next

        ' สร้าง Tab ใหม่
        Dim newTab As New DevComponents.DotNetBar.TabItem()
        Dim newTabPanel As New DevComponents.DotNetBar.TabControlPanel()

        ' ตั้งค่าชื่อและข้อความของ TabItem
        newTab.Text = tabName
        newTab.Name = "tab_" & tabName

        ' สลับไปที่ Tab ใหม่
        tabcontrol_Main.SelectedTab = newTab

        ' ตั้งค่าคุณสมบัติของ TabControlPanel
        newTabPanel.Dock = DockStyle.Fill
        newTabPanel.TabItem = newTab

        ' ตั้งค่า UserControl ให้เต็มพื้นที่
        userControl.Dock = DockStyle.Fill

        ' เพิ่ม Panel และ Tab เข้าใน TabControl
        tabcontrol_Main.Controls.Add(newTabPanel)
        tabcontrol_Main.Tabs.Add(newTab)

        ' ตั้งค่า Panel ให้ตรงกับ Tab ใหม่
        newTab.AttachedControl = newTabPanel

        ' เพิ่ม UserControl ลงใน TabControlPanel
        newTabPanel.Controls.Add(userControl)
    End Sub

    Private Sub ButtonItem_FindItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem_FindItem.Click
        Dim UserControl As New usercon_find_equipment
        UserControl.ConnectionString = ConnectionString
        WarehouseID = "1"
        UserControl.WarehouseID = WarehouseID
        OpenNewTab(UserControl, "ค้นหารายการ")
    End Sub

    Private Sub ButtonItem_AddItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem_AddItem.Click
        Dim UserControl As New usercon_add_equipment
        UserControl.ConnectionString = ConnectionString
        OpenNewTab(UserControl, "สร้างรายการใหม่")
    End Sub
End Class
