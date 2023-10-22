using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    internal class Ape : Animal
    {
        public bool IsTarzansFriend {  get; set; }

        public Ape(string name, int age, double weight, bool isTarzansfriend)
            : base (name, "fruits", age, "black", weight)
        {
            IsTarzansFriend = isTarzansfriend;
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{_Name} is banging his chest and roars!");
        }
        public void ClimbTree()
        {
            Console.WriteLine($"{_Name} climbs a large tree!" );
        }

    }
}
