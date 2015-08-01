using System;
using System.Text;
using System.Windows.Forms;
using System.IO;
using DevComponents.DotNetBar;

namespace CW_File_Viewer_5
{
    public partial class FrmTool : DevComponents.DotNetBar.Metro.MetroForm
    {
        int i, j;
        char[] ls1 = new char[1];
        char[] ls2 = new char[1];
        public FrmTool()
        {
            InitializeComponent();
        }
        int pdc(char px)
        {
            /*
             * English : 1
             * Number  : 2
             * symbol  : 3
             * Chinese : 4
             * Other   : 5
            */
            if ((px >= 'a' && px <= 'z') || (px >= 'A' && px <= 'Z'))
                return 1;
            if (px >= '0' && px <= '9')
                return 2;
            if (px == '@' || px == '#' || px == '$' || px == '%' || px == '^' || px == '&' || px == '*' || px == '+' || px == '[' || px == ']' || px == '<' || px == '>' || px == '=' || px == '_' || px == '`' || px == '~' || px == ',' || px == ' ' || px == '.' || px == '?' || px == '!' || px == '(' || px == ')' || px == '\"' || px == '\'' || px == ';' || px == ':' || px == '-')
                return 3;
            ls1[0] = px;
            string lins1 = new string(ls1);
            //code = Char.ConvertToUtf32(px, px);    //获得字符串input中指定索引index处字符unicode编码
            if (px > 128)
                return 4;
            return 5;
        }
        private void Tool_Load(object sender, EventArgs e)
        {

        }

