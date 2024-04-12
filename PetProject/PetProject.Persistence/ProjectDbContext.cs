using Microsoft.EntityFrameworkCore;
using PetProject.Core.Models;

namespace PetProject.Persistence;
public class ProjectDbContext : DbContext
{
    public ProjectDbContext(DbContextOptions<ProjectDbContext> options)
        : base(options)
    {
    }
    public DbSet<Target> Targets { get; set; }
}
