using System;
using System.Drawing;
using System.Windows.Forms;

namespace CW_File_Viewer_5
{
    public partial class FrmFullscr : DevComponents.DotNetBar.Metro.MetroAppForm
    {
        public FrmFullscr()
        {
            InitializeComponent();
        }

        private void lrcv_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmFullscr_Load(object sender, EventArgs e)
        {
            FrmMain frm = new FrmMain();
            if(frm.goodsort.Checked==true)
                rtfv.LoadFile(Gib.rtff, RichTextBoxStreamType.RichText);
            else
                lrcv.Text = Gib.infile;
        }

        private void rtfv_TextChanged(object sender, EventArgs e)
        {

        }

        private void fsbig_Click(object sender, EventArgs e)
        {
            lrcv.Font = new Font(lrcv.Font.Name, 22);
            wtsize.Value = 22;
        }

        private void fssmall_Click(object sender, EventArgs e)
        {
            lrcv.Font = new Font(lrcv.Font.Name, 12);
            wtsize.Value = 12;
        }

        private void wtsize_ValueChanged(object sender, EventArgs e)
        {
            lrcv.Font = new Font(lrcv.Font.Name, wtsize.Value);
        }
    }
}