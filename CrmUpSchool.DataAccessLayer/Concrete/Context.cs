using System;
using CrmUpSchool.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CrmUpSchool.DataAccessLayer.Concrete
{
    public class Context : IdentityDbContext<AppUser, AppRole, int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost,1433;Initial Catalog=CrmUpSchool;Integrated Security=SSPI;");
        }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<EmployeeTask> EmployeeTasks { get; set; }

        public DbSet<EmployeeTaskDetail> EmployeeTaskDetails { get; set; }

        public DbSet<Message> Messages { get; set; }

    }
}
