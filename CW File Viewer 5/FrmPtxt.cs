using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using DevComponents.DotNetBar;

namespace CW_File_Viewer_5
{
    public partial class FrmPtxt : Form
    {
        int lx, ly, fx, fy;
        string infile;
        public FrmPtxt()
        {
            InitializeComponent();
        }
        public static int X2 = 0;
        public static int Y2 = 0;
        public static int X1 = 0;
        public static int Y1 = 0;
        private void tmv_Tick(object sender, EventArgs e)
        {
            //MessageBoxEx.Show(X1.ToString() + '\n' + Y1.ToString() + '\n' + X2.ToString() + '\n' + Y2.ToString());
            if (X1 == 0 && Y1 == 0)
            {
                X1 = Control.MousePosition.X;
                Y1 = Control.MousePosition.Y;
            }
            X2 = Control.MousePosition.X;
            Y2 = Control.MousePosition.Y;

            if (X1 != X2 || Y1 != Y2)
            {
                X1 = X2;
                Y1 = Y2;
                Point spoint = Control.MousePosition;
                Point fpoint = this.PointToClient(Control.MousePosition);
                lx = spoint.X;
                ly = spoint.Y;
                fx = fpoint.X;
                fy = fpoint.Y;
                //MessageBoxEx.Show(lx.ToString() + '\n' + ly.ToString() + '\n' + fx.ToString() + '\n' + fy.ToString() + '\n' + this.Size.Width + '\n' + this.Size.Height);
                if (Math.Abs(Gib.mx - lx) > 1 || Math.Abs(Gib.my - ly) > 1)
                    if (!(fx >= -5 && fx <= this.Size.Width + 5 && fy >= -5 && fy <= this.Size.Height + 5))
                        this.Close();
            }

        }
        /*
        private void FrmPtxt_MouseMove(object sender, MouseEventArgs e)
        {
            Point spoint = Control.MousePosition;
            Point fpoint = this.PointToClient(Control.MousePosition);
            lx = spoint.X;
            ly = spoint.Y;
            fx = fpoint.X;
            fy = fpoint.Y;
            MessageBoxEx.Show(lx.ToString() + '\n' + ly.ToString() + '\n' + fx.ToString() + '\n' + fy.ToString()+'\n'+this.Size.Width+'\n'+this.Size.Height);
            if(Math.Abs(Gib.mx-lx)>1 || Math.Abs(Gib.my-ly)>1)
            {
                //ClientRectangle 
                if (fx >= 0 && fx <= this.Size.Width && fy >= 0 && fy <= this.Size.Height)
                {
                    MessageBoxEx.Show("Close");
                }
                else
                {
                    FrmMain frm = (FrmMain)this.Owner;
                    frm.Close();
                }
            }
        }
        */


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

        private void FrmPtxt_Load(object sender, EventArgs e)
        {
            this.Left = Gib.mx;
            this.Top = Gib.my;

            //MessageBox.Show("Test");


            this.layoutmain.BackColor = Color.LightYellow;

            int i, x = -1;
            for (i = 0; i < Gib.ts[Gib.nowsysi].ftagn; ++i)
                if (Gib.ppath == Gib.ts[Gib.nowsysi].ftagpath[i])
                {
                    x = i;
                    break;
                }
            if (x > -1)
                for (i = 0; i < Gib.ts[Gib.nowsysi].ftags[x]; ++i)
                    if (Gib.ts[Gib.nowsysi].ftagname[x, i] != "")
                    {
                        ButtonX tagbutton = new ButtonX();
                        tagbutton.Font = new Font("Consolas", 8F);
                        tagbutton.Location = new Point(3, 3);
                        tagbutton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
                        tagbutton.Size = new Size(8*getlen(Gib.ts[Gib.nowsysi].ftagname[x, i]) + 10, 25);
                        tagbutton.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro;
                        tagbutton.FocusCuesEnabled = false;
                        tagbutton.Text = Gib.ts[Gib.nowsysi].ftagname[x, i];
                        layoutmain.Controls.Add(tagbutton);
                    }
            /*
            if (Gib.plast == ".lrc" || Gib.plast == ".LRC")
            {
                StreamReader fileread = new StreamReader(Gib.ppath);
                textprev.Text = fileread.ReadToEnd();
                fileread.Close();
            }
            else if (Gib.plast == ".txt" || Gib.plast == ".TXT")
            {
                StreamReader fileread = new StreamReader(Gib.ppath, Encoding.GetEncoding("GB2312"));
                textprev.Text = fileread.ReadToEnd();
                fileread.Close();
            }
            */
        }

        private void textprev_TextChanged(object sender, EventArgs e)
        {

        }

        private void tcanuse_Tick(object sender, EventArgs e)
        {
        }

        private void layoutmain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
