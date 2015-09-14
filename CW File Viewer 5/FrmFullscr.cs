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
            if (Gib.last.ToLower() == ".txt" || Gib.last.ToLower() == ".cfvnote" || Gib.last.ToLower() == ".lrc" ||
                Gib.last.ToLower() == ".cst1" || Gib.last.ToLower() == ".cst2" || Gib.last.ToLower() == ".cst3" ||
                Gib.last.ToLower() == ".his")
            {
                try
                {
                    lrcv.LoadFile(Gib.txtpath, RichTextBoxStreamType.PlainText);
                }
                catch
                {
                    try
                    {
                        lrcv.LoadFile(Gib.txtpath, RichTextBoxStreamType.RichText);
                    }
                    catch
                    {
                    }
                }
            }
            else if (Gib.last.ToLower() == ".rtf")
            {
                try
                {
                    lrcv.LoadFile(Gib.txtpath, RichTextBoxStreamType.RichText);
                }
                catch
                {
                    try
                    {
                        lrcv.LoadFile(Gib.txtpath, RichTextBoxStreamType.PlainText);
                    }
                    catch
                    {
                    }
                }
            }
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