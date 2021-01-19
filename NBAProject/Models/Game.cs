using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NBAProject.Models
{
    public class home_team
    {
       public int id { get; set; }
        public string abbreviation { get; set; }
        public string city { get; set; }
        public string conference { get; set; }
        public string division { get; set; }
        public string full_name { get; set; }
        public string name { get; set; }
        public int record { get; set; }

    }
    public class visitor_team
    {
        public int id { get; set; }
        public string abbreviation { get; set; }
        public string city { get; set; }
        public string conference { get; set; }
        public string division { get; set; }
        public string full_name { get; set; }
        public string name { get; set; }
        public string record { get; set; }

    }
    public class Game
    {
        public Game()
        { }


        public int id { get; set; }
        public DateTime date { get; set; }
        public home_team home_team { get; set; }
        public int home_team_score { get; set; }
        public bool postseason { get; set; }
        public int season { get; set; }
        public visitor_team visitor_team { get; set; }
        public int visitor_team_score { get; set; }

        // public string visitor_team { get; set; }
        //public int HomeScore { get; set; }
        //public int AwayScore { get; set; }
        //public DateTime Date { get; }
        //public bool Postseason { get; set; }
        //public int Season { get; set; }
    }
}