using System;

namespace ptBacNhat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter b:");
            int b = Convert.ToInt32(Console.ReadLine());
            if (a != 0)
            {
                Console.WriteLine(-b / a);
            }
            else
            {
                if (b == 0)
                {
                    Console.WriteLine("pt vo so nghiem");
                }
                else
                {
                    Console.WriteLine("pt vo nghiem");
                }
            }
        }
    }
}
