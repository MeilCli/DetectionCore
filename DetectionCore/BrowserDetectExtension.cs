using CBrowser = DetectionCore.Browser;

namespace DetectionCore
{
    public static class BrowserDetectExtension
    {
        public static string Browser(this string userAgent)
        {
            string ie = userAgent.detectIE();
            if (ie != null)
            {
                return ie;
            }
            string other = userAgent.detectOther();
            if (other != null)
            {
                return other;
            }
            return CBrowser.Unknown;
        }

        private static string detectIE(this string userAgent)
        {
            if (userAgent.Contains("MSIE 8"))
            {
                return CBrowser.IE8;
            }
            if (userAgent.Contains("MSIE 9"))
            {
                return CBrowser.IE9;
            }
            if (userAgent.Contains("MSIE 10"))
            {
                return CBrowser.IE10;
            }
            if (userAgent.Contains("Trident/7"))
            {
                return CBrowser.IE11;
            }
            if (userAgent.Contains("MSIE") || userAgent.Contains("Trident/"))
            {
                return CBrowser.IE;
            }
            return null;
        }

        private static string detectOther(this string userAgent)
        {
            if (userAgent.Contains("Firefox"))
            {
                return CBrowser.FireFox;
            }
            if (userAgent.Contains("OPR/") || userAgent.Contains("Opera/"))
            {
                return CBrowser.Opera;
            }
            if (userAgent.Contains("Safari/") && userAgent.Contains("Version/"))
            {
                return CBrowser.Safari;
            }
            if (userAgent.Contains("Edge/"))
            {
                return CBrowser.Edge;
            }
            if (userAgent.Contains("Chrome") || userAgent.Contains("CriOS/"))
            {
                return CBrowser.Chrome;
            }
            if (userAgent.Contains("Safari"))
            {
                return CBrowser.Safari;
            }
            return null;
        }
    }
}
