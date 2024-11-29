using Microsoft.EntityFrameworkCore;

namespace Apisemana12.Models
{
    public class InvoiceContext : DbContext
    {
        public DbSet<Product> Products {get; set; }
        public DbSet<Detail> Details { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Customer> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAB1507-04\\SQLEXPRESS03; Database=MVCDemoEFCDB; Integrated Security=True;Trust Server Certificate=True ");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Customer>().HasQueryFilter(x => x.Enabled);
        }
    }
}

