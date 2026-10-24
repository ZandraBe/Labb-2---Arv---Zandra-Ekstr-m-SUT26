using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_2___Arv___Zandra_Ekström_SUT26.Models
{
    public class Orangutan : Animal
    {
        // Unik egenskap för orangutangen
        public double ArmLength { get; set; }

        // Konstruktor med standardvärden
        public Orangutan(string name = "Olle", int age = 8)
            : base(name, age, "Orange", 70, "Male")
        {
            ArmLength = 1.5;
        }

        // Unik metod för orangutangen
        public void ClimbTree()
        {
            Console.WriteLine($"{Name} klättrar i ett träd!");
        }

        // Orangutangens läte
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} låter: HOO HOO!");
        }
    }

}
