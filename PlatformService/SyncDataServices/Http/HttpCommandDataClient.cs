using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using PlatformService.Dtos;
 

namespace PlatformService.SyncDataServices.Http
{
    public class HttpCommandDataClient : ICommandDataClient
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration;

        public HttpCommandDataClient(HttpClient httpClient,IConfiguration configuration)
        {
            _httpClient = httpClient;
            _configuration=configuration;
        }
        public async Task SendPlatformToCommand(PlatformReadDto plat)
        {
            var httpContent = new StringContent(
               JsonConvert.SerializeObject(plat),
               Encoding.UTF8,
               "application/json"
            );

            var res = await _httpClient.PostAsync($"{_configuration["CommandsService"]}", httpContent);
            if (res.IsSuccessStatusCode)
            {
                Console.WriteLine("--> Sync POST to CommandService was successful...");
            }
            else
            {
                Console.WriteLine("--> Sync POST to CommandService was Not OK!...");
            }
        }
    }
}