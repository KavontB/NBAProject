using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NBAProject.Models
{
    public class Team
    {
        public Team()
        {

        }
        public int TeamID { get; set; }
        public string TeamName { get; set; }
        public string Conference { get; set; }
        public string Division { get; set; }
        public string Abbreviation { get; set; }
        public string Record { get; set; }
    }
}
