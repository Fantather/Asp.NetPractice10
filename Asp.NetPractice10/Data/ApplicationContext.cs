using Asp.NetPractice10.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Asp.NetPractice10.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<User> Users { get; set; }
    }
}
