using System;
using System.Collections.Generic;
using System.Net.Mime;
using System.Threading.Tasks;
using AutoMapper;
using Business.Repository.IRepository;
using DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Models;

namespace Business.Repository
{
    public class WorkRepository : IWorkRepository
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;
        public WorkRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<WorkDTO> CreateWork(WorkDTO workDTO)
        {
            Work work = _mapper.Map<WorkDTO, Work>(workDTO);
            var addedWork = await _db.Works.AddAsync(work);
            await _db.SaveChangesAsync();

            return _mapper.Map<Work, WorkDTO>(addedWork.Entity);
        }

        public async Task<WorkDTO> UpdateWork(int roomId, WorkDTO workDTO)
        {
            try
            {
                if (roomId == workDTO.Id)
                {
                    Work workDetail = await _db.Works.FindAsync(roomId);
                    Work work = _mapper.Map<WorkDTO, Work>(workDTO,workDetail);
                    var updatedWork = _db.Works.Update(work);
                    await _db.SaveChangesAsync();
                    
                    return _mapper.Map<Work, WorkDTO>(updatedWork.Entity);
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

        public async Task<WorkDTO> GetWork(int workId)
        {
            try
            {
                WorkDTO work = _mapper.Map<Work,WorkDTO>(
                    await _db.Works.FirstOrDefaultAsync(x => x.Id == workId));

                return work;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public async Task<IEnumerable<WorkDTO>> GetAllWorkExperience()
        {
            try
            {
                IEnumerable<WorkDTO> workDTOs = 
                    _mapper.Map<IEnumerable<Work>,IEnumerable<WorkDTO>>(_db.Works);
                
                return workDTOs;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public async Task<WorkDTO> IsWorkUnique(string title,int workId = 0)
        {
            try
            {
                WorkDTO work = null;
                if (workId == 0)
                {
                    work = _mapper.Map<Work, WorkDTO>(
                        await _db.Works.FirstOrDefaultAsync(x=>x.Title.ToLower() == title.ToLower()));
                }
                else
                {
                    work = _mapper.Map<Work, WorkDTO>(
                        await _db.Works.FirstOrDefaultAsync(x=>x.Title.ToLower() == title.ToLower()
                        && x.Id != workId));
                }

                return work;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public async Task<int> DeleteWork(int workId)
        {
            var workDetail = await _db.Works.FindAsync(workId);
            if (workDetail != null)
            {
                _db.Works.Remove(workDetail);
                return await _db.SaveChangesAsync();
            }

            return 0;
        }
    }
}