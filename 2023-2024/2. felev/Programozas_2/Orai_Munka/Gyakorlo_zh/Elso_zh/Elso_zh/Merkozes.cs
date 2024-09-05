using System;

namespace Kiszh1Pelda
{
    internal class Merkozes
    {
        string _hazaiCsapat;
        string _vendegCsapat;

        public Merkozes(string hazaiCsapat, string vendegCsapat)
        {
            _hazaiCsapat = hazaiCsapat;
            _vendegCsapat = vendegCsapat;
        }

        public string HazaiCsapat
        {
            get { return _hazaiCsapat; }
        }
        public string VendegCsapat
        {
            get { return _vendegCsapat; }
        }
    }
}
