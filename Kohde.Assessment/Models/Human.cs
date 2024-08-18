using System;

namespace Kohde.Assessment
{
    public class Human : Mammal // inherits properties and methods from base class
    {
        public string Gender { get; set; }

        public override string ToString()
        {
            return $"Name: {Name} Age: {Age}";
        }
    }
}