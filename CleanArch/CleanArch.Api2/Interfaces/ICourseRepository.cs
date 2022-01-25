using System.Collections.Generic;
using CleanArch.Api2.Models;

namespace CleanArch.Api2.Interfaces
{
    public interface ICourseRepository
    {
        public List<Course> GetAllCourses();
        //void AddCourse(Course course);
    }
}