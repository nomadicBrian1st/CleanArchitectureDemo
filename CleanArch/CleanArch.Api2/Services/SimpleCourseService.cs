using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArch.Api2.Context;
using CleanArch.Api2.Interfaces;
using CleanArch.Api2.Models;
using Microsoft.AspNetCore.Mvc;

namespace CleanArch.Api2.Services
{
    public class SimpleCourseService: ISimpleCourseService
    {
        private readonly UniversityDBContext _ctx;

        public SimpleCourseService(UniversityDBContext ctx)
        {
            _ctx = ctx;
        }

        public List<Course> GetAllCourses()
        {
            List<Course> courses = null;

            using (_ctx)
            {
                courses = _ctx.Courses.ToList();
            }
            return courses;
        }

        public int CreateCourse(Course course) 
        {
            using (_ctx)
            {
                _ctx.Courses.Add(course);
                var results = _ctx.SaveChanges();
                return results; 
            }
        }
    }
}
