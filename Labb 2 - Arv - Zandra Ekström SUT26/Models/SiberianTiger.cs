using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_2___Arv___Zandra_Ekström_SUT26.Models
{
    public class SiberianTiger : Tiger
    {
        // unique property for the Siberian tiger
        public double FurThickness { get; set; }

        // constructor with default values for the Siberian tiger
        public SiberianTiger(string name = "Boris", int age = 6)
            : base(name, age)
        {
            FurThickness = 5.0;
        }

        // unique method for the Siberian tiger
        public void WalkInSnow()
        {
            Console.WriteLine($"{Name} går genom snön!");
        }
    }

}
