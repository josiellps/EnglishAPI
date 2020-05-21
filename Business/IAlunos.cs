﻿using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Business.Business
{
    public interface IAlunos
    {
        Alunos Create(Alunos alunos);
        Alunos ProdurarId(Alunos alunos);
        List<Alunos>ListarTodos(Alunos alunos);
        Alunos Alterar(Alunos alunos);
        bool Existe(Alunos alunos);
    }
}
