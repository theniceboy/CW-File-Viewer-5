using System.Security.AccessControl;

namespace CW_File_Viewer_5
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.filev2 = new System.Windows.Forms.ListView();
            this.lfsum2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rightmenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.rbcut = new System.Windows.Forms.ToolStripMenuItem();
            this.rbcopy = new System.Windows.Forms.ToolStripMenuItem();
            this.rbpast = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.makesamefile = new System.Windows.Forms.ToolStripMenuItem();
            this.origfile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.rbtocollection = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.rbrename = new System.Windows.Forms.ToolStripMenuItem();
            this.rbinfo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.rbdel = new System.Windows.Forms.ToolStripMenuItem();
            this.wtsize = new DevComponents.Editors.IntegerInput();
            this.filepath = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.go = new DevComponents.DotNetBar.ButtonX();
            this.bhistory = new DevComponents.DotNetBar.ButtonX();
            this.todirf = new DevComponents.DotNetBar.ButtonX();
            this.todird = new DevComponents.DotNetBar.ButtonX();
            this.todire = new DevComponents.DotNetBar.ButtonX();
            this.refresh = new DevComponents.DotNetBar.ButtonX();
            this.viewfile = new DevComponents.DotNetBar.ButtonX();
            this.back = new DevComponents.DotNetBar.ButtonX();
            this.next = new DevComponents.DotNetBar.ButtonX();
            this.tabv = new DevComponents.DotNetBar.TabControl();
            this.tabControlPanel1 = new DevComponents.DotNetBar.TabControlPanel();
            this.filev1 = new System.Windows.Forms.ListView();
            this.lfsum1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tab1 = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel3 = new DevComponents.DotNetBar.TabControlPanel();
            this.filev3 = new System.Windows.Forms.ListView();
            this.lfsum3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList3 = new System.Windows.Forms.ImageList(this.components);
            this.tab3 = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel2 = new DevComponents.DotNetBar.TabControlPanel();
            this.tab2 = new DevComponents.DotNetBar.TabItem(this.components);
            this.ribbar = new DevComponents.DotNetBar.RibbonControl();
            this.ribbonPanel1 = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonBar6 = new DevComponents.DotNetBar.RibbonBar();
            this.Recovery = new DevComponents.DotNetBar.ButtonX();
            this.controlContainerItem32 = new DevComponents.DotNetBar.ControlContainerItem();
            this.ribbonBar3 = new DevComponents.DotNetBar.RibbonBar();
            this.fsbig = new DevComponents.DotNetBar.ButtonX();
            this.fssmall = new DevComponents.DotNetBar.ButtonX();
            this.controlContainerItem16 = new DevComponents.DotNetBar.ControlContainerItem();
            this.itemContainer8 = new DevComponents.DotNetBar.ItemContainer();
            this.controlContainerItem17 = new DevComponents.DotNetBar.ControlContainerItem();
            this.controlContainerItem18 = new DevComponents.DotNetBar.ControlContainerItem();
            this.ribbonBar2 = new DevComponents.DotNetBar.RibbonBar();
            this.cut = new DevComponents.DotNetBar.ButtonX();
            this.batch = new DevComponents.DotNetBar.ButtonX();
            this.copy = new DevComponents.DotNetBar.ButtonX();
            this.past = new DevComponents.DotNetBar.ButtonX();
            this.del = new DevComponents.DotNetBar.ButtonX();
            this.toolsbox = new DevComponents.DotNetBar.ButtonX();
            this.ordertags = new DevComponents.DotNetBar.ButtonX();
            this.choosetagsys = new DevComponents.DotNetBar.ButtonX();
            this.controlContainerItem8 = new DevComponents.DotNetBar.ControlContainerItem();
            this.controlContainerItem9 = new DevComponents.DotNetBar.ControlContainerItem();
            this.controlContainerItem10 = new DevComponents.DotNetBar.ControlContainerItem();
            this.controlContainerItem11 = new DevComponents.DotNetBar.ControlContainerItem();
            this.controlContainerItem12 = new DevComponents.DotNetBar.ControlContainerItem();
            this.controlContainerItem14 = new DevComponents.DotNetBar.ControlContainerItem();
            this.controlContainerItem31 = new DevComponents.DotNetBar.ControlContainerItem();
            this.controlContainerItem49 = new DevComponents.DotNetBar.ControlContainerItem();
            this.ribbonBar1 = new DevComponents.DotNetBar.RibbonBar();
            this.sortw1 = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.sortw2 = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.onlyfolder = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.openotherfile = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.useprev = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.goodsort = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.seevery = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.userogbin = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.ShowTXT = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.ShowNote = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.itemContainer2 = new DevComponents.DotNetBar.ItemContainer();
            this.controlContainerItem6 = new DevComponents.DotNetBar.ControlContainerItem();
            this.controlContainerItem27 = new DevComponents.DotNetBar.ControlContainerItem();
            this.itemContainer3 = new DevComponents.DotNetBar.ItemContainer();
            this.controlContainerItem28 = new DevComponents.DotNetBar.ControlContainerItem();
            this.controlContainerItem36 = new DevComponents.DotNetBar.ControlContainerItem();
            this.itemContainer4 = new DevComponents.DotNetBar.ItemContainer();
            this.controlContainerItem2 = new DevComponents.DotNetBar.ControlContainerItem();
            this.controlContainerItem37 = new DevComponents.DotNetBar.ControlContainerItem();
            this.itemContainer5 = new DevComponents.DotNetBar.ItemContainer();
            this.controlContainerItem39 = new DevComponents.DotNetBar.ControlContainerItem();
            this.controlContainerItem40 = new DevComponents.DotNetBar.ControlContainerItem();
            this.itemContainer6 = new DevComponents.DotNetBar.ItemContainer();
            this.controlContainerItem54 = new DevComponents.DotNetBar.ControlContainerItem();
            this.controlContainerItem55 = new DevComponents.DotNetBar.ControlContainerItem();
            this.ribbonPanel2 = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonBar11 = new DevComponents.DotNetBar.RibbonBar();
            this.textwork = new DevComponents.DotNetBar.ButtonX();
            this.controlContainerItem52 = new DevComponents.DotNetBar.ControlContainerItem();
            this.ribbonBar10 = new DevComponents.DotNetBar.RibbonBar();
            this.ordertaginfo = new DevComponents.DotNetBar.ButtonX();
            this.controlContainerItem51 = new DevComponents.DotNetBar.ControlContainerItem();
            this.ribbonBar9 = new DevComponents.DotNetBar.RibbonBar();
            this.embackup = new DevComponents.DotNetBar.ButtonX();
            this.controlContainerItem50 = new DevComponents.DotNetBar.ControlContainerItem();
            this.ribbonBar8 = new DevComponents.DotNetBar.RibbonBar();
            this.savestatenow = new DevComponents.DotNetBar.ButtonX();
            this.controlContainerItem48 = new DevComponents.DotNetBar.ControlContainerItem();
            this.ribbonBar7 = new DevComponents.DotNetBar.RibbonBar();
            this.cleantag = new DevComponents.DotNetBar.ButtonX();
            this.tagpageman = new DevComponents.DotNetBar.ButtonX();
            this.controlContainerItem41 = new DevComponents.DotNetBar.ControlContainerItem();
            this.controlContainerItem47 = new DevComponents.DotNetBar.ControlContainerItem();
            this.ribbonBar5 = new DevComponents.DotNetBar.RibbonBar();
            this.search = new DevComponents.DotNetBar.ButtonX();
            this.controlContainerItem7 = new DevComponents.DotNetBar.ControlContainerItem();
            this.ribbonBar4 = new DevComponents.DotNetBar.RibbonBar();
            this.usedic = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.add = new DevComponents.DotNetBar.ButtonX();
            this.itemContainer7 = new DevComponents.DotNetBar.ItemContainer();
            this.controlContainerItem23 = new DevComponents.DotNetBar.ControlContainerItem();
            this.controlContainerItem24 = new DevComponents.DotNetBar.ControlContainerItem();
            this.applicationButton1 = new DevComponents.DotNetBar.ApplicationButton();
            this.superTabControl1 = new DevComponents.DotNetBar.SuperTabControl();
            this.superTabControlPanel1 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.reflectionLabel2 = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.superTabItem1 = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanel2 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.textl1 = new DevComponents.DotNetBar.LabelX();
            this.autost = new DevComponents.Editors.IntegerInput();
            this.UseFormatForm = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.filehighlight = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.useast = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.recoveryatfirst = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.savenohint = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.常规 = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanel4 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.aboutcfv = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonTabItem1 = new DevComponents.DotNetBar.RibbonTabItem();
            this.ribbonTabItem2 = new DevComponents.DotNetBar.RibbonTabItem();
            this.panelfile = new System.Windows.Forms.Panel();
            this.repeatplay = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.playbutton = new DevComponents.DotNetBar.ButtonX();
            this.volumeslider = new DevComponents.DotNetBar.Controls.Slider();
            this.looksametxt = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.looklrc = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.coverl1 = new DevComponents.DotNetBar.LabelX();
            this.label4 = new System.Windows.Forms.Label();
            this.lwsum = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fbroser = new System.Windows.Forms.FolderBrowserDialog();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.styleManager = new DevComponents.DotNetBar.StyleManager(this.components);
            this.nowdoti = new System.Windows.Forms.Timer(this.components);
            this.fullscr = new DevComponents.DotNetBar.ButtonX();
            this.controlContainerItem1 = new DevComponents.DotNetBar.ControlContainerItem();
            this.controlContainerItem30 = new DevComponents.DotNetBar.ControlContainerItem();
            this.controlContainerItem29 = new DevComponents.DotNetBar.ControlContainerItem();
            this.itemContainer12 = new DevComponents.DotNetBar.ItemContainer();
            this.itemContainer13 = new DevComponents.DotNetBar.ItemContainer();
            this.microChartItem1 = new DevComponents.DotNetBar.MicroChartItem();
            this.metroStatusBar1 = new DevComponents.DotNetBar.Metro.MetroStatusBar();
            this.tschooser = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.txtstate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nowdo = new System.Windows.Forms.Label();
            this.nowprog = new DevComponents.DotNetBar.ProgressBarItem();
            this.controlContainerItem53 = new DevComponents.DotNetBar.ControlContainerItem();
            this.controlContainerItem13 = new DevComponents.DotNetBar.ControlContainerItem();
            this.controlContainerItem19 = new DevComponents.DotNetBar.ControlContainerItem();
            this.controlContainerItem34 = new DevComponents.DotNetBar.ControlContainerItem();
            this.controlContainerItem35 = new DevComponents.DotNetBar.ControlContainerItem();
            this.controlContainerItem33 = new DevComponents.DotNetBar.ControlContainerItem();
            this.godestop = new DevComponents.DotNetBar.ButtonX();
            this.panelplayer = new System.Windows.Forms.Panel();
            this.volumevalue = new DevComponents.DotNetBar.LabelX();
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.newfile = new DevComponents.DotNetBar.ButtonX();
            this.savefile = new DevComponents.DotNetBar.ButtonItem();
            this.safeclose = new DevComponents.DotNetBar.ButtonX();
            this.controlContainerItem3 = new DevComponents.DotNetBar.ControlContainerItem();
            this.controlContainerItem21 = new DevComponents.DotNetBar.ControlContainerItem();
            this.controlContainerItem20 = new DevComponents.DotNetBar.ControlContainerItem();
            this.itemContainer1 = new DevComponents.DotNetBar.ItemContainer();
            this.controlContainerItem22 = new DevComponents.DotNetBar.ControlContainerItem();
            this.dockContainerItem1 = new DevComponents.DotNetBar.DockContainerItem();
            this.givetfirst = new System.Windows.Forms.Timer(this.components);
            this.controlContainerItem26 = new DevComponents.DotNetBar.ControlContainerItem();
            this.controlContainerItem25 = new DevComponents.DotNetBar.ControlContainerItem();
            this.btip = new DevComponents.DotNetBar.BalloonTip();
            this.makecopy = new DevComponents.DotNetBar.ButtonX();
            this.rename = new DevComponents.DotNetBar.ButtonX();
            this.plus = new DevComponents.DotNetBar.ButtonX();
            this.plusdate = new DevComponents.DotNetBar.ButtonX();
            this.filetag = new DevComponents.DotNetBar.ButtonX();
            this.lastdir = new DevComponents.DotNetBar.ButtonX();
            this.rogbin = new DevComponents.DotNetBar.ButtonX();
            this.dockContainerItem2 = new DevComponents.DotNetBar.DockContainerItem();
            this.dockContainerItem4 = new DevComponents.DotNetBar.DockContainerItem();
            this.line1 = new DevComponents.DotNetBar.Controls.Line();
            this.line4 = new DevComponents.DotNetBar.Controls.Line();
            this.line2 = new DevComponents.DotNetBar.Controls.Line();
            this.paneltxt = new System.Windows.Forms.Panel();
            this.line7 = new DevComponents.DotNetBar.Controls.Line();
            this.line8 = new DevComponents.DotNetBar.Controls.Line();
            this.line5 = new DevComponents.DotNetBar.Controls.Line();
            this.line6 = new DevComponents.DotNetBar.Controls.Line();
            this.imgv = new System.Windows.Forms.PictureBox();
            this.lrcv = new System.Windows.Forms.RichTextBox();
            this.infilemenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addate = new System.Windows.Forms.ToolStripMenuItem();
            this.filenote = new DevComponents.DotNetBar.ButtonX();
            this.line3 = new DevComponents.DotNetBar.Controls.Line();
            this.filename = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.filecontrolbar = new System.Windows.Forms.Panel();
            this.filevname = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.todirc = new DevComponents.DotNetBar.ButtonX();
            this.cancelsearch = new DevComponents.DotNetBar.ButtonX();
            this.searchfilev = new DevComponents.DotNetBar.ButtonX();
            this.controlContainerItem42 = new DevComponents.DotNetBar.ControlContainerItem();
            this.PGManager = new DevComponents.DotNetBar.DotNetBarManager(this.components);
            this.dockSite4 = new DevComponents.DotNetBar.DockSite();
            this.dockSite9 = new DevComponents.DotNetBar.DockSite();
            this.bar1 = new DevComponents.DotNetBar.Bar();
            this.panelDockContainer2 = new DevComponents.DotNetBar.PanelDockContainer();
            this.dockContainerItem5 = new DevComponents.DotNetBar.DockContainerItem();
            this.bar2 = new DevComponents.DotNetBar.Bar();
            this.panelDockContainer1 = new DevComponents.DotNetBar.PanelDockContainer();
            this.dockContainerItem3 = new DevComponents.DotNetBar.DockContainerItem();
            this.dockSite1 = new DevComponents.DotNetBar.DockSite();
            this.dockSite2 = new DevComponents.DotNetBar.DockSite();
            this.dockSite8 = new DevComponents.DotNetBar.DockSite();
            this.dockSite5 = new DevComponents.DotNetBar.DockSite();
            this.dockSite6 = new DevComponents.DotNetBar.DockSite();
            this.dockSite7 = new DevComponents.DotNetBar.DockSite();
            this.dockSite3 = new DevComponents.DotNetBar.DockSite();
            this.fpcrumb = new DevComponents.DotNetBar.CrumbBar();
            this.controlContainerItem15 = new DevComponents.DotNetBar.ControlContainerItem();
            this.controlContainerItem4 = new DevComponents.DotNetBar.ControlContainerItem();
            this.controlContainerItem5 = new DevComponents.DotNetBar.ControlContainerItem();
            this.collectionbar = new DevComponents.DotNetBar.Bar();
            this.collectionrightmenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.delcollection = new System.Windows.Forms.ToolStripMenuItem();
            this.tocollection = new DevComponents.DotNetBar.ButtonX();
            this.rangeValidator1 = new DevComponents.DotNetBar.Validator.RangeValidator();
            this.requiredFieldValidator1 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Your error message here.");
            this.requiredFieldValidator2 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Your error message here.");
            this.requiredFieldValidator3 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Your error message here.");
            this.controlContainerItem44 = new DevComponents.DotNetBar.ControlContainerItem();
            this.controlContainerItem46 = new DevComponents.DotNetBar.ControlContainerItem();
            this.controlContainerItem45 = new DevComponents.DotNetBar.ControlContainerItem();
            this.controlContainerItem43 = new DevComponents.DotNetBar.ControlContainerItem();
            this.controlContainerItem38 = new DevComponents.DotNetBar.ControlContainerItem();
            this.filect = new System.Windows.Forms.Timer(this.components);
            this.fcpst = new System.Windows.Forms.Timer(this.components);
            this.closingt = new System.Windows.Forms.Timer(this.components);
            this.autosave = new System.Windows.Forms.Timer(this.components);
            this.backt = new System.Windows.Forms.Timer(this.components);
            this.lrcvfocuser = new System.Windows.Forms.Timer(this.components);
            this.查找ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.文本操作ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rightmenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wtsize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabv)).BeginInit();
            this.tabv.SuspendLayout();
            this.tabControlPanel1.SuspendLayout();
            this.tabControlPanel3.SuspendLayout();
            this.tabControlPanel2.SuspendLayout();
            this.ribbar.SuspendLayout();
            this.ribbonPanel1.SuspendLayout();
            this.ribbonBar6.SuspendLayout();
            this.ribbonBar3.SuspendLayout();
            this.ribbonBar2.SuspendLayout();
            this.ribbonBar1.SuspendLayout();
            this.ribbonPanel2.SuspendLayout();
            this.ribbonBar11.SuspendLayout();
            this.ribbonBar10.SuspendLayout();
            this.ribbonBar9.SuspendLayout();
            this.ribbonBar8.SuspendLayout();
            this.ribbonBar7.SuspendLayout();
            this.ribbonBar5.SuspendLayout();
            this.ribbonBar4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.superTabControl1)).BeginInit();
            this.superTabControl1.SuspendLayout();
            this.superTabControlPanel1.SuspendLayout();
            this.superTabControlPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.autost)).BeginInit();
            this.panelfile.SuspendLayout();
            this.metroStatusBar1.SuspendLayout();
            this.panelplayer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.paneltxt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgv)).BeginInit();
            this.infilemenu.SuspendLayout();
            this.filecontrolbar.SuspendLayout();
            this.dockSite9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            this.bar1.SuspendLayout();
            this.panelDockContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bar2)).BeginInit();
            this.bar2.SuspendLayout();
            this.panelDockContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.collectionbar)).BeginInit();
            this.collectionrightmenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // filev2
            // 
            this.filev2.BackColor = System.Drawing.Color.White;
            this.filev2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.filev2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lfsum2});
            this.filev2.ContextMenuStrip = this.rightmenu;
            this.filev2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filev2.Font = new System.Drawing.Font("SimSun", 10F);
            this.filev2.ForeColor = System.Drawing.Color.Black;
            this.filev2.FullRowSelect = true;
            this.filev2.GridLines = true;
            this.filev2.Location = new System.Drawing.Point(1, 1);
            this.filev2.Name = "filev2";
            this.filev2.Size = new System.Drawing.Size(411, 550);
            this.filev2.SmallImageList = this.imageList2;
            this.filev2.TabIndex = 0;
            this.filev2.UseCompatibleStateImageBehavior = false;
            this.filev2.View = System.Windows.Forms.View.Details;
            this.filev2.ItemMouseHover += new System.Windows.Forms.ListViewItemMouseHoverEventHandler(this.filev2_ItemMouseHover);
            this.filev2.SelectedIndexChanged += new System.EventHandler(this.filev2_SelectedIndexChanged);
            this.filev2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.filev2_KeyDown);
            this.filev2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.filev2_MouseDown);
            // 
            // lfsum2
            // 
            this.lfsum2.Text = "未选择路径";
            this.lfsum2.Width = 1300;
            // 
            // rightmenu
            // 
            this.rightmenu.BackColor = System.Drawing.Color.White;
            this.rightmenu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightmenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.rightmenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rbcut,
            this.rbcopy,
            this.rbpast,
            this.toolStripSeparator3,
            this.makesamefile,
            this.origfile,
            this.toolStripSeparator2,
            this.rbtocollection,
            this.toolStripMenuItem2,
            this.rbrename,
            this.rbinfo,
            this.toolStripSeparator1,
            this.rbdel});
            this.rightmenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.rightmenu.Name = "rightmenu";
            this.rightmenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.rightmenu.Size = new System.Drawing.Size(149, 262);
            // 
            // rbcut
            // 
            this.rbcut.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rbcut.Name = "rbcut";
            this.rbcut.Size = new System.Drawing.Size(148, 26);
            this.rbcut.Text = "剪切";
            this.rbcut.Click += new System.EventHandler(this.rbcut_Click);
            // 
            // rbcopy
            // 
            this.rbcopy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rbcopy.Name = "rbcopy";
            this.rbcopy.Size = new System.Drawing.Size(148, 26);
            this.rbcopy.Text = "复制";
            this.rbcopy.Click += new System.EventHandler(this.rbcopy_Click);
            // 
            // rbpast
            // 
            this.rbpast.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rbpast.Name = "rbpast";
            this.rbpast.Size = new System.Drawing.Size(148, 26);
            this.rbpast.Text = "粘贴";
            this.rbpast.Click += new System.EventHandler(this.rbpast_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(145, 6);
            // 
            // makesamefile
            // 
            this.makesamefile.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.makesamefile.Name = "makesamefile";
            this.makesamefile.Size = new System.Drawing.Size(148, 26);
            this.makesamefile.Text = "制作副本";
            this.makesamefile.Click += new System.EventHandler(this.makesamefile_Click);
            // 
            // origfile
            // 
            this.origfile.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.origfile.Image = global::CW_File_Viewer_5.Properties.Resources.see;
            this.origfile.Name = "origfile";
            this.origfile.Size = new System.Drawing.Size(148, 26);
            this.origfile.Text = "原文件";
            this.origfile.Click += new System.EventHandler(this.origfile_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(145, 6);
            // 
            // rbtocollection
            // 
            this.rbtocollection.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rbtocollection.Image = global::CW_File_Viewer_5.Properties.Resources.tocollection;
            this.rbtocollection.Name = "rbtocollection";
            this.rbtocollection.Size = new System.Drawing.Size(148, 26);
            this.rbtocollection.Text = "收藏";
            this.rbtocollection.Click += new System.EventHandler(this.rbtocollection_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(145, 6);
            // 
            // rbrename
            // 
            this.rbrename.Name = "rbrename";
            this.rbrename.Size = new System.Drawing.Size(148, 26);
            this.rbrename.Text = "重命名";
            this.rbrename.Click += new System.EventHandler(this.rbrename_Click);
            // 
            // rbinfo
            // 
            this.rbinfo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rbinfo.Image = global::CW_File_Viewer_5.Properties.Resources.info;
            this.rbinfo.Name = "rbinfo";
            this.rbinfo.Size = new System.Drawing.Size(148, 26);
            this.rbinfo.Text = "属性";
            this.rbinfo.Click += new System.EventHandler(this.rbinfo_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(145, 6);
            // 
            // rbdel
            // 
            this.rbdel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rbdel.Image = global::CW_File_Viewer_5.Properties.Resources.delete;
            this.rbdel.Name = "rbdel";
            this.rbdel.Size = new System.Drawing.Size(148, 26);
            this.rbdel.Text = "删除";
            this.rbdel.Click += new System.EventHandler(this.rbdel_Click);
            // 
            // wtsize
            // 
            this.wtsize.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.wtsize.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.wtsize.BackgroundStyle.Class = "DateTimeInputBackground";
            this.wtsize.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.wtsize.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.wtsize.ForeColor = System.Drawing.Color.Black;
            this.wtsize.Location = new System.Drawing.Point(4, 14);
            this.wtsize.MaxValue = 48;
            this.wtsize.MinValue = 1;
            this.wtsize.Name = "wtsize";
            this.wtsize.ShowUpDown = true;
            this.wtsize.Size = new System.Drawing.Size(41, 26);
            this.wtsize.TabIndex = 132;
            this.wtsize.Value = 12;
            this.wtsize.ValueChanged += new System.EventHandler(this.wtsize_ValueChanged);
            // 
            // filepath
            // 
            this.filepath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filepath.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.filepath.Border.Class = "TextBoxBorder";
            this.filepath.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.filepath.DisabledBackColor = System.Drawing.Color.White;
            this.filepath.Font = new System.Drawing.Font("YouYuan", 8.1F);
            this.filepath.ForeColor = System.Drawing.Color.Black;
            this.filepath.Location = new System.Drawing.Point(246, 32);
            this.filepath.MaxLength = 2147483647;
            this.filepath.Name = "filepath";
            this.filepath.Size = new System.Drawing.Size(1032, 22);
            this.filepath.TabIndex = 133;
            this.filepath.WatermarkColor = System.Drawing.SystemColors.ControlDark;
            this.filepath.WatermarkText = "当前路径";
            this.filepath.KeyDown += new System.Windows.Forms.KeyEventHandler(this.filepath_KeyDown);
            this.filepath.MouseLeave += new System.EventHandler(this.filepath_MouseLeave);
            // 
            // go
            // 
            this.go.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.go.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.go.BackColor = System.Drawing.Color.White;
            this.go.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.go.FocusCuesEnabled = false;
            this.go.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.go.Location = new System.Drawing.Point(1314, 32);
            this.go.Name = "go";
            this.go.Size = new System.Drawing.Size(24, 22);
            this.go.Symbol = "";
            this.go.SymbolColor = System.Drawing.SystemColors.ControlText;
            this.go.SymbolSize = 10F;
            this.go.TabIndex = 130;
            this.go.Click += new System.EventHandler(this.go_Click);
            // 
            // bhistory
            // 
            this.bhistory.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bhistory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bhistory.BackColor = System.Drawing.Color.Transparent;
            this.bhistory.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            this.bhistory.FocusCuesEnabled = false;
            this.bhistory.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.bhistory.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bhistory.Location = new System.Drawing.Point(1117, 5);
            this.bhistory.Name = "bhistory";
            this.bhistory.Size = new System.Drawing.Size(68, 23);
            this.bhistory.Symbol = "";
            this.bhistory.SymbolSize = 9F;
            this.bhistory.TabIndex = 129;
            this.bhistory.Text = "记录";
            this.bhistory.Click += new System.EventHandler(this.bhistory_Click);
            // 
            // todirf
            // 
            this.todirf.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.todirf.BackColor = System.Drawing.Color.Transparent;
            this.todirf.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.todirf.FocusCuesEnabled = false;
            this.todirf.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold);
            this.todirf.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.todirf.Location = new System.Drawing.Point(251, 2);
            this.todirf.Name = "todirf";
            this.todirf.Size = new System.Drawing.Size(25, 25);
            this.todirf.SymbolColor = System.Drawing.Color.White;
            this.todirf.TabIndex = 128;
            this.todirf.Text = "F";
            this.todirf.Click += new System.EventHandler(this.todirf_Click);
            // 
            // todird
            // 
            this.todird.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.todird.BackColor = System.Drawing.Color.Transparent;
            this.todird.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.todird.FocusCuesEnabled = false;
            this.todird.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold);
            this.todird.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.todird.Location = new System.Drawing.Point(189, 2);
            this.todird.Name = "todird";
            this.todird.Size = new System.Drawing.Size(25, 25);
            this.todird.SymbolColor = System.Drawing.Color.White;
            this.todird.TabIndex = 127;
            this.todird.Text = "D";
            this.todird.Click += new System.EventHandler(this.todird_Click);
            // 
            // todire
            // 
            this.todire.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.todire.BackColor = System.Drawing.Color.Transparent;
            this.todire.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.todire.FocusCuesEnabled = false;
            this.todire.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold);
            this.todire.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.todire.Location = new System.Drawing.Point(220, 2);
            this.todire.Name = "todire";
            this.todire.Size = new System.Drawing.Size(25, 25);
            this.todire.SymbolColor = System.Drawing.Color.White;
            this.todire.TabIndex = 126;
            this.todire.Text = "E";
            this.todire.Click += new System.EventHandler(this.todire_Click);
            // 
            // refresh
            // 
            this.refresh.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.refresh.BackColor = System.Drawing.Color.Transparent;
            this.btip.SetBalloonCaption(this.refresh, "提示");
            this.btip.SetBalloonText(this.refresh, "刷新");
            this.refresh.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            this.refresh.FocusCuesEnabled = false;
            this.refresh.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold);
            this.refresh.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.refresh.Location = new System.Drawing.Point(96, 2);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(25, 25);
            this.refresh.Symbol = "";
            this.refresh.SymbolColor = System.Drawing.Color.White;
            this.refresh.SymbolSize = 9F;
            this.refresh.TabIndex = 109;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // viewfile
            // 
            this.viewfile.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.viewfile.BackColor = System.Drawing.Color.Transparent;
            this.viewfile.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            this.viewfile.FocusCuesEnabled = false;
            this.viewfile.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.viewfile.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.viewfile.Location = new System.Drawing.Point(38, 5);
            this.viewfile.Margin = new System.Windows.Forms.Padding(4);
            this.viewfile.Name = "viewfile";
            this.viewfile.Size = new System.Drawing.Size(68, 23);
            this.viewfile.Symbol = "";
            this.viewfile.SymbolSize = 9F;
            this.viewfile.TabIndex = 101;
            this.viewfile.Text = "浏览";
            this.viewfile.Click += new System.EventHandler(this.viewfile_Click);
            // 
            // back
            // 
            this.back.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.back.BackColor = System.Drawing.Color.Transparent;
            this.back.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            this.back.Enabled = false;
            this.back.FocusCuesEnabled = false;
            this.back.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.back.Location = new System.Drawing.Point(3, 2);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(25, 25);
            this.back.Symbol = "";
            this.back.SymbolColor = System.Drawing.Color.White;
            this.back.SymbolSize = 10F;
            this.back.TabIndex = 131;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // next
            // 
            this.next.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.next.BackColor = System.Drawing.Color.Transparent;
            this.next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.next.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            this.next.Enabled = false;
            this.next.FocusCuesEnabled = false;
            this.next.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.next.Location = new System.Drawing.Point(34, 2);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(25, 25);
            this.next.SplitButton = true;
            this.next.Symbol = "";
            this.next.SymbolColor = System.Drawing.Color.White;
            this.next.SymbolSize = 10F;
            this.next.TabIndex = 102;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // tabv
            // 
            this.tabv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabv.CanReorderTabs = true;
            this.tabv.CloseButtonOnTabsAlwaysDisplayed = false;
            this.tabv.Controls.Add(this.tabControlPanel1);
            this.tabv.Controls.Add(this.tabControlPanel3);
            this.tabv.Controls.Add(this.tabControlPanel2);
            this.tabv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabv.FixedTabSize = new System.Drawing.Size(123, 0);
            this.tabv.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.tabv.ForeColor = System.Drawing.Color.Black;
            this.tabv.Location = new System.Drawing.Point(0, 0);
            this.tabv.Name = "tabv";
            this.tabv.SelectedTabFont = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold);
            this.tabv.SelectedTabIndex = 0;
            this.tabv.Size = new System.Drawing.Size(413, 582);
            this.tabv.Style = DevComponents.DotNetBar.eTabStripStyle.Metro;
            this.tabv.TabIndex = 136;
            this.tabv.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            this.tabv.Tabs.Add(this.tab1);
            this.tabv.Tabs.Add(this.tab2);
            this.tabv.Tabs.Add(this.tab3);
            // 
            // tabControlPanel1
            // 
            this.tabControlPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.tabControlPanel1.Controls.Add(this.filev1);
            this.tabControlPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.tabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel1.Location = new System.Drawing.Point(0, 30);
            this.tabControlPanel1.Name = "tabControlPanel1";
            this.tabControlPanel1.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel1.Size = new System.Drawing.Size(413, 552);
            this.tabControlPanel1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.tabControlPanel1.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel1.Style.GradientAngle = 90;
            this.tabControlPanel1.TabIndex = 1;
            this.tabControlPanel1.TabItem = this.tab1;
            // 
            // filev1
            // 
            this.filev1.BackColor = System.Drawing.Color.White;
            this.filev1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.filev1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lfsum1});
            this.filev1.ContextMenuStrip = this.rightmenu;
            this.filev1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filev1.Font = new System.Drawing.Font("SimSun", 10F);
            this.filev1.ForeColor = System.Drawing.Color.Black;
            this.filev1.FullRowSelect = true;
            this.filev1.GridLines = true;
            this.filev1.Location = new System.Drawing.Point(1, 1);
            this.filev1.Name = "filev1";
            this.filev1.Size = new System.Drawing.Size(411, 550);
            this.filev1.SmallImageList = this.imageList1;
            this.filev1.TabIndex = 0;
            this.filev1.UseCompatibleStateImageBehavior = false;
            this.filev1.View = System.Windows.Forms.View.Details;
            this.filev1.ItemMouseHover += new System.Windows.Forms.ListViewItemMouseHoverEventHandler(this.filev1_ItemMouseHover);
            this.filev1.SelectedIndexChanged += new System.EventHandler(this.filev1_SelectedIndexChanged);
            this.filev1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.filev1_KeyDown);
            this.filev1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.filev1_MouseDown);
            // 
            // lfsum1
            // 
            this.lfsum1.Text = "未选择路径";
            this.lfsum1.Width = 1300;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // tab1
            // 
            this.tab1.AttachedControl = this.tabControlPanel1;
            this.tab1.Name = "tab1";
            this.tab1.Text = "未选择路径";
            this.tab1.Click += new System.EventHandler(this.tab1_Click);
            // 
            // tabControlPanel3
            // 
            this.tabControlPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.tabControlPanel3.Controls.Add(this.filev3);
            this.tabControlPanel3.DisabledBackColor = System.Drawing.Color.Empty;
            this.tabControlPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel3.Location = new System.Drawing.Point(0, 30);
            this.tabControlPanel3.Name = "tabControlPanel3";
            this.tabControlPanel3.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel3.Size = new System.Drawing.Size(413, 552);
            this.tabControlPanel3.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabControlPanel3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel3.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.tabControlPanel3.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel3.Style.GradientAngle = 90;
            this.tabControlPanel3.TabIndex = 3;
            this.tabControlPanel3.TabItem = this.tab3;
            // 
            // filev3
            // 
            this.filev3.BackColor = System.Drawing.Color.White;
            this.filev3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.filev3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lfsum3});
            this.filev3.ContextMenuStrip = this.rightmenu;
            this.filev3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filev3.Font = new System.Drawing.Font("SimSun", 10F);
            this.filev3.ForeColor = System.Drawing.Color.Black;
            this.filev3.FullRowSelect = true;
            this.filev3.GridLines = true;
            this.filev3.Location = new System.Drawing.Point(1, 1);
            this.filev3.Name = "filev3";
            this.filev3.Size = new System.Drawing.Size(411, 550);
            this.filev3.SmallImageList = this.imageList3;
            this.filev3.TabIndex = 0;
            this.filev3.UseCompatibleStateImageBehavior = false;
            this.filev3.View = System.Windows.Forms.View.Details;
            this.filev3.ItemMouseHover += new System.Windows.Forms.ListViewItemMouseHoverEventHandler(this.filev3_ItemMouseHover);
            this.filev3.SelectedIndexChanged += new System.EventHandler(this.filev3_SelectedIndexChanged);
            this.filev3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.filev3_KeyDown);
            this.filev3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.filev3_MouseDown);
            // 
            // lfsum3
            // 
            this.lfsum3.Text = "未选择路径";
            this.lfsum3.Width = 1300;
            // 
            // imageList3
            // 
            this.imageList3.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList3.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList3.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // tab3
            // 
            this.tab3.AttachedControl = this.tabControlPanel3;
            this.tab3.Name = "tab3";
            this.tab3.Text = "未选择路径";
            this.tab3.Click += new System.EventHandler(this.tab3_Click);
            // 
            // tabControlPanel2
            // 
            this.tabControlPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.tabControlPanel2.Controls.Add(this.filev2);
            this.tabControlPanel2.DisabledBackColor = System.Drawing.Color.Empty;
            this.tabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel2.Location = new System.Drawing.Point(0, 30);
            this.tabControlPanel2.Name = "tabControlPanel2";
            this.tabControlPanel2.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel2.Size = new System.Drawing.Size(413, 552);
            this.tabControlPanel2.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabControlPanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel2.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.tabControlPanel2.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel2.Style.GradientAngle = 90;
            this.tabControlPanel2.TabIndex = 2;
            this.tabControlPanel2.TabItem = this.tab2;
            // 
            // tab2
            // 
            this.tab2.AttachedControl = this.tabControlPanel2;
            this.tab2.Name = "tab2";
            this.tab2.Text = "未选择路径";
            this.tab2.Click += new System.EventHandler(this.tab2_Click);
            // 
            // ribbar
            // 
            this.ribbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.ribbar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbar.CanCustomize = false;
            this.ribbar.CaptionVisible = true;
            this.ribbar.CategorizeMode = DevComponents.DotNetBar.eCategorizeMode.Categories;
            this.ribbar.Controls.Add(this.ribbonPanel1);
            this.ribbar.Controls.Add(this.ribbonPanel2);
            this.ribbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.ribbar.EnableQatPlacement = false;
            this.ribbar.ForeColor = System.Drawing.Color.Black;
            this.ribbar.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.applicationButton1,
            this.ribbonTabItem1,
            this.ribbonTabItem2});
            this.ribbar.KeyTipsFont = new System.Drawing.Font("SimSun", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbar.Location = new System.Drawing.Point(5, 1);
            this.ribbar.Name = "ribbar";
            this.ribbar.RibbonStripFont = new System.Drawing.Font("Segoe UI", 8F);
            this.ribbar.Size = new System.Drawing.Size(1374, 130);
            this.ribbar.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.ribbar.SystemText.MaximizeRibbonText = "&Maximize the Ribbon";
            this.ribbar.SystemText.MinimizeRibbonText = "Mi&nimize the Ribbon";
            this.ribbar.SystemText.QatAddItemText = "&Add to Quick Access Toolbar";
            this.ribbar.SystemText.QatCustomizeMenuLabel = "<b>Customize Quick Access Toolbar</b>";
            this.ribbar.SystemText.QatCustomizeText = "&Customize Quick Access Toolbar...";
            this.ribbar.SystemText.QatDialogAddButton = "&Add >>";
            this.ribbar.SystemText.QatDialogCancelButton = "Cancel";
            this.ribbar.SystemText.QatDialogCaption = "Customize Quick Access Toolbar";
            this.ribbar.SystemText.QatDialogCategoriesLabel = "&Choose commands from:";
            this.ribbar.SystemText.QatDialogOkButton = "OK";
            this.ribbar.SystemText.QatDialogPlacementCheckbox = "&Place Quick Access Toolbar below the Ribbon";
            this.ribbar.SystemText.QatDialogRemoveButton = "&Remove";
            this.ribbar.SystemText.QatPlaceAboveRibbonText = "&Place Quick Access Toolbar above the Ribbon";
            this.ribbar.SystemText.QatPlaceBelowRibbonText = "&Place Quick Access Toolbar below the Ribbon";
            this.ribbar.SystemText.QatRemoveItemText = "&Remove from Quick Access Toolbar";
            this.ribbar.TabGroupHeight = 14;
            this.ribbar.TabIndex = 147;
            this.ribbar.Text = "ribbonControl1";
            this.ribbar.UseCustomizeDialog = false;
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.ribbonPanel1.Controls.Add(this.ribbonBar6);
            this.ribbonPanel1.Controls.Add(this.ribbonBar3);
            this.ribbonPanel1.Controls.Add(this.ribbonBar2);
            this.ribbonPanel1.Controls.Add(this.ribbonBar1);
            this.ribbonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbonPanel1.Location = new System.Drawing.Point(0, 57);
            this.ribbonPanel1.Name = "ribbonPanel1";
            this.ribbonPanel1.Padding = new System.Windows.Forms.Padding(3, 0, 3, 2);
            this.ribbonPanel1.Size = new System.Drawing.Size(1374, 73);
            // 
            // 
            // 
            this.ribbonPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonPanel1.TabIndex = 1;
            // 
            // ribbonBar6
            // 
            this.ribbonBar6.AutoOverflowEnabled = true;
            this.ribbonBar6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.ribbonBar6.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar6.ContainerControlProcessDialogKey = true;
            this.ribbonBar6.Controls.Add(this.Recovery);
            this.ribbonBar6.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar6.DragDropSupport = true;
            this.ribbonBar6.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.ribbonBar6.ForeColor = System.Drawing.Color.Black;
            this.ribbonBar6.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.controlContainerItem32});
            this.ribbonBar6.Location = new System.Drawing.Point(1226, 0);
            this.ribbonBar6.Name = "ribbonBar6";
            this.ribbonBar6.Size = new System.Drawing.Size(93, 71);
            this.ribbonBar6.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.ribbonBar6.TabIndex = 3;
            this.ribbonBar6.Text = "恢复";
            // 
            // 
            // 
            this.ribbonBar6.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar6.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // Recovery
            // 
            this.Recovery.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.Recovery.BackColor = System.Drawing.Color.Transparent;
            this.btip.SetBalloonCaption(this.Recovery, "提示");
            this.btip.SetBalloonText(this.Recovery, "恢复到上一次关闭时浏览到的目录。");
            this.Recovery.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            this.Recovery.FocusCuesEnabled = false;
            this.Recovery.Location = new System.Drawing.Point(4, 4);
            this.Recovery.Name = "Recovery";
            this.Recovery.Size = new System.Drawing.Size(83, 43);
            this.Recovery.Symbol = "";
            this.Recovery.TabIndex = 152;
            this.Recovery.Text = "恢复";
            this.Recovery.Click += new System.EventHandler(this.Recovery_Click);
            // 
            // controlContainerItem32
            // 
            this.controlContainerItem32.AllowItemResize = false;
            this.controlContainerItem32.Control = this.Recovery;
            this.controlContainerItem32.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem32.Name = "controlContainerItem32";
            // 
            // ribbonBar3
            // 
            this.ribbonBar3.AutoOverflowEnabled = true;
            this.ribbonBar3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.ribbonBar3.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar3.ContainerControlProcessDialogKey = true;
            this.ribbonBar3.Controls.Add(this.wtsize);
            this.ribbonBar3.Controls.Add(this.fsbig);
            this.ribbonBar3.Controls.Add(this.fssmall);
            this.ribbonBar3.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar3.DragDropSupport = true;
            this.ribbonBar3.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.ribbonBar3.ForeColor = System.Drawing.Color.Black;
            this.ribbonBar3.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.controlContainerItem16,
            this.itemContainer8});
            this.ribbonBar3.Location = new System.Drawing.Point(1145, 0);
            this.ribbonBar3.Name = "ribbonBar3";
            this.ribbonBar3.Size = new System.Drawing.Size(81, 71);
            this.ribbonBar3.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.ribbonBar3.TabIndex = 2;
            this.ribbonBar3.Text = "字体";
            // 
            // 
            // 
            this.ribbonBar3.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar3.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // fsbig
            // 
            this.fsbig.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.fsbig.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.fsbig.BackColor = System.Drawing.Color.Transparent;
            this.fsbig.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            this.fsbig.FocusCuesEnabled = false;
            this.fsbig.Font = new System.Drawing.Font("SimSun", 7F);
            this.fsbig.Location = new System.Drawing.Point(50, 3);
            this.fsbig.Name = "fsbig";
            this.fsbig.Size = new System.Drawing.Size(25, 23);
            this.fsbig.Symbol = "";
            this.fsbig.SymbolSize = 15F;
            this.fsbig.TabIndex = 142;
            this.fsbig.Click += new System.EventHandler(this.fsbig_Click);
            // 
            // fssmall
            // 
            this.fssmall.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.fssmall.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.fssmall.BackColor = System.Drawing.Color.Transparent;
            this.fssmall.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            this.fssmall.FocusCuesEnabled = false;
            this.fssmall.Font = new System.Drawing.Font("SimSun", 7F);
            this.fssmall.Location = new System.Drawing.Point(50, 29);
            this.fssmall.Name = "fssmall";
            this.fssmall.Size = new System.Drawing.Size(25, 23);
            this.fssmall.Symbol = "";
            this.fssmall.SymbolSize = 9F;
            this.fssmall.TabIndex = 143;
            this.fssmall.Click += new System.EventHandler(this.fssmall_Click);
            // 
            // controlContainerItem16
            // 
            this.controlContainerItem16.AllowItemResize = false;
            this.controlContainerItem16.Control = this.wtsize;
            this.controlContainerItem16.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem16.Name = "controlContainerItem16";
            // 
            // itemContainer8
            // 
            // 
            // 
            // 
            this.itemContainer8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer8.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemContainer8.Name = "itemContainer8";
            this.itemContainer8.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.controlContainerItem17,
            this.controlContainerItem18});
            // 
            // 
            // 
            this.itemContainer8.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // controlContainerItem17
            // 
            this.controlContainerItem17.AllowItemResize = false;
            this.controlContainerItem17.Control = this.fsbig;
            this.controlContainerItem17.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem17.Name = "controlContainerItem17";
            // 
            // controlContainerItem18
            // 
            this.controlContainerItem18.AllowItemResize = false;
            this.controlContainerItem18.Control = this.fssmall;
            this.controlContainerItem18.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem18.Name = "controlContainerItem18";
            // 
            // ribbonBar2
            // 
            this.ribbonBar2.AutoOverflowEnabled = true;
            this.ribbonBar2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.ribbonBar2.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar2.ContainerControlProcessDialogKey = true;
            this.ribbonBar2.Controls.Add(this.cut);
            this.ribbonBar2.Controls.Add(this.batch);
            this.ribbonBar2.Controls.Add(this.copy);
            this.ribbonBar2.Controls.Add(this.past);
            this.ribbonBar2.Controls.Add(this.del);
            this.ribbonBar2.Controls.Add(this.toolsbox);
            this.ribbonBar2.Controls.Add(this.ordertags);
            this.ribbonBar2.Controls.Add(this.choosetagsys);
            this.ribbonBar2.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar2.DragDropSupport = true;
            this.ribbonBar2.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.ribbonBar2.ForeColor = System.Drawing.Color.Black;
            this.ribbonBar2.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.controlContainerItem8,
            this.controlContainerItem9,
            this.controlContainerItem10,
            this.controlContainerItem11,
            this.controlContainerItem12,
            this.controlContainerItem14,
            this.controlContainerItem31,
            this.controlContainerItem49});
            this.ribbonBar2.Location = new System.Drawing.Point(454, 0);
            this.ribbonBar2.Name = "ribbonBar2";
            this.ribbonBar2.Size = new System.Drawing.Size(691, 71);
            this.ribbonBar2.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.ribbonBar2.TabIndex = 1;
            this.ribbonBar2.Text = "文件操作";
            // 
            // 
            // 
            this.ribbonBar2.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar2.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // cut
            // 
            this.cut.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cut.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cut.BackColor = System.Drawing.Color.Transparent;
            this.btip.SetBalloonCaption(this.cut, "提示");
            this.btip.SetBalloonText(this.cut, "分割当前文本");
            this.cut.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            this.cut.FocusCuesEnabled = false;
            this.cut.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cut.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cut.Location = new System.Drawing.Point(4, 4);
            this.cut.Name = "cut";
            this.cut.Size = new System.Drawing.Size(85, 43);
            this.cut.Symbol = "";
            this.cut.TabIndex = 104;
            this.cut.Text = "分割";
            this.cut.Click += new System.EventHandler(this.cut_Click);
            // 
            // batch
            // 
            this.batch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.batch.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.batch.BackColor = System.Drawing.Color.Transparent;
            this.btip.SetBalloonCaption(this.batch, "提示");
            this.btip.SetBalloonText(this.batch, "在当前目录下做各种批量的操作");
            this.batch.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            this.batch.FocusCuesEnabled = false;
            this.batch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.batch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.batch.Location = new System.Drawing.Point(94, 4);
            this.batch.Name = "batch";
            this.batch.Size = new System.Drawing.Size(85, 43);
            this.batch.Symbol = "";
            this.batch.TabIndex = 115;
            this.batch.Text = "批量";
            this.batch.Click += new System.EventHandler(this.batch_Click);
            // 
            // copy
            // 
            this.copy.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.copy.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.copy.BackColor = System.Drawing.Color.Transparent;
            this.btip.SetBalloonCaption(this.copy, "提示");
            this.btip.SetBalloonText(this.copy, "复制当前选中的文件。");
            this.copy.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            this.copy.FocusCuesEnabled = false;
            this.copy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.copy.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.copy.Location = new System.Drawing.Point(184, 4);
            this.copy.Name = "copy";
            this.copy.Size = new System.Drawing.Size(60, 43);
            this.copy.Symbol = "";
            this.copy.SymbolSize = 15F;
            this.copy.TabIndex = 0;
            this.copy.Text = "复制";
            this.copy.Click += new System.EventHandler(this.copy_Click);
            // 
            // past
            // 
            this.past.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.past.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.past.BackColor = System.Drawing.Color.Transparent;
            this.btip.SetBalloonCaption(this.past, "提示");
            this.btip.SetBalloonText(this.past, "粘贴已复制的文件到当前目录");
            this.past.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            this.past.FocusCuesEnabled = false;
            this.past.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.past.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.past.Location = new System.Drawing.Point(249, 4);
            this.past.Name = "past";
            this.past.Size = new System.Drawing.Size(60, 43);
            this.past.SplitButton = true;
            this.past.Symbol = "";
            this.past.SymbolColor = System.Drawing.Color.Black;
            this.past.SymbolSize = 15F;
            this.past.TabIndex = 111;
            this.past.Text = "粘贴";
            this.past.Click += new System.EventHandler(this.past_Click);
            // 
            // del
            // 
            this.del.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.del.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.del.BackColor = System.Drawing.Color.Transparent;
            this.btip.SetBalloonCaption(this.del, "提示");
            this.btip.SetBalloonText(this.del, "删除当前选中的文件。");
            this.del.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            this.del.FocusCuesEnabled = false;
            this.del.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.del.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.del.Location = new System.Drawing.Point(314, 4);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(85, 43);
            this.del.Symbol = "";
            this.del.TabIndex = 105;
            this.del.Text = "删除";
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // toolsbox
            // 
            this.toolsbox.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.toolsbox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.toolsbox.BackColor = System.Drawing.Color.Transparent;
            this.btip.SetBalloonCaption(this.toolsbox, "提示");
            this.btip.SetBalloonText(this.toolsbox, "其他工具");
            this.toolsbox.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            this.toolsbox.FocusCuesEnabled = false;
            this.toolsbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolsbox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.toolsbox.Location = new System.Drawing.Point(404, 4);
            this.toolsbox.Name = "toolsbox";
            this.toolsbox.Size = new System.Drawing.Size(85, 43);
            this.toolsbox.Symbol = "";
            this.toolsbox.TabIndex = 116;
            this.toolsbox.Text = "工具";
            this.toolsbox.Click += new System.EventHandler(this.toolsbox_Click);
            // 
            // ordertags
            // 
            this.ordertags.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ordertags.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ordertags.BackColor = System.Drawing.Color.Transparent;
            this.btip.SetBalloonCaption(this.ordertags, "提示");
            this.btip.SetBalloonText(this.ordertags, "按书签名整理所有已标标签的文件，整理输出目录为：C:\\CW File Viewer\\Tags");
            this.ordertags.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            this.ordertags.FocusCuesEnabled = false;
            this.ordertags.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ordertags.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ordertags.Location = new System.Drawing.Point(494, 4);
            this.ordertags.Name = "ordertags";
            this.ordertags.Size = new System.Drawing.Size(85, 43);
            this.ordertags.Symbol = "";
            this.ordertags.TabIndex = 115;
            this.ordertags.Text = "整理标签";
            this.ordertags.Click += new System.EventHandler(this.ordertags_Click);
            // 
            // choosetagsys
            // 
            this.choosetagsys.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.choosetagsys.BackColor = System.Drawing.Color.Transparent;
            this.choosetagsys.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            this.choosetagsys.FocusCuesEnabled = false;
            this.choosetagsys.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.choosetagsys.Location = new System.Drawing.Point(584, 4);
            this.choosetagsys.Name = "choosetagsys";
            this.choosetagsys.Size = new System.Drawing.Size(101, 43);
            this.choosetagsys.Symbol = "";
            this.choosetagsys.TabIndex = 158;
            this.choosetagsys.Text = "管理标签系统";
            this.choosetagsys.Click += new System.EventHandler(this.choosetagsys_Click);
            // 
            // controlContainerItem8
            // 
            this.controlContainerItem8.AllowItemResize = false;
            this.controlContainerItem8.Control = this.cut;
            this.controlContainerItem8.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem8.Name = "controlContainerItem8";
            // 
            // controlContainerItem9
            // 
            this.controlContainerItem9.AllowItemResize = false;
            this.controlContainerItem9.Control = this.batch;
            this.controlContainerItem9.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem9.Name = "controlContainerItem9";
            // 
            // controlContainerItem10
            // 
            this.controlContainerItem10.AllowItemResize = false;
            this.controlContainerItem10.Control = this.copy;
            this.controlContainerItem10.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem10.Name = "controlContainerItem10";
            // 
            // controlContainerItem11
            // 
            this.controlContainerItem11.AllowItemResize = false;
            this.controlContainerItem11.Control = this.past;
            this.controlContainerItem11.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem11.Name = "controlContainerItem11";
            // 
            // controlContainerItem12
            // 
            this.controlContainerItem12.AllowItemResize = false;
            this.controlContainerItem12.Control = this.del;
            this.controlContainerItem12.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem12.Name = "controlContainerItem12";
            // 
            // controlContainerItem14
            // 
            this.controlContainerItem14.AllowItemResize = false;
            this.controlContainerItem14.Control = this.toolsbox;
            this.controlContainerItem14.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem14.Name = "controlContainerItem14";
            // 
            // controlContainerItem31
            // 
            this.controlContainerItem31.AllowItemResize = false;
            this.controlContainerItem31.Control = this.ordertags;
            this.controlContainerItem31.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem31.Name = "controlContainerItem31";
            // 
            // controlContainerItem49
            // 
            this.controlContainerItem49.AllowItemResize = false;
            this.controlContainerItem49.Control = this.choosetagsys;
            this.controlContainerItem49.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem49.Name = "controlContainerItem49";
            // 
            // ribbonBar1
            // 
            this.ribbonBar1.AutoOverflowEnabled = true;
            this.ribbonBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.ribbonBar1.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar1.ContainerControlProcessDialogKey = true;
            this.ribbonBar1.Controls.Add(this.sortw1);
            this.ribbonBar1.Controls.Add(this.sortw2);
            this.ribbonBar1.Controls.Add(this.onlyfolder);
            this.ribbonBar1.Controls.Add(this.openotherfile);
            this.ribbonBar1.Controls.Add(this.useprev);
            this.ribbonBar1.Controls.Add(this.goodsort);
            this.ribbonBar1.Controls.Add(this.seevery);
            this.ribbonBar1.Controls.Add(this.userogbin);
            this.ribbonBar1.Controls.Add(this.ShowTXT);
            this.ribbonBar1.Controls.Add(this.ShowNote);
            this.ribbonBar1.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar1.DragDropSupport = true;
            this.ribbonBar1.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.ribbonBar1.ForeColor = System.Drawing.Color.Black;
            this.ribbonBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer2,
            this.itemContainer3,
            this.itemContainer4,
            this.itemContainer5,
            this.itemContainer6});
            this.ribbonBar1.Location = new System.Drawing.Point(3, 0);
            this.ribbonBar1.Name = "ribbonBar1";
            this.ribbonBar1.Size = new System.Drawing.Size(451, 71);
            this.ribbonBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.ribbonBar1.TabIndex = 0;
            this.ribbonBar1.Text = "文件及查看选项";
            // 
            // 
            // 
            this.ribbonBar1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar1.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // sortw1
            // 
            this.sortw1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.sortw1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.sortw1.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.sortw1.Checked = true;
            this.sortw1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.sortw1.CheckValue = "Y";
            this.sortw1.FocusCuesEnabled = false;
            this.sortw1.ForeColor = System.Drawing.Color.Black;
            this.sortw1.Location = new System.Drawing.Point(4, 3);
            this.sortw1.Name = "sortw1";
            this.sortw1.Size = new System.Drawing.Size(67, 20);
            this.sortw1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.sortw1.TabIndex = 156;
            this.sortw1.Text = "按名称";
            this.sortw1.CheckedChanged += new System.EventHandler(this.sortw1_CheckedChanged);
            // 
            // sortw2
            // 
            this.sortw2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.sortw2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.sortw2.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.sortw2.FocusCuesEnabled = false;
            this.sortw2.ForeColor = System.Drawing.Color.Black;
            this.sortw2.Location = new System.Drawing.Point(4, 26);
            this.sortw2.Name = "sortw2";
            this.sortw2.Size = new System.Drawing.Size(67, 20);
            this.sortw2.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.sortw2.TabIndex = 157;
            this.sortw2.Text = "按后缀";
            // 
            // onlyfolder
            // 
            this.onlyfolder.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.onlyfolder.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.onlyfolder.FocusCuesEnabled = false;
            this.onlyfolder.ForeColor = System.Drawing.Color.Black;
            this.onlyfolder.Location = new System.Drawing.Point(76, 3);
            this.onlyfolder.Name = "onlyfolder";
            this.onlyfolder.Size = new System.Drawing.Size(116, 20);
            this.onlyfolder.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.onlyfolder.TabIndex = 158;
            this.onlyfolder.Text = "只显示文件夹";
            this.onlyfolder.CheckedChanged += new System.EventHandler(this.onlyfolder_CheckedChanged);
            // 
            // openotherfile
            // 
            this.openotherfile.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.openotherfile.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.btip.SetBalloonCaption(this.openotherfile, "提示");
            this.btip.SetBalloonText(this.openotherfile, "打开除文本和声音以外的文件，使用Windows默认方式打开。");
            this.openotherfile.Checked = true;
            this.openotherfile.CheckState = System.Windows.Forms.CheckState.Checked;
            this.openotherfile.CheckValue = "Y";
            this.openotherfile.FocusCuesEnabled = false;
            this.openotherfile.ForeColor = System.Drawing.Color.Black;
            this.openotherfile.Location = new System.Drawing.Point(76, 26);
            this.openotherfile.Name = "openotherfile";
            this.openotherfile.Size = new System.Drawing.Size(116, 20);
            this.openotherfile.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.openotherfile.TabIndex = 157;
            this.openotherfile.Text = "打开其他文件";
            // 
            // useprev
            // 
            this.useprev.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.useprev.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.btip.SetBalloonCaption(this.useprev, "提示");
            this.btip.SetBalloonText(this.useprev, "可预览文本和图片文件。");
            this.useprev.FocusCuesEnabled = false;
            this.useprev.ForeColor = System.Drawing.Color.Black;
            this.useprev.Location = new System.Drawing.Point(197, 3);
            this.useprev.Name = "useprev";
            this.useprev.Size = new System.Drawing.Size(85, 20);
            this.useprev.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.useprev.TabIndex = 157;
            this.useprev.Text = "使用预览";
            // 
            // goodsort
            // 
            this.goodsort.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.goodsort.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.btip.SetBalloonCaption(this.goodsort, "提示");
            this.btip.SetBalloonText(this.goodsort, "优化对数字的排序，但会少许降低速度 （本功能仅在第一种排序方法有效）");
            this.goodsort.FocusCuesEnabled = false;
            this.goodsort.ForeColor = System.Drawing.Color.Black;
            this.goodsort.Location = new System.Drawing.Point(197, 26);
            this.goodsort.Name = "goodsort";
            this.goodsort.Size = new System.Drawing.Size(85, 20);
            this.goodsort.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.goodsort.TabIndex = 148;
            this.goodsort.Text = "高级排序";
            this.goodsort.CheckedChanged += new System.EventHandler(this.goodsort_CheckedChanged);
            // 
            // seevery
            // 
            this.seevery.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.seevery.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.btip.SetBalloonCaption(this.seevery, "提示");
            this.btip.SetBalloonText(this.seevery, "可显示文件夹是否为空，但会降低路径加载速度。");
            this.seevery.FocusCuesEnabled = false;
            this.seevery.ForeColor = System.Drawing.Color.Black;
            this.seevery.Location = new System.Drawing.Point(287, 3);
            this.seevery.Name = "seevery";
            this.seevery.Size = new System.Drawing.Size(98, 20);
            this.seevery.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.seevery.TabIndex = 150;
            this.seevery.Text = "文件夹透视";
            this.seevery.CheckedChanged += new System.EventHandler(this.seevery_CheckedChanged);
            // 
            // userogbin
            // 
            this.userogbin.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.userogbin.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.userogbin.Checked = true;
            this.userogbin.CheckState = System.Windows.Forms.CheckState.Checked;
            this.userogbin.CheckValue = "Y";
            this.userogbin.FocusCuesEnabled = false;
            this.userogbin.ForeColor = System.Drawing.Color.Black;
            this.userogbin.Location = new System.Drawing.Point(287, 26);
            this.userogbin.Name = "userogbin";
            this.userogbin.Size = new System.Drawing.Size(98, 20);
            this.userogbin.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.userogbin.TabIndex = 148;
            this.userogbin.Text = "放入回收站";
            // 
            // ShowTXT
            // 
            this.ShowTXT.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.ShowTXT.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ShowTXT.Checked = true;
            this.ShowTXT.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ShowTXT.CheckValue = "Y";
            this.ShowTXT.FocusCuesEnabled = false;
            this.ShowTXT.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.ShowTXT.ForeColor = System.Drawing.Color.Black;
            this.ShowTXT.Location = new System.Drawing.Point(390, 3);
            this.ShowTXT.Name = "ShowTXT";
            this.ShowTXT.Size = new System.Drawing.Size(55, 20);
            this.ShowTXT.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.ShowTXT.TabIndex = 148;
            this.ShowTXT.Text = "TXT";
            this.ShowTXT.CheckedChanged += new System.EventHandler(this.ShowTXT_CheckedChanged);
            // 
            // ShowNote
            // 
            this.ShowNote.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.ShowNote.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ShowNote.Checked = true;
            this.ShowNote.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ShowNote.CheckValue = "Y";
            this.ShowNote.FocusCuesEnabled = false;
            this.ShowNote.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.ShowNote.ForeColor = System.Drawing.Color.Black;
            this.ShowNote.Location = new System.Drawing.Point(390, 26);
            this.ShowNote.Name = "ShowNote";
            this.ShowNote.Size = new System.Drawing.Size(55, 20);
            this.ShowNote.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.ShowNote.TabIndex = 148;
            this.ShowNote.Text = "Note";
            this.ShowNote.CheckedChanged += new System.EventHandler(this.ShowNote_CheckedChanged);
            // 
            // itemContainer2
            // 
            // 
            // 
            // 
            this.itemContainer2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer2.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemContainer2.Name = "itemContainer2";
            this.itemContainer2.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.controlContainerItem6,
            this.controlContainerItem27});
            // 
            // 
            // 
            this.itemContainer2.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // controlContainerItem6
            // 
            this.controlContainerItem6.AllowItemResize = false;
            this.controlContainerItem6.Control = this.sortw1;
            this.controlContainerItem6.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem6.Name = "controlContainerItem6";
            // 
            // controlContainerItem27
            // 
            this.controlContainerItem27.AllowItemResize = false;
            this.controlContainerItem27.Control = this.sortw2;
            this.controlContainerItem27.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem27.Name = "controlContainerItem27";
            // 
            // itemContainer3
            // 
            // 
            // 
            // 
            this.itemContainer3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer3.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemContainer3.Name = "itemContainer3";
            this.itemContainer3.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.controlContainerItem28,
            this.controlContainerItem36});
            // 
            // 
            // 
            this.itemContainer3.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // controlContainerItem28
            // 
            this.controlContainerItem28.AllowItemResize = false;
            this.controlContainerItem28.Control = this.onlyfolder;
            this.controlContainerItem28.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem28.Name = "controlContainerItem28";
            // 
            // controlContainerItem36
            // 
            this.controlContainerItem36.AllowItemResize = false;
            this.controlContainerItem36.Control = this.openotherfile;
            this.controlContainerItem36.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem36.Name = "controlContainerItem36";
            // 
            // itemContainer4
            // 
            // 
            // 
            // 
            this.itemContainer4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer4.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemContainer4.Name = "itemContainer4";
            this.itemContainer4.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.controlContainerItem2,
            this.controlContainerItem37});
            // 
            // 
            // 
            this.itemContainer4.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // controlContainerItem2
            // 
            this.controlContainerItem2.AllowItemResize = false;
            this.controlContainerItem2.Control = this.useprev;
            this.controlContainerItem2.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem2.Name = "controlContainerItem2";
            // 
            // controlContainerItem37
            // 
            this.controlContainerItem37.AllowItemResize = false;
            this.controlContainerItem37.Control = this.goodsort;
            this.controlContainerItem37.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem37.Name = "controlContainerItem37";
            // 
            // itemContainer5
            // 
            // 
            // 
            // 
            this.itemContainer5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer5.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemContainer5.Name = "itemContainer5";
            this.itemContainer5.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.controlContainerItem39,
            this.controlContainerItem40});
            // 
            // 
            // 
            this.itemContainer5.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // controlContainerItem39
            // 
            this.controlContainerItem39.AllowItemResize = false;
            this.controlContainerItem39.Control = this.seevery;
            this.controlContainerItem39.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem39.Name = "controlContainerItem39";
            // 
            // controlContainerItem40
            // 
            this.controlContainerItem40.AllowItemResize = false;
            this.controlContainerItem40.Control = this.userogbin;
            this.controlContainerItem40.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem40.Name = "controlContainerItem40";
            // 
            // itemContainer6
            // 
            // 
            // 
            // 
            this.itemContainer6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer6.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemContainer6.Name = "itemContainer6";
            this.itemContainer6.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.controlContainerItem54,
            this.controlContainerItem55});
            // 
            // 
            // 
            this.itemContainer6.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // controlContainerItem54
            // 
            this.controlContainerItem54.AllowItemResize = false;
            this.controlContainerItem54.Control = this.ShowTXT;
            this.controlContainerItem54.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem54.Name = "controlContainerItem54";
            // 
            // controlContainerItem55
            // 
            this.controlContainerItem55.AllowItemResize = false;
            this.controlContainerItem55.Control = this.ShowNote;
            this.controlContainerItem55.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem55.Name = "controlContainerItem55";
            // 
            // ribbonPanel2
            // 
            this.ribbonPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.ribbonPanel2.Controls.Add(this.ribbonBar11);
            this.ribbonPanel2.Controls.Add(this.ribbonBar10);
            this.ribbonPanel2.Controls.Add(this.ribbonBar9);
            this.ribbonPanel2.Controls.Add(this.ribbonBar8);
            this.ribbonPanel2.Controls.Add(this.ribbonBar7);
            this.ribbonPanel2.Controls.Add(this.ribbonBar5);
            this.ribbonPanel2.Controls.Add(this.ribbonBar4);
            this.ribbonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel2.Location = new System.Drawing.Point(0, 57);
            this.ribbonPanel2.Name = "ribbonPanel2";
            this.ribbonPanel2.Padding = new System.Windows.Forms.Padding(3, 0, 3, 2);
            this.ribbonPanel2.Size = new System.Drawing.Size(1374, 73);
            // 
            // 
            // 
            this.ribbonPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonPanel2.TabIndex = 2;
            this.ribbonPanel2.Visible = false;
            // 
            // ribbonBar11
            // 
            this.ribbonBar11.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar11.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar11.ContainerControlProcessDialogKey = true;
            this.ribbonBar11.Controls.Add(this.textwork);
            this.ribbonBar11.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar11.DragDropSupport = true;
            this.ribbonBar11.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.controlContainerItem52});
            this.ribbonBar11.Location = new System.Drawing.Point(988, 0);
            this.ribbonBar11.Name = "ribbonBar11";
            this.ribbonBar11.Size = new System.Drawing.Size(140, 71);
            this.ribbonBar11.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.ribbonBar11.TabIndex = 6;
            this.ribbonBar11.Text = "文本操作";
            // 
            // 
            // 
            this.ribbonBar11.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar11.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // textwork
            // 
            this.textwork.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.textwork.BackColor = System.Drawing.Color.Transparent;
            this.textwork.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            this.textwork.FocusCuesEnabled = false;
            this.textwork.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textwork.Location = new System.Drawing.Point(4, 4);
            this.textwork.Name = "textwork";
            this.textwork.Size = new System.Drawing.Size(130, 43);
            this.textwork.Symbol = "";
            this.textwork.TabIndex = 158;
            this.textwork.Text = "文本操作";
            this.textwork.Click += new System.EventHandler(this.textwork_Click);
            // 
            // controlContainerItem52
            // 
            this.controlContainerItem52.AllowItemResize = false;
            this.controlContainerItem52.Control = this.textwork;
            this.controlContainerItem52.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem52.Name = "controlContainerItem52";
            // 
            // ribbonBar10
            // 
            this.ribbonBar10.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar10.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar10.ContainerControlProcessDialogKey = true;
            this.ribbonBar10.Controls.Add(this.ordertaginfo);
            this.ribbonBar10.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar10.DragDropSupport = true;
            this.ribbonBar10.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.controlContainerItem51});
            this.ribbonBar10.Location = new System.Drawing.Point(829, 0);
            this.ribbonBar10.Name = "ribbonBar10";
            this.ribbonBar10.Size = new System.Drawing.Size(159, 71);
            this.ribbonBar10.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.ribbonBar10.TabIndex = 5;
            this.ribbonBar10.Text = "整理";
            // 
            // 
            // 
            this.ribbonBar10.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar10.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // ordertaginfo
            // 
            this.ordertaginfo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ordertaginfo.BackColor = System.Drawing.Color.Transparent;
            this.ordertaginfo.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            this.ordertaginfo.FocusCuesEnabled = false;
            this.ordertaginfo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ordertaginfo.Location = new System.Drawing.Point(4, 4);
            this.ordertaginfo.Name = "ordertaginfo";
            this.ordertaginfo.Size = new System.Drawing.Size(149, 43);
            this.ordertaginfo.Symbol = "";
            this.ordertaginfo.TabIndex = 158;
            this.ordertaginfo.Text = "整理标签说明";
            this.ordertaginfo.Click += new System.EventHandler(this.ordertaginfo_Click);
            // 
            // controlContainerItem51
            // 
            this.controlContainerItem51.AllowItemResize = false;
            this.controlContainerItem51.Control = this.ordertaginfo;
            this.controlContainerItem51.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem51.Name = "controlContainerItem51";
            // 
            // ribbonBar9
            // 
            this.ribbonBar9.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar9.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar9.ContainerControlProcessDialogKey = true;
            this.ribbonBar9.Controls.Add(this.embackup);
            this.ribbonBar9.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar9.DragDropSupport = true;
            this.ribbonBar9.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.controlContainerItem50});
            this.ribbonBar9.Location = new System.Drawing.Point(697, 0);
            this.ribbonBar9.Name = "ribbonBar9";
            this.ribbonBar9.Size = new System.Drawing.Size(132, 71);
            this.ribbonBar9.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.ribbonBar9.TabIndex = 4;
            this.ribbonBar9.Text = "备份";
            // 
            // 
            // 
            this.ribbonBar9.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar9.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // embackup
            // 
            this.embackup.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.embackup.BackColor = System.Drawing.Color.Transparent;
            this.embackup.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            this.embackup.FocusCuesEnabled = false;
            this.embackup.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.embackup.Location = new System.Drawing.Point(4, 4);
            this.embackup.Name = "embackup";
            this.embackup.Size = new System.Drawing.Size(122, 43);
            this.embackup.Symbol = "";
            this.embackup.TabIndex = 158;
            this.embackup.Text = "紧急备份";
            this.embackup.Click += new System.EventHandler(this.embackup_Click);
            // 
            // controlContainerItem50
            // 
            this.controlContainerItem50.AllowItemResize = false;
            this.controlContainerItem50.Control = this.embackup;
            this.controlContainerItem50.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem50.Name = "controlContainerItem50";
            // 
            // ribbonBar8
            // 
            this.ribbonBar8.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar8.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar8.ContainerControlProcessDialogKey = true;
            this.ribbonBar8.Controls.Add(this.savestatenow);
            this.ribbonBar8.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar8.DragDropSupport = true;
            this.ribbonBar8.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.ribbonBar8.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.controlContainerItem48});
            this.ribbonBar8.Location = new System.Drawing.Point(541, 0);
            this.ribbonBar8.Name = "ribbonBar8";
            this.ribbonBar8.Size = new System.Drawing.Size(156, 71);
            this.ribbonBar8.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.ribbonBar8.TabIndex = 3;
            this.ribbonBar8.Text = "保存";
            // 
            // 
            // 
            this.ribbonBar8.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar8.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // savestatenow
            // 
            this.savestatenow.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.savestatenow.BackColor = System.Drawing.Color.Transparent;
            this.savestatenow.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            this.savestatenow.FocusCuesEnabled = false;
            this.savestatenow.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.savestatenow.Location = new System.Drawing.Point(4, 4);
            this.savestatenow.Name = "savestatenow";
            this.savestatenow.Size = new System.Drawing.Size(146, 43);
            this.savestatenow.Symbol = "";
            this.savestatenow.TabIndex = 158;
            this.savestatenow.Text = "保存当前状态";
            this.savestatenow.Click += new System.EventHandler(this.savestatenow_Click);
            // 
            // controlContainerItem48
            // 
            this.controlContainerItem48.AllowItemResize = false;
            this.controlContainerItem48.Control = this.savestatenow;
            this.controlContainerItem48.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem48.Name = "controlContainerItem48";
            // 
            // ribbonBar7
            // 
            this.ribbonBar7.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar7.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar7.ContainerControlProcessDialogKey = true;
            this.ribbonBar7.Controls.Add(this.cleantag);
            this.ribbonBar7.Controls.Add(this.tagpageman);
            this.ribbonBar7.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar7.DragDropSupport = true;
            this.ribbonBar7.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.ribbonBar7.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.controlContainerItem41,
            this.controlContainerItem47});
            this.ribbonBar7.Location = new System.Drawing.Point(270, 0);
            this.ribbonBar7.Name = "ribbonBar7";
            this.ribbonBar7.Size = new System.Drawing.Size(271, 71);
            this.ribbonBar7.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.ribbonBar7.TabIndex = 2;
            this.ribbonBar7.Text = "标签工具";
            // 
            // 
            // 
            this.ribbonBar7.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar7.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // cleantag
            // 
            this.cleantag.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cleantag.BackColor = System.Drawing.Color.Transparent;
            this.btip.SetBalloonCaption(this.cleantag, "提示");
            this.btip.SetBalloonText(this.cleantag, "检查所有文件中的所有已标的标签中是否有已被删除的标签，如果有，删除。");
            this.cleantag.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            this.cleantag.FocusCuesEnabled = false;
            this.cleantag.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cleantag.Location = new System.Drawing.Point(4, 4);
            this.cleantag.Name = "cleantag";
            this.cleantag.Size = new System.Drawing.Size(122, 43);
            this.cleantag.Symbol = "";
            this.cleantag.TabIndex = 158;
            this.cleantag.Text = "清理标签";
            this.cleantag.Click += new System.EventHandler(this.cleantag_Click);
            // 
            // tagpageman
            // 
            this.tagpageman.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.tagpageman.BackColor = System.Drawing.Color.Transparent;
            this.tagpageman.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            this.tagpageman.FocusCuesEnabled = false;
            this.tagpageman.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tagpageman.Location = new System.Drawing.Point(131, 4);
            this.tagpageman.Name = "tagpageman";
            this.tagpageman.Size = new System.Drawing.Size(134, 43);
            this.tagpageman.Symbol = "";
            this.tagpageman.TabIndex = 158;
            this.tagpageman.Text = "标签页管理";
            this.tagpageman.Click += new System.EventHandler(this.tagpageman_Click);
            // 
            // controlContainerItem41
            // 
            this.controlContainerItem41.AllowItemResize = false;
            this.controlContainerItem41.Control = this.cleantag;
            this.controlContainerItem41.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem41.Name = "controlContainerItem41";
            // 
            // controlContainerItem47
            // 
            this.controlContainerItem47.AllowItemResize = false;
            this.controlContainerItem47.Control = this.tagpageman;
            this.controlContainerItem47.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem47.Name = "controlContainerItem47";
            // 
            // ribbonBar5
            // 
            this.ribbonBar5.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar5.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar5.ContainerControlProcessDialogKey = true;
            this.ribbonBar5.Controls.Add(this.search);
            this.ribbonBar5.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar5.DragDropSupport = true;
            this.ribbonBar5.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.ribbonBar5.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.controlContainerItem7});
            this.ribbonBar5.Location = new System.Drawing.Point(107, 0);
            this.ribbonBar5.Name = "ribbonBar5";
            this.ribbonBar5.Size = new System.Drawing.Size(163, 71);
            this.ribbonBar5.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.ribbonBar5.TabIndex = 1;
            this.ribbonBar5.Text = "文件搜索工具";
            // 
            // 
            // 
            this.ribbonBar5.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar5.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // search
            // 
            this.search.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.search.BackColor = System.Drawing.Color.Transparent;
            this.search.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            this.search.FocusCuesEnabled = false;
            this.search.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.search.Location = new System.Drawing.Point(4, 4);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(153, 43);
            this.search.Symbol = "";
            this.search.TabIndex = 158;
            this.search.Text = "搜索已标文件";
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // controlContainerItem7
            // 
            this.controlContainerItem7.AllowItemResize = false;
            this.controlContainerItem7.Control = this.search;
            this.controlContainerItem7.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem7.Name = "controlContainerItem7";
            // 
            // ribbonBar4
            // 
            this.ribbonBar4.AutoOverflowEnabled = true;
            this.ribbonBar4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.ribbonBar4.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar4.ContainerControlProcessDialogKey = true;
            this.ribbonBar4.Controls.Add(this.usedic);
            this.ribbonBar4.Controls.Add(this.add);
            this.ribbonBar4.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar4.DragDropSupport = true;
            this.ribbonBar4.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.ribbonBar4.ForeColor = System.Drawing.Color.Black;
            this.ribbonBar4.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer7});
            this.ribbonBar4.Location = new System.Drawing.Point(3, 0);
            this.ribbonBar4.Name = "ribbonBar4";
            this.ribbonBar4.Size = new System.Drawing.Size(104, 71);
            this.ribbonBar4.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.ribbonBar4.TabIndex = 0;
            this.ribbonBar4.Text = "自定义词典工具";
            // 
            // 
            // 
            this.ribbonBar4.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar4.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // usedic
            // 
            this.usedic.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.usedic.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.usedic.FocusCuesEnabled = false;
            this.usedic.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.usedic.ForeColor = System.Drawing.Color.Black;
            this.usedic.Location = new System.Drawing.Point(4, 3);
            this.usedic.Name = "usedic";
            this.usedic.Size = new System.Drawing.Size(94, 20);
            this.usedic.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.usedic.TabIndex = 147;
            this.usedic.Text = "词典工具";
            // 
            // add
            // 
            this.add.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.add.BackColor = System.Drawing.Color.Transparent;
            this.add.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            this.add.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.add.FocusCuesEnabled = false;
            this.add.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.add.Location = new System.Drawing.Point(4, 26);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(94, 20);
            this.add.Symbol = "";
            this.add.SymbolSize = 10F;
            this.add.TabIndex = 147;
            this.add.Text = "添加词语";
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // itemContainer7
            // 
            // 
            // 
            // 
            this.itemContainer7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer7.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemContainer7.Name = "itemContainer7";
            this.itemContainer7.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.controlContainerItem23,
            this.controlContainerItem24});
            // 
            // 
            // 
            this.itemContainer7.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // controlContainerItem23
            // 
            this.controlContainerItem23.AllowItemResize = false;
            this.controlContainerItem23.Control = this.usedic;
            this.controlContainerItem23.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem23.Name = "controlContainerItem23";
            // 
            // controlContainerItem24
            // 
            this.controlContainerItem24.AllowItemResize = false;
            this.controlContainerItem24.Control = this.add;
            this.controlContainerItem24.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem24.Name = "controlContainerItem24";
            // 
            // applicationButton1
            // 
            this.applicationButton1.AutoExpandOnClick = true;
            this.applicationButton1.BackstageTab = this.superTabControl1;
            this.applicationButton1.CanCustomize = false;
            this.applicationButton1.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.Image;
            this.applicationButton1.ImageFixedSize = new System.Drawing.Size(16, 16);
            this.applicationButton1.ImagePaddingHorizontal = 0;
            this.applicationButton1.ImagePaddingVertical = 1;
            this.applicationButton1.Name = "applicationButton1";
            this.applicationButton1.ShowSubItems = false;
            this.applicationButton1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.aboutcfv});
            this.applicationButton1.Text = "设置";
            // 
            // superTabControl1
            // 
            this.superTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.superTabControl1.AutoCloseTabs = false;
            this.superTabControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.superTabControl1.CloseButtonOnTabsAlwaysDisplayed = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.superTabControl1.ControlBox.CloseBox.Name = "";
            // 
            // 
            // 
            this.superTabControl1.ControlBox.MenuBox.Name = "";
            this.superTabControl1.ControlBox.Name = "";
            this.superTabControl1.ControlBox.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.superTabControl1.ControlBox.MenuBox,
            this.superTabControl1.ControlBox.CloseBox});
            this.superTabControl1.ControlBox.Visible = false;
            this.superTabControl1.Controls.Add(this.superTabControlPanel1);
            this.superTabControl1.Controls.Add(this.superTabControlPanel2);
            this.superTabControl1.Controls.Add(this.superTabControlPanel4);
            this.superTabControl1.ForeColor = System.Drawing.Color.Black;
            this.superTabControl1.ImageAlignment = DevComponents.DotNetBar.ImageAlignment.TopCenter;
            this.superTabControl1.ItemPadding.Left = 6;
            this.superTabControl1.ItemPadding.Right = 4;
            this.superTabControl1.ItemPadding.Top = 4;
            this.superTabControl1.Location = new System.Drawing.Point(1, 1);
            this.superTabControl1.Name = "superTabControl1";
            this.superTabControl1.ReorderTabsEnabled = true;
            this.superTabControl1.SelectedTabFont = new System.Drawing.Font("Segoe UI", 10F);
            this.superTabControl1.SelectedTabIndex = 4;
            this.superTabControl1.Size = new System.Drawing.Size(1382, 766);
            this.superTabControl1.TabAlignment = DevComponents.DotNetBar.eTabStripAlignment.Left;
            this.superTabControl1.TabFont = new System.Drawing.Font("Segoe UI", 10F);
            this.superTabControl1.TabHorizontalSpacing = 20;
            this.superTabControl1.TabIndex = 158;
            this.superTabControl1.Tabs.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.常规,
            this.superTabItem1});
            this.superTabControl1.TabStyle = DevComponents.DotNetBar.eSuperTabStyle.Office2010BackstageBlue;
            this.superTabControl1.TabVerticalSpacing = 8;
            // 
            // superTabControlPanel1
            // 
            this.superTabControlPanel1.Controls.Add(this.reflectionLabel2);
            this.superTabControlPanel1.Controls.Add(this.labelX1);
            this.superTabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel1.Location = new System.Drawing.Point(109, 28);
            this.superTabControlPanel1.Name = "superTabControlPanel1";
            this.superTabControlPanel1.Size = new System.Drawing.Size(1273, 738);
            this.superTabControlPanel1.TabIndex = 0;
            this.superTabControlPanel1.TabItem = this.superTabItem1;
            // 
            // reflectionLabel2
            // 
            this.reflectionLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.reflectionLabel2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.reflectionLabel2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.reflectionLabel2.Font = new System.Drawing.Font("YouYuan", 30F);
            this.reflectionLabel2.ForeColor = System.Drawing.Color.Black;
            this.reflectionLabel2.Location = new System.Drawing.Point(885, 585);
            this.reflectionLabel2.Name = "reflectionLabel2";
            this.reflectionLabel2.Size = new System.Drawing.Size(251, 205);
            this.reflectionLabel2.TabIndex = 174;
            this.reflectionLabel2.Text = "陈为制作";
            // 
            // labelX1
            // 
            this.labelX1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelX1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Curlz MT", 90F);
            this.labelX1.ForeColor = System.Drawing.Color.Black;
            this.labelX1.Location = new System.Drawing.Point(13, 16);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(1079, 718);
            this.labelX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.labelX1.TabIndex = 175;
            this.labelX1.Text = "CW File Viewer\r\n        5.6.6";
            // 
            // superTabItem1
            // 
            this.superTabItem1.AttachedControl = this.superTabControlPanel1;
            this.superTabItem1.GlobalItem = false;
            this.superTabItem1.Name = "superTabItem1";
            this.superTabItem1.Text = "关于";
            // 
            // superTabControlPanel2
            // 
            this.superTabControlPanel2.Controls.Add(this.textl1);
            this.superTabControlPanel2.Controls.Add(this.autost);
            this.superTabControlPanel2.Controls.Add(this.UseFormatForm);
            this.superTabControlPanel2.Controls.Add(this.filehighlight);
            this.superTabControlPanel2.Controls.Add(this.useast);
            this.superTabControlPanel2.Controls.Add(this.recoveryatfirst);
            this.superTabControlPanel2.Controls.Add(this.savenohint);
            this.superTabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel2.Location = new System.Drawing.Point(109, 28);
            this.superTabControlPanel2.Name = "superTabControlPanel2";
            this.superTabControlPanel2.Size = new System.Drawing.Size(1273, 738);
            this.superTabControlPanel2.TabIndex = 0;
            this.superTabControlPanel2.TabItem = this.常规;
            // 
            // textl1
            // 
            this.textl1.AutoSize = true;
            this.textl1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.textl1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textl1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.textl1.Location = new System.Drawing.Point(384, 112);
            this.textl1.Name = "textl1";
            this.textl1.Size = new System.Drawing.Size(48, 29);
            this.textl1.TabIndex = 3;
            this.textl1.Text = "分钟";
            // 
            // autost
            // 
            // 
            // 
            // 
            this.autost.BackgroundStyle.Class = "DateTimeInputBackground";
            this.autost.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.autost.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.autost.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autost.Location = new System.Drawing.Point(324, 112);
            this.autost.MaxValue = 100;
            this.autost.MinValue = 1;
            this.autost.Name = "autost";
            this.autost.ShowUpDown = true;
            this.autost.Size = new System.Drawing.Size(54, 30);
            this.autost.TabIndex = 2;
            this.autost.Value = 1;
            this.autost.ValueChanged += new System.EventHandler(this.autost_ValueChanged);
            // 
            // UseFormatForm
            // 
            this.UseFormatForm.AutoSize = true;
            this.UseFormatForm.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.UseFormatForm.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.UseFormatForm.Checked = true;
            this.UseFormatForm.CheckSignSize = new System.Drawing.Size(17, 17);
            this.UseFormatForm.CheckState = System.Windows.Forms.CheckState.Checked;
            this.UseFormatForm.CheckValue = "Y";
            this.UseFormatForm.FocusCuesEnabled = false;
            this.UseFormatForm.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.UseFormatForm.Location = new System.Drawing.Point(31, 205);
            this.UseFormatForm.Name = "UseFormatForm";
            this.UseFormatForm.Size = new System.Drawing.Size(230, 29);
            this.UseFormatForm.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.UseFormatForm.TabIndex = 1;
            this.UseFormatForm.Text = "选择文本是启用格式窗";
            this.UseFormatForm.CheckedChanged += new System.EventHandler(this.UseFormatForm_CheckedChanged);
            // 
            // filehighlight
            // 
            this.filehighlight.AutoSize = true;
            this.filehighlight.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.filehighlight.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.filehighlight.Checked = true;
            this.filehighlight.CheckSignSize = new System.Drawing.Size(17, 17);
            this.filehighlight.CheckState = System.Windows.Forms.CheckState.Checked;
            this.filehighlight.CheckValue = "Y";
            this.filehighlight.FocusCuesEnabled = false;
            this.filehighlight.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.filehighlight.Location = new System.Drawing.Point(31, 158);
            this.filehighlight.Name = "filehighlight";
            this.filehighlight.Size = new System.Drawing.Size(171, 29);
            this.filehighlight.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.filehighlight.TabIndex = 1;
            this.filehighlight.Text = "打开文件时高亮";
            this.filehighlight.CheckedChanged += new System.EventHandler(this.filehighlight_CheckedChanged);
            // 
            // useast
            // 
            this.useast.AutoSize = true;
            this.useast.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.useast.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.useast.Checked = true;
            this.useast.CheckSignSize = new System.Drawing.Size(17, 17);
            this.useast.CheckState = System.Windows.Forms.CheckState.Checked;
            this.useast.CheckValue = "Y";
            this.useast.FocusCuesEnabled = false;
            this.useast.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.useast.Location = new System.Drawing.Point(31, 111);
            this.useast.Name = "useast";
            this.useast.Size = new System.Drawing.Size(309, 29);
            this.useast.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.useast.TabIndex = 1;
            this.useast.Text = "启用自动保存，保存时间间隔：";
            this.useast.CheckedChanged += new System.EventHandler(this.useast_CheckedChanged);
            // 
            // recoveryatfirst
            // 
            this.recoveryatfirst.AutoSize = true;
            this.recoveryatfirst.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.recoveryatfirst.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.recoveryatfirst.CheckSignSize = new System.Drawing.Size(17, 17);
            this.recoveryatfirst.FocusCuesEnabled = false;
            this.recoveryatfirst.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.recoveryatfirst.Location = new System.Drawing.Point(31, 66);
            this.recoveryatfirst.Name = "recoveryatfirst";
            this.recoveryatfirst.Size = new System.Drawing.Size(569, 27);
            this.recoveryatfirst.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.recoveryatfirst.TabIndex = 1;
            this.recoveryatfirst.Text = "自动回复到上一次关闭前最后一次浏览到的路径\r\n\r\n<i>（重启后生效）</i>";
            this.recoveryatfirst.CheckedChanged += new System.EventHandler(this.recoveryatfirst_CheckedChanged);
            // 
            // savenohint
            // 
            this.savenohint.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.savenohint.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.savenohint.Checked = true;
            this.savenohint.CheckSignSize = new System.Drawing.Size(17, 17);
            this.savenohint.CheckState = System.Windows.Forms.CheckState.Checked;
            this.savenohint.CheckValue = "Y";
            this.savenohint.FocusCuesEnabled = false;
            this.savenohint.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.savenohint.Location = new System.Drawing.Point(31, 25);
            this.savenohint.Name = "savenohint";
            this.savenohint.Size = new System.Drawing.Size(343, 23);
            this.savenohint.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.savenohint.TabIndex = 0;
            this.savenohint.Text = "选择新文件时自动保存（不提示）";
            this.savenohint.CheckedChanged += new System.EventHandler(this.savenohint_CheckedChanged);
            // 
            // 常规
            // 
            this.常规.AttachedControl = this.superTabControlPanel2;
            this.常规.GlobalItem = false;
            this.常规.Name = "常规";
            this.常规.Text = "常规";
            // 
            // superTabControlPanel4
            // 
            this.superTabControlPanel4.BackgroundImagePosition = DevComponents.DotNetBar.eStyleBackgroundImage.BottomRight;
            this.superTabControlPanel4.Location = new System.Drawing.Point(236, 0);
            this.superTabControlPanel4.Name = "superTabControlPanel4";
            this.superTabControlPanel4.Size = new System.Drawing.Size(1128, 718);
            this.superTabControlPanel4.TabIndex = 4;
            // 
            // aboutcfv
            // 
            this.aboutcfv.Name = "aboutcfv";
            this.aboutcfv.Symbol = "";
            this.aboutcfv.Text = "关于 CW File Viewer";
            // 
            // ribbonTabItem1
            // 
            this.ribbonTabItem1.Checked = true;
            this.ribbonTabItem1.Name = "ribbonTabItem1";
            this.ribbonTabItem1.Panel = this.ribbonPanel1;
            this.ribbonTabItem1.Text = "实用工具";
            // 
            // ribbonTabItem2
            // 
            this.ribbonTabItem2.Name = "ribbonTabItem2";
            this.ribbonTabItem2.Panel = this.ribbonPanel2;
            this.ribbonTabItem2.Text = "其他工具";
            // 
            // panelfile
            // 
            this.panelfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.panelfile.Controls.Add(this.tabv);
            this.panelfile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelfile.ForeColor = System.Drawing.Color.Black;
            this.panelfile.Location = new System.Drawing.Point(0, 0);
            this.panelfile.Name = "panelfile";
            this.panelfile.Size = new System.Drawing.Size(413, 582);
            this.panelfile.TabIndex = 152;
            this.panelfile.SizeChanged += new System.EventHandler(this.leftpanel_SizeChanged);
            // 
            // repeatplay
            // 
            this.repeatplay.AutoSize = true;
            this.repeatplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.repeatplay.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.repeatplay.FocusCuesEnabled = false;
            this.repeatplay.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.repeatplay.ForeColor = System.Drawing.Color.Black;
            this.repeatplay.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.repeatplay.Location = new System.Drawing.Point(217, 10);
            this.repeatplay.Name = "repeatplay";
            this.repeatplay.Size = new System.Drawing.Size(88, 23);
            this.repeatplay.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.repeatplay.TabIndex = 137;
            this.repeatplay.Text = "重复播放";
            // 
            // playbutton
            // 
            this.playbutton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.playbutton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.playbutton.Enabled = false;
            this.playbutton.FocusCuesEnabled = false;
            this.playbutton.HoverImage = global::CW_File_Viewer_5.Properties.Resources.state12;
            this.playbutton.Image = global::CW_File_Viewer_5.Properties.Resources.state11;
            this.playbutton.Location = new System.Drawing.Point(2, 9);
            this.playbutton.Name = "playbutton";
            this.playbutton.PressedImage = global::CW_File_Viewer_5.Properties.Resources.state13;
            this.playbutton.Size = new System.Drawing.Size(25, 25);
            this.playbutton.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.playbutton.TabIndex = 154;
            this.playbutton.Click += new System.EventHandler(this.playbutton_Click);
            // 
            // volumeslider
            // 
            this.volumeslider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.volumeslider.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.volumeslider.FocusCuesEnabled = false;
            this.volumeslider.ForeColor = System.Drawing.Color.Black;
            this.volumeslider.LabelPosition = DevComponents.DotNetBar.eSliderLabelPosition.Right;
            this.volumeslider.LabelVisible = false;
            this.volumeslider.LabelWidth = 31;
            this.volumeslider.Location = new System.Drawing.Point(58, 11);
            this.volumeslider.Name = "volumeslider";
            this.volumeslider.Size = new System.Drawing.Size(150, 21);
            this.volumeslider.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.volumeslider.TabIndex = 153;
            this.volumeslider.Text = "100";
            this.volumeslider.TextColor = System.Drawing.Color.DarkGray;
            this.volumeslider.Value = 100;
            this.volumeslider.ValueChanged += new System.EventHandler(this.volumeslider_ValueChanged);
            // 
            // looksametxt
            // 
            this.looksametxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.looksametxt.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.looksametxt.Checked = true;
            this.looksametxt.CheckState = System.Windows.Forms.CheckState.Checked;
            this.looksametxt.CheckValue = "Y";
            this.looksametxt.FocusCuesEnabled = false;
            this.looksametxt.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.looksametxt.ForeColor = System.Drawing.Color.Black;
            this.looksametxt.Location = new System.Drawing.Point(477, 10);
            this.looksametxt.Name = "looksametxt";
            this.looksametxt.Size = new System.Drawing.Size(143, 21);
            this.looksametxt.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.looksametxt.TabIndex = 145;
            this.looksametxt.Text = "同时显示同名RTF";
            // 
            // looklrc
            // 
            this.looklrc.AutoSize = true;
            this.looklrc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.looklrc.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.looklrc.FocusCuesEnabled = false;
            this.looklrc.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.looklrc.ForeColor = System.Drawing.Color.Black;
            this.looklrc.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.looklrc.Location = new System.Drawing.Point(312, 10);
            this.looklrc.Name = "looklrc";
            this.looklrc.Size = new System.Drawing.Size(159, 23);
            this.looklrc.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.looklrc.TabIndex = 139;
            this.looklrc.Text = "显示字幕+播放状态";
            // 
            // coverl1
            // 
            this.coverl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.coverl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.coverl1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.coverl1.ForeColor = System.Drawing.Color.Black;
            this.coverl1.Location = new System.Drawing.Point(-28, 8);
            this.coverl1.Name = "coverl1";
            this.coverl1.Size = new System.Drawing.Size(984, 34);
            this.coverl1.TabIndex = 148;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(660, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 123;
            this.label4.Text = "字数:";
            // 
            // lwsum
            // 
            this.lwsum.AutoSize = true;
            this.lwsum.BackColor = System.Drawing.Color.Transparent;
            this.lwsum.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lwsum.ForeColor = System.Drawing.Color.White;
            this.lwsum.Location = new System.Drawing.Point(713, 2);
            this.lwsum.Name = "lwsum";
            this.lwsum.Size = new System.Drawing.Size(18, 20);
            this.lwsum.TabIndex = 118;
            this.lwsum.Text = "0";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(311, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 117;
            this.label1.Text = "字数：";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "未选择路径";
            this.columnHeader1.Width = 1244;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "未选择路径";
            this.columnHeader3.Width = 1244;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "未选择路径";
            this.columnHeader2.Width = 1244;
            // 
            // styleManager
            // 
            this.styleManager.ManagerColorTint = System.Drawing.Color.White;
            this.styleManager.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2013;
            this.styleManager.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))), System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(142)))), ((int)(((byte)(0))))));
            // 
            // nowdoti
            // 
            this.nowdoti.Enabled = true;
            this.nowdoti.Tick += new System.EventHandler(this.nowdoti_Tick);
            // 
            // fullscr
            // 
            this.fullscr.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.fullscr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fullscr.BackColor = System.Drawing.Color.Transparent;
            this.fullscr.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            this.fullscr.FocusCuesEnabled = false;
            this.fullscr.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.fullscr.Location = new System.Drawing.Point(1191, 5);
            this.fullscr.Name = "fullscr";
            this.fullscr.Size = new System.Drawing.Size(68, 23);
            this.fullscr.Symbol = "";
            this.fullscr.SymbolSize = 9F;
            this.fullscr.TabIndex = 144;
            this.fullscr.Text = "全屏";
            this.fullscr.Click += new System.EventHandler(this.fullscr_Click);
            // 
            // controlContainerItem1
            // 
            this.controlContainerItem1.AllowItemResize = false;
            this.controlContainerItem1.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem1.Name = "controlContainerItem1";
            // 
            // controlContainerItem30
            // 
            this.controlContainerItem30.AllowItemResize = false;
            this.controlContainerItem30.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem30.Name = "controlContainerItem30";
            // 
            // controlContainerItem29
            // 
            this.controlContainerItem29.AllowItemResize = false;
            this.controlContainerItem29.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem29.Name = "controlContainerItem29";
            // 
            // itemContainer12
            // 
            // 
            // 
            // 
            this.itemContainer12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer12.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemContainer12.Name = "itemContainer12";
            this.itemContainer12.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer13});
            // 
            // 
            // 
            this.itemContainer12.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // itemContainer13
            // 
            // 
            // 
            // 
            this.itemContainer13.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer13.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemContainer13.Name = "itemContainer13";
            // 
            // 
            // 
            this.itemContainer13.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // microChartItem1
            // 
            this.microChartItem1.Name = "microChartItem1";
            // 
            // metroStatusBar1
            // 
            this.metroStatusBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.metroStatusBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroStatusBar1.ContainerControlProcessDialogKey = true;
            this.metroStatusBar1.Controls.Add(this.tschooser);
            this.metroStatusBar1.Controls.Add(this.txtstate);
            this.metroStatusBar1.Controls.Add(this.label4);
            this.metroStatusBar1.Controls.Add(this.lwsum);
            this.metroStatusBar1.Controls.Add(this.label2);
            this.metroStatusBar1.Controls.Add(this.nowdo);
            this.metroStatusBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroStatusBar1.DragDropSupport = true;
            this.metroStatusBar1.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroStatusBar1.ForeColor = System.Drawing.Color.Black;
            this.metroStatusBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.nowprog,
            this.controlContainerItem53,
            this.controlContainerItem13,
            this.controlContainerItem19,
            this.controlContainerItem34,
            this.controlContainerItem35,
            this.controlContainerItem33});
            this.metroStatusBar1.Location = new System.Drawing.Point(5, 744);
            this.metroStatusBar1.Name = "metroStatusBar1";
            this.metroStatusBar1.Size = new System.Drawing.Size(1374, 22);
            this.metroStatusBar1.TabIndex = 148;
            // 
            // tschooser
            // 
            this.tschooser.DisplayMember = "Text";
            this.tschooser.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.tschooser.Font = new System.Drawing.Font("SimSun", 8.25F);
            this.tschooser.FormattingEnabled = true;
            this.tschooser.ItemHeight = 17;
            this.tschooser.Location = new System.Drawing.Point(413, 0);
            this.tschooser.Name = "tschooser";
            this.tschooser.Size = new System.Drawing.Size(175, 23);
            this.tschooser.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.tschooser.TabIndex = 1;
            this.tschooser.SelectedIndexChanged += new System.EventHandler(this.tschooser_SelectedIndexChanged);
            // 
            // txtstate
            // 
            this.txtstate.AutoSize = true;
            this.txtstate.BackColor = System.Drawing.Color.Transparent;
            this.txtstate.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.txtstate.ForeColor = System.Drawing.Color.White;
            this.txtstate.Location = new System.Drawing.Point(594, 2);
            this.txtstate.Name = "txtstate";
            this.txtstate.Size = new System.Drawing.Size(60, 20);
            this.txtstate.TabIndex = 148;
            this.txtstate.Text = "未修改";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 6.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(737, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 147;
            this.label2.Text = " 音频:";
            // 
            // nowdo
            // 
            this.nowdo.AutoSize = true;
            this.nowdo.BackColor = System.Drawing.Color.Transparent;
            this.nowdo.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.nowdo.ForeColor = System.Drawing.Color.White;
            this.nowdo.Location = new System.Drawing.Point(784, 2);
            this.nowdo.Name = "nowdo";
            this.nowdo.Size = new System.Drawing.Size(408, 20);
            this.nowdo.TabIndex = 147;
            this.nowdo.Text = "（如想查看字幕和状态请选择“显示字幕+播放状态”）";
            this.nowdo.Visible = false;
            // 
            // nowprog
            // 
            // 
            // 
            // 
            this.nowprog.BackStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.nowprog.ChunkGradientAngle = 0F;
            this.nowprog.ClickAutoRepeat = true;
            this.nowprog.Height = 16;
            this.nowprog.Maximum = 10000;
            this.nowprog.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleIfRecentlyUsed;
            this.nowprog.Name = "nowprog";
            this.nowprog.RecentlyUsed = false;
            this.nowprog.ShowSubItems = false;
            this.nowprog.TextVisible = true;
            this.nowprog.Value = 10000;
            this.nowprog.Width = 405;
            // 
            // controlContainerItem53
            // 
            this.controlContainerItem53.AllowItemResize = false;
            this.controlContainerItem53.Control = this.tschooser;
            this.controlContainerItem53.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem53.Name = "controlContainerItem53";
            // 
            // controlContainerItem13
            // 
            this.controlContainerItem13.AllowItemResize = false;
            this.controlContainerItem13.Control = this.txtstate;
            this.controlContainerItem13.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem13.Name = "controlContainerItem13";
            // 
            // controlContainerItem19
            // 
            this.controlContainerItem19.AllowItemResize = false;
            this.controlContainerItem19.Control = this.label4;
            this.controlContainerItem19.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem19.Name = "controlContainerItem19";
            // 
            // controlContainerItem34
            // 
            this.controlContainerItem34.AllowItemResize = false;
            this.controlContainerItem34.Control = this.lwsum;
            this.controlContainerItem34.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem34.Name = "controlContainerItem34";
            // 
            // controlContainerItem35
            // 
            this.controlContainerItem35.AllowItemResize = false;
            this.controlContainerItem35.Control = this.label2;
            this.controlContainerItem35.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem35.Name = "controlContainerItem35";
            // 
            // controlContainerItem33
            // 
            this.controlContainerItem33.AllowItemResize = false;
            this.controlContainerItem33.Control = this.nowdo;
            this.controlContainerItem33.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem33.Name = "controlContainerItem33";
            // 
            // godestop
            // 
            this.godestop.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.godestop.BackColor = System.Drawing.Color.Transparent;
            this.btip.SetBalloonCaption(this.godestop, "提示");
            this.btip.SetBalloonText(this.godestop, "返回桌面");
            this.godestop.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            this.godestop.FocusCuesEnabled = false;
            this.godestop.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold);
            this.godestop.Location = new System.Drawing.Point(127, 2);
            this.godestop.Name = "godestop";
            this.godestop.Size = new System.Drawing.Size(25, 25);
            this.godestop.Symbol = "";
            this.godestop.SymbolColor = System.Drawing.Color.White;
            this.godestop.SymbolSize = 9F;
            this.godestop.TabIndex = 147;
            this.godestop.Click += new System.EventHandler(this.godestop_Click);
            // 
            // panelplayer
            // 
            this.panelplayer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelplayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.panelplayer.Controls.Add(this.volumevalue);
            this.panelplayer.Controls.Add(this.playbutton);
            this.panelplayer.Controls.Add(this.volumeslider);
            this.panelplayer.Controls.Add(this.repeatplay);
            this.panelplayer.Controls.Add(this.looklrc);
            this.panelplayer.Controls.Add(this.looksametxt);
            this.panelplayer.Controls.Add(this.coverl1);
            this.panelplayer.Controls.Add(this.player);
            this.panelplayer.ForeColor = System.Drawing.Color.Black;
            this.panelplayer.Location = new System.Drawing.Point(0, 0);
            this.panelplayer.Name = "panelplayer";
            this.panelplayer.Size = new System.Drawing.Size(946, 41);
            this.panelplayer.TabIndex = 0;
            // 
            // volumevalue
            // 
            this.volumevalue.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            // 
            // 
            // 
            this.volumevalue.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.volumevalue.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.volumevalue.ForeColor = System.Drawing.Color.DarkGray;
            this.volumevalue.Location = new System.Drawing.Point(30, 11);
            this.volumevalue.Name = "volumevalue";
            this.volumevalue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.volumevalue.Size = new System.Drawing.Size(29, 21);
            this.volumevalue.TabIndex = 155;
            this.volumevalue.Text = "100";
            // 
            // player
            // 
            this.player.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.player.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.player.Enabled = true;
            this.player.ForeColor = System.Drawing.Color.Black;
            this.player.Location = new System.Drawing.Point(-28, -3);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(1000, 45);
            this.player.TabIndex = 147;
            this.player.StatusChange += new System.EventHandler(this.player_StatusChange);
            // 
            // newfile
            // 
            this.newfile.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.newfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.newfile.BackColor = System.Drawing.Color.White;
            this.btip.SetBalloonCaption(this.newfile, "新建文件名为左框中字符串的文件");
            this.newfile.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.newfile.FocusCuesEnabled = false;
            this.newfile.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.newfile.Location = new System.Drawing.Point(718, 0);
            this.newfile.Name = "newfile";
            this.newfile.Size = new System.Drawing.Size(53, 25);
            this.newfile.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.savefile});
            this.newfile.SymbolSize = 10F;
            this.newfile.TabIndex = 141;
            this.newfile.Text = "新建";
            this.newfile.Click += new System.EventHandler(this.newfile_Click);
            // 
            // savefile
            // 
            this.savefile.GlobalItem = false;
            this.savefile.Name = "savefile";
            this.savefile.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2);
            this.savefile.Symbol = "";
            this.savefile.SymbolSize = 10F;
            this.savefile.Text = "保存";
            this.savefile.Tooltip = "保存当前文本";
            this.savefile.Click += new System.EventHandler(this.write_Click);
            // 
            // safeclose
            // 
            this.safeclose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.safeclose.BackColor = System.Drawing.Color.Transparent;
            this.safeclose.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            this.safeclose.FocusCuesEnabled = false;
            this.safeclose.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.safeclose.Location = new System.Drawing.Point(113, 5);
            this.safeclose.Name = "safeclose";
            this.safeclose.Size = new System.Drawing.Size(96, 23);
            this.safeclose.Symbol = "";
            this.safeclose.SymbolSize = 9F;
            this.safeclose.TabIndex = 147;
            this.safeclose.Text = "安全关闭";
            this.safeclose.Click += new System.EventHandler(this.safeclose_Click);
            // 
            // controlContainerItem3
            // 
            this.controlContainerItem3.AllowItemResize = false;
            this.controlContainerItem3.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem3.Name = "controlContainerItem3";
            // 
            // controlContainerItem21
            // 
            this.controlContainerItem21.AllowItemResize = false;
            this.controlContainerItem21.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem21.Name = "controlContainerItem21";
            // 
            // controlContainerItem20
            // 
            this.controlContainerItem20.AllowItemResize = false;
            this.controlContainerItem20.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem20.Name = "controlContainerItem20";
            // 
            // itemContainer1
            // 
            // 
            // 
            // 
            this.itemContainer1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer1.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemContainer1.Name = "itemContainer1";
            this.itemContainer1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.controlContainerItem22});
            // 
            // 
            // 
            this.itemContainer1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // controlContainerItem22
            // 
            this.controlContainerItem22.AllowItemResize = false;
            this.controlContainerItem22.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem22.Name = "controlContainerItem22";
            // 
            // dockContainerItem1
            // 
            this.dockContainerItem1.Name = "dockContainerItem1";
            this.dockContainerItem1.Text = "dockContainerItem1";
            // 
            // givetfirst
            // 
            this.givetfirst.Enabled = true;
            this.givetfirst.Interval = 1500;
            this.givetfirst.Tick += new System.EventHandler(this.givetimefirst_Tick);
            // 
            // controlContainerItem26
            // 
            this.controlContainerItem26.AllowItemResize = false;
            this.controlContainerItem26.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem26.Name = "controlContainerItem26";
            // 
            // controlContainerItem25
            // 
            this.controlContainerItem25.AllowItemResize = true;
            this.controlContainerItem25.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem25.Name = "controlContainerItem25";
            // 
            // btip
            // 
            this.btip.AlertAnimation = DevComponents.DotNetBar.eAlertAnimation.TopToBottom;
            this.btip.InitialDelay = 700;
            this.btip.ShowCloseButton = false;
            this.btip.Style = DevComponents.DotNetBar.eBallonStyle.Office2007Alert;
            // 
            // makecopy
            // 
            this.makecopy.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.makecopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btip.SetBalloonCaption(this.makecopy, "提示");
            this.btip.SetBalloonText(this.makecopy, "制作副本，文件名为：“<文件名> - 副本x”。x为当前目录下的x为最小正整数可得到的不重复的文件名");
            this.makecopy.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.makecopy.FocusCuesEnabled = false;
            this.makecopy.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.makecopy.Location = new System.Drawing.Point(631, 0);
            this.makecopy.Name = "makecopy";
            this.makecopy.Size = new System.Drawing.Size(50, 25);
            this.makecopy.TabIndex = 157;
            this.makecopy.Text = "副本";
            this.makecopy.Click += new System.EventHandler(this.makecopy_Click);
            // 
            // rename
            // 
            this.rename.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.rename.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rename.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btip.SetBalloonCaption(this.rename, "提示");
            this.btip.SetBalloonText(this.rename, "以左框中字符串为文件名重命名当前文件");
            this.rename.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.rename.FocusCuesEnabled = false;
            this.rename.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.rename.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rename.Location = new System.Drawing.Point(777, 0);
            this.rename.Name = "rename";
            this.rename.Size = new System.Drawing.Size(52, 25);
            this.rename.TabIndex = 107;
            this.rename.Text = "重命名";
            this.rename.Click += new System.EventHandler(this.rename_Click);
            // 
            // plus
            // 
            this.plus.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.plus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btip.SetBalloonCaption(this.plus, "提示");
            this.btip.SetBalloonText(this.plus, "在文件名的结尾添加“.txt”。");
            this.plus.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.plus.FocusCuesEnabled = false;
            this.plus.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.plus.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.plus.Location = new System.Drawing.Point(687, 0);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(25, 25);
            this.plus.Symbol = "";
            this.plus.SymbolSize = 10F;
            this.plus.TabIndex = 121;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // plusdate
            // 
            this.plusdate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.plusdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.plusdate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btip.SetBalloonCaption(this.plusdate, "提示");
            this.btip.SetBalloonText(this.plusdate, "在文件名中添加日期时间");
            this.plusdate.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.plusdate.FocusCuesEnabled = false;
            this.plusdate.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.plusdate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.plusdate.Location = new System.Drawing.Point(890, 0);
            this.plusdate.Name = "plusdate";
            this.plusdate.Size = new System.Drawing.Size(25, 25);
            this.plusdate.Symbol = "";
            this.plusdate.SymbolSize = 10F;
            this.plusdate.TabIndex = 124;
            this.plusdate.Click += new System.EventHandler(this.plusdate_Click);
            // 
            // filetag
            // 
            this.filetag.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.filetag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btip.SetBalloonCaption(this.filetag, "提示");
            this.btip.SetBalloonText(this.filetag, "显示当前文件的标签");
            this.filetag.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.filetag.FocusCuesEnabled = false;
            this.filetag.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.filetag.Location = new System.Drawing.Point(835, 0);
            this.filetag.Name = "filetag";
            this.filetag.Size = new System.Drawing.Size(50, 25);
            this.filetag.TabIndex = 157;
            this.filetag.Text = "标签";
            this.filetag.Click += new System.EventHandler(this.filetag_Click);
            // 
            // lastdir
            // 
            this.lastdir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.lastdir.BackColor = System.Drawing.Color.Transparent;
            this.btip.SetBalloonCaption(this.lastdir, "提示");
            this.btip.SetBalloonText(this.lastdir, "返回上一次目录");
            this.lastdir.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            this.lastdir.FocusCuesEnabled = false;
            this.lastdir.Location = new System.Drawing.Point(65, 2);
            this.lastdir.Name = "lastdir";
            this.lastdir.Size = new System.Drawing.Size(25, 25);
            this.lastdir.Symbol = "";
            this.lastdir.SymbolColor = System.Drawing.Color.White;
            this.lastdir.SymbolSize = 10F;
            this.lastdir.TabIndex = 170;
            this.lastdir.Click += new System.EventHandler(this.lastdir_Click);
            // 
            // rogbin
            // 
            this.rogbin.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.rogbin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rogbin.BackColor = System.Drawing.Color.Transparent;
            this.rogbin.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            this.rogbin.FocusCuesEnabled = false;
            this.rogbin.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.rogbin.Location = new System.Drawing.Point(1025, 5);
            this.rogbin.Name = "rogbin";
            this.rogbin.Size = new System.Drawing.Size(86, 23);
            this.rogbin.Symbol = "";
            this.rogbin.SymbolSize = 9F;
            this.rogbin.TabIndex = 156;
            this.rogbin.Text = "回收站";
            this.rogbin.Click += new System.EventHandler(this.rogbin_Click);
            // 
            // dockContainerItem2
            // 
            this.dockContainerItem2.Name = "dockContainerItem2";
            this.dockContainerItem2.Text = "dockContainerItem2";
            // 
            // dockContainerItem4
            // 
            this.dockContainerItem4.Name = "dockContainerItem4";
            this.dockContainerItem4.Text = "文件浏览与修改";
            // 
            // line1
            // 
            this.line1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.line1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.line1.ForeColor = System.Drawing.Color.DarkGray;
            this.line1.Location = new System.Drawing.Point(0, 0);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(624, 1);
            this.line1.TabIndex = 151;
            // 
            // line4
            // 
            this.line4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.line4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.line4.ForeColor = System.Drawing.Color.DarkGray;
            this.line4.Location = new System.Drawing.Point(0, 24);
            this.line4.Name = "line4";
            this.line4.Size = new System.Drawing.Size(624, 1);
            this.line4.TabIndex = 151;
            // 
            // line2
            // 
            this.line2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.line2.ForeColor = System.Drawing.Color.DarkGray;
            this.line2.Location = new System.Drawing.Point(0, 0);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(1, 25);
            this.line2.TabIndex = 152;
            this.line2.VerticalLine = true;
            // 
            // paneltxt
            // 
            this.paneltxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paneltxt.BackColor = System.Drawing.Color.White;
            this.paneltxt.Controls.Add(this.line7);
            this.paneltxt.Controls.Add(this.line8);
            this.paneltxt.Controls.Add(this.line5);
            this.paneltxt.Controls.Add(this.line6);
            this.paneltxt.Controls.Add(this.imgv);
            this.paneltxt.Controls.Add(this.lrcv);
            this.paneltxt.Controls.Add(this.rename);
            this.paneltxt.Controls.Add(this.newfile);
            this.paneltxt.Controls.Add(this.makecopy);
            this.paneltxt.Controls.Add(this.filetag);
            this.paneltxt.Controls.Add(this.line2);
            this.paneltxt.Controls.Add(this.filenote);
            this.paneltxt.Controls.Add(this.plusdate);
            this.paneltxt.Controls.Add(this.line1);
            this.paneltxt.Controls.Add(this.plus);
            this.paneltxt.Controls.Add(this.line3);
            this.paneltxt.Controls.Add(this.line4);
            this.paneltxt.Controls.Add(this.filename);
            this.paneltxt.ForeColor = System.Drawing.Color.Black;
            this.paneltxt.Location = new System.Drawing.Point(0, 35);
            this.paneltxt.Name = "paneltxt";
            this.paneltxt.Size = new System.Drawing.Size(946, 547);
            this.paneltxt.TabIndex = 154;
            // 
            // line7
            // 
            this.line7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.line7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.line7.ForeColor = System.Drawing.Color.DarkGray;
            this.line7.Location = new System.Drawing.Point(0, 546);
            this.line7.Name = "line7";
            this.line7.Size = new System.Drawing.Size(946, 1);
            this.line7.TabIndex = 161;
            // 
            // line8
            // 
            this.line8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.line8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.line8.ForeColor = System.Drawing.Color.DarkGray;
            this.line8.Location = new System.Drawing.Point(945, 27);
            this.line8.Name = "line8";
            this.line8.Size = new System.Drawing.Size(1, 520);
            this.line8.TabIndex = 162;
            this.line8.VerticalLine = true;
            // 
            // line5
            // 
            this.line5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.line5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.line5.ForeColor = System.Drawing.Color.DarkGray;
            this.line5.Location = new System.Drawing.Point(0, 27);
            this.line5.Name = "line5";
            this.line5.Size = new System.Drawing.Size(946, 1);
            this.line5.TabIndex = 159;
            // 
            // line6
            // 
            this.line6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.line6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.line6.ForeColor = System.Drawing.Color.DarkGray;
            this.line6.Location = new System.Drawing.Point(0, 27);
            this.line6.Name = "line6";
            this.line6.Size = new System.Drawing.Size(1, 520);
            this.line6.TabIndex = 160;
            this.line6.VerticalLine = true;
            // 
            // imgv
            // 
            this.imgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imgv.Location = new System.Drawing.Point(0, 27);
            this.imgv.Name = "imgv";
            this.imgv.Size = new System.Drawing.Size(946, 520);
            this.imgv.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgv.TabIndex = 163;
            this.imgv.TabStop = false;
            // 
            // lrcv
            // 
            this.lrcv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lrcv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lrcv.ContextMenuStrip = this.infilemenu;
            this.lrcv.Font = new System.Drawing.Font("SimSun", 12F);
            this.lrcv.Location = new System.Drawing.Point(0, 27);
            this.lrcv.Name = "lrcv";
            this.lrcv.Size = new System.Drawing.Size(946, 520);
            this.lrcv.TabIndex = 158;
            this.lrcv.Text = "";
            this.lrcv.SelectionChanged += new System.EventHandler(this.lrcv_SelectionChanged);
            this.lrcv.TextChanged += new System.EventHandler(this.lrcv_TextChanged);
            this.lrcv.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lrcv_KeyDown);
            this.lrcv.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lrcv_MouseUp);
            // 
            // infilemenu
            // 
            this.infilemenu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infilemenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.infilemenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addate,
            this.查找ToolStripMenuItem,
            this.文本操作ToolStripMenuItem});
            this.infilemenu.Name = "infilemenu";
            this.infilemenu.Size = new System.Drawing.Size(149, 82);
            // 
            // addate
            // 
            this.addate.Image = global::CW_File_Viewer_5.Properties.Resources.date;
            this.addate.Name = "addate";
            this.addate.Size = new System.Drawing.Size(148, 26);
            this.addate.Text = "复制日期";
            this.addate.Click += new System.EventHandler(this.addate_Click);
            // 
            // filenote
            // 
            this.filenote.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.filenote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.filenote.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.filenote.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.filenote.FocusCuesEnabled = false;
            this.filenote.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.filenote.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.filenote.Location = new System.Drawing.Point(921, 0);
            this.filenote.Name = "filenote";
            this.filenote.Size = new System.Drawing.Size(25, 25);
            this.filenote.Symbol = "";
            this.filenote.SymbolSize = 10F;
            this.filenote.TabIndex = 124;
            this.filenote.Click += new System.EventHandler(this.filenote_Click);
            // 
            // line3
            // 
            this.line3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.line3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.line3.ForeColor = System.Drawing.Color.DarkGray;
            this.line3.Location = new System.Drawing.Point(624, 0);
            this.line3.Name = "line3";
            this.line3.Size = new System.Drawing.Size(1, 25);
            this.line3.TabIndex = 155;
            this.line3.VerticalLine = true;
            // 
            // filename
            // 
            this.filename.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filename.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.filename.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.filename.DisabledBackColor = System.Drawing.Color.White;
            this.filename.Font = new System.Drawing.Font("SimSun", 9F);
            this.filename.ForeColor = System.Drawing.Color.Black;
            this.filename.Location = new System.Drawing.Point(1, 4);
            this.filename.MaxLength = 2147483647;
            this.filename.Name = "filename";
            this.filename.Size = new System.Drawing.Size(624, 19);
            this.filename.TabIndex = 134;
            this.filename.WatermarkColor = System.Drawing.SystemColors.ControlDark;
            this.filename.WatermarkText = "文件名";
            this.filename.TextChanged += new System.EventHandler(this.filename_TextChanged);
            // 
            // filecontrolbar
            // 
            this.filecontrolbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(142)))), ((int)(((byte)(0)))));
            this.filecontrolbar.Controls.Add(this.filevname);
            this.filecontrolbar.Controls.Add(this.refresh);
            this.filecontrolbar.Controls.Add(this.todirc);
            this.filecontrolbar.Controls.Add(this.back);
            this.filecontrolbar.Controls.Add(this.todirf);
            this.filecontrolbar.Controls.Add(this.todire);
            this.filecontrolbar.Controls.Add(this.todird);
            this.filecontrolbar.Controls.Add(this.cancelsearch);
            this.filecontrolbar.Controls.Add(this.searchfilev);
            this.filecontrolbar.Controls.Add(this.godestop);
            this.filecontrolbar.Controls.Add(this.lastdir);
            this.filecontrolbar.Controls.Add(this.next);
            this.filecontrolbar.Location = new System.Drawing.Point(-280, 161);
            this.filecontrolbar.Name = "filecontrolbar";
            this.filecontrolbar.Size = new System.Drawing.Size(290, 56);
            this.filecontrolbar.TabIndex = 160;
            this.filecontrolbar.Click += new System.EventHandler(this.filecontrolbar_Click);
            this.filecontrolbar.Paint += new System.Windows.Forms.PaintEventHandler(this.filecontrolbar_Paint);
            this.filecontrolbar.MouseEnter += new System.EventHandler(this.filecontrolbar_MouseEnter);
            // 
            // filevname
            // 
            this.filevname.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.filevname.Border.Class = "TextBoxBorder";
            this.filevname.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.filevname.DisabledBackColor = System.Drawing.Color.White;
            this.filevname.ForeColor = System.Drawing.Color.Black;
            this.filevname.Location = new System.Drawing.Point(4, 29);
            this.filevname.Name = "filevname";
            this.filevname.PreventEnterBeep = true;
            this.filevname.Size = new System.Drawing.Size(210, 25);
            this.filevname.TabIndex = 159;
            // 
            // todirc
            // 
            this.todirc.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.todirc.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.todirc.FocusCuesEnabled = false;
            this.todirc.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold);
            this.todirc.Location = new System.Drawing.Point(158, 2);
            this.todirc.Name = "todirc";
            this.todirc.Size = new System.Drawing.Size(25, 25);
            this.todirc.TabIndex = 159;
            this.todirc.Text = "C";
            this.todirc.Click += new System.EventHandler(this.todirc_Click);
            // 
            // cancelsearch
            // 
            this.cancelsearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cancelsearch.BackColor = System.Drawing.Color.Transparent;
            this.cancelsearch.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            this.cancelsearch.FocusCuesEnabled = false;
            this.cancelsearch.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold);
            this.cancelsearch.Location = new System.Drawing.Point(251, 29);
            this.cancelsearch.Name = "cancelsearch";
            this.cancelsearch.Size = new System.Drawing.Size(25, 25);
            this.cancelsearch.Symbol = "";
            this.cancelsearch.SymbolColor = System.Drawing.Color.White;
            this.cancelsearch.SymbolSize = 9F;
            this.cancelsearch.TabIndex = 147;
            this.cancelsearch.Click += new System.EventHandler(this.cancelsearch_Click);
            // 
            // searchfilev
            // 
            this.searchfilev.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.searchfilev.BackColor = System.Drawing.Color.Transparent;
            this.searchfilev.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            this.searchfilev.FocusCuesEnabled = false;
            this.searchfilev.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold);
            this.searchfilev.Location = new System.Drawing.Point(220, 29);
            this.searchfilev.Name = "searchfilev";
            this.searchfilev.Size = new System.Drawing.Size(25, 25);
            this.searchfilev.Symbol = "";
            this.searchfilev.SymbolColor = System.Drawing.Color.White;
            this.searchfilev.SymbolSize = 9F;
            this.searchfilev.TabIndex = 147;
            this.searchfilev.Click += new System.EventHandler(this.searchfilev_Click);
            // 
            // controlContainerItem42
            // 
            this.controlContainerItem42.AllowItemResize = false;
            this.controlContainerItem42.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem42.Name = "controlContainerItem42";
            // 
            // PGManager
            // 
            this.PGManager.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.F1);
            this.PGManager.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlC);
            this.PGManager.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlA);
            this.PGManager.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlV);
            this.PGManager.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlX);
            this.PGManager.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlZ);
            this.PGManager.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlY);
            this.PGManager.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.Del);
            this.PGManager.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.Ins);
            this.PGManager.BottomDockSite = this.dockSite4;
            this.PGManager.EnableFullSizeDock = false;
            this.PGManager.FillDockSite = this.dockSite9;
            this.PGManager.LeftDockSite = this.dockSite1;
            this.PGManager.ParentForm = this;
            this.PGManager.RightDockSite = this.dockSite2;
            this.PGManager.ShowResetButton = true;
            this.PGManager.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.PGManager.ToolbarBottomDockSite = this.dockSite8;
            this.PGManager.ToolbarLeftDockSite = this.dockSite5;
            this.PGManager.ToolbarRightDockSite = this.dockSite6;
            this.PGManager.ToolbarTopDockSite = this.dockSite7;
            this.PGManager.TopDockSite = this.dockSite3;
            // 
            // dockSite4
            // 
            this.dockSite4.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSite4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dockSite4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dockSite4.DocumentDockContainer = new DevComponents.DotNetBar.DocumentDockContainer();
            this.dockSite4.ForeColor = System.Drawing.Color.Black;
            this.dockSite4.Location = new System.Drawing.Point(5, 766);
            this.dockSite4.Name = "dockSite4";
            this.dockSite4.Size = new System.Drawing.Size(1374, 0);
            this.dockSite4.TabIndex = 163;
            this.dockSite4.TabStop = false;
            // 
            // dockSite9
            // 
            this.dockSite9.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSite9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dockSite9.Controls.Add(this.bar1);
            this.dockSite9.Controls.Add(this.bar2);
            this.dockSite9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dockSite9.DocumentDockContainer = new DevComponents.DotNetBar.DocumentDockContainer(new DevComponents.DotNetBar.DocumentBaseContainer[] {
            ((DevComponents.DotNetBar.DocumentBaseContainer)(new DevComponents.DotNetBar.DocumentBarContainer(this.bar2, 414, 568))),
            ((DevComponents.DotNetBar.DocumentBaseContainer)(new DevComponents.DotNetBar.DocumentBarContainer(this.bar1, 939, 568)))}, DevComponents.DotNetBar.eOrientation.Horizontal);
            this.dockSite9.ForeColor = System.Drawing.Color.Black;
            this.dockSite9.Location = new System.Drawing.Point(5, 131);
            this.dockSite9.Name = "dockSite9";
            this.dockSite9.Size = new System.Drawing.Size(1374, 613);
            this.dockSite9.TabIndex = 168;
            this.dockSite9.TabStop = false;
            // 
            // bar1
            // 
            this.bar1.AccessibleDescription = "DotNetBar Bar (bar1)";
            this.bar1.AccessibleName = "DotNetBar Bar";
            this.bar1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.bar1.AlwaysDisplayDockTab = true;
            this.bar1.BackColor = System.Drawing.Color.White;
            this.bar1.CanDockBottom = false;
            this.bar1.CanDockDocument = true;
            this.bar1.CanDockTop = false;
            this.bar1.Controls.Add(this.panelDockContainer2);
            this.bar1.DockTabAlignment = DevComponents.DotNetBar.eTabStripAlignment.Top;
            this.bar1.FadeEffect = true;
            this.bar1.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bar1.ForeColor = System.Drawing.Color.Black;
            this.bar1.HideFloatingInactive = false;
            this.bar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.dockContainerItem5});
            this.bar1.LayoutType = DevComponents.DotNetBar.eLayoutType.DockContainer;
            this.bar1.Location = new System.Drawing.Point(422, 0);
            this.bar1.Name = "bar1";
            this.bar1.SelectedDockTab = 0;
            this.bar1.Size = new System.Drawing.Size(952, 613);
            this.bar1.Stretch = true;
            this.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.bar1.TabIndex = 0;
            this.bar1.TabStop = false;
            // 
            // panelDockContainer2
            // 
            this.panelDockContainer2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.panelDockContainer2.Controls.Add(this.paneltxt);
            this.panelDockContainer2.Controls.Add(this.panelplayer);
            this.panelDockContainer2.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelDockContainer2.Location = new System.Drawing.Point(3, 28);
            this.panelDockContainer2.Name = "panelDockContainer2";
            this.panelDockContainer2.Size = new System.Drawing.Size(946, 582);
            this.panelDockContainer2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelDockContainer2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.panelDockContainer2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.panelDockContainer2.Style.GradientAngle = 90;
            this.panelDockContainer2.TabIndex = 2;
            // 
            // dockContainerItem5
            // 
            this.dockContainerItem5.Control = this.panelDockContainer2;
            this.dockContainerItem5.Name = "dockContainerItem5";
            this.dockContainerItem5.Text = "声音控制及文本操作";
            // 
            // bar2
            // 
            this.bar2.AccessibleDescription = "DotNetBar Bar (bar2)";
            this.bar2.AccessibleName = "DotNetBar Bar";
            this.bar2.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.bar2.AlwaysDisplayDockTab = true;
            this.bar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bar2.CanDockBottom = false;
            this.bar2.CanDockDocument = true;
            this.bar2.CanDockTop = false;
            this.bar2.Controls.Add(this.panelDockContainer1);
            this.bar2.DockTabAlignment = DevComponents.DotNetBar.eTabStripAlignment.Top;
            this.bar2.FadeEffect = true;
            this.bar2.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bar2.ForeColor = System.Drawing.Color.Black;
            this.bar2.HideFloatingInactive = false;
            this.bar2.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.dockContainerItem3});
            this.bar2.LayoutType = DevComponents.DotNetBar.eLayoutType.DockContainer;
            this.bar2.Location = new System.Drawing.Point(0, 0);
            this.bar2.MenuBar = true;
            this.bar2.Name = "bar2";
            this.bar2.SelectedDockTab = 0;
            this.bar2.Size = new System.Drawing.Size(419, 613);
            this.bar2.Stretch = true;
            this.bar2.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.bar2.TabIndex = 1;
            this.bar2.TabStop = false;
            // 
            // panelDockContainer1
            // 
            this.panelDockContainer1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.panelDockContainer1.Controls.Add(this.panelfile);
            this.panelDockContainer1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelDockContainer1.Location = new System.Drawing.Point(3, 28);
            this.panelDockContainer1.Name = "panelDockContainer1";
            this.panelDockContainer1.Size = new System.Drawing.Size(413, 582);
            this.panelDockContainer1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelDockContainer1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.panelDockContainer1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.panelDockContainer1.Style.GradientAngle = 90;
            this.panelDockContainer1.TabIndex = 0;
            // 
            // dockContainerItem3
            // 
            this.dockContainerItem3.Control = this.panelDockContainer1;
            this.dockContainerItem3.Name = "dockContainerItem3";
            this.dockContainerItem3.Text = "文件浏览";
            // 
            // dockSite1
            // 
            this.dockSite1.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSite1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dockSite1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dockSite1.DocumentDockContainer = new DevComponents.DotNetBar.DocumentDockContainer();
            this.dockSite1.ForeColor = System.Drawing.Color.Black;
            this.dockSite1.Location = new System.Drawing.Point(5, 131);
            this.dockSite1.Name = "dockSite1";
            this.dockSite1.Size = new System.Drawing.Size(0, 613);
            this.dockSite1.TabIndex = 160;
            this.dockSite1.TabStop = false;
            // 
            // dockSite2
            // 
            this.dockSite2.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSite2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dockSite2.Dock = System.Windows.Forms.DockStyle.Right;
            this.dockSite2.DocumentDockContainer = new DevComponents.DotNetBar.DocumentDockContainer();
            this.dockSite2.ForeColor = System.Drawing.Color.Black;
            this.dockSite2.Location = new System.Drawing.Point(1379, 131);
            this.dockSite2.Name = "dockSite2";
            this.dockSite2.Size = new System.Drawing.Size(0, 613);
            this.dockSite2.TabIndex = 161;
            this.dockSite2.TabStop = false;
            // 
            // dockSite8
            // 
            this.dockSite8.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSite8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dockSite8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dockSite8.ForeColor = System.Drawing.Color.Black;
            this.dockSite8.Location = new System.Drawing.Point(5, 766);
            this.dockSite8.Name = "dockSite8";
            this.dockSite8.Size = new System.Drawing.Size(1374, 0);
            this.dockSite8.TabIndex = 167;
            this.dockSite8.TabStop = false;
            // 
            // dockSite5
            // 
            this.dockSite5.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSite5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dockSite5.Dock = System.Windows.Forms.DockStyle.Left;
            this.dockSite5.ForeColor = System.Drawing.Color.Black;
            this.dockSite5.Location = new System.Drawing.Point(5, 1);
            this.dockSite5.Name = "dockSite5";
            this.dockSite5.Size = new System.Drawing.Size(0, 765);
            this.dockSite5.TabIndex = 164;
            this.dockSite5.TabStop = false;
            // 
            // dockSite6
            // 
            this.dockSite6.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSite6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dockSite6.Dock = System.Windows.Forms.DockStyle.Right;
            this.dockSite6.ForeColor = System.Drawing.Color.Black;
            this.dockSite6.Location = new System.Drawing.Point(1379, 1);
            this.dockSite6.Name = "dockSite6";
            this.dockSite6.Size = new System.Drawing.Size(0, 765);
            this.dockSite6.TabIndex = 165;
            this.dockSite6.TabStop = false;
            // 
            // dockSite7
            // 
            this.dockSite7.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSite7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dockSite7.Dock = System.Windows.Forms.DockStyle.Top;
            this.dockSite7.ForeColor = System.Drawing.Color.Black;
            this.dockSite7.Location = new System.Drawing.Point(5, 1);
            this.dockSite7.Name = "dockSite7";
            this.dockSite7.Size = new System.Drawing.Size(1374, 0);
            this.dockSite7.TabIndex = 166;
            this.dockSite7.TabStop = false;
            // 
            // dockSite3
            // 
            this.dockSite3.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSite3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dockSite3.Dock = System.Windows.Forms.DockStyle.Top;
            this.dockSite3.DocumentDockContainer = new DevComponents.DotNetBar.DocumentDockContainer();
            this.dockSite3.ForeColor = System.Drawing.Color.Black;
            this.dockSite3.Location = new System.Drawing.Point(5, 1);
            this.dockSite3.Name = "dockSite3";
            this.dockSite3.Size = new System.Drawing.Size(1374, 0);
            this.dockSite3.TabIndex = 162;
            this.dockSite3.TabStop = false;
            // 
            // fpcrumb
            // 
            this.fpcrumb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fpcrumb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.fpcrumb.BackgroundStyle.Class = "CrumbBarBackgroundKey";
            this.fpcrumb.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.fpcrumb.ContainerControlProcessDialogKey = true;
            this.fpcrumb.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.fpcrumb.ForeColor = System.Drawing.Color.Black;
            this.fpcrumb.Location = new System.Drawing.Point(246, 32);
            this.fpcrumb.Name = "fpcrumb";
            this.fpcrumb.PathSeparator = ";";
            this.fpcrumb.Size = new System.Drawing.Size(1032, 22);
            this.fpcrumb.Style = DevComponents.DotNetBar.eCrumbBarStyle.Office2007;
            this.fpcrumb.TabIndex = 172;
            this.fpcrumb.SelectedItemChanging += new DevComponents.DotNetBar.CrumBarSelectionEventHandler(this.fpcrumb_SelectedItemChanging);
            this.fpcrumb.DoubleClick += new System.EventHandler(this.fpcrumb_DoubleClick);
            // 
            // controlContainerItem15
            // 
            this.controlContainerItem15.AllowItemResize = false;
            this.controlContainerItem15.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem15.Name = "controlContainerItem15";
            // 
            // controlContainerItem4
            // 
            this.controlContainerItem4.AllowItemResize = false;
            this.controlContainerItem4.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem4.Name = "controlContainerItem4";
            // 
            // controlContainerItem5
            // 
            this.controlContainerItem5.AllowItemResize = false;
            this.controlContainerItem5.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem5.Name = "controlContainerItem5";
            // 
            // collectionbar
            // 
            this.collectionbar.AccessibleDescription = "DotNetBar Bar (collectionbar)";
            this.collectionbar.AccessibleName = "DotNetBar Bar";
            this.collectionbar.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar;
            this.collectionbar.AntiAlias = true;
            this.collectionbar.BackColor = System.Drawing.Color.White;
            this.collectionbar.ContextMenuStrip = this.collectionrightmenu;
            this.collectionbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.collectionbar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.collectionbar.Location = new System.Drawing.Point(5, 131);
            this.collectionbar.MaximumSize = new System.Drawing.Size(0, 25);
            this.collectionbar.Name = "collectionbar";
            this.collectionbar.Size = new System.Drawing.Size(1374, 25);
            this.collectionbar.Stretch = true;
            this.collectionbar.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.collectionbar.TabIndex = 2;
            this.collectionbar.TabStop = false;
            this.collectionbar.BarStateChanged += new DevComponents.DotNetBar.BarStateChangedEventHandler(this.collectionbar_BarStateChanged);
            this.collectionbar.SizeChanged += new System.EventHandler(this.collectionbar_SizeChanged);
            // 
            // collectionrightmenu
            // 
            this.collectionrightmenu.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.collectionrightmenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.collectionrightmenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.delcollection});
            this.collectionrightmenu.Name = "collectionrightmenu";
            this.collectionrightmenu.Size = new System.Drawing.Size(117, 30);
            // 
            // delcollection
            // 
            this.delcollection.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.delcollection.Image = global::CW_File_Viewer_5.Properties.Resources.delete;
            this.delcollection.Name = "delcollection";
            this.delcollection.Size = new System.Drawing.Size(116, 26);
            this.delcollection.Text = "删除";
            this.delcollection.Click += new System.EventHandler(this.delcollection_Click);
            // 
            // tocollection
            // 
            this.tocollection.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.tocollection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tocollection.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.tocollection.FocusCuesEnabled = false;
            this.tocollection.Location = new System.Drawing.Point(1284, 32);
            this.tocollection.Name = "tocollection";
            this.tocollection.Size = new System.Drawing.Size(24, 22);
            this.tocollection.Symbol = "";
            this.tocollection.SymbolSize = 10F;
            this.tocollection.TabIndex = 174;
            this.tocollection.Click += new System.EventHandler(this.tocollection_Click);
            // 
            // rangeValidator1
            // 
            this.rangeValidator1.ErrorMessage = "Your error message here.";
            this.rangeValidator1.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // requiredFieldValidator1
            // 
            this.requiredFieldValidator1.ErrorMessage = "Your error message here.";
            this.requiredFieldValidator1.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // requiredFieldValidator2
            // 
            this.requiredFieldValidator2.ErrorMessage = "Your error message here.";
            this.requiredFieldValidator2.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // requiredFieldValidator3
            // 
            this.requiredFieldValidator3.ErrorMessage = "Your error message here.";
            this.requiredFieldValidator3.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // controlContainerItem44
            // 
            this.controlContainerItem44.AllowItemResize = false;
            this.controlContainerItem44.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem44.Name = "controlContainerItem44";
            // 
            // controlContainerItem46
            // 
            this.controlContainerItem46.AllowItemResize = false;
            this.controlContainerItem46.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem46.Name = "controlContainerItem46";
            // 
            // controlContainerItem45
            // 
            this.controlContainerItem45.AllowItemResize = false;
            this.controlContainerItem45.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem45.Name = "controlContainerItem45";
            // 
            // controlContainerItem43
            // 
            this.controlContainerItem43.AllowItemResize = false;
            this.controlContainerItem43.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem43.Name = "controlContainerItem43";
            // 
            // controlContainerItem38
            // 
            this.controlContainerItem38.AllowItemResize = false;
            this.controlContainerItem38.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem38.Name = "controlContainerItem38";
            // 
            // filect
            // 
            this.filect.Interval = 500;
            this.filect.Tick += new System.EventHandler(this.filect_Tick);
            // 
            // fcpst
            // 
            this.fcpst.Interval = 5;
            this.fcpst.Tick += new System.EventHandler(this.fcpst_Tick);
            // 
            // closingt
            // 
            this.closingt.Tick += new System.EventHandler(this.closingt_Tick);
            // 
            // autosave
            // 
            this.autosave.Interval = 100000;
            this.autosave.Tick += new System.EventHandler(this.autosave_Tick);
            // 
            // backt
            // 
            this.backt.Tick += new System.EventHandler(this.backt_Tick);
            // 
            // lrcvfocuser
            // 
            this.lrcvfocuser.Tick += new System.EventHandler(this.lrcvfocuser_Tick);
            // 
            // 查找ToolStripMenuItem
            // 
            this.查找ToolStripMenuItem.Name = "查找ToolStripMenuItem";
            this.查找ToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.查找ToolStripMenuItem.Text = "查找";
            this.查找ToolStripMenuItem.Click += new System.EventHandler(this.查找ToolStripMenuItem_Click);
            // 
            // 文本操作ToolStripMenuItem
            // 
            this.文本操作ToolStripMenuItem.Name = "文本操作ToolStripMenuItem";
            this.文本操作ToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.文本操作ToolStripMenuItem.Text = "文本操作";
            this.文本操作ToolStripMenuItem.Click += new System.EventHandler(this.文本操作ToolStripMenuItem_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1384, 768);
            this.Controls.Add(this.superTabControl1);
            this.Controls.Add(this.tocollection);
            this.Controls.Add(this.filecontrolbar);
            this.Controls.Add(this.collectionbar);
            this.Controls.Add(this.fpcrumb);
            this.Controls.Add(this.filepath);
            this.Controls.Add(this.dockSite9);
            this.Controls.Add(this.dockSite2);
            this.Controls.Add(this.dockSite1);
            this.Controls.Add(this.rogbin);
            this.Controls.Add(this.safeclose);
            this.Controls.Add(this.go);
            this.Controls.Add(this.fullscr);
            this.Controls.Add(this.bhistory);
            this.Controls.Add(this.viewfile);
            this.Controls.Add(this.metroStatusBar1);
            this.Controls.Add(this.ribbar);
            this.Controls.Add(this.dockSite3);
            this.Controls.Add(this.dockSite4);
            this.Controls.Add(this.dockSite5);
            this.Controls.Add(this.dockSite6);
            this.Controls.Add(this.dockSite7);
            this.Controls.Add(this.dockSite8);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CW File Viewer 5.6.6";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.SizeChanged += new System.EventHandler(this.FrmMain_SizeChanged);
            this.rightmenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.wtsize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabv)).EndInit();
            this.tabv.ResumeLayout(false);
            this.tabControlPanel1.ResumeLayout(false);
            this.tabControlPanel3.ResumeLayout(false);
            this.tabControlPanel2.ResumeLayout(false);
            this.ribbar.ResumeLayout(false);
            this.ribbar.PerformLayout();
            this.ribbonPanel1.ResumeLayout(false);
            this.ribbonBar6.ResumeLayout(false);
            this.ribbonBar3.ResumeLayout(false);
            this.ribbonBar2.ResumeLayout(false);
            this.ribbonBar1.ResumeLayout(false);
            this.ribbonPanel2.ResumeLayout(false);
            this.ribbonBar11.ResumeLayout(false);
            this.ribbonBar10.ResumeLayout(false);
            this.ribbonBar9.ResumeLayout(false);
            this.ribbonBar8.ResumeLayout(false);
            this.ribbonBar7.ResumeLayout(false);
            this.ribbonBar5.ResumeLayout(false);
            this.ribbonBar4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.superTabControl1)).EndInit();
            this.superTabControl1.ResumeLayout(false);
            this.superTabControlPanel1.ResumeLayout(false);
            this.superTabControlPanel2.ResumeLayout(false);
            this.superTabControlPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.autost)).EndInit();
            this.panelfile.ResumeLayout(false);
            this.metroStatusBar1.ResumeLayout(false);
            this.metroStatusBar1.PerformLayout();
            this.panelplayer.ResumeLayout(false);
            this.panelplayer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.paneltxt.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgv)).EndInit();
            this.infilemenu.ResumeLayout(false);
            this.filecontrolbar.ResumeLayout(false);
            this.dockSite9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            this.bar1.ResumeLayout(false);
            this.panelDockContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bar2)).EndInit();
            this.bar2.ResumeLayout(false);
            this.panelDockContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.collectionbar)).EndInit();
            this.collectionrightmenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ImageList imageList2;
        public System.Windows.Forms.ImageList imageList1;
        public System.Windows.Forms.ImageList imageList3;
        public DevComponents.DotNetBar.TabControlPanel tabControlPanel2;
        public System.Windows.Forms.ListView filev2;
        public System.Windows.Forms.ColumnHeader lfsum2;
        public DevComponents.Editors.IntegerInput wtsize;
        public DevComponents.DotNetBar.ButtonX back;
        public DevComponents.DotNetBar.Controls.TextBoxX filepath;
        public DevComponents.DotNetBar.ButtonX go;
        public DevComponents.DotNetBar.ButtonX bhistory;
        public DevComponents.DotNetBar.ButtonX todirf;
        public DevComponents.DotNetBar.ButtonX todird;
        public DevComponents.DotNetBar.ButtonX todire;
        public System.Windows.Forms.Label label1;
        public DevComponents.DotNetBar.ButtonX toolsbox;
        public DevComponents.DotNetBar.ButtonX batch;
        public DevComponents.DotNetBar.ButtonX past;
        public DevComponents.DotNetBar.ButtonX copy;
        public DevComponents.DotNetBar.ButtonX refresh;
        public DevComponents.DotNetBar.ButtonX next;
        public DevComponents.DotNetBar.ButtonX viewfile;
        public DevComponents.DotNetBar.ButtonX cut;
        public DevComponents.DotNetBar.ButtonX del;
        public System.Windows.Forms.FolderBrowserDialog fbroser;
        public System.Windows.Forms.ColumnHeader columnHeader1;
        public System.Windows.Forms.ColumnHeader columnHeader3;
        public System.Windows.Forms.ColumnHeader columnHeader2;
        public DevComponents.DotNetBar.StyleManager styleManager;
        public System.Windows.Forms.ToolStripMenuItem rbdel;
        public System.Windows.Forms.ContextMenuStrip rightmenu;
        public System.Windows.Forms.Timer nowdoti;
        public DevComponents.DotNetBar.ButtonX fullscr;
        public DevComponents.DotNetBar.ButtonX fssmall;
        public DevComponents.DotNetBar.ButtonX fsbig;
        public DevComponents.DotNetBar.RibbonControl ribbar;
        public DevComponents.DotNetBar.RibbonPanel ribbonPanel1;
        public DevComponents.DotNetBar.RibbonBar ribbonBar1;
        public DevComponents.DotNetBar.ApplicationButton applicationButton1;
        public DevComponents.DotNetBar.RibbonTabItem ribbonTabItem1;
        public System.Windows.Forms.Label lwsum;
        public System.Windows.Forms.Label label4;
        public DevComponents.DotNetBar.ControlContainerItem controlContainerItem1;
        public DevComponents.DotNetBar.RibbonBar ribbonBar2;
        public DevComponents.DotNetBar.RibbonBar ribbonBar3;
        public DevComponents.DotNetBar.ControlContainerItem controlContainerItem16;
        public DevComponents.DotNetBar.ItemContainer itemContainer8;
        public DevComponents.DotNetBar.ControlContainerItem controlContainerItem17;
        public DevComponents.DotNetBar.ControlContainerItem controlContainerItem18;
        public DevComponents.DotNetBar.Controls.CheckBoxX goodsort;
        public DevComponents.DotNetBar.ItemContainer itemContainer12;
        public DevComponents.DotNetBar.ItemContainer itemContainer13;
        public DevComponents.DotNetBar.ProgressBarItem nowprog;
        public DevComponents.DotNetBar.TabControl tabv;
        public DevComponents.DotNetBar.TabControlPanel tabControlPanel1;
        public System.Windows.Forms.ListView filev1;
        public System.Windows.Forms.ColumnHeader lfsum1;
        public DevComponents.DotNetBar.TabItem tab1;
        public DevComponents.DotNetBar.TabControlPanel tabControlPanel3;
        public System.Windows.Forms.ListView filev3;
        public System.Windows.Forms.ColumnHeader lfsum3;
        public DevComponents.DotNetBar.TabItem tab3;
        public DevComponents.DotNetBar.TabItem tab2;
        public DevComponents.DotNetBar.ControlContainerItem controlContainerItem3;
        public DevComponents.DotNetBar.ControlContainerItem controlContainerItem30;
        public DevComponents.DotNetBar.ControlContainerItem controlContainerItem29;
        public System.Windows.Forms.ToolStripMenuItem rbinfo;
        public System.Windows.Forms.ToolStripMenuItem rbcut;
        public System.Windows.Forms.ToolStripMenuItem rbcopy;
        public System.Windows.Forms.ToolStripMenuItem rbpast;
        public System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        public System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        public DevComponents.DotNetBar.MicroChartItem microChartItem1;
        public DevComponents.DotNetBar.Metro.MetroStatusBar metroStatusBar1;
        public DevComponents.DotNetBar.RibbonBar ribbonBar6;
        public DevComponents.DotNetBar.ButtonX Recovery;
        public System.Windows.Forms.Panel panelfile;
        public DevComponents.DotNetBar.ButtonX safeclose;
        public System.Windows.Forms.Label nowdo;
        public DevComponents.DotNetBar.ControlContainerItem controlContainerItem33;
        public DevComponents.DotNetBar.ButtonItem aboutcfv;
        public System.Windows.Forms.Label label2;
        public DevComponents.DotNetBar.ControlContainerItem controlContainerItem19;
        public DevComponents.DotNetBar.ControlContainerItem controlContainerItem34;
        public DevComponents.DotNetBar.ControlContainerItem controlContainerItem35;
        public DevComponents.DotNetBar.RibbonPanel ribbonPanel2;
        public DevComponents.DotNetBar.RibbonBar ribbonBar4;
        public DevComponents.DotNetBar.RibbonTabItem ribbonTabItem2;
        public DevComponents.DotNetBar.ControlContainerItem controlContainerItem21;
        public DevComponents.DotNetBar.ControlContainerItem controlContainerItem20;
        public DevComponents.DotNetBar.ButtonX add;
        public DevComponents.DotNetBar.ItemContainer itemContainer1;
        public DevComponents.DotNetBar.ControlContainerItem controlContainerItem22;
        public DevComponents.DotNetBar.ButtonX godestop;
        public DevComponents.DotNetBar.Controls.CheckBoxX usedic;
        public DevComponents.DotNetBar.DockContainerItem dockContainerItem1;
        public System.Windows.Forms.Timer givetfirst;
        public DevComponents.DotNetBar.Controls.CheckBoxX seevery;
        public System.Windows.Forms.Label txtstate;
        public DevComponents.DotNetBar.ControlContainerItem controlContainerItem13;
        public DevComponents.DotNetBar.ControlContainerItem controlContainerItem26;
        public DevComponents.DotNetBar.Controls.CheckBoxX userogbin;
        public DevComponents.DotNetBar.ControlContainerItem controlContainerItem25;
        public DevComponents.DotNetBar.BalloonTip btip;
        public DevComponents.DotNetBar.ButtonX rogbin;
        public DevComponents.DotNetBar.Controls.CheckBoxX repeatplay;
        public DevComponents.DotNetBar.ButtonX playbutton;
        public DevComponents.DotNetBar.Controls.Slider volumeslider;
        public DevComponents.DotNetBar.Controls.CheckBoxX looksametxt;
        public DevComponents.DotNetBar.Controls.CheckBoxX looklrc;
        public DevComponents.DotNetBar.LabelX coverl1;
        public AxWMPLib.AxWindowsMediaPlayer player;
        public DevComponents.DotNetBar.ButtonX rename;
        public DevComponents.DotNetBar.ButtonX newfile;
        public DevComponents.DotNetBar.ButtonX plus;
        public DevComponents.DotNetBar.ButtonX plusdate;
        public DevComponents.DotNetBar.Controls.Line line1;
        public DevComponents.DotNetBar.Controls.Line line4;
        public DevComponents.DotNetBar.Controls.Line line2;
        public DevComponents.DotNetBar.ControlContainerItem controlContainerItem15;
        public DevComponents.DotNetBar.ControlContainerItem controlContainerItem4;
        public DevComponents.DotNetBar.Controls.CheckBoxX onlyfolder;
        public DevComponents.DotNetBar.Controls.CheckBoxX openotherfile;
        public DevComponents.DotNetBar.ItemContainer itemContainer2;
        public DevComponents.DotNetBar.ControlContainerItem controlContainerItem6;
        public DevComponents.DotNetBar.ControlContainerItem controlContainerItem27;
        public DevComponents.DotNetBar.ItemContainer itemContainer3;
        public DevComponents.DotNetBar.ControlContainerItem controlContainerItem28;
        public DevComponents.DotNetBar.ControlContainerItem controlContainerItem36;
        public DevComponents.DotNetBar.ItemContainer itemContainer4;
        public DevComponents.DotNetBar.ControlContainerItem controlContainerItem5;
        public DevComponents.DotNetBar.ItemContainer itemContainer5;
        public DevComponents.DotNetBar.ControlContainerItem controlContainerItem39;
        public DevComponents.DotNetBar.ControlContainerItem controlContainerItem40;
        public DevComponents.DotNetBar.DockContainerItem dockContainerItem2;
        public DevComponents.DotNetBar.DockContainerItem dockContainerItem4;
        public System.Windows.Forms.Panel panelplayer;
        public System.Windows.Forms.Panel paneltxt;
        public DevComponents.DotNetBar.DotNetBarManager PGManager;
        public DevComponents.DotNetBar.DockSite dockSite4;
        public DevComponents.DotNetBar.DockSite dockSite9;
        public DevComponents.DotNetBar.Bar bar1;
        public DevComponents.DotNetBar.PanelDockContainer panelDockContainer1;
        public DevComponents.DotNetBar.PanelDockContainer panelDockContainer2;
        public DevComponents.DotNetBar.DockContainerItem dockContainerItem3;
        public DevComponents.DotNetBar.DockContainerItem dockContainerItem5;
        public DevComponents.DotNetBar.DockSite dockSite1;
        public DevComponents.DotNetBar.DockSite dockSite2;
        public DevComponents.DotNetBar.DockSite dockSite3;
        public DevComponents.DotNetBar.DockSite dockSite5;
        public DevComponents.DotNetBar.DockSite dockSite6;
        public DevComponents.DotNetBar.DockSite dockSite7;
        public DevComponents.DotNetBar.DockSite dockSite8;
        public DevComponents.DotNetBar.Bar bar2;
        public DevComponents.DotNetBar.ButtonX lastdir;
        public DevComponents.DotNetBar.SuperTabControl superTabControl1;
        public DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel4;
        public DevComponents.DotNetBar.CrumbBar fpcrumb;
        public DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel1;
        public DevComponents.DotNetBar.Controls.ReflectionLabel reflectionLabel2;
        public DevComponents.DotNetBar.LabelX labelX1;
        public DevComponents.DotNetBar.SuperTabItem superTabItem1;
        public DevComponents.DotNetBar.ControlContainerItem controlContainerItem32;
        public DevComponents.DotNetBar.Controls.CheckBoxX sortw2;
        public DevComponents.DotNetBar.Controls.CheckBoxX sortw1;
        private DevComponents.DotNetBar.Controls.CheckBoxX useprev;
        private DevComponents.DotNetBar.ControlContainerItem controlContainerItem2;
        private DevComponents.DotNetBar.ControlContainerItem controlContainerItem37;
        private DevComponents.DotNetBar.LabelX volumevalue;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem makesamefile;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel2;
        private DevComponents.DotNetBar.SuperTabItem 常规;
        private DevComponents.DotNetBar.Controls.CheckBoxX savenohint;
        private DevComponents.DotNetBar.Controls.CheckBoxX recoveryatfirst;
        private DevComponents.DotNetBar.Bar collectionbar;
        private System.Windows.Forms.ContextMenuStrip collectionrightmenu;
        private System.Windows.Forms.ToolStripMenuItem delcollection;
        private DevComponents.DotNetBar.ButtonX tocollection;
        private System.Windows.Forms.ToolStripMenuItem rbtocollection;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private DevComponents.DotNetBar.ButtonX filetag;
        private DevComponents.DotNetBar.ButtonX search;
        private DevComponents.DotNetBar.Validator.RangeValidator rangeValidator1;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator1;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator2;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator3;
        private DevComponents.DotNetBar.ButtonX makecopy;
        public DevComponents.DotNetBar.Controls.Line line3;
        private System.Windows.Forms.ContextMenuStrip infilemenu;
        private System.Windows.Forms.ToolStripMenuItem addate;
        private DevComponents.DotNetBar.RibbonBar ribbonBar5;
        private DevComponents.DotNetBar.ControlContainerItem controlContainerItem7;
        public DevComponents.DotNetBar.ButtonX ordertags;
        private DevComponents.DotNetBar.ControlContainerItem controlContainerItem44;
        private DevComponents.DotNetBar.ControlContainerItem controlContainerItem46;
        private DevComponents.DotNetBar.ControlContainerItem controlContainerItem45;
        private DevComponents.DotNetBar.ControlContainerItem controlContainerItem43;
        private DevComponents.DotNetBar.ControlContainerItem controlContainerItem38;
        private DevComponents.DotNetBar.ControlContainerItem controlContainerItem42;
        private DevComponents.DotNetBar.ButtonX todirc;
        private System.Windows.Forms.Panel filecontrolbar;
        private System.Windows.Forms.Timer filect;
        private DevComponents.DotNetBar.ButtonItem savefile;
        private System.Windows.Forms.Timer fcpst;
        private DevComponents.DotNetBar.RibbonBar ribbonBar7;
        private DevComponents.DotNetBar.ButtonX cleantag;
        private DevComponents.DotNetBar.ControlContainerItem controlContainerItem41;
        private System.Windows.Forms.Timer closingt;
        private DevComponents.DotNetBar.ButtonX tagpageman;
        private System.Windows.Forms.Timer autosave;
        private DevComponents.DotNetBar.LabelX textl1;
        private DevComponents.Editors.IntegerInput autost;
        private DevComponents.DotNetBar.Controls.CheckBoxX useast;
        private DevComponents.DotNetBar.RibbonBar ribbonBar8;
        private DevComponents.DotNetBar.ButtonX savestatenow;
        private DevComponents.DotNetBar.ControlContainerItem controlContainerItem48;
        private DevComponents.DotNetBar.ButtonX choosetagsys;
        private System.Windows.Forms.ToolStripMenuItem origfile;
        private DevComponents.DotNetBar.RibbonBar ribbonBar9;
        private DevComponents.DotNetBar.ButtonX embackup;
        private DevComponents.DotNetBar.ControlContainerItem controlContainerItem50;
        public DevComponents.DotNetBar.ButtonX filenote;
        private System.Windows.Forms.Timer backt;
        private DevComponents.DotNetBar.RibbonBar ribbonBar10;
        private DevComponents.DotNetBar.ButtonX ordertaginfo;
        private DevComponents.DotNetBar.ControlContainerItem controlContainerItem51;
        public System.Windows.Forms.RichTextBox lrcv;
        private DevComponents.DotNetBar.Controls.CheckBoxX filehighlight;
        private System.Windows.Forms.Timer lrcvfocuser;
        private DevComponents.DotNetBar.Controls.TextBoxX filevname;
        public DevComponents.DotNetBar.ButtonX cancelsearch;
        public DevComponents.DotNetBar.ButtonX searchfilev;
        private DevComponents.DotNetBar.RibbonBar ribbonBar11;
        private DevComponents.DotNetBar.ButtonX textwork;
        private DevComponents.DotNetBar.ControlContainerItem controlContainerItem52;
        private DevComponents.DotNetBar.Controls.ComboBoxEx tschooser;
        private DevComponents.DotNetBar.ControlContainerItem controlContainerItem53;
        public DevComponents.DotNetBar.Controls.Line line7;
        public DevComponents.DotNetBar.Controls.Line line6;
        public DevComponents.DotNetBar.Controls.Line line5;
        public DevComponents.DotNetBar.Controls.Line line8;
        private DevComponents.DotNetBar.Controls.CheckBoxX UseFormatForm;
        private DevComponents.DotNetBar.ControlContainerItem controlContainerItem47;
        private DevComponents.DotNetBar.ItemContainer itemContainer7;
        private DevComponents.DotNetBar.ControlContainerItem controlContainerItem23;
        private DevComponents.DotNetBar.ControlContainerItem controlContainerItem24;
        private DevComponents.DotNetBar.ItemContainer itemContainer6;
        public DevComponents.DotNetBar.Controls.CheckBoxX ShowNote;
        public DevComponents.DotNetBar.Controls.CheckBoxX ShowTXT;
        private DevComponents.DotNetBar.ControlContainerItem controlContainerItem54;
        private DevComponents.DotNetBar.ControlContainerItem controlContainerItem55;
        public DevComponents.DotNetBar.Controls.TextBoxX filename;
        private System.Windows.Forms.PictureBox imgv;
        private DevComponents.DotNetBar.ControlContainerItem controlContainerItem8;
        private DevComponents.DotNetBar.ControlContainerItem controlContainerItem9;
        private DevComponents.DotNetBar.ControlContainerItem controlContainerItem10;
        private DevComponents.DotNetBar.ControlContainerItem controlContainerItem11;
        private DevComponents.DotNetBar.ControlContainerItem controlContainerItem12;
        private DevComponents.DotNetBar.ControlContainerItem controlContainerItem14;
        private DevComponents.DotNetBar.ControlContainerItem controlContainerItem31;
        private DevComponents.DotNetBar.ControlContainerItem controlContainerItem49;
        private System.Windows.Forms.ToolStripMenuItem rbrename;
        private System.Windows.Forms.ToolStripMenuItem 查找ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 文本操作ToolStripMenuItem;

    }
}

