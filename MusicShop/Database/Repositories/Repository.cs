using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace MusicShop.Database.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly DbSet<T> DbSet;

        public Repository(DbContext context) { DbSet = context.Set<T>(); }

        public void Insert(T entity) => DbSet.Add(entity);

        public void Delete(T entity) => DbSet.Remove(entity);

        public IQueryable<T> SearchFor(Expression<Func<T, bool>> predicate) => DbSet.Where(predicate);

        public IQueryable<T> GetAll() => DbSet.AsQueryable();

        public T GetById(int id) => DbSet.Find(id);
    }
}
