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
        public Alunos Create(Alunos alunos)
        {
            return repository.Create(alunos);
        }
        public Alunos FindById(Alunos alunos)
        {
            throw new NotImplementedException();
        }
        public bool isExist(Alunos alunos)
        {
            throw new NotImplementedException();
        }
        public Alunos Update(Alunos alunos)
        {
            return repository.Update(alunos);
        }
        public List<Alunos> FindAll()
        {
            return repository.FindAll();
        }
    }
}
