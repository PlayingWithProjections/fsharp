using System;
using System.Collections.Generic;

namespace cli
{
    internal class Event
    {
        public string Id {get; set;}
        public string Type {get; set;}
        public DateTime Timestamp {get; set;}
        public Dictionary<string, string> Payload{get;set;}
    }
}