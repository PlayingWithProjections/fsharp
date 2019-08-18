using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace cli
{
    internal class EventStore
    {
        private readonly string _filePath;

        public EventStore(string filePath)
        {
            _filePath = filePath;
        }

        public void Replay(Action<Event> projection)
        {
            Console.WriteLine($"reading events from '{_filePath}'");
            var data = File.ReadAllText(_filePath);

            Console.WriteLine("parsing events ...");
            var enumerable = JsonConvert.DeserializeObject<IEnumerable<Event>>(data);

            Console.WriteLine("replaying events ...");
            foreach (var s in enumerable)
            {
                projection(s);
            }
        }
    }
}