using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;

namespace CW_File_Viewer_5
{
    public partial class FrmTagProper : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FrmTagProper()
        {
            InitializeComponent();
        }

        private bool bj,canclose;
        private int i;
        private string name;

        private int choose = -1;

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

        private void pageb_Click(object sender, EventArgs e)
        {
            choose = (int)((CheckBoxX)sender).Tag;
        }

        private void change_Click(object sender, EventArgs e)
        {
            canclose = true;
            this.highlighter.SetHighlightColor(this.tagname, DevComponents.DotNetBar.Validator.eHighlightColor.None);
            FrmTag frm = (FrmTag) this.Owner;
            name = tagname.Text.Trim();
            if (name != "")
            {
                bj = true;
                for (i = 0; i < Gib.ts[Gib.nowsysi].tagn; ++i)
                    if (Gib.ts[Gib.nowsysi].alltag[i] == name)
                    {
                        bj = false;
                        break;
                    }
                if (bj)
                    frm.renametag(name, false);
                else if (name != Gib.crossfile1)
                {
                    if (MessageBoxEx.Show(this, "标签名已存在，是否合并？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        frm.renametag(name, true);
                    else
                    {
                        canclose = false;
                        this.highlighter.SetHighlightColor(this.tagname,
                            DevComponents.DotNetBar.Validator.eHighlightColor.Red);
                        this.errorProvider.SetError(this.tagname, "标签已存在！");
                    }
                }
            }
            else
            {
                canclose = false;
                this.highlighter.SetHighlightColor(this.tagname, DevComponents.DotNetBar.Validator.eHighlightColor.Red);
                this.errorProvider.SetError(this.tagname, "标签名不得为空！");
            }

            frm.changepagev(choose);
            frm.changetaginfo(taginfo.Text, i);

            if (canclose)
                this.Close();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmTagRename_Load(object sender, EventArgs e)
        {
            line1.ForeColor = Color.DarkGray;
            line2.ForeColor = Color.DarkGray;
            line3.ForeColor = Color.DarkGray;
            line4.ForeColor = Color.DarkGray;
            mainlayout.BackColor = Color.White;
            int i;
            for (i = 0; i < Gib.ts[Gib.nowsysi].pagen; ++i)
            {
                CheckBoxX pageb = new CheckBoxX();
                pageb.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
                pageb.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
                pageb.FocusCuesEnabled = false;
                pageb.Font = new Font("Consolas", 9F);
                pageb.Size = new Size(9 * getlen(Gib.ts[Gib.nowsysi].allpage[i]) + 32, 27);
                pageb.Tag = i;
                pageb.Text = Gib.ts[Gib.nowsysi].allpage[i];
                if (pageb.Text == Gib.crossfile2)
                {
                    pageb.Checked = true;
                    pageb.Font = new Font("Consolas", 9F, FontStyle.Bold);
                }
                pageb.Click += new System.EventHandler(this.pageb_Click);

                this.mainlayout.Controls.Add(pageb);
            }
            tagname.Text = Gib.crossfile1;
            for (i = 0; i < Gib.ts[Gib.nowsysi].tagn; ++i)
                if (Gib.ts[Gib.nowsysi].alltag[i] == Gib.crossfile1)
                    break;
            taginfo.Text = Gib.ts[Gib.nowsysi].taginfo[i];
        }
    }
}