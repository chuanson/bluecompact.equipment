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
        Me.toolbar_RoomAction = New DevComponents.DotNetBar.Bar()
        Me.toolbar_RoomAction_Add = New DevComponents.DotNetBar.ButtonItem()
        Me.toolbar_RoomAction_ViewEdit = New DevComponents.DotNetBar.ButtonItem()
        Me.toolbar_RoomAction_Del = New DevComponents.DotNetBar.ButtonItem()
        Me.toolbar_RoomAction_Refresh = New DevComponents.DotNetBar.ButtonItem()
        Me.toolbar_RoomAction_Print = New DevComponents.DotNetBar.ButtonItem()
        Me.toolbar_RoomAction_Export = New DevComponents.DotNetBar.ButtonItem()
        Me.toolbar_RoomAction_ExportXls = New DevComponents.DotNetBar.ButtonItem()
        Me.toolbar_RoomAction_Ungroup = New DevComponents.DotNetBar.ButtonItem()
        Me.toolbar_RoomAction_TabClose = New DevComponents.DotNetBar.ButtonItem()
        Me.supergridview_RoomList = New DevComponents.DotNetBar.SuperGrid.SuperGridControl()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.Line1 = New DevComponents.DotNetBar.Controls.Line()
        Me.TextBoxX2 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.ComboBoxEx3 = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboBoxEx2 = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.ComboBoxEx1 = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.ComboBoxEx4 = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.ComboBoxEx5 = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
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
        Me.toolbar_RoomAction.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.toolbar_RoomAction_Add, Me.toolbar_RoomAction_ViewEdit, Me.toolbar_RoomAction_Del, Me.toolbar_RoomAction_Refresh, Me.toolbar_RoomAction_Print, Me.toolbar_RoomAction_Export, Me.toolbar_RoomAction_Ungroup, Me.toolbar_RoomAction_TabClose})
        Me.toolbar_RoomAction.ItemSpacing = 5
        Me.toolbar_RoomAction.Location = New System.Drawing.Point(6, 164)
        Me.toolbar_RoomAction.Name = "toolbar_RoomAction"
        Me.toolbar_RoomAction.Size = New System.Drawing.Size(986, 25)
        Me.toolbar_RoomAction.Stretch = True
        Me.toolbar_RoomAction.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.toolbar_RoomAction.TabIndex = 12
        Me.toolbar_RoomAction.TabStop = False
        '
        'toolbar_RoomAction_Add
        '
        Me.toolbar_RoomAction_Add.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.toolbar_RoomAction_Add.ImagePaddingHorizontal = 10
        Me.toolbar_RoomAction_Add.Name = "toolbar_RoomAction_Add"
        Me.toolbar_RoomAction_Add.Text = "เพิ่มรายการใหม่"
        '
        'toolbar_RoomAction_ViewEdit
        '
        Me.toolbar_RoomAction_ViewEdit.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.toolbar_RoomAction_ViewEdit.ImagePaddingHorizontal = 10
        Me.toolbar_RoomAction_ViewEdit.Name = "toolbar_RoomAction_ViewEdit"
        Me.toolbar_RoomAction_ViewEdit.Text = "แก้ไขรายการ"
        '
        'toolbar_RoomAction_Del
        '
        Me.toolbar_RoomAction_Del.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.toolbar_RoomAction_Del.ImagePaddingHorizontal = 10
        Me.toolbar_RoomAction_Del.Name = "toolbar_RoomAction_Del"
        Me.toolbar_RoomAction_Del.Text = "ลบรายการ"
        '
        'toolbar_RoomAction_Refresh
        '
        Me.toolbar_RoomAction_Refresh.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.toolbar_RoomAction_Refresh.ImagePaddingHorizontal = 10
        Me.toolbar_RoomAction_Refresh.Name = "toolbar_RoomAction_Refresh"
        Me.toolbar_RoomAction_Refresh.Text = "รีเฟรชรายการ"
        '
        'toolbar_RoomAction_Print
        '
        Me.toolbar_RoomAction_Print.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.toolbar_RoomAction_Print.ImagePaddingHorizontal = 10
        Me.toolbar_RoomAction_Print.Name = "toolbar_RoomAction_Print"
        Me.toolbar_RoomAction_Print.Text = "พิมพ์รายการ"
        '
        'toolbar_RoomAction_Export
        '
        Me.toolbar_RoomAction_Export.AutoExpandOnClick = True
        Me.toolbar_RoomAction_Export.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.toolbar_RoomAction_Export.ImagePaddingHorizontal = 10
        Me.toolbar_RoomAction_Export.Name = "toolbar_RoomAction_Export"
        Me.toolbar_RoomAction_Export.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.toolbar_RoomAction_ExportXls})
        Me.toolbar_RoomAction_Export.Text = "ส่งออกรายการ"
        '
        'toolbar_RoomAction_ExportXls
        '
        Me.toolbar_RoomAction_ExportXls.Name = "toolbar_RoomAction_ExportXls"
        Me.toolbar_RoomAction_ExportXls.Text = "บันทึกเป็นไฟล์ .xls"
        '
        'toolbar_RoomAction_Ungroup
        '
        Me.toolbar_RoomAction_Ungroup.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.toolbar_RoomAction_Ungroup.ImagePaddingHorizontal = 10
        Me.toolbar_RoomAction_Ungroup.Name = "toolbar_RoomAction_Ungroup"
        Me.toolbar_RoomAction_Ungroup.Text = "ยกเลิกจัดกลุ่ม"
        Me.toolbar_RoomAction_Ungroup.Visible = False
        '
        'toolbar_RoomAction_TabClose
        '
        Me.toolbar_RoomAction_TabClose.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.toolbar_RoomAction_TabClose.ImagePaddingHorizontal = 10
        Me.toolbar_RoomAction_TabClose.Name = "toolbar_RoomAction_TabClose"
        Me.toolbar_RoomAction_TabClose.Text = "ปิดแท็บ"
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
        'PanelEx1
        '
        Me.PanelEx1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelEx1.CanvasColor = System.Drawing.Color.Empty
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.Line1)
        Me.PanelEx1.Controls.Add(Me.TextBoxX2)
        Me.PanelEx1.Controls.Add(Me.ComboBoxEx3)
        Me.PanelEx1.Controls.Add(Me.LabelX3)
        Me.PanelEx1.Controls.Add(Me.LabelX7)
        Me.PanelEx1.Controls.Add(Me.ComboBoxEx2)
        Me.PanelEx1.Controls.Add(Me.LabelX2)
        Me.PanelEx1.Controls.Add(Me.LabelX4)
        Me.PanelEx1.Controls.Add(Me.ComboBoxEx5)
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
        Me.Line1.ForeColor = System.Drawing.Color.LightGray
        Me.Line1.Location = New System.Drawing.Point(102, 39)
        Me.Line1.Name = "Line1"
        Me.Line1.Size = New System.Drawing.Size(352, 14)
        Me.Line1.TabIndex = 24
        Me.Line1.Text = "Line1"
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
        Me.TextBoxX2.Location = New System.Drawing.Point(102, 11)
        Me.TextBoxX2.Name = "TextBoxX2"
        Me.TextBoxX2.PreventEnterBeep = True
        Me.TextBoxX2.Size = New System.Drawing.Size(352, 22)
        Me.TextBoxX2.TabIndex = 23
        '
        'ComboBoxEx3
        '
        Me.ComboBoxEx3.DisplayMember = "Text"
        Me.ComboBoxEx3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ComboBoxEx3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxEx3.ForeColor = System.Drawing.Color.Black
        Me.ComboBoxEx3.FormattingEnabled = True
        Me.ComboBoxEx3.ItemHeight = 17
        Me.ComboBoxEx3.Location = New System.Drawing.Point(577, 59)
        Me.ComboBoxEx3.Name = "ComboBoxEx3"
        Me.ComboBoxEx3.Size = New System.Drawing.Size(352, 23)
        Me.ComboBoxEx3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ComboBoxEx3.TabIndex = 22
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
        Me.ComboBoxEx2.Size = New System.Drawing.Size(352, 23)
        Me.ComboBoxEx2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ComboBoxEx2.TabIndex = 21
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
        Me.ComboBoxEx1.Size = New System.Drawing.Size(352, 23)
        Me.ComboBoxEx1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ComboBoxEx1.TabIndex = 20
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
        'LabelX5
        '
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Location = New System.Drawing.Point(471, 59)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LabelX5.Size = New System.Drawing.Size(85, 23)
        Me.LabelX5.TabIndex = 19
        Me.LabelX5.Text = "วัสดุ :"
        '
        'ComboBoxEx4
        '
        Me.ComboBoxEx4.DisplayMember = "Text"
        Me.ComboBoxEx4.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ComboBoxEx4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxEx4.ForeColor = System.Drawing.Color.Black
        Me.ComboBoxEx4.FormattingEnabled = True
        Me.ComboBoxEx4.ItemHeight = 17
        Me.ComboBoxEx4.Location = New System.Drawing.Point(577, 88)
        Me.ComboBoxEx4.Name = "ComboBoxEx4"
        Me.ComboBoxEx4.Size = New System.Drawing.Size(352, 23)
        Me.ComboBoxEx4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ComboBoxEx4.TabIndex = 20
        '
        'LabelX7
        '
        '
        '
        '
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX7.Location = New System.Drawing.Point(471, 88)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LabelX7.Size = New System.Drawing.Size(100, 23)
        Me.LabelX7.TabIndex = 17
        Me.LabelX7.Text = "ผู้ผลิต/ผู้จำหน่าย :"
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
        Me.ComboBoxEx5.Size = New System.Drawing.Size(352, 23)
        Me.ComboBoxEx5.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ComboBoxEx5.TabIndex = 20
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
        'usercon_find_equipment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PanelEx1)
        Me.Controls.Add(Me.supergridview_RoomList)
        Me.Controls.Add(Me.toolbar_RoomAction)
        Me.Name = "usercon_find_equipment"
        Me.Padding = New System.Windows.Forms.Padding(3)
        Me.Size = New System.Drawing.Size(998, 650)
        CType(Me.toolbar_RoomAction, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelEx1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents toolbar_RoomAction As DevComponents.DotNetBar.Bar
    Friend WithEvents toolbar_RoomAction_Add As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents toolbar_RoomAction_ViewEdit As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents toolbar_RoomAction_Del As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents toolbar_RoomAction_Refresh As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents toolbar_RoomAction_Print As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents toolbar_RoomAction_Export As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents toolbar_RoomAction_ExportXls As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents toolbar_RoomAction_Ungroup As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents toolbar_RoomAction_TabClose As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents supergridview_RoomList As DevComponents.DotNetBar.SuperGrid.SuperGridControl
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Line1 As DevComponents.DotNetBar.Controls.Line
    Friend WithEvents TextBoxX2 As DevComponents.DotNetBar.Controls.TextBoxX
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

End Class
