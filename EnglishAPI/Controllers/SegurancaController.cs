using Business.Business;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace EnglishAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SegurancaController : ControllerBase
    {
        private IAlunos _alunos;
        public SegurancaController(IAlunos alunos)
        {
            _alunos = alunos;
        }

        [HttpPost]
        public IActionResult Post([FromBody]Alunos alunos)
        {
            return Ok(_alunos.Create(alunos));
        }
    }
}