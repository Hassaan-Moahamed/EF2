using EF2.Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF2.Data.Configrations
{
    public class CourseConfig : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasOne(C => C.Topic)
              .WithMany(C => C.Courses)
              .HasForeignKey(C => C.TopicId)
              .IsRequired(false)
              .OnDelete(DeleteBehavior.Cascade);
        }
    }
    
}
