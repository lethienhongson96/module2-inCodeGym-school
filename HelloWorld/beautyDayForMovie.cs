using System;

namespace HelloWorld
{
    class beautyDayForMovie
    {
        public static void Main()
        {
            long result = beautifulDays(49860, 205494, 155635764);

            Console.Write($"{result} ");

        }

        public static long beautifulDays(long i, long j, long k)
        {
            string[] numstr = new string[0];
            long[] beforsubarr = new long[0];
            for (long x = i; x <= j; x++)
            {
                Array.Resize(ref beforsubarr, beforsubarr.Length + 1);
                beforsubarr[beforsubarr.Length - 1] = x;
                long even = x / 10;
                float uneven = x % 10;
                Array.Resize(ref numstr, numstr.Length + 1);
                numstr[numstr.Length - 1] = Convert.ToString(uneven) + Convert.ToString(even);
            }

            for (long a = 0; a < beforsubarr.Length; a++)
            {
                beforsubarr[a] = Math.Abs(beforsubarr[a] - Convert.ToInt32(numstr[a]));
            }

            long count = 0;
            for (long a = 0; a < beforsubarr.Length; a++)
            {
                if (beforsubarr[a] % k == 0)
                {
                    count++;
                }
            }

            return count;
        }
    }
}