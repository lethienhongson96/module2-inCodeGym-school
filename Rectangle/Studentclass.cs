using System;

namespace Rectangle
{
    class Studentclass
    {
        private int _id;
        private int _age;
        private string _name;
        private string _address;

        public Studentclass(int id, int age, string name, string address)
        {
            this._id = id;
            this._age = age;
            this._name = name;
            this._address = address;
        }

        public int Id
        {
            get => this._id;
            set => this._id = value;
        }

        public int Age
        {
            get => this._age;
            set => this._age = value;
        }

        public string Name
        {
            get => this._name;
            set => this._name = value;
        }

        public string Address
        {
            get => this._address;
            set => this._address = value;
        }

        public string strinfo() => $"id: {this._id} age: {this._age} name: {this._name} address: {this._address}";
    }
}