using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;
using DevComponents.DotNetBar;

namespace CW_File_Viewer_5
{
    public partial class FrmBegin : DevComponents.DotNetBar.RibbonForm
    {
        public FrmBegin()
        {
            InitializeComponent();
        }

        private int v;
        private string ver = "7";


        private void CopyFolder(string from, string to)
        {
            if (!Directory.Exists(to))
                Directory.CreateDirectory(to);

            // 文件
            string[] str = Directory.GetFiles(from);
            foreach (string file in str)
                File.Copy(file, to + '\\' + Path.GetFileName(file), true);

            // 子文件夹
            str = Directory.GetDirectories(from);
            foreach (string folder in str)
                CopyFolder(folder, to + '\\' + Path.GetFileName(folder));
        }

        private void backup()
        {
            try
            {
                string dir = "C:\\ProgramData\\CW Soft\\CW File Viewer\\Backup\\" + DateTime.Now.ToString("yyyy-MM-dd") +
                             ' ' + DateTime.Now.Hour.ToString("00") + '：' +
                             DateTime.Now.Minute.ToString("00") + '：' + DateTime.Now.Second.ToString("00");
                Directory.CreateDirectory(dir);
                dir = dir + "\\";
                DirectoryInfo dinfo = new DirectoryInfo("C:\\ProgramData\\CW Soft\\CW File Viewer\\TagSystem");
                FileSystemInfo[] fsinfos = dinfo.GetFileSystemInfos();

                foreach (FileSystemInfo fsinfo in fsinfos)
                    if (fsinfo is DirectoryInfo)
                    {
                        if (!Directory.Exists(dir + fsinfo.Name))
                            Directory.CreateDirectory(dir + fsinfo.Name);
                        File.Copy(
                            "C:\\ProgramData\\CW Soft\\CW File Viewer\\TagSystem\\" + fsinfo.Name + "\\TagPath.txt",
                            dir + fsinfo.Name + "\\TagPath.txt");
                        File.Copy(
                            "C:\\ProgramData\\CW Soft\\CW File Viewer\\TagSystem\\" + fsinfo.Name + "\\TagName.txt",
                            dir + fsinfo.Name + "\\TagName.txt");
                        File.Copy(
                            "C:\\ProgramData\\CW Soft\\CW File Viewer\\TagSystem\\" + fsinfo.Name + "\\AllTag.txt",
                            dir + fsinfo.Name + "\\AllTag.txt");
                        File.Copy(
                            "C:\\ProgramData\\CW Soft\\CW File Viewer\\TagSystem\\" + fsinfo.Name + "\\AllPage.txt",
                            dir + fsinfo.Name + "\\AllPage.txt");
                        File.Copy(
                            "C:\\ProgramData\\CW Soft\\CW File Viewer\\TagSystem\\" + fsinfo.Name + "\\TagPage.txt",
                            dir + fsinfo.Name + "\\TagPage.txt");
                        CopyFolder("C:\\ProgramData\\CW Soft\\CW File Viewer\\TagSystem\\" + fsinfo.Name + "\\TagInfo",
                            dir + fsinfo.Name + "\\TagInfo");
                    }
                File.Copy("C:\\ProgramData\\CW Soft\\CW File Viewer\\Collection.txt", dir + "Collection.txt");
            }
            catch
            {
            }
        }

        private int MAX_TAG_NUM = 5000, SINGLE_FILE_TAB_NUM = 50;

