using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace CW_File_Viewer_5
{
    public partial class FrmFileNote : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FrmFileNote()
        {
            InitializeComponent();
        }

        private string name = null;

        private void ok_Click(object sender, EventArgs e)
        {
            File.WriteAllText(name, note.Text, Encoding.GetEncoding("GB2312"));
            this.Close();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            //Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab] + 1]
            this.Close();
        }

        private void note_TextChanged(object sender, EventArgs e)
        {
            length.Text = "¹² " + note.Text.Length.ToString() + " ×Ö";
        }

        private void FrmFileNote_Load(object sender, EventArgs e)
        {
            name = Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]] + '\\' + Path.GetFileNameWithoutExtension(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab] + 1]) + ".cfvnote";
            if (File.Exists(name))
                note.Text = File.ReadAllText(name, Encoding.GetEncoding("GB2312"));
            else
                note.WatermarkText = "ÎÞ×¢ÊÍ";
            note.SelectedText = "";
        }

        private void note_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
                note.SelectAll();
        }
    }
}