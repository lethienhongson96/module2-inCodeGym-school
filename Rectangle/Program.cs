using System;

namespace Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter width: ");
            float width = float.Parse(Console.ReadLine());

            Console.WriteLine("enter height: ");
            float height = float.Parse(Console.ReadLine());

            float area = width * height;
            Console.WriteLine("area of rectangle is: " + area);
        }
    }
}
