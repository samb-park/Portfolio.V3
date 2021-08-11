using System.Collections.Generic;
using System.Threading.Tasks;
using Models;

namespace Business.Repository.IRepository
{
    public interface IWorkRepository
    {
        public Task<WorkDTO> CreateWork(WorkDTO workDTO);
        public Task<WorkDTO> UpdateWork(int roomId, WorkDTO workDTO);
        public Task<WorkDTO> GetWork(int workId);
        public Task<IEnumerable<WorkDTO>> GetAllWorkExperience();
        public Task<WorkDTO> IsWorkUnique(string title,int workId = 0);
        public Task<int> DeleteWork(int workId);
    }
}