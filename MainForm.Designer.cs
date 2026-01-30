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
            cbDisableMetadata = new CheckBox();
            metadataCheck = new ToolTip(components);
            cbDisableArchive = new CheckBox();
            pasteBtn = new Button();
            urlResetBtn = new Button();
            selectConfigFolderBtn = new Button();
            toolStrip1 = new ToolStrip();
            settingToolStripBtn = new ToolStripButton();
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
            dlBtn.Size = new Size(83, 59);
            dlBtn.TabIndex = 8;
            dlBtn.Text = "DL";
            dlBtn.Click += dlBtn_Click;
            // 
            // confCmbBx
            // 
            confCmbBx.DropDownStyle = ComboBoxStyle.DropDownList;
            confCmbBx.FormattingEnabled = true;
            confCmbBx.Location = new Point(12, 130);
            confCmbBx.Name = "confCmbBx";
            confCmbBx.Size = new Size(374, 27);
            confCmbBx.TabIndex = 2;
            confCmbBx.SelectedIndexChanged += confCmbBx_SelectedIndexChanged;
            // 
            // savePathTextBox
            // 
            savePathTextBox.Enabled = false;
            savePathTextBox.Location = new Point(107, 227);
            savePathTextBox.Name = "savePathTextBox";
            savePathTextBox.ReadOnly = true;
            savePathTextBox.Size = new Size(365, 26);
            savePathTextBox.TabIndex = 3;
            // 
            // browseBtn
            // 
            browseBtn.Enabled = false;
            browseBtn.Location = new Point(478, 230);
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
            cUseCustomPath.Location = new Point(12, 230);
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
            logTextBox.Location = new Point(12, 259);
            logTextBox.Name = "logTextBox";
            logTextBox.ReadOnly = true;
            logTextBox.ScrollBars = RichTextBoxScrollBars.Vertical;
            logTextBox.Size = new Size(505, 351);
            logTextBox.TabIndex = 7;
            logTextBox.Text = "";
            // 
            // cbDisableMetadata
            // 
            cbDisableMetadata.AutoSize = true;
            cbDisableMetadata.Location = new Point(12, 201);
            cbDisableMetadata.Name = "cbDisableMetadata";
            cbDisableMetadata.Size = new Size(164, 23);
            cbDisableMetadata.TabIndex = 10;
            cbDisableMetadata.Text = "メタデータを埋め込まない";
            metadataCheck.SetToolTip(cbDisableMetadata, "※ このオプションは .conf に --embed-metadata がある場合でも無効化できます");
            cbDisableMetadata.UseVisualStyleBackColor = true;
            // 
            // cbDisableArchive
            // 
            cbDisableArchive.AutoSize = true;
            cbDisableArchive.Location = new Point(12, 173);
            cbDisableArchive.Name = "cbDisableArchive";
            cbDisableArchive.Size = new Size(157, 23);
            cbDisableArchive.TabIndex = 10;
            cbDisableArchive.Text = "Archiveに書き込まない";
            cbDisableArchive.UseVisualStyleBackColor = true;
            cbDisableArchive.CheckedChanged += cbDisableArchive_CheckedChanged;
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
            selectConfigFolderBtn.Location = new Point(392, 134);
            selectConfigFolderBtn.Name = "selectConfigFolderBtn";
            selectConfigFolderBtn.Size = new Size(39, 23);
            selectConfigFolderBtn.TabIndex = 13;
            selectConfigFolderBtn.Text = "...";
            selectConfigFolderBtn.UseVisualStyleBackColor = true;
            selectConfigFolderBtn.Click += selectConfigFolderBtn_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { settingToolStripBtn });
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
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(528, 622);
            Controls.Add(toolStrip1);
            Controls.Add(selectConfigFolderBtn);
            Controls.Add(urlResetBtn);
            Controls.Add(pasteBtn);
            Controls.Add(cbDisableArchive);
            Controls.Add(cbDisableMetadata);
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
        private CheckBox cbDisableMetadata;
        private ToolTip metadataCheck;
        private CheckBox cbDisableArchive;
        private Button pasteBtn;
        private Button urlResetBtn;
        private Button selectConfigFolderBtn;
        private ToolStrip toolStrip1;
        private ToolStripButton settingToolStripBtn;
    }
}
