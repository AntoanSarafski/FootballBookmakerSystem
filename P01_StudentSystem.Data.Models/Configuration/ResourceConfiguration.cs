﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace P01_StudentSystem.P01_StudentSystem.Data.Models.Configuration
{
    public class ResourceConfiguration : IEntityTypeConfiguration<Resource>
    {
        public void Configure(EntityTypeBuilder<Resource> builder)
        {
            builder.Property(r => r.Name)
                   .IsRequired(true)
                     .HasMaxLength(50)
                       .IsUnicode(true);

            
            builder.Property(r => r.Url)
                     .IsUnicode(false)
                       .IsRequired(true);

            builder.Property(r => r.ResourceType)
                .IsRequired(true);

            builder.HasOne(r => r.Course)
                .WithMany(c => c.Resources)
                .HasForeignKey(r => r.CourseId);

        }
    }
}
