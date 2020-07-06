using System;

namespace HelloWorld
{
    class mainDiagonal
    {
        public static void Main()
        {
            Console.Write("enter row: ");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter col: ");
            int col = Convert.ToInt32(Console.ReadLine());
            int[,] arr2d = matrix2D.creRndMatrixArr(row, col);
            matrix2D.printMatrix(arr2d);
            //calculate sum of main diagonal;
            int sum = 0;
            for (byte i = 0; i < arr2d.GetLength(0); i++)
            {
                sum += arr2d[i, i];
            }
            Console.WriteLine(sum);
        }
    }
}