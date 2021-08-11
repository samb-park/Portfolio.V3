using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repository.IRepository
{
    public interface IAboutMeRepository
    {
        public Task<AboutMeDTO> CreateAboutMe(AboutMeDTO aboutMeDTO);
        public Task<AboutMeDTO> UpdateAboutMe(int aboutMeId, AboutMeDTO aboutMeDTO);
        public Task<AboutMeDTO> GetAboutMe();
        public Task<int> DeleteAboutMe(int aboutMeId);
    }
}
