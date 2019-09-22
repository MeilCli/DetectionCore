using System.Diagnostics.CodeAnalysis;

namespace DetectionCore
{
    public static partial class Detector
    {
        public static bool TryDetectPlatform(this string userAgent, out PlatformType platformType, [NotNullWhen(true)] out string? platformDetail)
        {
            if (userAgent.tryDetectWindows(out platformType, out platformDetail))
            {
                return true;
            }
            if (userAgent.tryDetectMac(out platformType, out platformDetail))
            {
                return true;
            }
            if (userAgent.tryDetectLinux(out platformType, out platformDetail))
            {
                return true;
            }
            if (userAgent.tryDetectGame(out platformType, out platformDetail))
            {
                return true;
            }
            if (userAgent.tryDetectIOS(out platformType, out platformDetail))
            {
                return true;
            }
            if (userAgent.tryDetectAndroid(out platformType, out platformDetail))
            {
                return true;
            }

            platformType = default;
            platformDetail = default;
            return false;
        }

        private static bool tryDetectWindows(this string userAgent, out PlatformType platformType, [NotNullWhen(true)] out string? platformDetail)
        {
            if (userAgent.Contains("Windows"))
            {
                platformType = PlatformType.Windows;
                platformDetail = PlatformConstant.Windows;

                if (userAgent.Contains("Windows NT 5.2") || userAgent.Contains("Windows NT 5.1"))
                {
                    platformDetail = PlatformConstant.WindowsXP;
                }
                if (userAgent.Contains("Windows NT 6.0"))
                {
                    platformDetail = PlatformConstant.WindowsVista;
                }
                if (userAgent.Contains("Windows NT 6.1"))
                {
                    platformDetail = PlatformConstant.Windows7;
                }
                if (userAgent.Contains("Windows NT 6.2"))
                {
                    platformDetail = PlatformConstant.Windows8;
                }
                if (userAgent.Contains("Windows NT 6.3"))
                {
                    platformDetail = PlatformConstant.Windows8_1;
                }
                if (userAgent.Contains("Windows NT 10"))
                {
                    platformDetail = PlatformConstant.Windows10;
                }

                return true;
            }

            platformType = default;
            platformDetail = default;
            return false;
        }

        private static bool tryDetectMac(this string userAgent, out PlatformType platformType, [NotNullWhen(true)]out string? platformDetail)
        {
            if (userAgent.Contains("Mac OS X") && userAgent.Contains("iPhone") == false && userAgent.Contains("iPad") == false)
            {
                platformType = PlatformType.MacOS;
                platformDetail = PlatformConstant.MacOS;

                if (userAgent.Contains("Mac OS X 10_5") || userAgent.Contains("Mac OS X 10.5"))
                {
                    platformDetail = PlatformConstant.MacOS10_5;
                }
                if (userAgent.Contains("Mac OS X 10_6") || userAgent.Contains("Mac OS X 10.6"))
                {
                    platformDetail = PlatformConstant.MacOS10_6;
                }
                if (userAgent.Contains("Mac OS X 10_7") || userAgent.Contains("Mac OS X 10.7"))
                {
                    platformDetail = PlatformConstant.MacOS10_7;
                }
                if (userAgent.Contains("Mac OS X 10_8") || userAgent.Contains("Mac OS X 10.8"))
                {
                    platformDetail = PlatformConstant.MacOS10_8;
                }
                if (userAgent.Contains("Mac OS X 10_9") || userAgent.Contains("Mac OS X 10.9"))
                {
                    platformDetail = PlatformConstant.MacOS10_9;
                }
                if (userAgent.Contains("Mac OS X 10_10") || userAgent.Contains("Mac OS X 10.10"))
                {
                    platformDetail = PlatformConstant.MacOS10_10;
                }
                if (userAgent.Contains("Mac OS X 10_11") || userAgent.Contains("Mac OS X 10.11"))
                {
                    platformDetail = PlatformConstant.MacOS10_11;
                }
                if (userAgent.Contains("Mac OS X 10_12") || userAgent.Contains("Mac OS X 10.12"))
                {
                    platformDetail = PlatformConstant.MacOS10_12;
                }
                // ToDo: Add Platform
                return true;
            }

            platformType = default;
            platformDetail = default;
            return false;
        }

