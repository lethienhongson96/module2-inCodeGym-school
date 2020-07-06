using System;

namespace HelloWorld
{
    class findMaxInArr
    {
        public static void Main()
        {
            int[,] arr2d = matrix2D.creRndMatrixArr(3, 3);
            int max = findMaxInMatrix(arr2d);
            matrix2D.printMatrix(arr2d);
            Console.WriteLine(max);
        }
        public static int findMaxInAr1Way(int[] arr)
        {
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                }
            }
            return max;
        }

        public static int findMaxInMatrix(int[,] arr)
        {
            int maxInMaxtrix = arr[0, 0];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (maxInMaxtrix < arr[i, j])
                    {
                        maxInMaxtrix = arr[i, j];
                    }
                }
            }
            return maxInMaxtrix;
        }
    }
}