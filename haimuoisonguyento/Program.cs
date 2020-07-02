using System;

namespace haimuoisonguyento
{
    class Program
    {
        static void Main(string[] args)
        {
            int dem = 0;
            int n = 2;
            while (dem != 20)
            {
                bool checkisprime = true;
                for (int i = 2; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        checkisprime = false;
                        break;
                    }
                }
                if (checkisprime)
                {
                    Console.WriteLine(n);
                    dem++;
                }
                n++;
            }
        }
    }
}
