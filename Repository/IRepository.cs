﻿using Domain.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repository
{
    public interface IRepository<T> where T : BaseEntity
    {
        T Create(T item);
        T FindById(long? id);
        List<T> FindAll();
        T Update(T item);
        void Delete(long? id);
        bool isExist(long? id);
    }
}
