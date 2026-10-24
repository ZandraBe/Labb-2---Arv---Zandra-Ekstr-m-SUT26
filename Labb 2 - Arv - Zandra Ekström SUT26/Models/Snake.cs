using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_2___Arv___Zandra_Ekström_SUT26.Models
{
    public class Snake : Animal
    {
        // Unik egenskap för ormen
        public bool IsVenomous { get; set; }

        // Konstruktor med standardvärden
        public Snake(string name = "Snape", int age = 3)
            : base(name, age, "Green", 5, "Male")
        {
            IsVenomous = false;
        }

        // Unik metod för ormen
        public void Slither()
        {
            Console.WriteLine($"{Name} slingrar sig!");
        }

        // Ormens läte
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} väser: SSSSS!");
        }
    }

}
