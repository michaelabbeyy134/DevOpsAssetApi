using Microsoft.EntityFrameworkCore;
using DevOpsAssetApi.Models;

namespace DevOpsAssetApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(
            DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Asset> Assets { get; set; }
    }
}