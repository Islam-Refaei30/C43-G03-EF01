using Demo.Context;
using Microsoft.EntityFrameworkCore;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CompanyDbContext dbcontext = new CompanyDbContext();

            dbcontext.empolyees.Where(E => E.ID == 1);

            //dbcontext.Database.EnsureDeleted();
            //dbcontext.Database.EnsureCreated();  // old way

            // Migratio  
            //dbcontext.Database.Migrate();



        }
    }
}
