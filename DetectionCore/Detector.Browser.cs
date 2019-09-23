using System.Diagnostics.CodeAnalysis;

namespace DetectionCore
{
    public static partial class Detector
    {
        public static bool TryDetectBrowser(this string userAgent, out BrowserType browserType, [NotNullWhen(true)] out string? browserDetail)
        {
            if (userAgent.TryDetectBrowser(out browserType, out int? version))
            {
                if (version is int nonNullVersion)
                {
                    browserDetail = $"{browserType.ToName()} {nonNullVersion}";
                }
                else
                {
                    browserDetail = browserType.ToName();
                }
                return true;
            }

            browserType = default;
            browserDetail = default;
            return false;
        }

        public static bool TryDetectBrowser(this string userAgent, out BrowserType browserType, out int? version)
        {
            if (userAgent.tryDetectInternetExplore(out browserType, out version))
            {
                return true;
            }
            if (userAgent.tryDetectEdge(out browserType, out version))
            {
                return true;
            }
            if (userAgent.tryDetectOpera(out browserType, out version))
            {
                // method call: before chrome detect
                return true;
            }
            if (userAgent.tryDetectChrome(out browserType, out version))
            {
                return true;
            }
            if (userAgent.tryDetectFireFox(out browserType, out version))
            {
                return true;
            }
            if (userAgent.tryDetectSafari(out browserType, out version))
            {
                return true;
            }
            if (userAgent.tryDetectNintendoBrowser(out browserType, out version))
            {
                return true;
            }

            browserType = default;
            version = default;
            return false;
        }

        private static bool tryDetectInternetExplore(this string userAgent, out BrowserType browserType, out int? version)
        {
            if (userAgent.Contains("MSIE"))
            {
                browserType = BrowserType.InternetExplorer;
                userAgent.searchBrowserVersion("MSIE", 5, out version);
                return true;
            }
            else if (userAgent.Contains("Trident/"))
            {
                browserType = BrowserType.InternetExplorer;

                if (userAgent.Contains("Trident/7"))
                {
                    // IE11 only contain Trident/7
                    version = 11;
                }
                else
                {
                    version = default;
                }

                return true;
            }

            browserType = default;
            version = default;
            return false;
        }

        private static bool tryDetectEdge(this string userAgent, out BrowserType browserType, out int? version)
        {
            if (userAgent.Contains("Edge/"))
            {
                browserType = BrowserType.Edge;
                userAgent.searchBrowserVersion("Edge/", 5, out version);
                return true;
            }

            browserType = default;
            version = default;
            return false;
        }

        private static bool tryDetectChrome(this string userAgent, out BrowserType browserType, out int? version)
        {
            if (userAgent.Contains("Chrome/"))
            {
                browserType = BrowserType.Chrome;
                userAgent.searchBrowserVersion("Chrome/", 5, out version);
                return true;
            }
            if (userAgent.Contains("CriOS/"))
            {
                browserType = BrowserType.Chrome;
                userAgent.searchBrowserVersion("CriOS/", 5, out version);
                return true;
            }

            browserType = default;
            version = default;
            return false;
        }

        private static bool tryDetectFireFox(this string userAgent, out BrowserType browserType, out int? version)
        {
            if (userAgent.Contains("Firefox/"))
            {
                browserType = BrowserType.FireFox;
                userAgent.searchBrowserVersion("Firefox/", 5, out version);
                return true;
            }

            browserType = default;
            version = default;
            return false;
        }

        private static bool tryDetectSafari(this string userAgent, out BrowserType browserType, out int? version)
        {
            if (userAgent.Contains("Safari/") && userAgent.Contains("Version/"))
            {
                browserType = BrowserType.Safari;
                userAgent.searchBrowserVersion("Version/", 5, out version);
                return true;
            }

            browserType = default;
            version = default;
            return false;
        }

        private static bool tryDetectOpera(this string userAgent, out BrowserType browserType, out int? version)
        {
            if (userAgent.Contains("Opera"))
            {
                browserType = BrowserType.Opera;
                userAgent.searchBrowserVersion("Opera", 5, out version);
                return true;
            }
            if (userAgent.Contains("OPR/"))
            {
                browserType = BrowserType.Opera;
                userAgent.searchBrowserVersion("OPR/", 5, out version);
                return true;
            }

            browserType = default;
            version = default;
            return false;
        }

        private static bool tryDetectNintendoBrowser(this string userAgent, out BrowserType browserType, out int? version)
        {
            if (userAgent.Contains("NintendoBrowser/"))
            {
                browserType = BrowserType.NintendoBrowser;
                userAgent.searchBrowserVersion("NintendoBrowser/", 5, out version);
                return true;
            }

            browserType = default;
            version = default;
            return false;
        }

        private static void searchBrowserVersion(this string userAgent, string browserSearchWord, int searchLength, out int? version)
        {
            int versionSearchIndex = userAgent.IndexOf(browserSearchWord) + browserSearchWord.Length;
            if (userAgent.TryGetInt(versionSearchIndex, searchLength, out int foundVersion))
            {
                version = foundVersion;
            }
            else
            {
                version = default;
            }
        }
    }
}
