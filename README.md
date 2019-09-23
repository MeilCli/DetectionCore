# DetectionCore
[![Build Status](https://meilcli.visualstudio.com/DetectionCore/_apis/build/status/MeilCli.DetectionCore?branchName=master)](https://meilcli.visualstudio.com/DetectionCore/_build/latest?definitionId=20&branchName=master) [![NuGet version](https://badge.fury.io/nu/DetectionCore.svg)](https://www.nuget.org/packages/DetectionCore)  
A browser detect library for .NET Standard 2.0.

## NuGet

[NuGet](https://www.nuget.org/packages/DetectionCore/)

~~~
Install-Package DetectionCore
~~~

## Detect

### Browser
- Internet Explorer
- Microsoft Edge
- Chrome
- Firefox
- Safari
- Opera
- NintendoBrowser

```csharp
string userAgent = "mozilla/5.0 (Linux; Android 6.0.1; Nexus 5x build/mtc19t applewebkit/537.36 (KHTML, like Gecko) Chrome/51.0.2702.81 Mobile Safari/537.36";
if (userAgent.TryDetectBrowser(out BrowserType browserType, out string? browserDetail))
{
    Console.WriteLine($"BrowserType: {Enum.GetName(typeof(BrowserType), browserType)}"); // BrowserType: Chrome
    Console.WriteLine($"Browser: {browserDetail}"); // Browser: Chrome 51
}
```

### Platform
- Windows(each consumer version, over WindowsXP)
- MacOS(each version, over Mac OS X v10.5)
- Chrome OS
- Ubuntu
- Mint Linux
- Fedora
- Gentoo
- FreeBSD
- OpenBSD
- NetBSD
- Nintendo Wii
- Nintendo WiiU
- Nintendo Switch
- Nintendo 3DS
- PlayStation 2
- PlayStation 3
- PlayStation 4
- PlayStation Vita
- iOS
- Android
- Windows Phone

```csharp
string userAgent = "mozilla/5.0 (Linux; Android 6.0.1; Nexus 5x build/mtc19t applewebkit/537.36 (KHTML, like Gecko) Chrome/51.0.2702.81 Mobile Safari/537.36";
if (userAgent.TryDetectPlatform(out PlatformType platformType, out string? platformDetail))
{
    Console.WriteLine($"PlatformType: {Enum.GetName(typeof(PlatformType), platformType)}"); // PlatformType: Android
    Console.WriteLine($"Platform: {platformDetail}"); // Android 6.0.1
}
```

## Request Newer Detection
[@MeilCli](https://github.com/MeilCli) don't regularly use this library, but would like to add a new detection if requested.

[Create Issue from Template](https://github.com/MeilCli/DetectionCore/issues/new/choose)

## Develop Environment
- C# 8.0
- Visual Studio 2019 Preview
- .NET Core 2.2 and 3.0

[See Contributing Document](.github/CONTRIBUTING.md)

## License

This library is under MIT License.

### Using
- [System.Memory](https://www.nuget.org/packages/System.Memory/), published by [MIT License](https://github.com/dotnet/corefx/blob/master/LICENSE.TXT)
