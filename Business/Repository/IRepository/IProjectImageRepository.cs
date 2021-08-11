using System.Collections.Generic;
using System.Threading.Tasks;
using Models;

namespace Business.Repository.IRepository
{
    public interface IProjectImageRepository
    {
        public Task<int> CreateProjectImage(ProjectImageDTO imageDTO);
        public Task<int> DeleteProjectImageByImageId(int imageId);
        public Task<int> DeleteProjectImageByProjectId(int projectId);
        public Task<int> DeletePojectImageByImageUrl(string imageUrl);
        public Task<IEnumerable<ProjectImageDTO>> GetProjectImages(int projectId);
    }
}