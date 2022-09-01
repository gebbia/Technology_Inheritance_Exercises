using System;
using System.Collections.Generic;
using System.Text;

namespace Technology_Inheritance_Exercises
{
    public class Smartphone : Computer
    {
        public double NumberOfSelfies { get; set; }

        public Smartphone(double ram, double storage, bool hasKeyboard, double numberOfSelfies) : base(ram, storage, hasKeyboard)
        {
            NumberOfSelfies = numberOfSelfies;
        }

        public double TakeSelfie(double increaseSelfies)
        {
            return NumberOfSelfies += increaseSelfies;
        }


    }
}
