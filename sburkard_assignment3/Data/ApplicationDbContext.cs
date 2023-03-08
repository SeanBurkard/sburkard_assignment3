using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using sburkard_assignment3.Models;

namespace sburkard_assignment3.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<sburkard_assignment3.Models.Movie> Movie { get; set; }
        public DbSet<sburkard_assignment3.Models.Actor> Actor { get; set; }
        public DbSet<sburkard_assignment3.Models.MovieActor> MovieActor { get; set; }
    }
}