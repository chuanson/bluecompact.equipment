Imports System.Data.SQLite
Module ComboBox_Module

    ' คลาสสำหรับเก็บค่า ComboBoxItem
    Public Class ComboBoxItem
        Public Property Text As String
        Public Property Value As String

        Public Overrides Function ToString() As String
            Return Text
        End Function
    End Class

    Public Sub LoadComboBoxData(ByVal comboBox As ComboBox, ByVal ConnectionString As String, ByVal Query As String, ByVal displayField As String, ByVal valueField As String)
        Try
            Using connection As New SQLiteConnection(ConnectionString)
                connection.Open()

                Dim adapter As New SQLiteDataAdapter(Query, connection)
                Dim dt As New DataTable()
                adapter.Fill(dt)

                ' เพิ่มแถวว่างไว้ด้านบน
                Dim newRow As DataRow = dt.NewRow()
                newRow(displayField) = "ไม่ระบุ"
                newRow(valueField) = DBNull.Value
                dt.Rows.InsertAt(newRow, 0)

                comboBox.DisplayMember = displayField
                comboBox.ValueMember = valueField
                comboBox.DataSource = dt

                comboBox.SelectedIndex = -1
            End Using
        Catch ex As Exception
            MessageBox.Show("เกิดข้อผิดพลาดในการโหลดข้อมูล: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Module
