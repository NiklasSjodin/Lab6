using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    internal class Cheetah : Animal
    {
        public bool FastestAnimal {  get; set; }

        public Cheetah(string name, int age, double weight, bool fastestAnimal)
            : base(name, "other animals", age, "black spots", weight)
        {
            FastestAnimal = fastestAnimal;
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{_Name} is roaring when attacking it´s prey!");
        }

        public void Swoosh() 
        {
            Console.WriteLine("The cheetah swooshes past at full speed! ");
        }


    }
}
