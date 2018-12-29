using LMS.Model;
using System.Data.Entity;
using System.Linq;

namespace LMS.Repository
{
    public class BaseRepository<T> where T:BaseEntity
    {
        protected DataContext context;
        public BaseRepository()
        {
            this.context = new DataContext();
        }

        public bool Add(T entity)
        {
            DbSet<T> dbSet = this.context.Set<T>();//context konta chinai dilo ex. Students,Teachers
            dbSet.Add(entity);
           int i= context.SaveChanges();//how many rows will be effected

            return i > 0;
        }


        public IQueryable<T> Get()
        {
            //return this.context.Set<T>().AsQueryable();
            DbSet<T> dbSet = this.context.Set<T>();
            return dbSet.AsQueryable();
        }

        public T  GetDetail(string id)
        {
            return this.context.Set<T>().Find(id);
           
        }

        public bool Edit(T entity)
        {
            context.Entry(entity).State = EntityState.Modified;
            int i = context.SaveChanges();//how many rows will be effected
            return i > 0;
        }

        public bool Delete(string id)
        {
            var entity = GetDetail(id);
            if (entity != null)
            {
                context.Set<T>().Remove(entity);
                int i = context.SaveChanges();//how many rows will be effected
                return i > 0;
            }
            return true;
        }
    }
}
