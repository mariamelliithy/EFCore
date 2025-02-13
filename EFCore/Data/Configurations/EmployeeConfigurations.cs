using EFCore.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Data.Configurations
{
    internal class EmployeeConfigurations : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder
                .Property(E => E.EmpName)
                .IsRequired(false)
                .HasDefaultValue("TestEmployee");

            builder
                .Property(E => E.EmpId)
                .UseIdentityColumn(10, 1);
        }
    }
}
