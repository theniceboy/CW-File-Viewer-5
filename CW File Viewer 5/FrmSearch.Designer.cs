namespace CW_File_Viewer_5
{
    partial class FrmSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSearch));
            this.filev = new System.Windows.Forms.ListView();
            this.hfname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rbmenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showtag = new System.Windows.Forms.ToolStripMenuItem();
            this.showtagplus = new System.Windows.Forms.ToolStripMenuItem();
            this.layoutmain = new System.Windows.Forms.FlowLayoutPanel();
            this.search = new DevComponents.DotNetBar.ButtonX();
            this.save = new DevComponents.DotNetBar.ButtonX();
            this.line2 = new DevComponents.DotNetBar.Controls.Line();
            this.searchtext = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.line1 = new DevComponents.DotNetBar.Controls.Line();
            this.searchfile = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.searcht = new DevComponents.DotNetBar.ButtonX();
            this.infile = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.way1 = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.way2 = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.highlighter = new DevComponents.DotNetBar.Validator.Highlighter();
            this.rbmenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // filev
            // 
            this.filev.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.filev.BackColor = System.Drawing.Color.White;
            this.filev.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.hfname});
            this.filev.ContextMenuStrip = this.rbmenu;
            this.filev.ForeColor = System.Drawing.Color.Black;
            this.filev.FullRowSelect = true;
            this.filev.GridLines = true;
            this.filev.Location = new System.Drawing.Point(12, 2);
            this.filev.MultiSelect = false;
            this.filev.Name = "filev";
            this.filev.Size = new System.Drawing.Size(282, 569);
            this.filev.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.filev.TabIndex = 0;
            this.filev.UseCompatibleStateImageBehavior = false;
            this.filev.View = System.Windows.Forms.View.Details;
            this.filev.SelectedIndexChanged += new System.EventHandler(this.filev_SelectedIndexChanged);
            // 
            // hfname
            // 
            this.hfname.Text = "文件名";
            this.hfname.Width = 277;
            // 
            // rbmenu
            // 
            this.rbmenu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbmenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showtag,
            this.showtagplus});
            this.rbmenu.Name = "rbmenu";
            this.rbmenu.Size = new System.Drawing.Size(217, 52);
            // 
            // showtag
            // 
            this.showtag.Name = "showtag";
            this.showtag.Size = new System.Drawing.Size(216, 24);
            this.showtag.Text = "显示标签";
            this.showtag.Click += new System.EventHandler(this.showtag_Click);
            // 
            // showtagplus
            // 
            this.showtagplus.Name = "showtagplus";
            this.showtagplus.Size = new System.Drawing.Size(216, 24);
            this.showtagplus.Text = "显示标签+已标标签";
            this.showtagplus.Click += new System.EventHandler(this.showtagplus_Click);
            // 
            // layoutmain
            // 
            this.layoutmain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.layoutmain.AutoScroll = true;
            this.layoutmain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.layoutmain.ForeColor = System.Drawing.Color.Black;
            this.layoutmain.Location = new System.Drawing.Point(300, 2);
            this.layoutmain.Name = "layoutmain";
            this.layoutmain.Size = new System.Drawing.Size(794, 536);
            this.layoutmain.TabIndex = 1;
            // 
            // search
            // 
            this.search.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.search.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.search.FocusCuesEnabled = false;
            this.search.Location = new System.Drawing.Point(709, 544);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(148, 27);
            this.search.TabIndex = 2;
            this.search.Text = "搜索";
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // save
            // 
            this.save.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.save.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.save.FocusCuesEnabled = false;
            this.save.Location = new System.Drawing.Point(12, 577);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(282, 27);
            this.save.TabIndex = 3;
            this.save.Text = "全部保存到当前目录中";
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // line2
            // 
            this.line2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.line2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.line2.ForeColor = System.Drawing.Color.Black;
            this.line2.Location = new System.Drawing.Point(863, 544);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(13, 27);
            this.line2.TabIndex = 9;
            this.line2.Text = "line1";
            this.line2.VerticalLine = true;
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
            this.searchtext.Location = new System.Drawing.Point(882, 544);
            this.searchtext.Name = "searchtext";
            this.searchtext.PreventEnterBeep = true;
            this.searchtext.Size = new System.Drawing.Size(182, 27);
            this.searchtext.TabIndex = 8;
            this.searchtext.WatermarkText = "请输入要搜索的标签名";
            // 
            // line1
            // 
            this.line1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.line1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.line1.ForeColor = System.Drawing.Color.Black;
            this.line1.Location = new System.Drawing.Point(690, 544);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(13, 27);
            this.line1.TabIndex = 9;
            this.line1.Text = "line1";
            this.line1.VerticalLine = true;
            // 
            // searchfile
            // 
            this.searchfile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchfile.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.searchfile.Border.Class = "TextBoxBorder";
            this.searchfile.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.searchfile.DisabledBackColor = System.Drawing.Color.White;
            this.searchfile.ForeColor = System.Drawing.Color.Black;
            this.searchfile.Location = new System.Drawing.Point(320, 544);
            this.searchfile.Name = "searchfile";
            this.searchfile.PreventEnterBeep = true;
            this.searchfile.Size = new System.Drawing.Size(364, 27);
            this.searchfile.TabIndex = 8;
            this.searchfile.WatermarkText = "请输入要搜索的文件名";
            // 
            // searcht
            // 
            this.searcht.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.searcht.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.searcht.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.searcht.FocusCuesEnabled = false;
            this.searcht.Location = new System.Drawing.Point(1070, 544);
            this.searcht.Name = "searcht";
            this.searcht.Size = new System.Drawing.Size(27, 27);
            this.searcht.Symbol = "";
            this.searcht.SymbolSize = 10F;
            this.searcht.TabIndex = 2;
            this.searcht.Click += new System.EventHandler(this.searcht_Click);
            // 
            // infile
            // 
            this.infile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.infile.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.infile.Border.Class = "TextBoxBorder";
            this.infile.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.infile.DisabledBackColor = System.Drawing.Color.White;
            this.infile.ForeColor = System.Drawing.Color.Black;
            this.infile.Location = new System.Drawing.Point(320, 577);
            this.infile.Name = "infile";
            this.infile.PreventEnterBeep = true;
            this.infile.Size = new System.Drawing.Size(777, 27);
            this.infile.TabIndex = 8;
            this.infile.WatermarkText = "请输入要搜索的文件内容";
            // 
            // way1
            // 
            this.way1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.way1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.way1.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.way1.FocusCuesEnabled = false;
            this.way1.ForeColor = System.Drawing.Color.Black;
            this.way1.Location = new System.Drawing.Point(303, 544);
            this.way1.Name = "way1";
            this.way1.Size = new System.Drawing.Size(27, 27);
            this.way1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.way1.TabIndex = 10;
            this.way1.CheckedChanged += new System.EventHandler(this.way1_CheckedChanged);
            // 
            // way2
            // 
            this.way2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.way2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.way2.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.way2.FocusCuesEnabled = false;
            this.way2.ForeColor = System.Drawing.Color.Black;
            this.way2.Location = new System.Drawing.Point(303, 577);
            this.way2.Name = "way2";
            this.way2.Size = new System.Drawing.Size(27, 27);
            this.way2.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.way2.TabIndex = 11;
            this.way2.CheckedChanged += new System.EventHandler(this.way2_CheckedChanged);
            // 
            // highlighter
            // 
            this.highlighter.ContainerControl = this;
            this.highlighter.FocusHighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Orange;
            // 
            // FrmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 615);
            this.Controls.Add(this.infile);
            this.Controls.Add(this.way2);
            this.Controls.Add(this.searchfile);
            this.Controls.Add(this.way1);
            this.Controls.Add(this.line1);
            this.Controls.Add(this.line2);
            this.Controls.Add(this.searchtext);
            this.Controls.Add(this.save);
            this.Controls.Add(this.searcht);
            this.Controls.Add(this.search);
            this.Controls.Add(this.layoutmain);
            this.Controls.Add(this.filev);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CW File Viewer - 文件搜索";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmSearch_Load);
            this.rbmenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView filev;
        private System.Windows.Forms.ColumnHeader hfname;
        private System.Windows.Forms.FlowLayoutPanel layoutmain;
        private DevComponents.DotNetBar.ButtonX search;
        private DevComponents.DotNetBar.ButtonX save;
        private DevComponents.DotNetBar.Controls.Line line2;
        public DevComponents.DotNetBar.Controls.TextBoxX searchtext;
        private DevComponents.DotNetBar.Controls.Line line1;
        public DevComponents.DotNetBar.Controls.TextBoxX searchfile;
        private DevComponents.DotNetBar.ButtonX searcht;
        private System.Windows.Forms.ContextMenuStrip rbmenu;
        private System.Windows.Forms.ToolStripMenuItem showtag;
        private System.Windows.Forms.ToolStripMenuItem showtagplus;
        public DevComponents.DotNetBar.Controls.TextBoxX infile;
        private DevComponents.DotNetBar.Controls.CheckBoxX way1;
        private DevComponents.DotNetBar.Controls.CheckBoxX way2;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter;
    }
}