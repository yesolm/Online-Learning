using OL.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OL.Core.Contracts.Services
{
    public interface ICourseService
    {
        Task<Course> GetById(int id);
        Task<IEnumerable<Course>> GetAll();
        Course Add(Course course);

    }
}
