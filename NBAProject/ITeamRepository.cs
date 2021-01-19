using NBAProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NBAProject
{
    public interface ITeamRepository
    {
        public IEnumerable<Team> GetAllTeams();
        public Team GetTeam(int GameID);
        
    }
}
