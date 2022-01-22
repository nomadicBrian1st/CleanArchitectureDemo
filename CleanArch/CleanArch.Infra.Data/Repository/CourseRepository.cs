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
        private UniversityDBContext _ctx;

        //Inject the UniversityDBContext 
        public CourseRepository(UniversityDBContext ctx) 
        {
            _ctx = ctx;
        }
        public IEnumerable<Course> GetCourse()
        {
            return _ctx.Courses;            
        }
    }
}
