# DetectionCore
![](https://meilcli.visualstudio.com/_apis/public/build/definitions/aa83b402-b78d-4038-a10b-93b8509336e0/2/badge)  
A browser detect library for .NET Core(.NET Standard Library1.6)

## Detect

### Browser
- IE(each version, over IE8)
- Edge
- Chrome
- Firefox
- Safari
- Opera

### Platform
- Windows(each consumer version, over WindowsXP)
- MacOS(each version,over Mac OS X v10.5)
- Chrome OS
- Ubuntu
- Mint Linux
- Fedora
- Gentoo
- FreeBSD
- OpenBSD
- NetBSD
- Nintendo Wii
- PlayStation 2
- PlayStation 3
- PlayStation 4
- iOS(each version,over iOS7.0)
- Android(each version,over Android4.0)

## NuGet

[NuGet URL](https://www.nuget.org/packages/DetectionCore/)

~~~
Install-Package DetectionCore
~~~

## Usage
~~~
using DetectionCore;

string userAgent = "~~~~";

string browser = userAgent.Browser();
string platform = userAgent.Platform();
~~~

## License

This library is under MIT License
