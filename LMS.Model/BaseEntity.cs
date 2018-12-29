using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Model
{
   public class BaseEntity
    {
        public string Id { get; set; }
        [Index]
        [Required]
        
        public DateTime Created { get; set; }
        [Index]
        [Required]
        [MaxLength(50)]
        public string CreatedBy { get; set; }
        [Index]
        [Required]
        public DateTime Modified { get; set; }
        [Index]
        [Required]
        [MaxLength(50)]
        public string ModifiedBy { get; set; }

    }
}
