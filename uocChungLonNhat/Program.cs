using System;

namespace uocChungLonNhat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int[] boiSoCuaA = new int[0];

            for (int i = 1; i <= a; i++)
            {
                if (a % i == 0 && b % i == 0)
                {
                    Array.Resize(ref boiSoCuaA, boiSoCuaA.Length + 1);
                    boiSoCuaA[boiSoCuaA.Length - 1] = i;
                }
            }

            int max = boiSoCuaA[0];
            for (int i = 0; i < boiSoCuaA.Length; i++)
            {
                if (max < boiSoCuaA[i])
                {
                    max = boiSoCuaA[i];
                }
            }
            Console.WriteLine(max);
            // for (int i = 0; i < boiSoCuaA.Length; i++)
            // {
            //     Console.Write(boiSoCuaA[i] + " ");
            // }
            // Console.WriteLine(boiSoCuaA[0]);

            // int[] arr = new int[0];
            // string key = "Y";
            // do
            // {
            //     Console.Write("Input your number: ");
            //     int num = int.Parse(Console.ReadLine());
            //     Array.Resize(ref arr, arr.Length + 1);
            //     arr[arr.Length - 1] = num;
            //     Console.Write("Do you want to continue? y/n: t");
            //     key = Console.ReadLine();
            // }
            // while (string.Compare(key.ToUpper(), "N") != 0);

            // for (int i = 0; i < arr.Length; i++)
            // {
            //     Console.Write($"{arr[i]} ");
            // }

        }
    }
}
