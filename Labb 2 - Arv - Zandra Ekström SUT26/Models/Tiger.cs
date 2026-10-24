using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_2___Arv___Zandra_Ekström_SUT26.Models
{

    public class Tiger : Animal
    {
        // Unique feature
        public int StripeCount { get; set; }

        // Constructor with default value
        public Tiger(string name = "Atlas", int age = 5)
            : base(name, age, "Orange", 184, "Hane")
        {
            StripeCount = 100;
        }

        // Unique method for tiger
        public void Hunt()
        {
            Console.WriteLine($"{Name} jagar: vildsvin!");
        }

        // Tigers sound
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} ryter: ROAR!");
        }
    }
 }
