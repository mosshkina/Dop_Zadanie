using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Классы
{
    class Team
    {
        public string team;
        public int score;
        public int points;
        public List<string> members = new List<string>();
        public Team(string team, int points)
        {
            this.team = team;
            this.points = points;
        }
    }
}
