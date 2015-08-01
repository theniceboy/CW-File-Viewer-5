using System;
using System.Text;
using System.Windows.Forms;
using System.IO;
using DevComponents.DotNetBar;

namespace CW_File_Viewer_5
{
    public partial class FrmCut : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FrmCut()
        {
            InitializeComponent();
        }


        int i, j, js, wsum = 1000, lsjs, azs = 3;
        int mode = 3, mode4 = 1, fcn = 8, fsn;
        string fc = ".!?;:。！？";
        string fs;
        char[] cfc = new char[100];
        char[] cfs = new char[100];
        char[] ls1 = new char[1];
        char[] ls2 = new char[1];
        string cuts = ".!?;:。！？";
        string cuta = " - cut";
        char[] cutc = new char[100];
        int cutn;
        bool pda()
        {
            if (j < Gib.infile.Length)
            {
                ls1[0] = Gib.infile[j];
                string lins1 = new string(ls1);
                /*
                if (Gib.infile[k] == '.')
                {
                    MessageBoxEx.Show(lins, "提示", MessageBoxButtons.YesNo, MessageBoxIcon.None);
                    if (lins == ".")
                        MessageBoxEx.Show(lins, "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                }
                */
                int lsi;
                for (lsi = 0; lsi < cutn; ++lsi)
                {
                    if (Gib.infile[j] == cutc[lsi])
                    {
                        //MessageBoxEx.Show(infile, "提示", MessageBoxButtons.YesNo, MessageBoxIcon.None);
                        if (j < Gib.infile.Length - 1)
                        {
                            //ls2[0] = Gib.infile[j + 1];
                            //lins2 = new string(ls2);
                            while (j < Gib.infile.Length - 1 && (Gib.infile[j + 1] == '\"' || Gib.infile[j + 1] == '”' || Gib.infile[j + 1] == '\''))
                            {
                                ++j;
                            }
                        }
                        return true;
                    }
                }
            }
            return false;
        }
        bool pdc()
        {
            if (Gib.infile[j] == '\n')
                return true;
            return false;
        }

        private void FrmCut_Load(object sender, EventArgs e)
        {
            char[] cutc = cuts.ToCharArray();
            this.cut.Focus();
        }

