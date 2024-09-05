using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VAT
{
    internal class Goods
    {
        private string _name;
        private int _netPrice;

        public string Name
        {
            get
            {
                return _name;
            }
        }

        public int NetPrice
        {
            get
            {
                return _netPrice;
            }
        }

        public Goods(string name, int netPrice)
        {
            _name = name;
            _netPrice = netPrice;
        }

        public static double VAT { get; set; } = 27.5;

        public int GrossPrice()
        {
            return (int)Math.Round(this._netPrice + (this._netPrice * VAT / 100));
        }
    }
}
