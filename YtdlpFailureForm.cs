namespace cs_ydl
{
    internal sealed class YtdlpFailureForm : Form
    {
        public YtdlpFailureForm(string warningText, string errorText)
        {
            Text = "yt-dlp エラー";
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            ClientSize = new Size(370, 115);

            var messageLabel = new Label
            {
                AutoSize = true,
                Location = new Point(16, 16),
                Text = "yt-dlp の実行中にエラーが発生しました。"
            };

            var warningButton = CreateCopyButton(
                "WARNING をコピー",
                warningText,
                new Point(16, 52));
            var errorButton = CreateCopyButton(
                "ERROR をコピー",
                errorText,
                new Point(149, 52));
            var closeButton = new Button
            {
                DialogResult = DialogResult.OK,
                Location = new Point(270, 52),
                Size = new Size(84, 30),
                Text = "閉じる"
            };

            Controls.AddRange(new Control[]
            {
                messageLabel,
                warningButton,
                errorButton,
                closeButton
            });
            AcceptButton = closeButton;
        }

        private static Button CreateCopyButton(
            string text,
            string message,
            Point location)
        {
            var button = new Button
            {
                Enabled = !string.IsNullOrWhiteSpace(message),
                Location = location,
                Size = new Size(120, 30),
                Text = text
            };

            button.Click += (_, _) => Clipboard.SetText(message);
            return button;
        }
    }
}
