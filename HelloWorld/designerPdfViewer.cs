using System;

namespace HelloWorld
{
    class hackkedrank
    {
        public static void Main()
        {
            int[] valuaoftext = { 1, 3, 1, 3, 1, 4, 1, 3, 2, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 7 };
            string str = "zaba";
            Console.WriteLine(FdesignerPdfViewer(valuaoftext, str));
        }
        public static int FdesignerPdfViewer(int[] h, string word)
        {
            int[] heightofchar = new int[0];
            char[] alphabet ={'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o'
                , 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};

            for (int i = 0; i < word.Length; i++)
            {

                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (word[i] == alphabet[j])
                    {
                        Array.Resize(ref heightofchar, heightofchar.Length + 1);
                        heightofchar[heightofchar.Length - 1] = h[j];
                        break;
                    }
                }
            }
            return findMaxInArr.findMaxInAr1Way(heightofchar) * word.Length;
        }
    }
}