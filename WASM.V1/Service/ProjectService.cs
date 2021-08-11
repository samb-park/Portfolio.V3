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
    public class ProjectService : IProjectService
    {
        private readonly HttpClient _client;

        public ProjectService(HttpClient client)
        {
            _client = client;
        }

        public async Task<IEnumerable<ProjectDTO>> GetAllProjects()
        {
            var response = await _client.GetAsync($"api/project");
            var content = await response.Content.ReadAsStringAsync();
            var projects = JsonConvert.DeserializeObject<IEnumerable<ProjectDTO>>(content);
            return projects;
        }

        public Task<ProjectDTO> GetProject(int projectId)
        {
            throw new NotImplementedException();
        }
    }
}
