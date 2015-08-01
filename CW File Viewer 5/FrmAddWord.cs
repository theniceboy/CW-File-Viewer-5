using System;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace CW_File_Viewer_5
{
    public partial class FrmAddWord : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FrmAddWord()
        {
            InitializeComponent();
        }
        private void metroShell1_Click(object sender, EventArgs e)
        {

        }

        private void word_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void FrmAddWord_Load(object sender, EventArgs e)
        {
            word.Text = Gib.selecttext;
        }

        private void add_Click(object sender, EventArgs e)
        {
            File.WriteAllText("C:\\ProgramData\\CW Soft\\CW File Viewer\\Dic\\" + word.Text + ".txt", mean.Text);
            File.WriteAllText("C:\\ProgramData\\CW Soft\\CW File Viewer\\Dic\\" + mean.Text + ".txt", word.Text);
            this.Close();
        }
    }
}