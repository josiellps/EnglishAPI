using System.Collections.Generic;
using Domain.Models;

namespace Business.Business
{
    public interface IVerbs
    {
        Verbs Create(Verbs verbs);
        Verbs FindById(long? id);
        List<Verbs> FindAll();
        Verbs Update(Verbs verbs);
        void Delete(long? id);
        bool Exists(long? id);
    }
}