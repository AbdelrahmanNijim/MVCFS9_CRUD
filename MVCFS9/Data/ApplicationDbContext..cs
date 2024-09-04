using Microsoft.EntityFrameworkCore;
using MVCFS9.Models;
using System.Configuration;

namespace MVCFS9.Data
{
    public class ApplicationDbContext : DbContext
    {
       
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        
        public DbSet<Student> Students { get; set; }

        public DbSet<User> Users { get; set; }
    }
}
