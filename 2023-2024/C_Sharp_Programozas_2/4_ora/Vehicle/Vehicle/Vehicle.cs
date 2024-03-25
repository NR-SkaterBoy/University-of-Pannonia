using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    internal class Vehicle
    {
        private string _type;

        public string Type
        {
            get
            {
                return _type;
            }
        }

        public Vehicle(string type)
        {
            _type = type;
        }

        public static int NumberOfWheels { get; set; } = 4;
    }
}
