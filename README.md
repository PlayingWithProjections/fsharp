# Playing with Projections in F#
The project targets `netcoreapp2.1`, which means it should compile on .NET Core 2.1 or later. You can download the latest version here: https://dotnet.microsoft.com/download

## Getting started: Visual Studio or Project Rider
In Visual Studio/Project Rider, specify a command line argument pointing to the json file you want to replay.
e.g. `../../../../../data/basic.json`

## Getting started: cli
For Linux or Mac: `./run.sh [path to json file]` eg `./run.sh ../data/basic.json`
For Windows: `dotnet run --project cli [path to json file]` eg `dotnet run --project cli ..\data\basic.json`