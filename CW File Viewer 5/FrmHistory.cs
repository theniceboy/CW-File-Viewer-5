using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.IO;

namespace CW_File_Viewer_5
{
    public partial class FrmHistory : DevComponents.DotNetBar.Metro.MetroForm
    {
        int i;
        public FrmHistory()
        {
            InitializeComponent();
        }
        [DllImport("shell32.dll", EntryPoint = "SHGetFileInfo")]
        public static extern IntPtr SHGetFileInfo(string pszPath, uint dwFileAttribute, ref SHFILEINFO psfi, uint cbSizeFileInfo, uint Flags);
        [DllImport("User32.dll", EntryPoint = "DestroyIcon")]
        public static extern int DestroyIcon(IntPtr hIcon);
        [DllImport("shell32.dll")]
        public static extern uint ExtractIconEx(string lpszFile, int nIconIndex, int[] phiconLarge, int[] phiconSmall, uint nIcons);
        [StructLayout(LayoutKind.Sequential)]
        public struct SHFILEINFO
        {
            public IntPtr hIcon;
            public IntPtr iIcon;
            public uint dwAttributes;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
            public string szDisplayName;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
            public string szTypeName;
        }
        private void FrmHistory_Load(object sender, EventArgs e)
        {
            lfsum.Text = "共" + Gib.hissum.ToString() + "条历史记录";
            for (i = Gib.hissum; i >= 1; --i)
            {
                SHFILEINFO shfi = new SHFILEINFO();
                SHGetFileInfo(Gib.hispath[i], (uint)0x80, ref shfi, (uint)System.Runtime.InteropServices.Marshal.SizeOf(shfi), (uint)(0x100 | 0x400));
                try
                {
                    imageList1.Images.Add(Gib.hispath[i], (Icon)Icon.FromHandle(shfi.hIcon).Clone());
                }
                catch
                {
                    imageList1.Images.Add(Image.FromFile("media\\error.ico"));
                }
                hisv.Items.Add(Gib.hispath[i], Gib.hissum - i);
            }
        }

