using System;
using System.Diagnostics;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("enter a number: ");
            number = Convert.ToInt32(Console.ReadLine());
            if (number < 2)
            {
                Console.WriteLine(number + " is not a number");
            }
            
            else
            {
                int i = 2;
                bool check = true;
                string result = "";
                while (i <= Math.Sqrt(number))
                {
                    if (number % i == 0)
                    {
                        check = false;
                        break;
                    }
                    i++;
                }
                if (check)
                {
                    result = number + " is a prime";
                }
                else
                {
                    result = number + " is not a prime";
                }
                Console.WriteLine(result);
            }

        }
    }
}
