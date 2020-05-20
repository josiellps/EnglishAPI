using EnglishAPI.Models;
using EnglishAPI.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnglishAPI.Business.Implementation
{
    public class AlunosBusiness : IAlunos
    {
        private IRepository<Alunos> repository;
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
