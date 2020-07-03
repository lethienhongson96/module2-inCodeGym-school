using System;

namespace HelloWorld
{
    class maxInArr
    {
        public static void Main()
        {
            int[,] arr2d = createMatrixArr(3, 3);
            int max = arr2d[0, 0];
            for (int i = 0; i < arr2d.GetLength(0); i++)
            {
                for (int j = 0; j < arr2d.GetLength(1); j++)
                {
                    if (max < arr2d[i, j])
                    {
                        max = arr2d[i, j];
                    }
                }
            }

            print2d(arr2d);
            Console.WriteLine(max);

        }

        public static int[,] createMatrixArr(int row, int col)
        {
            int[,] arr2d = new int[row, col];
            Random rnd = new Random();
            for (int i = 0; i < arr2d.GetLength(0); i++)
            {
                for (int j = 0; j < arr2d.GetLength(1); j++)
                {
                    arr2d[i, j] = rnd.Next(10, 50);
                }
            }
            return arr2d;
        }
        public static void print2d(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"{arr[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}