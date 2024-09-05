using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiszh3Pelda
{
    internal class LimitedStorage<T>
    {
        private List<T> list;
        public int MaxSize { get; }

        public LimitedStorage(int size)
        {
            list = new List<T>(size);
            MaxSize = size;
        }

        public int Size => list.Count;

        public void Add(T item)
        {
            if (Size < MaxSize)
            {
                list.Add(item);
            }
        }

        public T Item(int idx)
        {
            return idx < Size && idx >= 0 ? list[idx] : default(T);
        }


        public void Extend<U>(List<U> items) where U : T
        {
            foreach (var item in items)
            {
                if (Size < MaxSize)
                {
                    list.Add(item);
                }
                else
                {
                    break;
                }
            }
        }
    }
}
