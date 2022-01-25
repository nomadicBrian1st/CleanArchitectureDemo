using AutoMapper;
using CleanArch.Application.ViewModels;
using CleanArch.Domain.Commands;
using CleanArch.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Application.AutoMapper
{
    class DomainProfileToViewModel: Profile
    {
        public DomainProfileToViewModel()
        {
            CreateMap<Course, CourseViewModel>();
        }
    }
}
