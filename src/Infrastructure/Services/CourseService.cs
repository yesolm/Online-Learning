using Microsoft.EntityFrameworkCore;
using OL.Core.Contracts.Services;
using OL.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OL.Infrastructure.Services
{
    public class CourseService : ICourseService
    {
        public readonly ApplicationDbContext _context;
        public CourseService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Course?> GetById(int id)
        {
            return await _context.Courses.Where(x => x.Id == id).FirstOrDefaultAsync();
        }
        public async Task<IEnumerable<Course>> GetAll()
        {
            return await _context.Courses.ToListAsync();
        }
        public Course Add(Course course)
        {
            _context.Courses.Add(course);
            return course;
        }        
    }
}
