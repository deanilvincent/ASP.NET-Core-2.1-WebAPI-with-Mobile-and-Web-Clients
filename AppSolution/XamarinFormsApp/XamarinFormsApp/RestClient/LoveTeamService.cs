using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using XamarinFormsApp.Models;

namespace XamarinFormsApp.RestClient
{
    public class LoveTeamService
    {
        public const string ApiUrl = "http://stinovawebapidemo.azurewebsites.net/api/";

        public async Task<List<LoveTeam>> Get()
        {
            var httpClient = new HttpClient();

            var task = await httpClient.GetStringAsync($"{ApiUrl}loveteams");

            return JsonConvert.DeserializeObject<List<LoveTeam>>(task);
        }
    }
}