using Microsoft.EntityFrameworkCore;

namespace WebAPIProject.Data
{
    public class HotelListingDbContext :DbContext
    {
        public HotelListingDbContext(DbContextOptions options) :base(options) 
        { 

        }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasData(
                new Country
                {
                    Id=1,
                    Name= "India",
                    ShortName = "IN"
                },
                 new Country
                 {
                     Id = 2,
                     Name = "China",
                     ShortName = "CN"
                 }
                );
            modelBuilder.Entity<Hotel>().HasData(
                new Hotel { 
                   Id=1,
                   Name ="Apolo Dimoro",
                   Address ="Kerala",
                   CountryId = 1,
                   Rating = 5.0
                
                },
                 new Hotel
                 {
                     Id = 2,
                     Name = "Chinpin",
                     Address = "beijing",
                     CountryId = 2,
                     Rating = 1.0

                 }
                );
        }

    }
}
