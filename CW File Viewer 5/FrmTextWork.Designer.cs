namespace CW_File_Viewer_5
{
    partial class FrmTextWork
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTextWork));
            this.TurnYellow = new DevComponents.DotNetBar.ButtonX();
            this.Italic = new DevComponents.DotNetBar.ButtonX();
            this.Bold = new DevComponents.DotNetBar.ButtonX();
            this.Underline = new DevComponents.DotNetBar.ButtonX();
            this.colorPicker = new DevComponents.DotNetBar.ColorPickerButton();
            this.DelFormat = new DevComponents.DotNetBar.ButtonX();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.TurnPink = new DevComponents.DotNetBar.ButtonX();
            this.ChooseFont = new DevComponents.DotNetBar.ButtonX();
            this.TurnRed = new DevComponents.DotNetBar.ButtonX();
            this.tmv = new System.Windows.Forms.Timer(this.components);
            this.TurnOrange = new DevComponents.DotNetBar.ButtonX();
            this.Tone2 = new DevComponents.DotNetBar.ButtonX();
            this.Tone1 = new DevComponents.DotNetBar.ButtonX();
            this.TextSize = new DevComponents.DotNetBar.TextBoxItem();
            this.SuspendLayout();
            // 
            // TurnYellow
            // 
            this.TurnYellow.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.TurnYellow.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.TurnYellow.FocusCuesEnabled = false;
            this.TurnYellow.Location = new System.Drawing.Point(72, 4);
            this.TurnYellow.Name = "TurnYellow";
            this.TurnYellow.Size = new System.Drawing.Size(33, 27);
            this.TurnYellow.Symbol = "";
            this.TurnYellow.SymbolColor = System.Drawing.Color.Yellow;
            this.TurnYellow.SymbolSize = 10F;
            this.TurnYellow.TabIndex = 0;
            this.TurnYellow.Click += new System.EventHandler(this.TurnYellow_Click);
            // 
            // Italic
            // 
            this.Italic.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.Italic.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.Italic.FocusCuesEnabled = false;
            this.Italic.Location = new System.Drawing.Point(127, 37);
            this.Italic.Name = "Italic";
            this.Italic.Size = new System.Drawing.Size(27, 27);
            this.Italic.Symbol = "";
            this.Italic.SymbolSize = 10F;
            this.Italic.TabIndex = 0;
            this.Italic.Click += new System.EventHandler(this.Style_Click);
            // 
            // Bold
            // 
            this.Bold.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.Bold.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.Bold.FocusCuesEnabled = false;
            this.Bold.Location = new System.Drawing.Point(94, 37);
            this.Bold.Name = "Bold";
            this.Bold.Size = new System.Drawing.Size(27, 27);
            this.Bold.Symbol = "";
            this.Bold.SymbolSize = 10F;
            this.Bold.TabIndex = 0;
            this.Bold.Click += new System.EventHandler(this.Style_Click);
            // 
            // Underline
            // 
            this.Underline.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.Underline.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.Underline.FocusCuesEnabled = false;
            this.Underline.Location = new System.Drawing.Point(160, 37);
            this.Underline.Name = "Underline";
            this.Underline.Size = new System.Drawing.Size(27, 27);
            this.Underline.Symbol = "";
            this.Underline.SymbolSize = 10F;
            this.Underline.TabIndex = 0;
            this.Underline.Click += new System.EventHandler(this.Style_Click);
            // 
            // colorPicker
            // 
            this.colorPicker.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.colorPicker.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.colorPicker.FocusCuesEnabled = false;
            this.colorPicker.Image = ((System.Drawing.Image)(resources.GetObject("colorPicker.Image")));
            this.colorPicker.Location = new System.Drawing.Point(49, 37);
            this.colorPicker.Name = "colorPicker";
            this.colorPicker.SelectedColorImageRectangle = new System.Drawing.Rectangle(2, 2, 12, 12);
            this.colorPicker.Size = new System.Drawing.Size(39, 27);
            this.colorPicker.TabIndex = 4;
            this.colorPicker.SelectedColorChanged += new System.EventHandler(this.colorPicker_SelectedColorChanged);
            // 
            // DelFormat
            // 
            this.DelFormat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.DelFormat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.DelFormat.FocusCuesEnabled = false;
            this.DelFormat.Location = new System.Drawing.Point(193, 37);
            this.DelFormat.Name = "DelFormat";
            this.DelFormat.Size = new System.Drawing.Size(36, 27);
            this.DelFormat.Symbol = "";
            this.DelFormat.SymbolSize = 10F;
            this.DelFormat.TabIndex = 0;
            this.DelFormat.Click += new System.EventHandler(this.DelFormat_Click);
            // 
            // fontDialog
            // 
            this.fontDialog.Font = new System.Drawing.Font("SimSun", 12F);
            // 
            // TurnPink
            // 
            this.TurnPink.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.TurnPink.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.TurnPink.FocusCuesEnabled = false;
            this.TurnPink.Location = new System.Drawing.Point(189, 4);
            this.TurnPink.Name = "TurnPink";
            this.TurnPink.Size = new System.Drawing.Size(40, 27);
            this.TurnPink.Symbol = "";
            this.TurnPink.SymbolColor = System.Drawing.Color.HotPink;
            this.TurnPink.SymbolSize = 10F;
            this.TurnPink.TabIndex = 0;
            this.TurnPink.Click += new System.EventHandler(this.TurnPink_Click);
            // 
            // ChooseFont
            // 
            this.ChooseFont.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ChooseFont.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ChooseFont.FocusCuesEnabled = false;
            this.ChooseFont.Location = new System.Drawing.Point(4, 37);
            this.ChooseFont.Name = "ChooseFont";
            this.ChooseFont.Size = new System.Drawing.Size(39, 27);
            this.ChooseFont.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.TextSize});
            this.ChooseFont.Symbol = "";
            this.ChooseFont.SymbolSize = 10F;
            this.ChooseFont.TabIndex = 0;
            this.ChooseFont.Click += new System.EventHandler(this.ChooseFont_Click);
            // 
            // TurnRed
            // 
            this.TurnRed.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.TurnRed.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.TurnRed.FocusCuesEnabled = false;
            this.TurnRed.Location = new System.Drawing.Point(111, 4);
            this.TurnRed.Name = "TurnRed";
            this.TurnRed.Size = new System.Drawing.Size(33, 27);
            this.TurnRed.Symbol = "";
            this.TurnRed.SymbolColor = System.Drawing.Color.Red;
            this.TurnRed.SymbolSize = 10F;
            this.TurnRed.TabIndex = 0;
            this.TurnRed.Click += new System.EventHandler(this.TurnRed_Click);
            // 
            // tmv
            // 
            this.tmv.Enabled = true;
            this.tmv.Tick += new System.EventHandler(this.tmv_Tick);
            // 
            // TurnOrange
            // 
            this.TurnOrange.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.TurnOrange.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.TurnOrange.FocusCuesEnabled = false;
            this.TurnOrange.Location = new System.Drawing.Point(150, 4);
            this.TurnOrange.Name = "TurnOrange";
            this.TurnOrange.Size = new System.Drawing.Size(33, 27);
            this.TurnOrange.Symbol = "";
            this.TurnOrange.SymbolColor = System.Drawing.Color.Orange;
            this.TurnOrange.SymbolSize = 10F;
            this.TurnOrange.TabIndex = 0;
            this.TurnOrange.Click += new System.EventHandler(this.TurnOrange_Click);
            // 
            // Tone2
            // 
            this.Tone2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.Tone2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.Tone2.FocusCuesEnabled = false;
            this.Tone2.Location = new System.Drawing.Point(38, 4);
            this.Tone2.Name = "Tone2";
            this.Tone2.Size = new System.Drawing.Size(28, 27);
            this.Tone2.SymbolColor = System.Drawing.Color.Orange;
            this.Tone2.SymbolSize = 10F;
            this.Tone2.TabIndex = 0;
            this.Tone2.Text = "2";
            this.Tone2.Click += new System.EventHandler(this.Tone2_Click);
            // 
            // Tone1
            // 
            this.Tone1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.Tone1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.Tone1.FocusCuesEnabled = false;
            this.Tone1.Location = new System.Drawing.Point(4, 4);
            this.Tone1.Name = "Tone1";
            this.Tone1.Size = new System.Drawing.Size(28, 27);
            this.Tone1.SymbolColor = System.Drawing.Color.Orange;
            this.Tone1.SymbolSize = 10F;
            this.Tone1.TabIndex = 0;
            this.Tone1.Text = "1";
            this.Tone1.Click += new System.EventHandler(this.Tone1_Click);
            // 
            // TextSize
            // 
            this.TextSize.GlobalItem = false;
            this.TextSize.MaxLength = 3;
            this.TextSize.Name = "TextSize";
            this.TextSize.TextBoxWidth = 50;
            this.TextSize.WatermarkColor = System.Drawing.SystemColors.GrayText;
            this.TextSize.InputTextChanged += new DevComponents.DotNetBar.TextBoxItem.TextChangedEventHandler(this.TextSize_InputTextChanged);
            // 
            // FrmTextWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 69);
            this.Controls.Add(this.colorPicker);
            this.Controls.Add(this.Bold);
            this.Controls.Add(this.ChooseFont);
            this.Controls.Add(this.DelFormat);
            this.Controls.Add(this.Underline);
            this.Controls.Add(this.Italic);
            this.Controls.Add(this.TurnRed);
            this.Controls.Add(this.TurnPink);
            this.Controls.Add(this.Tone1);
            this.Controls.Add(this.Tone2);
            this.Controls.Add(this.TurnOrange);
            this.Controls.Add(this.TurnYellow);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(233, 69);
            this.MinimumSize = new System.Drawing.Size(233, 69);
            this.Name = "FrmTextWork";
            this.Opacity = 0.5D;
            this.Text = "CW File Viewer - 文本批注";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmTextWork_FormClosing);
            this.Load += new System.EventHandler(this.FrmTextWork_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX TurnYellow;
        private DevComponents.DotNetBar.ButtonX Italic;
        private DevComponents.DotNetBar.ButtonX Bold;
        private DevComponents.DotNetBar.ButtonX Underline;
        private DevComponents.DotNetBar.ColorPickerButton colorPicker;
        private DevComponents.DotNetBar.ButtonX DelFormat;
        private System.Windows.Forms.FontDialog fontDialog;
        private DevComponents.DotNetBar.ButtonX TurnPink;
        private DevComponents.DotNetBar.ButtonX ChooseFont;
        private DevComponents.DotNetBar.ButtonX TurnRed;
        private System.Windows.Forms.Timer tmv;
        private DevComponents.DotNetBar.TextBoxItem TextSize;
        private DevComponents.DotNetBar.ButtonX TurnOrange;
        private DevComponents.DotNetBar.ButtonX Tone2;
        private DevComponents.DotNetBar.ButtonX Tone1;
    }
}