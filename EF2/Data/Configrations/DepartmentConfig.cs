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
    internal class DepartmentConfig : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {

            builder.HasMany(D => D.Instructors)
                .WithOne(I => I.WorkDepartment)
                .HasForeignKey(I => I.DepartmentId)
                .IsRequired(false);
        }
    }
}
