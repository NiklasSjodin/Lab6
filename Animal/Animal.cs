using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    internal class Animal
    {
        public string _Name { get; set; }
        public string _Diet { get; set; }
        public int _Age { get; set; }
        public string _Color { get; set; }
        public double _Weight { get; set; }

        public Animal(string name, string diet, int age, string color, double weight)
        {
            _Name = name;
            _Diet = diet;
            _Age = age;
            _Color = color;
            _Weight = weight;
        }

        public virtual void MakeSound()
        {
            Console.WriteLine($"{_Name} is making a sound, listen!");
        }

        public void Eat(string food) 
        {
            Console.WriteLine($"{_Name} is eating his {food}.");
        }

        public void IsSleepoing(int hours) 
        {
            Console.WriteLine($"{_Name} has slept for {hours} hours. Must be exhuasted..");
        }

    }
}
