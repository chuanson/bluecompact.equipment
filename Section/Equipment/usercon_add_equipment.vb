Imports System.IO
Imports System.Data.SQLite
Imports ZXing
Imports System.Text.RegularExpressions
Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.Controls
Imports DevComponents.DotNetBar.SuperGrid
Imports DevComponents.DotNetBar.SuperGrid.Style

Public Class usercon_add_equipment

    ' สร้าง Property เพื่อรับค่าจากฟอร์มหลัก
    Public Property ConnectionString As String
    Public Property UserID As String
    Public Property WarehouseID As String

    Dim imageData As Byte()
    Dim imageBytes As Byte()
    Dim imageSelected As Byte()

    Private Sub usercon_add_equipment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Load_Combobox()
        Create_ItemCode()
    End Sub

    ' เพิ่มรายการใน ComboBox
    Private Sub Load_Combobox()
        LoadComboBoxData(ComboBox_Categories, ConnectionString, "SELECT CategoryID, CategoryName FROM Categories", "CategoryName", "CategoryID")
        LoadComboBoxData_WithNull(ComboBox_StandardCode, ConnectionString, "SELECT StandardID, StandardCode FROM Standards", "StandardCode", "StandardID", "ไม่ระบุ")
        LoadComboBoxData_WithNull(ComboBox_MeasurementUnit, ConnectionString, "SELECT MeasurementUnitID, Description FROM MeasurementUnits", "Description", "MeasurementUnitID", "ไม่ระบุ")
        LoadComboBoxData_WithNull(ComboBox_MaterialType, ConnectionString, "SELECT MaterialTypeID, MaterialTypeNameTH FROM MaterialTypes", "MaterialTypeNameTH", "MaterialTypeID", "ไม่ระบุ")
        LoadComboBoxData_WithNull(ComboBox_QuantityUnit, ConnectionString, "SELECT QuantityUnitID, Description FROM QuantityUnits", "Description", "QuantityUnitID", "ไม่ระบุ")
        LoadComboBoxData_WithNull(ComboBox_Brand, ConnectionString, "SELECT BrandID, BrandName FROM Brands", "BrandName", "BrandID", "ไม่ระบุ")
        LoadComboBoxData_WithNull(ComboBox_Model, ConnectionString, "SELECT ModelID, ModelName FROM Models", "ModelName", "ModelID", "ไม่ระบุ")

        ' ล้างข้อมูล SubCategory ก่อน
        ComboBox_SubCategories.DataSource = Nothing
    End Sub

    Private Sub ComboBox_Categories_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox_Categories.SelectedIndexChanged
        If ComboBox_Categories.SelectedValue Is Nothing OrElse
           TypeOf ComboBox_Categories.SelectedValue Is DataRowView Then
            Exit Sub
        End If

        Dim CategoryID As Integer = Convert.ToInt32(ComboBox_Categories.SelectedValue)

        ' ล้างข้อมูล SubCategory ก่อน
        ComboBox_SubCategories.DataSource = Nothing

        ' โหลดข้อมูล SubCategory ตาม Category ที่เลือก
        LoadComboBoxData(ComboBox_SubCategories, ConnectionString, "SELECT SubCategoryID, SubCategoryName FROM SubCategories WHERE CategoryID = '" & CategoryID & "'", "SubCategoryName", "SubCategoryID")
    End Sub

    ' สร้างข้อมูลพนักงานใหม่
    Private Sub Create_ItemCode()
        Using connection As New SQLiteConnection(ConnectionString)
            Try
                connection.Open()
                Dim sqlQuery As String = "SELECT ItemCode FROM Items WHERE ItemCode LIKE 'ITEM-%'"
                Dim command As New SQLiteCommand(sqlQuery, connection)
                Dim reader As SQLiteDataReader = command.ExecuteReader()

                Dim maxx As Integer = 0

                While reader.Read()
                    Dim currentID As String = reader("ItemCode").ToString()
                    Dim numberPart As Integer = Val(currentID.Replace("ITEM-", ""))
                    If numberPart > maxx Then
                        maxx = numberPart
                    End If
                End While

                reader.Close()
                Dim new_EmpCode As String = "ITEM-" & (maxx + 1).ToString("0000000")
                TextBox_ItemCode.Text = new_EmpCode
                barcode_Module.GenerateBarcode_Warehouse(new_EmpCode, PictureBox_BarcodeWarehouse)
            Catch ex As Exception
                TextBox_ItemCode.Text = "ITEM-0000001"
                barcode_Module.GenerateBarcode_Warehouse("ITEM-0000001", PictureBox_BarcodeWarehouse)
            End Try
        End Using
    End Sub

    Private Sub Button_ItemCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_ItemCreate.Click
        ' กำหนดค่า Combobox
        Dim CategoriesID As String = ComboBox_Categories.SelectedValue.ToString()
        Dim SubCategoryID As String = ComboBox_SubCategories.SelectedValue.ToString()
        Dim BrandID As String = If(ComboBox_Brand.SelectedValue IsNot Nothing, ComboBox_Brand.SelectedValue.ToString(), DBNull.Value)
        Dim ModelID As String = If(ComboBox_Model.SelectedValue IsNot Nothing, ComboBox_Model.SelectedValue.ToString(), DBNull.Value)
        Dim MaterialTypeID As String = If(ComboBox_MaterialType.SelectedValue IsNot Nothing, ComboBox_MaterialType.SelectedValue.ToString(), DBNull.Value)
        Dim QuantityUnitID As String = If(ComboBox_QuantityUnit.SelectedValue IsNot Nothing, ComboBox_QuantityUnit.SelectedValue.ToString(), "1")
        Dim MeasurementUnitID As String = If(ComboBox_MeasurementUnit.SelectedValue IsNot Nothing, ComboBox_MeasurementUnit.SelectedValue.ToString(), DBNull.Value)
        Dim StandardID As String = If(ComboBox_StandardCode.SelectedValue IsNot Nothing, ComboBox_StandardCode.SelectedValue.ToString(), DBNull.Value)

        ' กำหนดคำสั่ง SQL
        Dim sql As String = "INSERT INTO Items (" & _
            "ItemCode, " & _
            "ItemName, " & _
            "CategoryID, " & _
            "SubCategoryID, " & _
            "BrandID, " & _
            "ModelID, " & _
            "MaterialTypeID, " & _
            "QuantityUnitID, " & _
            "MeasurementValue, " & _
            "MeasurementUnitID, " & _
            "StandardID, " & _
            "BarcodePOS, " & _
            "Remark, " & _
            "ItemPicture) " & _
            "VALUES (" & _
            "@ItemCode, " & _
            "@ItemName, " & _
            "@CategoryID, " & _
            "@SubCategoryID, " & _
            "@BrandID, " & _
            "@ModelID, " & _
            "@MaterialTypeID, " & _
            "@QuantityUnitID, " & _
            "@MeasurementValue, " & _
            "@MeasurementUnitID, " & _
            "@StandardID, " & _
            "@BarcodePOS, " & _
            "@Remark, " & _
            "@ItemPicture)"

        Try
            Using connection As New SQLiteConnection(ConnectionString)
                Using Command As New SQLiteCommand(sql, connection)
                    ' เพิ่มพารามิเตอร์พร้อมค่า
                    Command.Parameters.Add("@ItemCode", DbType.String).Value = TextBox_ItemCode.Text
                    Command.Parameters.Add("@ItemName", DbType.String).Value = TextBox_ItemName.Text
                    Command.Parameters.Add("@CategoryID", DbType.String).Value = CategoriesID
                    Command.Parameters.Add("@SubCategoryID", DbType.String).Value = SubCategoryID
                    Command.Parameters.Add("@BrandID", DbType.String).Value = BrandID
                    Command.Parameters.Add("@ModelID", DbType.String).Value = ModelID
                    Command.Parameters.Add("@MaterialTypeID", DbType.String).Value = MaterialTypeID
                    Command.Parameters.Add("@QuantityUnitID", DbType.String).Value = QuantityUnitID
                    Command.Parameters.Add("@MeasurementValue", DbType.Double).Value = DoubleInput_MeasurementValue.Value
                    Command.Parameters.Add("@MeasurementUnitID", DbType.String).Value = MeasurementUnitID
                    Command.Parameters.Add("@StandardID", DbType.String).Value = StandardID
                    Command.Parameters.Add("@BarcodePOS", DbType.String).Value = TextBox_BarcodePOS.Text
                    Command.Parameters.Add("@Remark", DbType.String).Value = RichTextBox_Remark.Text

                    ' รูปภาพ
                    Dim finalImageData As Byte()
                    If imageData IsNot Nothing Then
                        finalImageData = imageData
                    ElseIf imageBytes IsNot Nothing Then
                        finalImageData = imageBytes
                    Else
                        finalImageData = Nothing
                    End If

                    Command.Parameters.Add("@ItemPicture", DbType.Binary).Value = If(finalImageData Is Nothing, DBNull.Value, finalImageData)

                    ' เปิดการเชื่อมต่อและเพิ่มข้อมูล
                    connection.Open()
                    Command.ExecuteNonQuery()

                    alert_Module.SuccessDialog_Show("การดำเนินการเสร็จสิ้น", "บันทึกข้อมูลเรียบร้อยแล้ว", "แจ้งเตือน")
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("เกิดข้อผิดพลาด: " & ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' *********************************************************************'
    ' ฟังชั่นการเพิ่ม แก้ไข ดูรูปภาพ
    ' *********************************************************************'

    ' ฟังก์ชันสำหรับแปลง Image เป็น Byte Array
    Private Function ConvertImageToByteArray(ByVal image As Image) As Byte()
        ' สร้างสำเนาภาพก่อนเพื่อหลีกเลี่ยงปัญหาล็อก
        Using tempImage As New Bitmap(image)
            Using ms As New MemoryStream()
                tempImage.Save(ms, Imaging.ImageFormat.Jpeg) ' บันทึกภาพเป็น JPEG
                Return ms.ToArray() ' แปลงเป็น Byte Array
            End Using
        End Using
    End Function

    Private Sub ButtonItem_PictureChooseFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem_PictureChooseFile.Click
        Dim dlgImage As OpenFileDialog = New OpenFileDialog()

        ' / Open File Dialog
        With dlgImage
            .Title = "Select images"
            .Filter = "Images types (*.jpg;*.png;*.gif;*.bmp)|*.jpg;*.png;*.gif;*.bmp"
            .FilterIndex = 1
            .RestoreDirectory = True
        End With

        ' Select OK after Browse ...
        If dlgImage.ShowDialog() = DialogResult.OK Then
            ' แสดงรูปภาพที่เลือก
            PictureBox_ItemPicture.Image = Image.FromFile(dlgImage.FileName)

            ' แปลงรูปภาพเป็น Byte Array
            Using ms As New MemoryStream()
                PictureBox_ItemPicture.Image.Save(ms, Imaging.ImageFormat.Jpeg)
                imageData = ms.ToArray()
            End Using
        End If
    End Sub

    Private Sub ButtonItem_PictureRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem_PictureRemove.Click
        PictureBox_ItemPicture.Image = Nothing
        imageBytes = Nothing
    End Sub

    ' ฟังก์ชันคำนวณ Checksum ของ EAN-13
    Private Function CalculateEAN13Checksum(ByVal code As String) As Integer
        If code.Length <> 12 Then
            Throw New ArgumentException("ต้องมี 12 หลัก")
        End If

        Dim sum As Integer = 0
        For i As Integer = 0 To 11
            Dim digit As Integer = Integer.Parse(code(i).ToString())
            If (i Mod 2 = 0) Then
                sum += digit
            Else
                sum += digit * 3
            End If
        Next
        Dim checksum As Integer = (10 - (sum Mod 10)) Mod 10
        Return checksum
    End Function

    ' จำกัดให้พิมพ์ได้ไม่เกิน 12 หลัก
    Private Sub TextBox_BarcodePOS_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles TextBox_BarcodePOS.KeyPress
        If Char.IsControl(e.KeyChar) Then
            Return
        End If

        If Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
            Return
        End If

        ' จำกัดแค่ 12 หลัก (ยังไม่รวม checksum)
        If TextBox_BarcodePOS.Text.Length >= 12 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox_Barcode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox_BarcodePOS.TextChanged
        Dim inputText As String = TextBox_BarcodePOS.Text.Trim()

        If inputText.Length = 12 Then
            Try
                Dim checksum As Integer = CalculateEAN13Checksum(inputText)
                TextBox_BarcodePOS.Text = inputText & checksum.ToString()
                ' สร้าง Barcode EAN-13
                barcode_Module.GenerateBarcode_POS(TextBox_BarcodePOS.Text, PictureBox_BarcodePOS)
            Catch ex As Exception
                PictureBox_BarcodePOS.Image = Nothing
                Return
            End Try
        End If
    End Sub
End Class
