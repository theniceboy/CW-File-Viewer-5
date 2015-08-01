using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace CW_File_Viewer_5
{
    public partial class FrmTagCopy : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FrmTagCopy()
        {
            InitializeComponent();
        }


        private ButtonX nowselect;
        private int nowpage;
        private bool dosel;

        private void sys_CheckedChanged(object sender, EventArgs e)
        {
            if (((ButtonX) sender).Checked)
            {
                dosel = false;
                nowselect = (ButtonX) sender;
                choosepage.Items.Clear();
                for (int i = 0; i < Gib.ts[(int) nowselect.Tag].pagen; ++i)
                {
                    ComboBoxItem page = new ComboBoxItem();
                    page.Text = Gib.ts[(int) nowselect.Tag].allpage[i];
                    page.Tag = i;
                    this.choosepage.Items.Add(page);
                }
            }
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

        private void FrmTagCopy_Load(object sender, EventArgs e)
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
                    if (i == Gib.nowsysi)
                        sys.Font = new Font("Consolas", 9F, FontStyle.Bold);
                    sys.MouseDown += new System.Windows.Forms.MouseEventHandler(sys_MouseDown);
                    this.mainlayout.Controls.Add(sys);
                    if (i == 0)
                        sys.Checked = true;
                }
        }

        private void ok_Click(object sender, EventArgs e)
        {
            if (dosel)
            {
                int i, j, k, t = (int) nowselect.Tag, x = 0, y = Gib.ts[t].tagn;
                bool bj, flag, fd;
                for (i = 0; i < Gib.ts[t].tagn; ++i)
                    if (Gib.ts[t].alltag[i] == Gib.crossfile4)
                    {
                        y = i;
                        break;
                    }
                if (y != Gib.ts[t].tagn)
                    if (
                        MessageBoxEx.Show(this, "标签已存在，是否继续", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
                            MessageBoxDefaultButton.Button2) == DialogResult.No)
                        return;
                for (i = 0; i < Gib.ts[Gib.nowsysi].ftagn; ++i)
                {
                    bj = false;
                    for (j = 0; j < Gib.ts[Gib.nowsysi].ftags[i]; ++j)
                        if (Gib.ts[Gib.nowsysi].ftagname[i, j] == Gib.crossfile4)
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
                                if (Gib.ts[t].ftagname[x, j] == Gib.crossfile4)
                                {
                                    fd = false;
                                    break;
                                }
                            if (fd)
                            {
                                Gib.ts[t].ftagname[x, Gib.ts[t].ftags[x]] = Gib.crossfile4;
                                ++Gib.ts[t].ftags[x];
                            }

                        }
                        else
                        {
                            Gib.ts[t].ftagpath[Gib.ts[t].ftagn] = Gib.ts[Gib.nowsysi].ftagpath[i];
                            Gib.ts[t].ftags[Gib.ts[t].ftagn] = 1;
                            Gib.ts[t].ftagname[Gib.ts[t].ftagn, 0] = Gib.crossfile4;
                            ++Gib.ts[t].ftagn;
                        }
                    }
                }
                if (y == Gib.ts[t].tagn)
                {
                    Gib.ts[t].alltag[y] = Gib.crossfile4;
                    Gib.ts[t].tagp[y] = nowpage;
                    Gib.ts[t].taginfo[y] = Gib.crossfile5;
                    ++Gib.ts[t].tagn;
                }
                this.Close();
            }
            else
            {
                this.highlighter.SetHighlightColor(this.choosepage,
                    DevComponents.DotNetBar.Validator.eHighlightColor.Red);
                this.errorProvider.SetError(this.choosepage, "请选择拷贝目标页！");
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void choosepage_SelectedIndexChanged(object sender, EventArgs e)
        {
            dosel = true;
            nowpage = (int) ((ComboBoxItem) this.choosepage.SelectedItem).Tag;
        }
    }
}