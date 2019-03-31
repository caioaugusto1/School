using System;
using System.Collections.Generic;

namespace School_Project.Repositories.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class
    {
        List<TEntity> GetAll();
        
        TEntity GetById(Guid id);

        void Insert(TEntity obj);

        void Update(TEntity obj, Guid id);

        void RemoveById(Guid id);

        void Save();
    }
}
