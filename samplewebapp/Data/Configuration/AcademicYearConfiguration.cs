using Microsoft.EntityFrameworkCore;
using samplewebapp.Data.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace samplewebapp.Data.Configuration
{
    public class AcademicYearConfiguration : EntityTypeConfiguration<AcademicYear>
    {
        public override void Map(EntityTypeBuilder<AcademicYear> builder)
        {
            builder.ToTable("AcademicYear");
            builder.HasKey(o=>o.AcademicYearId);
            builder.Property(o=>o.AcademicYearId).IsRequired();
            builder.Property(o=>o.Year).IsRequired();
            builder.Property(o=>o.YearCode).HasMaxLength(20).IsRequired();

        }
    }
}