namespace CW_File_Viewer_5
{
    partial class FrmPtxt
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
            this.tcanuse = new System.Windows.Forms.Timer(this.components);
            this.tmv = new System.Windows.Forms.Timer(this.components);
            this.layoutmain = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // tcanuse
            // 
            this.tcanuse.Enabled = true;
            this.tcanuse.Interval = 500;
            this.tcanuse.Tick += new System.EventHandler(this.tcanuse_Tick);
            // 
            // tmv
            // 
            this.tmv.Enabled = true;
            this.tmv.Tick += new System.EventHandler(this.tmv_Tick);
            // 
            // layoutmain
            // 
            this.layoutmain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.layoutmain.AutoScroll = true;
            this.layoutmain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.layoutmain.ForeColor = System.Drawing.Color.Black;
            this.layoutmain.Location = new System.Drawing.Point(0, -2);
            this.layoutmain.Name = "layoutmain";
            this.layoutmain.Size = new System.Drawing.Size(236, 33);
            this.layoutmain.TabIndex = 2;
            this.layoutmain.Paint += new System.Windows.Forms.PaintEventHandler(this.layoutmain_Paint);
            // 
            // FrmPtxt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(236, 29);
            this.Controls.Add(this.layoutmain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPtxt";
            this.ShowIcon = false;
            this.Text = "FrmPtxt";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmPtxt_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tcanuse;
        private System.Windows.Forms.Timer tmv;
        private System.Windows.Forms.FlowLayoutPanel layoutmain;
    }
}