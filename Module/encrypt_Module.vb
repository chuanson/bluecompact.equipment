Imports System.Security.Cryptography
Imports System.Text

Module encrypt_Module

    Dim encryptionKey As String = "d189df65-a16c-4707-b6a7-44f9a1998e2e"

    ' เข้ารหัสข้อมูล
    Public Function EncryptData(ByVal plainText As String) As String
        Dim key() As Byte = Encoding.UTF8.GetBytes(encryptionKey.Substring(0, 16))
        Using aes As Aes = aes.Create()
            aes.Key = key
            aes.IV = key
            Using encryptor = aes.CreateEncryptor(aes.Key, aes.IV)
                Dim plainBytes() As Byte = Encoding.UTF8.GetBytes(plainText)
                Dim encryptedBytes() As Byte = encryptor.TransformFinalBlock(plainBytes, 0, plainBytes.Length)
                Return Convert.ToBase64String(encryptedBytes)
            End Using
        End Using
    End Function

    ' ฟังก์ชันถอดรหัส ConnectionString
    Public Function DecryptData(ByVal encryptedText As String) As String
        Dim key() As Byte = Encoding.UTF8.GetBytes(encryptionKey.Substring(0, 16))
        Using aes As Aes = aes.Create()
            aes.Key = key
            aes.IV = key
            Using decryptor = aes.CreateDecryptor(aes.Key, aes.IV)
                Dim encryptedBytes() As Byte = Convert.FromBase64String(encryptedText)
                Dim plainBytes() As Byte = decryptor.TransformFinalBlock(encryptedBytes, 0, encryptedBytes.Length)
                Return Encoding.UTF8.GetString(plainBytes)
            End Using
        End Using
    End Function

    ' เข้ารหัสข้อมูล
    Public Function EncryptDataWithKey(ByVal plainText As String, ByVal encryptionKey As String) As String
        Dim key() As Byte = Encoding.UTF8.GetBytes(encryptionKey.Substring(0, 16))
        Using aes As Aes = aes.Create()
            aes.Key = key
            aes.IV = key
            Using encryptor = aes.CreateEncryptor(aes.Key, aes.IV)
                Dim plainBytes() As Byte = Encoding.UTF8.GetBytes(plainText)
                Dim encryptedBytes() As Byte = encryptor.TransformFinalBlock(plainBytes, 0, plainBytes.Length)
                Return Convert.ToBase64String(encryptedBytes)
            End Using
        End Using
    End Function

    ' ฟังก์ชันถอดรหัส ConnectionString
    Public Function DecryptDataWithKey(ByVal encryptedText As String, ByVal encryptionKey As String) As String
        Dim key() As Byte = Encoding.UTF8.GetBytes(encryptionKey.Substring(0, 16))
        Using aes As Aes = aes.Create()
            aes.Key = key
            aes.IV = key
            Using decryptor = aes.CreateDecryptor(aes.Key, aes.IV)
                Dim encryptedBytes() As Byte = Convert.FromBase64String(encryptedText)
                Dim plainBytes() As Byte = decryptor.TransformFinalBlock(encryptedBytes, 0, encryptedBytes.Length)
                Return Encoding.UTF8.GetString(plainBytes)
            End Using
        End Using
    End Function
End Module
