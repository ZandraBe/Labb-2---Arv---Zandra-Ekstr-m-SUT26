using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_2___Arv___Zandra_Ekström_SUT26.Models
{
    public class SiberianTiger : Tiger
    {
        // Unik egenskap
        public double FurThickness { get; set; }

        // Konstruktor
        public SiberianTiger(string name = "Boris", int age = 6)
            : base(name, age)
        {
            FurThickness = 5.0;
        }

        // Unik metod
        public void WalkInSnow()
        {
            Console.WriteLine($"{Name} går genom snön!");
        }
    }

}
