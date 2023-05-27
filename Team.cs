using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballHomework
{
    public class Team
    {
        public Coach Coach { get; protected set; }

        private List<FootballPlayer> players;
        public List<FootballPlayer> Players
        {
            get
            {
                return players;
            }
            protected set
            {
                if (value.Count < 11 || value.Count > 22)
                {
                    throw new ArgumentException("The entered players count is out of the required range [11, 22]!");
                }
                players = value;
            }
        }

        public Team(Coach coach, List<FootballPlayer> players)
        {
            Coach = coach;
            Players = players;
        }

        public double CalculatePlayersAverageAge()
        { 
            return players.Average(x => x.Age);
        }
    }
}