        private void killenter_Click(object sender, EventArgs e)
        {
            if (Gib.infile != "")
            {
                string lsinf = "";
                for (i = 0; i < Gib.infile.Length; ++i)
                {
                    if (i < Gib.infile.Length - 1)
                    {
                        if (Gib.infile[i] == '\r' && Gib.infile[i + 1] == '\n')
                        {
                            if (i < Gib.infile.Length - 3)
                            {
                                if ((Gib.infile[i + 2] == '\r' && Gib.infile[i + 3] == '\n') == false)
                                    lsinf = lsinf + Gib.infile[i];
                            }
                            else
                                lsinf = lsinf + Gib.infile[i];
                        }
                        else
                            lsinf = lsinf + Gib.infile[i];
                    }
                    else
                        lsinf = lsinf + Gib.infile[i];
                }
                Gib.infile = lsinf;
                FrmMain frm = (FrmMain)this.Owner;
                frm.lrcv.Text = Gib.infile;
            }
            this.Close();
        }
        public void finish()
        {
            FrmMain lft = new FrmMain();
            lft.Updatetext();
            FrmTool lft1 = new FrmTool();
            lft1.Close();
        }
        private void alltoone_Click(object sender, EventArgs e)
        {
            string str = "", lsstr;
            for (i = 1; i <= Gib.fsum[Gib.nowtab]; ++i)
            {
                if (Gib.clast[Gib.nowtab, i] == ".txt" || Gib.clast[Gib.nowtab, i] == ".TXT")
                {
                    StreamReader tfileread = new StreamReader(Gib.cpath[Gib.nowtab, i], Encoding.GetEncoding("GB2312"));
                    lsstr = tfileread.ReadToEnd();
                    str = str + lsstr;
                    tfileread.Close();
                }
                if (Gib.clast[Gib.nowtab, i] == ".lrc" || Gib.clast[Gib.nowtab, i] == ".LRC")
                {
                    StreamReader tfileread = new StreamReader(Gib.cpath[Gib.nowtab, i]);
                    lsstr = tfileread.ReadToEnd();
                    str = str + lsstr;
                    tfileread.Close();
                }
            }
            string lsfn = Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]] + '\\' + "Merge - " + DateTime.Now.ToLongDateString().ToString() + ".txt";
            //MessageBoxEx.Show(lsfn);
            //MessageBoxEx.Show(str);
            File.WriteAllText(lsfn, str, Encoding.GetEncoding("GB2312"));
            FrmMain frm = (FrmMain)this.Owner;
            frm.reffile(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]]);
            this.Close();
        }

        private void changecode_Click(object sender, EventArgs e)
        {
            if (Path.GetExtension(Gib.crossfile1) != "")
            {
                System.Diagnostics.Process.Start(Gib.crossfile1);
                //FrmChangeCode fcc = new FrmChangeCode();
                //fcc.ShowDialog(this);
                this.Close();
            }
            else
                MessageBoxEx.Show("未选择文件！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void makesamefile_Click(object sender, EventArgs e)
        {
            for (i = 1; ; ++i)
                if (File.Exists(Path.GetDirectoryName(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab] + 1]) + '\\' + Path.GetFileNameWithoutExtension(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab] + 1]) + " - 副本" + i.ToString() + Path.GetExtension(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab] + 1])) == false)
                    break;
            //MessageBoxEx.Show(Gib.fpos[Gib.nowtab,Gib.nowp[Gib.nowtab] + 1] + '\n' + Path.GetDirectoryName(Gib.fpos[Gib.nowtab,Gib.nowp[Gib.nowtab] + 1]) + '\\' + Path.GetFileNameWithoutExtension(Gib.fpos[Gib.nowtab,Gib.nowp[Gib.nowtab] + 1]) + " - 副本" + i.ToString() + Path.GetExtension(Gib.fpos[Gib.nowtab,Gib.nowp[Gib.nowtab] + 1]));
            string sss = Path.GetDirectoryName(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab] + 1]) + '\\' + Path.GetFileNameWithoutExtension(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab] + 1]) + " - 副本" + i.ToString() + Path.GetExtension(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab] + 1]);//File.Copy(Path.GetDirectoryName(Gib.fpos[Gib.nowtab,Gib.nowp[Gib.nowtab] + 1]), Path.GetDirectoryName(Gib.fpos[Gib.nowtab,Gib.nowp[Gib.nowtab] + 1]) + '\\' + Path.GetFileNameWithoutExtension(Gib.fpos[Gib.nowtab,Gib.nowp[Gib.nowtab] + 1]) + " - 副本" + i.ToString() + Path.GetExtension(Gib.fpos[Gib.nowtab,Gib.nowp[Gib.nowtab] + 1]),true);
            File.Copy(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab] + 1], sss);
            FrmMain frm = (FrmMain)this.Owner;
            frm.reffile(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]]);
            this.Close();
        }

        private void killenglish_Click(object sender, EventArgs e)
        {
            Gib.infile = "";
            for (i = 0; i < Gib.infile.Length; ++i)
                if (pdc(Gib.infile[i]) != 1 && pdc(Gib.infile[i]) != 3)
                {
                    Gib.infile = Gib.infile + Gib.infile[i];
                    //MessageBoxEx.Show(Gib.infile, "提示", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            FrmMain frm = (FrmMain)this.Owner;
            frm.lrcv.Text = Gib.infile;
            this.Close();
        }

        private void killchinese_Click(object sender, EventArgs e)
        {
            Gib.infile = "";
            for (i = 0; i < Gib.infile.Length; ++i)
                if (pdc(Gib.infile[i]) != 2 && pdc(Gib.infile[i]) != 4)
                {
                    Gib.infile = Gib.infile + Gib.infile[i];
                    //MessageBoxEx.Show(Gib.infile, "提示", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            FrmMain frm = (FrmMain)this.Owner;
            frm.lrcv.Text = Gib.infile;
            this.Close();
        }

        private void recover_Click(object sender, EventArgs e)
        {
            FrmMain frm = (FrmMain)this.Owner;
            Gib.infile = Gib.backup;
            frm.lrcv.Text = Gib.infile;
        }

        private void metroShell1_Click(object sender, EventArgs e)
        {

        }
    }
}
/*
asdfasaui hsadimfasdfhsamdfuusah dsaf 
ads fsadf dmsaimhas df


fsadf sadf isamdfiumaishdf asdf
asdf sadf
asdf sadf\\\\\

abstractsfasd
Attribute .ads
sadf

*/