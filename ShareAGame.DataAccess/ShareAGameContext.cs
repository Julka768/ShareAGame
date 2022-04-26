using Microsoft.EntityFrameworkCore;
using ShareAGame.DataAccess.Configurations;
using ShareAGame.DataAccess.Models;

namespace ShareAGame.DataAccess
{
  public class ShareAGameContext : DbContext
  {
    public ShareAGameContext(DbContextOptions options): base(options) 
    {
    }

    public DbSet<Game> Games { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.ApplyConfiguration(new GameConfiguration());
    }
  }
}
