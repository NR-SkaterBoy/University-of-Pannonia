using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiszh1H14
{
    internal class FootballCompetition : Competition
    {
        Team[] team;
        static int requireMatches = 5;

        public static int RequiredMatches
        {
            get { return requireMatches; }
            set { requireMatches = value; }
        }

        public FootballCompetition(string name, DateTime startDate, DateTime endDate, int len) : base(name, startDate, endDate)
        {
            team = new Team[len];
            for(int i = 0; i < len; i++) {
                team[i] =  null;
            }
        }

        public void SetTeam(int idx, Team teams)
        {
            team[idx] = teams;
        }

        public new void Print()
        {
            base.Print();
            for (int i = 0; i < team.Length; i++)
            {
                Console.WriteLine($"{team[i].Name} : {team[i].Wins}-{team[i].Losses}");

            }
        }

        public void WhoNeedsMoreMatches()
        {
            for (int i = 0; i < team.Length; i++)
            {
                if ((team[i].Wins + team[i].Losses) < RequiredMatches)
                {
                    Console.WriteLine($"Team needs more matches : {team[i].Name}"); 
                }
            }
        }

        public Team BestTeam()
        {
            int idx = 0;
            for (int i = 0; i < team.Length; i++)
            {
                if (team[i].Wins > team[idx].Wins )
                {
                    idx = i;
                }
            }

            return team[idx];
        }
    }
}
