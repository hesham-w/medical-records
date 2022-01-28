using Api.Customers.Domain;
using Microsoft.EntityFrameworkCore;

namespace Api.Customers
{
    internal class CustomersDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    => optionsBuilder.UseCosmos(
        "AccountEndpoint=https://medical-records.documents.azure.com:443/;AccountKey=mNp9biv0ZbcQ0Qt0YpLjdim4AIQ2kXhyd121OcB4aKXyBexLzCknPopnbq5m1k7LFs0EU3DmYbYngqWIEKIaXA==;",
        databaseName: "customers-db");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region DefaultContainer
            modelBuilder.HasDefaultContainer("Store");
            #endregion

            #region Container
            modelBuilder.Entity<Customer>()
                .ToContainer("Customers");
            #endregion

            #region NoDiscriminator
            modelBuilder.Entity<Customer>()
                .HasNoDiscriminator();
            #endregion

            #region PartitionKey
            modelBuilder.Entity<Customer>()
                .HasPartitionKey(o => o.Id);
            #endregion

            #region ETag
            modelBuilder.Entity<Customer>()
                .UseETagConcurrency();
            #endregion

        }
    }
}
