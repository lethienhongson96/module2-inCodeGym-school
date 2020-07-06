using System;

namespace Rectangle
{
    class QuadRaticEquation
    {
        private double a, b, c;

        public QuadRaticEquation(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double geta()
        {
            return this.a;
        }
        public double getb()
        {
            return this.b;
        }
        public double getc()
        {
            return this.c;
        }
        public double GetDiscriminant()
        {
            return ((this.b * this.b) - 4 * this.a * this.c);
        }

        public double GetRoot1()
        {
            if (this.GetDiscriminant() == 0)
            {
                return (-this.b / 2 * this.a);
            }

            else if (this.GetDiscriminant() > 0)
            {
                return ((-this.b + Math.Pow(GetDiscriminant(), 0.5)) / (2 * this.a));
            }

            else
            {
                return 0;
            }
        }
        public double GetRoot2()
        {
            if (this.GetDiscriminant() == 0)
            {
                return (-this.b / 2 * this.a);
            }

            else if (this.GetDiscriminant() > 0)
            {
                return ((-this.b - Math.Pow(GetDiscriminant(), 0.5)) / (2 * this.a));
            }

            else
            {
                return 0;
            }
        }

        public string gettworoot()
        {

            if (this.GetDiscriminant() > 0)
            {
                return $"The equation has two roots {GetRoot1()} and {GetRoot2()}";
            }

            else if (this.GetDiscriminant() == 0)
            {
                return $"The equation has one roots {GetRoot2()}";
            }

            else
            {
                return "The equation has no roots";
            }
        }
    }
}