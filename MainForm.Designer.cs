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
            updateBtn = new Button();
            logTextBox = new RichTextBox();
            metadataCheck = new ToolTip(components);
            pasteBtn = new Button();
            urlResetBtn = new Button();
            selectConfigFolderBtn = new Button();
            toolStrip1 = new ToolStrip();
            fileToolStripDropDownButton = new ToolStripDropDownButton();
            fileToolStripMenuItemUpdataYdl = new ToolStripMenuItem();
            fileToolStripMenuItemUpdataYdlNightly = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            fileToolStripMenuItemExit = new ToolStripMenuItem();
            settingToolStripBtn = new ToolStripButton();
            aboutToolStripBtn = new ToolStripButton();
            lblConf = new Label();
            btnLogRest = new Button();
            cmbMode = new ComboBox();
            grpPath = new GroupBox();
            cmbUseCustomPath = new ComboBox();
            cbUseOptions = new CheckBox();
            cmbEmbedSubs = new ComboBox();
            cmbEmbedAutoSubs = new ComboBox();
            cmbEmbedThumbnail = new ComboBox();
            cmbEmbedMetadata = new ComboBox();
            cmbWriteComments = new ComboBox();
            cmbEnableArchive = new ComboBox();
            grpArchive = new GroupBox();
            grpMetadata = new GroupBox();
            lblAutoSubs = new Label();
            lblComments = new Label();
            lblMetadata = new Label();
            lblThumbnail = new Label();
            lblSubs = new Label();
            toolStrip1.SuspendLayout();
            grpPath.SuspendLayout();
            grpArchive.SuspendLayout();
            grpMetadata.SuspendLayout();
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
            dlBtn.Size = new Size(125, 72);
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
            savePathTextBox.Location = new Point(127, 22);
            savePathTextBox.Name = "savePathTextBox";
            savePathTextBox.ReadOnly = true;
            savePathTextBox.Size = new Size(452, 26);
            savePathTextBox.TabIndex = 3;
            // 
            // browseBtn
            // 
            browseBtn.Enabled = false;
            browseBtn.Location = new Point(585, 27);
            browseBtn.Name = "browseBtn";
            browseBtn.Size = new Size(39, 23);
            browseBtn.TabIndex = 4;
            browseBtn.Text = "...";
            browseBtn.UseVisualStyleBackColor = true;
            browseBtn.Click += browseBtn_Click;
            // 
            // updateBtn
            // 
            updateBtn.Location = new Point(517, 63);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(125, 29);
            updateBtn.TabIndex = 6;
            updateBtn.Text = "yt-dlpをアップデート";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // logTextBox
            // 
            logTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            logTextBox.Location = new Point(12, 564);
            logTextBox.Name = "logTextBox";
            logTextBox.ReadOnly = true;
            logTextBox.ScrollBars = RichTextBoxScrollBars.Vertical;
            logTextBox.Size = new Size(631, 177);
            logTextBox.TabIndex = 7;
            logTextBox.Text = "";
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
            toolStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripDropDownButton, settingToolStripBtn, aboutToolStripBtn });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(654, 26);
            toolStrip1.TabIndex = 14;
            toolStrip1.Text = "toolStrip1";
            // 
            // fileToolStripDropDownButton
            // 
            fileToolStripDropDownButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            fileToolStripDropDownButton.DropDownItems.AddRange(new ToolStripItem[] { fileToolStripMenuItemUpdataYdl, fileToolStripMenuItemUpdataYdlNightly, toolStripSeparator1, fileToolStripMenuItemExit });
            fileToolStripDropDownButton.Image = (Image)resources.GetObject("fileToolStripDropDownButton.Image");
            fileToolStripDropDownButton.ImageTransparentColor = Color.Magenta;
            fileToolStripDropDownButton.Name = "fileToolStripDropDownButton";
            fileToolStripDropDownButton.Size = new Size(63, 23);
            fileToolStripDropDownButton.Text = "ファイル";
            // 
            // fileToolStripMenuItemUpdataYdl
            // 
            fileToolStripMenuItemUpdataYdl.Name = "fileToolStripMenuItemUpdataYdl";
            fileToolStripMenuItemUpdataYdl.Size = new Size(236, 24);
            fileToolStripMenuItemUpdataYdl.Text = "yt-dlpをアップデート";
            fileToolStripMenuItemUpdataYdl.Click += fileToolStripMenuItemUpdataYdl_Click;
            // 
            // fileToolStripMenuItemUpdataYdlNightly
            // 
            fileToolStripMenuItemUpdataYdlNightly.Name = "fileToolStripMenuItemUpdataYdlNightly";
            fileToolStripMenuItemUpdataYdlNightly.Size = new Size(236, 24);
            fileToolStripMenuItemUpdataYdlNightly.Text = "yt-dlpをアップデート(nightly)";
            fileToolStripMenuItemUpdataYdlNightly.Click += fileToolStripMenuItemUpdataYdlNightly_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(233, 6);
            // 
            // fileToolStripMenuItemExit
            // 
            fileToolStripMenuItemExit.Name = "fileToolStripMenuItemExit";
            fileToolStripMenuItemExit.Size = new Size(236, 24);
            fileToolStripMenuItemExit.Text = "終了";
            fileToolStripMenuItemExit.Click += fileToolStripMenuItemExit_Click;
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
            btnLogRest.Location = new Point(550, 747);
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
            // grpPath
            // 
            grpPath.Controls.Add(cmbUseCustomPath);
            grpPath.Controls.Add(savePathTextBox);
            grpPath.Controls.Add(browseBtn);
            grpPath.Location = new Point(12, 502);
            grpPath.Name = "grpPath";
            grpPath.Size = new Size(630, 56);
            grpPath.TabIndex = 20;
            grpPath.TabStop = false;
            grpPath.Text = "保存フォルダ";
            // 
            // cmbUseCustomPath
            // 
            cmbUseCustomPath.FormattingEnabled = true;
            cmbUseCustomPath.Location = new Point(6, 23);
            cmbUseCustomPath.Name = "cmbUseCustomPath";
            cmbUseCustomPath.Size = new Size(115, 27);
            cmbUseCustomPath.TabIndex = 22;
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
            // cmbEmbedSubs
            // 
            cmbEmbedSubs.FormattingEnabled = true;
            cmbEmbedSubs.Location = new Point(74, 25);
            cmbEmbedSubs.Name = "cmbEmbedSubs";
            cmbEmbedSubs.Size = new Size(106, 27);
            cmbEmbedSubs.TabIndex = 22;
            // 
            // cmbEmbedAutoSubs
            // 
            cmbEmbedAutoSubs.FormattingEnabled = true;
            cmbEmbedAutoSubs.Location = new Point(270, 25);
            cmbEmbedAutoSubs.Name = "cmbEmbedAutoSubs";
            cmbEmbedAutoSubs.Size = new Size(106, 27);
            cmbEmbedAutoSubs.TabIndex = 22;
            // 
            // cmbEmbedThumbnail
            // 
            cmbEmbedThumbnail.FormattingEnabled = true;
            cmbEmbedThumbnail.Location = new Point(74, 58);
            cmbEmbedThumbnail.Name = "cmbEmbedThumbnail";
            cmbEmbedThumbnail.Size = new Size(106, 27);
            cmbEmbedThumbnail.TabIndex = 22;
            // 
            // cmbEmbedMetadata
            // 
            cmbEmbedMetadata.FormattingEnabled = true;
            cmbEmbedMetadata.Location = new Point(74, 91);
            cmbEmbedMetadata.Name = "cmbEmbedMetadata";
            cmbEmbedMetadata.Size = new Size(106, 27);
            cmbEmbedMetadata.TabIndex = 22;
            // 
            // cmbWriteComments
            // 
            cmbWriteComments.FormattingEnabled = true;
            cmbWriteComments.Location = new Point(74, 124);
            cmbWriteComments.Name = "cmbWriteComments";
            cmbWriteComments.Size = new Size(106, 27);
            cmbWriteComments.TabIndex = 22;
            // 
            // cmbEnableArchive
            // 
            cmbEnableArchive.FormattingEnabled = true;
            cmbEnableArchive.Location = new Point(11, 25);
            cmbEnableArchive.Name = "cmbEnableArchive";
            cmbEnableArchive.Size = new Size(121, 27);
            cmbEnableArchive.TabIndex = 22;
            // 
            // grpArchive
            // 
            grpArchive.Controls.Add(cmbEnableArchive);
            grpArchive.Location = new Point(12, 435);
            grpArchive.Name = "grpArchive";
            grpArchive.Size = new Size(264, 61);
            grpArchive.TabIndex = 23;
            grpArchive.TabStop = false;
            grpArchive.Text = "アーカイブ";
            // 
            // grpMetadata
            // 
            grpMetadata.Controls.Add(cmbEmbedSubs);
            grpMetadata.Controls.Add(cmbEmbedAutoSubs);
            grpMetadata.Controls.Add(cmbWriteComments);
            grpMetadata.Controls.Add(cmbEmbedThumbnail);
            grpMetadata.Controls.Add(cmbEmbedMetadata);
            grpMetadata.Controls.Add(lblAutoSubs);
            grpMetadata.Controls.Add(lblComments);
            grpMetadata.Controls.Add(lblMetadata);
            grpMetadata.Controls.Add(lblThumbnail);
            grpMetadata.Controls.Add(lblSubs);
            grpMetadata.Location = new Point(12, 267);
            grpMetadata.Name = "grpMetadata";
            grpMetadata.Size = new Size(499, 162);
            grpMetadata.TabIndex = 24;
            grpMetadata.TabStop = false;
            grpMetadata.Text = "メタデータ";
            // 
            // lblAutoSubs
            // 
            lblAutoSubs.AutoSize = true;
            lblAutoSubs.Location = new Point(199, 28);
            lblAutoSubs.Name = "lblAutoSubs";
            lblAutoSubs.Size = new Size(65, 19);
            lblAutoSubs.TabIndex = 15;
            lblAutoSubs.Text = "自動字幕";
            // 
            // lblComments
            // 
            lblComments.AutoSize = true;
            lblComments.Location = new Point(6, 127);
            lblComments.Name = "lblComments";
            lblComments.Size = new Size(49, 19);
            lblComments.TabIndex = 15;
            lblComments.Text = "コメント";
            // 
            // lblMetadata
            // 
            lblMetadata.AutoSize = true;
            lblMetadata.Location = new Point(6, 94);
            lblMetadata.Name = "lblMetadata";
            lblMetadata.Size = new Size(61, 19);
            lblMetadata.TabIndex = 15;
            lblMetadata.Text = "メタデータ";
            // 
            // lblThumbnail
            // 
            lblThumbnail.AutoSize = true;
            lblThumbnail.Location = new Point(6, 61);
            lblThumbnail.Name = "lblThumbnail";
            lblThumbnail.Size = new Size(64, 19);
            lblThumbnail.TabIndex = 15;
            lblThumbnail.Text = "サムネイル";
            // 
            // lblSubs
            // 
            lblSubs.AutoSize = true;
            lblSubs.Location = new Point(6, 28);
            lblSubs.Name = "lblSubs";
            lblSubs.Size = new Size(37, 19);
            lblSubs.TabIndex = 15;
            lblSubs.Text = "字幕";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(654, 785);
            Controls.Add(grpMetadata);
            Controls.Add(grpArchive);
            Controls.Add(cbUseOptions);
            Controls.Add(grpPath);
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
            grpPath.ResumeLayout(false);
            grpPath.PerformLayout();
            grpArchive.ResumeLayout(false);
            grpMetadata.ResumeLayout(false);
            grpMetadata.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox urlTextBox;
        private Button dlBtn;
        private ComboBox confCmbBx;
        private TextBox savePathTextBox;
        private Button browseBtn;
        private Button updateBtn;
        private RichTextBox logTextBox;
        private ToolTip metadataCheck;
        private Button pasteBtn;
        private Button urlResetBtn;
        private Button selectConfigFolderBtn;
        private ToolStrip toolStrip1;
        private ToolStripButton settingToolStripBtn;
        private ToolStripButton aboutToolStripBtn;
        private Label lblConf;
        private Button btnLogRest;
        private ComboBox cmbMode;
        private GroupBox grpPath;
        private CheckBox cbUseOptions;
        private ToolStripDropDownButton fileToolStripDropDownButton;
        private ToolStripMenuItem fileToolStripMenuItemUpdataYdl;
        private ToolStripMenuItem fileToolStripMenuItemUpdataYdlNightly;
        private ToolStripMenuItem fileToolStripMenuItemExit;
        private ToolStripSeparator toolStripSeparator1;
        private ComboBox cmbEmbedSubs;
        private ComboBox cmbEmbedAutoSubs;
        private ComboBox cmbEmbedThumbnail;
        private ComboBox cmbEmbedMetadata;
        private ComboBox cmbWriteComments;
        private ComboBox cmbEnableArchive;
        private ComboBox cmbUseCustomPath;
        private GroupBox grpArchive;
        private GroupBox grpMetadata;
        private Label lblComments;
        private Label lblMetadata;
        private Label lblThumbnail;
        private Label lblSubs;
        private Label lblAutoSubs;
    }
}
