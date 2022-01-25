using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArch.Api2.Models;

namespace CleanArch.Api2.Interfaces
{
    public interface ISimpleCourseService
    {
        public List<Course> GetAllCourses();
        public int CreateCourse(Course course);
    }
}
