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
        Dim Padding4 As DevComponents.DotNetBar.SuperGrid.Style.Padding = New DevComponents.DotNetBar.SuperGrid.Style.Padding()
        Dim Background3 As DevComponents.DotNetBar.SuperGrid.Style.Background = New DevComponents.DotNetBar.SuperGrid.Style.Background()
        Dim Padding5 As DevComponents.DotNetBar.SuperGrid.Style.Padding = New DevComponents.DotNetBar.SuperGrid.Style.Padding()
        Dim Padding6 As DevComponents.DotNetBar.SuperGrid.Style.Padding = New DevComponents.DotNetBar.SuperGrid.Style.Padding()
        Dim Background4 As DevComponents.DotNetBar.SuperGrid.Style.Background = New DevComponents.DotNetBar.SuperGrid.Style.Background()
        Dim Padding7 As DevComponents.DotNetBar.SuperGrid.Style.Padding = New DevComponents.DotNetBar.SuperGrid.Style.Padding()
        Dim Background5 As DevComponents.DotNetBar.SuperGrid.Style.Background = New DevComponents.DotNetBar.SuperGrid.Style.Background()
        Dim Padding8 As DevComponents.DotNetBar.SuperGrid.Style.Padding = New DevComponents.DotNetBar.SuperGrid.Style.Padding()
        Dim Padding9 As DevComponents.DotNetBar.SuperGrid.Style.Padding = New DevComponents.DotNetBar.SuperGrid.Style.Padding()
        Dim Background6 As DevComponents.DotNetBar.SuperGrid.Style.Background = New DevComponents.DotNetBar.SuperGrid.Style.Background()
        Me.toolbar_RoomAction = New DevComponents.DotNetBar.Bar()
        Me.CheckBoxItem_ShowStockInfo = New DevComponents.DotNetBar.CheckBoxItem()
        Me.ButtonItem_Refresh = New DevComponents.DotNetBar.ButtonItem()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.Line1 = New DevComponents.DotNetBar.Controls.Line()
        Me.TextBox_TextSearch = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.ComboBox_MaterialType = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.Label_Locations = New DevComponents.DotNetBar.LabelX()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.ComboBox_SubCategories = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.ComboBox_Locations = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboBox_StandardCode = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboBox_Supplier = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboBox_Categories = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.supergridview_RoomList = New DevComponents.DotNetBar.SuperGrid.SuperGridControl()
        Me.SuperGridView_Items = New DevComponents.DotNetBar.SuperGrid.SuperGridControl()
        Me.CheckBox_ShowStockInfo = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.ComboBox_Brand = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.Label_Brand = New DevComponents.DotNetBar.LabelX()
        Me.Button_FormReset = New DevComponents.DotNetBar.ButtonX()
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
        Me.toolbar_RoomAction.Location = New System.Drawing.Point(6, 194)
        Me.toolbar_RoomAction.Name = "toolbar_RoomAction"
        Me.toolbar_RoomAction.Size = New System.Drawing.Size(986, 25)
        Me.toolbar_RoomAction.Stretch = True
        Me.toolbar_RoomAction.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.toolbar_RoomAction.TabIndex = 12
        Me.toolbar_RoomAction.TabStop = False
        '
        'CheckBoxItem_ShowStockInfo
        '
        Me.CheckBoxItem_ShowStockInfo.Name = "CheckBoxItem_ShowStockInfo"
        Me.CheckBoxItem_ShowStockInfo.Text = "แสดงข้อมูลสต็อก"
        '
        'ButtonItem_Refresh
        '
        Me.ButtonItem_Refresh.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem_Refresh.ImagePaddingHorizontal = 10
        Me.ButtonItem_Refresh.Name = "ButtonItem_Refresh"
        Me.ButtonItem_Refresh.Text = "รีเฟรชรายการ"
        '
        'PanelEx1
        '
        Me.PanelEx1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelEx1.CanvasColor = System.Drawing.Color.Empty
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.Button_FormReset)
        Me.PanelEx1.Controls.Add(Me.ComboBox_Brand)
        Me.PanelEx1.Controls.Add(Me.Label_Brand)
        Me.PanelEx1.Controls.Add(Me.Line1)
        Me.PanelEx1.Controls.Add(Me.TextBox_TextSearch)
        Me.PanelEx1.Controls.Add(Me.ComboBox_MaterialType)
        Me.PanelEx1.Controls.Add(Me.Label_Locations)
        Me.PanelEx1.Controls.Add(Me.LabelX6)
        Me.PanelEx1.Controls.Add(Me.LabelX7)
        Me.PanelEx1.Controls.Add(Me.ComboBox_SubCategories)
        Me.PanelEx1.Controls.Add(Me.LabelX2)
        Me.PanelEx1.Controls.Add(Me.LabelX4)
        Me.PanelEx1.Controls.Add(Me.ComboBox_Locations)
        Me.PanelEx1.Controls.Add(Me.ComboBox_StandardCode)
        Me.PanelEx1.Controls.Add(Me.ComboBox_Supplier)
        Me.PanelEx1.Controls.Add(Me.ComboBox_Categories)
        Me.PanelEx1.Controls.Add(Me.LabelX5)
        Me.PanelEx1.Controls.Add(Me.LabelX1)
        Me.PanelEx1.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.PanelEx1.Location = New System.Drawing.Point(6, 6)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Padding = New System.Windows.Forms.Padding(8)
        Me.PanelEx1.Size = New System.Drawing.Size(1125, 182)
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
        Me.Line1.Size = New System.Drawing.Size(1103, 14)
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
        Me.TextBox_TextSearch.Size = New System.Drawing.Size(300, 22)
        Me.TextBox_TextSearch.TabIndex = 23
        Me.TextBox_TextSearch.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty
        Me.TextBox_TextSearch.WatermarkText = "ป้อนเพื่อค้นหาด้วยรหัสหรือชื่อรายการ"
        '
        'ComboBox_MaterialType
        '
        Me.ComboBox_MaterialType.DisplayMember = "Text"
        Me.ComboBox_MaterialType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ComboBox_MaterialType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_MaterialType.ForeColor = System.Drawing.Color.Black
        Me.ComboBox_MaterialType.FormattingEnabled = True
        Me.ComboBox_MaterialType.ItemHeight = 17
        Me.ComboBox_MaterialType.Location = New System.Drawing.Point(102, 146)
        Me.ComboBox_MaterialType.Name = "ComboBox_MaterialType"
        Me.ComboBox_MaterialType.Size = New System.Drawing.Size(300, 23)
        Me.ComboBox_MaterialType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ComboBox_MaterialType.TabIndex = 22
        Me.ComboBox_MaterialType.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty
        Me.ComboBox_MaterialType.WatermarkText = "ใช้การกรองด้วยประเภทวัสดุ"
        '
        'Label_Locations
        '
        '
        '
        '
        Me.Label_Locations.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Label_Locations.Location = New System.Drawing.Point(11, 59)
        Me.Label_Locations.Name = "Label_Locations"
        Me.Label_Locations.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label_Locations.Size = New System.Drawing.Size(85, 23)
        Me.Label_Locations.TabIndex = 17
        Me.Label_Locations.Text = "ตำแหน่งจัดเก็บ :"
        '
        'LabelX6
        '
        '
        '
        '
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.Location = New System.Drawing.Point(419, 59)
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
        Me.LabelX7.Location = New System.Drawing.Point(419, 88)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LabelX7.Size = New System.Drawing.Size(100, 23)
        Me.LabelX7.TabIndex = 17
        Me.LabelX7.Text = "ผู้ผลิต/ผู้จำหน่าย :"
        '
        'ComboBox_SubCategories
        '
        Me.ComboBox_SubCategories.DisplayMember = "Text"
        Me.ComboBox_SubCategories.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ComboBox_SubCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_SubCategories.ForeColor = System.Drawing.Color.Black
        Me.ComboBox_SubCategories.FormattingEnabled = True
        Me.ComboBox_SubCategories.ItemHeight = 17
        Me.ComboBox_SubCategories.Location = New System.Drawing.Point(102, 117)
        Me.ComboBox_SubCategories.Name = "ComboBox_SubCategories"
        Me.ComboBox_SubCategories.Size = New System.Drawing.Size(300, 23)
        Me.ComboBox_SubCategories.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ComboBox_SubCategories.TabIndex = 21
        Me.ComboBox_SubCategories.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty
        Me.ComboBox_SubCategories.WatermarkText = "ใช้การกรองด้วยหมวดหมู่ย่อย"
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
        'ComboBox_Locations
        '
        Me.ComboBox_Locations.DisplayMember = "Text"
        Me.ComboBox_Locations.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ComboBox_Locations.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_Locations.ForeColor = System.Drawing.Color.Black
        Me.ComboBox_Locations.FormattingEnabled = True
        Me.ComboBox_Locations.ItemHeight = 17
        Me.ComboBox_Locations.Location = New System.Drawing.Point(102, 59)
        Me.ComboBox_Locations.Name = "ComboBox_Locations"
        Me.ComboBox_Locations.Size = New System.Drawing.Size(300, 23)
        Me.ComboBox_Locations.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ComboBox_Locations.TabIndex = 20
        Me.ComboBox_Locations.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty
        Me.ComboBox_Locations.WatermarkText = "ใช้การกรองด้วยตำแหน่งจัดเก็บ"
        '
        'ComboBox_StandardCode
        '
        Me.ComboBox_StandardCode.DisplayMember = "Text"
        Me.ComboBox_StandardCode.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ComboBox_StandardCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_StandardCode.ForeColor = System.Drawing.Color.Black
        Me.ComboBox_StandardCode.FormattingEnabled = True
        Me.ComboBox_StandardCode.ItemHeight = 17
        Me.ComboBox_StandardCode.Location = New System.Drawing.Point(525, 59)
        Me.ComboBox_StandardCode.Name = "ComboBox_StandardCode"
        Me.ComboBox_StandardCode.Size = New System.Drawing.Size(300, 23)
        Me.ComboBox_StandardCode.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ComboBox_StandardCode.TabIndex = 20
        Me.ComboBox_StandardCode.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty
        Me.ComboBox_StandardCode.WatermarkText = "ใช้การกรองด้วยมาตรฐาน"
        '
        'ComboBox_Supplier
        '
        Me.ComboBox_Supplier.DisplayMember = "Text"
        Me.ComboBox_Supplier.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ComboBox_Supplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_Supplier.ForeColor = System.Drawing.Color.Black
        Me.ComboBox_Supplier.FormattingEnabled = True
        Me.ComboBox_Supplier.ItemHeight = 17
        Me.ComboBox_Supplier.Location = New System.Drawing.Point(525, 88)
        Me.ComboBox_Supplier.Name = "ComboBox_Supplier"
        Me.ComboBox_Supplier.Size = New System.Drawing.Size(300, 23)
        Me.ComboBox_Supplier.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ComboBox_Supplier.TabIndex = 20
        Me.ComboBox_Supplier.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty
        Me.ComboBox_Supplier.WatermarkText = "ใช้การกรองด้วยผู้ผลิตหรือผู้จำหน่าย"
        '
        'ComboBox_Categories
        '
        Me.ComboBox_Categories.DisplayMember = "Text"
        Me.ComboBox_Categories.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ComboBox_Categories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_Categories.ForeColor = System.Drawing.Color.Black
        Me.ComboBox_Categories.FormattingEnabled = True
        Me.ComboBox_Categories.ItemHeight = 17
        Me.ComboBox_Categories.Location = New System.Drawing.Point(102, 88)
        Me.ComboBox_Categories.Name = "ComboBox_Categories"
        Me.ComboBox_Categories.Size = New System.Drawing.Size(300, 23)
        Me.ComboBox_Categories.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ComboBox_Categories.TabIndex = 20
        Me.ComboBox_Categories.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty
        Me.ComboBox_Categories.WatermarkText = "ใช้การกรองด้วยตำแหน่งหมวดหมู่หลัก"
        '
        'LabelX5
        '
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Location = New System.Drawing.Point(11, 146)
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
        Padding4.Left = 5
        Padding4.Right = 5
        Me.supergridview_RoomList.DefaultVisualStyles.CellStyles.Default.Padding = Padding4
        Background3.Color1 = System.Drawing.Color.WhiteSmoke
        Background3.Color2 = System.Drawing.Color.WhiteSmoke
        Me.supergridview_RoomList.DefaultVisualStyles.CellStyles.MouseOver.Background = Background3
        Me.supergridview_RoomList.DefaultVisualStyles.ColumnHeaderStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleLeft
        Me.supergridview_RoomList.DefaultVisualStyles.ColumnHeaderStyles.Default.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Padding5.Left = 5
        Padding5.Right = 5
        Me.supergridview_RoomList.DefaultVisualStyles.ColumnHeaderStyles.Default.Padding = Padding5
        Me.supergridview_RoomList.DefaultVisualStyles.FilterColumnHeaderStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleLeft
        Me.supergridview_RoomList.DefaultVisualStyles.FilterColumnHeaderStyles.Default.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.supergridview_RoomList.DefaultVisualStyles.FooterStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleLeft
        Me.supergridview_RoomList.DefaultVisualStyles.FooterStyles.Default.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Padding6.Left = 5
        Padding6.Right = 5
        Me.supergridview_RoomList.DefaultVisualStyles.FooterStyles.Default.Padding = Padding6
        Me.supergridview_RoomList.DefaultVisualStyles.GroupHeaderStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleLeft
        Background4.Color1 = System.Drawing.Color.WhiteSmoke
        Background4.Color2 = System.Drawing.Color.WhiteSmoke
        Me.supergridview_RoomList.DefaultVisualStyles.GroupHeaderStyles.Default.Background = Background4
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
        Padding7.Left = 5
        Padding7.Right = 5
        Me.SuperGridView_Items.DefaultVisualStyles.CellStyles.Default.Padding = Padding7
        Background5.Color1 = System.Drawing.Color.WhiteSmoke
        Background5.Color2 = System.Drawing.Color.WhiteSmoke
        Me.SuperGridView_Items.DefaultVisualStyles.CellStyles.MouseOver.Background = Background5
        Me.SuperGridView_Items.DefaultVisualStyles.ColumnHeaderStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleLeft
        Me.SuperGridView_Items.DefaultVisualStyles.ColumnHeaderStyles.Default.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Padding8.Left = 5
        Padding8.Right = 5
        Me.SuperGridView_Items.DefaultVisualStyles.ColumnHeaderStyles.Default.Padding = Padding8
        Me.SuperGridView_Items.DefaultVisualStyles.FilterColumnHeaderStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleLeft
        Me.SuperGridView_Items.DefaultVisualStyles.FilterColumnHeaderStyles.Default.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.SuperGridView_Items.DefaultVisualStyles.FooterStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleLeft
        Me.SuperGridView_Items.DefaultVisualStyles.FooterStyles.Default.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Padding9.Left = 5
        Padding9.Right = 5
        Me.SuperGridView_Items.DefaultVisualStyles.FooterStyles.Default.Padding = Padding9
        Me.SuperGridView_Items.DefaultVisualStyles.GroupHeaderStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleLeft
        Background6.Color1 = System.Drawing.Color.WhiteSmoke
        Background6.Color2 = System.Drawing.Color.WhiteSmoke
        Me.SuperGridView_Items.DefaultVisualStyles.GroupHeaderStyles.Default.Background = Background6
        Me.SuperGridView_Items.DefaultVisualStyles.GroupHeaderStyles.Default.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.SuperGridView_Items.FilterExprColors.SysFunction = System.Drawing.Color.Empty
        Me.SuperGridView_Items.ForeColor = System.Drawing.Color.Black
        Me.SuperGridView_Items.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F"
        Me.SuperGridView_Items.Location = New System.Drawing.Point(6, 225)
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
        Me.SuperGridView_Items.Size = New System.Drawing.Size(1125, 419)
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
        'ComboBox_Brand
        '
        Me.ComboBox_Brand.DisplayMember = "Text"
        Me.ComboBox_Brand.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ComboBox_Brand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_Brand.ForeColor = System.Drawing.Color.Black
        Me.ComboBox_Brand.FormattingEnabled = True
        Me.ComboBox_Brand.ItemHeight = 17
        Me.ComboBox_Brand.Location = New System.Drawing.Point(525, 117)
        Me.ComboBox_Brand.Name = "ComboBox_Brand"
        Me.ComboBox_Brand.Size = New System.Drawing.Size(300, 23)
        Me.ComboBox_Brand.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ComboBox_Brand.TabIndex = 26
        Me.ComboBox_Brand.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty
        Me.ComboBox_Brand.WatermarkText = "ใช้การกรองด้วยยี่ห้อ"
        '
        'Label_Brand
        '
        '
        '
        '
        Me.Label_Brand.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Label_Brand.Location = New System.Drawing.Point(419, 117)
        Me.Label_Brand.Name = "Label_Brand"
        Me.Label_Brand.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label_Brand.Size = New System.Drawing.Size(42, 23)
        Me.Label_Brand.TabIndex = 25
        Me.Label_Brand.Text = "ยี่ห้อ :"
        '
        'Button_FormReset
        '
        Me.Button_FormReset.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Button_FormReset.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_FormReset.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Button_FormReset.Location = New System.Drawing.Point(984, 134)
        Me.Button_FormReset.Name = "Button_FormReset"
        Me.Button_FormReset.Size = New System.Drawing.Size(130, 37)
        Me.Button_FormReset.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Button_FormReset.TabIndex = 27
        Me.Button_FormReset.Text = "ล้างตัวกรอง"
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
        Me.Size = New System.Drawing.Size(1137, 650)
        CType(Me.toolbar_RoomAction, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelEx1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents toolbar_RoomAction As DevComponents.DotNetBar.Bar
    Friend WithEvents ButtonItem_Refresh As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Line1 As DevComponents.DotNetBar.Controls.Line
    Friend WithEvents TextBox_TextSearch As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents ComboBox_MaterialType As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboBox_SubCategories As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents ComboBox_Categories As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents ComboBox_Supplier As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Label_Locations As DevComponents.DotNetBar.LabelX
    Friend WithEvents ComboBox_Locations As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents ComboBox_StandardCode As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents supergridview_RoomList As DevComponents.DotNetBar.SuperGrid.SuperGridControl
    Friend WithEvents SuperGridView_Items As DevComponents.DotNetBar.SuperGrid.SuperGridControl
    Friend WithEvents CheckBox_ShowStockInfo As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents CheckBoxItem_ShowStockInfo As DevComponents.DotNetBar.CheckBoxItem
    Friend WithEvents ComboBox_Brand As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents Label_Brand As DevComponents.DotNetBar.LabelX
    Friend WithEvents Button_FormReset As DevComponents.DotNetBar.ButtonX

End Class
