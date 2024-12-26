using Diary_App.Models;
using Microsoft.EntityFrameworkCore;

namespace Diary_App.Data
{
    public class CLSDbContext:DbContext
    {
        public CLSDbContext(DbContextOptions<CLSDbContext> options) : base(options) 
        {
            
        }
        public DbSet<DiaryEntry> DiaryEntries { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DiaryEntry>().HasData(
                new DiaryEntry
                {
                    Id = 1,
                    Title="Went Hiing",
                    Content="Went hiking",
                    Created= DateTime.Now,

                },
                new DiaryEntry
                {
                    Id=2,
                    Title="Went shoping",
                    Content= "Went shoping with Jon!",
                    Created= DateTime.Now,
                }
                
                );
        }
    }
}
