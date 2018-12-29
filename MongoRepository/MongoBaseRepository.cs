using LMS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoRepository
{
   public class MongoBaseRepository<T> where T:BaseEntity
    {
        public IQueryable<T> Get()
        {
            List<T> models = new List<T>();
            return models.AsQueryable();
        }
    }
}
