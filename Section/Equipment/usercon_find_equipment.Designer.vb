<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usercon_find_equipment
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim Padding4 As DevComponents.DotNetBar.SuperGrid.Style.Padding = New DevComponents.DotNetBar.SuperGrid.Style.Padding()
        Dim Background3 As DevComponents.DotNetBar.SuperGrid.Style.Background = New DevComponents.DotNetBar.SuperGrid.Style.Background()
        Dim Padding5 As DevComponents.DotNetBar.SuperGrid.Style.Padding = New DevComponents.DotNetBar.SuperGrid.Style.Padding()
        Dim Padding6 As DevComponents.DotNetBar.SuperGrid.Style.Padding = New DevComponents.DotNetBar.SuperGrid.Style.Padding()
        Dim Background4 As DevComponents.DotNetBar.SuperGrid.Style.Background = New DevComponents.DotNetBar.SuperGrid.Style.Background()
        Me.toolbar_RoomAction = New DevComponents.DotNetBar.Bar()
        Me.ButtonItem_Refresh = New DevComponents.DotNetBar.ButtonItem()
        Me.CheckBoxItem_ShowStockInfo = New DevComponents.DotNetBar.CheckBoxItem()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.Line1 = New DevComponents.DotNetBar.Controls.Line()
        Me.TextBox_TextSearch = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.ComboBoxEx3 = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.ComboBoxEx2 = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.ComboBoxEx5 = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboBoxEx6 = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboBoxEx4 = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboBoxEx1 = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.supergridview_RoomList = New DevComponents.DotNetBar.SuperGrid.SuperGridControl()
        Me.SuperGridView_Items = New DevComponents.DotNetBar.SuperGrid.SuperGridControl()
        Me.CheckBox_ShowStockInfo = New DevComponents.DotNetBar.Controls.CheckBoxX()
        CType(Me.toolbar_RoomAction, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelEx1.SuspendLayout()
        Me.SuspendLayout()
        '
        'toolbar_RoomAction
        '
        Me.toolbar_RoomAction.AccessibleDescription = "DotNetBar Bar (toolbar_RoomAction)"
        Me.toolbar_RoomAction.AccessibleName = "DotNetBar Bar"
        Me.toolbar_RoomAction.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar
        Me.toolbar_RoomAction.AntiAlias = True
        Me.toolbar_RoomAction.BarType = DevComponents.DotNetBar.eBarType.MenuBar
        Me.toolbar_RoomAction.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.toolbar_RoomAction.IsMaximized = False
        Me.toolbar_RoomAction.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.CheckBoxItem_ShowStockInfo, Me.ButtonItem_Refresh})
        Me.toolbar_RoomAction.ItemSpacing = 5
        Me.toolbar_RoomAction.Location = New System.Drawing.Point(6, 164)
        Me.toolbar_RoomAction.Name = "toolbar_RoomAction"
        Me.toolbar_RoomAction.Size = New System.Drawing.Size(986, 25)
        Me.toolbar_RoomAction.Stretch = True
        Me.toolbar_RoomAction.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.toolbar_RoomAction.TabIndex = 12
        Me.toolbar_RoomAction.TabStop = False
        '
        'ButtonItem_Refresh
        '
        Me.ButtonItem_Refresh.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem_Refresh.ImagePaddingHorizontal = 10
        Me.ButtonItem_Refresh.Name = "ButtonItem_Refresh"
        Me.ButtonItem_Refresh.Text = "รีเฟรชรายการ"
        '
        'CheckBoxItem_ShowStockInfo
        '
        Me.CheckBoxItem_ShowStockInfo.Name = "CheckBoxItem_ShowStockInfo"
        Me.CheckBoxItem_ShowStockInfo.Text = "แสดงข้อมูลสต็อก"
        '
        'PanelEx1
        '
        Me.PanelEx1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelEx1.CanvasColor = System.Drawing.Color.Empty
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.Line1)
        Me.PanelEx1.Controls.Add(Me.TextBox_TextSearch)
        Me.PanelEx1.Controls.Add(Me.ComboBoxEx3)
        Me.PanelEx1.Controls.Add(Me.LabelX3)
        Me.PanelEx1.Controls.Add(Me.LabelX6)
        Me.PanelEx1.Controls.Add(Me.LabelX7)
        Me.PanelEx1.Controls.Add(Me.ComboBoxEx2)
        Me.PanelEx1.Controls.Add(Me.LabelX2)
        Me.PanelEx1.Controls.Add(Me.LabelX4)
        Me.PanelEx1.Controls.Add(Me.ComboBoxEx5)
        Me.PanelEx1.Controls.Add(Me.ComboBoxEx6)
        Me.PanelEx1.Controls.Add(Me.ComboBoxEx4)
        Me.PanelEx1.Controls.Add(Me.ComboBoxEx1)
        Me.PanelEx1.Controls.Add(Me.LabelX5)
        Me.PanelEx1.Controls.Add(Me.LabelX1)
        Me.PanelEx1.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.PanelEx1.Location = New System.Drawing.Point(6, 6)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Padding = New System.Windows.Forms.Padding(8)
        Me.PanelEx1.Size = New System.Drawing.Size(986, 150)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 14
        '
        'Line1
        '
        Me.Line1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Line1.ForeColor = System.Drawing.Color.LightGray
        Me.Line1.Location = New System.Drawing.Point(11, 39)
        Me.Line1.Name = "Line1"
        Me.Line1.Size = New System.Drawing.Size(964, 14)
        Me.Line1.TabIndex = 24
        Me.Line1.Text = "Line1"
        '
        'TextBox_TextSearch
        '
        Me.TextBox_TextSearch.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.TextBox_TextSearch.Border.Class = "TextBoxBorder"
        Me.TextBox_TextSearch.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TextBox_TextSearch.DisabledBackColor = System.Drawing.Color.White
        Me.TextBox_TextSearch.ForeColor = System.Drawing.Color.Black
        Me.TextBox_TextSearch.Location = New System.Drawing.Point(102, 11)
        Me.TextBox_TextSearch.Name = "TextBox_TextSearch"
        Me.TextBox_TextSearch.PreventEnterBeep = True
        Me.TextBox_TextSearch.Size = New System.Drawing.Size(250, 22)
        Me.TextBox_TextSearch.TabIndex = 23
        Me.TextBox_TextSearch.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty
        Me.TextBox_TextSearch.WatermarkText = "ป้อนเพื่อค้นหาด้วยรหัสหรือชื่อรายการ"
        '
        'ComboBoxEx3
        '
        Me.ComboBoxEx3.DisplayMember = "Text"
        Me.ComboBoxEx3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ComboBoxEx3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxEx3.ForeColor = System.Drawing.Color.Black
        Me.ComboBoxEx3.FormattingEnabled = True
        Me.ComboBoxEx3.ItemHeight = 17
        Me.ComboBoxEx3.Location = New System.Drawing.Point(474, 59)
        Me.ComboBoxEx3.Name = "ComboBoxEx3"
        Me.ComboBoxEx3.Size = New System.Drawing.Size(250, 23)
        Me.ComboBoxEx3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ComboBoxEx3.TabIndex = 22
        Me.ComboBoxEx3.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty
        Me.ComboBoxEx3.WatermarkText = "ใช้การกรองด้วยประเภทวัสดุ"
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Location = New System.Drawing.Point(11, 59)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LabelX3.Size = New System.Drawing.Size(85, 23)
        Me.LabelX3.TabIndex = 17
        Me.LabelX3.Text = "ตำแหน่งจัดเก็บ :"
        '
        'LabelX6
        '
        '
        '
        '
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.Location = New System.Drawing.Point(368, 88)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LabelX6.Size = New System.Drawing.Size(100, 23)
        Me.LabelX6.TabIndex = 17
        Me.LabelX6.Text = "มาตรฐาน :"
        '
        'LabelX7
        '
        '
        '
        '
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX7.Location = New System.Drawing.Point(368, 117)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LabelX7.Size = New System.Drawing.Size(100, 23)
        Me.LabelX7.TabIndex = 17
        Me.LabelX7.Text = "ผู้ผลิต/ผู้จำหน่าย :"
        '
        'ComboBoxEx2
        '
        Me.ComboBoxEx2.DisplayMember = "Text"
        Me.ComboBoxEx2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ComboBoxEx2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxEx2.ForeColor = System.Drawing.Color.Black
        Me.ComboBoxEx2.FormattingEnabled = True
        Me.ComboBoxEx2.ItemHeight = 17
        Me.ComboBoxEx2.Location = New System.Drawing.Point(102, 117)
        Me.ComboBoxEx2.Name = "ComboBoxEx2"
        Me.ComboBoxEx2.Size = New System.Drawing.Size(250, 23)
        Me.ComboBoxEx2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ComboBoxEx2.TabIndex = 21
        Me.ComboBoxEx2.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty
        Me.ComboBoxEx2.WatermarkText = "ใช้การกรองด้วยหมวดหมู่ย่อย"
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(11, 117)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LabelX2.Size = New System.Drawing.Size(85, 23)
        Me.LabelX2.TabIndex = 16
        Me.LabelX2.Text = "หมวดหมู่ย่อย :"
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Location = New System.Drawing.Point(11, 11)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LabelX4.Size = New System.Drawing.Size(73, 22)
        Me.LabelX4.TabIndex = 18
        Me.LabelX4.Text = "คำค้นหา :"
        '
        'ComboBoxEx5
        '
        Me.ComboBoxEx5.DisplayMember = "Text"
        Me.ComboBoxEx5.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ComboBoxEx5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxEx5.ForeColor = System.Drawing.Color.Black
        Me.ComboBoxEx5.FormattingEnabled = True
        Me.ComboBoxEx5.ItemHeight = 17
        Me.ComboBoxEx5.Location = New System.Drawing.Point(102, 59)
        Me.ComboBoxEx5.Name = "ComboBoxEx5"
        Me.ComboBoxEx5.Size = New System.Drawing.Size(250, 23)
        Me.ComboBoxEx5.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ComboBoxEx5.TabIndex = 20
        Me.ComboBoxEx5.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty
        Me.ComboBoxEx5.WatermarkText = "ใช้การกรองด้วยตำแหน่งจัดเก็บ"
        '
        'ComboBoxEx6
        '
        Me.ComboBoxEx6.DisplayMember = "Text"
        Me.ComboBoxEx6.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ComboBoxEx6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxEx6.ForeColor = System.Drawing.Color.Black
        Me.ComboBoxEx6.FormattingEnabled = True
        Me.ComboBoxEx6.ItemHeight = 17
        Me.ComboBoxEx6.Location = New System.Drawing.Point(474, 88)
        Me.ComboBoxEx6.Name = "ComboBoxEx6"
        Me.ComboBoxEx6.Size = New System.Drawing.Size(250, 23)
        Me.ComboBoxEx6.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ComboBoxEx6.TabIndex = 20
        Me.ComboBoxEx6.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty
        Me.ComboBoxEx6.WatermarkText = "ใช้การกรองด้วยมาตรฐาน"
        '
        'ComboBoxEx4
        '
        Me.ComboBoxEx4.DisplayMember = "Text"
        Me.ComboBoxEx4.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ComboBoxEx4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxEx4.ForeColor = System.Drawing.Color.Black
        Me.ComboBoxEx4.FormattingEnabled = True
        Me.ComboBoxEx4.ItemHeight = 17
        Me.ComboBoxEx4.Location = New System.Drawing.Point(474, 117)
        Me.ComboBoxEx4.Name = "ComboBoxEx4"
        Me.ComboBoxEx4.Size = New System.Drawing.Size(250, 23)
        Me.ComboBoxEx4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ComboBoxEx4.TabIndex = 20
        Me.ComboBoxEx4.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty
        Me.ComboBoxEx4.WatermarkText = "ใช้การกรองด้วยผู้ผลิตหรือผู้จำหน่าย"
        '
        'ComboBoxEx1
        '
        Me.ComboBoxEx1.DisplayMember = "Text"
        Me.ComboBoxEx1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ComboBoxEx1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxEx1.ForeColor = System.Drawing.Color.Black
        Me.ComboBoxEx1.FormattingEnabled = True
        Me.ComboBoxEx1.ItemHeight = 17
        Me.ComboBoxEx1.Location = New System.Drawing.Point(102, 88)
        Me.ComboBoxEx1.Name = "ComboBoxEx1"
        Me.ComboBoxEx1.Size = New System.Drawing.Size(250, 23)
        Me.ComboBoxEx1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ComboBoxEx1.TabIndex = 20
        Me.ComboBoxEx1.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty
        Me.ComboBoxEx1.WatermarkText = "ใช้การกรองด้วยตำแหน่งหมวดหมู่หลัก"
        '
        'LabelX5
        '
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Location = New System.Drawing.Point(368, 59)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LabelX5.Size = New System.Drawing.Size(85, 23)
        Me.LabelX5.TabIndex = 19
        Me.LabelX5.Text = "วัสดุ :"
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(11, 88)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LabelX1.Size = New System.Drawing.Size(85, 23)
        Me.LabelX1.TabIndex = 19
        Me.LabelX1.Text = "หมวดหมู่หลัก :"
        '
        'supergridview_RoomList
        '
        Me.supergridview_RoomList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.supergridview_RoomList.Location = New System.Drawing.Point(6, 195)
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
        Me.supergridview_RoomList.PrimaryGrid.GroupByRow.Visible = True
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
        Me.supergridview_RoomList.Size = New System.Drawing.Size(986, 449)
        Me.supergridview_RoomList.TabIndex = 13
        '
        'SuperGridView_Items
        '
        Me.SuperGridView_Items.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SuperGridView_Items.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.SuperGridView_Items.DefaultVisualStyles.CellStyles.Default.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Padding4.Left = 5
        Padding4.Right = 5
        Me.SuperGridView_Items.DefaultVisualStyles.CellStyles.Default.Padding = Padding4
        Background3.Color1 = System.Drawing.Color.WhiteSmoke
        Background3.Color2 = System.Drawing.Color.WhiteSmoke
        Me.SuperGridView_Items.DefaultVisualStyles.CellStyles.MouseOver.Background = Background3
        Me.SuperGridView_Items.DefaultVisualStyles.ColumnHeaderStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleLeft
        Me.SuperGridView_Items.DefaultVisualStyles.ColumnHeaderStyles.Default.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Padding5.Left = 5
        Padding5.Right = 5
        Me.SuperGridView_Items.DefaultVisualStyles.ColumnHeaderStyles.Default.Padding = Padding5
        Me.SuperGridView_Items.DefaultVisualStyles.FilterColumnHeaderStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleLeft
        Me.SuperGridView_Items.DefaultVisualStyles.FilterColumnHeaderStyles.Default.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.SuperGridView_Items.DefaultVisualStyles.FooterStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleLeft
        Me.SuperGridView_Items.DefaultVisualStyles.FooterStyles.Default.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Padding6.Left = 5
        Padding6.Right = 5
        Me.SuperGridView_Items.DefaultVisualStyles.FooterStyles.Default.Padding = Padding6
        Me.SuperGridView_Items.DefaultVisualStyles.GroupHeaderStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleLeft
        Background4.Color1 = System.Drawing.Color.WhiteSmoke
        Background4.Color2 = System.Drawing.Color.WhiteSmoke
        Me.SuperGridView_Items.DefaultVisualStyles.GroupHeaderStyles.Default.Background = Background4
        Me.SuperGridView_Items.DefaultVisualStyles.GroupHeaderStyles.Default.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.SuperGridView_Items.FilterExprColors.SysFunction = System.Drawing.Color.Empty
        Me.SuperGridView_Items.ForeColor = System.Drawing.Color.Black
        Me.SuperGridView_Items.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F"
        Me.SuperGridView_Items.Location = New System.Drawing.Point(6, 195)
        Me.SuperGridView_Items.Name = "SuperGridView_Items"
        '
        '
        '
        Me.SuperGridView_Items.PrimaryGrid.AllowEdit = False
        Me.SuperGridView_Items.PrimaryGrid.AutoExpandSetGroup = True
        Me.SuperGridView_Items.PrimaryGrid.ColumnAutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.DisplayedCells
        '
        '
        '
        Me.SuperGridView_Items.PrimaryGrid.ColumnHeader.RowHeight = 24
        Me.SuperGridView_Items.PrimaryGrid.DefaultRowHeight = 24
        '
        '
        '
        Me.SuperGridView_Items.PrimaryGrid.Filter.RowHeight = 24
        Me.SuperGridView_Items.PrimaryGrid.FocusCuesEnabled = False
        '
        '
        '
        Me.SuperGridView_Items.PrimaryGrid.Footer.RowHeight = 20
        '
        '
        '
        Me.SuperGridView_Items.PrimaryGrid.GroupByRow.AllowUserSort = False
        Me.SuperGridView_Items.PrimaryGrid.GroupByRow.Text = ""
        Me.SuperGridView_Items.PrimaryGrid.GroupByRow.Visible = True
        '
        '
        '
        Me.SuperGridView_Items.PrimaryGrid.Header.Text = ""
        Me.SuperGridView_Items.PrimaryGrid.KeyboardEditMode = DevComponents.DotNetBar.SuperGrid.KeyboardEditMode.None
        Me.SuperGridView_Items.PrimaryGrid.RowHeaderIndexOffset = 1
        Me.SuperGridView_Items.PrimaryGrid.RowHeaderWidth = 30
        Me.SuperGridView_Items.PrimaryGrid.SelectionGranularity = DevComponents.DotNetBar.SuperGrid.SelectionGranularity.Row
        Me.SuperGridView_Items.PrimaryGrid.ShowGroupUnderline = False
        Me.SuperGridView_Items.PrimaryGrid.ShowRowGridIndex = True
        '
        '
        '
        Me.SuperGridView_Items.PrimaryGrid.Title.Text = ""
        Me.SuperGridView_Items.PrimaryGrid.TopLeftHeaderSelectBehavior = DevComponents.DotNetBar.SuperGrid.TopLeftHeaderSelectBehavior.NoSelection
        Me.SuperGridView_Items.Size = New System.Drawing.Size(986, 449)
        Me.SuperGridView_Items.TabIndex = 18
        Me.SuperGridView_Items.Text = "SuperGridControl1"
        '
        'CheckBox_ShowStockInfo
        '
        Me.CheckBox_ShowStockInfo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBox_ShowStockInfo.AutoSize = True
        '
        '
        '
        Me.CheckBox_ShowStockInfo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.CheckBox_ShowStockInfo.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.CheckBox_ShowStockInfo.Location = New System.Drawing.Point(3, 3)
        Me.CheckBox_ShowStockInfo.Name = "CheckBox_ShowStockInfo"
        Me.CheckBox_ShowStockInfo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CheckBox_ShowStockInfo.Size = New System.Drawing.Size(108, 17)
        Me.CheckBox_ShowStockInfo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.CheckBox_ShowStockInfo.TabIndex = 25
        Me.CheckBox_ShowStockInfo.Text = "แสดงข้อมูลสต็อก"
        '
        'usercon_find_equipment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SuperGridView_Items)
        Me.Controls.Add(Me.PanelEx1)
        Me.Controls.Add(Me.toolbar_RoomAction)
        Me.Name = "usercon_find_equipment"
        Me.Padding = New System.Windows.Forms.Padding(3)
        Me.Size = New System.Drawing.Size(998, 650)
        CType(Me.toolbar_RoomAction, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelEx1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents toolbar_RoomAction As DevComponents.DotNetBar.Bar
    Friend WithEvents ButtonItem_Refresh As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Line1 As DevComponents.DotNetBar.Controls.Line
    Friend WithEvents TextBox_TextSearch As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents ComboBoxEx3 As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboBoxEx2 As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents ComboBoxEx1 As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents ComboBoxEx4 As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents ComboBoxEx5 As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents ComboBoxEx6 As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents supergridview_RoomList As DevComponents.DotNetBar.SuperGrid.SuperGridControl
    Friend WithEvents SuperGridView_Items As DevComponents.DotNetBar.SuperGrid.SuperGridControl
    Friend WithEvents CheckBox_ShowStockInfo As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents CheckBoxItem_ShowStockInfo As DevComponents.DotNetBar.CheckBoxItem

End Class
