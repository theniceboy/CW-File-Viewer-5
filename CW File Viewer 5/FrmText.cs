using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace CW_File_Viewer_5
{
    public partial class FrmText : DevComponents.DotNetBar.Metro.MetroForm
    {
        private FrmMain frm;
        private int nowtab = 1, len;
        private string str;

        public FrmText()
        {
            InitializeComponent();
        }

        void work1()
        {
            text.Text = text.Text.Replace("\r\n", "\n");
            rt.Text = rt.Text.Replace("\r\n", "\n");
            str = str.Replace(text.Text, rt.Text);
        }

        private void repace(int index, char x, char y)
        {
            int i;
            for (i = index; i < len; ++i )
            {
                
            }
        }

        void work2()
        {
        }

        private void work_Click(object sender, EventArgs e)
        {
            frm = (FrmMain)this.Owner;

            if (Gib.ftextinter)
                str = Gib.ftextinterstr;
            else
                str = frm.lrcv.Text;
            len = str.Length;

            if (nowtab == 1)
                work1();
            else
                work2();

            if (!Gib.ftextinter)
                frm.lrcv.Text = str;

            this.Close();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmText_Load(object sender, EventArgs e)
        {

        }

        private void tab1_Click(object sender, EventArgs e)
        {
            nowtab = 1;
        }

        private void tab2_Click(object sender, EventArgs e)
        {
            nowtab = 2;
        }
    }
}