module StreamReader

open Newtonsoft.Json
 open System.IO

let read<'t> filePath = seq {
    use stream = File.OpenText filePath
    use reader = new JsonTextReader(stream)
    let serializer = JsonSerializer()
    while reader.Read() do
        if reader.TokenType = JsonToken.StartObject then
            yield serializer.Deserialize<'t>(reader)
}
