using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace cli
{
    internal class EventStore
    {
        private readonly string filePath;

        public EventStore(string filePath)
        {
            this.filePath = filePath;
        }

        public void Replay(Action<Event> projection)
        {
            Console.WriteLine($"reading events from '{filePath}'");
            var text = File.ReadAllText(filePath);

            Console.WriteLine("parsing events ...");
            var events = JsonConvert.DeserializeObject<IEnumerable<Event>>(text);

            Console.WriteLine("replaying events ...");
            foreach (var @event in events) projection(@event);
        }
    }
}