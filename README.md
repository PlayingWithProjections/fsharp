# Playing with Projections in F#
The project targets `netcoreapp2.1`, which means it should compile on .NET Core 2.1 or later. You can download the latest version here: https://dotnet.microsoft.com/download

## Getting started: Visual Studio or JetBrains Rider
In Visual Studio/JetBrains Rider, specify a command line argument pointing to the json file you want to replay. If you have the data installed adjacent to a clone of this repo, that'll be: `../../../../../data/basic.json`

## Getting started: cli
For Windows, use the `dotnet` tool directly: `dotnet run --project cli [path to json file]` eg `dotnet run --project cli ..\data\basic.json`
For Linux or Mac, there's an invocation wrapper: `./run.sh [path to json file]` eg `./run.sh ../data/basic.json`
