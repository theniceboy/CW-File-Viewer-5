using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace CW_File_Viewer_5
{
    public partial class FrmFind : DevComponents.DotNetBar.Metro.MetroForm
    {
        private RichTextBox tbox;
        private FrmMain frm;
        private string str;
        private int result, state, st;

        public FrmFind()
        {
            InitializeComponent();
        }

        private void btnFindNext_Click(object sender, EventArgs e)
        {
            state = 0;
            st = frm.lrcv.SelectionStart;
            if (Gib.lrcvSelectedState < 2)
            {
                ++st;
            }
            result = frm.lrcv.Find(tbText.Text, st,
                cbCaseSensitive.Checked ? RichTextBoxFinds.MatchCase : RichTextBoxFinds.None);
            if (result < 0)
            {
                state = 1;
                st = 0;
                result = frm.lrcv.Find(tbText.Text, st,
                    cbCaseSensitive.Checked ? RichTextBoxFinds.MatchCase : RichTextBoxFinds.None);
            }
            if (result > -1)
            {
                if (state > 0)
                    ToastNotification.Show(frm, "�Ѳ��ҵ��ļ���β�����ļ���ͷ��ʼ");
                frm.lrcv.Select(result, tbText.Text.Length);
                frm.lrcv.Focus();
                ++st;
            }
            else
            {
                ToastNotification.Show(frm, "δ�ҵ�", null, 1000, eToastGlowColor.Red);
            }
            Gib.lrcvSelectedState = 0;
        }

        private void tbText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.F)
            {
                btnFindNext_Click(sender, e);
            }
            else if (e.Control && e.KeyCode == Keys.A)
            {
                tbText.SelectAll();
            }
        }

        private void FrmFind_Load(object sender, EventArgs e)
        {
            frm = (FrmMain) this.Owner;
            tbox = frm.lrcv;
        }
    }
}