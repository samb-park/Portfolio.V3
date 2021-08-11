using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WASM.V1.Service.IService
{
    public interface IWorkService
    {
        public Task<IEnumerable<WorkDTO>> GetAllWorks();
        public Task<WorkDTO> GetWork(int workId);
    }
}
