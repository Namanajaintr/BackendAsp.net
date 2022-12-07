using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EmployeeList_EF_DbFirst.Models;

namespace EmployeeList_EF_DbFirst.Models
{
        public class EmployeeContext : DbContext
    {
            public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options) {

            }
            public DbSet<tblSkill> tblSkills { get; set; }
            public DbSet<tblEmployee> tblEmployees { get; set; }
            public DbSet<EmployeeList_EF_DbFirst.Models.EmployeeViewModel> EmployeeViewModel { get; set; }
        }


    }

