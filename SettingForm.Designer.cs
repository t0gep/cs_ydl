namespace cs_ydl
{
    partial class SettingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ytdlpPathTextBox = new TextBox();
            browseYtdlpBtn = new Button();
            saveBtn = new Button();
            ytdlpPathLabel = new Label();
            SuspendLayout();
            // 
            // ytdlpPathTextBox
            // 
            ytdlpPathTextBox.AllowDrop = true;
            ytdlpPathTextBox.Location = new Point(12, 52);
            ytdlpPathTextBox.Name = "ytdlpPathTextBox";
            ytdlpPathTextBox.Size = new Size(287, 26);
            ytdlpPathTextBox.TabIndex = 0;
            ytdlpPathTextBox.DragDrop += ytdlpPathTextBox_DragDrop;
            ytdlpPathTextBox.DragEnter += ytdlpPathTextBox_DragEnter;
            // 
            // browseYtdlpBtn
            // 
            browseYtdlpBtn.Location = new Point(305, 55);
            browseYtdlpBtn.Name = "browseYtdlpBtn";
            browseYtdlpBtn.Size = new Size(31, 23);
            browseYtdlpBtn.TabIndex = 1;
            browseYtdlpBtn.Text = "...";
            browseYtdlpBtn.UseVisualStyleBackColor = true;
            browseYtdlpBtn.Click += browseYtdlpBtn_Click;
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(225, 408);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(111, 30);
            saveBtn.TabIndex = 2;
            saveBtn.Text = "設定を保存";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // ytdlpPathLabel
            // 
            ytdlpPathLabel.AutoSize = true;
            ytdlpPathLabel.Location = new Point(12, 30);
            ytdlpPathLabel.Name = "ytdlpPathLabel";
            ytdlpPathLabel.Size = new Size(141, 19);
            ytdlpPathLabel.TabIndex = 3;
            ytdlpPathLabel.Text = "yt-dlp.exeのパスを指定";
            // 
            // SettingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(348, 450);
            Controls.Add(ytdlpPathLabel);
            Controls.Add(saveBtn);
            Controls.Add(browseYtdlpBtn);
            Controls.Add(ytdlpPathTextBox);
            Name = "SettingForm";
            Text = "設定";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox ytdlpPathTextBox;
        private Button browseYtdlpBtn;
        private Button saveBtn;
        private Label ytdlpPathLabel;
    }
}