Imports System.Security.Cryptography
Imports System.Text

Module license_Module
    Public Function EncryptLicenseKey(ByVal plainText As String, ByVal encryptionKey As String) As String
        ' จัดการ key ให้อยู่ในรูปแบบ 16 byte
        Dim keyString As String = encryptionKey.PadRight(16, " "c).Substring(0, 16)
        Dim key() As Byte = Encoding.UTF8.GetBytes(keyString)

        Using aes As Aes = aes.Create()
            aes.Key = key
            aes.IV = key ' หมายเหตุ: ปกติควรใช้ IV ที่สุ่ม ไม่ใช้ key ซ้ำกับ IV

            Using encryptor = aes.CreateEncryptor(aes.Key, aes.IV)
                Dim plainBytes() As Byte = Encoding.UTF8.GetBytes(plainText)
                Dim encryptedBytes() As Byte = encryptor.TransformFinalBlock(plainBytes, 0, plainBytes.Length)

                ' แปลงเป็น Base64 และจัดรูปแบบ License Key
                Dim base64 As String = Convert.ToBase64String(encryptedBytes)
                Dim cleanBase64 As String = base64.Replace("=", "").Replace("+", "").Replace("/", "")
                Return FormatLicenseKey(cleanBase64)
            End Using
        End Using
    End Function

    Private Function FormatLicenseKey(ByVal raw As String) As String
        ' ตัดให้ได้ 16 ตัวอักษรแรก และจัดรูปแบบเป็น XXXX-XXXX-XXXX-XXXX
        Dim trimmed = raw.Substring(0, Math.Min(16, raw.Length)).ToUpper()
        Return String.Join("-", Enumerable.Range(0, trimmed.Length \ 4).Select(Function(i) trimmed.Substring(i * 4, 4)))
    End Function
End Module
