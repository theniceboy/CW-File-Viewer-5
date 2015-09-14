using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.ExceptionServices;
using System.Speech.Recognition;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using DevComponents.DotNetBar;

namespace CW_File_Viewer_5
{

    public partial class FrmMain : DevComponents.DotNetBar.RibbonForm
    {
        /*
         * c : class
         * f : place
        */

        #region Define

        private int js, ls;
        public bool isleftkey;
        private string tablsname;
        private char[] lsstr = new char[100000];
        private char[] ls1 = new char[1];

        private int closemode = 1;

        string[] sset =new string[5];

        private bool dobackup = false;

        private string saveplace = "C:\\ProgramData\\CW Soft\\CW File Viewer\\";
        
        #endregion

        public FrmMain()
        {
            InitializeComponent();
        }

        /*
            Encoding targetEncoding = Encoding.Default;
            FileStream stream = new FileStream(filename, FileMode.Open, FileAccess.Read);
            if (stream != null && stream.Length >= 2)
            {
//保存文件流的前4个字节
                byte byte1 = 0;
                byte byte2 = 0;
                byte byte3 = 0;

                stream.Seek(0, SeekOrigin.Begin);
                int nByte = stream.ReadByte();
                byte1 = Convert.ToByte(nByte);
                byte2 = Convert.ToByte(stream.ReadByte());

                if (stream.Length >= 3)
                    byte3 = Convert.ToByte(stream.ReadByte());
//根据文件流的前4个字节判断Encoding
//Unicode {0xFF, 0xFE};
//BE-Unicode {0xFE, 0xFF};
//UTF8 = {0xEF, 0xBB, 0xBF};

                if (byte1 == 0xFE && byte2 == 0xFF) //UnicodeBe
                    targetEncoding = Encoding.BigEndianUnicode;

                if (byte1 == 0xFF && byte2 == 0xFE && byte3 != 0xFF) //Unicode
                    targetEncoding = Encoding.Unicode;

                if (byte1 == 0xEF && byte2 == 0xBB && byte3 == 0xBF) //UTF8
                    targetEncoding = Encoding.UTF8;
            }
            stream.Close();
            stream.Dispose();
            return targetEncoding;
         */
        private void buttonItem_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(((ButtonItem)sender).Tag.ToString()))
            {
                Gib.fpos[Gib.nowtab, ++Gib.nowp[Gib.nowtab]] = ((ButtonItem)sender).Tag.ToString();
                Gib.maxn[Gib.nowtab] = Gib.maxn[Gib.nowtab] > Gib.nowp[Gib.nowtab]
                    ? Gib.maxn[Gib.nowtab]
                    : Gib.nowp[Gib.nowtab];
                filepath.Text = Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]];
                reffile(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]]);
            }
            else
            {
                if (DialogResult.OK ==
                    MessageBoxEx.Show("路径已不存在，是否删除", "提示", MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Question))
                {
                    collectionbar.Items.Remove((ButtonItem)sender);
                    --Gib.collectn;
                    collectionbar.Refresh();
                }
            }
            if (Gib.nowtab == 1) filev1.Focus();
            else if (Gib.nowtab == 2) filev2.Focus();
            else filev3.Focus();
        }
        private void buttonItem_MouseDown(object sender, MouseEventArgs e)
        {
            Gib.rbcol = ((ButtonItem) sender);
        }

        #region DllImport
        [DllImport("shell32.dll", EntryPoint = "SHGetFileInfo")]
        public static extern IntPtr SHGetFileInfo(string pszPath, uint dwFileAttribute, ref SHFILEINFO psfi,
            uint cbSizeFileInfo, uint Flags);

        [DllImport("User32.dll", EntryPoint = "DestroyIcon")]
        public static extern int DestroyIcon(IntPtr hIcon);

        [DllImport("shell32.dll")]
        public static extern uint ExtractIconEx(string lpszFile, int nIconIndex, int[] phiconLarge, int[] phiconSmall,
            uint nIcons);

        [StructLayout(LayoutKind.Sequential)]
        public struct SHFILEINFO
        {
            public IntPtr hIcon;
            public IntPtr iIcon;
            public uint dwAttributes;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)] public string szDisplayName;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)] public string szTypeName;
        }
        #endregion


        #region FrmMain Things

        /*
         * File Format In The Setting File
         * Lines And Meanings In Orders :
         * 1 savenohint 1:Checked 2:UnChecked
         * 2 
         * 3 
         * 4 
        */

        public void initsettings()
        {
            Gib.settingl = 2;
            Gib.settings[0] = 1;
            sset[0] = "1";
            Gib.settings[1] = 0;
            sset[1] = "0";
            Gib.settings[2] = 1;
            sset[2] = "1";
            Gib.settings[3] = 0;
            sset[3] = "0";
            Gib.settings[4] = 1;
            sset[4] = "1";
            File.WriteAllLines("C:\\ProgramData\\CW Soft\\CW File Viewer\\Settings.txt", sset);
        }

        void loadsettings(string[] sset)
        {
            for (int i = 0; i < Gib.settingl; ++i)
                Gib.settings[i] = Convert.ToInt32(sset[i]);
            savenohint.Checked = Convert.ToBoolean(Gib.settings[0]);
            recoveryatfirst.Checked = Convert.ToBoolean(Gib.settings[1]);
            if (Gib.settings[2] > 0)
            {
                autosave.Enabled = true;
                autosave.Interval = 60000*Gib.settings[2];
                useast.Checked = true;
                autost.Value = Gib.settings[2];
            }
            else
            {
                useast.Checked = false;
                autost.Enabled = false;
                textl1.Enabled = false;
            }
            filehighlight.Checked = Convert.ToBoolean(Gib.settings[3]);
            UseFormatForm.Checked = Convert.ToBoolean(Gib.settings[4]);
        }

        string cutstring(string old)
        {
            if (old.Length > 14)
                return old.Remove(14)+"...";
            return old;
        }

        private void loadcollection()
        {
            StreamReader cfile = new StreamReader("C:\\ProgramData\\CW Soft\\CW File Viewer\\Collection.txt",
                Encoding.GetEncoding("GB2312"));
            Gib.collectn = 0;
            collectionbar.Items.Clear();
            while ((Gib.collects[Gib.collectn] = cfile.ReadLine()) != null)
            {
                ButtonItem buttonitem = new ButtonItem();

                if (Directory.Exists(Gib.collects[Gib.collectn]))
                    buttonitem.Image = Properties.Resources.folderp;
                else
                    buttonitem.Image = Properties.Resources.errorp;

                buttonitem.ButtonStyle = eButtonStyle.ImageAndText;
                buttonitem.Tag = buttonitem.Tooltip = Gib.collects[Gib.collectn];
                buttonitem.Text = cutstring(Path.GetFileName(Gib.collects[Gib.collectn]));
                buttonitem.Click += new System.EventHandler(buttonItem_Click);
                buttonitem.MouseDown += new System.Windows.Forms.MouseEventHandler(buttonItem_MouseDown);
        
                collectionbar.Items.Add(buttonitem);
                ++Gib.collectn;
            }
            cfile.Close();
            cfile.Dispose();
        }
        /*
        private void G_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            switch (e.Result.Text)
            {
                case "分割":
                    cut_Click(sender, e);
                    break;
                case "批量":
                    batch_Click(sender, e);
                    break;
                case "标签":
                    filetag_Click(sender, e);
                    break;
            }
        }
         */

        //private SpeechRecognitionEngine SRE = new SpeechRecognitionEngine();

        public void FrmMain_Load(object sender, EventArgs e)
        {
            FrmBegin frm = new FrmBegin();
            frm.ShowDialog(this);

            todirc.Enabled = Directory.Exists("C:\\");
            todird.Enabled = Directory.Exists("D:\\");
            todire.Enabled = Directory.Exists("E:\\");
            todirf.Enabled = Directory.Exists("F:\\");
            /*
            try
            {
                Control.CheckForIllegalCrossThreadCalls = false;
                SRE.SetInputToDefaultAudioDevice();
                GrammarBuilder GB = new GrammarBuilder();
                GB.Append(new Choices(new string[] { "分割", "批量", "标签" }));
                Grammar G = new Grammar(GB);
                G.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(G_SpeechRecognized);
                SRE.LoadGrammar(G);
                SRE.RecognizeAsync(RecognizeMode.Multiple);
            }
            catch
            {
                ToastNotification.Show(this, "未接入录音设备。如使用语音识别功能，请接入设备后重启程序", Properties.Resources.errorflag, 7000, eToastGlowColor.Red,
                    eToastPosition.TopCenter);
            }
             */
            
            if (File.Exists("C:\\ProgramData\\CW Soft\\CW File Viewer\\Settings.txt") == false)
            {
                //File.Create("C:\\ProgramData\\CW Soft\\CW File Viewer\\Settings.txt");
                initsettings();
            }
            else
            {
                string[] sset =
                    File.ReadAllLines("C:\\ProgramData\\CW Soft\\CW File Viewer\\Settings.txt");
                Gib.settingl = sset.Length;
                loadsettings(sset);
            }
            if (Gib.settings[1] == 1)
            {
                try
                {
                    string[] tp = File.ReadAllLines("C:\\ProgramData\\CW Soft\\CW File Viewer\\TempPath.txt");

                    try
                    {
                        filepath.Text = tp[1];
                        tab2_Click(sender, e);
                        filepath.Text = tp[1];
                        if (Directory.Exists(filepath.Text))
                        {
                            Gib.fpos[2, ++Gib.nowp[2]] = filepath.Text;
                            if (Gib.nowp[2] > Gib.maxn[2])
                                Gib.maxn[2] = Gib.nowp[2];
                            Gib.nowtab = 2;
                            reffile(Gib.fpos[2, Gib.nowp[2]]);
                        }
                    }
                    catch
                    {
                    }

                    try
                    {
                        filepath.Text = tp[2];
                        tab3_Click(sender, e);
                        filepath.Text = tp[2];
                        if (Directory.Exists(filepath.Text))
                        {
                            Gib.fpos[3, ++Gib.nowp[3]] = filepath.Text;
                            if (Gib.nowp[3] > Gib.maxn[3])
                                Gib.maxn[3] = Gib.nowp[3];
                            Gib.nowtab = 3;
                            reffile(Gib.fpos[3, Gib.nowp[3]]);
                        }
                    }
                    catch
                    {
                    }

                    tab1_Click(sender, e);
                    try
                    {
                        filepath.Text = tp[0];
                        if (Directory.Exists(filepath.Text))
                        {
                            Gib.fpos[1, ++Gib.nowp[1]] = filepath.Text;
                            if (Gib.nowp[1] > Gib.maxn[1])
                                Gib.maxn[1] = Gib.nowp[1];
                            Gib.nowtab = 1;
                            reffile(Gib.fpos[1, Gib.nowp[1]]);
                        }
                    }
                    catch
                    {
                    }
                }
                catch
                {
                }
            }

            if (File.Exists("C:\\ProgramData\\CW Soft\\CW File Viewer\\Collection.txt"))
                loadcollection();
            else
                File.Create("C:\\ProgramData\\CW Soft\\CW File Viewer\\Collection.txt");

            collectionbar.Refresh();

            for (int i = 0; i < Gib.tsn; ++i)
            {
                ComboBoxItem page = new ComboBoxItem();
                page.Text = Gib.ts[i].name;
                page.Tag = i;
                tschooser.Items.Add(page);
            }
            tschooser.SelectedIndex = Gib.nowsysi;
        }

        public void reboot()
        {
            closemode = 2;
            closingthing();
        }


        private void closingt_Tick(object sender, EventArgs e)
        {
            if (saveplace == "C:\\ProgramData\\CW Soft\\CW File Viewer\\EmergencyRealTimeBackup\\")
            {
                Directory.Delete("C:\\ProgramData\\CW Soft\\CW File Viewer\\EmergencyRealTimeBackup", true);
                while (Directory.Exists("C:\\ProgramData\\CW Soft\\CW File Viewer\\EmergencyRealTimeBackup")) { }
                Directory.CreateDirectory("C:\\ProgramData\\CW Soft\\CW File Viewer\\EmergencyRealTimeBackup");
            }
            //try
            {
                closingt.Enabled = false;
                int i, j;
                string[] tpwrite = new string[3];
                tpwrite[0] = Gib.fpos[1, Gib.nowp[1]];
                tpwrite[1] = Gib.fpos[2, Gib.nowp[2]];
                tpwrite[2] = Gib.fpos[3, Gib.nowp[3]];
                File.WriteAllLines(saveplace + "TempPath.txt", tpwrite);
                for (i = 0; i < Gib.settingl; ++i)
                    sset[i] = Gib.settings[i].ToString();
                File.WriteAllLines(saveplace + "Settings.txt", sset);

                StreamWriter cfile = new StreamWriter(saveplace + "Collection.txt",
                    false, Encoding.GetEncoding("GB2312"));
                foreach (ButtonItem buttonitem in collectionbar.Items)
                {
                    cfile.WriteLine(buttonitem.Tag.ToString());
                }
                cfile.Close();
                cfile.Dispose();
                bool bj;

                if (!Directory.Exists(saveplace + "TagSystem"))
                    Directory.CreateDirectory(saveplace + "TagSystem");

                for (int tsi = 0; tsi < Gib.tsn; ++tsi)
                {
                    if (!Directory.Exists(saveplace + "TagSystem\\" + Gib.ts[tsi].name))
                        Directory.CreateDirectory(saveplace + "TagSystem\\" + Gib.ts[tsi].name);
                    if (!Directory.Exists(saveplace + "TagSystem\\" + Gib.ts[tsi].name + "\\TagInfo"))
                        Directory.CreateDirectory(saveplace + "TagSystem\\" + Gib.ts[tsi].name + "\\TagInfo");
                    //Which file has been sign up which tag and what's those tag's path
                    StreamWriter tpfile =
                        new StreamWriter(saveplace + "TagSystem\\" + Gib.ts[tsi].name +
                                         "\\TagPath.txt");
                    StreamWriter tnfile =
                        new StreamWriter(saveplace + "TagSystem\\" + Gib.ts[tsi].name +
                                         "\\TagName.txt");
                    for (i = 0; i < Gib.ts[tsi].ftagn; ++i)
                        if (Gib.ts[tsi].ftagpath[i] != "" && Gib.ts[tsi].ftags[i] > 0)
                        {
                            bj = false;
                            for (j = 0; j < Gib.ts[tsi].ftags[i]; ++j)
                                if (Gib.ts[tsi].ftagname[i, j] != "")
                                {
                                    tnfile.Write(Gib.ts[tsi].ftagname[i, j] + "\\");
                                    bj = true;
                                }
                            if (bj)
                            {
                                tpfile.WriteLine(Gib.ts[tsi].ftagpath[i]);
                                tnfile.Write("\n");
                            }
                        }
                    tpfile.Close();
                    tpfile.Dispose();
                    tnfile.Close();
                    tnfile.Dispose();

                    //All the tag's name and which page are those tag in
                    StreamWriter tatfile =
                        new StreamWriter(saveplace + "TagSystem\\" + Gib.ts[tsi].name +
                                         "\\AllTag.txt");
                    StreamWriter ttagp =
                        new StreamWriter(saveplace + "TagSystem\\" + Gib.ts[tsi].name +
                                         "\\TagPage.txt");
                    for (i = 0; i < Gib.ts[tsi].tagn; ++i)
                    {
                        if (Gib.ts[tsi].taginfo[i] != "" && Gib.ts[tsi].taginfo[i] != null)
                            File.WriteAllText(
                                saveplace + "TagSystem\\" + Gib.ts[tsi].name +
                                "\\TagInfo\\" +
                                Gib.ts[tsi].alltag[i] + ".txt",
                                Gib.ts[tsi].taginfo[i], Encoding.GetEncoding("GB2312"));
                        else if (
                            File.Exists(saveplace + "TagSystem\\" + Gib.ts[tsi].name + "\\TagInfo\\" +
                                        Gib.ts[tsi].alltag[i] + ".txt"))
                        {
                            File.Delete(saveplace + "TagSystem\\" + Gib.ts[tsi].name + "\\TagInfo\\" +
                                        Gib.ts[tsi].alltag[i] + ".txt");
                        }
                        tatfile.WriteLine(Gib.ts[tsi].alltag[i]);
                        ttagp.WriteLine(Gib.ts[tsi].tagp[i]);
                    }
                    tatfile.Close();
                    tatfile.Dispose();
                    ttagp.Close();
                    ttagp.Dispose();

                    StreamWriter tallpage =
                        new StreamWriter(saveplace + "TagSystem\\" + Gib.ts[tsi].name +
                                         "\\AllPage.txt");
                    for (i = 0; i < Gib.ts[tsi].pagen; ++i)
                        if (Gib.ts[tsi].allpage[i] != "")
                            tallpage.WriteLine(Gib.ts[tsi].allpage[i]);
                    tallpage.Close();
                    tallpage.Dispose();
                }
            }
            //catch
            //{
            //    closingt.Enabled = true;
            //    return;
            //}
            if (dobackup)
            {
                closemode = 0;
                dobackup = false;
                backup();
            }
            if (closemode == 2)
            {
                closemode = 1;
                FrmBegin frm = new FrmBegin();
                frm.ShowDialog();

                if (File.Exists(saveplace + "Settings.txt") == false)
                {
                    initsettings();
                }
                else
                {
                    sset =
                        File.ReadAllLines(saveplace + "Settings.txt");
                    Gib.settingl = sset.Length;
                    loadsettings(sset);
                }
                if (Gib.settings[1] == 1)
                {
                    try
                    {
                        filepath.Text = File.ReadAllText(saveplace + "TempPath.txt");
                        if (Directory.Exists(filepath.Text))
                        {
                            Gib.fpos[Gib.nowtab, ++Gib.nowp[Gib.nowtab]] = filepath.Text;
                            if (Gib.nowp[Gib.nowtab] > Gib.maxn[Gib.nowtab])
                                Gib.maxn[Gib.nowtab] = Gib.nowp[Gib.nowtab];
                            reffile(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]]);
                        }
                    }
                    catch
                    {
                    }
                }

                if (File.Exists(saveplace + "Collection.txt"))
                    loadcollection();
                else
                    File.Create(saveplace + "Collection.txt");

                collectionbar.Refresh();
            }
            else if (closemode == 1)
            {
                this.FormClosing -= new FormClosingEventHandler(this.FrmMain_FormClosing);
                Application.Exit();
            }
            else if (closemode == 0)
            {
                //ToastNotification.Show(this, "成功保存当前状态", 2000);
                closemode = 1;
            }

            if (saveplace == "C:\\ProgramData\\CW Soft\\CW File Viewer\\EmergencyRealTimeBackup\\")
                saveplace = "C:\\ProgramData\\CW Soft\\CW File Viewer\\";
        }

        private void closingthing()
        {
            /*
            try
            {
                DirectoryInfo dir = new DirectoryInfo("C:\\ProgramData\\CW Soft\\CW File Viewer\\TagSystem");
                FileSystemInfo[] files = dir.GetFileSystemInfos();
                for (int i = 0; i < Gib.tsn; ++i)
                {
                    File.Delete("C:\\ProgramData\\CW Soft\\CW File Viewer\\TagSystem\\" + Gib.ts[i].name +
                                "\\TagPath.txt");
                    File.Delete("C:\\ProgramData\\CW Soft\\CW File Viewer\\TagSystem\\" + Gib.ts[i].name +
                                "\\TagName.txt");
                    File.Delete("C:\\ProgramData\\CW Soft\\CW File Viewer\\TagSystem\\" + Gib.ts[i].name +
                                "\\AllTag.txt");
                    File.Delete("C:\\ProgramData\\CW Soft\\CW File Viewer\\TagSystem\\" + Gib.ts[i].name +
                                "\\AllPage.txt");
                    File.Delete("C:\\ProgramData\\CW Soft\\CW File Viewer\\TagSystem\\" + Gib.ts[i].name +
                                "\\TagPage.txt");
                    Directory.Delete("C:\\ProgramData\\CW Soft\\CW File Viewer\\TagSystem\\" + Gib.ts[i].name +
                          "\\TagInfo", true);
                }
            }
            catch { }
             */

            closingt.Enabled = true;
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            if (Gib.backup != Gib.infile)
            {
                if (DialogResult.OK ==
                    MessageBoxEx.Show("文件未保存，确定要不保存文件并关闭CW File Viewer吗？", "提示", MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Question))
                    closingthing();
            }
            else
                closingthing();
        }


        #endregion

        private int pdc(char px)
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
            if (px == '@' || px == '#' || px == '$' || px == '%' || px == '^' || px == '&' || px == '*' || px == '+' ||
                px == '[' || px == ']' || px == '<' || px == '>' || px == '=' || px == '_' || px == '`' || px == '~' ||
                px == ',' || px == ' ' || px == '.' || px == '?' || px == '!' || px == '(' || px == ')' || px == '\"' ||
                px == '\'' || px == ';' || px == ':' || px == '-')
                return 3;
            ls1[0] = px;
            //code = Char.ConvertToUtf32(px, px);    //获得字符串input中指定索引index处字符unicode编码
            if (px > 128)
                return 4;
            return 5;
        }


        #region File Look

        private bool pdnum(char x)
        {
            if (x >= '0' && x <= '9')
                return true;
            return false;
        }

        private bool goodcmp(string ca, string cb)
        {
            if (ca == "" || cb == "")
                return false;
            char[] a = ca.ToCharArray();
            char[] b = cb.ToCharArray();
            int la = ca.Length, lb = cb.Length, lm = la < lb ? la : lb, ia = 0, ib = 0, lsa, lsb;
            while (ia < la && ib < lb)
            {
                if (pdnum(a[ia]) && pdnum(b[ib]))
                {
                    lsa = lsb = 0;
                    while (ia < la && pdnum(a[ia]))
                    {
                        lsa = lsa*10 + a[ia] - '0';
                        ++ia;
                    }
                    while (ib < lb && pdnum(b[ib]))
                    {
                        lsb = lsb*10 + b[ib] - '0';
                        ++ib;
                    }
                    if (lsa != lsb)
                        return lsa < lsb;
                }
                else
                {
                    if (a[ia] >= 'a' && a[ia] <= 'z')
                        a[ia] -= ' ';
                    if (b[ib] >= 'a' && b[ib] <= 'z')
                        b[ib] -= ' ';
                    if (a[ia] != b[ib])
                        return a[ia] < b[ib];
                    ++ia;
                    ++ib;
                }
            }
            return false;
        }


        private int l, nowx;
        private char[] croldpath;
        private string crpaths = "";

        private void loadin(CrumbBarItem parent)
        {
            int i;
            //MessageBoxEx.Show(croldpath.ToString() + '\n' + crpaths + '\n' + l+'\n'+nowx);
            //ToastNotification.Show(this, croldpath.ToString() + '\n' + crpaths + '\n' + l + '\n' + nowx, 5000);
            //MessageBoxEx.Show("Test1");
            // Load folders are selection changes...
            //if (parent == null || parent.SubItems.Count > 0){
            //    MessageBoxEx.Show("out"); return;}
            DirectoryInfo dirInfo;
            if (parent.Tag is DriveInfo)
            {
                DriveInfo driveInfo = (DriveInfo) parent.Tag;
                dirInfo = driveInfo.RootDirectory;
            }
            else if (parent.Tag is DirectoryInfo)
            {
                dirInfo = (DirectoryInfo) parent.Tag;
            }
            else
            {
                return;
            }
            parent.SubItems.Clear();
            parent.FontBold = true;
            DirectoryInfo[] subDirectories = dirInfo.GetDirectories();
            string lsfilename;
            if (nowx > 3 && nowx < l)
                crpaths += '\\';
            for (i = nowx; i < l; ++i)
            {
                if (croldpath[i] == '\\')
                    break;
                crpaths += croldpath[i];
            }
            nowx = i + 1;
            lsfilename = Path.GetFileName(crpaths);
            parent.ShowSubItems = true;
            foreach (DirectoryInfo directoryInfo in subDirectories)
            {
                CrumbBarItem node = new CrumbBarItem();
                node.Tag = directoryInfo;
                node.Text = directoryInfo.Name;
                node.Image = Properties.Resources.folderp;
                parent.SubItems.Add(node);
                if (node.Text == lsfilename)
                {
                    if (nowx >= l)
                    {
                        Gib.nowcrst = 1;
                        DirectoryInfo[] nodesubdirs = directoryInfo.GetDirectories();
                        foreach (DirectoryInfo nodesubdirinfo in nodesubdirs)
                        {
                            CrumbBarItem subnode = new CrumbBarItem();
                            subnode.Tag = nodesubdirinfo;
                            subnode.Text = nodesubdirinfo.Name;
                            subnode.Image = Properties.Resources.folderp;
                            node.SubItems.Add(subnode);
                        }
                        fpcrumb.SelectedItem = node;
                    }
                    loadin(node);
                }
            }
            if (l == 3 && parent.Text.Length == 3)
            {
                Gib.nowcrst = 1;
                fpcrumb.SelectedItem = parent;
            }
        }

        private void putinfilev()
        {
            if (Gib.nowtab == 1) filev1.Items.Clear();
            else if (Gib.nowtab == 2) filev2.Items.Clear();
            else filev3.Items.Clear();

            if (Gib.nowtab == 1) imageList1.Images.Clear();
            else if (Gib.nowtab == 2) imageList2.Images.Clear();
            else imageList3.Images.Clear();
            int i;
            if (Gib.nowtab == 1)
            {
                tab1.Text = tablsname;
                SHFILEINFO shfi = new SHFILEINFO();
                for (i = 1; i <= Gib.fsum[Gib.nowtab]; ++i)
                {
                    if (Gib.cmode[Gib.nowtab, i] == 2)
                    {
                        if (seevery.Checked)
                        {
                            try
                            {
                                if (Directory.GetDirectories(Gib.cpath[Gib.nowtab, i]).Length > 0 ||
                                    Directory.GetFiles(Gib.cpath[Gib.nowtab, i]).Length > 0)
                                    imageList1.Images.Add(Properties.Resources.folder);

                                else
                                    imageList1.Images.Add(Properties.Resources.folderemp);
                            }
                            catch
                            {
                                imageList1.Images.Add(Properties.Resources.folderemp);
                            }
                        }
                        else
                            imageList1.Images.Add(Properties.Resources.folder);
                    }
                    else
                    {
                        if (Gib.clast[Gib.nowtab, i].ToLower() == ".txt" || Gib.clast[Gib.nowtab, i].ToLower() == ".lrc")
                            imageList1.Images.Add(Properties.Resources.text);
                        else if (Gib.clast[Gib.nowtab, i].ToLower() == ".mp3")
                            imageList1.Images.Add(Properties.Resources.MP3);
                        else if (Gib.clast[Gib.nowtab, i].ToLower() == ".rtf")
                            imageList1.Images.Add(Properties.Resources.rtf);
                        else if (Gib.clast[Gib.nowtab, i].ToLower() == ".cfvnote")
                            imageList1.Images.Add(Properties.Resources.cfvnote);
                        else if (Gib.clast[Gib.nowtab, i].ToLower() == ".png" || Gib.clast[Gib.nowtab, i].ToLower() == ".bmp" ||
                                 Gib.clast[Gib.nowtab, i].ToLower() == ".jpg")
                            imageList1.Images.Add(Properties.Resources.png);
                        else
                        {
                            SHGetFileInfo(Gib.cpath[Gib.nowtab, i], 0x80, ref shfi,
                                (uint) Marshal.SizeOf(shfi), (0x100 | 0x400));
                            //获取文件的图标及类型
                            try
                            {
                                imageList1.Images.Add(Gib.cname[Gib.nowtab, i], (Icon) Icon.FromHandle(shfi.hIcon).Clone());
                            }
                            catch
                            {
                                imageList1.Images.Add(Properties.Resources.error);
                            }
                        }
                        //MessageBoxEx.Show(i.ToString() + '\n' + Gib.cpath[Gib.nowtab, i] + '\n' + Gib.fsum[Gib.nowtab]);
                        //filev.Items.Add(Gib.cpath[Gib.nowtab, i], _iconListManager.AddFileIcon(Gib.cpath[Gib.nowtab, i],Gib.cname[Gib.nowtab, i]));
                    }
                    filev1.Items.Add(Gib.cname[Gib.nowtab, i], i - 1);
                    nowprog.Value = i;
                }
                DestroyIcon(shfi.hIcon); //销毁图标
            }
            else if (Gib.nowtab == 2)
            {
                tab2.Text = tablsname;
                SHFILEINFO shfi = new SHFILEINFO();
                for (i = 1; i <= Gib.fsum[Gib.nowtab]; ++i)
                {
                    if (Gib.cmode[Gib.nowtab, i] == 2)
                    {
                        if (seevery.Checked)
                        {
                            try
                            {
                                if (Directory.GetDirectories(Gib.cpath[Gib.nowtab, i]).Length > 0 ||
                                    Directory.GetFiles(Gib.cpath[Gib.nowtab, i]).Length > 0)
                                    imageList2.Images.Add(Properties.Resources.folder);

                                else
                                    imageList2.Images.Add(Properties.Resources.folderemp);
                            }
                            catch
                            {
                                imageList2.Images.Add(Properties.Resources.folderemp);
                            }
                        }
                        else
                            imageList2.Images.Add(Properties.Resources.folder);
                    }
                    else
                    {
                        if (Gib.clast[Gib.nowtab, i].ToLower() == ".txt" || Gib.clast[Gib.nowtab, i].ToLower() == ".lrc")
                            imageList2.Images.Add(Properties.Resources.text);
                        else if (Gib.clast[Gib.nowtab, i].ToLower() == ".mp3")
                            imageList2.Images.Add(Properties.Resources.MP3);
                        else if (Gib.clast[Gib.nowtab, i].ToLower() == ".rtf")
                            imageList2.Images.Add(Properties.Resources.rtf);
                        else if (Gib.clast[Gib.nowtab, i].ToLower() == ".cfvnote")
                            imageList2.Images.Add(Properties.Resources.cfvnote);
                        else if (Gib.clast[Gib.nowtab, i].ToLower() == ".png" || Gib.clast[Gib.nowtab, i].ToLower() == ".bmp" ||
                                 Gib.clast[Gib.nowtab, i].ToLower() == ".jpg")
                            imageList2.Images.Add(Properties.Resources.png);
                        else
                        {
                            SHGetFileInfo(Gib.cpath[Gib.nowtab, i], 0x80, ref shfi,
                                (uint) Marshal.SizeOf(shfi), (0x100 | 0x400));
                            //获取文件的图标及类型
                            try
                            {
                                imageList2.Images.Add(Gib.cname[Gib.nowtab, i], (Icon) Icon.FromHandle(shfi.hIcon).Clone());
                            }
                            catch
                            {
                                imageList2.Images.Add(Properties.Resources.error);
                            }
                        }
                        //MessageBoxEx.Show(i.ToString() + '\n' + Gib.cpath[Gib.nowtab, i] + '\n' + Gib.fsum[Gib.nowtab]);
                        //filev.Items.Add(Gib.cpath[Gib.nowtab, i], _iconListManager.AddFileIcon(Gib.cpath[Gib.nowtab, i],Gib.cname[Gib.nowtab, i]));
                    }
                    filev2.Items.Add(Gib.cname[Gib.nowtab, i], i - 1);
                    nowprog.Value = i;
                }
                DestroyIcon(shfi.hIcon); //销毁图标
            }
            else
            {
                tab3.Text = tablsname;
                SHFILEINFO shfi = new SHFILEINFO();
                for (i = 1; i <= Gib.fsum[Gib.nowtab]; ++i)
                {
                    if (Gib.cmode[Gib.nowtab, i] == 2)
                    {
                        if (seevery.Checked)
                        {
                            try
                            {
                                if (Directory.GetDirectories(Gib.cpath[Gib.nowtab, i]).Length > 0 ||
                                    Directory.GetFiles(Gib.cpath[Gib.nowtab, i]).Length > 0)
                                    imageList3.Images.Add(Properties.Resources.folder);

                                else
                                    imageList3.Images.Add(Properties.Resources.folderemp);
                            }
                            catch
                            {
                                imageList3.Images.Add(Properties.Resources.folderemp);
                            }
                        }
                        else
                            imageList3.Images.Add(Properties.Resources.folder);
                    }
                    else
                    {
                        if (Gib.clast[Gib.nowtab, i].ToLower() == ".txt" || Gib.clast[Gib.nowtab, i].ToLower() == ".lrc")
                            imageList3.Images.Add(Properties.Resources.text);
                        else if (Gib.clast[Gib.nowtab, i].ToLower() == ".mp3")
                            imageList3.Images.Add(Properties.Resources.MP3);
                        else if (Gib.clast[Gib.nowtab, i].ToLower() == ".rtf")
                            imageList3.Images.Add(Properties.Resources.rtf);
                        else if (Gib.clast[Gib.nowtab, i].ToLower() == ".cfvnote")
                            imageList3.Images.Add(Properties.Resources.cfvnote);
                        else if (Gib.clast[Gib.nowtab, i].ToLower() == ".png" || Gib.clast[Gib.nowtab, i].ToLower() == ".bmp" ||
                                 Gib.clast[Gib.nowtab, i].ToLower() == ".jpg")
                            imageList3.Images.Add(Properties.Resources.png);
                        else
                        {
                            SHGetFileInfo(Gib.cpath[Gib.nowtab, i], 0x80, ref shfi,
                                (uint) Marshal.SizeOf(shfi), (0x100 | 0x400));
                            //获取文件的图标及类型
                            try
                            {
                                imageList3.Images.Add(Gib.cname[Gib.nowtab, i], (Icon) Icon.FromHandle(shfi.hIcon).Clone());
                            }
                            catch
                            {
                                imageList3.Images.Add(Properties.Resources.error);
                            }
                        }
                        //MessageBoxEx.Show(i.ToString() + '\n' + Gib.cpath[Gib.nowtab, i] + '\n' + Gib.fsum[Gib.nowtab]);
                        //filev.Items.Add(Gib.cpath[Gib.nowtab, i], _iconListManager.AddFileIcon(Gib.cpath[Gib.nowtab, i],Gib.cname[Gib.nowtab, i]));
                    }
                    filev3.Items.Add(Gib.cname[Gib.nowtab, i], i - 1);
                    nowprog.Value = i;
                }
                DestroyIcon(shfi.hIcon); //销毁图标
            }

        }

        private int la, lb;
        private bool flag;
        bool find(string a, string b)
        {
            la = a.Length;
            lb = b.Length;
            if (la < lb)
                return false;
            int j;
            for (int i = 0; i < la - lb + 1; ++i)
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

        private void putinfilevwithsearch()
        {
            if (Gib.nowtab == 1) filev1.Items.Clear();
            else if (Gib.nowtab == 2) filev2.Items.Clear();
            else filev3.Items.Clear();

            if (Gib.nowtab == 1) imageList1.Images.Clear();
            else if (Gib.nowtab == 2) imageList2.Images.Clear();
            else imageList3.Images.Clear();

            int i, js = 0;
            if (Gib.nowtab == 1)
            {
                tab1.Text = tablsname;
                SHFILEINFO shfi = new SHFILEINFO();
                for (i = 1; i <= Gib.fsum[Gib.nowtab]; ++i)
                    if (find(Gib.cname[Gib.nowtab, i], filevname.Text))
                    {
                        if (Gib.cmode[Gib.nowtab, i] == 2)
                        {
                            if (seevery.Checked)
                            {
                                try
                                {
                                    if (Directory.GetDirectories(Gib.cpath[Gib.nowtab, i]).Length > 0 ||
                                        Directory.GetFiles(Gib.cpath[Gib.nowtab, i]).Length > 0)
                                        imageList1.Images.Add(Properties.Resources.folder);

                                    else
                                        imageList1.Images.Add(Properties.Resources.folderemp);
                                }
                                catch
                                {
                                    imageList1.Images.Add(Properties.Resources.folderemp);
                                }
                            }
                            else
                                imageList1.Images.Add(Properties.Resources.folder);
                        }
                        else
                        {
                            if (Gib.clast[Gib.nowtab, i].ToLower() == ".txt" ||
                                Gib.clast[Gib.nowtab, i].ToLower() == ".lrc")
                                imageList1.Images.Add(Properties.Resources.text);
                            else if (Gib.clast[Gib.nowtab, i].ToLower() == ".mp3")
                                imageList1.Images.Add(Properties.Resources.MP3);
                        else if (Gib.clast[Gib.nowtab, i].ToLower() == ".rtf")
                                imageList1.Images.Add(Properties.Resources.rtf);
                            else if (Gib.clast[Gib.nowtab, i].ToLower() == ".cfvnote")
                                imageList1.Images.Add(Properties.Resources.cfvnote);
                            else if (Gib.clast[Gib.nowtab, i].ToLower() == ".png" ||
                                     Gib.clast[Gib.nowtab, i].ToLower() == ".bmp" ||
                                     Gib.clast[Gib.nowtab, i].ToLower() == ".jpg")
                                imageList1.Images.Add(Properties.Resources.png);
                            else
                            {
                                SHGetFileInfo(Gib.cpath[Gib.nowtab, i], 0x80, ref shfi,
                                    (uint) Marshal.SizeOf(shfi), (0x100 | 0x400));
                                //获取文件的图标及类型
                                try
                                {
                                    imageList1.Images.Add(Gib.cname[Gib.nowtab, i],
                                        (Icon) Icon.FromHandle(shfi.hIcon).Clone());
                                }
                                catch
                                {
                                    imageList1.Images.Add(Properties.Resources.error);
                                }
                            }
                            //MessageBoxEx.Show(i.ToString() + '\n' + Gib.cpath[Gib.nowtab, i] + '\n' + Gib.fsum[Gib.nowtab]);
                            //filev.Items.Add(Gib.cpath[Gib.nowtab, i], _iconListManager.AddFileIcon(Gib.cpath[Gib.nowtab, i],Gib.cname[Gib.nowtab, i]));
                        }
                        filev1.Items.Add(Gib.cname[Gib.nowtab, i], js++);
                        nowprog.Value = i;
                    }
                DestroyIcon(shfi.hIcon); //销毁图标
            }
            else if (Gib.nowtab == 2)
            {
                tab2.Text = tablsname;
                SHFILEINFO shfi = new SHFILEINFO();
                for (i = 1; i <= Gib.fsum[Gib.nowtab]; ++i)
                    if (find(Gib.cname[Gib.nowtab, i], filevname.Text))
                    {
                        if (Gib.cmode[Gib.nowtab, i] == 2)
                        {
                            if (seevery.Checked)
                            {
                                try
                                {
                                    if (Directory.GetDirectories(Gib.cpath[Gib.nowtab, i]).Length > 0 ||
                                        Directory.GetFiles(Gib.cpath[Gib.nowtab, i]).Length > 0)
                                        imageList2.Images.Add(Properties.Resources.folder);

                                    else
                                        imageList2.Images.Add(Properties.Resources.folderemp);
                                }
                                catch
                                {
                                    imageList2.Images.Add(Properties.Resources.folderemp);
                                }
                            }
                            else
                                imageList2.Images.Add(Properties.Resources.folder);
                        }
                        else
                        {
                            if (Gib.clast[Gib.nowtab, i].ToLower() == ".txt" ||
                                Gib.clast[Gib.nowtab, i].ToLower() == ".lrc")
                                imageList2.Images.Add(Properties.Resources.text);
                            else if (Gib.clast[Gib.nowtab, i].ToLower() == ".mp3")
                                imageList2.Images.Add(Properties.Resources.MP3);
                            else if (Gib.clast[Gib.nowtab, i].ToLower() == ".rtf")
                                imageList2.Images.Add(Properties.Resources.rtf);
                            else if (Gib.clast[Gib.nowtab, i].ToLower() == ".cfvnote")
                                imageList2.Images.Add(Properties.Resources.cfvnote);
                            else if (Gib.clast[Gib.nowtab, i].ToLower() == ".png" ||
                                     Gib.clast[Gib.nowtab, i].ToLower() == ".bmp" ||
                                     Gib.clast[Gib.nowtab, i].ToLower() == ".jpg")
                                imageList2.Images.Add(Properties.Resources.png);
                            else
                            {
                                SHGetFileInfo(Gib.cpath[Gib.nowtab, i], 0x80, ref shfi,
                                    (uint) Marshal.SizeOf(shfi), (0x100 | 0x400));
                                //获取文件的图标及类型
                                try
                                {
                                    imageList2.Images.Add(Gib.cname[Gib.nowtab, i],
                                        (Icon) Icon.FromHandle(shfi.hIcon).Clone());
                                }
                                catch
                                {
                                    imageList2.Images.Add(Properties.Resources.error);
                                }
                            }
                            //MessageBoxEx.Show(i.ToString() + '\n' + Gib.cpath[Gib.nowtab, i] + '\n' + Gib.fsum[Gib.nowtab]);
                            //filev.Items.Add(Gib.cpath[Gib.nowtab, i], _iconListManager.AddFileIcon(Gib.cpath[Gib.nowtab, i],Gib.cname[Gib.nowtab, i]));
                        }
                        filev2.Items.Add(Gib.cname[Gib.nowtab, i], js++);
                        nowprog.Value = i;
                    }
                DestroyIcon(shfi.hIcon); //销毁图标
            }
            else
            {
                tab3.Text = tablsname;
                SHFILEINFO shfi = new SHFILEINFO();
                for (i = 1; i <= Gib.fsum[Gib.nowtab]; ++i)
                    if (find(Gib.cname[Gib.nowtab, i], filevname.Text))
                    {
                        if (Gib.cmode[Gib.nowtab, i] == 2)
                        {
                            if (seevery.Checked)
                            {
                                try
                                {
                                    if (Directory.GetDirectories(Gib.cpath[Gib.nowtab, i]).Length > 0 ||
                                        Directory.GetFiles(Gib.cpath[Gib.nowtab, i]).Length > 0)
                                        imageList3.Images.Add(Properties.Resources.folder);

                                    else
                                        imageList3.Images.Add(Properties.Resources.folderemp);
                                }
                                catch
                                {
                                    imageList3.Images.Add(Properties.Resources.folderemp);
                                }
                            }
                            else
                                imageList3.Images.Add(Properties.Resources.folder);
                        }
                        else
                        {
                            if (Gib.clast[Gib.nowtab, i].ToLower() == ".txt" ||
                                Gib.clast[Gib.nowtab, i].ToLower() == ".lrc")
                                imageList3.Images.Add(Properties.Resources.text);
                            else if (Gib.clast[Gib.nowtab, i].ToLower() == ".mp3")
                                imageList3.Images.Add(Properties.Resources.MP3);
                            else if (Gib.clast[Gib.nowtab, i].ToLower() == ".rtf")
                                imageList3.Images.Add(Properties.Resources.rtf);
                            else if (Gib.clast[Gib.nowtab, i].ToLower() == ".cfvnote")
                                imageList3.Images.Add(Properties.Resources.cfvnote);
                            else if (Gib.clast[Gib.nowtab, i].ToLower() == ".png" ||
                                     Gib.clast[Gib.nowtab, i].ToLower() == ".bmp" ||
                                     Gib.clast[Gib.nowtab, i].ToLower() == ".jpg")
                                imageList3.Images.Add(Properties.Resources.png);
                            else
                            {
                                SHGetFileInfo(Gib.cpath[Gib.nowtab, i], 0x80, ref shfi,
                                    (uint) Marshal.SizeOf(shfi), (0x100 | 0x400));
                                //获取文件的图标及类型
                                try
                                {
                                    imageList3.Images.Add(Gib.cname[Gib.nowtab, i],
                                        (Icon) Icon.FromHandle(shfi.hIcon).Clone());
                                }
                                catch
                                {
                                    imageList3.Images.Add(Properties.Resources.error);
                                }
                            }
                            //MessageBoxEx.Show(i.ToString() + '\n' + Gib.cpath[Gib.nowtab, i] + '\n' + Gib.fsum[Gib.nowtab]);
                            //filev.Items.Add(Gib.cpath[Gib.nowtab, i], _iconListManager.AddFileIcon(Gib.cpath[Gib.nowtab, i],Gib.cname[Gib.nowtab, i]));
                        }
                        filev3.Items.Add(Gib.cname[Gib.nowtab, i], js++);
                        nowprog.Value = i;
                    }
                DestroyIcon(shfi.hIcon); //销毁图标
            }

        }

        void refcrb(string repath)
        {

            l = repath.Length;
            croldpath = repath.ToCharArray();

            crpaths = croldpath[0].ToString() + croldpath[1] + croldpath[2];

            CrumbBarItem myComputer = new CrumbBarItem();
            myComputer.Text = "";
            myComputer.Image = Properties.Resources.computer;
            fpcrumb.Items.Add(myComputer);
            // Load disks, we will lazy load folders are disk are selected
            nowx = 3;

            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo driveInfo in drives)
            {
                if (driveInfo.DriveType != DriveType.Fixed) continue;
                CrumbBarItem node = new CrumbBarItem();
                node.Tag = driveInfo;
                node.Text = driveInfo.Name;
                node.Image = Properties.Resources.hdd;
                myComputer.SubItems.Add(node);
                if (node.Text == Path.GetPathRoot(repath))
                    loadin(node);
            }
            // Finally select My Computer
            Gib.nowcrst = 0;
        }

        private void qk(int[] a, int x, int y)
        {
            int l = x, r = y, k = a[l], t;
            if (l >= r) return;
            while (l < r)
            {
                while (l < r && a[r] >= k)
                    r--;
                t = a[l];
                a[l] = a[r];
                a[r] = t;
                while (l < r && a[l] <= k)
                    l++;
                t = a[l];
                a[l] = a[r];
                a[r] = t;
            }
            qk(a, x, l - 1);
            qk(a, l + 1, y);
        }

        public void reffile(string repath)
        {
            if (Directory.Exists(repath) == false)
            {
                if (repath != "")
                    MessageBoxEx.Show("路径不存在！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            origfile.Visible = (Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(repath))) ==
                                "C:\\CW File Viewer");
                

            //ToastNotification.Show(this, repath, 5000);
            int i, j, k, progs;
            //Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab] + 1] = "";
            filepath.Text = repath;

            if (Gib.nowp[Gib.nowtab] == 1)
                back.Enabled = false;
            else
                back.Enabled = true;

            if (Gib.nowp[Gib.nowtab] == Gib.maxn[Gib.nowtab])
                next.Enabled = false;
            else
                next.Enabled = true;
            //crpathc[3] = '\0';

            refcrb(repath);

            //nowstate.Text = "正在载入...";
            /*
            Gib.cname = new string[4, 100000];
            Gib.cpath = new string[4, 100000];
            Gib.clast = new string[4, 100000];
            Gib.cmode = new int[4, 100000]; //1:file  2:folder
             */
            //FrmMain frm = (FrmMain)this.Owner;
            if (Gib.nowtab == 1) filev1.Items.Clear();
            else if (Gib.nowtab == 2) filev2.Items.Clear();
            else filev3.Items.Clear();
            Gib.fsum[Gib.nowtab] = 0;
            DirectoryInfo dinfo = new DirectoryInfo(repath);
            FileSystemInfo[] fsinfos = dinfo.GetFileSystemInfos();
            progs = fsinfos.Length;

            if (progs == 0)
                progs = 1;
            nowprog.Maximum = progs;

            foreach (FileSystemInfo fsinfo in fsinfos)
            {
                if (fsinfo is DirectoryInfo)
                {
                    DirectoryInfo dirinfo = new DirectoryInfo(fsinfo.FullName);
                    ++Gib.fsum[Gib.nowtab];
                    Gib.cname[Gib.nowtab, Gib.fsum[Gib.nowtab]] = dirinfo.Name;
                    Gib.cpath[Gib.nowtab, Gib.fsum[Gib.nowtab]] = repath;
                    if (Gib.cpath[Gib.nowtab, Gib.fsum[Gib.nowtab]].Length > 3)
                        Gib.cpath[Gib.nowtab, Gib.fsum[Gib.nowtab]] = Gib.cpath[Gib.nowtab, Gib.fsum[Gib.nowtab]] + '\\';
                    Gib.clast[Gib.nowtab, Gib.fsum[Gib.nowtab]] = "";
                    Gib.cpath[Gib.nowtab, Gib.fsum[Gib.nowtab]] = Gib.cpath[Gib.nowtab, Gib.fsum[Gib.nowtab]] +
                                                                  Gib.cname[Gib.nowtab, Gib.fsum[Gib.nowtab]];
                    Gib.cmode[Gib.nowtab, Gib.fsum[Gib.nowtab]] = 2;
                }
                else if (onlyfolder.Checked == false && (ShowTXT.Checked || fsinfo.Extension != ".txt") &&
                         (ShowNote.Checked || fsinfo.Extension != ".cfvnote"))
                {
                    ++Gib.fsum[Gib.nowtab];
                    Gib.cname[Gib.nowtab, Gib.fsum[Gib.nowtab]] = fsinfo.Name;
                    Gib.cpath[Gib.nowtab, Gib.fsum[Gib.nowtab]] = repath;
                    if (Gib.cpath[Gib.nowtab, Gib.fsum[Gib.nowtab]].Length > 3)
                        Gib.cpath[Gib.nowtab, Gib.fsum[Gib.nowtab]] = Gib.cpath[Gib.nowtab, Gib.fsum[Gib.nowtab]] +
                                                                      '\\';
                    Gib.cpath[Gib.nowtab, Gib.fsum[Gib.nowtab]] = Gib.cpath[Gib.nowtab, Gib.fsum[Gib.nowtab]] +
                                                                  Gib.cname[Gib.nowtab, Gib.fsum[Gib.nowtab]];
                    Gib.clast[Gib.nowtab, Gib.fsum[Gib.nowtab]] =
                        Path.GetExtension(Gib.cpath[Gib.nowtab, Gib.fsum[Gib.nowtab]]);
                    Gib.cmode[Gib.nowtab, Gib.fsum[Gib.nowtab]] = 1;

                }
                nowprog.Value = Gib.fsum[Gib.nowtab];
            }
            string lins;
            int ils;
            if (Gib.nowtab == 1) filev1.Columns[0].Text = "共" + Gib.fsum[Gib.nowtab].ToString() + "个对象";
            else if (Gib.nowtab == 2) filev2.Columns[0].Text = "共" + Gib.fsum[Gib.nowtab].ToString() + "个对象";
            else filev3.Columns[0].Text = "共" + Gib.fsum[Gib.nowtab].ToString() + "个对象";
            //nowstate.Text = "正在排序...";
            //MessageBoxEx.Show("Test");
            if (Gib.smode == 1)
            {
                if (goodsort.Checked)
                {
                    Gib.cname[Gib.nowtab, 0] = "";
                    for (i = 1; i < Gib.fsum[Gib.nowtab]; ++i)
                    {
                        k = i - 1;
                        for (j = i; j <= Gib.fsum[Gib.nowtab]; ++j)
                            if (goodcmp(Gib.cname[Gib.nowtab, j], Gib.cname[Gib.nowtab, k]))
                                k = j;
                        if (k != i - 1)
                        {
                            lins = Gib.cname[Gib.nowtab, i - 1];
                            Gib.cname[Gib.nowtab, i - 1] = Gib.cname[Gib.nowtab, k];
                            Gib.cname[Gib.nowtab, k] = lins;

                            lins = Gib.cpath[Gib.nowtab, i - 1];
                            Gib.cpath[Gib.nowtab, i - 1] = Gib.cpath[Gib.nowtab, k];
                            Gib.cpath[Gib.nowtab, k] = lins;

                            lins = Gib.clast[Gib.nowtab, i - 1];
                            Gib.clast[Gib.nowtab, i - 1] = Gib.clast[Gib.nowtab, k];
                            Gib.clast[Gib.nowtab, k] = lins;

                            ils = Gib.cmode[Gib.nowtab, i - 1];
                            Gib.cmode[Gib.nowtab, i - 1] = Gib.cmode[Gib.nowtab, k];
                            Gib.cmode[Gib.nowtab, k] = ils;
                        }
                    }
                    if (Gib.fsum[Gib.nowtab] > 0 &&
                        goodcmp(Gib.cname[Gib.nowtab, Gib.fsum[Gib.nowtab]],
                            Gib.cname[Gib.nowtab, Gib.fsum[Gib.nowtab] - 1]))
                    {
                        lins = Gib.cname[Gib.nowtab, Gib.fsum[Gib.nowtab] - 1];
                        Gib.cname[Gib.nowtab, Gib.fsum[Gib.nowtab] - 1] = Gib.cname[Gib.nowtab, Gib.fsum[Gib.nowtab]];
                        Gib.cname[Gib.nowtab, Gib.fsum[Gib.nowtab]] = lins;

                        lins = Gib.cpath[Gib.nowtab, Gib.fsum[Gib.nowtab] - 1];
                        Gib.cpath[Gib.nowtab, Gib.fsum[Gib.nowtab] - 1] = Gib.cpath[Gib.nowtab, Gib.fsum[Gib.nowtab]];
                        Gib.cpath[Gib.nowtab, Gib.fsum[Gib.nowtab]] = lins;

                        lins = Gib.clast[Gib.nowtab, Gib.fsum[Gib.nowtab] - 1];
                        Gib.clast[Gib.nowtab, Gib.fsum[Gib.nowtab] - 1] = Gib.clast[Gib.nowtab, Gib.fsum[Gib.nowtab]];
                        Gib.clast[Gib.nowtab, Gib.fsum[Gib.nowtab]] = lins;

                        ils = Gib.cmode[Gib.nowtab, Gib.fsum[Gib.nowtab] - 1];
                        Gib.cmode[Gib.nowtab, Gib.fsum[Gib.nowtab] - 1] = Gib.cmode[Gib.nowtab, Gib.fsum[Gib.nowtab]];
                        Gib.cmode[Gib.nowtab, Gib.fsum[Gib.nowtab]] = ils;
                    }
                }
                else
                {
                    for (i = 1; i < Gib.fsum[Gib.nowtab]; ++i)
                    {
                        k = i - 1;
                        for (j = i; j <= Gib.fsum[Gib.nowtab]; ++j)
                            if (String.Compare(Gib.cname[Gib.nowtab, j], Gib.cname[Gib.nowtab, k]) < 0)
                                k = j;
                        if (k != i - 1)
                        {
                            lins = Gib.cname[Gib.nowtab, i - 1];
                            Gib.cname[Gib.nowtab, i - 1] = Gib.cname[Gib.nowtab, k];
                            Gib.cname[Gib.nowtab, k] = lins;

                            lins = Gib.cpath[Gib.nowtab, i - 1];
                            Gib.cpath[Gib.nowtab, i - 1] = Gib.cpath[Gib.nowtab, k];
                            Gib.cpath[Gib.nowtab, k] = lins;

                            lins = Gib.clast[Gib.nowtab, i - 1];
                            Gib.clast[Gib.nowtab, i - 1] = Gib.clast[Gib.nowtab, k];
                            Gib.clast[Gib.nowtab, k] = lins;

                            ils = Gib.cmode[Gib.nowtab, i - 1];
                            Gib.cmode[Gib.nowtab, i - 1] = Gib.cmode[Gib.nowtab, k];
                            Gib.cmode[Gib.nowtab, k] = ils;
                        }
                    }
                }
            }
            else if (Gib.smode == 2)
            {
                for (i = 1; i < Gib.fsum[Gib.nowtab]; ++i)
                {
                    k = i - 1;
                    for (j = i; j <= Gib.fsum[Gib.nowtab]; ++j)
                        if (String.Compare(Gib.clast[Gib.nowtab, j], Gib.clast[Gib.nowtab, k]) < 0)
                            k = j;
                    if (k != i - 1)
                    {
                        lins = Gib.cname[Gib.nowtab, i - 1];
                        Gib.cname[Gib.nowtab, i - 1] = Gib.cname[Gib.nowtab, k];
                        Gib.cname[Gib.nowtab, k] = lins;

                        lins = Gib.cpath[Gib.nowtab, i - 1];
                        Gib.cpath[Gib.nowtab, i - 1] = Gib.cpath[Gib.nowtab, k];
                        Gib.cpath[Gib.nowtab, k] = lins;

                        lins = Gib.clast[Gib.nowtab, i - 1];
                        Gib.clast[Gib.nowtab, i - 1] = Gib.clast[Gib.nowtab, k];
                        Gib.clast[Gib.nowtab, k] = lins;

                        ils = Gib.cmode[Gib.nowtab, i - 1];
                        Gib.cmode[Gib.nowtab, i - 1] = Gib.cmode[Gib.nowtab, k];
                        Gib.cmode[Gib.nowtab, k] = ils;
                    }
                }
            }

            if (Gib.nowtab == 1) imageList1.Images.Clear();
            else if (Gib.nowtab == 2) imageList2.Images.Clear();
            else imageList3.Images.Clear();

            //nowstate.Text = "正在更新列表...";

            if (repath != "C:\\" && repath != "D:\\" && repath != "E:\\" && repath != "F:\\")
                tablsname = Path.GetFileName(repath);
            else
                tablsname = repath;

            putinfilev();

            //nowstate.Text = "完成";
            nowprog.Value = progs;

            try
            {
                if (Gib.lpos[Gib.nowtab, Gib.nowp[Gib.nowtab]] > 0 &&
                    Gib.lpos[Gib.nowtab, Gib.nowp[Gib.nowtab]] <= Gib.fsum[Gib.nowtab])
                {
                    /*
                    if (Gib.nowtab == 1) filev1.Items[Gib.lpos[Gib.nowtab, Gib.nowp[Gib.nowtab]]].EnsureVisible();
                    else if (Gib.nowtab == 2) filev2.Items[Gib.lpos[Gib.nowtab, Gib.nowp[Gib.nowtab]]].EnsureVisible();
                    else filev3.Items[Gib.lpos[Gib.nowtab, Gib.nowp[Gib.nowtab]]].EnsureVisible();
                     */
                    if (Gib.nowtab == 1) filev1.TopItem = filev1.Items[Gib.lpos[Gib.nowtab, Gib.nowp[Gib.nowtab]]];
                    else if (Gib.nowtab == 2) filev2.TopItem = filev2.Items[Gib.lpos[Gib.nowtab, Gib.nowp[Gib.nowtab]]];
                    else filev3.TopItem = filev3.Items[Gib.lpos[Gib.nowtab, Gib.nowp[Gib.nowtab]]];
                }
            }
            catch
            {
            }
        }

        bool isnum(char x)
        {
            if ( x >= '0' && x <= '9')
                return true;
            return false;
        }

        void highlightfile()
        {
            int i = 0, j, l = 0, sp = 0;
            bool bj = true;
            string tar = "";
            while (i <  filename.Text.Length - 4&& !isnum(filename.Text[i]))
                ++i;
            while (i < filename.Text.Length - 4 && isnum(filename.Text[i++])) { }
            while (i < filename.Text.Length - 4 && isnum(filename.Text[i]))
                ++i;
            while (i < filename.TextLength - 4)
            {
                tar += filename.Text[i++];
                ++l;
            }
            for (i = 0; i < lrcv.Text.Length; ++i)
            {
                bj = true;
                for (j = 0; j < l; ++j)
                    if (Gib.infile[i + j] != tar[j])
                    {
                        bj = false;
                        break;
                    }
                if (bj)
                {
                    sp = i;
                    break;
                }
            }
            if (bj && l > 0)
            {
                lrcv.Select(sp, l);
                lrcvfocuser.Enabled = true;
            }
        }

        string StrNextN(string str, int i, int n)
        {
            string temp = "";
            for (int j = i; j < i + n; ++j)
                temp += str[j];
            return temp;
        }

        /*
        void LoadTextFormat(string str, int bg)
        {
            string temp, pass;
            int i, begin;
            for (i = 0; i < str.Length; ++i)
            {
                if (str[i] == '<')
                    if (StrNextN(str, i, 8) == "<proper=")
                    {
                        i += 8;
                        temp = pass = "";
                        while (i < str.Length && str[i] != '>')
                            temp += str[i++];
                        begin = i;
                        while (i < str.Length)
                        {
                            pass += str[i];
                            if (str[i] == '<')
                                if (StrNextN(str, i, 9) == "</proper>")
                                    break;
                            ++i;
                        }
                        ToTextFormat(temp);
                        LoadTextFormat(pass, begin);
                    }
            }
        }
         */

        public void loadfile()
        {
            if (isleftkey)
            {
                Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab] + 1] = Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]];
                if (Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]].Length > 3)
                    Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab] + 1] = Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab] + 1] +
                                                                     '\\';
                Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab] + 1] = Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab] + 1] +
                                                                 Gib.fname;

                Gib.last = Path.GetExtension(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab] + 1]);

                if (Directory.Exists(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab] + 1]))
                {
                    ++Gib.nowp[Gib.nowtab];

                    Gib.maxn[Gib.nowtab] = Gib.maxn[Gib.nowtab] > Gib.nowp[Gib.nowtab]
                        ? Gib.maxn[Gib.nowtab]
                        : Gib.nowp[Gib.nowtab];

                    filepath.Text = Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]];

                    reffile(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]]);

                    File.WriteAllText("C:\\ProgramData\\CW Soft\\CW File Viewer\\Temp.txt", filepath.Text);
                }
                else
                {
                    //MessageBoxEx.Show(cfile, "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    Gib.hispath[++Gib.hissum] = Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab] + 1];
                    if (Gib.firsto == false)
                    {
                        if (Gib.settings[0] == 0)
                        {
                            if (Gib.infile != Gib.backup)
                                if (MessageBoxEx.Show("文件未保存，是否保存？", "提示", MessageBoxButtons.OKCancel,
                                    MessageBoxIcon.Question) ==
                                    DialogResult.OK)
                                {
                                    if (Path.GetExtension(Gib.txtpath).ToLower() == ".rtf")
                                        lrcv.SaveFile(Gib.txtpath, RichTextBoxStreamType.RichText);
                                    else if (Path.GetExtension(Gib.txtpath).ToLower() == ".lrc")
                                        File.WriteAllText(Gib.txtpath, Gib.infile);
                                    else if (Path.GetExtension(Gib.txtpath).ToLower() == ".txt")
                                        File.WriteAllText(Gib.txtpath, Gib.infile, Encoding.GetEncoding("GB2312"));
                                    else if (Path.GetExtension(Gib.txtpath).ToLower() != ".mp3")
                                        File.WriteAllText(Gib.txtpath, Gib.infile, Encoding.Default);
                                    Gib.backup = Gib.infile;
                                    txtstate.Text = "未修改";
                                }
                        }
                        else
                        {
                            if (File.Exists(Gib.txtpath))
                            {
                                if (Path.GetExtension(Gib.txtpath).ToLower() == ".rtf")
                                    lrcv.SaveFile(Gib.txtpath, RichTextBoxStreamType.RichText);
                                else if (Path.GetExtension(Gib.txtpath).ToLower() == ".lrc")
                                    File.WriteAllText(Gib.txtpath, Gib.infile);
                                else if (Path.GetExtension(Gib.txtpath).ToLower() == ".txt")
                                    File.WriteAllText(Gib.txtpath, Gib.infile, Encoding.GetEncoding("GB2312"));
                                else if (Path.GetExtension(Gib.txtpath).ToLower() != ".mp3")
                                    File.WriteAllText(Gib.txtpath, Gib.infile, Encoding.Default);

                                Gib.backup = Gib.infile;
                                txtstate.Text = "未修改";
                            }
                        }
                    }
                    else
                        Gib.firsto = false;
                    filename.Text = Gib.fname;
                    if (File.Exists(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab] + 1]))
                    {
                        if (Gib.last.ToLower() == ".rtf")
                        {
                            imgv.Visible = false;
                            Gib.txtpath = Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab] + 1];
                            lrcv.LoadFile(Gib.txtpath, RichTextBoxStreamType.RichText);
                            Gib.infile = lrcv.Text;
                            lrcv.ScrollToCaret();
                            Gib.backup = Gib.infile;
                            txtstate.Text = "未修改";
                            if (filehighlight.Checked)
                                highlightfile();
                        }
                        else if (Gib.last.ToLower() == ".txt" || Gib.last.ToLower() == ".cfvnote")
                        {
                            imgv.Visible = false;
                            Gib.txtpath = Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab] + 1];
                            Gib.infile = File.ReadAllText(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab] + 1],
                                Encoding.GetEncoding("GB2312"));
                            lrcv.Text = Gib.infile;
                            lrcv.ScrollToCaret();
                            Gib.backup = Gib.infile;
                            txtstate.Text = "未修改";
                            if (filehighlight.Checked)
                                highlightfile();
                        }
                        else if (Gib.last.ToLower() == ".lrc")
                        {
                            imgv.Visible = false;
                            Gib.txtpath = Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab] + 1];
                            Gib.infile = File.ReadAllText(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab] + 1]);
                            lrcv.Text = Gib.infile;
                            lrcv.ScrollToCaret();
                            Gib.backup = Gib.infile;
                            txtstate.Text = "未修改";
                            if (filehighlight.Checked)
                                highlightfile();
                        }
                        else if (Gib.last.ToLower() == ".mp3")
                        {
                            player.URL = Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab] + 1];
                            Gib.pstate = 1;
                            playbutton.Enabled = true;
                            player.Ctlcontrols.play();
                            playbutton.Image = Properties.Resources.state21;
                            playbutton.HoverImage = Properties.Resources.state22;
                            playbutton.PressedImage = Properties.Resources.state23;
                            if (looksametxt.Checked)
                            {
                                if (File.Exists(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]] + '\\' +
                                                Path.GetFileNameWithoutExtension(Gib.fname) + ".rtf"))
                                {
                                    Gib.txtpath = Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab] + 1] =
                                        Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]] + '\\' +
                                        Path.GetFileNameWithoutExtension(Gib.fname) + ".rtf";
                                    Gib.nfname = Path.GetFileName(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab] + 1]);
                                    Gib.last = ".rtf";
                                    Gib.infile =
                                        File.ReadAllText(
                                            Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]] + '\\' +
                                            Path.GetFileNameWithoutExtension(Gib.fname) + ".rtf",
                                            Encoding.GetEncoding("GB2312"));
                                    lrcv.LoadFile(Gib.txtpath, RichTextBoxStreamType.RichText);
                                    lrcv.ScrollToCaret();
                                    if (filehighlight.Checked)
                                        highlightfile();
                                    Gib.backup = Gib.infile;
                                    txtstate.Text = "未修改";
                                    filename.Text = Path.GetFileNameWithoutExtension(filename.Text) + ".rtf";
                                }
                                else if (File.Exists(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]] + '\\' +
                                                Path.GetFileNameWithoutExtension(Gib.fname) + ".txt"))
                                {
                                    Gib.txtpath = Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab] + 1] =
                                        Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]] + '\\' +
                                        Path.GetFileNameWithoutExtension(Gib.fname) + ".txt";
                                    Gib.nfname = Path.GetFileName(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab] + 1]);
                                    Gib.last = ".txt";
                                    Gib.infile =
                                        File.ReadAllText(
                                            Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]] + '\\' +
                                            Path.GetFileNameWithoutExtension(Gib.fname) + ".txt",
                                            Encoding.GetEncoding("GB2312"));
                                    lrcv.LoadFile(Gib.txtpath, RichTextBoxStreamType.PlainText);
                                    lrcv.ScrollToCaret();
                                    if (filehighlight.Checked)
                                        highlightfile();
                                    Gib.backup = Gib.infile;
                                    txtstate.Text = "未修改";
                                    filename.Text = Path.GetFileNameWithoutExtension(filename.Text) + ".txt";
                                }
                            }
                        }
                        else if (Gib.last == ".cst1" || Gib.last == ".cst2" || Gib.last == ".cst3" || Gib.last == ".his")
                        {
                            imgv.Visible = false;
                            Gib.rtff = Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab] + 1];
                            Gib.infile = File.ReadAllText(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab] + 1],
                                Encoding.Default);
                            lrcv.Text = Gib.infile;
                            Gib.backup = Gib.infile;
                            txtstate.Text = "未修改";
                        }
                        else if (Gib.last.ToLower() == ".png" || Gib.last.ToLower() == ".jpg" ||
                                 Gib.last.ToLower() == ".gif" || Gib.last.ToLower() == ".bmp")
                        {
                            imgv.Visible = true;
                            imgv.Load(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab] + 1]);
                        }
                        else if (openotherfile.Checked)
                            System.Diagnostics.Process.Start(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab] + 1]);
                    }
                }
            }
            //else
            //{
                Gib.rbfile = Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]];
                if (Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]].Length > 3)
                    Gib.rbfile = Gib.rbfile + '\\';
                Gib.rbfile = Gib.rbfile + Gib.fname;
            //}
        }

        #endregion

        #region Other Voids

        public void Updatetext()
        {
            lrcv.Text = Gib.infile;
        }

        private void delfd(string path, bool print)
        {
            if (File.Exists(path))
            {
                if (userogbin.Checked)
                {
                    string movepath;
                    ls = 2;
                    if (
                        File.Exists("C:\\ProgramData\\CW Soft\\CW File Viewer\\RecycleBin\\" +
                                    Path.GetFileName(path)) ||
                        Directory.Exists("C:\\ProgramData\\CW Soft\\CW File Viewer\\RecycleBin\\" +
                                         Path.GetFileName(path)))
                    {
                        while (
                            File.Exists("C:\\ProgramData\\CW Soft\\CW File Viewer\\RecycleBin\\" +
                                        Path.GetFileNameWithoutExtension(path) + " (" + ls.ToString() + ")" +
                                        Path.GetExtension(path)) ||
                            Directory.Exists("C:\\ProgramData\\CW Soft\\CW File Viewer\\RecycleBin\\" +
                                             Path.GetFileNameWithoutExtension(path) + " (" + ls.ToString() + ")" +
                                             Path.GetExtension(path)))
                            ++ls;
                        movepath = "C:\\ProgramData\\CW Soft\\CW File Viewer\\RecycleBin\\" +
                                   Path.GetFileNameWithoutExtension(path) + " (" + ls.ToString() + ")" +
                                   Path.GetExtension(path);

                    }
                    else
                        movepath = "C:\\ProgramData\\CW Soft\\CW File Viewer\\RecycleBin\\" + Path.GetFileName(path);
                    if (Path.GetPathRoot(path) != "C:\\")
                    {
                        pastfile(path, Path.GetDirectoryName(movepath), Path.GetFileName(movepath), 1, false);
                        File.Delete(path);
                    }
                    else
                    {
                        File.Move(path, movepath);
                    }
                }
                else
                    File.Delete(path);
                //if (print)
                //    ToastNotification.Show(this, "文件已删除", 2000);
            }
            else if (Directory.Exists(path))
            {
                if (userogbin.Checked)
                {
                    string movepath;
                    ls = 2;
                    if (
                        File.Exists("C:\\ProgramData\\CW Soft\\CW File Viewer\\RecycleBin\\" +
                                    Path.GetFileName(path)) ||
                        Directory.Exists("C:\\ProgramData\\CW Soft\\CW File Viewer\\RecycleBin\\" +
                                         Path.GetFileName(path)))
                    {
                        while (
                            File.Exists("C:\\ProgramData\\CW Soft\\CW File Viewer\\RecycleBin\\" +
                                        Path.GetFileNameWithoutExtension(path) + " (" + ls.ToString() + ")" +
                                        Path.GetExtension(path)) ||
                            Directory.Exists("C:\\ProgramData\\CW Soft\\CW File Viewer\\RecycleBin\\" +
                                             Path.GetFileNameWithoutExtension(path) + " (" + ls.ToString() + ")" +
                                             Path.GetExtension(path)))
                            ++ls;
                        movepath = "C:\\ProgramData\\CW Soft\\CW File Viewer\\RecycleBin\\" +
                                   Path.GetFileNameWithoutExtension(path) + " (" + ls.ToString() + ")" +
                                   Path.GetExtension(path);

                    }
                    else
                        movepath = "C:\\ProgramData\\CW Soft\\CW File Viewer\\RecycleBin\\" + Path.GetFileName(path);
                    if (Path.GetPathRoot(path) != "C:\\")
                    {
                        pastfile(path, Path.GetDirectoryName(movepath), Path.GetFileName(movepath), 2, false);
                        Directory.Delete(path, true);
                    }
                    else
                    {
                        Directory.Move(path, movepath);
                    }
                }
                else
                    Directory.Delete(path, true);
                //if (print)
                //    ToastNotification.Show(this, "文件夹已删除", 2000);
                reffile(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]]);
            }
            else
            {
                MessageBoxEx.Show("路径不存在！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Buttons Click

        private void add_Click(object sender, EventArgs e)
        {
            FrmAddWord frm = new FrmAddWord();
            frm.Show();
        }

        public void viewfile_Click(object sender, EventArgs e)
        {

            if (fbroser.ShowDialog() == DialogResult.OK)
            {
                fbroser.SelectedPath = fbroser.SelectedPath;
                Gib.fpos[Gib.nowtab, ++Gib.nowp[Gib.nowtab]] = fbroser.SelectedPath;
                Gib.maxn[Gib.nowtab] = Gib.maxn[Gib.nowtab] > Gib.nowp[Gib.nowtab]
                    ? Gib.maxn[Gib.nowtab]
                    : Gib.nowp[Gib.nowtab];
                filepath.Text = Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]];
                //实例化DirectoryInfo对象
                reffile(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]]);
            }
            /*
          folderbroser.SelectedPath = "C:\\360云盘\\Visual Studio 2012\\CW Web Browser\\CW Web Browser 1\\CW Web Browser 1\\CW Web Browser 1\\media\\bmp";
          Gib.fpos[Gib.nowtab,++Gib.nowp[Gib.nowtab]] = folderbroser.SelectedPath;
          Gib.maxn = Gib.maxn > Gib.nowp[Gib.nowtab] ? Gib.maxn : Gib.nowp[Gib.nowtab];
          sfpath.Text = Gib.fpos[Gib.nowtab,Gib.nowp[Gib.nowtab]];
          //实例化DirectoryInfo对象
          reffile(Gib.fpos[Gib.nowtab,Gib.nowp[Gib.nowtab]]);*/
        }

        void flback()
        {
            if (Gib.nowp[Gib.nowtab] > 1)
            {
                --Gib.nowp[Gib.nowtab];
                filepath.Text = Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]];
                reffile(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]]);
            }
            else
            {
                back.Enabled = false;
            }
        }

        void flnext()
        {
            if (Gib.nowp[Gib.nowtab] < Gib.maxn[Gib.nowtab])
            {
                ++Gib.nowp[Gib.nowtab];
                filepath.Text = Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]];
                reffile(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]]);
            }
            else
            {
                back.Enabled = false;
            }
        }


        public void back_Click(object sender, EventArgs e)
        {
            flback();
        }

        public void next_Click(object sender, EventArgs e)
        {
            flnext();
        }

        public void write_Click(object sender, EventArgs e)
        {
            if (File.Exists(filepath.Text + '\\' + filename.Text))
            {
                if (Path.GetExtension(Gib.txtpath).ToLower() == ".rtf")
                    lrcv.SaveFile(Gib.txtpath, RichTextBoxStreamType.RichText);
                else if (Path.GetExtension(Gib.txtpath).ToLower() == ".lrc")
                    File.WriteAllText(Gib.txtpath, Gib.infile);
                else if (Path.GetExtension(Gib.txtpath).ToLower() == ".txt")
                    File.WriteAllText(Gib.txtpath, Gib.infile, Encoding.GetEncoding("GB2312"));
                else if (Path.GetExtension(Gib.txtpath).ToLower() != ".mp3")
                    File.WriteAllText(Gib.txtpath, Gib.infile, Encoding.Default);

                Gib.backup = Gib.infile;
                txtstate.Text = "未修改";
            }
            else
                MessageBoxEx.Show("文件不存在！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        string Path_FileNote(string path)
        {
            return Path.GetDirectoryName(path) + '\\' + Path.GetFileNameWithoutExtension(path) + ".cfvnote";
        }

        public void rename_Click(object sender, EventArgs e)
        {
            if (Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab] + 1] != "")
            {
                File.Move(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab] + 1],
                    Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]] + '\\' + Gib.nfname);
                Gib.fname = Gib.nfname;
                int i;
                for (int j = 0; j < Gib.tsn; ++j)
                    for (i = 0; i < Gib.ts[Gib.nowsysi].ftagn; ++i)
                        if (Gib.ts[j].ftagpath[i] == Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab] + 1])
                        {
                            Gib.ts[j].ftagpath[i] = Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]] + '\\' + Gib.nfname;
                            break;
                        }
                Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab] + 1] = Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]] + '\\' +
                                                                 Gib.nfname;
                if (Path.GetExtension(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab] + 1]).ToLower() == ".txt" ||
                    Path.GetExtension(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab] + 1]).ToLower() == ".lrc" ||
                    Path.GetExtension(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab] + 1]).ToLower() == ".rtf")
                    Gib.txtpath = Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab] + 1];

                if (File.Exists(Path_FileNote(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab] + 1])))
                    File.Move(Path_FileNote(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab] + 1]),
                        Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]] + '\\' + Path.GetFileNameWithoutExtension(Gib.nfname) + ".cfvnote");
               
                reffile(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]]);
            }
            else
                MessageBoxEx.Show("未选择文件！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void del_Click(object sender, EventArgs e)
        {
            if (Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab] + 1] != "")
            {
                delfd(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab] + 1], true);
                Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab] + 1] = "";
                reffile(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]]);
            }
            else
                MessageBoxEx.Show("未选中文件！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void newfile_Click(object sender, EventArgs e)
        {
            //MessageBoxEx.Show("Test");
            if (File.Exists(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]] + '\\' + filename.Text) == true)
                MessageBoxEx.Show("文件已存在！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (filename.Text == "")
                MessageBoxEx.Show("文件名不得为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (Gib.nowp[Gib.nowtab] <= 0)
                MessageBoxEx.Show("未选择目录！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (Path.GetExtension(filename.Text) == "")
                    Directory.CreateDirectory(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]] + '\\' + filename.Text);
                else
                {
                    if (File.Exists(filepath.Text + '\\' + filename.Text) == false)
                    {
                        Gib.fname = filename.Text;
                        Gib.last = Path.GetExtension(Gib.fname);
                        if (Gib.last == ".lrc" || Gib.last == ".LRC")
                            File.WriteAllText(filepath.Text + '\\' + filename.Text, "");
                        else if (Gib.last == ".txt" || Gib.last == ".TXT")
                            File.WriteAllText(filepath.Text + '\\' + filename.Text, "", Encoding.GetEncoding("GB2312"));
                        loadfile();
                    }
                }
                reffile(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]]);
            }
        }

        public void cut_Click(object sender, EventArgs e)
        {
            if (Gib.nowp[Gib.nowtab] > 0)
            {
                Gib.crossfile1 = filepath.Text + '\\' + filename.Text;
                FrmCut fcut = new FrmCut();
                fcut.Show(this);
            }
            else
                MessageBoxEx.Show("未选择文件！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void refresh_Click(object sender, EventArgs e)
        {
            if (Gib.nowp[Gib.nowtab] > 0)
                reffile(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]]);
        }

        public void copy_Click(object sender, EventArgs e)
        {
            if (Gib.nowp[Gib.nowtab] > 0)
                copyfile(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab] + 1], true);
            else
                MessageBoxEx.Show("未选择文件！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //sfpath.Text = Gib.copypath;
        }

        public void past_Click(object sender, EventArgs e)
        {
            if (Gib.copypath == "Null")
                MessageBoxEx.Show("未选择要复制的文件！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (Gib.nowp[Gib.nowtab] <= 0)
                MessageBoxEx.Show("未选择目录！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (File.Exists(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]] + '\\' + Gib.copyfn))
                {
                    if (MessageBoxEx.Show("文件已存在，是否替换？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                        DialogResult.Yes)
                        pastfile(Gib.copypath, Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]], Gib.copyfn, 1, true);
                }
                else
                {
                    //MessageBoxEx.Show(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]] + '\\' + Gib.copyfn);
                    pastfile(Gib.copypath, Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]], Gib.copyfn, 1, true);
                }
            }
            //ToastNotification.Show(this, "文件（夹）已粘贴", 2000);
            reffile(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]]);
        }

        public void batch_Click(object sender, EventArgs e)
        {
            if (Gib.nowp[Gib.nowtab] > 0)
            {
                FrmAll fall = new FrmAll();
                fall.Show(this);
            }
            else
                MessageBoxEx.Show("未选择文件！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void plus_Click(object sender, EventArgs e)
        {
            filename.Text += ".txt";
        }
        
        private void toolsbox_Click(object sender, EventArgs e)
        {
            Gib.crossfile1 = filepath.Text + '\\' + filename.Text;
            FrmTool ftool = new FrmTool();
            ftool.Show(this);
        }

        private void addate_Click(object sender, EventArgs e)
        {
            Clipboard.SetData(DataFormats.Text,
                DateTime.Now.ToString("yyyy-MM-dd") + ' ' + DateTime.Now.ToShortTimeString());
        }

        private void bhistory_Click(object sender, EventArgs e)
        {
            FrmHistory fcc = new FrmHistory();
            fcc.Show(this);
        }

        private void go_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(filepath.Text))
            {
                Gib.fpos[Gib.nowtab, ++Gib.nowp[Gib.nowtab]] = filepath.Text;
                Gib.maxn[Gib.nowtab] = Gib.maxn[Gib.nowtab] > Gib.nowp[Gib.nowtab]
                    ? Gib.maxn[Gib.nowtab]
                    : Gib.nowp[Gib.nowtab];
                reffile(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]]);
            }
        }

        private void plusdate_Click(object sender, EventArgs e)
        {
            int i;
            Gib.nfname = filename.Text;
            int ll = Gib.nfname.Length;
            char[] lsffn = new char[200];
            lsffn = Gib.nfname.ToCharArray();
            Gib.nfname = "";
            for (i = 0; i < filename.SelectionStart; ++i)
                Gib.nfname += lsffn[i].ToString();
            Gib.nfname = Gib.nfname + DateTime.Now.ToString("yyyy-MM-dd  hh时mm分");
            for (i = filename.SelectionStart; i < ll; ++i)
                Gib.nfname += lsffn[i].ToString();
            filename.Text = Gib.nfname;
        }

        private void safeclose_Click(object sender, EventArgs e)
        {
            int i, j;
            if (File.Exists(filepath.Text + '\\' + filename.Text))
                if (Path.GetExtension(filename.Text).ToLower() == ".lrc")
                    File.WriteAllText(filepath.Text + '\\' + filename.Text, Gib.infile);
                else
                    File.WriteAllText(filepath.Text + '\\' + filename.Text, Gib.infile, Encoding.GetEncoding("GB2312"));

            closingthing();
        }

        private void Recovery_Click(object sender, EventArgs e)
        {
            try
            {
                filepath.Text = File.ReadAllText("C:\\ProgramData\\CW Soft\\CW File Viewer\\TempPath.txt");
                if (Directory.Exists(filepath.Text))
                {
                    Gib.fpos[Gib.nowtab, ++Gib.nowp[Gib.nowtab]] = filepath.Text;
                    if (Gib.nowp[Gib.nowtab] > Gib.maxn[Gib.nowtab])
                        Gib.maxn[Gib.nowtab] = Gib.nowp[Gib.nowtab];
                    reffile(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]]);
                }
            }
            catch
            {
            }
        }

        private void putup_Click(object sender, EventArgs e)
        {
            if (Gib.isheng == false)
            {
                Gib.isheng = true;
            }
            else
            {

                Gib.isheng = false;
            }
        }

        private void fullscr_Click(object sender, EventArgs e)
        {
            FrmFullscr frm = new FrmFullscr();
            frm.Show();
        }

        private void sortw1_CheckedChanged(object sender, EventArgs e)
        {
            if (sortw1.Checked)
            {
                Gib.smode = 1;
                if (Gib.nowp[Gib.nowtab] > 0)
                    reffile(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]]);
            }
            else
            {
                Gib.smode = 2;
                if (Gib.nowp[Gib.nowtab] > 0)
                    reffile(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]]);
            }
        }

        #endregion

        #region LRCV

        private string strtrm(string x)
        {
            lsstr = x.ToCharArray();
            if (pdc(lsstr[lsstr.Length - 1]) == 3)
                lsstr[lsstr.Length - 1] = '\0';
            return new string(lsstr);
        }

        public void lrcv_TextChanged(object sender, EventArgs e)
        {
            Gib.infile = lrcv.Text;
            if (Gib.infile != Gib.backup)
                txtstate.Text = "已修改";
            else
                txtstate.Text = "未修改";
            lwsum.Text = Gib.infile.Length.ToString();
        }
        public void lrcv_MouseUp(object sender, MouseEventArgs e)
        {
            if (lrcv.SelectedText.Trim() != "")
            {
                if (usedic.Checked)
                {
                    Gib.selecttext = strtrm(lrcv.SelectedText.Trim());
                    Point ppoint = Control.MousePosition;
                    Point fpoint = this.PointToClient(Control.MousePosition);
                    if (fpoint.X > this.Size.Width - 433)
                        Gib.mx = ppoint.X - 441;
                    else
                        Gib.mx = ppoint.X + 8;
                    if (fpoint.Y > this.Size.Height - 165)
                        Gib.my = ppoint.Y - 172;
                    else
                        Gib.my = ppoint.Y + 8;
                    FrmDic frm = new FrmDic();
                    frm.Show();
                }
                if (UseFormatForm.Checked && !Gib.TextFormatFormOpened && lrcv.SelectionFont != null)
                {
                    Point ppoint = Control.MousePosition;
                    Point fpoint = this.PointToClient(Control.MousePosition);
                    if (fpoint.X > this.Size.Width - 233)
                        Gib.mx = ppoint.X - 241;
                    else
                        Gib.mx = ppoint.X + 8;
                    if (fpoint.Y > this.Size.Height - 69)
                        Gib.my = ppoint.Y - 77;
                    else
                        Gib.my = ppoint.Y + 8;
                    FrmTextWork frm = new FrmTextWork();
                    frm.Show(this);
                }
            }
        }

        private void lrcv_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
                this.lrcv.SelectAll();
            else if (e.Control && e.KeyCode == Keys.F)
            {
                FrmFind frm = new FrmFind();
                frm.Show(this);
            }
            else if (e.Alt && e.KeyCode == Keys.F)
            {
                switch (Gib.nowtab)
                {
                    case 1:
                        filev1.Focus();
                        break;
                    case 2:
                        filev2.Focus();
                        break;
                    case 3:
                        filev3.Focus();
                        break;
                }
            }
            else if (e.KeyCode == Keys.S)
            {
                if (e.Control)
                {
                    if (Gib.nowp[Gib.nowtab] > 0)
                        if (Gib.txtpath != "")
                        {
                            if (Path.GetExtension(Gib.txtpath).ToLower() == ".rtf")
                                lrcv.SaveFile(Gib.txtpath, RichTextBoxStreamType.RichText);
                            else if (Path.GetExtension(Gib.txtpath).ToLower() == ".lrc")
                                File.WriteAllText(Gib.txtpath, Gib.infile);
                            else if (Path.GetExtension(Gib.txtpath).ToLower() == ".txt")
                                File.WriteAllText(Gib.txtpath, Gib.infile, Encoding.GetEncoding("GB2312"));
                            else if (Path.GetExtension(Gib.txtpath).ToLower() != ".mp3")
                                File.WriteAllText(Gib.txtpath, Gib.infile, Encoding.Default);

                            Gib.backup = Gib.infile;
                            txtstate.Text = "未修改";
                        }
                }
                else if (e.Alt)
                    search_Click(sender, e);
            }
            else if (e.Control && e.KeyCode == Keys.D)
            {
                if (MessageBoxEx.Show("确定删除文件？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) ==
                    DialogResult.OK)
                {
                    delfd(Gib.txtpath, true);
                    reffile(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]]);
                }
            }
            else if (e.Control && e.KeyCode == Keys.C)
                try { Clipboard.SetDataObject(this.lrcv.SelectedRtf, true); }
                catch { }
                
        }

        #endregion


        public void filename_TextChanged(object sender, EventArgs e)
        {
            Gib.nfname = filename.Text;
        }

        public void player_StatusChange(object sender, EventArgs e)
        {
            if (player.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                if (repeatplay.Checked)
                    player.Ctlcontrols.play();
                else
                {

                    Gib.pstate = 2;
                    player.Ctlcontrols.pause();
                    playbutton.Image = Properties.Resources.state11;
                    playbutton.HoverImage = Properties.Resources.state12;
                    playbutton.PressedImage = Properties.Resources.state13;
                }
            }
        }

        private void onlyfolder_CheckedChanged(object sender, EventArgs e)
        {
            if (Gib.nowp[Gib.nowtab] > 0)
                reffile(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]]);
        }

        #region ToDir
        private void todirc_Click(object sender, EventArgs e)
        {
            if (Directory.Exists("C:\\"))
            {
                Gib.fpos[Gib.nowtab, ++Gib.nowp[Gib.nowtab]] = "C:\\";
                Gib.maxn[Gib.nowtab] = Gib.maxn[Gib.nowtab] > Gib.nowp[Gib.nowtab] ? Gib.maxn[Gib.nowtab] : Gib.nowp[Gib.nowtab];
                filepath.Text = Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]];
                reffile(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]]);
            }
        }

        private void todird_Click(object sender, EventArgs e)
        {
            if (Directory.Exists("D:\\"))
            {
                Gib.fpos[Gib.nowtab, ++Gib.nowp[Gib.nowtab]] = "D:\\";
                Gib.maxn[Gib.nowtab] = Gib.maxn[Gib.nowtab] > Gib.nowp[Gib.nowtab] ? Gib.maxn[Gib.nowtab] : Gib.nowp[Gib.nowtab];
                filepath.Text = Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]];
                reffile(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]]);
            }
        }

        private void todire_Click(object sender, EventArgs e)
        {
            if (Directory.Exists("E:\\"))
            {
                Gib.fpos[Gib.nowtab, ++Gib.nowp[Gib.nowtab]] = "E:\\";
                Gib.maxn[Gib.nowtab] = Gib.maxn[Gib.nowtab] > Gib.nowp[Gib.nowtab] ? Gib.maxn[Gib.nowtab] : Gib.nowp[Gib.nowtab];
                filepath.Text = Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]];
                reffile(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]]);
            }
        }

        private void todirf_Click(object sender, EventArgs e)
        {
            if (Directory.Exists("F:\\"))
            {
                Gib.fpos[Gib.nowtab, ++Gib.nowp[Gib.nowtab]] = "F:\\";
                Gib.maxn[Gib.nowtab] = Gib.maxn[Gib.nowtab] > Gib.nowp[Gib.nowtab] ? Gib.maxn[Gib.nowtab] : Gib.nowp[Gib.nowtab];
                filepath.Text = Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]];
                reffile(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]]);
            }
        }
        #endregion

        #region filepath
        private void filepath_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Gib.fpos[Gib.nowtab, ++Gib.nowp[Gib.nowtab]] = filepath.Text;
                ++Gib.maxn[Gib.nowtab];
                reffile(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]]);
            }
        }
        #endregion· 

        #region Font Size Control

        private void fssmall_Click(object sender, EventArgs e)
        {
            lrcv.Font = new Font(lrcv.Font.Name, 12);
            wtsize.Value = 12;
        }
        private void fsbig_Click(object sender, EventArgs e)
        {
            lrcv.Font = new Font(lrcv.Font.Name, 22);
            wtsize.Value = 22;
        }
        private void wtsize_ValueChanged(object sender, EventArgs e)
        {
            lrcv.Font = new Font(lrcv.Font.Name, wtsize.Value);
        }

        #endregion

        #region FILEV

        #region filev_SelectedIndexChanged


        private int bj = 0;

        private void filev1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bj == 1)
                if (this.filev1.SelectedItems.Count > 0)
                {
                    Gib.fname = this.filev1.SelectedItems[0].Text;
                    Gib.lpos[Gib.nowtab, Gib.nowp[Gib.nowtab]] = this.filev1.TopItem.Index;
                    loadfile();
                }
        }

        private void filev1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                isleftkey = true;
            else if (e.Button == MouseButtons.Right)
                isleftkey = false;
            bj = 1;
        }
        private void filev2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.filev2.SelectedItems.Count > 0)
            {
                Gib.fname = this.filev2.SelectedItems[0].Text;
                Gib.lpos[Gib.nowtab, Gib.nowp[Gib.nowtab]] = this.filev2.TopItem.Index;
                loadfile();
            }
        }
        private void filev2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isleftkey = true;
            }
            else if (e.Button == MouseButtons.Right)
            {
                isleftkey = false;
            }
        }
        private void filev3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.filev3.SelectedItems.Count > 0)
            {
                Gib.fname = this.filev3.SelectedItems[0].Text;
                Gib.lpos[Gib.nowtab, Gib.nowp[Gib.nowtab]] = this.filev3.TopItem.Index;
                loadfile();
            }
        }
        private void filev3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isleftkey = true;
            }
            else if (e.Button == MouseButtons.Right)
            {
                isleftkey = false;
            }
        }
        #endregion

        #region filev_ItemMouseHover
        private void filev1_ItemMouseHover(object sender, ListViewItemMouseHoverEventArgs e)//ListViewItemMouseHoverEventArgs e)
        {
            if (useprev.Checked)
            {
                //Point ppoint = this.PointToClient(Control.MousePosition);
                Gib.pname = e.Item.Text;

                Gib.ppath = Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]] + '\\' + Gib.pname;
                Gib.plast = Path.GetExtension(Gib.ppath);
                //MessageBoxEx.Show(Gib.pname + '\n' + Gib.ppath + '\n' + Gib.plast);
                if (Gib.plast == ".txt" || Gib.plast == ".TXT" || Gib.plast == ".lrc" || Gib.plast == ".LRC")
                {
                    if (Gib.ptext != Gib.pname)
                    {
                        Gib.ptext = Gib.pname;
                        Point ppoint = Control.MousePosition;
                        Gib.mx = ppoint.X + 2;
                        Gib.my = ppoint.Y + 2;
                        FrmPtxt fprev = new FrmPtxt();
                        fprev.Show();
                    }
                    else
                    {
                        Gib.ptext = Gib.pname;
                    }
                }
                else if (Gib.plast == ".png" || Gib.plast == ".PNG" || Gib.plast == ".jpg" || Gib.plast == ".JPG" || Gib.plast == ".bmp" || Gib.plast == ".BMP" || Gib.plast == ".ico" || Gib.plast == ".ICO")
                {
                    if (Gib.ptext != Gib.pname)
                    {
                        Gib.ptext = Gib.pname;
                        Point ppoint = Control.MousePosition;
                        Gib.mx = ppoint.X + 2;
                        Gib.my = ppoint.Y + 2;
                        Bitmap image1 = new Bitmap(Gib.ppath);
                        FrmPpic.PictureWidth = image1.Width.ToString();
                        FrmPpic.Pictureheight = image1.Height.ToString();
                        FileInfo finfo = new FileInfo(Gib.ppath);
                        FrmPpic fprev = new FrmPpic();
                        fprev.Show(this);
                        fprev.Hide();
                    }
                    else
                    {
                        Gib.ptext = Gib.pname;
                    }
                    //Gib.ptext = Gib.pname;
                }
            }
        }
        private void filev2_ItemMouseHover(object sender, ListViewItemMouseHoverEventArgs e)//ListViewItemMouseHoverEventArgs e)
        {
            if (useprev.Checked == true)
            {
                //Point ppoint = this.PointToClient(Control.MousePosition);
                Gib.pname = e.Item.Text;

                Gib.ppath = Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]] + '\\' + Gib.pname;
                Gib.plast = Path.GetExtension(Gib.ppath);
                //MessageBoxEx.Show(Gib.pname + '\n' + Gib.ppath + '\n' + Gib.plast);
                if (Gib.plast == ".txt" || Gib.plast == ".TXT" || Gib.plast == ".lrc" || Gib.plast == ".LRC")
                {
                    if (Gib.ptext != Gib.pname)
                    {
                        Gib.ptext = Gib.pname;
                        Point ppoint = Control.MousePosition;
                        Gib.mx = ppoint.X + 2;
                        Gib.my = ppoint.Y + 2;
                        FrmPtxt fprev = new FrmPtxt();
                        fprev.Show(this);
                        fprev.Hide();
                    }
                    else
                    {
                        Gib.ptext = Gib.pname;
                    }
                }
                else if (Gib.plast == ".png" || Gib.plast == ".PNG" || Gib.plast == ".jpg" || Gib.plast == ".JPG" || Gib.plast == ".bmp" || Gib.plast == ".BMP" || Gib.plast == ".ico" || Gib.plast == ".ICO")
                {
                    if (Gib.ptext != Gib.pname)
                    {
                        Gib.ptext = Gib.pname;
                        Point ppoint = Control.MousePosition;
                        Gib.mx = ppoint.X + 2;
                        Gib.my = ppoint.Y + 2;
                        Bitmap image1 = new Bitmap(Gib.ppath);
                        FrmPpic.PictureWidth = image1.Width.ToString();
                        FrmPpic.Pictureheight = image1.Height.ToString();
                        FileInfo finfo = new FileInfo(Gib.ppath);
                        FrmPpic fprev = new FrmPpic();
                        fprev.Show(this);
                        fprev.Hide();
                    }
                    else
                    {
                        Gib.ptext = Gib.pname;
                    }
                    //Gib.ptext = Gib.pname;
                }
            }
        }
        private void filev3_ItemMouseHover(object sender, ListViewItemMouseHoverEventArgs e)//ListViewItemMouseHoverEventArgs e)
        {
            if (useprev.Checked == true)
            {
                //Point ppoint = this.PointToClient(Control.MousePosition);
                Gib.pname = e.Item.Text;

                Gib.ppath = Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]] + '\\' + Gib.pname;
                Gib.plast = Path.GetExtension(Gib.ppath);
                //MessageBoxEx.Show(Gib.pname + '\n' + Gib.ppath + '\n' + Gib.plast);
                if (Gib.plast == ".txt" || Gib.plast == ".TXT" || Gib.plast == ".lrc" || Gib.plast == ".LRC")
                {
                    if (Gib.ptext != Gib.pname)
                    {
                        Gib.ptext = Gib.pname;
                        Point ppoint = Control.MousePosition;
                        Gib.mx = ppoint.X + 2;
                        Gib.my = ppoint.Y + 2;
                        FrmPtxt fprev = new FrmPtxt();
                        fprev.Show(this);
                        fprev.Hide();
                    }
                    else
                    {
                        Gib.ptext = Gib.pname;
                    }
                }
                else if (Gib.plast == ".png" || Gib.plast == ".PNG" || Gib.plast == ".jpg" || Gib.plast == ".JPG" || Gib.plast == ".bmp" || Gib.plast == ".BMP" || Gib.plast == ".ico" || Gib.plast == ".ICO")
                {
                    if (Gib.ptext != Gib.pname)
                    {
                        Gib.ptext = Gib.pname;
                        Point ppoint = Control.MousePosition;
                        Gib.mx = ppoint.X + 2;
                        Gib.my = ppoint.Y + 2;
                        Bitmap image1 = new Bitmap(Gib.ppath);
                        FrmPpic.PictureWidth = image1.Width.ToString();
                        FrmPpic.Pictureheight = image1.Height.ToString();
                        FileInfo finfo = new FileInfo(Gib.ppath);
                        FrmPpic fprev = new FrmPpic();
                        fprev.Show(this);
                        fprev.Hide();
                    }
                    else
                    {
                        Gib.ptext = Gib.pname;
                    }
                    //Gib.ptext = Gib.pname;
                }
            }
        }
        #endregion

        #region filev_KeyDown

        private void keydown(Keys key)
        {
            if (key == Keys.D)
            {
                if (MessageBoxEx.Show("确定删除文件？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) ==
                    DialogResult.OK)
                {
                    delfd(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab] + 1], true);
                    reffile(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]]);
                }
            }
            else if (key == Keys.Back && back.Enabled)
                flback();
            else if (key == Keys.Enter)
                reffile(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]]);
            else if (key == Keys.F)
                flmakecopy();
            else if (key == Keys.M)
            {
                if (Gib.txtpath != "")
                {
                    Gib.dochoosetag = false;
                    FrmTag frm = new FrmTag();
                    frm.Show(this);
                }
                else
                    MessageBoxEx.Show("未选择文件！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (key == Keys.S)
                search_Click(new object(), new EventArgs());
        }

        private void filev1_KeyDown(object sender, KeyEventArgs e)
        {
            keydown(e.KeyCode);
        }
        private void filev2_KeyDown(object sender, KeyEventArgs e)
        {
            keydown(e.KeyCode);
        }
        private void filev3_KeyDown(object sender, KeyEventArgs e)
        {
            keydown(e.KeyCode);
        }
        #endregion

        #endregion

        #region TABV

        private void tab1_Click(object sender, EventArgs e)
        {
            Gib.nowtab = 1;
            filepath.Text = Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]];
            if (filepath.Text != "")
                refcrb(filepath.Text);
            else
            {
                Gib.nowcrst = 1;
                fpcrumb.Items.Clear();
            }
        }
        private void tab2_Click(object sender, EventArgs e)
        {
            Gib.nowtab = 2;
            filepath.Text = Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]];
            if (filepath.Text != "")
                refcrb(filepath.Text);
            else
            {
                Gib.nowcrst = 1;
                fpcrumb.Items.Clear();
            }
        }
        private void tab3_Click(object sender, EventArgs e)
        {
            Gib.nowtab = 3;
            filepath.Text = Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]];
            if (filepath.Text != "")
                refcrb(filepath.Text);
            else
            {
                Gib.nowcrst = 1;
                fpcrumb.Items.Clear();
            }
        }

        #endregion

        private void nowdoti_Tick(object sender, EventArgs e)
        {
            //MessageBoxEx.Show("\""+player.status+"\"");
            if (looklrc.Checked)
            {
                if (player.status == "")
                    nowdo.Text = "未选择路径";
                else
                    nowdo.Text = player.status;
            }
            else
            {
                nowdo.Text = "（如想查看字幕和状态请选择“显示字幕+播放状态”）";
            }
        }

        #region Right Button

        private void rbdel_Click(object sender, EventArgs e)
        {
            delfd(Gib.rbfile, true);
            reffile(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]]);
        }

        private void copyfile(string from, bool print)
        {
            if (File.Exists(from))
            {
                Gib.cpmode = 1;
                Gib.copypath = from;
                Gib.copyfn = Path.GetFileName(from);
                //if (print)
                //    ToastNotification.Show(this, "文件已复制", 2000);
            }
            else if (Directory.Exists(from))
            {
                Gib.cpmode = 2;
                Gib.copypath = from;
                Gib.copyfn = Path.GetFileName(from);
                //if (print)
                //    ToastNotification.Show(this, "文件夹已复制", 2000);
            }
            else
                MessageBoxEx.Show("路径不存在！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        private void rbcut_Click(object sender, EventArgs e)
        {
            Gib.cpiscut = true;
            copyfile(Gib.rbfile, true);
        }

        private void rbcopy_Click(object sender, EventArgs e)
        {
            Gib.cpiscut = false;
            copyfile(Gib.rbfile, true);
        }
        private void CopyFolder(string from, string to)
        {
            if (!Directory.Exists(to))
                Directory.CreateDirectory(to);

            // 文件
            string[] str = Directory.GetFiles(from);
            foreach (string file in str)
                try { File.Copy(file, to + '\\' + Path.GetFileName(file), true);}
                catch (Exception Ex) { if ( MessageBoxEx.Show(this, Ex.ToString(), "错误！点Cancel复制消息。", MessageBoxButtons.OKCancel) == DialogResult.Cancel ) Clipboard.SetText(Ex.ToString()); }
                

            // 子文件夹
            str = Directory.GetDirectories(from);
            foreach (string folder in str)
                CopyFolder(folder, to +'\\'+ Path.GetFileName(folder));
        }

        private void pastfile(string from, string to, string toname, int cpmode, bool print)
        {
            if (File.Exists(from) == false && Directory.Exists(from) == false)
            {
                MessageBoxEx.Show("未选择路径！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cpmode == 1)
            {
                if (File.Exists(to + '\\' + toname))
                {
                    if (MessageBoxEx.Show("文件已存在，是否替换？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                        DialogResult.Yes)
                    {
                        File.Copy(from, to + '\\' + toname, true);
                        try { File.Copy(Path_FileNote(from), Path_FileNote(to + '\\' + toname), true); } catch { }
                        //if (print) ToastNotification.Show(this, "文件已粘贴", 2000);
                    }
                }
                else
                {
                    File.Copy(from, to + '\\' + toname, true);
                    try
                    {
                        File.Copy(Path_FileNote(from), Path_FileNote(to + '\\' + toname), true);
                    }
                    catch { }
                    //if (print) ToastNotification.Show(this, "文件已粘贴", 2000);
                }
            }
            else
            {
                if (Directory.Exists(to + '\\' + toname))
                {
                    MessageBoxEx.Show("文件夹已存在!");
                }
                else
                {
                    CopyFolder(from, to + '\\' + toname);
                    //if (print)
                    //    ToastNotification.Show(this, "文件夹已粘贴", 2000);
                }
            }
        }

        private void rbpast_Click(object sender, EventArgs e)
        {
            pastfile(Gib.copypath, Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]], Gib.copyfn,Gib.cpmode,true);
            if (Gib.cpiscut)
                delfd(Gib.rbfile, false);
            reffile(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]]);
        }
        private void makesamefile_Click(object sender, EventArgs e)
        {
            int i;
            string fpath = Path.GetDirectoryName(Gib.rbfile), fname = Path.GetFileName(Gib.rbfile);
            if (File.Exists(Gib.rbfile))
            {
                for (i = 1; ; ++i)
                    if (
                        File.Exists(fpath + '\\' + Path.GetFileNameWithoutExtension(fname) + " - 副本" + i.ToString() +
                                    Path.GetExtension(fname)) == false)
                        break;
                string fs = fpath + '\\' + Path.GetFileNameWithoutExtension(fname) + " - 副本" + i.ToString() +
                            Path.GetExtension(fname);
                pastfile(Gib.rbfile, Path.GetDirectoryName(fs), Path.GetFileName(fs), 1, false);
                //ToastNotification.Show(this, "成功为文件制作副本", 2000);
            }
            else if (Directory.Exists(Gib.rbfile))
            {
                for (i = 1; ; ++i)
                    if (
                        Directory.Exists(fpath + '\\' + Path.GetFileNameWithoutExtension(fname) + " - 副本" + i.ToString() +
                                    Path.GetExtension(fname)) == false)
                        break;
                string fs = fpath + '\\' + Path.GetFileNameWithoutExtension(fname) + " - 副本" + i.ToString() +
                            Path.GetExtension(fname);
                pastfile(Gib.rbfile, Path.GetDirectoryName(fs), Path.GetFileName(fs), 2, false);
                //ToastNotification.Show(this, "成功为文件夹制作副本", 2000);
            }
            reffile(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]]);
        }

        private void rbinfo_Click(object sender, EventArgs e)
        {
            FrmInfo finfo = new FrmInfo();
            finfo.Show(this);
        }
        #endregion

        private void godestop_Click(object sender, EventArgs e)
        {
            Gib.fpos[Gib.nowtab, ++Gib.nowp[Gib.nowtab]] = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            Gib.maxn[Gib.nowtab] = Gib.maxn[Gib.nowtab] > Gib.nowp[Gib.nowtab] ? Gib.maxn[Gib.nowtab] : Gib.nowp[Gib.nowtab];
            reffile(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]]);
        }

        private void givetimefirst_Tick(object sender, EventArgs e)
        {
            int nowt = DateTime.Now.Hour;
            if (nowt < 12)
                ToastNotification.Show(this, "上午好，现在时间：" + DateTime.Now.ToString("hh:mm  yyyy/MM/dd  ") + DateTime.Now.DayOfWeek.ToString(), 10000);
            else if (nowt == 12)
                ToastNotification.Show(this, "中午好，现在时间：" + DateTime.Now.ToString("hh:mm  yyyy/MM/dd  ") + DateTime.Now.DayOfWeek.ToString(), 10000);
            else if (nowt > 12 && nowt < 18)
                ToastNotification.Show(this, "下午好，现在时间：" + DateTime.Now.ToString("hh:mm  yyyy/MM/dd  ") + DateTime.Now.DayOfWeek.ToString(), 10000);
            else
                ToastNotification.Show(this, "晚上好，现在时间：" + DateTime.Now.ToString("hh:mm  yyyy/MM/dd  ") + DateTime.Now.DayOfWeek.ToString(), 10000);
            givetfirst.Enabled = false;
        }

        private void seevery_CheckedChanged(object sender, EventArgs e)
        {
            reffile(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]]);
        }

        private void rogbin_Click(object sender, EventArgs e)
        {
            Gib.fpos[Gib.nowtab, ++Gib.nowp[Gib.nowtab]] = "C:\\ProgramData\\CW Soft\\CW File Viewer\\RecycleBin";
            Gib.maxn[Gib.nowtab] = Gib.maxn[Gib.nowtab] > Gib.nowp[Gib.nowtab] ? Gib.maxn[Gib.nowtab] : Gib.nowp[Gib.nowtab];
            reffile(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]]);
        }

        private void volumeslider_ValueChanged(object sender, EventArgs e)
        {
            player.settings.volume = volumeslider.Value;
            volumevalue.Text = volumeslider.Value.ToString();
        }

        private void playbutton_Click(object sender, EventArgs e)
        {
            if (Gib.pstate == 1)
            {
                Gib.pstate = 2;
                player.Ctlcontrols.pause();
                playbutton.Image = Properties.Resources.state11;
                playbutton.HoverImage = Properties.Resources.state12;
                playbutton.PressedImage = Properties.Resources.state13;
            }
            else
            {
                Gib.pstate = 1;
                player.Ctlcontrols.play();
                playbutton.Image = Properties.Resources.state21;
                playbutton.HoverImage = Properties.Resources.state22;
                playbutton.PressedImage = Properties.Resources.state23;
            }
        }

        private void leftpanel_SizeChanged(object sender, EventArgs e)
        {
            tabv.FixedTabSize = new Size((panelfile.Size.Width - 39) / 3, 0);
        }

        private void goodsort_CheckedChanged(object sender, EventArgs e)
        {
            reffile(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]]);
        }

        private void lastdir_Click(object sender, EventArgs e)
        {
            if(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]].Length>3)
            {
                Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab] + 1] = Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]];
                ++Gib.nowp[Gib.nowtab];
                Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]].Remove(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]].LastIndexOf('\\'), 1);
                Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]] = Path.GetDirectoryName(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]]);
                Gib.maxn[Gib.nowtab] = Gib.maxn[Gib.nowtab] > Gib.nowp[Gib.nowtab] ? Gib.maxn[Gib.nowtab] : Gib.nowp[Gib.nowtab];
                filepath.Text = Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]];
                reffile(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]]);
            }
        }

        private void fpcrumb_SelectedItemChanging(object sender, CrumbBarSelectionEventArgs e)
        {
            if (Gib.nowcrst == 0)
            {
                CrumbBarItem parent = e.NewSelectedItem;
                Gib.nowcrst = 1;
                parent.SubItems.Clear();
                DirectoryInfo dirInfo = null;
                if (parent.Tag is DriveInfo)
                {
                    DriveInfo driveInfo = (DriveInfo) parent.Tag;
                    dirInfo = driveInfo.RootDirectory;
                }
                else if (parent.Tag is DirectoryInfo)
                {
                    dirInfo = (DirectoryInfo) parent.Tag;
                }
                else
                {
                    return;
                }
                Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]] = dirInfo.FullName;
                Gib.maxn[Gib.nowtab] = Gib.maxn[Gib.nowtab] > Gib.nowp[Gib.nowtab]
                    ? Gib.maxn[Gib.nowtab]
                    : Gib.nowp[Gib.nowtab];
                filepath.Text = Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]];
                //loadin(parent);
                reffile(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]]);
                //Gib.nowcrst = 1;
            }
            else
                Gib.nowcrst = 0;
        }

        private void fpcrumb_DoubleClick(object sender, EventArgs e)
        {
            fpcrumb.Visible = false;
        }

        private void filepath_MouseLeave(object sender, EventArgs e)
        {
            fpcrumb.Visible = true;
        }

        private void savenohint_CheckedChanged(object sender, EventArgs e)
        {
            Gib.settings[0] = Convert.ToInt32(savenohint.Checked);
        }

        private void recoveryatfirst_CheckedChanged(object sender, EventArgs e)
        {
            Gib.settings[1] = Convert.ToInt32(recoveryatfirst.Checked);
        }

        private void delcollection_Click(object sender, EventArgs e)
        {
            try
            {
                collectionbar.Items.Remove(Gib.rbcol);
                --Gib.collectn;
                collectionbar.Refresh();
            }
            catch
            {
            }
        }

        private void changecollectiontext_Click(object sender, EventArgs e)
        {
            Gib.rbcol.Image = Properties.Resources.folderp;

            Gib.rbcol.Tag = Gib.rbcol.Tooltip = Gib.rbfile;
            Gib.rbcol.Text = cutstring(Path.GetFileName(Path.GetFileName(Gib.rbfile)));

            if (Directory.Exists(Gib.crossfile2))
                Gib.rbcol.Image = Properties.Resources.folderp;
            else
                Gib.rbcol.Image = Properties.Resources.errorp;

            Gib.rbcol.Tag = Gib.rbcol.Tooltip = Gib.crossfile2;
            Gib.rbcol.Text = cutstring(Path.GetFileName(Gib.crossfile1));
        }

        private void tocollection_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(filepath.Text))
            {
                Gib.rbcol = new ButtonItem();

                Gib.rbcol.ButtonStyle = eButtonStyle.ImageAndText;
                Gib.rbcol.Click += new System.EventHandler(buttonItem_Click);
                Gib.rbcol.MouseDown += new System.Windows.Forms.MouseEventHandler(buttonItem_MouseDown);

                Gib.rbcol.Image = Properties.Resources.folderp;

                Gib.rbcol.Tag = Gib.rbcol.Tooltip = filepath.Text;
                Gib.rbcol.Text = cutstring(Path.GetFileName(Path.GetFileName(filepath.Text)));

                collectionbar.Items.Add(Gib.rbcol);

                collectionbar.Refresh();

                ++Gib.collectn;
            }
        }

        private void rbtocollection_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(Gib.rbfile))
            {
                Gib.rbcol = new ButtonItem();

                Gib.rbcol.ButtonStyle = eButtonStyle.ImageAndText;
                Gib.rbcol.Click += new System.EventHandler(buttonItem_Click);
                Gib.rbcol.MouseDown += new System.Windows.Forms.MouseEventHandler(buttonItem_MouseDown);

                Gib.rbcol.Image = Properties.Resources.folderp;

                Gib.rbcol.Tag = Gib.rbcol.Tooltip = Gib.rbfile;
                Gib.rbcol.Text = cutstring(Path.GetFileName(Path.GetFileName(Gib.rbfile)));

                collectionbar.Items.Add(Gib.rbcol);

                collectionbar.Refresh();

                ++Gib.collectn;
            }
        }

        public void filetag_Click(object sender, EventArgs e)
        {
            if (Gib.txtpath != "")
            {
                Gib.dochoosetag = false;
                FrmTag frm = new FrmTag();
                frm.ShowDialog(this);
            }
            else
                MessageBoxEx.Show("未选择文件！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void search_Click(object sender, EventArgs e)
        {
            FrmSearch frm = new FrmSearch();
            frm.Show(this);
        }

        void flmakecopy()
        {
            int i;
            for (i = 1; ; ++i)
                if (File.Exists(Path.GetDirectoryName(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab] + 1]) + '\\' + Path.GetFileNameWithoutExtension(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab] + 1]) + " - 副本" + i.ToString() + Path.GetExtension(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab] + 1])) == false)
                    break;
            //MessageBoxEx.Show(Gib.fpos[Gib.nowtab,Gib.nowp[Gib.nowtab] + 1] + '\n' + Path.GetDirectoryName(Gib.fpos[Gib.nowtab,Gib.nowp[Gib.nowtab] + 1]) + '\\' + Path.GetFileNameWithoutExtension(Gib.fpos[Gib.nowtab,Gib.nowp[Gib.nowtab] + 1]) + " - 副本" + i.ToString() + Path.GetExtension(Gib.fpos[Gib.nowtab,Gib.nowp[Gib.nowtab] + 1]));
            string sss = Path.GetDirectoryName(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab] + 1]) + '\\' + Path.GetFileNameWithoutExtension(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab] + 1]) + " - 副本" + i.ToString() + Path.GetExtension(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab] + 1]);//File.Copy(Path.GetDirectoryName(Gib.fpos[Gib.nowtab,Gib.nowp[Gib.nowtab] + 1]), Path.GetDirectoryName(Gib.fpos[Gib.nowtab,Gib.nowp[Gib.nowtab] + 1]) + '\\' + Path.GetFileNameWithoutExtension(Gib.fpos[Gib.nowtab,Gib.nowp[Gib.nowtab] + 1]) + " - 副本" + i.ToString() + Path.GetExtension(Gib.fpos[Gib.nowtab,Gib.nowp[Gib.nowtab] + 1]),true);
            File.Copy(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab] + 1], sss);
            reffile(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]]);
        }

        private void makecopy_Click(object sender, EventArgs e)
        {
            flmakecopy();
        }

        private void ordertags_Click(object sender, EventArgs e)
        {
            int i, j, k;
            for (i = 0; i < Gib.ts[Gib.nowsysi].pagen; ++i)
                if (Directory.Exists("C:\\CW File Viewer\\Tag - " + Gib.ts[Gib.nowsysi].name + "\\" + Gib.ts[Gib.nowsysi].allpage[i]) == false)
                    Directory.CreateDirectory("C:\\CW File Viewer\\Tag - " + Gib.ts[Gib.nowsysi].name + "\\" + Gib.ts[Gib.nowsysi].allpage[i]);
            for (i = 0; i < Gib.ts[Gib.nowsysi].tagn; ++i)
                if (
                    Directory.Exists("C:\\CW File Viewer\\Tag - " + Gib.ts[Gib.nowsysi].name + "\\" + Gib.ts[Gib.nowsysi].allpage[Gib.ts[Gib.nowsysi].tagp[i]] +
                                     "\\" + Gib.ts[Gib.nowsysi].alltag[i]) == false)
                    Directory.CreateDirectory("C:\\CW File Viewer\\Tag - " + Gib.ts[Gib.nowsysi].name + "\\" +
                                              Gib.ts[Gib.nowsysi].allpage[Gib.ts[Gib.nowsysi].tagp[i]] + "\\" + Gib.ts[Gib.nowsysi].alltag[i]);
            string fname;
            for (i = 0; i < Gib.ts[Gib.nowsysi].ftagn; ++i)
            {
                fname = Path.GetFileName(Gib.ts[Gib.nowsysi].ftagpath[i]);
                if (File.Exists(Gib.ts[Gib.nowsysi].ftagpath[i]))
                {
                    for (j = 0; j < Gib.ts[Gib.nowsysi].ftags[i]; ++j)
                        for (k = 0; k < Gib.ts[Gib.nowsysi].tagn; ++k)
                            if (Gib.ts[Gib.nowsysi].ftagname[i, j] == Gib.ts[Gib.nowsysi].alltag[k])
                                File.Copy(Gib.ts[Gib.nowsysi].ftagpath[i],
                                    "C:\\CW File Viewer\\Tag - " + Gib.ts[Gib.nowsysi].name + "\\" + Gib.ts[Gib.nowsysi].allpage[Gib.ts[Gib.nowsysi].tagp[k]] +
                                    "\\" + Gib.ts[Gib.nowsysi].alltag[k] + "\\" +
                                    fname, true);
                }
                else
                    Gib.ts[Gib.nowsysi].ftagpath[i] = "";
            }
            //ToastNotification.Show(this, "标签整理完成", 2000);
        }

        private void FrmMain_SizeChanged(object sender, EventArgs e)
        {
            collectionbar.Refresh();
        }

        private void collectionbar_BarStateChanged(object sender, BarStateChangedEventArgs e)
        {

        }

        private void collectionbar_SizeChanged(object sender, EventArgs e)
        {
            collectionbar.Size = new Size(1356, 25);
            collectionbar.Refresh();
        }

        private int state = 0;

        private void filecontrolbar_MouseEnter(object sender, EventArgs e)
        {
            fcpst.Enabled = true;
        }

        Point fpoint;

        private void filecontrolbar_Click(object sender, EventArgs e)
        {

        }

        private void filect_Tick(object sender, EventArgs e)
        {
            fpoint = this.PointToClient(Control.MousePosition);
            if (fpoint.X < 0 || fpoint.X > 295 || fpoint.Y < 156 || fpoint.Y > 217)
            {
                filecontrolbar.Location = new Point(-280, 161);
                state = 0;
                filect.Enabled = false;
                fcpst.Enabled = false;
            }
        }

        private void filecontrolbar_Paint(object sender, PaintEventArgs e)
        {
        }

        private void fcpst_Tick(object sender, EventArgs e)
        {
            if (state == 0)
            {
                filecontrolbar.Location = new Point(filecontrolbar.Location.X + 40, 161);
                //filecontrolbar.Refresh();
                if (filecontrolbar.Location.X >= 0)
                {
                    state = 1;
                    filect.Enabled = true;
                    fcpst.Enabled = false;
                }
            }
            /*
                fcpst.Enabled = true;
                for (int i = -280; i < 1; i += 10)
                {
                    filecontrolbar.Location = new Point(i, 161);
                    filecontrolbar.Refresh();
                }
                state = 1;
                filect.Enabled = true;
                 */
        }

        private void cleantag_Click(object sender, EventArgs e)
        {
            int i, j, k;
            bool flag;
            for (i = 0; i < Gib.ts[Gib.nowsysi].ftagn; ++i)
            {
                flag = false;
                for (j = 0; j < Gib.ts[Gib.nowsysi].ftags[i]; ++i)
                {
                    for (k = 0; k < Gib.ts[Gib.nowsysi].tagn; ++k)
                        if (Gib.ts[Gib.nowsysi].ftagname[i, j] == Gib.ts[Gib.nowsysi].alltag[k])
                        {
                            flag = true;
                            break;
                        }
                    if (flag)
                        break;
                }
                if (flag == false)
                    Gib.ts[Gib.nowsysi].ftagpath[i] = "";
            }
            //ToastNotification.Show(this, "清理标签完成", 2000);
        }

        private void tagpageman_Click(object sender, EventArgs e)
        {
            FrmTagPageMan frm = new FrmTagPageMan();
            frm.Show();
        }

        private void useast_CheckedChanged(object sender, EventArgs e)
        {
            if (useast.Checked)
            {
                autosave.Enabled = true;
                autost.Enabled = true;
                textl1.Enabled = true;
                Gib.settings[2] = 1;
            }
            else
            {
                autosave.Enabled = false;
                autost.Enabled = false;
                textl1.Enabled = false;
                Gib.settings[2] = 0;
            }
        }

        private void autost_ValueChanged(object sender, EventArgs e)
        {
            Gib.settings[2] = autost.Value;
            autosave.Interval = Gib.settings[2]*60000;
        }

        private void autosave_Tick(object sender, EventArgs e)
        {
            closemode = 0;
            saveplace = "C:\\ProgramData\\CW Soft\\CW File Viewer\\EmergencyRealTimeBackup\\";
            closingthing();
        }

        private void savestatenow_Click(object sender, EventArgs e)
        {
            closemode = 0;
            saveplace = "C:\\ProgramData\\CW Soft\\CW File Viewer\\EmergencyRealTimeBackup\\";
            closingthing();
        }

        private void choosetagsys_Click(object sender, EventArgs e)
        {
            FrmTagSystem frm = new FrmTagSystem();
            frm.ShowDialog(this);
        }

        private void origfile_Click(object sender, EventArgs e)
        {
            int i, j, tx = 0;
            bool bj = true;
            string sys = Path.GetFileName(Path.GetDirectoryName(Path.GetDirectoryName(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]])));
            string tarName = Path.GetFileName(Gib.rbfile);
            for ( i = 0; i < Gib.tsn; ++i )
                if ("Tag - " + Gib.ts[i].name == sys)
                {
                    tx = i;
                    break;
                }
            for ( i = 0; i < Gib.ts[tx].ftagn; ++i )
                if (Path.GetFileName(Gib.ts[tx].ftagpath[i]) == Path.GetFileName(Gib.rbfile) && File.Exists(Gib.ts[tx].ftagpath[i]))
                {
                    Gib.fpos[Gib.nowtab, ++Gib.nowp[Gib.nowtab]] =
                        Path.GetDirectoryName(Gib.ts[tx].ftagpath[i]);
                    Gib.maxn[Gib.nowtab] = Gib.maxn[Gib.nowtab] > Gib.nowp[Gib.nowtab]
                        ? Gib.maxn[Gib.nowtab]
                        : Gib.nowp[Gib.nowtab];
                    reffile(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]]);
                    if (Gib.nowtab == 1)
                    {
                        for (j = 0; j < filev1.Items.Count; ++j)
                            if (filev1.Items[j].Text == tarName)
                            {
                                filev1.SelectedItems.Clear();
                                filev1.TopItem = filev1.Items[j];
                                break;
                            }

                    }
                    Gib.fname = Path.GetFileName(Gib.ts[tx].ftagpath[i]);
                    isleftkey = true;
                    bj = false;
                    loadfile();
                    break;
                }
            if (bj)
                ToastNotification.Show(this, "未找到原文件", 2000);
        }

        int lsx;

        private void rightmenu_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void embackup_Click(object sender, EventArgs e)
        {
            dobackup = true;
            closingthing();
        }

        private void filenote_Click(object sender, EventArgs e)
        {
            FrmFileNote frm = new FrmFileNote();
            frm.ShowDialog(this);
        }

        private string bdir;
        private void backup()
        {
            backt.Enabled = true;
            bdir = "C:\\ProgramData\\CW Soft\\CW File Viewer\\Backup\\" + DateTime.Now.ToString("yyyy-MM-dd") +
                            ' ' + DateTime.Now.Hour.ToString("00") + '：' +
                            DateTime.Now.Minute.ToString("00") + '：' + DateTime.Now.Second.ToString("00");
            Directory.CreateDirectory(bdir);
            bdir = bdir + "\\";
        }
        private void backt_Tick(object sender, EventArgs e)
        {
            DirectoryInfo dinfo = new DirectoryInfo("C:\\ProgramData\\CW Soft\\CW File Viewer\\TagSystem");
            FileSystemInfo[] fsinfos = dinfo.GetFileSystemInfos();
            try
            {
                foreach (FileSystemInfo fsinfo in fsinfos)
                    if (fsinfo is DirectoryInfo)
                    {
                        if (!Directory.Exists(bdir + fsinfo.Name))
                            Directory.CreateDirectory(bdir + fsinfo.Name);
                        if (!File.Exists(bdir + fsinfo.Name + "\\TagPath.txt"))
                            File.Copy(
                                "C:\\ProgramData\\CW Soft\\CW File Viewer\\TagSystem\\" + fsinfo.Name + "\\TagPath.txt",
                                bdir + fsinfo.Name + "\\TagPath.txt");
                        if (!File.Exists(bdir + fsinfo.Name + "\\TagName.txt"))
                            File.Copy(
                                "C:\\ProgramData\\CW Soft\\CW File Viewer\\TagSystem\\" + fsinfo.Name + "\\TagName.txt",
                                bdir + fsinfo.Name + "\\TagName.txt");
                        if (!File.Exists(bdir + fsinfo.Name + "\\AllTag.txt"))
                            File.Copy(
                                "C:\\ProgramData\\CW Soft\\CW File Viewer\\TagSystem\\" + fsinfo.Name + "\\AllTag.txt",
                                bdir + fsinfo.Name + "\\AllTag.txt");
                        if (!File.Exists(bdir + fsinfo.Name + "\\AllTag.txt"))
                            File.Copy(
                                "C:\\ProgramData\\CW Soft\\CW File Viewer\\TagSystem\\" + fsinfo.Name + "\\AllPage.txt",
                                bdir + fsinfo.Name + "\\AllPage.txt");
                        if (!File.Exists(bdir + fsinfo.Name + "\\TagPage.txt"))
                            File.Copy(
                                "C:\\ProgramData\\CW Soft\\CW File Viewer\\TagSystem\\" + fsinfo.Name + "\\TagPage.txt",
                                bdir + fsinfo.Name + "\\TagPage.txt");
                        if (!Directory.Exists(bdir + fsinfo.Name + "\\TagInfo"))
                            CopyFolder(
                                "C:\\ProgramData\\CW Soft\\CW File Viewer\\TagSystem\\" + fsinfo.Name + "\\TagInfo",
                                bdir + fsinfo.Name + "\\TagInfo");
                    }
                File.Copy("C:\\ProgramData\\CW Soft\\CW File Viewer\\Collection.txt", bdir + "Collection.txt");
                backt.Enabled = false;
            }
            catch
            {
                backt.Enabled = true;
            }
        }

        private void ordertaginfo_Click(object sender, EventArgs e)
        {
            string name = "C:\\CW File Viewer\\TagInfo\\Tag - " + Gib.ts[Gib.nowsysi].name;
            if (!Directory.Exists(name))
                Directory.CreateDirectory(name);
            for (int i = 0; i < Gib.ts[Gib.nowsysi].tagn; ++i)
                if (Gib.ts[Gib.nowsysi].taginfo[i] != null && Gib.ts[Gib.nowsysi].taginfo[i].Trim() != "")
                {
                    if (!Directory.Exists(name + '\\' + Gib.ts[Gib.nowsysi].allpage[Gib.ts[Gib.nowsysi].tagp[i]]))
                        Directory.CreateDirectory(name + '\\' + Gib.ts[Gib.nowsysi].allpage[Gib.ts[Gib.nowsysi].tagp[i]]);
                    File.WriteAllText(
                        name + '\\' + Gib.ts[Gib.nowsysi].allpage[Gib.ts[Gib.nowsysi].tagp[i]] +
                        "\\" + Gib.ts[Gib.nowsysi].alltag[i] + ".txt", Gib.ts[Gib.nowsysi].taginfo[i],
                        Encoding.GetEncoding("GB2312"));
                }
        }


        private void lrcvfocuser_Tick(object sender, EventArgs e)
        {
            lrcvfocuser.Enabled = false;
            lrcv.Focus();
        }

        private void filehighlight_CheckedChanged(object sender, EventArgs e)
        {
            Gib.settings[3] = Convert.ToInt32(filehighlight.Checked);
        }

        private void cancelsearch_Click(object sender, EventArgs e)
        {
            putinfilev();
        }

        private void searchfilev_Click(object sender, EventArgs e)
        {
            putinfilevwithsearch();
        }

        private void textwork_Click(object sender, EventArgs e)
        {
            Gib.ftextinter = false;
            FrmText frm = new FrmText();
            frm.ShowDialog(this);
        }

        private void tschooser_SelectedIndexChanged(object sender, EventArgs e)
        {
            Gib.nowsysi = (int)((ComboBoxItem)this.tschooser.SelectedItem).Tag;
        }

        public void refreshts()
        {
            tschooser.Items.Clear();
            for (int i = 0; i < Gib.tsn; ++i)
            {
                ComboBoxItem page = new ComboBoxItem();
                page.Text = Gib.ts[i].name;
                page.Tag = i;
                tschooser.Items.Add(page);
            }
            tschooser.SelectedIndex = Gib.nowsysi;
        }

        private void UseFormatForm_CheckedChanged(object sender, EventArgs e)
        {
            Gib.settings[4] = Convert.ToInt32(UseFormatForm.Checked);
        }

        private void ShowTXT_CheckedChanged(object sender, EventArgs e)
        {
            if (Gib.nowp[Gib.nowtab] > 0)
                reffile(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]]);
        }

        private void ShowNote_CheckedChanged(object sender, EventArgs e)
        {
            if (Gib.nowp[Gib.nowtab] > 0)
                reffile(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]]);
        }

        private void rbrename_Click(object sender, EventArgs e)
        {
            Gib.crossfile1 = Gib.rbfile;
            FrmRename frm = new FrmRename();
            frm.ShowDialog(this);
        }

        private void lrcv_SelectionChanged(object sender, EventArgs e)
        {
            ++Gib.lrcvSelectedState;
        }

        private void 查找ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFind frm = new FrmFind();
            frm.Show(this);
        }

        private void 文本操作ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gib.ftextinter = false;
            FrmText frm = new FrmText();
            frm.ShowDialog(this);
        }
    }
}
/*
 catch (Exception Ex) { if ( MessageBoxEx.Show(this, Ex.ToString(), "错误！点Cancel复制消息。", MessageBoxButtons.OKCancel) == DialogResult.Cancel ) Clipboard.SetText(Ex.ToString()); }
 
 * 
 * publi static Icon GetIcon(string fileName, bool isLargeIcon)
        {
            SHFILEINFO shfi = new SHFILEINFO();
            IntPtr hI;
            if (isLargeIcon)
                hI = SHGetFileInfo(fileName, 0, ref shfi, (uint)Marshal.SizeOf(shfi), (uint)FileInfoFlags.SHGFI_ICON | (uint)FileInfoFlags.SHGFI_USEFILEATTRIBUTES | (uint)FileInfoFlags.SHGFI_LARGEICON);
            else
                hI = SHGetFileInfo(fileName, 0, ref shfi, (uint)Marshal.SizeOf(shfi), (uint)FileInfoFlags.SHGFI_ICON | (uint)FileInfoFlags.SHGFI_USEFILEATTRIBUTES | (uint)FileInfoFlags.SHGFI_SMALLICON);
            Icon icon = Icon.FromHandle(shfi.hIcon).Clone() as Icon;
            DestroyIcon(shfi.hIcon); //释放资源
            return icon;
        }
        /// <summary>  
        /// 获取文件夹图标
        /// </summary>  
        /// <returns>图标</returns>  
        public static Icon GetDirectoryIcon(bool isLargeIcon)
        {
            SHFILEINFO _SHFILEINFO = new SHFILEINFO();
            IntPtr _IconIntPtr;
            if (isLargeIcon)
            {
                _IconIntPtr = SHGetFileInfo(@"", 0, ref _SHFILEINFO, (uint)Marshal.SizeOf(_SHFILEINFO), ((uint)FileInfoFlags.SHGFI_ICON | (uint)FileInfoFlags.SHGFI_LARGEICON));
            }
            else
            {
                _IconIntPtr = SHGetFileInfo(@"", 0, ref _SHFILEINFO, (uint)Marshal.SizeOf(_SHFILEINFO), ((uint)FileInfoFlags.SHGFI_ICON | (uint)FileInfoFlags.SHGFI_SMALLICON));
            }
            if (_IconIntPtr.Equals(IntPtr.Zero)) return null;
            Icon _Icon = System.Drawing.Icon.FromHandle(_SHFILEINFO.hIcon);
            return _Icon;
        }
 char[] cs = yourstring.ToCharArray();
StreamReader sr = new StreamReader("TestFile.txt")//StreamReader sr = new StreamReader("TestFile.txt",Encoding.GetEncoding("GB2312"))
///GBK
String line;
while ((line = sr.ReadLine()) != null)
{
   textBox1 .Text +=ii.ToString ()+" -"+line.ToString()+"\r\n";

}
加入引用：System.IO
StreamReader objReader = new StreamReader("c:\\test.txt");
     System.IO 命名空间中的对象，尤其是 System.IO.StreamReader 类。

\r\n一般一起用,用来表示键盘上的回车键.也可只用\n.\t表示键盘上的“TAB
*/