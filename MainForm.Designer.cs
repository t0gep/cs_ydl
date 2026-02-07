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
            cbMetadata = new CheckBox();
            metadataCheck = new ToolTip(components);
            cbDisableArchive = new CheckBox();
            cbOnlyAudio = new CheckBox();
            cbThumbnail = new CheckBox();
            cbSubs = new CheckBox();
            cbAutoSubs = new CheckBox();
            pasteBtn = new Button();
            urlResetBtn = new Button();
            selectConfigFolderBtn = new Button();
            toolStrip1 = new ToolStrip();
            settingToolStripBtn = new ToolStripButton();
            aboutToolStripBtn = new ToolStripButton();
            lblConf = new Label();
            cbComments = new CheckBox();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // urlTextBox
            // 
            urlTextBox.Location = new Point(12, 98);
            urlTextBox.Name = "urlTextBox";
            urlTextBox.Size = new Size(417, 26);
            urlTextBox.TabIndex = 9;
            urlTextBox.KeyDown += urlTextBox_KeyDown;
            // 
            // dlBtn
            // 
            dlBtn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dlBtn.Location = new Point(437, 98);
            dlBtn.Name = "dlBtn";
            dlBtn.Size = new Size(83, 72);
            dlBtn.TabIndex = 8;
            dlBtn.Text = "DL";
            dlBtn.Click += dlBtn_Click;
            // 
            // confCmbBx
            // 
            confCmbBx.DropDownStyle = ComboBoxStyle.DropDownList;
            confCmbBx.FormattingEnabled = true;
            confCmbBx.Location = new Point(12, 146);
            confCmbBx.Name = "confCmbBx";
            confCmbBx.Size = new Size(374, 27);
            confCmbBx.TabIndex = 2;
            confCmbBx.SelectedIndexChanged += confCmbBx_SelectedIndexChanged;
            // 
            // savePathTextBox
            // 
            savePathTextBox.Enabled = false;
            savePathTextBox.Location = new Point(98, 353);
            savePathTextBox.Name = "savePathTextBox";
            savePathTextBox.ReadOnly = true;
            savePathTextBox.Size = new Size(377, 26);
            savePathTextBox.TabIndex = 3;
            // 
            // browseBtn
            // 
            browseBtn.Enabled = false;
            browseBtn.Location = new Point(481, 356);
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
            cUseCustomPath.Location = new Point(12, 356);
            cUseCustomPath.Name = "cUseCustomPath";
            cUseCustomPath.Size = new Size(89, 23);
            cUseCustomPath.TabIndex = 5;
            cUseCustomPath.Text = "パスを指定";
            cUseCustomPath.UseVisualStyleBackColor = true;
            cUseCustomPath.CheckedChanged += cUseCustomPath_CheckedChanged;
            // 
            // updateBtn
            // 
            updateBtn.Location = new Point(390, 28);
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
            logTextBox.Location = new Point(12, 385);
            logTextBox.Name = "logTextBox";
            logTextBox.ReadOnly = true;
            logTextBox.ScrollBars = RichTextBoxScrollBars.Vertical;
            logTextBox.Size = new Size(505, 330);
            logTextBox.TabIndex = 7;
            logTextBox.Text = "";
            // 
            // cbMetadata
            // 
            cbMetadata.AutoSize = true;
            cbMetadata.Checked = true;
            cbMetadata.CheckState = CheckState.Checked;
            cbMetadata.Location = new Point(12, 266);
            cbMetadata.Name = "cbMetadata";
            cbMetadata.Size = new Size(141, 23);
            cbMetadata.TabIndex = 10;
            cbMetadata.Text = "メタデータを埋め込む";
            metadataCheck.SetToolTip(cbMetadata, "メタデータを埋め込みます。これはチャプターとinfojsonを含みます。");
            cbMetadata.UseVisualStyleBackColor = true;
            // 
            // cbDisableArchive
            // 
            cbDisableArchive.AutoSize = true;
            cbDisableArchive.Location = new Point(12, 295);
            cbDisableArchive.Name = "cbDisableArchive";
            cbDisableArchive.Size = new Size(157, 23);
            cbDisableArchive.TabIndex = 10;
            cbDisableArchive.Text = "Archiveに書き込まない";
            metadataCheck.SetToolTip(cbDisableArchive, "--download-archive [FILE]が有効でもArchiveに書き込みません");
            cbDisableArchive.UseVisualStyleBackColor = true;
            cbDisableArchive.CheckedChanged += cbDisableArchive_CheckedChanged;
            // 
            // cbOnlyAudio
            // 
            cbOnlyAudio.AutoSize = true;
            cbOnlyAudio.Location = new Point(12, 179);
            cbOnlyAudio.Name = "cbOnlyAudio";
            cbOnlyAudio.Size = new Size(79, 23);
            cbOnlyAudio.TabIndex = 10;
            cbOnlyAudio.Text = "音声のみ";
            metadataCheck.SetToolTip(cbOnlyAudio, "音声のみを取得します");
            cbOnlyAudio.UseVisualStyleBackColor = true;
            cbOnlyAudio.CheckedChanged += cbDisableArchive_CheckedChanged;
            // 
            // cbThumbnail
            // 
            cbThumbnail.AutoSize = true;
            cbThumbnail.Checked = true;
            cbThumbnail.CheckState = CheckState.Checked;
            cbThumbnail.Location = new Point(12, 237);
            cbThumbnail.Name = "cbThumbnail";
            cbThumbnail.Size = new Size(144, 23);
            cbThumbnail.TabIndex = 10;
            cbThumbnail.Text = "サムネイルを埋め込む";
            metadataCheck.SetToolTip(cbThumbnail, "サムネイルを埋め込みます");
            cbThumbnail.UseVisualStyleBackColor = true;
            // 
            // cbSubs
            // 
            cbSubs.AutoSize = true;
            cbSubs.Checked = true;
            cbSubs.CheckState = CheckState.Checked;
            cbSubs.Location = new Point(12, 208);
            cbSubs.Name = "cbSubs";
            cbSubs.Size = new Size(117, 23);
            cbSubs.TabIndex = 10;
            cbSubs.Text = "字幕を埋め込む";
            metadataCheck.SetToolTip(cbSubs, "日本語の字幕を埋め込みます。");
            cbSubs.UseVisualStyleBackColor = true;
            cbSubs.CheckedChanged += cbSubs_CheckedChanged;
            // 
            // cbAutoSubs
            // 
            cbAutoSubs.AutoSize = true;
            cbAutoSubs.Checked = true;
            cbAutoSubs.CheckState = CheckState.Checked;
            cbAutoSubs.Location = new Point(135, 208);
            cbAutoSubs.Name = "cbAutoSubs";
            cbAutoSubs.Size = new Size(145, 23);
            cbAutoSubs.TabIndex = 10;
            cbAutoSubs.Text = "自動字幕も埋め込む";
            metadataCheck.SetToolTip(cbAutoSubs, "自動字幕を埋め込みます。");
            cbAutoSubs.UseVisualStyleBackColor = true;
            // 
            // pasteBtn
            // 
            pasteBtn.Location = new Point(338, 63);
            pasteBtn.Name = "pasteBtn";
            pasteBtn.Size = new Size(91, 29);
            pasteBtn.TabIndex = 11;
            pasteBtn.Text = "ペースト";
            pasteBtn.UseVisualStyleBackColor = true;
            pasteBtn.Click += pasteBtn_Click;
            // 
            // urlResetBtn
            // 
            urlResetBtn.Location = new Point(241, 63);
            urlResetBtn.Name = "urlResetBtn";
            urlResetBtn.Size = new Size(91, 29);
            urlResetBtn.TabIndex = 12;
            urlResetBtn.Text = "リセット";
            urlResetBtn.UseVisualStyleBackColor = true;
            urlResetBtn.Click += urlResetBtn_Click;
            // 
            // selectConfigFolderBtn
            // 
            selectConfigFolderBtn.Location = new Point(392, 147);
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
            toolStrip1.Size = new Size(528, 26);
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
            // cbComments
            // 
            cbComments.AutoSize = true;
            cbComments.Location = new Point(12, 324);
            cbComments.Name = "cbComments";
            cbComments.Size = new Size(129, 23);
            cbComments.TabIndex = 10;
            cbComments.Text = "コメントを書き込む";
            metadataCheck.SetToolTip(cbComments, "動画コメントを取得し、JSONファイルに書き込みます");
            cbComments.UseVisualStyleBackColor = true;
            cbComments.CheckedChanged += cbDisableArchive_CheckedChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(528, 727);
            Controls.Add(lblConf);
            Controls.Add(toolStrip1);
            Controls.Add(selectConfigFolderBtn);
            Controls.Add(urlResetBtn);
            Controls.Add(pasteBtn);
            Controls.Add(cbOnlyAudio);
            Controls.Add(cbAutoSubs);
            Controls.Add(cbSubs);
            Controls.Add(cbThumbnail);
            Controls.Add(cbComments);
            Controls.Add(cbDisableArchive);
            Controls.Add(cbMetadata);
            Controls.Add(logTextBox);
            Controls.Add(updateBtn);
            Controls.Add(cUseCustomPath);
            Controls.Add(browseBtn);
            Controls.Add(savePathTextBox);
            Controls.Add(confCmbBx);
            Controls.Add(dlBtn);
            Controls.Add(urlTextBox);
            KeyPreview = true;
            Name = "MainForm";
            Text = "cs_ydl";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
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
        private CheckBox cbMetadata;
        private ToolTip metadataCheck;
        private CheckBox cbDisableArchive;
        private Button pasteBtn;
        private Button urlResetBtn;
        private Button selectConfigFolderBtn;
        private ToolStrip toolStrip1;
        private ToolStripButton settingToolStripBtn;
        private ToolStripButton aboutToolStripBtn;
        private CheckBox cbOnlyAudio;
        private Label lblConf;
        private CheckBox cbThumbnail;
        private CheckBox cbSubs;
        private CheckBox cbAutoSubs;
        private CheckBox cbComments;
    }
}
