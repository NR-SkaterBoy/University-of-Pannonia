using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    internal class Person
    {
        private string _name;
        protected int _age;

        public string FullName
        {
            get
            {
                return _name;
            }
        }

        public Person(string name, int age)
        {
            _name = name;
            _age = age;
        }

        public void Write()
        {
            Console.WriteLine($"{_name}: {_age}");
        }

        public bool Younger(Person other)
        {
            return this._age < other._age;
        }
    }
}
