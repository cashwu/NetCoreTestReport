# NetCoreTestReport

- global tool
  - [coverlet.console](https://www.nuget.org/packages/coverlet.console/)
  - [dotnet-reportgenerator-globaltool](https://www.nuget.org/packages/dotnet-reportgenerator-globaltool/)
  
- test project package
  - [coverlet.msbuild](https://www.nuget.org/packages/coverlet.msbuild/)
  
- cmd
  - root folder
    - `dotnet test /p:CollectCoverage=true /p:CoverletOutputFormat=opencover /p:CoverletOutput=../coverage/opencoverLab.xml ./Lib.Tests/Lib.Tests.csproj`
    - `dotnet test /p:CollectCoverage=true /p:CoverletOutputFormat=opencover /p:CoverletOutput=../coverage/opencoverLab2.xml ./Lib2.Tests/Lib2.Tests.csproj`
  - coverage folder
    - `reportgenerator "-reports:opencoverLab.xml;opencoverLab2.xml" -reporttype:Html -targetdir:report`
