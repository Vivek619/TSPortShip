using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using TS.Core.Persistence;

namespace TS.Persistence.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly DbContext Context;

        public Repository(DbContext context)
        {
            this.Context = context;
        }

        public void Add(T t)
        {
            Context.Set<T>().Add(t);
        }

        public void AddRange(IEnumerable<T> t)
        {
            Context.Set<T>().AddRange(t);
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
        {
            return Context.Set<T>().Where(predicate);
        }

        public IEnumerable<T> GetAll()
        {
            return Context.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return Context.Set<T>().Find(id);
        }

        public void Remove(T t)
        {
            Context.Set<T>().Remove(t);
        }

        public void RemoveRange(IEnumerable<T> t)
        {
            Context.Set<T>().RemoveRange(t);
        }
    }
}
