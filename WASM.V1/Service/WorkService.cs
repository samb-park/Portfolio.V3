using Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using WASM.V1.Service.IService;

namespace WASM.V1.Service
{
    public class WorkService : IWorkService
    {
        private readonly HttpClient _client;

        public WorkService(HttpClient client)
        {
            _client = client;
        }

        public async Task<IEnumerable<WorkDTO>> GetAllWorks()
        {
            var response = await _client.GetAsync($"api/work");
            var content = await response.Content.ReadAsStringAsync();
            var workExperiences = JsonConvert.DeserializeObject<IEnumerable<WorkDTO>>(content);
            return workExperiences;
        }

        public Task<WorkDTO> GetWork(int workId)
        {
            throw new NotImplementedException();
        }
    }
}