        private void loadtag()
        {
            for (int i = 0; i < Gib.TS_Max_Num; ++i)
            {
                Gib.ts[i].ftagn = 0;
                Gib.ts[i].ftagpath = new string[50000];
                Gib.ts[i].ftagname = new string[50000, SINGLE_FILE_TAB_NUM];
                Gib.ts[i].ftags = new int[50000];

                Gib.ts[i].tagn = 0;
                Gib.ts[i].tagp = new int[MAX_TAG_NUM];
                Gib.ts[i].alltag = new string[MAX_TAG_NUM];
                Gib.ts[i].taginfo = new string[MAX_TAG_NUM];

                Gib.ts[i].pagen = 0;
                Gib.ts[i].allpage = new string[100];

                Gib.ts[i].name = null;
            }
            Gib.nowsysi =
                Gib.defsysi =
                    Convert.ToInt32(
                        File.ReadAllText("C:\\ProgramData\\CW Soft\\CW File Viewer\\DefaultTagSystem.txt"));
            Gib.tsn = 0;
            DirectoryInfo dir = new DirectoryInfo("C:\\ProgramData\\CW Soft\\CW File Viewer\\TagSystem");
            FileSystemInfo[] files = dir.GetFileSystemInfos();
            foreach (FileSystemInfo file in files)
                if (file is DirectoryInfo)
                {
                    if (
                        !Directory.Exists("C:\\ProgramData\\CW Soft\\CW File Viewer\\TagSystem\\" + file.Name +
                                          "\\TagInfo"))
                        Directory.CreateDirectory("C:\\ProgramData\\CW Soft\\CW File Viewer\\TagSystem\\" + file.Name +
                                                  "\\TagInfo");

                    int i, j, l;
                    /*
                    if (Gib.usesys == null)
                        Gib.usesys = Gib.defsys;
                    if (Gib.nowtagsys == null)
                        Gib.nowtagsys = Gib.defsys;
                    else
                        Gib.nowtagsys = Gib.usesys;
                     */
                    Gib.ts[Gib.tsn].name = file.Name;

                    Gib.ts[Gib.tsn].ftagn = 0;
                    StreamReader sftagpath =
                        new StreamReader("C:\\ProgramData\\CW Soft\\CW File Viewer\\TagSystem\\" + file.Name +
                                         "\\TagPath.txt");
                    while ((Gib.ts[Gib.tsn].ftagpath[Gib.ts[Gib.tsn].ftagn++] = sftagpath.ReadLine()) != null)
                    {
                    }
                    --Gib.ts[Gib.tsn].ftagn;
                    sftagpath.Close();
                    sftagpath.Dispose();

                    Gib.txtpath = "";

                    Gib.ts[Gib.tsn].tagn = 0;
                    StreamReader salltag =
                        new StreamReader("C:\\ProgramData\\CW Soft\\CW File Viewer\\TagSystem\\" + file.Name +
                                         "\\AllTag.txt");
                    while ((Gib.ts[Gib.tsn].alltag[Gib.ts[Gib.tsn].tagn++] = salltag.ReadLine()) != null)
                    {
                    }
                    --Gib.ts[Gib.tsn].tagn;
                    salltag.Close();
                    salltag.Dispose();

                    string[] readstr =
                        File.ReadAllLines("C:\\ProgramData\\CW Soft\\CW File Viewer\\TagSystem\\" + file.Name +
                                          "\\TagName.txt");
                    for (i = 0; i < Gib.ts[Gib.tsn].ftagn; ++i)
                    {
                        l = readstr[i].Length;
                        Gib.ts[Gib.tsn].ftags[i] = 0;
                        for (j = 0; j < l; ++j)
                        {
                            if (readstr[i][j] == '\\')
                                ++Gib.ts[Gib.tsn].ftags[i];
                            else
                                Gib.ts[Gib.tsn].ftagname[i, Gib.ts[Gib.tsn].ftags[i]] += readstr[i][j].ToString();
                        }
                    }

                    if (v > 1)
                    {
                        StreamReader sftabpage =
                            new StreamReader("C:\\ProgramData\\CW Soft\\CW File Viewer\\TagSystem\\" + file.Name +
                                             "\\TagPage.txt");
                        for (i = 0; i < Gib.ts[Gib.tsn].tagn; ++i)
                            Gib.ts[Gib.tsn].tagp[i] = Convert.ToInt32(sftabpage.ReadLine());
                        sftabpage.Close();
                        sftabpage.Dispose();
                    }

                    if (v > 1)
                    {
                        Gib.ts[Gib.tsn].pagen = 0;
                        StreamReader sfallpage =
                            new StreamReader("C:\\ProgramData\\CW Soft\\CW File Viewer\\TagSystem\\" + file.Name +
                                             "\\AllPage.txt");
                        while ((Gib.ts[Gib.tsn].allpage[Gib.ts[Gib.tsn].pagen++] = sfallpage.ReadLine()) != null)
                        {
                        }
                        --Gib.ts[Gib.tsn].pagen;
                        sfallpage.Close();
                        sfallpage.Dispose();
                    }

                    if (v < 3)
                    {
                        for (i = 0; i < Gib.ts[Gib.tsn].tagn; ++i)
                            File.Create("C:\\ProgramData\\CW Soft\\CW File Viewer\\TagSystem\\" + file.Name +
                                        "\\TagInfo\\" + Gib.ts[Gib.tsn].alltag[i] + ".txt");
                    }
                    else
                    {
                        DirectoryInfo dinfo =
                            new DirectoryInfo("C:\\ProgramData\\CW Soft\\CW File Viewer\\TagSystem\\" + file.Name +
                                              "\\TagInfo");
                        FileSystemInfo[] fsinfos = dinfo.GetFileSystemInfos();
                        string str;
                        foreach (FileSystemInfo fsinfo in fsinfos)
                            if (fsinfo is FileInfo)
                            {
                                str = Path.GetFileNameWithoutExtension(fsinfo.Name);
                                for (i = 0; i < Gib.ts[Gib.tsn].tagn; ++i)
                                    if (Gib.ts[Gib.tsn].alltag[i] == str)
                                    {
                                        Gib.ts[Gib.tsn].taginfo[i] = File.ReadAllText(fsinfo.FullName, Encoding.GetEncoding("GB2312"));
                                        break;
                                    }
                            }
                    }

                    ++Gib.tsn;
                }
        }

