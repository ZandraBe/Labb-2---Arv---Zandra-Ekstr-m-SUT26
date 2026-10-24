using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_2___Arv___Zandra_Ekström_SUT26.Models
{
    public class Zebra : Animal
    {
        // unique property for the zebra
        public string StripePattern { get; set; }

        // constructor with default values for the zebra
        public Zebra(string name = "Zandra", int age = 4)
            : base(name, age, "Black and white", 350, "Female")
        {
            StripePattern = "Vertical";
        }

        // unique method for the zebra
        public void Gallop()
        {
            Console.WriteLine($"{Name} galopperar!");
        }

        // zebra's sound
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} låter: I-AH! I-AH!");
        }
    }

}
