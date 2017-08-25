using Microsoft.EntityFrameworkCore;
using Abc.EFCore.Data.Entity;
using Abc.EFCore.Data.Configuration;
using Abc.EFCore.Data;

namespace Abc.EFCore.Data
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Student> Students{get;set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\sqldev;Database=EfCoreSample;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.AddConfiguration(new StudentConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }   
}