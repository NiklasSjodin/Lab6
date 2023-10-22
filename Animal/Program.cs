namespace Animal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Sandor", 3, 10, true);
            Ape ape = new Ape("Ceasar", 10, 55, true);
            Cheetah cheetah = new Cheetah("Sabor", 12, 31, true);
            King_corso kingCorso = new King_corso("Hercules", 2, 35);
            Dachshunds dachshunds = new Dachshunds("Elvis", 1, 7, true);

            dog.MakeSound();
            dog.GetStick();
            Console.WriteLine();

            ape.MakeSound();
            ape.ClimbTree();
            Console.WriteLine();

            cheetah.MakeSound();
            cheetah.Swoosh();
            Console.WriteLine();

            kingCorso.MakeSound();
            kingCorso.GuardHouse();
            Console.WriteLine();

            dachshunds.MakeSound();
            dachshunds.ShakePaw();
        }
    }
}