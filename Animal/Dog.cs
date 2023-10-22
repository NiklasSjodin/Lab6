using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    internal class Dog : Animal
    {
       public bool MansBestFriend { get; set; }

        public Dog(string name, int age, double weight, bool mansBestFriend)
             : base(name, "bones", age, "brown", weight)
        {
            MansBestFriend = mansBestFriend;
        }
        public override void MakeSound()
        {
            Console.WriteLine($"{_Name} is barking like crazy, just listen.. (Woof woof in the distance)");
        }
        public void GetStick() 
        {
            Console.WriteLine($"{_Name} is running to get the stick back!");
        }
    }
}
