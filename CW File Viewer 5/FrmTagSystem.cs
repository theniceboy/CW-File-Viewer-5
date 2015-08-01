using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace CW_File_Viewer_5
{
    public partial class FrmTagSystem : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FrmTagSystem()
        {
            InitializeComponent();
        }

        private ButtonX nowselect;

        private void sys_CheckedChanged(object sender, EventArgs e)
        {
            if (((ButtonX)sender).Checked)
                nowselect = (ButtonX)sender;
            name.Text = nowselect.Text;
        }

        private void sys_MouseDown(object sender, MouseEventArgs e)
        {
            if (nowselect != (ButtonX)sender)
            {
                if (nowselect != null)
                    nowselect.Checked = false;
                nowselect = ((ButtonX)sender);
                nowselect.Checked = true;
            }
        }

        private int getlen(string str)
        {
            char[] a = str.ToCharArray();
            int la = str.Length, i, len = 0;
            for (i = 0; i < la; ++i)
                if (a[i] < 128)
                    ++len;
                else
                    len += 2;
            return len;
        }

        private void FrmTagSystem_Load(object sender, EventArgs e)
        {
            this.mainlayout.BackColor = Color.White;
            for (int i = 0; i < Gib.tsn; ++i)
            {
                ButtonX sys = new ButtonX();
                sys.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
                sys.Size = new Size(9*getlen(Gib.ts[i].name) + 10, 27);
                sys.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro;
                sys.Font = new Font("Consolas", 9F);
                sys.FocusCuesEnabled = false;
                sys.Tag = i;
                sys.Text = Gib.ts[i].name;
                sys.CheckedChanged += new System.EventHandler(sys_CheckedChanged);
                if (i == Gib.nowsysi)
                    sys.Checked = true;
                if (i == Gib.defsysi)
                    sys.Font = new Font("Consolas", 9F, FontStyle.Bold);
                sys.MouseDown += new System.Windows.Forms.MouseEventHandler(sys_MouseDown);
                this.mainlayout.Controls.Add(sys);
            }
        }

        private void choose_Click(object sender, EventArgs e)
        {
            Gib.nowsysi = (int) nowselect.Tag;
            this.Close();
        }

        private void newsys_Click(object sender, EventArgs e)
        {
            string str = name.Text.Trim();
            if (Directory.Exists("C:\\ProgramData\\CW Soft\\CW File Viewer\\TagSystem\\" + str))
            {
                this.highlighter.SetHighlightColor(this.name, DevComponents.DotNetBar.Validator.eHighlightColor.Red);
                this.errorProvider.SetError(this.name, "标签系统已存在！");
            }
            else
            {
                Directory.CreateDirectory("C:\\ProgramData\\CW Soft\\CW File Viewer\\TagSystem\\" + str);
                File.WriteAllText("C:\\ProgramData\\CW Soft\\CW File Viewer\\TagSystem\\" + str + "\\AllPage.txt", "");
                File.WriteAllText("C:\\ProgramData\\CW Soft\\CW File Viewer\\TagSystem\\" + str + "\\AllTag.txt", "");
                File.WriteAllText("C:\\ProgramData\\CW Soft\\CW File Viewer\\TagSystem\\" + str + "\\TagName.txt", "");
                File.WriteAllText("C:\\ProgramData\\CW Soft\\CW File Viewer\\TagSystem\\" + str + "\\TagPage.txt", "");
                File.WriteAllText("C:\\ProgramData\\CW Soft\\CW File Viewer\\TagSystem\\" + str + "\\TagPath.txt", "");
                Directory.CreateDirectory("C:\\ProgramData\\CW Soft\\CW File Viewer\\TagSystem\\" + str + "\\TagInfo");

                ButtonX sys = new ButtonX();
                sys.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
                sys.Size = new Size(9*getlen(str) + 10, 27);
                sys.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro;
                sys.Font = new Font("Consolas", 9F);
                sys.FocusCuesEnabled = false;
                sys.Tag = Gib.tsn;
                sys.Text = str;
                sys.CheckedChanged += new System.EventHandler(sys_CheckedChanged);
                sys.MouseDown += new System.Windows.Forms.MouseEventHandler(sys_MouseDown);

                Gib.ts[Gib.tsn++].name = str;
                this.mainlayout.Controls.Add(sys);
            }
        }

        private void set_Click(object sender, EventArgs e)
        {
            File.WriteAllText("C:\\ProgramData\\CW Soft\\CW File Viewer\\DefaultTagSystem.txt", ((int) nowselect.Tag).ToString());
            foreach (ButtonX sys in this.mainlayout.Controls)
            {
                if ((int) sys.Tag == Gib.defsysi)
                {
                    sys.Font = new Font("Consolas", 9F);
                    break;
                }
            }
            nowselect.Font = new Font("Consolas", 9F, FontStyle.Bold);
            Gib.defsysi = (int) nowselect.Tag;
        }

        private void rename_Click(object sender, EventArgs e)
        {
            if (Directory.Exists("C:\\ProgramData\\CW Soft\\CW File Viewer\\TagSystem\\" + name.Text))
            {
                this.highlighter.SetHighlightColor(this.name, DevComponents.DotNetBar.Validator.eHighlightColor.Red);
                this.errorProvider.SetError(this.name, "标签系统已存在！");
            }
            else
            {
                Directory.Move("C:\\ProgramData\\CW Soft\\CW File Viewer\\TagSystem\\" + nowselect.Text,
                    "C:\\ProgramData\\CW Soft\\CW File Viewer\\TagSystem\\" + name.Text);
                for (int i = 0; i < Gib.tsn; ++i)
                    if (Gib.ts[i].name == nowselect.Text)
                    {
                        Gib.ts[i].name = name.Text;
                        break;
                    }
                nowselect.Text = name.Text;
            }
        }

        private void FrmTagSystem_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmMain frm = (FrmMain) this.Owner;
            frm.refreshts();
        }
    }
}