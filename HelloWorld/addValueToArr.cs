using System;
using System.Linq;

namespace HelloWorld
{
    class addValueToArr
    {
        public static void Main()
        {
            int[] arr1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            printarr(deLeTeAnEle(arr1, 2));
        }
        public static int[] addvlue(int[] arr, int index, int newvalue)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = 0;

            for (int i = arr.Length - 1; i >= index; i--)
            {
                arr[i] = arr[i - 1];
                if (i == index)
                {
                    arr[i] = newvalue;
                }
            }

            return arr;
        }
        public static void printarr(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
        public static int[] deLeTeAnEle(int[] arr, int valuetodel)
        {
            int indexof = -1;
            // Array.Resize(ref arr, arr.Length + 1);
            // arr[arr.Length - 1] = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == valuetodel)
                {
                    indexof = i;
                    break;
                }
            }

            for (int j = indexof; j < arr.Length; j++)
            {
                if (j == arr.Length - 1)
                {
                    arr[j] = 0;
                    break;
                }
                arr[j] = arr[j + 1];
            }

            arr = arr.Take(arr.Length - 1).ToArray();
            return arr;
        }
    }
}