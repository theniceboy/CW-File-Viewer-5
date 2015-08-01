namespace CW_File_Viewer_5
{
    partial class FrmCut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCut));
            this.finds = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.ficut = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.r42 = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.r41 = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.r4 = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.addz = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.upfile = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.r3 = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.r2 = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.r1 = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.cutch = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label1 = new System.Windows.Forms.Label();
            this.cutadd = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cutsum = new DevComponents.Editors.IntegerInput();
            this.azsum = new DevComponents.Editors.IntegerInput();
            this.cut = new DevComponents.DotNetBar.ButtonX();
            this.prog = new DevComponents.DotNetBar.Controls.ProgressBarX();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cutsum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.azsum)).BeginInit();
            this.SuspendLayout();
            // 
            // finds
            // 
            this.finds.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.finds.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.finds.Border.Class = "TextBoxBorder";
            this.finds.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.finds.DisabledBackColor = System.Drawing.Color.White;
            this.finds.ForeColor = System.Drawing.Color.Black;
            this.finds.Location = new System.Drawing.Point(136, 5);
            this.finds.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.finds.Name = "finds";
            this.finds.Size = new System.Drawing.Size(404, 26);
            this.finds.TabIndex = 95;
            this.finds.TextChanged += new System.EventHandler(this.finds_TextChanged);
            // 
            // ficut
            // 
            this.ficut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ficut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.ficut.Border.Class = "TextBoxBorder";
            this.ficut.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ficut.DisabledBackColor = System.Drawing.Color.White;
            this.ficut.ForeColor = System.Drawing.Color.Black;
            this.ficut.Location = new System.Drawing.Point(160, 54);
            this.ficut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ficut.Name = "ficut";
            this.ficut.Size = new System.Drawing.Size(380, 26);
            this.ficut.TabIndex = 93;
            this.ficut.Text = ".!?;:。！？";
            this.ficut.TextChanged += new System.EventHandler(this.ficut_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(33, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 20);
            this.label8.TabIndex = 73;
            this.label8.Text = "查找字符串：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(33, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 20);
            this.label9.TabIndex = 73;
            this.label9.Text = "分割字符";
            // 
            // r42
            // 
            this.r42.AutoSize = true;
            this.r42.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.r42.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.r42.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.r42.Checked = true;
            this.r42.CheckState = System.Windows.Forms.CheckState.Checked;
            this.r42.CheckValue = "Y";
            this.r42.FocusCuesEnabled = false;
            this.r42.ForeColor = System.Drawing.Color.Black;
            this.r42.Location = new System.Drawing.Point(81, 56);
            this.r42.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.r42.Name = "r42";
            this.r42.Size = new System.Drawing.Size(73, 23);
            this.r42.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.r42.TabIndex = 91;
            this.r42.Text = "字符：";
            this.r42.CheckedChanged += new System.EventHandler(this.r42_CheckedChanged);
            // 
            // r41
            // 
            this.r41.AutoSize = true;
            this.r41.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.r41.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.r41.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.r41.FocusCuesEnabled = false;
            this.r41.ForeColor = System.Drawing.Color.Black;
            this.r41.Location = new System.Drawing.Point(81, 87);
            this.r41.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.r41.Name = "r41";
            this.r41.Size = new System.Drawing.Size(134, 23);
            this.r41.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.r41.TabIndex = 90;
            this.r41.Text = "段（一个回车）";
            this.r41.CheckedChanged += new System.EventHandler(this.r41_CheckedChanged);
            // 
            // r4
            // 
            this.r4.AutoSize = true;
            this.r4.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.r4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.r4.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.r4.FocusCuesEnabled = false;
            this.r4.ForeColor = System.Drawing.Color.Black;
            this.r4.Location = new System.Drawing.Point(45, 350);
            this.r4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.r4.Name = "r4";
            this.r4.Size = new System.Drawing.Size(88, 23);
            this.r4.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.r4.TabIndex = 111;
            this.r4.Text = "查找分割";
            this.r4.CheckedChanged += new System.EventHandler(this.r4_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.finds);
            this.panel1.Controls.Add(this.ficut);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.r42);
            this.panel1.Controls.Add(this.r41);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(45, 369);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(559, 118);
            this.panel1.TabIndex = 114;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(82, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(249, 20);
            this.label7.TabIndex = 112;
            this.label7.Text = "说明：每扫描到一个回车分割一次";
            // 
            // addz
            // 
            this.addz.AutoSize = true;
            this.addz.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.addz.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.addz.FocusCuesEnabled = false;
            this.addz.ForeColor = System.Drawing.Color.Black;
            this.addz.Location = new System.Drawing.Point(45, 102);
            this.addz.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addz.Name = "addz";
            this.addz.Size = new System.Drawing.Size(119, 23);
            this.addz.TabIndex = 109;
            this.addz.Text = "数位相差补零";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(17, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 25);
            this.label5.TabIndex = 108;
            this.label5.Text = "功能选择";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(17, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 25);
            this.label4.TabIndex = 107;
            this.label4.Text = "基本设置";
            // 
            // upfile
            // 
            this.upfile.AutoSize = true;
            this.upfile.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.upfile.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.upfile.FocusCuesEnabled = false;
            this.upfile.ForeColor = System.Drawing.Color.Black;
            this.upfile.Location = new System.Drawing.Point(45, 74);
            this.upfile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.upfile.Name = "upfile";
            this.upfile.Size = new System.Drawing.Size(302, 23);
            this.upfile.TabIndex = 106;
            this.upfile.Text = "同时分割文本框中文件（大文件不推荐）";
            this.upfile.CheckedChanged += new System.EventHandler(this.upfile_CheckedChanged);
            // 
            // r3
            // 
            this.r3.AutoSize = true;
            this.r3.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.r3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.r3.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.r3.Checked = true;
            this.r3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.r3.CheckValue = "Y";
            this.r3.FocusCuesEnabled = false;
            this.r3.ForeColor = System.Drawing.Color.Black;
            this.r3.Location = new System.Drawing.Point(45, 189);
            this.r3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.r3.Name = "r3";
            this.r3.Size = new System.Drawing.Size(180, 23);
            this.r3.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.r3.TabIndex = 105;
            this.r3.Text = "按段（一个回车）分割";
            this.r3.CheckedChanged += new System.EventHandler(this.r3_CheckedChanged);
            // 
            // r2
            // 
            this.r2.AutoSize = true;
            this.r2.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.r2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.r2.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.r2.Cursor = System.Windows.Forms.Cursors.Default;
            this.r2.FocusCuesEnabled = false;
            this.r2.ForeColor = System.Drawing.Color.Black;
            this.r2.Location = new System.Drawing.Point(45, 297);
            this.r2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.r2.Name = "r2";
            this.r2.Size = new System.Drawing.Size(104, 23);
            this.r2.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.r2.TabIndex = 103;
            this.r2.Text = "按字数分割";
            this.r2.CheckedChanged += new System.EventHandler(this.r2_CheckedChanged);
            // 
            // r1
            // 
            this.r1.AutoSize = true;
            this.r1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.r1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.r1.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.r1.FocusCuesEnabled = false;
            this.r1.ForeColor = System.Drawing.Color.Black;
            this.r1.Location = new System.Drawing.Point(45, 241);
            this.r1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.r1.Name = "r1";
            this.r1.Size = new System.Drawing.Size(134, 23);
            this.r1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.r1.TabIndex = 102;
            this.r1.Text = "按分割字符分割";
            this.r1.CheckedChanged += new System.EventHandler(this.r1_CheckedChanged);
            // 
            // cutch
            // 
            this.cutch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cutch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.cutch.Border.Class = "TextBoxBorder";
            this.cutch.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cutch.DisabledBackColor = System.Drawing.Color.White;
            this.cutch.ForeColor = System.Drawing.Color.Black;
            this.cutch.Location = new System.Drawing.Point(170, 265);
            this.cutch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cutch.Name = "cutch";
            this.cutch.Size = new System.Drawing.Size(415, 26);
            this.cutch.TabIndex = 101;
            this.cutch.Text = ".!?;:。！？";
            this.cutch.TextChanged += new System.EventHandler(this.cutch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(82, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 100;
            this.label1.Text = "分割字符：";
            // 
            // cutadd
            // 
            this.cutadd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cutadd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.cutadd.Border.Class = "TextBoxBorder";
            this.cutadd.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cutadd.DisabledBackColor = System.Drawing.Color.White;
            this.cutadd.ForeColor = System.Drawing.Color.Black;
            this.cutadd.Location = new System.Drawing.Point(130, 39);
            this.cutadd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cutadd.Name = "cutadd";
            this.cutadd.Size = new System.Drawing.Size(455, 26);
            this.cutadd.TabIndex = 98;
            this.cutadd.Text = " - cut";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(82, 322);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 96;
            this.label3.Text = "分割字数：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(82, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 20);
            this.label6.TabIndex = 97;
            this.label6.Text = "位数：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(42, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 95;
            this.label2.Text = "文件夹名：";
            // 
            // cutsum
            // 
            this.cutsum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cutsum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.cutsum.BackgroundStyle.Class = "DateTimeInputBackground";
            this.cutsum.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cutsum.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.cutsum.ForeColor = System.Drawing.Color.Black;
            this.cutsum.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left;
            this.cutsum.Location = new System.Drawing.Point(170, 320);
            this.cutsum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cutsum.MinValue = 1;
            this.cutsum.Name = "cutsum";
            this.cutsum.ShowUpDown = true;
            this.cutsum.Size = new System.Drawing.Size(415, 26);
            this.cutsum.TabIndex = 115;
            this.cutsum.Value = 1000;
            this.cutsum.ValueChanged += new System.EventHandler(this.cutsum_ValueChanged);
            // 
            // azsum
            // 
            this.azsum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.azsum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.azsum.BackgroundStyle.Class = "DateTimeInputBackground";
            this.azsum.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.azsum.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.azsum.ForeColor = System.Drawing.Color.Black;
            this.azsum.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left;
            this.azsum.Location = new System.Drawing.Point(140, 125);
            this.azsum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.azsum.MaxValue = 100;
            this.azsum.MinValue = 1;
            this.azsum.Name = "azsum";
            this.azsum.ShowUpDown = true;
            this.azsum.Size = new System.Drawing.Size(445, 26);
            this.azsum.TabIndex = 116;
            this.azsum.Value = 3;
            this.azsum.ValueChanged += new System.EventHandler(this.azsum_ValueChanged);
            // 
            // cut
            // 
            this.cut.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cut.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.cut.FocusCuesEnabled = false;
            this.cut.Location = new System.Drawing.Point(221, 495);
            this.cut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cut.Name = "cut";
            this.cut.Size = new System.Drawing.Size(155, 71);
            this.cut.TabIndex = 117;
            this.cut.Text = "分割";
            this.cut.Click += new System.EventHandler(this.cut_Click);
            // 
            // prog
            // 
            this.prog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.prog.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.prog.ForeColor = System.Drawing.Color.Black;
            this.prog.Location = new System.Drawing.Point(3, 574);
            this.prog.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.prog.Maximum = 10000;
            this.prog.Name = "prog";
            this.prog.Size = new System.Drawing.Size(590, 32);
            this.prog.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.prog.TabIndex = 120;
            this.prog.Text = "progressBarX1";
            // 
            // FrmCut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(597, 610);
            this.Controls.Add(this.prog);
            this.Controls.Add(this.cutch);
            this.Controls.Add(this.cut);
            this.Controls.Add(this.azsum);
            this.Controls.Add(this.cutsum);
            this.Controls.Add(this.r4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.addz);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.upfile);
            this.Controls.Add(this.r3);
            this.Controls.Add(this.r2);
            this.Controls.Add(this.r1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cutadd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmCut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CW File Viewer - 分割";
            this.Load += new System.EventHandler(this.FrmCut_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cutsum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.azsum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX finds;
        private DevComponents.DotNetBar.Controls.TextBoxX ficut;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private DevComponents.DotNetBar.Controls.CheckBoxX r42;
        private DevComponents.DotNetBar.Controls.CheckBoxX r41;
        private DevComponents.DotNetBar.Controls.CheckBoxX r4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private DevComponents.DotNetBar.Controls.CheckBoxX addz;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private DevComponents.DotNetBar.Controls.CheckBoxX upfile;
        private DevComponents.DotNetBar.Controls.CheckBoxX r3;
        private DevComponents.DotNetBar.Controls.CheckBoxX r2;
        private DevComponents.DotNetBar.Controls.CheckBoxX r1;
        public DevComponents.DotNetBar.Controls.TextBoxX cutch;
        public System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.Controls.TextBoxX cutadd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private DevComponents.Editors.IntegerInput cutsum;
        private DevComponents.Editors.IntegerInput azsum;
        private DevComponents.DotNetBar.ButtonX cut;
        private DevComponents.DotNetBar.Controls.ProgressBarX prog;
    }
}