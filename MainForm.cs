using System.Diagnostics;
using System.Text;
using System.Windows.Forms;

namespace cs_ydl
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            LoadLastSavePath(); // 前回のパスを読み込む
            LoadConfigs(); // configのロード

            // 起動時はオプション無効
            cbUseOptions.Checked = false;

            // UIを同期
            ApplyOptionUiState();

            //CheckYtdlpPath();
        }

        private void ApplyOptionUiState()
        {
            bool optionsEnabled = cbUseOptions.Checked;

            grpMetadata.Enabled = optionsEnabled;
            grpArchive.Enabled = optionsEnabled;
            grpPath.Enabled = optionsEnabled;
            cmbMode.Enabled = optionsEnabled;
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
                if (settingForm.ShowDialog() == DialogResult.OK)
                {
                    CheckYtdlpPath();
                }
            }
        }

        // バージョン情報ツールストリップボタン
        private void aboutToolStripBtn_Click(object sender, EventArgs e)
        {
            //using (var about = new AboutForm())
            //{
            //    about.ShowDialog();
            //}
        }


        // アップデートボタン
        private async void updateBtn_Click(object sender, EventArgs e)
        {
            await RunYtdlpAsync("-U");
        }

        // ペーストボタン
        private void pasteBtn_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                urlTextBox.Text = Clipboard.GetText();
            }
        }

        // URLボックスリセットボタン
        private void urlResetBtn_Click(object sender, EventArgs e)
        {
            urlTextBox.Clear();
            urlTextBox.Focus();
        }

        // ログリセットボタン
        private void btnLogRest_Click(object sender, EventArgs e)
        {
            logTextBox.Clear();
        }

        // チェックボックスでオプション有効化
        private void cbUseOptions_CheckedChanged(object sender, EventArgs e)
        {
            ApplyOptionUiState();
        }


        // チェックボックスで保存先有効化
        private void cUseCustomPath_CheckedChanged(object sender, EventArgs e)
        {
            bool enabled = cUseCustomPath.Checked;
            savePathTextBox.Enabled = enabled;
            browseBtn.Enabled = enabled;
        }

        // チェックボックスで字幕有効化したとき、無効化したときの処理
        private void cbSubs_CheckedChanged(object sender, EventArgs e)
        {
            bool enabled = cbEmbedSubs.Checked;
            cbEmbedAutoSubs.Enabled = enabled;
            cbEmbedAutoSubs.Checked = enabled;
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
        private async void dlBtn_Click(Object sender, EventArgs e)
        {
            try
            {
                await StartDLAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void urlTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // ビープ音を防止
                await StartDLAsync();
            }
        }


        // 実行メイン処理
        private async Task StartDLAsync()
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

            var options = new YtdlpOptions();

            if (!string.IsNullOrWhiteSpace(configName))
            {

                options.ConfigPath = Path.Combine(Properties.Settings.Default.ConfigFolderPath, configName);
            }

            if (cbUseOptions.Checked)
            {
                options.Mode = cmbMode.SelectedIndex switch
                {
                    1 => DownloadMode.AudioOnly,
                    2 => DownloadMode.ThumbnailOnly,
                    3 => DownloadMode.MetadataOnly,
                    _ => DownloadMode.Normal
                };
                options.EmbedSubs = cbEmbedSubs.Checked;
                options.EmbedAutoSubs = cbEmbedAutoSubs.Checked;
                options.EmbedThumbnail = cbEmbedThumbnail.Checked;
                options.EmbedMetadata = cbEmbedMetadata.Checked;
                options.WriteComments = cbWriteComments.Checked;

                options.DisableArchive = cbDisableArchive.Checked;

                options.UseCustomPath = cUseCustomPath.Checked;
                options.SavePath = savePathTextBox.Text;
            }

            var argsList = options.BuildArguments(url);
            string argLine = string.Join(" ", argsList.Select(a => a.Contains(' ') ? $"\"{a}\"" : a));

            await RunYtdlpAsync(argLine);
        }

        // yt-dlp実行関数　＋　ログ出力
        private async Task RunYtdlpAsync(string arguments)
        {
            dlBtn.Enabled = false;
            try
            {
                string exePath = Properties.Settings.Default.YtDlpPath;

                if (string.IsNullOrWhiteSpace(exePath) || !File.Exists(exePath))
                {
                    throw new FileNotFoundException("yt-dlp.exe が見つかりません。設定画面でパスを指定してください。");
                }

                var psi = new ProcessStartInfo
                {
                    FileName = exePath,
                    Arguments = arguments,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                using var proc = Process.Start(psi)!;

                string stdout = await proc.StandardOutput.ReadToEndAsync();
                string stderr = await proc.StandardError.ReadToEndAsync();

                await proc.WaitForExitAsync();

                logTextBox.AppendText(stdout);

                if (proc.ExitCode == 0)
                {
                    logTextBox.AppendText("ダウンロード完了\n");
                    MessageBox.Show("完了しました。", "完了", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (!string.IsNullOrWhiteSpace(stderr))
                    {
                        logTextBox.SelectionColor = Color.Red;
                        logTextBox.AppendText(stderr);
                        logTextBox.SelectionColor = logTextBox.ForeColor;
                    }
                    MessageBox.Show("エラーが発生しました。ログを確認してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                {
                    MessageBox.Show(ex.Message, "例外", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            finally
            {
                dlBtn.Enabled = true;
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
