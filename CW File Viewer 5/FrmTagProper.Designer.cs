namespace CW_File_Viewer_5
{
    partial class FrmTagProper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTagProper));
            this.change = new DevComponents.DotNetBar.ButtonX();
            this.tagname = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cancel = new DevComponents.DotNetBar.ButtonX();
            this.mainlayout = new System.Windows.Forms.FlowLayoutPanel();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.taginfo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.highlighter = new DevComponents.DotNetBar.Validator.Highlighter();
            this.line1 = new DevComponents.DotNetBar.Controls.Line();
            this.line2 = new DevComponents.DotNetBar.Controls.Line();
            this.line3 = new DevComponents.DotNetBar.Controls.Line();
            this.line4 = new DevComponents.DotNetBar.Controls.Line();
            this.btib = new DevComponents.DotNetBar.BalloonTip();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // change
            // 
            this.change.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.change.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.change.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.change.FocusCuesEnabled = false;
            this.change.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.change.Location = new System.Drawing.Point(776, 427);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(100, 34);
            this.change.Symbol = "";
            this.change.SymbolSize = 12F;
            this.change.TabIndex = 0;
            this.change.Text = "确定";
            this.change.Click += new System.EventHandler(this.change_Click);
            // 
            // tagname
            // 
            this.tagname.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tagname.Border.Class = "TextBoxBorder";
            this.tagname.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tagname.DisabledBackColor = System.Drawing.Color.White;
            this.tagname.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tagname.ForeColor = System.Drawing.Color.Black;
            this.tagname.Location = new System.Drawing.Point(12, 32);
            this.tagname.Name = "tagname";
            this.tagname.PreventEnterBeep = true;
            this.tagname.Size = new System.Drawing.Size(419, 27);
            this.tagname.TabIndex = 1;
            // 
            // cancel
            // 
            this.cancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel.FocusCuesEnabled = false;
            this.cancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cancel.Location = new System.Drawing.Point(670, 427);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(100, 34);
            this.cancel.Symbol = "";
            this.cancel.SymbolSize = 12F;
            this.cancel.TabIndex = 0;
            this.cancel.Text = "取消";
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // mainlayout
            // 
            this.mainlayout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.mainlayout.AutoScroll = true;
            this.mainlayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.mainlayout.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainlayout.ForeColor = System.Drawing.Color.Black;
            this.mainlayout.Location = new System.Drawing.Point(12, 95);
            this.mainlayout.Name = "mainlayout";
            this.mainlayout.Size = new System.Drawing.Size(419, 326);
            this.mainlayout.TabIndex = 3;
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelX1.ForeColor = System.Drawing.Color.Black;
            this.labelX1.Location = new System.Drawing.Point(12, 65);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(95, 24);
            this.labelX1.TabIndex = 2;
            this.labelX1.Text = "标签页：";
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelX2.ForeColor = System.Drawing.Color.Black;
            this.labelX2.Location = new System.Drawing.Point(12, 2);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(95, 24);
            this.labelX2.TabIndex = 2;
            this.labelX2.Text = "标签名：";
            // 
            // taginfo
            // 
            this.taginfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.taginfo.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.taginfo.Border.Class = "TextBoxBorder";
            this.taginfo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.taginfo.DisabledBackColor = System.Drawing.Color.White;
            this.taginfo.ForeColor = System.Drawing.Color.Black;
            this.taginfo.Location = new System.Drawing.Point(437, 32);
            this.taginfo.MaxLength = 2147483647;
            this.taginfo.Multiline = true;
            this.taginfo.Name = "taginfo";
            this.taginfo.PreventEnterBeep = true;
            this.taginfo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.taginfo.Size = new System.Drawing.Size(439, 389);
            this.taginfo.TabIndex = 4;
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelX3.ForeColor = System.Drawing.Color.Black;
            this.labelX3.Location = new System.Drawing.Point(437, 2);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(116, 24);
            this.labelX3.TabIndex = 2;
            this.labelX3.Text = "标签说明：";
            // 
            // highlighter
            // 
            this.highlighter.ContainerControl = this;
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.line1.ForeColor = System.Drawing.Color.Black;
            this.line1.Location = new System.Drawing.Point(12, 95);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(419, 1);
            this.line1.TabIndex = 5;
            this.line1.Text = "line1";
            // 
            // line2
            // 
            this.line2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.line2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.line2.ForeColor = System.Drawing.Color.Black;
            this.line2.Location = new System.Drawing.Point(12, 420);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(419, 1);
            this.line2.TabIndex = 5;
            this.line2.Text = "line1";
            // 
            // line3
            // 
            this.line3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.line3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.line3.ForeColor = System.Drawing.Color.Black;
            this.line3.Location = new System.Drawing.Point(12, 95);
            this.line3.Name = "line3";
            this.line3.Size = new System.Drawing.Size(1, 326);
            this.line3.TabIndex = 5;
            this.line3.Text = "line1";
            this.line3.VerticalLine = true;
            // 
            // line4
            // 
            this.line4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.line4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.line4.ForeColor = System.Drawing.Color.Black;
            this.line4.Location = new System.Drawing.Point(430, 95);
            this.line4.Name = "line4";
            this.line4.Size = new System.Drawing.Size(1, 326);
            this.line4.TabIndex = 5;
            this.line4.Text = "line1";
            this.line4.VerticalLine = true;
            // 
            // btib
            // 
            this.btib.AutoClose = false;
            this.btib.BalloonFocus = true;
            this.btib.Style = DevComponents.DotNetBar.eBallonStyle.Office2007Alert;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
            // 
            // FrmTagProper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 473);
            this.Controls.Add(this.line4);
            this.Controls.Add(this.line3);
            this.Controls.Add(this.line2);
            this.Controls.Add(this.line1);
            this.Controls.Add(this.taginfo);
            this.Controls.Add(this.mainlayout);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.tagname);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.change);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmTagProper";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CW File Viewer - 标签属性";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmTagRename_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX change;
        private DevComponents.DotNetBar.Controls.TextBoxX tagname;
        private DevComponents.DotNetBar.ButtonX cancel;
        private System.Windows.Forms.FlowLayoutPanel mainlayout;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX taginfo;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter;
        private DevComponents.DotNetBar.Controls.Line line1;
        private DevComponents.DotNetBar.Controls.Line line4;
        private DevComponents.DotNetBar.Controls.Line line3;
        private DevComponents.DotNetBar.Controls.Line line2;
        private DevComponents.DotNetBar.BalloonTip btib;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}