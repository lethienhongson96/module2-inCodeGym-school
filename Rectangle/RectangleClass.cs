using System;

namespace classprat
{
    class Rectangle
    {
        public double width;
        public double height;
        public Rectangle() { }

        public void setheight(double newheight)
        {
            this.height = newheight;
        }

        public double getheight()
        {
            return this.height;
        }
        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public double getarea()
        {
            double area = this.width * this.height;
            return area;
        }

        public double getperimeter()
        {
            double perimeter = (this.width + this.height) * 2;
            return perimeter;
        }

        public string display()
        {
            return $"width: {this.width} height: {this.height}";
        }

    }
}