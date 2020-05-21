using Domain.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Alunos : BaseEntity
    {        
        public string Nome { get; set; }
        public string DataNascimento { get; set; }
        public string Senha { get; set; }
      //  public string RepeteSenha { get; set; }
        public string Email { get; set; }

    }
}
