using System;

namespace Kiszh1H14
{
    internal class Team
    {
        string _name;
        int _wins;
        int _losses;
        public Team(string name)
        {
            _name = name;
            _wins = 0;
            _losses = 0;
        }
        public Team(string name, int wins, int losses)
        {
            _name = name;
            _wins = wins;
            _losses = losses;
        }

        public string Name
        {
            get { return _name; }
        }
        public int Wins
        {
            get { return _wins; }
            set { _wins = value; }
        }
        public int Losses
        {
            get { return _losses; }
            set { _losses = value; }
        }
    }
}
