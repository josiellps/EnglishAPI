using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Business.Business
{
    public interface IAlunos
    {
        Alunos Create(Alunos alunos);
        Alunos FindById(Alunos alunos);
        List<Alunos> FindAll();
        Alunos Update(Alunos alunos);
        bool isExist(Alunos alunos);
    }
}
