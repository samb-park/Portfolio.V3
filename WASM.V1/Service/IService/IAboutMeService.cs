using System.Threading.Tasks;
using Models;

namespace WASM.V1.Service.IService
{
    public interface IAboutMeService
    {
        public Task<AboutMeDTO> GetAboutMe();
    }
}