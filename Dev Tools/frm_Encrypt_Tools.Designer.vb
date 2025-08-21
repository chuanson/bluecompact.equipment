<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Encrypt_Tools
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.tbox_data = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbox_Result = New System.Windows.Forms.TextBox()
        Me.btn_CopyToClipboard = New System.Windows.Forms.Button()
        Me.btn_Clear = New System.Windows.Forms.Button()
        Me.btn_Start = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radio_Decryption = New System.Windows.Forms.RadioButton()
        Me.radio_Encryption = New System.Windows.Forms.RadioButton()
        Me.tbox_Key = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lb_Alert = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbox_data
        '
        Me.tbox_data.Location = New System.Drawing.Point(12, 90)
        Me.tbox_data.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbox_data.Multiline = True
        Me.tbox_data.Name = "tbox_data"
        Me.tbox_data.Size = New System.Drawing.Size(351, 74)
        Me.tbox_data.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Data"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 243)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Result"
        '
        'tbox_Result
        '
        Me.tbox_Result.Location = New System.Drawing.Point(12, 263)
        Me.tbox_Result.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbox_Result.Multiline = True
        Me.tbox_Result.Name = "tbox_Result"
        Me.tbox_Result.Size = New System.Drawing.Size(351, 81)
        Me.tbox_Result.TabIndex = 3
        '
        'btn_CopyToClipboard
        '
        Me.btn_CopyToClipboard.Location = New System.Drawing.Point(236, 351)
        Me.btn_CopyToClipboard.Name = "btn_CopyToClipboard"
        Me.btn_CopyToClipboard.Size = New System.Drawing.Size(127, 31)
        Me.btn_CopyToClipboard.TabIndex = 6
        Me.btn_CopyToClipboard.Text = "Copy to Clipboard"
        Me.btn_CopyToClipboard.UseVisualStyleBackColor = True
        '
        'btn_Clear
        '
        Me.btn_Clear.Location = New System.Drawing.Point(179, 351)
        Me.btn_Clear.Name = "btn_Clear"
        Me.btn_Clear.Size = New System.Drawing.Size(51, 31)
        Me.btn_Clear.TabIndex = 5
        Me.btn_Clear.Text = "Clear"
        Me.btn_Clear.UseVisualStyleBackColor = True
        '
        'btn_Start
        '
        Me.btn_Start.Location = New System.Drawing.Point(92, 351)
        Me.btn_Start.Name = "btn_Start"
        Me.btn_Start.Size = New System.Drawing.Size(81, 31)
        Me.btn_Start.TabIndex = 4
        Me.btn_Start.Text = "Start"
        Me.btn_Start.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radio_Decryption)
        Me.GroupBox1.Controls.Add(Me.radio_Encryption)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(348, 54)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select Process"
        '
        'radio_Decryption
        '
        Me.radio_Decryption.AutoSize = True
        Me.radio_Decryption.Location = New System.Drawing.Point(105, 22)
        Me.radio_Decryption.Name = "radio_Decryption"
        Me.radio_Decryption.Size = New System.Drawing.Size(86, 20)
        Me.radio_Decryption.TabIndex = 0
        Me.radio_Decryption.Text = "Decryption"
        Me.radio_Decryption.UseVisualStyleBackColor = True
        '
        'radio_Encryption
        '
        Me.radio_Encryption.AutoSize = True
        Me.radio_Encryption.Checked = True
        Me.radio_Encryption.Location = New System.Drawing.Point(14, 22)
        Me.radio_Encryption.Name = "radio_Encryption"
        Me.radio_Encryption.Size = New System.Drawing.Size(85, 20)
        Me.radio_Encryption.TabIndex = 0
        Me.radio_Encryption.TabStop = True
        Me.radio_Encryption.Text = "Encryption"
        Me.radio_Encryption.UseVisualStyleBackColor = True
        '
        'tbox_Key
        '
        Me.tbox_Key.Location = New System.Drawing.Point(12, 188)
        Me.tbox_Key.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbox_Key.Multiline = True
        Me.tbox_Key.Name = "tbox_Key"
        Me.tbox_Key.Size = New System.Drawing.Size(351, 51)
        Me.tbox_Key.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 168)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 16)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Key"
        '
        'lb_Alert
        '
        Me.lb_Alert.AutoSize = True
        Me.lb_Alert.ForeColor = System.Drawing.Color.Green
        Me.lb_Alert.Location = New System.Drawing.Point(12, 358)
        Me.lb_Alert.Name = "lb_Alert"
        Me.lb_Alert.Size = New System.Drawing.Size(58, 16)
        Me.lb_Alert.TabIndex = 4
        Me.lb_Alert.Text = "Message"
        Me.lb_Alert.Visible = False
        '
        'Encrypt_Tools
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(375, 394)
        Me.Controls.Add(Me.lb_Alert)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_Start)
        Me.Controls.Add(Me.btn_Clear)
        Me.Controls.Add(Me.btn_CopyToClipboard)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbox_Key)
        Me.Controls.Add(Me.tbox_Result)
        Me.Controls.Add(Me.tbox_data)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Encrypt_Tools"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Encryption Tools"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbox_data As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tbox_Result As TextBox
    Friend WithEvents btn_CopyToClipboard As Button
    Friend WithEvents btn_Clear As Button
    Friend WithEvents btn_Start As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radio_Decryption As RadioButton
    Friend WithEvents radio_Encryption As RadioButton
    Friend WithEvents tbox_Key As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lb_Alert As Label
End Class
