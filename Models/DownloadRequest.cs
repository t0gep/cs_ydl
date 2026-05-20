namespace cs_ydl.Models
{
    public class DownloadRequest
    {
        public string Url { get; set; } = "";

        public YtdlpOptions Options { get; set; }
            = new();
    }
}