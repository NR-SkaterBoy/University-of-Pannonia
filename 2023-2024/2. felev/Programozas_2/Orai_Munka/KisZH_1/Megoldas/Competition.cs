using System;

namespace Kiszh1H14
{
    internal class Competition
    {
        string _name;
        DateTime _startDate;
        DateTime _endDate;

        public Competition(string name, DateTime startDate, DateTime endDate)
        {
            _name = name;
            _startDate = startDate;
            _endDate = endDate;
        }

        public string Name {
            get { return _name; }
        }
        public DateTime StartDate {
            get { return _startDate; }
        }
        public DateTime EndDate {
            get { return _endDate; }
        }
        public void Print()
        {
            Console.WriteLine($"{_name} : {_startDate.ToString("yyyy.MM.dd")} -> {_endDate.ToString("yyyy.MM.dd")}");
        }
    }
}
