using System.Diagnostics;

namespace cs_ydl
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            LoadConfigs(); // configのロード
            LoadLastSavePath(); // 前回のパスを読み込む

            savePathTextBox.Enabled = false;
            browseBtn.Enabled = false;
        }

        // 保存と読込用
        private const string SavePathSettingKey = "LastSavePath";

        private void SaveLastSavePath(string path)
        {
            Properties.Settings.Default[SavePathSettingKey] = path;
            Properties.Settings.Default.Save();
        }


        // 前回使ったパスを保存

        private void LoadLastSavePath()
        {
            if (Properties.Settings.Default[SavePathSettingKey] == null)
            {
                savePathTextBox.Text = Properties.Settings.Default[SavePathSettingKey].ToString();
            }
        }

        private void LoadConfigs()
        {
            string configFolder = Path.Combine(Application.StartupPath, "C://yt-dlp//configs");
            if (!Directory.Exists(configFolder)) return;

            string[] configs = Directory.GetFiles(configFolder, "*.conf");
            foreach (string config in configs)
            {
                confCmbBx.Items.Add(config);
            }

            if (confCmbBx.Items.Count > 0)
            {
                confCmbBx.SelectedIndex = 4;
            }
        }

        // アップデートボタン
        private void updateBtn_Click(object sender, EventArgs e)
        {
            RunYtdlp("-U");
        }

        // チェックボックスで保存先有効化
        private void cUseCustomPath_CheckedChanged(object sender, EventArgs e)
        {
            bool enabled = cUseCustomPath.Checked;
            savePathTextBox.Enabled = enabled;
            browseBtn.Enabled = enabled;
        }

        // チェックボックスでArchiveを無効化
        private void cbDisableArchive_CheckedChanged(object sender, EventArgs e)
        {

        }

        // フォルダ選択
        private void browseBtn_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dlg = new FolderBrowserDialog())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    savePathTextBox.Text = dlg.SelectedPath;
                    SaveLastSavePath(dlg.SelectedPath);
                }
            }
        }

        // ダウンロードボタン or enterキー
        private void dlBtn_Click(Object sender, EventArgs e) => StartDL();
        private void urlTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) StartDL();
        }

        // 実行メイン処理
        private void StartDL()
        {
            string url = urlTextBox.Text.Trim();
            string savePath = savePathTextBox.Text.Trim();
            string? config = confCmbBx.SelectedItem?.ToString();
            if (string.IsNullOrWhiteSpace(url))
            {
                MessageBox.Show("URLを入力してください");
                return;
            }

            if (cUseCustomPath.Checked && string.IsNullOrWhiteSpace(savePath))
            {
                MessageBox.Show("保存先を指定してください", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string args = "";

            if (!string.IsNullOrWhiteSpace(config))
            {
                args += $"--config-location \"{config}\" ";
            }

            if (cUseCustomPath.Checked && !string.IsNullOrWhiteSpace(savePath))
            {
                args += $"-P \"{savePath}\" ";
            }

            if (cbDisableMetadata.Checked)
            {
                args += "--no-embed-metadata ";
            }

            if (cbDisableArchive.Checked)
            {
                args += "--no-download-archive ";
            }

            args += $"\"{url}\" ";

            RunYtdlp(args);
        }

        // yt-dlp実行関数　＋　ログ出力
        private void RunYtdlp(string arguments)
        {
            try
            {
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = "C://yt-dlp//yt-dlp.exe",
                    Arguments = arguments,
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                Process? proc = Process.Start(psi);
                if (proc == null)
                {
                    throw new InvalidOperationException("yt-dlp の起動に失敗しました。");
                }
                using (proc)
                {
                    string output = proc.StandardOutput.ReadToEnd();
                    proc.WaitForExit();
                    logTextBox.AppendText(output + Environment.NewLine);
                }
            }
            catch (Exception ex)
            {
                {
                    MessageBox.Show("エラー： " + ex.Message);
                }
            }
        }


    }
}
