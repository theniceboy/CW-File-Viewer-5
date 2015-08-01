using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace CW_File_Viewer_5
{
    public partial class FrmRename : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FrmRename()
        {
            InitializeComponent();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string a, b;

        private void renameFolder(string from)
        {
            // 文件
            string[] str = Directory.GetFiles(from);
            foreach (string file in str)
                try
                {
                    int i;
                    for (int j = 0; j < Gib.tsn; ++j)
                        for (i = 0; i < Gib.ts[Gib.nowsysi].ftagn; ++i)
                            if (Gib.ts[j].ftagpath[i] == file)
                            {
                                Gib.ts[j].ftagpath[i] = Gib.ts[j].ftagpath[i].Replace(a, b);
                                break;
                            }
                }
                catch (Exception Ex) { if (MessageBoxEx.Show(this, Ex.ToString(), "错误！点Cancel复制消息。", MessageBoxButtons.OKCancel) == DialogResult.Cancel) Clipboard.SetText(Ex.ToString()); }


            // 子文件夹
            str = Directory.GetDirectories(from);
            foreach (string folder in str)
                renameFolder(folder);
        }

        private void ok_Click(object sender, EventArgs e)
        {
            string name = filename.Text.Trim();
            if (name != "")
            {
                string filepath = Path.GetDirectoryName(Gib.crossfile1) + '\\' + name;
                if (Directory.Exists(filepath))
                    MessageBoxEx.Show(this, "文件夹名已存在", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning,
                        MessageBoxDefaultButton.Button1, true);
                else
                {
                    a = Gib.crossfile1;
                    b = filepath;
                    renameFolder(a);
                    Directory.Move(a, filepath);
                    FrmMain frm = (FrmMain) this.Owner;
                    frm.reffile(Gib.fpos[Gib.nowtab, Gib.nowp[Gib.nowtab]]);
                    this.Close();
                }
            }
            else
            {
                MessageBoxEx.Show(this, "文件夹名不得为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1, true);
            }
        }

        private void FrmRename_Load(object sender, EventArgs e)
        {
            filename.Text = Path.GetFileName(Gib.crossfile1);
        }
    }
}