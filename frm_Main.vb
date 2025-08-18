Public Class frm_Main

    Private Sub frm_Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    ' ฟังก์ชันสำหรับเพิ่ม Tab ใหม่ใน TabControl
    Private Sub OpenNewTab(ByVal userControl As UserControl, ByVal tabName As String)
        ' ตรวจสอบว่าแท็บนี้เปิดอยู่หรือไม่
        For Each tab As DevComponents.DotNetBar.TabItem In TabControl_Main.Tabs
            If tab.Text = tabName Then
                ' หากมีแท็บนี้อยู่แล้ว ให้เลือกแท็บนั้น
                TabControl_Main.SelectedTab = tab
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
        TabControl_Main.SelectedTab = newTab

        ' ตั้งค่าคุณสมบัติของ TabControlPanel
        newTabPanel.Dock = DockStyle.Fill
        newTabPanel.TabItem = newTab

        ' ตั้งค่า UserControl ให้เต็มพื้นที่
        userControl.Dock = DockStyle.Fill

        ' เพิ่ม Panel และ Tab เข้าใน TabControl
        TabControl_Main.Controls.Add(newTabPanel)
        TabControl_Main.Tabs.Add(newTab)

        ' ตั้งค่า Panel ให้ตรงกับ Tab ใหม่
        newTab.AttachedControl = newTabPanel

        ' เพิ่ม UserControl ลงใน TabControlPanel
        newTabPanel.Controls.Add(userControl)
    End Sub

    Private Sub ButtonItem32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem32.Click
        Dim UserControl_Employee As New usercon_find_equipment
        'UserControl_Employee.ConnectionString = ConnectionString
        'UserControl_Employee.UserID = UserID
        OpenNewTab(UserControl_Employee, "ค้นหารายการ")
    End Sub
End Class
