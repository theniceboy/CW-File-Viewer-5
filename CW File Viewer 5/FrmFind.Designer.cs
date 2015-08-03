namespace CW_File_Viewer_5
{
    partial class FrmFind
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFind));
            this.tbText = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnFindNext = new DevComponents.DotNetBar.ButtonX();
            this.cbCaseSensitive = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.SuspendLayout();
            // 
            // tbText
            // 
            this.tbText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbText.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tbText.Border.Class = "TextBoxBorder";
            this.tbText.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbText.DisabledBackColor = System.Drawing.Color.White;
            this.tbText.ForeColor = System.Drawing.Color.Black;
            this.tbText.Location = new System.Drawing.Point(12, 13);
            this.tbText.Multiline = true;
            this.tbText.Name = "tbText";
            this.tbText.PreventEnterBeep = true;
            this.tbText.Size = new System.Drawing.Size(458, 259);
            this.tbText.TabIndex = 0;
            this.tbText.WatermarkText = "输入要查找的文字";
            this.tbText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbText_KeyDown);
            // 
            // btnFindNext
            // 
            this.btnFindNext.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnFindNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFindNext.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnFindNext.FocusCuesEnabled = false;
            this.btnFindNext.Location = new System.Drawing.Point(339, 278);
            this.btnFindNext.Name = "btnFindNext";
            this.btnFindNext.Size = new System.Drawing.Size(131, 39);
            this.btnFindNext.SymbolSize = 10F;
            this.btnFindNext.TabIndex = 1;
            this.btnFindNext.Text = "查找下一条";
            this.btnFindNext.Tooltip = "从光标（或选择开始部分）位置开始，查找上方输入的文本";
            this.btnFindNext.Click += new System.EventHandler(this.btnFindNext_Click);
            // 
            // cbCaseSensitive
            // 
            this.cbCaseSensitive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.cbCaseSensitive.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cbCaseSensitive.Location = new System.Drawing.Point(226, 278);
            this.cbCaseSensitive.Name = "cbCaseSensitive";
            this.cbCaseSensitive.Size = new System.Drawing.Size(107, 39);
            this.cbCaseSensitive.TabIndex = 2;
            this.cbCaseSensitive.Text = "区分大小写";
            // 
            // FrmFind
            // 
            this.AcceptButton = this.btnFindNext;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 329);
            this.Controls.Add(this.cbCaseSensitive);
            this.Controls.Add(this.btnFindNext);
            this.Controls.Add(this.tbText);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmFind";
            this.Text = "CW File View - 查找";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmFind_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX tbText;
        private DevComponents.DotNetBar.ButtonX btnFindNext;
        private DevComponents.DotNetBar.Controls.CheckBoxX cbCaseSensitive;
    }
}