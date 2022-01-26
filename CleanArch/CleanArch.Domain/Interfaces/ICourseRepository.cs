using System.Collections.Generic;
using System.Linq;
using CleanArch.Domain.Models;

namespace CleanArch.Domain.Interfaces
{
    public interface ICourseRepository
    {
        IQueryable<Course> GetCourses();
        void AddCourse(Course course);
    }
}