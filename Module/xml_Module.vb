Imports System.Xml.Linq
Imports System.IO

Module xml_Module

    Public Function GetVersionFromXML()
        Try
            ' อ่านไฟล์ XML โดยใช้ XDocument
            Dim doc As XDocument = XDocument.Load(Application.StartupPath & "\application_data.xml")

            ' ค้นหา Node <Version>
            Dim version = doc.Descendants("Version").FirstOrDefault()
            Dim version_Number As String
            ' ตรวจสอบว่าพบ Node หรือไม่
            If version IsNot Nothing Then
                ' แสดงค่าใน TextBox
                version_Number = version.Value
            Else
                version_Number = "Null"
            End If

            Return version_Number
        Catch ex As Exception
            ' แสดงข้อความข้อผิดพลาด
            MessageBox.Show("เกิดข้อผิดพลาด: " & ex.Message, "Xml Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return ex.Message
        End Try
    End Function

    Public Function GetConnectionFromXML(ByVal selected_ConnectionID As String)
        Try
            ' โหลด XML
            Dim xmlDoc As XDocument = XDocument.Load(Application.StartupPath & "\connections.xml")

            ' ค้นหา Connection ที่ตรงกับ ConnectionID ที่เลือก
            Dim selectedConnection As XElement = Nothing
            For Each connection As XElement In xmlDoc.Root.Elements("Connection")
                Dim connectionID As XElement = connection.Element("ConnectionID")
                If connectionID IsNot Nothing AndAlso connectionID.Value = selected_ConnectionID Then
                    selectedConnection = connection
                    Exit For
                End If
            Next
            Return selectedConnection
        Catch ex As Exception
            ' แสดงข้อความข้อผิดพลาด
            MessageBox.Show("เกิดข้อผิดพลาด: " & ex.Message, "Xml Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return ex.Message
        End Try
    End Function
End Module

