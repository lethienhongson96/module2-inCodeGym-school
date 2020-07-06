using System;

namespace HelloWorld
{
    class matrix2D
    {
        public static void Main()
        {
            int[,] arr1 = creRndMatrixArr(5, 5);
            printMatrix(arr1);
        }
        public static int[,] creRndMatrixArr(int row, int col)
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

        public static void printMatrix(int[,] arr2d)
        {
            for (int i = 0; i < arr2d.GetLength(0); i++)
            {
                for (int j = 0; j < arr2d.GetLength(1); j++)
                {
                    Console.Write(arr2d[i, j] + " ");
                }
                Console.WriteLine();
            }
        }


    }

}