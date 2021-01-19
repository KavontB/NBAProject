using Dapper;
using NBAProject.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace NBAProject
{
    public class GameRepository : IGameRepository
    {
        private readonly IDbConnection _conn;
        public GameRepository(IDbConnection conn)
        {
            _conn = conn;
        }
        public IEnumerable<Game> GetAllGames()
        {
            return _conn.Query<Game>("SELECT * FROM GAMES;");
        }
        //public IEnumerable<Team> GetAllTeams()
        //{
        //    return _conn.Query<Team>("SELECT * FROM TEAMS;");
        //}
        //public Team GetTeam(string teamname)
        //{
        //    return _conn.QuerySingle<Team>("SELECT * FROM TEAMS WHERE TeamName = @teamname;",
        //        new { teamname = teamname });}
        public Game GetGame(int id)
        {
            return _conn.QuerySingle<Game>("SELECT * FROM GAMES WHERE GameID = @id",
                new { id = id });
        }
        //SELECT REPLACE(TeamName, "_", " ") FROM teams;

    }
}
