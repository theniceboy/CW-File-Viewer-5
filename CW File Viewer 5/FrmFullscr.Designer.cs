namespace CW_File_Viewer_5
{
    partial class FrmFullscr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFullscr));
            this.lrcv = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.fsbig = new DevComponents.DotNetBar.ButtonX();
            this.fssmall = new DevComponents.DotNetBar.ButtonX();
            this.wtsize = new DevComponents.Editors.IntegerInput();
            this.rtfv = new DevComponents.DotNetBar.Controls.RichTextBoxEx();
            this.metroShell1 = new DevComponents.DotNetBar.Metro.MetroShell();
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.wtsize)).BeginInit();
            this.SuspendLayout();
            // 
            // lrcv
            // 
            this.lrcv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lrcv.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.lrcv.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lrcv.DisabledBackColor = System.Drawing.Color.White;
            this.lrcv.Font = new System.Drawing.Font("SimSun", 12F);
            this.lrcv.ForeColor = System.Drawing.Color.Black;
            this.lrcv.Location = new System.Drawing.Point(0, 29);
            this.lrcv.MaxLength = 2147483647;
            this.lrcv.Multiline = true;
            this.lrcv.Name = "lrcv";
            this.lrcv.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.lrcv.Size = new System.Drawing.Size(1033, 491);
            this.lrcv.TabIndex = 0;
            this.lrcv.TextChanged += new System.EventHandler(this.lrcv_TextChanged);
            // 
            // fsbig
            // 
            this.fsbig.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.fsbig.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.fsbig.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.fsbig.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.fsbig.Location = new System.Drawing.Point(409, 521);
            this.fsbig.Name = "fsbig";
            this.fsbig.Size = new System.Drawing.Size(95, 25);
            this.fsbig.TabIndex = 1;
            this.fsbig.Text = "大（22pt）";
            this.fsbig.Click += new System.EventHandler(this.fsbig_Click);
            // 
            // fssmall
            // 
            this.fssmall.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.fssmall.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.fssmall.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.fssmall.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.fssmall.Location = new System.Drawing.Point(512, 521);
            this.fssmall.Name = "fssmall";
            this.fssmall.Size = new System.Drawing.Size(95, 25);
            this.fssmall.TabIndex = 2;
            this.fssmall.Text = "小（12pt）";
            this.fssmall.Click += new System.EventHandler(this.fssmall_Click);
            // 
            // wtsize
            // 
            this.wtsize.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.wtsize.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.wtsize.BackgroundStyle.Class = "DateTimeInputBackground";
            this.wtsize.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.wtsize.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.wtsize.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.wtsize.ForeColor = System.Drawing.Color.Black;
            this.wtsize.Location = new System.Drawing.Point(613, 521);
            this.wtsize.MaxValue = 10000;
            this.wtsize.MinValue = 1;
            this.wtsize.Name = "wtsize";
            this.wtsize.ShowUpDown = true;
            this.wtsize.Size = new System.Drawing.Size(44, 26);
            this.wtsize.TabIndex = 3;
            this.wtsize.Value = 12;
            this.wtsize.ValueChanged += new System.EventHandler(this.wtsize_ValueChanged);
            // 
            // rtfv
            // 
            this.rtfv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtfv.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.rtfv.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.rtfv.Font = new System.Drawing.Font("SimSun", 12F);
            this.rtfv.ForeColor = System.Drawing.Color.Black;
            this.rtfv.Location = new System.Drawing.Point(0, 29);
            this.rtfv.Name = "rtfv";
            this.rtfv.Rtf = "{\\rtf1\\ansi\\ansicpg936\\deff0\\deflang1033\\deflangfe2052{\\fonttbl{\\f0\\fnil\\fcharset" +
    "134 \\\'cb\\\'ce\\\'cc\\\'e5;}}\r\n\\viewkind4\\uc1\\pard\\lang2052\\f0\\fs24\\par\r\n}\r\n";
            this.rtfv.Size = new System.Drawing.Size(1033, 491);
            this.rtfv.TabIndex = 4;
            this.rtfv.TextChanged += new System.EventHandler(this.rtfv_TextChanged);
            // 
            // metroShell1
            // 
            this.metroShell1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.metroShell1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroShell1.CaptionVisible = true;
            this.metroShell1.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroShell1.ForeColor = System.Drawing.Color.Black;
            this.metroShell1.HelpButtonText = null;
            this.metroShell1.HelpButtonVisible = false;
            this.metroShell1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem1});
            this.metroShell1.KeyTipsFont = new System.Drawing.Font("Tahoma", 7F);
            this.metroShell1.Location = new System.Drawing.Point(1, 1);
            this.metroShell1.Name = "metroShell1";
            this.metroShell1.SettingsButtonVisible = false;
            this.metroShell1.Size = new System.Drawing.Size(1032, 28);
            this.metroShell1.SystemText.MaximizeRibbonText = "&Maximize the Ribbon";
            this.metroShell1.SystemText.MinimizeRibbonText = "Mi&nimize the Ribbon";
            this.metroShell1.SystemText.QatAddItemText = "&Add to Quick Access Toolbar";
            this.metroShell1.SystemText.QatCustomizeMenuLabel = "<b>Customize Quick Access Toolbar</b>";
            this.metroShell1.SystemText.QatCustomizeText = "&Customize Quick Access Toolbar...";
            this.metroShell1.SystemText.QatDialogAddButton = "&Add >>";
            this.metroShell1.SystemText.QatDialogCancelButton = "Cancel";
            this.metroShell1.SystemText.QatDialogCaption = "Customize Quick Access Toolbar";
            this.metroShell1.SystemText.QatDialogCategoriesLabel = "&Choose commands from:";
            this.metroShell1.SystemText.QatDialogOkButton = "OK";
            this.metroShell1.SystemText.QatDialogPlacementCheckbox = "&Place Quick Access Toolbar below the Ribbon";
            this.metroShell1.SystemText.QatDialogRemoveButton = "&Remove";
            this.metroShell1.SystemText.QatPlaceAboveRibbonText = "&Place Quick Access Toolbar above the Ribbon";
            this.metroShell1.SystemText.QatPlaceBelowRibbonText = "&Place Quick Access Toolbar below the Ribbon";
            this.metroShell1.SystemText.QatRemoveItemText = "&Remove from Quick Access Toolbar";
            this.metroShell1.TabIndex = 121;
            this.metroShell1.TabStripFont = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroShell1.Text = "metroShell1";
            // 
            // buttonItem1
            // 
            this.buttonItem1.Name = "buttonItem1";
            this.buttonItem1.Text = "buttonItem1";
            // 
            // FrmFullscr
            // 
            this.ClientSize = new System.Drawing.Size(1034, 548);
            this.Controls.Add(this.metroShell1);
            this.Controls.Add(this.wtsize);
            this.Controls.Add(this.fssmall);
            this.Controls.Add(this.fsbig);
            this.Controls.Add(this.lrcv);
            this.Controls.Add(this.rtfv);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmFullscr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CW File Viewer - Full Screen View";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmFullscr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wtsize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX lrcv;
        private DevComponents.DotNetBar.ButtonX fsbig;
        private DevComponents.DotNetBar.ButtonX fssmall;
        private DevComponents.Editors.IntegerInput wtsize;
        private DevComponents.DotNetBar.Controls.RichTextBoxEx rtfv;
        private DevComponents.DotNetBar.Metro.MetroShell metroShell1;
        private DevComponents.DotNetBar.ButtonItem buttonItem1;

    }
}