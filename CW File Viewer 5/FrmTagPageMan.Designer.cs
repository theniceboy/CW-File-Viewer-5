namespace CW_File_Viewer_5
{
    partial class FrmTagPageMan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTagPageMan));
            this.mainlayout = new System.Windows.Forms.FlowLayoutPanel();
            this.pagename = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.rename = new DevComponents.DotNetBar.ButtonX();
            this.rbmenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copypage = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.delpage = new System.Windows.Forms.ToolStripMenuItem();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.highlighter = new DevComponents.DotNetBar.Validator.Highlighter();
            this.rbmenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // mainlayout
            // 
            this.mainlayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainlayout.AutoScroll = true;
            this.mainlayout.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainlayout.Location = new System.Drawing.Point(12, 12);
            this.mainlayout.Name = "mainlayout";
            this.mainlayout.Size = new System.Drawing.Size(601, 339);
            this.mainlayout.TabIndex = 0;
            // 
            // pagename
            // 
            this.pagename.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pagename.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.pagename.Border.Class = "TextBoxBorder";
            this.pagename.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.pagename.DisabledBackColor = System.Drawing.Color.White;
            this.pagename.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.pagename.ForeColor = System.Drawing.Color.Black;
            this.pagename.Location = new System.Drawing.Point(12, 357);
            this.pagename.Name = "pagename";
            this.pagename.PreventEnterBeep = true;
            this.pagename.Size = new System.Drawing.Size(520, 27);
            this.pagename.TabIndex = 1;
            // 
            // rename
            // 
            this.rename.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.rename.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rename.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.rename.FocusCuesEnabled = false;
            this.rename.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rename.Location = new System.Drawing.Point(538, 357);
            this.rename.Name = "rename";
            this.rename.Size = new System.Drawing.Size(75, 27);
            this.rename.TabIndex = 2;
            this.rename.Text = "重命名";
            this.rename.Click += new System.EventHandler(this.rename_Click);
            // 
            // rbmenu
            // 
            this.rbmenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copypage,
            this.toolStripMenuItem1,
            this.delpage});
            this.rbmenu.Name = "rbmenu";
            this.rbmenu.Size = new System.Drawing.Size(111, 58);
            // 
            // copypage
            // 
            this.copypage.Image = global::CW_File_Viewer_5.Properties.Resources.tocollection;
            this.copypage.Name = "copypage";
            this.copypage.Size = new System.Drawing.Size(110, 24);
            this.copypage.Text = "复制";
            this.copypage.Click += new System.EventHandler(this.copypage_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(107, 6);
            // 
            // delpage
            // 
            this.delpage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delpage.Image = global::CW_File_Viewer_5.Properties.Resources.delete;
            this.delpage.Name = "delpage";
            this.delpage.Size = new System.Drawing.Size(110, 24);
            this.delpage.Text = "删除";
            this.delpage.Click += new System.EventHandler(this.delpage_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
            // 
            // highlighter
            // 
            this.highlighter.ContainerControl = this;
            // 
            // FrmTagPageMan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 396);
            this.Controls.Add(this.rename);
            this.Controls.Add(this.pagename);
            this.Controls.Add(this.mainlayout);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmTagPageMan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CW File Viewer - 标签页管理";
            this.Load += new System.EventHandler(this.FrmTagPageMan_Load);
            this.rbmenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.FlowLayoutPanel mainlayout;
        public DevComponents.DotNetBar.Controls.TextBoxX pagename;
        public DevComponents.DotNetBar.ButtonX rename;
        public System.Windows.Forms.ContextMenuStrip rbmenu;
        public System.Windows.Forms.ToolStripMenuItem delpage;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter;
        private System.Windows.Forms.ToolStripMenuItem copypage;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;

    }
}