<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usercon_add_equipment
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
        Me.SuperGridView_RecentCreate = New DevComponents.DotNetBar.SuperGrid.SuperGridControl()
        Me.Panel_Main = New DevComponents.DotNetBar.PanelEx()
        Me.CheckBox_CreateAndStockIn = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.Button_FormReset = New DevComponents.DotNetBar.ButtonX()
        Me.Button_ItemCreate = New DevComponents.DotNetBar.ButtonX()
        Me.Button_PictureModify = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonItem_PictureChooseFile = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem_PictureCapture = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem_PictureRemove = New DevComponents.DotNetBar.ButtonItem()
        Me.panel_Picture = New DevComponents.DotNetBar.PanelEx()
        Me.PictureBox_ItemPicture = New System.Windows.Forms.PictureBox()
        Me.RichTextBox_Remark = New DevComponents.DotNetBar.Controls.RichTextBoxEx()
        Me.DoubleInput_MeasurementValue = New DevComponents.Editors.DoubleInput()
        Me.Line2 = New DevComponents.DotNetBar.Controls.Line()
        Me.Line1 = New DevComponents.DotNetBar.Controls.Line()
        Me.TextBox_ItemName = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.TextBox_Barcode = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.TextBox_ItemCode = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.ComboBox_Model = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboBox_Brand = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.Label_Brand = New DevComponents.DotNetBar.LabelX()
        Me.Label_ItemName = New DevComponents.DotNetBar.LabelX()
        Me.Label_Measurement = New DevComponents.DotNetBar.LabelX()
        Me.Label_StandardCode = New DevComponents.DotNetBar.LabelX()
        Me.Label_QuantityUnit = New DevComponents.DotNetBar.LabelX()
        Me.Label_Remark = New DevComponents.DotNetBar.LabelX()
        Me.Label_MaterialType = New DevComponents.DotNetBar.LabelX()
        Me.LabelX_Barcode = New DevComponents.DotNetBar.LabelX()
        Me.Label_Categories = New DevComponents.DotNetBar.LabelX()
        Me.Label_ItemCode = New DevComponents.DotNetBar.LabelX()
        Me.ComboBox_MeasurementUnit = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboBox_StandardCode = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboBox_QuantityUnit = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboBox_MaterialType = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboBox_Categories = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboBox_SubCategories = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.Label_SubCategories = New DevComponents.DotNetBar.LabelX()
        Me.Panel_Main.SuspendLayout()
        Me.panel_Picture.SuspendLayout()
        CType(Me.PictureBox_ItemPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DoubleInput_MeasurementValue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SuperGridView_RecentCreate
        '
        Me.SuperGridView_RecentCreate.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SuperGridView_RecentCreate.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.SuperGridView_RecentCreate.DefaultVisualStyles.CellStyles.Default.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Padding4.Left = 5
        Padding4.Right = 5
        Me.SuperGridView_RecentCreate.DefaultVisualStyles.CellStyles.Default.Padding = Padding4
        Background3.Color1 = System.Drawing.Color.WhiteSmoke
        Background3.Color2 = System.Drawing.Color.WhiteSmoke
        Me.SuperGridView_RecentCreate.DefaultVisualStyles.CellStyles.MouseOver.Background = Background3
        Me.SuperGridView_RecentCreate.DefaultVisualStyles.ColumnHeaderStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleLeft
        Me.SuperGridView_RecentCreate.DefaultVisualStyles.ColumnHeaderStyles.Default.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Padding5.Left = 5
        Padding5.Right = 5
        Me.SuperGridView_RecentCreate.DefaultVisualStyles.ColumnHeaderStyles.Default.Padding = Padding5
        Me.SuperGridView_RecentCreate.DefaultVisualStyles.FilterColumnHeaderStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleLeft
        Me.SuperGridView_RecentCreate.DefaultVisualStyles.FilterColumnHeaderStyles.Default.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.SuperGridView_RecentCreate.DefaultVisualStyles.FooterStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleLeft
        Me.SuperGridView_RecentCreate.DefaultVisualStyles.FooterStyles.Default.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Padding6.Left = 5
        Padding6.Right = 5
        Me.SuperGridView_RecentCreate.DefaultVisualStyles.FooterStyles.Default.Padding = Padding6
        Me.SuperGridView_RecentCreate.DefaultVisualStyles.GroupHeaderStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleLeft
        Background4.Color1 = System.Drawing.Color.WhiteSmoke
        Background4.Color2 = System.Drawing.Color.WhiteSmoke
        Me.SuperGridView_RecentCreate.DefaultVisualStyles.GroupHeaderStyles.Default.Background = Background4
        Me.SuperGridView_RecentCreate.DefaultVisualStyles.GroupHeaderStyles.Default.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.SuperGridView_RecentCreate.FilterExprColors.SysFunction = System.Drawing.Color.Empty
        Me.SuperGridView_RecentCreate.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.SuperGridView_RecentCreate.ForeColor = System.Drawing.Color.Black
        Me.SuperGridView_RecentCreate.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F"
        Me.SuperGridView_RecentCreate.Location = New System.Drawing.Point(6, 271)
        Me.SuperGridView_RecentCreate.Name = "SuperGridView_RecentCreate"
        '
        '
        '
        Me.SuperGridView_RecentCreate.PrimaryGrid.AllowEdit = False
        Me.SuperGridView_RecentCreate.PrimaryGrid.AutoExpandSetGroup = True
        '
        '
        '
        Me.SuperGridView_RecentCreate.PrimaryGrid.Caption.RowHeight = 23
        Me.SuperGridView_RecentCreate.PrimaryGrid.Caption.Text = "รายการสร้างล่าสุด"
        Me.SuperGridView_RecentCreate.PrimaryGrid.ColumnAutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.Fill
        '
        '
        '
        Me.SuperGridView_RecentCreate.PrimaryGrid.ColumnHeader.RowHeight = 24
        Me.SuperGridView_RecentCreate.PrimaryGrid.DefaultRowHeight = 24
        Me.SuperGridView_RecentCreate.PrimaryGrid.DefaultVisualStyles.CaptionStyles.Default.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        '
        '
        '
        Me.SuperGridView_RecentCreate.PrimaryGrid.Filter.RowHeight = 24
        Me.SuperGridView_RecentCreate.PrimaryGrid.FocusCuesEnabled = False
        '
        '
        '
        Me.SuperGridView_RecentCreate.PrimaryGrid.Footer.RowHeight = 20
        '
        '
        '
        Me.SuperGridView_RecentCreate.PrimaryGrid.GroupByRow.AllowUserSort = False
        Me.SuperGridView_RecentCreate.PrimaryGrid.GroupByRow.Text = ""
        Me.SuperGridView_RecentCreate.PrimaryGrid.GroupByRow.WatermarkText = "ลากและวางคอลัมน์ที่นี่เพื่อจัดกลุ่ม"
        '
        '
        '
        Me.SuperGridView_RecentCreate.PrimaryGrid.Header.Text = ""
        Me.SuperGridView_RecentCreate.PrimaryGrid.RowFocusMode = DevComponents.DotNetBar.SuperGrid.RowFocusMode.CellsOnly
        Me.SuperGridView_RecentCreate.PrimaryGrid.RowHeaderIndexOffset = 1
        Me.SuperGridView_RecentCreate.PrimaryGrid.RowHeaderWidth = 30
        Me.SuperGridView_RecentCreate.PrimaryGrid.SelectionGranularity = DevComponents.DotNetBar.SuperGrid.SelectionGranularity.Row
        Me.SuperGridView_RecentCreate.PrimaryGrid.ShowGroupUnderline = False
        Me.SuperGridView_RecentCreate.PrimaryGrid.ShowRowGridIndex = True
        '
        '
        '
        Me.SuperGridView_RecentCreate.PrimaryGrid.Title.Text = ""
        Me.SuperGridView_RecentCreate.PrimaryGrid.TopLeftHeaderSelectBehavior = DevComponents.DotNetBar.SuperGrid.TopLeftHeaderSelectBehavior.NoSelection
        Me.SuperGridView_RecentCreate.Size = New System.Drawing.Size(1225, 504)
        Me.SuperGridView_RecentCreate.TabIndex = 17
        '
        'Panel_Main
        '
        Me.Panel_Main.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel_Main.CanvasColor = System.Drawing.Color.Empty
        Me.Panel_Main.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Panel_Main.Controls.Add(Me.CheckBox_CreateAndStockIn)
        Me.Panel_Main.Controls.Add(Me.Button_FormReset)
        Me.Panel_Main.Controls.Add(Me.Button_ItemCreate)
        Me.Panel_Main.Controls.Add(Me.Button_PictureModify)
        Me.Panel_Main.Controls.Add(Me.panel_Picture)
        Me.Panel_Main.Controls.Add(Me.RichTextBox_Remark)
        Me.Panel_Main.Controls.Add(Me.DoubleInput_MeasurementValue)
        Me.Panel_Main.Controls.Add(Me.Line2)
        Me.Panel_Main.Controls.Add(Me.Line1)
        Me.Panel_Main.Controls.Add(Me.TextBox_ItemName)
        Me.Panel_Main.Controls.Add(Me.TextBox_Barcode)
        Me.Panel_Main.Controls.Add(Me.TextBox_ItemCode)
        Me.Panel_Main.Controls.Add(Me.ComboBox_Model)
        Me.Panel_Main.Controls.Add(Me.ComboBox_Brand)
        Me.Panel_Main.Controls.Add(Me.Label_Brand)
        Me.Panel_Main.Controls.Add(Me.Label_ItemName)
        Me.Panel_Main.Controls.Add(Me.Label_Measurement)
        Me.Panel_Main.Controls.Add(Me.Label_StandardCode)
        Me.Panel_Main.Controls.Add(Me.Label_QuantityUnit)
        Me.Panel_Main.Controls.Add(Me.Label_Remark)
        Me.Panel_Main.Controls.Add(Me.Label_MaterialType)
        Me.Panel_Main.Controls.Add(Me.LabelX_Barcode)
        Me.Panel_Main.Controls.Add(Me.Label_Categories)
        Me.Panel_Main.Controls.Add(Me.Label_ItemCode)
        Me.Panel_Main.Controls.Add(Me.ComboBox_MeasurementUnit)
        Me.Panel_Main.Controls.Add(Me.ComboBox_StandardCode)
        Me.Panel_Main.Controls.Add(Me.ComboBox_QuantityUnit)
        Me.Panel_Main.Controls.Add(Me.ComboBox_MaterialType)
        Me.Panel_Main.Controls.Add(Me.ComboBox_Categories)
        Me.Panel_Main.Controls.Add(Me.ComboBox_SubCategories)
        Me.Panel_Main.Controls.Add(Me.Label_SubCategories)
        Me.Panel_Main.DisabledBackColor = System.Drawing.Color.Empty
        Me.Panel_Main.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Panel_Main.Location = New System.Drawing.Point(6, 6)
        Me.Panel_Main.Name = "Panel_Main"
        Me.Panel_Main.Padding = New System.Windows.Forms.Padding(8)
        Me.Panel_Main.Size = New System.Drawing.Size(1225, 259)
        Me.Panel_Main.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.Panel_Main.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Panel_Main.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Panel_Main.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Panel_Main.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Panel_Main.Style.GradientAngle = 90
        Me.Panel_Main.TabIndex = 14
        '
        'CheckBox_CreateAndStockIn
        '
        Me.CheckBox_CreateAndStockIn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.CheckBox_CreateAndStockIn.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.CheckBox_CreateAndStockIn.Location = New System.Drawing.Point(978, 225)
        Me.CheckBox_CreateAndStockIn.Name = "CheckBox_CreateAndStockIn"
        Me.CheckBox_CreateAndStockIn.Size = New System.Drawing.Size(100, 23)
        Me.CheckBox_CreateAndStockIn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.CheckBox_CreateAndStockIn.TabIndex = 34
        Me.CheckBox_CreateAndStockIn.Text = "สร้างและรับเข้า"
        '
        'Button_FormReset
        '
        Me.Button_FormReset.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Button_FormReset.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_FormReset.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Button_FormReset.Location = New System.Drawing.Point(1084, 211)
        Me.Button_FormReset.Name = "Button_FormReset"
        Me.Button_FormReset.Size = New System.Drawing.Size(130, 37)
        Me.Button_FormReset.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Button_FormReset.TabIndex = 16
        Me.Button_FormReset.Text = "รีเซ็ตข้อมูล"
        '
        'Button_ItemCreate
        '
        Me.Button_ItemCreate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Button_ItemCreate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_ItemCreate.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Button_ItemCreate.Location = New System.Drawing.Point(1084, 168)
        Me.Button_ItemCreate.Name = "Button_ItemCreate"
        Me.Button_ItemCreate.Size = New System.Drawing.Size(130, 37)
        Me.Button_ItemCreate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Button_ItemCreate.TabIndex = 15
        Me.Button_ItemCreate.Text = "สร้างรายการ"
        '
        'Button_PictureModify
        '
        Me.Button_PictureModify.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Button_PictureModify.AutoExpandOnClick = True
        Me.Button_PictureModify.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Button_PictureModify.Location = New System.Drawing.Point(810, 224)
        Me.Button_PictureModify.Name = "Button_PictureModify"
        Me.Button_PictureModify.Size = New System.Drawing.Size(157, 23)
        Me.Button_PictureModify.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Button_PictureModify.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem_PictureChooseFile, Me.ButtonItem_PictureCapture, Me.ButtonItem_PictureRemove})
        Me.Button_PictureModify.TabIndex = 14
        Me.Button_PictureModify.Text = "จัดการรูปภาพ"
        '
        'ButtonItem_PictureChooseFile
        '
        Me.ButtonItem_PictureChooseFile.GlobalItem = False
        Me.ButtonItem_PictureChooseFile.Name = "ButtonItem_PictureChooseFile"
        Me.ButtonItem_PictureChooseFile.Text = "เลือกภาพจากไฟล์"
        '
        'ButtonItem_PictureCapture
        '
        Me.ButtonItem_PictureCapture.GlobalItem = False
        Me.ButtonItem_PictureCapture.Name = "ButtonItem_PictureCapture"
        Me.ButtonItem_PictureCapture.Text = "ถ่ายภาพจากกล้อง"
        '
        'ButtonItem_PictureRemove
        '
        Me.ButtonItem_PictureRemove.GlobalItem = False
        Me.ButtonItem_PictureRemove.Name = "ButtonItem_PictureRemove"
        Me.ButtonItem_PictureRemove.Text = "ลบรูปภาพ"
        '
        'panel_Picture
        '
        Me.panel_Picture.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.panel_Picture.Controls.Add(Me.PictureBox_ItemPicture)
        Me.panel_Picture.DisabledBackColor = System.Drawing.Color.Empty
        Me.panel_Picture.Location = New System.Drawing.Point(809, 59)
        Me.panel_Picture.Name = "panel_Picture"
        Me.panel_Picture.Padding = New System.Windows.Forms.Padding(1)
        Me.panel_Picture.Size = New System.Drawing.Size(159, 159)
        Me.panel_Picture.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.panel_Picture.Style.BackColor1.Color = System.Drawing.Color.White
        Me.panel_Picture.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.panel_Picture.Style.BorderColor.Color = System.Drawing.Color.LightGray
        Me.panel_Picture.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.panel_Picture.Style.GradientAngle = 90
        Me.panel_Picture.TabIndex = 30
        '
        'PictureBox_ItemPicture
        '
        Me.PictureBox_ItemPicture.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox_ItemPicture.Location = New System.Drawing.Point(1, 1)
        Me.PictureBox_ItemPicture.Name = "PictureBox_ItemPicture"
        Me.PictureBox_ItemPicture.Size = New System.Drawing.Size(157, 157)
        Me.PictureBox_ItemPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox_ItemPicture.TabIndex = 0
        Me.PictureBox_ItemPicture.TabStop = False
        '
        'RichTextBox_Remark
        '
        '
        '
        '
        Me.RichTextBox_Remark.BackgroundStyle.Class = "RichTextBoxBorder"
        Me.RichTextBox_Remark.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RichTextBox_Remark.Location = New System.Drawing.Point(492, 144)
        Me.RichTextBox_Remark.Name = "RichTextBox_Remark"
        Me.RichTextBox_Remark.Rtf = "{\rtf1\ansi\ansicpg874\deff0\deflang1054{\fonttbl{\f0\fnil\fcharset222 Tahoma;}}" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "\viewkind4\uc1\pard\f0\fs18\par" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "}" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.RichTextBox_Remark.Size = New System.Drawing.Size(300, 102)
        Me.RichTextBox_Remark.TabIndex = 13
        '
        'DoubleInput_MeasurementValue
        '
        '
        '
        '
        Me.DoubleInput_MeasurementValue.BackgroundStyle.BackColor = System.Drawing.Color.White
        Me.DoubleInput_MeasurementValue.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.DoubleInput_MeasurementValue.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DoubleInput_MeasurementValue.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.DoubleInput_MeasurementValue.Increment = 1.0R
        Me.DoubleInput_MeasurementValue.Location = New System.Drawing.Point(114, 145)
        Me.DoubleInput_MeasurementValue.Name = "DoubleInput_MeasurementValue"
        Me.DoubleInput_MeasurementValue.ShowUpDown = True
        Me.DoubleInput_MeasurementValue.Size = New System.Drawing.Size(178, 22)
        Me.DoubleInput_MeasurementValue.TabIndex = 6
        Me.DoubleInput_MeasurementValue.WatermarkText = "ระบุขนาด"
        '
        'Line2
        '
        Me.Line2.ForeColor = System.Drawing.Color.LightGray
        Me.Line2.Location = New System.Drawing.Point(114, 202)
        Me.Line2.Name = "Line2"
        Me.Line2.Size = New System.Drawing.Size(300, 17)
        Me.Line2.TabIndex = 24
        Me.Line2.Text = "Line1"
        '
        'Line1
        '
        Me.Line1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Line1.ForeColor = System.Drawing.Color.LightGray
        Me.Line1.Location = New System.Drawing.Point(12, 39)
        Me.Line1.Name = "Line1"
        Me.Line1.Size = New System.Drawing.Size(1202, 16)
        Me.Line1.TabIndex = 24
        Me.Line1.Text = "Line1"
        '
        'TextBox_ItemName
        '
        Me.TextBox_ItemName.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.TextBox_ItemName.Border.Class = "TextBoxBorder"
        Me.TextBox_ItemName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TextBox_ItemName.DisabledBackColor = System.Drawing.Color.White
        Me.TextBox_ItemName.ForeColor = System.Drawing.Color.Black
        Me.TextBox_ItemName.Location = New System.Drawing.Point(114, 59)
        Me.TextBox_ItemName.Name = "TextBox_ItemName"
        Me.TextBox_ItemName.PreventEnterBeep = True
        Me.TextBox_ItemName.Size = New System.Drawing.Size(300, 22)
        Me.TextBox_ItemName.TabIndex = 2
        Me.TextBox_ItemName.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty
        Me.TextBox_ItemName.WatermarkText = "ระบุชื่อรายการ"
        '
        'TextBox_Barcode
        '
        Me.TextBox_Barcode.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.TextBox_Barcode.Border.Class = "TextBoxBorder"
        Me.TextBox_Barcode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TextBox_Barcode.DisabledBackColor = System.Drawing.Color.White
        Me.TextBox_Barcode.ForeColor = System.Drawing.Color.Black
        Me.TextBox_Barcode.Location = New System.Drawing.Point(114, 225)
        Me.TextBox_Barcode.Name = "TextBox_Barcode"
        Me.TextBox_Barcode.PreventEnterBeep = True
        Me.TextBox_Barcode.Size = New System.Drawing.Size(300, 22)
        Me.TextBox_Barcode.TabIndex = 8
        Me.TextBox_Barcode.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty
        Me.TextBox_Barcode.WatermarkText = "ระบุรหัสบาร์โค้ด"
        '
        'TextBox_ItemCode
        '
        Me.TextBox_ItemCode.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.TextBox_ItemCode.Border.Class = "TextBoxBorder"
        Me.TextBox_ItemCode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TextBox_ItemCode.DisabledBackColor = System.Drawing.Color.White
        Me.TextBox_ItemCode.ForeColor = System.Drawing.Color.Black
        Me.TextBox_ItemCode.Location = New System.Drawing.Point(114, 11)
        Me.TextBox_ItemCode.Name = "TextBox_ItemCode"
        Me.TextBox_ItemCode.PreventEnterBeep = True
        Me.TextBox_ItemCode.ReadOnly = True
        Me.TextBox_ItemCode.Size = New System.Drawing.Size(300, 22)
        Me.TextBox_ItemCode.TabIndex = 1
        '
        'ComboBox_Model
        '
        Me.ComboBox_Model.DisplayMember = "Text"
        Me.ComboBox_Model.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ComboBox_Model.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_Model.ForeColor = System.Drawing.Color.Black
        Me.ComboBox_Model.FormattingEnabled = True
        Me.ComboBox_Model.ItemHeight = 17
        Me.ComboBox_Model.Location = New System.Drawing.Point(659, 115)
        Me.ComboBox_Model.Name = "ComboBox_Model"
        Me.ComboBox_Model.Size = New System.Drawing.Size(133, 23)
        Me.ComboBox_Model.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ComboBox_Model.TabIndex = 12
        Me.ComboBox_Model.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty
        Me.ComboBox_Model.WatermarkText = "ระบุรุ่น"
        '
        'ComboBox_Brand
        '
        Me.ComboBox_Brand.DisplayMember = "Text"
        Me.ComboBox_Brand.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ComboBox_Brand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_Brand.ForeColor = System.Drawing.Color.Black
        Me.ComboBox_Brand.FormattingEnabled = True
        Me.ComboBox_Brand.ItemHeight = 17
        Me.ComboBox_Brand.Location = New System.Drawing.Point(492, 115)
        Me.ComboBox_Brand.Name = "ComboBox_Brand"
        Me.ComboBox_Brand.Size = New System.Drawing.Size(161, 23)
        Me.ComboBox_Brand.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ComboBox_Brand.TabIndex = 11
        Me.ComboBox_Brand.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty
        Me.ComboBox_Brand.WatermarkText = "ระบุยี่ห้อ"
        '
        'Label_Brand
        '
        Me.Label_Brand.AutoSize = True
        '
        '
        '
        Me.Label_Brand.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Label_Brand.Location = New System.Drawing.Point(428, 117)
        Me.Label_Brand.Name = "Label_Brand"
        Me.Label_Brand.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label_Brand.Size = New System.Drawing.Size(50, 17)
        Me.Label_Brand.TabIndex = 16
        Me.Label_Brand.Text = "ยี่ห้อ/รุ่น :"
        '
        'Label_ItemName
        '
        Me.Label_ItemName.AutoSize = True
        '
        '
        '
        Me.Label_ItemName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Label_ItemName.Location = New System.Drawing.Point(12, 61)
        Me.Label_ItemName.Name = "Label_ItemName"
        Me.Label_ItemName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label_ItemName.Size = New System.Drawing.Size(61, 17)
        Me.Label_ItemName.TabIndex = 18
        Me.Label_ItemName.Text = "ชื่อรายการ :"
        '
        'Label_Measurement
        '
        Me.Label_Measurement.AutoSize = True
        '
        '
        '
        Me.Label_Measurement.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Label_Measurement.Location = New System.Drawing.Point(12, 148)
        Me.Label_Measurement.Name = "Label_Measurement"
        Me.Label_Measurement.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label_Measurement.Size = New System.Drawing.Size(84, 17)
        Me.Label_Measurement.TabIndex = 18
        Me.Label_Measurement.Text = "ขนาด/หน่วยวัด :"
        '
        'Label_StandardCode
        '
        Me.Label_StandardCode.AutoSize = True
        '
        '
        '
        Me.Label_StandardCode.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Label_StandardCode.Location = New System.Drawing.Point(428, 60)
        Me.Label_StandardCode.Name = "Label_StandardCode"
        Me.Label_StandardCode.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label_StandardCode.Size = New System.Drawing.Size(56, 17)
        Me.Label_StandardCode.TabIndex = 18
        Me.Label_StandardCode.Text = "มาตรฐาน :"
        '
        'Label_QuantityUnit
        '
        Me.Label_QuantityUnit.AutoSize = True
        '
        '
        '
        Me.Label_QuantityUnit.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Label_QuantityUnit.Location = New System.Drawing.Point(428, 88)
        Me.Label_QuantityUnit.Name = "Label_QuantityUnit"
        Me.Label_QuantityUnit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label_QuantityUnit.Size = New System.Drawing.Size(54, 17)
        Me.Label_QuantityUnit.TabIndex = 18
        Me.Label_QuantityUnit.Text = "หน่วยนับ :"
        '
        'Label_Remark
        '
        Me.Label_Remark.AutoSize = True
        '
        '
        '
        Me.Label_Remark.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Label_Remark.Location = New System.Drawing.Point(428, 146)
        Me.Label_Remark.Name = "Label_Remark"
        Me.Label_Remark.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label_Remark.Size = New System.Drawing.Size(58, 17)
        Me.Label_Remark.TabIndex = 18
        Me.Label_Remark.Text = "หมายเหตุ :"
        '
        'Label_MaterialType
        '
        Me.Label_MaterialType.AutoSize = True
        '
        '
        '
        Me.Label_MaterialType.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Label_MaterialType.Location = New System.Drawing.Point(12, 174)
        Me.Label_MaterialType.Name = "Label_MaterialType"
        Me.Label_MaterialType.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label_MaterialType.Size = New System.Drawing.Size(31, 17)
        Me.Label_MaterialType.TabIndex = 18
        Me.Label_MaterialType.Text = "วัสดุ :"
        '
        'LabelX_Barcode
        '
        Me.LabelX_Barcode.AutoSize = True
        '
        '
        '
        Me.LabelX_Barcode.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX_Barcode.Location = New System.Drawing.Point(12, 227)
        Me.LabelX_Barcode.Name = "LabelX_Barcode"
        Me.LabelX_Barcode.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LabelX_Barcode.Size = New System.Drawing.Size(70, 17)
        Me.LabelX_Barcode.TabIndex = 18
        Me.LabelX_Barcode.Text = "รหัสบาร์โค้ด :"
        '
        'Label_Categories
        '
        Me.Label_Categories.AutoSize = True
        '
        '
        '
        Me.Label_Categories.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Label_Categories.Location = New System.Drawing.Point(12, 90)
        Me.Label_Categories.Name = "Label_Categories"
        Me.Label_Categories.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label_Categories.Size = New System.Drawing.Size(77, 17)
        Me.Label_Categories.TabIndex = 18
        Me.Label_Categories.Text = "หมวดหมู่หลัก :"
        '
        'Label_ItemCode
        '
        Me.Label_ItemCode.AutoSize = True
        '
        '
        '
        Me.Label_ItemCode.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Label_ItemCode.Location = New System.Drawing.Point(12, 13)
        Me.Label_ItemCode.Name = "Label_ItemCode"
        Me.Label_ItemCode.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label_ItemCode.Size = New System.Drawing.Size(67, 17)
        Me.Label_ItemCode.TabIndex = 18
        Me.Label_ItemCode.Text = "รหัสรายการ :"
        '
        'ComboBox_MeasurementUnit
        '
        Me.ComboBox_MeasurementUnit.DisplayMember = "Text"
        Me.ComboBox_MeasurementUnit.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ComboBox_MeasurementUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_MeasurementUnit.ForeColor = System.Drawing.Color.Black
        Me.ComboBox_MeasurementUnit.FormattingEnabled = True
        Me.ComboBox_MeasurementUnit.ItemHeight = 17
        Me.ComboBox_MeasurementUnit.Location = New System.Drawing.Point(298, 145)
        Me.ComboBox_MeasurementUnit.Name = "ComboBox_MeasurementUnit"
        Me.ComboBox_MeasurementUnit.Size = New System.Drawing.Size(116, 23)
        Me.ComboBox_MeasurementUnit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ComboBox_MeasurementUnit.TabIndex = 7
        Me.ComboBox_MeasurementUnit.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty
        Me.ComboBox_MeasurementUnit.WatermarkText = "ระบุหน่วยวัด"
        '
        'ComboBox_StandardCode
        '
        Me.ComboBox_StandardCode.DisplayMember = "Text"
        Me.ComboBox_StandardCode.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ComboBox_StandardCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_StandardCode.ForeColor = System.Drawing.Color.Black
        Me.ComboBox_StandardCode.FormattingEnabled = True
        Me.ComboBox_StandardCode.ItemHeight = 17
        Me.ComboBox_StandardCode.Location = New System.Drawing.Point(492, 58)
        Me.ComboBox_StandardCode.Name = "ComboBox_StandardCode"
        Me.ComboBox_StandardCode.Size = New System.Drawing.Size(300, 23)
        Me.ComboBox_StandardCode.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ComboBox_StandardCode.TabIndex = 5
        Me.ComboBox_StandardCode.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty
        Me.ComboBox_StandardCode.WatermarkText = "ระบุมาตรฐาน"
        '
        'ComboBox_QuantityUnit
        '
        Me.ComboBox_QuantityUnit.DisplayMember = "Text"
        Me.ComboBox_QuantityUnit.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ComboBox_QuantityUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_QuantityUnit.ForeColor = System.Drawing.Color.Black
        Me.ComboBox_QuantityUnit.FormattingEnabled = True
        Me.ComboBox_QuantityUnit.ItemHeight = 17
        Me.ComboBox_QuantityUnit.Location = New System.Drawing.Point(492, 86)
        Me.ComboBox_QuantityUnit.Name = "ComboBox_QuantityUnit"
        Me.ComboBox_QuantityUnit.Size = New System.Drawing.Size(300, 23)
        Me.ComboBox_QuantityUnit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ComboBox_QuantityUnit.TabIndex = 10
        Me.ComboBox_QuantityUnit.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty
        Me.ComboBox_QuantityUnit.WatermarkText = "ระบุหน่วยนับจำนวน"
        '
        'ComboBox_MaterialType
        '
        Me.ComboBox_MaterialType.DisplayMember = "Text"
        Me.ComboBox_MaterialType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ComboBox_MaterialType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_MaterialType.ForeColor = System.Drawing.Color.Black
        Me.ComboBox_MaterialType.FormattingEnabled = True
        Me.ComboBox_MaterialType.ItemHeight = 17
        Me.ComboBox_MaterialType.Location = New System.Drawing.Point(114, 174)
        Me.ComboBox_MaterialType.Name = "ComboBox_MaterialType"
        Me.ComboBox_MaterialType.Size = New System.Drawing.Size(300, 23)
        Me.ComboBox_MaterialType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ComboBox_MaterialType.TabIndex = 9
        Me.ComboBox_MaterialType.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty
        Me.ComboBox_MaterialType.WatermarkText = "ระบุวัสดุ"
        '
        'ComboBox_Categories
        '
        Me.ComboBox_Categories.DisplayMember = "Text"
        Me.ComboBox_Categories.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ComboBox_Categories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_Categories.ForeColor = System.Drawing.Color.Black
        Me.ComboBox_Categories.FormattingEnabled = True
        Me.ComboBox_Categories.ItemHeight = 17
        Me.ComboBox_Categories.Location = New System.Drawing.Point(114, 87)
        Me.ComboBox_Categories.Name = "ComboBox_Categories"
        Me.ComboBox_Categories.Size = New System.Drawing.Size(300, 23)
        Me.ComboBox_Categories.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ComboBox_Categories.TabIndex = 3
        Me.ComboBox_Categories.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty
        Me.ComboBox_Categories.WatermarkText = "ระบุหมวดหมู่รายการ"
        '
        'ComboBox_SubCategories
        '
        Me.ComboBox_SubCategories.DisplayMember = "Text"
        Me.ComboBox_SubCategories.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ComboBox_SubCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_SubCategories.ForeColor = System.Drawing.Color.Black
        Me.ComboBox_SubCategories.FormattingEnabled = True
        Me.ComboBox_SubCategories.ItemHeight = 17
        Me.ComboBox_SubCategories.Location = New System.Drawing.Point(114, 116)
        Me.ComboBox_SubCategories.Name = "ComboBox_SubCategories"
        Me.ComboBox_SubCategories.Size = New System.Drawing.Size(300, 23)
        Me.ComboBox_SubCategories.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ComboBox_SubCategories.TabIndex = 4
        Me.ComboBox_SubCategories.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty
        Me.ComboBox_SubCategories.WatermarkText = "ระบุหมวดหมู่ย่อย"
        '
        'Label_SubCategories
        '
        Me.Label_SubCategories.AutoSize = True
        '
        '
        '
        Me.Label_SubCategories.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Label_SubCategories.Location = New System.Drawing.Point(12, 119)
        Me.Label_SubCategories.Name = "Label_SubCategories"
        Me.Label_SubCategories.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label_SubCategories.Size = New System.Drawing.Size(75, 17)
        Me.Label_SubCategories.TabIndex = 19
        Me.Label_SubCategories.Text = "หมวดหมู่ย่อย :"
        '
        'usercon_add_equipment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.Controls.Add(Me.Panel_Main)
        Me.Controls.Add(Me.SuperGridView_RecentCreate)
        Me.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Name = "usercon_add_equipment"
        Me.Padding = New System.Windows.Forms.Padding(3)
        Me.Size = New System.Drawing.Size(1237, 781)
        Me.Panel_Main.ResumeLayout(False)
        Me.Panel_Main.PerformLayout()
        Me.panel_Picture.ResumeLayout(False)
        CType(Me.PictureBox_ItemPicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DoubleInput_MeasurementValue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SuperGridView_RecentCreate As DevComponents.DotNetBar.SuperGrid.SuperGridControl
    Friend WithEvents Panel_Main As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Line1 As DevComponents.DotNetBar.Controls.Line
    Friend WithEvents TextBox_ItemCode As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents ComboBox_Model As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboBox_Brand As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents Label_Brand As DevComponents.DotNetBar.LabelX
    Friend WithEvents Label_ItemCode As DevComponents.DotNetBar.LabelX
    Friend WithEvents ComboBox_SubCategories As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents Label_SubCategories As DevComponents.DotNetBar.LabelX
    Friend WithEvents Label_Categories As DevComponents.DotNetBar.LabelX
    Friend WithEvents ComboBox_Categories As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents TextBox_ItemName As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label_ItemName As DevComponents.DotNetBar.LabelX
    Friend WithEvents Label_Measurement As DevComponents.DotNetBar.LabelX
    Friend WithEvents Label_QuantityUnit As DevComponents.DotNetBar.LabelX
    Friend WithEvents Label_MaterialType As DevComponents.DotNetBar.LabelX
    Friend WithEvents ComboBox_MeasurementUnit As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboBox_QuantityUnit As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboBox_MaterialType As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents DoubleInput_MeasurementValue As DevComponents.Editors.DoubleInput
    Friend WithEvents Label_StandardCode As DevComponents.DotNetBar.LabelX
    Friend WithEvents ComboBox_StandardCode As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents Line2 As DevComponents.DotNetBar.Controls.Line
    Friend WithEvents TextBox_Barcode As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label_Remark As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX_Barcode As DevComponents.DotNetBar.LabelX
    Friend WithEvents RichTextBox_Remark As DevComponents.DotNetBar.Controls.RichTextBoxEx
    Friend WithEvents panel_Picture As DevComponents.DotNetBar.PanelEx
    Friend WithEvents PictureBox_ItemPicture As System.Windows.Forms.PictureBox
    Friend WithEvents Button_PictureModify As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Button_ItemCreate As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Button_FormReset As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonItem_PictureChooseFile As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem_PictureCapture As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem_PictureRemove As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents CheckBox_CreateAndStockIn As DevComponents.DotNetBar.Controls.CheckBoxX

End Class
