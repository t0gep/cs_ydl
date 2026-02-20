namespace cs_ydl
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            urlTextBox = new TextBox();
            dlBtn = new Button();
            confCmbBx = new ComboBox();
            savePathTextBox = new TextBox();
            browseBtn = new Button();
            cUseCustomPath = new CheckBox();
            updateBtn = new Button();
            logTextBox = new RichTextBox();
            cbEmbedMetadata = new CheckBox();
            metadataCheck = new ToolTip(components);
            cbDisableArchive = new CheckBox();
            cbEmbedThumbnail = new CheckBox();
            cbEmbedSubs = new CheckBox();
            cbEmbedAutoSubs = new CheckBox();
            cbWriteComments = new CheckBox();
            pasteBtn = new Button();
            urlResetBtn = new Button();
            selectConfigFolderBtn = new Button();
            toolStrip1 = new ToolStrip();
            settingToolStripBtn = new ToolStripButton();
            aboutToolStripBtn = new ToolStripButton();
            lblConf = new Label();
            btnLogRest = new Button();
            cmbMode = new ComboBox();
            grpMetadata = new GroupBox();
            grpArchive = new GroupBox();
            grpPath = new GroupBox();
            cbUseOptions = new CheckBox();
            toolStrip1.SuspendLayout();
            grpMetadata.SuspendLayout();
            grpArchive.SuspendLayout();
            grpPath.SuspendLayout();
            SuspendLayout();
            // 
            // urlTextBox
            // 
            urlTextBox.Location = new Point(12, 98);
            urlTextBox.Name = "urlTextBox";
            urlTextBox.Size = new Size(499, 26);
            urlTextBox.TabIndex = 9;
            urlTextBox.KeyDown += urlTextBox_KeyDown;
            // 
            // dlBtn
            // 
            dlBtn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dlBtn.BackColor = SystemColors.Control;
            dlBtn.Cursor = Cursors.Hand;
            dlBtn.Location = new Point(517, 101);
            dlBtn.Name = "dlBtn";
            dlBtn.Size = new Size(108, 72);
            dlBtn.TabIndex = 8;
            dlBtn.Text = "DL";
            dlBtn.UseVisualStyleBackColor = false;
            dlBtn.Click += dlBtn_Click;
            // 
            // confCmbBx
            // 
            confCmbBx.DropDownStyle = ComboBoxStyle.DropDownList;
            confCmbBx.FormattingEnabled = true;
            confCmbBx.Location = new Point(12, 146);
            confCmbBx.Name = "confCmbBx";
            confCmbBx.Size = new Size(454, 27);
            confCmbBx.TabIndex = 2;
            confCmbBx.SelectedIndexChanged += confCmbBx_SelectedIndexChanged;
            // 
            // savePathTextBox
            // 
            savePathTextBox.Enabled = false;
            savePathTextBox.Location = new Point(101, 22);
            savePathTextBox.Name = "savePathTextBox";
            savePathTextBox.ReadOnly = true;
            savePathTextBox.Size = new Size(377, 26);
            savePathTextBox.TabIndex = 3;
            // 
            // browseBtn
            // 
            browseBtn.Enabled = false;
            browseBtn.Location = new Point(484, 25);
            browseBtn.Name = "browseBtn";
            browseBtn.Size = new Size(39, 23);
            browseBtn.TabIndex = 4;
            browseBtn.Text = "...";
            browseBtn.UseVisualStyleBackColor = true;
            browseBtn.Click += browseBtn_Click;
            // 
            // cUseCustomPath
            // 
            cUseCustomPath.AutoSize = true;
            cUseCustomPath.Location = new Point(6, 25);
            cUseCustomPath.Name = "cUseCustomPath";
            cUseCustomPath.Size = new Size(89, 23);
            cUseCustomPath.TabIndex = 5;
            cUseCustomPath.Text = "パスを指定";
            cUseCustomPath.UseVisualStyleBackColor = true;
            cUseCustomPath.CheckedChanged += cUseCustomPath_CheckedChanged;
            // 
            // updateBtn
            // 
            updateBtn.Location = new Point(384, 29);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(127, 29);
            updateBtn.TabIndex = 6;
            updateBtn.Text = "yt-dlpをアップデート";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // logTextBox
            // 
            logTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            logTextBox.Location = new Point(12, 470);
            logTextBox.Name = "logTextBox";
            logTextBox.ReadOnly = true;
            logTextBox.ScrollBars = RichTextBoxScrollBars.Vertical;
            logTextBox.Size = new Size(614, 259);
            logTextBox.TabIndex = 7;
            logTextBox.Text = "";
            // 
            // cbEmbedMetadata
            // 
            cbEmbedMetadata.AutoSize = true;
            cbEmbedMetadata.Checked = true;
            cbEmbedMetadata.CheckState = CheckState.Checked;
            cbEmbedMetadata.Location = new Point(11, 83);
            cbEmbedMetadata.Name = "cbEmbedMetadata";
            cbEmbedMetadata.Size = new Size(141, 23);
            cbEmbedMetadata.TabIndex = 10;
            cbEmbedMetadata.Text = "メタデータを埋め込む";
            metadataCheck.SetToolTip(cbEmbedMetadata, "メタデータを埋め込みます。これはチャプターとinfojsonを含みます。");
            cbEmbedMetadata.UseVisualStyleBackColor = true;
            // 
            // cbDisableArchive
            // 
            cbDisableArchive.AutoSize = true;
            cbDisableArchive.Location = new Point(6, 25);
            cbDisableArchive.Name = "cbDisableArchive";
            cbDisableArchive.Size = new Size(157, 23);
            cbDisableArchive.TabIndex = 10;
            cbDisableArchive.Text = "Archiveに書き込まない";
            metadataCheck.SetToolTip(cbDisableArchive, "--download-archive [FILE]が有効でもArchiveに書き込みません");
            cbDisableArchive.UseVisualStyleBackColor = true;
            // 
            // cbEmbedThumbnail
            // 
            cbEmbedThumbnail.AutoSize = true;
            cbEmbedThumbnail.Checked = true;
            cbEmbedThumbnail.CheckState = CheckState.Checked;
            cbEmbedThumbnail.Location = new Point(11, 54);
            cbEmbedThumbnail.Name = "cbEmbedThumbnail";
            cbEmbedThumbnail.Size = new Size(144, 23);
            cbEmbedThumbnail.TabIndex = 10;
            cbEmbedThumbnail.Text = "サムネイルを埋め込む";
            metadataCheck.SetToolTip(cbEmbedThumbnail, "サムネイルを埋め込みます");
            cbEmbedThumbnail.UseVisualStyleBackColor = true;
            // 
            // cbEmbedSubs
            // 
            cbEmbedSubs.AutoSize = true;
            cbEmbedSubs.Checked = true;
            cbEmbedSubs.CheckState = CheckState.Checked;
            cbEmbedSubs.Location = new Point(11, 25);
            cbEmbedSubs.Name = "cbEmbedSubs";
            cbEmbedSubs.Size = new Size(117, 23);
            cbEmbedSubs.TabIndex = 10;
            cbEmbedSubs.Text = "字幕を埋め込む";
            metadataCheck.SetToolTip(cbEmbedSubs, "日本語の字幕を埋め込みます。");
            cbEmbedSubs.UseVisualStyleBackColor = true;
            cbEmbedSubs.CheckedChanged += cbSubs_CheckedChanged;
            // 
            // cbEmbedAutoSubs
            // 
            cbEmbedAutoSubs.AutoSize = true;
            cbEmbedAutoSubs.Checked = true;
            cbEmbedAutoSubs.CheckState = CheckState.Checked;
            cbEmbedAutoSubs.Location = new Point(134, 25);
            cbEmbedAutoSubs.Name = "cbEmbedAutoSubs";
            cbEmbedAutoSubs.Size = new Size(145, 23);
            cbEmbedAutoSubs.TabIndex = 10;
            cbEmbedAutoSubs.Text = "自動字幕も埋め込む";
            metadataCheck.SetToolTip(cbEmbedAutoSubs, "自動字幕を埋め込みます。");
            cbEmbedAutoSubs.UseVisualStyleBackColor = true;
            // 
            // cbWriteComments
            // 
            cbWriteComments.AutoSize = true;
            cbWriteComments.Location = new Point(11, 112);
            cbWriteComments.Name = "cbWriteComments";
            cbWriteComments.Size = new Size(129, 23);
            cbWriteComments.TabIndex = 10;
            cbWriteComments.Text = "コメントを書き込む";
            metadataCheck.SetToolTip(cbWriteComments, "動画コメントを取得し、JSONファイルに書き込みます");
            cbWriteComments.UseVisualStyleBackColor = true;
            // 
            // pasteBtn
            // 
            pasteBtn.Location = new Point(420, 63);
            pasteBtn.Name = "pasteBtn";
            pasteBtn.Size = new Size(91, 29);
            pasteBtn.TabIndex = 11;
            pasteBtn.Text = "ペースト";
            pasteBtn.UseVisualStyleBackColor = true;
            pasteBtn.Click += pasteBtn_Click;
            // 
            // urlResetBtn
            // 
            urlResetBtn.Location = new Point(323, 63);
            urlResetBtn.Name = "urlResetBtn";
            urlResetBtn.Size = new Size(91, 29);
            urlResetBtn.TabIndex = 12;
            urlResetBtn.Text = "リセット";
            urlResetBtn.UseVisualStyleBackColor = true;
            urlResetBtn.Click += urlResetBtn_Click;
            // 
            // selectConfigFolderBtn
            // 
            selectConfigFolderBtn.Location = new Point(472, 150);
            selectConfigFolderBtn.Name = "selectConfigFolderBtn";
            selectConfigFolderBtn.Size = new Size(39, 23);
            selectConfigFolderBtn.TabIndex = 13;
            selectConfigFolderBtn.Text = "...";
            selectConfigFolderBtn.UseVisualStyleBackColor = true;
            selectConfigFolderBtn.Click += selectConfigFolderBtn_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { settingToolStripBtn, aboutToolStripBtn });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(637, 26);
            toolStrip1.TabIndex = 14;
            toolStrip1.Text = "toolStrip1";
            // 
            // settingToolStripBtn
            // 
            settingToolStripBtn.DisplayStyle = ToolStripItemDisplayStyle.Text;
            settingToolStripBtn.Image = (Image)resources.GetObject("settingToolStripBtn.Image");
            settingToolStripBtn.ImageTransparentColor = Color.Magenta;
            settingToolStripBtn.Name = "settingToolStripBtn";
            settingToolStripBtn.Size = new Size(41, 23);
            settingToolStripBtn.Text = "設定";
            settingToolStripBtn.Click += settingToolStripBtn_Click;
            // 
            // aboutToolStripBtn
            // 
            aboutToolStripBtn.DisplayStyle = ToolStripItemDisplayStyle.Text;
            aboutToolStripBtn.Image = (Image)resources.GetObject("aboutToolStripBtn.Image");
            aboutToolStripBtn.ImageTransparentColor = Color.Magenta;
            aboutToolStripBtn.Name = "aboutToolStripBtn";
            aboutToolStripBtn.Size = new Size(91, 23);
            aboutToolStripBtn.Text = "バージョン情報";
            aboutToolStripBtn.Click += aboutToolStripBtn_Click;
            // 
            // lblConf
            // 
            lblConf.AutoSize = true;
            lblConf.Location = new Point(12, 125);
            lblConf.Name = "lblConf";
            lblConf.Size = new Size(77, 19);
            lblConf.TabIndex = 15;
            lblConf.Text = ".confの選択";
            // 
            // btnLogRest
            // 
            btnLogRest.Location = new Point(537, 735);
            btnLogRest.Name = "btnLogRest";
            btnLogRest.Size = new Size(92, 26);
            btnLogRest.TabIndex = 16;
            btnLogRest.Text = "ログクリア";
            btnLogRest.UseVisualStyleBackColor = true;
            btnLogRest.Click += btnLogRest_Click;
            // 
            // cmbMode
            // 
            cmbMode.FormattingEnabled = true;
            cmbMode.Items.AddRange(new object[] { "通常", "音声のみ", "サムネイルのみ", "メタデータのみ" });
            cmbMode.Location = new Point(12, 230);
            cmbMode.Name = "cmbMode";
            cmbMode.Size = new Size(121, 27);
            cmbMode.TabIndex = 17;
            // 
            // grpMetadata
            // 
            grpMetadata.Controls.Add(cbEmbedSubs);
            grpMetadata.Controls.Add(cbEmbedAutoSubs);
            grpMetadata.Controls.Add(cbEmbedThumbnail);
            grpMetadata.Controls.Add(cbEmbedMetadata);
            grpMetadata.Controls.Add(cbWriteComments);
            grpMetadata.Location = new Point(12, 263);
            grpMetadata.Name = "grpMetadata";
            grpMetadata.Size = new Size(291, 139);
            grpMetadata.TabIndex = 18;
            grpMetadata.TabStop = false;
            grpMetadata.Text = "メタデータ";
            // 
            // grpArchive
            // 
            grpArchive.Controls.Add(cbDisableArchive);
            grpArchive.Location = new Point(311, 263);
            grpArchive.Name = "grpArchive";
            grpArchive.Size = new Size(200, 92);
            grpArchive.TabIndex = 19;
            grpArchive.TabStop = false;
            grpArchive.Text = "アーカイブ";
            // 
            // grpPath
            // 
            grpPath.Controls.Add(cUseCustomPath);
            grpPath.Controls.Add(savePathTextBox);
            grpPath.Controls.Add(browseBtn);
            grpPath.Location = new Point(12, 408);
            grpPath.Name = "grpPath";
            grpPath.Size = new Size(543, 56);
            grpPath.TabIndex = 20;
            grpPath.TabStop = false;
            grpPath.Text = "保存フォルダ";
            // 
            // cbUseOptions
            // 
            cbUseOptions.AutoSize = true;
            cbUseOptions.Location = new Point(12, 201);
            cbUseOptions.Name = "cbUseOptions";
            cbUseOptions.Size = new Size(140, 23);
            cbUseOptions.TabIndex = 21;
            cbUseOptions.Text = "オプションを利用する";
            cbUseOptions.UseVisualStyleBackColor = true;
            cbUseOptions.CheckedChanged += cbUseOptions_CheckedChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(637, 773);
            Controls.Add(cbUseOptions);
            Controls.Add(grpPath);
            Controls.Add(grpArchive);
            Controls.Add(grpMetadata);
            Controls.Add(cmbMode);
            Controls.Add(btnLogRest);
            Controls.Add(lblConf);
            Controls.Add(toolStrip1);
            Controls.Add(selectConfigFolderBtn);
            Controls.Add(urlResetBtn);
            Controls.Add(pasteBtn);
            Controls.Add(logTextBox);
            Controls.Add(updateBtn);
            Controls.Add(confCmbBx);
            Controls.Add(dlBtn);
            Controls.Add(urlTextBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            Name = "MainForm";
            Text = "cs_ydl";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            grpMetadata.ResumeLayout(false);
            grpMetadata.PerformLayout();
            grpArchive.ResumeLayout(false);
            grpArchive.PerformLayout();
            grpPath.ResumeLayout(false);
            grpPath.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox urlTextBox;
        private Button dlBtn;
        private ComboBox confCmbBx;
        private TextBox savePathTextBox;
        private Button browseBtn;
        private CheckBox cUseCustomPath;
        private Button updateBtn;
        private RichTextBox logTextBox;
        private CheckBox cbEmbedMetadata;
        private ToolTip metadataCheck;
        private CheckBox cbDisableArchive;
        private Button pasteBtn;
        private Button urlResetBtn;
        private Button selectConfigFolderBtn;
        private ToolStrip toolStrip1;
        private ToolStripButton settingToolStripBtn;
        private ToolStripButton aboutToolStripBtn;
        private Label lblConf;
        private CheckBox cbEmbedThumbnail;
        private CheckBox cbEmbedSubs;
        private CheckBox cbEmbedAutoSubs;
        private CheckBox cbWriteComments;
        private Button btnLogRest;
        private ComboBox cmbMode;
        private GroupBox grpMetadata;
        private GroupBox grpArchive;
        private GroupBox grpPath;
        private CheckBox cbUseOptions;
    }
}
