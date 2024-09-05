using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VAT
{
    internal class Food : Goods
    {
        DateTime _expiryDate;

        public Food(string name, int netPrice, DateTime expiryDate) : base(name, netPrice)
        {
            this._expiryDate = expiryDate;
        }

        public DateTime ExpiryDate { get { return _expiryDate; } }

        public static double VAT { get;  set; } = 15;

        public int GrossPrice()
        {
            return (int)Math.Round(NetPrice + NetPrice * VAT / 100);
        }
    }
}
