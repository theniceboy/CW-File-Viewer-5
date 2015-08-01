using System;
using System.Drawing;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;

namespace CW_File_Viewer_5
{
    public partial class FrmTagPageMan_Del : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FrmTagPageMan_Del()
        {
            InitializeComponent();
        }

        private ButtonX nowselect = null;
        private int nowi;

        private void pageb_MouseDown(object sender, MouseEventArgs e)
        {
            if (nowselect != (ButtonX)sender)
            {
                if (nowselect != null)
                    nowselect.Checked = false;
                nowselect = ((ButtonX)sender);
                nowselect.Checked = true;
                nowi = (int) nowselect.Tag;
            }
        }

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

        private void FrmTabPageMan_Del_Load(object sender, EventArgs e)
        {
            this.mainlayout.BackColor = Color.White;
            for (int i = 0; i < Gib.ts[Gib.nowsysi].pagen; ++i)
                if (Gib.ts[Gib.nowsysi].allpage[i] != Gib.crossbutton1.Text)
                {
                    ButtonX pageb = new ButtonX();
                    pageb.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
                    pageb.Size = new Size(9 * getlen(Gib.ts[Gib.nowsysi].allpage[i]) + 10, 27);
                    pageb.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro;
                    pageb.Font = new Font("Consolas", 9F);
                    pageb.Tag = i;
                    pageb.FocusCuesEnabled = false;
                    pageb.Text = Gib.ts[Gib.nowsysi].allpage[i];
                    pageb.MouseDown += new System.Windows.Forms.MouseEventHandler(pageb_MouseDown);
                    if (i == 0)
                        pageb.Checked = false;
                    this.mainlayout.Controls.Add(pageb);
                }
        }

        private void ok_Click(object sender, EventArgs e)
        {
            FrmTagPageMan frm = (FrmTagPageMan)this.Owner;
            frm.mainlayout.Controls.Remove(Gib.crossbutton1);
            int i, j, k, x = 0;
            if (mixto.Checked)
            {
                for (i = 0; i < Gib.ts[Gib.nowsysi].pagen; ++i)
                    if (Gib.ts[Gib.nowsysi].allpage[i] == Gib.crossbutton1.Text)
                    {
                        x = i;
                        break;
                    }

                for (i = 0; i < Gib.ts[Gib.nowsysi].tagn; ++i)
                {
                    if (Gib.ts[Gib.nowsysi].tagp[i] == x)
                        Gib.ts[Gib.nowsysi].tagp[i] = nowi;
                    if (Gib.ts[Gib.nowsysi].tagp[i] > x)
                        --Gib.ts[Gib.nowsysi].tagp[i];
                }

                for (i = x + 1; i < Gib.ts[Gib.nowsysi].pagen; ++i)
                    Gib.ts[Gib.nowsysi].allpage[i - 1] = Gib.ts[Gib.nowsysi].allpage[i];
                --Gib.ts[Gib.nowsysi].pagen;
            }
            else
            {
                for (i = 0; i < Gib.ts[Gib.nowsysi].pagen; ++i)
                    if (Gib.ts[Gib.nowsysi].allpage[i] == Gib.crossbutton1.Text)
                    {
                        x = i;
                        Gib.ts[Gib.nowsysi].allpage[i] = "";
                        break;
                    }
                int tagn = 0;
                int[] tagp = Gib.ts[Gib.nowsysi].tagp;
                string[] alltag = Gib.ts[Gib.nowsysi].alltag;
                string[] taginfo = Gib.ts[Gib.nowsysi].taginfo;
                for (i = 0; i < Gib.ts[Gib.nowsysi].tagn; ++i)
                    if (tagp[i] != x)
                    {
                        if (tagp[i] > x)
                            --tagp[i];
                        Gib.ts[Gib.nowsysi].tagp[tagn] = tagp[i];
                        Gib.ts[Gib.nowsysi].alltag[tagn] = alltag[i];
                        Gib.ts[Gib.nowsysi].taginfo[tagn] = taginfo[i];
                        ++tagn;
                    }
                    else
                    {
                        for (j = 0; j < Gib.ts[Gib.nowsysi].ftagn; ++j)
                            for (k = 0; k < Gib.ts[Gib.nowsysi].ftags[j]; ++k)
                                if (Gib.ts[Gib.nowsysi].ftagname[j, k] == alltag[i])
                                    Gib.ts[Gib.nowsysi].ftagname[j, k] = "";
                    }
                Gib.ts[Gib.nowsysi].tagn = tagn;
                Gib.ts[Gib.nowsysi].tagp = tagp;
                Gib.ts[Gib.nowsysi].alltag = alltag;
                Gib.ts[Gib.nowsysi].taginfo = taginfo;

                for (i = x + 1; i < Gib.ts[Gib.nowsysi].pagen; ++i)
                    Gib.ts[Gib.nowsysi].allpage[i - 1] = Gib.ts[Gib.nowsysi].allpage[i];
                --Gib.ts[Gib.nowsysi].pagen;
            }
            frm.mainlayout.Controls.Remove(Gib.crossbutton1);
            this.Close();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
