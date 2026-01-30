using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cs_ydl
{
    public partial class SettingForm : Form
    {
        public SettingForm()
        {
            InitializeComponent();

            // 現在の設定を読み込む
            ytdlpPathTextBox.Text = Properties.Settings.Default.YtDlpPath;
        }

        // yt-dlp.exe参照ボタン
        private void browseYtdlpBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "yt-dlp.exeを選択してください";
                dlg.Filter = "実行ファイル (*.exe)|*.exe|すべてのファイル (*.*)|*.*";
                dlg.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    ytdlpPathTextBox.Text = dlg.FileName;
                }
            }
        }

        // yt-dlp.exeドラッグアンドドロップ
        private void ytdlpPathTextBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data != null && e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        // yt-dlp.exeドラッグアンドドロップ
        private void ytdlpPathTextBox_DragDrop(object sender, DragEventArgs e)
        {
            var data = e.Data?.GetData(DataFormats.FileDrop);

            if (data is string[] paths && paths.Length > 0)
            {
                if (Directory.Exists(paths[0]))
                {
                    ytdlpPathTextBox.Text = paths[0];
                }
            }
        }

        // 設定保存ボタン
        private void saveBtn_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.YtDlpPath = ytdlpPathTextBox.Text;

            Properties.Settings.Default.Save();

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
