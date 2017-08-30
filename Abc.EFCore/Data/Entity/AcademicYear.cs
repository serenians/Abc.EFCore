using System.Collections;
using System.Collections.Generic;

namespace Abc.EFCore.Data.Entity
{
    public class AcademicYear
    {
        public int AcademicYearId { get; set; }
        public int Year { get; set; }
        public string YearCode { get; set; }

        public virtual ICollection<StudentEnrollment> StudentEnrollments{get;set;}
    }
}