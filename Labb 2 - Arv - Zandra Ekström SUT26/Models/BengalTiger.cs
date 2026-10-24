using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_2___Arv___Zandra_Ekström_SUT26.Models
{
    public class BengalTiger : Tiger
    {
        // unique property for the Bengal tiger
        public string Habitat { get; set; }

        // constructor with default values for the Bengal tiger
        public BengalTiger(string name = "Mike", int age = 4)
            : base(name, age)
        {
            Habitat = "Tropical forest";
        }

        // Unique method for the Bengal tiger
        public void Swim()
        {
            Console.WriteLine($"{Name} simmar i vattnet!");
        }
    }

}
