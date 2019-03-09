using LMS.Model.Students;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Model
{
   public class StudentContent:BaseEntity
    {
        [Index]
        [MaxLength(128)]
        public string StudentId { get; set; }

        [ForeignKey("StudentId")]
        public virtual Student Student { get; set; }

        [Index]
        [MaxLength(128)]
        public string ContentId { get; set; }

        [ForeignKey("ContentId")]
        public virtual Content Content { get; set; }

        public int? WatchedSeconds { get; set; }

    }
}
