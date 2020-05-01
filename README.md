# GobiernoApiSharp <img src="https://is5-ssl.mzstatic.com/image/thumb/Purple123/v4/50/c0/59/50c05982-802b-a02b-b13f-f7cc0b5214ac/AppIcon-0-0-1x_U007emarketing-0-0-0-10-0-85-220.png/320x0w.jpg" width="50">



Supports almost every features that Gobierno api has!

-----
GobiernoApiSharp's  - Update date: April 29, 2020 - 

| Target | Branch | Version | Download link |  
| ------ | ------ | ------ | ------ | ------ |
| Nuget | master | v0.0.0.0 | - | - |
| Release | master | v0.0.0.0 | - | |

<!-- 
## Install
Use this library as dll (download from [release page](https://github.com/ramtinak/GobiernoApiSharp/releases)) or reference it from [NuGet](https://www.nuget.org/packages/GobiernoApiSharp/).

Nuget package manager command:
```
PM> Install-Package GobiernoApiSharp
```

Note: this library uses [Json.NET v10.0.3 and above](https://www.nuget.org/packages/Newtonsoft.Json/) for serialize and deserialize json.

## Cross Platform
| Platform | Supported Version |
| ------ | ------ |
| .NET Framework | 4.5.2 |
| .NET Standard | 1.3 |
| .NET Standard | 2.0 |
| .NET Core(UWP) | 10.0.10240 |


 -->

## Features
Some of features:

|    |    |    |    |
| ------ | ------ | ------ | ------ |

| Get Estacionamientos cercanos   |

## Usage
#### Use builder to get Gobierno API instance:

```c#
var api = InstaApiBuilder.CreateBuilder()
                // required
                .SetUser(new UserSessionData(...Your user...))
                .Build();
```
##### Note: every API method has synchronous implementation as well.
<!-- 

## Wiki
Check [Wiki pages](https://github.com/ramtinak/GobiernoApiSharp/wiki) for documentation.

## Version changes

v1.3.4.2
- [Bugfix] for InstaRecentActivityConverter timestamp for different cultures [ by [@estgold](https://github.com/estgold) ]
- [Bugfix] for media products (thx to [@tommasoceschia](https://github.com/tommasoceschia) for report)

v1.3.4.1
- [Bugfix] for UploadStoryPhotoWithUrlAsync
- [Bugfix] for ProductTags (thx to [@tommasoceschia](https://github.com/tommasoceschia) for report)
- [Add] some new properties to InstaProduct class
- [Add] support for Questions in InstaStoryUploadOptions
- [Update] facebook login function
- [Update] story slider

AlezDsGs developers - (c) 2020 | Zemestan 1398. -->
