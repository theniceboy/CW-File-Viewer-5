namespace CW_File_Viewer_5
{
    partial class FrmTagCopy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTagCopy));
            this.mainlayout = new System.Windows.Forms.FlowLayoutPanel();
            this.ok = new DevComponents.DotNetBar.ButtonX();
            this.cancel = new DevComponents.DotNetBar.ButtonX();
            this.choosepage = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.highlighter = new DevComponents.DotNetBar.Validator.Highlighter();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
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
            this.mainlayout.Size = new System.Drawing.Size(439, 215);
            this.mainlayout.TabIndex = 1;
            // 
            // ok
            // 
            this.ok.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ok.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ok.FocusCuesEnabled = false;
            this.ok.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ok.Location = new System.Drawing.Point(351, 233);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(100, 30);
            this.ok.TabIndex = 3;
            this.ok.Text = "确定";
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // cancel
            // 
            this.cancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.cancel.FocusCuesEnabled = false;
            this.cancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cancel.Location = new System.Drawing.Point(245, 233);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(100, 30);
            this.cancel.TabIndex = 3;
            this.cancel.Text = "取消";
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // choosepage
            // 
            this.choosepage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.choosepage.DisplayMember = "Text";
            this.choosepage.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.choosepage.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.choosepage.FormattingEnabled = true;
            this.choosepage.ItemHeight = 20;
            this.choosepage.Location = new System.Drawing.Point(12, 235);
            this.choosepage.Name = "choosepage";
            this.choosepage.Size = new System.Drawing.Size(227, 26);
            this.choosepage.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.choosepage.TabIndex = 4;
            this.choosepage.SelectedIndexChanged += new System.EventHandler(this.choosepage_SelectedIndexChanged);
            // 
            // highlighter
            // 
            this.highlighter.FocusHighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
            // 
            // FrmTagCopy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 275);
            this.Controls.Add(this.choosepage);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.mainlayout);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmTagCopy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CW File Viewer - 拷贝标签";
            this.Load += new System.EventHandler(this.FrmTagCopy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel mainlayout;
        private DevComponents.DotNetBar.ButtonX ok;
        private DevComponents.DotNetBar.ButtonX cancel;
        private DevComponents.DotNetBar.Controls.ComboBoxEx choosepage;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}