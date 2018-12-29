
using LMS.Model.Students;
using LMS.Model.Teachers;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Model
{
   public class DataContext:DbContext
    {
        public DataContext() : base("DefaultBusinessConnection") {
            //Database.SetInitializer<DataContext>(null);
        }

        public DbSet<Student> Students { get; set; }

        public DbSet<Teacher> Teachers { get; set; }

       
    }
}