        private void cutma()
        {
            FrmMain frm = (FrmMain) this.Owner;
            if (cutadd.Text != "")
            {
                prog.Maximum = Gib.infile.Length;
                js = 0;
                bool reald = false;
                string llast = Path.GetExtension(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab] + 1]);
                Directory.CreateDirectory(Gib.crossfile1 + cutadd.Text);
                Gib.infile = "";
                string fn, word = "";
                //l = Gib.infile.Length;
                if (upfile.Checked)
                {
                    for (i = 0; i < Gib.infile.Length; ++i)
                    {
                        ++js;
                        fn = Gib.crossfile1 + cutadd.Text + "\\";
                        if (addz.Checked == true)
                            for (j = 1; j < azs; ++j)
                                if (js < Math.Pow(10, j))
                                    fn = fn + '0';
                        fn = fn + js.ToString() + llast;

                        for (j = i; j < Gib.infile.Length; ++j)
                        {
                            if (Gib.infile[j] != '\n')
                                reald = true;
                            if (j < Gib.infile.Length && reald == true)
                            {
                                word = word + Gib.infile[j];
                                Gib.infile = Gib.infile + Gib.infile[j];
                            }
                            if (pda() == true)
                            {
                                if (Gib.p == 1)
                                {
                                    Gib.infile = Gib.infile + Gib.infile[j];
                                    Gib.p = 0;
                                }
                                if (reald == true)
                                {
                                    Gib.infile = Gib.infile + "\r\n";
                                    word = word + "\r\n";
                                }
                                break;
                            }

                            prog.Value = j;
                        }

                        prog.Value = i;

                        if (llast == ".txt" || llast == ".TXT")
                            File.WriteAllText(fn, word, Encoding.GetEncoding("GB2312"));
                        else
                            File.WriteAllText(fn, word);
                        word = "";
                        i = j;
                    }
                    frm.lrcv.Text = Gib.infile;
                }
                else
                {
                    for (i = 0; i < Gib.infile.Length; ++i)
                    {
                        ++js;
                        fn = Gib.crossfile1 + cutadd.Text + "\\";
                        if (addz.Checked == true)
                            for (j = 1; j < azs; ++j)
                                if (js < Math.Pow(10, j))
                                    fn = fn + '0';
                        fn = fn + js.ToString() + llast;

                        for (j = i; j < Gib.infile.Length; ++j)
                        {
                            if (Gib.infile[j] != '\n')
                                reald = true;
                            if (j < Gib.infile.Length && reald)
                                word = word + Gib.infile[j];
                            if (pda())
                            {
                                if (Gib.p == 1)
                                    Gib.p = 0;
                                if (reald)
                                    word = word + "\r\n";
                                break;
                            }

                            prog.Value = j;
                        }

                        prog.Value = i;

                        if (llast == ".txt" || llast == ".TXT")
                            File.WriteAllText(fn, word, Encoding.GetEncoding("GB2312"));
                        else
                            File.WriteAllText(fn, word);
                        word = "";
                        i = j;
                    }
                }
                frm.reffile(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]]);
                //((FrmCut)FrmMain).;
            }
            else
                MessageBoxEx.Show("分割后文件夹添加名不得为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            prog.Value = 10000;
            //frm.nowstate.Text = "完成";
        }

        void cutmb()
        {
            FrmMain frm = (FrmMain)this.Owner;
            if (cutadd.Text != "")
            {
                prog.Maximum = Gib.infile.Length;
                string llast = Path.GetExtension(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab] + 1]);
                Directory.CreateDirectory(Gib.crossfile1 + cutadd.Text);
                string fn, word = "";
                js = 1;
                lsjs = 1;

                if (upfile.Checked)
                {
                    Gib.infile = "";
                    for (i = 0; i < Gib.infile.Length; ++i)
                    {
                        if (lsjs > wsum)
                        {
                            fn = Gib.crossfile1 + cutadd.Text + "\\";
                            if (addz.Checked == true)
                                for (j = 1; j < azs; ++j)
                                    if (js < Math.Pow(10, j))
                                        fn = fn + '0';
                            fn = fn + js.ToString() + llast;
                            Gib.infile = Gib.infile + "\r\n";
                            word = word + "\r\n";
                            if (llast == ".txt" || llast == ".TXT")
                                File.WriteAllText(fn, word, Encoding.GetEncoding("GB2312"));
                            else
                                File.WriteAllText(fn, word);
                            word = "";
                            lsjs = 1;
                            ++js;
                        }
                        else
                        {
                            Gib.infile = Gib.infile + Gib.infile[i];
                            word = word + Gib.infile[i];
                            ++lsjs;
                            if (lsjs > wsum)
                            {
                                fn = Gib.crossfile1 + cutadd.Text + "\\";
                                if (addz.Checked == true)
                                    for (j = 1; j < azs; ++j)
                                        if (js < Math.Pow(10, j))
                                            fn = fn + '0';
                                fn = fn + js.ToString() + llast;
                                Gib.infile = Gib.infile + "\r\n";
                                word = word + "\r\n";
                                if (llast == ".txt" || llast == ".TXT")
                                    File.WriteAllText(fn, word, Encoding.GetEncoding("GB2312"));
                                else
                                    File.WriteAllText(fn, word);
                                word = "";
                                lsjs = 1;
                                ++js;
                            }
                            else if (i == Gib.infile.Length - 1)
                            {
                                fn = Gib.crossfile1 + cutadd.Text + "\\";
                                if (addz.Checked == true)
                                    for (j = 1; j < azs; ++j)
                                        if (js < Math.Pow(10, j))
                                            fn = fn + '0';
                                fn = fn + js.ToString() + llast;
                                Gib.infile = Gib.infile + "\r\n";
                                word = word + "\r\n";
                                if (llast == ".txt" || llast == ".TXT")
                                    File.WriteAllText(fn, word, Encoding.GetEncoding("GB2312"));
                                else
                                    File.WriteAllText(fn, word);
                                word = "";
                                lsjs = 0;
                                ++js;
                            }
                        }

                        prog.Value = i;
                    }
                    File.WriteAllText(Gib.crossfile1, Gib.infile);
                    frm.lrcv.Text = Gib.infile;
                }
                else
                {
                    for (i = 0; i < Gib.infile.Length; ++i)
                    {
                        if (lsjs > wsum)
                        {
                            fn = Gib.crossfile1 + cutadd.Text + "\\";
                            if (addz.Checked == true)
                                for (j = 1; j < azs; ++j)
                                    if (js < Math.Pow(10, j))
                                        fn = fn + '0';
                            fn = fn + js.ToString() + llast;
                            word = word + "\r\n";
                            if (llast == ".txt" || llast == ".TXT")
                                File.WriteAllText(fn, word, Encoding.GetEncoding("GB2312"));
                            else
                                File.WriteAllText(fn, word);
                            word = "";
                            lsjs = 1;
                            ++js;
                        }
                        else
                        {
                            word = word + Gib.infile[i];
                            ++lsjs;
                            if (lsjs > wsum)
                            {
                                fn = Gib.crossfile1 + cutadd.Text + "\\";
                                if (addz.Checked == true)
                                    for (j = 1; j < azs; ++j)
                                        if (js < Math.Pow(10, j))
                                            fn = fn + '0';
                                fn = fn + js.ToString() + llast;
                                word = word + "\r\n";
                                if (llast == ".txt" || llast == ".TXT")
                                    File.WriteAllText(fn, word, Encoding.GetEncoding("GB2312"));
                                else
                                    File.WriteAllText(fn, word);
                                word = "";
                                lsjs = 1;
                                ++js;
                            }
                            else if (i == Gib.infile.Length - 1)
                            {
                                fn = Gib.crossfile1 + cutadd.Text + "\\";
                                if (addz.Checked == true)
                                    for (j = 1; j < azs; ++j)
                                        if (js < Math.Pow(10, j))
                                            fn = fn + '0';
                                fn = fn + js.ToString() + llast;
                                word = word + "\r\n";
                                if (llast == ".txt" || llast == ".TXT")
                                    File.WriteAllText(fn, word, Encoding.GetEncoding("GB2312"));
                                else
                                    File.WriteAllText(fn, word);
                            }
                        }
                        prog.Value = i;
                    }
                }
                frm.reffile(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]]);
            }
            else
                MessageBoxEx.Show("分割后文件夹添加名不得为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            prog.Value = 10000;
            //frm.nowstate.Text = "完成";
        }
        void cutmc()
        {
            FrmMain frm = (FrmMain)this.Owner;
            if (cutadd.Text != "")
            {
                prog.Maximum = Gib.infile.Length;
                js = 0;
                string llast = Path.GetExtension(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab] + 1]);
                Directory.CreateDirectory(Gib.crossfile1 + cutadd.Text);
                string fn, word = "";
                //l = Gib.infile.Length;
                for (i = 0; i < Gib.infile.Length; ++i)
                {
                    ++js;
                    fn = Gib.crossfile1 + cutadd.Text + "\\";
                    if (addz.Checked == true)
                        for (j = 1; j < azs; ++j)
                            if (js < Math.Pow(10, j))
                                fn = fn + '0';
                    fn = fn + js.ToString() + llast;

                    for (j = i; j < Gib.infile.Length; ++j)
                    {
                        if (j < Gib.infile.Length)
                            word = word + Gib.infile[j];
                        else
                            break;
                        if (Gib.infile[j] == '\n')
                        {
                            word = word + "\r\n";
                            while(j+1<Gib.infile.Length && (Gib.infile[j+1]=='\r' || Gib.infile[j+1]=='\n'))
                                ++j;
                            break;
                        }
                        prog.Value = j;
                    }
                    prog.Value = i;
                    if (llast == ".txt" || llast == ".TXT")
                        File.WriteAllText(fn, word, Encoding.GetEncoding("GB2312"));
                    else
                        File.WriteAllText(fn, word);
                    word = "";
                    i = j;
                }
                //MessageBoxEx.Show(Gib.infile, "提示", MessageBoxButtons.OK, MessageBoxIcon.None);
                //FrmMain frm=new FrmMain();
                //FrmMain frm = (FrmMain)this.Owner;
                frm.reffile(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]]);
                //((FrmCut)FrmMain).;
            }
            else
                MessageBoxEx.Show("分割后文件夹添加名不得为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            prog.Value = 10000;
            //frm.nowstate.Text = "完成";
        }
        void cutmd()
        {
            FrmMain frm = (FrmMain)this.Owner;
            int lsk;
            if (cutadd.Text != "")
            {
                js = 0;
                prog.Maximum = Gib.infile.Length;
                string llast = Path.GetExtension(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab] + 1]);
                Directory.CreateDirectory(Gib.crossfile1 + cutadd.Text);
                Gib.infile = "";
                string fn, word = "", lsw;
                //l = Gib.infile.Length;
                if (upfile.Checked)
                {
                    for (i = 0; i < Gib.infile.Length; ++i)
                    {
                        lsw = "";
                        if (i + fsn < Gib.infile.Length)
                            for (j = i; j < i + fsn; ++j)
                                lsw = lsw + Gib.infile[j];
                        if (lsw == fs)
                        {
                            for (j = i; j >= 0; --j)
                            {
                                if (mode4 == 1)
                                {
                                    if (pda())
                                        break;
                                }
                                else
                                {
                                    if (pdc())
                                        break;
                                }
                            }
                            word = "";
                            lsk = j + 1;
                            for (j = lsk; j < Gib.infile.Length; ++j)
                            {
                                word = word + Gib.infile[j];
                                if (mode4 == 1)
                                {
                                    if (pda())
                                        break;
                                }
                                else
                                {
                                    if (pdc())
                                        break;
                                }
                            }
                            i = j;
                            ++js;
                            fn = Gib.crossfile1 + cutadd.Text + "\\";
                            if (addz.Checked)
                                for (j = 1; j < azs; ++j)
                                    if (js < Math.Pow(10, j))
                                        fn = fn + '0';
                            fn = fn + js.ToString() + llast;
                            if (llast == ".txt" || llast == ".TXT")
                                File.WriteAllText(fn, word, Encoding.GetEncoding("GB2312"));
                            else
                                File.WriteAllText(fn, word);
                            Gib.infile = Gib.infile + word + '\n';
                        }
                        prog.Value = i;
                    }
                    frm.lrcv.Text = Gib.infile;
                    frm.reffile(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]]);
                }
                else
                {
                    for (i = 0; i < Gib.infile.Length; ++i)
                    {
                        lsw = "";
                        if (i + fsn < Gib.infile.Length)
                            for (j = i; j < i + fsn; ++j)
                                lsw = lsw + Gib.infile[j];
                        if (lsw == fs)
                        {
                            for (j = i; j >= 0; --j)
                            {
                                if (mode4 == 1)
                                {
                                    if (pda())
                                        break;
                                }
                                else
                                {
                                    if (pdc())
                                        break;
                                }
                            }
                            word = "";
                            lsk = j + 1;
                            for (j = lsk; j < Gib.infile.Length; ++j)
                            {
                                word = word + Gib.infile[j];
                                if (mode4 == 1)
                                {
                                    if (pda())
                                        break;
                                }
                                else
                                {
                                    if (pdc())
                                        break;
                                }
                            }
                            i = j;
                            ++js;
                            fn = Gib.crossfile1 + cutadd.Text + "\\";
                            if (addz.Checked)
                                for (j = 1; j < azs; ++j)
                                    if (js < Math.Pow(10, j))
                                        fn = fn + '0';
                            fn = fn + js.ToString() + llast;
                            if (llast == ".txt" || llast == ".TXT")
                                File.WriteAllText(fn, word, Encoding.GetEncoding("GB2312"));
                            else
                                File.WriteAllText(fn, word);
                        }
                        prog.Value = i;
                    }
                    frm.reffile(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]]);
                }
            }
            else
                MessageBoxEx.Show("分割后文件夹添加名不得为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //frm.nowstate.Text = "完成";
        }
        private void cut_Click(object sender, EventArgs e)
        {
            FrmMain frm = (FrmMain)this.Owner;
            //frm.nowstate.Text = "正在执行操作...";
            //MessageBoxEx.Show(Gib.infile, "提示", MessageBoxButtons.OK, MessageBoxIcon.None);
            if (Gib.crossfile1 != "Null")
            {
                if (mode == 1)
                {
                    cutma();
                }
                else if (mode == 2)
                {
                    cutmb();
                }
                else if (mode == 3)
                {
                    cutmc();
                }
                else
                {
                    if (fs != "")
                    {
                        cutmd();
                    }
                    else
                        MessageBoxEx.Show("查找字符串不得为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBoxEx.Show("未选中文件！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            File.WriteAllText(Gib.crossfile1, Gib.infile);
            this.Close();
        }

        private void cutch_TextChanged(object sender, EventArgs e)
        {
            cuts = cutch.Text;
            cutc = cuts.ToCharArray();
            cutn = cuts.Length;
        }


        private void r1_CheckedChanged(object sender, EventArgs e)
        {
            mode = 1;
        }
        private void r2_CheckedChanged(object sender, EventArgs e)
        {
            mode = 2;
        }
        private void r3_CheckedChanged(object sender, EventArgs e)
        {
            mode = 3;
        }

        private void cutsum_TextChanged(object sender, EventArgs e)
        {
            if (cutsum.Text != "")
            {
                wsum = Convert.ToInt32(cutsum.Text);
            }
            else
            {
                wsum = 1;
                cutsum.Text = "1";
            }
        }
        private void cutsum_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == 8)
                e.Handled = false;
        }
        private void azsum_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == 8)
                e.Handled = false;
        }
        private void azsum_TextChanged(object sender, EventArgs e)
        {
            if (azsum.Text != "")
            {
                azs = Convert.ToInt32(azsum.Text);
                if (azs > 100)
                {
                    azsum.Text = "100";
                    azs = 100;
                }
            }
            else
            {
                azs = 1;
                azsum.Text = "1";
            }
        }

        private void ficut_TextChanged(object sender, EventArgs e)
        {
            fc = ficut.Text;
            cfc = fc.ToCharArray();
            fcn = fc.Length;
        }

        private void r4_CheckedChanged(object sender, EventArgs e)
        {
            mode = 4;
        }

        private void r41_CheckedChanged(object sender, EventArgs e)
        {
            mode4 = 2;
        }

        private void r42_CheckedChanged(object sender, EventArgs e)
        {
            mode4 = 1;
        }

        private void finds_TextChanged(object sender, EventArgs e)
        {
            fs = finds.Text;
            cfs = fs.ToCharArray();
            fsn = fs.Length;
        }

        private void azsum_ValueChanged(object sender, EventArgs e)
        {
            azs = azsum.Value;
        }

        private void cutsum_ValueChanged(object sender, EventArgs e)
        {
            wsum = cutsum.Value;
        }

        private void upfile_CheckedChanged(object sender, EventArgs e)
        {

        }

    }
}
