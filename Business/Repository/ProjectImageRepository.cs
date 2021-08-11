using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Business.Repository.IRepository;
using DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Models;

namespace Business.Repository
{
    public class ProjectImageRepository : IProjectImageRepository
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;

        public ProjectImageRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<int> CreateProjectImage(ProjectImageDTO imageDTO)
        {
            var image = _mapper.Map<ProjectImageDTO, ProjectImage>(imageDTO);
            await _db.ProjectImages.AddAsync(image);
            return await _db.SaveChangesAsync();
        }

        public async Task<int> DeleteProjectImageByImageId(int imageId)
        {
            var image = await _db.ProjectImages.FindAsync(imageId);
            _db.ProjectImages.Remove(image);
            return await _db.SaveChangesAsync();
        }

        public async Task<int> DeleteProjectImageByProjectId(int projectId)
        {
            var imageList = await _db.ProjectImages.Where(x => x.ProjectId == projectId).ToListAsync();
            _db.ProjectImages.RemoveRange(imageList);
            return await _db.SaveChangesAsync();
        }
        
        public async Task<int> DeletePojectImageByImageUrl(string imageUrl)
        {
            var allImages =
                await _db.ProjectImages.FirstOrDefaultAsync(x => x.ProjectImageUrl.ToLower() == imageUrl.ToLower());
            if (allImages == null)
            {
                return 0;
            }
            _db.ProjectImages.Remove(allImages);
            return await _db.SaveChangesAsync();
        }

        public async Task<IEnumerable<ProjectImageDTO>> GetProjectImages(int projectId)
        {
            var imageList = await _db.ProjectImages.Where(x => x.ProjectId == projectId).ToListAsync();
            return _mapper.Map<IEnumerable<ProjectImage>, IEnumerable<ProjectImageDTO>>(imageList);
        }
    }
}