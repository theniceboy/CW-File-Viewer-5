namespace CW_File_Viewer_5
{
    partial class FrmText
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmText));
            this.text = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.work = new DevComponents.DotNetBar.ButtonX();
            this.cancel = new DevComponents.DotNetBar.ButtonX();
            this.rt = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tabv = new DevComponents.DotNetBar.TabControl();
            this.tabControlPanel1 = new DevComponents.DotNetBar.TabControlPanel();
            this.tab1 = new DevComponents.DotNetBar.TabItem(this.components);
            this.tab2 = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel2 = new DevComponents.DotNetBar.TabControlPanel();
            this.r21 = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.r22 = new DevComponents.DotNetBar.Controls.CheckBoxX();
            ((System.ComponentModel.ISupportInitialize)(this.tabv)).BeginInit();
            this.tabv.SuspendLayout();
            this.tabControlPanel1.SuspendLayout();
            this.tabControlPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // text
            // 
            this.text.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.text.Border.Class = "TextBoxBorder";
            this.text.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.text.DisabledBackColor = System.Drawing.Color.White;
            this.text.ForeColor = System.Drawing.Color.Black;
            this.text.Location = new System.Drawing.Point(4, 4);
            this.text.MaxLength = 2147483647;
            this.text.Multiline = true;
            this.text.Name = "text";
            this.text.PreventEnterBeep = true;
            this.text.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.text.Size = new System.Drawing.Size(526, 184);
            this.text.TabIndex = 0;
            this.text.WatermarkText = "Old";
            // 
            // work
            // 
            this.work.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.work.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.work.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.work.Location = new System.Drawing.Point(376, 419);
            this.work.Name = "work";
            this.work.Size = new System.Drawing.Size(82, 26);
            this.work.TabIndex = 1;
            this.work.Text = "操作";
            this.work.Click += new System.EventHandler(this.work_Click);
            // 
            // cancel
            // 
            this.cancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.cancel.Location = new System.Drawing.Point(464, 419);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(82, 26);
            this.cancel.TabIndex = 1;
            this.cancel.Text = "取消";
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // rt
            // 
            this.rt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rt.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.rt.Border.Class = "TextBoxBorder";
            this.rt.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.rt.DisabledBackColor = System.Drawing.Color.White;
            this.rt.ForeColor = System.Drawing.Color.Black;
            this.rt.Location = new System.Drawing.Point(4, 194);
            this.rt.MaxLength = 2147483647;
            this.rt.Multiline = true;
            this.rt.Name = "rt";
            this.rt.PreventEnterBeep = true;
            this.rt.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.rt.Size = new System.Drawing.Size(526, 181);
            this.rt.TabIndex = 0;
            this.rt.WatermarkText = "New";
            // 
            // tabv
            // 
            this.tabv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabv.CanReorderTabs = true;
            this.tabv.Controls.Add(this.tabControlPanel2);
            this.tabv.Controls.Add(this.tabControlPanel1);
            this.tabv.ForeColor = System.Drawing.Color.Black;
            this.tabv.Location = new System.Drawing.Point(12, 1);
            this.tabv.Name = "tabv";
            this.tabv.SelectedTabFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tabv.SelectedTabIndex = 0;
            this.tabv.Size = new System.Drawing.Size(534, 412);
            this.tabv.Style = DevComponents.DotNetBar.eTabStripStyle.Metro;
            this.tabv.TabIndex = 2;
            this.tabv.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            this.tabv.Tabs.Add(this.tab1);
            this.tabv.Tabs.Add(this.tab2);
            // 
            // tabControlPanel1
            // 
            this.tabControlPanel1.Controls.Add(this.text);
            this.tabControlPanel1.Controls.Add(this.rt);
            this.tabControlPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.tabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel1.Location = new System.Drawing.Point(0, 33);
            this.tabControlPanel1.Name = "tabControlPanel1";
            this.tabControlPanel1.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel1.Size = new System.Drawing.Size(534, 379);
            this.tabControlPanel1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.tabControlPanel1.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel1.Style.GradientAngle = 90;
            this.tabControlPanel1.TabIndex = 1;
            this.tabControlPanel1.TabItem = this.tab1;
            // 
            // tab1
            // 
            this.tab1.AttachedControl = this.tabControlPanel1;
            this.tab1.Name = "tab1";
            this.tab1.Text = "文本替换";
            this.tab1.Click += new System.EventHandler(this.tab1_Click);
            // 
            // tab2
            // 
            this.tab2.AttachedControl = this.tabControlPanel2;
            this.tab2.Name = "tab2";
            this.tab2.Text = "匹配替换";
            this.tab2.Click += new System.EventHandler(this.tab2_Click);
            // 
            // tabControlPanel2
            // 
            this.tabControlPanel2.Controls.Add(this.r22);
            this.tabControlPanel2.Controls.Add(this.r21);
            this.tabControlPanel2.DisabledBackColor = System.Drawing.Color.Empty;
            this.tabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel2.Location = new System.Drawing.Point(0, 33);
            this.tabControlPanel2.Name = "tabControlPanel2";
            this.tabControlPanel2.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel2.Size = new System.Drawing.Size(534, 379);
            this.tabControlPanel2.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabControlPanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel2.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.tabControlPanel2.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel2.Style.GradientAngle = 90;
            this.tabControlPanel2.TabIndex = 2;
            this.tabControlPanel2.TabItem = this.tab2;
            // 
            // r21
            // 
            this.r21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.r21.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.r21.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.r21.Checked = true;
            this.r21.CheckState = System.Windows.Forms.CheckState.Checked;
            this.r21.CheckValue = "Y";
            this.r21.ForeColor = System.Drawing.Color.Black;
            this.r21.Location = new System.Drawing.Point(10, 10);
            this.r21.Name = "r21";
            this.r21.Size = new System.Drawing.Size(173, 23);
            this.r21.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.r21.TabIndex = 0;
            this.r21.Text = "英文引号变中文引号";
            // 
            // r22
            // 
            this.r22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.r22.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.r22.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.r22.ForeColor = System.Drawing.Color.Black;
            this.r22.Location = new System.Drawing.Point(10, 39);
            this.r22.Name = "r22";
            this.r22.Size = new System.Drawing.Size(173, 23);
            this.r22.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.r22.TabIndex = 0;
            this.r22.Text = "中文引号变英文引号";
            // 
            // FrmText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 457);
            this.Controls.Add(this.tabv);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.work);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmText";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CW File Viewer - 文本操作";
            this.Load += new System.EventHandler(this.FrmText_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabv)).EndInit();
            this.tabv.ResumeLayout(false);
            this.tabControlPanel1.ResumeLayout(false);
            this.tabControlPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX text;
        private DevComponents.DotNetBar.ButtonX work;
        private DevComponents.DotNetBar.ButtonX cancel;
        private DevComponents.DotNetBar.Controls.TextBoxX rt;
        private DevComponents.DotNetBar.TabControl tabv;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel1;
        private DevComponents.DotNetBar.TabItem tab1;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel2;
        private DevComponents.DotNetBar.Controls.CheckBoxX r22;
        private DevComponents.DotNetBar.Controls.CheckBoxX r21;
        private DevComponents.DotNetBar.TabItem tab2;
    }
}