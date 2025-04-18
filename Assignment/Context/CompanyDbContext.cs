using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment.Models;
using Microsoft.EntityFrameworkCore;

namespace Assignment.Context
{
    internal class CompanyDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = .; Database = Company02; Trusted_Connection = true; TrustServerCertificate = True");
        }

        public DbSet<Student> students { get; set; }
        public DbSet<Topic> topics { get; set; }
        public DbSet<StudCourse> studCourses { get; set; }
        public DbSet<Instructor> instructors { get; set; }
        public DbSet<Department> departments { get; set; }
        public DbSet<CourseInst> courseInsts { get; set; }
        public DbSet<Course> courses { get; set; }



    }
}
