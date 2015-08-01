namespace CW_File_Viewer_5
{
    partial class FrmFileNote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFileNote));
            this.note = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.ok = new DevComponents.DotNetBar.ButtonX();
            this.cancel = new DevComponents.DotNetBar.ButtonX();
            this.length = new DevComponents.DotNetBar.LabelX();
            this.SuspendLayout();
            // 
            // note
            // 
            this.note.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.note.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.note.Border.Class = "TextBoxBorder";
            this.note.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.note.DisabledBackColor = System.Drawing.Color.White;
            this.note.ForeColor = System.Drawing.Color.Black;
            this.note.Location = new System.Drawing.Point(12, 8);
            this.note.MaxLength = 2147483647;
            this.note.Multiline = true;
            this.note.Name = "note";
            this.note.PreventEnterBeep = true;
            this.note.Size = new System.Drawing.Size(601, 356);
            this.note.TabIndex = 0;
            this.note.WatermarkText = "请输入注释";
            this.note.TextChanged += new System.EventHandler(this.note_TextChanged);
            this.note.KeyDown += new System.Windows.Forms.KeyEventHandler(this.note_KeyDown);
            // 
            // ok
            // 
            this.ok.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ok.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ok.FocusCuesEnabled = false;
            this.ok.Location = new System.Drawing.Point(509, 370);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(104, 35);
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
            this.cancel.Location = new System.Drawing.Point(399, 370);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(104, 35);
            this.cancel.TabIndex = 1;
            this.cancel.Text = "取消";
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // length
            // 
            this.length.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.length.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.length.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.length.ForeColor = System.Drawing.Color.Black;
            this.length.Location = new System.Drawing.Point(15, 378);
            this.length.Name = "length";
            this.length.Size = new System.Drawing.Size(177, 23);
            this.length.TabIndex = 2;
            this.length.Text = "共 0 字";
            // 
            // FrmFileNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 417);
            this.Controls.Add(this.length);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.note);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmFileNote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CW File Viewer - 文件注释";
            this.Load += new System.EventHandler(this.FrmFileNote_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX note;
        private DevComponents.DotNetBar.ButtonX ok;
        private DevComponents.DotNetBar.ButtonX cancel;
        private DevComponents.DotNetBar.LabelX length;
    }
}