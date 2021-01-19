using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace NBAProject.Controllers
{
    public class TeamController : Controller
    {
        private readonly ITeamRepository repo;

        public TeamController(ITeamRepository repo)
        { 
            this.repo = repo;
        }
        public IActionResult TeamIndex()
        {
            var teams = repo.GetAllTeams();
            return View(teams);
        }
        public IActionResult ViewTeam(int id)
        {
            var team = repo.GetTeam(id);
            return View(team);
        }

    }
}
