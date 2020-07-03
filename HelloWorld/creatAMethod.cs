using System;

namespace HelloWorld
{
    class createfunction
    {
        public static void Main()
        {
            int x = 10;
            int y = 20;
            Console.Write(hoanDoi(ref x, ref y));
            Console.Write("x= " + x + " y=" + y);
        }
        public static int sumtownumber(int sum1, int sum2)
        {
            int sum = 0;
            sum = sum1 + sum2;
            return sum;
        }
        public static string hoanDoi(ref int a, ref int b)
        {
            string result = "";
            int temp = a;
            a = b;
            b = temp;
            result = $"a= {a},b= {b}";
            return result;
        }
    }
}