using System;
namespace Rectangle
{
    class Fanclass
    {

        const int _slow = 1;
        const int _medium = 2;
        const int _fast = 3;
        private int _speed = _slow;
        private bool _on = false;
        private double _radius = 5;
        private string _color = "blue";
        public Fanclass()
        {

        }

        public int Speed
        {
            get => this._speed;
            set => this._speed = value;
        }

        public double Radius
        {
            get => this._radius;
            set => this._radius = value;
        }


        public string Color
        {
            get => this._color;
            set => this._color = value;
        }

        public void turn() => this._on = !this._on;

        public string strinfo()
        {
            string result = "";
            if (this._on)
            {
                result = $"speed: {this._speed} color: {this._color} radius: {this._radius} fan is on";
            }

            else
            {
                result = $"color: {this._color} radius: {this._radius} fan is off !!!";
            }
            return result;
        }

    }
}