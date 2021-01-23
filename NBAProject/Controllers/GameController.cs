using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace NBAProject.Controllers
{
    public class GameController : Controller
    {
        

        // GET: /<controller>/
        public IActionResult GameIndex()
        {
            

            WebClient webClient = new WebClient();
            var json = webClient.DownloadString(@"C:\Users\kavon\OneDrive\Desktop\repos\NBAProject\NBAProject\nba.json");
            var games = JsonConvert.DeserializeObject<GameList>(json);
            return View(games);

        }
        public IActionResult ViewGame(int id)
        {
            //var game = repo.GetGame(id);
            WebClient webClient = new WebClient();
            var json = webClient.DownloadString(@"C:\Users\kavon\OneDrive\Desktop\repos\NBAProject\NBAProject\nba.json");
            var games = JsonConvert.DeserializeObject<GameList>(json);
            foreach(var game in games.data)
            {
                if(game.id == id)
                {
                    return View(game);
                }
            }
            return View(null);
        }
       
        }

    }

