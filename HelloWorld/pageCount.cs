using System;

namespace HelloWorld
{
    class pageCount
    {
        public static void Main()
        {

        }

        static int drawAndCountBook(int n, int p)
        {
            int[,] drawbookarr;
            int count = 0;
            int amountPage;
            if (n % 2 == 0)
            {
                amountPage = (n / 2) + 1;
            }
            else
            {
                amountPage = (n / 2) + (n % 2);
            }

            drawbookarr = new int[amountPage, 2];


            for (int i = 0; i < drawbookarr.GetLength(0); i++)
            {
                for (int k = 1; k < n; k++)
                {
                    for (int j = 0; j < drawbookarr.GetLength(1); j++)
                    {
                        if (k == 1)
                        {
                            drawbookarr[i, j] = k;
                            break;
                        }
                        drawbookarr[i, j] = k;
                    }
                }
            }

            return count;
        }
    }
}