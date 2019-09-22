using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DetectionCore.Test
{
    [TestClass]
    public class BrowserTest
    {

        [DataTestMethod]
        [DataRow(Browser.IE8, "Mozilla/4.0 (compatible; MSIE 8.0; Windows NT 5.2; Trident/4.0; .NET CLR 1.1.4322; .NET CLR 2.0.50727; .NET CLR 3.0.4506.2152; .NET CLR 3.5.30729; CognosRCP)")]
        [DataRow(Browser.IE9, "Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 6.1; Trident/5.0; SLCC2; .NET CLR 2.0.50727; .NET CLR 3.5.30729; .NET CLR 3.0.30729; Media Center PC 6.0; .NET4.0C; SiteKiosk 7.8 Build 328)")]
        [DataRow(Browser.IE10, "Mozilla/5.0 (compatible; MSIE 10.0; Windows NT 6.2; WOW64; Trident/6.0; Touch; MALNJS)")]
        [DataRow(Browser.IE11, "Mozilla/5.0 (Windows NT 6.3; WOW64; Trident/7.0; TNJB; rv:11.0) like Gecko")]
        [DataRow(Browser.IE, " Mozilla/4.0 (compatible; MSIE 4.01; Digital AlphaServer 1000A 4/233; Windows NT; Powered By 64-Bit Alpha Processor)")]
        [DataRow(Browser.Edge, "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/39.0.2171.71 Safari/537.36 Edge/12.0")]
        [DataRow(Browser.Chrome, "Mozilla/5.0 (SymbianOS/9.2; U; Series60/3.1 NokiaN81-3/21.0.010 Profile/MIDP-2.0 Google Chrome ) AppleWebKit/413 (KHTML, like Gecko) Safari/413")]
        [DataRow(Browser.Chrome, "Mozilla/5.0 (X11; Linux i686) AppleWebKit/534.24 (KHTML, like Gecko) Chrome/11.0.696.77 Large Screen Safari/534.24 GoogleTV/b61925")]
        [DataRow(Browser.Chrome, "Mozilla/5.0 (iPad; U; CPU OS 4_3_3 like Mac OS X; en-us) AppleWebKit/534.46.0 (KHTML, like Gecko) CriOS/21.0.1180.80 Mobile/8J2 Safari/7534.48.3")]
        [DataRow(Browser.Chrome, "Mozilla/5.0 (Linux; Android 4.4.4; XT1068 Build/KXB21.85-23) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/48.0.2564.95 Mobile Safari/537.36")]
        [DataRow(Browser.FireFox, "SymbianOS/9.4; NokiaC6-00/41.0.010; Series60/5.0 Profile MIDP2.1 Configuration/CLDC-1.1 Series60/5.0 NokiaC6-00/41.0.010 Profile/MIDP-2.1 Configuration/CLDC-1.1 Mozila Firefox")]
        [DataRow(Browser.FireFox, "Mozilla/5.0 (Windows; U; Win95; en-US; rv:1.8.0.12) Gecko/20070508 Firefox/1.5.0.12")]
        [DataRow(Browser.FireFox, "Mozilla/5.0 (Android; Tablet; rv:19.0) Gecko/19.0 Firefox/19.0")]
        [DataRow(Browser.FireFox, "Mozilla/5.0 (masking-agent; rv:14.0) Gecko/20100101 Firefox/14.0.1")]
        [DataRow(Browser.Safari, "Mozilla/5.0 (Macintosh; U; PPC Mac OS X; en) AppleWebKit/124 (KHTML, like Gecko) Safari/125")]
        [DataRow(Browser.Safari, "Mozilla/5.0 (Safari; iPad 2)")]
        [DataRow(Browser.Safari, "Mozilla/5.0 (Windows NT 5.1.1; U; en) AppleWebKit/535.2 (KHTML, like Gecko) xp/234.76 Safari/535.2 01/07")]
        [DataRow(Browser.Safari, "Mozilla/5.0 (Macintosh; PPC Mac OS X 10_5_8) AppleWebKit/534.50.2 (KHTML, like Gecko) Version/5.0.3 Safari/533.19.4")]
        [DataRow(Browser.Opera, "Opera/9.80 (Windows Mobile; WCE; Opera Mobi/WMD-50369; U; en) Presto/2.4.13 Version/10.00")]
        [DataRow(Browser.Opera, "Opera/9.80 (Macintosh; Intel Mac OS X; U; en) Presto/2.6.30 Version/10.63")]
        [DataRow(Browser.Opera, "Opera/9.80 (Windows NT 5.1; Opera Tablet/11648; U; en) Presto/2.7.81 Version/11.00")]
        [DataRow(Browser.Opera, "Opera/9.80 (Android 2.3.3; Linux; Opera Mobi/ADR-1111101157; U; es-ES) Presto/2.9.201 Version/11.50")]
        [DataRow(Browser.Opera, "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/28.0.1500.20 Safari/537.36 OPR/15.0.1147.18 (Edition Next)")]
        public void Test(string browser, string userAgent)
        {
            Assert.AreEqual(browser, userAgent.Browser());
        }
    }
}
