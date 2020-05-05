<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_Main
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Main))
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btn_Filter_Gender = New DevExpress.XtraBars.BarButtonItem()
        Me.Menu_Genders = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.btn_Filter_Gender_Boy = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Filter_Gender_Girl = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Filter_Religion = New DevExpress.XtraBars.BarButtonItem()
        Me.Menu_Religions = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.btn_Filter_Religion_Hindu = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Filter_Religion_Islam = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Filter_Religion_Christianity = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_ApplyFilter = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Filter_FirstLetter = New DevExpress.XtraBars.BarButtonItem()
        Me.Menu_FirstLetter = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.btn_Filter_FirstLetter_Automatic = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Filter_FirstLetter_Manual = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Filter_FirstLetter_None = New DevExpress.XtraBars.BarButtonItem()
        Me.lbl_NoOfItems = New DevExpress.XtraBars.BarStaticItem()
        Me.txt_NoOfItems = New DevExpress.XtraBars.BarStaticItem()
        Me.btn_GenerateReport = New DevExpress.XtraBars.BarButtonItem()
        Me.rp_Home = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.rpg_Filter = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpg_Report = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.gc_Names = New DevExpress.XtraGrid.GridControl()
        Me.gv_Names = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.grp_ManualFilter = New DevExpress.XtraEditors.GroupControl()
        Me.btn_InsertTamilLetters = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_BeginsWith = New DevExpress.XtraEditors.TextEdit()
        Me.lbl_BeginsWith = New DevExpress.XtraEditors.LabelControl()
        Me.grp_AutoFilter = New DevExpress.XtraEditors.GroupControl()
        Me.btn_CalcStarSign = New DevExpress.XtraEditors.SimpleButton()
        Me.layout_StarSign = New System.Windows.Forms.TableLayoutPanel()
        Me.lbl_Letters = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_Nakshatra = New DevExpress.XtraEditors.LabelControl()
        Me.cmb_Nakshatra = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cmb_Rashi = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.lbl_Rashi = New DevExpress.XtraEditors.LabelControl()
        Me.txt_Letters = New DevExpress.XtraEditors.TextEdit()
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Menu_Genders, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Menu_Religions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Menu_FirstLetter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gc_Names, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gv_Names, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grp_ManualFilter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_ManualFilter.SuspendLayout()
        CType(Me.txt_BeginsWith.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grp_AutoFilter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_AutoFilter.SuspendLayout()
        Me.layout_StarSign.SuspendLayout()
        CType(Me.cmb_Nakshatra.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_Rashi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Letters.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl
        '
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.RibbonControl.SearchEditItem, Me.btn_Filter_Gender, Me.btn_Filter_Gender_Boy, Me.btn_Filter_Gender_Girl, Me.btn_Filter_Religion, Me.btn_Filter_Religion_Hindu, Me.btn_Filter_Religion_Islam, Me.btn_Filter_Religion_Christianity, Me.btn_ApplyFilter, Me.btn_Filter_FirstLetter, Me.btn_Filter_FirstLetter_Automatic, Me.btn_Filter_FirstLetter_Manual, Me.lbl_NoOfItems, Me.txt_NoOfItems, Me.btn_GenerateReport, Me.btn_Filter_FirstLetter_None})
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.MaxItemId = 22
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.rp_Home})
        Me.RibbonControl.ShowCategoryInCaption = False
        Me.RibbonControl.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl.ShowQatLocationSelector = False
        Me.RibbonControl.ShowToolbarCustomizeItem = False
        Me.RibbonControl.Size = New System.Drawing.Size(655, 158)
        Me.RibbonControl.StatusBar = Me.RibbonStatusBar
        Me.RibbonControl.Toolbar.ShowCustomizeItem = False
        '
        'btn_Filter_Gender
        '
        Me.btn_Filter_Gender.ActAsDropDown = True
        Me.btn_Filter_Gender.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
        Me.btn_Filter_Gender.Caption = "Gender"
        Me.btn_Filter_Gender.DropDownControl = Me.Menu_Genders
        Me.btn_Filter_Gender.Id = 5
        Me.btn_Filter_Gender.ImageOptions.SvgImage = CType(resources.GetObject("btn_Filter_Gender.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btn_Filter_Gender.Name = "btn_Filter_Gender"
        '
        'Menu_Genders
        '
        Me.Menu_Genders.ItemLinks.Add(Me.btn_Filter_Gender_Boy)
        Me.Menu_Genders.ItemLinks.Add(Me.btn_Filter_Gender_Girl)
        Me.Menu_Genders.Name = "Menu_Genders"
        Me.Menu_Genders.Ribbon = Me.RibbonControl
        '
        'btn_Filter_Gender_Boy
        '
        Me.btn_Filter_Gender_Boy.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.btn_Filter_Gender_Boy.Caption = "Boy"
        Me.btn_Filter_Gender_Boy.Down = True
        Me.btn_Filter_Gender_Boy.Id = 6
        Me.btn_Filter_Gender_Boy.ImageOptions.SvgImage = CType(resources.GetObject("btn_Filter_Gender_Boy.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btn_Filter_Gender_Boy.Name = "btn_Filter_Gender_Boy"
        '
        'btn_Filter_Gender_Girl
        '
        Me.btn_Filter_Gender_Girl.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.btn_Filter_Gender_Girl.Caption = "Girl"
        Me.btn_Filter_Gender_Girl.Down = True
        Me.btn_Filter_Gender_Girl.Id = 7
        Me.btn_Filter_Gender_Girl.ImageOptions.SvgImage = CType(resources.GetObject("btn_Filter_Gender_Girl.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btn_Filter_Gender_Girl.Name = "btn_Filter_Gender_Girl"
        '
        'btn_Filter_Religion
        '
        Me.btn_Filter_Religion.ActAsDropDown = True
        Me.btn_Filter_Religion.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
        Me.btn_Filter_Religion.Caption = "Religion"
        Me.btn_Filter_Religion.DropDownControl = Me.Menu_Religions
        Me.btn_Filter_Religion.Id = 10
        Me.btn_Filter_Religion.ImageOptions.SvgImage = CType(resources.GetObject("btn_Filter_Religion.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btn_Filter_Religion.Name = "btn_Filter_Religion"
        '
        'Menu_Religions
        '
        Me.Menu_Religions.ItemLinks.Add(Me.btn_Filter_Religion_Hindu)
        Me.Menu_Religions.ItemLinks.Add(Me.btn_Filter_Religion_Islam)
        Me.Menu_Religions.ItemLinks.Add(Me.btn_Filter_Religion_Christianity)
        Me.Menu_Religions.Name = "Menu_Religions"
        Me.Menu_Religions.Ribbon = Me.RibbonControl
        '
        'btn_Filter_Religion_Hindu
        '
        Me.btn_Filter_Religion_Hindu.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.btn_Filter_Religion_Hindu.Caption = "Hindu"
        Me.btn_Filter_Religion_Hindu.Down = True
        Me.btn_Filter_Religion_Hindu.Id = 11
        Me.btn_Filter_Religion_Hindu.ImageOptions.SvgImage = CType(resources.GetObject("btn_Filter_Religion_Hindu.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btn_Filter_Religion_Hindu.Name = "btn_Filter_Religion_Hindu"
        '
        'btn_Filter_Religion_Islam
        '
        Me.btn_Filter_Religion_Islam.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.btn_Filter_Religion_Islam.Caption = "Islam"
        Me.btn_Filter_Religion_Islam.Down = True
        Me.btn_Filter_Religion_Islam.Id = 12
        Me.btn_Filter_Religion_Islam.ImageOptions.SvgImage = CType(resources.GetObject("btn_Filter_Religion_Islam.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btn_Filter_Religion_Islam.Name = "btn_Filter_Religion_Islam"
        '
        'btn_Filter_Religion_Christianity
        '
        Me.btn_Filter_Religion_Christianity.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.btn_Filter_Religion_Christianity.Caption = "Christianity"
        Me.btn_Filter_Religion_Christianity.Down = True
        Me.btn_Filter_Religion_Christianity.Id = 13
        Me.btn_Filter_Religion_Christianity.ImageOptions.SvgImage = CType(resources.GetObject("btn_Filter_Religion_Christianity.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btn_Filter_Religion_Christianity.Name = "btn_Filter_Religion_Christianity"
        '
        'btn_ApplyFilter
        '
        Me.btn_ApplyFilter.Caption = "Apply Filter"
        Me.btn_ApplyFilter.Id = 14
        Me.btn_ApplyFilter.ImageOptions.SvgImage = CType(resources.GetObject("btn_ApplyFilter.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btn_ApplyFilter.Name = "btn_ApplyFilter"
        '
        'btn_Filter_FirstLetter
        '
        Me.btn_Filter_FirstLetter.ActAsDropDown = True
        Me.btn_Filter_FirstLetter.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
        Me.btn_Filter_FirstLetter.Caption = "First Letter"
        Me.btn_Filter_FirstLetter.DropDownControl = Me.Menu_FirstLetter
        Me.btn_Filter_FirstLetter.Id = 15
        Me.btn_Filter_FirstLetter.ImageOptions.SvgImage = CType(resources.GetObject("btn_Filter_FirstLetter.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btn_Filter_FirstLetter.Name = "btn_Filter_FirstLetter"
        '
        'Menu_FirstLetter
        '
        Me.Menu_FirstLetter.ItemLinks.Add(Me.btn_Filter_FirstLetter_Automatic)
        Me.Menu_FirstLetter.ItemLinks.Add(Me.btn_Filter_FirstLetter_Manual)
        Me.Menu_FirstLetter.ItemLinks.Add(Me.btn_Filter_FirstLetter_None)
        Me.Menu_FirstLetter.Name = "Menu_FirstLetter"
        Me.Menu_FirstLetter.Ribbon = Me.RibbonControl
        '
        'btn_Filter_FirstLetter_Automatic
        '
        Me.btn_Filter_FirstLetter_Automatic.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.btn_Filter_FirstLetter_Automatic.Caption = "Automatic"
        Me.btn_Filter_FirstLetter_Automatic.Down = True
        Me.btn_Filter_FirstLetter_Automatic.Id = 16
        Me.btn_Filter_FirstLetter_Automatic.ImageOptions.SvgImage = CType(resources.GetObject("btn_Filter_FirstLetter_Automatic.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btn_Filter_FirstLetter_Automatic.Name = "btn_Filter_FirstLetter_Automatic"
        '
        'btn_Filter_FirstLetter_Manual
        '
        Me.btn_Filter_FirstLetter_Manual.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.btn_Filter_FirstLetter_Manual.Caption = "Manual"
        Me.btn_Filter_FirstLetter_Manual.Id = 17
        Me.btn_Filter_FirstLetter_Manual.ImageOptions.SvgImage = CType(resources.GetObject("btn_Filter_FirstLetter_Manual.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btn_Filter_FirstLetter_Manual.Name = "btn_Filter_FirstLetter_Manual"
        '
        'btn_Filter_FirstLetter_None
        '
        Me.btn_Filter_FirstLetter_None.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.btn_Filter_FirstLetter_None.Caption = "None"
        Me.btn_Filter_FirstLetter_None.Id = 21
        Me.btn_Filter_FirstLetter_None.ImageOptions.SvgImage = CType(resources.GetObject("btn_Filter_FirstLetter_None.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btn_Filter_FirstLetter_None.Name = "btn_Filter_FirstLetter_None"
        '
        'lbl_NoOfItems
        '
        Me.lbl_NoOfItems.Caption = "No Of Items :"
        Me.lbl_NoOfItems.Id = 18
        Me.lbl_NoOfItems.Name = "lbl_NoOfItems"
        '
        'txt_NoOfItems
        '
        Me.txt_NoOfItems.Caption = "0"
        Me.txt_NoOfItems.Id = 19
        Me.txt_NoOfItems.Name = "txt_NoOfItems"
        '
        'btn_GenerateReport
        '
        Me.btn_GenerateReport.Caption = "Generate Report"
        Me.btn_GenerateReport.Id = 20
        Me.btn_GenerateReport.ImageOptions.SvgImage = CType(resources.GetObject("btn_GenerateReport.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btn_GenerateReport.Name = "btn_GenerateReport"
        '
        'rp_Home
        '
        Me.rp_Home.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.rpg_Filter, Me.rpg_Report})
        Me.rp_Home.Name = "rp_Home"
        Me.rp_Home.Text = "Home"
        '
        'rpg_Filter
        '
        Me.rpg_Filter.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
        Me.rpg_Filter.ItemLinks.Add(Me.btn_Filter_Gender)
        Me.rpg_Filter.ItemLinks.Add(Me.btn_Filter_Religion)
        Me.rpg_Filter.ItemLinks.Add(Me.btn_Filter_FirstLetter)
        Me.rpg_Filter.ItemLinks.Add(Me.btn_ApplyFilter, True)
        Me.rpg_Filter.Name = "rpg_Filter"
        Me.rpg_Filter.Text = "Filters"
        '
        'rpg_Report
        '
        Me.rpg_Report.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
        Me.rpg_Report.ItemLinks.Add(Me.btn_GenerateReport)
        Me.rpg_Report.Name = "rpg_Report"
        Me.rpg_Report.Text = "Report"
        '
        'RibbonStatusBar
        '
        Me.RibbonStatusBar.ItemLinks.Add(Me.lbl_NoOfItems)
        Me.RibbonStatusBar.ItemLinks.Add(Me.txt_NoOfItems)
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 425)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.RibbonControl
        Me.RibbonStatusBar.Size = New System.Drawing.Size(655, 24)
        '
        'gc_Names
        '
        Me.gc_Names.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gc_Names.Location = New System.Drawing.Point(0, 286)
        Me.gc_Names.MainView = Me.gv_Names
        Me.gc_Names.MenuManager = Me.RibbonControl
        Me.gc_Names.Name = "gc_Names"
        Me.gc_Names.Size = New System.Drawing.Size(655, 139)
        Me.gc_Names.TabIndex = 2
        Me.gc_Names.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gv_Names})
        '
        'gv_Names
        '
        Me.gv_Names.GridControl = Me.gc_Names
        Me.gv_Names.Name = "gv_Names"
        '
        'grp_ManualFilter
        '
        Me.grp_ManualFilter.Controls.Add(Me.btn_InsertTamilLetters)
        Me.grp_ManualFilter.Controls.Add(Me.txt_BeginsWith)
        Me.grp_ManualFilter.Controls.Add(Me.lbl_BeginsWith)
        Me.grp_ManualFilter.Dock = System.Windows.Forms.DockStyle.Top
        Me.grp_ManualFilter.Location = New System.Drawing.Point(0, 158)
        Me.grp_ManualFilter.Name = "grp_ManualFilter"
        Me.grp_ManualFilter.Size = New System.Drawing.Size(655, 49)
        Me.grp_ManualFilter.TabIndex = 3
        Me.grp_ManualFilter.Text = "First Letter Filter - Manual"
        Me.grp_ManualFilter.Visible = False
        '
        'btn_InsertTamilLetters
        '
        Me.btn_InsertTamilLetters.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_InsertTamilLetters.Location = New System.Drawing.Point(529, 21)
        Me.btn_InsertTamilLetters.Name = "btn_InsertTamilLetters"
        Me.btn_InsertTamilLetters.Size = New System.Drawing.Size(114, 23)
        Me.btn_InsertTamilLetters.TabIndex = 1
        Me.btn_InsertTamilLetters.Text = "Insert Tamil Letters"
        '
        'txt_BeginsWith
        '
        Me.txt_BeginsWith.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_BeginsWith.Location = New System.Drawing.Point(97, 23)
        Me.txt_BeginsWith.MenuManager = Me.RibbonControl
        Me.txt_BeginsWith.Name = "txt_BeginsWith"
        Me.txt_BeginsWith.Size = New System.Drawing.Size(426, 20)
        Me.txt_BeginsWith.TabIndex = 0
        '
        'lbl_BeginsWith
        '
        Me.lbl_BeginsWith.Location = New System.Drawing.Point(28, 26)
        Me.lbl_BeginsWith.Name = "lbl_BeginsWith"
        Me.lbl_BeginsWith.Size = New System.Drawing.Size(63, 13)
        Me.lbl_BeginsWith.TabIndex = 0
        Me.lbl_BeginsWith.Text = "Begins With :"
        '
        'grp_AutoFilter
        '
        Me.grp_AutoFilter.Controls.Add(Me.btn_CalcStarSign)
        Me.grp_AutoFilter.Controls.Add(Me.layout_StarSign)
        Me.grp_AutoFilter.Dock = System.Windows.Forms.DockStyle.Top
        Me.grp_AutoFilter.Location = New System.Drawing.Point(0, 207)
        Me.grp_AutoFilter.Name = "grp_AutoFilter"
        Me.grp_AutoFilter.Size = New System.Drawing.Size(655, 79)
        Me.grp_AutoFilter.TabIndex = 4
        Me.grp_AutoFilter.Text = "First Letter Filter - Automatic (Based on Star Sign)"
        '
        'btn_CalcStarSign
        '
        Me.btn_CalcStarSign.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_CalcStarSign.Location = New System.Drawing.Point(502, 23)
        Me.btn_CalcStarSign.Name = "btn_CalcStarSign"
        Me.btn_CalcStarSign.Size = New System.Drawing.Size(141, 52)
        Me.btn_CalcStarSign.TabIndex = 3
        Me.btn_CalcStarSign.Text = "Find Nakshatra, Rashi" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "using" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Date && Time of Birth"
        '
        'layout_StarSign
        '
        Me.layout_StarSign.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.layout_StarSign.ColumnCount = 4
        Me.layout_StarSign.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 82.0!))
        Me.layout_StarSign.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.layout_StarSign.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 49.0!))
        Me.layout_StarSign.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.layout_StarSign.Controls.Add(Me.lbl_Letters, 0, 1)
        Me.layout_StarSign.Controls.Add(Me.lbl_Nakshatra, 0, 0)
        Me.layout_StarSign.Controls.Add(Me.cmb_Nakshatra, 1, 0)
        Me.layout_StarSign.Controls.Add(Me.cmb_Rashi, 3, 0)
        Me.layout_StarSign.Controls.Add(Me.lbl_Rashi, 2, 0)
        Me.layout_StarSign.Controls.Add(Me.txt_Letters, 1, 1)
        Me.layout_StarSign.Location = New System.Drawing.Point(12, 23)
        Me.layout_StarSign.Name = "layout_StarSign"
        Me.layout_StarSign.RowCount = 2
        Me.layout_StarSign.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.layout_StarSign.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.layout_StarSign.Size = New System.Drawing.Size(484, 52)
        Me.layout_StarSign.TabIndex = 2
        '
        'lbl_Letters
        '
        Me.lbl_Letters.Appearance.Options.UseTextOptions = True
        Me.lbl_Letters.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_Letters.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.lbl_Letters.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_Letters.Location = New System.Drawing.Point(3, 29)
        Me.lbl_Letters.Name = "lbl_Letters"
        Me.lbl_Letters.Size = New System.Drawing.Size(76, 20)
        Me.lbl_Letters.TabIndex = 4
        Me.lbl_Letters.Text = "Letters :"
        '
        'lbl_Nakshatra
        '
        Me.lbl_Nakshatra.Appearance.Options.UseTextOptions = True
        Me.lbl_Nakshatra.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_Nakshatra.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.lbl_Nakshatra.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_Nakshatra.Location = New System.Drawing.Point(3, 3)
        Me.lbl_Nakshatra.Name = "lbl_Nakshatra"
        Me.lbl_Nakshatra.Size = New System.Drawing.Size(76, 20)
        Me.lbl_Nakshatra.TabIndex = 0
        Me.lbl_Nakshatra.Text = "Nakshatra :"
        '
        'cmb_Nakshatra
        '
        Me.cmb_Nakshatra.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmb_Nakshatra.Location = New System.Drawing.Point(85, 3)
        Me.cmb_Nakshatra.MenuManager = Me.RibbonControl
        Me.cmb_Nakshatra.Name = "cmb_Nakshatra"
        Me.cmb_Nakshatra.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmb_Nakshatra.Size = New System.Drawing.Size(170, 20)
        Me.cmb_Nakshatra.TabIndex = 1
        '
        'cmb_Rashi
        '
        Me.cmb_Rashi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmb_Rashi.Location = New System.Drawing.Point(310, 3)
        Me.cmb_Rashi.Name = "cmb_Rashi"
        Me.cmb_Rashi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmb_Rashi.Size = New System.Drawing.Size(171, 20)
        Me.cmb_Rashi.TabIndex = 1
        '
        'lbl_Rashi
        '
        Me.lbl_Rashi.Appearance.Options.UseTextOptions = True
        Me.lbl_Rashi.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_Rashi.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.lbl_Rashi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_Rashi.Location = New System.Drawing.Point(261, 3)
        Me.lbl_Rashi.Name = "lbl_Rashi"
        Me.lbl_Rashi.Size = New System.Drawing.Size(43, 20)
        Me.lbl_Rashi.TabIndex = 0
        Me.lbl_Rashi.Text = "Rashi :"
        '
        'txt_Letters
        '
        Me.layout_StarSign.SetColumnSpan(Me.txt_Letters, 3)
        Me.txt_Letters.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Letters.Location = New System.Drawing.Point(85, 29)
        Me.txt_Letters.MenuManager = Me.RibbonControl
        Me.txt_Letters.Name = "txt_Letters"
        Me.txt_Letters.Size = New System.Drawing.Size(396, 20)
        Me.txt_Letters.TabIndex = 5
        '
        'frm_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(655, 449)
        Me.Controls.Add(Me.gc_Names)
        Me.Controls.Add(Me.grp_AutoFilter)
        Me.Controls.Add(Me.grp_ManualFilter)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.RibbonControl)
        Me.IconOptions.Icon = CType(resources.GetObject("frm_Main.IconOptions.Icon"), System.Drawing.Icon)
        Me.Name = "frm_Main"
        Me.Ribbon = Me.RibbonControl
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "Devil7 - Tamil Baby Names"
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Menu_Genders, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Menu_Religions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Menu_FirstLetter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gc_Names, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gv_Names, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grp_ManualFilter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_ManualFilter.ResumeLayout(False)
        Me.grp_ManualFilter.PerformLayout()
        CType(Me.txt_BeginsWith.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grp_AutoFilter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_AutoFilter.ResumeLayout(False)
        Me.layout_StarSign.ResumeLayout(False)
        Me.layout_StarSign.PerformLayout()
        CType(Me.cmb_Nakshatra.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_Rashi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Letters.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents rp_Home As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents rpg_Filter As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents btn_Filter_Gender As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Menu_Genders As DevExpress.XtraBars.PopupMenu
    Friend WithEvents btn_Filter_Gender_Boy As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Filter_Gender_Girl As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Filter_Religion As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Menu_Religions As DevExpress.XtraBars.PopupMenu
    Friend WithEvents btn_Filter_Religion_Hindu As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Filter_Religion_Islam As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Filter_Religion_Christianity As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_ApplyFilter As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Filter_FirstLetter As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents gc_Names As DevExpress.XtraGrid.GridControl
    Friend WithEvents gv_Names As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents grp_ManualFilter As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txt_BeginsWith As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lbl_BeginsWith As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grp_AutoFilter As DevExpress.XtraEditors.GroupControl
    Friend WithEvents layout_StarSign As TableLayoutPanel
    Friend WithEvents lbl_Nakshatra As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmb_Nakshatra As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cmb_Rashi As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents lbl_Rashi As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_CalcStarSign As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lbl_Letters As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_Letters As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Menu_FirstLetter As DevExpress.XtraBars.PopupMenu
    Friend WithEvents btn_Filter_FirstLetter_Automatic As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Filter_FirstLetter_Manual As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents lbl_NoOfItems As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents txt_NoOfItems As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents btn_InsertTamilLetters As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_GenerateReport As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rpg_Report As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btn_Filter_FirstLetter_None As DevExpress.XtraBars.BarButtonItem
End Class
