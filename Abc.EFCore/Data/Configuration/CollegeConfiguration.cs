using Microsoft.EntityFrameworkCore;
using Abc.EFCore.Data.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Abc.EFCore.Data.Configuration
{
    public class CollegeConfiguration : EntityTypeConfiguration<College>
    {
        public override void Map(EntityTypeBuilder<College> builder)
        {
            builder.ToTable("College");
            builder.HasKey(o=>o.CollegeId);
            builder.Property(o=>o.CollegeId).IsRequired();
            builder.Property(o=>o.CollegeCode).HasMaxLength(50).IsRequired();
            builder.Property(o=>o.CollegName).HasMaxLength(1024).IsRequired();
            builder.Property(o=>o.Address).HasMaxLength(1024).IsRequired(false);
        }
    }
}