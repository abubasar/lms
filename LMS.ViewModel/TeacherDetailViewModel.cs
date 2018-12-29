using LMS.Model.Teachers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.ViewModel
{
    public class TeacherDetailViewModel:BaseViewModel
    {
        public TeacherDetailViewModel(Teacher teacher):base(teacher)
        {
            Name = teacher.Name;
        }
        public string Name { get; set; }
    }
}
 