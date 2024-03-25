using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberLine
{
    internal class NumberLine
    {
        private int[] _array;

        public int[] Array
        {
            get
            {
                return _array;
            }
        }

        public NumberLine(int numberCount)
        {
            _array = new int[numberCount];
        }

        public NumberLine(NumberLine other)
        {
            _array = new int[other.Array.Length];
            for (int i = 0; i < other.Array.Length; i++)
            {
                _array[i] = other.Array[i];
            }
        }

        public int GetValue(int index)
        {
            return _array[index];
        }

        public void SetValue(int index, int value)
        {
            if (index < _array.Length)
            {
                _array[index] = value;
            }
        }
    }
}
