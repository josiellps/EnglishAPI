using Business.Business;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace EnglishAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VerbsController: ControllerBase
    {
        private IVerbs _verbs;
        public VerbsController(IVerbs verbs)
        {
            _verbs = verbs;
        }

        [HttpPost]
        public IActionResult Post([FromBody]Verbs verbs)
        {
            return Ok(_verbs.Create(verbs));
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_verbs.FindAll());
        }
    }
}