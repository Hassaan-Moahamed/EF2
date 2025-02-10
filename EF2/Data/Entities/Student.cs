using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF2.Data.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string? Address { get; set; }
        public int? Age { get; set; }
        
        public ICollection<Stud_Course> StudentCourses = new HashSet<Stud_Course>();
       
        public int? DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}
