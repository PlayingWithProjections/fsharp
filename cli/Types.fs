namespace global

open System
open System.Collections.Generic

type Event = { id : string; ``type`` : string; timestamp : DateTime; payload : Dictionary<string,string> }