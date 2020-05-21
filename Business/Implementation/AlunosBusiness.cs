using Business.Business;
using Domain.Models;
using Repository;
using System;
using System.Collections.Generic;

namespace Business.Implementation
{
    public class AlunosBusiness : IAlunos
    {
        private readonly IRepository<Alunos> repository;
        public AlunosBusiness(IRepository<Alunos> repositoryAlunos)
        {
            repository = repositoryAlunos;
        }
        public Alunos Alterar(Alunos alunos)
        {
            return repository.Criar(alunos);            
        }

        public Alunos Create(Alunos alunos)
        {
            return repository.Criar(alunos);
        }

        public bool Existe(Alunos alunos)
        {
            throw new NotImplementedException();
        }

        public List<Alunos> ListarTodos(Alunos alunos)
        {
            throw new NotImplementedException();
        }

        public Alunos ProdurarId(Alunos alunos)
        {
            throw new NotImplementedException();
        }
    }
}
