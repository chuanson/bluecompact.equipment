Public Class frm_IDGenerator

    Private Sub frm_CreateID_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tbox_Result.Clear()
        lb_Alert.Visible = False
    End Sub

    Private Sub Random_ID()
        tbox_Result.Clear()
        lb_Alert.Visible = False

        ' สร้าง randomID
        Dim randomID As String

        If radio_A.Checked = True Then
            randomID = idtools_Module.GenerateID()
        Else
            randomID = idtools_Module.GenerateKey()
        End If

        tbox_Result.Text = randomID
    End Sub

    Private Sub btn_Random_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Random.Click
        If checkbox_RandomCopy.Checked = True Then
            Random_ID()
            Clipboard.SetText(tbox_Result.Text)
            lb_Alert.Visible = True
        Else
            Random_ID()
        End If
    End Sub

    Private Sub btn_Copy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Copy.Click
        Clipboard.SetText(tbox_Result.Text)
        lb_Alert.Visible = True
    End Sub
End Class