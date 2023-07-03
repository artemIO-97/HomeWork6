using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp2.Program;

namespace ConsoleApp2
{
    internal class Cat : Animal
    {

        public string Name { get; set; }



        public override void Feed(FoodType foodType, int count)
        {
            if (foodType != FoodType.CatFood)
            {
                Console.WriteLine("Meow, I dont eat this!");

                return;
            }

            Satiety += count;
            Console.WriteLine("Om-nom-nom");
        }

        public void SayHelloToCat()
        {
            Console.WriteLine($"Hello, {Name}");
        }
    }
}

