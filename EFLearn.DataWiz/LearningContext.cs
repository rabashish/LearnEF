using EFLearn.Basics.Models;
using Microsoft.EntityFrameworkCore;

namespace EFLearn.DataWiz
{
    public class LearningContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FighterPlane>().Property(b => b.Name).IsRequired();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("server:(localdb)\\\\mssqllocaldb; database:Test_Prac ;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
        public DbSet<FighterPlane> FighterPlanes { get; set; }
    }
}
