﻿using Microsoft.EntityFrameworkCore;

namespace WebAPI.Models
{
    public class EmployeeDBContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        public EmployeeDBContext(DbContextOptions<EmployeeDBContext> options) : base(options)
        {
        }
    }
}
