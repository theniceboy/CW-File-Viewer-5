namespace CW_File_Viewer_5
{
    partial class FrmDic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDic));
            this.flt = new System.Windows.Forms.Timer(this.components);
            this.tmv = new System.Windows.Forms.Timer(this.components);
            this.word = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.mean = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.speaknow = new DevComponents.DotNetBar.ButtonX();
            this.look = new DevComponents.DotNetBar.ButtonX();
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // flt
            // 
            this.flt.Enabled = true;
            this.flt.Interval = 1;
            this.flt.Tick += new System.EventHandler(this.flt_Tick);
            // 
            // tmv
            // 
            this.tmv.Enabled = true;
            this.tmv.Tick += new System.EventHandler(this.tmv_Tick);
            // 
            // word
            // 
            this.word.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.word.Border.Class = "TextBoxBorder";
            this.word.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.word.DisabledBackColor = System.Drawing.Color.White;
            this.word.ForeColor = System.Drawing.Color.Black;
            this.word.Location = new System.Drawing.Point(12, 12);
            this.word.Name = "word";
            this.word.Size = new System.Drawing.Size(357, 25);
            this.word.TabIndex = 0;
            // 
            // mean
            // 
            this.mean.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.mean.Border.Class = "TextBoxBorder";
            this.mean.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mean.DisabledBackColor = System.Drawing.Color.White;
            this.mean.ForeColor = System.Drawing.Color.Black;
            this.mean.Location = new System.Drawing.Point(12, 43);
            this.mean.Multiline = true;
            this.mean.Name = "mean";
            this.mean.Size = new System.Drawing.Size(419, 111);
            this.mean.TabIndex = 1;
            // 
            // speaknow
            // 
            this.speaknow.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.speaknow.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.speaknow.Location = new System.Drawing.Point(375, 12);
            this.speaknow.Name = "speaknow";
            this.speaknow.Size = new System.Drawing.Size(25, 25);
            this.speaknow.Symbol = "";
            this.speaknow.SymbolSize = 10F;
            this.speaknow.TabIndex = 2;
            this.speaknow.Click += new System.EventHandler(this.speaknow_Click);
            // 
            // look
            // 
            this.look.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.look.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.look.Location = new System.Drawing.Point(406, 12);
            this.look.Name = "look";
            this.look.Size = new System.Drawing.Size(25, 25);
            this.look.Symbol = "";
            this.look.SymbolSize = 10F;
            this.look.TabIndex = 3;
            this.look.Click += new System.EventHandler(this.look_Click);
            // 
            // player
            // 
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(0, 146);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(75, 23);
            this.player.TabIndex = 4;
            this.player.Visible = false;
            // 
            // FrmDic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(142)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(443, 166);
            this.Controls.Add(this.player);
            this.Controls.Add(this.look);
            this.Controls.Add(this.speaknow);
            this.Controls.Add(this.mean);
            this.Controls.Add(this.word);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDic";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "FrmDic";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmDic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer flt;
        private System.Windows.Forms.Timer tmv;
        private DevComponents.DotNetBar.Controls.TextBoxX word;
        private DevComponents.DotNetBar.Controls.TextBoxX mean;
        private DevComponents.DotNetBar.ButtonX speaknow;
        private DevComponents.DotNetBar.ButtonX look;
        private AxWMPLib.AxWindowsMediaPlayer player;

    }
}