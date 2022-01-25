//using CleanArch.Application.Interfaces;
using CleanArch.Api2.Models;
using CleanArch.Api2.Context;
using CleanArch.Api2.Interfaces;
using CleanArch.Api2.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArch.Api2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        // Inject the course service (IoC)

        // Implement with Infra IoC/Data with CQRS and Bus 
        //private readonly ICourseService _courseService;
        //public CourseController(ICourseService courseService)
        // {
        //    _courseService = courseService;
        //}

        private readonly ISimpleCourseService _courseService;
        public CourseController(ISimpleCourseService courseService)
        {
            _courseService = courseService;
        }       

        //Http Entry Point Methods

        [HttpGet]
        public List<Course> GetAllCourses()
        {
            List<Course> courses = _courseService.GetAllCourses();
         
            return courses;
        }

        [HttpPost]
        public IActionResult CreateCourse([FromBody] Course course) 
        {
            _courseService.CreateCourse(course);
            return Ok(course);
        }
    
    }
}
