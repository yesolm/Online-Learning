using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OL.Core.Model
{
    public class Course
    {
        public int Id { get; set; } 
        public string? InstructorId { get; set; }
        public virtual ApplicationUser Instructor { get; set; }
        public string Name { get; set; } = string.Empty;    
        public string? Discription { get;set; }
        public string? ImageGuid { get; set; }
    }
}
