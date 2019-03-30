using School_Project.Context;
using School_Project.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace School_Project.Repositories
{
    public class RepositoryBase<TEntity> : IDisposable, IRepository<TEntity> where TEntity : class
    {
        protected readonly SchoolDBContext _schoolDBContext;

        public RepositoryBase(SchoolDBContext schoolDBContext)
        {
            _schoolDBContext = schoolDBContext;
        }

        public void Dispose()
        {
            _schoolDBContext.Dispose();
        }

        public List<TEntity> GetAll()
        {
            return _schoolDBContext.Set<TEntity>().ToList();
        }

        public TEntity GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Insert(TEntity obj)
        {
            _schoolDBContext.Entry(obj).State = EntityState.Added;
            _schoolDBContext.Set<TEntity>().Add(obj);
            Save();
        }

        public void RemoveById(Guid id)
        {
            var obj = GetById(id);

            _schoolDBContext.Entry(obj).State = EntityState.Deleted;
            Save();
        }

        public void Save()
        {
            _schoolDBContext.SaveChanges();
        }

        public void Update(TEntity obj, Guid id)
        {
            _schoolDBContext.Entry(obj).State = EntityState.Modified;
        }
    }
}