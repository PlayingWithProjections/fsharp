using System;
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
            using (var stream = File.OpenText(filePath))
            using (var reader = new JsonTextReader(stream))
            {
                var serializer = new JsonSerializer();
                while (reader.Read())
                {
                    if (reader.TokenType == JsonToken.StartObject)
                    {
                        Project(serializer.Deserialize<Event>(reader));
                    }
                }
            }
        }

        private void Project(Event @event)
        {
            foreach (var projection in projections)
            {
                projection(@event);
            }
        }
    }
}