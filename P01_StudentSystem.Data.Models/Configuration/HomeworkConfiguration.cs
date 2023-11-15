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
    public class HomeworkConfiguration : IEntityTypeConfiguration<Homework>
    {
        public void Configure(EntityTypeBuilder<Homework> builder)
        {
            builder.Property(h => h.Content).IsRequired(true)
                .IsUnicode(false)
                  .IsRequired(true);

            builder.Property(h => h.SubmissionTime)
                .IsRequired(true);

            builder.Property(h => h.StudentId)
                .IsRequired(true);

            builder.Property(h => h.CourseId)
                .IsRequired(true);

            builder.HasOne(h => h.Course)
                .WithMany(c => c.Homeworks)
                  .HasForeignKey(h => h.CourseId);

            builder.HasOne(h => h.Student)
                .WithMany(s => s.Homeworks)
                  .HasForeignKey(h => h.StudentId);

        }
    }
}
