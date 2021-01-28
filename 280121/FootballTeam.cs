using System;
using System.Collections.Generic;
using System.Text;

namespace _280121
{
    class FootballTeam
    {
        public string TeamName { get; set; }
        public string CoachName { get; set; }
        public int SquadSize { get; set; }

        public FootballTeam() : this("N/A", "N/A", 0)
        {
        }

        public FootballTeam (string teamName) : this(teamName, "N/A", 0)
        {
            TeamName = teamName;
        }

        public FootballTeam(string teamName, string coachName, int squadSize)
        {
            TeamName = teamName;
            CoachName = coachName;
            SquadSize = squadSize;
        }

    }
}
