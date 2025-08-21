<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dialog_Question
    Inherits DevComponents.DotNetBar.OfficeForm

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
        Me.Title_Message = New DevComponents.DotNetBar.LabelX()
        Me.btn_Cancel = New DevComponents.DotNetBar.ButtonX()
        Me.btn_OK = New DevComponents.DotNetBar.ButtonX()
        Me.Des_Message = New DevComponents.DotNetBar.LabelX()
        Me.Line1 = New DevComponents.DotNetBar.Controls.Line()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Title_Message
        '
        Me.Title_Message.AutoSize = True
        '
        '
        '
        Me.Title_Message.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Title_Message.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title_Message.Location = New System.Drawing.Point(66, 14)
        Me.Title_Message.Name = "Title_Message"
        Me.Title_Message.Size = New System.Drawing.Size(92, 18)
        Me.Title_Message.TabIndex = 3
        Me.Title_Message.Text = "Title Message"
        '
        'btn_Cancel
        '
        Me.btn_Cancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_Cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.No
        Me.btn_Cancel.Location = New System.Drawing.Point(307, 86)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(75, 23)
        Me.btn_Cancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_Cancel.TabIndex = 1
        Me.btn_Cancel.Text = "ยกเลิก"
        '
        'btn_OK
        '
        Me.btn_OK.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_OK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_OK.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn_OK.DialogResult = System.Windows.Forms.DialogResult.Yes
        Me.btn_OK.Location = New System.Drawing.Point(226, 86)
        Me.btn_OK.Name = "btn_OK"
        Me.btn_OK.Size = New System.Drawing.Size(75, 23)
        Me.btn_OK.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_OK.TabIndex = 2
        Me.btn_OK.Text = "ตกลง"
        '
        'Des_Message
        '
        Me.Des_Message.AutoSize = True
        '
        '
        '
        Me.Des_Message.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Des_Message.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Des_Message.Location = New System.Drawing.Point(66, 38)
        Me.Des_Message.Name = "Des_Message"
        Me.Des_Message.Size = New System.Drawing.Size(111, 17)
        Me.Des_Message.TabIndex = 4
        Me.Des_Message.Text = "Description Message"
        '
        'Line1
        '
        Me.Line1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Line1.ForeColor = System.Drawing.Color.LightGray
        Me.Line1.Location = New System.Drawing.Point(12, 68)
        Me.Line1.Name = "Line1"
        Me.Line1.Size = New System.Drawing.Size(370, 12)
        Me.Line1.TabIndex = 5
        Me.Line1.Text = "Line1"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Equipment.My.Resources.Resources.question_m
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 48)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'dialog_Question
        '
        Me.AcceptButton = Me.btn_OK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BottomLeftCornerSize = 0
        Me.BottomRightCornerSize = 0
        Me.CancelButton = Me.btn_Cancel
        Me.CaptionFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ClientSize = New System.Drawing.Size(394, 121)
        Me.Controls.Add(Me.Line1)
        Me.Controls.Add(Me.Des_Message)
        Me.Controls.Add(Me.btn_OK)
        Me.Controls.Add(Me.btn_Cancel)
        Me.Controls.Add(Me.Title_Message)
        Me.Controls.Add(Me.PictureBox1)
        Me.DoubleBuffered = True
        Me.EnableGlass = False
        Me.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dialog_Question"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "แจ้งเตือน"
        Me.TopLeftCornerSize = 0
        Me.TopRightCornerSize = 0
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Title_Message As DevComponents.DotNetBar.LabelX
    Friend WithEvents btn_Cancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btn_OK As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Des_Message As DevComponents.DotNetBar.LabelX
    Friend WithEvents Line1 As DevComponents.DotNetBar.Controls.Line
End Class
