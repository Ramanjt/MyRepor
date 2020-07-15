using MyRepor.Core.Models;
using System.Linq;

namespace MyRepor.DataAccess.InMemory
{
    public interface IInMemoryRepository<T> where T : BaseEntity
    {
        IQueryable<T> Collection();
        void Commit();
        void Delete(string Id);
        T Find(string Id);
        void Insert(T t);
        void Update(T t);
    }
}