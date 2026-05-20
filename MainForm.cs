using cs_ydl.Models;
using cs_ydl.Services;

namespace cs_ydl
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            InitializeOptionComboBoxes();

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

        // ======= フィールド =======
        // yt-dlp実行サービス
        private readonly YtdlpService _ytdlpService = new();

        // ======== コンストラクタ ========


        // ======= 初期化関連 =======

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

        // オプション取得関数
        private OptionState GetOptionState(ComboBox comboBox)
        {
            return comboBox.SelectedIndex switch
            {
                1 => OptionState.Enabled,
                2 => OptionState.Disabled,
                _ => OptionState.Default
            };
        }

        // オプションコンボボックス初期化
        private void InitializeOptionComboBoxes()
        {
            InitOptionComboBox(cmbEmbedSubs);
            InitOptionComboBox(cmbEmbedAutoSubs);
            InitOptionComboBox(cmbEmbedThumbnail);
            InitOptionComboBox(cmbEmbedMetadata);
            InitOptionComboBox(cmbWriteComments);
            InitOptionComboBox(cmbEnableArchive);
            InitOptionComboBox(cmbUseCustomPath);
        }

        // オプションコンボボックス初期化関数
        private void InitOptionComboBox(
            ComboBox comboBox)
        {
            comboBox.Items.Clear();

            comboBox.Items.Add("Configに従う");
            comboBox.Items.Add("有効");
            comboBox.Items.Add("無効");

            comboBox.SelectedIndex = 0;

            comboBox.DropDownStyle =
                ComboBoxStyle.DropDownList;
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

        // ======= UIイベント ===========

        // ファイルドロップダウン
        // ファイル/yt-dlpをアップデートボタン
        private async void fileToolStripMenuItemUpdataYdl_Click(object sender, EventArgs e)
        {
            await RunYtdlpAsync("-U");
        }

        // ファイル/yt-dlpをアップデート(nightly)ボタン
        private async void fileToolStripMenuItemUpdataYdlNightly_Click(object sender, EventArgs e)
        {
            await RunYtdlpAsync("--update-to nightly");
        }

        // ファイル/終了ボタン
        private void fileToolStripMenuItemExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        // ======== 実行メイン処理 ========
        // 実行メイン処理
        private async Task StartDLAsync()
        {
            try
            {
                DownloadRequest request =
                    BuildRequestFromUi();

                string arguments =
                    BuildArguments(request);

                await RunYtdlpAsync(arguments);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "例外",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // ======== ビルド関数 ========
        // ダウンロードリクエストビルド関数
        private string BuildDownloadArguments(DownloadRequest request)
        {
            List<string> argsList =
                request.Options.BuildArguments(request.Url);
            return string.Join(
                " ",
                argsList.Select(
                    a => a.Contains(' ')
                    ? $"\"{a}\""
                    : a
                    )
            );
        }

        // UI取得
        private DownloadRequest BuildRequestFromUi()
        {
            string url = urlTextBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(url))
            {
                throw new Exception("URLを入力してください");
            }

            return new DownloadRequest
            {
                Url = url,

                Options = BuildOptionsFromUi()
            };
        }

        // オプションUI
        private YtdlpOptions BuildOptionsFromUi()
        {
            var options = new YtdlpOptions();

            // オプション無効時はデフォルト返却
            if (!cbUseOptions.Checked)
            {
                return options;
            }

            // ダウンロードモード
            options.Mode = cmbMode.SelectedIndex switch
            {
                1 => DownloadMode.AudioOnly,
                2 => DownloadMode.ThumbnailOnly,
                3 => DownloadMode.MetadataOnly,
                _ => DownloadMode.Normal
            };

            // 埋め込み系
            options.EmbedSubs =
                GetOptionState(cmbEmbedSubs);

            options.EmbedAutoSubs =
                GetOptionState(cmbEmbedAutoSubs);

            options.EmbedThumbnail =
                GetOptionState(cmbEmbedThumbnail);

            options.EmbedMetadata =
                GetOptionState(cmbEmbedMetadata);

            // コメント保存
            options.WriteComments =
                GetOptionState(cmbWriteComments);
            // archive有効
            options.EnableArchive =
                GetOptionState(cmbEnableArchive);

            // 保存先
            options.UseCustomPath =
                GetOptionState(cmbUseCustomPath);

            options.SavePath =
                savePathTextBox.Text.Trim();

            // config
            string? configName =
                confCmbBx.SelectedItem?.ToString();

            if (!string.IsNullOrWhiteSpace(configName))
            {
                options.ConfigPath =
                    Path.Combine(
                        Properties.Settings.Default.ConfigFolderPath,
                        configName);
            }

            return options;
        }

        // コマンドモード取得関数
        private YtdlpCommandMode GetSelectedMode()
        {
            return YtdlpCommandMode.Download;
        }

        // 引数ビルド関数
        private string BuildArguments(DownloadRequest request)
        {
            YtdlpCommandMode mode =
                GetSelectedMode();

            return mode switch
            {
                YtdlpCommandMode.Download =>
                    BuildDownloadArguments(request),

                YtdlpCommandMode.Formats =>
                    $"-F \"{request.Url}\"",

                YtdlpCommandMode.Json =>
                    $"-J \"{request.Url}\"",

                YtdlpCommandMode.Simulate =>
                    $"--simulate \"{request.Url}\"",

                _ =>
                    throw new NotImplementedException()
            };
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
                    throw new FileNotFoundException(
                        "yt-dlp.exe が見つかりません。");
                }

                YtdlpResult result =
                    await _ytdlpService.RunAsync(
                        exePath,
                        arguments);

                logTextBox.AppendText(result.StdOut);

                if (result.ExitCode == 0)
                {
                    logTextBox.AppendText(
                        "ダウンロード完了\n");

                    MessageBox.Show(
                        "完了しました。",
                        "完了",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    if (!string.IsNullOrWhiteSpace(result.StdErr))
                    {
                        logTextBox.SelectionColor = Color.Red;

                        logTextBox.AppendText(result.StdErr);

                        logTextBox.SelectionColor =
                            logTextBox.ForeColor;
                    }

                    MessageBox.Show(
                        "エラーが発生しました。",
                        "エラー",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "例外",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
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
