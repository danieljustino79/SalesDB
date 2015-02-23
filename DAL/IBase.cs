using System.Linq;

namespace DAL
{
    public interface IBase<T>
    {
        void Add(T paramEntity);
        void SaveChanges();

        IQueryable<T> GetAll();
    }
}
