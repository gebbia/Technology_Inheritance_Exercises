using System;
using System.Collections.Generic;
using System.Text;

namespace Technology_Inheritance_Exercises
{
    public class Computer : AbstractEntity
    {
        public double Ram { get; set; }
        public double Storage { get; set; }
        public readonly bool hasKeyboard;

        public Computer(double ram, double storage, bool hasKeyboard)
        {
            Ram = ram;
            Storage = storage;
            this.hasKeyboard = hasKeyboard;
            

        }

        public double AddRam(double extraRam)
        {
            return Ram += extraRam;
        }

        public double AddStorage(double extraStorage)
        {
            return Storage += extraStorage;
        }
    }
}
