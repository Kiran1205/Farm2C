using Microsoft.EntityFrameworkCore;

namespace Farm2CApi.Entities.Mapping
{
    public class Farm2CEntities : DbContext
    {
        public Farm2CEntities(DbContextOptions<Farm2CEntities> options)
        : base(options)
        {
        }

        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<ItemPrice> ItemPrices { get; set; }
        public virtual DbSet<ItemCategory> ItemCategorys { get; set; }
        public virtual DbSet<Units> Units { get; set; }
        public virtual DbSet<Quantity> Quantity { get; set; }

        public virtual DbSet<UserInfo> UserInfo { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Code to seed data
        }
    }
}
