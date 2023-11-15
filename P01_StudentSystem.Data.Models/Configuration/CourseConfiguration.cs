using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace P01_StudentSystem.P01_StudentSystem.Data.Models.Configuration
{
    public class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.Property(c => c.Name)
                .IsRequired(true)
                  .HasMaxLength(80)
                    .IsUnicode(true);


            builder.Property(c => c.Description)
                .IsRequired(false)
                  .IsUnicode(true);


            builder.Property(c => c.StartDate)
                .IsRequired(true);


            builder.Property(c => c.EndDate)
                .IsRequired(true);


            builder.Property(c => c.Price)
                .IsRequired(true);


        }
    }
}
