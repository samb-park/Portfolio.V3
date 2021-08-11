using System.Threading.Tasks;
using Business.Repository.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace Portfilo_Api.Controllers
{
    [Route("api/[controller]")]
    public class ProjectController : Controller
    {
        private readonly IProjectRepository _projectRepository;

        public ProjectController(IProjectRepository projectRepository)
        {
            _projectRepository = projectRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetProjects()
        {
            var allProject = await _projectRepository.GetAllProjects();
            return Ok(allProject);
        }

        [HttpGet("{projectId}")]
        public async Task<IActionResult> GetProject(int? projectId)
        {
            if (projectId == null)
            {
                return BadRequest(new ErrorModel()
                {
                    Title = "",
                    ErrorMessage = "Invalid Room Id",
                    StatusCode =  StatusCodes.Status400BadRequest
                });
            }
            var projectDetail = await _projectRepository.GetProject(projectId.Value);

            if (projectDetail == null)
            {
                return BadRequest(new ErrorModel()
                {
                    Title = "",
                    ErrorMessage = "Invalid Room Id",
                    StatusCode =  StatusCodes.Status404NotFound
                });
            }

            return Ok(projectDetail);
        }
    }
}