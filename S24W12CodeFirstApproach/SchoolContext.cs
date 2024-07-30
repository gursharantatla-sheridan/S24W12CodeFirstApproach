using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S24W12CodeFirstApproach
{
    // context class
    public class SchoolContext : DbContext
    {
        // entity sets - required
        // DbSet<> properties
        public DbSet<Student> Students { get; set; }
        public DbSet<Standard> Standards { get; set; }


        // define the connection string - required
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(LocalDB)\MSSQLLocalDB; 
                                          Database=SchoolCF; 
                                          Trusted_Connection=True;
                                          MultipleActiveResultSets=true;");
        }



        // data seed - optional

    }
}
