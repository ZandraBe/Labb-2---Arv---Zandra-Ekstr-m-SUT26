using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_2___Arv___Zandra_Ekström_SUT26.Models
{
    public class Snake : Animal
    {
        // unique property for the snake
        public bool IsVenomous { get; set; }

        // constructor with default values for the snake
        public Snake(string name = "Slytherin", int age = 3)
            : base(name, age, "Grön", 5, "Hane")
        {
            IsVenomous = false;
        }

        // unique method for the snake
        public void Slither()
        {
            Console.WriteLine($"{Name} slingrar sig!");
        }

        // the snake makes a hissing sound
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} väser: SSSSS!");
        }
    }

}
