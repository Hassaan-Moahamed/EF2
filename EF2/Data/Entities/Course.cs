using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF2.Data.Entities
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Duration { get; set; }
        public string? Description { get; set; }
        //Take relationship
        public ICollection<Stud_Course> CourseStudents { get; set; } = new HashSet<Stud_Course>();
        //Classify relationship
        [ForeignKey(nameof(Topic))]
        public int? TopicId { get; set; }
        public Topic Topic { get; set; }
        //Teach relationship
        public ICollection<Course_Inst> CoursesInstructors { get; set; } = new HashSet<Course_Inst>();


    }
}
