using EFCore.Data.Configurations;
using EFCore.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Data.Context
{
    internal class MyCompanyDbContext : DbContext
    {

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region overload 1
            //modelBuilder.Entity<Employee>(E =>
            //    {
            //        E.Property(E => E.EmpName)
            //        .HasDefaultValue("TestEmployee");

            //        E.Property(E => E.EmpId)
            //        .UseIdentityColumn(10, 1);
            //    }); 
            #endregion
            modelBuilder.ApplyConfiguration(new EmployeeConfigurations());
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=MyCompany;Trusted_Connection=True;TrustServerCertificate=True");
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
