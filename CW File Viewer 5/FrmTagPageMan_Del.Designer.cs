namespace CW_File_Viewer_5
{
    partial class FrmTagPageMan_Del
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTagPageMan_Del));
            this.mixto = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.mainlayout = new System.Windows.Forms.FlowLayoutPanel();
            this.delall = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.ok = new DevComponents.DotNetBar.ButtonX();
            this.cancel = new DevComponents.DotNetBar.ButtonX();
            this.checkBoxX1 = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.SuspendLayout();
            // 
            // mixto
            // 
            this.mixto.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.mixto.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mixto.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.mixto.Checked = true;
            this.mixto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mixto.CheckValue = "Y";
            this.mixto.FocusCuesEnabled = false;
            this.mixto.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.mixto.ForeColor = System.Drawing.Color.Black;
            this.mixto.Location = new System.Drawing.Point(12, 12);
            this.mixto.Name = "mixto";
            this.mixto.Size = new System.Drawing.Size(332, 30);
            this.mixto.TabIndex = 0;
            this.mixto.Text = "将本页的所有标签合并到选择页";
            // 
            // mainlayout
            // 
            this.mainlayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainlayout.AutoScroll = true;
            this.mainlayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.mainlayout.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainlayout.ForeColor = System.Drawing.Color.Black;
            this.mainlayout.Location = new System.Drawing.Point(12, 44);
            this.mainlayout.Name = "mainlayout";
            this.mainlayout.Size = new System.Drawing.Size(481, 324);
            this.mainlayout.TabIndex = 1;
            // 
            // delall
            // 
            this.delall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.delall.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.delall.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.delall.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.delall.FocusCuesEnabled = false;
            this.delall.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.delall.ForeColor = System.Drawing.Color.Black;
            this.delall.Location = new System.Drawing.Point(12, 375);
            this.delall.Name = "delall";
            this.delall.Size = new System.Drawing.Size(243, 30);
            this.delall.TabIndex = 0;
            this.delall.Text = "将本页的所有标签全部删除";
            // 
            // ok
            // 
            this.ok.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ok.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ok.FocusCuesEnabled = false;
            this.ok.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ok.Location = new System.Drawing.Point(392, 448);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(101, 30);
            this.ok.TabIndex = 2;
            this.ok.Text = "确定";
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // cancel
            // 
            this.cancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel.FocusCuesEnabled = false;
            this.cancel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cancel.Location = new System.Drawing.Point(285, 448);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(101, 30);
            this.cancel.TabIndex = 2;
            this.cancel.Text = "取消";
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // checkBoxX1
            // 
            this.checkBoxX1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxX1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.checkBoxX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.checkBoxX1.Checked = true;
            this.checkBoxX1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxX1.CheckValue = "Y";
            this.checkBoxX1.FocusCuesEnabled = false;
            this.checkBoxX1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.checkBoxX1.ForeColor = System.Drawing.Color.Black;
            this.checkBoxX1.Location = new System.Drawing.Point(76, 405);
            this.checkBoxX1.Name = "checkBoxX1";
            this.checkBoxX1.Size = new System.Drawing.Size(243, 30);
            this.checkBoxX1.TabIndex = 0;
            this.checkBoxX1.Text = "彻底删除其中标签（清理）";
            // 
            // FrmTabPageMan_Del
            // 
            this.AcceptButton = this.ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancel;
            this.ClientSize = new System.Drawing.Size(505, 490);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.mainlayout);
            this.Controls.Add(this.checkBoxX1);
            this.Controls.Add(this.delall);
            this.Controls.Add(this.mixto);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmTabPageMan_Del";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CW File Viewer - 标签页面删除选项";
            this.Load += new System.EventHandler(this.FrmTabPageMan_Del_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.CheckBoxX mixto;
        private System.Windows.Forms.FlowLayoutPanel mainlayout;
        private DevComponents.DotNetBar.Controls.CheckBoxX delall;
        private DevComponents.DotNetBar.ButtonX ok;
        private DevComponents.DotNetBar.ButtonX cancel;
        private DevComponents.DotNetBar.Controls.CheckBoxX checkBoxX1;
    }
}