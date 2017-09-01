using Microsoft.EntityFrameworkCore;
using AFull.Data.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AFull.Data.Configuration
{
    public class StudentConfiguration : EntityTypeConfiguration<Student>
    {

        public override void Map(EntityTypeBuilder<Student> builder)
        {
            builder.ToTable("Student");

            builder.HasKey(o=>o.StudentId);
            builder.Property(o=>o.FirstName).IsRequired().HasMaxLength(255);
            builder.Property(o=>o.LastName).IsRequired().HasMaxLength(255);
            builder.Property(o=>o.RegistrationNo).IsRequired().HasMaxLength(100);
            builder.Property(o=>o.Address1).IsRequired(false).HasMaxLength(255);
        }
    }
}
