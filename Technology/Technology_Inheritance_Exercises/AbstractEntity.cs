using System;
using System.Collections.Generic;
using System.Text;

namespace Technology_Inheritance_Exercises
{
    public class AbstractEntity
    {
        public int Id { get; set; }
        private static int nextId = 1;

        public AbstractEntity()
        {
            Id = nextId;
            nextId++;
        }
    }
}
