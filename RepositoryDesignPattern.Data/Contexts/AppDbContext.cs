using Microsoft.EntityFrameworkCore;
using RepositoryDesignPattern.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryDesignPattern.Data.Contexts
{
   public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> contextOptions) : base (contextOptions) 
        {
            
        }

        public DbSet<Employee> Employees { get; set; }

    }
}
