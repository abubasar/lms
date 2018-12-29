using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Model.Teachers
{
   public class Teacher:BaseEntity
    {
        [Index]
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

    }
}
