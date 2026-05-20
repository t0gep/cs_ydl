using System;

namespace cs_ydl.Models
{
    public enum DownloadMode
    {
        Normal,
        AudioOnly,
        ThumbnailOnly,
        MetadataOnly
    }

    public class YtdlpOptions
    {
        // .conf用
        public string? ConfigPath { get; set; }

        public DownloadMode Mode { get; set; } = DownloadMode.Normal;
        
        // メタデータ系
        public OptionState EmbedSubs { get; set; } = OptionState.Default;
        public OptionState EmbedAutoSubs { get; set; } = OptionState.Default;
        public OptionState EmbedThumbnail { get; set; } = OptionState.Default;
        public OptionState EmbedMetadata { get; set; }  
        public OptionState WriteComments { get; set; } = OptionState.Default;
        // アーカイブ系
        public OptionState EnableArchive { get; set; } = OptionState.Default;

        // パス
        public OptionState UseCustomPath { get; set; } = OptionState.Default;
        public string? SavePath { get; set; }

        public List<string> BuildArguments(string url)
        {
            var args = new List<string>();

            if (!string.IsNullOrWhiteSpace(ConfigPath))
            {
                args.Add("--config-location");
                args.Add(ConfigPath);
            }

            switch (Mode)
            {
                case DownloadMode.AudioOnly:
                    args.Add("-x");
                    break;
                case DownloadMode.ThumbnailOnly:
                    args.Add("--skip-download");
                    args.Add("--write-thumbnail");
                    break;
                case DownloadMode.MetadataOnly:
                    args.Add("--skip-download");
                    args.Add("--write-info-json");
                    break;
            }

            switch (EmbedSubs)
            {
                case OptionState.Enabled:
                    args.Add("--embed-subs");
                    args.Add("--write-subs");
                    args.Add("--sub-lang");
                    args.Add("ja");
                    break;

                case OptionState.Disabled:
                    args.Add("--no-embed-subs");
                    args.Add("--no-write-subs");
                    break;

                case OptionState.Default:
                    // configに従う
                    break;
            }

            switch (EmbedAutoSubs)
            {
                case OptionState.Enabled:
                    args.Add("--write-auto-subs");
                    args.Add("--sub-lang");
                    args.Add("ja");
                    break;

                case OptionState.Disabled:
                    args.Add("--no-write-auto-subs");
                    break;

                case OptionState.Default:
                    // configに従う
                    break;
            }

            switch (EmbedThumbnail)
            {
                case OptionState.Enabled:
                    args.Add("--embed-thumbnail");
                    break;

                case OptionState.Disabled:
                    args.Add("--no-embed-thumbnail");
                    break;

                case OptionState.Default:
                    // configに従う
                    break;
            }

            switch (EmbedMetadata)
            {
                case OptionState.Enabled:
                    args.Add("--embed-metadata");
                    break;

                case OptionState.Disabled:
                    args.Add("--no-embed-metadata");
                    break;

                case OptionState.Default:
                    // configに従う
                    break;
            }

            switch (WriteComments)
            {
                case OptionState.Enabled:
                    args.Add("--write-comments");
                    break;

                case OptionState.Disabled:
                    args.Add("--no-write-comments");
                    break;

                case OptionState.Default:
                    // configに従う
                    break;
            }

            switch (EnableArchive)
            {
                case OptionState.Enabled:
                    args.Add("--download-archive");
                    break;

                case OptionState.Disabled:
                    args.Add("--no-download-archive");
                    break;

                case OptionState.Default:
                    // configに従う
                    break;
            }

            if (UseCustomPath == OptionState.Enabled
                && !string.IsNullOrWhiteSpace(SavePath))
            {
                args.Add("-P");
                args.Add(SavePath!);
            }

            args.Add(url);

            return args;
        }


    }

}
