<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ItemFind
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
        Dim Padding1 As DevComponents.DotNetBar.SuperGrid.Style.Padding = New DevComponents.DotNetBar.SuperGrid.Style.Padding()
        Dim Background1 As DevComponents.DotNetBar.SuperGrid.Style.Background = New DevComponents.DotNetBar.SuperGrid.Style.Background()
        Dim Padding2 As DevComponents.DotNetBar.SuperGrid.Style.Padding = New DevComponents.DotNetBar.SuperGrid.Style.Padding()
        Dim Padding3 As DevComponents.DotNetBar.SuperGrid.Style.Padding = New DevComponents.DotNetBar.SuperGrid.Style.Padding()
        Dim Background2 As DevComponents.DotNetBar.SuperGrid.Style.Background = New DevComponents.DotNetBar.SuperGrid.Style.Background()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_ItemFind))
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.ComboBoxEx1 = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.ComboBoxEx2 = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.ComboBoxEx3 = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.TextBoxX2 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Line1 = New DevComponents.DotNetBar.Controls.Line()
        Me.supergridview_RoomList = New DevComponents.DotNetBar.SuperGrid.SuperGridControl()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX3 = New DevComponents.DotNetBar.ButtonX()
        Me.SuspendLayout()
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(12, 60)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LabelX1.Size = New System.Drawing.Size(100, 22)
        Me.LabelX1.TabIndex = 0
        Me.LabelX1.Text = "หมวดหมู่ :"
        '
        'ComboBoxEx1
        '
        Me.ComboBoxEx1.DisplayMember = "Text"
        Me.ComboBoxEx1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ComboBoxEx1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxEx1.ForeColor = System.Drawing.Color.Black
        Me.ComboBoxEx1.FormattingEnabled = True
        Me.ComboBoxEx1.ItemHeight = 17
        Me.ComboBoxEx1.Location = New System.Drawing.Point(118, 60)
        Me.ComboBoxEx1.Name = "ComboBoxEx1"
        Me.ComboBoxEx1.Size = New System.Drawing.Size(352, 23)
        Me.ComboBoxEx1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ComboBoxEx1.TabIndex = 1
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(12, 88)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LabelX2.Size = New System.Drawing.Size(100, 22)
        Me.LabelX2.TabIndex = 0
        Me.LabelX2.Text = "กลุ่ม :"
        '
        'ComboBoxEx2
        '
        Me.ComboBoxEx2.DisplayMember = "Text"
        Me.ComboBoxEx2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ComboBoxEx2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxEx2.ForeColor = System.Drawing.Color.Black
        Me.ComboBoxEx2.FormattingEnabled = True
        Me.ComboBoxEx2.ItemHeight = 17
        Me.ComboBoxEx2.Location = New System.Drawing.Point(118, 88)
        Me.ComboBoxEx2.Name = "ComboBoxEx2"
        Me.ComboBoxEx2.Size = New System.Drawing.Size(352, 23)
        Me.ComboBoxEx2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ComboBoxEx2.TabIndex = 1
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Location = New System.Drawing.Point(12, 117)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LabelX3.Size = New System.Drawing.Size(100, 22)
        Me.LabelX3.TabIndex = 0
        Me.LabelX3.Text = "ผู้ผลิต/ผู้จำหน่าย :"
        '
        'ComboBoxEx3
        '
        Me.ComboBoxEx3.DisplayMember = "Text"
        Me.ComboBoxEx3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ComboBoxEx3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxEx3.ForeColor = System.Drawing.Color.Black
        Me.ComboBoxEx3.FormattingEnabled = True
        Me.ComboBoxEx3.ItemHeight = 17
        Me.ComboBoxEx3.Location = New System.Drawing.Point(118, 117)
        Me.ComboBoxEx3.Name = "ComboBoxEx3"
        Me.ComboBoxEx3.Size = New System.Drawing.Size(352, 23)
        Me.ComboBoxEx3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ComboBoxEx3.TabIndex = 1
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Location = New System.Drawing.Point(12, 12)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LabelX4.Size = New System.Drawing.Size(100, 22)
        Me.LabelX4.TabIndex = 0
        Me.LabelX4.Text = "คำค้นหา :"
        '
        'TextBoxX2
        '
        Me.TextBoxX2.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.TextBoxX2.Border.Class = "TextBoxBorder"
        Me.TextBoxX2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TextBoxX2.DisabledBackColor = System.Drawing.Color.White
        Me.TextBoxX2.ForeColor = System.Drawing.Color.Black
        Me.TextBoxX2.Location = New System.Drawing.Point(118, 12)
        Me.TextBoxX2.Name = "TextBoxX2"
        Me.TextBoxX2.PreventEnterBeep = True
        Me.TextBoxX2.Size = New System.Drawing.Size(352, 22)
        Me.TextBoxX2.TabIndex = 7
        '
        'Line1
        '
        Me.Line1.ForeColor = System.Drawing.Color.LightGray
        Me.Line1.Location = New System.Drawing.Point(118, 40)
        Me.Line1.Name = "Line1"
        Me.Line1.Size = New System.Drawing.Size(352, 14)
        Me.Line1.TabIndex = 8
        Me.Line1.Text = "Line1"
        '
        'supergridview_RoomList
        '
        Me.supergridview_RoomList.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.supergridview_RoomList.DefaultVisualStyles.CellStyles.Default.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Padding1.Left = 5
        Padding1.Right = 5
        Me.supergridview_RoomList.DefaultVisualStyles.CellStyles.Default.Padding = Padding1
        Background1.Color1 = System.Drawing.Color.WhiteSmoke
        Background1.Color2 = System.Drawing.Color.WhiteSmoke
        Me.supergridview_RoomList.DefaultVisualStyles.CellStyles.MouseOver.Background = Background1
        Me.supergridview_RoomList.DefaultVisualStyles.ColumnHeaderStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleLeft
        Me.supergridview_RoomList.DefaultVisualStyles.ColumnHeaderStyles.Default.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Padding2.Left = 5
        Padding2.Right = 5
        Me.supergridview_RoomList.DefaultVisualStyles.ColumnHeaderStyles.Default.Padding = Padding2
        Me.supergridview_RoomList.DefaultVisualStyles.FilterColumnHeaderStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleLeft
        Me.supergridview_RoomList.DefaultVisualStyles.FilterColumnHeaderStyles.Default.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.supergridview_RoomList.DefaultVisualStyles.FooterStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleLeft
        Me.supergridview_RoomList.DefaultVisualStyles.FooterStyles.Default.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Padding3.Left = 5
        Padding3.Right = 5
        Me.supergridview_RoomList.DefaultVisualStyles.FooterStyles.Default.Padding = Padding3
        Me.supergridview_RoomList.DefaultVisualStyles.GroupHeaderStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleLeft
        Background2.Color1 = System.Drawing.Color.WhiteSmoke
        Background2.Color2 = System.Drawing.Color.WhiteSmoke
        Me.supergridview_RoomList.DefaultVisualStyles.GroupHeaderStyles.Default.Background = Background2
        Me.supergridview_RoomList.DefaultVisualStyles.GroupHeaderStyles.Default.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.supergridview_RoomList.FilterExprColors.SysFunction = System.Drawing.Color.Empty
        Me.supergridview_RoomList.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.supergridview_RoomList.ForeColor = System.Drawing.Color.Black
        Me.supergridview_RoomList.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F"
        Me.supergridview_RoomList.Location = New System.Drawing.Point(12, 155)
        Me.supergridview_RoomList.Name = "supergridview_RoomList"
        '
        '
        '
        Me.supergridview_RoomList.PrimaryGrid.AllowEdit = False
        Me.supergridview_RoomList.PrimaryGrid.AutoExpandSetGroup = True
        '
        '
        '
        Me.supergridview_RoomList.PrimaryGrid.Caption.Text = ""
        Me.supergridview_RoomList.PrimaryGrid.ColumnAutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.Fill
        '
        '
        '
        Me.supergridview_RoomList.PrimaryGrid.ColumnHeader.RowHeight = 24
        Me.supergridview_RoomList.PrimaryGrid.DefaultRowHeight = 24
        '
        '
        '
        Me.supergridview_RoomList.PrimaryGrid.Filter.RowHeight = 24
        Me.supergridview_RoomList.PrimaryGrid.FocusCuesEnabled = False
        '
        '
        '
        Me.supergridview_RoomList.PrimaryGrid.Footer.RowHeight = 20
        '
        '
        '
        Me.supergridview_RoomList.PrimaryGrid.GroupByRow.AllowUserSort = False
        Me.supergridview_RoomList.PrimaryGrid.GroupByRow.Text = ""
        Me.supergridview_RoomList.PrimaryGrid.GroupByRow.WatermarkText = "ลากและวางคอลัมน์ที่นี่เพื่อจัดกลุ่ม"
        '
        '
        '
        Me.supergridview_RoomList.PrimaryGrid.Header.Text = ""
        Me.supergridview_RoomList.PrimaryGrid.RowFocusMode = DevComponents.DotNetBar.SuperGrid.RowFocusMode.CellsOnly
        Me.supergridview_RoomList.PrimaryGrid.RowHeaderIndexOffset = 1
        Me.supergridview_RoomList.PrimaryGrid.RowHeaderWidth = 30
        Me.supergridview_RoomList.PrimaryGrid.SelectionGranularity = DevComponents.DotNetBar.SuperGrid.SelectionGranularity.Row
        Me.supergridview_RoomList.PrimaryGrid.ShowGroupUnderline = False
        Me.supergridview_RoomList.PrimaryGrid.ShowRowGridIndex = True
        '
        '
        '
        Me.supergridview_RoomList.PrimaryGrid.Title.Text = ""
        Me.supergridview_RoomList.PrimaryGrid.TopLeftHeaderSelectBehavior = DevComponents.DotNetBar.SuperGrid.TopLeftHeaderSelectBehavior.NoSelection
        Me.supergridview_RoomList.Size = New System.Drawing.Size(590, 279)
        Me.supergridview_RoomList.TabIndex = 14
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Location = New System.Drawing.Point(486, 12)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(116, 28)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.TabIndex = 15
        Me.ButtonX1.Text = "ค้นหา"
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX2.Location = New System.Drawing.Point(486, 46)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Size = New System.Drawing.Size(116, 28)
        Me.ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX2.TabIndex = 15
        Me.ButtonX2.Text = "รีเซทการค้นหา"
        '
        'ButtonX3
        '
        Me.ButtonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX3.Location = New System.Drawing.Point(486, 80)
        Me.ButtonX3.Name = "ButtonX3"
        Me.ButtonX3.Size = New System.Drawing.Size(116, 28)
        Me.ButtonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX3.TabIndex = 15
        Me.ButtonX3.Text = "แสดงรายการทั้งหมด"
        '
        'frm_ItemFind
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BottomLeftCornerSize = 0
        Me.BottomRightCornerSize = 0
        Me.CaptionFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ClientSize = New System.Drawing.Size(614, 446)
        Me.Controls.Add(Me.ButtonX3)
        Me.Controls.Add(Me.ButtonX2)
        Me.Controls.Add(Me.ButtonX1)
        Me.Controls.Add(Me.supergridview_RoomList)
        Me.Controls.Add(Me.Line1)
        Me.Controls.Add(Me.TextBoxX2)
        Me.Controls.Add(Me.ComboBoxEx3)
        Me.Controls.Add(Me.LabelX3)
        Me.Controls.Add(Me.ComboBoxEx2)
        Me.Controls.Add(Me.LabelX2)
        Me.Controls.Add(Me.LabelX4)
        Me.Controls.Add(Me.ComboBoxEx1)
        Me.Controls.Add(Me.LabelX1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_ItemFind"
        Me.RenderFormIcon = False
        Me.Text = "ค้นหารายการ"
        Me.TopLeftCornerSize = 0
        Me.TopRightCornerSize = 0
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents ComboBoxEx1 As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents ComboBoxEx2 As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents ComboBoxEx3 As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents TextBoxX2 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Line1 As DevComponents.DotNetBar.Controls.Line
    Friend WithEvents supergridview_RoomList As DevComponents.DotNetBar.SuperGrid.SuperGridControl
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX3 As DevComponents.DotNetBar.ButtonX
End Class
