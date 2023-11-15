using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using P01_StudentSystem.Data.Models;

namespace P01_StudentSystem.P01_StudentSystem.Data.Models.Configuration
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.Property(s => s.Name)
                .IsRequired(true)
                  .HasMaxLength(100)
                    .IsUnicode(true);


            builder.Property(s => s.PhoneNumber)
                .HasMaxLength(10)
                  .IsFixedLength(true)
                    .IsUnicode(false)
                      .IsRequired(false);


            builder.Property(s => s.RegisteredOn)
                .IsRequired(true);


            builder.Property(s => s.Birthday)
                .IsRequired(false);


        }
    }
}
