using Microsoft.EntityFrameworkCore;
using LifEx.Infrastructure.Data.Models;
using Path = LifEx.Infrastructure.Data.Models.Path;

namespace LifEx.Infrastructure.DbContexts
{
    public class LifExDbContext : DbContext
    {
        public DbSet<Path> Paths { get; set; }
        public DbSet<Area> Areas { get; set; }
        public DbSet<Module> Modules { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<DifficultyLevel> DifficultyLevels { get; set; }

        public LifExDbContext(DbContextOptions<LifExDbContext> options) : base(options) 
        {

        }
    }
}