using Microsoft.EntityFrameworkCore;
using RepoMVCusingSP.Models;

namespace RepoMVCusingSP.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Emp> emp2 { get; set; }
    }
}
