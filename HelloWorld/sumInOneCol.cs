using System;

namespace HelloWorld
{
    class sumInOneCol
    {
        public static void Main()
        {
            int[,] arr2d = matrix2D.createMatrixArr(5, 5);
            matrix2D.printMatrix(arr2d);
            Console.Write("enter the col you want to get sum ");
            int col = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (byte i = 0; i < arr2d.GetLength(0); i++)
            {
                sum += arr2d[i, col];
            }
            Console.WriteLine(sum);
        }
    }
}