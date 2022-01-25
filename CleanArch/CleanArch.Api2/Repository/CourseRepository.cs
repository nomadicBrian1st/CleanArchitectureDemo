using CleanArch.Api2.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArch.Api2.Interfaces;
using CleanArch.Api2.Models;

namespace CleanArch.Api2.Repository
{
    public class CourseRepository : ICourseRepository
    {
        private UniversityDBContext _ctx;

        //Inject the UniversityDBContext 
        public CourseRepository(UniversityDBContext ctx) 
        {
            _ctx = ctx;
        }

        //Implement DB context options using Domain layer models 
        public List<Course> GetAllCourses()
        {
            return _ctx.Courses.ToList();            
        }
        
        //public void AddCourse(Course course) 
        //{
        //    _ctx.Courses.Add(course);
        //    _ctx.SaveChanges();
        //}
    }
}
