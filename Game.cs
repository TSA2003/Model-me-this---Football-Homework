using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballHomework
{
    public class Game
    {
        private Team team1;
        public Team Team1
        {
            get
            {
                return team1;
            }
            protected set
            {
                if (value.Players.Count != 11)
                {
                    throw new ArgumentException("The entered players count is not 11!");
                }
                team1 = value;
            }
        }

        private Team team2;
        public Team Team2
        {
            get
            {
                return team2;
            }
            protected set
            {
                if (value.Players.Count != 11)
                {
                    throw new ArgumentException("The entered players count is not 11!");
                }
                team2 = value;
            }
        }

        public Referee Referee { get; protected set; }
        public Referee AssistantReferee1 { get; protected set; }
        public Referee AssistantReferee2 { get; protected set; }
        public List<Goal> Goals { get; protected set; }
        public string Result { get; protected set; }
        public Team Winner { get; protected set; }

        public Game(Team team1, Team team2, Referee referee, Referee assistantReferee1, Referee assistantReferee2, List<Goal> goals, string result, Team winner)
        {
            Team1 = team1;
            Team2 = team2;
            Referee = referee;
            AssistantReferee1 = assistantReferee1;
            AssistantReferee2 = assistantReferee2;
            Goals = goals;
            Winner = winner;
        }
    }
}
