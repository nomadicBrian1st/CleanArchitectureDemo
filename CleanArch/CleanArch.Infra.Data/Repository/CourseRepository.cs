using CleanArch.Domain.Interfaces;
using CleanArch.Domain.Models;
using CleanArch.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Infra.Data.Repository
{
    public class CourseRepository : ICourseRepository
    {
        private readonly UniversityDBContext _ctx;

        //Inject the UniversityDBContext 
        public CourseRepository(UniversityDBContext ctx) 
        {
            _ctx = ctx;
        }

        //Implement DB context options using Domain layer models 
        public IQueryable<Course> GetCourses()
        {
            return _ctx.Courses;            
        }

        public void AddCourse(Course course) 
        {
            _ctx.Courses.Add(course);
            _ctx.SaveChanges();
        }
    }
}
