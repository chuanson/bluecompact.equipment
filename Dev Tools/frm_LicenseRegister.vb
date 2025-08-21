Public Class frm_LicenseRegister

    Private Sub frm_Start_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        load_UserZone()
        load_GeneratorZone()
    End Sub

    ' ******* User *******

    Dim AppTitle As String = "Blue Compact"
    Dim SectionName As String = "Payroll"
    Dim ProductID As Int32
    Dim LicenseKey As String
    Dim UserEncryptionKey As String = "5332B737-76F5-4B83-AE7C-0D2E6BD5A586"
    Dim Register_Result As Boolean

    Private Sub load_UserZone()
        ' รับค่า Drive Volume SerialNumber เพื่อใช้เป็น Product ID
        Dim GetProductID As Int32 = GetDriveVolumeSerialNumber()
        tbox_UserProductID.Text = GetProductID
        ' อ่านค่า License Key จาก Registry
        Dim ReadLicenseKey As String = ReadAppRegistry(SectionName, "LicenseKey", "")
        ' เข้ารหัส Product ID (Drive Volume Serial Number) ร่วมกับ Encryption Key (กุญแจ)
        Dim ActivateKey As String = EncryptLicenseKey(GetProductID, UserEncryptionKey)

        ' เปรียบเทียบค่าที่ได้ (Activate Key) และค่าที่อ่านจาก Registry
        If ActivateKey = ReadLicenseKey Then
            ' ลงทะเบียนแล้ว
            lb_LicenseStatus.Text = "License : Full Verion"
            tbox_InputLicenseKey.Text = ReadLicenseKey
            tbox_InputLicenseKey.Enabled = False
            btn_LicenseRegister.Enabled = False
        Else
            ' ไม่ลงทะเบียน
            lb_LicenseStatus.Text = "License : Demo"
            tbox_InputLicenseKey.Focus()
        End If

        ' Background
        tbox_UserEncryptionKey.Text = UserEncryptionKey
        tbox_DriveVolumeSerialNumber.Text = GetDriveVolumeSerialNumber()
    End Sub

    Private Function GetDriveVolumeSerialNumber() As String
        Dim DriveSerial As Long
        Dim FSO As Object, Drv As Object
        '/ Create a FileSystemObject object
        FSO = CreateObject("Scripting.FileSystemObject")
        Drv = FSO.GetDrive(FSO.GetDriveName(AppDomain.CurrentDomain.BaseDirectory))
        With Drv
            If .IsReady Then
                DriveSerial = .SerialNumber
            Else    '"Drive Not Ready!"
                DriveSerial = -1
            End If
        End With
        '/ Clean up
        Drv = Nothing
        FSO = Nothing
        GetDriveVolumeSerialNumber = Math.Abs(DriveSerial) 'Hex(Math.Abs(DriveSerial))
    End Function

    ' Read Registry
    Private Function ReadAppRegistry(ByVal SectionName As String, ByVal KeyName As String, ByVal KeyValue As String) As String
        ' Check exist KeyName, If not have to create new value by default.
        If GetSetting(AppTitle, SectionName, KeyName) = "" Then _
            Call SaveSetting(AppTitle, SectionName, KeyName, KeyValue)

        ' Return Value
        ReadAppRegistry = GetSetting(AppTitle, SectionName, KeyName)
    End Function

    ' Write Registry
    Public Sub WriteAppRegistry(ByVal SectionName As String, ByVal KeyName As String, ByVal KeyValue As String)
        Call SaveSetting(AppTitle, SectionName, KeyName, KeyValue)
    End Sub

    Private Sub btn_LicenseRegister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_LicenseRegister.Click
        ' รับค่า Drive Volume SerialNumber เพื่อใช้เป็น Product ID
        ProductID = GetDriveVolumeSerialNumber()

        ' เข้ารหัส Product ID (Drive Volume Serial Number) ร่วมกับ Encryption Key (กุญแจ)
        Dim ActivateKey As String = EncryptLicenseKey(ProductID, UserEncryptionKey)

        ' เปรียบเทียบค่าที่ได้ (Activate Key) กับค่าที่ผู้ใช้ป้อนเข้ามา (License Key)
        If ActivateKey = tbox_InputLicenseKey.Text Then
            ' ลงทะเบียนแล้ว
            lb_LicenseStatus.Text = "License : Full Verion"

            Call WriteAppRegistry(SectionName, "ProductID", ProductID)
            Call WriteAppRegistry(SectionName, "LicenseKey", tbox_InputLicenseKey.Text.Trim)
            MessageBox.Show("Registration Complete.", "Report Status", MessageBoxButtons.OK, MessageBoxIcon.Information)
            load_UserZone()
        Else
            ' ไม่ลงทะเบียน
            lb_LicenseStatus.Text = "License : Demo"
            MessageBox.Show("Product Key is not correct.", "Report Status", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            tbox_InputLicenseKey.Focus()
        End If
    End Sub


    Private Sub btn_CopyProductID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_CopyProductID.Click
        Try
            Clipboard.SetText(tbox_UserProductID.Text)
            lb_UserAlertText.Visible = True
            lb_UserAlertText.Text = "Copied to Clipboard!"
        Catch ex As Exception
            lb_UserAlertText.Visible = True
            lb_UserAlertText.Text = "Product ID not Found, Try Again"
        End Try
    End Sub

    ' ******* License Key Generator *******

    Dim GeneratorEncryptionKey As String = "5332B737-76F5-4B83-AE7C-0D2E6BD5A586"

    Private Sub load_GeneratorZone()
        ' Background
        tbox_GeneraterEncryptionKey.Text = GeneratorEncryptionKey
    End Sub

    Private Sub btn_LicenseKeyGenerate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_LicenseKeyGenerate.Click
        If tbox_InputUserProductID.Text = "" Then
            tbox_InputUserProductID.Focus()
        Else
            ' รับค่า User Product ID จากผู้ใช้
            Dim UserProductID As String = tbox_InputUserProductID.Text
            ' เข้ารหัส User Product ID (ที่ได้จากผู้ใช้) ร่วมกับ Encryption Key (กุญแจ) เพื่อสร้าง License Key
            tbox_ResultLicenseKey.Text = EncryptLicenseKey(UserProductID, GeneratorEncryptionKey)
            lb_GeneratorAlertText.Visible = True
            lb_GeneratorAlertText.Text = "Success!"
        End If
    End Sub

    Private Sub btn_CopyLicenseKey_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_CopyLicenseKey.Click
        Try
            Clipboard.SetText(tbox_ResultLicenseKey.Text)
            lb_GeneratorAlertText.Visible = True
            lb_GeneratorAlertText.Text = "Copied to Clipboard!"
        Catch ex As Exception
            lb_GeneratorAlertText.Visible = True
            lb_GeneratorAlertText.Text = "License Key not Found, Try Again"
        End Try
    End Sub
End Class