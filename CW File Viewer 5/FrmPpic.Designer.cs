namespace CW_File_Viewer_5
{
    partial class FrmPpic
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
            this.picprev = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picprev)).BeginInit();
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
            // picprev
            // 
            this.picprev.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picprev.Location = new System.Drawing.Point(0, 0);
            this.picprev.Name = "picprev";
            this.picprev.Size = new System.Drawing.Size(400, 400);
            this.picprev.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picprev.TabIndex = 1;
            this.picprev.TabStop = false;
            this.picprev.Click += new System.EventHandler(this.picprev_Click);
            // 
            // FrmPpic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.picprev);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPpic";
            this.Text = "FrmPpic";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.picprev)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tcanuse;
        private System.Windows.Forms.Timer tmv;
        private System.Windows.Forms.PictureBox picprev;
    }
}