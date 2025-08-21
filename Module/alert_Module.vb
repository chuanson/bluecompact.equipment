Module alert_Module
    Public Sub SuccessDialog_Show(ByVal Title_Message As String, ByVal Des_Message As String, ByVal Caption As String)
        Dim CustomDialog As New dialog_Default
        CustomDialog.Title_Message.Text = Title_Message
        CustomDialog.Des_Message.Text = Des_Message
        CustomDialog.Text = Caption
        CustomDialog.PictureBox1.Image = My.Resources.circle_check_m

        ' ตั้งค่า Owner ให้เป็นฟอร์มนี้
        CustomDialog.Owner = frm_Main
        CustomDialog.ShowDialog()
    End Sub

    Public Sub WarningDialog_Show(ByVal Title_Message As String, ByVal Des_Message As String, ByVal Caption As String)
        Dim CustomDialog As New dialog_Default
        CustomDialog.Title_Message.Text = Title_Message
        CustomDialog.Des_Message.Text = Des_Message
        CustomDialog.Text = Caption
        CustomDialog.PictureBox1.Image = My.Resources.warning_m

        ' ตั้งค่า Owner ให้เป็นฟอร์มนี้
        CustomDialog.Owner = frm_Main
        CustomDialog.ShowDialog()
    End Sub

    Public Sub ErrorDialog_Show(ByVal Title_Message As String, ByVal Des_Message As String, ByVal Caption As String)
        Dim CustomDialog As New dialog_Default
        CustomDialog.Title_Message.Text = Title_Message
        CustomDialog.Des_Message.Text = Des_Message
        CustomDialog.Text = Caption
        CustomDialog.PictureBox1.Image = My.Resources.error_m

        ' ตั้งค่า Owner ให้เป็นฟอร์มนี้
        CustomDialog.Owner = frm_Main
        CustomDialog.ShowDialog()
    End Sub

    Public Function QuestionDialog_Show(ByVal Title_Message As String, ByVal Des_Message As String, ByVal Caption As String, ByVal Icon As Image)
        Dim CustomDialog As New dialog_Question
        CustomDialog.Title_Message.Text = Title_Message
        CustomDialog.Des_Message.Text = Des_Message
        CustomDialog.Text = Caption
        CustomDialog.PictureBox1.Image = Icon

        ' ตั้งค่า Owner ให้เป็นฟอร์มนี้
        CustomDialog.Owner = frm_Main

        ' แสดงและรับผลลัพธ์
        Dim result As DialogResult = CustomDialog.ShowDialog()
        Return result
    End Function
End Module
