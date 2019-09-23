using System;

namespace DetectionCore.Sample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello DetectionCore!");

            string userAgent = "mozilla/5.0 (Linux; Android 6.0.1; Nexus 5x build/mtc19t applewebkit/537.36 (KHTML, like Gecko) Chrome/51.0.2702.81 Mobile Safari/537.36";
            if (userAgent.TryDetectBrowser(out BrowserType browserType, out string? browserDetail))
            {
                Console.WriteLine($"BrowserType: {Enum.GetName(typeof(BrowserType), browserType)}");
                Console.WriteLine($"Browser: {browserDetail}");
            }
            if (userAgent.TryDetectPlatform(out PlatformType platformType, out string? platformDetail))
            {
                Console.WriteLine($"PlatformType: {Enum.GetName(typeof(PlatformType), platformType)}");
                Console.WriteLine($"Platform: {platformDetail}");
            }
        }
    }
}
