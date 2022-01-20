using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9CsharpHw
{
    abstract class Storage
    {
        public string MediaName { get; set; }

        public string Model { get; set; } 
        
        protected Storage(string mediaName, string model)
        {
            MediaName = mediaName;
            Model = model;
        }

        abstract public double GetCapacity();

        abstract public void Clone(in double mediaSize);

        abstract public double GetFreeMemory();

        abstract public void PrintDeviceInfo();

        public override string ToString() => 
            $"DEVICE NAME: {MediaName}\nDEVICE MODEL: {Model}";

    }
}
