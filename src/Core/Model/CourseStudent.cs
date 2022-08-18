using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OL.Core.Model
{
    public class CourseStudent
    {
        public int CourseId { get; set; }
        public virtual Course Course { get; set; }  
        public int StudentId { get; set;}
        public virtual ApplicationUser Student { get; set; }
        public DateTime EnrollmentDate { get; set; }
    }
}
