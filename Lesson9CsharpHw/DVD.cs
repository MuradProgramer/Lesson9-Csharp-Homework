namespace Lesson9CsharpHw
{
    class DVD : Storage
    {
        public readonly int Speed;

        public readonly double Memory;

        public double FreeMemory { get; set; }

        public DVD(in int speed, in bool mod) : base("DVD", "GXT23D")
        {
            Speed = speed;
            FreeMemory = (mod) ? 9.0 : 4.7;
            Memory = (mod) ? 9.0 : 4.7;
        }

        public override double GetCapacity() => Memory;

        public override void Clone(in double mediaSize)
        {
            int result = (mediaSize <= Memory) ? 1 : (int)((mediaSize % Memory == 0) ? mediaSize / Memory : (int)(mediaSize / Memory) + 1);
            FreeMemory = (mediaSize <= Memory) ? Memory - mediaSize : Math.Abs((mediaSize * 1024 - (Memory * result * 1024)) / 1024);
            Console.WriteLine($"Needed Count Of Media's: {result}");
            Console.WriteLine($"Needed Hours to Copy It: {mediaSize * 1024 / (Speed * 10)} hours");            
        }

        public override double GetFreeMemory() => FreeMemory;

        public override void PrintDeviceInfo()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("---------- DEVICE INFO ----------\n");
            Console.WriteLine("DEVICE NAME: {0}", MediaName);
            Console.WriteLine("DEVICE MODEL: {0}", Model);
            Console.WriteLine("DEVICE SPEED READ/WRITE: {0} {1}", Speed, " mb/sec");
            Console.WriteLine("DEVICE CAPACITY: {0}", Memory);
            Console.WriteLine("DEVICE FREE MEMORY: {0}", FreeMemory);
        }
    }
}