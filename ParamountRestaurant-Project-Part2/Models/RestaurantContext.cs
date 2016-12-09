namespace ParamountRestaurant_Project_Part2.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class RestaurantContext : DbContext
    {
        public RestaurantContext()
            : base("name=RestaurantConnection")
        {
        }

        public virtual DbSet<FoodItem> FoodItems { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FoodItem>()
                .Property(e => e.Price)
                .HasPrecision(10, 2);
        }
    }
}
