using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballHomework
{
    public class FootballPlayer : Person
    {
        public int Number { get; protected set; }
        public int Height { get; protected set; }

        public FootballPlayer(string name, int age, int number, int height) : base(name, age)
        {
            Number = number;
            Height = height;
        }
    }
}
