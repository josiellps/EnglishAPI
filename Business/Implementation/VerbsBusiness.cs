using System.Collections.Generic;
using Business.Business;
using Domain.Models;
using Repository;

namespace Business.Implementation
{
    public class VerbsBusiness : IVerbs
    {
        private readonly IRepository<Verbs> repository;
        public VerbsBusiness(IRepository<Verbs> repositoryAlunos)
        {
            repository = repositoryAlunos;
        }
        public Verbs Create(Verbs verbs)
        {
            return repository.Create(verbs);
        }
        public void Delete(long? id)
        {
            repository.Delete(id);
        }
        public bool Exists(long? id)
        {
            return repository.isExist(id);
        }
        public List<Verbs> FindAll()
        {
            return repository.FindAll();
        }
        public Verbs FindById(long? id)
        {
            throw new System.NotImplementedException();
        }
        public Verbs Update(Verbs verbs)
        {
            throw new System.NotImplementedException();
        }
    }
}