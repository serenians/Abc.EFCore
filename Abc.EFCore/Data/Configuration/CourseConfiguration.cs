
using Microsoft.EntityFrameworkCore;
using Abc.EFCore.Data.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Abc.EFCore.Data.Configuration
{
    public class CourseConfiguration : EntityTypeConfiguration<Course>
    {
        public override void Map(EntityTypeBuilder<Course> builder)
        {
            builder.ToTable("Course");

            builder.HasKey(o=>o.CourseId);

            builder.Property(o=>o.CourseId).IsRequired();
            builder.Property(o=>o.CourseName).HasMaxLength(1024).IsRequired();
            builder.Property(o=>o.CourseCode).HasMaxLength(50).IsRequired();

        }
    }
}