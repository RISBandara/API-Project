using Microsoft.EntityFrameworkCore;
using PersonApi.Models.Responses;


namespace PersonApi.Data
{
    public class PersonDbContext : DbContext
    {
        public PersonDbContext(DbContextOptions<PersonDbContext> options) : base(options) { }

        public DbSet<GetPersonDetailsResponse> PersonDetailsResponses { get; set; }
        public DbSet<GetPersonAddressResponse> PersonAddressResponses { get; set; }
        public DbSet<GetProductResponse> PrductDetailsResponse { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GetPersonDetailsResponse>().HasNoKey();
            modelBuilder.Entity<GetPersonAddressResponse>().HasNoKey();
            modelBuilder.Entity<GetProductResponse>().HasNoKey();
        }
    }
}
