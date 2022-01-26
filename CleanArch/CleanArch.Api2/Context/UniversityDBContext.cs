//using CleanArch.Domain.Models;
using CleanArch.Api2.Models;
using Microsoft.EntityFrameworkCore;

namespace CleanArch.Api2.Context
{
    public class UniversityDBContext : DbContext
    {
        public UniversityDBContext(DbContextOptions<UniversityDBContext> options)
            : base(options)
        {
        }
        public DbSet<Course> Courses { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Resolve the pluarl/single table name problem
            modelBuilder.Entity<Course>().ToTable("Course");
        }
    }
}
