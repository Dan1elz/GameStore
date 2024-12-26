using Microsoft.EntityFrameworkCore;
using GameStore.Domain.Entities.ClientContext;
using GameStore.Domain.Entities.InteractionContext;
using GameStore.Domain.Entities.SaleContext;
using GameStore.Domain.Entities.ProductContext;

namespace GameStore.Infrastructure.Context
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public required DbSet<Token> Token { get; set; }
        public required DbSet<Address> Addresse { get; set; }
        public required DbSet<Client> Client { get; set; }
        public required DbSet<Contact> Contact { get; set; }
        public required DbSet<Cart> Cart { get; set; }
        public required DbSet<Inventory> Inventory { get; set; }
        public required DbSet<Review> Review { get; set; }
        public required DbSet<Favorite> Favorite { get; set; }
        public required DbSet<Payment> Payment { get; set; }
        public required DbSet<Order> Order { get; set; }
        public required DbSet<OrderItem> OrderItem { get; set; }
        public required DbSet<Category> Category { get; set; }
        public required DbSet<Product> Product { get; set; }
        public required DbSet<Company> Company { get; set; }
        public required DbSet<GameImage> GameImage { get; set; }
        public required DbSet<ProductCategory> ProductCategory { get; set; }
        public required DbSet<Promotion> Promotion { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
