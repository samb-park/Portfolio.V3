using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Business.Repository.IRepository;
using DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Models;

namespace Business.Repository
{
    public class ProjectRepository : IProjectRepository
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;

        public ProjectRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<ProjectDTO> CreateProject(ProjectDTO projectDTO)
        {
            Project project = _mapper.Map<ProjectDTO, Project>(projectDTO);
            var addedProject = await _db.Projects.AddAsync(project);
            await _db.SaveChangesAsync();

            return _mapper.Map<Project, ProjectDTO>(addedProject.Entity);
        }

        public async Task<ProjectDTO> UpdateProject(int projectId, ProjectDTO projectDTO)
        {
            try
            {
                if (projectId == projectDTO.Id)
                {
                    Project projectDetail = await _db.Projects.FindAsync(projectId);
                    Project project = _mapper.Map<ProjectDTO, Project>(projectDTO, projectDetail);
                    var updatedProject = _db.Projects.Update(project);
                    await _db.SaveChangesAsync();

                    return _mapper.Map<Project, ProjectDTO>(updatedProject.Entity);
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

        public async Task<ProjectDTO> GetProject(int projectId)
        {
            try
            {
                ProjectDTO project = _mapper.Map<Project, ProjectDTO>(
                    await _db.Projects.Include(x => x.ProjectImages).FirstOrDefaultAsync(x => x.Id == projectId));

                return project;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public async Task<IEnumerable<ProjectDTO>> GetAllProjects()
        {
            try
            {
                IEnumerable<ProjectDTO> projectDTOs =
                    _mapper.Map<IEnumerable<Project>, IEnumerable<ProjectDTO>>(
                        _db.Projects.Include(x => x.ProjectImages));

                return projectDTOs;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public async Task<ProjectDTO> IsProjectUnique(string title, int projectId = 0)
        {
            try
            {
                ProjectDTO project = null;
                if (projectId == 0)
                {
                    project = _mapper.Map<Project, ProjectDTO>(
                        await _db.Projects.FirstOrDefaultAsync(x => x.Title.ToLower() == title.ToLower()));
                }
                else
                {
                    project = _mapper.Map<Project, ProjectDTO>(
                        await _db.Projects.FirstOrDefaultAsync(x => x.Title.ToLower() == title.ToLower()
                                                                    && x.Id != projectId));
                }

                return project;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public async Task<int> DeleteProject(int projectId)
        {
            var projectDetail = await _db.Projects.FindAsync(projectId);
            if (projectDetail != null)
            {
                _db.Projects.Remove(projectDetail);
                return await _db.SaveChangesAsync();
            }

            return 0;
        }
    }
}