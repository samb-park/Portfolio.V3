using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WASM.V1.Service.IService
{
    public interface IProjectService
    {
        public Task<IEnumerable<ProjectDTO>> GetAllProjects();
        public Task<ProjectDTO> GetProject(int projectId);
    }
}
