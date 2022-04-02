using Microsoft.EntityFrameworkCore;
using Store.Data.POCO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Repo
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly StoreDBContext context;
        private DbSet<T> entities;

        public Repository(StoreDBContext _context)
        {
            context = _context;
            entities = context.Set<T>();
        }

        public void Add(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("Entity");
            }

            entities.Add(entity);
            context.SaveChanges();
        }

        public void Delete(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("Entity");
            }

            entities.Remove(entity);
            context.SaveChanges();
        }

        public void Edit(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("Entity");
            }

            entities.Update(entity);
            context.SaveChanges();
        }

        public T Get(int id)
        {
            var entity = entities.Find(id);
            return entity;
        }

        public IEnumerable<T> GetAll()
        {
            return entities;
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }
    }
}
