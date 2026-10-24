using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_2___Arv___Zandra_Ekström_SUT26.Models
{
    public class Elephant : Animal
    {
        // Unique feature
        public double TrunkLength { get; set; }

        // Constructor with default value
        public Elephant(string name = "Dumbo", int age = 10)
            : base(name, age, "Grå", 2894, "Hona")
        {
            TrunkLength = 2.0;
        }

        // Unique method for elephant
        public void SprayWater()
        {
            Console.WriteLine($"{Name} sprutar vatten med sin snabel!");
        }

        // Elephant noice
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} trumpetar: TOOOT!");
        }
    }

}
