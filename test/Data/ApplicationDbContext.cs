using Test.Models;
using Microsoft.EntityFrameworkCore;

namespace Test.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) : base (options)
        {
        }
        public DbSet<LopHoc> LopHocs {get; set;}
    }
    
}