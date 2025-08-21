Public Class frm_Encrypt_Tools
    Private Sub btn_Start_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_Start.Click
        Try
            If radio_Encryption.Checked = True Then
                tbox_Result.Text = encrypt_Module.EncryptDataWithKey(tbox_data.Text, tbox_Key.Text)
            Else
                tbox_Result.Text = encrypt_Module.DecryptDataWithKey(tbox_data.Text, tbox_Key.Text)
            End If

            lb_Alert.Text = "Success!"
            lb_Alert.Visible = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error, Try Again", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub btn_Clear_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_Clear.Click
        tbox_data.Clear()
        tbox_Key.Clear()
        tbox_Result.Clear()
        lb_Alert.Visible = False
    End Sub

    Private Sub btn_CopyToClipboard_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_CopyToClipboard.Click
        Clipboard.SetText(tbox_Result.Text)
        lb_Alert.Text = "Copie!"
        lb_Alert.Visible = True
    End Sub
End Class