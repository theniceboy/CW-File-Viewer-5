namespace CW_File_Viewer_5
{
    partial class FrmHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHistory));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lfsum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hisv = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // lfsum
            // 
            this.lfsum.Text = "共0条历史记录";
            this.lfsum.Width = 1091;
            // 
            // hisv
            // 
            this.hisv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hisv.BackColor = System.Drawing.Color.White;
            this.hisv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.hisv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lfsum});
            this.hisv.Font = new System.Drawing.Font("SimSun", 10F);
            this.hisv.ForeColor = System.Drawing.Color.Black;
            this.hisv.FullRowSelect = true;
            this.hisv.GridLines = true;
            this.hisv.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.hisv.LargeImageList = this.imageList1;
            this.hisv.Location = new System.Drawing.Point(-4, -2);
            this.hisv.Margin = new System.Windows.Forms.Padding(4);
            this.hisv.MultiSelect = false;
            this.hisv.Name = "hisv";
            this.hisv.Size = new System.Drawing.Size(789, 574);
            this.hisv.SmallImageList = this.imageList1;
            this.hisv.TabIndex = 51;
            this.hisv.UseCompatibleStateImageBehavior = false;
            this.hisv.View = System.Windows.Forms.View.Details;
            this.hisv.SelectedIndexChanged += new System.EventHandler(this.hisv_SelectedIndexChanged);
            // 
            // FrmHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 569);
            this.Controls.Add(this.hisv);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CW File Viewer - 历史记录";
            this.Load += new System.EventHandler(this.FrmHistory_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        public System.Windows.Forms.ColumnHeader lfsum;
        public System.Windows.Forms.ListView hisv;
    }
}