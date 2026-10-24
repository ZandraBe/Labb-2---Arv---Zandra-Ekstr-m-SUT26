using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_2___Arv___Zandra_Ekström_SUT26.Models
{
    public class Orangutan : Animal
    {
        // unique property for the orangutan
        public double ArmLength { get; set; }

        // constructor with default values for the orangutan
        public Orangutan(string name = "Olle", int age = 8)
            : base(name, age, "Orange", 70, "Hane")
        {
            ArmLength = 1.5;
        }

        // unique method for the orangutan
        public void ClimbTree()
        {
            Console.WriteLine($"{Name} klättrar i ett träd!");
        }

        // orangutans sound
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} låter: HOO HOO!");
        }
    }

}
