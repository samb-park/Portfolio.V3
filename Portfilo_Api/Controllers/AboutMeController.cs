using System.Threading.Tasks;
using Business.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace Portfilo_Api.Controllers
{
    [Route("api/[controller]")]
    public class AboutMeController : Controller
    {
        private readonly IAboutMeRepository _aboutMeRepository;

        public AboutMeController(IAboutMeRepository aboutMeRepository)
        {
            _aboutMeRepository = aboutMeRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAboutMe()
        {
            var aboutMe = await _aboutMeRepository.GetAboutMe();
            return Ok(aboutMe);
        }
    }
}