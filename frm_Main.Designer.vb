<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Main
    Inherits DevComponents.DotNetBar.RibbonForm

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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Main))
        Me.RibbonControl_Main = New DevComponents.DotNetBar.RibbonControl()
        Me.RibbonPanel_Management = New DevComponents.DotNetBar.RibbonPanel()
        Me.RibbonBar_Config = New DevComponents.DotNetBar.RibbonBar()
        Me.ButtonItem_WarehouseChange = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem_WarehouseConfig = New DevComponents.DotNetBar.ButtonItem()
        Me.ItemContainer5 = New DevComponents.DotNetBar.ItemContainer()
        Me.ButtonItem_LocationsConfig = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem_CategoriesConfig = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem_SubCategoriesConfig = New DevComponents.DotNetBar.ButtonItem()
        Me.ItemContainer6 = New DevComponents.DotNetBar.ItemContainer()
        Me.ButtonItem_SuppliersConfig = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem_OtherConfig = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem_MaterialTypeConfig = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem_Standards = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem_Unit = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem_MeasureConfig = New DevComponents.DotNetBar.ButtonItem()
        Me.RibbonBar_User = New DevComponents.DotNetBar.RibbonBar()
        Me.ButtonItem_UserConfig = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem_Logout = New DevComponents.DotNetBar.ButtonItem()
        Me.RibbonBar_SignBarcode = New DevComponents.DotNetBar.RibbonBar()
        Me.ButtonItem_PrintSign = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem_PrintBarcode = New DevComponents.DotNetBar.ButtonItem()
        Me.RibbonBar_Items = New DevComponents.DotNetBar.RibbonBar()
        Me.ButtonItem_AddItem = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem_FindItem = New DevComponents.DotNetBar.ButtonItem()
        Me.RibbonBar_Stock = New DevComponents.DotNetBar.RibbonBar()
        Me.ButtonItem_StockIn = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem_StockOut = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem_Tranfer = New DevComponents.DotNetBar.ButtonItem()
        Me.ItemContainer7 = New DevComponents.DotNetBar.ItemContainer()
        Me.ButtonItem_StockCount = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem_StockAdjust = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem_StockTransection = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem_StockInTransection = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem_StockOutTransection = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem_StockAdjustTransection = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem_TranferTransection = New DevComponents.DotNetBar.ButtonItem()
        Me.RibbonPanel_Settings = New DevComponents.DotNetBar.RibbonPanel()
        Me.RibbonBar_Help = New DevComponents.DotNetBar.RibbonBar()
        Me.ButtonItem_About = New DevComponents.DotNetBar.ButtonItem()
        Me.RibbonBar_Database = New DevComponents.DotNetBar.RibbonBar()
        Me.ButtonItem_DataBackup = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem_ClearData = New DevComponents.DotNetBar.ButtonItem()
        Me.RibbonBar_System = New DevComponents.DotNetBar.RibbonBar()
        Me.ButtonItem_GeneralSettings = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem_Permission = New DevComponents.DotNetBar.ButtonItem()
        Me.RibbonPanel_Report = New DevComponents.DotNetBar.RibbonPanel()
        Me.RibbonBar_Report = New DevComponents.DotNetBar.RibbonBar()
        Me.ButtonItem_ReportStockBalance = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem_ReportStockValue = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem_ReportStockInOut = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem_ReportStockTranfer = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem_ReportStockAdjust = New DevComponents.DotNetBar.ButtonItem()
        Me.RibbonTabItem_Management = New DevComponents.DotNetBar.RibbonTabItem()
        Me.RibbonTabItem_Report = New DevComponents.DotNetBar.RibbonTabItem()
        Me.RibbonTabItem_Settings = New DevComponents.DotNetBar.RibbonTabItem()
        Me.Label_WarehouseActive = New DevComponents.DotNetBar.LabelItem()
        Me.Label_UserActive = New DevComponents.DotNetBar.LabelItem()
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.bar_StatusInfo = New DevComponents.DotNetBar.Bar()
        Me.Label_VersionNumber = New DevComponents.DotNetBar.LabelItem()
        Me.Label_License = New DevComponents.DotNetBar.LabelItem()
        Me.Label_DatabaseName = New DevComponents.DotNetBar.LabelItem()
        Me.Label_DatabaseSize = New DevComponents.DotNetBar.LabelItem()
        Me.Label_Permission = New DevComponents.DotNetBar.LabelItem()
        Me.tabcontrol_Main = New DevComponents.DotNetBar.TabControl()
        Me.TabControlPanel_Dashboard = New DevComponents.DotNetBar.TabControlPanel()
        Me.TabItem_Dashboard = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.RibbonControl_Main.SuspendLayout()
        Me.RibbonPanel_Management.SuspendLayout()
        Me.RibbonPanel_Settings.SuspendLayout()
        Me.RibbonPanel_Report.SuspendLayout()
        CType(Me.bar_StatusInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tabcontrol_Main, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabcontrol_Main.SuspendLayout()
        Me.SuspendLayout()
        '
        'RibbonControl_Main
        '
        Me.RibbonControl_Main.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.RibbonControl_Main.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonControl_Main.CanCustomize = False
        Me.RibbonControl_Main.CaptionFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.RibbonControl_Main.CaptionVisible = True
        Me.RibbonControl_Main.Controls.Add(Me.RibbonPanel_Management)
        Me.RibbonControl_Main.Controls.Add(Me.RibbonPanel_Settings)
        Me.RibbonControl_Main.Controls.Add(Me.RibbonPanel_Report)
        Me.RibbonControl_Main.Dock = System.Windows.Forms.DockStyle.Top
        Me.RibbonControl_Main.ForeColor = System.Drawing.Color.Black
        Me.RibbonControl_Main.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.RibbonTabItem_Management, Me.RibbonTabItem_Report, Me.RibbonTabItem_Settings, Me.Label_WarehouseActive})
        Me.RibbonControl_Main.KeyTipsFont = New System.Drawing.Font("Tahoma", 7.0!)
        Me.RibbonControl_Main.Location = New System.Drawing.Point(5, 1)
        Me.RibbonControl_Main.Name = "RibbonControl_Main"
        Me.RibbonControl_Main.QuickToolbarItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.Label_UserActive})
        Me.RibbonControl_Main.RibbonStripFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.RibbonControl_Main.Size = New System.Drawing.Size(1212, 170)
        Me.RibbonControl_Main.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonControl_Main.SystemText.MaximizeRibbonText = "&Maximize the Ribbon"
        Me.RibbonControl_Main.SystemText.MinimizeRibbonText = "Mi&nimize the Ribbon"
        Me.RibbonControl_Main.SystemText.QatAddItemText = "&Add to Quick Access Toolbar"
        Me.RibbonControl_Main.SystemText.QatCustomizeMenuLabel = "<b>Customize Quick Access Toolbar</b>"
        Me.RibbonControl_Main.SystemText.QatCustomizeText = "&Customize Quick Access Toolbar..."
        Me.RibbonControl_Main.SystemText.QatDialogAddButton = "&Add >>"
        Me.RibbonControl_Main.SystemText.QatDialogCancelButton = "Cancel"
        Me.RibbonControl_Main.SystemText.QatDialogCaption = "Customize Quick Access Toolbar"
        Me.RibbonControl_Main.SystemText.QatDialogCategoriesLabel = "&Choose commands from:"
        Me.RibbonControl_Main.SystemText.QatDialogOkButton = "OK"
        Me.RibbonControl_Main.SystemText.QatDialogPlacementCheckbox = "&Place Quick Access Toolbar below the Ribbon"
        Me.RibbonControl_Main.SystemText.QatDialogRemoveButton = "&Remove"
        Me.RibbonControl_Main.SystemText.QatPlaceAboveRibbonText = "&Place Quick Access Toolbar above the Ribbon"
        Me.RibbonControl_Main.SystemText.QatPlaceBelowRibbonText = "&Place Quick Access Toolbar below the Ribbon"
        Me.RibbonControl_Main.SystemText.QatRemoveItemText = "&Remove from Quick Access Toolbar"
        Me.RibbonControl_Main.TabGroupHeight = 14
        Me.RibbonControl_Main.TabIndex = 0
        Me.RibbonControl_Main.Text = "RibbonControl1"
        '
        'RibbonPanel_Management
        '
        Me.RibbonPanel_Management.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonPanel_Management.Controls.Add(Me.RibbonBar_Config)
        Me.RibbonPanel_Management.Controls.Add(Me.RibbonBar_User)
        Me.RibbonPanel_Management.Controls.Add(Me.RibbonBar_SignBarcode)
        Me.RibbonPanel_Management.Controls.Add(Me.RibbonBar_Items)
        Me.RibbonPanel_Management.Controls.Add(Me.RibbonBar_Stock)
        Me.RibbonPanel_Management.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanel_Management.Location = New System.Drawing.Point(0, 53)
        Me.RibbonPanel_Management.Name = "RibbonPanel_Management"
        Me.RibbonPanel_Management.Padding = New System.Windows.Forms.Padding(3, 0, 3, 2)
        Me.RibbonPanel_Management.Size = New System.Drawing.Size(1212, 117)
        '
        '
        '
        Me.RibbonPanel_Management.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonPanel_Management.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonPanel_Management.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonPanel_Management.TabIndex = 1
        '
        'RibbonBar_Config
        '
        Me.RibbonBar_Config.AutoOverflowEnabled = True
        '
        '
        '
        Me.RibbonBar_Config.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar_Config.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonBar_Config.ContainerControlProcessDialogKey = True
        Me.RibbonBar_Config.Dock = System.Windows.Forms.DockStyle.Left
        Me.RibbonBar_Config.DragDropSupport = True
        Me.RibbonBar_Config.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem_WarehouseChange, Me.ButtonItem_WarehouseConfig, Me.ItemContainer5, Me.ItemContainer6})
        Me.RibbonBar_Config.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F"
        Me.RibbonBar_Config.Location = New System.Drawing.Point(705, 0)
        Me.RibbonBar_Config.Name = "RibbonBar_Config"
        Me.RibbonBar_Config.Size = New System.Drawing.Size(343, 115)
        Me.RibbonBar_Config.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonBar_Config.TabIndex = 15
        Me.RibbonBar_Config.Text = "กำหนดค่า"
        '
        '
        '
        Me.RibbonBar_Config.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar_Config.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'ButtonItem_WarehouseChange
        '
        Me.ButtonItem_WarehouseChange.Image = Global.Equipment.My.Resources.Resources.warehouse_change
        Me.ButtonItem_WarehouseChange.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem_WarehouseChange.Name = "ButtonItem_WarehouseChange"
        Me.ButtonItem_WarehouseChange.SubItemsExpandWidth = 14
        Me.ButtonItem_WarehouseChange.Text = "เปลี่ยนคลัง"
        '
        'ButtonItem_WarehouseConfig
        '
        Me.ButtonItem_WarehouseConfig.Image = Global.Equipment.My.Resources.Resources.warehouse_config
        Me.ButtonItem_WarehouseConfig.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem_WarehouseConfig.Name = "ButtonItem_WarehouseConfig"
        Me.ButtonItem_WarehouseConfig.SubItemsExpandWidth = 14
        Me.ButtonItem_WarehouseConfig.Text = "ตั้งค่าคลัง"
        '
        'ItemContainer5
        '
        '
        '
        '
        Me.ItemContainer5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ItemContainer5.ItemSpacing = 3
        Me.ItemContainer5.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical
        Me.ItemContainer5.Name = "ItemContainer5"
        Me.ItemContainer5.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem_LocationsConfig, Me.ButtonItem_CategoriesConfig, Me.ButtonItem_SubCategoriesConfig})
        '
        '
        '
        Me.ItemContainer5.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'ButtonItem_LocationsConfig
        '
        Me.ButtonItem_LocationsConfig.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem_LocationsConfig.Image = Global.Equipment.My.Resources.Resources.config_location
        Me.ButtonItem_LocationsConfig.ImagePaddingHorizontal = 15
        Me.ButtonItem_LocationsConfig.Name = "ButtonItem_LocationsConfig"
        Me.ButtonItem_LocationsConfig.Text = "สถานที่จัดเก็บ"
        '
        'ButtonItem_CategoriesConfig
        '
        Me.ButtonItem_CategoriesConfig.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem_CategoriesConfig.Image = Global.Equipment.My.Resources.Resources.config_category
        Me.ButtonItem_CategoriesConfig.ImagePaddingHorizontal = 15
        Me.ButtonItem_CategoriesConfig.Name = "ButtonItem_CategoriesConfig"
        Me.ButtonItem_CategoriesConfig.Text = "หมวดหมู่หลัก"
        '
        'ButtonItem_SubCategoriesConfig
        '
        Me.ButtonItem_SubCategoriesConfig.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem_SubCategoriesConfig.Image = Global.Equipment.My.Resources.Resources.config_group
        Me.ButtonItem_SubCategoriesConfig.ImagePaddingHorizontal = 15
        Me.ButtonItem_SubCategoriesConfig.Name = "ButtonItem_SubCategoriesConfig"
        Me.ButtonItem_SubCategoriesConfig.Text = "หมวดหมู่ย่อย"
        '
        'ItemContainer6
        '
        '
        '
        '
        Me.ItemContainer6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ItemContainer6.ItemSpacing = 3
        Me.ItemContainer6.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical
        Me.ItemContainer6.Name = "ItemContainer6"
        Me.ItemContainer6.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem_SuppliersConfig, Me.ButtonItem_OtherConfig})
        '
        '
        '
        Me.ItemContainer6.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'ButtonItem_SuppliersConfig
        '
        Me.ButtonItem_SuppliersConfig.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem_SuppliersConfig.Image = Global.Equipment.My.Resources.Resources.config_supplier
        Me.ButtonItem_SuppliersConfig.ImagePaddingHorizontal = 15
        Me.ButtonItem_SuppliersConfig.Name = "ButtonItem_SuppliersConfig"
        Me.ButtonItem_SuppliersConfig.Text = "ผู้ผลิต/ผู้จำหน่าย"
        '
        'ButtonItem_OtherConfig
        '
        Me.ButtonItem_OtherConfig.AutoExpandOnClick = True
        Me.ButtonItem_OtherConfig.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem_OtherConfig.Image = Global.Equipment.My.Resources.Resources.config_measu_unit2
        Me.ButtonItem_OtherConfig.ImagePaddingHorizontal = 15
        Me.ButtonItem_OtherConfig.Name = "ButtonItem_OtherConfig"
        Me.ButtonItem_OtherConfig.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem_MaterialTypeConfig, Me.ButtonItem_Standards, Me.ButtonItem_Unit, Me.ButtonItem_MeasureConfig})
        Me.ButtonItem_OtherConfig.Text = "กำหนดค่าอื่นๆ"
        '
        'ButtonItem_MaterialTypeConfig
        '
        Me.ButtonItem_MaterialTypeConfig.Name = "ButtonItem_MaterialTypeConfig"
        Me.ButtonItem_MaterialTypeConfig.Text = "กำหนดประเภทวัสดุ"
        '
        'ButtonItem_Standards
        '
        Me.ButtonItem_Standards.Name = "ButtonItem_Standards"
        Me.ButtonItem_Standards.Text = "กำหนดมาตรฐาน"
        '
        'ButtonItem_Unit
        '
        Me.ButtonItem_Unit.Name = "ButtonItem_Unit"
        Me.ButtonItem_Unit.Text = "กำหนดหน่วยนับ"
        '
        'ButtonItem_MeasureConfig
        '
        Me.ButtonItem_MeasureConfig.Name = "ButtonItem_MeasureConfig"
        Me.ButtonItem_MeasureConfig.Text = "กำหนดหน่วยวัด"
        '
        'RibbonBar_User
        '
        Me.RibbonBar_User.AutoOverflowEnabled = True
        '
        '
        '
        Me.RibbonBar_User.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar_User.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonBar_User.ContainerControlProcessDialogKey = True
        Me.RibbonBar_User.Dock = System.Windows.Forms.DockStyle.Left
        Me.RibbonBar_User.DragDropSupport = True
        Me.RibbonBar_User.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem_UserConfig, Me.ButtonItem_Logout})
        Me.RibbonBar_User.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F"
        Me.RibbonBar_User.Location = New System.Drawing.Point(565, 0)
        Me.RibbonBar_User.Name = "RibbonBar_User"
        Me.RibbonBar_User.Size = New System.Drawing.Size(140, 115)
        Me.RibbonBar_User.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonBar_User.TabIndex = 14
        Me.RibbonBar_User.Text = "ผู้ใช้งาน"
        '
        '
        '
        Me.RibbonBar_User.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar_User.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'ButtonItem_UserConfig
        '
        Me.ButtonItem_UserConfig.Image = Global.Equipment.My.Resources.Resources.user_edit
        Me.ButtonItem_UserConfig.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem_UserConfig.Name = "ButtonItem_UserConfig"
        Me.ButtonItem_UserConfig.SubItemsExpandWidth = 14
        Me.ButtonItem_UserConfig.Text = "แก้ไข" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ข้อมูลผู้ใช้"
        '
        'ButtonItem_Logout
        '
        Me.ButtonItem_Logout.Image = Global.Equipment.My.Resources.Resources.user_logout
        Me.ButtonItem_Logout.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem_Logout.Name = "ButtonItem_Logout"
        Me.ButtonItem_Logout.SubItemsExpandWidth = 14
        Me.ButtonItem_Logout.Text = "ออกจากระบบ"
        '
        'RibbonBar_SignBarcode
        '
        Me.RibbonBar_SignBarcode.AutoOverflowEnabled = True
        '
        '
        '
        Me.RibbonBar_SignBarcode.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar_SignBarcode.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonBar_SignBarcode.ContainerControlProcessDialogKey = True
        Me.RibbonBar_SignBarcode.Dock = System.Windows.Forms.DockStyle.Left
        Me.RibbonBar_SignBarcode.DragDropSupport = True
        Me.RibbonBar_SignBarcode.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem_PrintSign, Me.ButtonItem_PrintBarcode})
        Me.RibbonBar_SignBarcode.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F"
        Me.RibbonBar_SignBarcode.Location = New System.Drawing.Point(430, 0)
        Me.RibbonBar_SignBarcode.Name = "RibbonBar_SignBarcode"
        Me.RibbonBar_SignBarcode.Size = New System.Drawing.Size(135, 115)
        Me.RibbonBar_SignBarcode.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonBar_SignBarcode.TabIndex = 13
        Me.RibbonBar_SignBarcode.Text = "ป้ายและบาร์โค้ด"
        '
        '
        '
        Me.RibbonBar_SignBarcode.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar_SignBarcode.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'ButtonItem_PrintSign
        '
        Me.ButtonItem_PrintSign.Image = Global.Equipment.My.Resources.Resources.tag_print
        Me.ButtonItem_PrintSign.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem_PrintSign.Name = "ButtonItem_PrintSign"
        Me.ButtonItem_PrintSign.SubItemsExpandWidth = 14
        Me.ButtonItem_PrintSign.Text = "พิมพ์ป้าย" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "หมวดหมู่"
        '
        'ButtonItem_PrintBarcode
        '
        Me.ButtonItem_PrintBarcode.Image = Global.Equipment.My.Resources.Resources.barcode_print
        Me.ButtonItem_PrintBarcode.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem_PrintBarcode.Name = "ButtonItem_PrintBarcode"
        Me.ButtonItem_PrintBarcode.SubItemsExpandWidth = 14
        Me.ButtonItem_PrintBarcode.Text = "พิมพ์บาร์โค้ด" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "รายการ"
        '
        'RibbonBar_Items
        '
        Me.RibbonBar_Items.AutoOverflowEnabled = True
        '
        '
        '
        Me.RibbonBar_Items.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar_Items.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonBar_Items.ContainerControlProcessDialogKey = True
        Me.RibbonBar_Items.Dock = System.Windows.Forms.DockStyle.Left
        Me.RibbonBar_Items.DragDropSupport = True
        Me.RibbonBar_Items.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem_AddItem, Me.ButtonItem_FindItem})
        Me.RibbonBar_Items.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F"
        Me.RibbonBar_Items.Location = New System.Drawing.Point(302, 0)
        Me.RibbonBar_Items.Name = "RibbonBar_Items"
        Me.RibbonBar_Items.Size = New System.Drawing.Size(128, 115)
        Me.RibbonBar_Items.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonBar_Items.TabIndex = 12
        Me.RibbonBar_Items.Text = "รายการ"
        '
        '
        '
        Me.RibbonBar_Items.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar_Items.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'ButtonItem_AddItem
        '
        Me.ButtonItem_AddItem.Image = Global.Equipment.My.Resources.Resources.create_item
        Me.ButtonItem_AddItem.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem_AddItem.Name = "ButtonItem_AddItem"
        Me.ButtonItem_AddItem.SubItemsExpandWidth = 14
        Me.ButtonItem_AddItem.Text = "สร้าง" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "รายการใหม่"
        '
        'ButtonItem_FindItem
        '
        Me.ButtonItem_FindItem.Image = Global.Equipment.My.Resources.Resources.item_find
        Me.ButtonItem_FindItem.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem_FindItem.Name = "ButtonItem_FindItem"
        Me.ButtonItem_FindItem.SubItemsExpandWidth = 14
        Me.ButtonItem_FindItem.Text = "ค้นหา" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "รายการ"
        '
        'RibbonBar_Stock
        '
        Me.RibbonBar_Stock.AutoOverflowEnabled = True
        '
        '
        '
        Me.RibbonBar_Stock.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar_Stock.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonBar_Stock.ContainerControlProcessDialogKey = True
        Me.RibbonBar_Stock.Dock = System.Windows.Forms.DockStyle.Left
        Me.RibbonBar_Stock.DragDropSupport = True
        Me.RibbonBar_Stock.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem_StockIn, Me.ButtonItem_StockOut, Me.ButtonItem_Tranfer, Me.ItemContainer7})
        Me.RibbonBar_Stock.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F"
        Me.RibbonBar_Stock.Location = New System.Drawing.Point(3, 0)
        Me.RibbonBar_Stock.Name = "RibbonBar_Stock"
        Me.RibbonBar_Stock.Size = New System.Drawing.Size(299, 115)
        Me.RibbonBar_Stock.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonBar_Stock.TabIndex = 1
        Me.RibbonBar_Stock.Text = "สต็อก"
        '
        '
        '
        Me.RibbonBar_Stock.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar_Stock.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'ButtonItem_StockIn
        '
        Me.ButtonItem_StockIn.Image = Global.Equipment.My.Resources.Resources.stock_in
        Me.ButtonItem_StockIn.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem_StockIn.Name = "ButtonItem_StockIn"
        Me.ButtonItem_StockIn.SubItemsExpandWidth = 14
        Me.ButtonItem_StockIn.Text = "รับเข้า" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "รายการ"
        '
        'ButtonItem_StockOut
        '
        Me.ButtonItem_StockOut.Image = Global.Equipment.My.Resources.Resources.issue_item
        Me.ButtonItem_StockOut.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem_StockOut.Name = "ButtonItem_StockOut"
        Me.ButtonItem_StockOut.SubItemsExpandWidth = 14
        Me.ButtonItem_StockOut.Text = "เบิก" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "รายการ"
        '
        'ButtonItem_Tranfer
        '
        Me.ButtonItem_Tranfer.Image = Global.Equipment.My.Resources.Resources.tranfer_item
        Me.ButtonItem_Tranfer.ImagePaddingHorizontal = 15
        Me.ButtonItem_Tranfer.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem_Tranfer.Name = "ButtonItem_Tranfer"
        Me.ButtonItem_Tranfer.Text = "โอนย้าย" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "รายการ"
        '
        'ItemContainer7
        '
        '
        '
        '
        Me.ItemContainer7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ItemContainer7.ItemSpacing = 3
        Me.ItemContainer7.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical
        Me.ItemContainer7.Name = "ItemContainer7"
        Me.ItemContainer7.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem_StockCount, Me.ButtonItem_StockAdjust, Me.ButtonItem_StockTransection})
        '
        '
        '
        Me.ItemContainer7.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'ButtonItem_StockCount
        '
        Me.ButtonItem_StockCount.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem_StockCount.Image = Global.Equipment.My.Resources.Resources.stock_count
        Me.ButtonItem_StockCount.ImagePaddingHorizontal = 15
        Me.ButtonItem_StockCount.Name = "ButtonItem_StockCount"
        Me.ButtonItem_StockCount.Text = "นับสต๊อก"
        '
        'ButtonItem_StockAdjust
        '
        Me.ButtonItem_StockAdjust.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem_StockAdjust.Image = Global.Equipment.My.Resources.Resources.stock_adjust
        Me.ButtonItem_StockAdjust.ImagePaddingHorizontal = 15
        Me.ButtonItem_StockAdjust.Name = "ButtonItem_StockAdjust"
        Me.ButtonItem_StockAdjust.Text = "ปรับปรุงสต๊อก"
        '
        'ButtonItem_StockTransection
        '
        Me.ButtonItem_StockTransection.AutoExpandOnClick = True
        Me.ButtonItem_StockTransection.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem_StockTransection.Image = Global.Equipment.My.Resources.Resources.in_out_history
        Me.ButtonItem_StockTransection.ImagePaddingHorizontal = 15
        Me.ButtonItem_StockTransection.Name = "ButtonItem_StockTransection"
        Me.ButtonItem_StockTransection.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem_StockInTransection, Me.ButtonItem_StockOutTransection, Me.ButtonItem_StockAdjustTransection, Me.ButtonItem_TranferTransection})
        Me.ButtonItem_StockTransection.SubItemsExpandWidth = 14
        Me.ButtonItem_StockTransection.Text = "ประวัติรายการ"
        '
        'ButtonItem_StockInTransection
        '
        Me.ButtonItem_StockInTransection.Name = "ButtonItem_StockInTransection"
        Me.ButtonItem_StockInTransection.Text = "ประวัติการรับเข้า"
        '
        'ButtonItem_StockOutTransection
        '
        Me.ButtonItem_StockOutTransection.Name = "ButtonItem_StockOutTransection"
        Me.ButtonItem_StockOutTransection.Text = "ประวัติการเบิก"
        '
        'ButtonItem_StockAdjustTransection
        '
        Me.ButtonItem_StockAdjustTransection.Name = "ButtonItem_StockAdjustTransection"
        Me.ButtonItem_StockAdjustTransection.Text = "ประวัติการปรับปรุงสต๊อก"
        '
        'ButtonItem_TranferTransection
        '
        Me.ButtonItem_TranferTransection.Name = "ButtonItem_TranferTransection"
        Me.ButtonItem_TranferTransection.Text = "ประวัติการโอนย้าย"
        '
        'RibbonPanel_Settings
        '
        Me.RibbonPanel_Settings.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonPanel_Settings.Controls.Add(Me.RibbonBar_Help)
        Me.RibbonPanel_Settings.Controls.Add(Me.RibbonBar_Database)
        Me.RibbonPanel_Settings.Controls.Add(Me.RibbonBar_System)
        Me.RibbonPanel_Settings.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanel_Settings.Location = New System.Drawing.Point(0, 53)
        Me.RibbonPanel_Settings.Name = "RibbonPanel_Settings"
        Me.RibbonPanel_Settings.Padding = New System.Windows.Forms.Padding(3, 0, 3, 2)
        Me.RibbonPanel_Settings.Size = New System.Drawing.Size(1212, 117)
        '
        '
        '
        Me.RibbonPanel_Settings.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonPanel_Settings.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonPanel_Settings.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonPanel_Settings.TabIndex = 3
        Me.RibbonPanel_Settings.Visible = False
        '
        'RibbonBar_Help
        '
        Me.RibbonBar_Help.AutoOverflowEnabled = True
        '
        '
        '
        Me.RibbonBar_Help.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar_Help.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonBar_Help.ContainerControlProcessDialogKey = True
        Me.RibbonBar_Help.Dock = System.Windows.Forms.DockStyle.Left
        Me.RibbonBar_Help.DragDropSupport = True
        Me.RibbonBar_Help.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem_About})
        Me.RibbonBar_Help.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F"
        Me.RibbonBar_Help.Location = New System.Drawing.Point(287, 0)
        Me.RibbonBar_Help.Name = "RibbonBar_Help"
        Me.RibbonBar_Help.Size = New System.Drawing.Size(64, 115)
        Me.RibbonBar_Help.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonBar_Help.TabIndex = 2
        Me.RibbonBar_Help.Text = "ช่วยเหลือ"
        '
        '
        '
        Me.RibbonBar_Help.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar_Help.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'ButtonItem_About
        '
        Me.ButtonItem_About.Image = Global.Equipment.My.Resources.Resources.application_info
        Me.ButtonItem_About.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem_About.Name = "ButtonItem_About"
        Me.ButtonItem_About.SubItemsExpandWidth = 14
        Me.ButtonItem_About.Text = "เกี่ยวกับ" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ซอฟต์แวร์"
        '
        'RibbonBar_Database
        '
        Me.RibbonBar_Database.AutoOverflowEnabled = True
        '
        '
        '
        Me.RibbonBar_Database.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar_Database.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonBar_Database.ContainerControlProcessDialogKey = True
        Me.RibbonBar_Database.Dock = System.Windows.Forms.DockStyle.Left
        Me.RibbonBar_Database.DragDropSupport = True
        Me.RibbonBar_Database.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem_DataBackup, Me.ButtonItem_ClearData})
        Me.RibbonBar_Database.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F"
        Me.RibbonBar_Database.Location = New System.Drawing.Point(154, 0)
        Me.RibbonBar_Database.Name = "RibbonBar_Database"
        Me.RibbonBar_Database.Size = New System.Drawing.Size(133, 115)
        Me.RibbonBar_Database.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonBar_Database.TabIndex = 1
        Me.RibbonBar_Database.Text = "ฐานข้อมูล"
        '
        '
        '
        Me.RibbonBar_Database.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar_Database.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'ButtonItem_DataBackup
        '
        Me.ButtonItem_DataBackup.Image = Global.Equipment.My.Resources.Resources.database_backup
        Me.ButtonItem_DataBackup.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem_DataBackup.Name = "ButtonItem_DataBackup"
        Me.ButtonItem_DataBackup.SubItemsExpandWidth = 14
        Me.ButtonItem_DataBackup.Text = "สำรองข้อมูล"
        '
        'ButtonItem_ClearData
        '
        Me.ButtonItem_ClearData.Image = Global.Equipment.My.Resources.Resources.clear_data
        Me.ButtonItem_ClearData.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem_ClearData.Name = "ButtonItem_ClearData"
        Me.ButtonItem_ClearData.SubItemsExpandWidth = 14
        Me.ButtonItem_ClearData.Text = "ล้างข้อมูล"
        '
        'RibbonBar_System
        '
        Me.RibbonBar_System.AutoOverflowEnabled = True
        '
        '
        '
        Me.RibbonBar_System.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar_System.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonBar_System.ContainerControlProcessDialogKey = True
        Me.RibbonBar_System.Dock = System.Windows.Forms.DockStyle.Left
        Me.RibbonBar_System.DragDropSupport = True
        Me.RibbonBar_System.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem_GeneralSettings, Me.ButtonItem_Permission})
        Me.RibbonBar_System.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F"
        Me.RibbonBar_System.Location = New System.Drawing.Point(3, 0)
        Me.RibbonBar_System.Name = "RibbonBar_System"
        Me.RibbonBar_System.Size = New System.Drawing.Size(151, 115)
        Me.RibbonBar_System.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonBar_System.TabIndex = 0
        Me.RibbonBar_System.Text = "ระบบ"
        '
        '
        '
        Me.RibbonBar_System.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar_System.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'ButtonItem_GeneralSettings
        '
        Me.ButtonItem_GeneralSettings.Image = Global.Equipment.My.Resources.Resources.setting
        Me.ButtonItem_GeneralSettings.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem_GeneralSettings.Name = "ButtonItem_GeneralSettings"
        Me.ButtonItem_GeneralSettings.SubItemsExpandWidth = 14
        Me.ButtonItem_GeneralSettings.Text = "ตั้งค่าทั่วไป"
        '
        'ButtonItem_Permission
        '
        Me.ButtonItem_Permission.Image = Global.Equipment.My.Resources.Resources.permission
        Me.ButtonItem_Permission.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem_Permission.Name = "ButtonItem_Permission"
        Me.ButtonItem_Permission.SubItemsExpandWidth = 14
        Me.ButtonItem_Permission.Text = "กำหนด" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "สิทธิการใช้งาน"
        '
        'RibbonPanel_Report
        '
        Me.RibbonPanel_Report.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonPanel_Report.Controls.Add(Me.RibbonBar_Report)
        Me.RibbonPanel_Report.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanel_Report.Location = New System.Drawing.Point(0, 53)
        Me.RibbonPanel_Report.Name = "RibbonPanel_Report"
        Me.RibbonPanel_Report.Padding = New System.Windows.Forms.Padding(3, 0, 3, 2)
        Me.RibbonPanel_Report.Size = New System.Drawing.Size(1212, 117)
        '
        '
        '
        Me.RibbonPanel_Report.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonPanel_Report.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonPanel_Report.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonPanel_Report.TabIndex = 2
        Me.RibbonPanel_Report.Visible = False
        '
        'RibbonBar_Report
        '
        Me.RibbonBar_Report.AutoOverflowEnabled = True
        '
        '
        '
        Me.RibbonBar_Report.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar_Report.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonBar_Report.ContainerControlProcessDialogKey = True
        Me.RibbonBar_Report.Dock = System.Windows.Forms.DockStyle.Left
        Me.RibbonBar_Report.DragDropSupport = True
        Me.RibbonBar_Report.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem_ReportStockBalance, Me.ButtonItem_ReportStockValue, Me.ButtonItem_ReportStockInOut, Me.ButtonItem_ReportStockTranfer, Me.ButtonItem_ReportStockAdjust})
        Me.RibbonBar_Report.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F"
        Me.RibbonBar_Report.Location = New System.Drawing.Point(3, 0)
        Me.RibbonBar_Report.Name = "RibbonBar_Report"
        Me.RibbonBar_Report.Size = New System.Drawing.Size(405, 115)
        Me.RibbonBar_Report.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonBar_Report.TabIndex = 0
        Me.RibbonBar_Report.Text = "รายงาน"
        '
        '
        '
        Me.RibbonBar_Report.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar_Report.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'ButtonItem_ReportStockBalance
        '
        Me.ButtonItem_ReportStockBalance.Image = Global.Equipment.My.Resources.Resources.report_blue
        Me.ButtonItem_ReportStockBalance.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem_ReportStockBalance.Name = "ButtonItem_ReportStockBalance"
        Me.ButtonItem_ReportStockBalance.SubItemsExpandWidth = 14
        Me.ButtonItem_ReportStockBalance.Text = "รายงาน" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "คงเหลือ"
        '
        'ButtonItem_ReportStockValue
        '
        Me.ButtonItem_ReportStockValue.Image = Global.Equipment.My.Resources.Resources.report_blue
        Me.ButtonItem_ReportStockValue.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem_ReportStockValue.Name = "ButtonItem_ReportStockValue"
        Me.ButtonItem_ReportStockValue.SubItemsExpandWidth = 14
        Me.ButtonItem_ReportStockValue.Text = "รายงาน" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "มูลค่าคงเหลือ"
        '
        'ButtonItem_ReportStockInOut
        '
        Me.ButtonItem_ReportStockInOut.Image = Global.Equipment.My.Resources.Resources.report_green
        Me.ButtonItem_ReportStockInOut.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem_ReportStockInOut.Name = "ButtonItem_ReportStockInOut"
        Me.ButtonItem_ReportStockInOut.SubItemsExpandWidth = 14
        Me.ButtonItem_ReportStockInOut.Text = "รายงาน" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "รับเข้า - จ่ายออก"
        '
        'ButtonItem_ReportStockTranfer
        '
        Me.ButtonItem_ReportStockTranfer.Image = Global.Equipment.My.Resources.Resources.report_purple
        Me.ButtonItem_ReportStockTranfer.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem_ReportStockTranfer.Name = "ButtonItem_ReportStockTranfer"
        Me.ButtonItem_ReportStockTranfer.SubItemsExpandWidth = 14
        Me.ButtonItem_ReportStockTranfer.Text = "รายงาน" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "การโอนย้ายสต๊อก"
        '
        'ButtonItem_ReportStockAdjust
        '
        Me.ButtonItem_ReportStockAdjust.Image = Global.Equipment.My.Resources.Resources.report_purple
        Me.ButtonItem_ReportStockAdjust.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem_ReportStockAdjust.Name = "ButtonItem_ReportStockAdjust"
        Me.ButtonItem_ReportStockAdjust.SubItemsExpandWidth = 14
        Me.ButtonItem_ReportStockAdjust.Text = "รายงาน" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ปรับปรุงสต๊อก"
        '
        'RibbonTabItem_Management
        '
        Me.RibbonTabItem_Management.Checked = True
        Me.RibbonTabItem_Management.Name = "RibbonTabItem_Management"
        Me.RibbonTabItem_Management.Panel = Me.RibbonPanel_Management
        Me.RibbonTabItem_Management.Text = "การจัดการ"
        '
        'RibbonTabItem_Report
        '
        Me.RibbonTabItem_Report.Name = "RibbonTabItem_Report"
        Me.RibbonTabItem_Report.Panel = Me.RibbonPanel_Report
        Me.RibbonTabItem_Report.Text = "รายงาน"
        '
        'RibbonTabItem_Settings
        '
        Me.RibbonTabItem_Settings.Name = "RibbonTabItem_Settings"
        Me.RibbonTabItem_Settings.Panel = Me.RibbonPanel_Settings
        Me.RibbonTabItem_Settings.Text = "การตั้งค่า"
        '
        'Label_WarehouseActive
        '
        Me.Label_WarehouseActive.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far
        Me.Label_WarehouseActive.Name = "Label_WarehouseActive"
        Me.Label_WarehouseActive.PaddingBottom = 3
        Me.Label_WarehouseActive.Text = "คลังสินค้า : XXXX"
        '
        'Label_UserActive
        '
        Me.Label_UserActive.Name = "Label_UserActive"
        Me.Label_UserActive.Text = "ชื่อผู้ใช้ : XXXX"
        '
        'StyleManager1
        '
        Me.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.VisualStudio2012Light
        Me.StyleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer)))
        '
        'bar_StatusInfo
        '
        Me.bar_StatusInfo.AntiAlias = True
        Me.bar_StatusInfo.BarType = DevComponents.DotNetBar.eBarType.MenuBar
        Me.bar_StatusInfo.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.bar_StatusInfo.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bar_StatusInfo.IsMaximized = False
        Me.bar_StatusInfo.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.Label_VersionNumber, Me.Label_License, Me.Label_DatabaseName, Me.Label_DatabaseSize, Me.Label_Permission})
        Me.bar_StatusInfo.ItemSpacing = 10
        Me.bar_StatusInfo.Location = New System.Drawing.Point(5, 598)
        Me.bar_StatusInfo.Name = "bar_StatusInfo"
        Me.bar_StatusInfo.PaddingBottom = 2
        Me.bar_StatusInfo.PaddingLeft = 2
        Me.bar_StatusInfo.PaddingRight = 2
        Me.bar_StatusInfo.PaddingTop = 5
        Me.bar_StatusInfo.Size = New System.Drawing.Size(1212, 24)
        Me.bar_StatusInfo.Stretch = True
        Me.bar_StatusInfo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.bar_StatusInfo.TabIndex = 12
        Me.bar_StatusInfo.TabStop = False
        Me.bar_StatusInfo.Text = "Bar1"
        '
        'Label_VersionNumber
        '
        Me.Label_VersionNumber.Name = "Label_VersionNumber"
        Me.Label_VersionNumber.Text = "Version 1.0"
        '
        'Label_License
        '
        Me.Label_License.Name = "Label_License"
        Me.Label_License.Text = "Licensed to : SUN Group"
        '
        'Label_DatabaseName
        '
        Me.Label_DatabaseName.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far
        Me.Label_DatabaseName.Name = "Label_DatabaseName"
        Me.Label_DatabaseName.Text = "ฐานข้อมูล : XXX"
        '
        'Label_DatabaseSize
        '
        Me.Label_DatabaseSize.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far
        Me.Label_DatabaseSize.Name = "Label_DatabaseSize"
        Me.Label_DatabaseSize.Text = "ขนาด : XXX MB"
        '
        'Label_Permission
        '
        Me.Label_Permission.Name = "Label_Permission"
        Me.Label_Permission.Text = "สิทธิ์ใช้งาน : XXXX"
        '
        'tabcontrol_Main
        '
        Me.tabcontrol_Main.AutoCloseTabs = True
        Me.tabcontrol_Main.BackColor = System.Drawing.Color.White
        Me.tabcontrol_Main.CanReorderTabs = True
        Me.tabcontrol_Main.CloseButtonOnTabsVisible = True
        Me.tabcontrol_Main.CloseButtonPosition = DevComponents.DotNetBar.eTabCloseButtonPosition.Right
        Me.tabcontrol_Main.CloseButtonVisible = True
        Me.tabcontrol_Main.Controls.Add(Me.TabControlPanel_Dashboard)
        Me.tabcontrol_Main.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabcontrol_Main.ForeColor = System.Drawing.Color.Black
        Me.tabcontrol_Main.Location = New System.Drawing.Point(5, 171)
        Me.tabcontrol_Main.Name = "tabcontrol_Main"
        Me.tabcontrol_Main.SelectedTabFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.tabcontrol_Main.SelectedTabIndex = 0
        Me.tabcontrol_Main.Size = New System.Drawing.Size(1212, 427)
        Me.tabcontrol_Main.Style = DevComponents.DotNetBar.eTabStripStyle.Metro
        Me.tabcontrol_Main.TabIndex = 14
        Me.tabcontrol_Main.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox
        Me.tabcontrol_Main.Tabs.Add(Me.TabItem_Dashboard)
        Me.tabcontrol_Main.Text = "TabControl1"
        '
        'TabControlPanel_Dashboard
        '
        Me.TabControlPanel_Dashboard.DisabledBackColor = System.Drawing.Color.Empty
        Me.TabControlPanel_Dashboard.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel_Dashboard.Location = New System.Drawing.Point(0, 27)
        Me.TabControlPanel_Dashboard.Name = "TabControlPanel_Dashboard"
        Me.TabControlPanel_Dashboard.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel_Dashboard.Size = New System.Drawing.Size(1212, 400)
        Me.TabControlPanel_Dashboard.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.TabControlPanel_Dashboard.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel_Dashboard.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.TabControlPanel_Dashboard.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                    Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel_Dashboard.Style.GradientAngle = 90
        Me.TabControlPanel_Dashboard.TabIndex = 1
        Me.TabControlPanel_Dashboard.TabItem = Me.TabItem_Dashboard
        '
        'TabItem_Dashboard
        '
        Me.TabItem_Dashboard.AttachedControl = Me.TabControlPanel_Dashboard
        Me.TabItem_Dashboard.Name = "TabItem_Dashboard"
        Me.TabItem_Dashboard.Text = "แดชบอร์ด"
        '
        'frm_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1222, 624)
        Me.Controls.Add(Me.tabcontrol_Main)
        Me.Controls.Add(Me.bar_StatusInfo)
        Me.Controls.Add(Me.RibbonControl_Main)
        Me.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Equipment"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.RibbonControl_Main.ResumeLayout(False)
        Me.RibbonControl_Main.PerformLayout()
        Me.RibbonPanel_Management.ResumeLayout(False)
        Me.RibbonPanel_Settings.ResumeLayout(False)
        Me.RibbonPanel_Report.ResumeLayout(False)
        CType(Me.bar_StatusInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tabcontrol_Main, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabcontrol_Main.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RibbonControl_Main As DevComponents.DotNetBar.RibbonControl
    Friend WithEvents RibbonPanel_Management As DevComponents.DotNetBar.RibbonPanel
    Friend WithEvents RibbonPanel_Report As DevComponents.DotNetBar.RibbonPanel
    Friend WithEvents RibbonTabItem_Management As DevComponents.DotNetBar.RibbonTabItem
    Friend WithEvents RibbonTabItem_Report As DevComponents.DotNetBar.RibbonTabItem
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents RibbonPanel_Settings As DevComponents.DotNetBar.RibbonPanel
    Friend WithEvents RibbonTabItem_Settings As DevComponents.DotNetBar.RibbonTabItem
    Friend WithEvents RibbonBar_Stock As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents ButtonItem_StockIn As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem_StockOut As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents RibbonBar_Report As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents ButtonItem_ReportStockBalance As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem_ReportStockInOut As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem_ReportStockValue As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem_ReportStockTranfer As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem_ReportStockAdjust As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents Label_UserActive As DevComponents.DotNetBar.LabelItem
    Friend WithEvents Label_WarehouseActive As DevComponents.DotNetBar.LabelItem
    Friend WithEvents ItemContainer7 As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents ButtonItem_StockCount As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem_StockAdjust As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem_Tranfer As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem_StockTransection As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem_StockInTransection As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem_StockOutTransection As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem_StockAdjustTransection As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem_TranferTransection As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents RibbonBar_Database As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents ButtonItem_DataBackup As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents RibbonBar_System As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents ButtonItem_GeneralSettings As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem_Permission As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents RibbonBar_Help As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents ButtonItem_About As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem_ClearData As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents bar_StatusInfo As DevComponents.DotNetBar.Bar
    Friend WithEvents Label_VersionNumber As DevComponents.DotNetBar.LabelItem
    Friend WithEvents Label_License As DevComponents.DotNetBar.LabelItem
    Friend WithEvents Label_DatabaseName As DevComponents.DotNetBar.LabelItem
    Friend WithEvents Label_DatabaseSize As DevComponents.DotNetBar.LabelItem
    Friend WithEvents Label_Permission As DevComponents.DotNetBar.LabelItem
    Friend WithEvents tabcontrol_Main As DevComponents.DotNetBar.TabControl
    Friend WithEvents TabControlPanel_Dashboard As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents TabItem_Dashboard As DevComponents.DotNetBar.TabItem
    Friend WithEvents RibbonBar_Config As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents ButtonItem_WarehouseChange As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem_WarehouseConfig As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ItemContainer5 As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents ButtonItem_LocationsConfig As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem_CategoriesConfig As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem_SubCategoriesConfig As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ItemContainer6 As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents ButtonItem_SuppliersConfig As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem_OtherConfig As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem_MaterialTypeConfig As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem_Standards As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem_Unit As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem_MeasureConfig As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents RibbonBar_User As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents ButtonItem_UserConfig As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem_Logout As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents RibbonBar_SignBarcode As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents ButtonItem_PrintSign As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem_PrintBarcode As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents RibbonBar_Items As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents ButtonItem_AddItem As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem_FindItem As DevComponents.DotNetBar.ButtonItem

End Class
