<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usercon_equipment
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
        CType(Me.toolbar_RoomAction, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'toolbar_RoomAction
        '
        Me.toolbar_RoomAction.AccessibleDescription = "DotNetBar Bar (toolbar_RoomAction)"
        Me.toolbar_RoomAction.AccessibleName = "DotNetBar Bar"
        Me.toolbar_RoomAction.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar
        Me.toolbar_RoomAction.AntiAlias = True
        Me.toolbar_RoomAction.BarType = DevComponents.DotNetBar.eBarType.MenuBar
        Me.toolbar_RoomAction.Dock = System.Windows.Forms.DockStyle.Top
        Me.toolbar_RoomAction.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.toolbar_RoomAction.GrabHandleStyle = DevComponents.DotNetBar.eGrabHandleStyle.Office2003
        Me.toolbar_RoomAction.IsMaximized = False
        Me.toolbar_RoomAction.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.toolbar_RoomAction_Add, Me.toolbar_RoomAction_ViewEdit, Me.toolbar_RoomAction_Del, Me.toolbar_RoomAction_Refresh, Me.toolbar_RoomAction_Print, Me.toolbar_RoomAction_Export, Me.toolbar_RoomAction_Ungroup, Me.toolbar_RoomAction_TabClose})
        Me.toolbar_RoomAction.ItemSpacing = 5
        Me.toolbar_RoomAction.Location = New System.Drawing.Point(0, 0)
        Me.toolbar_RoomAction.Name = "toolbar_RoomAction"
        Me.toolbar_RoomAction.Size = New System.Drawing.Size(998, 25)
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
        Me.supergridview_RoomList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.supergridview_RoomList.FilterExprColors.SysFunction = System.Drawing.Color.Empty
        Me.supergridview_RoomList.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.supergridview_RoomList.ForeColor = System.Drawing.Color.Black
        Me.supergridview_RoomList.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F"
        Me.supergridview_RoomList.Location = New System.Drawing.Point(0, 25)
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
        Me.supergridview_RoomList.Size = New System.Drawing.Size(998, 625)
        Me.supergridview_RoomList.TabIndex = 13
        '
        'usercon_equipment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.supergridview_RoomList)
        Me.Controls.Add(Me.toolbar_RoomAction)
        Me.Name = "usercon_equipment"
        Me.Size = New System.Drawing.Size(998, 650)
        CType(Me.toolbar_RoomAction, System.ComponentModel.ISupportInitialize).EndInit()
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

End Class
