using System;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.Speech.Synthesis;

namespace CW_File_Viewer_5
{
    public partial class FrmDic : Form
    {
        int lx, ly, fx, fy;
        int name;
        public FrmDic()
        {
            InitializeComponent();
        }

        SpeechSynthesizer spr = new SpeechSynthesizer();

        Thread tsp;
        void speek()
        {
            if (File.Exists("C:\\ProgramData\\CW Soft\\Speech\\" + word.Text.Trim() + ".mp3"))
                this.player.URL = "C:\\ProgramData\\CW Soft\\Speech\\" + word.Text.Trim() + ".mp3";
            else
                spr.Speak(word.Text);
        }


        string search(string word)
        {
            if (File.Exists("C:\\ProgramData\\CW Soft\\CW File Viewer\\Dic\\" + word + ".txt"))
                return File.ReadAllText("C:\\ProgramData\\CW Soft\\CW File Viewer\\Dic\\" + word + ".txt", Encoding.GetEncoding("GB2312"));
            else
                return "未添加本词解释";
        }

        private void FrmDic_Load(object sender, EventArgs e)
        {
            //MessageBoxEx.Show("Test");
            this.Left = Gib.mx;
            this.Top = Gib.my;
            word.Text = Gib.selecttext;
            mean.Text = search(word.Text);
            //spr.SelectVoice("Microsoft Anna");
            //spr.Speak(word.Text);
        }
        private void tmv_Tick(object sender, EventArgs e)
        {
            Point fpoint = this.PointToClient(Control.MousePosition);
            fx = fpoint.X;
            fy = fpoint.Y;
            if (fx < -10 || fx > this.Size.Width + 10 || fy < -10 || fy > this.Size.Height + 10)
            {
                //MessageBoxEx.Show(fx.ToString() + '\n' + fy.ToString());
                spr.Pause();
                tsp.Abort();
                this.Close();
            }
        }

        private void speaknow_Click(object sender, EventArgs e)
        {
            tsp = new Thread(new ThreadStart(speek));
            tsp.IsBackground = true;
            tsp.Name="tsp";
            tsp.Priority=ThreadPriority.Highest;
            tsp.Start();
        }

        private void flt_Tick(object sender, EventArgs e)
        {
            tsp = new Thread(new ThreadStart(speek));
            tsp.IsBackground = true;
            tsp.Name = "tsp";
            tsp.Priority = ThreadPriority.Highest;
            tsp.Start();
            flt.Enabled = false;
        }

        private void look_Click(object sender, EventArgs e)
        {
            mean.Text = search(word.Text);
            tsp = new Thread(new ThreadStart(speek));
            tsp.IsBackground = true;
            tsp.Name = "tsp";
            tsp.Priority = ThreadPriority.Highest;
            tsp.Start();
        }
    }
}
