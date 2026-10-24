using Labb_2___Arv___Zandra_Ekström_SUT26.Models;

namespace Labb_2___Arv___Zandra_Ekström_SUT26
{

    class Program
    {
        static void Main(string[] args)
        {
            // create a tiger
            Tiger tiger = new Tiger();

            tiger.ShowInfo();
            tiger.Eat();
            tiger.Sleep();
            tiger.Hunt();
            tiger.MakeSound();


            Console.WriteLine();

            // create a elephant
            Elephant elephant = new Elephant();

            elephant.ShowInfo();
            elephant.Eat();
            elephant.Sleep();
            elephant.SprayWater();
            elephant.MakeSound();


            Console.WriteLine();

            // create a snake
            Snake snake = new Snake();

            snake.ShowInfo();
            snake.Eat();
            snake.Sleep();
            snake.Slither();
            snake.MakeSound();

            Console.WriteLine($"Är ormen giftig? {snake.IsVenomous}");


            Console.WriteLine();

            // create a orangutan
            Orangutan orangutan = new Orangutan();

            orangutan.ShowInfo();
            orangutan.Eat();
            orangutan.Sleep();
            orangutan.ClimbTree();
            orangutan.MakeSound();

            Console.WriteLine($"Armlängd: {orangutan.ArmLength} meter");


            Console.WriteLine();

            // create a zebra
            Zebra zebra = new Zebra();

            zebra.ShowInfo();
            zebra.Eat();
            zebra.Sleep();
            zebra.Gallop();
            zebra.MakeSound();

            Console.WriteLine($"Randmönster: {zebra.StripePattern}");


            Console.WriteLine();

            // create a Bengal tiger
            BengalTiger bengalTiger = new BengalTiger();

            bengalTiger.ShowInfo();
            bengalTiger.Sleep();
            bengalTiger.MakeSound();            
            bengalTiger.Hunt();
            bengalTiger.Swim();
            

            Console.WriteLine();

            // create a Siberian tiger
            SiberianTiger siberianTiger = new SiberianTiger();

            siberianTiger.ShowInfo();
            siberianTiger.MakeSound();
            siberianTiger.Sleep();
            siberianTiger.Hunt();
            siberianTiger.WalkInSnow();


          
            Console.ReadKey();
        }
    }


}
