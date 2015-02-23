using System.Linq;

namespace DAL
{
    public abstract class AbstractBase<T> : IBase<T> where T:class
    {
        private SalesDBEntities entities = new SalesDBEntities();

        public void Add(T paramEntity)
        {
            entities.AddObject(paramEntity.GetType().Name, paramEntity);
        }

        public void SaveChanges()
        {
            entities.SaveChanges();
        }

        public IQueryable<T> GetAll()
        {
            return entities.CreateObjectSet<T>();
        }
    }
}
