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
            var projector = new CountEvents();
            new EventStore(FilePathFrom(args)).Replay(e => projector.Projection(e));

            Console.WriteLine("number of events: {0}", projector.Result);
        }

        private static string FilePathFrom(string[] args)
        {
            if (args.Length < 1) throw new ArgumentException("Please specify a file to replay");
            return args[0];
        }
    }
}