        private static bool tryDetectLinux(this string userAgent, out PlatformType platformType, [NotNullWhen(true)]out string? platformDetail)
        {
            if (userAgent.Contains("CrOS"))
            {
                platformType = PlatformType.ChromeOS;
                platformDetail = PlatformConstant.ChromeOS;
                return true;
            }
            if (userAgent.Contains("Ubuntu"))
            {
                platformType = PlatformType.Ubuntu;
                platformDetail = PlatformConstant.Ubuntu;
                return true;
            }
            if (userAgent.Contains("Mint/"))
            {
                platformType = PlatformType.MintLinux;
                platformDetail = PlatformConstant.MintLinux;
                return true;
            }
            if (userAgent.Contains("Fedora/"))
            {
                platformType = PlatformType.Fedora;
                platformDetail = PlatformConstant.Fedora;
                return true;
            }
            if (userAgent.Contains("Gentoo"))
            {
                platformType = PlatformType.Gentoo;
                platformDetail = PlatformConstant.Gentoo;
                return true;
            }
            if (userAgent.Contains("FreeBSD"))
            {
                platformType = PlatformType.FreeBSD;
                platformDetail = PlatformConstant.FreeBSD;
                return true;
            }
            if (userAgent.Contains("OpenBSD"))
            {
                platformType = PlatformType.OpenBSD;
                platformDetail = PlatformConstant.OpenBSD;
                return true;
            }
            if (userAgent.Contains("NetBSD"))
            {
                platformType = PlatformType.NetBSD;
                platformDetail = PlatformConstant.NetBSD;
                return true;
            }
            if (userAgent.Contains("Linux") && userAgent.Contains("Android") == false)
            {
                platformType = PlatformType.Linux;
                platformDetail = PlatformConstant.Linux;
                return true;
            }

            platformType = default;
            platformDetail = default;
            return false;
        }

        private static bool tryDetectGame(this string userAgent, out PlatformType platformType, [NotNullWhen(true)] out string? platformDetail)
        {
            if (userAgent.Contains("Nintendo Wii"))
            {
                platformType = PlatformType.Wii;
                platformDetail = PlatformConstant.Wii;
                return true;
            }
            if (userAgent.Contains("PS2"))
            {
                platformType = PlatformType.PlayStation2;
                platformDetail = PlatformConstant.PlayStation2;
                return true;
            }
            if (userAgent.Contains("PLAYSTATION 3"))
            {
                platformType = PlatformType.PlayStation3;
                platformDetail = PlatformConstant.PlayStation3;
                return true;
            }
            if (userAgent.Contains("PlayStation 4"))
            {
                platformType = PlatformType.PlayStation4;
                platformDetail = PlatformConstant.PlayStation4;
                return true;
            }

            platformType = default;
            platformDetail = default;
            return false;
        }

        private static bool tryDetectIOS(this string userAgent, out PlatformType platformType, [NotNullWhen(true)] out string? platformDetail)
        {
            if (userAgent.Contains("iPhone") == false && userAgent.Contains("iPad") == false)
            {
                platformType = default;
                platformDetail = default;
                return false;
            }

            platformType = PlatformType.iOS;

            if (userAgent.searchPlatformVersion("OS", 7, out string? foundVersion))
            {
                platformDetail = $"{PlatformConstant.iOS} {foundVersion}";
            }
            else
            {
                platformDetail = PlatformConstant.iOS;
            }

            return true;
        }

        private static bool tryDetectAndroid(this string userAgent, out PlatformType platformType, [NotNullWhen(true)] out string? platformDetail)
        {
            if (userAgent.Contains("Android"))
            {
                platformType = PlatformType.Android;

                if (userAgent.searchPlatformVersion("Android", 7, out string? foundVersion))
                {
                    platformDetail = $"{PlatformConstant.Android} {foundVersion}";
                }
                else
                {
                    platformDetail = PlatformConstant.Android;
                }

                return true;
            }
            else if (userAgent.Contains("android"))
            {
                platformType = PlatformType.Android;

                if (userAgent.searchPlatformVersion("android", 7, out string? foundVersion))
                {
                    platformDetail = $"{PlatformConstant.Android} {foundVersion}";
                }
                else
                {
                    platformDetail = PlatformConstant.Android;
                }

                return true;
            }

            platformType = default;
            platformDetail = default;
            return false;
        }

        private static bool searchPlatformVersion(this string userAgent, string browserSearchWord, int searchLength, [NotNullWhen(true)]out string? version)
        {
            int versionSearchIndex = userAgent.IndexOf(browserSearchWord);
            while (0 <= versionSearchIndex)
            {
                if (userAgent.TryGetVersion(versionSearchIndex + browserSearchWord.Length, searchLength, out string foundVersion))
                {
                    version = foundVersion.Replace("_", ".");
                    return true;
                }
                versionSearchIndex = userAgent.IndexOf(browserSearchWord, versionSearchIndex + browserSearchWord.Length);
            }

            version = default;
            return false;
        }
    }
}