        private void hisv_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.hisv.SelectedItems.Count <= 0)
                return;
            string path = hisv.SelectedItems[0].Text;
            //MessageBoxEx.Show(path);
            FrmMain frmm = (FrmMain)this.Owner;
            Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab] + 1] = Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]];
            if (Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]].Length > 3)
                Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab] + 1] = Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab] + 1] + '\\';
            Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab] + 1] = Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab] + 1] + Gib.fname;
            //MessageBoxEx.Show(path, "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //folderbroser.SelectedPath = folderbroser.SelectedPath;
            //实例化DirectoryInfo对象

            Gib.last = Path.GetExtension(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab] + 1]);
            //获取指定目录下的所有子目录及文件类型
            if (Directory.Exists(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab] + 1]))
            {
                ++Gib.nowp[Gib.nowtab];
                Gib.maxn[Gib.nowtab] = Gib.maxn[Gib.nowtab] > Gib.nowp[Gib.nowtab] ? Gib.maxn[Gib.nowtab] : Gib.nowp[Gib.nowtab];
                //MessageBoxEx.Show(Gib.fpos[Gib.nowtab,Gib.nowp[Gib.nowtab]], "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                frmm.filepath.Text = Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]];
                //filename.Text = "";
                Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab] + 1] = "";
                frmm.reffile(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]]);
                File.WriteAllText("C:\\ProgramData\\CW Soft\\CW File Viewer\\Temp.txt", frmm.filepath.Text);
            }
            else
            {
                //MessageBoxEx.Show(cfile, "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                Gib.hispath[++Gib.hissum] = Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab] + 1];
                if (Gib.firsto == true)
                {
                    if (File.Exists(Gib.txtpath))
                    {
                        if (Path.GetExtension(Gib.txtpath) == "lrc" || Path.GetExtension(Gib.txtpath) == ".txt" || Path.GetExtension(Gib.txtpath) == ".LRC" || Path.GetExtension(Gib.txtpath) == ".TXT")
                        {
                            if (Path.GetExtension(Gib.txtpath) == ".txt" || Path.GetExtension(Gib.txtpath) == ".TXT")
                                File.WriteAllText(Gib.txtpath, Gib.infile, Encoding.GetEncoding("GB2312"));
                            else if (Path.GetExtension(Gib.txtpath) == ".lrc" || Path.GetExtension(Gib.txtpath) == ".LRC")
                                File.WriteAllText(Gib.txtpath, Gib.infile);
                            Gib.backup = Gib.infile;
                            frmm.txtstate.Text = "未修改";
                        }
                    }
                }
                else
                    Gib.firsto = true;
                frmm.filename.Text = Gib.fname;
                if (Gib.last == ".lrc" || Gib.last == ".txt" || Gib.last == ".LRC" || Gib.last == ".TXT")
                {
                    Gib.txtpath = Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab] + 1];

                    if (Gib.last == ".lrc" || Gib.last == ".LRC")
                    {
                        Gib.infile = File.ReadAllText(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab] + 1]);
                        frmm.lrcv.Text = Gib.infile;
                        Gib.backup = Gib.infile;
                        frmm.txtstate.Text = "未修改";
                    }
                    else if (Gib.last == ".txt" || Gib.last == ".TXT")
                    {
                        Gib.infile = File.ReadAllText(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab] + 1], Encoding.GetEncoding("GB2312"));
                        frmm.lrcv.Text = Gib.infile;
                        Gib.backup = Gib.infile;
                        frmm.txtstate.Text = "未修改";
                    }
                }
                else if (Gib.last == ".mp3")
                {
                    frmm.player.URL = Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab] + 1];
                    Gib.pstate = 1;
                    frmm.playbutton.Enabled = true;
                    frmm.player.Ctlcontrols.play();
                    frmm.playbutton.Image = Properties.Resources.state21;
                    frmm.playbutton.HoverImage = Properties.Resources.state22;
                    frmm.playbutton.PressedImage = Properties.Resources.state23;
                    if (frmm.looksametxt.Checked == true)
                    {
                        if (File.Exists(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]] + '\\' + Path.GetFileNameWithoutExtension(Gib.fname) + ".txt"))
                        {
                            Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab] + 1] = Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]] + '\\' + Path.GetFileNameWithoutExtension(Gib.fname) + ".txt";
                            Gib.nfname = Path.GetFileName(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab] + 1]);
                            Gib.last = ".txt";
                            frmm.filepath.Text = Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]];
                            Gib.txtpath = Gib.fname;
                            StreamReader fileread = new StreamReader(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]] + '\\' + Path.GetFileNameWithoutExtension(Gib.fname) + ".txt", Encoding.GetEncoding("GB2312"));
                            Gib.infile = fileread.ReadToEnd();
                            frmm.lrcv.Text = Gib.infile;
                            Gib.backup = Gib.infile;
                            frmm.txtstate.Text = "未修改";
                            frmm.filename.Text = Path.GetFileNameWithoutExtension(frmm.filename.Text) + ".txt";
                            fileread.Close();
                        }
                    }
                }
                else if (Gib.last == ".cst1" || Gib.last == ".cst2" || Gib.last == ".cst3")
                {
                    Gib.rtff = Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab] + 1];
                    Gib.infile = File.ReadAllText(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab] + 1]);
                    frmm.lrcv.Text = Gib.infile;
                    Gib.backup = Gib.infile;
                    frmm.txtstate.Text = "未修改";
                }
                else if (frmm.openotherfile.Checked == true)//if(Gib.last==".doc" || Gib.last==".docx" || Gib.last==".ppt" || Gib.last==".pptx" || Gib.last==".xls" || Gib.last==".xlsx")
                    System.Diagnostics.Process.Start(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab] + 1]);
                Gib.firsto = true;
            }
        }
    }
}
