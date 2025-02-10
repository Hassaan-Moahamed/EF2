using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF2.Data.Entities
{
    public class Instructor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public decimal Bonus { get; set; }
        public string? Address { get; set; }
        public decimal HourRate { get; set; }
       
        public ICollection<Course_Inst> InstructorCourses { get; set; } = new HashSet<Course_Inst>();
        //Manage relationship
        [InverseProperty(nameof(Department.Manger))]
        public Department ManageDepartment { get; set; }
      
        [InverseProperty(nameof(Department.Instructors))]
        public Department WorkDepartment { get; set; }
        public int? DepartmentId { get; set; }
    }
}
