using System;

namespace HelloWorld
{
    class countChartInString
    {
        public static void Main()
        {
            Console.Write("input a string: ");
            string str = Convert.ToString(Console.ReadLine());
            Console.Write("input the chart you want to count: ");
            char chr = Convert.ToChar(Console.ReadLine());

            byte count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == chr)
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}