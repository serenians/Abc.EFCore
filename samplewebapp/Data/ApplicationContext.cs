using Microsoft.EntityFrameworkCore;
using samplewebapp.Data.Entity;
using samplewebapp.Data.Configuration;

namespace samplewebapp.Data
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Student> Students{get;set;}
        public DbSet<AcademicYear> AcademicYears{get;set;}
        public DbSet<Course> Courses  { get; set; }
        public DbSet<College> Colleges{get;set;}
        public DbSet<StudentEnrollment> StudentEnrollments{get;set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\sqldev;Database=EfCoreSample;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.AddConfiguration(new StudentConfiguration());
            modelBuilder.AddConfiguration(new AcademicYearConfiguration());
            modelBuilder.AddConfiguration(new CourseConfiguration());
            modelBuilder.AddConfiguration(new CollegeConfiguration());
            modelBuilder.AddConfiguration( new StudentEnrollmentConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }   
}