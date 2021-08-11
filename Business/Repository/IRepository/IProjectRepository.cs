using System.Collections.Generic;
using System.Threading.Tasks;
using Models;

namespace Business.Repository.IRepository
{
    public interface IProjectRepository
    {
        public Task<ProjectDTO> CreateProject(ProjectDTO projectDTO);
        public Task<ProjectDTO> UpdateProject(int projectId, ProjectDTO projectDTO);
        public Task<ProjectDTO> GetProject(int projectId);
        public Task<IEnumerable<ProjectDTO>> GetAllProjects();
        public Task<ProjectDTO> IsProjectUnique(string title,int projectId = 0);
        public Task<int> DeleteProject(int projectId);
    }
}