using backend.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;
namespace backend.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
         
    }
    public DbSet<User> Users { get; set; }
        public DbSet<Student> student {  get; set; }



    }
}
