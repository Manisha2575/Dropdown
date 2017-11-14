using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Dropdown2.Models
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext() : base("DefaultConnection")
        {

        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<State> StateList { get; set; }
        public DbSet<City> CityList { get; set; }
    }
}