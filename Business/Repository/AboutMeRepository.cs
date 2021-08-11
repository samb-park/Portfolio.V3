using AutoMapper;
using Business.Repository.IRepository;
using DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repository
{
    public class AboutMeRepository : IAboutMeRepository
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;

        public AboutMeRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }


        public async Task<AboutMeDTO> CreateAboutMe(AboutMeDTO aboutMeDTO)
        {
            AboutMe aboutMe = _mapper.Map<AboutMeDTO, AboutMe>(aboutMeDTO);
            var addedAboutMe = await _db.AboutMes.AddAsync(aboutMe);
            await _db.SaveChangesAsync();

            return _mapper.Map<AboutMe, AboutMeDTO>(addedAboutMe.Entity);
        }

        public async Task<int> DeleteAboutMe(int aboutMeId)
        {
            var aboutMe = await _db.AboutMes.FindAsync(aboutMeId);

            if(aboutMe != null)
            {
                _db.AboutMes.Remove(aboutMe);
                return await _db.SaveChangesAsync();
            }
            return 0;
        }

        public async Task<AboutMeDTO> GetAboutMe()
        {
            try
            {
                var aboutMeDTO = _mapper.Map<AboutMe,AboutMeDTO>(await _db.AboutMes.FirstOrDefaultAsync());

                return aboutMeDTO;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<AboutMeDTO> UpdateAboutMe(int aboutMeId, AboutMeDTO aboutMeDTO)
        {
            try
            {
                if (aboutMeId == aboutMeDTO.Id)
                {
                    AboutMe aboutMeDetail = await _db.AboutMes.FindAsync(aboutMeId);
                    AboutMe aboutMe = _mapper.Map<AboutMeDTO, AboutMe>(aboutMeDTO, aboutMeDetail);
                    var updatedAboutMe = _db.AboutMes.Update(aboutMe);
                    await _db.SaveChangesAsync();

                    return _mapper.Map<AboutMe, AboutMeDTO>(updatedAboutMe.Entity);
                }
                else
                {
                    return null;
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
