using System;

namespace cs_ydl
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
        public bool EmbedSubs { get; set; }
        public bool EmbedAutoSubs { get; set; }
        public bool EmbedThumbnail { get; set; }
        public bool EmbedMetadata { get; set; }
        public bool WriteComments { get; set; }

        // アーカイブ系
        public bool DisableArchive { get; set; }

        // パス
        public bool UseCustomPath { get; set; }
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
            if (EmbedSubs)
            {
                args.Add("--embed-subs");
                args.Add("--write-subs");
                args.Add("--sub-lang");
                args.Add("ja");
            }

            if (EmbedAutoSubs)
            {
                args.Add("--write-auto-subs");
            }

            if (EmbedThumbnail)
            {
                args.Add("--embed-thumbnail");
            }

            if (EmbedMetadata)
            {
                args.Add("--embed-metadata");
            }

            if (WriteComments)
            {
                args.Add("--write-comments");
            }

            if (DisableArchive)
            {
                args.Add("--no-download-archive");
            }

            if (UseCustomPath && !string.IsNullOrWhiteSpace(SavePath))
            {
                args.Add("-P");
                args.Add(SavePath!);
            }

            args.Add(url);

            return args;
        }


    }

}
