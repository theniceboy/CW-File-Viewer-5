using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Security.AccessControl;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace CW_File_Viewer_5
{
    public partial class FrmTagPageMan : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FrmTagPageMan()
        {
            InitializeComponent();
        }

        private ButtonX nowselect;

        private void pageb_CheckedChanged(object sender, EventArgs e)
        {
            if (((ButtonX) sender).Checked)
                nowselect = (ButtonX) sender;
            pagename.Text = nowselect.Text;
        }

        private void pageb_MouseDown(object sender, MouseEventArgs e)
        {
            if (nowselect != (ButtonX) sender)
            {
                if (nowselect != null)
                    nowselect.Checked = false;
                nowselect = ((ButtonX) sender);
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

        private void FrmTagPageMan_Load(object sender, EventArgs e)
        {
            this.mainlayout.BackColor = Color.White;
            for (int i = 0; i < Gib.ts[Gib.nowsysi].pagen; ++i)
            {
                ButtonX pageb = new ButtonX();
                pageb.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
                pageb.Size = new Size(9 * getlen(Gib.ts[Gib.nowsysi].allpage[i]) + 10, 27);
                pageb.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro;
                pageb.Font = new Font("Consolas", 9F);
                pageb.FocusCuesEnabled = false;
                pageb.Text = Gib.ts[Gib.nowsysi].allpage[i];
                pageb.Tag = i;
                pageb.CheckedChanged += new System.EventHandler(pageb_CheckedChanged);
                pageb.MouseDown += new System.Windows.Forms.MouseEventHandler(pageb_MouseDown);
                pageb.ContextMenuStrip = rbmenu;
                this.mainlayout.Controls.Add(pageb);
            }
        }

        private void delpage_Click(object sender, EventArgs e)
        {
            Gib.crossbutton1 = nowselect;
            FrmTagPageMan_Del frm = new FrmTagPageMan_Del();
            frm.ShowDialog(this);
        }

        private void rename_Click(object sender, EventArgs e)
        {
            string name = pagename.Text.Trim();
            if (name != "")
            {
                int i;
                bool bj = true;
                for (i = 0; i < Gib.ts[Gib.nowsysi].pagen; ++i)
                    if (name == Gib.ts[Gib.nowsysi].allpage[i])
                    {
                        bj = false;
                        break;
                    }
                if (bj)
                {
                    nowselect.Text = name;
                    nowselect.Size = new Size(9 * getlen(name) + 10, 27);
                    Gib.ts[Gib.nowsysi].allpage[(int)nowselect.Tag] = name;
                }
                else
                {
                    this.highlighter.SetHighlightColor(this.pagename,
                        DevComponents.DotNetBar.Validator.eHighlightColor.Red);
                    this.errorProvider.SetError(this.pagename, "标签页已存在！");
                }
            }
            else
            {
                this.highlighter.SetHighlightColor(this.pagename, DevComponents.DotNetBar.Validator.eHighlightColor.Red);
                this.errorProvider.SetError(this.pagename, "标签页标题不得为空！");
            }
        }

        private void copypage_Click(object sender, EventArgs e)
        {
            Gib.crossbutton1 = nowselect;
            var frm = new FrmTagPageMan_CopyPage();
            frm.ShowDialog(this);
        }
    }
}