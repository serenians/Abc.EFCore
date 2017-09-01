
using Microsoft.EntityFrameworkCore;
using AFull.Data.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AFull.Data.Configuration
{
    public class StudentEnrollmentConfiguration : EntityTypeConfiguration<StudentEnrollment>
    {
        public override void Map(EntityTypeBuilder<StudentEnrollment> builder)
        {
            builder.ToTable("StudentEnrollment");
            builder.HasKey(o=>o.StudentEnrollmentId);

            builder.Property(o=>o.AcademicYearId).IsRequired();
            builder.Property(o=>o.CollegeId).IsRequired();
            builder.Property(o=>o.CourseId).IsRequired();
            builder.Property(o=>o.StudentId).IsRequired();
            builder.Property(o=>o.EnrolledDate).IsRequired();

            builder.HasOne(o=>o.AcademicYear).WithMany(o=>o.StudentEnrollments)
            .HasForeignKey(o=>o.AcademicYearId)
            .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(o=> o.College).WithMany().HasForeignKey(o=>o.CollegeId)
            .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(o=>o.Course).WithMany().HasForeignKey(o=>o.CourseId)
            .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(o=>o.Student).WithMany().HasForeignKey(o=>o.StudentId)
            .OnDelete(DeleteBehavior.Restrict);

        }
    }
}