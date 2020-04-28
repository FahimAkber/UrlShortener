using Microsoft.EntityFrameworkCore;

namespace UShortener.Models
{
    public class DbUrlContext : DbContext
    {
        public DbSet<UrlData> convertedUrls{get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=url.db");
    }
}