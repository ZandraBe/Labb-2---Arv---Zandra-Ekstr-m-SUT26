using Labb_2___Arv___Zandra_Ekström_SUT26.Models;

namespace Labb_2___Arv___Zandra_Ekström_SUT26
{

    class Program
    {
        static void Main(string[] args)
        {
            // Skapa en tiger
            Tiger tiger = new Tiger();

            tiger.ShowInfo();
            tiger.Eat();
            tiger.Hunt();
            tiger.MakeSound();

            Console.WriteLine();

            // Skapa en elefant
            Elephant elephant = new Elephant();

            elephant.ShowInfo();
            elephant.Eat();
            elephant.SprayWater();
            elephant.MakeSound();


            Console.WriteLine();

            // Skapa en orm
            Snake snake = new Snake();

            snake.ShowInfo();
            snake.Eat();
            snake.Slither();
            snake.MakeSound();

            Console.WriteLine($"Är ormen giftig? {snake.IsVenomous}");


            Console.WriteLine();

            // Skapa en orangutang
            Orangutan orangutan = new Orangutan();

            orangutan.ShowInfo();
            orangutan.Eat();
            orangutan.ClimbTree();
            orangutan.MakeSound();

            Console.WriteLine($"Armlängd: {orangutan.ArmLength} meter");


            Console.WriteLine();

            // Skapa en zebra
            Zebra zebra = new Zebra();

            zebra.ShowInfo();
            zebra.Eat();
            zebra.Gallop();
            zebra.MakeSound();

            Console.WriteLine($"Randmönster: {zebra.StripePattern}");


            Console.WriteLine();

            // Skapa en bengalisk tiger
            BengalTiger bengalTiger = new BengalTiger();

            bengalTiger.ShowInfo();
            bengalTiger.MakeSound();
            bengalTiger.Hunt();
            bengalTiger.Swim();

            Console.WriteLine();

            // Skapa en sibirisk tiger
            SiberianTiger siberianTiger = new SiberianTiger();

            siberianTiger.ShowInfo();
            siberianTiger.MakeSound();
            siberianTiger.Hunt();
            siberianTiger.WalkInSnow();


          
            Console.ReadKey();
        }
    }


}
