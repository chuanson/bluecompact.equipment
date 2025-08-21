Imports System.Security.Cryptography

Module idtools_Module
    Public Function GenerateID() As String
        ' สร้าง randomID
        Dim randomID As String
        Dim newGuid As Guid = Guid.NewGuid()
        randomID = newGuid.ToString("D")
        Return UCase(randomID)
    End Function

    Public Function GenerateKey() As String
        ' สร้าง randomID
        Dim randomID As String
        Dim newGuid As Guid = Guid.NewGuid()

        ' แปลง GUID เป็นตัวเลข
        Dim numericString As String = String.Concat(newGuid.ToByteArray().Select(Function(b) (b Mod 15).ToString()))
        randomID = numericString.Substring(0, 5) & "-" & numericString.Substring(5, 5) & "-" & numericString.Substring(9, 5) & "-" & numericString.Substring(14, 5)
        Return randomID
    End Function

    ' สร้าง UDID สั้น (Base36 ตัวใหญ่) ความยาวตามต้องการ (เริ่มต้น 6 ตัว)
    Public Function GenerateShortUDID(Optional ByVal length As Integer = 6) As String
        ' สร้างไบต์สุ่ม (5 bytes = 40 bits ≈ 8 ตัว base36)
        Dim bytes(4) As Byte
        Using rng As New RNGCryptoServiceProvider()
            rng.GetBytes(bytes)
        End Using

        ' แปลงเป็น UInt64 เพื่อใช้กับ Base36
        Dim value As ULong = BitConverter.ToUInt64(bytes.Concat({CByte(0), CByte(0), CByte(0)}).Take(8).ToArray(), 0)

        ' แปลงเป็น Base36 (A-Z, 0-9) และตัดความยาว
        Dim base36 As String = ConvertToBase36(value).ToUpper()
        If base36.Length > length Then
            base36 = base36.Substring(0, length)
        End If

        Return base36
    End Function

    ' ฟังก์ชันช่วย: แปลงตัวเลขเป็น Base36
    Private Function ConvertToBase36(ByVal value As ULong) As String
        Const chars As String = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        Dim result As String = ""
        Do
            result = chars(CInt(value Mod 36)) & result
            value \= 36
        Loop While value > 0
        Return result
    End Function
End Module
