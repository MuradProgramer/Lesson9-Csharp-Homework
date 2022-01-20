using Lesson9CsharpHw;

Console.Title = "B A C K U P";

Storage flash = new Flash(8);
Storage hdd = new HDD(1024);
Storage dvd = new DVD(100, true);

//flash.PrintDeviceInfo();
//Console.WriteLine();
//hdd.PrintDeviceInfo();
//Console.WriteLine();
//dvd.PrintDeviceInfo();
//Console.WriteLine();



//flash.Clone(1.2);
//Console.WriteLine( $"FREE MEMORY: {flash.GetFreeMemory()} GB" );

//flash.Clone(17);
//Console.WriteLine( $"FREE MEMORY: {flash.GetFreeMemory()} GB" );



//hdd.Clone(16.7);
//Console.WriteLine( $"FREE MEMORY: {hdd.GetFreeMemory()} GB" );

//hdd.Clone(2050);
//Console.WriteLine( $"FREE MEMORY: {hdd.GetFreeMemory()} GB" );



//dvd.Clone(4);
//Console.WriteLine( $"FREE MEMORY: {dvd.GetFreeMemory()} GB" );

//dvd.Clone(19);
//Console.WriteLine($"FREE MEMORY: {dvd.GetFreeMemory()} GB");
