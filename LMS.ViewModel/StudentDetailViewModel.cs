using LMS.Model.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.ViewModel
{
    public class StudentDetailViewModel:BaseViewModel
    {
        public StudentDetailViewModel(Student student):base(student)
        {
            Name = student.Name;
            Address = student.Address;
            Phone = student.Phone;
        }
        public string Name { get; set; }
        
        public string Address { get; set; }
       
        public string Phone { get; set; }
    }
}
