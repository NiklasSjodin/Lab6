using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    internal class Dachshunds : Dog
    {
        public bool HasSmallLegs { get; set; }

        public Dachshunds(string name, int age, double weight, bool hasSmallLegs)
            : base (name, age, weight, true)
        {
            HasSmallLegs = hasSmallLegs;
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{_Name} barks at the door when it wants to go on a walk!");
        }

        public void ShakePaw() 
        {
            Console.WriteLine($"{_Name} is shaking paws with you! He likes you <3");
        }
    }
}
