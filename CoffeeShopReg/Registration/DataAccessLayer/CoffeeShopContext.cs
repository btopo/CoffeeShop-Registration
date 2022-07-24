using Registration.Models;
using Microsoft.EntityFrameworkCore;

namespace Registration.DAL
{
    public class CoffeeShopContext : DbContext  // DbContext was from Entity Framework Core that allows the interactions from the database
    {
        public DbSet<Products> Products { get; set; }  // add and get data to the products table for CRUD operations on products

        public CoffeeShopContext(DbContextOptions<CoffeeShopContext> options)  // constructor for the class 
        : base(options)
        {

        }

    }

}
