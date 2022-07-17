﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits MetroFramework.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("")
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("")
        Me.ttBP = New System.Windows.Forms.ToolTip(Me.components)
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.gbSystems = New System.Windows.Forms.GroupBox()
        Me.ListOptionsMenu = New MetroFramework.Controls.MetroContextMenu(Me.components)
        Me.AddToShoppingListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IgnoreBlueprintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FavoriteBlueprintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ttUpdatePrices = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttManufacturing = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttDatacores = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttReactions = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttMining = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttPI = New System.Windows.Forms.ToolTip(Me.components)
        Me.CalcImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.btnDownloadPrices = New MetroFramework.Controls.MetroButton()
        Me.btnCalcCalculate = New MetroFramework.Controls.MetroButton()
        Me.MetroProgressBar = New MetroFramework.Controls.MetroProgressBar()
        Me.mnuChar = New MetroFramework.Controls.MetroComboBox()
        Me.chkCalcCanBuild = New MetroFramework.Controls.MetroCheckBox()
        Me.autoShopping = New MetroFramework.Controls.MetroRadioButton()
        Me.rbtnCalcAllBPs = New MetroFramework.Controls.MetroRadioButton()
        Me.rbtnCalcBPOwned = New MetroFramework.Controls.MetroRadioButton()
        Me.pnlStatus = New MetroFramework.Controls.MetroLabel()
        Me.lblCharacterData = New MetroFramework.Controls.MetroLabel()
        Me.lblRecommendation = New MetroFramework.Controls.MetroLabel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.FrmShoppingList1 = New Easy_IPH.frmShoppingList()
        Me.trkTrips = New MetroFramework.Controls.MetroTrackBar()
        Me.btnAddChar = New MetroFramework.Controls.MetroButton()
        Me.CalcBaseFacility = New Easy_IPH.ManufacturingFacility()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.lstManufacturing = New Easy_IPH.ManufacturingListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.chkDisableTracking = New System.Windows.Forms.CheckBox()
        Me.LabelVersion = New MetroFramework.Controls.MetroLabel()
        Me.ReportBugIcon = New System.Windows.Forms.PictureBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.VisitWebIcon = New System.Windows.Forms.PictureBox()
        Me.btnDonate = New MetroFramework.Controls.MetroButton()
        Me.PateronIcon = New System.Windows.Forms.PictureBox()
        Me.btnVisitweb = New MetroFramework.Controls.MetroButton()
        Me.btnReportbug = New MetroFramework.Controls.MetroButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnResetAll = New MetroFramework.Controls.MetroButton()
        Me.btnManageChar = New MetroFramework.Controls.MetroButton()
        Me.ListOptionsMenu.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.ReportBugIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VisitWebIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PateronIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ttBP
        '
        Me.ttBP.IsBalloon = True
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "OpenFileDialog1"
        '
        'gbSystems
        '
        Me.gbSystems.Location = New System.Drawing.Point(0, 0)
        Me.gbSystems.Name = "gbSystems"
        Me.gbSystems.Size = New System.Drawing.Size(200, 100)
        Me.gbSystems.TabIndex = 0
        Me.gbSystems.TabStop = False
        '
        'ListOptionsMenu
        '
        Me.ListOptionsMenu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ListOptionsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToShoppingListToolStripMenuItem, Me.IgnoreBlueprintToolStripMenuItem, Me.FavoriteBlueprintToolStripMenuItem})
        Me.ListOptionsMenu.Name = "ListOptionsMenu"
        Me.ListOptionsMenu.Size = New System.Drawing.Size(219, 76)
        Me.ListOptionsMenu.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'AddToShoppingListToolStripMenuItem
        '
        Me.AddToShoppingListToolStripMenuItem.Name = "AddToShoppingListToolStripMenuItem"
        Me.AddToShoppingListToolStripMenuItem.Size = New System.Drawing.Size(218, 24)
        Me.AddToShoppingListToolStripMenuItem.Text = "Add to Shopping List"
        '
        'IgnoreBlueprintToolStripMenuItem
        '
        Me.IgnoreBlueprintToolStripMenuItem.Name = "IgnoreBlueprintToolStripMenuItem"
        Me.IgnoreBlueprintToolStripMenuItem.Size = New System.Drawing.Size(218, 24)
        Me.IgnoreBlueprintToolStripMenuItem.Text = "Ignore Blueprint"
        '
        'FavoriteBlueprintToolStripMenuItem
        '
        Me.FavoriteBlueprintToolStripMenuItem.Name = "FavoriteBlueprintToolStripMenuItem"
        Me.FavoriteBlueprintToolStripMenuItem.Size = New System.Drawing.Size(218, 24)
        Me.FavoriteBlueprintToolStripMenuItem.Text = "Favorite Blueprint"
        '
        'CalcImageList
        '
        Me.CalcImageList.ImageStream = CType(resources.GetObject("CalcImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.CalcImageList.TransparentColor = System.Drawing.Color.White
        Me.CalcImageList.Images.SetKeyName(0, "GreenUP.bmp")
        Me.CalcImageList.Images.SetKeyName(1, "RedDown.bmp")
        Me.CalcImageList.Images.SetKeyName(2, "T2.bmp")
        Me.CalcImageList.Images.SetKeyName(3, "T3.bmp")
        Me.CalcImageList.Images.SetKeyName(4, "Storyline.bmp")
        Me.CalcImageList.Images.SetKeyName(5, "Faction.bmp")
        Me.CalcImageList.Images.SetKeyName(6, "Blank.bmp")
        Me.CalcImageList.Images.SetKeyName(7, "Green Up Arrow.bmp")
        Me.CalcImageList.Images.SetKeyName(8, "Red Down Arrow.bmp")
        '
        'btnDownloadPrices
        '
        Me.btnDownloadPrices.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btnDownloadPrices.Location = New System.Drawing.Point(22, 465)
        Me.btnDownloadPrices.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDownloadPrices.Name = "btnDownloadPrices"
        Me.btnDownloadPrices.Size = New System.Drawing.Size(156, 56)
        Me.btnDownloadPrices.TabIndex = 12
        Me.btnDownloadPrices.Text = "Update" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Prices"
        Me.btnDownloadPrices.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btnDownloadPrices.UseSelectable = True
        '
        'btnCalcCalculate
        '
        Me.btnCalcCalculate.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btnCalcCalculate.Location = New System.Drawing.Point(209, 465)
        Me.btnCalcCalculate.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCalcCalculate.Name = "btnCalcCalculate"
        Me.btnCalcCalculate.Size = New System.Drawing.Size(156, 56)
        Me.btnCalcCalculate.TabIndex = 21
        Me.btnCalcCalculate.Text = "Calculate"
        Me.btnCalcCalculate.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btnCalcCalculate.UseSelectable = True
        '
        'MetroProgressBar
        '
        Me.MetroProgressBar.Location = New System.Drawing.Point(395, 495)
        Me.MetroProgressBar.Name = "MetroProgressBar"
        Me.MetroProgressBar.Size = New System.Drawing.Size(442, 26)
        Me.MetroProgressBar.TabIndex = 76
        Me.MetroProgressBar.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'mnuChar
        '
        Me.mnuChar.FontSize = MetroFramework.MetroComboBoxSize.Tall
        Me.mnuChar.FormattingEnabled = True
        Me.mnuChar.ItemHeight = 29
        Me.mnuChar.Items.AddRange(New Object() {"Select A Character..."})
        Me.mnuChar.Location = New System.Drawing.Point(148, 60)
        Me.mnuChar.Name = "mnuChar"
        Me.mnuChar.Size = New System.Drawing.Size(330, 35)
        Me.mnuChar.TabIndex = 88
        Me.mnuChar.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.mnuChar.UseSelectable = True
        '
        'chkCalcCanBuild
        '
        Me.chkCalcCanBuild.AutoSize = True
        Me.chkCalcCanBuild.BackColor = System.Drawing.Color.Transparent
        Me.chkCalcCanBuild.Checked = True
        Me.chkCalcCanBuild.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkCalcCanBuild.ForeColor = System.Drawing.Color.White
        Me.chkCalcCanBuild.Location = New System.Drawing.Point(125, 30)
        Me.chkCalcCanBuild.Margin = New System.Windows.Forms.Padding(4)
        Me.chkCalcCanBuild.Name = "chkCalcCanBuild"
        Me.chkCalcCanBuild.Size = New System.Drawing.Size(206, 17)
        Me.chkCalcCanBuild.TabIndex = 89
        Me.chkCalcCanBuild.Text = "Only Calculate Items I Can Build"
        Me.chkCalcCanBuild.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.chkCalcCanBuild.UseSelectable = True
        Me.chkCalcCanBuild.Visible = False
        '
        'autoShopping
        '
        Me.autoShopping.AutoSize = True
        Me.autoShopping.BackColor = System.Drawing.Color.Transparent
        Me.autoShopping.FontSize = MetroFramework.MetroCheckBoxSize.Medium
        Me.autoShopping.ForeColor = System.Drawing.Color.White
        Me.autoShopping.Location = New System.Drawing.Point(471, 410)
        Me.autoShopping.Margin = New System.Windows.Forms.Padding(4)
        Me.autoShopping.Name = "autoShopping"
        Me.autoShopping.Size = New System.Drawing.Size(258, 20)
        Me.autoShopping.TabIndex = 88
        Me.autoShopping.Text = "Calculate Profit From My Blueprints"
        Me.autoShopping.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.autoShopping.UseSelectable = True
        '
        'rbtnCalcAllBPs
        '
        Me.rbtnCalcAllBPs.AutoSize = True
        Me.rbtnCalcAllBPs.Checked = True
        Me.rbtnCalcAllBPs.FontSize = MetroFramework.MetroCheckBoxSize.Medium
        Me.rbtnCalcAllBPs.Location = New System.Drawing.Point(471, 375)
        Me.rbtnCalcAllBPs.Margin = New System.Windows.Forms.Padding(4)
        Me.rbtnCalcAllBPs.Name = "rbtnCalcAllBPs"
        Me.rbtnCalcAllBPs.Size = New System.Drawing.Size(226, 20)
        Me.rbtnCalcAllBPs.TabIndex = 0
        Me.rbtnCalcAllBPs.TabStop = True
        Me.rbtnCalcAllBPs.Text = "Find New Profitable Blueprints"
        Me.rbtnCalcAllBPs.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.rbtnCalcAllBPs.UseSelectable = True
        '
        'rbtnCalcBPOwned
        '
        Me.rbtnCalcBPOwned.AutoSize = True
        Me.rbtnCalcBPOwned.Location = New System.Drawing.Point(339, 30)
        Me.rbtnCalcBPOwned.Margin = New System.Windows.Forms.Padding(4)
        Me.rbtnCalcBPOwned.Name = "rbtnCalcBPOwned"
        Me.rbtnCalcBPOwned.Size = New System.Drawing.Size(228, 17)
        Me.rbtnCalcBPOwned.TabIndex = 1
        Me.rbtnCalcBPOwned.Text = "Calculate Profit From My Blueprints"
        Me.rbtnCalcBPOwned.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.rbtnCalcBPOwned.UseSelectable = True
        Me.rbtnCalcBPOwned.Visible = False
        '
        'pnlStatus
        '
        Me.pnlStatus.BackColor = System.Drawing.Color.Transparent
        Me.pnlStatus.ForeColor = System.Drawing.Color.Transparent
        Me.pnlStatus.Location = New System.Drawing.Point(441, 457)
        Me.pnlStatus.Name = "pnlStatus"
        Me.pnlStatus.Size = New System.Drawing.Size(354, 35)
        Me.pnlStatus.TabIndex = 86
        Me.pnlStatus.Text = "Calculation status will appear here..."
        Me.pnlStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.pnlStatus.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'lblCharacterData
        '
        Me.lblCharacterData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCharacterData.Location = New System.Drawing.Point(22, 541)
        Me.lblCharacterData.Name = "lblCharacterData"
        Me.lblCharacterData.Size = New System.Drawing.Size(815, 37)
        Me.lblCharacterData.TabIndex = 90
        Me.lblCharacterData.Text = "Market/Wallet/Job data not updated yet, click Calculate to begin..."
        Me.lblCharacterData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblCharacterData.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.lblCharacterData.WrapToLine = True
        '
        'lblRecommendation
        '
        Me.lblRecommendation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRecommendation.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblRecommendation.Location = New System.Drawing.Point(22, 590)
        Me.lblRecommendation.Name = "lblRecommendation"
        Me.lblRecommendation.Size = New System.Drawing.Size(815, 175)
        Me.lblRecommendation.TabIndex = 88
        Me.lblRecommendation.Text = "Recommendations will appear here..."
        Me.lblRecommendation.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.lblRecommendation.WrapToLine = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(20, 91)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1620, 811)
        Me.TabControl1.TabIndex = 95
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.pnlStatus)
        Me.TabPage1.Controls.Add(Me.rbtnCalcAllBPs)
        Me.TabPage1.Controls.Add(Me.FrmShoppingList1)
        Me.TabPage1.Controls.Add(Me.autoShopping)
        Me.TabPage1.Controls.Add(Me.trkTrips)
        Me.TabPage1.Controls.Add(Me.btnAddChar)
        Me.TabPage1.Controls.Add(Me.lblRecommendation)
        Me.TabPage1.Controls.Add(Me.mnuChar)
        Me.TabPage1.Controls.Add(Me.MetroProgressBar)
        Me.TabPage1.Controls.Add(Me.CalcBaseFacility)
        Me.TabPage1.Controls.Add(Me.btnCalcCalculate)
        Me.TabPage1.Controls.Add(Me.btnDownloadPrices)
        Me.TabPage1.Controls.Add(Me.lblCharacterData)
        Me.TabPage1.Controls.Add(Me.MetroLabel4)
        Me.TabPage1.Controls.Add(Me.MetroLabel3)
        Me.TabPage1.Controls.Add(Me.MetroLabel1)
        Me.TabPage1.ForeColor = System.Drawing.Color.DimGray
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1612, 782)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        '
        'FrmShoppingList1
        '
        Me.FrmShoppingList1.AutoSize = True
        Me.FrmShoppingList1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.FrmShoppingList1.Location = New System.Drawing.Point(857, 8)
        Me.FrmShoppingList1.Margin = New System.Windows.Forms.Padding(4)
        Me.FrmShoppingList1.Name = "FrmShoppingList1"
        Me.FrmShoppingList1.Size = New System.Drawing.Size(748, 767)
        Me.FrmShoppingList1.TabIndex = 95
        '
        'trkTrips
        '
        Me.trkTrips.BackColor = System.Drawing.Color.Transparent
        Me.trkTrips.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.trkTrips.LargeChange = 4
        Me.trkTrips.Location = New System.Drawing.Point(179, 201)
        Me.trkTrips.Maximum = 6
        Me.trkTrips.Minimum = 2
        Me.trkTrips.Name = "trkTrips"
        Me.trkTrips.Size = New System.Drawing.Size(464, 55)
        Me.trkTrips.TabIndex = 94
        Me.trkTrips.Text = "Trips"
        Me.trkTrips.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.trkTrips.Value = 4
        '
        'btnAddChar
        '
        Me.btnAddChar.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btnAddChar.Location = New System.Drawing.Point(523, 49)
        Me.btnAddChar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAddChar.Name = "btnAddChar"
        Me.btnAddChar.Size = New System.Drawing.Size(156, 56)
        Me.btnAddChar.TabIndex = 92
        Me.btnAddChar.Text = "Add Character"
        Me.btnAddChar.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btnAddChar.UseSelectable = True
        '
        'CalcBaseFacility
        '
        Me.CalcBaseFacility.BackColor = System.Drawing.Color.Transparent
        Me.CalcBaseFacility.ForeColor = System.Drawing.Color.Transparent
        Me.CalcBaseFacility.Location = New System.Drawing.Point(59, 285)
        Me.CalcBaseFacility.Margin = New System.Windows.Forms.Padding(5)
        Me.CalcBaseFacility.Name = "CalcBaseFacility"
        Me.CalcBaseFacility.Size = New System.Drawing.Size(780, 58)
        Me.CalcBaseFacility.TabIndex = 0
        '
        'MetroLabel4
        '
        Me.MetroLabel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MetroLabel4.Location = New System.Drawing.Point(22, 358)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(815, 90)
        Me.MetroLabel4.TabIndex = 97
        Me.MetroLabel4.Text = "Find new profitable blueprints or find out which" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "of your existing blueprints is " &
    "most profitable"
        Me.MetroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MetroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel4.WrapToLine = True
        '
        'MetroLabel3
        '
        Me.MetroLabel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MetroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel3.Location = New System.Drawing.Point(166, 136)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(491, 134)
        Me.MetroLabel3.TabIndex = 96
        Me.MetroLabel3.Text = "Select more trips for more profit or less trips for less travel time"
        Me.MetroLabel3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.MetroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel3.WrapToLine = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.Location = New System.Drawing.Point(131, 8)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(566, 113)
        Me.MetroLabel1.TabIndex = 98
        Me.MetroLabel1.Text = "Select or add a character"
        Me.MetroLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.MetroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel1.WrapToLine = True
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.lstManufacturing)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1612, 782)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        '
        'lstManufacturing
        '
        Me.lstManufacturing.AllowColumnReorder = True
        Me.lstManufacturing.AllowSorting = True
        Me.lstManufacturing.BackColor = System.Drawing.Color.Gray
        Me.lstManufacturing.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.lstManufacturing.ContextMenuStrip = Me.ListOptionsMenu
        Me.lstManufacturing.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lstManufacturing.FullRowSelect = True
        Me.lstManufacturing.GridLines = True
        Me.lstManufacturing.HideSelection = False
        Me.lstManufacturing.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2})
        Me.lstManufacturing.Location = New System.Drawing.Point(18, 82)
        Me.lstManufacturing.Margin = New System.Windows.Forms.Padding(4)
        Me.lstManufacturing.Name = "lstManufacturing"
        Me.lstManufacturing.OwnerDraw = True
        Me.lstManufacturing.Size = New System.Drawing.Size(1581, 681)
        Me.lstManufacturing.Sorting = System.Windows.Forms.SortOrder.Descending
        Me.lstManufacturing.TabIndex = 94
        Me.lstManufacturing.UseCompatibleStateImageBehavior = False
        Me.lstManufacturing.UseSelectable = True
        Me.lstManufacturing.View = System.Windows.Forms.View.Details
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.TabPage3.Controls.Add(Me.Panel1)
        Me.TabPage3.Controls.Add(Me.Label1)
        Me.TabPage3.Controls.Add(Me.btnResetAll)
        Me.TabPage3.Controls.Add(Me.btnManageChar)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(1612, 782)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "TabPage3"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.chkDisableTracking)
        Me.Panel1.Controls.Add(Me.LabelVersion)
        Me.Panel1.Controls.Add(Me.ReportBugIcon)
        Me.Panel1.Controls.Add(Me.MetroLabel2)
        Me.Panel1.Controls.Add(Me.VisitWebIcon)
        Me.Panel1.Controls.Add(Me.btnDonate)
        Me.Panel1.Controls.Add(Me.PateronIcon)
        Me.Panel1.Controls.Add(Me.btnVisitweb)
        Me.Panel1.Controls.Add(Me.btnReportbug)
        Me.Panel1.Location = New System.Drawing.Point(55, 38)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(647, 651)
        Me.Panel1.TabIndex = 107
        '
        'chkDisableTracking
        '
        Me.chkDisableTracking.AutoSize = True
        Me.chkDisableTracking.Location = New System.Drawing.Point(17, 452)
        Me.chkDisableTracking.Margin = New System.Windows.Forms.Padding(4)
        Me.chkDisableTracking.Name = "chkDisableTracking"
        Me.chkDisableTracking.Size = New System.Drawing.Size(251, 20)
        Me.chkDisableTracking.TabIndex = 108
        Me.chkDisableTracking.Text = "Disable Anonomous Usage Tracking"
        Me.chkDisableTracking.UseVisualStyleBackColor = True
        '
        'LabelVersion
        '
        Me.LabelVersion.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.LabelVersion.Location = New System.Drawing.Point(14, 10)
        Me.LabelVersion.Name = "LabelVersion"
        Me.LabelVersion.Size = New System.Drawing.Size(181, 35)
        Me.LabelVersion.TabIndex = 103
        Me.LabelVersion.Text = "Version X.X.XXXXXX"
        Me.LabelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LabelVersion.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.LabelVersion.WrapToLine = True
        '
        'ReportBugIcon
        '
        Me.ReportBugIcon.ErrorImage = Nothing
        Me.ReportBugIcon.Image = CType(resources.GetObject("ReportBugIcon.Image"), System.Drawing.Image)
        Me.ReportBugIcon.Location = New System.Drawing.Point(17, 380)
        Me.ReportBugIcon.Name = "ReportBugIcon"
        Me.ReportBugIcon.Size = New System.Drawing.Size(57, 65)
        Me.ReportBugIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ReportBugIcon.TabIndex = 106
        Me.ReportBugIcon.TabStop = False
        '
        'MetroLabel2
        '
        Me.MetroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel2.Location = New System.Drawing.Point(14, 50)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(409, 174)
        Me.MetroLabel2.TabIndex = 102
        Me.MetroLabel2.Text = resources.GetString("MetroLabel2.Text")
        Me.MetroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel2.WrapToLine = True
        '
        'VisitWebIcon
        '
        Me.VisitWebIcon.ErrorImage = Nothing
        Me.VisitWebIcon.Image = CType(resources.GetObject("VisitWebIcon.Image"), System.Drawing.Image)
        Me.VisitWebIcon.Location = New System.Drawing.Point(17, 306)
        Me.VisitWebIcon.Name = "VisitWebIcon"
        Me.VisitWebIcon.Size = New System.Drawing.Size(57, 65)
        Me.VisitWebIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.VisitWebIcon.TabIndex = 105
        Me.VisitWebIcon.TabStop = False
        '
        'btnDonate
        '
        Me.btnDonate.Location = New System.Drawing.Point(81, 246)
        Me.btnDonate.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDonate.Name = "btnDonate"
        Me.btnDonate.Size = New System.Drawing.Size(266, 52)
        Me.btnDonate.TabIndex = 96
        Me.btnDonate.Text = "Donate to the original creator of EVEIPH"
        Me.btnDonate.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btnDonate.UseSelectable = True
        '
        'PateronIcon
        '
        Me.PateronIcon.ErrorImage = Nothing
        Me.PateronIcon.Image = CType(resources.GetObject("PateronIcon.Image"), System.Drawing.Image)
        Me.PateronIcon.Location = New System.Drawing.Point(17, 233)
        Me.PateronIcon.Name = "PateronIcon"
        Me.PateronIcon.Size = New System.Drawing.Size(57, 65)
        Me.PateronIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PateronIcon.TabIndex = 104
        Me.PateronIcon.TabStop = False
        '
        'btnVisitweb
        '
        Me.btnVisitweb.Location = New System.Drawing.Point(81, 306)
        Me.btnVisitweb.Margin = New System.Windows.Forms.Padding(4)
        Me.btnVisitweb.Name = "btnVisitweb"
        Me.btnVisitweb.Size = New System.Drawing.Size(266, 52)
        Me.btnVisitweb.TabIndex = 100
        Me.btnVisitweb.Text = "Visit EasyIPH.com for Tips and Tricks"
        Me.btnVisitweb.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btnVisitweb.UseSelectable = True
        '
        'btnReportbug
        '
        Me.btnReportbug.Location = New System.Drawing.Point(81, 380)
        Me.btnReportbug.Margin = New System.Windows.Forms.Padding(4)
        Me.btnReportbug.Name = "btnReportbug"
        Me.btnReportbug.Size = New System.Drawing.Size(266, 52)
        Me.btnReportbug.TabIndex = 101
        Me.btnReportbug.Text = "Report a Bug or Suggest a Feature"
        Me.btnReportbug.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btnReportbug.UseSelectable = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(133, 284)
        Me.Label1.Margin = New System.Windows.Forms.Padding(8, 0, 4, 0)
        Me.Label1.MaximumSize = New System.Drawing.Size(0, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 21)
        Me.Label1.TabIndex = 98
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnResetAll
        '
        Me.btnResetAll.BackColor = System.Drawing.Color.Red
        Me.btnResetAll.ForeColor = System.Drawing.Color.DarkRed
        Me.btnResetAll.Location = New System.Drawing.Point(1040, 418)
        Me.btnResetAll.Margin = New System.Windows.Forms.Padding(4)
        Me.btnResetAll.Name = "btnResetAll"
        Me.btnResetAll.Size = New System.Drawing.Size(120, 36)
        Me.btnResetAll.TabIndex = 24
        Me.btnResetAll.Text = "Reset All Data"
        Me.btnResetAll.UseSelectable = True
        '
        'btnManageChar
        '
        Me.btnManageChar.Location = New System.Drawing.Point(815, 418)
        Me.btnManageChar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnManageChar.Name = "btnManageChar"
        Me.btnManageChar.Size = New System.Drawing.Size(120, 36)
        Me.btnManageChar.TabIndex = 23
        Me.btnManageChar.Text = "Manage Characters"
        Me.btnManageChar.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btnManageChar.UseSelectable = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1661, 927)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.rbtnCalcBPOwned)
        Me.Controls.Add(Me.chkCalcCanBuild)
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "EasyIPH"
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.TransparencyKey = System.Drawing.Color.LightBlue
        Me.ListOptionsMenu.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ReportBugIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VisitWebIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PateronIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbSystems As System.Windows.Forms.GroupBox
    Friend WithEvents ttBP As System.Windows.Forms.ToolTip
    Friend WithEvents OpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ListOptionsMenu As MetroFramework.Controls.MetroContextMenu
    Friend WithEvents IgnoreBlueprintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ttUpdatePrices As System.Windows.Forms.ToolTip
    Friend WithEvents ttManufacturing As System.Windows.Forms.ToolTip
    Friend WithEvents ttDatacores As System.Windows.Forms.ToolTip
    Friend WithEvents ttReactions As System.Windows.Forms.ToolTip
    Friend WithEvents ttMining As System.Windows.Forms.ToolTip
    Friend WithEvents ttPI As System.Windows.Forms.ToolTip
    Friend WithEvents CalcImageList As System.Windows.Forms.ImageList
    Friend WithEvents AddToShoppingListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FavoriteBlueprintToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CalcBaseFacility As ManufacturingFacility
    Friend WithEvents btnDownloadPrices As MetroFramework.Controls.MetroButton
    Friend WithEvents btnCalcCalculate As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroProgressBar As MetroFramework.Controls.MetroProgressBar
    Friend WithEvents rbtnCalcAllBPs As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents rbtnCalcBPOwned As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents pnlStatus As MetroFramework.Controls.MetroLabel
    Friend WithEvents mnuChar As MetroFramework.Controls.MetroComboBox
    Friend WithEvents autoShopping As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents chkCalcCanBuild As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents lblCharacterData As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblRecommendation As MetroFramework.Controls.MetroLabel
    Friend WithEvents lstManufacturing As ManufacturingListView
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents btnAddChar As MetroFramework.Controls.MetroButton
    Friend WithEvents btnManageChar As MetroFramework.Controls.MetroButton
    Friend WithEvents btnResetAll As MetroFramework.Controls.MetroButton
    Friend WithEvents Label1 As Label
    Friend WithEvents LabelVersion As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnReportbug As MetroFramework.Controls.MetroButton
    Friend WithEvents btnVisitweb As MetroFramework.Controls.MetroButton
    Friend WithEvents btnDonate As MetroFramework.Controls.MetroButton
    Friend WithEvents PateronIcon As PictureBox
    Friend WithEvents VisitWebIcon As PictureBox
    Friend WithEvents ReportBugIcon As PictureBox
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents trkTrips As MetroFramework.Controls.MetroTrackBar
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents FrmShoppingList1 As frmShoppingList
    Friend WithEvents Panel1 As Panel
    Friend WithEvents chkDisableTracking As CheckBox
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
End Class
