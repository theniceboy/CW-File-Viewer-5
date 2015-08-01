using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using DevComponents.DotNetBar;

namespace CW_File_Viewer_5
{
    public partial class FrmTag : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FrmTag()
        {
            InitializeComponent();
        }

        ButtonX rbtag=new ButtonX();
        private int nowpage = 0;
        private string addstr;

        int getlen(string str)
        {
            char[] a = str.ToCharArray();
            int la = str.Length, i,len=0;
            for (i = 0; i < la; ++i)
                if (a[i] < 128)
                    ++len;
                else
                    len += 2;
            return len;
        }

        void tagbutton_Click(object sender, EventArgs e)
        {
            ((ButtonX) sender).Checked = !(((ButtonX) sender).Checked);
            if (!Gib.ftaglocked)
                this.Close();
        }
        void tabpage_Click(object sender, EventArgs e)
        {
            nowpage = tabv.SelectedTabIndex;
        }

        private void tagbutton_MouseDown(object sender, MouseEventArgs e)
        {
            rbtag = ((ButtonX)sender);
        }

        private int x = -1;

        private void loadtag()
        {
            int i, j, tnum;
            string temp;
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

            int[] lss = new int[Gib.ts[Gib.nowsysi].pagen];
            for (i = 0; i < Gib.ts[Gib.nowsysi].pagen; ++i)
                lss[i] = i;
            for (i = 0; i < Gib.ts[Gib.nowsysi].pagen; ++i)
                for (j = i + 1; j < Gib.ts[Gib.nowsysi].pagen; ++j)
                    if (String.Compare(Gib.ts[Gib.nowsysi].allpage[i], Gib.ts[Gib.nowsysi].allpage[j]) > 0)
                    {
                        temp = Gib.ts[Gib.nowsysi].allpage[i];
                        Gib.ts[Gib.nowsysi].allpage[i] = Gib.ts[Gib.nowsysi].allpage[j];
                        Gib.ts[Gib.nowsysi].allpage[j] = temp;

                        tnum = lss[i];
                        lss[i] = lss[j];
                        lss[j] = tnum;
                    }
            for (i = 0; i < Gib.ts[Gib.nowsysi].tagn; ++i)
                for (j = 0; j < Gib.ts[Gib.nowsysi].pagen; ++j)
                    if (lss[j] == Gib.ts[Gib.nowsysi].tagp[i])
                    {
                        Gib.ts[Gib.nowsysi].tagp[i] = j;
                        break;
                    }

            for (i = 0; i < Gib.ts[Gib.nowsysi].pagen; ++i)
            {
                FlowLayoutPanel layoutp = new FlowLayoutPanel();
                layoutp.Dock = DockStyle.Fill;
                layoutp.BackColor = Color.White;
                layoutp.AutoScroll = true;
                layoutp.Size = new Size(872, 499);

                TabControlPanel tabpage = new TabControlPanel();
                TabItem tabitem = new TabItem();
                tabpage.Controls.Add(layoutp);
                tabpage.BackColor = Color.White;
                tabpage.Dock = DockStyle.Fill;
                tabpage.Padding = new System.Windows.Forms.Padding(1);
                tabpage.Tag = i;
                tabpage.TabItem = tabitem;

                tabitem.AttachedControl = tabpage;
                tabitem.Text = Gib.ts[Gib.nowsysi].allpage[i];
                tabitem.BackColor = Color.White;
                tabitem.Click += new System.EventHandler(this.tabpage_Click);
                this.tabv.Tabs.Add(tabitem);
            }
            if (Gib.dochoosetag == false)
                for (i = 0; i < Gib.ts[Gib.nowsysi].ftagn; ++i)
                    if (Gib.ts[Gib.nowsysi].ftagpath[i] == Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab] + 1])
                    {
                        x = i;
                        break;
                    }
            int ls;
            bool bj;
            for (i = 0; i < Gib.ts[Gib.nowsysi].tagn; ++i)
            {
                ButtonX tagbutton = new ButtonX();
                tagbutton.Location = new Point(3, 3);
                tagbutton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
                tagbutton.Size = new Size(8*getlen(Gib.ts[Gib.nowsysi].alltag[i]) + 10, 26);
                tagbutton.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro;
                tagbutton.Font = new Font("Consolas", 8F);
                tagbutton.FocusCuesEnabled = false;
                tagbutton.Text = Gib.ts[Gib.nowsysi].alltag[i];
                tagbutton.Click += new System.EventHandler(tagbutton_Click);
                tagbutton.MouseDown += new System.Windows.Forms.MouseEventHandler(tagbutton_MouseDown);
                tagbutton.ContextMenuStrip = trmenu;
                if (Gib.ts[Gib.nowsysi].taginfo[i] == null || Gib.ts[Gib.nowsysi].taginfo[i].Trim() != "")
                    tagbutton.Tooltip = Gib.ts[Gib.nowsysi].taginfo[i];
                else
                    tagbutton.Tooltip = "";

                if (x > -1)
                {
                    bj = false;
                    for (j = 0; j < Gib.ts[Gib.nowsysi].ftags[x]; ++j)
                        if (Gib.ts[Gib.nowsysi].ftagname[x, j] == Gib.ts[Gib.nowsysi].alltag[i])
                        {
                            ls = j;
                            bj = true;
                            break;
                        }
                    if (bj)
                        tagbutton.Checked = true;
                }

                this.tabv.Tabs[Gib.ts[Gib.nowsysi].tagp[i]].AttachedControl.Controls[0].Controls.Add(tagbutton);
            }
        }

        private void FrmTag_Load(object sender, EventArgs e)
        {
            islocked.Checked = Gib.ftaglocked;
            line1.ForeColor = line2.ForeColor = line3.ForeColor = Color.DarkGray;
            buttonlayout.BackColor = Color.White;
            showCheckedTag.Tag = 1;
            loadtag();
            if (Gib.dochoosetag)
                addstr = " - 选择标签";
            else
                addstr = "";
            this.Text = "CW File Viewer - 标签 - " + Gib.ts[Gib.nowsysi].name + " （共" +
                                    ( Gib.ts[Gib.nowsysi].tagn).ToString() + "个标签，" + Gib.ts[Gib.nowsysi].ftagn + "个已标文件）" + addstr;
            if (Gib.doshowtag)
            {
                showCheckedTag_Click(sender, e);
                Gib.doshowtag = false;
            }
        }

        private void addtag_Click(object sender, EventArgs e)
        {
            if (tagname.Text.Trim() != "")
            {
                if (Gib.ts[Gib.nowsysi].pagen > 0)
                {
                    string name = tagname.Text.Trim();
                    bool bj = false;
                    foreach (TabItem tabpage in this.tabv.Tabs)
                    {
                        foreach (ButtonX btag in tabpage.AttachedControl.Controls[0].Controls)
                            if (btag.Text == name)
                            {
                                bj = true;
                                break;
                            }
                        if (bj)
                            break;
                    }
                    if (bj == false)
                    {
                        ButtonX tagbutton = new ButtonX();
                        tagbutton.Location = new Point(3, 3);
                        tagbutton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
                        tagbutton.Size = new Size(8*getlen(name) + 10, 26);
                        tagbutton.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro;
                        tagbutton.FocusCuesEnabled = false;
                        tagbutton.Font = new Font("Consolas", 8F);
                        tagbutton.Text = name;
                        tagbutton.Click += new System.EventHandler(tagbutton_Click);
                        tagbutton.MouseDown += new System.Windows.Forms.MouseEventHandler(tagbutton_MouseDown);
                        tagbutton.ContextMenuStrip = trmenu;
                        tagbutton.Tooltip = "";
                        tagbutton.Checked = true;

                        foreach (TabControlPanel tagpage in this.tabv.Controls)
                            if ((int) tagpage.Tag == nowpage)
                            {
                                tagpage.Controls[0].Controls.Add(tagbutton);
                                break;
                            }
                        this.Text = "CW File Viewer - 标签 - " + Gib.ts[Gib.nowsysi].name + " （共" +
                                    (++Gib.ts[Gib.nowsysi].tagn).ToString() + "个标签，" + Gib.ts[Gib.nowsysi].ftagn +
                                    "个已标文件）" + addstr;

                        if (sender.ToString() == "给所有标签系统添加")
                            for (i = 0; i < Gib.tsn; ++i)
                                if (i != Gib.nowsysi)
                                {
                                    bj = true;
                                    for (j = 0; j < Gib.ts[i].tagn; ++j)
                                        if (Gib.ts[i].alltag[j] == name)
                                            bj = false;
                                    if (bj)
                                    {
                                        Gib.ts[i].alltag[Gib.ts[i].tagn] = name;
                                        Gib.ts[i].tagp[Gib.ts[i].tagn] = 0;
                                        ++Gib.ts[i].tagn;
                                    }
                                }
                    }
                    else
                    {
                        this.highlighter.SetHighlightColor(this.tagname,
                            DevComponents.DotNetBar.Validator.eHighlightColor.Red);
                        this.errorProvider.SetError(this.tagname, "标签已存在！");
                    }
                }
                else
                {
                    this.highlighter.SetHighlightColor(this.tagname,
                        DevComponents.DotNetBar.Validator.eHighlightColor.Red);
                    this.errorProvider.SetError(this.tagname, "必须先添加标签页！");
                }
            }
            else
            {
                this.highlighter.SetHighlightColor(this.tagname,
                    DevComponents.DotNetBar.Validator.eHighlightColor.Red);
                this.errorProvider.SetError(this.tagname, "标签名不得为空！");
            }
        }

        private void savetags()
        {
            Gib.ts[Gib.nowsysi].tagn = 0;
            foreach (TabItem tabpage in this.tabv.Tabs)
                foreach (ButtonX btag in tabpage.AttachedControl.Controls[0].Controls)
                {
                    Gib.ts[Gib.nowsysi].alltag[Gib.ts[Gib.nowsysi].tagn] = btag.Text;
                    Gib.ts[Gib.nowsysi].taginfo[Gib.ts[Gib.nowsysi].tagn] = btag.Tooltip;
                    Gib.ts[Gib.nowsysi].tagp[Gib.ts[Gib.nowsysi].tagn++] = (int)tabpage.AttachedControl.Tag;
                }
        }

        private void deltag_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(rbtag.Tooltip))
                if (
                    MessageBoxEx.Show(this, "本标签含有说明，是否继续删除？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
                        MessageBoxDefaultButton.Button2) == DialogResult.No)
                    return;
            rbtag.Parent.Controls.Remove(rbtag);
            this.Text = "CW File Viewer - 标签 - " + Gib.ts[Gib.nowsysi].name + " （共" +
                        (--Gib.ts[Gib.nowsysi].tagn).ToString() + "个标签，" + Gib.ts[Gib.nowsysi].ftagn + "个已标文件）" +
                        addstr;
        }

        private void FrmTag_FormClosing(object sender, FormClosingEventArgs e)
        {
            savetags();
            int js = 0;
            if (Gib.dochoosetag)
            {
                Gib.choosedtagn = 0;
                foreach (TabItem tabpage in tabv.Tabs)
                    foreach (ButtonX btag in tabpage.AttachedControl.Controls[0].Controls)
                        if (btag.Checked)
                            Gib.choosedtags[Gib.choosedtagn++] = btag.Text;
                FrmAll frm = (FrmAll) this.Owner;
                frm.showchoosedtags();
            }
            else
            {
                if (x > -1)
                {
                    foreach (TabItem tabpage in tabv.Tabs)
                        foreach (ButtonX btag in tabpage.AttachedControl.Controls[0].Controls)
                            if (btag.Checked)
                                Gib.ts[Gib.nowsysi].ftagname[x, js++] = btag.Text;
                    Gib.ts[Gib.nowsysi].ftagpath[x] = Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab] + 1];
                    Gib.ts[Gib.nowsysi].ftags[x] = js;
                }
                else
                {
                    foreach (TabItem tabpage in tabv.Tabs)
                        foreach (ButtonX btag in tabpage.AttachedControl.Controls[0].Controls)
                            if (btag.Checked)
                                Gib.ts[Gib.nowsysi].ftagname[Gib.ts[Gib.nowsysi].ftagn, js++] = btag.Text;
                    if (js > 0)
                    {
                        Gib.ts[Gib.nowsysi].ftagpath[Gib.ts[Gib.nowsysi].ftagn] = Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab] + 1];
                        Gib.ts[Gib.nowsysi].ftags[Gib.ts[Gib.nowsysi].ftagn] = js;
                        ++Gib.ts[Gib.nowsysi].ftagn;
                    }
                }
            }
        }
        
        private void addpage_Click(object sender, EventArgs e)
        {
            string name = pagename.Text.Trim();
            if (name != "")
            {
                bool bj = true;
                foreach (TabItem tabpage in this.tabv.Tabs)
                    if (tabpage.Text == name)
                    {
                        bj = false;
                        break;
                    }

                if (bj)
                {
                    FlowLayoutPanel layoutp = new FlowLayoutPanel();
                    layoutp.Dock = DockStyle.Fill;
                    layoutp.BackColor = Color.White;
                    layoutp.Size = new Size(872, 499);

                    TabControlPanel tabpage = new TabControlPanel();
                    TabItem tabitem = new TabItem();
                    tabpage.Tag = Gib.ts[Gib.nowsysi].pagen;
                    tabpage.BackColor = Color.White;
                    tabpage.Controls.Add(layoutp);
                    tabpage.Dock = DockStyle.Fill;
                    tabpage.Padding = new System.Windows.Forms.Padding(1);
                    tabpage.TabItem = tabitem;

                    tabitem.AttachedControl = tabpage;
                    tabitem.BackColor = Color.White;
                    tabitem.Text = name;
                    tabitem.Click += new System.EventHandler(this.tabpage_Click);
                    this.tabv.Tabs.Add(tabitem);
                    this.tabv.Refresh();

                    Gib.ts[Gib.nowsysi].allpage[Gib.ts[Gib.nowsysi].pagen++] = tabitem.Text;

                    if (sender.ToString() == "给所有标签系统添加")
                        for (i = 0; i < Gib.tsn; ++i)
                            if (i != Gib.nowsysi)
                            {
                                bj = true;
                                for (j = 0; j < Gib.ts[i].pagen; ++j)
                                    if (Gib.ts[i].allpage[j] == name)
                                        bj = false;
                                if (bj)
                                    Gib.ts[i].allpage[Gib.ts[i].pagen++] = name;
                            }
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
                this.highlighter.SetHighlightColor(this.pagename,
                    DevComponents.DotNetBar.Validator.eHighlightColor.Red);
                this.errorProvider.SetError(this.pagename, "页标题不得为空！");
            }
        }

        public void changetaginfo(string str,int x)
        {
            Gib.ts[Gib.nowsysi].taginfo[x] = str;
            rbtag.Tooltip = str;
        }

        public void changepagev(int choose)
        {
            foreach (TabItem tabitem in this.tabv.Tabs)
            {
                if ((int) tabitem.AttachedControl.Tag == choose)
                {
                    this.tabv.Tabs[nowpage].AttachedControl.Controls[0].Controls.Remove(rbtag);
                    tabitem.AttachedControl.Controls[0].Controls.Add(rbtag);
                    break;
                }
            }
        }

        private void tabv_Click(object sender, EventArgs e)
        {

        }

        public void renametag(string name, bool allto1)
        {
            int i, j, x;
            for (i = 0; i < Gib.ts[Gib.nowsysi].tagn; ++i)
                if (Gib.ts[Gib.nowsysi].alltag[i] == rbtag.Text)
                {
                    Gib.ts[Gib.nowsysi].alltag[i] = "";
                    break;
                }
            for (i = 0; i < Gib.ts[Gib.nowsysi].ftagn; ++i)
                for (j = 0; j < Gib.ts[Gib.nowsysi].ftags[i]; ++j)
                    if (Gib.ts[Gib.nowsysi].ftagname[i, j] == rbtag.Text)
                        Gib.ts[Gib.nowsysi].ftagname[i, j] = name;
            if (allto1)
            {
                this.Text = "CW File Viewer - 标签 - " + Gib.ts[Gib.nowsysi].name + " （共" +
                                    (--Gib.ts[Gib.nowsysi].tagn).ToString() + "个标签，" + Gib.ts[Gib.nowsysi].ftagn + "个已标文件）" + addstr;
                this.tabv.Tabs[nowpage].AttachedControl.Controls[0].Controls.Remove(rbtag);
            }
            else
            {
                rbtag.Text = name;
                rbtag.Size = new Size(8*getlen(name) + 10, 26);
            }
        }

        private void properties_Click(object sender, EventArgs e)
        {
            Gib.crossfile1 = rbtag.Text;
            Gib.crossfile2 = this.tabv.Tabs[nowpage].Text;
            FrmTagProper frm = new FrmTagProper();
            frm.ShowDialog(this);
        }

        private int i, j, la, lb;
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
                for ( j = 0; j < lb; ++j )
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

        private bool zbj = true;

        private void clear_Click(object sender, EventArgs e)
        {
            for (i = 0; i < Gib.ts[Gib.nowsysi].ftagn; ++i)
                for (j = 0; j < Gib.ts[Gib.nowsysi].ftags[i]; ++j)
                    if (Gib.ts[Gib.nowsysi].ftagname[i, j] == rbtag.Text)
                        Gib.ts[Gib.nowsysi].ftagname[i, j] = "";
            rbtag.Checked = false;
        }

        private void showCheckedTag_Click(object sender, EventArgs e)
        {
            bool bj, dosel = zbj;
            if ((int)showCheckedTag.Tag == 1)
            {
                zbj = false;
                foreach (TabItem tabpage in this.tabv.Tabs)
                {
                    bj = false;
                    foreach (ButtonX btag in tabpage.AttachedControl.Controls[0].Controls)
                        if (btag.Checked)
                            bj = true;
                    if (bj)
                    {
                        foreach (ButtonX btag in tabpage.AttachedControl.Controls[0].Controls)
                        {
                            if (btag.Checked)
                                btag.Visible = true;
                            else
                                btag.Visible = false;
                        }
                        tabpage.Visible = true;
                        zbj = true;
                    }
                    else
                        tabpage.Visible = false;
                }
                if (dosel == false && zbj)
                {
                    for (i = 0; i < Gib.ts[Gib.nowsysi].pagen; ++i)
                        if (tabv.Tabs[i].Visible)
                            break;
                    tabv.SelectedTabIndex = (i + 1) % Gib.ts[Gib.nowsysi].pagen;
                    tabv.SelectedTabIndex = i;
                    tabv.Tabs[i].AttachedControl.Focus();
                    tabv.Tabs[i].AttachedControl.Controls[0].Focus();
                }
                nowpage = tabv.SelectedTabIndex;
                showCheckedTag.Text = "显示全部标签";
                showCheckedTag.Tag = 2;
            }
            else
            {
                foreach (TabItem tabpage in this.tabv.Tabs)
                {
                    tabpage.Visible = true;
                    foreach (ButtonX btag in tabpage.AttachedControl.Controls[0].Controls)
                        btag.Visible = true;
                }
                showCheckedTag.Text = "显示已标标签";
                showCheckedTag.Tag = 1;
            }
        }

        private void copytag_Click(object sender, EventArgs e)
        {
            Gib.crossfile4 = rbtag.Text;
            Gib.crossfile5 = rbtag.Tooltip;
            FrmTagCopy frm = new FrmTagCopy();
            frm.ShowDialog(this);
        }

        private void search_Click(object sender, EventArgs e)
        {
            bool bj, dosel = zbj;
            zbj = false;
            foreach (TabItem tabpage in this.tabv.Tabs)
            {
                bj = false;
                foreach (ButtonX btag in tabpage.AttachedControl.Controls[0].Controls)
                    if (find(btag.Text, searchtext.Text))
                        bj = true;
                if (bj)
                {
                    foreach (ButtonX btag in tabpage.AttachedControl.Controls[0].Controls)
                    {
                        if (find(btag.Text, searchtext.Text))
                            btag.Visible = true;
                        else
                            btag.Visible = false;
                    }
                    tabpage.Visible = true;
                    zbj = true;
                }
                else
                    tabpage.Visible = false;
            }
            //if (tabv.Tabs[nowpage].Visible)
            //    tabv.Tabs[nowpage].AttachedControl.Controls[0].Focus();
            //else
            if (dosel == false && zbj)
            {
                for (i = 0; i < Gib.ts[Gib.nowsysi].pagen; ++i)
                    if (tabv.Tabs[i].Visible)
                        break;
                tabv.SelectedTabIndex = (i + 1) % Gib.ts[Gib.nowsysi].pagen;
                tabv.SelectedTabIndex = i;
                tabv.Tabs[i].AttachedControl.Focus();
                tabv.Tabs[i].AttachedControl.Controls[0].Focus();
            }
            nowpage = tabv.SelectedTabIndex;
            searchtext.Focus();
        }

        private void FrmTag_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.M && !tagname.Focused && !pagename.Focused && !searchtext.Focused)
                showCheckedTag_Click(sender, e);
        }

        private void islocked_Click(object sender, EventArgs e)
        {
            Gib.ftaglocked = !Gib.ftaglocked;
            islocked.Checked = Gib.ftaglocked;
        }
    }
}

/*
this.layoutmain.BackColor = Color.White;
this.layoutmain.Dock = System.Windows.Forms.DockStyle.Fill;
this.layoutmain.ForeColor = System.Drawing.Color.Black;
this.layoutmain.Location = new System.Drawing.Point(0, 0);
this.layoutmain.Name = "layoutmain";
*/