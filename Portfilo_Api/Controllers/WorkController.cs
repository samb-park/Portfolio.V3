using System.Threading.Tasks;
using Business.Repository.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace Portfilo_Api.Controllers
{
    [Route("api/[controller]")]
    public class WorkController : Controller
    {
        private readonly IWorkRepository _workRepository;

        public WorkController(IWorkRepository workRepository)
        {
            _workRepository = workRepository;
        }
        
        [HttpGet]
        public async Task<IActionResult> GetWorks()
        {
            var allWorks = await _workRepository.GetAllWorkExperience();
            return Ok(allWorks);
        }

        [HttpGet("{workId}")]
        public async Task<IActionResult> GetWork(int? workId)
        {
            if (workId == null)
            {
                return BadRequest(new ErrorModel()
                {
                    Title = "",
                    ErrorMessage = "Invalid Room Id",
                    StatusCode =  StatusCodes.Status400BadRequest
                });
            }
            var workDetail = await _workRepository.GetWork(workId.Value);

            if (workDetail == null)
            {
                return BadRequest(new ErrorModel()
                {
                    Title = "",
                    ErrorMessage = "Invalid Room Id",
                    StatusCode =  StatusCodes.Status404NotFound
                });
            }

            return Ok(workDetail);
        }
        
    }
}