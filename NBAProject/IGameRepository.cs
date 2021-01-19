using NBAProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NBAProject
{
    public interface IGameRepository
    {
        public IEnumerable<Game> GetAllGames();
        //public IEnumerable<Team> GetAllTeams();
        //public Team GetTeam(string teamname);
        public Game GetGame(int id);
        
    }
}
