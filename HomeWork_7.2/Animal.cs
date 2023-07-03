using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp2.Program;

namespace ConsoleApp2
{
    internal class Animal
    {
        protected double Satiety { get; set; }

        public virtual void Feed(FoodType foodType, int count)
        {

            Satiety += count;
            Console.WriteLine("Om-nom-nom");
        }




    }
}

