using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_2___Arv___Zandra_Ekström_SUT26.Models
{

    public abstract class Animal
    {
        // properties that all animals share
        public string Name { get; set; }
        public int Age { get; set; }
        public string Color { get; set; }
        public double Weight { get; set; }
        public string Gender { get; set; }

        // Constructor
        public Animal(string name, int age, string color,
                      double weight, string gender)
        {
            Name = name;
            Age = age;
            Color = color;
            Weight = weight;
            Gender = gender;
        }

        // Methods all animals share
        public void Eat()
        {
            Console.WriteLine($"{Name} äter.");
        }

        public void Sleep()
        {
            Console.WriteLine($"{Name} sover.");
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Namn: {Name}");
            Console.WriteLine($"Ålder: {Age}");
            Console.WriteLine($"Färg: {Color}");
            Console.WriteLine($"Vikt: {Weight} kg");
            Console.WriteLine($"Kön: {Gender}");
        }

        // Abstract because all animals make different sounds.        
        public abstract void MakeSound();
    }
}