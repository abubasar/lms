using LMS.Model;
using LMS.Model.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.ViewModel
{
   public class BaseViewModel
    {
        public BaseViewModel(BaseEntity entity)
        {
                Id = entity.Id;
                Created = entity.Created;
                CreatedBy = entity.CreatedBy;
                Modified = entity.Modified;
                ModifiedBy = entity.ModifiedBy;

        }
        public string Id { get; set; }
        
        public DateTime Created { get; set; }
       
        public string CreatedBy { get; set; }
        
        public DateTime Modified { get; set; }
        
        public string ModifiedBy { get; set; }
    }
}
