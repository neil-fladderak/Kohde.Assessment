using Kohde.Assessment.Interfaces;
using System;

namespace Kohde.Assessment
{
    // Created this Mammal Class from which the Human and Animal classes inherit as they all share the Name and Age fields
    public abstract class Mammal : IMammal
    {
        public string Name { get; set; }
        public int Age  // Added validation for age field
        {
            get
            {
                return Age;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("The age cannot be 0 or less.");
                }
                else
                {
                    Age = value;
                }
            }
        }

        public string GetDetails()
        {
            return $"Name: {Name} Age: {Age}";
        }
    }
}