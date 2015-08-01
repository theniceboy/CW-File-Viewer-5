namespace CW_File_Viewer_5
{
    partial class FrmTagSystem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTagSystem));
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.mainlayout = new System.Windows.Forms.FlowLayoutPanel();
            this.name = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.rename = new DevComponents.DotNetBar.ButtonX();
            this.set = new DevComponents.DotNetBar.ButtonX();
            this.choose = new DevComponents.DotNetBar.ButtonX();
            this.newsys = new DevComponents.DotNetBar.ButtonX();
            this.highlighter = new DevComponents.DotNetBar.Validator.Highlighter();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerColorTint = System.Drawing.Color.White;
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2013;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))), System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(142)))), ((int)(((byte)(0))))));
            // 
            // mainlayout
            // 
            this.mainlayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainlayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.mainlayout.ForeColor = System.Drawing.Color.Black;
            this.mainlayout.Location = new System.Drawing.Point(12, 12);
            this.mainlayout.Name = "mainlayout";
            this.mainlayout.Size = new System.Drawing.Size(632, 224);
            this.mainlayout.TabIndex = 0;
            // 
            // name
            // 
            this.name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.name.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.name.Border.Class = "TextBoxBorder";
            this.name.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.name.DisabledBackColor = System.Drawing.Color.White;
            this.name.ForeColor = System.Drawing.Color.Black;
            this.name.Location = new System.Drawing.Point(12, 242);
            this.name.Name = "name";
            this.name.PreventEnterBeep = true;
            this.name.Size = new System.Drawing.Size(288, 27);
            this.name.TabIndex = 1;
            // 
            // rename
            // 
            this.rename.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.rename.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rename.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.rename.FocusCuesEnabled = false;
            this.rename.Location = new System.Drawing.Point(392, 242);
            this.rename.Name = "rename";
            this.rename.Size = new System.Drawing.Size(80, 27);
            this.rename.TabIndex = 2;
            this.rename.Text = "重命名";
            this.rename.Click += new System.EventHandler(this.rename_Click);
            // 
            // set
            // 
            this.set.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.set.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.set.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.set.FocusCuesEnabled = false;
            this.set.Location = new System.Drawing.Point(478, 242);
            this.set.Name = "set";
            this.set.Size = new System.Drawing.Size(80, 27);
            this.set.TabIndex = 2;
            this.set.Text = "设为默认";
            this.set.Click += new System.EventHandler(this.set_Click);
            // 
            // choose
            // 
            this.choose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.choose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.choose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.choose.FocusCuesEnabled = false;
            this.choose.Location = new System.Drawing.Point(564, 242);
            this.choose.Name = "choose";
            this.choose.Size = new System.Drawing.Size(80, 27);
            this.choose.TabIndex = 2;
            this.choose.Text = "选择系统";
            this.choose.Click += new System.EventHandler(this.choose_Click);
            // 
            // newsys
            // 
            this.newsys.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.newsys.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.newsys.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.newsys.FocusCuesEnabled = false;
            this.newsys.Location = new System.Drawing.Point(306, 242);
            this.newsys.Name = "newsys";
            this.newsys.Size = new System.Drawing.Size(80, 27);
            this.newsys.TabIndex = 2;
            this.newsys.Text = "新建";
            this.newsys.Click += new System.EventHandler(this.newsys_Click);
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
            // FrmTagSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 282);
            this.Controls.Add(this.choose);
            this.Controls.Add(this.set);
            this.Controls.Add(this.newsys);
            this.Controls.Add(this.rename);
            this.Controls.Add(this.name);
            this.Controls.Add(this.mainlayout);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmTagSystem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CW File Viewer - 标签系统";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmTagSystem_FormClosing);
            this.Load += new System.EventHandler(this.FrmTagSystem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.StyleManager styleManager1;
        private System.Windows.Forms.FlowLayoutPanel mainlayout;
        private DevComponents.DotNetBar.Controls.TextBoxX name;
        private DevComponents.DotNetBar.ButtonX rename;
        private DevComponents.DotNetBar.ButtonX set;
        private DevComponents.DotNetBar.ButtonX choose;
        private DevComponents.DotNetBar.ButtonX newsys;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter;
        private System.Windows.Forms.ErrorProvider errorProvider;

    }
}

