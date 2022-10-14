using lecturesapi.Models.Domain;
using lecturesapi.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace lecturesapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LanguagesController : Controller
    {
        private readonly ILanguageRepository languageRepository;

        public LanguagesController(ILanguageRepository languageRepository)
        {
            this.languageRepository = languageRepository;
        }


        [HttpGet]
        public IActionResult GetAllLagnuages()
        {
            // return a static list for  testing 


            var languages = languageRepository.GetAll();

            return Ok(languages);


        }
    }
}