        void updateVersion()
        {
            v = Convert.ToInt32(File.ReadAllText("C:\\ProgramData\\CW Soft\\CW File Viewer\\Version.txt"));
            if (v < 2)
            {
                for (int i = 0; i < Gib.TS_Max_Num; ++i)
                {
                    Gib.ts[i].ftagn = 0;
                    Gib.ts[i].ftagpath = new string[50000];
                    Gib.ts[i].ftagname = new string[50000, SINGLE_FILE_TAB_NUM];
                    Gib.ts[i].ftags = new int[50000];

                    Gib.ts[i].tagn = 0;
                    Gib.ts[i].tagp = new int[MAX_TAG_NUM];
                    Gib.ts[i].alltag = new string[MAX_TAG_NUM];
                    Gib.ts[i].taginfo = new string[MAX_TAG_NUM];

                    Gib.ts[i].pagen = 0;
                    Gib.ts[i].allpage = new string[100];

                    Gib.ts[i].name = null;
                }
                Gib.tsn = 0;
                Gib.tsn = 1;
                Gib.ts[0].pagen = 1;
                Gib.ts[0].allpage[0] = "默认";
                File.WriteAllText("C:\\ProgramData\\CW Soft\\CW File Viewer\\Settings.txt", "1\n1");
            }
            if (v < 4)
            {
                string[] ls1 = File.ReadAllLines("C:\\ProgramData\\CW Soft\\CW File Viewer\\Settings.txt");
                string[] ls2 = new string[3];
                ls2[0] = ls1[0];
                ls2[1] = ls1[1];
                ls2[2] = "1";
                File.WriteAllLines("C:\\ProgramData\\CW Soft\\CW File Viewer\\Settings.txt",ls2);
                Gib.settings[2] = 1;
            }
            if (v < 6)
            {
                string[] ls1 = File.ReadAllLines("C:\\ProgramData\\CW Soft\\CW File Viewer\\Settings.txt");
                string[] ls2 = new string[4];
                ls2[0] = ls1[0];
                ls2[1] = ls1[1];
                ls2[2] = ls1[2];
                ls2[3] = "1";
                File.WriteAllLines("C:\\ProgramData\\CW Soft\\CW File Viewer\\Settings.txt", ls2);
                Gib.settings[3] = 1;
            }
            if (v < 7)
            {
                string[] ls1 = File.ReadAllLines("C:\\ProgramData\\CW Soft\\CW File Viewer\\Settings.txt");
                string[] ls2 = new string[5];
                ls2[0] = ls1[0];
                ls2[1] = ls1[1];
                ls2[2] = ls1[2];
                ls2[3] = ls1[3];
                ls2[4] = "1";
                File.WriteAllLines("C:\\ProgramData\\CW Soft\\CW File Viewer\\Settings.txt", ls2);
                Gib.settings[4] = 1;
            }
            //try
            //{
            File.WriteAllText("C:\\ProgramData\\CW Soft\\CW File Viewer\\Version.txt", ver);
                //StreamWriter vr = new StreamWriter("C:\\ProgramData\\CW Soft\\CW File Viewer\\Version.txt", false);
                //vr.WriteLine("3");
            //}
            //catch (Exception ex)
            //{
            //    MessageBoxEx.Show(ex.ToString());
            //}
        }
        
