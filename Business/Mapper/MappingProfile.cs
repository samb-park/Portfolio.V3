using AutoMapper;
using DataAccess.Data;
using Models;

namespace Business.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Work, WorkDTO>().ReverseMap();
            CreateMap<Project, ProjectDTO>().ReverseMap();
            CreateMap<ProjectImageDTO, ProjectImage>().ReverseMap();
            CreateMap<AboutMe, AboutMeDTO>().ReverseMap();

        }
    }
}