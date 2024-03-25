using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberLine
{
    internal class Person
    {
        private string _name;
        private int _age;

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
    }
}
