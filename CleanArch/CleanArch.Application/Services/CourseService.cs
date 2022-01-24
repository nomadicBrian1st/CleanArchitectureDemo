﻿using CleanArch.Application.Interfaces;
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

        //Inject the course repository (IoC) and MediatR handler bus
        public CourseService(
            ICourseRepository courseRepository, 
            IMediatorHandler bus) 
        {
            _courseRepository = courseRepository;
            _bus = bus;
        }     

        public void CreateCourse(CourseViewModel courseViewModel)
        {
            var createCourseCommand = new CreateCourseCommand( 
                courseViewModel.Name,
                courseViewModel.Description,
                courseViewModel.ImageUrl
                );
            _bus.SendCommand(createCourseCommand);
        }

        public CourseViewModel GetCourses()
        {
            return new CourseViewModel()
            {
                Courses = _courseRepository.GetCourse()
            };            
        }
    }
}
