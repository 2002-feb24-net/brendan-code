using RestaurantReviews.Library.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantReviews.Library
{
    public class RestaurantContext : DbContext
    {
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Review> Reviews { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBulder)
        {
            optionsBuider.UseSqlite("Data Sources=../../../restaurant.db");
        }
    }
}

  

