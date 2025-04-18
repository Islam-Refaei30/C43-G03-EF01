using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.Entities;
using Microsoft.EntityFrameworkCore;

namespace Demo.Context
{
    internal class CompanyDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = .; Database = Company01; Trusted_Connection = true; TrustServerCertificate = True");
        }

        public DbSet<Empolyee> empolyees { get; set; }
    }
}
