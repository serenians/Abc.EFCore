using System;

namespace Abc.EFCore.Data.Entity{
    public class StudentEnrollment{
        public int StudentEnrollmentId { get; set; }
        public int AcademicYearId { get; set; }
        public int CollegeId { get; set; }
        public int CourseId { get; set; }
        public int StudentId { get; set; }
        public DateTime EnrolledDate { get; set; }

        public virtual AcademicYear AcademicYear{get;set;}
        public virtual College College { get; set; }
        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
    }
}