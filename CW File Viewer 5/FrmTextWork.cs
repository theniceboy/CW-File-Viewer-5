using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace CW_File_Viewer_5
{
    public partial class FrmTextWork : DevComponents.DotNetBar.Metro.MetroAppForm
    {
        private bool Styled = false;

        private bool canclose = true;
        int lx, ly, fx, fy;
        private FontStyle style;
        private Font beginfont;
        private FrmMain frm;

        public FrmTextWork()
        {
            InitializeComponent();
        }

        private void FrmTextWork_Load(object sender, EventArgs e)
        {
            this.Left = Gib.mx;
            this.Top = Gib.my;
            Point fpoint = this.PointToClient(Control.MousePosition);
            fx = fpoint.X;
            fy = fpoint.Y;
            this.Opacity = CalcOpacity(fx, fy);
            Gib.TextFormatFormOpened = true;
            frm = (FrmMain) this.Owner;
            TextSize.Text = frm.lrcv.SelectionFont.Size.ToString();
            beginfont = frm.lrcv.SelectionFont;
            Bold.Checked = frm.lrcv.SelectionFont.Bold;
            Italic.Checked = frm.lrcv.SelectionFont.Italic;
            Underline.Checked = frm.lrcv.SelectionFont.Underline;
        }

        private void colorPicker_SelectedColorChanged(object sender, EventArgs e)
        {
            Styled = true;
            frm.lrcv.SelectionColor = colorPicker.SelectedColor;
        }

        private void FrmTextWork_FormClosing(object sender, FormClosingEventArgs e)
        {
            bool change = false;
            Gib.TextFormatFormOpened = false;
            if (Styled && Gib.last.ToLower() != ".rtf")
            {
                File.Delete(Gib.txtpath);
                Gib.txtpath = Path.GetDirectoryName(Gib.txtpath) + "\\" +
                              Path.GetFileNameWithoutExtension(Gib.txtpath) + ".rtf";
                Gib.last = ".rtf";
                change = true;
            }
            frm.lrcv.SaveFile(Gib.txtpath, RichTextBoxStreamType.RichText);
            if (change)
                frm.reffile(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]]);
        }

        private void DelFormat_Click(object sender, EventArgs e)
        {
            Bold.Checked = Italic.Checked = Underline.Checked = false;
            frm.lrcv.SelectionBackColor = Color.White;
            frm.lrcv.SelectionColor = Color.Black;
            frm.lrcv.SelectionFont = new Font(beginfont, new FontStyle());
        }

        private void TurnYellow_Click(object sender, EventArgs e)
        {
            Styled = true;
            frm.lrcv.SelectionBackColor = Color.Yellow;
        }

        private void TurnRed_Click(object sender, EventArgs e)
        {
            Styled = true;
            frm.lrcv.SelectionBackColor = Color.Red;
        }

        private void TurnPink_Click(object sender, EventArgs e)
        {
            Styled = true;
            frm.lrcv.SelectionBackColor = Color.HotPink;
        }

        private void ChooseFont_Click(object sender, EventArgs e)
        {
            Styled = true;
            style = new FontStyle();
            if (Bold.Checked)
                style = (FontStyle)(style | FontStyle.Bold);
            if (Italic.Checked)
                style = (FontStyle)(style | FontStyle.Italic);
            if (Underline.Checked)
                style = (FontStyle)(style | FontStyle.Underline);
            frm.lrcv.SelectionFont = new Font(frm.lrcv.SelectionFont, style);

            canclose = false;
            DialogResult result = fontDialog.ShowDialog(this);
            if (result != null)
                canclose = true;
            if (result == DialogResult.OK)
                frm.lrcv.SelectionFont = new Font(fontDialog.Font, style);
        }

        private void Style_Click(object sender, EventArgs e)
        {
            Styled = true;
            if (sender != null)
                ((ButtonX) sender).Checked = !((ButtonX) sender).Checked;
            style = new FontStyle();
            if (Bold.Checked)
                style = (FontStyle) (style | FontStyle.Bold);
            if (Italic.Checked)
                style = (FontStyle) (style | FontStyle.Italic);
            if (Underline.Checked)
                style = (FontStyle) (style | FontStyle.Underline);
            frm.lrcv.SelectionFont = new Font(frm.lrcv.SelectionFont, style);
        }

        double CalcOpacity(int fx, int fy)
        {
            int ox = 0, oy = 0;
            
            if (fx < 0)
                ox = -fx;
            else if (fx > this.Width)
                ox = fx - this.Width;

            if (fy < 0)
                oy = -fy;
            else if (fy - this.Height > 0)
                oy = fy - this.Height;

            double ol = (ox + oy)/2.0;
            double opa = 1 - ol/20;
            return opa;
        }

        private void tmv_Tick(object sender, EventArgs e)
        {
            Point fpoint = this.PointToClient(Control.MousePosition);
            fx = fpoint.X;
            fy = fpoint.Y;
            if (canclose && (fx < -15 || fx > this.Size.Width + 15 || fy < -15 || fy > this.Size.Height + 190))
                this.Close();
            this.Opacity = CalcOpacity(fx, fy);
        }

        private void TurnOrange_Click(object sender, EventArgs e)
        {
            frm.lrcv.SelectionBackColor = Color.Orange;
        }

        private void Tone1_Click(object sender, EventArgs e)
        {
            frm.lrcv.SelectionBackColor = Color.White;
            colorPicker.SelectedColor = Color.Red;
            Bold.Checked = true;
            Italic.Checked = Underline.Checked = false;
            Style_Click(null, null);
        }

        private void Tone2_Click(object sender, EventArgs e)
        {
            colorPicker.SelectedColor = Color.White;
            TurnRed_Click(null, null);
            Bold.Checked = true;
            Italic.Checked = Underline.Checked = false;
            Style_Click(null, null);
        }

        private void TextSize_InputTextChanged(object sender)
        {
            string str = "";
            for (int i = 0; i < TextSize.Text.Length; ++i)
                if ((TextSize.Text[i] >= '0' && TextSize.Text[i] <= '9') || TextSize.Text[i] == '.')
                    str += TextSize.Text[i];
            TextSize.Text = str;
            style = new FontStyle();
            if (Bold.Checked)
                style = (FontStyle)(style | FontStyle.Bold);
            if (Italic.Checked)
                style = (FontStyle)(style | FontStyle.Italic);
            if (Underline.Checked)
                style = (FontStyle)(style | FontStyle.Underline);
            frm.lrcv.SelectionFont = new Font(new FontFamily(frm.lrcv.SelectionFont.Name), (float)Convert.ToDouble(str), style);
        }
    }
}
