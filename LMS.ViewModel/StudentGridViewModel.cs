using LMS.Model.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.ViewModel
{
    public class StudentGridViewModel:BaseViewModel<Student>
    {
        public StudentGridViewModel(Student student):base(student)
        {
            Name = student.Name;
            Phone = student.Phone;
            Email = student.Email;

        }
        public string Name { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

    }
}
