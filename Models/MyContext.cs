using System;
using Microsoft.EntityFrameworkCore;

namespace ResumePorfolio.Models
{
    public class MyContext : DbContext 
    {
        public MyContext(DbContextOptions options) : base(options) { }
        public DbSet<Project> Projects { get; set; }
    }
}