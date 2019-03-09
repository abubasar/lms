using LMS.Model.Courses;
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
       
        [Index]
        [Required]
        [MaxLength(50)]
        public string Email { get; set; }
        [Index]
        [Required]
        [MaxLength(20)]
        public string Phone { get; set; }
        [Required]
        [MaxLength(100)]
        public string Address { get; set; }

        [Required]
        [MaxLength(100)]
        public string Designation { get; set; }
        [MaxLength(500)]
        public string Details { get; set; }

        public int StudentsCount { get; set; }
        [Required]
        public int CoursesCount { get; set; }
        
        public int ReviewsCount { get; set; }
        public virtual ICollection<Course> Courses { get; set; }


    }
}
