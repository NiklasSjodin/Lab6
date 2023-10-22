using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal 
{
    internal class King_corso : Dog
    {
        public bool guardDog {  get; set; }

        public King_corso(string name, int age, double weight)
            : base(name, age, weight, true)
        {
            guardDog = true; 
        }

        public override void MakeSound()
        {
            Console.WriteLine($"Someone is at the door. Tell {_Name} to stop barking..");
        }

        public void GuardHouse() 
        {
            Console.WriteLine($"{_Name} is guarding our house! We are safe now!");
        }
    }
}
