using System.Linq.Expressions;

namespace TS.Core.Persistence
{
    public interface IRepository<T> where T : class
    {
        T GetById(int id);
        IEnumerable<T> GetAll();
        IEnumerable<T> Find(Expression<Func<T, bool>> predicate);
        void Add(T t);
        void AddRange(IEnumerable<T> t);
        void RemoveRange(IEnumerable<T> t);
        void Remove(T t);
    }
}