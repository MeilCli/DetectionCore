using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CPlatform = DetectionCore.Platform;

namespace DetectionCore {
    public static class PlatformDetectExtension {

        public static string Platform(this string userAgent) {
            string windows = userAgent.detectWindows();
            if(windows != null) {
                return windows;
            }
            string mac = userAgent.detectMac();
            if(mac != null) {
                return mac;
            }
            string linux = userAgent.detectLinux();
            if(linux != null) {
                return linux;
            }
            string game = userAgent.detectGame();
            if(game != null) {
                return game;
            }
            string ios = userAgent.detectIOS();
            if(ios != null) {
                return ios;
            }
            string android = userAgent.detectAndroid();
            if(android != null) {
                return android;
            }
            return CPlatform.Unknown;
        }

        private static string detectWindows(this string userAgent) {
            if(userAgent.Contains("Windows NT 5")) {
                return CPlatform.WindowsXP;
            }
            if(userAgent.Contains("Windows NT 6.0")) {
                return CPlatform.WindowsVista;
            }
            if(userAgent.Contains("Windows NT 6.1")) {
                return CPlatform.Windows7;
            }
            if(userAgent.Contains("Windows NT 6.2")) {
                return CPlatform.Windows8;
            }
            if(userAgent.Contains("Windows NT 6.3")) {
                return CPlatform.Windows81;
            }
            if(userAgent.Contains("Windows NT 10")) {
                return CPlatform.Windows10;
            }
            if(userAgent.Contains("Windows")) {
                return CPlatform.Windows;
            }
            return null;
        }

        private static string detectMac(this string userAgent) {
            if(userAgent.Contains("Mac OS X 10_5") || userAgent.Contains("Mac OS X 10.5")) {
                return CPlatform.MacOs105;
            }
            if(userAgent.Contains("Mac OS X 10_6") || userAgent.Contains("Mac OS X 10.6")) {
                return CPlatform.MacOs106;
            }
            if(userAgent.Contains("Mac OS X 10_7") || userAgent.Contains("Mac OS X 10.7")) {
                return CPlatform.MacOs107;
            }
            if(userAgent.Contains("Mac OS X 10_8") || userAgent.Contains("Mac OS X 10.8")) {
                return CPlatform.MacOs108;
            }
            if(userAgent.Contains("Mac OS X 10_9") || userAgent.Contains("Mac OS X 10.9")) {
                return CPlatform.MacOs109;
            }
            if(userAgent.Contains("Mac OS X 10_10") || userAgent.Contains("Mac OS X 10.10")) {
                return CPlatform.MacOs1010;
            }
            if(userAgent.Contains("Mac OS X 10_11") || userAgent.Contains("Mac OS X 10.11")) {
                return CPlatform.MacOs1011;
            }
            if(userAgent.Contains("Mac OS X 10_12") || userAgent.Contains("Mac OS X 10.12")) {
                return CPlatform.MacOs1012;
            }
            if(userAgent.Contains("Mac OS X") && userAgent.Contains("iPhone") == false && userAgent.Contains("iPad") == false) {
                return CPlatform.MacOs;
            }
            return null;
        }

        private static string detectLinux(this string userAgent) {
            if(userAgent.Contains("CrOS")) {
                return CPlatform.ChromeOs;
            }
            if(userAgent.Contains("Ubuntu")) {
                return CPlatform.Ubuntu;
            }
            if(userAgent.Contains("Mint/")) {
                return CPlatform.MintLinux;
            }
            if(userAgent.Contains("Fedora/")) {
                return CPlatform.Fedora;
            }
            if(userAgent.Contains("Gentoo")) {
                return CPlatform.Gentoo;
            }
            if(userAgent.Contains("FreeBSD")) {
                return CPlatform.FreeBSD;
            }
            if(userAgent.Contains("OpenBSD")) {
                return CPlatform.OpenBSD;
            }
            if(userAgent.Contains("NetBSD")) {
                return CPlatform.NetBSD;
            }
            if(userAgent.Contains("Linux") && userAgent.Contains("Android") == false) {
                return CPlatform.Linux;
            }
            return null;
        }

        private static string detectGame(this string userAgent) {
            if(userAgent.Contains("Nintendo Wii")) {
                return CPlatform.Wii;
            }
            if(userAgent.Contains("PS2")) {
                return CPlatform.PS2;
            }
            if(userAgent.Contains("PLAYSTATION 3")) {
                return CPlatform.PS3;
            }
            if(userAgent.Contains("PlayStation 4")) {
                return CPlatform.PS4;
            }
            return null;
        }

        private static string detectIOS(this string userAgent) {
            if(userAgent.Contains("iPhone") == false && userAgent.Contains("iPad") == false) {
                return null;
            }
            if(userAgent.Contains("OS 7_0")) {
                return CPlatform.IOS70;
            }
            if(userAgent.Contains("OS 7_1")) {
                return CPlatform.IOS71;
            }
            if(userAgent.Contains("OS 8_0")) {
                return CPlatform.IOS80;
            }
            if(userAgent.Contains("OS 8_1")) {
                return CPlatform.IOS81;
            }
            if(userAgent.Contains("OS 8_2")) {
                return CPlatform.IOS82;
            }
            if(userAgent.Contains("OS 8_3")) {
                return CPlatform.IOS83;
            }
            if(userAgent.Contains("OS 8_4")) {
                return CPlatform.IOS84;
            }
            if(userAgent.Contains("OS 9_0")) {
                return CPlatform.IOS90;
            }
            if(userAgent.Contains("OS 9_1")) {
                return CPlatform.IOS91;
            }
            if(userAgent.Contains("OS 9_2")) {
                return CPlatform.IOS92;
            }
            if(userAgent.Contains("OS 9_3")) {
                return CPlatform.IOS93;
            }
            if(userAgent.Contains("OS 10_0")) {
                return CPlatform.IOS100;
            }
            return CPlatform.IOS;
        }

        private static string detectAndroid(this string userAgent) {
            if(userAgent.Contains("Android 4.0") || userAgent.Contains("android 4.0")) {
                return CPlatform.Android40;
            }
            if(userAgent.Contains("Android 4.1") || userAgent.Contains("android 4.1")) {
                return CPlatform.Android41;
            }
            if(userAgent.Contains("Android 4.2") || userAgent.Contains("android 4.2")) {
                return CPlatform.Android42;
            }
            if(userAgent.Contains("Android 4.3") || userAgent.Contains("android 4.3")) {
                return CPlatform.Android43;
            }
            if(userAgent.Contains("Android 4.4") || userAgent.Contains("android 4.4")) {
                return CPlatform.Android44;
            }
            if(userAgent.Contains("Android 5.0") || userAgent.Contains("android 5.0")) {
                return CPlatform.Android50;
            }
            if(userAgent.Contains("Android 5.1") || userAgent.Contains("android 5.1")) {
                return CPlatform.Android51;
            }
            if(userAgent.Contains("Android 6.0") || userAgent.Contains("android 6.0")) {
                return CPlatform.Android60;
            }
            if(userAgent.Contains("Android 7.0") || userAgent.Contains("android 7.0")) {
                return CPlatform.Android70;
            }
            if(userAgent.Contains("Android") || userAgent.Contains("android")) {
                return CPlatform.Android;
            }
            return null;
        }
    }
}
