using System;
using System.Drawing;
using System.Linq.Expressions;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Windows.Forms;
using System.IO;
using DevComponents.DotNetBar;

namespace CW_File_Viewer_5
{
    public partial class FrmSearch : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FrmSearch()
        {
            InitializeComponent();
        }

        private string[] slctag = new string[5000];
        private string[] print = new string[50000];
        private int slcn, printn, way = -1, cts = 0;

        int getlen(string str)
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

        void tagbutton_Click(object sender, EventArgs e)
        {
            ((ButtonX)sender).Checked = !(((ButtonX)sender).Checked);
            if (((ButtonX) sender).Checked)
                ++cts;
            else
                --cts;
            if (cts > 0)
            {
                if (way != 1)
                    this.highlighter.SetHighlightColor(this.layoutmain,
                        DevComponents.DotNetBar.Validator.eHighlightColor.Orange);
                way = 1;
                this.highlighter.SetHighlightColor(this.searchfile, DevComponents.DotNetBar.Validator.eHighlightColor.None);
                this.highlighter.SetHighlightColor(this.infile, DevComponents.DotNetBar.Validator.eHighlightColor.None);
                way1.Checked = way2.Checked = false;
            }
            else
            {
                this.highlighter.SetHighlightColor(this.layoutmain, DevComponents.DotNetBar.Validator.eHighlightColor.None);
                way = -1;
            }
        }

        private void loadtag()
        {
            int i;

            for (i = 0; i < Gib.ts[Gib.nowsysi].tagn; ++i)
            {
                ButtonX tagbutton = new ButtonX();
                tagbutton.Font = new Font("Consolas", 8F);
                tagbutton.Location = new Point(3, 3);
                tagbutton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
                tagbutton.Size = new Size(8 * getlen(Gib.ts[Gib.nowsysi].alltag[i]) + 10, 25);
                tagbutton.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro;
                tagbutton.FocusCuesEnabled = false;
                tagbutton.Text = Gib.ts[Gib.nowsysi].alltag[i];
                tagbutton.Click += new System.EventHandler(tagbutton_Click);

                this.layoutmain.Controls.Add(tagbutton);
            }
        }


