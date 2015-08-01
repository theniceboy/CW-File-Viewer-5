namespace CW_File_Viewer_5
{
    partial class FrmTagPageMan_CopyPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTagPageMan_CopyPage));
            this.mainlayout = new System.Windows.Forms.FlowLayoutPanel();
            this.ok = new DevComponents.DotNetBar.ButtonX();
            this.cancel = new DevComponents.DotNetBar.ButtonX();
            this.label1 = new DevComponents.DotNetBar.LabelX();
            this.SuspendLayout();
            // 
            // mainlayout
            // 
            this.mainlayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainlayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.mainlayout.ForeColor = System.Drawing.Color.Black;
            this.mainlayout.Location = new System.Drawing.Point(12, 50);
            this.mainlayout.Name = "mainlayout";
            this.mainlayout.Size = new System.Drawing.Size(601, 313);
            this.mainlayout.TabIndex = 1;
            // 
            // ok
            // 
            this.ok.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ok.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ok.FocusCuesEnabled = false;
            this.ok.Location = new System.Drawing.Point(510, 369);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(103, 36);
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
            this.cancel.Location = new System.Drawing.Point(401, 369);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(103, 36);
            this.cancel.TabIndex = 3;
            this.cancel.Text = "取消";
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            // 
            // 
            // 
            this.label1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "请选择要复制到的系统：";
            // 
            // FrmTagPageMan_CopyPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 417);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.mainlayout);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmTagPageMan_CopyPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CW File Viewer - 复制标签页";
            this.Load += new System.EventHandler(this.FrmTagPageMan_CopyPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel mainlayout;
        private DevComponents.DotNetBar.ButtonX ok;
        private DevComponents.DotNetBar.ButtonX cancel;
        private DevComponents.DotNetBar.LabelX label1;
    }
}