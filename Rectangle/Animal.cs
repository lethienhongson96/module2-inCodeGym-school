using System;
namespace Rectangle
{
    public abstract class Animal
    {
        protected string _weight;
        protected string _height;

        public string Weight
        {
            get => this._weight;
            set => this._weight = value;
        }
        public string Height
        {
            get => this._height;
            set => this._height = value;
        }

        public Animal(string weight, string height)
        {
            this._weight = weight;
            this._height = height;
        }

        public abstract void printinfo();
    }
    class Cat : Animal
    {
        private string name;
        public Cat(string weight, string height, string name) : base(weight, height)
        {
            this.name = name;
        }

        public string Name
        {
            get => this.name;
            set => this.name = value;
        }

        public override void printinfo() =>
        Console.WriteLine("Weight : {0}" + '\n' + "Height: {1}" + '\n' + "Name: {2}", this.Weight, this.Height, this.name);
    }
}