namespace CW_File_Viewer_5
{
    partial class FrmTag
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTag));
            this.addtag = new DevComponents.DotNetBar.ButtonX();
            this.addtagtoall = new DevComponents.DotNetBar.ButtonItem();
            this.tagname = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.trmenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.properties = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.deltag = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.clear = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.copytag = new System.Windows.Forms.ToolStripMenuItem();
            this.tabv = new DevComponents.DotNetBar.TabControl();
            this.addpage = new DevComponents.DotNetBar.ButtonX();
            this.addpagetoall = new DevComponents.DotNetBar.ButtonItem();
            this.pagename = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.highlighter = new DevComponents.DotNetBar.Validator.Highlighter();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.searchtext = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.line1 = new DevComponents.DotNetBar.Controls.Line();
            this.line2 = new DevComponents.DotNetBar.Controls.Line();
            this.buttonlayout = new System.Windows.Forms.FlowLayoutPanel();
            this.search = new DevComponents.DotNetBar.ButtonX();
            this.line3 = new DevComponents.DotNetBar.Controls.Line();
            this.showCheckedTag = new DevComponents.DotNetBar.ButtonX();
            this.line4 = new DevComponents.DotNetBar.Controls.Line();
            this.islocked = new DevComponents.DotNetBar.ButtonX();
            this.trmenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.buttonlayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // addtag
            // 
            this.addtag.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.addtag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addtag.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.addtag.FocusCuesEnabled = false;
            this.addtag.Location = new System.Drawing.Point(229, 3);
            this.addtag.Name = "addtag";
            this.addtag.Size = new System.Drawing.Size(80, 26);
            this.addtag.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.addtagtoall});
            this.addtag.TabIndex = 1;
            this.addtag.Text = "添加标签";
            this.addtag.Click += new System.EventHandler(this.addtag_Click);
            // 
            // addtagtoall
            // 
            this.addtagtoall.GlobalItem = false;
            this.addtagtoall.Name = "addtagtoall";
            this.addtagtoall.Text = "给所有标签系统添加";
            this.addtagtoall.Click += new System.EventHandler(this.addtag_Click);
            // 
            // tagname
            // 
            this.tagname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tagname.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tagname.Border.Class = "TextBoxBorder";
            this.tagname.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tagname.DisabledBackColor = System.Drawing.Color.White;
            this.tagname.ForeColor = System.Drawing.Color.Black;
            this.tagname.Location = new System.Drawing.Point(3, 3);
            this.tagname.Name = "tagname";
            this.tagname.PreventEnterBeep = true;
            this.tagname.Size = new System.Drawing.Size(220, 26);
            this.tagname.TabIndex = 2;
            this.tagname.WatermarkText = "请输入要添加的标签名";
            // 
            // trmenu
            // 
            this.trmenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.properties,
            this.toolStripMenuItem1,
            this.deltag,
            this.toolStripMenuItem2,
            this.clear,
            this.toolStripMenuItem3,
            this.copytag});
            this.trmenu.Name = "trmenu";
            this.trmenu.Size = new System.Drawing.Size(139, 118);
            // 
            // properties
            // 
            this.properties.Image = global::CW_File_Viewer_5.Properties.Resources.changecolname;
            this.properties.Name = "properties";
            this.properties.Size = new System.Drawing.Size(138, 24);
            this.properties.Text = "属性";
            this.properties.Click += new System.EventHandler(this.properties_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(135, 6);
            // 
            // deltag
            // 
            this.deltag.Image = global::CW_File_Viewer_5.Properties.Resources.delete;
            this.deltag.Name = "deltag";
            this.deltag.Size = new System.Drawing.Size(138, 24);
            this.deltag.Text = "删除";
            this.deltag.Click += new System.EventHandler(this.deltag_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(135, 6);
            // 
            // clear
            // 
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(138, 24);
            this.clear.Text = "清理标签";
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(135, 6);
            // 
            // copytag
            // 
            this.copytag.Name = "copytag";
            this.copytag.Size = new System.Drawing.Size(138, 24);
            this.copytag.Text = "拷贝标签";
            this.copytag.Click += new System.EventHandler(this.copytag_Click);
            // 
            // tabv
            // 
            this.tabv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabv.CanReorderTabs = true;
            this.tabv.ForeColor = System.Drawing.Color.Black;
            this.tabv.Location = new System.Drawing.Point(12, -3);
            this.tabv.Name = "tabv";
            this.tabv.SelectedTabFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.tabv.SelectedTabIndex = 0;
            this.tabv.Size = new System.Drawing.Size(1129, 573);
            this.tabv.Style = DevComponents.DotNetBar.eTabStripStyle.Metro;
            this.tabv.TabIndex = 5;
            this.tabv.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.MultilineNoNavigationBox;
            this.tabv.Click += new System.EventHandler(this.tabv_Click);
            // 
            // addpage
            // 
            this.addpage.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.addpage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addpage.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.addpage.FocusCuesEnabled = false;
            this.addpage.Location = new System.Drawing.Point(560, 3);
            this.addpage.Name = "addpage";
            this.addpage.Size = new System.Drawing.Size(80, 26);
            this.addpage.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.addpagetoall});
            this.addpage.TabIndex = 1;
            this.addpage.Text = "添加页";
            this.addpage.Click += new System.EventHandler(this.addpage_Click);
            // 
            // addpagetoall
            // 
            this.addpagetoall.GlobalItem = false;
            this.addpagetoall.Name = "addpagetoall";
            this.addpagetoall.Text = "给所有标签系统添加";
            this.addpagetoall.Click += new System.EventHandler(this.addpage_Click);
            // 
            // pagename
            // 
            this.pagename.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pagename.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.pagename.Border.Class = "TextBoxBorder";
            this.pagename.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.pagename.DisabledBackColor = System.Drawing.Color.White;
            this.pagename.ForeColor = System.Drawing.Color.Black;
            this.pagename.Location = new System.Drawing.Point(334, 3);
            this.pagename.Name = "pagename";
            this.pagename.PreventEnterBeep = true;
            this.pagename.Size = new System.Drawing.Size(220, 26);
            this.pagename.TabIndex = 6;
            this.pagename.WatermarkText = "请输入要添加的标签页标题";
            // 
            // highlighter
            // 
            this.highlighter.ContainerControl = this;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
            // 
            // searchtext
            // 
            this.searchtext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.searchtext.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.searchtext.Border.Class = "TextBoxBorder";
            this.searchtext.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.searchtext.DisabledBackColor = System.Drawing.Color.White;
            this.searchtext.ForeColor = System.Drawing.Color.Black;
            this.searchtext.Location = new System.Drawing.Point(665, 3);
            this.searchtext.Name = "searchtext";
            this.searchtext.PreventEnterBeep = true;
            this.searchtext.Size = new System.Drawing.Size(200, 26);
            this.searchtext.TabIndex = 6;
            this.searchtext.WatermarkText = "请输入要搜索的标签名";
            // 
            // line1
            // 
            this.line1.ForeColor = System.Drawing.Color.DarkGray;
            this.line1.Location = new System.Drawing.Point(315, 3);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(13, 26);
            this.line1.TabIndex = 7;
            this.line1.Text = "line1";
            this.line1.VerticalLine = true;
            // 
            // line2
            // 
            this.line2.ForeColor = System.Drawing.Color.DarkGray;
            this.line2.Location = new System.Drawing.Point(646, 3);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(13, 26);
            this.line2.TabIndex = 7;
            this.line2.Text = "line1";
            this.line2.VerticalLine = true;
            // 
            // buttonlayout
            // 
            this.buttonlayout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonlayout.AutoScroll = true;
            this.buttonlayout.Controls.Add(this.tagname);
            this.buttonlayout.Controls.Add(this.addtag);
            this.buttonlayout.Controls.Add(this.line1);
            this.buttonlayout.Controls.Add(this.pagename);
            this.buttonlayout.Controls.Add(this.addpage);
            this.buttonlayout.Controls.Add(this.line2);
            this.buttonlayout.Controls.Add(this.searchtext);
            this.buttonlayout.Controls.Add(this.search);
            this.buttonlayout.Controls.Add(this.line3);
            this.buttonlayout.Controls.Add(this.showCheckedTag);
            this.buttonlayout.Controls.Add(this.line4);
            this.buttonlayout.Controls.Add(this.islocked);
            this.buttonlayout.Location = new System.Drawing.Point(8, 573);
            this.buttonlayout.Name = "buttonlayout";
            this.buttonlayout.Size = new System.Drawing.Size(1144, 33);
            this.buttonlayout.TabIndex = 8;
            // 
            // search
            // 
            this.search.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.search.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.search.FocusCuesEnabled = false;
            this.search.Location = new System.Drawing.Point(871, 3);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(26, 26);
            this.search.Symbol = "";
            this.search.SymbolSize = 10F;
            this.search.TabIndex = 1;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // line3
            // 
            this.line3.ForeColor = System.Drawing.Color.DarkGray;
            this.line3.Location = new System.Drawing.Point(903, 3);
            this.line3.Name = "line3";
            this.line3.Size = new System.Drawing.Size(13, 26);
            this.line3.TabIndex = 7;
            this.line3.Text = "line1";
            this.line3.VerticalLine = true;
            // 
            // showCheckedTag
            // 
            this.showCheckedTag.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.showCheckedTag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.showCheckedTag.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.showCheckedTag.FocusCuesEnabled = false;
            this.showCheckedTag.Location = new System.Drawing.Point(922, 3);
            this.showCheckedTag.Name = "showCheckedTag";
            this.showCheckedTag.Size = new System.Drawing.Size(133, 26);
            this.showCheckedTag.TabIndex = 1;
            this.showCheckedTag.Text = "显示已标标签";
            this.showCheckedTag.Click += new System.EventHandler(this.showCheckedTag_Click);
            // 
            // line4
            // 
            this.line4.ForeColor = System.Drawing.Color.DarkGray;
            this.line4.Location = new System.Drawing.Point(1061, 3);
            this.line4.Name = "line4";
            this.line4.Size = new System.Drawing.Size(13, 26);
            this.line4.TabIndex = 7;
            this.line4.Text = "line1";
            this.line4.VerticalLine = true;
            // 
            // islocked
            // 
            this.islocked.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.islocked.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.islocked.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.islocked.FocusCuesEnabled = false;
            this.islocked.Location = new System.Drawing.Point(1080, 3);
            this.islocked.Name = "islocked";
            this.islocked.Size = new System.Drawing.Size(53, 26);
            this.islocked.TabIndex = 1;
            this.islocked.Text = "锁定";
            this.islocked.Click += new System.EventHandler(this.islocked_Click);
            // 
            // FrmTag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 613);
            this.Controls.Add(this.buttonlayout);
            this.Controls.Add(this.tabv);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FrmTag";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmTag_FormClosing);
            this.Load += new System.EventHandler(this.FrmTag_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmTag_KeyDown);
            this.trmenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.buttonlayout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public DevComponents.DotNetBar.ButtonX addtag;
        public DevComponents.DotNetBar.Controls.TextBoxX tagname;
        public System.Windows.Forms.ContextMenuStrip trmenu;
        public System.Windows.Forms.ToolStripMenuItem deltag;
        public DevComponents.DotNetBar.TabControl tabv;
        public DevComponents.DotNetBar.ButtonX addpage;
        public DevComponents.DotNetBar.Controls.TextBoxX pagename;
        public System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem properties;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter;
        private System.Windows.Forms.ErrorProvider errorProvider;
        public DevComponents.DotNetBar.Controls.TextBoxX searchtext;
        private DevComponents.DotNetBar.Controls.Line line1;
        private System.Windows.Forms.FlowLayoutPanel buttonlayout;
        private DevComponents.DotNetBar.Controls.Line line2;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem clear;
        private DevComponents.DotNetBar.Controls.Line line3;
        public DevComponents.DotNetBar.ButtonX showCheckedTag;
        private DevComponents.DotNetBar.ButtonItem addtagtoall;
        private DevComponents.DotNetBar.ButtonItem addpagetoall;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem copytag;
        public DevComponents.DotNetBar.ButtonX search;
        private DevComponents.DotNetBar.Controls.Line line4;
        public DevComponents.DotNetBar.ButtonX islocked;


    }
}