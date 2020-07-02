using System;

namespace isleapyear
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number year: ");
            int year = Convert.ToInt32(Console.ReadLine());
            //chia hết cho 4 mà không chia hết cho 100 là năm nhuận
            //chia hết cho 100 và 400 là năm nhuận
            if (year % 4 == 0 && year % 100 != 0)
            {
                Console.WriteLine(year + " is leap year");
            }
            else if (year % 100 == 0)
            {
                if (year % 400 == 0)
                {
                    Console.WriteLine(year + " is leap year");
                }
                else
                {
                    Console.WriteLine(year + " not is leap year");
                }
            }
            else
            {
                Console.WriteLine(year + " not a leap year");
            }
        }
    }
}
