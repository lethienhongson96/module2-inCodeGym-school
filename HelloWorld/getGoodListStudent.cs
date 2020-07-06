using System;

namespace HelloWorld
{
    class getGoodListStudent
    {
        public static void Main()
        {
            int[] studentArr;
            byte size;
            do
            {
                Console.Write("tell me how many student? ");
                size = Convert.ToByte(Console.ReadLine());
            } while (size > 30);

            studentArr = new int[size];
            int i = 0;
            while (i < studentArr.Length)
            {
                Console.Write($"input the mark of student {i + 1} ");
                studentArr[i] = Convert.ToInt32(Console.ReadLine());
                i++;
            }

            byte count = 0;
            for (i = 0; i < studentArr.Length; i++)
            {
                if (studentArr[i] >= 5 && studentArr[i] <= 10)
                {
                    count++;
                }
            }
            Console.WriteLine($"there are {count} good student");
        }
    }
}