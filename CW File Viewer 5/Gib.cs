using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DevComponents.DotNetBar;

namespace CW_File_Viewer_5
{
    internal class Gib
    {
        /*
         * c : class
         * f : place
        */
        public static int[] settings = new int[5];
        public static int settingl;

        public static string fname, nfname, last, infile = "", backup = "", crossfile1, crossfile2, crossfile3, crossfile4, crossfile5;
        public static string copypath, copyfn, ppath, pname, plast, ptext, txtpath, rtff;
        public static string rbfile;
        public static string[,] fpos = new string[4, 1000];
        public static int[,] lpos = new int[4, 1000];
        //public static bool[,] fch = new bool[5, 1000];

        public static ButtonItem rbcol = new ButtonItem();

        public static ButtonX crossbutton1 = new ButtonX();

        public static string[,] cname = new string[4, 50000];
        public static string[,] cpath = new string[4, 50000];
        public static string[,] clast = new string[4, 50000];
        public static int[,] cmode = new int[4, 50000]; //1:file  2:folder
        public static int[] fsum = new int[4];

        public static string[] collects = new string[1000];
        public static int collectn;

        //public static string defsys, nowtagsys, usesys = null;
        public static int nowsysi, defsysi;

        public const int TS_Max_Num = 30;
        public struct tagsys
        {
            public int ftagn;
            public string[] ftagpath;
            public string[,] ftagname;
            public int[] ftags;

            public int tagn;
            public int[] tagp;
            public string[] alltag;
            public string[] taginfo;

            public int pagen;
            public string[] allpage;

            public string name;
        }

        public static tagsys[] ts = new tagsys[TS_Max_Num];
        public static int tsn = 0;

        public static string[] hispath = new string[100000];
        public static int hissum;

        public static bool firsto, isheng = true;
        public static int cpmode; //1:file  2:folder
        public static bool cpiscut;

        public static int[] nowp = new int[5];
        public static int[] maxn = new int[5];

        public static int p, lasa, wsize = 12, smode = 1, mx, my, nowtab = 1, pstate = 2; //pstate  1:play , 2:pause

        public static bool isfullscr = false, fullscr = false;

        public static string selecttext = "";

        public static int nowcrst = 0;

        public static int crossnum1, crossnum2;

        public static int autosavet = 1;
        public static bool useast = true;

        public static bool doshowtag = false;
        
        public static bool dochoosetag = false;
        public static int choosedtagn;
        public static string[] choosedtags = new string[5000];

        public static bool ftextinter;
        public static string ftextinterstr;

        public static bool ftaglocked = false, TextFormatFormOpened;
    }
}

/*

if (Gib.nowtab == 1)
else if (Gib.nowtab == 2)
else

*/