using System.Diagnostics;

namespace cs_ydl
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();


            LoadLastSavePath(); // 前回のパスを読み込む
            LoadConfigs(); // configのロード

            savePathTextBox.Enabled = false;
            browseBtn.Enabled = false;

            CheckYtdlpPath();
        }

        // 保存と読込用
        private const string SavePathSettingKey = "LastSavePath";

        private void SaveLastSavePath(string path)
        {
            Properties.Settings.Default[SavePathSettingKey] = path;
            Properties.Settings.Default.Save();
        }


        // 前回使った保存先パスを保存

        private void LoadLastSavePath()
        {
            var val = Properties.Settings.Default[SavePathSettingKey];

            if (val != null)
            {
                savePathTextBox.Text = val.ToString();
            }
        }

        // configフォルダから設定をロード
        private void LoadConfigs()
        {
            string configFolder = Properties.Settings.Default.ConfigFolderPath;

            if (string.IsNullOrWhiteSpace(configFolder) || !Directory.Exists(configFolder))
            {
                return;
            }

            confCmbBx.Items.Clear();

            string[] configs = Directory.GetFiles(configFolder, "*.conf");

            foreach (string config in configs)
            {
                confCmbBx.Items.Add(Path.GetFileName(config));
            }

            if (confCmbBx.Items.Count == 0)
            {
                return;
            }

            // 最後に選択した.configを選択
            string lastConfigName = Properties.Settings.Default.LastConfigName;

            if (!string.IsNullOrEmpty(lastConfigName) && confCmbBx.Items.Contains(lastConfigName))
            {
                confCmbBx.SelectedItem = lastConfigName;
            }
            else
            {
                confCmbBx.SelectedIndex = 0;
            }
        }


        // configフォルダ選択ボタン
        private void selectConfigFolderBtn_Click(object sender, EventArgs e)
        {
            using (var dialog = new FolderBrowserDialog())
            {
                dialog.Description = "Select Config Folder";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedPath = dialog.SelectedPath;

                    // 設定に保存
                    Properties.Settings.Default.ConfigFolderPath = selectedPath;
                    Properties.Settings.Default.Save();

                    LoadConfigs();
                }
            }
        }

        // 最後に選択した.configを保存
        private void confCmbBx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (confCmbBx.SelectedItem != null)
            {
                Properties.Settings.Default.LastConfigName = confCmbBx.SelectedItem.ToString() ?? "";
                Properties.Settings.Default.Save();
            }
        }

        // 設定ツールストリップボタン
        private void settingToolStripBtn_Click(object sender, EventArgs e)
        {
            using (SettingForm settingForm = new SettingForm())
            {
                settingForm.ShowDialog();

                //if (settingForm.ShowDialog() == DialogResult.OK)
                //{
                //    // 設定が保存された後の処理（必要なら）
                //}
            }
        }

        // アップデートボタン
        private void updateBtn_Click(object sender, EventArgs e)
        {
            RunYtdlp("-U");
        }

        // ペーストボタン
        private void pasteBtn_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                urlTextBox.Text = Clipboard.GetText();
            }
        }

        // リセットボタン
        private void urlResetBtn_Click(object sender, EventArgs e)
        {
            urlTextBox.Clear();
            urlTextBox.Focus();
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
            string? configName = confCmbBx.SelectedItem?.ToString();
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

            if (!string.IsNullOrWhiteSpace(configName))
            {
                string fullConfigPath = Path.Combine(Properties.Settings.Default.ConfigFolderPath, configName);

                args += $"--config-location \"{fullConfigPath}\" ";
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
                string exePath = Properties.Settings.Default.YtDlpPath;

                if (string.IsNullOrWhiteSpace(exePath) || !File.Exists(exePath))
                {
                    throw new FileNotFoundException("yt-dlp.exe が見つかりません。設定画面でパスを指定してください。");
                }

                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = exePath,
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

        // yt-dlpパスチェック関数
        private void CheckYtdlpPath()
        {
            string exePath = Properties.Settings.Default.YtDlpPath;
            if (string.IsNullOrWhiteSpace(exePath) || !File.Exists(exePath))
            {
                var result = MessageBox.Show(
                    "yt-dlp.exe のパスが設定されていません。\n設定画面を開きますか？",
                    "yt-dlp パス未設定",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);
                
                if (result == DialogResult.Yes)
                {
                    using (SettingForm settingForm = new SettingForm())
                    {
                        settingForm.ShowDialog();
                    }
                }
            }
        }
    }
}
