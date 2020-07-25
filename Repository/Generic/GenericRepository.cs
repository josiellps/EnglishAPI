using Data.Context;
using Domain.Models.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repository.Generic
{
    public class GenericRepository<T> : IRepository<T> where T : BaseEntity
    {
        private MySQLContext _context;
        private DbSet<T> dataset;
        public GenericRepository()
        {

        }

        public GenericRepository(MySQLContext context)
        {
            _context = context;
            dataset = _context.Set<T>();
        }

        public T Update(T item)
        {
            try
            {
                if (!isExist(item.Id)) return null;

                var result = dataset.SingleOrDefault(p => p.Id.Equals(item.Id));
                if (result != null)
                {
                    _context.Entry(result).CurrentValues.SetValues(item);
                    _context.SaveChanges();
                    return item;
                }
                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public T Create(T item)
        {
            try
            {
                dataset.Add(item);
                _context.SaveChanges();
                return item;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(long? id)
        {
            try
            {
                var temp = dataset.SingleOrDefault(item => item.Id==id);
                if (temp != null)
                {
                    dataset.Remove(temp);
                    _context.SaveChanges();
                }             
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool isExist(long? id)
        {
            try
            {
                return dataset.SingleOrDefault(p => p.Id == id)?.Id>0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<T> FindAll()
        {
            try
            {
                return dataset.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public T FindById(long? id)
        {
            return dataset.SingleOrDefault(p => p.Id == id);
        }
    }
}
