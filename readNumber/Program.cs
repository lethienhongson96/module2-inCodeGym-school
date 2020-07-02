using System;

namespace readNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number: ");
            double numWantToRead = Convert.ToDouble(Console.ReadLine());
            double countnum = Convert.ToDouble(numWantToRead / 10);
            int countnumfloat = Convert.ToInt32(numWantToRead % 10);

            string[] textarrUnderTen = new string[10] { "", "one", "tow", "three", "four", "five", "six", "seven", "eight", "nine" };
            string[] textarrOverTwenty = new string[10] { "", "", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };
            const string moreTwenty = "teen";
            // const string overOneHundred = "hundred";
            if (countnum <= 1)
            {
                if (countnum == 1)
                {
                    Console.WriteLine("ten");
                }

                else
                {
                    for (int i = 1; i < textarrUnderTen.Length; i++)
                    {
                        if (countnumfloat == i)
                        {
                            Console.WriteLine(textarrUnderTen[i]);
                            break;
                        }
                    }
                }
            }

            else if (countnum > 1 && countnum < 2)
            {
                if (countnumfloat == 1)
                {
                    Console.WriteLine("elevent");
                }

                else if (countnumfloat == 2)
                {
                    Console.WriteLine("twelfth");
                }

                else
                {
                    for (int i = 3; i < textarrUnderTen.Length; i++)
                    {
                        if (countnumfloat == i && i == 3)
                        {
                            Console.WriteLine("thir" + moreTwenty);
                            break;
                        }

                        if (countnumfloat == i && i == 5)
                        {
                            Console.WriteLine("fif" + moreTwenty);
                            break;
                        }

                        if (countnumfloat == i)
                        {
                            Console.WriteLine(textarrUnderTen[i] + moreTwenty);
                        }
                    }
                }
            }

            else if (countnum >= 2 && countnum < 10)
            {
                for (int i = 1; i < textarrOverTwenty.Length; i++)
                {

                    if (Convert.ToInt32(Math.Floor(countnum)) == i)
                    {
                        Console.WriteLine(textarrOverTwenty[i] + " " + textarrUnderTen[countnumfloat]);
                        break;
                    }
                }
            }

            else
            {
                if (countnum == 10)
                {
                    Console.WriteLine("one hundred");
                }
            }
        }
    }
}

