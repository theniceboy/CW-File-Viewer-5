using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Speech.Synthesis;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace CW_File_Viewer_5
{
    public partial class FrmTagPageMan_CopyPage : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FrmTagPageMan_CopyPage()
        {
            InitializeComponent();
        }

        private ButtonX nowselect;

        private void sys_CheckedChanged(object sender, EventArgs e)
        {
            if (((ButtonX)sender).Checked)
                nowselect = (ButtonX)sender;
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

        private void FrmTagPageMan_CopyPage_Load(object sender, EventArgs e)
        {
            this.mainlayout.BackColor = Color.White;
            for (int i = 0; i < Gib.tsn; ++i)
                if (i != Gib.nowsysi)
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
                    if (i == 0)
                        sys.Checked = true;
                    sys.MouseDown += new System.Windows.Forms.MouseEventHandler(sys_MouseDown);
                    this.mainlayout.Controls.Add(sys);
                }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void copytag ( string tagname, string taginfo, int tagpage )
        {
            int i, j, t = (int)nowselect.Tag, x = 0, y = Gib.ts[t].tagn;
            bool bj, flag, fd;
            for (i = 0; i < Gib.ts[t].tagn; ++i)
                if (Gib.ts[t].alltag[i] == tagname)
                {
                    y = i;
                    break;
                }
            if (y != Gib.ts[t].tagn)
                if (
                    MessageBoxEx.Show(this, "标签“" + tagname + "”已在目标系统中存在，是否继续", "提示", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning,
                        MessageBoxDefaultButton.Button2) == DialogResult.No)
                    return;
            for (i = 0; i < Gib.ts[Gib.nowsysi].ftagn; ++i)
            {
                bj = false;
                for (j = 0; j < Gib.ts[Gib.nowsysi].ftags[i]; ++j)
                    if (Gib.ts[Gib.nowsysi].ftagname[i, j] == tagname)
                    {
                        bj = true;
                        break;
                    }
                if (bj)
                {
                    flag = false;
                    for (j = 0; j < Gib.ts[t].ftagn; ++j)
                        if (Gib.ts[t].ftagpath[j] == Gib.ts[Gib.nowsysi].ftagpath[i])
                        {
                            flag = true;
                            x = j;
                            break;
                        }
                    if (flag)
                    {
                        fd = true;
                        for (j = 0; j < Gib.ts[t].ftags[x]; ++j)
                            if (Gib.ts[t].ftagname[x, j] == tagname)
                            {
                                fd = false;
                                break;
                            }
                        if (fd)
                        {
                            Gib.ts[t].ftagname[x, Gib.ts[t].ftags[x]] = tagname;
                            ++Gib.ts[t].ftags[x];
                        }
                    }
                    else
                    {
                        Gib.ts[t].ftagpath[Gib.ts[t].ftagn] = Gib.ts[Gib.nowsysi].ftagpath[i];
                        Gib.ts[t].ftags[Gib.ts[t].ftagn] = 1;
                        Gib.ts[t].ftagname[Gib.ts[t].ftagn, 0] = tagname;
                        ++Gib.ts[t].ftagn;
                    }
                }
            }
            if (y == Gib.ts[t].tagn)
            {
                Gib.ts[t].alltag[y] = tagname;
                Gib.ts[t].tagp[y] = tagpage;
                Gib.ts[t].taginfo[y] = taginfo;
                ++Gib.ts[t].tagn;
            }
        }

        private void ok_Click(object sender, EventArgs e)
        {
            int i, t = (int) nowselect.Tag, k = 0;
            bool bj = false;
            for (i = 0; i < Gib.ts[t].pagen; ++i)
                if (Gib.crossbutton1.Text == Gib.ts[t].allpage[i])
                {
                    k = i;
                    bj = true;
                    break;
                }
            if (bj)
                if (
                    MessageBoxEx.Show(this, "标签页“" + Gib.crossbutton1.Text + "”已在目标系统中存在，是否继续", "提示",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
                        MessageBoxDefaultButton.Button2) == DialogResult.No)
                    return;

            int page;
            if (bj)
                page = k;
            else
            {
                Gib.ts[t].allpage[Gib.ts[t].pagen] = Gib.crossbutton1.Text;
                page = Gib.ts[t].pagen++;
            }

            for (i = 0; i < Gib.ts[Gib.nowsysi].tagn; ++i)
                if (Gib.ts[Gib.nowsysi].tagp[i] == (int)Gib.crossbutton1.Tag)
                    copytag(Gib.ts[Gib.nowsysi].alltag[i], Gib.ts[Gib.nowsysi].taginfo[i], page);

            this.Close();
        }
    }
}