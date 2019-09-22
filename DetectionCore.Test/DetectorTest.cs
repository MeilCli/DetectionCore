using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DetectionCore.Test
{
    [TestClass]
    public class DetectorTest
    {
        [DataTestMethod]
        /* 
         * Internet Explorer
         */
        [DataRow(
            "Mozilla/4.0 (compatible; MSIE 4.01; Digital AlphaServer 1000A 4/233; Windows NT; Powered By 64-Bit Alpha Processor)",
            BrowserType.InternetExplorer,
            4,
            PlatformType.Windows,
            PlatformConstant.Windows
        )]
        [DataRow(
            "Mozilla/4.0 (compatible; MSIE 5.01; Windows 98)",
            BrowserType.InternetExplorer,
            5,
            PlatformType.Windows,
            PlatformConstant.Windows
        )]
        [DataRow(
            "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1; SV1; .NET CLR 2.0.50727; .NET CLR 3.0.4506.2152; .NET CLR 3.5.30729)",
            BrowserType.InternetExplorer,
            6,
            PlatformType.Windows,
            PlatformConstant.WindowsXP
        )]
        [DataRow(
            "Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 6.1; WOW64; Trident/7.0; SLCC2; .NET CLR 2.0.50727; .NET CLR 3.5.30729; .NET CLR 3.0.30729; .NET4.0C; .NET4.0E)",
            BrowserType.InternetExplorer,
            7,
            PlatformType.Windows,
            PlatformConstant.Windows7
        )]
        [DataRow(
            "Mozilla/4.0 (compatible; MSIE 8.0; Windows NT 5.2; Trident/4.0; .NET CLR 1.1.4322; .NET CLR 2.0.50727; .NET CLR 3.0.4506.2152; .NET CLR 3.5.30729; CognosRCP)",
            BrowserType.InternetExplorer,
            8,
            PlatformType.Windows,
            PlatformConstant.WindowsXP
        )]
        [DataRow(
            "Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 6.1; Trident/5.0; SLCC2; .NET CLR 2.0.50727; .NET CLR 3.5.30729; .NET CLR 3.0.30729; Media Center PC 6.0; .NET4.0C; SiteKiosk 7.8 Build 328)",
            BrowserType.InternetExplorer,
            9,
            PlatformType.Windows,
            PlatformConstant.Windows7
        )]
        [DataRow(
            "Mozilla/5.0 (compatible; MSIE 10.0; Windows NT 6.2; WOW64; Trident/6.0; Touch; MALNJS)",
            BrowserType.InternetExplorer,
            10,
            PlatformType.Windows,
            PlatformConstant.Windows8
        )]
        [DataRow(
            "Mozilla/5.0 (Windows NT 6.3; WOW64; Trident/7.0; TNJB; rv:11.0) like Gecko",
            BrowserType.InternetExplorer,
            11,
            PlatformType.Windows,
            PlatformConstant.Windows8_1
        )]

        /* 
         * Edge 
         */
        [DataRow(
            "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/39.0.2171.71 Safari/537.36 Edge/12.0",
            BrowserType.Edge,
            12,
            PlatformType.Windows,
            PlatformConstant.Windows10
        )]
        [DataRow(
            "Mozilla/5.0 (Windows NT 10.0; WebView/3.0) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/46.0.2486.0 Safari/537.36 Edge/13.10586",
            BrowserType.Edge,
            13,
            PlatformType.Windows,
            PlatformConstant.Windows10
        )]
        [DataRow(
            "Mozilla/5.0 (Windows Phone 10.0; Android 4.2.1; ; DG-W10M) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/46.0.2486.0 Mobile Safari/537.36 Edge/13.10586",
            BrowserType.Edge,
            13,
            PlatformType.Windows,
            PlatformConstant.Windows
        )]
        [DataRow(
            "Mozilla/5.0 (Windows Phone 10.0; Android 6.0.1; Microsoft; Lumia 640 LTE) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/51.0.2704.79 Mobile Safari/537.36 Edge/14.14393",
            BrowserType.Edge,
            14,
            PlatformType.Windows,
            PlatformConstant.Windows
        )]

        /* 
         * Chrome 
         */
        [DataRow(
            "Mozilla/5.0 (X11; Linux i686) AppleWebKit/534.24 (KHTML, like Gecko) Chrome/11.0.696.77 Large Screen Safari/534.24 GoogleTV/b61925",
            BrowserType.Chrome,
            11,
            PlatformType.Linux,
            PlatformConstant.Linux
        )]
        [DataRow(
            "Mozilla/5.0 (iPad; U; CPU OS 4_3_3 like Mac OS X; en-us) AppleWebKit/534.46.0 (KHTML, like Gecko) CriOS/21.0.1180.80 Mobile/8J2 Safari/7534.48.3",
            BrowserType.Chrome,
            21,
            PlatformType.iOS,
            "iOS 4.3.3"
        )]
        [DataRow(
            "Mozilla/5.0 (Linux; Android 4.4.4; XT1068 Build/KXB21.85-23) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/48.0.2564.95 Mobile Safari/537.36",
            BrowserType.Chrome,
            48,
            PlatformType.Android,
            "Android 4.4.4"
        )]

        /*
         * FireFox 
         */
        [DataRow(
            "Mozilla/5.0 (Windows; U; Win95; en-US; rv:1.8.0.12) Gecko/20070508 Firefox/1.5.0.12",
            BrowserType.FireFox,
            1,
            PlatformType.Windows,
            PlatformConstant.Windows
        )]
        [DataRow(
            "Mozilla/5.0 (Android; Tablet; rv:19.0) Gecko/19.0 Firefox/19.0",
            BrowserType.FireFox,
            19,
            PlatformType.Android,
            PlatformConstant.Android
        )]
        [DataRow(
            "Mozilla/5.0 (X11; Ubuntu; Linux x86_64; rv:32.0) Gecko/20100101 Firefox/32.0",
            BrowserType.FireFox,
            32,
            PlatformType.Ubuntu,
            PlatformConstant.Ubuntu
        )]

        /* 
         * Safari 
         */
        [DataRow(
            "Mozilla/5.0 (Macintosh; PPC Mac OS X 10_5_8) AppleWebKit/534.50.2 (KHTML, like Gecko) Version/5.0.3 Safari/533.19.4",
            BrowserType.Safari,
            5,
            PlatformType.MacOS,
            PlatformConstant.MacOS10_5
        )]
        [DataRow(
            "Mozilla/5.0 (iPhone; CPU iPhone OS 11_2_1 like Mac OS X) AppleWebKit/604.4.7 (KHTML, like Gecko) Version/11.0 Mobile/15C153 Safari/604.1",
            BrowserType.Safari,
            11,
            PlatformType.iOS,
            "iOS 11.2.1"
        )]
        [DataRow(
            "Mozilla/5.0 (iPad; CPU OS 10_1 like Mac OS X) AppleWebKit/602.2.14 (KHTML, like Gecko) Version/10.0 Mobile/14B72 Safari/602.1",
            BrowserType.Safari,
            10,
            PlatformType.iOS,
            "iOS 10.1"
        )]
        [DataRow(
            "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_12_6) AppleWebKit/604.4.7 (KHTML, like Gecko) Version/11.0.2 Safari/604.4.7",
            BrowserType.Safari,
            11,
            PlatformType.MacOS,
            PlatformConstant.MacOS10_12
        )]

        /* 
         * Opera 
         */
        [DataRow(
            "Opera/9.80 (Windows Mobile; WCE; Opera Mobi/WMD-50369; U; en) Presto/2.4.13 Version/10.00",
            BrowserType.Opera,
            9,
            PlatformType.Windows,
            PlatformConstant.Windows
        )]
        [DataRow(
            "Opera/9.80 (Android 2.3.3; Linux; Opera Mobi/ADR-1111101157; U; es-ES) Presto/2.9.201 Version/11.50",
            BrowserType.Opera,
            9,
            PlatformType.Android,
            "Android 2.3.3"
        )]
        [DataRow(
            "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/28.0.1500.20 Safari/537.36 OPR/15.0.1147.18 (Edition Next)",
            BrowserType.Opera,
            15,
            PlatformType.Windows,
            PlatformConstant.Windows7
        )]

        /* Windows */
        [DataRow(
            "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1; Maxthon; .NET CLR 1.1.4322)",
            BrowserType.InternetExplorer,
            6,
            PlatformType.Windows,
            PlatformConstant.WindowsXP
        )]
        [DataRow(
            "Mozilla/5.0 (Windows; U; Windows NT 6.0; en-US; Valve Steam GameOverlay/1911; ) AppleWebKit/535.15 (KHTML, like Gecko) Chrome/18.0.989.0 Safari/535.11",
            BrowserType.Chrome,
            18,
            PlatformType.Windows,
            PlatformConstant.WindowsVista
        )]
        [DataRow(
            "Mozilla/4.0 (compatible; MSIE 8.0; Windows NT 6.1; WOW64; Trident/4.0; Avant Browser; SLCC2; .NET CLR 2.0.50727; .NET CLR 3.5.30729; .NET CLR 3.0.30729; Media Center PC 6.0; CPDTDF; Avant Browser)",
            BrowserType.InternetExplorer,
            8,
            PlatformType.Windows,
            PlatformConstant.Windows7
        )]
        [DataRow(
            "Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 6.2; Trident/5.0; SlimBrowser)",
            BrowserType.InternetExplorer,
            9,
            PlatformType.Windows,
            PlatformConstant.Windows8
        )]
        [DataRow(
            "Mozilla/5.0 (Windows NT 6.3; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Vivaldi/1.0.73.3 Chrome/40.0.2214.82 Safari/537.36",
            BrowserType.Chrome,
            40,
            PlatformType.Windows,
            PlatformConstant.Windows8_1
        )]
        [DataRow(
            "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/39.0.2171.71 Safari/537.36 Edge/12.0",
            BrowserType.Edge,
            12,
            PlatformType.Windows,
            PlatformConstant.Windows10
        )]

        /* 
         * Mac
         */
        [DataRow(
            "Mozilla/5.0 (Macintosh; PPC Mac OS X 10.5; rv:13.0) Gecko/20120528 Firefox/13.0 TenFourFox/G5",
            BrowserType.FireFox,
            13,
            PlatformType.MacOS,
            PlatformConstant.MacOS10_5
        )]
        [DataRow(
            "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_6_8) AppleWebKit/535.7 (KHTML, like Gecko) Chrome/16.0.912.77 Safari/535.7",
            BrowserType.Chrome,
            16,
            PlatformType.MacOS,
            PlatformConstant.MacOS10_6
        )]
        [DataRow(
            "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_7_4) AppleWebKit/534.56.5 (KHTML, like Gecko) Safari/unknown",
            BrowserType.Unknown,
            null,
            PlatformType.MacOS,
            PlatformConstant.MacOS10_7
        )]
        [DataRow(
            "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_8_2) AppleWebKit/536.26.14 (KHTML, like Gecko) (Coda, like Safari)",
            BrowserType.Unknown,
            null,
            PlatformType.MacOS,
            PlatformConstant.MacOS10_8
        )]
        [DataRow(
            "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_9_5) AppleWebKit/601.7.8 (KHTML, like Gecko) Version/9.1.3 Safari/537.86.8",
            BrowserType.Safari,
            9,
            PlatformType.MacOS,
            PlatformConstant.MacOS10_9
        )]
        [DataRow(
            "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_10_5) AppleWebKit/602.1.50 (KHTML, like Gecko) Version/10.0 Safari/602.1.50",
            BrowserType.Safari,
            10,
            PlatformType.MacOS,
            PlatformConstant.MacOS10_10
        )]
        [DataRow(
            "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_11_6) AppleWebKit/602.1.50 (KHTML, like Gecko) Version/10.0 Safari/602.1.50",
            BrowserType.Safari,
            10,
            PlatformType.MacOS,
            PlatformConstant.MacOS10_11
        )]
        [DataRow(
            "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_12) AppleWebKit/602.1.50 (KHTML, like Gecko) Version/10.0 Safari/602.1.50",
            BrowserType.Safari,
            10,
            PlatformType.MacOS,
            PlatformConstant.MacOS10_12
        )]

        /* 
         * Linux 
         */
        [DataRow(
            "Mozilla/5.0 (X11; CrOS i686 14.811.2011) AppleWebKit/535.1 (KHTML, like Gecko) Chrome/14.0.834.0 Safari/535.1",
            BrowserType.Chrome,
            14,
            PlatformType.ChromeOS,
            PlatformConstant.ChromeOS
        )]
        [DataRow(
            "Mozilla/5.0 (X11; Ubuntu; Linux x86_64; rv:10.0.2) Gecko/20100101 Firefox/10.0.2",
            BrowserType.FireFox,
            10,
            PlatformType.Ubuntu,
            PlatformConstant.Ubuntu
        )]
        [DataRow(
            "Mozilla/5.0 (X11; U; Linux x86_64; en-US; rv:1.9.1.1) Gecko/20090716 Linux Mint/7 (Gloria) Firefox/3.5.1",
            BrowserType.FireFox,
            3,
            PlatformType.MintLinux,
            PlatformConstant.MintLinux
        )]
        [DataRow(
            "Mozilla/5.0 (X11; U; Linux i686; fr; rv:1.9.0.10) Gecko/2009042708 Fedora/3.0.10-1.fc10 Firefox/3.0.10",
            BrowserType.FireFox,
            3,
            PlatformType.Fedora,
            PlatformConstant.Fedora
        )]
        [DataRow(
            "Mozilla/5.0 (X11; U; Linux x86_64; de; rv:1.9.0.11) Gecko/2009070611 Gentoo Firefox/3.0.11",
            BrowserType.FireFox,
            3,
            PlatformType.Gentoo,
            PlatformConstant.Gentoo
        )]
        [DataRow(
            "Mozilla/5.0 (X11; U; FreeBSD amd64; en-US; rv:1.8.1.20) Gecko/20090422 Firefox/2.0.0.20 Kazehakase/0.5.4",
            BrowserType.FireFox,
            2,
            PlatformType.FreeBSD,
            PlatformConstant.FreeBSD
        )]
        [DataRow(
            "Mozilla/5.0 (X11; U; OpenBSD amd64; pt-BR; rv:1.9.2a1pre) Gecko/20060916 Firefox/2.0b2",
            BrowserType.FireFox,
            2,
            PlatformType.OpenBSD,
            PlatformConstant.OpenBSD
        )]
        [DataRow(
            "Mozilla/5.0 (X11; NetBSD amd64; rv:16.0) Gecko/20121102 Firefox/16.0",
            BrowserType.FireFox,
            16,
            PlatformType.NetBSD,
            PlatformConstant.NetBSD
        )]
        [DataRow(
            "Mozilla/5.0 (X11; U; Linux x86_64; en-us) AppleWebKit/531.2+ (KHTML, like Gecko) Version/5.0 Safari/531.2+",
            BrowserType.Safari,
            5,
            PlatformType.Linux,
            PlatformConstant.Linux
        )]

        /* 
         * Game 
         */
        [DataRow(
            "Opera/9.10 (Nintendo Wii; U; ; 1621; ja)",
            BrowserType.Opera,
            9,
            PlatformType.Wii,
            PlatformConstant.Wii
        )]
        [DataRow(
            "Mozilla/4.0 (PS2; PlayStation BB Navigator 1.0) NetFront/3.0",
            BrowserType.Unknown,
            null,
            PlatformType.PlayStation2,
            PlatformConstant.PlayStation2
        )]
        [DataRow(
            "Mozilla/5.0 (PLAYSTATION 3; 1.00)",
            BrowserType.Unknown,
            null,
            PlatformType.PlayStation3,
            PlatformConstant.PlayStation3
        )]
        [DataRow(
            "Mozilla/5.0 (PlayStation 4 1.52) AppleWebKit/536.26 (KHTML, like Gecko)",
            BrowserType.Unknown,
            null,
            PlatformType.PlayStation4,
            PlatformConstant.PlayStation4
        )]

        /* 
         * iOS 
         */
        [DataRow(
            "Mozilla/5.0 (iPhone; CPU iPhone OS 7_0 like Mac OS X) AppleWebKit/537.51.1 (KHTML, like Gecko) GSA/5.1.42378 Mobile/11A466 Safari/9537.53",
            BrowserType.Unknown,
            null,
            PlatformType.iOS,
            "iOS 7.0"
        )]
        [DataRow(
            "Mozilla/5.0 (iPad; CPU OS 7_1_1 like Mac OS X) AppleWebKit/537.51.2 (KHTML, like Gecko) Version/7.0 Mobile/11D201 Safari/9537.53",
            BrowserType.Safari,
            7,
            PlatformType.iOS,
            "iOS 7.1.1"
        )]
        [DataRow(
            "Mozilla/5.0 (iPhone; CPU OS 8_0 like Mac OS X) AppleWebKit/600.1.3 (KHTML, like Gecko) Version/8.0 Mobile/12A4345d Safari/600.1.4",
            BrowserType.Safari,
            8,
            PlatformType.iOS,
            "iOS 8.0"
        )]
        [DataRow(
            "Mozilla/5.0 (iPad; CPU OS 9_0 like Mac OS X) AppleWebKit/600.1.4 (KHTML, like Gecko) GSA/8.0.57838 Mobile/13A344 Safari/600.1.4",
            BrowserType.Unknown,
            null,
            PlatformType.iOS,
            "iOS 9.0"
        )]
        [DataRow(
            "Mozilla/5.0 (iPhone; CPU iPhone OS 10_0_1 like Mac OS X) AppleWebKit/602.1.50 (KHTML, like Gecko) Version/10.0 Mobile/14A403 Safari/602.1",
            BrowserType.Safari,
            10,
            PlatformType.iOS,
            "iOS 10.0.1"
        )]

        /* 
         * Android 
         */
        [DataRow(
            "Mozilla/5.0 (Linux; Android 4.1.1; HTC One X Build/JRO03C) AppleWebKit/535.19 (KHTML, like Gecko) Chrome/18.0.1025.166 Mobile Safari/535.19",
            BrowserType.Chrome,
            18,
            PlatformType.Android,
            "Android 4.1.1"
        )]
        [DataRow(
            "Mozilla/5.0 (android; u; android 5.0; id-en) presto/2.8.89 UNTRUSTED/1.0",
            BrowserType.Unknown,
            null,
            PlatformType.Android,
            "Android 5.0"
        )]
        [DataRow(
            "mozilla/5.0 (Linux; Android 6.0.1; Nexus 5x build/mtc19t applewebkit/537.36 (KHTML, like Gecko) Chrome/51.0.2702.81 Mobile Safari/537.36",
            BrowserType.Chrome,
            51,
            PlatformType.Android,
            "Android 6.0.1"
        )]
        public void Test(string userAgent, BrowserType browserType, int? browserVersion, PlatformType platformType, string? platformDetail)
        {
            bool detectBrowser = userAgent.TryDetectBrowser(out BrowserType actualBrowserType, out int? actualBrowserVersion);
            Assert.AreEqual(browserType != BrowserType.Unknown, detectBrowser);
            Assert.AreEqual(browserType, actualBrowserType);
            Assert.AreEqual(browserVersion, actualBrowserVersion);

            bool detectPlatform = userAgent.TryDetectPlatform(out PlatformType actualPlatformType, out string? actualPlatformDetail);
            Assert.AreEqual(platformType != PlatformType.Unknown, detectPlatform);
            Assert.AreEqual(platformType, actualPlatformType);
            Assert.AreEqual(platformDetail, actualPlatformDetail);
        }
    }
}
