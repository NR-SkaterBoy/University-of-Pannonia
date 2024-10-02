using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ora1Vehicles
{
    internal class CustomException : Exception
    {
        public CustomException() : base("The fetching is not authorized")
        {
            
        }
    }
}
