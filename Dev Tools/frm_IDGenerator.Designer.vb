<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_IDGenerator
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
        Me.tbox_Result = New System.Windows.Forms.TextBox()
        Me.btn_Random = New System.Windows.Forms.Button()
        Me.btn_Copy = New System.Windows.Forms.Button()
        Me.lb_Alert = New System.Windows.Forms.Label()
        Me.Type_Group = New System.Windows.Forms.GroupBox()
        Me.radio_A = New System.Windows.Forms.RadioButton()
        Me.radio_B = New System.Windows.Forms.RadioButton()
        Me.checkbox_RandomCopy = New System.Windows.Forms.CheckBox()
        Me.Type_Group.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbox_Result
        '
        Me.tbox_Result.Location = New System.Drawing.Point(13, 81)
        Me.tbox_Result.Margin = New System.Windows.Forms.Padding(4)
        Me.tbox_Result.Name = "tbox_Result"
        Me.tbox_Result.Size = New System.Drawing.Size(446, 26)
        Me.tbox_Result.TabIndex = 0
        Me.tbox_Result.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_Random
        '
        Me.btn_Random.Location = New System.Drawing.Point(241, 114)
        Me.btn_Random.Name = "btn_Random"
        Me.btn_Random.Size = New System.Drawing.Size(116, 33)
        Me.btn_Random.TabIndex = 1
        Me.btn_Random.Text = "Random"
        Me.btn_Random.UseVisualStyleBackColor = True
        '
        'btn_Copy
        '
        Me.btn_Copy.Location = New System.Drawing.Point(363, 114)
        Me.btn_Copy.Name = "btn_Copy"
        Me.btn_Copy.Size = New System.Drawing.Size(97, 33)
        Me.btn_Copy.TabIndex = 2
        Me.btn_Copy.Text = "Copy"
        Me.btn_Copy.UseVisualStyleBackColor = True
        '
        'lb_Alert
        '
        Me.lb_Alert.AutoSize = True
        Me.lb_Alert.ForeColor = System.Drawing.Color.Green
        Me.lb_Alert.Location = New System.Drawing.Point(320, 155)
        Me.lb_Alert.Name = "lb_Alert"
        Me.lb_Alert.Size = New System.Drawing.Size(140, 18)
        Me.lb_Alert.TabIndex = 3
        Me.lb_Alert.Text = "ID has been copied."
        '
        'Type_Group
        '
        Me.Type_Group.Controls.Add(Me.radio_B)
        Me.Type_Group.Controls.Add(Me.radio_A)
        Me.Type_Group.Location = New System.Drawing.Point(12, 12)
        Me.Type_Group.Name = "Type_Group"
        Me.Type_Group.Size = New System.Drawing.Size(448, 62)
        Me.Type_Group.TabIndex = 5
        Me.Type_Group.TabStop = False
        Me.Type_Group.Text = "ID Type"
        '
        'radio_A
        '
        Me.radio_A.AutoSize = True
        Me.radio_A.Checked = True
        Me.radio_A.Location = New System.Drawing.Point(13, 25)
        Me.radio_A.Name = "radio_A"
        Me.radio_A.Size = New System.Drawing.Size(74, 22)
        Me.radio_A.TabIndex = 0
        Me.radio_A.TabStop = True
        Me.radio_A.Text = "A Type"
        Me.radio_A.UseVisualStyleBackColor = True
        '
        'radio_B
        '
        Me.radio_B.AutoSize = True
        Me.radio_B.Location = New System.Drawing.Point(93, 25)
        Me.radio_B.Name = "radio_B"
        Me.radio_B.Size = New System.Drawing.Size(74, 22)
        Me.radio_B.TabIndex = 1
        Me.radio_B.TabStop = True
        Me.radio_B.Text = "B Type"
        Me.radio_B.UseVisualStyleBackColor = True
        '
        'checkbox_RandomCopy
        '
        Me.checkbox_RandomCopy.AutoSize = True
        Me.checkbox_RandomCopy.Location = New System.Drawing.Point(12, 125)
        Me.checkbox_RandomCopy.Name = "checkbox_RandomCopy"
        Me.checkbox_RandomCopy.Size = New System.Drawing.Size(148, 22)
        Me.checkbox_RandomCopy.TabIndex = 6
        Me.checkbox_RandomCopy.Text = "Random and Copy"
        Me.checkbox_RandomCopy.UseVisualStyleBackColor = True
        '
        'frm_CreateID
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(472, 191)
        Me.Controls.Add(Me.checkbox_RandomCopy)
        Me.Controls.Add(Me.Type_Group)
        Me.Controls.Add(Me.lb_Alert)
        Me.Controls.Add(Me.btn_Copy)
        Me.Controls.Add(Me.btn_Random)
        Me.Controls.Add(Me.tbox_Result)
        Me.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frm_CreateID"
        Me.Text = "DevTools - ID Random"
        Me.Type_Group.ResumeLayout(False)
        Me.Type_Group.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbox_Result As System.Windows.Forms.TextBox
    Friend WithEvents btn_Random As System.Windows.Forms.Button
    Friend WithEvents btn_Copy As System.Windows.Forms.Button
    Friend WithEvents lb_Alert As System.Windows.Forms.Label
    Friend WithEvents Type_Group As System.Windows.Forms.GroupBox
    Friend WithEvents radio_B As System.Windows.Forms.RadioButton
    Friend WithEvents radio_A As System.Windows.Forms.RadioButton
    Friend WithEvents checkbox_RandomCopy As System.Windows.Forms.CheckBox
End Class
