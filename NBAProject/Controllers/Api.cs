using NBAProject.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace NBAProject
{
    public class Api
    {
        public void NBApi()
        {
            var client = new RestClient("https://free-nba.p.rapidapi.com/games/?rapidapi-key=");
            var request = new RestRequest(Method.GET);
            request.AddHeader("x-rapidapi-key", "6c4a022c7fmshd490f15a0a68071p138ea7jsna0375dcf2db2");
            request.AddHeader("x-rapidapi-host", "free-nba.p.rapidapi.com");
            IRestResponse response = client.Execute(request);
            //GameList gameList = new GameList();
            
                var json = JObject.Parse(response.Content);

            Console.WriteLine(json);
            //    JObject Ie
            //    var properties = json.Properties().Where(p => p.Name.Contains("_")).ToList();
            //    var newObject = new JObject(properties.Select(p => new JProperty(p.Name.Replace("_", string.Empty), p.Value)));
            //    json.Add("_", newObject);


            //return JsonConvert.DeserializeObject<GameList>(File.ReadAllText(json));
           
        }
    }
}