        void newcomputer()
        {
            Directory.CreateDirectory("C:\\ProgramData\\CW Soft\\CW File Viewer");
            Directory.CreateDirectory("C:\\ProgramData\\CW Soft\\CW File Viewer\\Backup");
            Directory.CreateDirectory("C:\\ProgramData\\CW Soft\\CW File Viewer\\Dir");
            Directory.CreateDirectory("C:\\ProgramData\\CW Soft\\CW File Viewer\\EmergencyRealTimeBackup");
            Directory.CreateDirectory("C:\\ProgramData\\CW Soft\\CW File Viewer\\RecycleBin");
            Directory.CreateDirectory("C:\\ProgramData\\CW Soft\\CW File Viewer\\TagSystem");
            File.Create("C:\\ProgramData\\CW Soft\\CW File Viewer\\Collection.txt");
            File.WriteAllText("C:\\ProgramData\\CW Soft\\CW File Viewer\\DefaultTagSystem.txt", "0");
            File.Create("C:\\ProgramData\\CW Soft\\CW File Viewer\\Temp.txt");
            File.Create("C:\\ProgramData\\CW Soft\\CW File Viewer\\TempPath.txt");
            File.WriteAllText("C:\\ProgramData\\CW Soft\\CW File Viewer\\Version.txt", ver);
            Directory.CreateDirectory("C:\\ProgramData\\CW Soft\\CW File Viewer\\TagSystem\\默认");
            File.Create("C:\\ProgramData\\CW Soft\\CW File Viewer\\TagSystem\\默认\\AllPage.txt");
            File.Create("C:\\ProgramData\\CW Soft\\CW File Viewer\\TagSystem\\默认\\AllTag.txt");
            File.Create("C:\\ProgramData\\CW Soft\\CW File Viewer\\TagSystem\\默认\\TagPage.txt");
            File.Create("C:\\ProgramData\\CW Soft\\CW File Viewer\\TagSystem\\默认\\TagName.txt");
            File.Create("C:\\ProgramData\\CW Soft\\CW File Viewer\\TagSystem\\默认\\TagPath.txt");
            Directory.CreateDirectory("C:\\ProgramData\\CW Soft\\CW File Viewer\\TagSystem\\默认\\TagInfo");
            FrmMain frm = (FrmMain)this.Owner;
            frm.initsettings();
        }

