using Microsoft.EntityFrameworkCore;
using CleanArch.Mvc.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Mvc2.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<EZUIModel> EZUIs { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Resolve the pluarl/single table name problem
            modelBuilder.Entity<EZUIModel>().ToTable("EZUI");
        }
    }
}
