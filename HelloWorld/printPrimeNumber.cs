using System;

namespace HelloWorld
{
    class prinLessOneHundredPrime
    {
        public static void Main()
        {
            //những số nguyên tố nhỏ hơn 100;
            for (int i = 2; i < 100; i++)
            {
                bool checkprime = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        checkprime = false;
                        break;
                    }
                }
                if (checkprime)
                {
                    Console.Write($"{i}-");
                }
            }
        }
    }
}