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

                comboBox.DisplayMember = displayField
                comboBox.ValueMember = valueField
                comboBox.DataSource = dt
            End Using
        Catch ex As Exception
            MessageBox.Show("เกิดข้อผิดพลาดในการโหลดข้อมูล: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Module
