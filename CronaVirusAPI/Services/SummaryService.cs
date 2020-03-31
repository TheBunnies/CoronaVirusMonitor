using System.Net.Http;
using System.Threading.Tasks;
using CronaVirusAPI.Interfaces;
using CronaVirusAPI.Models;
using Newtonsoft.Json;

namespace CronaVirusAPI.Services
{
    public class SummaryService : ISummaryService
    {
        private HttpClient _client; 
        public async Task<SummaryDTO> GetData()
        {
            _client = new HttpClient();

            string request = "https://api.covid19api.com/summary";

            HttpResponseMessage response = (await _client.GetAsync(request)).EnsureSuccessStatusCode();

            string responseBody = await response.Content.ReadAsStringAsync();

            var data = JsonConvert.DeserializeObject<SummaryDTO>(responseBody);

            return data;
        }
    }
}
