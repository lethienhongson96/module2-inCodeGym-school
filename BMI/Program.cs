using System;

namespace BMI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your weight");
            double weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter your height");
            double height = Convert.ToDouble(Console.ReadLine());
            double BMI = weight / (height * 2);
            string result = "";
            if (BMI < 18.5)
            {
                result = "underweight";
            }
            else if (BMI >= 18.5 && BMI < 25.0)
            {
                result = "normal";
            }
            else if (BMI >= 25.0 && BMI < 30.0)
            {
                result = "over";
            }
            else if (BMI >= 30.0)
            {
                result = "obese";
            }
            Console.WriteLine(result);
        }
    }
}
