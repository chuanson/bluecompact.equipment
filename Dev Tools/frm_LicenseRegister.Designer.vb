<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_LicenseRegister
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_LicenseRegister))
        Me.lb_LicenseStatus = New System.Windows.Forms.Label()
        Me.btn_LicenseRegister = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lb_UserAlertText = New System.Windows.Forms.Label()
        Me.btn_CopyProductID = New System.Windows.Forms.Button()
        Me.tbox_InputLicenseKey = New System.Windows.Forms.TextBox()
        Me.tbox_UserProductID = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbox_UserEncryptionKey = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.lb_DriveVolumeSerialNumber = New System.Windows.Forms.Label()
        Me.tbox_DriveVolumeSerialNumber = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lb_GeneratorAlertText = New System.Windows.Forms.Label()
        Me.tbox_ResultLicenseKey = New System.Windows.Forms.TextBox()
        Me.tbox_InputUserProductID = New System.Windows.Forms.TextBox()
        Me.btn_LicenseKeyGenerate = New System.Windows.Forms.Button()
        Me.btn_CopyLicenseKey = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tbox_GeneraterEncryptionKey = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'lb_LicenseStatus
        '
        Me.lb_LicenseStatus.BackColor = System.Drawing.SystemColors.Control
        Me.lb_LicenseStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lb_LicenseStatus.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lb_LicenseStatus.Location = New System.Drawing.Point(12, 9)
        Me.lb_LicenseStatus.Name = "lb_LicenseStatus"
        Me.lb_LicenseStatus.Size = New System.Drawing.Size(469, 28)
        Me.lb_LicenseStatus.TabIndex = 0
        Me.lb_LicenseStatus.Text = "License : Demo"
        Me.lb_LicenseStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_LicenseRegister
        '
        Me.btn_LicenseRegister.Location = New System.Drawing.Point(6, 102)
        Me.btn_LicenseRegister.Name = "btn_LicenseRegister"
        Me.btn_LicenseRegister.Size = New System.Drawing.Size(90, 23)
        Me.btn_LicenseRegister.TabIndex = 1
        Me.btn_LicenseRegister.Text = "Register"
        Me.btn_LicenseRegister.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lb_UserAlertText)
        Me.GroupBox1.Controls.Add(Me.btn_CopyProductID)
        Me.GroupBox1.Controls.Add(Me.tbox_InputLicenseKey)
        Me.GroupBox1.Controls.Add(Me.tbox_UserProductID)
        Me.GroupBox1.Controls.Add(Me.btn_LicenseRegister)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 46)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(229, 156)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "User"
        '
        'lb_UserAlertText
        '
        Me.lb_UserAlertText.AutoSize = True
        Me.lb_UserAlertText.Location = New System.Drawing.Point(7, 132)
        Me.lb_UserAlertText.Name = "lb_UserAlertText"
        Me.lb_UserAlertText.Size = New System.Drawing.Size(52, 13)
        Me.lb_UserAlertText.TabIndex = 3
        Me.lb_UserAlertText.Text = "Alert Text"
        Me.lb_UserAlertText.Visible = False
        '
        'btn_CopyProductID
        '
        Me.btn_CopyProductID.Location = New System.Drawing.Point(115, 102)
        Me.btn_CopyProductID.Name = "btn_CopyProductID"
        Me.btn_CopyProductID.Size = New System.Drawing.Size(108, 23)
        Me.btn_CopyProductID.TabIndex = 2
        Me.btn_CopyProductID.Text = "Copy Product ID"
        Me.btn_CopyProductID.UseVisualStyleBackColor = True
        '
        'tbox_InputLicenseKey
        '
        Me.tbox_InputLicenseKey.Location = New System.Drawing.Point(6, 76)
        Me.tbox_InputLicenseKey.Name = "tbox_InputLicenseKey"
        Me.tbox_InputLicenseKey.Size = New System.Drawing.Size(217, 20)
        Me.tbox_InputLicenseKey.TabIndex = 1
        '
        'tbox_UserProductID
        '
        Me.tbox_UserProductID.Location = New System.Drawing.Point(6, 37)
        Me.tbox_UserProductID.Name = "tbox_UserProductID"
        Me.tbox_UserProductID.ReadOnly = True
        Me.tbox_UserProductID.Size = New System.Drawing.Size(217, 20)
        Me.tbox_UserProductID.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Enter License Key :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Product ID :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Encryption Key :"
        '
        'tbox_UserEncryptionKey
        '
        Me.tbox_UserEncryptionKey.Location = New System.Drawing.Point(6, 76)
        Me.tbox_UserEncryptionKey.Name = "tbox_UserEncryptionKey"
        Me.tbox_UserEncryptionKey.Size = New System.Drawing.Size(217, 20)
        Me.tbox_UserEncryptionKey.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RichTextBox1)
        Me.GroupBox2.Controls.Add(Me.lb_DriveVolumeSerialNumber)
        Me.GroupBox2.Controls.Add(Me.tbox_DriveVolumeSerialNumber)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.tbox_UserEncryptionKey)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 208)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(229, 236)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Background"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(6, 102)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(217, 128)
        Me.RichTextBox1.TabIndex = 2
        Me.RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        '
        'lb_DriveVolumeSerialNumber
        '
        Me.lb_DriveVolumeSerialNumber.AutoSize = True
        Me.lb_DriveVolumeSerialNumber.Location = New System.Drawing.Point(6, 21)
        Me.lb_DriveVolumeSerialNumber.Name = "lb_DriveVolumeSerialNumber"
        Me.lb_DriveVolumeSerialNumber.Size = New System.Drawing.Size(171, 13)
        Me.lb_DriveVolumeSerialNumber.TabIndex = 0
        Me.lb_DriveVolumeSerialNumber.Text = "Get > DriveVolume Serial Number :"
        '
        'tbox_DriveVolumeSerialNumber
        '
        Me.tbox_DriveVolumeSerialNumber.Location = New System.Drawing.Point(6, 37)
        Me.tbox_DriveVolumeSerialNumber.Name = "tbox_DriveVolumeSerialNumber"
        Me.tbox_DriveVolumeSerialNumber.ReadOnly = True
        Me.tbox_DriveVolumeSerialNumber.Size = New System.Drawing.Size(217, 20)
        Me.tbox_DriveVolumeSerialNumber.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lb_GeneratorAlertText)
        Me.GroupBox3.Controls.Add(Me.tbox_ResultLicenseKey)
        Me.GroupBox3.Controls.Add(Me.tbox_InputUserProductID)
        Me.GroupBox3.Controls.Add(Me.btn_LicenseKeyGenerate)
        Me.GroupBox3.Controls.Add(Me.btn_CopyLicenseKey)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Location = New System.Drawing.Point(252, 46)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(229, 156)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "License Key Generator"
        '
        'lb_GeneratorAlertText
        '
        Me.lb_GeneratorAlertText.AutoSize = True
        Me.lb_GeneratorAlertText.Location = New System.Drawing.Point(6, 132)
        Me.lb_GeneratorAlertText.Name = "lb_GeneratorAlertText"
        Me.lb_GeneratorAlertText.Size = New System.Drawing.Size(52, 13)
        Me.lb_GeneratorAlertText.TabIndex = 3
        Me.lb_GeneratorAlertText.Text = "Alert Text"
        Me.lb_GeneratorAlertText.Visible = False
        '
        'tbox_ResultLicenseKey
        '
        Me.tbox_ResultLicenseKey.Location = New System.Drawing.Point(6, 76)
        Me.tbox_ResultLicenseKey.Name = "tbox_ResultLicenseKey"
        Me.tbox_ResultLicenseKey.Size = New System.Drawing.Size(217, 20)
        Me.tbox_ResultLicenseKey.TabIndex = 1
        '
        'tbox_InputUserProductID
        '
        Me.tbox_InputUserProductID.Location = New System.Drawing.Point(6, 37)
        Me.tbox_InputUserProductID.Name = "tbox_InputUserProductID"
        Me.tbox_InputUserProductID.Size = New System.Drawing.Size(217, 20)
        Me.tbox_InputUserProductID.TabIndex = 1
        '
        'btn_LicenseKeyGenerate
        '
        Me.btn_LicenseKeyGenerate.Location = New System.Drawing.Point(6, 102)
        Me.btn_LicenseKeyGenerate.Name = "btn_LicenseKeyGenerate"
        Me.btn_LicenseKeyGenerate.Size = New System.Drawing.Size(90, 23)
        Me.btn_LicenseKeyGenerate.TabIndex = 1
        Me.btn_LicenseKeyGenerate.Text = "Generate"
        Me.btn_LicenseKeyGenerate.UseVisualStyleBackColor = True
        '
        'btn_CopyLicenseKey
        '
        Me.btn_CopyLicenseKey.Location = New System.Drawing.Point(115, 102)
        Me.btn_CopyLicenseKey.Name = "btn_CopyLicenseKey"
        Me.btn_CopyLicenseKey.Size = New System.Drawing.Size(108, 23)
        Me.btn_CopyLicenseKey.TabIndex = 1
        Me.btn_CopyLicenseKey.Text = "Copy License Key"
        Me.btn_CopyLicenseKey.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Result > License Key :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "User's Product ID :"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.RichTextBox2)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.tbox_GeneraterEncryptionKey)
        Me.GroupBox4.Location = New System.Drawing.Point(252, 208)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(229, 236)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Background"
        '
        'RichTextBox2
        '
        Me.RichTextBox2.Location = New System.Drawing.Point(6, 102)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.ReadOnly = True
        Me.RichTextBox2.Size = New System.Drawing.Size(217, 128)
        Me.RichTextBox2.TabIndex = 2
        Me.RichTextBox2.Text = "รับค่า User Product ID จากผู้ใช้" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) & "เข้ารหัส User Product ID (ที่ได้จากผู้ใช้) ร่วม" & _
            "กับ Encryption Key (กุญแจ) เพื่อสร้าง License Key"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 21)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(84, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Encryption Key :"
        '
        'tbox_GeneraterEncryptionKey
        '
        Me.tbox_GeneraterEncryptionKey.Location = New System.Drawing.Point(6, 37)
        Me.tbox_GeneraterEncryptionKey.Name = "tbox_GeneraterEncryptionKey"
        Me.tbox_GeneraterEncryptionKey.Size = New System.Drawing.Size(217, 20)
        Me.tbox_GeneraterEncryptionKey.TabIndex = 1
        '
        'frm_LicenseRegister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(493, 456)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lb_LicenseStatus)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm_LicenseRegister"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Software License Register System"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lb_LicenseStatus As System.Windows.Forms.Label
    Friend WithEvents btn_LicenseRegister As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents tbox_InputLicenseKey As System.Windows.Forms.TextBox
    Friend WithEvents tbox_UserProductID As System.Windows.Forms.TextBox
    Friend WithEvents tbox_UserEncryptionKey As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents tbox_ResultLicenseKey As System.Windows.Forms.TextBox
    Friend WithEvents tbox_InputUserProductID As System.Windows.Forms.TextBox
    Friend WithEvents btn_CopyLicenseKey As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lb_DriveVolumeSerialNumber As System.Windows.Forms.Label
    Friend WithEvents tbox_DriveVolumeSerialNumber As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents tbox_GeneraterEncryptionKey As System.Windows.Forms.TextBox
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents RichTextBox2 As System.Windows.Forms.RichTextBox
    Friend WithEvents btn_LicenseKeyGenerate As System.Windows.Forms.Button
    Friend WithEvents btn_CopyProductID As System.Windows.Forms.Button
    Friend WithEvents lb_UserAlertText As System.Windows.Forms.Label
    Friend WithEvents lb_GeneratorAlertText As System.Windows.Forms.Label
End Class
