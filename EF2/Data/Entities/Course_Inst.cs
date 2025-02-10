using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF2.Data.Entities
{
    public class Course_Inst
    {
        public int InstructorId { get; set; }
        public int CourseId { get; set; }
        public string? Evaluation { get; set; }
    }
}
