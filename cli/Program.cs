using System;

namespace cli
{
    internal class CountEvents
    {
        public int Result { get; private set; }

        public void Projection(Event @event)
        {
            Result++;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var filePath = args[0];
            
            var projector = new CountEvents();
            new EventStore(filePath).Replay(e => projector.Projection(e));
            Console.WriteLine("number of events: {0}", projector.Result);
        }
    }
}