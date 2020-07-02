using System;

namespace drawShapeWithArr2D
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "";
            string[] drawarr = new string[5];
            for (int i = 0; i < 5; i++)
            {
                line += "#";
                Console.WriteLine(line);
                // drawarr[i] = line;
            }

            for (int i = 5; i > 0; i--)
            {
                string lineleft = "";
                for (int j = i; j > 0; j--)
                {
                    lineleft += "#";
                }
                Console.WriteLine(lineleft);
            }

            for (int i = 7; i >= 1; i--)
            {
                string linecan = "";

                for (int j = 1; j <= i; j++)
                {

                    linecan += "#";
                }
                Console.WriteLine(linecan);
            }
        }
    }
}
