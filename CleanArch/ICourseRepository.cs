using System;
using System.Collections.Generic;
using CleanArch.Domain.M


namespace CleanArch.Domain.Interfaces
{
    public interface ICourseRepository
    {
        IEnumerable<Course> GetCourse();
    }
}