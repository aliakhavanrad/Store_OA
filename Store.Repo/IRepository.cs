using Store.Data.POCO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Repo
{
    public interface IRepository<T> where T : BaseEntity
    {
        IEnumerable<T> GetAll();
        T Get(int id);
        void Add(T entity);
        void Delete(T entity);
        void Edit(T entity);
        void SaveChanges();

    }
}
