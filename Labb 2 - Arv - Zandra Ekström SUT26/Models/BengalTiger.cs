using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_2___Arv___Zandra_Ekström_SUT26.Models
{
    public class BengalTiger : Tiger
    {
        // Unik egenskap
        public string Habitat { get; set; }

        // Konstruktor
        public BengalTiger(string name = "Rajah", int age = 4)
            : base(name, age)
        {
            Habitat = "Tropical forest";
        }

        // Unik metod
        public void Swim()
        {
            Console.WriteLine($"{Name} simmar i vattnet!");
        }
    }

}
