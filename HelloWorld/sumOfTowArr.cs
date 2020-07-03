using System;

namespace HelloWorld
{
    class addTwoArr
    {
        public static void Main()
        {
            int[] arr1 = new int[0];
            int[] arr2 = new int[0];
            int[] arr3 = new int[0];

            arr1 = createArr(arr1);
            print(arr1);
            arr2 = createArr(arr2);
            print(arr2);
            arr3 = addarr(arr1, arr3);
            arr3 = addarr(arr2, arr3);
            print(arr3);
        }
        public static void print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }

        public static int[] createArr(int[] arr)
        {
            string checkText = "";
            do
            {
                Console.WriteLine("enter a value for arr");
                int valueForArr = Convert.ToInt32(Console.ReadLine());
                Array.Resize(ref arr, arr.Length + 1);
                arr[arr.Length - 1] = valueForArr;
                Console.Write("do you want continue ");
                checkText = Convert.ToString(Console.ReadLine());
            } while (checkText != "N");

            return arr;
        }

        public static int[] addarr(int[] arr, int[] resultarr)
        {
            // int[] resultarr = new int[0];
            for (int i = 0; i < arr.Length; i++)
            {
                Array.Resize(ref resultarr, resultarr.Length + 1);
                resultarr[resultarr.Length - 1] = arr[i];
            }
            return resultarr;
        }
    }
}