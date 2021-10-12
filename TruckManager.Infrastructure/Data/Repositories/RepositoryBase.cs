using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using TruckManager.Domain.Core.Interfaces.Repositories;

namespace TruckManager.Infrastructure.Data.Repositories
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        private readonly SqlContext sqlcontex;

        public RepositoryBase(SqlContext sqlcontex)
        {
            this.sqlcontex = sqlcontex;
        }
        public void Add(TEntity obj)
        {
            try
            {
                sqlcontex.Set<TEntity>().Add(obj);
                sqlcontex.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<TEntity> GetAll()
        {
            return sqlcontex.Set<TEntity>().ToList();
        }

        public TEntity GetById(Guid id)
        {
            return sqlcontex.Set<TEntity>().Find(id);
        }

        public void Remove(TEntity obj)
        {
            try
            {
                sqlcontex.Set<TEntity>().Remove(obj);
                sqlcontex.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(TEntity obj)
        {
            try
            {
                sqlcontex.Entry(obj).State = EntityState.Modified;
                sqlcontex.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
