using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;

namespace CW_File_Viewer_5
{
    public partial class FrmAll : DevComponents.DotNetBar.Metro.MetroForm
    {
        private int la, lc, dell, nowtab = 1;
        private char[] an = new char[100];
        private char[] cn = new char[100];
        private char[] delc = new char[100];

        public FrmAll()
        {
            InitializeComponent();
        }


        private void FrmAll_Load(object sender, EventArgs e)
        {
            tagchoosed.BackColor = Color.White;
        }

        private void work1()
        {
            bool canclose = true;
            int i, j, k;
            FrmMain frm = (FrmMain) this.Owner;
            //frm.nowstate.Text = "正在执行操作...";
            prog.Maximum = Gib.fsum[Gib.nowtab];
            if (r11.Checked)
            {
                if (nchg.Text != "")
                {
                    cn = nchg.Text.ToCharArray();
                    lc = nchg.Text.Length;
                    string newname;
                    for (i = 1; i <= Gib.fsum[Gib.nowtab]; ++i)
                    {
                        newname = "";
                        //MessageBoxEx.Show(i+' '+j+'\n'+Gib.cpath[Gib.nowtab, i] + '\n' + Gib.fpos[Gib.nowtab,Gib.nowp[Gib.nowtab]] + '\n' + newname + '\n' + Gib.clast[Gib.nowtab, i], "提示", MessageBoxButtons.OK, MessageBoxIcon.None);
                        for (j = 0; j < lc; ++j)
                        {
                            if (cn[j] == '/')
                            {
                                if (addz.Checked)
                                {
                                    if (addz.Checked)
                                        for (k = 1; k < azsum.Value; ++k)
                                            if (i < Math.Pow(10, k))
                                                newname = newname + '0';
                                }
                                newname = newname + i.ToString();
                            }
                            else
                                newname = newname + cn[j].ToString();
                            //MessageBoxEx.Show(j.ToString());
                        }

                        //MessageBoxEx.Show(Gib.cpath[Gib.nowtab, i] + '\n' + Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]] + '\\' + newname + Gib.clast[Gib.nowtab, i]);
                        if (Gib.cmode[Gib.nowtab, i] == 1 &&
                            File.Exists(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]] + '\\' + newname +
                                        Gib.clast[Gib.nowtab, i]) == false)
                        {
                            //MessageBoxEx.Show(Gib.cpath[Gib.nowtab, i] + '\n' + Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]] +'\\' + newname + Gib.clast[Gib.nowtab, i]);
                            File.Move(Gib.cpath[Gib.nowtab, i],
                                Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]] + '\\' + newname + Gib.clast[Gib.nowtab, i]);
                        }
                        prog.Value = i;
                    }
                }
                else
                {
                    this.highlighter.SetHighlightColor(this.nchg,
                    DevComponents.DotNetBar.Validator.eHighlightColor.Red);
                    this.errorProvider.SetError(this.nchg, "文件名不得为空！");
                    canclose = false;
                }
            }
            else if (r12.Checked)
            {
                an = nadd.Text.ToCharArray();
                string newname;
                la = nadd.Text.Length;
                if (r121.Checked)
                {
                    if (nadd.Text != "")
                    {
                        for (i = 1; i <= Gib.fsum[Gib.nowtab]; ++i)
                        {
                            newname = "";
                            for (j = 0; j < la; ++j)
                            {
                                if (an[j] == '/')
                                {
                                    if (addz.Checked)
                                    {
                                        if (i < 10)
                                            newname = newname + "0";
                                        if (i < 100)
                                            newname = newname + "0";
                                    }
                                    newname = newname + i.ToString();
                                }
                                else
                                    newname = newname + an[j].ToString();
                            }
                            prog.Value = i;
                            //MessageBoxEx.Show(Gib.cpath[Gib.nowtab, i] + '\n' + Gib.fpos[Gib.nowtab,Gib.nowp[Gib.nowtab]] + '\\' + System.IO.Path.GetFileNameWithoutExtension(Gib.cpath[Gib.nowtab, i]) + newname + Gib.clast[Gib.nowtab, i], "提示", MessageBoxButtons.OK, MessageBoxIcon.None);
                            if (Gib.cmode[Gib.nowtab, i] == 1 &&
                                File.Exists(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]] + '\\' + newname +
                                            Path.GetFileNameWithoutExtension(Gib.cpath[Gib.nowtab, i]) +
                                            Gib.clast[Gib.nowtab, i]) == false)
                                File.Move(Gib.cpath[Gib.nowtab, i],
                                    Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]] + '\\' + newname +
                                    Path.GetFileNameWithoutExtension(Gib.cpath[Gib.nowtab, i]) +
                                    Gib.clast[Gib.nowtab, i]);

                        }
                    }
                    else
                    {
                        this.highlighter.SetHighlightColor(this.nadd,
                        DevComponents.DotNetBar.Validator.eHighlightColor.Red);
                        this.errorProvider.SetError(this.nadd, "文件名不得为空！");
                        canclose = false;
                    }
                }
                else
                {
                    if (nadd.Text != "")
                    {
                        for (i = 1; i <= Gib.fsum[Gib.nowtab]; ++i)
                        {
                            newname = "";
                            for (j = 0; j < la; ++j)
                            {
                                if (an[j] == '/')
                                {
                                    if (addz.Checked)
                                    {
                                        if (i < 10)
                                            newname = newname + "0";
                                        if (i < 100)
                                            newname = newname + "0";
                                    }
                                    newname = newname + i.ToString();
                                }
                                else
                                    newname = newname + an[j].ToString();
                            }
                            prog.Value = i;
                            /*
                        MessageBoxEx.Show(Gib.cpath[Gib.nowtab, i] + '\n' + Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]] +
                                        '\\' + Path.GetFileNameWithoutExtension(Gib.cpath[Gib.nowtab, i]) + newname +
                                        Gib.clast[Gib.nowtab, i]);
                         */

                            if (Gib.cmode[Gib.nowtab, i] == 1 &&
                                File.Exists(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]] + '\\' +
                                            Path.GetFileNameWithoutExtension(Gib.cpath[Gib.nowtab, i]) + newname +
                                            Gib.clast[Gib.nowtab, i]) == false)
                                File.Move(Gib.cpath[Gib.nowtab, i],
                                    Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]] + '\\' +
                                    Path.GetFileNameWithoutExtension(Gib.cpath[Gib.nowtab, i]) + newname +
                                    Gib.clast[Gib.nowtab, i]);

                        }
                    }
                    else
                    {
                        this.highlighter.SetHighlightColor(this.nadd,
                        DevComponents.DotNetBar.Validator.eHighlightColor.Red);
                        this.errorProvider.SetError(this.nadd, "文件名不得为空！");
                        canclose = false;
                    }
                }
            }
            else if (r13.Checked)
            {
                if (r131.Checked)
                {
                    int lsl = 0;
                    bool bj;
                    string newname;
                    delc = delt.Text.ToCharArray();
                    dell = delt.Text.Length;
                    char[] lsoldc = new char[1000];
                    for (i = 1; i <= Gib.fsum[Gib.nowtab]; ++i)
                    {
                        newname = "";
                        lsoldc = Path.GetFileNameWithoutExtension(Gib.cpath[Gib.nowtab, i]).ToCharArray();
                        lsl = lsoldc.Length;
                        for (j = 0; j < lsl; ++j)
                        {
                            bj = true;
                            for (k = j; k < j + dell; ++k)
                                if (lsoldc[k] != delc[k - j])
                                {
                                    bj = false;
                                    break;
                                }
                            if (bj == true)
                            {
                                j = j + dell - 1;
                            }
                            else
                            {
                                newname += lsoldc[j].ToString();
                            }
                        }
                        prog.Value = i;
                        //MessageBoxEx.Show(Gib.cpath[Gib.nowtab, i] + "\r\n" + Gib.fpos[Gib.nowtab,Gib.nowp[Gib.nowtab]] + "\r\n" + '\\' + "\r\n" + newname + "\r\n" + Gib.clast + "\r\n" + Gib.fpos[Gib.nowtab,Gib.nowp[Gib.nowtab]] + '\\' + newname + Gib.clast[Gib.nowtab, i]);
                        //MessageBoxEx.Show(Gib.fpos[Gib.nowtab,Gib.nowp[Gib.nowtab]] + '\n' + newname);
                        //MessageBoxEx.Show(newname + '\n' + Gib.clast[Gib.nowtab, i]);// + '\n' + newname + Gib.clast[Gib.nowtab, i]);
                        //MessageBoxEx.Show(Gib.cpath[Gib.nowtab, i] + '\n' + Gib.fpos[Gib.nowtab,Gib.nowp[Gib.nowtab]] + '\\' + newname + Gib.clast[Gib.nowtab, i], "提示", MessageBoxButtons.OK, MessageBoxIcon.None);
                        if (Gib.cmode[Gib.nowtab, i] == 1 &&
                            File.Exists(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]] + '\\' + newname +
                                        Gib.clast[Gib.nowtab, i]) == false)
                            File.Move(Gib.cpath[Gib.nowtab, i],
                                Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]] + '\\' + newname + Gib.clast[Gib.nowtab, i]);
                    }
                }
                else
                {
                    int lsl = 0;
                    string newname;
                    char[] lsoldc = new char[1000];
                    for (i = 1; i <= Gib.fsum[Gib.nowtab]; ++i)
                    {
                        newname = "";
                        lsoldc = Path.GetFileNameWithoutExtension(Gib.cpath[Gib.nowtab, i]).ToCharArray();
                        lsl = lsoldc.Length;
                        //MessageBoxEx.Show(lsl.ToString() + '\n' + mode4.ToString()+'\n'+dsum.ToString());
                        if (r1321.Checked)
                            for (j = delsum.Value; j < lsl; ++j)
                                newname += lsoldc[j].ToString();
                        else
                            for (j = 0; j < lsl - delsum.Value; ++j)
                                newname += lsoldc[j].ToString();
                        //MessageBoxEx.Show(newname);
                        prog.Value = i;
                        //MessageBoxEx.Show(Gib.cpath[Gib.nowtab, i] + "\r\n" + Gib.fpos[Gib.nowtab,Gib.nowp[Gib.nowtab]] + "\r\n" + '\\' + "\r\n" + newname + "\r\n" + Gib.clast + "\r\n" + Gib.fpos[Gib.nowtab,Gib.nowp[Gib.nowtab]] + '\\' + newname + Gib.clast[Gib.nowtab, i]);
                        //MessageBoxEx.Show(Gib.fpos[Gib.nowtab,Gib.nowp[Gib.nowtab]] + '\n' + newname);
                        //MessageBoxEx.Show(newname + '\n' + Gib.clast[Gib.nowtab, i]);// + '\n' + newname + Gib.clast[Gib.nowtab, i]);
                        //MessageBoxEx.Show(Gib.cpath[Gib.nowtab, i] + '\n' + Gib.fpos[Gib.nowtab,Gib.nowp[Gib.nowtab]] + '\\' + newname + Gib.clast[Gib.nowtab, i], "提示", MessageBoxButtons.OK, MessageBoxIcon.None);
                        if (Gib.cmode[Gib.nowtab, i] == 1 &&
                            File.Exists(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]] + '\\' + newname +
                                        Gib.clast[Gib.nowtab, i]) == false)
                            File.Move(Gib.cpath[Gib.nowtab, i],
                                Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]] + '\\' + newname + Gib.clast[Gib.nowtab, i]);
                    }
                }
            }
            //frm.nowstate.Text = "完成";
            //MessageBoxEx.Show(Gib.fpos[Gib.nowtab,Gib.nowp[Gib.nowtab]] + '\n' + Gib.smode, "提示", MessageBoxButtons.OK, MessageBoxIcon.None);
            frm.reffile(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]]);
            if(canclose)
                this.Close();
        }

        private void work2()
        {
            int i, j, k;
            FrmMain frm = (FrmMain) this.Owner;
            //frm.nowstate.Text = "正在执行操作...";
            prog.Maximum = Gib.infile.Length;
            if (r21.Checked)
            {
                int lsjs = 2;
                string filename = "";
                string wrfile;
                //MessageBoxEx.Show(Gib.fpos[Gib.nowtab,Gib.nowp[Gib.nowtab]] + '\\' + Path.GetFileName(Gib.txtpath) + " - viewcut");
                Directory.CreateDirectory(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]] + '\\' +
                                          Path.GetFileName(Gib.txtpath) + " - viewcut");
                if (r211.Checked)
                {
                    if (writeinfile.Checked)
                    {
                        for (i = 0; i < Gib.infile.Length; ++i)
                        {
                            wrfile = "";
                            for (j = 0; j < fountn.Value; ++j)
                            {
                                if (Gib.infile[i] != ' ' && Gib.infile[i] != '　' && Gib.infile[i] != '\r')
                                    filename = filename + Gib.infile[i].ToString();

                                if (i >= Gib.infile.Length)
                                    break;
                                if (Gib.infile[i + 1] == '\n')
                                    break;
                                if (Gib.infile[i] == ' ' || Gib.infile[i] == '　' || Gib.infile[i] == '\r')
                                    --j;
                                wrfile = wrfile + Gib.infile[i].ToString();
                                ++i;
                                prog.Value = i;
                            }
                            for (j = 0;; ++j)
                            {
                                if (i >= Gib.infile.Length)
                                    break;
                                //if (Gib.infile[i+1] == '\r' && Gib.infile[i + 2] == '\n')
                                //    break;
                                if (i + 1 < Gib.infile.Length && Gib.infile[i + 1] == '\n')
                                    break;
                                wrfile = wrfile + Gib.infile[i].ToString();
                                ++i;
                                prog.Value = i;
                            }
                            if (i < Gib.infile.Length)
                            {
                                wrfile = wrfile + Gib.infile[i].ToString();
                                ++i;
                            }
                            //MessageBoxEx.Show('\"' + filename + '\"');
                            //MessageBoxEx.Show('\"' + wrfile + '\"');
                            //MessageBoxEx.Show(Gib.fpos[Gib.nowtab,Gib.nowp[Gib.nowtab]] + Path.GetFileName(Gib.txtpath) + " - viewcut\\" + filename + ".txt");
                            if (filename != "")
                            {
                                if (
                                    File.Exists(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]] + '\\' +
                                                Path.GetFileName(Gib.txtpath) + " - viewcut\\" + filename + ".txt") ==
                                    true)
                                {
                                    while (
                                        File.Exists(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]] + '\\' +
                                                    Path.GetFileName(Gib.txtpath) + " - viewcut\\" + filename + "（" +
                                                    lsjs.ToString() + "）.txt") == true)
                                        ++lsjs;
                                    File.WriteAllText(
                                        Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]] + '\\' +
                                        Path.GetFileName(Gib.txtpath) + " - viewcut\\" + filename + "（" +
                                        lsjs.ToString() + "）.txt", wrfile, Encoding.GetEncoding("GB2312"));
                                }
                                else
                                    File.WriteAllText(
                                        Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]] + '\\' +
                                        Path.GetFileName(Gib.txtpath) + " - viewcut\\" + filename + ".txt", wrfile,
                                        Encoding.GetEncoding("GB2312"));
                            }
                            filename = "";
                        }
                    }
                    else
                    {
                        wrfile = "";
                        for (i = 0; i < Gib.infile.Length; ++i)
                        {
                            for (j = 0; j < fountn.Value; ++j)
                            {
                                if (Gib.infile[i] != ' ' && Gib.infile[i] != '　' && Gib.infile[i] != '\r')
                                    filename = filename + Gib.infile[i].ToString();

                                if (i >= Gib.infile.Length)
                                    break;
                                if (Gib.infile[i + 1] == '\n')
                                    break;
                                if (Gib.infile[i] == ' ' || Gib.infile[i] == '　' || Gib.infile[i] == '\r')
                                    --j;
                                ++i;
                                prog.Value = i;
                            }
                            for (j = 0;; ++j)
                            {
                                if (i >= Gib.infile.Length)
                                    break;
                                //if (Gib.infile[i+1] == '\r' && Gib.infile[i + 2] == '\n')
                                //    break;
                                if (i + 1 < Gib.infile.Length && Gib.infile[i + 1] == '\n')
                                    break;
                                ++i;
                                prog.Value = i;
                            }
                            if (i < Gib.infile.Length)
                            {
                                ++i;
                            }
                            //MessageBoxEx.Show('\"' + filename + '\"');
                            //MessageBoxEx.Show('\"' + wrfile + '\"');
                            //MessageBoxEx.Show(Gib.fpos[Gib.nowtab,Gib.nowp[Gib.nowtab]] + Path.GetFileName(Gib.txtpath) + " - viewcut\\" + filename + ".txt");
                            if (filename != "")
                            {
                                if (createFoldersNotFiles.Checked)
                                {

                                    if (Directory.Exists(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]] + '\\' +
                                                         Path.GetFileName(Gib.txtpath) + " - viewcut\\" + filename +
                                                         ".txt"))
                                    {
                                        while (Directory.Exists(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]] + '\\' +
                                                                Path.GetFileName(Gib.txtpath) + " - viewcut\\" +
                                                                filename + "（" +
                                                                lsjs.ToString() + "）.txt"))
                                            ++lsjs;
                                        Directory.CreateDirectory(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]] + '\\' +
                                                                  Path.GetFileName(Gib.txtpath) + " - viewcut\\" +
                                                                  filename + "（" +
                                                                  lsjs.ToString() + "）");
                                    }
                                    else
                                        Directory.CreateDirectory(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]] + '\\' +
                                                                  Path.GetFileName(Gib.txtpath) + " - viewcut\\" +
                                                                  filename);
                                }
                                else
                                {
                                    if (
                                        File.Exists(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]] + '\\' +
                                                    Path.GetFileName(Gib.txtpath) + " - viewcut\\" + filename + ".txt") ==
                                        true)
                                    {
                                        while (
                                            File.Exists(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]] + '\\' +
                                                        Path.GetFileName(Gib.txtpath) + " - viewcut\\" + filename + "（" +
                                                        lsjs.ToString() + "）.txt"))
                                            ++lsjs;
                                        File.WriteAllText(
                                            Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]] + '\\' +
                                            Path.GetFileName(Gib.txtpath) + " - viewcut\\" + filename + "（" +
                                            lsjs.ToString() + "）.txt", wrfile, Encoding.GetEncoding("GB2312"));
                                    }
                                    else
                                        File.WriteAllText(
                                            Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]] + '\\' +
                                            Path.GetFileName(Gib.txtpath) + " - viewcut\\" + filename + ".txt", wrfile,
                                            Encoding.GetEncoding("GB2312"));
                                }
                            }
                            filename = "";
                        }
                    }
                }
                else
                {
                    if (writeinfile.Checked)
                    {
                        for (i = 0; i < Gib.infile.Length; ++i)
                        {
                            filename = "";
                            wrfile = "";
                            for (j = 0;; ++j)
                            {
                                if (i >= Gib.infile.Length)
                                    break;
                                //if (Gib.infile[i+1] == '\r' && Gib.infile[i + 2] == '\n')
                                //    break;
                                if (i + 1 < Gib.infile.Length && Gib.infile[i + 1] == '\n')
                                    break;
                                wrfile = wrfile + Gib.infile[i].ToString();
                                if (Gib.infile[i] != '\r')
                                    filename = filename + Gib.infile[i].ToString();
                                ++i;
                                prog.Value = i;
                            }
                            if (i < Gib.infile.Length)
                            {
                                wrfile = wrfile + Gib.infile[i].ToString();
                                if (Gib.infile[i] != '\r')
                                    filename = filename + Gib.infile[i].ToString();
                                ++i;
                            }
                            if (
                                File.Exists(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]] + '\\' +
                                            Path.GetFileName(Gib.txtpath) + " - viewcut\\" + filename + ".txt") == true)
                            {
                                while (
                                    File.Exists(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]] + '\\' +
                                                Path.GetFileName(Gib.txtpath) + " - viewcut\\" + filename + "（" +
                                                lsjs.ToString() + "）.txt") == true)
                                    ++lsjs;
                                File.WriteAllText(
                                    Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]] + '\\' + Path.GetFileName(Gib.txtpath) +
                                    " - viewcut\\" + filename + "（" + lsjs.ToString() + "）.txt", wrfile,
                                    Encoding.GetEncoding("GB2312"));
                            }
                            else
                                File.WriteAllText(
                                    Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]] + '\\' + Path.GetFileName(Gib.txtpath) +
                                    " - viewcut\\" + filename + ".txt", wrfile, Encoding.GetEncoding("GB2312"));
                        }
                    }
                    else
                    {
                        wrfile = "";
                        for (i = 0; i < Gib.infile.Length; ++i)
                        {
                            filename = "";
                            for (j = 0;; ++j)
                            {
                                if (i >= Gib.infile.Length)
                                    break;
                                if (i + 1 < Gib.infile.Length && Gib.infile[i + 1] == '\n')
                                    break;
                                if (Gib.infile[i] != '\r')
                                    filename = filename + Gib.infile[i].ToString();
                                ++i;
                                prog.Value = i;
                            }
                            if (i < Gib.infile.Length)
                            {
                                if (Gib.infile[i] != '\r')
                                    filename = filename + Gib.infile[i].ToString();
                                ++i;
                            }
                            if (createFoldersNotFiles.Checked)
                            {
                                if (Directory.Exists(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]] + '\\' +
                                                     Path.GetFileName(Gib.txtpath) + " - viewcut\\" + filename +
                                                     ".txt"))
                                {
                                    while (Directory.Exists(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]] + '\\' +
                                                            Path.GetFileName(Gib.txtpath) + " - viewcut\\" +
                                                            filename + "（" +
                                                            lsjs.ToString() + "）.txt"))
                                        ++lsjs;
                                    Directory.CreateDirectory(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]] + '\\' +
                                                              Path.GetFileName(Gib.txtpath) + " - viewcut\\" +
                                                              filename + "（" +
                                                              lsjs.ToString() + "）");
                                }
                                else
                                    Directory.CreateDirectory(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]] + '\\' +
                                                              Path.GetFileName(Gib.txtpath) + " - viewcut\\" +
                                                              filename);
                            }
                            else
                            {
                                if (File.Exists(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]] + '\\' +
                                                Path.GetFileName(Gib.txtpath) + " - viewcut\\" + filename + ".txt"))
                                {
                                    while (
                                        File.Exists(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]] + '\\' +
                                                    Path.GetFileName(Gib.txtpath) + " - viewcut\\" + filename + "（" +
                                                    lsjs.ToString() + "）.txt") == true)
                                        ++lsjs;
                                    File.WriteAllText(
                                        Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]] + '\\' +
                                        Path.GetFileName(Gib.txtpath) +
                                        " - viewcut\\" + filename + "（" + lsjs.ToString() + "）.txt", wrfile,
                                        Encoding.GetEncoding("GB2312"));
                                }
                                else
                                    File.WriteAllText(
                                        Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]] + '\\' +
                                        Path.GetFileName(Gib.txtpath) +
                                        " - viewcut\\" + filename + ".txt", wrfile, Encoding.GetEncoding("GB2312"));
                            }
                        }
                    }
                }
                frm.reffile(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]]);
                this.Close();
            }
            else
            {
                if (fn2.Text != "")
                {
                    an = nadd.Text.ToCharArray();
                    string filename;
                    if (fnum1.Value > fnum2.Value)
                    {
                        int tempn = fnum2.Value;
                        fnum2.Value = fnum1.Value;
                        fnum1.Value = tempn;
                    }
                    int alll = fnum2.Value - fnum1.Value + 1;
                    prog.Maximum = alll;
                    for (i = fnum1.Value; i <= fnum2.Value; ++i)
                    {
                        filename = "";
                        an = fn2.Text.ToCharArray();
                        for (j = 0; j < fn2.Text.Length; ++j)
                        {
                            if (an[j] == '/')
                            {
                                if (addz.Checked == true)
                                {
                                    if (addz.Checked == true)
                                        for (k = 1; k < azsum.Value; ++k)
                                            if (i < Math.Pow(10, k))
                                                filename = filename + '0';
                                }
                                filename += i.ToString();
                            }
                            else
                                filename += an[j].ToString();
                        }
                        if (File.Exists(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]] + '\\' + filename + ".txt") == false)
                            File.Create(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]] + '\\' + filename + ".txt");
                        //lplog.Text = (i - fnum1.Value+1).ToString() + '/' + alll;
                        //lplog.Refresh();
                        //MessageBoxEx.Show("Test");
                        prog.Value = i - fnum1.Value + 1;
                    }
                    frm.reffile(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]]);
                    this.Close();
                }
                else
                {
                    this.highlighter.SetHighlightColor(this.fn2,
                        DevComponents.DotNetBar.Validator.eHighlightColor.Red);
                    this.errorProvider.SetError(this.fn2, "文件名不得为空！");
                }
            }
        }

        private void work3()
        {
            int i;
            FrmMain frm = (FrmMain) this.Owner;
            prog.Maximum = Gib.fsum[Gib.nowtab];
            if (r31.Checked)
            {
                for (i = 1; i <= Gib.fsum[Gib.nowtab]; ++i)
                {
                    if (Gib.clast[Gib.nowtab, i] != '.' + allchanget.Text && File.Exists(Gib.cpath[Gib.nowtab, i]))
                        File.Move(Gib.cpath[Gib.nowtab, i],
                            Path.GetDirectoryName(Gib.cpath[Gib.nowtab, i]) + '\\' +
                            Path.GetFileNameWithoutExtension(Gib.cname[Gib.nowtab, i]) +
                            '.' + allchanget.Text);
                    prog.Value = i;
                }
            }
            else if (r32.Checked)
            {
                for (i = 1; i <= Gib.fsum[Gib.nowtab]; ++i)
                {
                    if (Gib.clast[Gib.nowtab, i].ToLower() != '.' + changet2.Text.ToLower() &&
                        File.Exists(Gib.cpath[Gib.nowtab, i]) &&
                        Gib.clast[Gib.nowtab, i].ToLower() == '.' + changet1.Text.ToLower())
                        File.Move(Gib.cpath[Gib.nowtab, i],
                            Path.GetDirectoryName(Gib.cpath[Gib.nowtab, i]) + '\\' +
                            Path.GetFileNameWithoutExtension(Gib.cname[Gib.nowtab, i]) +
                            '.' + changet2.Text);
                    prog.Value = i;
                }
            }
            else
            {
                Word.Application oWord = new Word.Application();
                object vOpt = System.Reflection.Missing.Value;
                try
                {
                    //MessageBoxEx.Show(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]]);
                    string[] fs = Directory.GetFiles(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]], "*.doc");
                    prog.Maximum = fs.Length;
                    int js = 0;
                    foreach (string of in fs)
                    {
                        object f = (object) of;
                        Word.Document vDoc = oWord.Documents.Open(ref f, ref vOpt, ref vOpt, ref vOpt, ref vOpt,
                            ref vOpt,
                            ref vOpt, ref vOpt, ref vOpt, ref vOpt, ref vOpt, ref vOpt, ref vOpt, ref vOpt, ref vOpt,
                            ref vOpt);

                        string txtf = Path.GetDirectoryName(of) + '\\' + Path.GetFileNameWithoutExtension(of) + ".txt";
                        if (File.Exists(txtf)) File.Delete(txtf);
                        object otxt = (object) txtf;
                        object saveFormat = Word.WdSaveFormat.wdFormatText;
                        vDoc.SaveAs(ref otxt, ref saveFormat, ref vOpt, ref vOpt, ref vOpt, ref vOpt, ref vOpt, ref vOpt,
                            ref vOpt, ref vOpt, ref vOpt, ref vOpt, ref vOpt, ref vOpt, ref vOpt, ref vOpt);
                        vDoc.Close(ref vOpt, ref vOpt, ref vOpt);
                        ++js;
                        prog.Value = js;
                    }
                }
                catch (Exception ex)
                {
                    MessageBoxEx.Show(ex.Message);
                }
                finally
                {
                    oWord.Quit(ref vOpt, ref vOpt, ref vOpt);
                    oWord = null;
                }
                frm.reffile(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]]);
            }
            frm.reffile(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]]);
            this.Close();
        }

        private void work4()
        {
            int i;
            prog.Maximum = Gib.fsum[Gib.nowtab];
            if (clearfile.Checked)
            {
                for (i = 1; i <= Gib.fsum[Gib.nowtab]; ++i)
                {
                    if (File.Exists(Gib.cpath[Gib.nowtab, i]))
                    {
                        if (Gib.clast[Gib.nowtab, i].ToLower() == ".txt")
                            File.WriteAllText(Gib.cpath[Gib.nowtab, i],
                                writetext.Text,
                                Encoding.GetEncoding("GB2312"));
                        else if (Gib.clast[Gib.nowtab, i].ToLower() == ".lrc")
                            File.WriteAllText(Gib.cpath[Gib.nowtab, i], writetext.Text);
                    }
                    prog.Value = i;
                }
            }
            else
            {
                if (writehead.Value)
                {
                    for (i = 1; i <= Gib.fsum[Gib.nowtab]; ++i)
                    {
                        if (File.Exists(Gib.cpath[Gib.nowtab, i]))
                        {
                            if (Gib.clast[Gib.nowtab, i].ToLower() == ".txt")
                                File.WriteAllText(Gib.cpath[Gib.nowtab, i],
                                    writetext.Text +
                                    File.ReadAllText(Gib.cpath[Gib.nowtab, i], Encoding.GetEncoding("GB2312")),
                                    Encoding.GetEncoding("GB2312"));
                            else if (Gib.clast[Gib.nowtab, i].ToLower() == ".lrc")
                                File.WriteAllText(Gib.cpath[Gib.nowtab, i],
                                    writetext.Text + File.ReadAllText(Gib.cpath[Gib.nowtab, i]));
                        }
                        prog.Value = i;
                    }

                }
                else
                {
                    for (i = 1; i <= Gib.fsum[Gib.nowtab]; ++i)
                    {
                        if (File.Exists(Gib.cpath[Gib.nowtab, i]))
                        {
                            if (Gib.clast[Gib.nowtab, i].ToLower() == ".txt")
                                File.WriteAllText(Gib.cpath[Gib.nowtab, i],
                                    File.ReadAllText(Gib.cpath[Gib.nowtab, i], Encoding.GetEncoding("GB2312")) +
                                    writetext.Text,
                                    Encoding.GetEncoding("GB2312"));
                            else if (Gib.clast[Gib.nowtab, i].ToLower() == ".lrc")
                                File.WriteAllText(Gib.cpath[Gib.nowtab, i],
                                    File.ReadAllText(Gib.cpath[Gib.nowtab, i]) + writetext.Text);
                        }
                        prog.Value = i;
                    }
                }
            }

            Gib.firsto = true;
            this.Close();
        }

        private void copyfile(string from, string to)
        {
            if (File.Exists(to))
            {
                int js = 2;
                while (
                    File.Exists(Path.GetFileNameWithoutExtension(to) + " (" + js.ToString() + ")" +
                                Path.GetExtension(to)))
                    ++js;
                File.Copy(from,
                    Path.GetDirectoryName(to) + "\\" + Path.GetFileNameWithoutExtension(to) + " (" + js.ToString() + ")" +
                    Path.GetExtension(to), true);
            }
            else
            {
                File.Copy(from, to, true);
            }
        }

        private void copyfolder(string from, string to)
        {
            if (!Directory.Exists(to))
                Directory.CreateDirectory(to);

            string[] str = Directory.GetFiles(from);
            foreach (string file in str)
                copyfile(file, to + '\\' + Path.GetFileName(file));

            // 子文件夹
            str = Directory.GetDirectories(from);
            foreach (string folder in str)
                copyfolder(folder, to + '\\' + Path.GetFileName(folder));
        }

        private void work5()
        {
            if (toname.Text.Trim() != "")
            {
                if (!Directory.Exists(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]] + "\\" + toname.Text))
                {
                    Directory.CreateDirectory(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]] + "\\" + toname.Text);
                    DirectoryInfo dinfo = new DirectoryInfo(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]]);
                    FileSystemInfo[] fsinfos = dinfo.GetFileSystemInfos();
                    string str;
                    foreach (FileSystemInfo fsinfo in fsinfos)
                        if (fsinfo is DirectoryInfo && fsinfo.Name != toname.Text)
                            copyfolder(fsinfo.FullName, Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]] + "\\" + toname.Text);
                    prog.Value = prog.Maximum;
                    FrmMain frm = (FrmMain) this.Owner;
                    frm.reffile(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]]);
                    this.Close();
                }
                else
                {
                    this.highlighter.SetHighlightColor(this.toname,
                        DevComponents.DotNetBar.Validator.eHighlightColor.Red);
                    this.errorProvider.SetError(this.toname, "目标文件夹已存在！");
                }
            }
            else
            {
                this.highlighter.SetHighlightColor(this.toname,
                        DevComponents.DotNetBar.Validator.eHighlightColor.Red);
                this.errorProvider.SetError(this.toname, "目标文件夹名不得为空！");
            }
                //Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]]
        }

        void addtagto(string file)
        {
            int i, j, x = -1;
            bool bj;
            for (i = 0; i < Gib.ts[Gib.nowsysi].ftagn; ++i)
                if (Gib.ts[Gib.nowsysi].ftagpath[i] == file)
                {
                    x = i;
                    break;
                }
            if (x > -1)
            {
                for (i = 0; i < Gib.choosedtagn; ++i)
                {
                    bj = true;
                    for ( j =0; j < Gib.ts[Gib.nowsysi].ftags[x]; ++j)
                        if (Gib.ts[Gib.nowsysi].ftagname[x, i] == Gib.choosedtags[i])
                        {
                            bj = false;
                            break;
                        }
                    if (bj)
                        Gib.ts[Gib.nowsysi].ftagname[x, i] = Gib.choosedtags[i];
                }
                Gib.ts[Gib.nowsysi].ftagpath[x] = file;
                Gib.ts[Gib.nowsysi].ftags[x] = Gib.choosedtagn;
            }
            else
            {
                for (i = 0; i < Gib.choosedtagn; ++i)
                    Gib.ts[Gib.nowsysi].ftagname[Gib.ts[Gib.nowsysi].ftagn, i] = Gib.choosedtags[i];
                Gib.ts[Gib.nowsysi].ftagpath[Gib.ts[Gib.nowsysi].ftagn] = file;
                Gib.ts[Gib.nowsysi].ftags[Gib.ts[Gib.nowsysi].ftagn] = Gib.choosedtagn;
                ++Gib.ts[Gib.nowsysi].ftagn;
            }
        }

        void work6()
        {
            bool canclose = true;
            if (Gib.choosedtagn <= 0)
            {
                this.highlighter.SetHighlightColor(this.tagchoosed,
                    DevComponents.DotNetBar.Validator.eHighlightColor.Red);
                this.errorProvider.SetError(this.nchg, "请选择标签！");
                canclose = false;
            }
            else
            {
                prog.Maximum = Gib.fsum[Gib.nowtab];
                for (int i = 1; i <= Gib.fsum[Gib.nowtab]; ++i)
                {
                    prog.Value = i;
                    addtagto(Gib.cpath[Gib.nowtab, i]);
                }
            }
            if (canclose)
                this.Close();
        }
       

        private void go_Click(object sender, EventArgs e)
        {
            if (nowtab == 1)
            {
                work1();
            }
            else if (nowtab == 2)
            {
                work2();
            }
            else if (nowtab == 3)
            {
                work3();
            }
            else if (nowtab == 4)
            {
                work4();
            }
            else if (nowtab == 5)
            {
                work5();
            }
            else
            {
                work6();
            }
        }

        private void tab1_Click(object sender, EventArgs e)
        {
            nowtab = 1;
        }

        private void tab2_Click(object sender, EventArgs e)
        {
            nowtab = 2;
        }

        private void tab3_Click(object sender, EventArgs e)
        {
            nowtab = 3;
        }

        private void tab4_Click(object sender, EventArgs e)
        {
            nowtab = 4;
        }

        private void tab5_Click(object sender, EventArgs e)
        {
            nowtab = 5;
        }

        private void clearfile_CheckedChanged(object sender, EventArgs e)
        {
            if (clearfile.Checked)
                l41.Enabled = l42.Enabled = writehead.Enabled = false;
            else
                l41.Enabled = l42.Enabled = writehead.Enabled = true;
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

        public void showchoosedtags()
        {
            int i;
            for (i = 0; i < Gib.choosedtagn; ++i)
            {
                ButtonX ctab = new ButtonX();
                ctab.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
                ctab.FocusCuesEnabled = false;
                ctab.Font = new Font("Consolas", 9F);
                ctab.Size = new Size(9 * getlen(Gib.choosedtags[i]) + 10, 27);
                ctab.Text = Gib.choosedtags[i];
                this.tagchoosed.Controls.Add(ctab);
            }
        }

        private void choosetag_Click(object sender, EventArgs e)
        {
            this.tagchoosed.Controls.Clear();
            Gib.dochoosetag = true;
            FrmTag frm = new FrmTag();
            frm.ShowDialog(this);
        }

        private void tab6_Click(object sender, EventArgs e)
        {
            nowtab = 6;
        }

        private void writeinfile_CheckedChanged(object sender, EventArgs e)
        {
            createFoldersNotFiles.Enabled = !writeinfile.Checked;
        }

        private void createFoldersNotFiles_CheckedChanged(object sender, EventArgs e)
        {
            writeinfile.Enabled = !createFoldersNotFiles.Checked;
        }
    }
}
