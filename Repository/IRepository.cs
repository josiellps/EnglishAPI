using Domain.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repository
{
    public interface IRepository<T> where T : BaseEntity
    {
        T Criar(T item);
        T ProcurarPorId(long? id);
        List<T> ListarTodos();
        T Alterar(T item);
        void Deletar(long? id);
        bool Existe(long? id);
    }
}
