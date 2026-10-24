using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_2___Arv___Zandra_Ekström_SUT26.Models
{
    public class Zebra : Animal
    {
        // Unik egenskap för zebran
        public string StripePattern { get; set; }

        // Konstruktor med standardvärden
        public Zebra(string name = "Ziggy", int age = 4)
            : base(name, age, "Black and white", 350, "Female")
        {
            StripePattern = "Vertical";
        }

        // Unik metod för zebran
        public void Gallop()
        {
            Console.WriteLine($"{Name} galopperar!");
        }

        // Zebrans läte
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} låter: I-AH! I-AH!");
        }
    }

}
