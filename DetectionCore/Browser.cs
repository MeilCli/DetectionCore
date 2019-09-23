namespace DetectionCore
{
    public enum BrowserType
    {
        Unknown = 0,
        InternetExplorer,
        Edge,
        Chrome,
        FireFox,
        Safari,
        Opera,
        NintendoBrowser
    }

    public static class BrowserConstant
    {
        public const string InternetExplorer = "Internet Explorer";
        public const string Edge = "Microsoft Edge";
        public const string Chrome = "Chrome";
        public const string FireFox = "FireFox";
        public const string Safari = "Safari";
        public const string Opera = "Opera";
        public const string NintendoBrowser = "NintendoBrowser";
        public const string Unknown = "Unknown";
    }

    public static class BrowserTypeExtension
    {
        public static string ToName(this BrowserType browserType)
        {
            return browserType switch
            {
                BrowserType.InternetExplorer => BrowserConstant.InternetExplorer,
                BrowserType.Edge => BrowserConstant.Edge,
                BrowserType.Chrome => BrowserConstant.Chrome,
                BrowserType.FireFox => BrowserConstant.FireFox,
                BrowserType.Safari => BrowserConstant.Safari,
                BrowserType.Opera => BrowserConstant.Opera,
                BrowserType.NintendoBrowser => BrowserConstant.NintendoBrowser,
                _ => BrowserConstant.Unknown
            };
        }
    }
}
