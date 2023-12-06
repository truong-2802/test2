using System;
using Microsoft.EntityFrameworkCore;
namespace test2.Entities
{
    public class Datacontext : DbContext
    {
        public Datacontext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Department_Tbl> Department_Tbls { get; set; }
        public DbSet<Employee_Tbl> Employee_Tbls { get; set; }
       
    }
}
