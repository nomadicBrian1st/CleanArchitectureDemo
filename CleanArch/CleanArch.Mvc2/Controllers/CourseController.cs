using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArch.Mvc.Controllers
{
    public class CourseController : Controller
    {
        private readonly ICourseService _courseService;
        public CourseController(ICourseService courseService) 
        {
            _courseService = courseService;
        }
        public IActionResult Index()
        {
            //IEnumerable<CourseViewModel> model = _courseService.GetCourses();            
            return View(_courseService.GetCourses().ToList());            
        }       
    }
}
