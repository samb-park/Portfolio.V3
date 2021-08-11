using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Models;
using Newtonsoft.Json;
using WASM.V1.Service.IService;

namespace WASM.V1.Service
{
    public class AboutMeService : IAboutMeService
    {
        private readonly HttpClient _client;

        public AboutMeService(HttpClient client)
        {
            _client = client;
        }
        
        public async Task<AboutMeDTO> GetAboutMe()
        {
            var response = await _client.GetAsync($"api/aboutme");
            var content = await response.Content.ReadAsStringAsync();
            var abougMe = JsonConvert.DeserializeObject<AboutMeDTO>(content);
            return abougMe;
        }
    }
}