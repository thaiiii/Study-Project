using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityFrameworkDemo.Models
{
    public class Enrollment
    {
        public int EnrollmentId { get; set; }
        public int Grade { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public virtual Student Student { get; set; }
        public Course Course { get; set; }
    }
}