        private void filev_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (filev.SelectedItems.Count > 0)
            {
                FrmMain frm = (FrmMain) this.Owner;
                if (Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]] !=
                    Path.GetDirectoryName(print[(int) filev.SelectedItems[0].Tag]))
                {
                    Gib.fpos[Gib.nowtab, ++Gib.nowp[Gib.nowtab]] =
                        Path.GetDirectoryName(print[(int)filev.SelectedItems[0].Tag]);
                    Gib.maxn[Gib.nowtab] = Gib.maxn[Gib.nowtab] > Gib.nowp[Gib.nowtab]
                        ? Gib.maxn[Gib.nowtab]
                        : Gib.nowp[Gib.nowtab];
                    frm.reffile(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]]);
                }
                Gib.fname = Path.GetFileName(print[(int) filev.SelectedItems[0].Tag]);
                frm.isleftkey = true; 
                frm.loadfile();
            }
        }

        private void FrmSearch_Load(object sender, EventArgs e)
        {
            string temp;
            int tnum;
            for (i = 0; i < Gib.ts[Gib.nowsysi].tagn; ++i)
                for (j = i + 1; j < Gib.ts[Gib.nowsysi].tagn; ++j)
                    if (String.Compare(Gib.ts[Gib.nowsysi].alltag[i], Gib.ts[Gib.nowsysi].alltag[j]) > 0)
                    {
                        temp = Gib.ts[Gib.nowsysi].alltag[i];
                        Gib.ts[Gib.nowsysi].alltag[i] = Gib.ts[Gib.nowsysi].alltag[j];
                        Gib.ts[Gib.nowsysi].alltag[j] = temp;

                        tnum = Gib.ts[Gib.nowsysi].tagp[i];
                        Gib.ts[Gib.nowsysi].tagp[i] = Gib.ts[Gib.nowsysi].tagp[j];
                        Gib.ts[Gib.nowsysi].tagp[j] = tnum;

                        temp = Gib.ts[Gib.nowsysi].taginfo[i];
                        Gib.ts[Gib.nowsysi].taginfo[i] = Gib.ts[Gib.nowsysi].taginfo[j];
                        Gib.ts[Gib.nowsysi].taginfo[j] = temp;
                    }
            line1.ForeColor = line2.ForeColor = Color.DarkGray;
            layoutmain.BackColor = Color.White;
            loadtag();
        }

        private void search_Click(object sender, EventArgs e)
        {
            if (way < 0)
            {
                MessageBoxEx.Show("请选择搜索方式！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int i, j, k;
            slcn = printn = 0;
            filev.Items.Clear();
            if (way == 1)
            {
                foreach (ButtonX btag in this.layoutmain.Controls)
                    if (btag.Checked)
                        slctag[slcn++] = btag.Text;
                bool bj, bjw;
                for (i = 0; i < Gib.ts[Gib.nowsysi].ftagn; ++i)
                {
                    bj = true;
                    for (j = 0; j < slcn; ++j)
                    {
                        bjw = false;
                        for (k = 0; k < Gib.ts[Gib.nowsysi].ftags[i]; ++k)
                            if (Gib.ts[Gib.nowsysi].ftagname[i, k] == slctag[j])
                            {
                                bjw = true;
                                break;
                            }
                        if (bjw == false)
                        {
                            bj = false;
                            break;
                        }
                    }
                    if (bj && File.Exists(Gib.ts[Gib.nowsysi].ftagpath[i]))
                    {
                        print[printn] = Gib.ts[Gib.nowsysi].ftagpath[i];
                        ListViewItem pr = new ListViewItem(Path.GetFileName(print[printn]))
                        {
                            ToolTipText = print[printn],
                            Tag = printn
                        };
                        filev.Items.Add(pr);
                        ++printn;
                    }
                }
            }
            else if (way == 2)
            {
                string name = searchfile.Text.Trim();
                for (i = 0; i < Gib.ts[Gib.nowsysi].ftagn; ++i)
                    if (find(Path.GetFileName(Gib.ts[Gib.nowsysi].ftagpath[i]), name) && File.Exists(Gib.ts[Gib.nowsysi].ftagpath[i]))
                    {
                        print[printn] = Gib.ts[Gib.nowsysi].ftagpath[i];
                        ListViewItem pr = new ListViewItem(Path.GetFileName(print[printn]))
                        {
                            ToolTipText = print[printn],
                            Tag = printn
                        };
                        filev.Items.Add(pr);
                        ++printn;
                    }
            }
            else if (way == 3)
            {
                for (i = 0; i < Gib.ts[Gib.nowsysi].ftagn; ++i)
                {
                    if (File.Exists(Gib.ts[Gib.nowsysi].ftagpath[i]))
                        if (find(File.ReadAllText(Gib.ts[Gib.nowsysi].ftagpath[i], Encoding.GetEncoding("GB2312")),
                            infile.Text))
                        {
                            print[printn] = Gib.ts[Gib.nowsysi].ftagpath[i];
                            ListViewItem pr = new ListViewItem(Path.GetFileName(print[printn]))
                            {
                                ToolTipText = print[printn],
                                Tag = printn
                            };
                            filev.Items.Add(pr);
                            ++printn;
                        }
                }
            }
            else
            {
                MessageBox.Show("没点上，呵呵");
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (Gib.nowp[Gib.nowtab] > 0)
            {
                for (int i = 0; i < printn; ++i)
                    File.Copy(print[i], Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]] +'\\'+ Path.GetFileName(print[i]), true);
                FrmMain frm = (FrmMain)this.Owner;
                frm.reffile(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]]);
            }
            else
                MessageBoxEx.Show("未选择目录！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private int la, lb, i, j;
        private bool flag;

        bool find(string a, string b)
        {
            la = a.Length;
            lb = b.Length;
            if (la < lb)
                return false;
            for (i = 0; i < la - lb + 1; ++i)
            {
                flag = true;
                for (j = 0; j < lb; ++j)
                    if (a[i + j] != b[j])
                    {
                        flag = false;
                        break;
                    }
                if (flag)
                    return true;
            }
            return false;
        }

        private void searcht_Click(object sender, EventArgs e)
        {
            if (searchtext.Text != "")
                foreach (ButtonX btag in layoutmain.Controls)
                {
                    if (find(btag.Text, searchtext.Text))
                        btag.Font = new Font("Consolas", 9F, FontStyle.Bold);
                    else
                        btag.Font = new Font("Consolas", 9F);
                }
            else
                foreach (ButtonX btag in layoutmain.Controls)
                    btag.Font = new Font("Consolas", 9F);
        }

        private void showtag_Click(object sender, EventArgs e)
        {
            FrmMain frm = (FrmMain)this.Owner;
            frm.filetag_Click(sender, e);
            this.Close();
        }

        private void showtagplus_Click(object sender, EventArgs e)
        {
            Gib.doshowtag = true;
            FrmMain frm = (FrmMain)this.Owner;
            frm.filetag_Click(sender, e);
            this.Close();
        }

        private void way1_CheckedChanged(object sender, EventArgs e)
        {
            if (way1.Checked)
            {
                if (way != 2)
                    this.highlighter.SetHighlightColor(this.searchfile,
                        DevComponents.DotNetBar.Validator.eHighlightColor.Orange);
                this.highlighter.SetHighlightColor(this.layoutmain, DevComponents.DotNetBar.Validator.eHighlightColor.None);
                this.highlighter.SetHighlightColor(this.infile, DevComponents.DotNetBar.Validator.eHighlightColor.None);
                way = 2;
            }
            else
            {
                this.highlighter.SetHighlightColor(this.searchfile, DevComponents.DotNetBar.Validator.eHighlightColor.None);
                way = -1;
            }
        }

        private void way2_CheckedChanged(object sender, EventArgs e)
        {
            if (way2.Checked)
            {
                if (way != 3)
                    this.highlighter.SetHighlightColor(this.infile,
                        DevComponents.DotNetBar.Validator.eHighlightColor.Orange);
                this.highlighter.SetHighlightColor(this.layoutmain, DevComponents.DotNetBar.Validator.eHighlightColor.None);
                this.highlighter.SetHighlightColor(this.searchfile, DevComponents.DotNetBar.Validator.eHighlightColor.None);
                way = 3;
            }
            else
            {
                this.highlighter.SetHighlightColor(this.infile, DevComponents.DotNetBar.Validator.eHighlightColor.None);
                way = -1;
            }
        }
    }
}