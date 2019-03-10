using LMS.Model.Courses;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Model
{
   public class Content:BaseEntity
    {
        [Required]
        public int Serial { get; set; }

        [Index]
        [MaxLength(128)]
        public string CourseId { get; set; }

        [ForeignKey("CourseId")]
        public virtual Course Course { get; set; }

        [Index]
        [Required]
        [MaxLength(250)]
        public string Title { get; set; }

        [Required]
        [MaxLength(500)]
        public string Description { get; set; }

        [Required]
        [MaxLength(250)]
        public string Url { get; set; }

        [Required]
        public int TotalSeconds { get; set; }

        [Required]
        [MaxLength(250)]
        public string Tags { get; set; }

        [Required]
        public string Category { get; set; }
    }
}
