namespace CW_File_Viewer_5
{
    partial class FrmInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInfo));
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.filename = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.filepic = new System.Windows.Forms.PictureBox();
            this.filetype = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.filesize = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.filepath = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.filecreatdate = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.filechangedate = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.close = new DevComponents.DotNetBar.ButtonX();
            this.otherinfolabel = new DevComponents.DotNetBar.LabelX();
            this.otherinfo = new DevComponents.DotNetBar.Controls.TextBoxX();
            ((System.ComponentModel.ISupportInitialize)(this.filepic)).BeginInit();
            this.SuspendLayout();
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.ForeColor = System.Drawing.Color.Black;
            this.labelX2.Location = new System.Drawing.Point(12, 115);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(90, 21);
            this.labelX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.labelX2.TabIndex = 4;
            this.labelX2.Text = "文件大小：";
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.ForeColor = System.Drawing.Color.Black;
            this.labelX3.Location = new System.Drawing.Point(12, 157);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(90, 21);
            this.labelX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.labelX3.TabIndex = 5;
            this.labelX3.Text = "文件路径：";
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
            this.filename.Location = new System.Drawing.Point(108, 15);
            this.filename.Name = "filename";
            this.filename.ReadOnly = true;
            this.filename.Size = new System.Drawing.Size(405, 27);
            this.filename.TabIndex = 6;
            // 
            // filepic
            // 
            this.filepic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.filepic.ForeColor = System.Drawing.Color.Black;
            this.filepic.Location = new System.Drawing.Point(25, 7);
            this.filepic.Name = "filepic";
            this.filepic.Size = new System.Drawing.Size(45, 45);
            this.filepic.TabIndex = 7;
            this.filepic.TabStop = false;
            // 
            // filetype
            // 
            this.filetype.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filetype.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.filetype.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.filetype.DisabledBackColor = System.Drawing.Color.White;
            this.filetype.ForeColor = System.Drawing.Color.Black;
            this.filetype.Location = new System.Drawing.Point(108, 74);
            this.filetype.Name = "filetype";
            this.filetype.ReadOnly = true;
            this.filetype.Size = new System.Drawing.Size(405, 21);
            this.filetype.TabIndex = 8;
            // 
            // filesize
            // 
            this.filesize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filesize.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.filesize.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.filesize.DisabledBackColor = System.Drawing.Color.White;
            this.filesize.ForeColor = System.Drawing.Color.Black;
            this.filesize.Location = new System.Drawing.Point(108, 116);
            this.filesize.Name = "filesize";
            this.filesize.ReadOnly = true;
            this.filesize.Size = new System.Drawing.Size(405, 21);
            this.filesize.TabIndex = 9;
            // 
            // filepath
            // 
            this.filepath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filepath.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.filepath.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.filepath.DisabledBackColor = System.Drawing.Color.White;
            this.filepath.ForeColor = System.Drawing.Color.Black;
            this.filepath.Location = new System.Drawing.Point(108, 158);
            this.filepath.Name = "filepath";
            this.filepath.ReadOnly = true;
            this.filepath.Size = new System.Drawing.Size(405, 21);
            this.filepath.TabIndex = 10;
            // 
            // filecreatdate
            // 
            this.filecreatdate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filecreatdate.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.filecreatdate.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.filecreatdate.DisabledBackColor = System.Drawing.Color.White;
            this.filecreatdate.ForeColor = System.Drawing.Color.Black;
            this.filecreatdate.Location = new System.Drawing.Point(108, 200);
            this.filecreatdate.Name = "filecreatdate";
            this.filecreatdate.ReadOnly = true;
            this.filecreatdate.Size = new System.Drawing.Size(405, 21);
            this.filecreatdate.TabIndex = 11;
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.ForeColor = System.Drawing.Color.Black;
            this.labelX1.Location = new System.Drawing.Point(12, 199);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(90, 21);
            this.labelX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.labelX1.TabIndex = 12;
            this.labelX1.Text = "创建日期：";
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.ForeColor = System.Drawing.Color.Black;
            this.labelX4.Location = new System.Drawing.Point(12, 73);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(90, 21);
            this.labelX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.labelX4.TabIndex = 13;
            this.labelX4.Text = "文件类型：";
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.ForeColor = System.Drawing.Color.Black;
            this.labelX5.Location = new System.Drawing.Point(12, 241);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(90, 21);
            this.labelX5.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.labelX5.TabIndex = 14;
            this.labelX5.Text = "修改日期：";
            // 
            // filechangedate
            // 
            this.filechangedate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filechangedate.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.filechangedate.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.filechangedate.DisabledBackColor = System.Drawing.Color.White;
            this.filechangedate.ForeColor = System.Drawing.Color.Black;
            this.filechangedate.Location = new System.Drawing.Point(108, 242);
            this.filechangedate.Name = "filechangedate";
            this.filechangedate.ReadOnly = true;
            this.filechangedate.Size = new System.Drawing.Size(405, 21);
            this.filechangedate.TabIndex = 15;
            // 
            // close
            // 
            this.close.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.close.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.close.FocusCuesEnabled = false;
            this.close.Location = new System.Drawing.Point(376, 322);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(137, 45);
            this.close.TabIndex = 16;
            this.close.Text = "关闭";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // otherinfolabel
            // 
            this.otherinfolabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.otherinfolabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.otherinfolabel.ForeColor = System.Drawing.Color.Black;
            this.otherinfolabel.Location = new System.Drawing.Point(12, 283);
            this.otherinfolabel.Name = "otherinfolabel";
            this.otherinfolabel.Size = new System.Drawing.Size(90, 21);
            this.otherinfolabel.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.otherinfolabel.TabIndex = 14;
            // 
            // otherinfo
            // 
            this.otherinfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.otherinfo.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.otherinfo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.otherinfo.DisabledBackColor = System.Drawing.Color.White;
            this.otherinfo.ForeColor = System.Drawing.Color.Black;
            this.otherinfo.Location = new System.Drawing.Point(108, 284);
            this.otherinfo.Name = "otherinfo";
            this.otherinfo.ReadOnly = true;
            this.otherinfo.Size = new System.Drawing.Size(405, 21);
            this.otherinfo.TabIndex = 15;
            // 
            // FrmInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 379);
            this.Controls.Add(this.close);
            this.Controls.Add(this.otherinfo);
            this.Controls.Add(this.filechangedate);
            this.Controls.Add(this.otherinfolabel);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.filecreatdate);
            this.Controls.Add(this.filepath);
            this.Controls.Add(this.filesize);
            this.Controls.Add(this.filetype);
            this.Controls.Add(this.filepic);
            this.Controls.Add(this.filename);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(543, 426);
            this.MinimumSize = new System.Drawing.Size(543, 426);
            this.Name = "FrmInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CW File Viewer - 文件属性";
            this.Load += new System.EventHandler(this.FrmInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.filepic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX filename;
        private System.Windows.Forms.PictureBox filepic;
        private DevComponents.DotNetBar.Controls.TextBoxX filetype;
        private DevComponents.DotNetBar.Controls.TextBoxX filesize;
        private DevComponents.DotNetBar.Controls.TextBoxX filepath;
        private DevComponents.DotNetBar.Controls.TextBoxX filecreatdate;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.TextBoxX filechangedate;
        private DevComponents.DotNetBar.ButtonX close;
        private DevComponents.DotNetBar.LabelX otherinfolabel;
        private DevComponents.DotNetBar.Controls.TextBoxX otherinfo;

    }
}

