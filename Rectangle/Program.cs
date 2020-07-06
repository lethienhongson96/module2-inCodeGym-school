using System;

namespace Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat1 = new Cat("15kg", "1.5", "kitty");
            Console.WriteLine(cat1.Name);
            cat1.printinfo();
        }
    }
}
