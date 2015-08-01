namespace CW_File_Viewer_5
{
    partial class FrmRename
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRename));
            this.filename = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.ok = new DevComponents.DotNetBar.ButtonX();
            this.cancel = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // filename
            // 
            this.filename.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filename.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.filename.Border.Class = "TextBoxBorder";
            this.filename.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.filename.DisabledBackColor = System.Drawing.Color.White;
            this.filename.ForeColor = System.Drawing.Color.Black;
            this.filename.Location = new System.Drawing.Point(12, 15);
            this.filename.Name = "filename";
            this.filename.PreventEnterBeep = true;
            this.filename.Size = new System.Drawing.Size(363, 27);
            this.filename.TabIndex = 0;
            // 
            // ok
            // 
            this.ok.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ok.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ok.FocusCuesEnabled = false;
            this.ok.Location = new System.Drawing.Point(168, 57);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(97, 31);
            this.ok.Symbol = "";
            this.ok.SymbolSize = 10F;
            this.ok.TabIndex = 1;
            this.ok.Text = "确定";
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // cancel
            // 
            this.cancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.cancel.FocusCuesEnabled = false;
            this.cancel.Location = new System.Drawing.Point(278, 57);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(97, 31);
            this.cancel.Symbol = "";
            this.cancel.SymbolSize = 10F;
            this.cancel.TabIndex = 1;
            this.cancel.Text = "取消";
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // FrmRename
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 100);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.filename);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1231318, 147);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(18, 147);
            this.Name = "FrmRename";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CW File Viewer - 重命名";
            this.Load += new System.EventHandler(this.FrmRename_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX filename;
        private DevComponents.DotNetBar.ButtonX ok;
        private DevComponents.DotNetBar.ButtonX cancel;
    }
}