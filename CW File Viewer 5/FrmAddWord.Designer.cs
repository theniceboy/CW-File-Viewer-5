namespace CW_File_Viewer_5
{
    partial class FrmAddWord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddWord));
            this.word = new DevComponents.DotNetBar.Controls.MaskedTextBoxAdv();
            this.mean = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.add = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // word
            // 
            this.word.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.word.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.word.BackgroundStyle.Class = "TextBoxBorder";
            this.word.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.word.ButtonClear.Visible = true;
            this.word.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.word.ForeColor = System.Drawing.Color.Black;
            this.word.Location = new System.Drawing.Point(12, 12);
            this.word.Name = "word";
            this.word.Size = new System.Drawing.Size(356, 25);
            this.word.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.word.TabIndex = 1;
            this.word.Text = "";
            this.word.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.word_MaskInputRejected);
            // 
            // mean
            // 
            this.mean.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mean.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.mean.Border.Class = "TextBoxBorder";
            this.mean.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mean.DisabledBackColor = System.Drawing.Color.White;
            this.mean.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mean.ForeColor = System.Drawing.Color.Black;
            this.mean.Location = new System.Drawing.Point(12, 43);
            this.mean.Multiline = true;
            this.mean.Name = "mean";
            this.mean.Size = new System.Drawing.Size(356, 111);
            this.mean.TabIndex = 2;
            // 
            // add
            // 
            this.add.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.add.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.add.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.add.Location = new System.Drawing.Point(271, 160);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(97, 28);
            this.add.TabIndex = 3;
            this.add.Text = "添加";
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // FrmAddWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 200);
            this.Controls.Add(this.add);
            this.Controls.Add(this.mean);
            this.Controls.Add(this.word);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAddWord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CW File Viewer - 添加词语";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmAddWord_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.MaskedTextBoxAdv word;
        private DevComponents.DotNetBar.Controls.TextBoxX mean;
        private DevComponents.DotNetBar.ButtonX add;

    }
}

