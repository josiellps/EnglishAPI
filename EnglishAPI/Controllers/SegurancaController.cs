using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EnglishAPI.Business;
using EnglishAPI.Business.Implementation;
using EnglishAPI.Models;
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