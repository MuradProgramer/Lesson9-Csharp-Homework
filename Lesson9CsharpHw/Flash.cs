namespace Lesson9CsharpHw
{
    class Flash : Storage
    {
        public readonly string Speed;

        public readonly double Capacity;

        public double FreeMemory { get; set; }

        public Flash(in double capacity) : base("Flash", "AX302")
        {
            Speed = "USB 3.0";
            Capacity = capacity;
            FreeMemory = capacity;
        }

        public override double GetCapacity() => Capacity;

        public override void Clone(in double mediaSize)
        {
            int result = (mediaSize <= Capacity) ? 1 : (int)((mediaSize % Capacity == 0) ? mediaSize / Capacity : (int)(mediaSize / Capacity) + 1);
            FreeMemory = (mediaSize <= Capacity) ? Capacity - mediaSize : Math.Abs((mediaSize * 1024 - (Capacity * result * 1024)) / 1024);
            Console.WriteLine($"Needed Count Of Media's: {result}");
            Console.WriteLine($"Needed Hours to Copy It: {mediaSize / 3} hours");
        }

        public override double GetFreeMemory() => FreeMemory;

        public override void PrintDeviceInfo()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("---------- DEVICE INFO ----------\n");
            Console.WriteLine("DEVICE NAME: {0}", MediaName);
            Console.WriteLine("DEVICE MODEL: {0}", Model);
            Console.WriteLine("DEVICE SPEED: {0}", Speed);
            Console.WriteLine("DEVICE CAPACITY: {0}", Capacity);
            Console.WriteLine("DEVICE FREE MEMORY: {0}", FreeMemory);
        }
    }
}
