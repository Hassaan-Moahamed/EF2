using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF2.Data.Entities;

namespace EF2.Data.Configrations
{
    internal class StudCourseConfig : IEntityTypeConfiguration<Stud_Course>
    {
        public void Configure(EntityTypeBuilder<Stud_Course> builder)
        {
            builder.HasKey(Sc => new { Sc.StudentId, Sc.CourseId });
        }
    }
}
