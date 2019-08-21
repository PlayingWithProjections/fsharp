using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace cli
{
    internal class EventStore
    {
        private readonly Action<Event>[] projections;

        public EventStore(params Action<Event>[] projections)
        {
            this.projections = projections;
        }

        public void Replay(string filePath)
        {
            Console.WriteLine($"reading events from '{filePath}'");
            var text = File.ReadAllText(filePath);

            Console.WriteLine("parsing events ...");
            var events = JsonConvert.DeserializeObject<IEnumerable<Event>>(text);

            Console.WriteLine("replaying events ...");
            foreach (var @event in events)
            {
                foreach (var projection in projections)
                {
                    projection(@event);
                }
                ;
            }
        }
    }
}