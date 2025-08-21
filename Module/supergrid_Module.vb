Imports DevComponents.DotNetBar.SuperGrid

Module supergrid_Module
    ' ฟังก์ชันสำหรับนับจำนวนแถวใน SuperGridView
    Public Sub GridView_RowCount(ByRef Griview As SuperGridControl)
        Dim totalRows As Integer = Griview.PrimaryGrid.Rows.Count

        ' แสดงผลจำนวนรายการที่ถูกค้นหา
        Griview.PrimaryGrid.Footer.Text = "จำนวนทั้งหมด : " & totalRows & " รายการ"
    End Sub

    ' ฟังก์ชันสำหรับนับจำนวนแถวใน SuperGridView (VisibleRowCount)
    Public Sub GridView_VisibleRowCount(ByRef Griview As SuperGridControl)
        Dim totalRows As Integer = Griview.PrimaryGrid.VisibleRowCount

        ' แสดงผลจำนวนรายการที่ถูกค้นหา
        Griview.PrimaryGrid.Footer.Text = "จำนวนทั้งหมด : " & totalRows & " รายการ"
    End Sub
End Module
