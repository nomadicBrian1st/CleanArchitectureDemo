using AutoMapper;
using AutoMapper.QueryableExtensions;
using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModels;
using CleanArch.Domain.Commands;
using CleanArch.Domain.Core.Bus;
using CleanArch.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Application.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courseRepository;
        private readonly IMediatorHandler _bus;
        private readonly IMapper _autoMapper;

        //Inject (IoC) the course repo, MediatR handler bus, auto mapper
        public CourseService(
            ICourseRepository courseRepository, 
            IMediatorHandler bus,
            IMapper automapper) 
        {
            _courseRepository = courseRepository;
            _bus = bus;
            _autoMapper = automapper;
        }     

        public void CreateCourse(CourseViewModel courseViewModel)
        {
            //automapper replaces item by item DTO

            //var createCourseCommand = new CreateCourseCommand( 
            //    courseViewModel.Name,
            //    courseViewModel.Description,
            //    courseViewModel.ImageUrl
            //    );
            _bus.SendCommand(_autoMapper.Map<CreateCourseCommand>(courseViewModel));
        }

        public IEnumerable<CourseViewModel> GetCourses()
        {
            //Replace return with Automapper project feature
            //return new CourseViewModel()
            //{               
            //Courses = _courseRepository.GetCourse()
            //};

            return _courseRepository.GetCourses()
                .ProjectTo<CourseViewModel>(_autoMapper.ConfigurationProvider); 
        }
    }
}
