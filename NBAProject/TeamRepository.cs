using Dapper;
using NBAProject.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace NBAProject
{
    public class TeamRepository : ITeamRepository
    {

        private readonly IDbConnection _conn;
        public TeamRepository(IDbConnection conn)
        {
            _conn = conn;
        }
        public IEnumerable<Team> GetAllTeams()
        {
            return _conn.Query<Team>("SELECT * FROM TEAMS;");
        }
        public Team GetTeam(int id)
        {
            return _conn.QuerySingle<Team>("SELECT * FROM TEAMS WHERE TeamID = @id",
                new { id = id });
        }
        //public void GetRecord()
        //{
            
        //    WebClient webClient = new WebClient();
        //    var json = webClient.DownloadString(@"C:\Users\kavon\OneDrive\Desktop\repos\NBAProject\NBAProject\nba.json");
        //    var games = JsonConvert.DeserializeObject<GameList>(json);
        //    foreach (var game in games.data)
        //    {
        //        int w = 0;
        //        int l = 0;
        //        if (game.home_team_score > game.visitor_team_score)
        //        {
        //            w++;
                    
                    
        //        }
        //    }
        //    return _conn.Query<Team>("INSERT INTO TEAMS (Record) VALUES ();");

        //}
    }
}

