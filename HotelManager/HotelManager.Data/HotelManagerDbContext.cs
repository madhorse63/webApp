using HotelManager.Data.Entites.Room;
using Microsoft.EntityFrameworkCore;

namespace HotelManager.Data
{
    public class HotelManagerDbContext : DbContext
    {
        public HotelManagerDbContext(DbContextOptions<HotelManagerDbContext> options) : base(options)
        {

        }

        public DbSet<Room> Rooms { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("DefaultConnection");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Room>(entity =>
            {
                entity.Property(e => e.Price).HasPrecision(18, 2);
            });
        }
    }
}