        void load()
        {
            Gib.hissum = 0;
            Gib.infile = "";
            Gib.copypath = "Null";
            Gib.nowp[0] = Gib.nowp[1] = Gib.nowp[2] = Gib.nowp[3] = Gib.nowp[4] = 0;
            for (int i = 1; i <= 3; ++i)
                for (int j = 0; j < 3; ++j)
                    Gib.fpos[i, j] = "";
            Gib.firsto = true;
            if (!Directory.Exists("C:\\ProgramData\\CW Soft"))
                Directory.CreateDirectory("C:\\ProgramData\\CW Soft");
            if (!Directory.Exists("C:\\ProgramData\\CW Soft\\CW File Viewer"))
                newcomputer();


            if (File.Exists("C:\\ProgramData\\CW Soft\\CW File Viewer\\Temp.txt") == false)
            {
                //if (Directory.Exists("C:\\ProgramData\\CW Soft") == false)
                //    Directory.CreateDirectory("C:\\ProgramData\\CW Soft");
                if (Directory.Exists("C:\\ProgramData\\CW Soft\\CW File Viewer") == false)
                    Directory.CreateDirectory("C:\\ProgramData\\CW Soft\\CW File Viewer");
                File.Create("C:\\ProgramData\\CW Soft\\CW File Viewer\\Temp.txt");
            }
            if (Directory.Exists("C:\\ProgramData\\CW Soft\\CW File Viewer\\Dic") == false)
                Directory.CreateDirectory("C:\\ProgramData\\CW Soft\\CW File Viewer\\Dic");
            if (Directory.Exists("C:\\ProgramData\\CW Soft\\CW File Viewer\\RecycleBin") == false)
                Directory.CreateDirectory("C:\\ProgramData\\CW Soft\\CW File Viewer\\RecycleBin");
            if (Directory.Exists("C:\\ProgramData\\CW Soft\\CW File Viewer\\Backup") == false)
                Directory.CreateDirectory("C:\\ProgramData\\CW Soft\\CW File Viewer\\Backup");
            if (Directory.Exists("C:\\CW File Viewer\\Tag 2") == false)
                Directory.CreateDirectory("C:\\CW File Viewer\\Tag 2");
            if(File.Exists("C:\\ProgramData\\CW Soft\\CW File Viewer\\Version.txt")==false)
                File.WriteAllText("C:\\ProgramData\\CW Soft\\CW File Viewer\\Version.txt", "1");
            if (Directory.Exists("C:\\ProgramData\\CW Soft\\CW File Viewer\\TagSystem") == false)
                Directory.CreateDirectory("C:\\ProgramData\\CW Soft\\CW File Viewer\\TagSystem");
            if (Directory.Exists("C:\\ProgramData\\CW Soft\\CW File Viewer\\EmergencyRealTimeBackup") == false)
                Directory.CreateDirectory("C:\\ProgramData\\CW Soft\\CW File Viewer\\EmergencyRealTimeBackup");
            if(File.Exists("C:\\ProgramData\\CW Soft\\CW File Viewer\\TextWorkTag.txt")==false)
                File.WriteAllText("C:\\ProgramData\\CW Soft\\CW File Viewer\\TextWorkTag.txt", "");
            //if (Directory.Exists("C:\\ProgramData\\CW Soft\\CW File Viewer\\TagMinBackup") == false)
            //    Directory.CreateDirectory("C:\\ProgramData\\CW Soft\\CW File Viewer\\TagMinBackup");
            updateVersion();
            backup();
            loadtag();
        }

        private void first_Tick(object sender, EventArgs e)
        {
            first.Enabled = false;
            Thread tload = new Thread(load);
            tload.Start();
            while (tload.IsAlive) { }
            this.Close();
        }

        private void FrmBegin_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists("C:\\ProgramData\\CW Soft"))
                Directory.CreateDirectory("C:\\ProgramData\\CW Soft");
        }
    }
}