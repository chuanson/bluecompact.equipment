Imports System.Data.SQLite
Imports System.IO
Imports System.Xml.Linq
Imports System.Security.Cryptography
Imports System.Text
Imports System.Data.Sql
Imports System.Globalization

Module sql_Module

    Dim AppDataConnectionString As String = "Data Source=" & Application.StartupPath & "\Data\dbApplication.db;Version=3;"

    ' ฟังก์ชันสำหรับค้นหา Username และ Password
    Public Function GetUserLogin(ByVal ConnectionString As String, ByVal UserName As String, ByVal UserPassword As String) As String
        ' ถอดรหัส ConnectionKey

        Dim query As String = "SELECT UserPassword, IsActive FROM SYSUserLogin WHERE UserName = @UserName"
        Try
            Using connection As New SQLiteConnection(ConnectionString)
                Using command As New SQLiteCommand(query, connection)
                    command.Parameters.AddWithValue("@UserName", UserName)
                    connection.Open()

                    ' ตรวจสอบรหัสผ่าน
                    Dim password_Result As Object = command.ExecuteScalar()
                    If password_Result IsNot Nothing Then
                        If UserPassword = password_Result.ToString() Then
                            Dim reader As SQLiteDataReader = command.ExecuteReader()
                            If reader.HasRows Then
                                reader.Read()
                                ' แสดงชื่อย่อผู้ใช้
                                Dim Active_Check = reader("IsActive").ToString()

                                If Active_Check = "False" Then
                                    Return "1" ' User Deactivated
                                End If
                            End If
                            Return "0"
                        Else
                            Return "2" ' Incorrect password
                        End If
                    Else
                        Return "3" ' Username not found
                    End If
                End Using
            End Using
        Catch ex As SQLiteException
            Return "4" ' Connection error
        Catch ex As Exception
            Return "5" ' Other error
        End Try
    End Function

    ' ฟังก์ชันสำหรับดึงข้อมูล DatabaseFile จาก SQL Server
    Public Function GetDatabaseFile(ByVal ConnectionString As String, ByVal databaseID As String)
        Dim DatabaseFileResult As String = String.Empty

        Using connection As New SQLiteConnection(ConnectionString)
            Try
                connection.Open()

                ' SQL ดึงข้อมูลจากแถวที่ตรงกับ DatabaseID
                Dim query As String = "SELECT * FROM Database WHERE DatabaseID = @DatabaseID"
                Using command As New SQLiteCommand(query, connection)
                    command.Parameters.AddWithValue("@DatabaseID", databaseID)

                    Using reader As SQLiteDataReader = command.ExecuteReader()
                        If reader.Read() Then
                            DatabaseFileResult = reader("DatabaseFileName").ToString()
                        End If
                    End Using
                End Using
            Catch ex As SQLiteException
                MessageBox.Show("เกิดข้อผิดพลาด: " & ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using

        Return DatabaseFileResult
    End Function

    ' ฟังชั่นสำรองฐานข้อมูล
    Public Sub BackupDatabase(ByVal SourcePath As String, ByVal BackupFolder As String, ByVal BackupName As String)
        Try
            If Not File.Exists(SourcePath) Then
                MessageBox.Show("ไม่พบไฟล์ฐานข้อมูลต้นฉบับ", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            ' สร้างโฟลเดอร์สำรองหากยังไม่มี
            If Not Directory.Exists(BackupFolder) Then
                Directory.CreateDirectory(BackupFolder)
            End If

            ' ตั้งชื่อไฟล์สำรองอัตโนมัติ
            Dim BackupFileName As String = "BACKUP_" & BackupName & "_" & Now.ToString("yyyy-MM-dd_HH-mm-ss", CultureInfo.InvariantCulture) & ".db"

            Dim BackupFullPath As String = Path.Combine(BackupFolder, BackupFileName)

            ' เปิดการเชื่อมต่อและสำรอง
            Using sourceConnection As New SQLiteConnection("Data Source=" & SourcePath & ";Version=3;")
                sourceConnection.Open()

                Using backupConnection As New SQLiteConnection("Data Source=" & BackupFullPath & ";Version=3;")
                    backupConnection.Open()

                    sourceConnection.BackupDatabase(backupConnection, "main", "main", -1, Nothing, 0)
                End Using
            End Using

            MessageBox.Show("สำรองข้อมูลเรียบร้อยแล้วที่ " & BackupFullPath, "สำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("เกิดข้อผิดพลาดขณะสำรองข้อมูล: " & ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' ฟังชั่นสำรองฐานข้อมูลก่อนลบฐานข้อมูล
    Public Sub BackupDatabaseBeforeDelete(ByVal SourcePath As String, ByVal BackupFolder As String, ByVal BackupName As String)
        Try
            If Not File.Exists(SourcePath) Then
                MessageBox.Show("ไม่พบไฟล์ฐานข้อมูลต้นฉบับ", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            ' สร้างโฟลเดอร์สำรองหากยังไม่มี
            If Not Directory.Exists(BackupFolder) Then
                Directory.CreateDirectory(BackupFolder)
            End If

            ' ตั้งชื่อไฟล์สำรองอัตโนมัติ
            Dim BackupFileName As String = "BACKUP_" & BackupName & "_BEFORE_DELETE_" & Now.ToString("yyyy-MM-dd_HH-mm-ss", CultureInfo.InvariantCulture) & ".db"

            Dim BackupFullPath As String = Path.Combine(BackupFolder, BackupFileName)

            ' เปิดการเชื่อมต่อและสำรอง
            Using sourceConnection As New SQLiteConnection("Data Source=" & SourcePath & ";Version=3;")
                sourceConnection.Open()

                Using backupConnection As New SQLiteConnection("Data Source=" & BackupFullPath & ";Version=3;")
                    backupConnection.Open()

                    sourceConnection.BackupDatabase(backupConnection, "main", "main", -1, Nothing, 0)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("เกิดข้อผิดพลาดขณะสำรองข้อมูลก่อนลบ: " & ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' ฟังชั่นกู้คืนฐานข้อมูล
    Public Sub RestoreDatabase(ByVal BackupFilePath As String, ByVal DestinationPath As String, ByVal BackupBeforeRestorePath As String)
        Try
            If Not File.Exists(BackupFilePath) Then
                MessageBox.Show("ไม่พบไฟล์สำรอง", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            ' ถ้ามีฐานข้อมูลเดิมอยู่ และเลือกสำรองไว้ก่อน
            If File.Exists(DestinationPath) Then
                Dim BackupBeforeRestorePath_WithFileName As String = BackupBeforeRestorePath & "_BEFORE_RESTORE_" & Now.ToString("yyyy-MM-dd_HH-mm-ss", CultureInfo.InvariantCulture) & ".db"
                File.Copy(DestinationPath, BackupBeforeRestorePath_WithFileName)
            End If

            ' คัดลอกไฟล์สำรองมาแทนที่ฐานข้อมูล
            File.Copy(BackupFilePath, DestinationPath, overwrite:=True)

            MessageBox.Show("กู้คืนข้อมูลเรียบร้อยแล้ว", "สำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("เกิดข้อผิดพลาดขณะกู้คืนข้อมูล: " & ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Function GetConfigValue(ByVal ConfigKey As String) As String
        Dim value As String = Nothing
        Dim query As String = "SELECT ConfigValue FROM Config WHERE ConfigKey = @ConfigKey LIMIT 1"

        Try
            Using connection As New SQLiteConnection(AppDataConnectionString)
                connection.Open()
                Using command As New SQLiteCommand(query, connection)
                    command.Parameters.AddWithValue("@ConfigKey", ConfigKey)
                    Dim result = command.ExecuteScalar()
                    If result IsNot Nothing Then
                        value = result.ToString()
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("เกิดข้อผิดพลาดขณะอ่านค่าการตั้งค่า: " & ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return value
    End Function

End Module
